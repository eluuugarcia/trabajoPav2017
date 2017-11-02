Public Class frmMenu

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub cmdPacientes_Click(sender As Object, e As EventArgs) Handles cmdPacientes.Click
        Me.Hide()
        frmABMPacientes.Show()
    End Sub


    Private Sub cmdOdontologos_Click(sender As Object, e As EventArgs) Handles cmdOdontologos.Click
        Me.Hide()
        frmABMOdontologos.Show()
    End Sub

    Private Sub cmdOS_Click(sender As Object, e As EventArgs) Handles cmdOS.Click
        Me.Hide()
        frmObraSocial.Show()
    End Sub



    Private Sub frmMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cmdTurnos_Click(sender As Object, e As EventArgs) Handles cmdTurnos.Click
        Me.Hide()
        frmTurnos.Show()

    End Sub

    Private Sub cmdInformes_Click(sender As Object, e As EventArgs) Handles cmdInformes.Click
        frmMenuReportes.ShowDialog()
    End Sub
End Class