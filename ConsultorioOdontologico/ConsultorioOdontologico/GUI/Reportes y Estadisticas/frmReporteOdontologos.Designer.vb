<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReporteOdontologos
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
        Me.OdontologosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.mtxtFechaHasta = New System.Windows.Forms.MaskedTextBox()
        Me.mtxtFechaDesde = New System.Windows.Forms.MaskedTextBox()
        Me.lblOrdenarPor = New System.Windows.Forms.Label()
        Me.cmbOrden = New System.Windows.Forms.ComboBox()
        Me.lblFechaHasta = New System.Windows.Forms.Label()
        Me.lblFechaDesde = New System.Windows.Forms.Label()
        Me.lblSexo = New System.Windows.Forms.Label()
        Me.cmbSexo = New System.Windows.Forms.ComboBox()
        Me.cmdConsultar = New System.Windows.Forms.Button()
        Me.lblEspecialidades = New System.Windows.Forms.Label()
        Me.cmbEspecialidad = New System.Windows.Forms.ComboBox()
        CType(Me.OdontologosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ReportDataSource1.Name = "Odontologos"
        ReportDataSource1.Value = Me.OdontologosBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "ConsultorioOdontologico.reporteOdontologos.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(-5, 16)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(702, 284)
        Me.ReportViewer1.TabIndex = 0
        '
        'mtxtFechaHasta
        '
        Me.mtxtFechaHasta.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.mtxtFechaHasta.Location = New System.Drawing.Point(238, 385)
        Me.mtxtFechaHasta.Mask = "00/00/0000"
        Me.mtxtFechaHasta.Name = "mtxtFechaHasta"
        Me.mtxtFechaHasta.Size = New System.Drawing.Size(100, 20)
        Me.mtxtFechaHasta.TabIndex = 18
        Me.mtxtFechaHasta.ValidatingType = GetType(Date)
        '
        'mtxtFechaDesde
        '
        Me.mtxtFechaDesde.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.mtxtFechaDesde.Location = New System.Drawing.Point(9, 385)
        Me.mtxtFechaDesde.Mask = "00/00/0000"
        Me.mtxtFechaDesde.Name = "mtxtFechaDesde"
        Me.mtxtFechaDesde.Size = New System.Drawing.Size(100, 20)
        Me.mtxtFechaDesde.TabIndex = 17
        Me.mtxtFechaDesde.ValidatingType = GetType(Date)
        '
        'lblOrdenarPor
        '
        Me.lblOrdenarPor.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblOrdenarPor.AutoSize = True
        Me.lblOrdenarPor.Location = New System.Drawing.Point(238, 311)
        Me.lblOrdenarPor.Name = "lblOrdenarPor"
        Me.lblOrdenarPor.Size = New System.Drawing.Size(64, 13)
        Me.lblOrdenarPor.TabIndex = 16
        Me.lblOrdenarPor.Text = "Ordenar Por"
        '
        'cmbOrden
        '
        Me.cmbOrden.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock
        Me.cmbOrden.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmbOrden.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbOrden.FormattingEnabled = True
        Me.cmbOrden.Items.AddRange(New Object() {"Legajo", "DNI", "Apellido", "Nombre", "Fecha de Nacimiento", "Fecha de Ingreso"})
        Me.cmbOrden.Location = New System.Drawing.Point(238, 327)
        Me.cmbOrden.Name = "cmbOrden"
        Me.cmbOrden.Size = New System.Drawing.Size(121, 21)
        Me.cmbOrden.TabIndex = 15
        '
        'lblFechaHasta
        '
        Me.lblFechaHasta.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblFechaHasta.AutoSize = True
        Me.lblFechaHasta.Location = New System.Drawing.Point(235, 369)
        Me.lblFechaHasta.Name = "lblFechaHasta"
        Me.lblFechaHasta.Size = New System.Drawing.Size(138, 13)
        Me.lblFechaHasta.TabIndex = 14
        Me.lblFechaHasta.Text = "Fecha de nacimiento hasta:"
        '
        'lblFechaDesde
        '
        Me.lblFechaDesde.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblFechaDesde.AutoSize = True
        Me.lblFechaDesde.Location = New System.Drawing.Point(6, 369)
        Me.lblFechaDesde.Name = "lblFechaDesde"
        Me.lblFechaDesde.Size = New System.Drawing.Size(141, 13)
        Me.lblFechaDesde.TabIndex = 13
        Me.lblFechaDesde.Text = "Fecha de nacimiento desde:"
        '
        'lblSexo
        '
        Me.lblSexo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblSexo.AutoSize = True
        Me.lblSexo.Location = New System.Drawing.Point(6, 311)
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
        Me.cmbSexo.Location = New System.Drawing.Point(6, 327)
        Me.cmbSexo.Name = "cmbSexo"
        Me.cmbSexo.Size = New System.Drawing.Size(121, 21)
        Me.cmbSexo.TabIndex = 11
        '
        'cmdConsultar
        '
        Me.cmdConsultar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdConsultar.Location = New System.Drawing.Point(611, 413)
        Me.cmdConsultar.Name = "cmdConsultar"
        Me.cmdConsultar.Size = New System.Drawing.Size(75, 23)
        Me.cmdConsultar.TabIndex = 10
        Me.cmdConsultar.Text = "Consultar"
        Me.cmdConsultar.UseVisualStyleBackColor = True
        '
        'lblEspecialidades
        '
        Me.lblEspecialidades.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblEspecialidades.AutoSize = True
        Me.lblEspecialidades.Location = New System.Drawing.Point(463, 311)
        Me.lblEspecialidades.Name = "lblEspecialidades"
        Me.lblEspecialidades.Size = New System.Drawing.Size(67, 13)
        Me.lblEspecialidades.TabIndex = 30
        Me.lblEspecialidades.Text = "Especialidad"
        '
        'cmbEspecialidad
        '
        Me.cmbEspecialidad.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock
        Me.cmbEspecialidad.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmbEspecialidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEspecialidad.FormattingEnabled = True
        Me.cmbEspecialidad.Items.AddRange(New Object() {"DNI", "Apellido", "Nombre", "Fecha Nacimiento"})
        Me.cmbEspecialidad.Location = New System.Drawing.Point(466, 327)
        Me.cmbEspecialidad.Name = "cmbEspecialidad"
        Me.cmbEspecialidad.Size = New System.Drawing.Size(121, 21)
        Me.cmbEspecialidad.TabIndex = 31
        '
        'frmReporteOdontologos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(698, 448)
        Me.Controls.Add(Me.cmbEspecialidad)
        Me.Controls.Add(Me.lblEspecialidades)
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
        Me.Name = "frmReporteOdontologos"
        Me.Text = "frmReporteOdontologos"
        CType(Me.OdontologosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents OdontologosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents mtxtFechaHasta As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mtxtFechaDesde As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lblOrdenarPor As System.Windows.Forms.Label
    Friend WithEvents cmbOrden As System.Windows.Forms.ComboBox
    Friend WithEvents lblFechaHasta As System.Windows.Forms.Label
    Friend WithEvents lblFechaDesde As System.Windows.Forms.Label
    Friend WithEvents lblSexo As System.Windows.Forms.Label
    Friend WithEvents cmbSexo As System.Windows.Forms.ComboBox
    Friend WithEvents cmdConsultar As System.Windows.Forms.Button
    Friend WithEvents lblEspecialidades As System.Windows.Forms.Label
    Friend WithEvents cmbEspecialidad As System.Windows.Forms.ComboBox
End Class
