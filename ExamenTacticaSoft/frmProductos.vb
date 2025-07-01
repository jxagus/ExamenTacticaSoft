Imports Negocio

Public Class frmProductos
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub
    Private Sub frmProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim negocio As New ProductoNegocio()
        dgvProductos.AutoGenerateColumns = True
        dgvProductos.DataSource = negocio.listar()
    End Sub

End Class