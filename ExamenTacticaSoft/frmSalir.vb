Public Class frmSalir
    Private Sub btnSi_Click(sender As Object, e As EventArgs) Handles btnSi.Click
        ' Cerrar toda la aplicación
        Application.Exit()
    End Sub

    Private Sub btnNo_Click(sender As Object, e As EventArgs) Handles btnNo.Click
        ' Cerrar solo este formulario de salida y volver al principal
        Me.Close()
    End Sub
End Class
