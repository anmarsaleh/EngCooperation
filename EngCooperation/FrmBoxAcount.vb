Imports System.Drawing.Printing
Public Class FrmBoxAcount
    Dim Idr As Integer = -1
    Dim FullN, Remark As String
    Dim Tot, Totpay As Decimal

    Private Sub FrmBoxAcount_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Timer1.Stop()
        Timer1.Enabled = False
    End Sub
    Private Sub FrmBoxAcount_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AcountingDataSet.InBoxAcount' table. You can move, or remove it, as needed.
        Me.InBoxAcountTableAdapter.Fill(Me.AcountingDataSet.InBoxAcount, EngMode.AcountInWait)
        'TODO: This line of code loads data into the 'AcountingDataSet.InBoxDetailAcount' table. You can move, or remove it, as needed.
        Me.InBoxDetailAcountTableAdapter.Fill(Me.AcountingDataSet.InBoxDetailAcount)
        If Me.InBoxAcountDataGridView.RowCount <> 0 Then
            Idr = Me.InBoxAcountDataGridView.CurrentRow.Cells("ClAcountID").Value
            FullN = Me.InBoxAcountDataGridView.CurrentRow.Cells("ColFullName").Value
        End If
        Me.InBoxDetailAcountBindingSource.Filter = "AcountID=" & Idr & ""
        EngIDTextBox.Hide()
        TotalRestTextBox.Hide()
        Me.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.ReportViewer1.RefreshReport()
        If InBoxAcountDataGridView.RowCount <= 0 Then
            ReportViewer1.Visible = False
        Else
            ReportViewer1.Visible = True
        End If
        Timer1.Stop()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
    Dim Rid As Integer
    Private Sub InBoxAcountDataGridView_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles InBoxAcountDataGridView.CellMouseClick
        Dim LastIdr As Integer = Idr
        If InBoxAcountDataGridView.RowCount = 0 Then Exit Sub
        ReportViewer1.Visible = True
        Idr = InBoxAcountDataGridView.CurrentRow.Cells("ClAcountID").Value
        FullN = InBoxAcountDataGridView.CurrentRow.Cells("ColFullName").Value
        Tot = InBoxAcountDataGridView.CurrentRow.Cells("TotalCost").Value
        Totpay = InBoxAcountDataGridView.CurrentRow.Cells("TotalBay").Value
        Remark = InBoxAcountDataGridView.CurrentRow.Cells("Remarks").Value.ToString
        Rid = InBoxAcountDataGridView.CurrentRow.Cells("RestAcountID").Value
        If LastIdr = Idr Then Exit Sub
        InBoxDetailAcountBindingSource.RemoveFilter()
        InBoxDetailAcountBindingSource.Filter = "AcountID=" & Idr & ""
        ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        'Dim cprinter As New System.Drawing.Printing.PrinterSettings
        'Dim Paps As New System.Drawing.Printing.PaperSize("Ram", 583, 827)
        'cprinter.Copies = 2
        'cprinter.DefaultPageSettings.PaperSize = Paps
        'ReportViewer1.PrinterSettings = cprinter
        ReportViewer1.PrintDialog()
    End Sub
    Dim EngBatch As New BatchesDataSetTableAdapters.BatchsTableAdapter
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If EngIDTextBox.Text = String.Empty Then Exit Sub
        Dim MsgString As String = "هل أنت متأكد من ترحيل الوصل رقم " & "(" & Idr & ")" & " المقبوض من السيد" & "(" & FullN & ")...?"
        Dim Engid As Integer = EngIDTextBox.Text
        If MessageBox.Show(Me, MsgString, "تنبية", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2, MessageBoxOptions.RtlReading) = Windows.Forms.DialogResult.Yes Then
            If CInt(TotalRestTextBox.Text) > 0 Then
                InBoxAcountTableAdapter.UpdateAcountStat(True, Rid)
            Else
                InBoxAcountTableAdapter.UpdateAcountStat(False, Rid)
                'EngBatch.Insert(Idr, Engid, Now.Date, Total:=Totpay, Payed:=True, Remark:=Remark)
            End If
            InBoxAcountTableAdapter.UpdateAcountToCached(Idr)
            InBoxAcountTableAdapter.UpdateEngCvStatus(EngMode.Joind, Engid)

            Me.InBoxAcountTableAdapter.ClearBeforeFill = True
            Me.InBoxAcountTableAdapter.Fill(Me.AcountingDataSet.InBoxAcount, Inwiat)
            InBoxAcountDataGridView.Refresh()
            If InBoxAcountDataGridView.RowCount > 0 Then
                ReportViewer1.Visible = True
                InBoxDetailAcountBindingSource.Filter = "AcountID=" & InBoxAcountDataGridView.CurrentRow.Cells(0).Value & ""
                ReportViewer1.RefreshReport()
            Else
                ReportViewer1.Visible = False
            End If
            On Error Resume Next
            If InBoxAcountDataGridView.RowCount > 0 Then
                InBoxDetailAcountBindingSource.Filter = "AcountID=" & InBoxAcountDataGridView.CurrentRow.Cells(0).Value & ""
                ReportViewer1.Visible = True
                ReportViewer1.RefreshReport()
            Else
                ReportViewer1.Visible = False
            End If
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim pos As Long = Me.InBoxAcountBindingSource.Position
        Me.InBoxAcountTableAdapter.Fill(Me.AcountingDataSet.InBoxAcount, EngMode.AcountInWait)
        Me.InBoxDetailAcountTableAdapter.Fill(Me.AcountingDataSet.InBoxDetailAcount)
        Me.InBoxAcountBindingSource.Position = pos
        If Me.InBoxAcountDataGridView.RowCount <> 0 Then
            Idr = Me.InBoxAcountDataGridView.CurrentRow.Cells("ClAcountID").Value
            FullN = Me.InBoxAcountDataGridView.CurrentRow.Cells("ColFullName").Value
        End If
        Me.InBoxDetailAcountBindingSource.Filter = "AcountID=" & Idr & ""
        EngIDTextBox.Hide()
        TotalRestTextBox.Hide()
        InBoxAcountDataGridView.Refresh()
        If Not CheckBox1.Checked Then Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ToolStripTextBox1_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ToolStripTextBox1.KeyUp
        If e.KeyCode = Keys.Enter Then
            Dim pos As Integer = 0
            If IsNumeric(ToolStripTextBox1.Text) Then
                pos = InBoxAcountBindingSource.Find("AcountID", ToolStripTextBox1.Text)
                InBoxAcountBindingSource.Position = pos
            Else
                pos = InBoxAcountBindingSource.Find("FullName", ToolStripTextBox1.Text)
                InBoxAcountBindingSource.Position = pos
            End If
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            Timer1.Start()
        Else
            Timer1.Stop()
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Button4.PerformClick()
    End Sub
End Class