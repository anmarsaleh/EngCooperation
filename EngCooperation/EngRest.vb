Public Class EngRest
    Dim id As Integer = -1

    Private Sub EngRest_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BatchesDataSet.DataReportRest' table. You can move, or remove it, as needed.
        Me.DataReportRestTableAdapter.Fill(Me.BatchesDataSet.DataReportRest)
        'TODO: This line of code loads data into the 'EngDBDataSet.EngCV' table. You can move, or remove it, as needed.
        Me.EngCVTableAdapter.Fill(Me.EngDBDataSet.EngCV)
        'TODO: This line of code loads data into the 'BatchesDataSet.Batchs' table. You can move, or remove it, as needed.
        Me.BatchsTableAdapter.Fill(Me.BatchesDataSet.Batchs)
        Me.BatchsBindingSource.Filter = "Payed=0"
        BatchsDataGridView.Refresh()

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub BatchsDataGridView_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles BatchsDataGridView.CellMouseClick
        id = Me.BatchsDataGridView.CurrentRow.Cells(0).Value
        BatchsDataGridView.CurrentRow.Selected = True
        Me.DataReportRestBindingSource.RemoveFilter()
        Me.DataReportRestBindingSource.Filter = "Bid=" & id & ""
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.ReportViewer1.PrintDialog()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim MsgString As String = "هل أنت متأكد من ترحيل الوصل رقم " & "(" & id & ")" & "" & "(" & "" & ")...?"
        If MessageBox.Show(Me, MsgString, "تنبية", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2, MessageBoxOptions.RtlReading) = Windows.Forms.DialogResult.Yes Then
            Me.DataReportRestTableAdapter.UpdatePayedTrue(id)
            Me.BatchsTableAdapter.UpdatePayedTrue(id)
            Me.BatchsTableAdapter.Fill(Me.BatchesDataSet.Batchs)
            BatchsDataGridView.Refresh()
            Me.DataReportRestTableAdapter.Fill(Me.BatchesDataSet.DataReportRest)
            Me.ReportViewer1.RefreshReport()
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.DataReportRestTableAdapter.Fill(Me.BatchesDataSet.DataReportRest)
        Me.EngCVTableAdapter.Fill(Me.EngDBDataSet.EngCV)
        Me.BatchsTableAdapter.Fill(Me.BatchesDataSet.Batchs)
        Me.BatchsBindingSource.Filter = "Payed=0"
        BatchsDataGridView.Refresh()
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class