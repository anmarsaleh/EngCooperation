Public Class Setting

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub Setting_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AppSettingsDataSet.AppSettings' table. You can move, or remove it, as needed.
        Me.AppSettingsTableAdapter.Fill(Me.AppSettingsDataSet.AppSettings)
        If AppSettingsBindingSource.Count = 0 Then
            AppSettingsBindingSource.AddNew()
            TextBox2.Text = 9
            TextBox3.Text = 300
            TextBox4.Text = 50
            TextBox2.Text = 10
            TxtJoinY1.Text = 500
            TxtJoinY.Text = 250
            TxtJoinY2.Text = 240
            AppSettingsBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.AppSettingsDataSet)
            Me.AppSettingsDataSet.AcceptChanges()
            MsgBox(" يجب إعادة تشغيل البرنامج  لتفعيل التغييرات")
        End If
        'Label20.Text = TxtJoinY1.Text
        For i As Integer = 1990 To Now.Year
            ComboBox2.Items.Add(i)
            ComboBox3.Items.Add(i)
            ComboBox4.Items.Add(i)
        Next
        ComboBox2.Text = My.Settings.ExpEndY
        ComboBox4.Text = My.Settings.ExpStartY
        ComboBox1.Text = My.Settings.StartExpM
        ComboBox3.Text = My.Settings.StartExpY
        CheckBox1.Checked = My.Settings.IsExp
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim a, b As String
        a = "هل تريد بالفعل حفظ التعديلات؟"
        b = "ستؤثر هذة التعديلات على حساب قيمة الرسوم السنوية"
        If MsgBox(b & Chr(13) & a, MsgBoxStyle.Critical + MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
            Me.Validate()
            Me.AppSettingsBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.AppSettingsDataSet)
            Me.AppSettingsDataSet.AcceptChanges()
            MsgBox("يجب إعادة تشغيل البرنامج قبل لتفعيل التغييرات")
            LateMoreY = IIf(IsNumeric(TextBox8.Text), TextBox8.Text, 0)
            LateOneY = IIf(IsNumeric(TextBox9.Text), TextBox9.Text, 0)
        Else
            Me.AppSettingsBindingSource.CancelEdit()
        End If
        TextBox2.Enabled = False
        TextBox3.Enabled = False
        TextBox4.Enabled = False
        TextBox5.Enabled = False
        TxtJoinY.Enabled = False
        TxtJoinY1.Enabled = False
        TxtJoinY2.Enabled = False
        TextBox8.Enabled = False
        TextBox9.Enabled = False
    End Sub
    Dim cnt As Integer = 0
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click, Button2.Click
        If cnt = 3 Then
            GroupBox2.Enabled = False
            Exit Sub
        End If

        If IsNumeric(TextBox7.Text) And TextBox1.TextLength > 2 Then
            Dim UpdateCancel As New AppSettingsDataSetTableAdapters.UpdateIsCancelFromAcounting
            Dim n As String
            Dim p As String
            Dim r As Integer
            If UsersInfo.IsAdmin Then
                n = InputBox("أدخل اسم المستخدم", "تأكيد هوية المستخدم")
                p = InputBox("أدخل كلمة المرور", "تأكيد هوية المستخدم")
                If n = UsersInfo.name And p = UsersInfo.UserPW Then
                    If sender.name = "Button1" Then
                        r = UpdateCancel.UpdateIsCancel(True, TextBox1.Text, TextBox7.Text)
                    ElseIf sender.name = "Button2" Then
                        r = UpdateCancel.UpdateIsCancel(False, TextBox1.Text, TextBox7.Text)
                    End If
                    If r <> 1 Then
                        MsgBox("رقم الوصل غير موجود ضمن القيود")
                    ElseIf r = 1 Then
                        MsgBox("تم تنفيذ العملية بنجاح")
                    End If
                Else
                    MsgBox("هوية المستخدم غير معروفة   , أعد المحاولة من جديد")
                    cnt += 1
                End If
            Else
                MsgBox("صلاحية المسؤول غير متوفرة لديك, لا يمكن إتمام العملية")
            End If

        Else
            MsgBox("يجب إدخال رقم الوصل وكتابة سبب الإلغاء")
            TextBox7.Select()
        End If

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim ch As String = InputBox("أدخل كلمة المرور لتأكيد هوية المستخدم", "تأكيد الصلاحية")
        If ch = UsersInfo.UserPW And UsersInfo.IsAdmin Then
            TextBox2.Enabled = True
            TextBox3.Enabled = True
            TextBox4.Enabled = True
            TextBox5.Enabled = True
            TxtJoinY.Enabled = True
            TxtJoinY1.Enabled = True
            TxtJoinY2.Enabled = True
            TextBox8.Enabled = True
            TextBox9.Enabled = True
        Else
            MsgBox("لا تملك صلاحية التعديل")
        End If
    End Sub

    Private Sub TxtJoinY1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtJoinY1.TextChanged
        ' Label20.Text=TxtJoinY1.Text
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Try
            If ShrikDB() Then
                MsgBox("تمت العملية بنجاح")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Dim f As New ProgressBackup
        f.TopMost = True
        f.Show()
        Try
            If BackUpDB(Application.StartupPath) Then
                f.ProgressBar1.Value = 100
                f.Close()
                MsgBox("تمت العملية بنجاح")
            End If
        Catch ex As Exception
            f.Close()
            MsgBox(ex.Message)
        End Try
        Button8.Enabled = False
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        'Dim sd As New Windows.Forms.SaveFileDialog
        'If sd.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
        '    TextBox6.Text = sd.FileName
        'End If
        'If sd.CheckPathExists Then
        '    Button8.Enabled = True
        'End If
        On Error Resume Next
        Shell("explorer.exe " & Application.StartupPath & "\Backup")
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Dim Chk As Boolean = True
        If ComboBox2.Text.Length <> 4 Then
            Chk = False
        End If
        If ComboBox4.Text.Length <> 4 Then
            Chk = False
        End If
        If ComboBox1.Text.Length > 2 Then
            Chk = False
        End If
        If ComboBox3.Text.Length <> 4 Then
            Chk = False
        End If
        If Not Chk Then
            MsgBox("القيم المدخلة غير صحيحة, الرجاء التأكد من إدخال القيم بشكل صحيح للمتابعة")
            Exit Sub
        End If
        My.Settings.ExpEndY = ComboBox2.Text
        My.Settings.ExpStartY = ComboBox4.Text
        My.Settings.StartExpM = ComboBox1.Text
        My.Settings.StartExpY = ComboBox3.Text
        My.Settings.IsExp = CheckBox1.Checked
        MaxFine = IIf(IsNumeric(TextBox10.Text), TextBox10.Text, 0)
        My.Settings.Save()
        If CheckBox1.Checked Then
            MsgBox("تم تطبيق الإستثناءات بنجاح")
        Else
            MsgBox("تم إلغاء تطبيق الإستثناءات بنجاح")
        End If

    End Sub

    Private Sub Label18_Click(sender As System.Object, e As System.EventArgs) Handles Label18.Click

    End Sub

    Private Sub GroupBox3_Enter(sender As System.Object, e As System.EventArgs) Handles GroupBox3.Enter

    End Sub
End Class