Imports System.Data.SqlClient
Imports Dominio
Imports Negocio.Negocio

Public Class ProductoNegocio
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
End Class
