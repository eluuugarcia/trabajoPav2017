Public Class frmABMPacientes


    Private Sub frmABMPacientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarCombo(cmbOS, BDHelper2.GetObraSocial(), "idOS", "nombre")
        llenarGrid(BDHelper2.GetPacientes())
        dgvPacientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub

    Private Sub llenarGrid(ByVal source As Data.DataTable)
        dgvPacientes.Rows.Clear()

        For Each fila As DataRow In source.Rows
            dgvPacientes.Rows.Add(New String() {fila.Item("dniPaciente"), fila.Item("Apellido"), fila.Item("Nombre"), fila.Item("Sexo"), fila.Item("fechaNacimiento"), fila.Item("telContacto"), fila.Item("NombreOS"), fila.Item("NombrePlan"), fila.Item("idNroAfiliado"), fila.Item("idPlan"), fila.Item("idObraSocial")})

            Next

    End Sub

    Private Sub CargarCombo(ByRef combo As ComboBox, ByRef datos As Data.DataTable, ByVal pk As String, ByVal descripcion As String)

        combo.DataSource = datos
        combo.ValueMember = pk
        combo.DisplayMember = descripcion
        combo.SelectedIndex = -1

    End Sub


    Private Sub cmdConsultar_Click(sender As Object, e As EventArgs) Handles cmdConsultar.Click

        Dim param As New List(Of Object)
        param.Add(mtxtDNI.Text)
        If BDHelper2.validarDatos(param.ToArray()) = True Then
            Dim P As New Paciente
            Dim paciente = BDHelper2.GetPaciente(mtxtDNI.Text)

            For Each fila As DataRow In paciente.Rows
                P.Apellidos = fila.Item("Apellido")
            Next
            If (P.Apellidos IsNot Nothing) Then
                llenarGrid(paciente)
            Else
                MsgBox("Ese paciente no existe")
            End If
        End If

    End Sub

    Private Sub cmdSalir_Click(sender As Object, e As EventArgs)
        'Confirmación de salida.
        If MessageBox.Show("Seguro que desea salir?", _
                "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question _
                , MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.OK Then
            Me.Close()
        End If
    End Sub



    Private Sub cmdAgregar_Click(sender As Object, e As EventArgs) Handles cmdAgregar.Click

        Dim param As New List(Of Object)
        Dim index As New List(Of Object)
        param.Add(mtxtDNI.Text)
        param.Add(txtNombre.Text)
        param.Add(txtApellido.Text)
        param.Add(mtxtDOB.Text)
        param.Add(mtxtTelCont.Text)
        index.Add(cmbOS.SelectedValue)
        index.Add(cmbPlan.SelectedValue)
        param.Add(txtNroAfiliado.Text)


        If BDHelper2.validarDatos(param.ToArray()) = True Then
            If BDHelper2.validarCombos(index.ToArray()) = True Then
                If validarSiYaExiste() = True Then
                    If BDHelper2.validarFechaNac(CDate(mtxtDOB.Text)) = True Then

                        Dim str As String = "INSERT INTO Pacientes (dniPaciente, apellido,nombre,sexo,fechaNacimiento,telcontacto, activo) VALUES("
                        str += mtxtDNI.Text & ", '" & txtApellido.Text & "','" & txtNombre.Text & "','"
                        If cmbSexo.SelectedIndex = 1 Then
                            str += "F',"
                        Else
                            str += "M',"
                        End If
                        str += "CONVERT(DATE,'" & mtxtDOB.Text & "', 103 ),'" & mtxtTelCont.Text & "', 'T')"

                        str += "INSERT INTO ObraSocialXPaciente (idNroAfiliado,idPlan,idObraSocial,dniPaciente) VALUES("
                        str += txtNroAfiliado.Text & "," & cmbPlan.SelectedValue & "," & cmbOS.SelectedValue & "," & mtxtDNI.Text & ")"

                        BDHelper2.agregarPaciente(str)
                        MsgBox("El paciente se ha dado de alta")

                        llenarGrid(BDHelper2.GetPacientes())
                        deshabilitarCampos()
                        cmdAgregar.Enabled = False
                        borrarCampos()
                    End If
                Else : MsgBox("Ese paciente ya está registrado.")
                End If
            End If
        End If

    End Sub

    Private Sub cmbOS_SelectionChangedCommit(sender As Object, e As EventArgs) Handles cmbOS.SelectedIndexChanged
        CargarCombo(cmbPlan, BDHelper2.GetPlan(cmbOS.SelectedIndex), "idPlan", "nombre")
    End Sub

    Private Sub cmdModificar_Click(sender As Object, e As EventArgs) Handles cmdModificar.Click

        Dim param As New List(Of Object)
        Dim index As New List(Of Object)
        param.Add(mtxtDNI.Text)
        param.Add(txtNombre.Text)
        param.Add(txtApellido.Text)
        param.Add(mtxtDOB.Text)
        param.Add(mtxtTelCont.Text)
        param.Add(txtNroAfiliado.Text)
        index.Add(cmbOS.SelectedIndex)
        index.Add(cmbPlan.SelectedIndex)

        If BDHelper2.validarCombos(index.ToArray()) = True Then
            If BDHelper2.validarDatos(param.ToArray()) = True Then


                Dim str As String = "UPDATE Pacientes SET apellido = '" & txtApellido.Text & "', nombre = '" & txtNombre.Text & "', sexo ='"
                If cmbSexo.SelectedIndex = 1 Then
                    str += "F',"
                Else
                    str += "M',"
                End If
                str += "fechaNacimiento = CONVERT(DATE,'" & mtxtDOB.Text & "', 103 ),telcontacto = '" & mtxtTelCont.Text & "' WHERE dniPaciente =" & mtxtDNI.Text
                BDHelper2.modificarPaciente(str)

                llenarGrid(BDHelper2.GetPacientes())
                MsgBox("La informacion del paciente ha sido actualizada")
                deshabilitarCampos()
                cmdEliminar.Enabled = False
                cmdModificar.Enabled = False

            End If
        End If

    End Sub



    Private Sub cmdEliminar_Click(sender As Object, e As EventArgs) Handles cmdEliminar.Click
        If MessageBox.Show("¿Desea eliminar el paciente?", _
               "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question _
               , MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.OK Then
            Dim dni As String = dgvPacientes.CurrentRow.Cells(0).Value
            Dim str As String = "UPDATE Pacientes SET activo = 'F' WHERE dniPaciente = " & dni
            BDHelper2.eliminarPaciente(str)
            llenarGrid(BDHelper2.GetPacientes())
            MsgBox("El paciente ha sido dado de baja exitosamente")
        End If
    End Sub


    Private Sub cmdBorrarCampos_Click(sender As Object, e As EventArgs) Handles cmdBorrarCampos.Click
        borrarCampos()

    End Sub

    Private Sub dgvPacientes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPacientes.CellClick
        habilitarCampos()
        cmdEliminar.Enabled = True
        cmdModificar.Enabled = True
        mtxtDNI.Text = dgvPacientes.CurrentRow.Cells(0).Value
        txtApellido.Text = dgvPacientes.CurrentRow.Cells(1).Value
        txtNombre.Text = dgvPacientes.CurrentRow.Cells(2).Value
        If dgvPacientes.CurrentRow.Cells(3).Value.ToString.Trim = "F" Then
            cmbSexo.SelectedIndex = 1
        Else
            cmbSexo.SelectedIndex = 0
        End If
        mtxtDOB.Text = dgvPacientes.CurrentRow.Cells(4).Value
        mtxtTelCont.Text = dgvPacientes.CurrentRow.Cells(5).Value
        txtNroAfiliado.Text = dgvPacientes.CurrentRow.Cells(8).Value
        cmbOS.SelectedValue = dgvPacientes.CurrentRow.Cells(10).Value
        cmbPlan.SelectedValue = dgvPacientes.CurrentRow.Cells(9).Value


    End Sub



    Private Sub dgvPacientes_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPacientes.CellContentDoubleClick
        Me.Hide()
        frmHistoriaClinicavb.ShowDialog()

    End Sub

    Private Sub frmABMPacientes_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Hide()
        frmMenu.Show()
    End Sub

    Private Function validarSiYaExiste() As Boolean
        If BDHelper2.GetPaciente(mtxtDNI.Text).Rows.Count = 1 Then
            Return False
        Else
            Return True
        End If

    End Function

    Private Sub cmbPlan_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbPlan.SelectionChangeCommitted
        If cmbOS.SelectedIndex = 0 And cmbPlan.SelectedIndex = 0 Then
            txtNroAfiliado.Text = BDHelper2.GetPacientes().Rows.Count + 1
            txtNroAfiliado.Enabled = False
        End If
    End Sub


    Private Sub deshabilitarCampos()
        txtApellido.Enabled = False
        txtNombre.Enabled = False
        txtNroAfiliado.Enabled = False
        mtxtDOB.Enabled = False
        mtxtTelCont.Enabled = False
        cmbOS.Enabled = False
        cmbPlan.Enabled = False
        cmbSexo.Enabled = False
    End Sub

    Private Sub habilitarCampos()
        txtApellido.Enabled = True
        txtNombre.Enabled = True
        txtNroAfiliado.Enabled = True
        mtxtDOB.Enabled = True
        mtxtTelCont.Enabled = True
        cmbOS.Enabled = True
        cmbPlan.Enabled = True
        cmbSexo.Enabled = True
    End Sub


    Private Sub Nuevo_Click(sender As Object, e As EventArgs) Handles Nuevo.Click
        habilitarCampos()
        cmdAgregar.Enabled = True
        borrarCampos()
    End Sub

    Private Sub borrarCampos()
        mtxtDNI.Text = ""
        txtApellido.Text = ""
        txtNombre.Text = ""
        mtxtTelCont.Text = ""
        mtxtDOB.Text = ""
        cmbOS.SelectedIndex = -1
        cmbPlan.SelectedIndex = -1
        cmbSexo.SelectedIndex = -1
        txtNroAfiliado.Text = ""
    End Sub
End Class
