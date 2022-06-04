<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EngCase
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EngCase))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtRest = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtPayed = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtTotal = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtAcountDate = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtAcountID = New System.Windows.Forms.TextBox()
        Me.BatchsDataGridView = New System.Windows.Forms.DataGridView()
        Me.AcountID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PayDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Payed = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmpayed = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BatchsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BatchesDataSet = New EngCooperation.BatchesDataSet()
        Me.BatchsTableAdapter = New EngCooperation.BatchesDataSetTableAdapters.BatchsTableAdapter()
        Me.TableAdapterManager = New EngCooperation.BatchesDataSetTableAdapters.TableAdapterManager()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.BatchsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BatchsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BatchesDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(369, 407)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(121, 28)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "إغلاق"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(553, 36)
        Me.Panel1.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(315, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(187, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "الإسم الثلاثي أو الرقم الذاتي للمهندس"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(125, 10)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(184, 20)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BtnSave
        '
        Me.BtnSave.Location = New System.Drawing.Point(116, 407)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(121, 28)
        Me.BtnSave.TabIndex = 4
        Me.BtnSave.Text = "حفظ"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 36)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(553, 47)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "حـالـة الإشتراك"
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Padding = New System.Windows.Forms.Padding(20, 0, 20, 0)
        Me.Label2.Size = New System.Drawing.Size(547, 28)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "----------"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.TxtRest)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.TxtPayed)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.TxtTotal)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.TxtAcountDate)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.TxtAcountID)
        Me.GroupBox2.Controls.Add(Me.BatchsDataGridView)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox2.Location = New System.Drawing.Point(0, 83)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(553, 318)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "أقساط رسم إشتراك"
        '
        'Button2
        '
        Me.Button2.Enabled = False
        Me.Button2.Location = New System.Drawing.Point(452, 25)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(98, 35)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "أمر قبض قسط"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(186, 56)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(144, 14)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "تفاصيل دفعات المهندس"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 17)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(85, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "الباقي المستحق"
        '
        'TxtRest
        '
        Me.TxtRest.BackColor = System.Drawing.SystemColors.Info
        Me.TxtRest.Location = New System.Drawing.Point(12, 33)
        Me.TxtRest.Name = "TxtRest"
        Me.TxtRest.ReadOnly = True
        Me.TxtRest.Size = New System.Drawing.Size(82, 20)
        Me.TxtRest.TabIndex = 9
        Me.TxtRest.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(102, 17)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "مجموع الدفعات"
        '
        'TxtPayed
        '
        Me.TxtPayed.BackColor = System.Drawing.SystemColors.Info
        Me.TxtPayed.Location = New System.Drawing.Point(100, 33)
        Me.TxtPayed.Name = "TxtPayed"
        Me.TxtPayed.ReadOnly = True
        Me.TxtPayed.Size = New System.Drawing.Size(82, 20)
        Me.TxtPayed.TabIndex = 7
        Me.TxtPayed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(188, 17)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "المبلغ المستحق"
        '
        'TxtTotal
        '
        Me.TxtTotal.BackColor = System.Drawing.SystemColors.Info
        Me.TxtTotal.Location = New System.Drawing.Point(188, 33)
        Me.TxtTotal.Name = "TxtTotal"
        Me.TxtTotal.ReadOnly = True
        Me.TxtTotal.Size = New System.Drawing.Size(82, 20)
        Me.TxtTotal.TabIndex = 5
        Me.TxtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(279, 17)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "تاريخ الإستحقاق"
        '
        'TxtAcountDate
        '
        Me.TxtAcountDate.BackColor = System.Drawing.SystemColors.Info
        Me.TxtAcountDate.Location = New System.Drawing.Point(276, 33)
        Me.TxtAcountDate.Name = "TxtAcountDate"
        Me.TxtAcountDate.ReadOnly = True
        Me.TxtAcountDate.Size = New System.Drawing.Size(82, 20)
        Me.TxtAcountDate.TabIndex = 3
        Me.TxtAcountDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(384, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "إيصال رقم"
        '
        'TxtAcountID
        '
        Me.TxtAcountID.BackColor = System.Drawing.SystemColors.Info
        Me.TxtAcountID.Location = New System.Drawing.Point(364, 33)
        Me.TxtAcountID.Name = "TxtAcountID"
        Me.TxtAcountID.ReadOnly = True
        Me.TxtAcountID.Size = New System.Drawing.Size(82, 20)
        Me.TxtAcountID.TabIndex = 1
        Me.TxtAcountID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BatchsDataGridView
        '
        Me.BatchsDataGridView.AllowUserToDeleteRows = False
        Me.BatchsDataGridView.AllowUserToResizeRows = False
        Me.BatchsDataGridView.AutoGenerateColumns = False
        Me.BatchsDataGridView.BackgroundColor = System.Drawing.SystemColors.Window
        Me.BatchsDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.BatchsDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.BatchsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BatchsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AcountID, Me.DataGridViewTextBoxColumn2, Me.PayDate, Me.Payed, Me.clmpayed, Me.DataGridViewTextBoxColumn5})
        Me.BatchsDataGridView.DataSource = Me.BatchsBindingSource
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 8.0!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.BatchsDataGridView.DefaultCellStyle = DataGridViewCellStyle3
        Me.BatchsDataGridView.Enabled = False
        Me.BatchsDataGridView.GridColor = System.Drawing.SystemColors.WindowText
        Me.BatchsDataGridView.Location = New System.Drawing.Point(11, 73)
        Me.BatchsDataGridView.MultiSelect = False
        Me.BatchsDataGridView.Name = "BatchsDataGridView"
        Me.BatchsDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.BatchsDataGridView.RowHeadersVisible = False
        Me.BatchsDataGridView.Size = New System.Drawing.Size(530, 239)
        Me.BatchsDataGridView.TabIndex = 0
        '
        'AcountID
        '
        Me.AcountID.DataPropertyName = "AcountID"
        DataGridViewCellStyle2.NullValue = "0"
        Me.AcountID.DefaultCellStyle = DataGridViewCellStyle2
        Me.AcountID.HeaderText = "رقم الإيصال"
        Me.AcountID.Name = "AcountID"
        Me.AcountID.Width = 85
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "EngID"
        Me.DataGridViewTextBoxColumn2.HeaderText = "الرقم الذاتي"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 90
        '
        'PayDate
        '
        Me.PayDate.DataPropertyName = "BatchDate"
        Me.PayDate.HeaderText = "تاريخ الدفعة"
        Me.PayDate.Name = "PayDate"
        '
        'Payed
        '
        Me.Payed.DataPropertyName = "Total"
        Me.Payed.HeaderText = "قيمة الدفعة"
        Me.Payed.Name = "Payed"
        Me.Payed.Width = 85
        '
        'clmpayed
        '
        Me.clmpayed.DataPropertyName = "Payed"
        Me.clmpayed.FalseValue = "False"
        Me.clmpayed.HeaderText = "مدفوع"
        Me.clmpayed.Name = "clmpayed"
        Me.clmpayed.TrueValue = "True"
        Me.clmpayed.Width = 40
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Remark"
        Me.DataGridViewTextBoxColumn5.HeaderText = "ملاحظات"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 125
        '
        'BatchsBindingSource
        '
        Me.BatchsBindingSource.DataMember = "Batchs"
        Me.BatchsBindingSource.DataSource = Me.BatchesDataSet
        '
        'BatchesDataSet
        '
        Me.BatchesDataSet.DataSetName = "BatchesDataSet"
        Me.BatchesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BatchsTableAdapter
        '
        Me.BatchsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BatchsTableAdapter = Me.BatchsTableAdapter
        Me.TableAdapterManager.UpdateOrder = EngCooperation.BatchesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'EngCase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.ClientSize = New System.Drawing.Size(553, 447)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "EngCase"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.Text = "ذمـة المهندس"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.BatchsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BatchsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BatchesDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents BatchesDataSet As EngCooperation.BatchesDataSet
    Friend WithEvents BatchsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BatchsTableAdapter As EngCooperation.BatchesDataSetTableAdapters.BatchsTableAdapter
    Friend WithEvents TableAdapterManager As EngCooperation.BatchesDataSetTableAdapters.TableAdapterManager
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents BatchsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TxtRest As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtPayed As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtAcountDate As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtAcountID As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents AcountID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PayDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Payed As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmpayed As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
