Imports System.Data.SqlClient

Namespace Negocio
    Public Class AccesoDatos 'Conexion a base de datos SQL Server con Ado.NET
        Public conexion As SqlConnection
        Public comando As SqlCommand
        Public lector As SqlDataReader

        Public ReadOnly Property LectorDatos As SqlDataReader
            Get
                Return lector
            End Get
        End Property
        Public Sub New() 'Constructor: inicializa la conexion y el comando
            conexion = New SqlConnection("server=.\SQLEXPRESS; database=pruebademo; integrated security=true")
            comando = New SqlCommand()
        End Sub

        Public Sub SetearConsulta(consulta As String) 'Tipo de comando y el texto SQL a ejecutar
            comando.CommandType = CommandType.Text
            comando.CommandText = consulta
        End Sub

        Public Sub EjecutarLectura() 'Consulta que devuelve resultados
            comando.Connection = conexion
            Try
                conexion.Open()
                lector = comando.ExecuteReader()
            Catch ex As Exception
                Throw 'Manejamos el error sin capturarlo para manejarlo despues
            End Try
        End Sub

        Public Sub EjecutarAccion() 'Ejecuta una acción que no devuelve resultados (INSERT, UPDATE, DELETE)
            comando.Connection = conexion
            Try
                conexion.Open()
                comando.ExecuteNonQuery()
            Catch ex As Exception
                Throw
            End Try
        End Sub

        Public Sub SetearParametro(nombre As String, valor As Object) 'Seteo un parametro al comando SQL
            comando.Parameters.AddWithValue(nombre, valor)
        End Sub

        Public Sub CerrarConexion() 'Lector.Close()
            If lector IsNot Nothing Then
                lector.Close()
            End If
            conexion.Close()
        End Sub
    End Class
End Namespace
