<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBoxAcount
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
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle25 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle26 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle23 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle24 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim ReportDataSource4 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.InBoxDetailAcountBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AcountingDataSet = New EngCooperation.AcountingDataSet()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.TotalRestTextBox = New System.Windows.Forms.TextBox()
        Me.InBoxAcountBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.EngIDTextBox = New System.Windows.Forms.TextBox()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.InBoxAcountDataGridView = New System.Windows.Forms.DataGridView()
        Me.ClAcountID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColFullName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalCost = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalBay = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Remarks = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RestAcountID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.InBoxAcountTableAdapter = New EngCooperation.AcountingDataSetTableAdapters.InBoxAcountTableAdapter()
        Me.TableAdapterManager = New EngCooperation.AcountingDataSetTableAdapters.TableAdapterManager()
        Me.InBoxDetailAcountTableAdapter = New EngCooperation.AcountingDataSetTableAdapters.InBoxDetailAcountTableAdapter()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        CType(Me.InBoxDetailAcountBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AcountingDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.InBoxAcountBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.InBoxAcountDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'InBoxDetailAcountBindingSource
        '
        Me.InBoxDetailAcountBindingSource.DataMember = "InBoxDetailAcount"
        Me.InBoxDetailAcountBindingSource.DataSource = Me.AcountingDataSet
        '
        'AcountingDataSet
        '
        Me.AcountingDataSet.DataSetName = "AcountingDataSet"
        Me.AcountingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.CheckBox1)
        Me.Panel3.Controls.Add(Me.Button4)
        Me.Panel3.Controls.Add(Me.TotalRestTextBox)
        Me.Panel3.Controls.Add(Me.Button2)
        Me.Panel3.Controls.Add(Me.Button3)
        Me.Panel3.Controls.Add(Me.Button1)
        Me.Panel3.Controls.Add(Me.EngIDTextBox)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 388)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(820, 80)
        Me.Panel3.TabIndex = 0
        '
        'Button4
        '
        Me.Button4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button4.BackColor = System.Drawing.SystemColors.Window
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.ForeColor = System.Drawing.Color.Navy
        Me.Button4.Location = New System.Drawing.Point(734, 28)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(83, 28)
        Me.Button4.TabIndex = 6
        Me.Button4.Text = "تحديث القائمة"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'TotalRestTextBox
        '
        Me.TotalRestTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InBoxAcountBindingSource, "TotalRest", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0", "N0"))
        Me.TotalRestTextBox.Location = New System.Drawing.Point(742, 10)
        Me.TotalRestTextBox.Name = "TotalRestTextBox"
        Me.TotalRestTextBox.Size = New System.Drawing.Size(44, 20)
        Me.TotalRestTextBox.TabIndex = 5
        '
        'InBoxAcountBindingSource
        '
        Me.InBoxAcountBindingSource.DataMember = "InBoxAcount"
        Me.InBoxAcountBindingSource.DataSource = Me.AcountingDataSet
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.Font = New System.Drawing.Font("Simplified Arabic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Button2.Location = New System.Drawing.Point(582, 24)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(130, 32)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "ترحيل الوصل المحدد"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Simplified Arabic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Button3.Location = New System.Drawing.Point(38, 20)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(160, 40)
        Me.Button3.TabIndex = 1
        Me.Button3.Text = "طباعة الإيصال"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Font = New System.Drawing.Font("Simplified Arabic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Button1.Location = New System.Drawing.Point(290, 21)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(239, 40)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "إغـــلاق"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'EngIDTextBox
        '
        Me.EngIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InBoxAcountBindingSource, "EngID", True))
        Me.EngIDTextBox.Location = New System.Drawing.Point(742, 36)
        Me.EngIDTextBox.Name = "EngIDTextBox"
        Me.EngIDTextBox.Size = New System.Drawing.Size(44, 20)
        Me.EngIDTextBox.TabIndex = 4
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.InBoxAcountDataGridView)
        Me.SplitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.ReportViewer1)
        Me.SplitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.SplitContainer1.Size = New System.Drawing.Size(820, 388)
        Me.SplitContainer1.SplitterDistance = 382
        Me.SplitContainer1.TabIndex = 9
        '
        'InBoxAcountDataGridView
        '
        Me.InBoxAcountDataGridView.AllowUserToAddRows = False
        Me.InBoxAcountDataGridView.AllowUserToDeleteRows = False
        Me.InBoxAcountDataGridView.AllowUserToResizeColumns = False
        Me.InBoxAcountDataGridView.AllowUserToResizeRows = False
        Me.InBoxAcountDataGridView.AutoGenerateColumns = False
        Me.InBoxAcountDataGridView.BackgroundColor = System.Drawing.SystemColors.Window
        Me.InBoxAcountDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.InBoxAcountDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.InBoxAcountDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.InBoxAcountDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.InBoxAcountDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.InBoxAcountDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ClAcountID, Me.DataGridViewTextBoxColumn2, Me.ColFullName, Me.DataGridViewTextBoxColumn3, Me.TotalCost, Me.TotalBay, Me.Remarks, Me.RestAcountID})
        Me.InBoxAcountDataGridView.ContextMenuStrip = Me.ContextMenuStrip1
        Me.InBoxAcountDataGridView.DataSource = Me.InBoxAcountBindingSource
        Me.InBoxAcountDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.InBoxAcountDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.InBoxAcountDataGridView.EnableHeadersVisualStyles = False
        Me.InBoxAcountDataGridView.GridColor = System.Drawing.SystemColors.WindowText
        Me.InBoxAcountDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.InBoxAcountDataGridView.MultiSelect = False
        Me.InBoxAcountDataGridView.Name = "InBoxAcountDataGridView"
        Me.InBoxAcountDataGridView.ReadOnly = True
        DataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle25.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle25.Font = New System.Drawing.Font("Simplified Arabic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle25.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle25.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle25.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.InBoxAcountDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle25
        Me.InBoxAcountDataGridView.RowHeadersVisible = False
        DataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.InBoxAcountDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle26
        Me.InBoxAcountDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.InBoxAcountDataGridView.Size = New System.Drawing.Size(382, 388)
        Me.InBoxAcountDataGridView.TabIndex = 2
        '
        'ClAcountID
        '
        Me.ClAcountID.DataPropertyName = "AcountID"
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.ClAcountID.DefaultCellStyle = DataGridViewCellStyle15
        Me.ClAcountID.HeaderText = "إيصال رقم"
        Me.ClAcountID.Name = "ClAcountID"
        Me.ClAcountID.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "AcountDate"
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle16
        Me.DataGridViewTextBoxColumn2.HeaderText = "بتاريخ"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'ColFullName
        '
        Me.ColFullName.DataPropertyName = "FullName"
        DataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.ColFullName.DefaultCellStyle = DataGridViewCellStyle22
        Me.ColFullName.HeaderText = "يقبض من السيد"
        Me.ColFullName.Name = "ColFullName"
        Me.ColFullName.ReadOnly = True
        Me.ColFullName.Width = 125
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "AcountStatus"
        DataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle23.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle23
        Me.DataGridViewTextBoxColumn3.HeaderText = "حالة الإيصال"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Visible = False
        '
        'TotalCost
        '
        Me.TotalCost.DataPropertyName = "TotalCost"
        DataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle24.Format = "C1"
        DataGridViewCellStyle24.NullValue = Nothing
        Me.TotalCost.DefaultCellStyle = DataGridViewCellStyle24
        Me.TotalCost.HeaderText = "مبلغ وقدرة"
        Me.TotalCost.Name = "TotalCost"
        Me.TotalCost.ReadOnly = True
        '
        'TotalBay
        '
        Me.TotalBay.DataPropertyName = "TotalBay"
        Me.TotalBay.HeaderText = "قيمة الوصل"
        Me.TotalBay.Name = "TotalBay"
        Me.TotalBay.ReadOnly = True
        Me.TotalBay.Visible = False
        '
        'Remarks
        '
        Me.Remarks.DataPropertyName = "Remarks"
        Me.Remarks.HeaderText = "ملاحظات"
        Me.Remarks.Name = "Remarks"
        Me.Remarks.ReadOnly = True
        '
        'RestAcountID
        '
        Me.RestAcountID.DataPropertyName = "RestAcountID"
        Me.RestAcountID.HeaderText = "RestAcountID"
        Me.RestAcountID.Name = "RestAcountID"
        Me.RestAcountID.ReadOnly = True
        Me.RestAcountID.Visible = False
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripTextBox1})
        Me.ContextMenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(161, 27)
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(100, 21)
        Me.ToolStripTextBox1.Text = "بحث"
        Me.ToolStripTextBox1.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolStripTextBox1.ToolTipText = "بحث حسب رقم الوصل أو الإسم الثلاثي"
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource4.Name = "DataSet1"
        ReportDataSource4.Value = Me.InBoxDetailAcountBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource4)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "EngCooperation.Report4.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(434, 388)
        Me.ReportViewer1.TabIndex = 1
        '
        'InBoxAcountTableAdapter
        '
        Me.InBoxAcountTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AcountingTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClassesTableAdapter = Nothing
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.DetailsAcountingTableAdapter = Nothing
        Me.TableAdapterManager.EngCVTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = EngCooperation.AcountingDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'InBoxDetailAcountTableAdapter
        '
        Me.InBoxDetailAcountTableAdapter.ClearBeforeFill = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 5000
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(742, 6)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(75, 17)
        Me.CheckBox1.TabIndex = 7
        Me.CheckBox1.Text = "تحديث آلي"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'FrmBoxAcount
        '
        Me.AcceptButton = Me.Button4
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(820, 468)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.Panel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmBoxAcount"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.Text = "الصندوق"
        CType(Me.InBoxDetailAcountBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AcountingDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.InBoxAcountBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.InBoxAcountDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ContextMenuStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents AcountingDataSet As EngCooperation.AcountingDataSet
    Friend WithEvents InBoxAcountBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents InBoxAcountTableAdapter As EngCooperation.AcountingDataSetTableAdapters.InBoxAcountTableAdapter
    Friend WithEvents TableAdapterManager As EngCooperation.AcountingDataSetTableAdapters.TableAdapterManager
    Friend WithEvents InBoxDetailAcountBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents InBoxDetailAcountTableAdapter As EngCooperation.AcountingDataSetTableAdapters.InBoxDetailAcountTableAdapter
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents InBoxAcountDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents EngIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TotalRestTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents ClAcountID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColFullName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalCost As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalBay As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Remarks As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RestAcountID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripTextBox1 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
