Public Class EngCase
    Dim MaxDatePay As New BatchesDataSetTableAdapters.QueriesTableAdapter
    Dim MyBatch As New BatchesDataSetTableAdapters.EngRestTableTableAdapter
    Dim EngID As Integer = -1
    Dim LastDate As Date
    Dim EngName As String, AID As Integer
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        BatchsBindingSource.CancelEdit()
        Me.Close()
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        EngID = IIf(IsNumeric(TextBox1.Text), TextBox1.Text, -1)
        EngName = TextBox1.Text
        BatchsBindingSource.CancelEdit()
        If IsDate(MaxDatePay.QryMaxDateByIDorName(EngID, EngName)) Then
            LastDate = MaxDatePay.QryMaxDateByIDorName(EngID, EngName).Value
        Else
            Label2.Text = ""
            TxtAcountID.Text = ""
            TxtAcountDate.Text = ""
            TxtPayed.Text = ""
            TxtRest.Text = ""
            TxtTotal.Text = ""
            BatchsBindingSource.Filter = "EngID=" & EngID & ""
            Button2.Enabled = False
            Exit Sub
        End If
        If Now.Year = LastDate.Year Then
            If LastDate.Month < MyAppSet.MaxAllow + 1 Then
                Label2.Text = "جميع رسوم الإشتراك مسددة لغاية تاريخة"
                Label2.BackColor = Color.WhiteSmoke
            Else
                Label2.Text = "جميع رسوم الإشتراك مسددة لغاية تاريخة مع غرامة التأخير "
                Label2.BackColor = Color.Yellow
            End If
        ElseIf (Now.Year - LastDate.Year) = 1 And (Now.Month < MyAppSet.MaxAllow + 1) Then
            Label2.Text = " رسوم اشتراك المهندس مستحقة آخر رسم مدفوع عام" & ":" & LastDate.Year
            Label2.BackColor = Color.Red
        Else
            Label2.Text = " المهندس متأخر عن دفع رسم الإشتراك آخر رسم مدفوع عام" & ":" & LastDate.Year
            Label2.BackColor = Color.Red
        End If

        If MyBatch.GetData(EngID).Count > 0 Then
            TxtAcountID.Text = MyBatch.GetData(EngID).Item(0).AcountID
            TxtAcountDate.Text = MyBatch.GetData(EngID).Item(0).AcountDate
            TxtPayed.Text = MyBatch.GetData(EngID).Item(0).TotalPayed
            TxtRest.Text = MyBatch.GetData(EngID).Item(0).TotalRest
            TxtTotal.Text = MyBatch.GetData(EngID).Item(0).Total
        Else
            TxtAcountID.Text = ""
            TxtAcountDate.Text = ""
            TxtPayed.Text = ""
            TxtRest.Text = ""
            TxtTotal.Text = ""
        End If
        BatchsBindingSource.RemoveFilter()
        BatchsBindingSource.Filter = "EngID=" & EngID & ""

        If TxtRest.Text = "" Then
            Button2.Enabled = False
            BatchsDataGridView.AllowUserToAddRows = False
            BatchsDataGridView.ReadOnly = True
        Else
            Button2.Enabled = True

        End If
    End Sub

    Private Sub EngCase_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BatchesDataSet.Batchs' table. You can move, or remove it, as needed.
        Me.BatchsTableAdapter.Fill(Me.BatchesDataSet.Batchs)
        BatchsBindingSource.Filter = "EngID=" & EngID & ""
        BatchsDataGridView.MultiSelect = False

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim MyRow As DataRowView
        BatchsDataGridView.ReadOnly = False
        BatchsDataGridView.Enabled = True
        BatchsBindingSource.AddNew()
        MyRow = BatchsBindingSource.Current
        With MyRow
            .Item(0) = TxtAcountID.Text
            .Item(1) = TextBox1.Text
            .Item(2) = Now.Date
            .Item(4) = False
        End With
        BatchsDataGridView.Item(3, BatchsDataGridView.CurrentRow.Index).Selected = True

    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        Me.Validate()
        Me.BatchsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(BatchesDataSet)

        BatchsDataGridView.Refresh()

        If MyBatch.GetData(EngID).Count > 0 Then
            TxtAcountID.Text = MyBatch.GetData(EngID).Item(0).AcountID
            TxtAcountDate.Text = MyBatch.GetData(EngID).Item(0).AcountDate
            TxtPayed.Text = MyBatch.GetData(EngID).Item(0).TotalPayed
            TxtRest.Text = MyBatch.GetData(EngID).Item(0).TotalRest
            TxtTotal.Text = MyBatch.GetData(EngID).Item(0).Total
        End If

    End Sub

    Private Sub EngCase_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        TextBox1.Focus()
        On Error Resume Next
        TextBox1.Text = EngAcount.EngCaeID

    End Sub

    Private Sub BatchsDataGridView_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles BatchsDataGridView.CellEndEdit
        If e.ColumnIndex = 3 Then
            If BatchsDataGridView.CurrentCell.Value.ToString > TxtRest.Text Then
                BatchsDataGridView.CurrentCell.Value = TxtRest.Text
                MsgBox("القيمة المدخلة أكبر من المبلغ الباقي", vbOKOnly + vbInformation, "تنبية")
            End If
        End If
    End Sub
End Class