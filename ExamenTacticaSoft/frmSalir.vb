Public Class frmSalir
    Private Sub btnSi_Click(sender As Object, e As EventArgs) Handles btnSi.Click
        Dim respuesta As DialogResult
        respuesta = MessageBox.Show("¿Está seguro que desea salir?", "Confirmar salida",
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If respuesta = DialogResult.Yes Then
            Application.Exit() ' Cierra toda la aplicación
        End If
    End Sub
End Class
