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
End Class
