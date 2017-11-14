Public Class frmReporteEnfermedades


    Private Sub frmReporteEnfermedades_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim strSQL As String = "SELECT * FROM Enfermedades E ORDER BY E.nombre"

        EnfermedadesBindingSource.DataSource = BDHelper2.reportarPacientes(strSQL)
        Me.ReportViewer1.RefreshReport()
    End Sub

End Class