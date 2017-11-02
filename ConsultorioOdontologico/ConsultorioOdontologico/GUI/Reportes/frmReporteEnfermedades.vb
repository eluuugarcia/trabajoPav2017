Public Class frmReporteEnfermedades

    Private Sub frmReporteEnfermedades_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSetEnfermedades.Enfermedades' table. You can move, or remove it, as needed.
        Me.EnfermedadesTableAdapter.Fill(Me.DataSetEnfermedades.Enfermedades)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class