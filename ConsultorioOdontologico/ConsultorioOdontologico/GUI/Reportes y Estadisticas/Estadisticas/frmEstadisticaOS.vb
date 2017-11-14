Public Class frmEstadisticaOS

    Private Sub frmEstadisticaOS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSetEsadisticasOSPrueba.ObraSocial' table. You can move, or remove it, as needed.
        'Me.ObraSocialTableAdapter.Fill(Me.DataSetEsadisticasOSPrueba.ObraSocial)
        'TODO: This line of code loads data into the 'DataSetEsadisticasOSPrueba.ObraSocialXPaciente' table. You can move, or remove it, as needed.

        Me.ReportViewer1.Clear()
    End Sub

    Private Sub cmdConsult_Click(sender As Object, e As EventArgs) Handles cmdConsult.Click
        Dim strSQL As String = "SELECT OS.idOS, OS.nombre, COUNT(OSP.idNroAfiliado) AS 'Cantidad_Pacientes' FROM ObraSocial OS JOIN Planes  Pl ON (OS.idOS = Pl.idObraSocial) JOIN ObraSocialXPaciente OSP ON (Pl.idObraSocial = OSP.idObraSocial AND Pl.idPlan = OSP.idPlan) JOIN Pacientes P ON (P.dniPaciente = OSP.dniPaciente) WHERE P.activo = 'T' "

        If cmbSexo.SelectedIndex = -1 Or cmbSexo.SelectedIndex = 2 Then
            strSQL += "AND (sexo = 'F' OR sexo = 'M')"
        ElseIf cmbSexo.SelectedIndex = 0 Then
            strSQL += "AND sexo = 'M'"
        ElseIf cmbSexo.SelectedIndex = 1 Then
            strSQL += "AND sexo = 'F'"
        End If

        If mtxtEdadDesde.Text <> "" Then
            strSQL += " AND (YEAR(GETDATE())- YEAR(P.fechaNacimiento)) > " & mtxtEdadDesde.Text
        End If

        If mtxtEdadHasta.Text <> "" Then
            strSQL += " AND (YEAR(GETDATE())- YEAR(P.fechaNacimiento)) < " & mtxtEdadHasta.Text
        End If


        strSQL += " GROUP BY OS.idOS, OS.nombre"

        DataSetEstadisticaOSStoredPBindingSource.DataSource = BDHelper2.reportarPacientes(strSQL)
        Me.ReportViewer1.RefreshReport()


    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load

    End Sub
End Class