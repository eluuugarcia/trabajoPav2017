Public Class frmReportePrestaciones



    Private Sub frmReportePrestaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim strSQL As String = "SELECT * FROM Prestaciones P ORDER BY P.nombre"

        PrestacionesBindingSource.DataSource = BDHelper2.reportarPacientes(strSQL)
        Me.ReportViewer1.RefreshReport()

    End Sub


End Class