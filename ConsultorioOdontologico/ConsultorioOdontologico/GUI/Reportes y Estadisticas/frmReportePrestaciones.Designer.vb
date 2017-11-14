<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReportePrestaciones
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
        Me.PrestacionesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetPrestaciones = New ConsultorioOdontologico.DataSetPrestaciones()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.PrestacionesTableAdapter = New ConsultorioOdontologico.DataSetPrestacionesTableAdapters.PrestacionesTableAdapter()
        Me.cmdConsultar = New System.Windows.Forms.Button()
        CType(Me.PrestacionesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetPrestaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PrestacionesBindingSource
        '
        Me.PrestacionesBindingSource.DataMember = "Prestaciones"
        Me.PrestacionesBindingSource.DataSource = Me.DataSetPrestaciones
        '
        'DataSetPrestaciones
        '
        Me.DataSetPrestaciones.DataSetName = "DataSetPrestaciones"
        Me.DataSetPrestaciones.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ReportDataSource2.Name = "DataSetPrestaciones"
        ReportDataSource2.Value = Me.PrestacionesBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "ConsultorioOdontologico.reportePrestaciones.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(707, 295)
        Me.ReportViewer1.TabIndex = 0
        '
        'PrestacionesTableAdapter
        '
        Me.PrestacionesTableAdapter.ClearBeforeFill = True
        '
        'cmdConsultar
        '
        Me.cmdConsultar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdConsultar.Location = New System.Drawing.Point(616, 318)
        Me.cmdConsultar.Name = "cmdConsultar"
        Me.cmdConsultar.Size = New System.Drawing.Size(75, 23)
        Me.cmdConsultar.TabIndex = 10
        Me.cmdConsultar.Text = "Consultar"
        Me.cmdConsultar.UseVisualStyleBackColor = True
        '
        'frmReportePrestaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(703, 363)
        Me.Controls.Add(Me.cmdConsultar)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "frmReportePrestaciones"
        Me.Text = "Prestaciones"
        CType(Me.PrestacionesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetPrestaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents PrestacionesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataSetPrestaciones As ConsultorioOdontologico.DataSetPrestaciones
    Friend WithEvents PrestacionesTableAdapter As ConsultorioOdontologico.DataSetPrestacionesTableAdapters.PrestacionesTableAdapter
    Friend WithEvents cmdConsultar As System.Windows.Forms.Button
End Class
