<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAgregarMedicamentoInexistente
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
        Me.lblNombreDroga = New System.Windows.Forms.Label()
        Me.lblLaboratorio = New System.Windows.Forms.Label()
        Me.lblRestricciones = New System.Windows.Forms.Label()
        Me.cmdAgregar = New System.Windows.Forms.Button()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtLaboratorio = New System.Windows.Forms.TextBox()
        Me.rtxtRestricciones = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'lblNombreDroga
        '
        Me.lblNombreDroga.AutoSize = True
        Me.lblNombreDroga.Location = New System.Drawing.Point(12, 20)
        Me.lblNombreDroga.Name = "lblNombreDroga"
        Me.lblNombreDroga.Size = New System.Drawing.Size(74, 13)
        Me.lblNombreDroga.TabIndex = 0
        Me.lblNombreDroga.Text = "Nombre droga"
        '
        'lblLaboratorio
        '
        Me.lblLaboratorio.AutoSize = True
        Me.lblLaboratorio.Location = New System.Drawing.Point(12, 50)
        Me.lblLaboratorio.Name = "lblLaboratorio"
        Me.lblLaboratorio.Size = New System.Drawing.Size(60, 13)
        Me.lblLaboratorio.TabIndex = 1
        Me.lblLaboratorio.Text = "Laboratorio"
        '
        'lblRestricciones
        '
        Me.lblRestricciones.AutoSize = True
        Me.lblRestricciones.Location = New System.Drawing.Point(12, 76)
        Me.lblRestricciones.Name = "lblRestricciones"
        Me.lblRestricciones.Size = New System.Drawing.Size(71, 13)
        Me.lblRestricciones.TabIndex = 2
        Me.lblRestricciones.Text = "Restricciones"
        '
        'cmdAgregar
        '
        Me.cmdAgregar.Location = New System.Drawing.Point(276, 191)
        Me.cmdAgregar.Name = "cmdAgregar"
        Me.cmdAgregar.Size = New System.Drawing.Size(75, 23)
        Me.cmdAgregar.TabIndex = 10
        Me.cmdAgregar.Text = "Agregar"
        Me.cmdAgregar.UseVisualStyleBackColor = True
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(114, 17)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(226, 20)
        Me.txtNombre.TabIndex = 11
        '
        'txtLaboratorio
        '
        Me.txtLaboratorio.Location = New System.Drawing.Point(114, 47)
        Me.txtLaboratorio.Name = "txtLaboratorio"
        Me.txtLaboratorio.Size = New System.Drawing.Size(226, 20)
        Me.txtLaboratorio.TabIndex = 12
        '
        'rtxtRestricciones
        '
        Me.rtxtRestricciones.Location = New System.Drawing.Point(114, 73)
        Me.rtxtRestricciones.Name = "rtxtRestricciones"
        Me.rtxtRestricciones.Size = New System.Drawing.Size(226, 96)
        Me.rtxtRestricciones.TabIndex = 13
        Me.rtxtRestricciones.Text = ""
        '
        'frmAgregarMedicamentoInexistente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(363, 226)
        Me.Controls.Add(Me.rtxtRestricciones)
        Me.Controls.Add(Me.txtLaboratorio)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.cmdAgregar)
        Me.Controls.Add(Me.lblRestricciones)
        Me.Controls.Add(Me.lblLaboratorio)
        Me.Controls.Add(Me.lblNombreDroga)
        Me.Name = "frmAgregarMedicamentoInexistente"
        Me.Text = "frmAgregarMedicamentoInexistente"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblNombreDroga As System.Windows.Forms.Label
    Friend WithEvents lblLaboratorio As System.Windows.Forms.Label
    Friend WithEvents lblRestricciones As System.Windows.Forms.Label
    Friend WithEvents cmdAgregar As System.Windows.Forms.Button
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtLaboratorio As System.Windows.Forms.TextBox
    Friend WithEvents rtxtRestricciones As System.Windows.Forms.RichTextBox
End Class
