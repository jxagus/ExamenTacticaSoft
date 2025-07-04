Imports Dominio
Imports Negocio

Public Class frmAgregarCliente

    Public Property ClienteParaModificar As Cliente

    Private Sub frmAgregarCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If ClienteParaModificar IsNot Nothing Then
            ' Precargar datos si es modificación
            tbNombre.Text = ClienteParaModificar.NombreCliente
            tbTelefono.Text = ClienteParaModificar.Telefono
            tbCorreo.Text = ClienteParaModificar.Correo
            btnGuardar.Text = "Modificar"
        Else
            btnGuardar.Text = "Agregar"
        End If
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            If String.IsNullOrWhiteSpace(tbNombre.Text) OrElse
               String.IsNullOrWhiteSpace(tbTelefono.Text) OrElse
               String.IsNullOrWhiteSpace(tbCorreo.Text) Then

                MessageBox.Show("Por favor, completá todos los campos.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim cliente As New Cliente()
            cliente.NombreCliente = tbNombre.Text.Trim()
            cliente.Telefono = tbTelefono.Text.Trim()
            cliente.Correo = tbCorreo.Text.Trim()

            Dim negocio As New ClienteNegocio()

            If ClienteParaModificar IsNot Nothing Then
                cliente.Id = ClienteParaModificar.Id
                negocio.modificar(cliente)
                MessageBox.Show("Cliente modificado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                negocio.agregar(cliente)
                MessageBox.Show("Cliente agregado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            Me.DialogResult = DialogResult.OK
            Me.Close()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class
