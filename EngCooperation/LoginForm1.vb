
Public Class LoginForm1
    Protected CntLogIn As Integer = 0
    Dim cnn As New System.Data.SqlClient.SqlConnection
    Dim Cmd As New SqlClient.SqlCommand
    Dim Reader As SqlClient.SqlDataReader

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click

        If Not TestLogIn(UsernameTextBox.Text, PasswordTextBox.Text) Then
            ' MsgBox("معلومات حساب المستخدم غير صحيحة", vbOKOnly, "خطأ دخول")
            SplashScreen1.TopLevel = False
        Else
            SplashScreen1.TopLevel = True
            Me.Hide()
            FrmMain = New MainFrm
            FrmMain.Show()

        End If
        If CntLogIn >= 3 Then
            OK.Enabled = False
            Me.Enabled = False
            Timer1.Enabled = True
            Tk = 0
            Timer1.Start()

        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        End
    End Sub

    Function TestLogIn(ByVal user As String, ByVal PW As String) As Boolean
        Dim test As Boolean
        Dim MyStr As String = "Select * from UsersInfo where (UserName='" & user & "' and UserPW='" & PW & "')"
        cnn.ConnectionString = My.Settings.EngDBConnectionString
        cnn.Open()
        Cmd.Connection = cnn
        Cmd.CommandType = CommandType.Text
        Cmd.CommandText = MyStr
        'Cmd.ExecuteNonQuery()
        Reader = Cmd.ExecuteReader
        If Reader.HasRows Then
            Reader.Read()
            If Reader.GetValue(4).Equals(user) And Reader.GetValue(5).Equals(PW) Then
                test = True
                With UsersInfo
                    .UserID = IIf(IsDBNull(Reader.GetValue(0)), -1, Reader.GetValue(0))
                    .AllowCV = IIf(IsDBNull(Reader.GetValue(1)), False, True)
                    .AllowAcount = IIf(IsDBNull(Reader.GetValue(2)), False, True)
                    .AllowBox = IIf(IsDBNull(Reader.GetValue(3)), False, True)
                    .name = IIf(IsDBNull(Reader.GetValue(4)), -1, Reader.GetValue(4))
                    .UserPW = IIf(IsDBNull(Reader.GetValue(5)), -1, Reader.GetValue(5))
                    .IsAdmin = IIf(IsDBNull(Reader.GetValue(6)), False, True)
                End With

            Else
                test = False
                MsgBox("الرجاء التأكد من اسم المستخدم وكلمة المرور")
            End If
        Else
            MsgBox("معلومات الحساب المدخلة غير موجودة")
        End If
        cnn.Close()
        CntLogIn += 1
        Return test
    End Function

    Private Sub UsernameTextBox_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles UsernameTextBox.LostFocus
        If UsernameTextBox.Text.Length <= 1 Then
            OK.Enabled = False
        ElseIf PasswordTextBox.Text.Length <= 1 Then
            OK.Enabled = False
        Else
            OK.Enabled = True
        End If
    End Sub

    Private Sub PasswordTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PasswordTextBox.TextChanged
        If UsernameTextBox.Text.Length <= 1 Then
            OK.Enabled = False
        ElseIf PasswordTextBox.Text.Length <= 1 Then
            OK.Enabled = False
        Else
            OK.Enabled = True
        End If
    End Sub
    Dim Tk As Integer = 0
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Tk += 1
        If Tk = 60 Then
            Me.Enabled = True
            OK.Enabled = True
            Timer1.Stop()
            Timer1.Enabled = False
        End If
    End Sub

    Private Sub LoginForm1_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Cancel.PerformClick()
    End Sub
End Class
