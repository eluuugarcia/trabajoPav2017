Public Class frmAgregarTurno

    Dim horaInicio As String = frmTurnos.dgvTurnos.SelectedRows(frmTurnos.dgvTurnos.SelectedRows.Count - 1).Cells(0).Value.ToString

    Dim cantTurnos As Integer = frmTurnos.dgvTurnos.SelectedRows.Count.ToString

    Private Sub frmAgregarTurno_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarCombo(cmbPrestacion, BDHelper2.GetPrestaciones(), "idPrestacion", "nombre")
    End Sub


    Private Sub CargarCombo(ByRef combo As ComboBox, ByRef datos As Data.DataTable, ByVal pk As String, ByVal descripcion As String)

        combo.DataSource = datos
        combo.ValueMember = pk
        combo.DisplayMember = descripcion
        combo.SelectedIndex = -1

    End Sub

    Private Sub Buscar_Click(sender As Object, e As EventArgs) Handles Buscar.Click
        Dim param As New List(Of Object)
        param.Add(mtxtDNI.Text)
        If BDHelper2.validarDatos(param.ToArray()) = True Then
            Dim P As New Paciente
            Dim paciente = BDHelper2.GetPaciente(mtxtDNI.Text)

            For Each fila As DataRow In paciente.Rows
                P.Nombres = fila.Item("nombre")
                P.Apellidos = fila.Item("apellido")
            Next
            If (P.Nombres IsNot Nothing) Then
                txtPaciente.Text = P.Nombres + " " + P.Apellidos
            Else
                MsgBox("Ese paciente no existe")
            End If
        End If
    End Sub

    Private Sub cmdAgregarNuevo_Click(sender As Object, e As EventArgs) Handles cmdAgregarNuevo.Click
        frmABMPacientes.ShowDialog()
        Me.Hide()
    End Sub




    Private Sub cmbPrestacion_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbPrestacion.SelectionChangeCommitted

        Dim dni As Integer = mtxtDNI.Text
        Dim os As Integer = BDHelper2.GetPaciente(dni).Rows(0).Item("idObraSocial").ToString
        Dim plan As String = BDHelper2.GetPaciente(dni).Rows(0).Item("idPlan").ToString
        Dim montoCubierto As Integer = BDHelper2.getPrecioPrestacion(cmbPrestacion.SelectedIndex + 1).Rows(0).Item("precio").ToString
        txtMontoCubierto.Text = "$" & montoCubierto
        txtMontoFinal.Text = "$" & BDHelper2.calcularMontoFinalPrestacion(montoCubierto, cmbPrestacion.SelectedIndex + 1, os, plan)
    End Sub

    Private Sub Cancelar_Click(sender As Object, e As EventArgs) Handles Cancelar.Click
        If MessageBox.Show("¿Desea cancelar?", _
        "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question _
        , MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.OK Then
            Me.Hide()
        End If
    End Sub

    Private Sub Agregar_Click(sender As Object, e As EventArgs) Handles Agregar.Click
        Dim param As New List(Of Object)
        Dim index As New List(Of Object)
        param.Add(txtPaciente.Text)
        index.Add(cmbPrestacion.SelectedValue)


        If BDHelper2.validarDatos(param.ToArray()) = True Then
            If BDHelper2.validarCombos(index.ToArray()) = True Then
                Dim str As String = ""
                Dim odontologo As Integer = frmTurnos.cmbOdontologos.SelectedIndex + 1
                Dim fecha As Date = frmTurnos.calendar.SelectionStart.ToShortDateString.ToString
                Dim indexRow As Integer = 0
                While frmTurnos.dgvTurnos.Rows(indexRow).Cells(0).Value <> horaInicio.ToString
                    indexRow += 1
                End While
                Dim i As Integer = indexRow
                For i = indexRow To (indexRow + cantTurnos - 1)
                    Dim hora As String = frmTurnos.dgvTurnos.Rows(i).Cells(0).Value.ToString
                    str += " insert into Turno "
                    str += "values (" & odontologo & "," & mtxtDNI.Text & ",CONVERT(DATE,'" & fecha & "',103),'"
                    str += hora & "'," & cmbPrestacion.SelectedIndex + 1 & "," & 1 & ",'" & rtxtDescripcion.Text & "')"
                Next

                BDHelper2.agregarTurnos(str)
                MsgBox("Turno registrado.")
                frmTurnos.llenarGrid(BDHelper2.GetTurnos(frmTurnos.cmbOdontologos.SelectedIndex + 1, frmTurnos.calendar.SelectionRange.Start.ToShortDateString))

                Me.Hide()
                frmTurnos.Show()
            End If
        End If

    End Sub
End Class