Imports System.Data.SqlClient
Imports Dominio
Imports Negocio.Negocio

Public Class ClienteNegocio
    Public Function listar() As List(Of Cliente)
        Dim lista As New List(Of Cliente)
        Dim acceso As New AccesoDatos()
        Try
            acceso.SetearConsulta("SELECT ID, Cliente, Telefono, Correo FROM clientes")
            acceso.EjecutarLectura()

            While acceso.lector.Read()
                Dim aux As New Cliente()
                aux.Id = acceso.lector("ID")
                aux.NombreCliente = acceso.lector("Cliente")
                aux.Telefono = acceso.lector("Telefono").ToString()
                aux.Correo = acceso.lector("Correo").ToString()
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
