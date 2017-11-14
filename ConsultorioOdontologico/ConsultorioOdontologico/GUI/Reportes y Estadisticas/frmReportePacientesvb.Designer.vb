<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReportePacientesvb
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
        Me.PacientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetPacientes = New ConsultorioOdontologico.DataSetPacientes()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.cmdConsultar = New System.Windows.Forms.Button()
        Me.cmbSexo = New System.Windows.Forms.ComboBox()
        Me.lblSexo = New System.Windows.Forms.Label()
        Me.PacientesTableAdapter = New ConsultorioOdontologico.DataSetPacientesTableAdapters.PacientesTableAdapter()
        Me.lblFechaDesde = New System.Windows.Forms.Label()
        Me.lblFechaHasta = New System.Windows.Forms.Label()
        Me.lblOrdenarPor = New System.Windows.Forms.Label()
        Me.cmbOrden = New System.Windows.Forms.ComboBox()
        Me.mtxtFechaDesde = New System.Windows.Forms.MaskedTextBox()
        Me.mtxtFechaHasta = New System.Windows.Forms.MaskedTextBox()
        CType(Me.PacientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetPacientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PacientesBindingSource
        '
        Me.PacientesBindingSource.DataMember = "Pacientes"
        Me.PacientesBindingSource.DataSource = Me.DataSetPacientes
        '
        'DataSetPacientes
        '
        Me.DataSetPacientes.DataSetName = "DataSetPacientes"
        Me.DataSetPacientes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ReportDataSource1.Name = "DataSetPacientes"
        ReportDataSource1.Value = Me.PacientesBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "ConsultorioOdontologico.reportePacientes.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(707, 295)
        Me.ReportViewer1.TabIndex = 0
        '
        'cmdConsultar
        '
        Me.cmdConsultar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdConsultar.Location = New System.Drawing.Point(616, 387)
        Me.cmdConsultar.Name = "cmdConsultar"
        Me.cmdConsultar.Size = New System.Drawing.Size(75, 23)
        Me.cmdConsultar.TabIndex = 1
        Me.cmdConsultar.Text = "Consultar"
        Me.cmdConsultar.UseVisualStyleBackColor = True
        '
        'cmbSexo
        '
        Me.cmbSexo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSexo.FormattingEnabled = True
        Me.cmbSexo.Items.AddRange(New Object() {"Masculino", "Femenino", "Ambos"})
        Me.cmbSexo.Location = New System.Drawing.Point(12, 334)
        Me.cmbSexo.Name = "cmbSexo"
        Me.cmbSexo.Size = New System.Drawing.Size(121, 21)
        Me.cmbSexo.TabIndex = 2
        '
        'lblSexo
        '
        Me.lblSexo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblSexo.AutoSize = True
        Me.lblSexo.Location = New System.Drawing.Point(12, 318)
        Me.lblSexo.Name = "lblSexo"
        Me.lblSexo.Size = New System.Drawing.Size(31, 13)
        Me.lblSexo.TabIndex = 3
        Me.lblSexo.Text = "Sexo"
        '
        'PacientesTableAdapter
        '
        Me.PacientesTableAdapter.ClearBeforeFill = True
        '
        'lblFechaDesde
        '
        Me.lblFechaDesde.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblFechaDesde.AutoSize = True
        Me.lblFechaDesde.Location = New System.Drawing.Point(12, 376)
        Me.lblFechaDesde.Name = "lblFechaDesde"
        Me.lblFechaDesde.Size = New System.Drawing.Size(141, 13)
        Me.lblFechaDesde.TabIndex = 4
        Me.lblFechaDesde.Text = "Fecha de nacimiento desde:"
        '
        'lblFechaHasta
        '
        Me.lblFechaHasta.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblFechaHasta.AutoSize = True
        Me.lblFechaHasta.Location = New System.Drawing.Point(241, 376)
        Me.lblFechaHasta.Name = "lblFechaHasta"
        Me.lblFechaHasta.Size = New System.Drawing.Size(138, 13)
        Me.lblFechaHasta.TabIndex = 5
        Me.lblFechaHasta.Text = "Fecha de nacimiento hasta:"
        '
        'lblOrdenarPor
        '
        Me.lblOrdenarPor.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblOrdenarPor.AutoSize = True
        Me.lblOrdenarPor.Location = New System.Drawing.Point(244, 318)
        Me.lblOrdenarPor.Name = "lblOrdenarPor"
        Me.lblOrdenarPor.Size = New System.Drawing.Size(64, 13)
        Me.lblOrdenarPor.TabIndex = 7
        Me.lblOrdenarPor.Text = "Ordenar Por"
        '
        'cmbOrden
        '
        Me.cmbOrden.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock
        Me.cmbOrden.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmbOrden.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbOrden.FormattingEnabled = True
        Me.cmbOrden.Items.AddRange(New Object() {"DNI", "Apellido", "Nombre", "Fecha Nacimiento"})
        Me.cmbOrden.Location = New System.Drawing.Point(244, 334)
        Me.cmbOrden.Name = "cmbOrden"
        Me.cmbOrden.Size = New System.Drawing.Size(121, 21)
        Me.cmbOrden.TabIndex = 6
        '
        'mtxtFechaDesde
        '
        Me.mtxtFechaDesde.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.mtxtFechaDesde.Location = New System.Drawing.Point(15, 392)
        Me.mtxtFechaDesde.Mask = "00/00/0000"
        Me.mtxtFechaDesde.Name = "mtxtFechaDesde"
        Me.mtxtFechaDesde.Size = New System.Drawing.Size(100, 20)
        Me.mtxtFechaDesde.TabIndex = 8
        Me.mtxtFechaDesde.ValidatingType = GetType(Date)
        '
        'mtxtFechaHasta
        '
        Me.mtxtFechaHasta.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.mtxtFechaHasta.Location = New System.Drawing.Point(244, 392)
        Me.mtxtFechaHasta.Mask = "00/00/0000"
        Me.mtxtFechaHasta.Name = "mtxtFechaHasta"
        Me.mtxtFechaHasta.Size = New System.Drawing.Size(100, 20)
        Me.mtxtFechaHasta.TabIndex = 9
        Me.mtxtFechaHasta.ValidatingType = GetType(Date)
        '
        'frmReportePacientesvb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(703, 422)
        Me.Controls.Add(Me.mtxtFechaHasta)
        Me.Controls.Add(Me.mtxtFechaDesde)
        Me.Controls.Add(Me.lblOrdenarPor)
        Me.Controls.Add(Me.cmbOrden)
        Me.Controls.Add(Me.lblFechaHasta)
        Me.Controls.Add(Me.lblFechaDesde)
        Me.Controls.Add(Me.lblSexo)
        Me.Controls.Add(Me.cmbSexo)
        Me.Controls.Add(Me.cmdConsultar)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "frmReportePacientesvb"
        Me.Text = "frmReportePacientesvb"
        CType(Me.PacientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetPacientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents PacientesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataSetPacientes As ConsultorioOdontologico.DataSetPacientes
    Friend WithEvents PacientesTableAdapter As ConsultorioOdontologico.DataSetPacientesTableAdapters.PacientesTableAdapter
    Friend WithEvents cmdConsultar As System.Windows.Forms.Button
    Friend WithEvents cmbSexo As System.Windows.Forms.ComboBox
    Friend WithEvents lblSexo As System.Windows.Forms.Label
    Friend WithEvents lblFechaDesde As System.Windows.Forms.Label
    Friend WithEvents lblFechaHasta As System.Windows.Forms.Label
    Friend WithEvents lblOrdenarPor As System.Windows.Forms.Label
    Friend WithEvents cmbOrden As System.Windows.Forms.ComboBox
    Friend WithEvents mtxtFechaDesde As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mtxtFechaHasta As System.Windows.Forms.MaskedTextBox

End Class
