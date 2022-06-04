<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTreeAcount
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTreeAcount))
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.InBoxDetailAcountBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AcountingDataSet = New EngCooperation.AcountingDataSet()
        Me.BatchsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BatchesDataSet = New EngCooperation.BatchesDataSet()
        Me.InBoxDetailAcountTableAdapter = New EngCooperation.AcountingDataSetTableAdapters.InBoxDetailAcountTableAdapter()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Dt2 = New System.Windows.Forms.DateTimePicker()
        Me.Dt1 = New System.Windows.Forms.DateTimePicker()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TableAdapterManager = New EngCooperation.AcountingDataSetTableAdapters.TableAdapterManager()
        Me.BatchsTableAdapter = New EngCooperation.BatchesDataSetTableAdapters.BatchsTableAdapter()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.FillByKindToolStrip = New System.Windows.Forms.ToolStrip()
        Me.KindToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.KindToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.FillByKindToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        CType(Me.InBoxDetailAcountBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AcountingDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BatchsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BatchesDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.FillByKindToolStrip.SuspendLayout()
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
        'BatchsBindingSource
        '
        Me.BatchsBindingSource.DataMember = "Batchs"
        Me.BatchsBindingSource.DataSource = Me.BatchesDataSet
        Me.BatchsBindingSource.Filter = ""
        '
        'BatchesDataSet
        '
        Me.BatchesDataSet.DataSetName = "BatchesDataSet"
        Me.BatchesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'InBoxDetailAcountTableAdapter
        '
        Me.InBoxDetailAcountTableAdapter.ClearBeforeFill = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Dt2)
        Me.Panel1.Controls.Add(Me.Dt1)
        Me.Panel1.Controls.Add(Me.RadioButton2)
        Me.Panel1.Controls.Add(Me.RadioButton1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(787, 66)
        Me.Panel1.TabIndex = 1
        '
        'Button4
        '
        Me.Button4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button4.BackColor = System.Drawing.SystemColors.Window
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.ForeColor = System.Drawing.Color.Navy
        Me.Button4.Location = New System.Drawing.Point(607, 21)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(83, 28)
        Me.Button4.TabIndex = 8
        Me.Button4.Text = "تحديث القائمة"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(194, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(24, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "إلى"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(410, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "من"
        '
        'Dt2
        '
        Me.Dt2.Location = New System.Drawing.Point(12, 21)
        Me.Dt2.Name = "Dt2"
        Me.Dt2.Size = New System.Drawing.Size(176, 20)
        Me.Dt2.TabIndex = 3
        '
        'Dt1
        '
        Me.Dt1.Location = New System.Drawing.Point(228, 21)
        Me.Dt1.Name = "Dt1"
        Me.Dt1.Size = New System.Drawing.Size(176, 20)
        Me.Dt1.TabIndex = 2
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(445, 44)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(122, 17)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.Text = "سجلات القيد القديمة"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Location = New System.Drawing.Point(448, 21)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(119, 17)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "سجلات القيد اليومية"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(302, 9)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(196, 37)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "إغلاق"
        Me.Button1.UseVisualStyleBackColor = False
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
        'BatchsTableAdapter
        '
        Me.BatchsTableAdapter.ClearBeforeFill = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 649)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(787, 58)
        Me.Panel2.TabIndex = 3
        '
        'FillByKindToolStrip
        '
        Me.FillByKindToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KindToolStripLabel, Me.KindToolStripTextBox, Me.FillByKindToolStripButton, Me.ToolStripSeparator1, Me.ToolStripButton1})
        Me.FillByKindToolStrip.Location = New System.Drawing.Point(0, 66)
        Me.FillByKindToolStrip.Name = "FillByKindToolStrip"
        Me.FillByKindToolStrip.Size = New System.Drawing.Size(787, 25)
        Me.FillByKindToolStrip.TabIndex = 4
        Me.FillByKindToolStrip.Text = "FillByKindToolStrip"
        '
        'KindToolStripLabel
        '
        Me.KindToolStripLabel.Name = "KindToolStripLabel"
        Me.KindToolStripLabel.Size = New System.Drawing.Size(39, 22)
        Me.KindToolStripLabel.Text = "الصنف:"
        '
        'KindToolStripTextBox
        '
        Me.KindToolStripTextBox.Name = "KindToolStripTextBox"
        Me.KindToolStripTextBox.Size = New System.Drawing.Size(100, 25)
        '
        'FillByKindToolStripButton
        '
        Me.FillByKindToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillByKindToolStripButton.Name = "FillByKindToolStripButton"
        Me.FillByKindToolStripButton.Size = New System.Drawing.Size(40, 22)
        Me.FillByKindToolStripButton.Text = "تصفية"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(59, 22)
        Me.ToolStripButton1.Text = "عرض الكل"
        Me.ToolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "AcountingRp"
        ReportDataSource1.Value = Me.InBoxDetailAcountBindingSource
        ReportDataSource2.Name = "BatchsDataSet"
        ReportDataSource2.Value = Me.BatchsBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.DisplayName = "RepEng"
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "EngCooperation.Report2.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 91)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.PageCountMode = Microsoft.Reporting.WinForms.PageCountMode.Actual
        Me.ReportViewer1.Size = New System.Drawing.Size(787, 558)
        Me.ReportViewer1.TabIndex = 5
        '
        'FrmTreeAcount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.ClientSize = New System.Drawing.Size(787, 707)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.FillByKindToolStrip)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmTreeAcount"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.Text = "شجرة الحسابات"
        CType(Me.InBoxDetailAcountBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AcountingDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BatchsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BatchesDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.FillByKindToolStrip.ResumeLayout(False)
        Me.FillByKindToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents InBoxDetailAcountBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AcountingDataSet As EngCooperation.AcountingDataSet
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Dt2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Dt1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents InBoxDetailAcountTableAdapter As EngCooperation.AcountingDataSetTableAdapters.InBoxDetailAcountTableAdapter
    Friend WithEvents TableAdapterManager As EngCooperation.AcountingDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents BatchesDataSet As EngCooperation.BatchesDataSet
    Friend WithEvents BatchsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BatchsTableAdapter As EngCooperation.BatchesDataSetTableAdapters.BatchsTableAdapter
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents FillByKindToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents KindToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents KindToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents FillByKindToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
End Class
