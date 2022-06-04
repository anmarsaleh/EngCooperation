Module Module1
    'Public Numbertxt As New MyNumTotxt
    'Public ConvertTOtxt As New Ramitta.MyNumTotxt
    Public EngID As Integer = -1
    Public EngName As String = String.Empty
    Public Aid As Integer = -1
    Public FrmMain As MainFrm
    Public EngAcount As FrmAcount
    Public FrmClas As FrmClasses
    Public FrmEngCv As EngFrm
    Public FrmEngNew As FrmNewEng
    Public FrmTreeAcounts As FrmTreeAcount
    Public FrmBoxAcounts As FrmBoxAcount
    Public FrmBoxMoves As FrmBoxMove
    Public FrmLogIn As LoginForm1
    Public FrmUserInfo As UserInfoFrm
    Public FrmEngCase As EngCase
    Public FrmSetting As Setting
    Public FrmEngRest As EngRest
    Public FrmAmounts As FrmAmountEng
    Public ClassIdDeath As Integer = 4 'رقم الصنف للوفاة
    Public ClassIdJoind As Integer = 3 'رقم الصنف لرسم التسجيل
    Public Const Inwiat As String = "InWait"
    Public Const Cached As String = "Cached"
    Public Const InProgress As String = "InProgress"
    Public Const Acanceld As String = "Acanceld"
    Public Const Joind As String = "Joind"
    Public connStr As String = My.Settings.EngDBConnectionString '"Data Source=.\sqlexpress;Initial Catalog=ENcooperationDB;Integrated Security=True;Pooling=False"
    Public myconn As System.Data.SqlClient.SqlConnection
    Public PStartExpY, PEndExpY As Integer
    Public LateOneY As Integer 'في حال التأخر عن الرسم عام واحد
    Public LateMoreY As Integer 'في حال التأخر عن الرسم اكثر من عام
    Public MaxFine As Decimal ' الحد الأقصى للغرامة
    Public Structure MyAppSet
        Public Shared IfLate As Integer = 50
        Public Shared IfLateDeath As Integer = 10
        Public Shared MaxAllow As Integer = 9
        Public Shared Fretail As Integer = 300
        Public Shared JoinSameY As Integer = 250
        Public Shared JoinPreY As Integer = 500
        Public Shared JoinLateY As Integer = 240
    End Structure
    Public Structure UserInfo
        Public UserID As Integer
        Public name As String
        Public UserPW As String
        Public AllowCV As Boolean
        Public AllowAcount As Boolean
        Public AllowBox As Boolean
        Public IsAdmin As Boolean
    End Structure
    Public UsersInfo As New UserInfo
    Public Structure EngMode  'وضع المهندس
        Const InProgress As String = "InProgress"
        Const Joind As String = "Joind"
        Const Acanceld As String = "Acanceld"
        Const AcountInWait As String = "InWait"
        Const AcountCached As String = "Cached"
    End Structure

    Public Structure ClassIDs ' معرفات الرسوم السنوية
        Const hat As Integer = 1         'رسم اشتراك
        Const Magazine As Integer = 2    'رسم مجلة
        Const Joind As Integer = 3       'رسم تسجيل
        Const DeathBox As Integer = 4    ' رسم صندوق وفاة
        Const Identity As Integer = 5    'رسم هوية
        Const warranty As Integer = 6   'رسم مساهمة ضمان
        Const retirement As Integer = 7  'رسم تقاعد
        Const solidarity As Integer = 8 'رسم تكافل
    End Structure

    Public Sub CloseCurrentMdi(ByVal f As Form)
        Dim Cmdi As Form = f
        If Not Cmdi Is Nothing Then
            Cmdi.Close()
        End If
    End Sub
    Public Sub SetErr(ByVal Obj As Object, ByVal Behiv As String)
        Select Case Behiv
            Case "BehivStr"
                If Trim(Obj.Text) = String.Empty Then
                    EngFrm.ErrorProvider1.SetError(Obj, "يجب إدخال قيمة نصية صحيحة")
                Else
                    EngFrm.ErrorProvider1.Clear()
                End If
            Case "BehivNum"
                If Not IsNumeric(Obj.Text) Then
                    EngFrm.ErrorProvider1.SetError(Obj, "يجب إدخال قيمة رقمية صحيحة")
                Else
                    EngFrm.ErrorProvider1.Clear()
                End If
            Case "BehivDat"
                If Not IsDate(Obj.Text) Then
                    EngFrm.ErrorProvider1.SetError(Obj, "يجب إدخال التاريخ بشكل صحيح")
                Else
                    EngFrm.ErrorProvider1.Clear()
                End If
        End Select
    End Sub
    Public Sub TestConnection()

        Dim TestCnn As New SqlClient.SqlConnection
        Dim Cmd As New SqlClient.SqlCommand
        Dim SqlRead As SqlClient.SqlDataReader
        SplashScreen1.Activate()
        TestCnn.ConnectionString = My.Settings.EngDBConnectionString
        Try
            TestCnn.Open()
            If TestCnn.State <> ConnectionState.Open Then
                MsgBox("لا يمكن الإتصال بقاعدة البيانات")
                End
            End If
            Cmd.Connection = TestCnn
            Cmd.CommandType = System.Data.CommandType.Text
            Cmd.CommandText = "Select * from AppSettings"
            SqlRead = Cmd.ExecuteReader()
            SqlRead.Read()
            If SqlRead.HasRows Then
                MyAppSet.Fretail = SqlRead.Item("Retail")
                MyAppSet.IfLate = SqlRead.Item("IFlate")
                MyAppSet.IfLateDeath = SqlRead.Item("IFlateDeath")
                MyAppSet.MaxAllow = SqlRead.Item("MaxAllow")
                MyAppSet.JoinLateY = SqlRead.Item("JoinY2")
                MyAppSet.JoinPreY = SqlRead.Item("JoinY1")
                MyAppSet.JoinSameY = SqlRead.Item("JoinY")
                If My.Computer.Name = "ramitta" OrElse My.Computer.Name = "RAMITTA" Then
                    Try
                        Dim Bkname As String = Now.Date.Day.ToString + "-" + Now.Date.Month.ToString + "-" + Now.Date.Year.ToString
                        If Not My.Computer.FileSystem.DirectoryExists(Application.StartupPath & "\BackUp") Then
                            My.Computer.FileSystem.CreateDirectory(Application.StartupPath & "\BackUp")
                        End If
                        'If My.Computer.FileSystem.DirectoryExists(Application.StartupPath & "\BackUp") Then

                        '    BackUpDB(Application.StartupPath)
                        'End If
                    Catch ex As Exception

                    End Try
                End If

            Else
                MsgBox("كشف البرنامج عن خطأ في إعدادات بيئة العمل", MsgBoxStyle.Critical, "خظا")
                End
            End If
        Catch e As Exception
            MsgBox(e.Message + " " + Chr(13) + "فشل الإتصال بالمخدم")
            End
        End Try

        TestCnn.Close()
    End Sub
    Public Function ShrikDB() As Boolean
        Dim r As Boolean
        Dim SqlStr As String = "DBCC SHRINKDATABASE(N'ENcooperationDB' )"
        myconn = New SqlClient.SqlConnection(connStr)
        myconn.Open()
        Dim cmd As New SqlClient.SqlCommand(SqlStr, myconn)
        If cmd.ExecuteNonQuery() = -1 Then
            r = True
        Else
            r = False
        End If
        On Error Resume Next
        SqlStr = "set identity_insert [DetailsAcounting] OFF"
        cmd.ExecuteNonQuery()
        SqlStr = "set identity_insert [DetailsAcounting] ON"
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        myconn.Close()
        Return r
    End Function
    Public Function BackUpDB(ByVal Path As String) As Boolean
        Dim r As Boolean
        Dim SqlStr As String = "BACKUP DATABASE [ENcooperationDB] TO  DISK = N'" & Path & "\BackUp\DB.bak' WITH NOFORMAT, INIT,  NAME = N'ENcooperationDB-Full Database Backup', SKIP, NOREWIND, NOUNLOAD,  STATS = 10"
        myconn = New SqlClient.SqlConnection(connStr)
        myconn.Open()
        Dim cmd As New SqlClient.SqlCommand(SqlStr, myconn)
        If cmd.ExecuteNonQuery() = -1 Then
            r = True
        Else
            r = False
        End If
        cmd.Dispose()
        myconn.Close()
        Return r
    End Function
    Public Function RestoreDB(ByVal Path As String) As Boolean
        Dim r As Boolean = False
        Dim SqlStr As String = "RESTORE DATABASE [ENcooperationBK] FROM  DISK = N'" & Path & "\BackUp\DB.bak' WITH  FILE = 1,  MOVE N'ENcooperationDB' TO N'C:\Program Files\Microsoft SQL Server\MSSQL10.SQLEXPRESS\MSSQL\DATA\ENcooperationBK.mdf',  MOVE N'ENcooperationDB_log' TO N'C:\Program Files\Microsoft SQL Server\MSSQL10.SQLEXPRESS\MSSQL\DATA\ENcooperationBK_1.LDF',  NOUNLOAD,  REPLACE,  STATS = 10"
        myconn = New SqlClient.SqlConnection(connStr)
        myconn.Open()
        Dim cmd As New SqlClient.SqlCommand(SqlStr, myconn)
        If cmd.ExecuteNonQuery() = -1 Then
            r = True
        Else
            r = False
        End If
        cmd.Dispose()
        myconn.Close()
        Return r
    End Function
    Public Function IsSQLServerAvailable(ByVal ServerAddress As String) As Boolean
        ' Tests an SQL Server connection by name or IP address 
        Try
            ' Attempt to get server address 
            Dim objIPHost As New System.Net.IPHostEntry()
            objIPHost = System.Net.Dns.GetHostEntry(ServerAddress)
            Dim objAddress As System.Net.IPAddress
            objAddress = objIPHost.AddressList(0)
            ' Connect to port 1433, most common SQL Server 
            ' port. If your target is different, change here 
            Dim objTCP As System.Net.Sockets.TcpClient = _
                New System.Net.Sockets.TcpClient()
            objTCP.Connect(objAddress, 1433)
            ' No problems (hurrah!) 
            ' Close and cleanup 
            objTCP.Close()
            objTCP = Nothing
            objAddress = Nothing
            objIPHost = Nothing
            ' Return success 
            Return True

        Catch ex As Exception
            ' Server unavailable, return fail value 
            Return False
        End Try
    End Function
    Public Function ExpValue() As Integer
        Dim StartExpM, StartExpY, ExpStartY, ExpEndY As Integer
        Dim CuM As Integer = Month(Now)
        Dim CuY As Integer = Year(Now)
        Dim IsExp As Boolean = My.Settings.IsExp
        If Not IsExp Then
            GoTo notex
        Else
            StartExpM = My.Settings.StartExpM
            StartExpY = My.Settings.StartExpY
            ExpStartY = My.Settings.ExpStartY
            ExpEndY = My.Settings.ExpEndY
            PStartExpY = ExpStartY
            PEndExpY = ExpEndY
            If StartExpY = CuY AndAlso StartExpM >= CuM Then
                GoTo inexp
            Else
                GoTo notex
            End If
        End If
notex:  Return 0
inexp:  Return 1
    End Function
End Module
