Imports Dominio
Imports Negocio
Public Class frmVentas
    Private totalGeneral As Decimal = 0
    Private negocioVentas As New VentaNegocio()

    Private Sub btnAgregarProducto_Click(sender As Object, e As EventArgs) Handles btnAgregarProducto.Click
        Dim productoSeleccionado As Producto = CType(cbProductos.SelectedItem, Producto)
        Dim cantidad As Integer = Integer.Parse(txtCantidad.Text)
        Dim precioUnitario As Decimal = productoSeleccionado.Precio
        Dim precioTotal As Decimal = cantidad * precioUnitario

        ' Agregás una fila a la grilla
        dgvDetalleVenta.Rows.Add(productoSeleccionado.Id, productoSeleccionado.Nombre, cantidad, precioUnitario, precioTotal)

        ' Sumás al total
        totalGeneral += precioTotal
        lblTotalGeneral.Text = "Total: $" & totalGeneral.ToString("0.00")

    End Sub

    Private Sub btnGuardarVenta_Click(sender As Object, e As EventArgs) Handles btnGuardarVenta.Click
        ' Insertar en tabla "ventas"
        Dim idCliente As Integer = CType(cbClientes.SelectedItem, Cliente).Id
        Dim fechaVenta As DateTime = DateTime.Now
        Dim totalVenta As Decimal = totalGeneral

        Dim idVenta As Integer = negocioVentas.InsertarVenta(idCliente, fechaVenta, totalVenta)

        ' Insertar los ítems en "ventasitems"
        For Each fila As DataGridViewRow In dgvDetalleVenta.Rows
            Dim idProducto As Integer = fila.Cells("IDProducto").Value
            Dim cantidad As Integer = fila.Cells("Cantidad").Value
            Dim precioUnitario As Decimal = fila.Cells("PrecioUnitario").Value
            Dim precioTotal As Decimal = fila.Cells("PrecioTotal").Value

            negocioVentas.InsertarItemVenta(idVenta, idProducto, precioUnitario, cantidad, precioTotal)
        Next

    End Sub
End Class