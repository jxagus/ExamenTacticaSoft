Imports Dominio
Imports Negocio

Public Class frmHistorialVentas

    Private clienteActual As Cliente
    Private ventaNeg As New VentaNegocio()

    ' Constructor para pasar un cliente específico
    Public Sub New(cliente As Cliente)
        InitializeComponent()
        clienteActual = cliente
    End Sub

    Private Sub frmHistorialVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConfigurarGrilla()
        CargarHistorial()
    End Sub

    Private Sub ConfigurarGrilla()
        dgvHistorial.AutoGenerateColumns = False
        dgvHistorial.Columns.Clear()

        dgvHistorial.Columns.Add("IDVenta", "ID Venta")
        dgvHistorial.Columns.Add("Fecha", "Fecha")
        dgvHistorial.Columns.Add("Total", "Total")
    End Sub

    Private Sub CargarHistorial()
        Dim listaVentas As List(Of Venta) = ventaNeg.ObtenerVentasPorCliente(clienteActual.Id)

        dgvHistorial.Rows.Clear()

        For Each venta As Venta In listaVentas
            dgvHistorial.Rows.Add(venta.Id, venta.Fecha.ToShortDateString(), "$" & venta.Total.ToString("0.00"))
        Next
    End Sub

End Class
