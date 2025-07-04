Imports Negocio
Imports Dominio
Imports System.Globalization
Imports System.Text


Public Class frmClientes

    Private CampoDB As New Dictionary(Of String, String) From {
    {"Nombre", "cliente"},
    {"Correo", "correo"},
    {"Telefono", "telefono"}
}

    Private Sub CargarClientes()
        Dim lista As New ClienteNegocio()
        dgvClientes.DataSource = lista.listar()

    End Sub
    Private Sub AgregarBotonesAccion()
        ' Asegurarse que los botones estén al final
        ' Primero, eliminar si ya existen para que no se repitan o se reposicionen mal
        If dgvClientes.Columns.Contains("btnModificar") Then dgvClientes.Columns.Remove("btnModificar")
        If dgvClientes.Columns.Contains("btnEliminar") Then dgvClientes.Columns.Remove("btnEliminar")

        ' Botón Modificar
        Dim btnModificar As New DataGridViewButtonColumn()
        btnModificar.Name = "btnModificar"
        btnModificar.HeaderText = "Modificar"
        btnModificar.Text = "✍️"
        btnModificar.UseColumnTextForButtonValue = True
        dgvClientes.Columns.Add(btnModificar)

        ' Botón Eliminar
        Dim btnEliminar As New DataGridViewButtonColumn()
        btnEliminar.Name = "btnEliminar"
        btnEliminar.HeaderText = "Eliminar"
        btnEliminar.Text = "❌"
        btnEliminar.UseColumnTextForButtonValue = True
        dgvClientes.Columns.Add(btnEliminar)
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
    Private Sub frmClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim negocio As New ClienteNegocio()
        Dim listaClientes As List(Of Cliente) = negocio.listar()

        dgvClientes.AutoGenerateColumns = True 'hola
        dgvClientes.DataSource = listaClientes

        dgvClientes.AutoGenerateColumns = True
        dgvClientes.DataSource = negocio.listar()
        cbCampo.Items.Clear()
        cbCampo.Items.Add("Nombre")
        cbCampo.Items.Add("Telefono")
        cbCampo.Items.Add("Correo")
        AgregarBotonesAccion()

    End Sub
    Public Function QuitarTildes(texto As String) As String
        Dim normalized As String = texto.Normalize(NormalizationForm.FormD)
        Dim sb As New StringBuilder()
        For Each c As Char In normalized
            If CharUnicodeInfo.GetUnicodeCategory(c) <> UnicodeCategory.NonSpacingMark Then
                sb.Append(c)
            End If
        Next
        Return sb.ToString()
    End Function
    Private Sub AplicarFiltro()
        Dim negocio As New ClienteNegocio()

        If txtFiltro.Text.Trim() = "" Then
            dgvClientes.DataSource = negocio.listar()
            AgregarBotonesAccion()
            Return
        End If

        If cbCampo.SelectedIndex < 0 Or cbCriterio.SelectedIndex < 0 Then
            MessageBox.Show("Completá los filtros.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Campo del ComboBox (visible) → nombre real de la base
        Dim campoSeleccionado As String = cbCampo.SelectedItem.ToString().Trim()
        If Not CampoDB.ContainsKey(campoSeleccionado) Then
            MessageBox.Show("Campo inválido seleccionado.")
            Return
        End If

        ' Normalización de nombres y tildes
        Dim campo As String = CampoDB(campoSeleccionado).ToLower()
        Dim criterio As String = QuitarTildes(cbCriterio.SelectedItem.ToString().ToLower().Trim())
        Dim filtro As String = txtFiltro.Text.Trim()

        Try
            Dim listaFiltrada As List(Of Cliente) = negocio.Filtrar(campo, criterio, filtro)
            dgvClientes.DataSource = listaFiltrada
            AgregarBotonesAccion()
        Catch ex As Exception
            MessageBox.Show("Error al filtrar: " & ex.Message)
        End Try
    End Sub

    Private Sub txtFiltro_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFiltro.KeyDown
        If e.KeyCode = Keys.Enter Then
            AplicarFiltro()
            e.SuppressKeyPress = True ' Evita el beep al presionar Enter
            AgregarBotonesAccion()

        End If
    End Sub

    Private Sub dgvClientes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvClientes.CellContentClick
        If e.RowIndex < 0 OrElse dgvClientes.Rows(e.RowIndex).IsNewRow Then Exit Sub

        Dim fila As DataGridViewRow = dgvClientes.Rows(e.RowIndex)
        If fila.DataBoundItem Is Nothing Then Exit Sub

        Dim clienteSeleccionado As Cliente = CType(fila.DataBoundItem, Cliente)

        If dgvClientes.Columns(e.ColumnIndex).Name = "btnModificar" Then
            Dim frmModif As New frmAgregarCliente()
            frmModif.ClienteParaModificar = clienteSeleccionado
            If frmModif.ShowDialog() = DialogResult.OK Then
                dgvClientes.DataSource = New ClienteNegocio().listar()
                AgregarBotonesAccion()
            End If

        ElseIf dgvClientes.Columns(e.ColumnIndex).Name = "btnEliminar" Then
            Dim confirmar As DialogResult = MessageBox.Show(
                $"¿Estás seguro que querés eliminar al cliente '{clienteSeleccionado.NombreCliente}'?",
                "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If confirmar = DialogResult.Yes Then
                Try
                    Dim negocio As New ClienteNegocio()
                    negocio.eliminar(clienteSeleccionado.Id)
                    MessageBox.Show("Cliente eliminado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    dgvClientes.DataSource = negocio.listar()
                    AgregarBotonesAccion()
                Catch ex As Exception
                    MessageBox.Show("Error al eliminar: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End If
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim frmNuevoCliente As New frmAgregarCliente()
        If frmNuevoCliente.ShowDialog() = DialogResult.OK Then
            dgvClientes.DataSource = New ClienteNegocio().listar()
            AgregarBotonesAccion()
        End If
    End Sub
End Class