Imports Dominio
Imports Negocio

Public Class frmModificarVenta

    Private idVenta As Integer
    Private ventaOriginal As Venta

    Public Sub New(venta As Venta)
        InitializeComponent()
        ventaOriginal = venta
        idVenta = venta.Id
    End Sub

    Private Sub frmModificarVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Mostrar los datos actuales
        dtpFecha.Value = ventaOriginal.Fecha
        txtTotal.Text = ventaOriginal.Total.ToString("0.00")
    End Sub

    Private Sub btnGuardarCambios_Click(sender As Object, e As EventArgs) Handles btnGuardarCambios.Click
        Dim nuevaFecha As DateTime = dtpFecha.Value
        Dim nuevoTotal As Decimal

        If Not Decimal.TryParse(txtTotal.Text, nuevoTotal) Then
            MessageBox.Show("El total ingresado no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim negocio As New VentaNegocio()
        negocio.ModificarVenta(idVenta, nuevaFecha, nuevoTotal)

        MessageBox.Show("Venta modificada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

End Class
