<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAgregarTurno
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
        Me.txtPaciente = New System.Windows.Forms.TextBox()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.lblHora = New System.Windows.Forms.Label()
        Me.lblOdontologo = New System.Windows.Forms.Label()
        Me.grbPacientes = New System.Windows.Forms.GroupBox()
        Me.mtxtDNI = New System.Windows.Forms.MaskedTextBox()
        Me.txtMontoFinal = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtMontoCubierto = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Buscar = New System.Windows.Forms.Button()
        Me.cmdAgregarNuevo = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.rtxtDescripcion = New System.Windows.Forms.RichTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbPrestacion = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Cancelar = New System.Windows.Forms.Button()
        Me.Agregar = New System.Windows.Forms.Button()
        Me.grbPacientes.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtPaciente
        '
        Me.txtPaciente.Location = New System.Drawing.Point(123, 140)
        Me.txtPaciente.Name = "txtPaciente"
        Me.txtPaciente.ReadOnly = True
        Me.txtPaciente.Size = New System.Drawing.Size(141, 20)
        Me.txtPaciente.TabIndex = 0
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Location = New System.Drawing.Point(20, 33)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(49, 13)
        Me.lblFecha.TabIndex = 1
        Me.lblFecha.Text = "Fecha:   "
        '
        'lblHora
        '
        Me.lblHora.AutoSize = True
        Me.lblHora.Location = New System.Drawing.Point(183, 33)
        Me.lblHora.Name = "lblHora"
        Me.lblHora.Size = New System.Drawing.Size(53, 13)
        Me.lblHora.TabIndex = 3
        Me.lblHora.Text = "Horario:   "
        '
        'lblOdontologo
        '
        Me.lblOdontologo.AutoSize = True
        Me.lblOdontologo.Location = New System.Drawing.Point(398, 33)
        Me.lblOdontologo.Name = "lblOdontologo"
        Me.lblOdontologo.Size = New System.Drawing.Size(74, 13)
        Me.lblOdontologo.TabIndex = 4
        Me.lblOdontologo.Text = "Odontólogo:   "
        '
        'grbPacientes
        '
        Me.grbPacientes.Controls.Add(Me.mtxtDNI)
        Me.grbPacientes.Controls.Add(Me.txtMontoFinal)
        Me.grbPacientes.Controls.Add(Me.lblFecha)
        Me.grbPacientes.Controls.Add(Me.Label7)
        Me.grbPacientes.Controls.Add(Me.Label8)
        Me.grbPacientes.Controls.Add(Me.txtMontoCubierto)
        Me.grbPacientes.Controls.Add(Me.Label6)
        Me.grbPacientes.Controls.Add(Me.Buscar)
        Me.grbPacientes.Controls.Add(Me.cmdAgregarNuevo)
        Me.grbPacientes.Controls.Add(Me.Label5)
        Me.grbPacientes.Controls.Add(Me.rtxtDescripcion)
        Me.grbPacientes.Controls.Add(Me.Label4)
        Me.grbPacientes.Controls.Add(Me.cmbPrestacion)
        Me.grbPacientes.Controls.Add(Me.Label3)
        Me.grbPacientes.Controls.Add(Me.Label2)
        Me.grbPacientes.Controls.Add(Me.Label1)
        Me.grbPacientes.Controls.Add(Me.lblHora)
        Me.grbPacientes.Controls.Add(Me.lblOdontologo)
        Me.grbPacientes.Controls.Add(Me.txtPaciente)
        Me.grbPacientes.Location = New System.Drawing.Point(12, 12)
        Me.grbPacientes.Name = "grbPacientes"
        Me.grbPacientes.Size = New System.Drawing.Size(643, 324)
        Me.grbPacientes.TabIndex = 19
        Me.grbPacientes.TabStop = False
        Me.grbPacientes.Text = "Datos del turno"
        '
        'mtxtDNI
        '
        Me.mtxtDNI.Location = New System.Drawing.Point(123, 101)
        Me.mtxtDNI.Name = "mtxtDNI"
        Me.mtxtDNI.Size = New System.Drawing.Size(141, 20)
        Me.mtxtDNI.TabIndex = 35
        '
        'txtMontoFinal
        '
        Me.txtMontoFinal.Enabled = False
        Me.txtMontoFinal.Location = New System.Drawing.Point(527, 293)
        Me.txtMontoFinal.Name = "txtMontoFinal"
        Me.txtMontoFinal.ReadOnly = True
        Me.txtMontoFinal.Size = New System.Drawing.Size(93, 20)
        Me.txtMontoFinal.TabIndex = 34
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(432, 296)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 13)
        Me.Label7.TabIndex = 33
        Me.Label7.Text = "Monto Final"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(398, 296)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(0, 13)
        Me.Label8.TabIndex = 32
        '
        'txtMontoCubierto
        '
        Me.txtMontoCubierto.Enabled = False
        Me.txtMontoCubierto.Location = New System.Drawing.Point(123, 293)
        Me.txtMontoCubierto.Name = "txtMontoCubierto"
        Me.txtMontoCubierto.ReadOnly = True
        Me.txtMontoCubierto.Size = New System.Drawing.Size(94, 20)
        Me.txtMontoCubierto.TabIndex = 31
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(22, 296)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 13)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "Monto Cubierto"
        '
        'Buscar
        '
        Me.Buscar.Location = New System.Drawing.Point(279, 99)
        Me.Buscar.Name = "Buscar"
        Me.Buscar.Size = New System.Drawing.Size(57, 23)
        Me.Buscar.TabIndex = 29
        Me.Buscar.Text = "Buscar"
        Me.Buscar.UseVisualStyleBackColor = True
        '
        'cmdAgregarNuevo
        '
        Me.cmdAgregarNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAgregarNuevo.Location = New System.Drawing.Point(279, 140)
        Me.cmdAgregarNuevo.Name = "cmdAgregarNuevo"
        Me.cmdAgregarNuevo.Size = New System.Drawing.Size(23, 23)
        Me.cmdAgregarNuevo.TabIndex = 28
        Me.cmdAgregarNuevo.Text = "+"
        Me.cmdAgregarNuevo.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(22, 296)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 13)
        Me.Label5.TabIndex = 27
        '
        'rtxtDescripcion
        '
        Me.rtxtDescripcion.Location = New System.Drawing.Point(123, 182)
        Me.rtxtDescripcion.Name = "rtxtDescripcion"
        Me.rtxtDescripcion.Size = New System.Drawing.Size(497, 82)
        Me.rtxtDescripcion.TabIndex = 26
        Me.rtxtDescripcion.Text = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 185)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Descripción"
        '
        'cmbPrestacion
        '
        Me.cmbPrestacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPrestacion.FormattingEnabled = True
        Me.cmbPrestacion.Location = New System.Drawing.Point(499, 100)
        Me.cmbPrestacion.Name = "cmbPrestacion"
        Me.cmbPrestacion.Size = New System.Drawing.Size(121, 21)
        Me.cmbPrestacion.TabIndex = 24
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(398, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 13)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Prestación"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 143)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Paciente"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 104)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 13)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "DNI"
        '
        'Cancelar
        '
        Me.Cancelar.Location = New System.Drawing.Point(580, 355)
        Me.Cancelar.Name = "Cancelar"
        Me.Cancelar.Size = New System.Drawing.Size(75, 23)
        Me.Cancelar.TabIndex = 35
        Me.Cancelar.Text = "Cancelar"
        Me.Cancelar.UseVisualStyleBackColor = True
        '
        'Agregar
        '
        Me.Agregar.Location = New System.Drawing.Point(471, 355)
        Me.Agregar.Name = "Agregar"
        Me.Agregar.Size = New System.Drawing.Size(75, 23)
        Me.Agregar.TabIndex = 36
        Me.Agregar.Text = "Agregar"
        Me.Agregar.UseVisualStyleBackColor = True
        '
        'frmAgregarTurno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(667, 394)
        Me.Controls.Add(Me.Agregar)
        Me.Controls.Add(Me.Cancelar)
        Me.Controls.Add(Me.grbPacientes)
        Me.Name = "frmAgregarTurno"
        Me.Text = "Nuevo Turno"
        Me.grbPacientes.ResumeLayout(False)
        Me.grbPacientes.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtPaciente As System.Windows.Forms.TextBox
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents lblHora As System.Windows.Forms.Label
    Friend WithEvents lblOdontologo As System.Windows.Forms.Label
    Friend WithEvents grbPacientes As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents rtxtDescripcion As System.Windows.Forms.RichTextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbPrestacion As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtMontoFinal As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtMontoCubierto As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Buscar As System.Windows.Forms.Button
    Friend WithEvents cmdAgregarNuevo As System.Windows.Forms.Button
    Friend WithEvents Cancelar As System.Windows.Forms.Button
    Friend WithEvents Agregar As System.Windows.Forms.Button
    Friend WithEvents mtxtDNI As System.Windows.Forms.MaskedTextBox
End Class
