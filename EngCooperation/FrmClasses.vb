Public Class FrmClasses
    Dim YearClass As String = Year(Now)
    Dim HidCol As String = ""
    Private Sub FrmClasses_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        MainFrm.ToolStripButton4.Checked = False
    End Sub

    Private Sub FrmClasses_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ClassesDataSet.AcceptChanges()
        'TODO: This line of code loads data into the 'ClassesDataSet.Classes' table. You can move, or remove it, as needed.
        Me.ClassesTableAdapter.Fill(Me.ClassesDataSet.Classes)
        Dim y As String = "y" + YearClass
        ClassesDataGridView.Columns(y).Visible = True
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim ch As String = InputBox("أدخل كلمة المرور لتأكيد هوية المستخدم", "تأكيد الصلاحية")
        If ch = UsersInfo.UserPW And UsersInfo.IsAdmin Then
            If MsgBox("هل أنت متأكد من حفظ جميع التعديلات على سجلات الأصناف", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Me.Validate()
                Me.ClassesBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.ClassesDataSet)
                Me.ClassesDataSet.AcceptChanges()
            End If
        Else
            MsgBox("لا تملك صلاحية التعديل في سجلات الأصناف")
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        ClassesBindingSource.CancelEdit()
        MainFrm.FlowLayoutPanel4.Visible = False
        Me.Close()
    End Sub

    Private Sub ClassesDataGridView_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles ClassesDataGridView.DataError
        e.Cancel = True
    End Sub

    Private Sub ClassesDataGridView_UserAddedRow(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowEventArgs) Handles ClassesDataGridView.UserAddedRow
        ClassesDataGridView.Item("DataGridViewTextBoxColumn6", ClassesDataGridView.CurrentRow.Index).Value = Now
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Dim t As Boolean = False
        If IsNumeric(ToolStripComboBox1.Text) Then
            Dim d As String = ToolStripComboBox1.Text
            For Each s As String In ToolStripComboBox1.Items
                If s = d Then
                    t = True
                    Exit For
                End If
            Next
            If Not t Then
                MsgBox("العام المدخل غير صالح")
                Exit Sub
            End If

            HidCol = ClassesDataGridView.Columns("y" & YearClass).Name
            ClassesDataGridView.Columns(HidCol).Visible = False
            YearClass = ToolStripComboBox1.Text
            Dim y As String = "y" + YearClass
            ClassesDataGridView.Columns(y).Visible = True
        Else
            MsgBox("يجب إختيار العام من القائمة")
        End If
    End Sub

    Private Sub ToolStripComboBox1_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ToolStripComboBox1.KeyUp
        If e.KeyCode.Equals(Keys.Enter) Then
            ToolStripButton1.PerformClick()
        End If

    End Sub
End Class