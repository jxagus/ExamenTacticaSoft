Imports System.Data.SqlClient
Imports Dominio
Imports Negocio.Negocio

Public Class VentaNegocio
    Private acceso As New AccesoDatos()

    Public Function InsertarVenta(idCliente As Integer, fecha As DateTime, total As Decimal) As Integer
        Try
            acceso.SetearConsulta("INSERT INTO ventas (IDCliente, Fecha, Total) VALUES (@idCliente, @fecha, @total); SELECT SCOPE_IDENTITY();")
            acceso.SetearParametro("@idCliente", idCliente)
            acceso.SetearParametro("@fecha", fecha)
            acceso.SetearParametro("@total", total)
            acceso.EjecutarLectura()

            If acceso.LectorDatos.Read() Then
                Return Convert.ToInt32(acceso.LectorDatos(0))
            Else
                Throw New Exception("No se pudo obtener el ID de la venta insertada.")
            End If
        Finally
            acceso.CerrarConexion()
        End Try
    End Function

    Public Sub InsertarItemVenta(idVenta As Integer, idProducto As Integer, precioUnitario As Decimal, cantidad As Integer, precioTotal As Decimal)
        Dim acceso As New AccesoDatos()
        Try
            acceso.SetearConsulta("INSERT INTO ventasitems (IDVenta, IDProducto, PrecioUnitario, Cantidad, PrecioTotal) 
                               VALUES (@idVenta, @idProducto, @precioUnitario, @cantidad, @precioTotal)")
            acceso.comando.Parameters.Clear()
            acceso.SetearParametro("@idVenta", idVenta)
            acceso.SetearParametro("@idProducto", idProducto)
            acceso.SetearParametro("@precioUnitario", precioUnitario)
            acceso.SetearParametro("@cantidad", cantidad)
            acceso.SetearParametro("@precioTotal", precioTotal)

            acceso.EjecutarAccion()
        Catch ex As Exception
            Throw ex
        Finally
            acceso.CerrarConexion()
        End Try
    End Sub
    Public Function ObtenerItemsDeVenta(idVenta As Integer) As List(Of ItemVenta)
        Dim lista As New List(Of ItemVenta)
        Dim datos As New AccesoDatos()

        Try
            Dim consulta As String = "SELECT p.Nombre, vi.PrecioUnitario, vi.Cantidad, vi.PrecioTotal 
                                  FROM ventasitems vi
                                  INNER JOIN productos p ON p.ID = vi.IDProducto
                                  WHERE vi.IDVenta = @idVenta"
            datos.SetearConsulta(consulta)
            datos.SetearParametro("@idVenta", idVenta)
            datos.EjecutarLectura()

            While datos.LectorDatos.Read()
                Dim item As New ItemVenta()
                item.NombreProducto = datos.LectorDatos("Nombre").ToString()
                item.PrecioUnitario = Convert.ToDecimal(datos.LectorDatos("PrecioUnitario"))
                item.Cantidad = Convert.ToDecimal(datos.LectorDatos("Cantidad"))
                item.PrecioTotal = Convert.ToDecimal(datos.LectorDatos("PrecioTotal"))
                lista.Add(item)
            End While

            Return lista

        Catch ex As Exception
            Throw ex
        Finally
            datos.CerrarConexion()
        End Try
    End Function
    Public Function ObtenerVentasPorCliente(idCliente As Integer) As List(Of Venta)
        Dim lista As New List(Of Venta)
        Dim datos As New AccesoDatos()

        Try
            datos.SetearConsulta("SELECT ID, Fecha, Total FROM ventas WHERE IDCliente = @idCliente")
            datos.SetearParametro("@idCliente", idCliente)
            datos.EjecutarLectura()

            While datos.LectorDatos.Read()
                Dim venta As New Venta()
                venta.Id = Convert.ToInt32(datos.LectorDatos("ID"))
                venta.Fecha = Convert.ToDateTime(datos.LectorDatos("Fecha"))
                venta.Total = Convert.ToDecimal(datos.LectorDatos("Total"))
                lista.Add(venta)
            End While

            Return lista

        Catch ex As Exception
            Throw ex
        Finally
            datos.CerrarConexion()
        End Try
    End Function

End Class
