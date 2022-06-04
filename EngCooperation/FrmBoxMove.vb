Public Class FrmBoxMove

    Private Sub FrmBoxMove_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BatchesDataSet.Batchs' table. You can move, or remove it, as needed.
        ' Me.BatchsTableAdapter.Fill(Me.BatchesDataSet.Batchs)
        'TODO: This line of code loads data into the 'AcountingDataSet.InBoxDetailAcount' table. You can move, or remove it, as needed.
        Me.InBoxDetailAcountTableAdapter.Fill(Me.AcountingDataSet.InBoxDetailAcount)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        InBoxDetailAcountBindingSource.RemoveFilter()
        InBoxDetailAcountBindingSource.Filter = "IsCheck=false And AcountModified='" & Now.Date & "'"
        'BatchsBindingSource.Filter = "(Payed=1) AND (BatchDate='" & Now.Date & "')"
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        InBoxDetailAcountBindingSource.RemoveFilter()
        InBoxDetailAcountBindingSource.Filter = "IsCheck=false And AcountModified >= '" & DTPicker1.Value.Date & "' And AcountModified <= '" & DTPicker2.Value.Date & "'"
        'BatchsBindingSource.Filter = "(Payed=1) AND (BatchDate>='" & DTPicker1.Value.Date & "' AND BatchDate<='" & DTPicker2.Value.Date & "')"

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub DTPicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DTPicker1.ValueChanged
        If RadioButton2.Checked Then
            InBoxDetailAcountBindingSource.RemoveFilter()
            InBoxDetailAcountBindingSource.Filter = "IsCheck=false And AcountModified >= '" & DTPicker1.Value.Date & "' And AcountModified <= '" & DTPicker2.Value.Date & "'"
            'BatchsBindingSource.Filter = "(Payed=1) AND (BatchDate>='" & DTPicker1.Value.Date & "' AND BatchDate<='" & DTPicker2.Value.Date & "')"
            Me.ReportViewer1.RefreshReport()
        End If
    End Sub

    Private Sub DTPicker2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DTPicker2.ValueChanged
        If RadioButton2.Checked Then
            InBoxDetailAcountBindingSource.RemoveFilter()
            InBoxDetailAcountBindingSource.Filter = "IsCheck=false And AcountModified >= '" & DTPicker1.Value.Date & "' And AcountModified <= '" & DTPicker2.Value.Date & "'"
            'BatchsBindingSource.Filter = "(Payed=1) AND (BatchDate>='" & DTPicker1.Value.Date & "' AND BatchDate<='" & DTPicker2.Value.Date & "')"
            Me.ReportViewer1.RefreshReport()
        End If

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.InBoxDetailAcountTableAdapter.Fill(Me.AcountingDataSet.InBoxDetailAcount)
        InBoxDetailAcountBindingSource.Filter = "IsCheck=false And AcountModified >= '" & DTPicker1.Value.Date & "' And AcountModified <= '" & DTPicker2.Value.Date & "'"
        'BatchsBindingSource.Filter = "(Payed=1) AND (BatchDate>='" & DTPicker1.Value.Date & "' AND BatchDate<='" & DTPicker2.Value.Date & "')"
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class