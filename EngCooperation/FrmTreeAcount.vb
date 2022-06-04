Imports Microsoft.Reporting.WinForms

Public Class FrmTreeAcount
    Dim Myfilter As String
    Dim Mydt1, Mydt2 As Date

    Private Sub FrmTreeAcount_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        FrmMain.Button5.ForeColor = Color.Blue
    End Sub

    Private Sub FrmTreeAcount_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BatchesDataSet.Batchs' table. You can move, or remove it, as needed.
        Me.BatchsTableAdapter.Fill(Me.BatchesDataSet.Batchs)
        'TODO: This line of code loads data into the 'BatchesDataSet.Batchs' table. You can move, or remove it, as needed.
        Me.BatchsTableAdapter.Fill(Me.BatchesDataSet.Batchs)
        'TODO: This line of code loads data into the 'AcountingDataSet.InBoxDetailAcount' table. You can move, or remove it, as needed.
        Me.InBoxDetailAcountTableAdapter.Fill(Me.AcountingDataSet.InBoxDetailAcount)
        ' Me.InBoxDetailAcountTableAdapter.FillByCached(Me.AcountingDataSet.InBoxDetailAcount)
        'Me.InBoxDetailAcountBindingSource.Filter = "AcountModified='" & Now.Date & "' and TotalRest=0"
        Me.InBoxDetailAcountBindingSource.Filter = "IsCheck=false And AcountModified='" & Now.Date & "'"
        Me.BatchsBindingSource.Filter = "(Payed=1) AND (BatchDate='" & Now.Date & "')"
        Dt1.Value = Now.Date
        Dt2.Value = Now.Date
        Me.ReportViewer1.RefreshReport()

    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        InBoxDetailAcountBindingSource.RemoveFilter()
        Mydt1 = Dt1.Value.Date
        Mydt2 = Dt2.Value.Date
        Myfilter = "IsCheck=false And AcountModified >= '" & Mydt1 & "' And AcountModified <= '" & Mydt2 & "'"
        'Myfilter = "AcountDate <= '" & Mydt2 & "'"

        InBoxDetailAcountBindingSource.Filter = Myfilter
        Me.BatchsBindingSource.Filter = "(Payed=1) AND (BatchDate>='" & Mydt1 & "' AND BatchDate<='" & Mydt2 & "')"

        Me.ReportViewer1.RefreshReport()

    End Sub

    Private Sub Dt1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Dt1.ValueChanged
        If RadioButton2.Checked Then
            InBoxDetailAcountBindingSource.RemoveFilter()
            Mydt1 = Dt1.Value.Date
            Mydt2 = Dt2.Value.Date
            Myfilter = "IsCheck=false And AcountModified >= '" & Mydt1 & "' And AcountModified <= '" & Mydt2 & "'"
            'Myfilter = "AcountDate <= '" & Mydt2 & "'"
            InBoxDetailAcountBindingSource.Filter = Myfilter
            Me.BatchsBindingSource.Filter = "(Payed=1) AND (BatchDate>='" & Mydt1 & "' AND BatchDate<='" & Mydt2 & "')"

            Me.ReportViewer1.RefreshReport()
        End If
    End Sub

    Private Sub Dt2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Dt2.ValueChanged
        If RadioButton2.Checked Then
            InBoxDetailAcountBindingSource.RemoveFilter()
            Mydt1 = Dt1.Value.Date
            Mydt2 = Dt2.Value.Date
            Myfilter = "IsCheck=false And AcountModified >= '" & Mydt1 & "' And AcountModified <= '" & Mydt2 & "'"
            'Myfilter = "AcountDate <= '" & Mydt2 & "'"
            InBoxDetailAcountBindingSource.Filter = Myfilter
            Me.BatchsBindingSource.Filter = "(Payed=1) AND (BatchDate>='" & Mydt1 & "' AND BatchDate<='" & Mydt2 & "')"

            Me.ReportViewer1.RefreshReport()
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        InBoxDetailAcountBindingSource.RemoveFilter()
        Me.InBoxDetailAcountBindingSource.Filter = "IsCheck=false And AcountModified='" & Now.Date & "'"
        Me.BatchsBindingSource.Filter = "(Payed=1) AND (BatchDate='" & Now.Date & "')"

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.InBoxDetailAcountTableAdapter.Fill(Me.AcountingDataSet.InBoxDetailAcount)
        Myfilter = "IsCheck=false And AcountModified >= '" & Mydt1 & "' And AcountModified <= '" & Mydt2 & "'"
        InBoxDetailAcountBindingSource.Filter = Myfilter
        Me.BatchsBindingSource.Filter = "(Payed=1) AND (BatchDate>='" & Mydt1 & "' AND BatchDate<='" & Mydt2 & "')"
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub FrmTreeAcount_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        FrmMain.Button5.ForeColor = Color.Black
    End Sub

    Private Sub FillByKindToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FillByKindToolStripButton.Click
        Try
            Me.InBoxDetailAcountTableAdapter.FillByKind(Me.AcountingDataSet.InBoxDetailAcount, KindToolStripTextBox.Text)
            Me.InBoxDetailAcountBindingSource.Filter = "IsCheck=false"
            Me.ReportViewer1.RefreshReport()
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Try
            Me.InBoxDetailAcountTableAdapter.Fill(Me.AcountingDataSet.InBoxDetailAcount)
            Me.InBoxDetailAcountBindingSource.Filter = "IsCheck=false"
            Me.ReportViewer1.RefreshReport()
        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class