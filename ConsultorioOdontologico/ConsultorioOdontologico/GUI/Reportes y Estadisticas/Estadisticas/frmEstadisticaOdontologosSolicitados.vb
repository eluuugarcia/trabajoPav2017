Public Class frmEstadisticaOdontologosSolicitados

    Private Sub frmEstadisticaOdontologosSolicitados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSetOdontologosSolicitados2.odontologosPorTurnos' table. You can move, or remove it, as needed.
        'Me.odontologosPorTurnosTableAdapter.Fill(Me.DataSetOdontologosSolicitados2.odontologosPorTurnos)
        CargarCombo(cmbPrestacion, BDHelper2.GetPrestaciones(), "idPrestacion", "nombre")
        Me.ReportViewer1.Clear()
    End Sub

    Private Sub CargarCombo(ByRef combo As ComboBox, ByRef datos As Data.DataTable, ByVal pk As String, ByVal descripcion As String)

        combo.DataSource = datos
        combo.ValueMember = pk
        combo.DisplayMember = descripcion
        combo.SelectedIndex = -1

    End Sub

    Private Sub cmdConsult_Click(sender As Object, e As EventArgs) Handles cmdConsult.Click
        Dim strSQL As String = "SELECT O.legajo, (O.apellido + ' ' + O.nombre) AS 'Nombre_Completo' , T.fecha FROM Turno T JOIN Odontologos O ON (T.legajoOdontologo = O.legajo) JOIN Prestaciones P ON (P.idPrestacion = T.idPrestacion) WHERE O.activo = 'T' "

        If mtxtFechaDesde.MaskCompleted Then
            strSQL += " AND T.fecha > CONVERT(DATE,'" & mtxtFechaDesde.Text & "',103) "
        End If

        If mtxtFechaHasta.MaskCompleted Then
            strSQL += " AND T.fecha < CONVERT(DATE,'" & mtxtFechaHasta.Text & "',103) "
        End If


        If cmbPrestacion.SelectedIndex = -1 Then
            strSQL += ""
        Else
            strSQL += " AND T.idPrestacion = " & cmbPrestacion.SelectedIndex
        End If


        strSQL += " ORDER BY 'Nombre_Completo'"
        DataSetOdontologosPorTurnosMSBindingSource.DataSource = BDHelper2.reportarPacientes(strSQL)
        Me.ReportViewer1.RefreshReport()


    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load

    End Sub


End Class