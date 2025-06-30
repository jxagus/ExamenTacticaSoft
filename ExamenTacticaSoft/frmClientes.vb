Imports Negocio
Imports Dominio

Public Class frmClientes
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles lblClientes.Click

    End Sub
    Private Sub CargarClientes()
        Dim lista As New ClienteNegocio()
        dgvClientes.DataSource = lista.listar()
    End Sub

End Class