Public Class frmAgregarMedicamentoInexistente

    Private Sub frmAgregarMedicamentoInexistente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtNombre.Text = ""
        txtLaboratorio.Text = ""
        rtxtRestricciones.Text = ""
    End Sub

    Private Sub cmdAgregar_Click(sender As Object, e As EventArgs) Handles cmdAgregar.Click
        Dim param As New List(Of Object)


        param.Add(txtNombre.Text)
        param.Add(txtLaboratorio.Text)

        If BDHelper2.validarDatos(param.ToArray()) = True Then
            If BDHelper2.validarQueNoEsteEn(txtNombre.Text, BDHelper2.GetAlergias()) = True Then
                Dim str As String = "INSERT INTO Medicamentos(droga,laboratorio,restricciones) VALUES("
                str += "'" & txtNombre.Text & "','" & txtLaboratorio.Text & "','" & rtxtRestricciones.Text & "')"

                BDHelper2.agregarMedicamento(str)
                MsgBox("Medicamento agregado.")
            End If
        End If
    End Sub
End Class