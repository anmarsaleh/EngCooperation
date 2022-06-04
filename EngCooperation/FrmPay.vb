Imports System.Data
Imports System.Data.SqlClient
Public Class FrmPay
    Dim StrUpdt, StrMinID As String
    Dim Rmain As Integer
    Dim opj As Object
    Dim sqlCnn As New SqlClient.SqlConnection(My.Settings.EngDBConnectionString)
    Dim SqlCmdUpdt As SqlClient.SqlCommand
    Dim SqlCmdMin As SqlCommand

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        sqlCnn.Close()
        Me.Close()
    End Sub

    Private Sub FrmPay_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Height = 175
        StrMinID = "Select MIN(EngId) from EngCV where (EngId<0)"
        sqlCnn.Open()
        SqlCmdMin = New SqlCommand
        SqlCmdMin.CommandType = CommandType.Text
        SqlCmdMin.Connection = sqlCnn
        SqlCmdMin.CommandText = StrMinID
        opj = SqlCmdMin.ExecuteScalar()
        If Not IsDBNull(opj) Then
            Rmain = opj
            If Rmain = -1 Then Rmain = -1
        End If
        SqlCmdMin.Dispose()
        sqlCnn.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Button1.RightToLeft = 0 Then
            Button1.RightToLeft = Windows.Forms.RightToLeft.Yes
            Me.Height = 175
        Else
            Button1.RightToLeft = Windows.Forms.RightToLeft.No
            Me.Height = 255
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If TextBox1.TextLength < 1 Then
            TextBox1.BackColor = Color.Red
            TextBox1.Focus()
        End If
        If TextBox3.TextLength < 1 Then
            TextBox3.BackColor = Color.Red
            TextBox3.Focus()
        End If
        If TextBox1.BackColor = Color.Red OrElse TextBox3.BackColor = Color.Red Then
            MsgBox("يجب إكمال الحقول المطلوبة (الإسم والكنية)")
            Exit Sub
        End If
        StrUpdt = "INSERT INTO [EngCV] ([EngID] ,[Fname] ,[Mname] ,[Lname] ,[Gender],[Certificate] ,[DateOFbirthday],[DateOfgraduation],[DateOFjointly],[EngStatus] ,[National])"
        StrUpdt += " VALUES(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11)"
        Try
            sqlCnn.Open()
            SqlCmdUpdt = New SqlCommand
            SqlCmdUpdt.CommandType = CommandType.Text
            SqlCmdUpdt.Connection = sqlCnn
            SqlCmdUpdt.CommandText = StrUpdt
            SqlCmdUpdt.Parameters.Add("@p1", SqlDbType.Int).Value = Rmain - 1
            SqlCmdUpdt.Parameters.Add("@p2", SqlDbType.NVarChar).Value = TextBox1.Text
            SqlCmdUpdt.Parameters.Add("@p3", SqlDbType.NVarChar).Value = TextBox2.Text
            SqlCmdUpdt.Parameters.Add("@p4", SqlDbType.NVarChar).Value = TextBox3.Text
            SqlCmdUpdt.Parameters.Add("@p5", SqlDbType.NVarChar).Value = IIf(RadioButton1.Checked, "ذكر", "أنثى")
            SqlCmdUpdt.Parameters.Add("@p6", SqlDbType.NVarChar).Value = IIf(TextBox7.Text = "", "_", TextBox7.Text)
            SqlCmdUpdt.Parameters.Add("@p7", SqlDbType.Date).Value = IIf(IsDate(TextBox6.Text), TextBox6.Text, Now)
            SqlCmdUpdt.Parameters.Add("@p8", SqlDbType.Date).Value = Now
            SqlCmdUpdt.Parameters.Add("@p9", SqlDbType.Date).Value = Now
            SqlCmdUpdt.Parameters.Add("@p10", SqlDbType.NVarChar).Value = "Joind"
            SqlCmdUpdt.Parameters.Add("@p11", SqlDbType.NVarChar).Value = "سوري"
            SqlCmdUpdt.ExecuteNonQuery()
            SqlCmdUpdt.Dispose()
            sqlCnn.Close()
            Button2.Enabled = False
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        Finally
            Dim f As New FrmPayAcount
            f.TextBox1.Text = Rmain - 1
            f.ShowDialog()
            Me.Close()
        End Try

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        If TextBox1.TextLength > 0 Then
            TextBox1.BackColor = Color.White
        Else
            TextBox1.BackColor = Color.Red
        End If
    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged
        If TextBox3.TextLength > 0 Then
            TextBox3.BackColor = Color.White
        Else
            TextBox3.BackColor = Color.Red
        End If
    End Sub
End Class