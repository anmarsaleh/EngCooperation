Public Class FrmCheckRpt

    Private Sub FrmCheckRpt_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AcountingDataSet.InBoxDetailAcount' table. You can move, or remove it, as needed.
        Me.InBoxDetailAcountTableAdapter.Fill(Me.AcountingDataSet.InBoxDetailAcount)
        TextBox1.Hide()
        Me.InBoxDetailAcountBindingSource.Filter = "AcountID=" & TextBox1.Text & ""
        Me.ReportViewer1.Dock = DockStyle.Fill
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class