<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEstadisticaOS
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
        Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource4 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.DataSetEsadisticasOSPruebaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetEsadisticasOSPrueba = New ConsultorioOdontologico.DataSetEsadisticasOSPrueba()
        Me.DataSetEstadisticaOSStoredPBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetEstadisticaOSStoredP = New ConsultorioOdontologico.DataSetEstadisticaOSStoredP()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.lbEdadDesde = New System.Windows.Forms.Label()
        Me.lblSexo = New System.Windows.Forms.Label()
        Me.cmbSexo = New System.Windows.Forms.ComboBox()
        Me.cmdConsultar = New System.Windows.Forms.Button()
        Me.lblEdadHasta = New System.Windows.Forms.Label()
        Me.cmdConsult = New System.Windows.Forms.Button()
        Me.ObraSocialBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ObraSocialTableAdapter = New ConsultorioOdontologico.DataSetEsadisticasOSPruebaTableAdapters.ObraSocialTableAdapter()
        Me.mtxtEdadDesde = New System.Windows.Forms.MaskedTextBox()
        Me.mtxtEdadHasta = New System.Windows.Forms.MaskedTextBox()
        CType(Me.DataSetEsadisticasOSPruebaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetEsadisticasOSPrueba, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetEstadisticaOSStoredPBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetEstadisticaOSStoredP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ObraSocialBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataSetEsadisticasOSPruebaBindingSource
        '
        Me.DataSetEsadisticasOSPruebaBindingSource.DataSource = Me.DataSetEsadisticasOSPrueba
        Me.DataSetEsadisticasOSPruebaBindingSource.Position = 0
        '
        'DataSetEsadisticasOSPrueba
        '
        Me.DataSetEsadisticasOSPrueba.DataSetName = "DataSetEsadisticasOSPrueba"
        Me.DataSetEsadisticasOSPrueba.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataSetEstadisticaOSStoredPBindingSource
        '
        Me.DataSetEstadisticaOSStoredPBindingSource.DataSource = Me.DataSetEstadisticaOSStoredP
        Me.DataSetEstadisticaOSStoredPBindingSource.Position = 0
        '
        'DataSetEstadisticaOSStoredP
        '
        Me.DataSetEstadisticaOSStoredP.DataSetName = "DataSetEstadisticaOSStoredP"
        Me.DataSetEstadisticaOSStoredP.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ReportDataSource3.Name = "DataSet1"
        ReportDataSource3.Value = Me.DataSetEsadisticasOSPruebaBindingSource
        ReportDataSource4.Name = "DataSetOS"
        ReportDataSource4.Value = Me.DataSetEstadisticaOSStoredPBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource3)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource4)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "ConsultorioOdontologico.EstadisticaOS2.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(-1, -1)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(637, 318)
        Me.ReportViewer1.TabIndex = 0
        '
        'lbEdadDesde
        '
        Me.lbEdadDesde.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbEdadDesde.AutoSize = True
        Me.lbEdadDesde.Location = New System.Drawing.Point(185, 339)
        Me.lbEdadDesde.Name = "lbEdadDesde"
        Me.lbEdadDesde.Size = New System.Drawing.Size(67, 13)
        Me.lbEdadDesde.TabIndex = 13
        Me.lbEdadDesde.Text = "Edad desde:"
        '
        'lblSexo
        '
        Me.lblSexo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblSexo.AutoSize = True
        Me.lblSexo.Location = New System.Drawing.Point(12, 339)
        Me.lblSexo.Name = "lblSexo"
        Me.lblSexo.Size = New System.Drawing.Size(31, 13)
        Me.lblSexo.TabIndex = 12
        Me.lblSexo.Text = "Sexo"
        '
        'cmbSexo
        '
        Me.cmbSexo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSexo.FormattingEnabled = True
        Me.cmbSexo.Items.AddRange(New Object() {"Masculino", "Femenino", "Ambos"})
        Me.cmbSexo.Location = New System.Drawing.Point(12, 355)
        Me.cmbSexo.Name = "cmbSexo"
        Me.cmbSexo.Size = New System.Drawing.Size(121, 21)
        Me.cmbSexo.TabIndex = 11
        '
        'cmdConsultar
        '
        Me.cmdConsultar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdConsultar.Location = New System.Drawing.Point(701, 397)
        Me.cmdConsultar.Name = "cmdConsultar"
        Me.cmdConsultar.Size = New System.Drawing.Size(75, 23)
        Me.cmdConsultar.TabIndex = 10
        Me.cmdConsultar.Text = "Consultar"
        Me.cmdConsultar.UseVisualStyleBackColor = True
        '
        'lblEdadHasta
        '
        Me.lblEdadHasta.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblEdadHasta.AutoSize = True
        Me.lblEdadHasta.Location = New System.Drawing.Point(339, 339)
        Me.lblEdadHasta.Name = "lblEdadHasta"
        Me.lblEdadHasta.Size = New System.Drawing.Size(64, 13)
        Me.lblEdadHasta.TabIndex = 20
        Me.lblEdadHasta.Text = "Edad hasta:"
        '
        'cmdConsult
        '
        Me.cmdConsult.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdConsult.Location = New System.Drawing.Point(539, 391)
        Me.cmdConsult.Name = "cmdConsult"
        Me.cmdConsult.Size = New System.Drawing.Size(75, 23)
        Me.cmdConsult.TabIndex = 21
        Me.cmdConsult.Text = "Consultar"
        Me.cmdConsult.UseVisualStyleBackColor = True
        '
        'ObraSocialBindingSource
        '
        Me.ObraSocialBindingSource.DataMember = "ObraSocial"
        Me.ObraSocialBindingSource.DataSource = Me.DataSetEsadisticasOSPruebaBindingSource
        '
        'ObraSocialTableAdapter
        '
        Me.ObraSocialTableAdapter.ClearBeforeFill = True
        '
        'mtxtEdadDesde
        '
        Me.mtxtEdadDesde.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.mtxtEdadDesde.Location = New System.Drawing.Point(188, 355)
        Me.mtxtEdadDesde.Name = "mtxtEdadDesde"
        Me.mtxtEdadDesde.Size = New System.Drawing.Size(100, 20)
        Me.mtxtEdadDesde.TabIndex = 22
        '
        'mtxtEdadHasta
        '
        Me.mtxtEdadHasta.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.mtxtEdadHasta.Location = New System.Drawing.Point(342, 355)
        Me.mtxtEdadHasta.Name = "mtxtEdadHasta"
        Me.mtxtEdadHasta.Size = New System.Drawing.Size(100, 20)
        Me.mtxtEdadHasta.TabIndex = 23
        '
        'frmEstadisticaOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(638, 438)
        Me.Controls.Add(Me.mtxtEdadHasta)
        Me.Controls.Add(Me.mtxtEdadDesde)
        Me.Controls.Add(Me.cmdConsult)
        Me.Controls.Add(Me.lblEdadHasta)
        Me.Controls.Add(Me.lbEdadDesde)
        Me.Controls.Add(Me.lblSexo)
        Me.Controls.Add(Me.cmbSexo)
        Me.Controls.Add(Me.cmdConsultar)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "frmEstadisticaOS"
        Me.Text = "frmEstadisticaOS"
        CType(Me.DataSetEsadisticasOSPruebaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetEsadisticasOSPrueba, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetEstadisticaOSStoredPBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetEstadisticaOSStoredP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ObraSocialBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents lbEdadDesde As System.Windows.Forms.Label
    Friend WithEvents lblSexo As System.Windows.Forms.Label
    Friend WithEvents cmbSexo As System.Windows.Forms.ComboBox
    Friend WithEvents cmdConsultar As System.Windows.Forms.Button
    Friend WithEvents lblEdadHasta As System.Windows.Forms.Label
    Friend WithEvents cmdConsult As System.Windows.Forms.Button
    Friend WithEvents DataSetEsadisticasOSPrueba As ConsultorioOdontologico.DataSetEsadisticasOSPrueba
    Friend WithEvents DataSetEsadisticasOSPruebaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ObraSocialBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ObraSocialTableAdapter As ConsultorioOdontologico.DataSetEsadisticasOSPruebaTableAdapters.ObraSocialTableAdapter
    Friend WithEvents DataSetEstadisticaOSStoredPBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataSetEstadisticaOSStoredP As ConsultorioOdontologico.DataSetEstadisticaOSStoredP
    Friend WithEvents mtxtEdadDesde As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mtxtEdadHasta As System.Windows.Forms.MaskedTextBox
End Class
