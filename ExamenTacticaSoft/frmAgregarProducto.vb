Imports Dominio
Imports Negocio
Public Class frmAgregarProducto
    Public Property ProductoParaModificar As Producto

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        ' Validaciones
        Try
            If String.IsNullOrWhiteSpace(tbNombre.Text) OrElse
           String.IsNullOrWhiteSpace(tbPrecio.Text) OrElse
           String.IsNullOrWhiteSpace(tbCategoria.Text) Then

                MessageBox.Show("Por favor, completá todos los campos.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim precioDecimal As Decimal
            If Not Decimal.TryParse(tbPrecio.Text, precioDecimal) Then
                MessageBox.Show("El precio debe ser un número válido.", "Error en precio", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            ' Crear el producto
            Dim nuevoProducto As New Producto()
            nuevoProducto.Nombre = tbNombre.Text.Trim()
            nuevoProducto.Precio = precioDecimal
            nuevoProducto.Categoria = tbCategoria.Text.Trim()

            Dim negocio As New ProductoNegocio()

            If ProductoParaModificar IsNot Nothing Then
                nuevoProducto.Id = ProductoParaModificar.Id
                negocio.modificar(nuevoProducto)
                MessageBox.Show("Producto modificado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                negocio.agregar(nuevoProducto)
                MessageBox.Show("Producto agregado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            Me.DialogResult = DialogResult.OK
            Me.Close()
        Catch ex As AccessViolationException
            MessageBox.Show("Error de acceso a memoria: " & ex.Message, "Error crítico", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("Error general: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub frmAgregarProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If ProductoParaModificar IsNot Nothing Then
            tbNombre.Text = ProductoParaModificar.Nombre
            tbPrecio.Text = ProductoParaModificar.Precio.ToString()
            tbCategoria.Text = ProductoParaModificar.Categoria
            btnAgregar.Text = "Modificar"
        End If
    End Sub

End Class
