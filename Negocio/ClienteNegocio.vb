Imports System.Data.SqlClient
Imports Dominio
Imports Negocio.Negocio
Imports System.Text
Imports System.Globalization
Public Class ClienteNegocio
    Public Function listar() As List(Of Cliente)
        Dim lista As New List(Of Cliente)
        Dim acceso As New AccesoDatos()
        Try
            acceso.SetearConsulta("SELECT ID, Cliente, Telefono, Correo FROM clientes")
            acceso.EjecutarLectura()

            While acceso.LectorDatos.Read()
                Dim aux As New Cliente()
                aux.Id = acceso.LectorDatos("ID")
                aux.NombreCliente = acceso.LectorDatos("Cliente")
                aux.Telefono = acceso.LectorDatos("Telefono").ToString()
                aux.Correo = acceso.LectorDatos("Correo").ToString()
                lista.Add(aux)
            End While


            Return lista

        Catch ex As Exception
            Throw ex
        Finally
            acceso.CerrarConexion()
        End Try
    End Function
    Public Sub eliminar(id As Integer)
        Dim acceso As New AccesoDatos()
        Try
            acceso.SetearConsulta("DELETE FROM clientes WHERE Id = @id")
            acceso.SetearParametro("@id", id)
            acceso.EjecutarAccion()
        Catch ex As Exception
            Throw ex
        Finally
            acceso.CerrarConexion()
        End Try
    End Sub
    Public Sub agregar(cli As Cliente)
        Dim acceso As New AccesoDatos()
        Try
            acceso.SetearConsulta("INSERT INTO clientes (Cliente, Telefono, Correo) VALUES (@Cliente, @telefono, @correo)")
            acceso.SetearParametro("@Cliente", cli.NombreCliente)
            acceso.SetearParametro("@Telefono", cli.Telefono)
            acceso.SetearParametro("@correo", cli.Correo)
            acceso.EjecutarAccion()
        Catch ex As Exception
            Throw ex
        Finally
            acceso.CerrarConexion()
        End Try
    End Sub
    Public Sub modificar(cli As Cliente)
        Dim datos As New AccesoDatos()
        Try
            datos.SetearConsulta("UPDATE Clientes SET cliente = @cliente, telefono = @telefono, correo = @correo WHERE id = @id")
            datos.SetearParametro("@id", cli.Id)
            datos.SetearParametro("@cliente", cli.NombreCliente)
            datos.SetearParametro("@telefono", cli.Telefono)
            datos.SetearParametro("@correo", cli.Correo)

            datos.EjecutarAccion()
        Catch ex As Exception
            Throw New Exception("Error al modificar el cliente: " & ex.Message)
        Finally
            datos.CerrarConexion()
        End Try
    End Sub

    'Public Function Filtrar(campo As String, criterio As String, filtro As String) As List(Of Cliente)
    '    Dim lista As New List(Of Cliente)
    '    Dim datos As New AccesoDatos()

    '    Try
    '        Dim consulta As String = "SELECT ID, cliente, telefono, correo FROM clientes WHERE "

    '        If campo = "cliente" Then
    '            Select Case criterio
    '                Case "Comienza con"
    '                    consulta += "cliente LIKE '" & filtro & "%'"
    '                Case "Termina con"
    '                    consulta += "cliente LIKE '%" & filtro & "'"
    '                Case "Contiene"
    '                    consulta += "cliente LIKE '%" & filtro & "%'"
    '            End Select
    '        ElseIf campo = "correo" Then
    '            Select Case criterio
    '                Case "Comienza con"
    '                    consulta += "correo LIKE '" & filtro & "%'"
    '                Case "Termina con"
    '                    consulta += "correo LIKE '%" & filtro & "'"
    '                Case "Contiene"
    '                    consulta += "correo LIKE '%" & filtro & "%'"
    '            End Select
    '        ElseIf campo = "telefono" Then
    '            Select Case criterio
    '                Case "Comienza con"
    '                    consulta += "telefono LIKE '" & filtro & "%'"
    '                Case "Termina con"
    '                    consulta += "telefono LIKE '%" & filtro & "'"
    '                Case "Contiene"
    '                    consulta += "telefono LIKE '%" & filtro & "%'"
    '            End Select
    '        End If

    '        datos.SetearConsulta(consulta)
    '        datos.EjecutarLectura()

    '        While datos.LectorDatos.Read()
    '            Dim p As New Cliente()
    '            p.Id = datos.LectorDatos("ID")
    '            p.NombreCliente = datos.LectorDatos("cliente")
    '            p.Telefono = Convert.ToDecimal(datos.LectorDatos("telefono"))
    '            p.Correo = datos.LectorDatos("correo")
    '            lista.Add(p)
    '        End While

    '        Return lista
    '    Catch ex As Exception
    '        Throw
    '    Finally
    '        datos.CerrarConexion()
    '    End Try
    'End Function
    'Public Function Filtrar(campo As String, criterio As String, filtro As String) As List(Of Cliente)
    '    Dim lista As New List(Of Cliente)
    '    Dim datos As New AccesoDatos()

    '    Try
    '        Dim consulta As String = "SELECT ID, cliente, telefono, correo FROM clientes WHERE "
    '        Dim valorParametro As Object = Nothing

    '        Select Case campo.ToLower()
    '            Case "cliente", "correo"
    '                Dim columna As String = campo.ToLower()

    '                Select Case criterio.ToLower()
    '                    Case "comienza con"
    '                        valorParametro = filtro & "%"
    '                    Case "termina con"
    '                        valorParametro = "%" & filtro
    '                    Case "contiene"
    '                        valorParametro = "%" & filtro & "%"
    '                    Case Else
    '                        Throw New Exception("Criterio inválido para campo texto.")
    '                End Select

    '                consulta += columna & " LIKE @filtro"

    '            Case "telefono"
    '                ' Asumo que telefono es numérico, filtramos con operadores
    '                Dim filtroNum As Decimal
    '                If Not Decimal.TryParse(filtro, filtroNum) Then
    '                    Throw New Exception("El filtro para teléfono debe ser numérico.")
    '                End If

    '                Select Case criterio.ToLower()
    '                    Case "mayor a"
    '                        consulta += "telefono > @filtro"
    '                    Case "menor a"
    '                        consulta += "telefono < @filtro"
    '                    Case "igual a"
    '                        consulta += "telefono = @filtro"
    '                    Case Else
    '                        Throw New Exception("Criterio inválido para teléfono.")
    '                End Select

    '                valorParametro = filtroNum

    '            Case Else
    '                Throw New Exception("Campo inválido para filtrar.")
    '        End Select

    '        datos.SetearConsulta(consulta)
    '        datos.SetearParametro("@filtro", valorParametro)
    '        datos.EjecutarLectura()

    '        While datos.LectorDatos.Read()
    '            Dim p As New Cliente()
    '            p.Id = datos.LectorDatos("ID")
    '            p.NombreCliente = datos.LectorDatos("cliente").ToString()
    '            p.Telefono = datos.LectorDatos("telefono").ToString()
    '            p.Correo = datos.LectorDatos("correo").ToString()
    '            lista.Add(p)
    '        End While

    '        Return lista
    '    Catch ex As Exception
    '        Throw
    '    Finally
    '        datos.CerrarConexion()
    '    End Try
    'End Function
    Private Function GetOperadorNumerico(criterio As String) As String
        Select Case criterio
            Case "mayor a" : Return ">"
            Case "menor a" : Return "<"
            Case "igual a" : Return "="
            Case Else : Throw New Exception("Operador numérico no válido.")
        End Select
    End Function
    Public Function Filtrar(campo As String, criterio As String, filtro As String) As List(Of Cliente)
        Dim lista As New List(Of Cliente)
        Dim datos As New AccesoDatos()

        Try
            Dim consulta As String = "SELECT ID, cliente, telefono, correo FROM clientes WHERE "
            Dim valorParametro As Object = Nothing

            Select Case campo.ToLower()
                Case "cliente", "correo"
                    ' Aplica COLLATE para ignorar tildes y mayúsculas
                    Dim columnaCollate As String = campo & " COLLATE Latin1_General_CI_AI"

                    Select Case criterio.ToLower()
                        Case "comienza con"
                            valorParametro = filtro & "%"
                        Case "termina con"
                            valorParametro = "%" & filtro
                        Case "contiene"
                            valorParametro = "%" & filtro & "%"
                        Case Else
                            Throw New Exception("Criterio inválido para texto.")
                    End Select

                    consulta += columnaCollate & " LIKE @filtro"

                Case "telefono"
                    Select Case criterio.ToLower()
                        Case "mayor a", "menor a", "igual a"
                            consulta += "telefono " & GetOperadorNumerico(criterio.ToLower()) & " @filtro"
                            valorParametro = Convert.ToDecimal(filtro)

                        Case "comienza con"
                            consulta += "CAST(telefono AS VARCHAR) COLLATE Latin1_General_CI_AI LIKE @filtro"
                            valorParametro = filtro & "%"

                        Case "termina con"
                            consulta += "CAST(telefono AS VARCHAR) COLLATE Latin1_General_CI_AI LIKE @filtro"
                            valorParametro = "%" & filtro

                        Case "contiene"
                            consulta += "CAST(telefono AS VARCHAR) COLLATE Latin1_General_CI_AI LIKE @filtro"
                            valorParametro = "%" & filtro & "%"

                        Case Else
                            Throw New Exception("Criterio inválido para teléfono.")
                    End Select


                    'valorParametro = filtroNum

                Case Else
                    Throw New Exception("Campo inválido para filtrar.")
            End Select

            datos.SetearConsulta(consulta)
            datos.SetearParametro("@filtro", valorParametro)
            datos.EjecutarLectura()

            While datos.LectorDatos.Read()
                Dim p As New Cliente()
                p.Id = datos.LectorDatos("ID")
                p.NombreCliente = datos.LectorDatos("cliente").ToString()
                p.Telefono = datos.LectorDatos("telefono").ToString()
                p.Correo = datos.LectorDatos("correo").ToString()
                lista.Add(p)
            End While

            Return lista
        Catch ex As Exception
            Throw
        Finally
            datos.CerrarConexion()
        End Try
    End Function




End Class
