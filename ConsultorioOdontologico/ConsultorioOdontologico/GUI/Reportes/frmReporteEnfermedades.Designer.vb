<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReporteEnfermedades
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
        Me.DataSetEnfermedades = New ConsultorioOdontologico.DataSetEnfermedades()
        Me.EnfermedadesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EnfermedadesTableAdapter = New ConsultorioOdontologico.DataSetEnfermedadesTableAdapters.EnfermedadesTableAdapter()
        CType(Me.DataSetEnfermedades, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EnfermedadesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSetEnfermedades"
        ReportDataSource1.Value = Me.EnfermedadesBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "ConsultorioOdontologico.RreporteEnfermedades.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(565, 418)
        Me.ReportViewer1.TabIndex = 0
        '
        'DataSetEnfermedades
        '
        Me.DataSetEnfermedades.DataSetName = "DataSetEnfermedades"
        Me.DataSetEnfermedades.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EnfermedadesBindingSource
        '
        Me.EnfermedadesBindingSource.DataMember = "Enfermedades"
        Me.EnfermedadesBindingSource.DataSource = Me.DataSetEnfermedades
        '
        'EnfermedadesTableAdapter
        '
        Me.EnfermedadesTableAdapter.ClearBeforeFill = True
        '
        'frmReporteEnfermedades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(565, 418)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "frmReporteEnfermedades"
        Me.Text = "frmReporteEnfermedades"
        CType(Me.DataSetEnfermedades, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EnfermedadesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents EnfermedadesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataSetEnfermedades As ConsultorioOdontologico.DataSetEnfermedades
    Friend WithEvents EnfermedadesTableAdapter As ConsultorioOdontologico.DataSetEnfermedadesTableAdapters.EnfermedadesTableAdapter
End Class
