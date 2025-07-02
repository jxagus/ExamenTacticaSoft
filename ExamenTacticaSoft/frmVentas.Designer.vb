<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVentas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblClientes = New System.Windows.Forms.Label()
        Me.cbClientes = New System.Windows.Forms.ComboBox()
        Me.cbProductos = New System.Windows.Forms.ComboBox()
        Me.lblClient = New System.Windows.Forms.Label()
        Me.lblProducto = New System.Windows.Forms.Label()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.lblCantidad = New System.Windows.Forms.Label()
        Me.btnAgregarProducto = New System.Windows.Forms.Button()
        Me.dgvDetalleVenta = New System.Windows.Forms.DataGridView()
        Me.lblTotalGeneral = New System.Windows.Forms.Label()
        Me.btnGuardarVenta = New System.Windows.Forms.Button()
        CType(Me.dgvDetalleVenta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblClientes
        '
        Me.lblClientes.AutoSize = True
        Me.lblClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClientes.Location = New System.Drawing.Point(328, 9)
        Me.lblClientes.Name = "lblClientes"
        Me.lblClientes.Size = New System.Drawing.Size(99, 31)
        Me.lblClientes.TabIndex = 42
        Me.lblClientes.Text = "Ventas"
        '
        'cbClientes
        '
        Me.cbClientes.FormattingEnabled = True
        Me.cbClientes.Location = New System.Drawing.Point(88, 119)
        Me.cbClientes.Name = "cbClientes"
        Me.cbClientes.Size = New System.Drawing.Size(121, 21)
        Me.cbClientes.TabIndex = 43
        '
        'cbProductos
        '
        Me.cbProductos.FormattingEnabled = True
        Me.cbProductos.Location = New System.Drawing.Point(88, 163)
        Me.cbProductos.Name = "cbProductos"
        Me.cbProductos.Size = New System.Drawing.Size(121, 21)
        Me.cbProductos.TabIndex = 44
        '
        'lblClient
        '
        Me.lblClient.AutoSize = True
        Me.lblClient.Location = New System.Drawing.Point(29, 122)
        Me.lblClient.Name = "lblClient"
        Me.lblClient.Size = New System.Drawing.Size(44, 13)
        Me.lblClient.TabIndex = 46
        Me.lblClient.Text = "Clientes"
        '
        'lblProducto
        '
        Me.lblProducto.AutoSize = True
        Me.lblProducto.Location = New System.Drawing.Point(29, 163)
        Me.lblProducto.Name = "lblProducto"
        Me.lblProducto.Size = New System.Drawing.Size(50, 13)
        Me.lblProducto.TabIndex = 47
        Me.lblProducto.Text = "Producto"
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(88, 199)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(121, 20)
        Me.txtCantidad.TabIndex = 48
        '
        'lblCantidad
        '
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.Location = New System.Drawing.Point(32, 199)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(49, 13)
        Me.lblCantidad.TabIndex = 49
        Me.lblCantidad.Text = "Cantidad"
        '
        'btnAgregarProducto
        '
        Me.btnAgregarProducto.Location = New System.Drawing.Point(88, 242)
        Me.btnAgregarProducto.Name = "btnAgregarProducto"
        Me.btnAgregarProducto.Size = New System.Drawing.Size(121, 40)
        Me.btnAgregarProducto.TabIndex = 50
        Me.btnAgregarProducto.Text = "Agregar"
        Me.btnAgregarProducto.UseVisualStyleBackColor = True
        '
        'dgvDetalleVenta
        '
        Me.dgvDetalleVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetalleVenta.Location = New System.Drawing.Point(309, 93)
        Me.dgvDetalleVenta.Name = "dgvDetalleVenta"
        Me.dgvDetalleVenta.Size = New System.Drawing.Size(416, 261)
        Me.dgvDetalleVenta.TabIndex = 51
        '
        'lblTotalGeneral
        '
        Me.lblTotalGeneral.AutoSize = True
        Me.lblTotalGeneral.Location = New System.Drawing.Point(105, 305)
        Me.lblTotalGeneral.Name = "lblTotalGeneral"
        Me.lblTotalGeneral.Size = New System.Drawing.Size(87, 13)
        Me.lblTotalGeneral.TabIndex = 52
        Me.lblTotalGeneral.Text = "Total Acumulado"
        '
        'btnGuardarVenta
        '
        Me.btnGuardarVenta.Location = New System.Drawing.Point(88, 344)
        Me.btnGuardarVenta.Name = "btnGuardarVenta"
        Me.btnGuardarVenta.Size = New System.Drawing.Size(121, 37)
        Me.btnGuardarVenta.TabIndex = 53
        Me.btnGuardarVenta.Text = "Guardar"
        Me.btnGuardarVenta.UseVisualStyleBackColor = True
        '
        'frmVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnGuardarVenta)
        Me.Controls.Add(Me.lblTotalGeneral)
        Me.Controls.Add(Me.dgvDetalleVenta)
        Me.Controls.Add(Me.btnAgregarProducto)
        Me.Controls.Add(Me.lblCantidad)
        Me.Controls.Add(Me.txtCantidad)
        Me.Controls.Add(Me.lblProducto)
        Me.Controls.Add(Me.lblClient)
        Me.Controls.Add(Me.cbProductos)
        Me.Controls.Add(Me.cbClientes)
        Me.Controls.Add(Me.lblClientes)
        Me.Name = "frmVentas"
        Me.Text = "Ventas"
        CType(Me.dgvDetalleVenta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblClientes As Label
    Friend WithEvents cbClientes As ComboBox
    Friend WithEvents cbProductos As ComboBox
    Friend WithEvents lblClient As Label
    Friend WithEvents lblProducto As Label
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents lblCantidad As Label
    Friend WithEvents btnAgregarProducto As Button
    Friend WithEvents dgvDetalleVenta As DataGridView
    Friend WithEvents lblTotalGeneral As Label
    Friend WithEvents btnGuardarVenta As Button
End Class
