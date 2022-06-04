Public Class FrmEngRep

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub FrmEngRep_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EngDBDataSet.EngRep' table. You can move, or remove it, as needed.
        Me.EngRepTableAdapter.Fill(Me.EngDBDataSet.EngRep)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class