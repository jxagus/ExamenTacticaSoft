Public Class frmMenu
    Private currentBtn As Button = Nothing 'Para los botones activos
    Private currentChildForm As Form = Nothing ' Para el formulario hijo activo
    Private Sub ActivarBoton(btn As Button)
        If btn IsNot Nothing Then
            'Si hay un botón activo anterior, lo desactivo
            DesactivarBoton()

            'Estilo de boton activo
            btn.ForeColor = Color.RoyalBlue
            btn.Font = New Font(btn.Font.FontFamily, btn.Font.Size + 2, FontStyle.Bold)

            currentBtn = btn
        End If
    End Sub

    Private Sub DesactivarBoton()
        If currentBtn IsNot Nothing Then
            'Volver a color y tamaño original
            currentBtn.ForeColor = Color.Black
            currentBtn.Font = New Font(currentBtn.Font.FontFamily, 9.75F, FontStyle.Regular)
            currentBtn = Nothing
        End If
    End Sub
    Private Sub ActualizarTitulo()
        If currentBtn IsNot Nothing Then
            Select Case currentBtn.Name
                Case "btnClientes"
                    lblTitulo.Text = "Clientes"
                Case "btnProductos"
                    lblTitulo.Text = "Productos"
                Case "btnVentas"
                    lblTitulo.Text = "Ventas"
                Case "btnSalir"
                    lblTitulo.Text = "Salir"
                Case Else
                    lblTitulo.Text = "Gestión de Productos y Clientes"
            End Select
        Else
            lblTitulo.Text = "Gestión de Productos y Clientes"
        End If
    End Sub

    Private Sub AbrirForm(childForm As Form)
        If currentChildForm IsNot Nothing Then
            ' Cerrar el formulario hijo actual si existe
            currentChildForm.Close()
        End If

        currentChildForm = childForm
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        PanelContenedor.Controls.Add(childForm) ' Cambiá por el nombre real de tu panel
        PanelContenedor.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
    End Sub


    Private Sub btnClientes_Click(sender As Object, e As EventArgs) Handles btnClientes.Click
        ActivarBoton(CType(sender, Button))
        ActualizarTitulo()
        AbrirForm(New frmClientes())
    End Sub

    Private Sub btnProductos_Click(sender As Object, e As EventArgs) Handles btnProductos.Click
        ActivarBoton(CType(sender, Button))
        ActualizarTitulo()
        AbrirForm(New frmProductos())

    End Sub

    Private Sub btnVentas_Click(sender As Object, e As EventArgs) Handles btnVentas.Click
        ActivarBoton(CType(sender, Button))
        ActualizarTitulo()
        AbrirForm(New frmVentas())

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        ActivarBoton(CType(sender, Button))
        DesactivarBoton()
        AbrirForm(New frmSalir())


    End Sub

    Private Sub PanelTitulo_Paint(sender As Object, e As PaintEventArgs) Handles PanelTitulo.Paint

    End Sub


End Class