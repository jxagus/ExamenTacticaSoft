Imports System.Data.SqlClient
Imports Dominio
Imports Negocio.Negocio

Public Class ProductoNegocio
    'LISTAR
    Public Function listar() As List(Of Producto)
        Dim lista As New List(Of Producto)
        Dim acceso As New AccesoDatos()

        Try
            acceso.SetearConsulta("SELECT ID, Nombre, Precio, Categoria FROM productos")
            acceso.EjecutarLectura()

            While acceso.lector.Read()
                Dim aux As New Producto()
                aux.Id = acceso.lector("ID")
                aux.Nombre = acceso.lector("Nombre").ToString()
                aux.Precio = Convert.ToDecimal(acceso.lector("Precio"))
                aux.Categoria = acceso.lector("Categoria").ToString()

                lista.Add(aux)
            End While

            Return lista

        Catch ex As Exception
            Throw ex
        Finally
            acceso.CerrarConexion()
        End Try
    End Function
    'AGREGAR
    Public Sub agregar(prod As Producto)
        Dim acceso As New AccesoDatos()

        Try
            acceso.SetearConsulta("INSERT INTO productos (Nombre, Precio, Categoria) VALUES (@nombre, @precio, @categoria)")
            acceso.SetearParametro("@nombre", prod.Nombre)
            acceso.SetearParametro("@precio", prod.Precio)
            acceso.SetearParametro("@categoria", prod.Categoria)
            acceso.EjecutarAccion()

        Catch ex As Exception
            Throw ex
        Finally
            acceso.CerrarConexion()
        End Try
    End Sub
    'MODIFICAR
    Public Sub modificar(prod As Producto)
        Dim acceso As New AccesoDatos()

        Try
            acceso.SetearConsulta("UPDATE productos SET Nombre = @nombre, Precio = @precio, Categoria = @categoria WHERE ID = @id")
            acceso.SetearParametro("@id", prod.Id)
            acceso.SetearParametro("@nombre", prod.Nombre)
            acceso.SetearParametro("@precio", prod.Precio)
            acceso.SetearParametro("@categoria", prod.Categoria)
            acceso.EjecutarAccion()

        Catch ex As Exception
            Throw ex
        Finally
            acceso.CerrarConexion()
        End Try
    End Sub
    'ELIMINAR
    Public Sub eliminar(id As Integer)
        Dim acceso As New AccesoDatos()

        Try
            acceso.SetearConsulta("DELETE FROM productos WHERE Id = @id")
            acceso.SetearParametro("@id", id)
            acceso.EjecutarAccion()
        Catch ex As Exception
            Throw ex
        Finally
            acceso.CerrarConexion()
        End Try
    End Sub

    'FILTRAR
    Public Function Filtrar(campo As String, criterio As String, filtro As String) As List(Of Producto)
        Dim lista As New List(Of Producto)
        Dim datos As New AccesoDatos()

        Try
            Dim consulta As String = "SELECT ID, Nombre, Precio, Categoria FROM productos WHERE "

            If campo = "Precio" Then
                Select Case criterio
                    Case "Mayor a"
                        consulta += "Precio > " & filtro
                    Case "Menor a"
                        consulta += "Precio < " & filtro
                    Case "Igual a"
                        consulta += "Precio = " & filtro
                End Select
            ElseIf campo = "Nombre" Then
                Select Case criterio
                    Case "Comienza con"
                        consulta += "Nombre LIKE '" & filtro & "%'"
                    Case "Termina con"
                        consulta += "Nombre LIKE '%" & filtro & "'"
                    Case "Contiene"
                        consulta += "Nombre LIKE '%" & filtro & "%'"
                End Select
            ElseIf campo = "Categoría" Then
                Select Case criterio
                    Case "Comienza con"
                        consulta += "Categoria LIKE '" & filtro & "%'"
                    Case "Termina con"
                        consulta += "Categoria LIKE '%" & filtro & "'"
                    Case "Contiene"
                        consulta += "Categoria LIKE '%" & filtro & "%'"
                End Select
            End If

            datos.SetearConsulta(consulta)
            datos.EjecutarLectura()

            While datos.LectorDatos.Read()
                Dim p As New Producto()
                p.Id = datos.LectorDatos("ID")
                p.Nombre = datos.LectorDatos("Nombre")
                p.Precio = Convert.ToDecimal(datos.LectorDatos("Precio"))
                p.Categoria = datos.LectorDatos("Categoria").ToString()
                lista.Add(p)
            End While

            Return lista
        Catch ex As Exception
            Throw
        Finally
            datos.CerrarConexion()
        End Try
    End Function
    'FILTRO FAST
    Public Function FiltrarPorNombreOCategoriaOPrecio(filtro As String) As List(Of Producto)
        Dim lista As New List(Of Producto)
        Dim datos As New AccesoDatos()

        Try
            Dim consulta As String = "SELECT ID, Nombre, Precio, Categoria FROM productos " &
                                 "WHERE Nombre LIKE @filtro " &
                                 "OR Categoria LIKE @filtro " &
                                 "OR CAST(Precio AS VARCHAR) LIKE @filtro"

            datos.SetearConsulta(consulta)
            datos.SetearParametro("@filtro", "%" & filtro & "%")
            datos.EjecutarLectura()

            While datos.LectorDatos.Read()
                Dim p As New Producto()
                p.Id = datos.LectorDatos("ID")
                p.Nombre = datos.LectorDatos("Nombre").ToString()
                p.Precio = Convert.ToDecimal(datos.LectorDatos("Precio"))
                p.Categoria = datos.LectorDatos("Categoria").ToString()
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