<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserInfoFrm
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
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim UserIDLabel As System.Windows.Forms.Label
        Dim UserNameLabel As System.Windows.Forms.Label
        Dim UserPWLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.UsersInfoDataGridView = New System.Windows.Forms.DataGridView()
        Me.UsersInfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UserInfoDataSet = New EngCooperation.UserInfoDataSet()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.UsersInfoTableAdapter = New EngCooperation.UserInfoDataSetTableAdapters.UsersInfoTableAdapter()
        Me.TableAdapterManager = New EngCooperation.UserInfoDataSetTableAdapters.TableAdapterManager()
        Me.UserIDTextBox = New System.Windows.Forms.TextBox()
        Me.UserNameTextBox = New System.Windows.Forms.TextBox()
        Me.UserPWTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.IsAdminCheckBox = New System.Windows.Forms.CheckBox()
        Me.AllowBoxCheckBox = New System.Windows.Forms.CheckBox()
        Me.AllowAcountCheckBox = New System.Windows.Forms.CheckBox()
        Me.AllowCVCheckBox = New System.Windows.Forms.CheckBox()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn2 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn3 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn4 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        UserIDLabel = New System.Windows.Forms.Label()
        UserNameLabel = New System.Windows.Forms.Label()
        UserPWLabel = New System.Windows.Forms.Label()
        CType(Me.UsersInfoDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsersInfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserInfoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'UsersInfoDataGridView
        '
        Me.UsersInfoDataGridView.AllowUserToAddRows = False
        Me.UsersInfoDataGridView.AllowUserToDeleteRows = False
        Me.UsersInfoDataGridView.AllowUserToResizeColumns = False
        Me.UsersInfoDataGridView.AllowUserToResizeRows = False
        Me.UsersInfoDataGridView.AutoGenerateColumns = False
        Me.UsersInfoDataGridView.BackgroundColor = System.Drawing.SystemColors.Control
        Me.UsersInfoDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal
        Me.UsersInfoDataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.UsersInfoDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.UsersInfoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.UsersInfoDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewCheckBoxColumn1, Me.DataGridViewCheckBoxColumn2, Me.DataGridViewCheckBoxColumn3, Me.DataGridViewCheckBoxColumn4})
        Me.UsersInfoDataGridView.DataSource = Me.UsersInfoBindingSource
        Me.UsersInfoDataGridView.Location = New System.Drawing.Point(12, 12)
        Me.UsersInfoDataGridView.Name = "UsersInfoDataGridView"
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Info
        Me.UsersInfoDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.UsersInfoDataGridView.Size = New System.Drawing.Size(246, 299)
        Me.UsersInfoDataGridView.TabIndex = 0
        '
        'UsersInfoBindingSource
        '
        Me.UsersInfoBindingSource.DataMember = "UsersInfo"
        Me.UsersInfoBindingSource.DataSource = Me.UserInfoDataSet
        '
        'UserInfoDataSet
        '
        Me.UserInfoDataSet.DataSetName = "UserInfoDataSet"
        Me.UserInfoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 317)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(547, 45)
        Me.Panel1.TabIndex = 1
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(293, 3)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(117, 36)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "حذف"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(12, 3)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(117, 36)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "إغلاق"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(137, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(150, 36)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "حفظ"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(419, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(117, 36)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "إضافة"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'UsersInfoTableAdapter
        '
        Me.UsersInfoTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = EngCooperation.UserInfoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsersInfoTableAdapter = Me.UsersInfoTableAdapter
        '
        'UserIDLabel
        '
        UserIDLabel.AutoSize = True
        UserIDLabel.Location = New System.Drawing.Point(280, 14)
        UserIDLabel.Name = "UserIDLabel"
        UserIDLabel.Size = New System.Drawing.Size(86, 13)
        UserIDLabel.TabIndex = 2
        UserIDLabel.Text = "معرف المستخدم"
        UserIDLabel.Visible = False
        '
        'UserIDTextBox
        '
        Me.UserIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsersInfoBindingSource, "UserID", True))
        Me.UserIDTextBox.Location = New System.Drawing.Point(372, 14)
        Me.UserIDTextBox.Name = "UserIDTextBox"
        Me.UserIDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.UserIDTextBox.TabIndex = 3
        Me.UserIDTextBox.Visible = False
        '
        'UserNameLabel
        '
        UserNameLabel.AutoSize = True
        UserNameLabel.Location = New System.Drawing.Point(280, 43)
        UserNameLabel.Name = "UserNameLabel"
        UserNameLabel.Size = New System.Drawing.Size(81, 13)
        UserNameLabel.TabIndex = 12
        UserNameLabel.Text = "اسم المستخدم"
        '
        'UserNameTextBox
        '
        Me.UserNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsersInfoBindingSource, "UserName", True))
        Me.UserNameTextBox.Location = New System.Drawing.Point(372, 40)
        Me.UserNameTextBox.Name = "UserNameTextBox"
        Me.UserNameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.UserNameTextBox.TabIndex = 13
        '
        'UserPWLabel
        '
        UserPWLabel.AutoSize = True
        UserPWLabel.Location = New System.Drawing.Point(302, 69)
        UserPWLabel.Name = "UserPWLabel"
        UserPWLabel.Size = New System.Drawing.Size(59, 13)
        UserPWLabel.TabIndex = 14
        UserPWLabel.Text = "كلمة المرور"
        '
        'UserPWTextBox
        '
        Me.UserPWTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsersInfoBindingSource, "UserPW", True))
        Me.UserPWTextBox.Location = New System.Drawing.Point(372, 66)
        Me.UserPWTextBox.Name = "UserPWTextBox"
        Me.UserPWTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.UserPWTextBox.Size = New System.Drawing.Size(100, 20)
        Me.UserPWTextBox.TabIndex = 15
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.IsAdminCheckBox)
        Me.GroupBox1.Controls.Add(Me.AllowBoxCheckBox)
        Me.GroupBox1.Controls.Add(Me.AllowAcountCheckBox)
        Me.GroupBox1.Controls.Add(Me.AllowCVCheckBox)
        Me.GroupBox1.Location = New System.Drawing.Point(307, 95)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(165, 155)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "صلاحيات المستخدم"
        '
        'IsAdminCheckBox
        '
        Me.IsAdminCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.UsersInfoBindingSource, "IsAdmin", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "false"))
        Me.IsAdminCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.UsersInfoBindingSource, "IsAdmin", True))
        Me.IsAdminCheckBox.Location = New System.Drawing.Point(34, 118)
        Me.IsAdminCheckBox.Name = "IsAdminCheckBox"
        Me.IsAdminCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.IsAdminCheckBox.TabIndex = 15
        Me.IsAdminCheckBox.Text = "صلاحية مدير"
        Me.IsAdminCheckBox.UseVisualStyleBackColor = True
        '
        'AllowBoxCheckBox
        '
        Me.AllowBoxCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.UsersInfoBindingSource, "AllowBox", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "false"))
        Me.AllowBoxCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.UsersInfoBindingSource, "AllowBox", True))
        Me.AllowBoxCheckBox.Location = New System.Drawing.Point(34, 88)
        Me.AllowBoxCheckBox.Name = "AllowBoxCheckBox"
        Me.AllowBoxCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.AllowBoxCheckBox.TabIndex = 14
        Me.AllowBoxCheckBox.Text = "الصندوق"
        Me.AllowBoxCheckBox.UseVisualStyleBackColor = True
        '
        'AllowAcountCheckBox
        '
        Me.AllowAcountCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.UsersInfoBindingSource, "AllowAcount", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "false"))
        Me.AllowAcountCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.UsersInfoBindingSource, "AllowAcount", True))
        Me.AllowAcountCheckBox.Location = New System.Drawing.Point(34, 58)
        Me.AllowAcountCheckBox.Name = "AllowAcountCheckBox"
        Me.AllowAcountCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.AllowAcountCheckBox.TabIndex = 13
        Me.AllowAcountCheckBox.Text = "المحاسبة"
        Me.AllowAcountCheckBox.UseVisualStyleBackColor = True
        '
        'AllowCVCheckBox
        '
        Me.AllowCVCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.UsersInfoBindingSource, "AllowCV", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "False"))
        Me.AllowCVCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.UsersInfoBindingSource, "AllowCV", True))
        Me.AllowCVCheckBox.Location = New System.Drawing.Point(34, 28)
        Me.AllowCVCheckBox.Name = "AllowCVCheckBox"
        Me.AllowCVCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.AllowCVCheckBox.TabIndex = 12
        Me.AllowCVCheckBox.Text = "ذاتية"
        Me.AllowCVCheckBox.UseVisualStyleBackColor = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "UserID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "معرف"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 50
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "UserName"
        Me.DataGridViewTextBoxColumn2.HeaderText = "اسم المستخدم"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 150
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "UserPW"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridViewTextBoxColumn3.HeaderText = "كلمة المرور"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Visible = False
        Me.DataGridViewTextBoxColumn3.Width = 125
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "AllowCV"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "الذاتية"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.Visible = False
        Me.DataGridViewCheckBoxColumn1.Width = 75
        '
        'DataGridViewCheckBoxColumn2
        '
        Me.DataGridViewCheckBoxColumn2.DataPropertyName = "AllowAcount"
        Me.DataGridViewCheckBoxColumn2.HeaderText = "المحاسبة"
        Me.DataGridViewCheckBoxColumn2.Name = "DataGridViewCheckBoxColumn2"
        Me.DataGridViewCheckBoxColumn2.Visible = False
        Me.DataGridViewCheckBoxColumn2.Width = 75
        '
        'DataGridViewCheckBoxColumn3
        '
        Me.DataGridViewCheckBoxColumn3.DataPropertyName = "AllowBox"
        Me.DataGridViewCheckBoxColumn3.HeaderText = "الصندوق"
        Me.DataGridViewCheckBoxColumn3.Name = "DataGridViewCheckBoxColumn3"
        Me.DataGridViewCheckBoxColumn3.Visible = False
        Me.DataGridViewCheckBoxColumn3.Width = 75
        '
        'DataGridViewCheckBoxColumn4
        '
        Me.DataGridViewCheckBoxColumn4.DataPropertyName = "IsAdmin"
        Me.DataGridViewCheckBoxColumn4.HeaderText = "سماحية مدير"
        Me.DataGridViewCheckBoxColumn4.Name = "DataGridViewCheckBoxColumn4"
        Me.DataGridViewCheckBoxColumn4.Visible = False
        Me.DataGridViewCheckBoxColumn4.Width = 75
        '
        'UserInfoFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(547, 362)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(UserPWLabel)
        Me.Controls.Add(Me.UserPWTextBox)
        Me.Controls.Add(UserNameLabel)
        Me.Controls.Add(Me.UserNameTextBox)
        Me.Controls.Add(UserIDLabel)
        Me.Controls.Add(Me.UserIDTextBox)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.UsersInfoDataGridView)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "UserInfoFrm"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.Text = "صلاحيات دخول البرنامج"
        CType(Me.UsersInfoDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsersInfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserInfoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents UserInfoDataSet As EngCooperation.UserInfoDataSet
    Friend WithEvents UsersInfoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UsersInfoTableAdapter As EngCooperation.UserInfoDataSetTableAdapters.UsersInfoTableAdapter
    Friend WithEvents TableAdapterManager As EngCooperation.UserInfoDataSetTableAdapters.TableAdapterManager
    Friend WithEvents UsersInfoDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents UserIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UserNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UserPWTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents IsAdminCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents AllowBoxCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents AllowAcountCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents AllowCVCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn2 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn3 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn4 As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
