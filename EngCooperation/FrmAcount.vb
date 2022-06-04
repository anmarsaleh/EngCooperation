
Public Class FrmAcount
    Dim AdapterFine As New AcountingDataSetTableAdapters.EngCVTableAdapter
    Dim detailAcountSumCost As New AcountingDataSetTableAdapters.DetailsAcountingTableAdapter
    Dim batchTbl As New BatchesDataSetTableAdapters.EngRestTableTableAdapter
    Dim MaxAcountID As New AcountingDataSetTableAdapters.AcountingTableAdapter
    Dim MyEngID As Integer = -1
    Dim EngYearBirthday As Integer 'سنة ميلاد المهندس
    Dim EngYearGrat As Integer 'سنة تخرج المهندس
    Dim CurrentYear As Integer = Now.Date.Year ' السنة الحالية
    Dim EngAge As Integer 'عمر المهندس
    Dim EngStatus As String
    Dim EngHasRecord As Boolean = False
    Dim EngYearJoind As Integer
    Dim IsBenefit As Boolean = True
    Dim CostJoind As Integer = 0 ' قيمة رسم التسجيل لأول مرة
    Dim RetailCost As Integer = MyAppSet.Fretail 'رسم انتساب في صندوق التقاعد
    Dim IsLate As Boolean = False
    Dim EngLastYear As Integer
    Dim CurrentMonth As Integer = Month(Now) 'الشهر الحالي
    Dim LastMonth As Integer = MyAppSet.MaxAllow 'الشهر الأقصى المسموح بة للتأخير
    Dim MonthLate As Integer = 0 'عدد أشهر التأخير عن تسديد الرسم
    Dim NumOfClasses As Integer
    Dim CheckSplit As Boolean = False
    Dim IsRest As Boolean = False
    Dim resumclass As Boolean = False
    Dim NumOfYearLate As Integer = 0
    Dim NumOfYearPay As Integer = 0 'عدد سنوات دفع الرسوم
    Dim DesYear As Integer = 0 'مؤشر لإنقاص سنوات لتأخير في حساب رسم الوفاة
    Dim PlusOfDeath As Integer = 0
    Dim MaxPlusDeath As Integer = 0 'قيمة الحد الأقصى للغرامة
    Dim StopPlusDeath As Boolean = False 'التوقف عن حساب غرامة رسم الوفاة
    Dim Cdeathy As Integer = 0
    Dim StrEngCase As String
    Dim MultiExp As Byte = 1 'عامل الضرب للقيمة المستثناة من غرامة التأخير
    Private Structure EngCheck
        Shared IsForgin As Boolean = False 'هل المهندس أجنبي  
        Shared IsEngRetail As Boolean = False 'هل المهندس متقاعد أم لا
        Shared IsEngDeath As Boolean = False 'هل المهندس متوفي
        Shared IsEngMove As Boolean = False 'هل المهندس منقل من النقابة
        Shared IsEngCancel As Boolean = False 'هل المهندس ملغى
    End Structure

    Private Sub FrmAcount_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        FrmMain.Button1.ForeColor = Color.Blue
    End Sub
    Private Sub FrmAcount_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AcountingDataSet.Acounting' table. You can move, or remove it, as needed.
        Me.AcountingTableAdapter.Fill(Me.AcountingDataSet.Acounting) 'TODO: This line of code loads data into the 'ClassesDataSet.Classes' table. You can move, or remove it, as needed.
        'TODO: This line of code loads data into the 'AcountingDataSet.DetailsAcounting' table. You can move, or remove it, as needed.
        Me.DetailsAcountingTableAdapter.Fill(Me.AcountingDataSet.DetailsAcounting)
        Me.ClassesTableAdapter.Fill(Me.ClassesDataSet.Classes)
        EngID = -1
        EngName = String.Empty
        AcountingBindingSource.Filter = "EngID =" & -1
        DetailsAcountingDataGridView.Dock = DockStyle.Fill
        TextBox1.Text = IIf(Aid > 0, Aid, String.Empty)
        FillInfo()
        Aid = -1
        DetailsAcountingDataGridView.Columns("RealCost").Visible = False
        DetailsAcountingDataGridView.Columns("RestCost").Visible = False
        'AcountDateDateTimePicker.Value = Now
        EndAcountDateDateTimePicker.Value = AcountDateDateTimePicker.Value
        CheckBox2.Hide()
    End Sub

    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
        End If

    End Sub
    Private Sub CalcTolal() ' for BtnAddAll Only
        Dim Cnt As Integer
        Dim Tot As Double = 0
        Dim realtot As Double = 0
        Dim LastRest As Decimal = 0
        Dim SumDataRow As DataRowView
        Dim lastpay As Integer = 0
        lastpay = TotalTextBox.Text
        DetailsAcountingBindingSource.MoveFirst()
        Cnt = DetailsAcountingBindingSource.Count
        For i = 1 To Cnt
            SumDataRow = DetailsAcountingBindingSource.Current
            Tot = Tot + SumDataRow.Item("Cost")
            realtot = realtot + SumDataRow.Item("RealCost")
            LastRest = LastRest + SumDataRow.Item("RestCost")
            DetailsAcountingBindingSource.MoveNext()
        Next
        TotalTextBox.Text = Tot
        TotalBayTextBox.Text = realtot
        TotalRestTextBox.Text = Val(realtot - Tot)
    End Sub
    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If AcountStatusTextBox.Text = EngMode.AcountCached Then
            MsgBox("الإيصال الحالي مغلق لايمكن التعديل علية", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "تنبية")
            Me.AcountingBindingSource.CancelEdit()
            Me.DetailsAcountingBindingSource.CancelEdit()
            Exit Sub
        End If
       
        If Me.DetailsAcountingBindingSource.Count > 0 Then
            Dim Cnt As Integer
            Dim Tot As Double = 0
            Dim realtot As Double = 0
            Dim LastRest As Decimal = 0
            Dim SumDataRow As DataRowView
            Dim lastpay As Integer = 0
            lastpay = TotalTextBox.Text
            DetailsAcountingBindingSource.MoveFirst()
            Cnt = DetailsAcountingBindingSource.Count
            For i = 1 To Cnt
                SumDataRow = DetailsAcountingBindingSource.Current
                Tot = Tot + SumDataRow.Item("Cost")
                realtot = realtot + SumDataRow.Item("RealCost")
                LastRest = LastRest + SumDataRow.Item("RestCost")
                DetailsAcountingBindingSource.MoveNext()
            Next
            TotalTextBox.Text = Tot
            TotalBayTextBox.Text = realtot
            TotalRestTextBox.Text = Val(realtot - Tot)
            Dim a As Integer = AcountIDTextBox.Text
            If CheckSplit Then
                TotalRestTextBox.Text = LastRest

                'If CDate(AcountModifiedTextBox.Text) < racountDm Then
                '    MsgBox("تاريخ الوصل أصغر من تاريخ الوصل السابق" & Chr(13) & "القيمة غير صالحة")
                '    Exit Sub
                'End If
            Else
                TotalRestTextBox.Text = realtot - Tot
                RestAcountIDTextBox.Text = a
                'If (AcountDateDateTimePicker.Value.Year <> EngLastYear + 1) And TextBox8.Text <> "جديد" Then
                '    MsgBox("سنة الإستحقاق غير مطابقة لسنة حساب الرسوم" & Chr(13) & "سيقوم البرنامج بعملية المطابقة ومن  ثم إضغط على زر حفظ مرة أخرى")
                '    Exit Sub
                'End If
            End If
            If IsRest Then
                If TotalTextBox.Text = 0 Then
                    MsgBox("لا يمكن تقسيط الوصل دون دفعة أولى أكبر من صفر")
                    Exit Sub
                    RestAcountStatTextBox.Text = True
                End If
            Else
                TotalTextBox.Text = Tot
            End If

            If TotalRestTextBox.Text >= 0 Then
                RestAcountStatTextBox.Text = True
            ElseIf TotalRestTextBox.Text < 0 Then
                MsgBox("قيمة حقل الباقي المستحق يجب أن تكون أكبر أو تساوي الصفر")
                Exit Sub
            End If
            SumDataRow = Nothing
            Dim Testid As Integer = AcountIDTextBox.Text

            'تحديد طريقة الدفع
            Dim t As String = ComboBox1.Text
            If t = "في الصندوق" Then
                AcountStatusTextBox.Text = EngMode.AcountInWait
            ElseIf t = "اشعار/شيك مصرفي" Then
                If TextBox11.Text.Length < 10 Then
                    MsgBox("يجب كتابة رقم الإشعار المصرفي أو الشيك")
                    TextBox11.Focus()
                    Exit Sub
                End If
                AcountStatusTextBox.Text = EngMode.AcountCached
            Else
                MsgBox("يرجى تحديد طريقة الدفع قبل ترحيل السجل")
                ComboBox1.Focus()
                ComboBox1.DroppedDown = True
                Exit Sub
            End If
            If t = "اشعار/شيك مصرفي" Then
                CheckBox2.Checked = True
            Else
                CheckBox2.Checked = False
            End If
            Me.Validate()
            Me.AcountingBindingSource.EndEdit()
            Me.DetailsAcountingBindingSource.EndEdit()
            Try
                Me.TableAdapterManager.UpdateAll(Me.AcountingDataSet)
                Me.AcountingDataSet.AcceptChanges()
                If CheckBox2.Checked Then
                    Button4.Visible = True
                Else
                    Button4.Visible = False
                End If
            Catch ex As SqlClient.SqlException
                MsgBox(ex.Message)
            End Try

            If AcountStatusTextBox.Text = EngMode.AcountInWait Then
                Button3.Enabled = False
            Else
                Button3.Enabled = True
            End If
            BtnFirst.Enabled = True
            BtnLast.Enabled = True
            BtnPrev.Enabled = True
            BtnNext.Enabled = True
            Button3.Enabled = True
        ElseIf AcountingBindingSource.Count > 0 Then
            Me.AcountingBindingSource.RemoveCurrent()
            Exit Sub
        Else
            If MsgBox("يجب إضافة سجل ذاتية صالح للمهندس,ثم إضافة أمر قبض لإتمام عملية الحفظ" + Chr(13) + "هل ترغب بفتج سجلات الإنتساب", MsgBoxStyle.Critical + MsgBoxStyle.YesNo, "تنبية") = MsgBoxResult.Yes Then
                FrmNewEng.ShowDialog()
            End If
        End If

    End Sub

    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        'Me.Dispose(True)
        Me.Close()
    End Sub

    Private Sub AcountStatusTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AcountStatusTextBox.TextChanged
        Select Case AcountStatusTextBox.Text
            Case "InWait"
                TxtStatus.Text = "قيد الإنتظار"
            Case "Acanceld"
                TxtStatus.Text = "ملغى"
            Case "Cached"
                TxtStatus.Text = "مقبوض"
            Case Else
                TxtStatus.Text = ""
        End Select
    End Sub

    Private Sub DetailsAcountingDataGridView_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DetailsAcountingDataGridView.CellValueChanged
        If Not Me.Created Then Exit Sub
        If CheckSplit = False And NumOfYearPay <= 1 Then
            CalcCostEng(e.ColumnIndex, e.RowIndex)
        End If
        If Me.Created Then
            If e.ColumnIndex = 3 Then
                If Not IsRest Then
                    DetailsAcountingDataGridView.CurrentRow.Cells(e.ColumnIndex + 1).Value = DetailsAcountingDataGridView.CurrentRow.Cells(e.ColumnIndex).Value
                End If
                If Not CheckSplit Then
                    Dim dd As Decimal = IIf(IsDBNull(DetailsAcountingDataGridView.CurrentRow.Cells(e.ColumnIndex + 1).Value), 0, DetailsAcountingDataGridView.CurrentRow.Cells(e.ColumnIndex + 1).Value)
                    DetailsAcountingDataGridView.CurrentRow.Cells(e.ColumnIndex + 2).Value = dd - DetailsAcountingDataGridView.CurrentRow.Cells(e.ColumnIndex).Value
                Else
                    Dim val As Integer = DetailsAcountingDataGridView.CurrentRow.Cells(e.ColumnIndex + 2).Value - DetailsAcountingDataGridView.CurrentRow.Cells(e.ColumnIndex).Value
                    If val < 0 Then
                        MsgBox("الدفعة أكبر من الباقي")
                        DetailsAcountingDataGridView.CurrentRow.Cells(e.ColumnIndex).Value = 0
                        Exit Sub
                    End If
                    DetailsAcountingDataGridView.CurrentRow.Cells(e.ColumnIndex + 2).Value = val
                End If
            End If
        End If

    End Sub
    Dim d() As DataRowView
    Dim Rengid As Integer = 0
    Dim RAcountid As Integer = 0
    Dim Rtotal As Integer = 0
    Dim RtotalPay As Integer = 0
    Dim RtotalRest As Decimal = 0
    Dim RacountDate As DateTime = Now
    Dim Rendacountdate As DateTime = Now
    Dim racountDm As DateTime
    Dim rwcount As Integer = 0
    Function checkClasses(ByVal Yeary As Integer) As Boolean
        checkClasses = False
        Dim SqlConnect As New SqlClient.SqlConnection
        Dim SqlCmd As New SqlClient.SqlCommand
        Dim CurrentY As String = "y" & Yeary 'AcountDateDateTimePicker.Value.Year
        Dim SqlStr As String = "Update Classes set Cost=" & CurrentY & " where Status=N'رسم سنوي'"
        Dim SqlStrSelect As String = "Select " & CurrentY & " from  Classes "
        Dim SqlRead As SqlClient.SqlDataReader
        SqlConnect.ConnectionString = My.Settings.EngDBConnectionString
        'If SqlConnect.State = 1 Then SqlConnect.Close()
        SqlConnect.Open()
        SqlCmd.Connection = SqlConnect
        SqlCmd.CommandText = SqlStrSelect
        SqlRead = SqlCmd.ExecuteReader
        If SqlRead.HasRows Then
            SqlRead.Read()
            If SqlRead.IsDBNull(0) Then
                MsgBox(" سنة الإستحقاق المختارة تحتوي على قيم غير صالة")
                SqlRead.Close()
                SqlConnect.Close()
                resumclass = False
                Return False
                Exit Function
            End If
        Else
            MsgBox(" سنة الإستحقاق المختارة لا تحتوي على قيم للرسوم المستحقة")
            SqlRead.Close()
            SqlConnect.Close()
            resumclass = False
            Return False
            Exit Function
        End If
        SqlRead.Close()
        SqlCmd.CommandText = SqlStr
        'If Yeary <> Now.Year Then
        '    If MsgBox("سيقوم البرنامج بتحويل قيمة الرسوم لسنة الإستحقاق" & " " & AcountDateDateTimePicker.Value.Date) = vbNo Then
        '        SqlConnect.Close()
        '        resumclass = False
        '        Return False
        '        Exit Function
        '    End If
        'End If
        If SqlCmd.ExecuteNonQuery() > 0 Then
            checkClasses = True
            Me.ClassesTableAdapter.Fill(Me.ClassesDataSet.Classes)
            resumclass = True
            SqlConnect.Close()
        Else
            MsgBox("فشلت العملية بتحويل الرسوم لسنة الإستحقاق")
            SqlConnect.Close()
            resumclass = False
            Return False
            Exit Function
        End If
        SqlRead.Close()
        SqlConnect.Close()
        SqlConnect = Nothing

        Return checkClasses
    End Function
    Dim dt As DateTime
    Private Sub BtnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAdd.Click

        If Year(TextBox5.Text) = 1900 OrElse _
           TextBox7.Text = 1925 OrElse _
           TextBox10.Text = 1925 Then
            If MsgBox("عام الميلاد 1900 أو عام التخرج أو الإنتساب 1925 غير صالحين,هل ترغب  بتصحيح السجل؟", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                FrmEngCv.Show()
                FrmEngCv.Dock = DockStyle.Fill
                FrmEngCv.EngCVBindingSource.Find("EngID", TextBox2.Text)
                Me.Close()
            End If
            Exit Sub
        End If
        Dim Drv As DataRowView
        If Not CheckSplit Then
            'DetailsAcountingDataGridView.Enabled = True
            'DetailsAcountingDataGridView.EditMode = 2
            dt = AcountDateDateTimePicker.Value
            Drv = Me.AcountingBindingSource.Current
            If Not Drv Is Nothing Then
                If Drv.IsNew Then
                    MsgBox("لقد قمت بإضافة سجل فارغ جديد")
                    Exit Sub
                End If
            End If
            If MaxAcountID.MaxAcountID.HasValue Then
                AcountingDataSet.Acounting.AcountIDColumn.AutoIncrementSeed = MaxAcountID.MaxAcountID + 1
            Else
                AcountingDataSet.Acounting.AcountIDColumn.AutoIncrementSeed = 1
            End If
            Me.AcountingBindingSource.AddNew()
            'AcountIDTextBox.Text = Val(MaxAcountID.MaxAcountID + 1)
            EngIDTextBox.Text = MyEngID
            If TextBox8.Text = "جديد" Then
                dt = DateSerial(EngLastYear, 1, 1)
            Else
                dt = DateSerial(EngLastYear + 1, 1, 1)
            End If
            AcountDateDateTimePicker.Value = Now
            AcountDateDateTimePicker.Value = dt
            EndAcountDateDateTimePicker.Value = Now
            EndAcountDateDateTimePicker.Value = dt
            AcountModifiedTextBox.Text = Now
            TotalBayTextBox.Text = 0
            TotalRestTextBox.Text = 0
            TextBox11.Text = ""
            TotalTextBox.Text = "-1"
            TotalTextBox.Text = 0
            TotalTextBox.Refresh()
            RestAcountIDTextBox.Text = 0
            RestAcountStatTextBox.Text = True
            TextBoxIscancel.Text = False

            IsRest = False
            'If Not checkClasses() Then
            '    AcountingBindingSource.RemoveCurrent()
            '    Exit Sub
            'End If

            Me.DetailsAcountingDataGridView.EditMode = 2
        Else
            Rengid = TextBox2.Text
            RAcountid = CInt(RestAcountIDTextBox.Text)
            Rtotal = TotalTextBox.Text
            RtotalPay = TotalBayTextBox.Text
            RtotalRest = TotalRestTextBox.Text
            RacountDate = AcountDateDateTimePicker.Value
            Rendacountdate = EndAcountDateDateTimePicker.Value
            racountDm = AcountModifiedTextBox.Text
            rwcount = DetailsAcountingBindingSource.Count
            ReDim d(rwcount - 1)
            For i As Integer = 0 To rwcount - 1
                d(i) = DetailsAcountingBindingSource.Item(i)
            Next
            DetailsAcountingDataGridView.Enabled = True
            AcountingBindingSource.RemoveFilter()
            Me.AcountingBindingSource.AddNew()
            'AcountIDTextBox.Text = Val(MaxAcountID.MaxAcountID + 1)
            ' AcountingBindingSource.Filter = "AcountID='" & AcountIDTextBox.Text & "'"
            AcountDateDateTimePicker.Value = Now
            AcountDateDateTimePicker.Value = RacountDate
            EndAcountDateDateTimePicker.Value = Now
            EndAcountDateDateTimePicker.Value = Rendacountdate
            EngIDTextBox.Text = Rengid
            AcountModifiedTextBox.Text = Now
            TotalBayTextBox.Text = RtotalPay
            TextBox11.Text = ""
            TotalTextBox.Text = 0
            RestAcountIDTextBox.Text = RAcountid
            RestAcountStatTextBox.Text = True
            TotalRestTextBox.Text = 0
            TotalRestTextBox.Text = RtotalRest

            DetailsAcountingDataGridView.Columns("restcost").Visible = True
            DetailsAcountingDataGridView.Columns("realcost").Visible = True

            DetailsAcountingDataGridView.AllowUserToAddRows = True
            DetailsAcountingDataGridView.Select()
            Dim rw As DataRowView
            For y As Integer = 0 To rwcount - 1
                rw = DetailsAcountingBindingSource.Current
                For j As Integer = 0 To 4
                    rw.Item(j + 2) = d(y)(j + 2)
                    If j = 1 Then
                        rw.Item(j + 2) = 0
                    End If
                Next
                DetailsAcountingDataGridView.Update()
                If y = rwcount - 1 Then Exit For
                DetailsAcountingBindingSource.AddNew()
            Next
            'DetailsAcountingBindingSource.EndEdit()
            DetailsAcountingDataGridView.Update()
            DetailsAcountingDataGridView.Refresh()
            'DetailsAcountingDataGridView.EndEdit()
            DetailsAcountingDataGridView.EditMode = 2
            IsRest = True
        End If
        'If EngCheck.IsForgin Then
        '    ClassesBindingSource.RemoveFilter()
        '    ClassesBindingSource.Filter = "ClassID <> 4 and ClassID <> 7"
        'Else
        '    ClassesBindingSource.RemoveFilter()
        'End If
        'Me.AcountingBindingSource.EndEdit()
        DetailsAcountingDataGridView.Enabled = True
        DetailsAcountingDataGridView.ReadOnly = False
        BtnFirst.Enabled = False
        BtnLast.Enabled = False
        BtnPrev.Enabled = False
        BtnNext.Enabled = False
        Button3.Enabled = False
    End Sub

    Private Sub BtnFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFirst.Click
        AcountingBindingSource.MoveFirst()
    End Sub

    Private Sub BtnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNext.Click
        AcountingBindingSource.MoveNext()
    End Sub

    Private Sub BtnPrev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrev.Click
        AcountingBindingSource.MovePrevious()
    End Sub

    Private Sub BtnLast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLast.Click
        AcountingBindingSource.MoveLast()
    End Sub

    Sub CalcCostEng(ByVal Encol As Integer, ByVal EnRow As Integer) 'حساب قيمة الرسوم
        Dim CostJoind As Integer = 0
        Dim CostDeath As Integer = 0
        Dim CurrentClass As Integer = 0
        Dim More As Integer = 0
        If Encol = 2 And EnRow >= 0 Then
            If EngHasRecord Then
                Select Case TXTClassID.Text
                    Case ClassIDs.DeathBox ' حالة اختيار رسم وفاة
                        If EngAge <= 25 Then ' في حالة العمر تحت 25 سنة
                            DetailsAcountingDataGridView.Item(Encol + 1, EnRow).Value = (EngAge * 25) + TxtCost.Text
                        Else ' في حالة العمر فوق ال 25 سنة
                            DetailsAcountingDataGridView.Item(Encol + 1, EnRow).Value = (EngAge - 25) * ((EngAge + 25) * (EngAge + 25)) + TxtCost.Text
                        End If
                    Case ClassIDs.Joind 'حالة إختيار رسم تسجيل
                        If (CurrentYear - EngYearGrat) > 1 Then
                            'CostJoind = MyAppSet.JoinPreY + MyAppSet.JoinLateY * (CurrentYear - EngYearGrat) الحساب القديم
                            CostJoind = MyAppSet.JoinPreY + MyAppSet.JoinLateY * (LateMoreY - EngYearGrat)
                            DetailsAcountingDataGridView.Item(Encol + 1, EnRow).Value = CostJoind
                        ElseIf (CurrentYear - EngYearGrat) = 1 Then
                            'DetailsAcountingDataGridView.Item(Encol + 1, EnRow).Value = MyAppSet.JoinPreY  الحساب القديم
                            DetailsAcountingDataGridView.Item(Encol + 1, EnRow).Value = LateOneY
                        Else
                            DetailsAcountingDataGridView.Item(Encol + 1, EnRow).Value = TxtCost.Text
                        End If
                    Case ClassIDs.retirement 'حالة إختيار رسم تقاعد
                        DetailsAcountingDataGridView.Item(Encol + 1, EnRow).Value = RetailCost + CInt(TxtCost.Text)
                    Case Else
                        DetailsAcountingDataGridView.Item(Encol + 1, EnRow).Value = TxtCost.Text
                End Select
            Else
                If Not IsLate Then 'حساب يمة الرسم النظامي
                    DetailsAcountingDataGridView.Item(Encol + 1, EnRow).Value = TxtCost.Text

                Else   'حسلب قيمة الرسم في حالة التأخير 
                    More = IIf(IsDBNull(DetailsAcountingDataGridView.Item(Encol + 1, EnRow).Value), 0, DetailsAcountingDataGridView.Item(Encol + 1, EnRow).Value)
                    If TXTClassID.Text = ClassIDs.DeathBox Then 'حالة رسم الوفاة
                        DetailsAcountingDataGridView.Item(Encol + 1, EnRow).Value = More + CalcEngLate(TxtCost.Text, ClassIDs.DeathBox)

                        DetailsAcountingDataGridView.Item(Encol + 4, EnRow).Value = IIf(MultiExp = 0, "", "قيمة الغرامة" & " : " & PlusOfDeath)

                    ElseIf TXTClassID.Text = ClassIDs.Magazine Then
                        DetailsAcountingDataGridView.Item(Encol + 1, EnRow).Value = More + CalcEngLate(TxtCost.Text, ClassIDs.Magazine)
                    Else
                        If TXTClassID.Text > 8 Then
                            DetailsAcountingDataGridView.Item(Encol + 1, EnRow).Value = TxtCost.Text
                        Else
                            DetailsAcountingDataGridView.Item(Encol + 1, EnRow).Value = More + CalcEngLate(TxtCost.Text, -1)
                        End If
                    End If
                End If
                DetailsAcountingDataGridView.Update()
                DetailsAcountingDataGridView.Refresh()
                'DetailsAcountingBindingSource.EndEdit()
            End If
        End If
    End Sub
    Function CalcEngLate(ByVal r As Integer, ByVal stat As Integer) As Integer
        Dim calc As Integer
        Dim m As Integer = 0
        If stat = ClassIDs.DeathBox Then
            If DesYear = (Now.Year - AcountDateDateTimePicker.Value.Year) Then
                If AcountDateDateTimePicker.Value.Year > 2007 Then
                    m = 45
                Else
                    m = 30
                End If
            Else
                m = 0
            End If

            calc = (((r * (MyAppSet.IfLateDeath / 100)) * DesYear)) + m
            'If NumOfYearPay <= 1 Then
            '    calc = (r * (MyAppSet.IfLateDeath / 100) * DesYear) + m
            'Else
            '    calc = (((r * (MyAppSet.IfLateDeath / 100)) * DesYear)) + m
            'End If
            If Cdeathy = Now.Year Then 'توقيف الغرامة عن آخر سنة في حالة عدم التأخير
                If Now.Month < MyAppSet.MaxAllow + 1 Then
                    calc = (((r * (MyAppSet.IfLateDeath / 100)) * DesYear)) + m
                Else
                    calc = (((r * (MyAppSet.IfLateDeath / 100)) * 1)) + m
                End If

            End If
            If calc > r Then calc = r
            PlusOfDeath += calc
            calc += r
        ElseIf stat = ClassIDs.Magazine Then
            calc = r
        Else
            If Cdeathy = Now.Year Then 'توقيف الغرامة عن آخر سنة في حالة عدم التأخير
                If Now.Month < MyAppSet.MaxAllow + 1 Then
                    calc = r
                    Return calc
                    Exit Function
                End If
            End If
            calc = (r * (MyAppSet.IfLate / 100) + r) 'IIf(NumOfPay <= 1, r * (MyAppSet.IfLate / 100) + r, (r * (MyAppSet.IfLate / 100) + r) * NumOfPay)
        End If
        If MultiExp = 0 And ExpValue() = 1 Then
            TextBox11.Text = "غرامة التأخير (" & PStartExpY & " لغاية " & PEndExpY & ") معفاة"
            Return r
            Exit Function
        End If
        Return calc
    End Function
    Private Sub BtnAddAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddAll.Click
        If Year(TextBox5.Text) = 1900 OrElse _
           TextBox7.Text = 1925 OrElse _
           TextBox10.Text = 1925 Then
            If MsgBox("عام الميلاد 1900 أو عام التخرج أو الإنتساب 1925 غير صالحين,هل ترغب  بتصحيح السجل؟", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Dim f As New EngFrm
                f.Show()
                f.EngCVBindingSource.Find("EngID", TextBox2.Text)
                Me.Close()
            End If
            Exit Sub
        End If
        Dim CheckYear As Boolean = False
        Dim Starty, Endy As Integer
        LblWait.Dock = DockStyle.Fill
        LblWait.Visible = True
        Starty = AcountDateDateTimePicker.Value.Year
        Endy = EndAcountDateDateTimePicker.Value.Year
        Dim lolo As Integer = IIf(TextBox8.Text = "جديد", (Starty - EngLastYear), (Starty - EngLastYear) - 1)
        Dim soso As Integer = IIf(TextBox8.Text = "جديد", EngLastYear, EngLastYear + 1)
        If lolo > 0 Then
            If MsgBox("سنة الإستحقاق غير صحيحة" & Chr(13) & "سنة الإستحقاق الصحيحة هي عام" & " " & soso & "هل تريد أن يقوم البرنامج بتصحيح سنة الإستحقاق والمتابعة؟", MsgBoxStyle.Critical + MsgBoxStyle.YesNo) = MsgBoxResult.Ok Then
                AcountDateDateTimePicker.Value = Convert.ToDateTime("1-1-" & soso.ToString)
            Else
                If MsgBox("هل تريد المتابعة على أية حال", MsgBoxStyle.Critical + MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                    AcountDateDateTimePicker.Select()
                    LblWait.Visible = False
                    Exit Sub
                End If
            End If
        End If
        NumOfYearPay = (Endy - Starty) + 1  'عدد سنوات دفع الإشتراك
        MaxPlusDeath = GetDeathValue(Endy, ClassIDs.DeathBox)
        CheckYear = EngLastYear <= Now.Year
        If CheckYear Then
            If Not checkClasses(AcountDateDateTimePicker.Value.Year) Then
                AcountingBindingSource.RemoveCurrent()
                LblWait.Visible = False
                Exit Sub
            End If
            Dim Acnt As Integer = AcountingBindingSource.Count
            Dim Dcnt As Integer = DetailsAcountingBindingSource.Count
            If EngCheck.IsForgin Then
                MsgBox("يجب إختيار الرسوم من الشبكة بالنسبة للمهندسين الأجانب")
                LblWait.Visible = False
                DetailsAcountingDataGridView.Select()
                Exit Sub
            End If
            If Acnt <= 0 Then
                BtnAdd.PerformClick()
                'إضافة سجلات الرسم السنوي
                GetKindOfClass()
            ElseIf Dcnt <= 0 Then
                GetKindOfClass()
            End If
            CalcTolal() 'حساب المجاميع
        Else
            MsgBox("رسوم الإشتراك لهذا العام مدفوعة", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "تنبية")
            Me.AcountingBindingSource.CancelEdit()
        End If
        LblWait.Dock = DockStyle.None
        LblWait.Visible = False
    End Sub
    Function GetDeathValue(ByVal YearClass As Integer, ByVal ClsID As Integer) As Integer
        Dim val As Integer
        Dim Cyearclass = "y" & YearClass
        Dim mycnn As New SqlClient.SqlConnection(My.Settings.EngDBConnectionString)
        Dim cmd As New SqlClient.SqlCommand
        Dim myread As SqlClient.SqlDataReader
        'If mycnn.State = 1 Then mycnn.Close()
        mycnn.Open()
        cmd.Connection = mycnn
        cmd.CommandText = "Select " & Cyearclass & " from Classes where (ClassID=" & ClsID & ")"
        myread = cmd.ExecuteReader
        myread.Read()
        If myread.HasRows Then
            If IsDBNull(myread.Item(Cyearclass)) Then
                MsgBox("يجب اضافة معايير الحساب لسنوات استحقاق الرسوم")
            Else
                val = myread.Item(Cyearclass)
            End If

        Else
            MsgBox("فشل في استعلام القيمة")
        End If
        myread.Close()
        mycnn.Close()
        mycnn = Nothing
        Return val
    End Function
    Sub GetKindOfClass() 'إضافة الرسم السنوي
        If Not resumclass Then Exit Sub
        Dim MyRow As DataRowView
        Dim MyDetialRow As DataRowView
        DesYear = (Now.Year - AcountDateDateTimePicker.Value.Year) + 1  'NumOfYearPay
        If Now.Month > 9 Then
            DesYear += 1
        End If
        For y As Integer = 0 To NumOfYearPay - 1
            Cdeathy = AcountDateDateTimePicker.Value.Year + y
            If ExpValue() = 1 Then
                If Cdeathy >= PStartExpY Or Cdeathy = PEndExpY Then
                    MultiExp = 0
                Else
                    MultiExp = 1
                End If
            End If
            checkClasses(Cdeathy)
            ' Me.ClassesTableAdapter.Fill(Me.ClassesDataSet.Classes)
            ClassesBindingSource.CurrencyManager.Refresh()
            ClassesBindingSource.RemoveFilter()
            If EngCheck.IsEngRetail Then
                ClassesBindingSource.Filter = "Status='رسم سنوي' and (ClassID<>1 and ClassID<>7)"
            Else
                ClassesBindingSource.Filter = "Status='رسم سنوي'"
            End If
            ClassesBindingSource.MoveFirst()
            DetailsAcountingBindingSource.MoveFirst()

            DesYear = DesYear - 1 'NumOfYearPay - y 'إنقاص سنة استحقاق رسم الوفاة عند دفع أكثر من عام

            For i As Integer = 0 To ClassesBindingSource.Count - 1
                MyRow = ClassesBindingSource.Current
                If Not IsBenefit And MyRow.Row.Item(0) = ClassIDs.DeathBox Then ClassesBindingSource.MoveNext() : MyRow = ClassesBindingSource.Current
                If Not IsBenefit And MyRow.Row.Item(0) = ClassIDs.retirement Then ClassesBindingSource.MoveNext() : MyRow = ClassesBindingSource.Current
                If Not IsBenefit And MyRow.Row.Item(0) = ClassIDs.solidarity Then Exit For 'ClassesBindingSource.MoveNext() : MyRow = ClassesBindingSource.Current

                If EngHasRecord = True Then
                    If y = 0 Then DetailsAcountingBindingSource.AddNew()
                    MyDetialRow = DetailsAcountingBindingSource.Current
                    If y = 0 Then MyDetialRow.Row.Item(2) = MyRow.Row.Item(0).ToString
                    MyDetialRow.Row.Item(3) = MyDetialRow.Row.Item(3) 'MyDetialRow.Row.Item(3) + 1
                    'DetailsAcountingDataGridView.Update()
                    CalcCostEng(2, DetailsAcountingDataGridView.CurrentRow.Index)
                    'DetailsAcountingBindingSource.EndEdit()
                    DetailsAcountingBindingSource.MoveNext()
                ElseIf MyRow.Row.Item(0) <> ClassIDs.Joind And MyRow.Row.Item(0) <> ClassIDs.Identity Then
                    If y = 0 Then DetailsAcountingBindingSource.AddNew()
                    MyDetialRow = DetailsAcountingBindingSource.Current
                    If y = 0 Then MyDetialRow.Row.Item(2) = MyRow.Row.Item(0).ToString
                    MyDetialRow.Row.Item(3) = MyDetialRow.Row.Item(3)  'MyDetialRow.Row.Item(2) + 1
                    'DetailsAcountingDataGridView.Update()
                    CalcCostEng(2, DetailsAcountingDataGridView.CurrentRow.Index)
                    'DetailsAcountingBindingSource.EndEdit()
                    DetailsAcountingBindingSource.MoveNext()
                End If
                DetailsAcountingDataGridView.Update()

                ClassesBindingSource.MoveNext()
            Next
            ClassesBindingSource.RemoveFilter()
            ClassesBindingSource.MoveFirst()
        Next
        Cdeathy = 0
        PlusOfDeath = 0
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Not IsNothing(DetailsAcountingBindingSource.Current) Then
            DetailsAcountingBindingSource.RemoveCurrent()
        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If Not AcountStatusTextBox.Text.Equals(EngMode.AcountCached) Then
            If Not IsNothing(AcountingBindingSource.Current) Then
                If MessageBox.Show("الوصل الحالي قيد الإنتظار في الصندوق" & Chr(13) & "هل تريد حذف الوصل الحالي ", "تحذير", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2, MessageBoxOptions.RtlReading) = Windows.Forms.DialogResult.Yes Then
                    AcountingBindingSource.CancelEdit()
                    'AcountingBindingSource.ResetBindings(False)
                End If
            Else
                MsgBox("لا يوجد وصل نشط لحذفة")
            End If
        Else
            MessageBox.Show("لا يمكن حذف وصل مقبوض من الصندوق" & Chr(13) & "ييمكن إلغاء الوصل الحالي بسماحيات دخول المدير فقط" & Chr(13) & "لمزيد من المعلومات راجع مسؤول النظام", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        End If
    End Sub

    Private Sub TxtStatus_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not Me.Created Then Exit Sub
        If AcountStatusTextBox.Text = EngMode.AcountCached Then
            BtnAddAll.Enabled = False
            Button1.Enabled = False
            Button2.Enabled = False
            BtnSave.Enabled = False
            DetailsAcountingDataGridView.Enabled = False
            DetailsAcountingDataGridView.ReadOnly = True
            DetailsAcountingDataGridView.EditMode = 4
        Else
            BtnAddAll.Enabled = True
            Button1.Enabled = True
            Button2.Enabled = True
            BtnSave.Enabled = True
            DetailsAcountingDataGridView.Enabled = True
            DetailsAcountingDataGridView.ReadOnly = False
            DetailsAcountingDataGridView.EditMode = 2
        End If
        If AcountStatusTextBox.Text = EngMode.AcountInWait Then
            Button3.Enabled = True
        Else
            Button3.Enabled = False
        End If
        TotalBayTextBox.Enabled = False
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If Button3.Text = "تقسيط" Then
            DetailsAcountingDataGridView.Columns("RealCost").Visible = True
            DetailsAcountingDataGridView.Columns("RealCost").Frozen = True
            DetailsAcountingDataGridView.Columns("RestCost").Visible = True
            DetailsAcountingDataGridView.Columns("RestCost").Frozen = True
            DetailsAcountingDataGridView.Enabled = True
            DetailsAcountingDataGridView.ReadOnly = False
            DetailsAcountingDataGridView.EditMode = 2
            DetailsAcountingDataGridView.AllowUserToAddRows = False
            TotalBayTextBox.Enabled = True
            Button3.Text = "نقدي"
            IsRest = True
            Label14.Text = "طريقة الدفع تقسيط"
        ElseIf Button3.Text = "نقدي" Then
            DetailsAcountingDataGridView.Columns("RealCost").Visible = False
            DetailsAcountingDataGridView.Columns("RestCost").Visible = False
            TotalBayTextBox.Enabled = False
            Button3.Text = "تقسيط"
            IsRest = False
            Label14.Text = "طريقة الدفع نقدي"
            DetailsAcountingDataGridView.AllowUserToAddRows = True
        End If
    End Sub

    Private Sub TextBox1_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyUp
        If e.KeyCode.Equals(Keys.Enter) Then
            FillInfo()
        End If
        If AcountStatusTextBox.Text = EngMode.AcountCached Then
            DetailsAcountingDataGridView.Enabled = False
            Button3.Enabled = False
        Else
            DetailsAcountingDataGridView.Enabled = True
            Button3.Enabled = True
        End If
        If Me.AcountingBindingSource.Count > 0 Then
            CheckBox1.Enabled = True
        Else
            CheckBox1.Enabled = False
        End If

    End Sub

    Sub FillInfo()
        Dim stat As Integer = -1
        Dim Fullname As String = String.Empty
        Dim searchIndex As Integer
        Dim Cnt As Integer = 0
        EngLastYear = 0
        If IsNumeric(TextBox1.Text) Then
            stat = CInt(TextBox1.Text)
            Fullname = String.Empty
        Else
            stat = -1
            Fullname = TextBox1.Text
        End If
        Label10.Text = ""
        'Me.AcountingBindingSource.CancelEdit()
        Cnt = AdapterFine.GetDataByIdANDName(stat, Fullname).Rows.Count
        If Cnt > 0 Then
            On Error Resume Next
            'If TotalBayTextBox.Text = 0 Then
            '    AcountingBindingSource.RemoveCurrent()
            'End If
            With AdapterFine.GetDataByIdANDName(stat, Fullname).Item(0)
                TextBox8.Text = IIf(.EngStatus = EngMode.InProgress, "جديد", "مشترك")
                TextBox2.Text = .EngID
                TextBox3.Text = .FullName
                TextBox4.Text = .MotherName
                TextBox5.Text = .DateOFbirthday
                TextBox6.Text = .Certificate
                TextBox7.Text = .DateOfgraduation.Date.Year
                TextBox10.Text = .DateOFjointly.Date.Year
                MyEngID = .EngID
                EngCheck.IsEngCancel = .EngCancel
                EngCheck.IsEngDeath = .EngDeath
                EngCheck.IsEngMove = .EngMove
                EngCheck.IsEngRetail = .EngRetail
                EngCheck.IsForgin = IIf(.National = "سوري", False, True)
                EngYearBirthday = Year(.DateOFbirthday)
                EngYearGrat = Year(.DateOfgraduation)
                EngAge = CurrentYear - EngYearBirthday
                EngHasRecord = IIf(.EngStatus = EngMode.InProgress, True, False) ' تسجيل أول مرة أم لا
                EngYearJoind = Year(.DateOFjointly) 'سنة التسجيل
                If (EngYearJoind - EngYearBirthday) >= 50 Then 'هل المهندس مستفيد من صنوق النقابة
                    IsBenefit = False 'غير مستفيد
                    Label10.Text = "عمر المهندس فوق الخمين عاما عند التسجيل"
                Else
                    IsBenefit = True 'مستفيد
                    Label10.Text = Label10.Text
                End If
                Panel3.Enabled = True
                'أخر عام تم دفع الإشتراك المستحق
                Dim Tj1 As Boolean = True
                Dim Tj2 As Boolean = True
                Dim TableYear As New AcountingDataSetTableAdapters.AcountingTableAdapter
                Tj1 = IsDBNull(TableYear.QryLastJointly(EngMode.AcountCached, MyEngID).Date)
                Tj2 = IsDBNull(TableYear.QryLastJointly(EngMode.AcountInWait, MyEngID).Date)
                If Tj1 And Tj2 Then
                    EngLastYear = 0
                    If TextBox8.Text = "جديد" Then EngLastYear = Now.Year
                ElseIf Not Tj1 Then
                    EngLastYear = Year(TableYear.QryLastJointly(EngMode.AcountCached, MyEngID).Date)
                ElseIf Not Tj2 Then
                    EngLastYear = Year(TableYear.QryLastJointly(EngMode.AcountInWait, MyEngID).Date)
                End If
                'التحقق من أن المهندس غير متأخر في دفع الرسم المستحق
                If EngLastYear = 0 Then
                    Dim last As String = 20000
                    Dim msgstr As String = "لم يكشف البرنامج عن آخر سنة إشتراك مسددة من قبل المهندس" & " " & Chr(13) & "إذا كان المهندس مشترك وليس مسجل في البرنامج قم بإدخال أخر سنة اشتراك مسددة"

                    Do Until ((CInt(last) <= Now.Year) And (CInt(last) >= 1980))
                        TextBox3.Focus()
                        last = InputBox(msgstr, "تنبية", Year(Now).ToString)

                        If Not IsNumeric(last) Then
                            last = 20000
                        Else
                            EngLastYear = CInt(last)
                        End If
                    Loop
                End If

                If (CurrentYear - EngLastYear) = 1 Then
                    If LastMonth < CurrentMonth Then
                        IsLate = True
                        MonthLate = CurrentMonth - LastMonth
                        NumOfYearLate = 1
                    Else
                        IsLate = False
                        MonthLate = 0
                        Label10.Text = Label10.Text
                        NumOfYearLate = 0
                    End If
                ElseIf (CurrentYear - EngLastYear) > 1 Then
                    IsLate = True
                    Dim dt1 As Date = AcountingTableAdapter.QryLastJointly(EngMode.AcountCached, MyEngID).Value
                    MonthLate = DateDiff(DateInterval.Month, dt1, Now.Date)
                    Label10.Text = Label10.Text & " --- " & "متأخر عن دفع الإشتراك"
                    If LastMonth < CurrentMonth Then
                        NumOfYearLate = CurrentYear - EngLastYear
                    Else
                        NumOfYearLate = (CurrentYear - EngLastYear) - 1
                    End If
                End If

                If (Tj2 = False) And (Tj1 = True) Then
                    Label10.Text = "لم يكشف البرنامج عن أي اشتراك مدفوع" & Chr(13) & " يوجد وصل قيد الإنتظار لسنة الإستحقاق:" & Chr(13) & EngLastYear.ToString
                ElseIf TextBox8.Text = "جديد" Then
                    Label10.Text = "إنتساب جديد"
                Else
                    Label10.Text = "آخر اشتراك مدفوع عام" & " : " & IIf(EngLastYear = 0, "غير معروفة", EngLastYear.ToString)
                End If
            End With

            If AcountIDTextBox.Text <> String.Empty Then
                If EngLastYear = Now.Year Then
                    Label13.Text = "رسوم الإشتراك مدفوعة"
                    Label13.BackColor = Color.GreenYellow
                    Label13.ForeColor = Color.Black
                Else
                    Label13.Text = "رسوم الإشتراك مستحقة الدفع"
                    Label13.BackColor = Color.OrangeRed
                    Label13.ForeColor = Color.White
                End If
            Else
                Label13.Text = "  "
                Label13.BackColor = Color.Ivory
            End If
            If EngCheck.IsEngMove Or EngCheck.IsEngDeath Or EngCheck.IsEngCancel Then
                Panel3.Enabled = False
                CheckBox1.Enabled = False
                Panel4.Enabled = False
                Panel5.Enabled = False
                BtnSave.Enabled = False
                Label13.Text = ""
                Label10.TextAlign = ContentAlignment.MiddleLeft
                'Label10.Font = New Font(FontFamily.GenericSansSerif, emSize:=9, style:=FontStyle.Bold)
                Label10.Text = "في الحالات التالية:" & Chr(13) & "الوفاة والنقل والإلغاء" & Chr(13) & "يكون سجل المهندس مغلق"
            Else
                Panel3.Enabled = True
                CheckBox1.Enabled = True
                Panel4.Enabled = True
                Panel5.Enabled = True
                BtnSave.Enabled = True
                Label10.TextAlign = ContentAlignment.MiddleCenter
            End If
            If EngCheck.IsEngRetail Then
                LinkLabel1.Text = "المهندس متقاعد"
            Else
                LinkLabel1.Text = ""
            End If
            If EngCheck.IsForgin Then
                LinkLabel1.Text = LinkLabel1.Text & " " & "أجنبي"
            End If
            If LinkLabel1.Text.Length <= 0 Then
                LinkLabel1.Visible = False
            Else
                LinkLabel1.Visible = True
            End If
            If Label10.Text.Length <= 0 Then
                Label10.Visible = False
            Else
                Label10.Visible = True
            End If
            If Year(TextBox5.Text) = 1900 Then
                TextBox5.BackColor = Color.Red
                Panel3.Enabled = False
            Else
                TextBox5.BackColor = Color.Ivory
                Panel3.Enabled = True
            End If
            If TextBox7.Text = 1925 Then
                TextBox7.BackColor = Color.Red
                Panel3.Enabled = False
            Else
                TextBox7.BackColor = Color.Ivory
                Panel3.Enabled = True
            End If
            If TextBox10.Text = 1925 Then
                TextBox10.BackColor = Color.Red
                Panel3.Enabled = False
            Else
                TextBox10.BackColor = Color.Ivory
                Panel3.Enabled = True
            End If
        Else
            TextBox8.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
            TextBox4.Text = ""
            TextBox5.Text = ""
            TextBox6.Text = ""
            TextBox7.Text = ""
            TextBox10.Text = ""
            MyEngID = -1
            Panel3.Enabled = False
        End If
        stat = IIf(IsNumeric(TextBox2.Text), TextBox2.Text, -1)
        'searchIndex = AcountingBindingSource.Find("EngID", stat)
        ' EngHasRecord = IIf(searchIndex > 0, True, False) ' تسجيل أول مرة أم لا
        'Me.AcountingTableAdapter.Fill(Me.AcountingDataSet.Acounting)
        Me.AcountingBindingSource.CancelEdit()
        ' Me.AcountingBindingSource.RemoveFilter()
        Me.AcountingBindingSource.Filter = "EngID=" & stat


    End Sub
    Public EngCaeID As Integer
    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        EngCaeID = MyEngID
        FrmMain.Button6.PerformClick()
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        Me.Acounting1TableAdapter.Fill(Me.AcountingDataSet.Acounting1, MyEngID)
        If Me.Acounting1BindingSource.Count > 0 Then
            CheckSplit = CheckBox1.Checked
            IsRest = CheckBox1.Checked
            Panel6.Visible = CheckBox1.Checked
            Panel6.Dock = DockStyle.Bottom
            Panel6.Height = DetailsAcountingDataGridView.Height
            If ListBox1.Items.Count = 0 Then Exit Sub
            Dim id As String = ListBox1.Text
            If id = String.Empty Then Exit Sub
            'AcountingBindingSource.Filter = "RestAcountID='" & id & "' and RestAcountStat=true"
            AcountingBindingSource.Filter = "AcountID=" & id & "" '"RestAcountID='" & id & "' and RestAcountStat=true and AcountModified=max(AcountModified)"
            DetailsAcountingDataGridView.Columns("restcost").Visible = True
            DetailsAcountingDataGridView.Columns("realcost").Visible = True
            If CheckSplit Then
                BtnAdd.Text = "أمر قبض قسط"
                Button3.Enabled = False
                Label14.Visible = False
            Else
                BtnAdd.Text = "أمر قبض"
                Button3.Enabled = True
                Label14.Visible = True
                FillInfo()

            End If
            If CheckSplit Then
                If AcountStatusTextBox.Text = EngMode.AcountInWait Then
                    BtnAdd.Enabled = False
                    Button2.Enabled = False
                Else
                    BtnAdd.Enabled = True
                    Button2.Enabled = True
                End If
            End If

            ListBox1.SelectedIndex = 0
        Else
            CheckBox1.CheckState = False
            MsgBox("لا يوجد أقساط مترتبة على المهندس الحالي")
        End If

    End Sub

    Private Sub DetailsAcountingDataGridView_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DetailsAcountingDataGridView.Resize
        Panel6.Height = DetailsAcountingDataGridView.Height
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        If Not CheckSplit Then Exit Sub
        Dim id As String = ListBox1.Text
        If id = String.Empty Then Exit Sub
        'AcountingBindingSource.Filter = "RestAcountID='" & id & "' and RestAcountStat=true"

        AcountingBindingSource.Filter = "AcountID=" & id & ""  '"RestAcountID='" & id & "' and RestAcountStat=true and AcountModified=max(AcountModified)"
        If CheckSplit Then
            If AcountStatusTextBox.Text = EngMode.AcountInWait Then
                BtnAdd.Enabled = False
                Button2.Enabled = False
            Else
                BtnAdd.Enabled = True
                Button2.Enabled = True
            End If
        End If
    End Sub

    Private Sub TotalRestTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not Me.Created Then Exit Sub
        If IsNumeric(TotalRestTextBox.Text) Then
            If CInt(TotalRestTextBox.Text) > 0 Then
                DetailsAcountingDataGridView.Columns("restcost").Visible = True
                DetailsAcountingDataGridView.Columns("realcost").Visible = True
            Else
                DetailsAcountingDataGridView.Columns("restcost").Visible = False
                DetailsAcountingDataGridView.Columns("realcost").Visible = False
            End If
        End If
    End Sub

    Private Sub EndAcountDateDateTimePicker_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

        If Me.ShowWithoutActivation Then
            If EndAcountDateDateTimePicker.Value < AcountDateDateTimePicker.Value Then
                MsgBox("يجب أن تكون التاريخ أكبر أو يساوي تاريخ الإستحقاق")
                EndAcountDateDateTimePicker.Value = AcountDateDateTimePicker.Value
            End If
        End If
    End Sub

    Private Sub FrmAcount_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        FrmMain.Button1.ForeColor = Color.Black
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        'Select Case ComboBox1.Text
        '    Case "في الصندوق"
        '        Button4.Visible = False
        '    Case "اشعار/شيك مصرفي"
        '        If CheckBox2.Checked Then
        '            Button4.Visible = True
        '        Else
        '            Button4.Visible = False
        '        End If

        'End Select
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Dim f As New FrmCheckRpt
        f.TextBox1.Text = AcountIDTextBox.Text
        f.ShowDialog()
    End Sub

    Private Sub CheckBox2_CheckStateChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox2.CheckStateChanged
        If CheckBox2.Checked Then
            Button4.Visible = True
        Else
            Button4.Visible = False
        End If
    End Sub

End Class