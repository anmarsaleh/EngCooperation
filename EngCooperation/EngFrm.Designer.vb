<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EngFrm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim EngIDLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EngFrm))
        Dim FnameLabel As System.Windows.Forms.Label
        Dim MnameLabel As System.Windows.Forms.Label
        Dim LnameLabel As System.Windows.Forms.Label
        Dim FullNameLabel As System.Windows.Forms.Label
        Dim EntryLabel As System.Windows.Forms.Label
        Dim IntegrityLabel As System.Windows.Forms.Label
        Dim CertificateLabel As System.Windows.Forms.Label
        Dim DateOFbirthdayLabel As System.Windows.Forms.Label
        Dim DateOfgraduationLabel As System.Windows.Forms.Label
        Dim DateOFjointlyLabel As System.Windows.Forms.Label
        Dim CellPhoneLabel As System.Windows.Forms.Label
        Dim EmailEnLabel As System.Windows.Forms.Label
        Dim PoBoxLabel As System.Windows.Forms.Label
        Dim FaxLabel As System.Windows.Forms.Label
        Dim GenderLabel1 As System.Windows.Forms.Label
        Dim IdCardLabel As System.Windows.Forms.Label
        Dim MotherNameLabel As System.Windows.Forms.Label
        Dim BirthdayOfLocLabel As System.Windows.Forms.Label
        Dim HomeAddressLabel As System.Windows.Forms.Label
        Dim WorkAddressLabel As System.Windows.Forms.Label
        Dim HomePhoneLabel As System.Windows.Forms.Label
        Dim WorkPhoneLabel As System.Windows.Forms.Label
        Dim NationalLabel As System.Windows.Forms.Label
        Dim EngRemarksLabel As System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.TxtSearch = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.CheckBox6 = New System.Windows.Forms.CheckBox()
        Me.EngCVBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EngDBDataSet = New EngCooperation.EngDBDataSet()
        Me.CheckBox5 = New System.Windows.Forms.CheckBox()
        Me.CheckBox4 = New System.Windows.Forms.CheckBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.EngRemarksTextBox = New System.Windows.Forms.TextBox()
        Me.NationalComboBox = New System.Windows.Forms.ComboBox()
        Me.GenderComboBox = New System.Windows.Forms.ComboBox()
        Me.IdCardTextBox = New System.Windows.Forms.TextBox()
        Me.MotherNameTextBox = New System.Windows.Forms.TextBox()
        Me.BirthdayOfLocTextBox = New System.Windows.Forms.TextBox()
        Me.HomeAddressTextBox = New System.Windows.Forms.TextBox()
        Me.WorkAddressTextBox = New System.Windows.Forms.TextBox()
        Me.HomePhoneTextBox = New System.Windows.Forms.TextBox()
        Me.WorkPhoneTextBox = New System.Windows.Forms.TextBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.PanelMove = New System.Windows.Forms.Panel()
        Me.LblTotal = New System.Windows.Forms.Label()
        Me.LblCurrent = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnLast = New System.Windows.Forms.Button()
        Me.BtnPrev = New System.Windows.Forms.Button()
        Me.BtnNext = New System.Windows.Forms.Button()
        Me.BtnFirst = New System.Windows.Forms.Button()
        Me.EngStatusTextBox = New System.Windows.Forms.TextBox()
        Me.CVModifiedDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.BtnLoadImage = New System.Windows.Forms.Button()
        Me.EngIDTextBox = New System.Windows.Forms.TextBox()
        Me.FnameTextBox = New System.Windows.Forms.TextBox()
        Me.MnameTextBox = New System.Windows.Forms.TextBox()
        Me.LnameTextBox = New System.Windows.Forms.TextBox()
        Me.FullNameLabel1 = New System.Windows.Forms.Label()
        Me.EntryTextBox = New System.Windows.Forms.TextBox()
        Me.IntegrityTextBox = New System.Windows.Forms.TextBox()
        Me.CertificateTextBox = New System.Windows.Forms.TextBox()
        Me.DateOFbirthdayDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.DateOfgraduationDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.DateOFjointlyDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.EngBitmapPictureBox = New System.Windows.Forms.PictureBox()
        Me.CellPhoneTextBox = New System.Windows.Forms.TextBox()
        Me.EmailEnTextBox = New System.Windows.Forms.TextBox()
        Me.PoBoxTextBox = New System.Windows.Forms.TextBox()
        Me.FaxTextBox = New System.Windows.Forms.TextBox()
        Me.EngCVTableAdapter = New EngCooperation.EngDBDataSetTableAdapters.EngCVTableAdapter()
        Me.TableAdapterManager = New EngCooperation.EngDBDataSetTableAdapters.TableAdapterManager()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        EngIDLabel = New System.Windows.Forms.Label()
        FnameLabel = New System.Windows.Forms.Label()
        MnameLabel = New System.Windows.Forms.Label()
        LnameLabel = New System.Windows.Forms.Label()
        FullNameLabel = New System.Windows.Forms.Label()
        EntryLabel = New System.Windows.Forms.Label()
        IntegrityLabel = New System.Windows.Forms.Label()
        CertificateLabel = New System.Windows.Forms.Label()
        DateOFbirthdayLabel = New System.Windows.Forms.Label()
        DateOfgraduationLabel = New System.Windows.Forms.Label()
        DateOFjointlyLabel = New System.Windows.Forms.Label()
        CellPhoneLabel = New System.Windows.Forms.Label()
        EmailEnLabel = New System.Windows.Forms.Label()
        PoBoxLabel = New System.Windows.Forms.Label()
        FaxLabel = New System.Windows.Forms.Label()
        GenderLabel1 = New System.Windows.Forms.Label()
        IdCardLabel = New System.Windows.Forms.Label()
        MotherNameLabel = New System.Windows.Forms.Label()
        BirthdayOfLocLabel = New System.Windows.Forms.Label()
        HomeAddressLabel = New System.Windows.Forms.Label()
        WorkAddressLabel = New System.Windows.Forms.Label()
        HomePhoneLabel = New System.Windows.Forms.Label()
        WorkPhoneLabel = New System.Windows.Forms.Label()
        NationalLabel = New System.Windows.Forms.Label()
        EngRemarksLabel = New System.Windows.Forms.Label()
        Me.panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.EngCVBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EngDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelMove.SuspendLayout()
        CType(Me.EngBitmapPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'EngIDLabel
        '
        resources.ApplyResources(EngIDLabel, "EngIDLabel")
        EngIDLabel.Name = "EngIDLabel"
        '
        'FnameLabel
        '
        resources.ApplyResources(FnameLabel, "FnameLabel")
        FnameLabel.Name = "FnameLabel"
        '
        'MnameLabel
        '
        resources.ApplyResources(MnameLabel, "MnameLabel")
        MnameLabel.Name = "MnameLabel"
        '
        'LnameLabel
        '
        resources.ApplyResources(LnameLabel, "LnameLabel")
        LnameLabel.Name = "LnameLabel"
        '
        'FullNameLabel
        '
        resources.ApplyResources(FullNameLabel, "FullNameLabel")
        FullNameLabel.Name = "FullNameLabel"
        '
        'EntryLabel
        '
        resources.ApplyResources(EntryLabel, "EntryLabel")
        EntryLabel.Name = "EntryLabel"
        '
        'IntegrityLabel
        '
        resources.ApplyResources(IntegrityLabel, "IntegrityLabel")
        IntegrityLabel.Name = "IntegrityLabel"
        '
        'CertificateLabel
        '
        resources.ApplyResources(CertificateLabel, "CertificateLabel")
        CertificateLabel.Name = "CertificateLabel"
        '
        'DateOFbirthdayLabel
        '
        resources.ApplyResources(DateOFbirthdayLabel, "DateOFbirthdayLabel")
        DateOFbirthdayLabel.Name = "DateOFbirthdayLabel"
        '
        'DateOfgraduationLabel
        '
        resources.ApplyResources(DateOfgraduationLabel, "DateOfgraduationLabel")
        DateOfgraduationLabel.Name = "DateOfgraduationLabel"
        '
        'DateOFjointlyLabel
        '
        resources.ApplyResources(DateOFjointlyLabel, "DateOFjointlyLabel")
        DateOFjointlyLabel.Name = "DateOFjointlyLabel"
        '
        'CellPhoneLabel
        '
        resources.ApplyResources(CellPhoneLabel, "CellPhoneLabel")
        CellPhoneLabel.Name = "CellPhoneLabel"
        '
        'EmailEnLabel
        '
        resources.ApplyResources(EmailEnLabel, "EmailEnLabel")
        EmailEnLabel.Name = "EmailEnLabel"
        '
        'PoBoxLabel
        '
        resources.ApplyResources(PoBoxLabel, "PoBoxLabel")
        PoBoxLabel.Name = "PoBoxLabel"
        '
        'FaxLabel
        '
        resources.ApplyResources(FaxLabel, "FaxLabel")
        FaxLabel.Name = "FaxLabel"
        '
        'GenderLabel1
        '
        resources.ApplyResources(GenderLabel1, "GenderLabel1")
        GenderLabel1.Name = "GenderLabel1"
        '
        'IdCardLabel
        '
        resources.ApplyResources(IdCardLabel, "IdCardLabel")
        IdCardLabel.Name = "IdCardLabel"
        '
        'MotherNameLabel
        '
        resources.ApplyResources(MotherNameLabel, "MotherNameLabel")
        MotherNameLabel.Name = "MotherNameLabel"
        '
        'BirthdayOfLocLabel
        '
        resources.ApplyResources(BirthdayOfLocLabel, "BirthdayOfLocLabel")
        BirthdayOfLocLabel.Name = "BirthdayOfLocLabel"
        '
        'HomeAddressLabel
        '
        resources.ApplyResources(HomeAddressLabel, "HomeAddressLabel")
        HomeAddressLabel.Name = "HomeAddressLabel"
        '
        'WorkAddressLabel
        '
        resources.ApplyResources(WorkAddressLabel, "WorkAddressLabel")
        WorkAddressLabel.Name = "WorkAddressLabel"
        '
        'HomePhoneLabel
        '
        resources.ApplyResources(HomePhoneLabel, "HomePhoneLabel")
        HomePhoneLabel.Name = "HomePhoneLabel"
        '
        'WorkPhoneLabel
        '
        resources.ApplyResources(WorkPhoneLabel, "WorkPhoneLabel")
        WorkPhoneLabel.Name = "WorkPhoneLabel"
        '
        'NationalLabel
        '
        resources.ApplyResources(NationalLabel, "NationalLabel")
        NationalLabel.Name = "NationalLabel"
        '
        'EngRemarksLabel
        '
        resources.ApplyResources(EngRemarksLabel, "EngRemarksLabel")
        EngRemarksLabel.Name = "EngRemarksLabel"
        '
        'Button1
        '
        resources.ApplyResources(Me.Button1, "Button1")
        Me.Button1.Name = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'panel1
        '
        Me.panel1.Controls.Add(Me.Button4)
        Me.panel1.Controls.Add(Me.Button1)
        resources.ApplyResources(Me.panel1, "panel1")
        Me.panel1.Name = "panel1"
        '
        'Button4
        '
        resources.ApplyResources(Me.Button4, "Button4")
        Me.Button4.Name = "Button4"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel2.Controls.Add(Me.Button7)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.Panel5)
        resources.ApplyResources(Me.Panel2, "Panel2")
        Me.Panel2.Name = "Panel2"
        '
        'Button7
        '
        resources.ApplyResources(Me.Button7, "Button7")
        Me.Button7.Name = "Button7"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Button5)
        Me.Panel4.Controls.Add(Me.TxtSearch)
        Me.Panel4.Controls.Add(Me.Label1)
        resources.ApplyResources(Me.Panel4, "Panel4")
        Me.Panel4.Name = "Panel4"
        '
        'Button5
        '
        resources.ApplyResources(Me.Button5, "Button5")
        Me.Button5.Name = "Button5"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'TxtSearch
        '
        Me.TxtSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TxtSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        resources.ApplyResources(Me.TxtSearch, "TxtSearch")
        Me.TxtSearch.Name = "TxtSearch"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.Button3)
        Me.Panel5.Controls.Add(Me.Button2)
        resources.ApplyResources(Me.Panel5, "Panel5")
        Me.Panel5.Name = "Panel5"
        '
        'Button3
        '
        resources.ApplyResources(Me.Button3, "Button3")
        Me.Button3.Name = "Button3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        resources.ApplyResources(Me.Button2, "Button2")
        Me.Button2.Name = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.CheckBox2)
        Me.Panel3.Controls.Add(Me.Panel6)
        Me.Panel3.Controls.Add(NationalLabel)
        Me.Panel3.Controls.Add(Me.NationalComboBox)
        Me.Panel3.Controls.Add(GenderLabel1)
        Me.Panel3.Controls.Add(Me.GenderComboBox)
        Me.Panel3.Controls.Add(IdCardLabel)
        Me.Panel3.Controls.Add(Me.IdCardTextBox)
        Me.Panel3.Controls.Add(MotherNameLabel)
        Me.Panel3.Controls.Add(Me.MotherNameTextBox)
        Me.Panel3.Controls.Add(BirthdayOfLocLabel)
        Me.Panel3.Controls.Add(Me.BirthdayOfLocTextBox)
        Me.Panel3.Controls.Add(HomeAddressLabel)
        Me.Panel3.Controls.Add(Me.HomeAddressTextBox)
        Me.Panel3.Controls.Add(WorkAddressLabel)
        Me.Panel3.Controls.Add(Me.WorkAddressTextBox)
        Me.Panel3.Controls.Add(HomePhoneLabel)
        Me.Panel3.Controls.Add(Me.HomePhoneTextBox)
        Me.Panel3.Controls.Add(WorkPhoneLabel)
        Me.Panel3.Controls.Add(Me.WorkPhoneTextBox)
        Me.Panel3.Controls.Add(Me.CheckBox1)
        Me.Panel3.Controls.Add(Me.Button6)
        Me.Panel3.Controls.Add(Me.PanelMove)
        Me.Panel3.Controls.Add(Me.EngStatusTextBox)
        Me.Panel3.Controls.Add(Me.CVModifiedDateTimePicker)
        Me.Panel3.Controls.Add(Me.BtnLoadImage)
        Me.Panel3.Controls.Add(EngIDLabel)
        Me.Panel3.Controls.Add(Me.EngIDTextBox)
        Me.Panel3.Controls.Add(FnameLabel)
        Me.Panel3.Controls.Add(Me.FnameTextBox)
        Me.Panel3.Controls.Add(MnameLabel)
        Me.Panel3.Controls.Add(Me.MnameTextBox)
        Me.Panel3.Controls.Add(LnameLabel)
        Me.Panel3.Controls.Add(Me.LnameTextBox)
        Me.Panel3.Controls.Add(FullNameLabel)
        Me.Panel3.Controls.Add(Me.FullNameLabel1)
        Me.Panel3.Controls.Add(EntryLabel)
        Me.Panel3.Controls.Add(Me.EntryTextBox)
        Me.Panel3.Controls.Add(IntegrityLabel)
        Me.Panel3.Controls.Add(Me.IntegrityTextBox)
        Me.Panel3.Controls.Add(CertificateLabel)
        Me.Panel3.Controls.Add(Me.CertificateTextBox)
        Me.Panel3.Controls.Add(DateOFbirthdayLabel)
        Me.Panel3.Controls.Add(Me.DateOFbirthdayDateTimePicker)
        Me.Panel3.Controls.Add(DateOfgraduationLabel)
        Me.Panel3.Controls.Add(Me.DateOfgraduationDateTimePicker)
        Me.Panel3.Controls.Add(DateOFjointlyLabel)
        Me.Panel3.Controls.Add(Me.DateOFjointlyDateTimePicker)
        Me.Panel3.Controls.Add(Me.EngBitmapPictureBox)
        Me.Panel3.Controls.Add(CellPhoneLabel)
        Me.Panel3.Controls.Add(Me.CellPhoneTextBox)
        Me.Panel3.Controls.Add(EmailEnLabel)
        Me.Panel3.Controls.Add(Me.EmailEnTextBox)
        Me.Panel3.Controls.Add(PoBoxLabel)
        Me.Panel3.Controls.Add(Me.PoBoxTextBox)
        Me.Panel3.Controls.Add(FaxLabel)
        Me.Panel3.Controls.Add(Me.FaxTextBox)
        resources.ApplyResources(Me.Panel3, "Panel3")
        Me.Panel3.Name = "Panel3"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.Info
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.Name = "Label4"
        '
        'CheckBox2
        '
        resources.ApplyResources(Me.CheckBox2, "CheckBox2")
        Me.CheckBox2.Checked = True
        Me.CheckBox2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'Panel6
        '
        resources.ApplyResources(Me.Panel6, "Panel6")
        Me.Panel6.Controls.Add(Me.CheckBox6)
        Me.Panel6.Controls.Add(Me.CheckBox5)
        Me.Panel6.Controls.Add(Me.CheckBox4)
        Me.Panel6.Controls.Add(Me.CheckBox3)
        Me.Panel6.Controls.Add(EngRemarksLabel)
        Me.Panel6.Controls.Add(Me.EngRemarksTextBox)
        Me.Panel6.Name = "Panel6"
        '
        'CheckBox6
        '
        resources.ApplyResources(Me.CheckBox6, "CheckBox6")
        Me.CheckBox6.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.EngCVBindingSource, "EngCancel", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "False"))
        Me.CheckBox6.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.EngCVBindingSource, "EngCancel", True))
        Me.CheckBox6.Name = "CheckBox6"
        Me.CheckBox6.UseVisualStyleBackColor = True
        '
        'EngCVBindingSource
        '
        Me.EngCVBindingSource.DataMember = "EngCV"
        Me.EngCVBindingSource.DataSource = Me.EngDBDataSet
        '
        'EngDBDataSet
        '
        Me.EngDBDataSet.DataSetName = "EngDBDataSet"
        Me.EngDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CheckBox5
        '
        resources.ApplyResources(Me.CheckBox5, "CheckBox5")
        Me.CheckBox5.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.EngCVBindingSource, "EngMove", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "False"))
        Me.CheckBox5.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.EngCVBindingSource, "EngMove", True))
        Me.CheckBox5.Name = "CheckBox5"
        Me.CheckBox5.UseVisualStyleBackColor = True
        '
        'CheckBox4
        '
        resources.ApplyResources(Me.CheckBox4, "CheckBox4")
        Me.CheckBox4.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.EngCVBindingSource, "EngDeath", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "false"))
        Me.CheckBox4.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.EngCVBindingSource, "EngDeath", True))
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        resources.ApplyResources(Me.CheckBox3, "CheckBox3")
        Me.CheckBox3.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.EngCVBindingSource, "EngRetail", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "false"))
        Me.CheckBox3.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.EngCVBindingSource, "EngRetail", True))
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'EngRemarksTextBox
        '
        Me.EngRemarksTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EngCVBindingSource, "EngRemarks", True))
        resources.ApplyResources(Me.EngRemarksTextBox, "EngRemarksTextBox")
        Me.EngRemarksTextBox.Name = "EngRemarksTextBox"
        '
        'NationalComboBox
        '
        Me.NationalComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EngCVBindingSource, "National", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "سوري"))
        resources.ApplyResources(Me.NationalComboBox, "NationalComboBox")
        Me.NationalComboBox.FormattingEnabled = True
        Me.NationalComboBox.Name = "NationalComboBox"
        '
        'GenderComboBox
        '
        Me.GenderComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.GenderComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.GenderComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EngCVBindingSource, "Gender", True))
        Me.GenderComboBox.FormattingEnabled = True
        Me.GenderComboBox.Items.AddRange(New Object() {resources.GetString("GenderComboBox.Items"), resources.GetString("GenderComboBox.Items1")})
        resources.ApplyResources(Me.GenderComboBox, "GenderComboBox")
        Me.GenderComboBox.Name = "GenderComboBox"
        '
        'IdCardTextBox
        '
        Me.IdCardTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EngCVBindingSource, "IdCard", True))
        resources.ApplyResources(Me.IdCardTextBox, "IdCardTextBox")
        Me.IdCardTextBox.Name = "IdCardTextBox"
        '
        'MotherNameTextBox
        '
        Me.MotherNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EngCVBindingSource, "MotherName", True))
        resources.ApplyResources(Me.MotherNameTextBox, "MotherNameTextBox")
        Me.MotherNameTextBox.Name = "MotherNameTextBox"
        '
        'BirthdayOfLocTextBox
        '
        Me.BirthdayOfLocTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EngCVBindingSource, "BirthdayOfLoc", True))
        resources.ApplyResources(Me.BirthdayOfLocTextBox, "BirthdayOfLocTextBox")
        Me.BirthdayOfLocTextBox.Name = "BirthdayOfLocTextBox"
        '
        'HomeAddressTextBox
        '
        Me.HomeAddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EngCVBindingSource, "HomeAddress", True))
        resources.ApplyResources(Me.HomeAddressTextBox, "HomeAddressTextBox")
        Me.HomeAddressTextBox.Name = "HomeAddressTextBox"
        '
        'WorkAddressTextBox
        '
        Me.WorkAddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EngCVBindingSource, "WorkAddress", True))
        resources.ApplyResources(Me.WorkAddressTextBox, "WorkAddressTextBox")
        Me.WorkAddressTextBox.Name = "WorkAddressTextBox"
        '
        'HomePhoneTextBox
        '
        Me.HomePhoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EngCVBindingSource, "HomePhone", True))
        resources.ApplyResources(Me.HomePhoneTextBox, "HomePhoneTextBox")
        Me.HomePhoneTextBox.Name = "HomePhoneTextBox"
        '
        'WorkPhoneTextBox
        '
        Me.WorkPhoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EngCVBindingSource, "WorkPhone", True))
        resources.ApplyResources(Me.WorkPhoneTextBox, "WorkPhoneTextBox")
        Me.WorkPhoneTextBox.Name = "WorkPhoneTextBox"
        '
        'CheckBox1
        '
        resources.ApplyResources(Me.CheckBox1, "CheckBox1")
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Button6
        '
        resources.ApplyResources(Me.Button6, "Button6")
        Me.Button6.Name = "Button6"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'PanelMove
        '
        Me.PanelMove.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelMove.Controls.Add(Me.LblTotal)
        Me.PanelMove.Controls.Add(Me.LblCurrent)
        Me.PanelMove.Controls.Add(Me.Label3)
        Me.PanelMove.Controls.Add(Me.Label2)
        Me.PanelMove.Controls.Add(Me.BtnLast)
        Me.PanelMove.Controls.Add(Me.BtnPrev)
        Me.PanelMove.Controls.Add(Me.BtnNext)
        Me.PanelMove.Controls.Add(Me.BtnFirst)
        resources.ApplyResources(Me.PanelMove, "PanelMove")
        Me.PanelMove.Name = "PanelMove"
        '
        'LblTotal
        '
        resources.ApplyResources(Me.LblTotal, "LblTotal")
        Me.LblTotal.Name = "LblTotal"
        '
        'LblCurrent
        '
        resources.ApplyResources(Me.LblCurrent, "LblCurrent")
        Me.LblCurrent.Name = "LblCurrent"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'BtnLast
        '
        resources.ApplyResources(Me.BtnLast, "BtnLast")
        Me.BtnLast.Name = "BtnLast"
        Me.BtnLast.UseVisualStyleBackColor = True
        '
        'BtnPrev
        '
        resources.ApplyResources(Me.BtnPrev, "BtnPrev")
        Me.BtnPrev.Name = "BtnPrev"
        Me.BtnPrev.UseVisualStyleBackColor = True
        '
        'BtnNext
        '
        resources.ApplyResources(Me.BtnNext, "BtnNext")
        Me.BtnNext.Name = "BtnNext"
        Me.BtnNext.UseVisualStyleBackColor = True
        '
        'BtnFirst
        '
        resources.ApplyResources(Me.BtnFirst, "BtnFirst")
        Me.BtnFirst.Name = "BtnFirst"
        Me.BtnFirst.UseVisualStyleBackColor = True
        '
        'EngStatusTextBox
        '
        Me.EngStatusTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EngCVBindingSource, "EngStatus", True))
        resources.ApplyResources(Me.EngStatusTextBox, "EngStatusTextBox")
        Me.EngStatusTextBox.Name = "EngStatusTextBox"
        '
        'CVModifiedDateTimePicker
        '
        Me.CVModifiedDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.EngCVBindingSource, "CVModified", True))
        resources.ApplyResources(Me.CVModifiedDateTimePicker, "CVModifiedDateTimePicker")
        Me.CVModifiedDateTimePicker.Name = "CVModifiedDateTimePicker"
        '
        'BtnLoadImage
        '
        resources.ApplyResources(Me.BtnLoadImage, "BtnLoadImage")
        Me.BtnLoadImage.Name = "BtnLoadImage"
        Me.BtnLoadImage.UseVisualStyleBackColor = True
        '
        'EngIDTextBox
        '
        Me.EngIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EngCVBindingSource, "EngID", True))
        resources.ApplyResources(Me.EngIDTextBox, "EngIDTextBox")
        Me.EngIDTextBox.Name = "EngIDTextBox"
        '
        'FnameTextBox
        '
        Me.FnameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EngCVBindingSource, "Fname", True))
        resources.ApplyResources(Me.FnameTextBox, "FnameTextBox")
        Me.FnameTextBox.Name = "FnameTextBox"
        '
        'MnameTextBox
        '
        Me.MnameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EngCVBindingSource, "Mname", True))
        resources.ApplyResources(Me.MnameTextBox, "MnameTextBox")
        Me.MnameTextBox.Name = "MnameTextBox"
        '
        'LnameTextBox
        '
        Me.LnameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EngCVBindingSource, "Lname", True))
        resources.ApplyResources(Me.LnameTextBox, "LnameTextBox")
        Me.LnameTextBox.Name = "LnameTextBox"
        '
        'FullNameLabel1
        '
        Me.FullNameLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EngCVBindingSource, "FullName", True))
        resources.ApplyResources(Me.FullNameLabel1, "FullNameLabel1")
        Me.FullNameLabel1.Name = "FullNameLabel1"
        '
        'EntryTextBox
        '
        Me.EntryTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EngCVBindingSource, "Entry", True))
        resources.ApplyResources(Me.EntryTextBox, "EntryTextBox")
        Me.EntryTextBox.Name = "EntryTextBox"
        '
        'IntegrityTextBox
        '
        Me.IntegrityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EngCVBindingSource, "integrity", True))
        resources.ApplyResources(Me.IntegrityTextBox, "IntegrityTextBox")
        Me.IntegrityTextBox.Name = "IntegrityTextBox"
        '
        'CertificateTextBox
        '
        Me.CertificateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EngCVBindingSource, "Certificate", True))
        resources.ApplyResources(Me.CertificateTextBox, "CertificateTextBox")
        Me.CertificateTextBox.Name = "CertificateTextBox"
        '
        'DateOFbirthdayDateTimePicker
        '
        Me.DateOFbirthdayDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.EngCVBindingSource, "DateOFbirthday", True))
        resources.ApplyResources(Me.DateOFbirthdayDateTimePicker, "DateOFbirthdayDateTimePicker")
        Me.DateOFbirthdayDateTimePicker.Name = "DateOFbirthdayDateTimePicker"
        '
        'DateOfgraduationDateTimePicker
        '
        Me.DateOfgraduationDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.EngCVBindingSource, "DateOfgraduation", True))
        resources.ApplyResources(Me.DateOfgraduationDateTimePicker, "DateOfgraduationDateTimePicker")
        Me.DateOfgraduationDateTimePicker.Name = "DateOfgraduationDateTimePicker"
        '
        'DateOFjointlyDateTimePicker
        '
        Me.DateOFjointlyDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.EngCVBindingSource, "DateOFjointly", True))
        resources.ApplyResources(Me.DateOFjointlyDateTimePicker, "DateOFjointlyDateTimePicker")
        Me.DateOFjointlyDateTimePicker.Name = "DateOFjointlyDateTimePicker"
        '
        'EngBitmapPictureBox
        '
        Me.EngBitmapPictureBox.BackColor = System.Drawing.SystemColors.Window
        Me.EngBitmapPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.EngBitmapPictureBox.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.EngCVBindingSource, "EngBitmap", True))
        resources.ApplyResources(Me.EngBitmapPictureBox, "EngBitmapPictureBox")
        Me.EngBitmapPictureBox.Name = "EngBitmapPictureBox"
        Me.EngBitmapPictureBox.TabStop = False
        '
        'CellPhoneTextBox
        '
        Me.CellPhoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EngCVBindingSource, "CellPhone", True))
        resources.ApplyResources(Me.CellPhoneTextBox, "CellPhoneTextBox")
        Me.CellPhoneTextBox.Name = "CellPhoneTextBox"
        '
        'EmailEnTextBox
        '
        Me.EmailEnTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EngCVBindingSource, "EmailEn", True))
        resources.ApplyResources(Me.EmailEnTextBox, "EmailEnTextBox")
        Me.EmailEnTextBox.Name = "EmailEnTextBox"
        '
        'PoBoxTextBox
        '
        Me.PoBoxTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EngCVBindingSource, "PoBox", True))
        resources.ApplyResources(Me.PoBoxTextBox, "PoBoxTextBox")
        Me.PoBoxTextBox.Name = "PoBoxTextBox"
        '
        'FaxTextBox
        '
        Me.FaxTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EngCVBindingSource, "Fax", True))
        resources.ApplyResources(Me.FaxTextBox, "FaxTextBox")
        Me.FaxTextBox.Name = "FaxTextBox"
        '
        'EngCVTableAdapter
        '
        Me.EngCVTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.EngCVTableAdapter = Me.EngCVTableAdapter
        Me.TableAdapterManager.UpdateOrder = EngCooperation.EngDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        Me.ErrorProvider1.DataMember = ""
        '
        'EngFrm
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "EngFrm"
        Me.panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.EngCVBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EngDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelMove.ResumeLayout(False)
        Me.PanelMove.PerformLayout()
        CType(Me.EngBitmapPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents TxtSearch As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents EngDBDataSet As EngCooperation.EngDBDataSet
    Friend WithEvents EngCVBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EngCVTableAdapter As EngCooperation.EngDBDataSetTableAdapters.EngCVTableAdapter
    Friend WithEvents TableAdapterManager As EngCooperation.EngDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents EngIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FnameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MnameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LnameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FullNameLabel1 As System.Windows.Forms.Label
    Friend WithEvents EntryTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IntegrityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CertificateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DateOFbirthdayDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateOfgraduationDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateOFjointlyDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents EngBitmapPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents CellPhoneTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EmailEnTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PoBoxTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FaxTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BtnLoadImage As System.Windows.Forms.Button
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents EngStatusTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CVModifiedDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents PanelMove As System.Windows.Forms.Panel
    Friend WithEvents LblTotal As System.Windows.Forms.Label
    Friend WithEvents LblCurrent As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BtnLast As System.Windows.Forms.Button
    Friend WithEvents BtnPrev As System.Windows.Forms.Button
    Friend WithEvents BtnNext As System.Windows.Forms.Button
    Friend WithEvents BtnFirst As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents GenderComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents IdCardTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MotherNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BirthdayOfLocTextBox As System.Windows.Forms.TextBox
    Friend WithEvents HomeAddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents WorkAddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents HomePhoneTextBox As System.Windows.Forms.TextBox
    Friend WithEvents WorkPhoneTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents NationalComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents EngRemarksTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox6 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox5 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox4 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox3 As System.Windows.Forms.CheckBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
