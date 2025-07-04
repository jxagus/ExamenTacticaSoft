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
        cbCampo.Items.Add("Nombre")
        cbCampo.Items.Add("Precio")
        cbCampo.Items.Add("Categoría")
        AgregarBotonesAccion()
    End Sub
    Private Sub AgregarBotonesAccion()
        ' Asegurarse que los botones estén al final
        ' Primero, eliminar si ya existen para que no se repitan o se reposicionen mal
        If dgvProductos.Columns.Contains("btnModificar") Then dgvProductos.Columns.Remove("btnModificar")
        If dgvProductos.Columns.Contains("btnEliminar") Then dgvProductos.Columns.Remove("btnEliminar")

        ' Botón Modificar
        Dim btnModificar As New DataGridViewButtonColumn()
        btnModificar.Name = "btnModificar"
        btnModificar.HeaderText = "Modificar"
        btnModificar.Text = "✍️"
        btnModificar.UseColumnTextForButtonValue = True
        dgvProductos.Columns.Add(btnModificar)

        ' Botón Eliminar
        Dim btnEliminar As New DataGridViewButtonColumn()
        btnEliminar.Name = "btnEliminar"
        btnEliminar.HeaderText = "Eliminar"
        btnEliminar.Text = "❌"
        btnEliminar.UseColumnTextForButtonValue = True
        dgvProductos.Columns.Add(btnEliminar)
    End Sub

    Private Sub cbCampo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCampo.SelectedIndexChanged
        cbCriterio.Items.Clear()

        Select Case cbCampo.SelectedItem.ToString()
            Case "Precio"
                cbCriterio.Items.Add("Mayor a")
                cbCriterio.Items.Add("Menor a")
                cbCriterio.Items.Add("Igual a")
            Case Else
                cbCriterio.Items.Add("Comienza con")
                cbCriterio.Items.Add("Termina con")
                cbCriterio.Items.Add("Contiene")
        End Select
    End Sub
    Private Sub AplicarFiltro()
        Dim negocio As New ProductoNegocio()

        ' Si el filtro está vacío, mostrar todo
        If txtFiltro.Text.Trim() = "" Then
            Dim listaCompleta As List(Of Producto) = negocio.listar()
            dgvProductos.DataSource = Nothing
            dgvProductos.DataSource = listaCompleta
            Return
        End If

        ' Si los combos no están seleccionados, aviso
        If cbCampo.SelectedIndex < 0 Or cbCriterio.SelectedIndex < 0 Then
            MessageBox.Show("Completá los filtros.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim campo As String = cbCampo.SelectedItem.ToString()
        Dim criterio As String = cbCriterio.SelectedItem.ToString()
        Dim filtro As String = txtFiltro.Text.Trim()

        Dim listaFiltrada As List(Of Producto) = negocio.Filtrar(campo, criterio, filtro)
        dgvProductos.DataSource = Nothing
        dgvProductos.DataSource = listaFiltrada
        AgregarBotonesAccion()

    End Sub


    Private Sub txtFiltro_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFiltro.KeyDown
        If e.KeyCode = Keys.Enter Then
            AplicarFiltro()
            e.SuppressKeyPress = True ' Evita el beep al presionar Enter
            AgregarBotonesAccion()

        End If
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim formAgregar As New frmAgregarProducto()
        If formAgregar.ShowDialog() = DialogResult.OK Then
            ' Refrescar la grilla después de agregar
            Dim negocio As New ProductoNegocio()
            dgvProductos.DataSource = negocio.listar()
            AgregarBotonesAccion()

        End If
    End Sub
    'para modificar
    Private Sub dgvProductos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProductos.CellContentClick
        If e.RowIndex < 0 OrElse dgvProductos.Rows(e.RowIndex).IsNewRow Then Exit Sub

        Dim fila As DataGridViewRow = dgvProductos.Rows(e.RowIndex)
        If fila.DataBoundItem Is Nothing Then Exit Sub

        Dim productoSeleccionado As Producto = CType(fila.DataBoundItem, Producto)

        If dgvProductos.Columns(e.ColumnIndex).Name = "btnModificar" Then
            ' Abrir formulario de modificación con datos precargados
            Dim frmModif As New frmAgregarProducto()
            frmModif.ProductoParaModificar = productoSeleccionado
            If frmModif.ShowDialog() = DialogResult.OK Then
                dgvProductos.DataSource = New ProductoNegocio().listar()
                AgregarBotonesAccion()
            End If

        ElseIf dgvProductos.Columns(e.ColumnIndex).Name = "btnEliminar" Then
            ' Confirmar y eliminar producto
            Dim confirmar As DialogResult = MessageBox.Show(
                $"¿Estás seguro que querés eliminar el producto '{productoSeleccionado.Nombre}'?",
                "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If confirmar = DialogResult.Yes Then
                Try
                    Dim negocio As New ProductoNegocio()
                    negocio.eliminar(productoSeleccionado.Id)
                    MessageBox.Show("Producto eliminado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    dgvProductos.DataSource = negocio.listar()
                    AgregarBotonesAccion()
                Catch ex As Exception
                    MessageBox.Show("Error al eliminar: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End If
    End Sub


End Class