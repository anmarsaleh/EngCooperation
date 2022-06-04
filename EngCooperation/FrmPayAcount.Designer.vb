<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPayAcount
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
        Dim AcountIDLabel As System.Windows.Forms.Label
        Dim EngIDLabel As System.Windows.Forms.Label
        Dim TotalLabel As System.Windows.Forms.Label
        Dim TotalBayLabel As System.Windows.Forms.Label
        Dim TotalRestLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPayAcount))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.EngIDComboBox = New System.Windows.Forms.ComboBox()
        Me.EngCVBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PatDataSet = New EngCooperation.PatDataSet()
        Me.TotalRestTextBox = New System.Windows.Forms.TextBox()
        Me.AcountingBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TotalBayTextBox = New System.Windows.Forms.TextBox()
        Me.TotalTextBox = New System.Windows.Forms.TextBox()
        Me.AcountIDTextBox = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DetailsAcountingDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.ClassesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DetailsAcountingBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.AcountingTableAdapter = New EngCooperation.PatDataSetTableAdapters.AcountingTableAdapter()
        Me.TableAdapterManager = New EngCooperation.PatDataSetTableAdapters.TableAdapterManager()
        Me.DetailsAcountingTableAdapter = New EngCooperation.PatDataSetTableAdapters.DetailsAcountingTableAdapter()
        Me.ClassesTableAdapter = New EngCooperation.PatDataSetTableAdapters.ClassesTableAdapter()
        Me.EngCVTableAdapter = New EngCooperation.PatDataSetTableAdapters.EngCVTableAdapter()
        AcountIDLabel = New System.Windows.Forms.Label()
        EngIDLabel = New System.Windows.Forms.Label()
        TotalLabel = New System.Windows.Forms.Label()
        TotalBayLabel = New System.Windows.Forms.Label()
        TotalRestLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.EngCVBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PatDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AcountingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.DetailsAcountingDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClassesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetailsAcountingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'AcountIDLabel
        '
        AcountIDLabel.AutoSize = True
        AcountIDLabel.Location = New System.Drawing.Point(679, 18)
        AcountIDLabel.Name = "AcountIDLabel"
        AcountIDLabel.Size = New System.Drawing.Size(55, 13)
        AcountIDLabel.TabIndex = 0
        AcountIDLabel.Text = "رقم الوصل"
        '
        'EngIDLabel
        '
        EngIDLabel.AutoSize = True
        EngIDLabel.Location = New System.Drawing.Point(532, 18)
        EngIDLabel.Name = "EngIDLabel"
        EngIDLabel.Size = New System.Drawing.Size(35, 13)
        EngIDLabel.TabIndex = 2
        EngIDLabel.Text = "السيد"
        '
        'TotalLabel
        '
        TotalLabel.AutoSize = True
        TotalLabel.Location = New System.Drawing.Point(344, 21)
        TotalLabel.Name = "TotalLabel"
        TotalLabel.Size = New System.Drawing.Size(48, 13)
        TotalLabel.TabIndex = 4
        TotalLabel.Text = "الإجمالي"
        '
        'TotalBayLabel
        '
        TotalBayLabel.AutoSize = True
        TotalBayLabel.Location = New System.Drawing.Point(186, 21)
        TotalBayLabel.Name = "TotalBayLabel"
        TotalBayLabel.Size = New System.Drawing.Size(43, 13)
        TotalBayLabel.TabIndex = 6
        TotalBayLabel.Text = "المدفوع"
        '
        'TotalRestLabel
        '
        TotalRestLabel.AutoSize = True
        TotalRestLabel.Location = New System.Drawing.Point(186, 47)
        TotalRestLabel.Name = "TotalRestLabel"
        TotalRestLabel.Size = New System.Drawing.Size(36, 13)
        TotalRestLabel.TabIndex = 8
        TotalRestLabel.Text = "الباقي"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.EngIDComboBox)
        Me.Panel1.Controls.Add(TotalRestLabel)
        Me.Panel1.Controls.Add(Me.TotalRestTextBox)
        Me.Panel1.Controls.Add(TotalBayLabel)
        Me.Panel1.Controls.Add(Me.TotalBayTextBox)
        Me.Panel1.Controls.Add(TotalLabel)
        Me.Panel1.Controls.Add(Me.TotalTextBox)
        Me.Panel1.Controls.Add(EngIDLabel)
        Me.Panel1.Controls.Add(AcountIDLabel)
        Me.Panel1.Controls.Add(Me.AcountIDTextBox)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(744, 73)
        Me.Panel1.TabIndex = 0
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(615, 47)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(58, 20)
        Me.TextBox1.TabIndex = 11
        '
        'EngIDComboBox
        '
        Me.EngIDComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.EngCVBindingSource, "EngID", True))
        Me.EngIDComboBox.DataSource = Me.EngCVBindingSource
        Me.EngIDComboBox.DisplayMember = "FullName"
        Me.EngIDComboBox.FormattingEnabled = True
        Me.EngIDComboBox.Location = New System.Drawing.Point(405, 18)
        Me.EngIDComboBox.Name = "EngIDComboBox"
        Me.EngIDComboBox.Size = New System.Drawing.Size(121, 21)
        Me.EngIDComboBox.TabIndex = 10
        Me.EngIDComboBox.ValueMember = "EngID"
        '
        'EngCVBindingSource
        '
        Me.EngCVBindingSource.DataMember = "EngCV"
        Me.EngCVBindingSource.DataSource = Me.PatDataSet
        '
        'PatDataSet
        '
        Me.PatDataSet.DataSetName = "PatDataSet"
        Me.PatDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TotalRestTextBox
        '
        Me.TotalRestTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AcountingBindingSource, "TotalRest", True))
        Me.TotalRestTextBox.Location = New System.Drawing.Point(80, 44)
        Me.TotalRestTextBox.Name = "TotalRestTextBox"
        Me.TotalRestTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TotalRestTextBox.TabIndex = 9
        '
        'AcountingBindingSource
        '
        Me.AcountingBindingSource.DataMember = "Acounting"
        Me.AcountingBindingSource.DataSource = Me.PatDataSet
        '
        'TotalBayTextBox
        '
        Me.TotalBayTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AcountingBindingSource, "TotalBay", True))
        Me.TotalBayTextBox.Location = New System.Drawing.Point(80, 18)
        Me.TotalBayTextBox.Name = "TotalBayTextBox"
        Me.TotalBayTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TotalBayTextBox.TabIndex = 7
        '
        'TotalTextBox
        '
        Me.TotalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AcountingBindingSource, "Total", True))
        Me.TotalTextBox.Location = New System.Drawing.Point(237, 18)
        Me.TotalTextBox.Name = "TotalTextBox"
        Me.TotalTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TotalTextBox.TabIndex = 5
        '
        'AcountIDTextBox
        '
        Me.AcountIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AcountingBindingSource, "AcountID", True))
        Me.AcountIDTextBox.Location = New System.Drawing.Point(573, 18)
        Me.AcountIDTextBox.Name = "AcountIDTextBox"
        Me.AcountIDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.AcountIDTextBox.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.DetailsAcountingDataGridView)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 73)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(744, 349)
        Me.Panel2.TabIndex = 1
        '
        'DetailsAcountingDataGridView
        '
        Me.DetailsAcountingDataGridView.AutoGenerateColumns = False
        Me.DetailsAcountingDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DetailsAcountingDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn5})
        Me.DetailsAcountingDataGridView.DataSource = Me.DetailsAcountingBindingSource
        Me.DetailsAcountingDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DetailsAcountingDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.DetailsAcountingDataGridView.Name = "DetailsAcountingDataGridView"
        Me.DetailsAcountingDataGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.DetailsAcountingDataGridView.RowHeadersVisible = False
        Me.DetailsAcountingDataGridView.Size = New System.Drawing.Size(744, 349)
        Me.DetailsAcountingDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "AcountID"
        Me.DataGridViewTextBoxColumn2.HeaderText = "No#"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 60
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "ClassID"
        Me.DataGridViewTextBoxColumn3.DataSource = Me.ClassesBindingSource
        Me.DataGridViewTextBoxColumn3.DisplayMember = "Kind"
        Me.DataGridViewTextBoxColumn3.HeaderText = "البيــــــــان"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn3.ValueMember = "ClassID"
        Me.DataGridViewTextBoxColumn3.Width = 200
        '
        'ClassesBindingSource
        '
        Me.ClassesBindingSource.DataMember = "Classes"
        Me.ClassesBindingSource.DataSource = Me.PatDataSet
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "RealCost"
        Me.DataGridViewTextBoxColumn6.HeaderText = "الكلفة"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Cost"
        Me.DataGridViewTextBoxColumn4.HeaderText = "الدفعة"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "RestCost"
        Me.DataGridViewTextBoxColumn7.HeaderText = "الباقي"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Remarks"
        Me.DataGridViewTextBoxColumn5.HeaderText = "ملاحظات"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DetailsAcountingBindingSource
        '
        Me.DetailsAcountingBindingSource.DataMember = "FK_DetailsAcounting_Acounting"
        Me.DetailsAcountingBindingSource.DataSource = Me.AcountingBindingSource
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.TextBox2)
        Me.Panel3.Controls.Add(Me.Button2)
        Me.Panel3.Controls.Add(Me.Button1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 418)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(744, 50)
        Me.Panel3.TabIndex = 2
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClassesBindingSource, "Cost", True))
        Me.TextBox2.Location = New System.Drawing.Point(405, 16)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(80, 20)
        Me.TextBox2.TabIndex = 2
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(80, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(125, 27)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "إغلاق"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(520, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(125, 27)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "حفظ"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'AcountingTableAdapter
        '
        Me.AcountingTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AcountingTableAdapter = Me.AcountingTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClassesTableAdapter = Nothing
        Me.TableAdapterManager.DetailsAcountingTableAdapter = Me.DetailsAcountingTableAdapter
        Me.TableAdapterManager.EngCVTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = EngCooperation.PatDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DetailsAcountingTableAdapter
        '
        Me.DetailsAcountingTableAdapter.ClearBeforeFill = True
        '
        'ClassesTableAdapter
        '
        Me.ClassesTableAdapter.ClearBeforeFill = True
        '
        'EngCVTableAdapter
        '
        Me.EngCVTableAdapter.ClearBeforeFill = True
        '
        'FrmPayAcount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(744, 468)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmPayAcount"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.Text = "أمر قبض"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.EngCVBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PatDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AcountingBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.DetailsAcountingDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClassesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetailsAcountingBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents PatDataSet As EngCooperation.PatDataSet
    Friend WithEvents AcountingBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AcountingTableAdapter As EngCooperation.PatDataSetTableAdapters.AcountingTableAdapter
    Friend WithEvents TableAdapterManager As EngCooperation.PatDataSetTableAdapters.TableAdapterManager
    Friend WithEvents AcountIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TotalRestTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TotalBayTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TotalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DetailsAcountingTableAdapter As EngCooperation.PatDataSetTableAdapters.DetailsAcountingTableAdapter
    Friend WithEvents DetailsAcountingBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DetailsAcountingDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents ClassesTableAdapter As EngCooperation.PatDataSetTableAdapters.ClassesTableAdapter
    Friend WithEvents ClassesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EngIDComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents EngCVTableAdapter As EngCooperation.PatDataSetTableAdapters.EngCVTableAdapter
    Friend WithEvents EngCVBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
