<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTurnos
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvTurnos = New System.Windows.Forms.DataGridView()
        Me.Horario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Paciente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Consulta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dniPaciente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idPrestacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idEstado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HoraFin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.calendar = New System.Windows.Forms.MonthCalendar()
        Me.lblOdontologo = New System.Windows.Forms.Label()
        Me.cmbOdontologos = New System.Windows.Forms.ComboBox()
        Me.cmdAgregar = New System.Windows.Forms.Button()
        Me.rtxtDetalles = New System.Windows.Forms.RichTextBox()
        Me.lblDetalles = New System.Windows.Forms.Label()
        Me.EstadoTurnosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EstadoTurnosBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.lblEstadoTurno = New System.Windows.Forms.Label()
        Me.cmbEstadoTurno = New System.Windows.Forms.ComboBox()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        CType(Me.dgvTurnos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EstadoTurnosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EstadoTurnosBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvTurnos
        '
        Me.dgvTurnos.AllowUserToAddRows = False
        Me.dgvTurnos.AllowUserToDeleteRows = False
        Me.dgvTurnos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvTurnos.BackgroundColor = System.Drawing.Color.LightGreen
        Me.dgvTurnos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvTurnos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.dgvTurnos.ColumnHeadersHeight = 35
        Me.dgvTurnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvTurnos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Horario, Me.Paciente, Me.Consulta, Me.Descripcion, Me.Estado, Me.dniPaciente, Me.idPrestacion, Me.idEstado, Me.HoraFin})
        Me.dgvTurnos.Location = New System.Drawing.Point(300, 62)
        Me.dgvTurnos.Name = "dgvTurnos"
        Me.dgvTurnos.ReadOnly = True
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvTurnos.RowHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvTurnos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.dgvTurnos.RowTemplate.Height = 30
        Me.dgvTurnos.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvTurnos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTurnos.Size = New System.Drawing.Size(566, 324)
        Me.dgvTurnos.TabIndex = 3
        '
        'Horario
        '
        Me.Horario.HeaderText = "Horario"
        Me.Horario.Name = "Horario"
        Me.Horario.ReadOnly = True
        Me.Horario.Width = 108
        '
        'Paciente
        '
        Me.Paciente.HeaderText = "Paciente"
        Me.Paciente.Name = "Paciente"
        Me.Paciente.ReadOnly = True
        Me.Paciente.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Paciente.Width = 108
        '
        'Consulta
        '
        Me.Consulta.HeaderText = "Consulta"
        Me.Consulta.Name = "Consulta"
        Me.Consulta.ReadOnly = True
        Me.Consulta.Width = 108
        '
        'Descripcion
        '
        Me.Descripcion.HeaderText = "Descripcion"
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.ReadOnly = True
        Me.Descripcion.Width = 108
        '
        'Estado
        '
        Me.Estado.HeaderText = "Estado"
        Me.Estado.Name = "Estado"
        Me.Estado.ReadOnly = True
        Me.Estado.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Estado.Width = 108
        '
        'dniPaciente
        '
        Me.dniPaciente.HeaderText = "dniPaciente"
        Me.dniPaciente.Name = "dniPaciente"
        Me.dniPaciente.ReadOnly = True
        Me.dniPaciente.Visible = False
        Me.dniPaciente.Width = 88
        '
        'idPrestacion
        '
        Me.idPrestacion.HeaderText = "idPrestacion"
        Me.idPrestacion.Name = "idPrestacion"
        Me.idPrestacion.ReadOnly = True
        Me.idPrestacion.Visible = False
        Me.idPrestacion.Width = 90
        '
        'idEstado
        '
        Me.idEstado.HeaderText = "idEstado"
        Me.idEstado.Name = "idEstado"
        Me.idEstado.ReadOnly = True
        Me.idEstado.Visible = False
        Me.idEstado.Width = 73
        '
        'HoraFin
        '
        Me.HoraFin.HeaderText = "HoraFin"
        Me.HoraFin.Name = "HoraFin"
        Me.HoraFin.ReadOnly = True
        Me.HoraFin.Visible = False
        '
        'calendar
        '
        Me.calendar.Location = New System.Drawing.Point(18, 18)
        Me.calendar.Name = "calendar"
        Me.calendar.TabIndex = 4
        '
        'lblOdontologo
        '
        Me.lblOdontologo.AutoSize = True
        Me.lblOdontologo.Location = New System.Drawing.Point(297, 21)
        Me.lblOdontologo.Name = "lblOdontologo"
        Me.lblOdontologo.Size = New System.Drawing.Size(62, 13)
        Me.lblOdontologo.TabIndex = 5
        Me.lblOdontologo.Text = "Odontologo"
        '
        'cmbOdontologos
        '
        Me.cmbOdontologos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbOdontologos.FormattingEnabled = True
        Me.cmbOdontologos.Location = New System.Drawing.Point(393, 18)
        Me.cmbOdontologos.Name = "cmbOdontologos"
        Me.cmbOdontologos.Size = New System.Drawing.Size(121, 21)
        Me.cmbOdontologos.TabIndex = 6
        '
        'cmdAgregar
        '
        Me.cmdAgregar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdAgregar.Enabled = False
        Me.cmdAgregar.Location = New System.Drawing.Point(666, 409)
        Me.cmdAgregar.Name = "cmdAgregar"
        Me.cmdAgregar.Size = New System.Drawing.Size(75, 23)
        Me.cmdAgregar.TabIndex = 7
        Me.cmdAgregar.Text = "Agregar"
        Me.cmdAgregar.UseVisualStyleBackColor = True
        '
        'rtxtDetalles
        '
        Me.rtxtDetalles.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.rtxtDetalles.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtxtDetalles.Location = New System.Drawing.Point(18, 237)
        Me.rtxtDetalles.Name = "rtxtDetalles"
        Me.rtxtDetalles.ReadOnly = True
        Me.rtxtDetalles.Size = New System.Drawing.Size(248, 195)
        Me.rtxtDetalles.TabIndex = 11
        Me.rtxtDetalles.Text = ""
        '
        'lblDetalles
        '
        Me.lblDetalles.AutoSize = True
        Me.lblDetalles.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDetalles.Location = New System.Drawing.Point(14, 202)
        Me.lblDetalles.Name = "lblDetalles"
        Me.lblDetalles.Size = New System.Drawing.Size(230, 20)
        Me.lblDetalles.TabIndex = 12
        Me.lblDetalles.Text = "Detalles del turno seleccionado"
        '
        'lblEstadoTurno
        '
        Me.lblEstadoTurno.AutoSize = True
        Me.lblEstadoTurno.Location = New System.Drawing.Point(616, 21)
        Me.lblEstadoTurno.Name = "lblEstadoTurno"
        Me.lblEstadoTurno.Size = New System.Drawing.Size(84, 13)
        Me.lblEstadoTurno.TabIndex = 13
        Me.lblEstadoTurno.Text = "Estado del turno"
        '
        'cmbEstadoTurno
        '
        Me.cmbEstadoTurno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEstadoTurno.Enabled = False
        Me.cmbEstadoTurno.FormattingEnabled = True
        Me.cmbEstadoTurno.Location = New System.Drawing.Point(722, 18)
        Me.cmbEstadoTurno.Name = "cmbEstadoTurno"
        Me.cmbEstadoTurno.Size = New System.Drawing.Size(121, 21)
        Me.cmbEstadoTurno.TabIndex = 14
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdCancelar.Enabled = False
        Me.cmdCancelar.Location = New System.Drawing.Point(768, 409)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(75, 23)
        Me.cmdCancelar.TabIndex = 8
        Me.cmdCancelar.Text = "Cancelar"
        Me.cmdCancelar.UseVisualStyleBackColor = True
        '
        'frmTurnos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(898, 479)
        Me.Controls.Add(Me.cmbEstadoTurno)
        Me.Controls.Add(Me.lblEstadoTurno)
        Me.Controls.Add(Me.lblDetalles)
        Me.Controls.Add(Me.rtxtDetalles)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cmdAgregar)
        Me.Controls.Add(Me.cmbOdontologos)
        Me.Controls.Add(Me.lblOdontologo)
        Me.Controls.Add(Me.calendar)
        Me.Controls.Add(Me.dgvTurnos)
        Me.Name = "frmTurnos"
        Me.Text = "Turnos"
        CType(Me.dgvTurnos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EstadoTurnosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EstadoTurnosBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents dgvTurnos As System.Windows.Forms.DataGridView
    Friend WithEvents calendar As System.Windows.Forms.MonthCalendar
    Friend WithEvents lblOdontologo As System.Windows.Forms.Label
    Friend WithEvents cmbOdontologos As System.Windows.Forms.ComboBox
    Friend WithEvents cmdAgregar As System.Windows.Forms.Button
    Friend WithEvents rtxtDetalles As System.Windows.Forms.RichTextBox
    Friend WithEvents lblDetalles As System.Windows.Forms.Label
    Friend WithEvents EstadoTurnosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EstadoTurnosBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents lblEstadoTurno As System.Windows.Forms.Label
    Friend WithEvents cmbEstadoTurno As System.Windows.Forms.ComboBox
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents Horario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Paciente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Consulta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Estado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dniPaciente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idPrestacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idEstado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HoraFin As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
