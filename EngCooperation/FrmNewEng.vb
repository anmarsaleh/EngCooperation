Public Class FrmNewEng

    Const EnStat As String = EngMode.InProgress
    Private Sub FrmNewEng_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EngDBDataSet.EngCV' table. You can move, or remove it, as needed.
        'Me.EngCVTableAdapter.Fill(Me.EngDBDataSet.EngCV)
        Me.EngCVTableAdapter.FillByEngStatus(Me.EngDBDataSet.EngCV, EnStat)
    End Sub

    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub EngCVDataGridView_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles EngCVDataGridView.CellMouseClick
        EngCVDataGridView.CurrentRow.Selected = True
    End Sub

    Private Sub EngCVDataGridView_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles EngCVDataGridView.CellMouseDoubleClick
        Aid = EngCVDataGridView.CurrentRow.Cells("EngID").Value
        Me.Close()
        FrmMain.Button1.PerformClick()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.EngCVTableAdapter.FillByEngStatus(Me.EngDBDataSet.EngCV, EnStat)
        EngCVDataGridView.Refresh()
    End Sub

End Class