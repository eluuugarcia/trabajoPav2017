Public Class frmReporteOdontologos

    Private Sub frmReporteOdontologos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSetOdontologos.Odontologos' table. You can move, or remove it, as needed.
        Me.OdontologosTableAdapter.Fill(Me.DataSetOdontologos.Odontologos)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class