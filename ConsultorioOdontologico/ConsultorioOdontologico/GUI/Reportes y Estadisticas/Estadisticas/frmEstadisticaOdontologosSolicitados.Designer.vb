<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEstadisticaOdontologosSolicitados
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
        Me.DataSetOdontologosPorTurnosMSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetOdontologosPorTurnosMS = New ConsultorioOdontologico.DataSetOdontologosPorTurnosMS()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.mtxtFechaHasta = New System.Windows.Forms.MaskedTextBox()
        Me.mtxtFechaDesde = New System.Windows.Forms.MaskedTextBox()
        Me.cmdConsult = New System.Windows.Forms.Button()
        Me.lblFechaHasta = New System.Windows.Forms.Label()
        Me.lbFechaDesde = New System.Windows.Forms.Label()
        Me.lblPrestacion = New System.Windows.Forms.Label()
        Me.cmbPrestacion = New System.Windows.Forms.ComboBox()
        Me.Db_consultorio_odontologicoDataSet = New ConsultorioOdontologico.db_consultorio_odontologicoDataSet()
        Me.DbconsultorioodontologicoDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbconsultorioodontologicoDataSetBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetOdontologosSolicitados2 = New ConsultorioOdontologico.DataSetOdontologosSolicitados2()
        Me.odontologosPorTurnosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.odontologosPorTurnosTableAdapter = New ConsultorioOdontologico.DataSetOdontologosSolicitados2TableAdapters.odontologosPorTurnosTableAdapter()
        CType(Me.DataSetOdontologosPorTurnosMSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetOdontologosPorTurnosMS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Db_consultorio_odontologicoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbconsultorioodontologicoDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbconsultorioodontologicoDataSetBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetOdontologosSolicitados2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.odontologosPorTurnosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataSetOdontologosPorTurnosMSBindingSource
        '
        Me.DataSetOdontologosPorTurnosMSBindingSource.DataSource = Me.DataSetOdontologosPorTurnosMS
        Me.DataSetOdontologosPorTurnosMSBindingSource.Position = 0
        '
        'DataSetOdontologosPorTurnosMS
        '
        Me.DataSetOdontologosPorTurnosMS.DataSetName = "DataSetOdontologosPorTurnosMS"
        Me.DataSetOdontologosPorTurnosMS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ReportDataSource2.Name = "DataSet1"
        ReportDataSource2.Value = Me.DataSetOdontologosPorTurnosMSBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "ConsultorioOdontologico.EstadisticaOdontologosSolicitados.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 1)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(637, 318)
        Me.ReportViewer1.TabIndex = 1
        '
        'mtxtFechaHasta
        '
        Me.mtxtFechaHasta.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.mtxtFechaHasta.Location = New System.Drawing.Point(342, 360)
        Me.mtxtFechaHasta.Mask = "00/00/0000"
        Me.mtxtFechaHasta.Name = "mtxtFechaHasta"
        Me.mtxtFechaHasta.Size = New System.Drawing.Size(100, 20)
        Me.mtxtFechaHasta.TabIndex = 30
        Me.mtxtFechaHasta.ValidatingType = GetType(Date)
        '
        'mtxtFechaDesde
        '
        Me.mtxtFechaDesde.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.mtxtFechaDesde.Location = New System.Drawing.Point(188, 360)
        Me.mtxtFechaDesde.Mask = "00/00/0000"
        Me.mtxtFechaDesde.Name = "mtxtFechaDesde"
        Me.mtxtFechaDesde.Size = New System.Drawing.Size(100, 20)
        Me.mtxtFechaDesde.TabIndex = 29
        Me.mtxtFechaDesde.ValidatingType = GetType(Date)
        '
        'cmdConsult
        '
        Me.cmdConsult.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdConsult.Location = New System.Drawing.Point(539, 391)
        Me.cmdConsult.Name = "cmdConsult"
        Me.cmdConsult.Size = New System.Drawing.Size(75, 23)
        Me.cmdConsult.TabIndex = 28
        Me.cmdConsult.Text = "Consultar"
        Me.cmdConsult.UseVisualStyleBackColor = True
        '
        'lblFechaHasta
        '
        Me.lblFechaHasta.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblFechaHasta.AutoSize = True
        Me.lblFechaHasta.Location = New System.Drawing.Point(339, 344)
        Me.lblFechaHasta.Name = "lblFechaHasta"
        Me.lblFechaHasta.Size = New System.Drawing.Size(69, 13)
        Me.lblFechaHasta.TabIndex = 27
        Me.lblFechaHasta.Text = "Fecha hasta:"
        '
        'lbFechaDesde
        '
        Me.lbFechaDesde.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbFechaDesde.AutoSize = True
        Me.lbFechaDesde.Location = New System.Drawing.Point(185, 344)
        Me.lbFechaDesde.Name = "lbFechaDesde"
        Me.lbFechaDesde.Size = New System.Drawing.Size(72, 13)
        Me.lbFechaDesde.TabIndex = 26
        Me.lbFechaDesde.Text = "Fecha desde:"
        '
        'lblPrestacion
        '
        Me.lblPrestacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblPrestacion.AutoSize = True
        Me.lblPrestacion.Location = New System.Drawing.Point(12, 344)
        Me.lblPrestacion.Name = "lblPrestacion"
        Me.lblPrestacion.Size = New System.Drawing.Size(57, 13)
        Me.lblPrestacion.TabIndex = 25
        Me.lblPrestacion.Text = "Prestacion"
        '
        'cmbPrestacion
        '
        Me.cmbPrestacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmbPrestacion.FormattingEnabled = True
        Me.cmbPrestacion.Location = New System.Drawing.Point(12, 360)
        Me.cmbPrestacion.Name = "cmbPrestacion"
        Me.cmbPrestacion.Size = New System.Drawing.Size(121, 21)
        Me.cmbPrestacion.TabIndex = 24
        '
        'Db_consultorio_odontologicoDataSet
        '
        Me.Db_consultorio_odontologicoDataSet.DataSetName = "db_consultorio_odontologicoDataSet"
        Me.Db_consultorio_odontologicoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DbconsultorioodontologicoDataSetBindingSource
        '
        Me.DbconsultorioodontologicoDataSetBindingSource.DataSource = Me.Db_consultorio_odontologicoDataSet
        Me.DbconsultorioodontologicoDataSetBindingSource.Position = 0
        '
        'DbconsultorioodontologicoDataSetBindingSource1
        '
        Me.DbconsultorioodontologicoDataSetBindingSource1.DataSource = Me.Db_consultorio_odontologicoDataSet
        Me.DbconsultorioodontologicoDataSetBindingSource1.Position = 0
        '
        'DataSetOdontologosSolicitados2
        '
        Me.DataSetOdontologosSolicitados2.DataSetName = "DataSetOdontologosSolicitados2"
        Me.DataSetOdontologosSolicitados2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'odontologosPorTurnosBindingSource
        '
        Me.odontologosPorTurnosBindingSource.DataMember = "odontologosPorTurnos"
        Me.odontologosPorTurnosBindingSource.DataSource = Me.DataSetOdontologosSolicitados2
        '
        'odontologosPorTurnosTableAdapter
        '
        Me.odontologosPorTurnosTableAdapter.ClearBeforeFill = True
        '
        'frmEstadisticaOdontologosSolicitados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(638, 438)
        Me.Controls.Add(Me.mtxtFechaHasta)
        Me.Controls.Add(Me.mtxtFechaDesde)
        Me.Controls.Add(Me.cmdConsult)
        Me.Controls.Add(Me.lblFechaHasta)
        Me.Controls.Add(Me.lbFechaDesde)
        Me.Controls.Add(Me.lblPrestacion)
        Me.Controls.Add(Me.cmbPrestacion)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "frmEstadisticaOdontologosSolicitados"
        Me.Text = "frmEstadisticaOdontologosSolicitados"
        CType(Me.DataSetOdontologosPorTurnosMSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetOdontologosPorTurnosMS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Db_consultorio_odontologicoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbconsultorioodontologicoDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbconsultorioodontologicoDataSetBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetOdontologosSolicitados2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.odontologosPorTurnosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents mtxtFechaHasta As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mtxtFechaDesde As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cmdConsult As System.Windows.Forms.Button
    Friend WithEvents lblFechaHasta As System.Windows.Forms.Label
    Friend WithEvents lbFechaDesde As System.Windows.Forms.Label
    Friend WithEvents lblPrestacion As System.Windows.Forms.Label
    Friend WithEvents cmbPrestacion As System.Windows.Forms.ComboBox
    Friend WithEvents DataSetOdontologosPorTurnosMSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataSetOdontologosPorTurnosMS As ConsultorioOdontologico.DataSetOdontologosPorTurnosMS
    Friend WithEvents Db_consultorio_odontologicoDataSet As ConsultorioOdontologico.db_consultorio_odontologicoDataSet
    Friend WithEvents DbconsultorioodontologicoDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DbconsultorioodontologicoDataSetBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents odontologosPorTurnosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataSetOdontologosSolicitados2 As ConsultorioOdontologico.DataSetOdontologosSolicitados2
    Friend WithEvents odontologosPorTurnosTableAdapter As ConsultorioOdontologico.DataSetOdontologosSolicitados2TableAdapters.odontologosPorTurnosTableAdapter
End Class
