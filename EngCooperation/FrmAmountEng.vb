Public Class FrmAmountEng
    Dim EngIDs As Integer
    Private Sub FrmAmountEng_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AcountingDataSet.Amounts' table. You can move, or remove it, as needed.
        Me.AmountsTableAdapter.Fill(Me.AcountingDataSet.Amounts, -1)
        'TODO: This line of code loads data into the 'AcountingDataSet.Amounts' table. You can move, or remove it, as needed.
        'Me.AmountsTableAdapter.Fill(Me.AcountingDataSet.Amounts)
        EngIDs = -1
        Me.ReportViewer1.RefreshReport()
        Me.Height = Panel1.Height + 20
        Me.MaximizeBox = False
        Me.MinimizeBox = False
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        EngIDs = IIf(IsNumeric(TextBox1.Text), TextBox1.Text, -1)
        Me.AmountsTableAdapter.Fill(Me.AcountingDataSet.Amounts, EngIDs)

        Me.WindowState = 2
        Me.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class