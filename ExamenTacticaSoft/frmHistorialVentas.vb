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
        Dim negocio As New VentaNegocio()
        Dim listaVentas As List(Of Venta) = negocio.ObtenerVentasPorCliente(clienteActual.Id)

        dgvHistorial.Rows.Clear()

        For Each venta As Venta In listaVentas
            dgvHistorial.Rows.Add(venta.Id, venta.Fecha.ToShortDateString(), "$" & venta.Total.ToString("0.00"))
        Next
    End Sub

    Private Sub btnEliminarHistorial_Click(sender As Object, e As EventArgs) Handles btnEliminarHistorial.Click
        If dgvHistorial.CurrentRow Is Nothing Then
            MessageBox.Show("Seleccioná una venta para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim idVenta As Integer = CInt(dgvHistorial.CurrentRow.Cells("IDVenta").Value)
        Dim confirm As DialogResult = MessageBox.Show("¿Estás seguro que querés eliminar esta venta?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If confirm = DialogResult.Yes Then
            Dim negocio As New VentaNegocio()
            negocio.EliminarVenta(idVenta)
            MessageBox.Show("Venta eliminada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            CargarHistorial() ' Re-cargá el dgv
        End If
    End Sub

    Private Sub btnModificarHistorial_Click(sender As Object, e As EventArgs) Handles btnModificarHistorial.Click
        If dgvHistorial.CurrentRow Is Nothing Then
            MessageBox.Show("Seleccioná una venta para modificar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim idVenta As Integer = CInt(dgvHistorial.CurrentRow.Cells("IDVenta").Value)
        Dim fecha As Date = Date.Parse(dgvHistorial.CurrentRow.Cells("Fecha").Value.ToString())
        Dim total As Decimal = Decimal.Parse(dgvHistorial.CurrentRow.Cells("Total").Value.ToString().Replace("$", ""))

        Dim ventaSeleccionada As New Venta With {
            .Id = idVenta,
            .Fecha = fecha,
            .Total = total
        }

        Dim formModificar As New frmModificarVenta(ventaSeleccionada)
        If formModificar.ShowDialog() = DialogResult.OK Then
            CargarHistorial()
        End If
    End Sub


End Class
