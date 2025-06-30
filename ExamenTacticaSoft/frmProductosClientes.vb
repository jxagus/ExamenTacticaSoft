Public Class frmProductosClientes
    Private currentBtn As Button = Nothing

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblFiltroRapido.Click

    End Sub
    Private Sub ActivarBoton(btn As Button)
        If btn IsNot Nothing Then
            ' Si hay un botón activo anterior, lo desactivo
            DesactivarBoton()

            ' Estilo de botón activo
            btn.ForeColor = Color.Crimson
            btn.Font = New Font(btn.Font.FontFamily, btn.Font.Size + 2, FontStyle.Bold)

            currentBtn = btn
        End If
    End Sub

    Private Sub DesactivarBoton()
        If currentBtn IsNot Nothing Then
            ' Volver a color y tamaño original
            currentBtn.ForeColor = Color.Black
            currentBtn.Font = New Font(currentBtn.Font.FontFamily, 9.75F, FontStyle.Regular)
            currentBtn = Nothing
        End If
    End Sub



    Private Sub btnClientes_Click(sender As Object, e As EventArgs) Handles btnClientes.Click
        ActivarBoton(CType(sender, Button))
    End Sub

    Private Sub btnProductos_Click(sender As Object, e As EventArgs) Handles btnProductos.Click
        ActivarBoton(CType(sender, Button))

    End Sub

    Private Sub btnVentas_Click(sender As Object, e As EventArgs) Handles btnVentas.Click
        ActivarBoton(CType(sender, Button))

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        DesactivarBoton()
    End Sub
End Class