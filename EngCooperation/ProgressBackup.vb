Public Class ProgressBackup

    Private Sub ProgressBackup_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.TopMost = True
        Timer1.Enabled = True
    End Sub
   
    Private Sub ProgressBackup_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label1.Text += " ."
        If ProgressBar1.Value >= 100 Then
            Timer1.Stop()
            Timer1.Enabled = False
            Me.Close()
        Else
            ProgressBar1.Value += 1
        End If
    End Sub
End Class