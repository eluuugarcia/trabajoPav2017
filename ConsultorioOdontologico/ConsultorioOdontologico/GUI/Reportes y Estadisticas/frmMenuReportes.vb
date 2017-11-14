Public Class frmMenuReportes

    Private Sub cmdConsultarReportes_Click(sender As Object, e As EventArgs) Handles cmdConsultarReportes.Click
        Dim eleccion As Integer = cmbReportes.SelectedIndex + 1
        Select Case eleccion
            Case 1
                frmReportePacientesvb.ShowDialog()
            Case 2
                frmReporteOdontologos.ShowDialog()
            Case 3
                frmReporteEnfermedades.ShowDialog()
            Case 4
                frmReportePrestaciones.ShowDialog()
        End Select
    End Sub



    Private Sub cmdConsultarEstadisticas_Click(sender As Object, e As EventArgs) Handles cmdConsultarEstadisticas.Click
        Dim eleccion As Integer = cmbEstadisticas.SelectedIndex + 1
        Select eleccion
            Case 1
                frmEstadisticaOS.ShowDialog()
            Case 2
                frmEstadisticaOdontologosSolicitados.ShowDialog()
        End Select
    End Sub

    Private Sub frmMenuReportes_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Hide()
        frmMenu.Show()
    End Sub
End Class