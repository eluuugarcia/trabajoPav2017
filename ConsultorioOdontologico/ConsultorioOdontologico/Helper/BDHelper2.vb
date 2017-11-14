Imports System.Data.SqlClient

Public Class BDHelper2

    Public Shared string_conexion As String = "Data Source=DESKTOP-I4BBJMS\SQLEXPRESS;Initial Catalog=db_consultorio_odontologico;User ID=sa;Password=19781996"

    Private Shared Function EjecutarSQL(ByVal strSql As String) As Integer
        Dim conexion As New SqlConnection
        Dim cmd As New SqlCommand
        Dim tabla As New Data.DataTable
        Try
            conexion.ConnectionString = string_conexion
            conexion.Open()
            cmd.Connection = conexion
            cmd.CommandType = CommandType.Text
            cmd.CommandText = strSql

            Return cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw ex
        Finally
            conexion.Close()
            conexion.Dispose()
        End Try
    End Function

    

    Private Shared Function ConsultaSQL(ByVal strSql As String) As Data.DataTable
        Dim conexion As New SqlConnection
        Dim cmd As New SqlCommand
        Dim tabla As New DataTable
        Try
            conexion.ConnectionString = string_conexion
            conexion.Open()
            cmd.Connection = conexion
            cmd.CommandType = CommandType.Text
            cmd.CommandText = strSql

            tabla.Load(cmd.ExecuteReader())

            Return tabla
        Catch ex As Exception
            Throw ex
        Finally
            conexion.Close()
            conexion.Dispose()
        End Try
    End Function


    Public Shared Sub transaccionHistoriaClinica(ByVal strSql As String)
        Dim conexion As New SqlConnection
        Dim cmd As New SqlCommand
        Dim transaccion As SqlTransaction

        conexion.ConnectionString = string_conexion
        conexion.Open()
        transaccion = conexion.BeginTransaction

        Try

            cmd = New SqlCommand(strSql, conexion, transaccion)
            cmd.Connection = conexion

            cmd.ExecuteNonQuery()

            transaccion.Commit()
            MsgBox("Entradas nuevas de la historia clinica registradas")

        Catch ex As Exception
            transaccion.Rollback()
            MsgBox("No se pudieron registrar los datos de la Historia Clinica")

        Finally
            conexion.Close()
            conexion.Dispose()

        End Try

    End Sub


    Public Shared Function GetPacientes() As Data.DataTable
        Dim tabla As Data.DataTable
        Dim consulta As String = "SELECT Pacientes.dniPaciente ,Pacientes.nombre , Pacientes.apellido, Pacientes.sexo , Pacientes.fechaNacimiento , Pacientes.telContacto , ObraSocial.nombre AS 'NombreOS', Planes.nombre AS 'NombrePlan', ObraSocialXPaciente.idNroAfiliado, ObraSocialXPaciente.idPlan, ObraSocialXPaciente.idObraSocial FROM (Pacientes JOIN ObraSocialXPaciente ON (Pacientes.dniPaciente = ObraSocialXPaciente.dniPaciente)) JOIN ObraSocial ON (ObraSocial.idOS = ObraSocialXPaciente.idObraSocial) JOIN Planes ON (Planes.idObraSocial = ObraSocialXPaciente.idObraSocial AND Planes.idPlan = ObraSocialXPaciente.idPlan ) WHERE Pacientes.activo = 'T' ORDER BY Pacientes.apellido"

        tabla = ConsultaSQL(consulta)

        Return tabla

    End Function

    Public Shared Function GetPaciente(ByVal dni As Integer) As Data.DataTable

        Dim tabla As Data.DataTable
        Dim consulta As String = "SELECT Pacientes.dniPaciente ,Pacientes.nombre , Pacientes.apellido, Pacientes.sexo , Pacientes.fechaNacimiento , Pacientes.telContacto , ObraSocial.nombre AS 'NombreOS', Planes.nombre AS 'NombrePlan', ObraSocialXPaciente.idNroAfiliado, ObraSocialXPaciente.idPlan, ObraSocialXPaciente.idObraSocial FROM Pacientes JOIN ObraSocialXPaciente ON Pacientes.dniPaciente = ObraSocialXPaciente.dniPaciente JOIN ObraSocial ON ObraSocial.idOS = ObraSocialXPaciente.idObraSocial JOIN Planes ON (Planes.idObraSocial = ObraSocialXPaciente.idObraSocial AND Planes.idPlan = ObraSocialXPaciente.idPlan ) WHERE Pacientes.dniPaciente = " & dni & " AND Pacientes.activo = 'T'"
        tabla = ConsultaSQL(consulta)
        Return tabla


    End Function


    Public Shared Function GetOdontologo(ByVal legajo As Integer) As Data.DataTable

        Dim tabla As Data.DataTable

        Dim consulta As String = "SELECT O.legajo, O.dniOdontologo AS DNI, O.apellido, O.nombre , O.sexo , O.fechaNacimiento , O.telContacto , O.eMail, O.nroMatricula, O.domicilio FROM Odontologos O WHERE O.activo = 'T' AND O.legajo = " & legajo

        tabla = ConsultaSQL(consulta)

        Return tabla

    End Function

    Public Shared Function GetOdontologos() As Data.DataTable
        Dim tabla As Data.DataTable
        Dim consulta As String = "SELECT O.legajo, O.dniOdontologo AS DNI, O.apellido, O.nombre , O.sexo , O.fechaNacimiento , O.telContacto , O.eMail, O.nroMatricula, O.domicilio FROM Odontologos O WHERE O.activo = 'T' ORDER BY O.apellido"

        tabla = ConsultaSQL(consulta)


        Return tabla

    End Function




    Public Shared Function GetObraSocial() As DataTable
        Dim strSQL As String = "SELECT * FROM ObraSocial"
        Return BDHelper2.ConsultaSQL(strSQL)
    End Function

    Public Shared Function GetObraSocialSinNT() As DataTable
        Dim strSQL As String = "SELECT * FROM ObraSocial WHERE ObraSocial.nombre != 'N/T'"
        Return BDHelper2.ConsultaSQL(strSQL)
    End Function

    Public Shared Function GetPlan(ByRef OSSeleccionada As Integer) As DataTable
        Dim strSQL As String = "SELECT * FROM Planes WHERE idObraSocial =  " & OSSeleccionada.ToString
        Return BDHelper2.ConsultaSQL(strSQL)
    End Function

    Public Shared Function GetPrestacionesParaGrilla(ByVal PlanSeleccionado As Integer, ByVal OSSeleccionada As Integer) As Data.DataTable
        Dim tabla As Data.DataTable
        Dim consulta As String = "SELECT PPP.idPlan, PPP.idObraSocial,PPP.idPrestacion, P.nombre, P.descripcion, P.precio, PPP.montoCubierto, P.duracion FROM Prestaciones P JOIN PrestacionesPorPlan PPP ON (P.idPrestacion = PPP.idPrestacion) WHERE (PPP.idObraSocial = " & OSSeleccionada & " AND PPP.idPlan = " & PlanSeleccionado & ") ORDER BY P.nombre"

        tabla = ConsultaSQL(consulta)

        Return tabla

    End Function

    Public Shared Function GetPrestacionesNotInPlan(OSSeleccionada As Integer, PlanSeleccionado As Integer) As DataTable

        Dim strSQL As String = "SELECT P.idPrestacion, P.nombre FROM Prestaciones P WHERE P.idPrestacion NOT IN ("
        strSQL += "SELECT P.idPrestacion FROM Prestaciones P LEFT JOIN PrestacionesPorPlan PPP ON (P.idPrestacion = PPP.idPrestacion)"
        strSQL += "WHERE (PPP.idObraSocial  = " & OSSeleccionada & ") AND (PPP.idPlan = " & PlanSeleccionado & "))"
        Return BDHelper2.ConsultaSQL(strSQL)
    End Function


    Public Shared Function GetPrestaciones() As DataTable
        Dim strSQL As String = "SELECT * FROM Prestaciones"
        Return BDHelper2.ConsultaSQL(strSQL)
    End Function

    Public Shared Function GetEspecialidadesParaGrilla() As Data.DataTable
        Dim tabla As Data.DataTable
        Dim consulta As String = "SELECT * FROM Especialidad"

        tabla = ConsultaSQL(consulta)


        Return tabla

    End Function


    Public Shared Sub agregarPaciente(ByVal str As String)
        BDHelper2.EjecutarSQL(str)
    End Sub

    Public Shared Function agregarOdontologo(ByVal str As String) As Integer
        Dim tabla As Data.DataTable = BDHelper2.ConsultaSQL(str)
        Return tabla.Rows(0).Item("ID")

    End Function

    Public Shared Sub agregarEspecialidadesXOdontologo(ByVal str As String)
        BDHelper2.EjecutarSQL(str)
    End Sub


    Public Shared Sub modificarPaciente(ByVal str As String)
        BDHelper2.EjecutarSQL(str)
    End Sub

    Public Shared Sub modificarOdontologo(ByVal str As String)
        BDHelper2.EjecutarSQL(str)
    End Sub

    Public Shared Sub eliminarPaciente(ByVal str As String)
        BDHelper2.EjecutarSQL(str)
    End Sub

    Public Shared Sub eliminarOdontologo(ByVal str As String)
        BDHelper2.EjecutarSQL(str)
    End Sub

    Public Shared Sub agregarPrestacionPorPlan(ByVal str As String)
        BDHelper2.EjecutarSQL(str)
    End Sub

    Public Shared Sub agregarPlan(ByVal str As String)
        BDHelper2.EjecutarSQL(str)
    End Sub

    Public Shared Sub agregarEspecialidad(ByVal str As String)
        BDHelper2.EjecutarSQL(str)
    End Sub

    Public Shared Function getEspecialidadesPorOdontologo(ByVal str As String) As Data.DataTable
        Return BDHelper2.ConsultaSQL(str)
    End Function

    Public Shared Function GetEspecialidades() As DataTable

        Dim strSQL As String = "SELECT E.nombre FROM Especialidad E"
        Return BDHelper2.ConsultaSQL(strSQL)
    End Function

    Public Shared Function validarDatos(ByVal params As Object()) As Boolean
        For i = 0 To params.Length - 1


            If params(i.ToString) = vbNullString Then
                MsgBox("Faltan completar datos.")
                Return False
            End If

        Next
        Return True

    End Function

    Public Shared Function validarCombos(ByVal index As Object()) As Boolean

        For i = 0 To index.Length - 1
            If index(i) = -1 Then
                MsgBox("Faltan completar datos.")
                Return False
            End If

        Next
        Return True

    End Function

    Public Shared Function GetHistoriasClinicas(ByVal dni As Integer) As DataTable
        Dim str As String = "SELECT HC.fecha, HC.idPrestacion, P.nombre AS nombrePrestacion, HC.idUbicacion, U.descripcion, HC.idTipo, TD.nombre AS nombreTipo, HC.observaciones FROM HistoriaClinica HC JOIN Prestaciones P ON (HC.idPrestacion = P.idPrestacion) JOIN Ubicacion U ON (HC.idUbicacion = U.idUbicacion)JOIN TipoDiente TD ON (HC.idTipo = TD.idTipo) WHERE HC.dniPaciente = " & dni & "ORDER BY HC.fecha DESC"

        Return BDHelper2.ConsultaSQL(str)
    End Function

    Public Shared Function GetEnfermedadesDePaciente(ByVal dni As Integer) As DataTable
        Dim str As String = "SELECT EPP.idEnfermedad, E.nombre, EPP.descripcion FROM EnfermedadesXPaciente EPP JOIN Enfermedades E ON EPP.idEnfermedad = E.idEnfermedades WHERE dniPaciente = " & dni

        Return BDHelper2.ConsultaSQL(str)
    End Function

    Public Shared Function GetAlergiasDePaciente(ByVal dni As Integer) As DataTable
        Dim str As String = "SELECT APP.idAlergia, A.nombre, APP.descripcion FROM AlergiasXPaciente APP JOIN Alergias A ON APP.idAlergia = A.idAlergia WHERE dniPaciente = " & dni

        Return BDHelper2.ConsultaSQL(str)
    End Function


    Public Shared Function GetAlergias() As DataTable
        Dim strSQL As String = "SELECT * FROM Alergias"
        Return BDHelper2.ConsultaSQL(strSQL)
    End Function


    Public Shared Sub agregarAlergiaAPaciente(ByVal str As String)
        BDHelper2.EjecutarSQL(str)
    End Sub

    Public Shared Function GetEnfermedades() As DataTable
        Dim strSQL As String = "SELECT * FROM Enfermedades"
        Return BDHelper2.ConsultaSQL(strSQL)
    End Function

    Public Shared Function GetUbicaciones() As DataTable
        Dim strSQL As String = "SELECT * FROM Ubicacion"
        Return BDHelper2.ConsultaSQL(strSQL)
    End Function

    Public Shared Function GetTipos() As DataTable
        Dim strSQL As String = "SELECT * FROM TipoDiente"
        Return BDHelper2.ConsultaSQL(strSQL)
    End Function

    Public Shared Sub agregarHCAPaciente(ByVal str As String)
        BDHelper2.EjecutarSQL(str)
    End Sub

    Public Shared Function validarMonto(ByVal Prestacion As String, ByVal monto As Integer) As Boolean
        Dim strSQL As String = "SELECT precio FROM Prestaciones WHERE nombre = '" & Prestacion & "'"
        Dim tabla As Data.DataTable = BDHelper2.ConsultaSQL(strSQL)
        Dim precio As Integer = tabla.Rows(0).Item("precio")
        If monto > precio Then
            MsgBox("ERROR: El monto ingresado es mayor al precio de la prestación (" & precio & ").")
            Return False
        End If
        Return True
    End Function

    Public Shared Function validarFechaNac(ByVal fecha As DateTime) As Boolean
        Dim fechaMin As New DateTime(1867, 1, 1)
        Dim fechaMax As DateTime = DateTime.Now
        If (fecha < fechaMin) OrElse (fecha > fechaMax) Then
            MsgBox("Fecha de nacimiento errónea")
            Return False
        End If
        Return True
    End Function

    Public Shared Function validarQueNoEsteEn(ByVal elemento As String, ByVal table As Data.DataTable) As Boolean
        For i = 0 To table.Rows.Count - 1
            Dim name As String = table.Rows(i).Item("nombre")
            If elemento = name Then
                MsgBox(elemento & " ya existe en la base de datos.")
                Return False
            End If
        Next
        Return True
    End Function

    Public Shared Function GetTurnos(ByVal odontologo As Integer, ByVal fecha As Date) As IList(Of Turno)
        Dim str As String = "SELECT T.*, E.nombre AS Estado,(P.apellido + ' ' + p.nombre) AS Paciente, PR.nombre AS Prestacion "
        str += "FROM Turno T JOIN EstadoTurnos E ON (T.idEstado = E.idEstado) JOIN Pacientes P ON (P.dniPaciente = T.idPaciente) JOIN Prestaciones PR ON (PR.idPrestacion = T.idPrestacion) "
        str += "WHERE (T.fecha = CONVERT(DATE,'" & fecha & "',103)) AND T.legajoOdontologo = " & odontologo
        Dim lst As New List(Of Turno)
        For Each row As DataRow In ConsultaSQL(str).Rows
            lst.Add(mapTurno(row))
        Next
        Return lst
    End Function

    Public Shared Function mapTurno(ByVal row As DataRow) As Turno

        Dim oTurno As New Turno

        oTurno.legajoOdontologo = row.Item("legajoOdontologo").ToString
        oTurno.idPaciente = row.Item("idPaciente").ToString
        oTurno.hora = row.Item("hora").ToString
        oTurno.idPrestacion = row.Item("idPrestacion").ToString
        oTurno.idEstado = row.Item("idEstado").ToString
        oTurno.descripcion = row.Item("descripcion").ToString
        oTurno.estado = row.Item("Estado").ToString
        oTurno.paciente = row.Item("Paciente").ToString
        oTurno.prestacion = row.Item("Prestacion").ToString

        Return oTurno
    End Function

    Public Shared Function cargarComboOdontologos() As Data.DataTable
        Dim str As String = "SELECT legajo, apellido + ' ' + nombre AS Odontologo FROM Odontologos"
        Return ConsultaSQL(str)
    End Function

    Public Shared Function getEstadosTurno() As Data.DataTable
        Dim str As String = "SELECT * FROM EstadoTurnos WHERE idEstado != 1"
        Return ConsultaSQL(str)
    End Function

    Public Shared Sub eliminarTurnos(ByVal str As String)
        BDHelper2.EjecutarSQL(str)
    End Sub

    Public Shared Function getPrecioPrestacion(idPrestacion) As Data.DataTable
        Dim str As String = "select precio from prestaciones where idPrestacion = " & idPrestacion
        Return BDHelper2.ConsultaSQL(str)
    End Function

    Public Shared Function calcularMontoFinalPrestacion(precioPrestacion, idPrestacion, idOS, idPlan) As Integer
        Dim str As String = "select montoCubierto from PrestacionesPorPlan where idObraSocial = " & idOS & " and idPlan = " & idPlan & " and idPrestacion = " & idPrestacion
        If ConsultaSQL(str).Rows.Count > 0 Then
            Dim montoCubierto As Integer = ConsultaSQL(str).Rows(0).Item("montoCubierto").ToString
            Return precioPrestacion - montoCubierto
        Else : Return precioPrestacion
        End If
    End Function

    Public Shared Sub agregarTurnos(ByVal str As String)
        BDHelper2.EjecutarSQL(str)
    End Sub

    Public Shared Sub cambiarEstadoTurnos(ByVal str As String)
        BDHelper2.EjecutarSQL(str)
    End Sub

    Public Shared Function reportarPacientes(ByVal str As String) As Data.DataTable
        Return ConsultaSQL(str)
    End Function

    Public Shared Function reportarOdontologos(ByVal str As String) As Data.DataTable
        Return ConsultaSQL(str)
    End Function

    Public Shared Function GetMedicamentos() As DataTable
        Dim strSQL As String = "SELECT * FROM Medicamentos"
        Return BDHelper2.ConsultaSQL(strSQL)
    End Function

    Public Shared Sub agregarMedicamento(ByVal str As String)
        BDHelper2.EjecutarSQL(str)
    End Sub

    Public Shared Function GetRecetasDePaciente(ByVal dni As Integer) As DataTable
        Dim str As String = "SELECT R.fecha, (O.apellido + ' ' + O.nombre) AS 'Nombre_Completo', R.legajoOdontologo, (M.droga + ' - ' + M.laboratorio) AS 'Nombre_Med', R.idMedicamento, R.observaciones FROM Receta R JOIN Odontologos O ON (R.legajoOdontologo = O.legajo) JOIN Medicamentos M ON (R.idMedicamento = M.idMedicamento) WHERE R.dniPaciente = " & dni

        Return BDHelper2.ConsultaSQL(str)
    End Function

    Public Shared Function GetTurnosNoFacturados(ByVal dni As Integer) As DataTable
        Dim str As String = "SELECT T.fecha, T.hora, T.idPrestacion, PR.nombre AS 'Prestacion', O.legajo, O.nombre + ' ' + O.apellido AS 'Odontologo', T.costo, OXP.idPlan, OXP.idObraSocial "
        str += "FROM Turno T JOIN Pacientes P ON (T.idPaciente = P.dniPaciente) JOIN Prestaciones PR ON (PR.idPrestacion = T.idPrestacion) JOIN Odontologos O ON (O.legajo = T.legajoOdontologo) JOIN ObraSocialXPaciente OXP ON (OXP.dniPaciente = p.dniPaciente) "
        str += "WHERE T.idEstado = 4 AND T.facturado = 'F' AND T.idPaciente = " & dni
        Return BDHelper2.ConsultaSQL(str)
    End Function

    Public Shared Function BuscarNroFactura() As Integer
        Dim str As String = "SELECT * FROM Factura"
        Dim tabla As Data.DataTable = BDHelper2.ConsultaSQL(str)
        Return tabla.Rows.Count + 1
    End Function

    Public Shared Sub crearFactura(ByVal str As String)
        BDHelper2.EjecutarSQL(str)
    End Sub
End Class

