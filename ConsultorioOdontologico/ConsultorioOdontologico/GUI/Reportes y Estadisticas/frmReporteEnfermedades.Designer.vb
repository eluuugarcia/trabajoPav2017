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
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.EnfermedadesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetEnfermedades = New ConsultorioOdontologico.DataSetEnfermedades()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.EnfermedadesTableAdapter = New ConsultorioOdontologico.DataSetEnfermedadesTableAdapters.EnfermedadesTableAdapter()
        Me.cmdConsultar = New System.Windows.Forms.Button()
        CType(Me.EnfermedadesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetEnfermedades, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'EnfermedadesBindingSource
        '
        Me.EnfermedadesBindingSource.DataMember = "Enfermedades"
        Me.EnfermedadesBindingSource.DataSource = Me.DataSetEnfermedades
        '
        'DataSetEnfermedades
        '
        Me.DataSetEnfermedades.DataSetName = "DataSetEnfermedades"
        Me.DataSetEnfermedades.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ReportDataSource2.Name = "DataSetEnfermedades"
        ReportDataSource2.Value = Me.EnfermedadesBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "ConsultorioOdontologico.reporteEnfermedades.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(707, 295)
        Me.ReportViewer1.TabIndex = 0
        '
        'EnfermedadesTableAdapter
        '
        Me.EnfermedadesTableAdapter.ClearBeforeFill = True
        '
        'cmdConsultar
        '
        Me.cmdConsultar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdConsultar.Location = New System.Drawing.Point(616, 319)
        Me.cmdConsultar.Name = "cmdConsultar"
        Me.cmdConsultar.Size = New System.Drawing.Size(75, 23)
        Me.cmdConsultar.TabIndex = 11
        Me.cmdConsultar.Text = "Consultar"
        Me.cmdConsultar.UseVisualStyleBackColor = True
        '
        'frmReporteEnfermedades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(703, 363)
        Me.Controls.Add(Me.cmdConsultar)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "frmReporteEnfermedades"
        Me.Text = "frmReporteEnfermedades"
        CType(Me.EnfermedadesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetEnfermedades, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents EnfermedadesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataSetEnfermedades As ConsultorioOdontologico.DataSetEnfermedades
    Friend WithEvents EnfermedadesTableAdapter As ConsultorioOdontologico.DataSetEnfermedadesTableAdapters.EnfermedadesTableAdapter
    Friend WithEvents cmdConsultar As System.Windows.Forms.Button
End Class
