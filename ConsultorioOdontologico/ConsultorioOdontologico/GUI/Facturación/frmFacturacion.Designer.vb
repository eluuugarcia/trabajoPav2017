<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFacturacion
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
        Me.dgvTurnosNoFacturados = New System.Windows.Forms.DataGridView()
        Me.lblTurnosNoFacturados = New System.Windows.Forms.Label()
        Me.lblTurnosAFacturar = New System.Windows.Forms.Label()
        Me.dgvTurnosAFacturar = New System.Windows.Forms.DataGridView()
        Me.mtxtDNI = New System.Windows.Forms.MaskedTextBox()
        Me.Buscar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gbxDatosDeFactura = New System.Windows.Forms.GroupBox()
        Me.txtPlan = New System.Windows.Forms.TextBox()
        Me.lblPlan = New System.Windows.Forms.Label()
        Me.txtMontoTotal = New System.Windows.Forms.TextBox()
        Me.txtFecha = New System.Windows.Forms.TextBox()
        Me.txtOS = New System.Windows.Forms.TextBox()
        Me.txtPaciente = New System.Windows.Forms.TextBox()
        Me.txtNroFactura = New System.Windows.Forms.TextBox()
        Me.lblMonto = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbTipo = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmdAceptar = New System.Windows.Forms.Button()
        Me.FechaTurno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Hora = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idPrestacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Prestacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idOdontologo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Odontologo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Monto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idOS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idPlan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Hora2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idPrestacion2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Prestacion2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idOdontologo2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Odontologo2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Monto2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idOS2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idPlan2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvTurnosNoFacturados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvTurnosAFacturar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxDatosDeFactura.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvTurnosNoFacturados
        '
        Me.dgvTurnosNoFacturados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTurnosNoFacturados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FechaTurno, Me.Hora, Me.idPrestacion, Me.Prestacion, Me.idOdontologo, Me.Odontologo, Me.Monto, Me.idOS, Me.idPlan})
        Me.dgvTurnosNoFacturados.Location = New System.Drawing.Point(519, 51)
        Me.dgvTurnosNoFacturados.Name = "dgvTurnosNoFacturados"
        Me.dgvTurnosNoFacturados.Size = New System.Drawing.Size(441, 150)
        Me.dgvTurnosNoFacturados.TabIndex = 1
        '
        'lblTurnosNoFacturados
        '
        Me.lblTurnosNoFacturados.AutoSize = True
        Me.lblTurnosNoFacturados.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTurnosNoFacturados.Location = New System.Drawing.Point(520, 16)
        Me.lblTurnosNoFacturados.Name = "lblTurnosNoFacturados"
        Me.lblTurnosNoFacturados.Size = New System.Drawing.Size(160, 20)
        Me.lblTurnosNoFacturados.TabIndex = 2
        Me.lblTurnosNoFacturados.Text = "Turnos no facturados"
        '
        'lblTurnosAFacturar
        '
        Me.lblTurnosAFacturar.AutoSize = True
        Me.lblTurnosAFacturar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTurnosAFacturar.Location = New System.Drawing.Point(525, 223)
        Me.lblTurnosAFacturar.Name = "lblTurnosAFacturar"
        Me.lblTurnosAFacturar.Size = New System.Drawing.Size(130, 20)
        Me.lblTurnosAFacturar.TabIndex = 4
        Me.lblTurnosAFacturar.Text = "Turnos a facturar"
        '
        'dgvTurnosAFacturar
        '
        Me.dgvTurnosAFacturar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTurnosAFacturar.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Fecha2, Me.Hora2, Me.idPrestacion2, Me.Prestacion2, Me.idOdontologo2, Me.Odontologo2, Me.Monto2, Me.idOS2, Me.idPlan2})
        Me.dgvTurnosAFacturar.Location = New System.Drawing.Point(524, 258)
        Me.dgvTurnosAFacturar.Name = "dgvTurnosAFacturar"
        Me.dgvTurnosAFacturar.Size = New System.Drawing.Size(436, 150)
        Me.dgvTurnosAFacturar.TabIndex = 3
        '
        'mtxtDNI
        '
        Me.mtxtDNI.Location = New System.Drawing.Point(159, 52)
        Me.mtxtDNI.Name = "mtxtDNI"
        Me.mtxtDNI.Size = New System.Drawing.Size(141, 20)
        Me.mtxtDNI.TabIndex = 41
        '
        'Buscar
        '
        Me.Buscar.Location = New System.Drawing.Point(331, 51)
        Me.Buscar.Name = "Buscar"
        Me.Buscar.Size = New System.Drawing.Size(57, 23)
        Me.Buscar.TabIndex = 40
        Me.Buscar.Text = "Buscar"
        Me.Buscar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(106, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 16)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "DNI"
        '
        'gbxDatosDeFactura
        '
        Me.gbxDatosDeFactura.Controls.Add(Me.txtPlan)
        Me.gbxDatosDeFactura.Controls.Add(Me.lblPlan)
        Me.gbxDatosDeFactura.Controls.Add(Me.txtMontoTotal)
        Me.gbxDatosDeFactura.Controls.Add(Me.txtFecha)
        Me.gbxDatosDeFactura.Controls.Add(Me.txtOS)
        Me.gbxDatosDeFactura.Controls.Add(Me.txtPaciente)
        Me.gbxDatosDeFactura.Controls.Add(Me.txtNroFactura)
        Me.gbxDatosDeFactura.Controls.Add(Me.lblMonto)
        Me.gbxDatosDeFactura.Controls.Add(Me.Label4)
        Me.gbxDatosDeFactura.Controls.Add(Me.Label5)
        Me.gbxDatosDeFactura.Controls.Add(Me.cmbTipo)
        Me.gbxDatosDeFactura.Controls.Add(Me.Label6)
        Me.gbxDatosDeFactura.Controls.Add(Me.Label7)
        Me.gbxDatosDeFactura.Controls.Add(Me.Label8)
        Me.gbxDatosDeFactura.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxDatosDeFactura.Location = New System.Drawing.Point(12, 122)
        Me.gbxDatosDeFactura.Name = "gbxDatosDeFactura"
        Me.gbxDatosDeFactura.Size = New System.Drawing.Size(476, 286)
        Me.gbxDatosDeFactura.TabIndex = 42
        Me.gbxDatosDeFactura.TabStop = False
        Me.gbxDatosDeFactura.Text = "Datos de Factura"
        '
        'txtPlan
        '
        Me.txtPlan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPlan.Location = New System.Drawing.Point(364, 145)
        Me.txtPlan.Name = "txtPlan"
        Me.txtPlan.ReadOnly = True
        Me.txtPlan.Size = New System.Drawing.Size(86, 22)
        Me.txtPlan.TabIndex = 69
        '
        'lblPlan
        '
        Me.lblPlan.AutoSize = True
        Me.lblPlan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlan.Location = New System.Drawing.Point(286, 148)
        Me.lblPlan.Name = "lblPlan"
        Me.lblPlan.Size = New System.Drawing.Size(38, 16)
        Me.lblPlan.TabIndex = 68
        Me.lblPlan.Text = "Plan:"
        '
        'txtMontoTotal
        '
        Me.txtMontoTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMontoTotal.Location = New System.Drawing.Point(364, 233)
        Me.txtMontoTotal.Name = "txtMontoTotal"
        Me.txtMontoTotal.ReadOnly = True
        Me.txtMontoTotal.Size = New System.Drawing.Size(86, 22)
        Me.txtMontoTotal.TabIndex = 67
        Me.txtMontoTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtFecha
        '
        Me.txtFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFecha.Location = New System.Drawing.Point(364, 38)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.ReadOnly = True
        Me.txtFecha.Size = New System.Drawing.Size(86, 22)
        Me.txtFecha.TabIndex = 66
        '
        'txtOS
        '
        Me.txtOS.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOS.Location = New System.Drawing.Point(112, 145)
        Me.txtOS.Name = "txtOS"
        Me.txtOS.ReadOnly = True
        Me.txtOS.Size = New System.Drawing.Size(122, 22)
        Me.txtOS.TabIndex = 65
        '
        'txtPaciente
        '
        Me.txtPaciente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPaciente.Location = New System.Drawing.Point(111, 93)
        Me.txtPaciente.Name = "txtPaciente"
        Me.txtPaciente.ReadOnly = True
        Me.txtPaciente.Size = New System.Drawing.Size(122, 22)
        Me.txtPaciente.TabIndex = 64
        '
        'txtNroFactura
        '
        Me.txtNroFactura.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNroFactura.Location = New System.Drawing.Point(112, 39)
        Me.txtNroFactura.Name = "txtNroFactura"
        Me.txtNroFactura.ReadOnly = True
        Me.txtNroFactura.Size = New System.Drawing.Size(122, 22)
        Me.txtNroFactura.TabIndex = 63
        '
        'lblMonto
        '
        Me.lblMonto.AutoSize = True
        Me.lblMonto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMonto.Location = New System.Drawing.Point(254, 236)
        Me.lblMonto.Name = "lblMonto"
        Me.lblMonto.Size = New System.Drawing.Size(107, 16)
        Me.lblMonto.TabIndex = 62
        Me.lblMonto.Text = "Monto Total:      $"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(11, 148)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 16)
        Me.Label4.TabIndex = 55
        Me.Label4.Text = "Obra Social: "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(285, 41)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 16)
        Me.Label5.TabIndex = 54
        Me.Label5.Text = "Fecha: "
        '
        'cmbTipo
        '
        Me.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTipo.FormattingEnabled = True
        Me.cmbTipo.Items.AddRange(New Object() {"A", "B", "C"})
        Me.cmbTipo.Location = New System.Drawing.Point(364, 92)
        Me.cmbTipo.Name = "cmbTipo"
        Me.cmbTipo.Size = New System.Drawing.Size(86, 24)
        Me.cmbTipo.TabIndex = 53
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(285, 95)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 16)
        Me.Label6.TabIndex = 52
        Me.Label6.Text = "Tipo:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(11, 41)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(33, 16)
        Me.Label7.TabIndex = 51
        Me.Label7.Text = "Nro."
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(11, 95)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(67, 16)
        Me.Label8.TabIndex = 50
        Me.Label8.Text = "Paciente: "
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAceptar.Location = New System.Drawing.Point(874, 436)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(86, 34)
        Me.cmdAceptar.TabIndex = 43
        Me.cmdAceptar.Text = "Aceptar"
        Me.cmdAceptar.UseVisualStyleBackColor = True
        '
        'FechaTurno
        '
        Me.FechaTurno.HeaderText = "Fecha"
        Me.FechaTurno.Name = "FechaTurno"
        '
        'Hora
        '
        Me.Hora.HeaderText = "Hora"
        Me.Hora.Name = "Hora"
        '
        'idPrestacion
        '
        Me.idPrestacion.HeaderText = "idPrestacion"
        Me.idPrestacion.Name = "idPrestacion"
        Me.idPrestacion.Visible = False
        '
        'Prestacion
        '
        Me.Prestacion.HeaderText = "Prestación"
        Me.Prestacion.Name = "Prestacion"
        '
        'idOdontologo
        '
        Me.idOdontologo.HeaderText = "idOdontologo"
        Me.idOdontologo.Name = "idOdontologo"
        Me.idOdontologo.Visible = False
        '
        'Odontologo
        '
        Me.Odontologo.HeaderText = "Odontólogo"
        Me.Odontologo.Name = "Odontologo"
        '
        'Monto
        '
        Me.Monto.HeaderText = "Monto"
        Me.Monto.Name = "Monto"
        '
        'idOS
        '
        Me.idOS.HeaderText = "idOS"
        Me.idOS.Name = "idOS"
        Me.idOS.Visible = False
        '
        'idPlan
        '
        Me.idPlan.HeaderText = "idPlan"
        Me.idPlan.Name = "idPlan"
        Me.idPlan.Visible = False
        '
        'Fecha2
        '
        Me.Fecha2.HeaderText = "Fecha"
        Me.Fecha2.Name = "Fecha2"
        '
        'Hora2
        '
        Me.Hora2.HeaderText = "Hora"
        Me.Hora2.Name = "Hora2"
        '
        'idPrestacion2
        '
        Me.idPrestacion2.HeaderText = "idPrestacion"
        Me.idPrestacion2.Name = "idPrestacion2"
        Me.idPrestacion2.Visible = False
        '
        'Prestacion2
        '
        Me.Prestacion2.HeaderText = "Prestación"
        Me.Prestacion2.Name = "Prestacion2"
        '
        'idOdontologo2
        '
        Me.idOdontologo2.HeaderText = "idOdontologo"
        Me.idOdontologo2.Name = "idOdontologo2"
        Me.idOdontologo2.Visible = False
        '
        'Odontologo2
        '
        Me.Odontologo2.HeaderText = "Odontólogo"
        Me.Odontologo2.Name = "Odontologo2"
        '
        'Monto2
        '
        Me.Monto2.HeaderText = "Monto"
        Me.Monto2.Name = "Monto2"
        '
        'idOS2
        '
        Me.idOS2.HeaderText = "idOS2"
        Me.idOS2.Name = "idOS2"
        Me.idOS2.Visible = False
        '
        'idPlan2
        '
        Me.idPlan2.HeaderText = "idPlan2"
        Me.idPlan2.Name = "idPlan2"
        Me.idPlan2.Visible = False
        '
        'frmFacturacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(984, 488)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.gbxDatosDeFactura)
        Me.Controls.Add(Me.mtxtDNI)
        Me.Controls.Add(Me.Buscar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblTurnosAFacturar)
        Me.Controls.Add(Me.dgvTurnosAFacturar)
        Me.Controls.Add(Me.lblTurnosNoFacturados)
        Me.Controls.Add(Me.dgvTurnosNoFacturados)
        Me.Name = "frmFacturacion"
        Me.Text = "frmFacturacion"
        CType(Me.dgvTurnosNoFacturados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvTurnosAFacturar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxDatosDeFactura.ResumeLayout(False)
        Me.gbxDatosDeFactura.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvTurnosNoFacturados As System.Windows.Forms.DataGridView
    Friend WithEvents lblTurnosNoFacturados As System.Windows.Forms.Label
    Friend WithEvents lblTurnosAFacturar As System.Windows.Forms.Label
    Friend WithEvents dgvTurnosAFacturar As System.Windows.Forms.DataGridView
    Friend WithEvents mtxtDNI As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Buscar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents gbxDatosDeFactura As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbTipo As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtPlan As System.Windows.Forms.TextBox
    Friend WithEvents lblPlan As System.Windows.Forms.Label
    Friend WithEvents txtMontoTotal As System.Windows.Forms.TextBox
    Friend WithEvents txtFecha As System.Windows.Forms.TextBox
    Friend WithEvents txtOS As System.Windows.Forms.TextBox
    Friend WithEvents txtPaciente As System.Windows.Forms.TextBox
    Friend WithEvents txtNroFactura As System.Windows.Forms.TextBox
    Friend WithEvents lblMonto As System.Windows.Forms.Label
    Friend WithEvents cmdAceptar As System.Windows.Forms.Button
    Friend WithEvents FechaTurno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Hora As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idPrestacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Prestacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idOdontologo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Odontologo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Monto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idOS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idPlan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Fecha2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Hora2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idPrestacion2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Prestacion2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idOdontologo2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Odontologo2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Monto2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idOS2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idPlan2 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
