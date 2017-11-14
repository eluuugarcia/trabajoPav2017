Public Class frmReporteOdontologos



    Private Sub cmdConsultar_Click(sender As Object, e As EventArgs) Handles cmdConsultar.Click
        Dim strSQL As String = "SELECT * FROM Odontologos O "
        If cmbEspecialidad.SelectedIndex <> -1 Then
            strSQL += "JOIN MedicosXEspecialidad MXE ON (O.legajo = MXE.idMedico) WHERE MXE.idEspecialidad = " & (cmbEspecialidad.SelectedIndex + 1)
            strSQL += " AND O.activo = 'T' AND "
        Else : strSQL += "WHERE O.activo = 'T' AND "
        End If


        If cmbSexo.SelectedIndex = -1 Or cmbSexo.SelectedIndex = 2 Then
            strSQL += "(O.sexo = 'F' OR O.sexo = 'M')"
        ElseIf cmbSexo.SelectedIndex = 0 Then
            strSQL += "O.sexo = 'M'"
        ElseIf cmbSexo.SelectedIndex = 1 Then
            strSQL += "O.sexo = 'F'"
        End If

        If mtxtFechaDesde.MaskCompleted Then
            strSQL += " AND O.fechaNacimiento > CONVERT(DATE,'" & mtxtFechaDesde.Text & "',103)"
        End If

        If mtxtFechaHasta.MaskCompleted Then
            strSQL += " AND O.fechaNacimiento < CONVERT(DATE,'" & mtxtFechaHasta.Text & "',103)"
        End If


        If cmbOrden.SelectedIndex = 0 Then
            strSQL += " ORDER BY O.legajo "
        ElseIf cmbOrden.SelectedIndex = 1 Then
            strSQL += " ORDER BY O.dniOdontologo "
        ElseIf cmbOrden.SelectedIndex = 2 Then
            strSQL += " ORDER BY O.apellido "
        ElseIf cmbOrden.SelectedIndex = 3 Then
            strSQL += " ORDER BY O.nombre "
        ElseIf cmbOrden.SelectedIndex = 4 Then
            strSQL += " ORDER BY O.fechaNacimiento "
        ElseIf cmbOrden.SelectedIndex = 5 Then
            strSQL += " ORDER BY O.fechaIngreso"
        End If
        OdontologosBindingSource.DataSource = BDHelper2.reportarOdontologos(strSQL)
        Me.ReportViewer1.RefreshReport()


    End Sub

    Private Sub frmReporteOdontologos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarCombo(cmbEspecialidad, BDHelper2.GetEspecialidadesParaGrilla(), "idEspecialidad", "nombre")
        Me.ReportViewer1.Clear()
    End Sub

    Private Sub CargarCombo(ByRef combo As ComboBox, ByRef datos As Data.DataTable, ByVal pk As String, ByVal descripcion As String)

        combo.DataSource = datos
        combo.ValueMember = pk
        combo.DisplayMember = descripcion
        combo.SelectedIndex = -1
    End Sub
End Class