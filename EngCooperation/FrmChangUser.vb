Public Class FrmChangUser
    Dim UserSet As New UserInfoDataSetTableAdapters.UsersInfoTableAdapter
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub FrmChangUser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text += " (" + UsersInfo.name + ")"
        TextBox1.Text = UsersInfo.name
        TextBox2.Text = ""
        TextBox3.Text = ""
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox2.Text = UsersInfo.UserPW Then
            If TextBox3.Text = TextBox4.Text Then
                Dim r As MsgBoxResult = MessageBox.Show("هل أنت متأكد من تغيير حسابك الشخصي", "تغيير هوية المستخدم", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, MessageBoxOptions.RtlReading)
                If r = MsgBoxResult.Yes Then
                    If UserSet.ChangeUser(TextBox1.Text, TextBox3.Text, UsersInfo.UserID) = 1 Then
                        MsgBox("تم تغيير حسابك بنجاح سيقوم البرنامج بتسجيل الخروج الآن")
                        Me.Close()
                        FrmMain.تسجيلالخروجToolStripMenuItem.PerformClick()
                    End If
                End If
            Else
                MsgBox("كلمة المرور غير مطابقة")
                TextBox3.Focus()
                TextBox3.SelectAll()
            End If
        Else
            MsgBox("يرجى التأكد من كلمة المرور القديمة")
            TextBox2.Focus()
            TextBox2.SelectAll()
        End If
    End Sub
End Class