<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormReport
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
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.VendedorQueryToolStrip = New System.Windows.Forms.ToolStrip()
        Me.VendedorToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.VendedorToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.VendedorQueryToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.tb_compraBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.papelariaDBDataSet = New Sistema_Papelaria.papelariaDBDataSet()
        Me.tb_compraTableAdapter = New Sistema_Papelaria.papelariaDBDataSetTableAdapters.tb_compraTableAdapter()
        Me.VendedorQueryToolStrip.SuspendLayout()
        CType(Me.tb_compraBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.papelariaDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource2.Name = "RelatorioAdminComum"
        ReportDataSource2.Value = Me.tb_compraBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Sistema_Papelaria.Report1.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(525, 392)
        Me.ReportViewer1.TabIndex = 0
        '
        'VendedorQueryToolStrip
        '
        Me.VendedorQueryToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VendedorToolStripLabel, Me.VendedorToolStripTextBox, Me.VendedorQueryToolStripButton})
        Me.VendedorQueryToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.VendedorQueryToolStrip.Name = "VendedorQueryToolStrip"
        Me.VendedorQueryToolStrip.Size = New System.Drawing.Size(525, 25)
        Me.VendedorQueryToolStrip.TabIndex = 1
        Me.VendedorQueryToolStrip.Text = "VendedorQueryToolStrip"
        '
        'VendedorToolStripLabel
        '
        Me.VendedorToolStripLabel.Name = "VendedorToolStripLabel"
        Me.VendedorToolStripLabel.Size = New System.Drawing.Size(61, 22)
        Me.VendedorToolStripLabel.Text = "Vendedor:"
        '
        'VendedorToolStripTextBox
        '
        Me.VendedorToolStripTextBox.Name = "VendedorToolStripTextBox"
        Me.VendedorToolStripTextBox.Size = New System.Drawing.Size(100, 25)
        '
        'VendedorQueryToolStripButton
        '
        Me.VendedorQueryToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.VendedorQueryToolStripButton.Name = "VendedorQueryToolStripButton"
        Me.VendedorQueryToolStripButton.Size = New System.Drawing.Size(61, 22)
        Me.VendedorQueryToolStripButton.Text = "Pesquisar"
        '
        'tb_compraBindingSource
        '
        Me.tb_compraBindingSource.DataMember = "tb_compra"
        Me.tb_compraBindingSource.DataSource = Me.papelariaDBDataSet
        '
        'papelariaDBDataSet
        '
        Me.papelariaDBDataSet.DataSetName = "papelariaDBDataSet"
        Me.papelariaDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'tb_compraTableAdapter
        '
        Me.tb_compraTableAdapter.ClearBeforeFill = True
        '
        'FormReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(525, 392)
        Me.Controls.Add(Me.VendedorQueryToolStrip)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "FormReport"
        Me.Text = "Relatório"
        Me.VendedorQueryToolStrip.ResumeLayout(False)
        Me.VendedorQueryToolStrip.PerformLayout()
        CType(Me.tb_compraBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.papelariaDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents tb_compraBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents papelariaDBDataSet As Sistema_Papelaria.papelariaDBDataSet
    Friend WithEvents tb_compraTableAdapter As Sistema_Papelaria.papelariaDBDataSetTableAdapters.tb_compraTableAdapter
    Friend WithEvents VendedorQueryToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents VendedorToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents VendedorToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents VendedorQueryToolStripButton As System.Windows.Forms.ToolStripButton
End Class
