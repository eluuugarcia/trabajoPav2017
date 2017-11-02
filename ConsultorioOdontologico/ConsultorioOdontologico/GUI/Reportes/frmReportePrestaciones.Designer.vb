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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.DataSetPrestaciones = New ConsultorioOdontologico.DataSetPrestaciones()
        Me.PrestacionesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PrestacionesTableAdapter = New ConsultorioOdontologico.DataSetPrestacionesTableAdapters.PrestacionesTableAdapter()
        CType(Me.DataSetPrestaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrestacionesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSetPrestaciones"
        ReportDataSource1.Value = Me.PrestacionesBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "ConsultorioOdontologico.reportePrestaciones.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(521, 428)
        Me.ReportViewer1.TabIndex = 0
        '
        'DataSetPrestaciones
        '
        Me.DataSetPrestaciones.DataSetName = "DataSetPrestaciones"
        Me.DataSetPrestaciones.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PrestacionesBindingSource
        '
        Me.PrestacionesBindingSource.DataMember = "Prestaciones"
        Me.PrestacionesBindingSource.DataSource = Me.DataSetPrestaciones
        '
        'PrestacionesTableAdapter
        '
        Me.PrestacionesTableAdapter.ClearBeforeFill = True
        '
        'frmReportePrestaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(521, 428)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "frmReportePrestaciones"
        Me.Text = "frmReportePrestaciones"
        CType(Me.DataSetPrestaciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrestacionesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents PrestacionesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataSetPrestaciones As ConsultorioOdontologico.DataSetPrestaciones
    Friend WithEvents PrestacionesTableAdapter As ConsultorioOdontologico.DataSetPrestacionesTableAdapters.PrestacionesTableAdapter
End Class
