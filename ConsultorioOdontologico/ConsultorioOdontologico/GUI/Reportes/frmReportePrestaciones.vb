Public Class frmReportePrestaciones

    Private Sub frmReportePrestaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSetPrestaciones.Prestaciones' table. You can move, or remove it, as needed.
        Me.PrestacionesTableAdapter.Fill(Me.DataSetPrestaciones.Prestaciones)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class