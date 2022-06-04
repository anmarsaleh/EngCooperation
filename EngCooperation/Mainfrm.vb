Public Class MainFrm
    Dim WithEvents btn As New Button
    Dim IsLoc As Boolean = False
    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        CloseCurrentMdi(Me.ActiveMdiChild)
        ToolStripButton1.Checked = True
        ToolStripButton2.Checked = False
        ToolStripButton3.Checked = False
        FlowLayoutPanel2.Visible = False
        FlowLayoutPanel3.Visible = False
        ToolStripButton4.Checked = False
        FlowLayoutPanel4.Visible = False
        FlowLayoutPanel1.Visible = True
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        CloseCurrentMdi(Me.ActiveMdiChild)
        ToolStripButton1.Checked = False
        ToolStripButton3.Checked = False
        FlowLayoutPanel1.Visible = False
        FlowLayoutPanel3.Visible = False
        ToolStripButton4.Checked = False
        FlowLayoutPanel4.Visible = False
        ToolStripButton2.Checked = True
        FlowLayoutPanel2.Visible = True
        'EngFrm.Show()
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        CloseCurrentMdi(Me.ActiveMdiChild)
        ToolStripButton1.Checked = False
        ToolStripButton2.Checked = False
        FlowLayoutPanel2.Visible = False
        FlowLayoutPanel1.Visible = False
        ToolStripButton4.Checked = False
        FlowLayoutPanel4.Visible = False
        ToolStripButton3.Checked = True
        FlowLayoutPanel3.Visible = True
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        CloseCurrentMdi(Me.ActiveMdiChild)
        FrmEngCv = New EngFrm
        FrmEngCv.MdiParent = Me
        FrmEngCv.Dock = DockStyle.Fill
        FrmEngCv.Show()
    End Sub

    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
        SplashScreen1.ProgressBar1.Value = 100
        SplashScreen1.ProgressBar1.Visible = False
        SplashScreen1.Show()
        SplashScreen1.TopMost = True
        btn.Name = "Close"
        btn.Text = "إغلاق"
        btn.Height = 20
        btn.Width = 45
        btn.Location = New Point(1, 1)
        SplashScreen1.Controls.Add(btn)
        btn.Visible = True
        btn.BringToFront()
        btn.BackColor = Color.AliceBlue
    End Sub
    Sub btnclick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn.Click
        SplashScreen1.Hide()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'On Error Resume Next
        'EngAcount.Close()
        CloseCurrentMdi(Me.ActiveMdiChild)
        EngAcount = New FrmAcount
        EngAcount.MdiParent = Me
        EngAcount.Dock = DockStyle.Fill
        EngAcount.Show()
    End Sub

    Private Sub إيقافالتشغيلToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles إيقافالتشغيلToolStripMenuItem.Click
        CheckClose()
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click

        FrmClas = New FrmClasses
        FrmClas.ShowDialog(Me)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        FrmEngNew = New FrmNewEng
        FrmEngNew.ShowDialog(Me)
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        'On Error Resume Next
        'FrmTreeAcounts.Close()
        CloseCurrentMdi(Me.ActiveMdiChild)
        FrmTreeAcounts = New FrmTreeAcount
        FrmTreeAcounts.MdiParent = Me
        FrmTreeAcounts.Dock = DockStyle.Fill
        FrmTreeAcounts.Show()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        'On Error Resume Next
        'FrmBoxAcounts.Close()
        CloseCurrentMdi(Me.ActiveMdiChild)
        FrmBoxAcounts = New FrmBoxAcount
        FrmBoxAcounts.MdiParent = Me
        FrmBoxAcounts.Dock = DockStyle.Fill
        FrmBoxAcounts.Show()
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        'On Error Resume Next
        'FrmBoxMoves.Close()
        CloseCurrentMdi(Me.ActiveMdiChild)
        FrmBoxMoves = New FrmBoxMove
        FrmBoxMoves.MdiParent = Me
        FrmBoxMoves.Dock = DockStyle.Fill
        FrmBoxMoves.Show()
    End Sub

    Private Sub ToolStripButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton6.Click
        If ToolStripButton6.Checked Then
            ToolStripButton6.Checked = True
            FlowLayoutPanel4.Visible = True
        Else
            FlowLayoutPanel4.Visible = False
            ToolStripButton6.Checked = False
        End If

    End Sub

    Private Sub تسجيلالخروجToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles تسجيلالخروجToolStripMenuItem.Click
        CloseCurrentMdi(Me.ActiveMdiChild)
        Me.Hide()
        FrmLogIn = New LoginForm1
        FrmLogIn.Show()
    End Sub

    Private Sub CheckClose()
        Dim Hc As New AcountingDataSet
        If Hc.HasChanges() Then
            Dim r As MsgBoxResult = MsgBox("لم تقم بحفظ التعديلات الأخيرة!" + Chr(13) + "إذا اردت المتابعة بإنهاء البرنامج ستفقد التعديلات الأخيرة,هل تريد المتابعة على أية حال؟", MsgBoxStyle.YesNo)
            If Not r = MsgBoxResult.Yes Then
                Exit Sub
            End If
        End If
        If My.Computer.Name = "RAMITTA" OrElse My.Computer.Name = "ramitta" Then
            If MsgBox("سيقوم البرنامج بعمل نسخة من قاعدة البيانات,هل تريد المتابعة؟", MsgBoxStyle.Information + MsgBoxStyle.OkCancel, "Backup Database") = MsgBoxResult.Ok Then
                BackUpDB(Application.StartupPath)
            End If
        End If
        NotifyIcon1.Visible = False
        NotifyIcon1.Dispose()
        Application.Exit()
        End
    End Sub
    Private Sub MainFrm_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        CheckClose()
    End Sub

    Private Sub MainFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SplashScreen1.TopLevel = True
        If Not UsersInfo.IsAdmin Then
            ToolStripButton1.Visible = UsersInfo.AllowAcount
            ToolStripButton3.Visible = UsersInfo.AllowBox
            ToolStripButton2.Visible = UsersInfo.AllowCV
            ToolStripButton6.Visible = UsersInfo.IsAdmin
        End If
        Me.Text = Me.Text & "---" & "المستخدم الحالي" & UsersInfo.name
        تسجيلالخروجToolStripMenuItem.Text += " - " + UsersInfo.name
        SplashScreen1.Hide()
        ToolStripMenuItem13.Text += " (" + UsersInfo.name + ")"
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        FrmUserInfo = New UserInfoFrm
        FrmUserInfo.ShowDialog(Me)
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        FrmEngCase = New EngCase
        FrmEngCase.ShowDialog(Me)
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        FrmSetting = New Setting
        FrmSetting.ShowDialog(Me)
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        On Error Resume Next
        FrmEngRest.Close()
        FrmEngRest = New EngRest
        FrmEngRest.MdiParent = Me
        FrmEngRest.Dock = DockStyle.Fill
        FrmEngRest.Show()
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        Dim dlgp As New System.Windows.Forms.PrintDialog
        dlgp.ShowDialog(Me)
    End Sub

    Private Sub MainFrm_MdiChildActivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.MdiChildActivate
        PictureBox1.Visible = False
    End Sub

    Private Sub OvalShape1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OvalShape1.Click, LineShape3.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub OvalShape1_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles OvalShape1.MouseHover, LineShape3.MouseHover
        OvalShape1.FillGradientStyle = PowerPacks.FillGradientStyle.None
        LineShape3.Visible = True
    End Sub

    Private Sub OvalShape1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles OvalShape1.MouseLeave, LineShape3.MouseLeave
        OvalShape1.FillGradientStyle = PowerPacks.FillGradientStyle.Horizontal
        LineShape3.Visible = False
    End Sub

    Private Sub OvalShape2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OvalShape2.Click, RectangleShape1.Click
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
            Panel1.Location = New Point(Me.Width - Panel1.Width, 12)
        Else
            Me.WindowState = FormWindowState.Maximized
            Panel1.Location = New Point(Me.Width - Panel1.Width, 12)
        End If
    End Sub

    Private Sub OvalShape2_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles OvalShape2.MouseHover, RectangleShape1.MouseHover
        OvalShape2.FillGradientStyle = PowerPacks.FillGradientStyle.None
        RectangleShape1.Visible = True
    End Sub

    Private Sub OvalShape2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles OvalShape2.MouseLeave, RectangleShape1.MouseLeave
        OvalShape2.FillGradientStyle = PowerPacks.FillGradientStyle.Horizontal
        RectangleShape1.Visible = False
    End Sub

    Private Sub OvalShape3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OvalShape3.Click, LineShape4.Click, LineShape5.Click
        CheckClose()
    End Sub

    Private Sub OvalShape3_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles OvalShape3.MouseHover, LineShape4.MouseHover, LineShape5.MouseHover
        OvalShape3.FillColor = Color.DarkRed
        LineShape4.Visible = True
        LineShape5.Visible = True
    End Sub

    Private Sub OvalShape3_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles OvalShape3.MouseLeave, LineShape4.MouseLeave, LineShape5.MouseLeave
        OvalShape3.FillColor = Color.Crimson
        LineShape4.Visible = False
        LineShape5.Visible = False
    End Sub

    Private Sub MainFrm_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        If Me.ActiveMdiChild Is Nothing Then
            PictureBox1.Visible = True
        Else
            PictureBox1.Visible = False
        End If
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        FrmAmounts = New FrmAmountEng
        FrmAmounts.Show(Me)
    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        Dim f As New FrmArchiv
        f.ShowDialog()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        On Error Resume Next
        CloseCurrentMdi(Me.ActiveMdiChild)
        Dim f As New FrmEngRep
        f.MdiParent = Me
        f.Dock = DockStyle.Fill
        f.Show()
    End Sub

    Private Sub تسجيلالخروجToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles تسجيلالخروجToolStripMenuItem1.Click
        تسجيلالخروجToolStripMenuItem.PerformClick()
    End Sub

    Private Sub إيقافالتشغيلToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles إيقافالتشغيلToolStripMenuItem1.Click
        إيقافالتشغيلToolStripMenuItem.PerformClick()
    End Sub

    Private Sub ToolStripMenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem7.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub ToolStripMenuItem10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem10.Click
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub ToolStripMenuItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem8.Click
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub قفلالبرنامحToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles قفلالبرنامحToolStripMenuItem.Click
        Dim loc As String
        Me.Enabled = False
        إيقافالتشغيلToolStripMenuItem1.Enabled = False
        تسجيلالخروجToolStripMenuItem1.Enabled = False
        ToolStripMenuItem8.Enabled = False
        IsLoc = True
        Do
            loc = InputBox("أدخل كلمة المرور لتأكيد هوية المستخدم", "قفل البرنامج")
            If loc = UsersInfo.UserPW Then
                Me.Enabled = True
                إيقافالتشغيلToolStripMenuItem1.Enabled = True
                تسجيلالخروجToolStripMenuItem1.Enabled = True
                ToolStripMenuItem8.Enabled = True
                IsLoc = False
                Exit Do
            Else
                MsgBox("كلمة المرور غير صالة")
            End If
        Loop
    End Sub

    Private Sub قفلإلغاءقفلToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles قفلإلغاءقفلToolStripMenuItem.Click
        If Not IsLoc Then
            Me.Enabled = False
            إيقافالتشغيلToolStripMenuItem1.Enabled = False
            تسجيلالخروجToolStripMenuItem1.Enabled = False
            ToolStripMenuItem8.Enabled = False
            قفلالبرنامحToolStripMenuItem.PerformClick()
        End If
    End Sub

    Private Sub ToolStripMenuItem13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem13.Click
        Dim f As New FrmChangUser
        f.ShowDialog()
    End Sub

    Private Sub ToolStripButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton7.Click
        Dim f As New FrmPay
        f.ShowDialog()
    End Sub
End Class
