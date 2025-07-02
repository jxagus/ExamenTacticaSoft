Imports Dominio
Imports Negocio
Public Class frmVentas
    Private totalGeneral As Decimal = 0
    Private negocioVentas As New VentaNegocio()
    Private cargando As Boolean = False

    Private Sub frmVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargando = True
        CargarClientes()
        CargarProductos()
        ConfigurarGrilla()
        cargando = False
    End Sub

    Private Sub cbClientes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbClientes.SelectedIndexChanged
        If cargando Then Return ' Evitar limpiar si es al iniciar

        dgvDetalleVenta.Rows.Clear()
        totalGeneral = 0
        lblTotalGeneral.Text = "Total: $0.00"
    End Sub

    Private Sub ConfigurarGrilla()
        ' Evitas columnas automáticas
        dgvDetalleVenta.AutoGenerateColumns = False
        dgvDetalleVenta.Columns.Clear()

        dgvDetalleVenta.Columns.Add("IDProducto", "ID Producto")
        dgvDetalleVenta.Columns.Add("NombreProducto", "Nombre")
        dgvDetalleVenta.Columns.Add("Cantidad", "Cantidad")
        dgvDetalleVenta.Columns.Add("PrecioUnitario", "Precio Unitario")
        dgvDetalleVenta.Columns.Add("PrecioTotal", "Precio Total")
    End Sub
    Private Sub btnAgregarProducto_Click(sender As Object, e As EventArgs) Handles btnAgregarProducto.Click
        Dim productoSeleccionado As Producto = CType(cbProductos.SelectedItem, Producto)
        Dim cantidad As Integer = Integer.Parse(txtCantidad.Text)
        Dim precioUnitario As Decimal = productoSeleccionado.Precio
        Dim precioTotal As Decimal = cantidad * precioUnitario

        ' Agregas una fila a la grilla
        dgvDetalleVenta.Rows.Add(productoSeleccionado.Id, productoSeleccionado.Nombre, cantidad, precioUnitario, precioTotal)

        ' Sumas al total
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


End Class