Imports Dominio
Imports Negocio

Public Class frmProductos
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProductos.CellClick
        If e.ColumnIndex = dgvProductos.Columns("btnModificar").Index AndAlso e.RowIndex >= 0 Then
            ' Obtenemos el producto seleccionado
            Dim productoSeleccionado As Producto = CType(dgvProductos.Rows(e.RowIndex).DataBoundItem, Producto)

            ' Aca podes abrir un formulario con los datos para modificar, o mostrarlos en cajas de texto
            MessageBox.Show("Modificar producto: " & productoSeleccionado.Nombre)
        End If
    End Sub
    Private Sub frmProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim negocio As New ProductoNegocio()
        dgvProductos.AutoGenerateColumns = True
        dgvProductos.DataSource = negocio.listar()
        'Agregar boton para modificar
        If dgvProductos.Columns("btnModificar") Is Nothing Then
            Dim btnCol As New DataGridViewButtonColumn()
            btnCol.Name = "btnModificar"
            btnCol.HeaderText = "Acción-Modificar"
            btnCol.Text = "✍️" 'Emoji cutie
            btnCol.UseColumnTextForButtonValue = True
            dgvProductos.Columns.Add(btnCol)
        End If
        'Agregar boton para eliminar
        If dgvProductos.Columns("btnEliminar") Is Nothing Then
            Dim btnCol As New DataGridViewButtonColumn()
            btnCol.Name = "btnElminar"
            btnCol.HeaderText = "Acción-Eliminar"
            btnCol.Text = "❌" 'Emoji cutie eliminador
            btnCol.UseColumnTextForButtonValue = True
            dgvProductos.Columns.Add(btnCol)
        End If
    End Sub

End Class