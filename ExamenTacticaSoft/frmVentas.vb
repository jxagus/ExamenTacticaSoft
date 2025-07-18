﻿Imports Dominio
Imports Negocio

Public Class frmVentas

    Private totalGeneral As Decimal = 0
    Private negocioVentas As New VentaNegocio()
    Private cargando As Boolean = False
    Dim ventaValida As Boolean = False


    Private Sub frmVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargando = True
        CargarClientes()
        CargarProductos()
        ConfigurarGrilla()
        cargando = False
    End Sub

    Private Sub cbClientes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbClientes.SelectedIndexChanged
        If cargando Then Return

        LimpiarFormulario()
    End Sub

    Private Sub ConfigurarGrilla()
        dgvDetalleVenta.AutoGenerateColumns = False
        dgvDetalleVenta.Columns.Clear()

        dgvDetalleVenta.Columns.Add("IDProducto", "ID Producto")
        dgvDetalleVenta.Columns.Add("NombreProducto", "Nombre")
        dgvDetalleVenta.Columns.Add("Cantidad", "Cantidad")
        dgvDetalleVenta.Columns.Add("PrecioUnitario", "Precio Unitario")
        dgvDetalleVenta.Columns.Add("PrecioTotal", "Precio Total")
    End Sub

    Private Sub btnAgregarProducto_Click(sender As Object, e As EventArgs) Handles btnAgregarProducto.Click
        If cbProductos.SelectedItem Is Nothing Then
            MessageBox.Show("Por favor, seleccioná un producto.")
            Return
        End If

        If Not Integer.TryParse(txtCantidad.Text, Nothing) OrElse Val(txtCantidad.Text) <= 0 Then
            MessageBox.Show("Ingresá una cantidad válida.")
            Return
        Else
            ventaValida = True
        End If

        Dim productoSeleccionado As Producto = CType(cbProductos.SelectedItem, Producto)
        Dim cantidad As Integer = Integer.Parse(txtCantidad.Text)
        Dim precioUnitario As Decimal = productoSeleccionado.Precio
        Dim precioTotal As Decimal = cantidad * precioUnitario

        dgvDetalleVenta.Rows.Add(productoSeleccionado.Id, productoSeleccionado.Nombre, cantidad, precioUnitario, precioTotal)

        totalGeneral += precioTotal
        If dgvDetalleVenta.Rows.Count = 0 Then
            MessageBox.Show("No hay productos en la venta.")
            Return
        End If
        lblTotalGeneral.Text = "Total: $" & totalGeneral.ToString("0.00")
        txtCantidad.Clear()
    End Sub

    Private Sub btnGuardarVenta_Click(sender As Object, e As EventArgs) Handles btnGuardarVenta.Click
        If dgvDetalleVenta.Rows.Count = 0 Then
            MessageBox.Show("No hay productos en la venta.")
            Return
        End If

        Dim idCliente As Integer = CType(cbClientes.SelectedItem, Cliente).Id
        Dim fechaVenta As DateTime = DateTime.Now
        Dim totalVenta As Decimal = totalGeneral

        Dim idVenta As Integer = negocioVentas.InsertarVenta(idCliente, fechaVenta, totalVenta)

        For Each fila As DataGridViewRow In dgvDetalleVenta.Rows
            Dim idProducto As Integer = fila.Cells("IDProducto").Value
            Dim cantidad As Integer = fila.Cells("Cantidad").Value
            Dim precioUnitario As Decimal = fila.Cells("PrecioUnitario").Value
            Dim precioTotal As Decimal = fila.Cells("PrecioTotal").Value

            negocioVentas.InsertarItemVenta(idVenta, idProducto, precioUnitario, cantidad, precioTotal)
        Next
        If ventaValida = True Then
            MessageBox.Show("¡Venta guardada con éxito!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ventaValida = False
            LimpiarFormulario()
        Else
            MessageBox.Show("Error al guardar la venta. Por favor, intente nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub CargarClientes()
        Dim clienteNeg As New ClienteNegocio()
        Dim listaClientes As List(Of Cliente) = clienteNeg.listar()

        cbClientes.DataSource = listaClientes
        cbClientes.DisplayMember = "NombreCliente"
        cbClientes.ValueMember = "Id"
    End Sub

    Private Sub CargarProductos()
        Dim productoNeg As New ProductoNegocio()
        Dim listaProductos As List(Of Producto) = productoNeg.listar()

        cbProductos.DataSource = listaProductos
        cbProductos.DisplayMember = "Nombre"
        cbProductos.ValueMember = "Id"
    End Sub

    Private Sub LimpiarFormulario()
        dgvDetalleVenta.Rows.Clear()
        totalGeneral = 0
        lblTotalGeneral.Text = "Total: $0.00"
        txtCantidad.Clear()
    End Sub

    Private Sub btnHistorial_Click(sender As Object, e As EventArgs) Handles btnHistorial.Click
        If cbClientes.SelectedItem IsNot Nothing Then
            Dim clienteSeleccionado As Cliente = CType(cbClientes.SelectedItem, Cliente)
            Dim negocioVentas As New VentaNegocio()

            If negocioVentas.TieneVentasCliente(clienteSeleccionado.Id) Then
                Dim frm As New frmHistorialVentas(clienteSeleccionado)
                frm.ShowDialog()
            Else
                MessageBox.Show("El cliente no tiene ventas registradas.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("Seleccione un cliente para ver su historial.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

End Class
