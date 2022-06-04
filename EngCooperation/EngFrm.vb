Imports System.ComponentModel
Public Class EngFrm
    Protected SaveTest As Byte = 0
    Dim MaxID As New EngDBDataSetTableAdapters.EngCVTableAdapter
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EngDBDataSet.EngCV' table. You can move, or remove it, as needed.
        On Error Resume Next
        Me.EngCVTableAdapter.Fill(Me.EngDBDataSet.EngCV)

        Button7.Visible = UsersInfo.IsAdmin
        SaveTest = 0
        Me.EngStatusTextBox.Hide()
        Me.CVModifiedDateTimePicker.Hide()
        'CheckBox1.Enabled = UsersInfo.IsAdmin
        Panel6.Enabled = UsersInfo.IsAdmin
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.EngCVBindingSource.CancelEdit()
        Me.Close()
    End Sub


    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If SaveTest = 1 Then
            If MsgBox("هل تريد حفظ السجل الحالي", MsgBoxStyle.YesNo, "تنبية") = vbYes Then
                Button4.PerformClick()
            Else
                Me.EngCVBindingSource.RemoveCurrent()
            End If
        End If
        SaveTest = 2
        Panel4.Dock = DockStyle.Top
        Label1.Dock = DockStyle.Top
        TxtSearch.Dock = DockStyle.Top
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If SaveTest = 1 Then Exit Sub
        If SaveTest = 2 Then Me.EngCVBindingSource.CancelEdit()
        Me.EngCVBindingSource.AllowNew = True
        Me.EngCVBindingSource.AddNew()
        Me.DateOfgraduationDateTimePicker.Value = Now
        Me.DateOFbirthdayDateTimePicker.Value = Now
        Me.DateOFjointlyDateTimePicker.Value = Now
        Me.EngStatusTextBox.Text = EngMode.InProgress
        Me.CVModifiedDateTimePicker.Value = Now
        CheckBox3.Checked = False
        CheckBox4.Checked = False
        CheckBox5.Checked = False
        CheckBox6.Checked = False
        SaveTest = 1
        EngIDTextBox.Focus()
        Label4.Visible = True
        Label4.Text = IIf(IsNothing(MaxID.MaxEngID), 1, MaxID.MaxEngID + 1)
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If SaveTest = 1 Then
            If MsgBox("هل تريد حفظ السجل الحالي", MsgBoxStyle.YesNo, "تنبية") = vbYes Then
                Button4.PerformClick()
            Else
                Me.EngCVBindingSource.RemoveCurrent()
            End If
        End If
        If SaveTest = 2 Then Me.EngCVBindingSource.CancelEdit()
        SaveTest = 3
        Label1.Dock = DockStyle.Bottom
        TxtSearch.Dock = DockStyle.Bottom
    End Sub

    Private Sub EngFrm_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        Dim locx, locy As New Point
        locx.X = (Panel2.Location.X - Panel3.Width) / 2
        locx.Y = Panel2.Location.Y
        Panel3.Location = locx
        locy.X = Panel3.Location.X
        locy.Y = (panel1.Location.Y - Panel3.Height) / 2
        Panel3.Location = locy
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Validate()
        If TestBeforSave() = 0 Then
            Try
                Me.EngCVBindingSource.EndEdit()
                Me.EngCVTableAdapter.Update(Me.EngDBDataSet.EngCV)
                SaveTest = 0
            Catch ex As SqlClient.SqlException
                MsgBox(ex.Message & " " & "الرقم الذاتي محجوز استخدم رقم آخر")
            End Try
        Else
            MsgBox("يجب ملئ الحقول المطلوبة بشكل صحيح")
        End If
    End Sub

    Private Sub EngFrm_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Dim locx, locy As New Point
        locx.X = (Panel2.Location.X - Panel3.Width) / 2
        locx.Y = Panel2.Location.Y
        Panel3.Location = locx
        locy.X = Panel3.Location.X
        locy.Y = (panel1.Location.Y - Panel3.Height) / 2
        Panel3.Location = locy

    End Sub

    Private Sub EngIDTextBox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles EngIDTextBox.KeyDown, FnameTextBox.KeyDown, MnameTextBox.KeyDown, LnameTextBox.KeyDown, CertificateTextBox.KeyDown, MotherNameTextBox.KeyDown, IntegrityTextBox.KeyDown, GenderComboBox.KeyDown, EntryTextBox.KeyDown, DateOFjointlyDateTimePicker.KeyDown, DateOfgraduationDateTimePicker.KeyDown, DateOFbirthdayDateTimePicker.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub EngIDTextBox_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles EngIDTextBox.Validating
        SetErr(sender, "BehivNum")
    End Sub

    Private Sub FnameTextBox_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles FnameTextBox.Validating

        SetErr(sender, "BehivStr")
    End Sub

    Private Sub MnameTextBox_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MnameTextBox.Validating

        SetErr(sender, "BehivStr")
    End Sub

    Private Sub LnameTextBox_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles LnameTextBox.Validating
        SetErr(sender, "BehivStr")
    End Sub

    Private Sub GenderComboBox_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)

        If Not (GenderComboBox.Text = "ذكر") Or Not (GenderComboBox.Text = "أنثى") Then
            SetErr(sender, "BehivStr")
        End If
    End Sub

    Private Sub CertificateTextBox_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles CertificateTextBox.Validating
        SetErr(sender, "BehivStr")
    End Sub

    Private Sub DateOFbirthdayDateTimePicker_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles DateOFbirthdayDateTimePicker.Validating
        SetErr(sender, "BehivDate")
    End Sub

    Private Sub DateOfgraduationDateTimePicker_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles DateOfgraduationDateTimePicker.Validating
        SetErr(sender, "BehivDate")
    End Sub

    Private Sub DateOFjointlyDateTimePicker_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles DateOFjointlyDateTimePicker.Validating
        SetErr(sender, "BehivDate")
    End Sub
    Function TestBeforSave() As Integer
        Dim i As Integer = 0
        Dim f As String = GenderComboBox.Text
        ErrorProvider1.Clear()
        If Not IsNumeric(EngIDTextBox.Text) Then ErrorProvider1.SetError(EngIDTextBox, "يجب إدخال الرقم الذاتي بشكل صحيح") : i += 1 'Else ErrorProvider1.Clear()
        If Trim(FnameTextBox.Text) = String.Empty Then ErrorProvider1.SetError(FnameTextBox, "يجب إدخال الإسم بشكل صحيح") : i += 1 'Else ErrorProvider1.Clear()
        If Trim(MnameTextBox.Text) = String.Empty Then ErrorProvider1.SetError(MnameTextBox, "يجب إدخال اسم الأب بشكل صحيح") : i += 1 'Else ErrorProvider1.Clear()
        If Trim(LnameTextBox.Text) = String.Empty Then ErrorProvider1.SetError(LnameTextBox, "يجب إدخال نسبة العائلة بشكل صحيح") : i += 1 'Else ErrorProvider1.Clear()
        If f = "أنثى" Then
            'ErrorProvider1.Clear()
        ElseIf f = "ذكر" Then
            'ErrorProvider1.Clear()
        Else
            ErrorProvider1.SetError(GenderComboBox, "يجب تحديد نوع الجنس بشكل صحيح") : i += 1
        End If
        If Trim(CertificateTextBox.Text) = String.Empty Then ErrorProvider1.SetError(CertificateTextBox, "يجب إدخال  الشهادة بشكل صحيح") : i += 1 'Else ErrorProvider1.Clear()
        'If Not DateOFbirthdayDateTimePicker.Value <= DateAdd(DateInterval.Year, -22, Now) Then ErrorProvider1.SetError(DateOFbirthdayDateTimePicker, "تاريخ الميلاد غير صالح") : i += 1 'Else ErrorProvider1.Clear()
        'If Not DateOfgraduationDateTimePicker.Value >= DateAdd(DateInterval.Year, +22, DateOFbirthdayDateTimePicker.Value) Then ErrorProvider1.SetError(DateOfgraduationDateTimePicker, "تاريخ التخرج غير صالح") : i += 1 'Else ErrorProvider1.Clear()
        'If Not DateOFjointlyDateTimePicker.Value >= DateOfgraduationDateTimePicker.Value Then ErrorProvider1.SetError(DateOFjointlyDateTimePicker, "تاريخ التسجيل غير صالح") : i += 1 'Else ErrorProvider1.Clear()

        Return i

    End Function

    Private Sub TxtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtSearch.TextChanged
        Dim TxtNum As String = Trim(TxtSearch.Text)
        Dim Lastpos As Integer = 0
        Dim st As String = -1
        If Not IsNumeric(TxtNum) Then
            st = -1
        Else
            st = TxtNum
            TxtNum = -1
        End If
        EngCVBindingSource.CancelEdit()
        EngCVTableAdapter.ClearBeforeFill = True
        Lastpos = EngCVBindingSource.Position
        If EngCVTableAdapter.FillBy(EngDBDataSet.EngCV, st, TxtNum) = 0 Then
            EngCVBindingSource.Position = Lastpos
        End If
    End Sub

    Private Sub BtnFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFirst.Click
        EngCVBindingSource.MoveFirst()
    End Sub

    Private Sub BtnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNext.Click
        EngCVBindingSource.MoveNext()
    End Sub

    Private Sub BtnPrev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrev.Click
        EngCVBindingSource.MovePrevious()
    End Sub

    Private Sub BtnLast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLast.Click
        EngCVBindingSource.MoveLast()
    End Sub

    Private Sub EngCVBindingSource_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles EngCVBindingSource.PositionChanged
        LblCurrent.Text = EngCVBindingSource.Position.ToString + 1
        LblTotal.Text = EngCVBindingSource.Count.ToString
    End Sub
    Dim WithEvents DlgImg As New OpenFileDialog
    Dim ImgName As String
    Private Sub BtnLoadImage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLoadImage.Click
        With DlgImg
            .Filter = "JPG|*.jpg"
            .ShowDialog(Me)
            If .FileName = "" Then Exit Sub
            ImgName = .FileName
            .Title = "إدراج صورة"
        End With
    End Sub
    Private Sub FileOkd() Handles DlgImg.FileOk
        Dim img As Image
        If DlgImg.FileName = "" Then Exit Sub
        ImgName = DlgImg.FileName
        img = Image.FromFile(ImgName)
        If img.Width > 100 Or img.Height > 100 Or img.VerticalResolution > 100 Then
            MsgBox("حجم الصورة كبير")
        Else
            EngBitmapPictureBox.Image = img

        End If
        img = Nothing
        ImgName = String.Empty
        DlgImg.FileName = String.Empty
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        EngBitmapPictureBox.Image = Nothing
        EngBitmapPictureBox = Nothing
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            EngStatusTextBox.Text = EngMode.InProgress
        ElseIf Not CheckBox1.Checked Then
            EngStatusTextBox.Text = EngMode.Joind
        End If
    End Sub

    Private Sub EngStatusTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EngStatusTextBox.TextChanged
        If EngStatusTextBox.Text = EngMode.InProgress Then
            CheckBox1.Checked = True
        Else
            CheckBox1.Checked = False
        End If
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        If Not ChkDate() Then
            MsgBox("عام الميلاد 1900 أو عام التخرج أو الإنتساب 1925 غير صالحين")
            Exit Sub
        End If
        Aid = Me.EngIDTextBox.Text
        Me.Close()
        FrmMain.ToolStripButton1.PerformClick()
        FrmMain.Button1.PerformClick()

    End Sub

    Private Sub EngIDTextBox_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles EngIDTextBox.KeyUp, FnameTextBox.KeyUp, MnameTextBox.KeyUp, LnameTextBox.KeyUp, CertificateTextBox.KeyUp, MotherNameTextBox.KeyUp, IntegrityTextBox.KeyUp, GenderComboBox.KeyUp, EntryTextBox.KeyUp, DateOFjointlyDateTimePicker.KeyUp, DateOfgraduationDateTimePicker.KeyUp, DateOFbirthdayDateTimePicker.KeyUp
        If e.KeyCode.Equals(Keys.Enter) Then
            EngIDTextBox.Text = Label4.Text
            Label4.Visible = False
            Dim ctrl As Control = ActiveControl
            If (TypeOf ctrl Is TextBox) Or (TypeOf ctrl Is ComboBox) Or (TypeOf ctrl Is DateTimePicker) Then
                SelectNextControl(ctrl, True, True, True, True)
            End If
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        NationalComboBox.Enabled = Not CheckBox2.Checked
        If CheckBox2.Checked Then
            NationalComboBox.Text = "سوري"
        End If
    End Sub

    Private Sub NationalComboBox_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles NationalComboBox.TextChanged
        If NationalComboBox.Text = "سوري" Then
            CheckBox2.Checked = True
        Else
            CheckBox2.Checked = False
        End If
    End Sub

    Private Sub DateOFbirthdayDateTimePicker_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateOFbirthdayDateTimePicker.ValueChanged
        If DateOFbirthdayDateTimePicker.Value.Year = 1925 Then
            SetErr(sender, "تاريخ الميلاد غير صالح")
        End If
    End Sub

    Private Sub DateOfgraduationDateTimePicker_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateOfgraduationDateTimePicker.ValueChanged
        If DateOfgraduationDateTimePicker.Value.Year = 1925 Then
            SetErr(sender, "تاريخ التخرج غير صالح")
        End If
    End Sub

    Private Sub DateOFjointlyDateTimePicker_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateOFjointlyDateTimePicker.ValueChanged
        If DateOFjointlyDateTimePicker.Value.Year = 1925 Then
            SetErr(sender, "تاريخ الإنتساب غير صالح")
        End If
    End Sub

    Function ChkDate() As Boolean
        Dim r As Boolean = True
        If DateOfgraduationDateTimePicker.Value.Year = 1925 OrElse _
            DateOFjointlyDateTimePicker.Value.Year = 1925 OrElse _
            DateOFbirthdayDateTimePicker.Value.Year = 1900 Then
            r = False
        Else
            r = True
        End If
        Return r
    End Function

    Private Sub EngIDTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EngIDTextBox.TextChanged
        If EngIDTextBox.Text = String.Empty Then
            Label4.Visible = True
        Else
            Label4.Visible = False
        End If
    End Sub
End Class