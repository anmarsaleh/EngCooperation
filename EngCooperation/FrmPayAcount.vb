Public Class FrmPayAcount

  

    Private Sub FrmPayAcount_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PatDataSet.EngCV' table. You can move, or remove it, as needed.
        Me.EngCVTableAdapter.Fill(Me.PatDataSet.EngCV)
        'TODO: This line of code loads data into the 'PatDataSet.Classes' table. You can move, or remove it, as needed.
        Me.ClassesTableAdapter.Fill(Me.PatDataSet.Classes)
        'TODO: This line of code loads data into the 'PatDataSet.DetailsAcounting' table. You can move, or remove it, as needed.
        Me.DetailsAcountingTableAdapter.Fill(Me.PatDataSet.DetailsAcounting)
        'TODO: This line of code loads data into the 'PatDataSet.Acounting' table. You can move, or remove it, as needed.
        Me.AcountingTableAdapter.Fill(Me.PatDataSet.Acounting)
        TextBox1.Hide()
        TextBox2.Hide()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub FrmPayAcount_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Me.AcountingBindingSource.AddNew()
        ' EngIDComboBox.SelectedValue = TextBox1.Text

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim DrAc As DataRowView = Me.AcountingBindingSource.Current
        Dim DrDa As DataRowView
        DrAc("EngId") = EngIDComboBox.SelectedValue
        DrAc("AcountDate") = Now
        DrAc("AcountStatus") = Inwiat
        DrAc("AcountModified") = Now
        DrAc("RestAcountID") = EngIDComboBox.SelectedValue
        DrAc("RestAcountStat") = False
        DrAc("EndAcountDate") = Now
        DrAc("IsCancel") = False
        Me.DetailsAcountingBindingSource.MoveFirst()
        For i As Integer = 1 To Me.DetailsAcountingBindingSource.Count
            DrDa = Me.DetailsAcountingBindingSource.Current
            TotalTextBox.Text = DrDa("RealCost")
            TotalBayTextBox.Text = DrDa("Cost")
            TotalRestTextBox.Text = DrDa("RestCost")
            Me.DetailsAcountingBindingSource.MoveNext()
        Next

        Me.Validate()
        Me.AcountingBindingSource.EndEdit()
        Me.DetailsAcountingBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PatDataSet)
        Me.PatDataSet.AcceptChanges()
    End Sub

    Private Sub DetailsAcountingDataGridView_CellValueChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DetailsAcountingDataGridView.CellValueChanged
        If Not Me.Created Then Exit Sub
        If DetailsAcountingDataGridView.Rows.Count < 1 Then Exit Sub
        If e.ColumnIndex = 2 Then
            Me.DetailsAcountingDataGridView.CurrentRow.Cells("DataGridViewTextBoxColumn6").Value = TextBox2.Text
        End If
        If e.ColumnIndex = 4 Then
            Me.DetailsAcountingDataGridView.CurrentRow.Cells("DataGridViewTextBoxColumn7").Value = Me.DetailsAcountingDataGridView.CurrentRow.Cells("DataGridViewTextBoxColumn6").Value - Me.DetailsAcountingDataGridView.CurrentRow.Cells("DataGridViewTextBoxColumn4").Value
        End If
    End Sub
End Class