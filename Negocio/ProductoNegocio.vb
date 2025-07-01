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
            acceso.SetearConsulta("DELETE FROM productos WHERE ID = @id")
            acceso.SetearParametro("@id", id)
            acceso.EjecutarAccion()

        Catch ex As Exception
            Throw ex
        Finally
            acceso.CerrarConexion()
        End Try
    End Sub
End Class