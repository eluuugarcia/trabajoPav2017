Public Class frmFacturacion

    Private Sub frmFacturacion_FormClosed(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        frmMenu.Show()
    End Sub


    Private Sub frmFacturacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvTurnosAFacturar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvTurnosNoFacturados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        txtFecha.Text = Today.Date
        txtMontoTotal.Text = "0"
        txtNroFactura.Text = BDHelper2.BuscarNroFactura()
        dgvTurnosAFacturar.Refresh()
        dgvTurnosNoFacturados.Refresh()
        txtMontoTotal.Refresh()
        txtOS.Refresh()
        txtPlan.Refresh()


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
                P.OS = fila.Item("NombreOS")
                P.Plan = fila.Item("NombrePlan")

            Next
            If (P.Nombres IsNot Nothing) Then
                txtPaciente.Text = P.Nombres + " " + P.Apellidos
                txtOS.Text = P.OS
                txtPlan.Text = P.Plan
                llenarGrid(buscarTurnosNoFacturados())
            Else
                MsgBox("Ese paciente no existe.")
            End If
        End If
    End Sub

    Private Function buscarTurnosNoFacturados() As Data.DataTable
        Return BDHelper2.GetTurnosNoFacturados(mtxtDNI.Text)
    End Function

    Private Sub llenarGrid(ByVal source As Data.DataTable)
        dgvTurnosNoFacturados.Rows.Clear()

        For Each fila As DataRow In source.Rows
            If fila.Item("costo").ToString <> 0 Then
                dgvTurnosNoFacturados.Rows.Add(New String() {fila.Item("fecha"), fila.Item("hora"), fila.Item("idPrestacion"), fila.Item("Prestacion"), fila.Item("legajo"), fila.Item("Odontologo"), fila.Item("costo"), fila.Item("idObraSocial"), fila.Item("idPlan")})
            End If
        Next

    End Sub



    Private Sub dgvTurnosNoFacturados_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvTurnosNoFacturados.CellMouseDoubleClick
        If dgvTurnosNoFacturados.Rows.Count > 1 Then
            Dim fila As DataGridViewRow = dgvTurnosNoFacturados.CurrentRow
            Dim count As Integer = dgvTurnosAFacturar.Rows.Count
            dgvTurnosAFacturar.Rows.Add(1)
            For i = 0 To dgvTurnosNoFacturados.ColumnCount - 1
                dgvTurnosAFacturar.Rows(count - 1).Cells(i).Value = fila.Cells(i).Value
            Next
            txtMontoTotal.Text = Int32.Parse(txtMontoTotal.Text) + fila.Cells.Item("Monto").Value
            dgvTurnosNoFacturados.Rows.RemoveAt(dgvTurnosNoFacturados.CurrentRow.Index)
        End If

    End Sub

    Private Sub dgvTurnosAFacturar_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvTurnosAFacturar.CellMouseDoubleClick
        If dgvTurnosAFacturar.Rows.Count > 1 Then
            Dim fila As DataGridViewRow = dgvTurnosAFacturar.CurrentRow
            Dim count As Integer = dgvTurnosNoFacturados.Rows.Count
            dgvTurnosNoFacturados.Rows.Add(1)
            For i = 0 To dgvTurnosAFacturar.ColumnCount - 1
                dgvTurnosNoFacturados.Rows(count - 1).Cells(i).Value = fila.Cells(i).Value
            Next
            txtMontoTotal.Text = Int32.Parse(txtMontoTotal.Text) - fila.Cells.Item("Monto2").Value
            dgvTurnosAFacturar.Rows.RemoveAt(dgvTurnosAFacturar.CurrentRow.Index)
        End If
    End Sub


    Private Sub cmdAceptar_Click(sender As Object, e As EventArgs) Handles cmdAceptar.Click
        Dim index As New List(Of Object)
        index.Add(cmbTipo.SelectedValue)

        If mtxtDNI.Text <> "" Then
            If BDHelper2.validarCombos(index.ToArray()) = True Then
                If dgvTurnosAFacturar.Rows.Count > 1 Then

                    Dim idOS As Integer = dgvTurnosAFacturar.CurrentRow.Cells(7).Value
                    Dim idPlan As Integer = dgvTurnosAFacturar.CurrentRow.Cells(8).Value

                    Dim str As String = "INSERT INTO Factura VALUES (CONVERT(DATE,'" & Today.Date & "',103),"
                    str += mtxtDNI.Text & "," & idOS & "," & idPlan & "," & txtMontoTotal.Text & ")"

                    For i = 0 To dgvTurnosAFacturar.Rows.Count - 2
                        Dim idPrestacion As Integer = dgvTurnosAFacturar.Rows(i).Cells(2).Value
                        Dim subtotal As Integer = dgvTurnosAFacturar.Rows(i).Cells(6).Value
                        Dim fecha As Date = dgvTurnosAFacturar.Rows(i).Cells(0).Value
                        Dim hora As String = dgvTurnosAFacturar.Rows(i).Cells(1).Value
                        Dim legajoOdontologo As Integer = dgvTurnosAFacturar.CurrentRow.Cells(4).Value

                        str += " INSERT INTO DetalleFactura VALUES(" & txtNroFactura.Text & "," & idPrestacion & "," & subtotal & "," & legajoOdontologo & ")"
                        str += " UPDATE Turno SET facturado = 'T' WHERE fecha = CONVERT(DATE,'" & fecha & "',103) AND hora = '" & hora & "' and legajoOdontologo = " & legajoOdontologo
                    Next
                    BDHelper2.crearFactura(str)
                    MsgBox("Factura agregada.")
                    dgvTurnosAFacturar.Rows.Clear()
                    llenarGrid(buscarTurnosNoFacturados())


                Else
                    MsgBox("Debe seleccionar al menos un turno para facturar.")
                End If
            End If
        Else
            MsgBox("Debe ingresar un DNI de paciente.")
        End If

    End Sub


    Private Sub borrarCampos()
        mtxtDNI.Text = ""
        txtMontoTotal.Text = "0"
        txtOS.Text = ""
        txtPaciente.Text = ""
        txtPlan.Text = ""
        cmbTipo.SelectedIndex = -1
    End Sub


End Class