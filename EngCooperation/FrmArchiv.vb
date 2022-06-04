Public Class FrmArchiv

    Private Sub AcountingBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AcountingBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.AcountingBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.AcountingDataSet)

    End Sub

    Private Sub FrmArchiv_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AcountingDataSet.EngCV' table. You can move, or remove it, as needed.
        On Error Resume Next
        Me.EngCVTableAdapter.Fill(Me.AcountingDataSet.EngCV)
        'TODO: This line of code loads data into the 'AcountingDataSet.Acounting' table. You can move, or remove it, as needed.
        Me.AcountingTableAdapter.Fill(Me.AcountingDataSet.Acounting)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.AcountingTableAdapter.Fill(Me.AcountingDataSet.Acounting)
        If RadioButton1.Checked Then
            Select Case ComboBox1.Text
                Case "مقبوض"
                    Select Case ComboBox2.Text
                        Case "رقم الوصل"
                            If IsNumeric(TextBox1.Text) Then
                                Me.AcountingBindingSource.Filter = "AcountID=" & TextBox1.Text & " and AcountStatus='Cached' And RestAcountStat=false"
                            Else
                                MsgBox("توقع البرنامج قيمة رقمية")
                                TextBox1.SelectAll()
                            End If
                        Case "المهندس"
                            Dim pos As Integer = Me.EngCVBindingSource.Find("FullName", TextBox1.Text)
                            Me.EngCVBindingSource.Position = pos
                            Dim Dr As DataRowView = Me.EngCVBindingSource.Current
                            Me.AcountingBindingSource.Filter = "EngID=" & Dr.Item("EngID") & " and AcountStatus='Cached' And RestAcountStat=false "
                        Case "الكل"
                            Me.AcountingBindingSource.Filter = " AcountStatus='Cached' And RestAcountStat=false "
                    End Select
                Case "قيد التقسيط"
                    Select Case ComboBox2.Text
                        Case "رقم الوصل"
                            If IsNumeric(TextBox1.Text) Then
                                Me.AcountingBindingSource.Filter = "AcountID=" & TextBox1.Text & " and AcountStatus='Cached' And RestAcountStat=true"
                            Else
                                MsgBox("توقع البرنامج قيمة رقمية")
                                TextBox1.SelectAll()
                            End If
                        Case "المهندس"
                            Dim pos As Integer = Me.EngCVBindingSource.Find("FullName", TextBox1.Text)
                            Me.EngCVBindingSource.Position = pos
                            Dim Dr As DataRowView = Me.EngCVBindingSource.Current
                            Me.AcountingBindingSource.Filter = "EngID=" & Dr.Item("EngID") & " and AcountStatus='Cached' And RestAcountStat=true "
                        Case "الكل"
                            Me.AcountingBindingSource.Filter = " AcountStatus='Cached' And RestAcountStat=true "
                    End Select
                Case "الكل"
                    Select Case ComboBox2.Text
                        Case "رقم الوصل"
                            If IsNumeric(TextBox1.Text) Then
                                Me.AcountingBindingSource.Filter = "AcountID=" & TextBox1.Text & "  and AcountStatus='Cached'"
                            Else
                                MsgBox("توقع البرنامج قيمة رقمية")
                                TextBox1.SelectAll()
                            End If
                        Case "المهندس"
                            Dim pos As Integer = Me.EngCVBindingSource.Find("FullName", TextBox1.Text)
                            Me.EngCVBindingSource.Position = pos
                            Dim Dr As DataRowView = Me.EngCVBindingSource.Current
                            Me.AcountingBindingSource.Filter = "EngID=" & Dr.Item("EngID") & " and AcountStatus='Cached'"
                        Case "الكل"
                            Me.AcountingBindingSource.Filter = " AcountStatus='Cached'"
                    End Select
            End Select
        ElseIf RadioButton2.Checked Then
            Select Case ComboBox1.Text
                Case "مقبوض"
                    Select Case ComboBox2.Text
                        Case "رقم الوصل"
                            If IsNumeric(TextBox1.Text) Then
                                Me.AcountingBindingSource.Filter = "AcountID=" & TextBox1.Text & " and AcountStatus='InWait' And RestAcountStat=false"
                            Else
                                MsgBox("توقع البرنامج قيمة رقمية")
                                TextBox1.SelectAll()
                            End If
                        Case "المهندس"
                            Dim pos As Integer = Me.EngCVBindingSource.Find("FullName", TextBox1.Text)
                            Me.EngCVBindingSource.Position = pos
                            Dim Dr As DataRowView = Me.EngCVBindingSource.Current
                            Me.AcountingBindingSource.Filter = "EngID=" & Dr.Item("EngID") & " and AcountStatus='InWait' And RestAcountStat=false "
                        Case "الكل"
                            Me.AcountingBindingSource.Filter = " AcountStatus='InWait' And RestAcountStat=false "
                    End Select
                Case "قيد التقسيط"
                    Select Case ComboBox2.Text
                        Case "رقم الوصل"
                            If IsNumeric(TextBox1.Text) Then
                                Me.AcountingBindingSource.Filter = "AcountID=" & TextBox1.Text & " and AcountStatus='InWait' And RestAcountStat=true"
                            Else
                                MsgBox("توقع البرنامج قيمة رقمية")
                                TextBox1.SelectAll()
                            End If
                        Case "المهندس"
                            Dim pos As Integer = Me.EngCVBindingSource.Find("FullName", TextBox1.Text)
                            Me.EngCVBindingSource.Position = pos
                            Dim Dr As DataRowView = Me.EngCVBindingSource.Current
                            Me.AcountingBindingSource.Filter = "EngID=" & Dr.Item("EngID") & " and AcountStatus='Cached' And RestAcountStat=true "
                        Case "الكل"
                            Me.AcountingBindingSource.Filter = " AcountStatus='InWait' And RestAcountStat=true "
                    End Select
                Case "الكل"
                    Select Case ComboBox2.Text
                        Case "رقم الوصل"
                            If IsNumeric(TextBox1.Text) Then
                                Me.AcountingBindingSource.Filter = "AcountID=" & TextBox1.Text & "  and AcountStatus='InWait'"
                            Else
                                MsgBox("توقع البرنامج قيمة رقمية")
                                TextBox1.SelectAll()
                            End If
                        Case "المهندس"
                            Dim pos As Integer = Me.EngCVBindingSource.Find("FullName", TextBox1.Text)
                            Me.EngCVBindingSource.Position = pos
                            Dim Dr As DataRowView = Me.EngCVBindingSource.Current
                            Me.AcountingBindingSource.Filter = "EngID=" & Dr.Item("EngID") & " and AcountStatus='InWait'"
                        Case "الكل"
                            Me.AcountingBindingSource.Filter = " AcountStatus='InWait'"
                    End Select
            End Select
        ElseIf RadioButton3.Checked Then
            Me.AcountingTableAdapter.FillByCancel(Me.AcountingDataSet.Acounting)
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub AcountingDataGridView_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles AcountingDataGridView.CellDoubleClick
        Aid = AcountingDataGridView.CurrentRow.Cells(0).Value
        Me.Close()
        Dim f As New FrmAcount
        f.MdiParent = FrmMain
        f.Dock = DockStyle.Fill
        f.Show()
    End Sub
End Class