<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenuReportes
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
        Me.cmbReportes = New System.Windows.Forms.ComboBox()
        Me.lblReporte = New System.Windows.Forms.Label()
        Me.cmdConsultarReportes = New System.Windows.Forms.Button()
        Me.cmdConsultarEstadisticas = New System.Windows.Forms.Button()
        Me.lblEstadisticas = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'cmbReportes
        '
        Me.cmbReportes.FormattingEnabled = True
        Me.cmbReportes.Items.AddRange(New Object() {"Pacientes", "Odontologos", "Enfermedades", "Prestaciones"})
        Me.cmbReportes.Location = New System.Drawing.Point(318, 53)
        Me.cmbReportes.Name = "cmbReportes"
        Me.cmbReportes.Size = New System.Drawing.Size(121, 21)
        Me.cmbReportes.TabIndex = 0
        '
        'lblReporte
        '
        Me.lblReporte.AutoSize = True
        Me.lblReporte.Location = New System.Drawing.Point(318, 20)
        Me.lblReporte.Name = "lblReporte"
        Me.lblReporte.Size = New System.Drawing.Size(53, 13)
        Me.lblReporte.TabIndex = 1
        Me.lblReporte.Text = "Reportes:"
        '
        'cmdConsultarReportes
        '
        Me.cmdConsultarReportes.Location = New System.Drawing.Point(318, 101)
        Me.cmdConsultarReportes.Name = "cmdConsultarReportes"
        Me.cmdConsultarReportes.Size = New System.Drawing.Size(75, 23)
        Me.cmdConsultarReportes.TabIndex = 2
        Me.cmdConsultarReportes.Text = "Consultar"
        Me.cmdConsultarReportes.UseVisualStyleBackColor = True
        '
        'cmdConsultarEstadisticas
        '
        Me.cmdConsultarEstadisticas.Location = New System.Drawing.Point(318, 265)
        Me.cmdConsultarEstadisticas.Name = "cmdConsultarEstadisticas"
        Me.cmdConsultarEstadisticas.Size = New System.Drawing.Size(75, 23)
        Me.cmdConsultarEstadisticas.TabIndex = 5
        Me.cmdConsultarEstadisticas.Text = "Consultar"
        Me.cmdConsultarEstadisticas.UseVisualStyleBackColor = True
        '
        'lblEstadisticas
        '
        Me.lblEstadisticas.AutoSize = True
        Me.lblEstadisticas.Location = New System.Drawing.Point(318, 184)
        Me.lblEstadisticas.Name = "lblEstadisticas"
        Me.lblEstadisticas.Size = New System.Drawing.Size(63, 13)
        Me.lblEstadisticas.TabIndex = 4
        Me.lblEstadisticas.Text = "Estadisticas"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(318, 217)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 3
        '
        'frmMenuReportes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BackgroundImage = Global.ConsultorioOdontologico.My.Resources.Resources._300
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(479, 309)
        Me.Controls.Add(Me.cmdConsultarEstadisticas)
        Me.Controls.Add(Me.lblEstadisticas)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.cmdConsultarReportes)
        Me.Controls.Add(Me.lblReporte)
        Me.Controls.Add(Me.cmbReportes)
        Me.DoubleBuffered = True
        Me.Name = "frmMenuReportes"
        Me.Text = "frmMenuReportes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbReportes As System.Windows.Forms.ComboBox
    Friend WithEvents lblReporte As System.Windows.Forms.Label
    Friend WithEvents cmdConsultarReportes As System.Windows.Forms.Button
    Friend WithEvents cmdConsultarEstadisticas As System.Windows.Forms.Button
    Friend WithEvents lblEstadisticas As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
End Class
