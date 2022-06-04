<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EngRest
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EngRest))
        Me.DataReportRestBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BatchesDataSet = New EngCooperation.BatchesDataSet()
        Me.EngCVBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EngDBDataSet = New EngCooperation.EngDBDataSet()
        Me.EngCVTableAdapter = New EngCooperation.EngDBDataSetTableAdapters.EngCVTableAdapter()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BatchsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BatchsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.BatchsTableAdapter = New EngCooperation.BatchesDataSetTableAdapters.BatchsTableAdapter()
        Me.TableAdapterManager = New EngCooperation.BatchesDataSetTableAdapters.TableAdapterManager()
        Me.DataReportRestTableAdapter = New EngCooperation.BatchesDataSetTableAdapters.DataReportRestTableAdapter()
        Me.Button4 = New System.Windows.Forms.Button()
        CType(Me.DataReportRestBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BatchesDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EngCVBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EngDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.BatchsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BatchsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataReportRestBindingSource
        '
        Me.DataReportRestBindingSource.DataMember = "DataReportRest"
        Me.DataReportRestBindingSource.DataSource = Me.BatchesDataSet
        '
        'BatchesDataSet
        '
        Me.BatchesDataSet.DataSetName = "BatchesDataSet"
        Me.BatchesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'EngCVTableAdapter
        '
        Me.EngCVTableAdapter.ClearBeforeFill = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 468)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(578, 46)
        Me.Panel1.TabIndex = 2
        '
        'Button3
        '
        Me.Button3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button3.Location = New System.Drawing.Point(174, 6)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(140, 31)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "طباعة وصل"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button2.Location = New System.Drawing.Point(12, 6)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(140, 31)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "خروج"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button1.Location = New System.Drawing.Point(333, 6)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(140, 31)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "ترحيل الدفعة"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.BatchsDataGridView)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(578, 132)
        Me.Panel2.TabIndex = 4
        '
        'BatchsDataGridView
        '
        Me.BatchsDataGridView.AllowDrop = True
        Me.BatchsDataGridView.AllowUserToAddRows = False
        Me.BatchsDataGridView.AllowUserToDeleteRows = False
        Me.BatchsDataGridView.AllowUserToOrderColumns = True
        Me.BatchsDataGridView.AllowUserToResizeColumns = False
        Me.BatchsDataGridView.AllowUserToResizeRows = False
        Me.BatchsDataGridView.AutoGenerateColumns = False
        Me.BatchsDataGridView.BackgroundColor = System.Drawing.SystemColors.Window
        Me.BatchsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.BatchsDataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.BatchsDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.BatchsDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.BatchsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BatchsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewCheckBoxColumn1, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn1})
        Me.BatchsDataGridView.DataSource = Me.BatchsBindingSource
        Me.BatchsDataGridView.Dock = System.Windows.Forms.DockStyle.Top
        Me.BatchsDataGridView.GridColor = System.Drawing.SystemColors.WindowText
        Me.BatchsDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.BatchsDataGridView.MultiSelect = False
        Me.BatchsDataGridView.Name = "BatchsDataGridView"
        Me.BatchsDataGridView.ReadOnly = True
        Me.BatchsDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 8.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.BatchsDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.BatchsDataGridView.RowHeadersVisible = False
        Me.BatchsDataGridView.Size = New System.Drawing.Size(578, 115)
        Me.BatchsDataGridView.TabIndex = 2
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Bid"
        Me.DataGridViewTextBoxColumn6.HeaderText = "رقم الإيصال"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "EngID"
        Me.DataGridViewTextBoxColumn2.DataSource = Me.EngCVBindingSource
        Me.DataGridViewTextBoxColumn2.DisplayMember = "FullName"
        Me.DataGridViewTextBoxColumn2.HeaderText = "اسم المهندس"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn2.ValueMember = "EngID"
        Me.DataGridViewTextBoxColumn2.Width = 125
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "BatchDate"
        Me.DataGridViewTextBoxColumn3.HeaderText = "تاريخ الدفعة"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Total"
        Me.DataGridViewTextBoxColumn4.HeaderText = "المبلغ"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "Payed"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "مقبوض"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.ReadOnly = True
        Me.DataGridViewCheckBoxColumn1.Width = 50
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Remark"
        Me.DataGridViewTextBoxColumn5.HeaderText = "ملاحظات"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 102
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "AcountID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "AcountID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'BatchsBindingSource
        '
        Me.BatchsBindingSource.DataMember = "Batchs"
        Me.BatchsBindingSource.DataSource = Me.BatchesDataSet
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.DataReportRestBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "EngCooperation.Report5.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 132)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ShowBackButton = False
        Me.ReportViewer1.ShowContextMenu = False
        Me.ReportViewer1.ShowCredentialPrompts = False
        Me.ReportViewer1.ShowDocumentMapButton = False
        Me.ReportViewer1.ShowExportButton = False
        Me.ReportViewer1.ShowFindControls = False
        Me.ReportViewer1.ShowPageNavigationControls = False
        Me.ReportViewer1.Size = New System.Drawing.Size(578, 336)
        Me.ReportViewer1.TabIndex = 5
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
        'DataReportRestTableAdapter
        '
        Me.DataReportRestTableAdapter.ClearBeforeFill = True
        '
        'Button4
        '
        Me.Button4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button4.BackColor = System.Drawing.SystemColors.Window
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.ForeColor = System.Drawing.Color.Navy
        Me.Button4.Location = New System.Drawing.Point(483, 9)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(83, 28)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "تحديث القائمة"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'EngRest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.ClientSize = New System.Drawing.Size(578, 514)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "EngRest"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.Text = "EngRest"
        CType(Me.DataReportRestBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BatchesDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EngCVBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EngDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.BatchsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BatchsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BatchesDataSet As EngCooperation.BatchesDataSet
    Friend WithEvents BatchsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BatchsTableAdapter As EngCooperation.BatchesDataSetTableAdapters.BatchsTableAdapter
    Friend WithEvents EngDBDataSet As EngCooperation.EngDBDataSet
    Friend WithEvents EngCVBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EngCVTableAdapter As EngCooperation.EngDBDataSetTableAdapters.EngCVTableAdapter
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents BatchsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents DataReportRestBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataReportRestTableAdapter As EngCooperation.BatchesDataSetTableAdapters.DataReportRestTableAdapter
    Friend WithEvents TableAdapterManager As EngCooperation.BatchesDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button4 As System.Windows.Forms.Button
End Class
