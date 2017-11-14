Public Class frmTurnos



    Private Sub frmTurnos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarCombo(cmbOdontologos, BDHelper2.cargarComboOdontologos(), "legajo", "Odontologo")
        CargarCombo(cmbEstadoTurno, BDHelper2.getEstadosTurno(), "idEstado", "nombre")
        cargarHorarios()
        dgvTurnos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvTurnos.ClearSelection()
        cmdAgregar.Enabled = False
    End Sub

    Private Sub CargarCombo(ByRef combo As ComboBox, ByRef datos As Data.DataTable, ByVal pk As String, ByVal descripcion As String)

        combo.DataSource = datos
        combo.ValueMember = pk
        combo.DisplayMember = descripcion
        combo.SelectedIndex = -1

    End Sub


    Private Sub calendar_DateChanged(sender As Object, e As DateRangeEventArgs) Handles calendar.DateChanged
        If cmbOdontologos.SelectedIndex <> -1 Then
            dgvTurnos.Rows.Clear()
            llenarGrid(BDHelper2.GetTurnos(cmbOdontologos.SelectedIndex + 1, calendar.SelectionRange.Start.ToShortDateString))
        End If
    End Sub

    Public Sub llenarGrid(ByRef source As List(Of Turno))
        cargarHorarios()
        For Each oTurno As Turno In source
            Dim row As Integer = 0

            While dgvTurnos.Rows(row).Cells(0).Value.ToString <> oTurno.hora
                row += 1
            End While
            dgvTurnos.Rows(row).Cells(1).Value = oTurno.paciente
            dgvTurnos.Rows(row).Cells(2).Value = oTurno.prestacion
            dgvTurnos.Rows(row).Cells(3).Value = oTurno.descripcion
            dgvTurnos.Rows(row).Cells(4).Value = oTurno.estado
            dgvTurnos.Rows(row).Cells(5).Value = oTurno.idPaciente
            dgvTurnos.Rows(row).Cells(6).Value = oTurno.idPrestacion
            dgvTurnos.Rows(row).Cells(7).Value = oTurno.idEstado
            If oTurno.idEstado = 1 Then
                dgvTurnos.Rows(row).DefaultCellStyle.BackColor = Color.IndianRed
            ElseIf oTurno.idEstado = 2 Then
                dgvTurnos.Rows(row).DefaultCellStyle.BackColor = Color.Orange
            ElseIf oTurno.idEstado = 3 Then
                dgvTurnos.Rows(row).DefaultCellStyle.BackColor = Color.Khaki
            ElseIf oTurno.idEstado = 4 Then
                dgvTurnos.Rows(row).DefaultCellStyle.BackColor = Color.LightGray
            End If




        Next
    End Sub


    Private Sub cargarHorarios()
        dgvTurnos.Rows.Clear()
        dgvTurnos.Rows.Add(27)
        Dim hs As Integer = 10
        Dim row As Integer = 0

        For i = 9 To 19
            If (hs <> 12 And hs <> 13) Then
                dgvTurnos.Rows(row).Cells(0).Value = (hs.ToString + ":00")
                dgvTurnos.Rows(row).Cells(8).Value = (hs.ToString + ":20")
                dgvTurnos.Rows(row).DefaultCellStyle.BackColor = Color.LightGreen

                dgvTurnos.Rows(row + 1).Cells(0).Value = (hs.ToString + ":20")
                dgvTurnos.Rows(row + 1).Cells(8).Value = (hs.ToString + ":40")
                dgvTurnos.Rows(row + 1).DefaultCellStyle.BackColor = Color.LightGreen

                dgvTurnos.Rows(row + 2).Cells(0).Value = (hs.ToString + ":40")
                dgvTurnos.Rows(row + 2).Cells(8).Value = ((hs + 1).ToString + ":00")
                dgvTurnos.Rows(row + 2).DefaultCellStyle.BackColor = Color.LightGreen
                row += 3
            End If
            hs += 1
        Next

    End Sub

    Private Sub cmbOdontologos_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbOdontologos.SelectionChangeCommitted
        cargarHorarios()
        llenarGrid(BDHelper2.GetTurnos(cmbOdontologos.SelectedIndex + 1, calendar.SelectionRange.Start.ToShortDateString))
    End Sub

    Private Sub cmdAgregar_Click(sender As Object, e As EventArgs) Handles cmdAgregar.Click
        frmAgregarTurno.lblFecha.Text = "Fecha: " & calendar.SelectionStart.ToShortDateString.ToString
        Dim hs As String = "Horario: " & dgvTurnos.SelectedRows(dgvTurnos.SelectedRows.Count - 1).Cells(0).Value.ToString
        hs += " - " & dgvTurnos.SelectedRows(0).Cells(8).Value.ToString
        frmAgregarTurno.lblHora.Text = hs
        frmAgregarTurno.lblOdontologo.Text = "Odontólogo: " & cmbOdontologos.Text.ToString
        frmAgregarTurno.Show()
        cargarHorarios()
        llenarGrid(BDHelper2.GetTurnos(cmbOdontologos.SelectedIndex + 1, calendar.SelectionRange.Start.ToShortDateString))
        dgvTurnos.ClearSelection()


    End Sub


    Private Function validarTurnosOcupados() As Boolean
        If dgvTurnos.SelectedRows.Count > 0 Then
            For Each row As DataGridViewRow In dgvTurnos.SelectedRows
                If (row.Cells(4).Value IsNot Nothing) Then
                    Return True
                End If
            Next
        End If
        Return False

    End Function

    Private Sub cmbEstadoTurno_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbEstadoTurno.SelectionChangeCommitted
        If MessageBox.Show("¿Desea cambiar el turno?", _
                "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question _
                , MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.OK Then
            Dim str As String = ""
            For Each row As DataGridViewRow In dgvTurnos.SelectedRows
                Dim hora As String = row.Cells(0).Value.ToString
                str += " UPDATE TURNO SET idEstado = " & cmbEstadoTurno.SelectedIndex + 2
                str += " WHERE fecha = CONVERT(DATE,'" & calendar.SelectionStart.ToShortDateString & "',103) AND hora = '"
                str += hora & "' AND legajoOdontologo = " & cmbOdontologos.SelectedIndex + 1
            Next
            BDHelper2.cambiarEstadoTurnos(str)
            MsgBox("Estado cambiado.")
            cargarHorarios()
            llenarGrid(BDHelper2.GetTurnos(cmbOdontologos.SelectedIndex + 1, calendar.SelectionRange.Start.ToShortDateString))
            dgvTurnos.ClearSelection()
        End If
    End Sub
    Private Sub mostrarDetallesTurno()
        rtxtDetalles.Clear()

        Dim dni As Integer = dgvTurnos.CurrentRow.Cells(5).Value.ToString
        Dim os As String = BDHelper2.GetPaciente(dni).Rows(0).Item("NombreOS").ToString
        Dim plan As String = BDHelper2.GetPaciente(dni).Rows(0).Item("NombrePlan").ToString

        rtxtDetalles.AppendText("Paciente: " & dgvTurnos.CurrentRow.Cells(1).Value.ToString & vbLf)
        rtxtDetalles.AppendText(vbLf & "DNI: " & dni & vbLf)
        rtxtDetalles.AppendText(vbLf & "Obra Social: " & os & " - " & plan & vbLf)
        rtxtDetalles.AppendText(vbLf & "Prestación: " & dgvTurnos.CurrentRow.Cells(2).Value.ToString)
        rtxtDetalles.AppendText(vbLf & dgvTurnos.CurrentRow.Cells(3).Value.ToString)
        rtxtDetalles.AppendText(vbLf & "Odontólogo: " & cmbOdontologos.Text & vbLf)



    End Sub





    Private Sub cmdCancelar_Click(sender As Object, e As EventArgs) Handles cmdCancelar.Click
        If MessageBox.Show("¿Desea cancelar el/los turnos(s) seleccionado(s)?", _
        "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question _
        , MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.OK Then
            Dim str As String = ""
            Dim fecha As Date = calendar.SelectionStart.ToShortDateString
            For Each row As DataGridViewRow In dgvTurnos.SelectedRows
                Dim hora As String = row.Cells(0).Value.ToString
                str += " DELETE FROM TURNO WHERE (fecha = CONVERT(DATE,'" & fecha & "',103) AND hora = '" & hora & "')"
            Next
            BDHelper2.eliminarTurnos(str)
            MsgBox("El turno ha sido cancelado.")
            llenarGrid(BDHelper2.GetTurnos(cmbOdontologos.SelectedIndex + 1, calendar.SelectionRange.Start.ToShortDateString))
            dgvTurnos.ClearSelection()
        End If
    End Sub

    Private Sub dgvTurnos_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvTurnos.RowHeaderMouseClick
        If cmbOdontologos.SelectedIndex <> -1 Then
            rtxtDetalles.Clear()
            If validarTurnosOcupados() = False Then
                cmdAgregar.Enabled = True
                cmdCancelar.Enabled = False
                cmbEstadoTurno.Enabled = False

            Else
                cmdAgregar.Enabled = False
                cmdCancelar.Enabled = True
                cmbEstadoTurno.Enabled = True
                mostrarDetallesTurno()
            End If
        End If
    End Sub

    Private Sub dgvTurnos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTurnos.CellClick
        If cmbOdontologos.SelectedIndex <> -1 Then
            rtxtDetalles.Clear()

                If validarTurnosOcupados() = False Then
                    cmdAgregar.Enabled = True
                    cmdCancelar.Enabled = False
                    cmbEstadoTurno.Enabled = False

                Else
                    cmdAgregar.Enabled = False
                    cmdCancelar.Enabled = True
                    cmbEstadoTurno.Enabled = True
                    mostrarDetallesTurno()
                End If
        End If
    End Sub



    Private Sub frmTurnos_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        frmMenu.Show()
    End Sub

End Class