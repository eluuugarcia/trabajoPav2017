Public Class frmReportePacientesvb

    Private Sub frmReportePacientesvb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSetPacientes.Pacientes' table. You can move, or remove it, as needed.
        Me.PacientesTableAdapter.Fill(Me.DataSetPacientes.Pacientes)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class