Imports Negocio
Imports Dominio

Public Class frmClientes
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles lblClientes.Click

    End Sub
    Private Sub CargarClientes()
        Dim lista As New ClienteNegocio()
        dgvClientes.DataSource = lista.listar()
    End Sub
    Private Sub frmClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim negocio As New ClienteNegocio()
        Dim listaClientes As List(Of Cliente) = negocio.listar()

        dgvClientes.AutoGenerateColumns = True 'hola
        dgvClientes.DataSource = listaClientes
    End Sub

    Private Sub dgvClientes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvClientes.CellContentClick

    End Sub
End Class