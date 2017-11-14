Public Class frmReportePacientesvb



    Private Sub frmReportePacientesvb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''TODO: This line of code loads data into the 'DataSetPacientes.Pacientes' table. You can move, or remove it, as needed.
        'Me.PacientesTableAdapter.Fill(Me.DataSetPacientes.Pacientes)

        Me.ReportViewer1.Clear()
    End Sub

    Private Sub cmdConsultar_Click(sender As Object, e As EventArgs) Handles cmdConsultar.Click
        Dim strSQL As String = "SELECT * FROM PACIENTES WHERE activo = 'T' "

        If cmbSexo.SelectedIndex = -1 Or cmbSexo.SelectedIndex = 2 Then
            strSQL += "AND (sexo = 'F' OR sexo = 'M')"
        ElseIf cmbSexo.SelectedIndex = 0 Then
            strSQL += "AND sexo = 'M'"
        ElseIf cmbSexo.SelectedIndex = 1 Then
            strSQL += "AND sexo = 'F'"
        End If

        If mtxtFechaDesde.MaskCompleted Then
            strSQL += " AND fechaNacimiento > CONVERT(DATE,'" & mtxtFechaDesde.Text & "',103)"
        End If

        If mtxtFechaHasta.MaskCompleted Then
            strSQL += " AND fechaNacimiento < CONVERT(DATE,'" & mtxtFechaHasta.Text & "',103)"
        End If


        If cmbOrden.SelectedIndex = 0 Then
            strSQL += " ORDER BY dniPaciente "
        ElseIf cmbOrden.SelectedIndex = 1 Then
            strSQL += " ORDER BY apellido "
        ElseIf cmbOrden.SelectedIndex = 2 Then
            strSQL += " ORDER BY nombre "
        ElseIf cmbOrden.SelectedIndex = 3 Then
            strSQL += " ORDER BY fechaNacimiento "
        End If
        MsgBox(strSQL)
        PacientesBindingSource.DataSource = BDHelper2.reportarPacientes(strSQL)
        Me.ReportViewer1.RefreshReport()

    End Sub
End Class