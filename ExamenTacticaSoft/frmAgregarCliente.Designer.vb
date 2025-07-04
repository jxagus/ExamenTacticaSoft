<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAgregarCliente
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
        Me.tbCorreo = New System.Windows.Forms.TextBox()
        Me.tbTelefono = New System.Windows.Forms.TextBox()
        Me.tbNombre = New System.Windows.Forms.TextBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.lblCorreo = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'tbCorreo
        '
        Me.tbCorreo.Location = New System.Drawing.Point(127, 177)
        Me.tbCorreo.Name = "tbCorreo"
        Me.tbCorreo.Size = New System.Drawing.Size(100, 20)
        Me.tbCorreo.TabIndex = 15
        '
        'tbTelefono
        '
        Me.tbTelefono.Location = New System.Drawing.Point(127, 139)
        Me.tbTelefono.Name = "tbTelefono"
        Me.tbTelefono.Size = New System.Drawing.Size(100, 20)
        Me.tbTelefono.TabIndex = 14
        '
        'tbNombre
        '
        Me.tbNombre.Location = New System.Drawing.Point(127, 95)
        Me.tbNombre.Name = "tbNombre"
        Me.tbNombre.Size = New System.Drawing.Size(100, 20)
        Me.tbNombre.TabIndex = 13
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(115, 237)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(112, 36)
        Me.btnGuardar.TabIndex = 12
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Location = New System.Drawing.Point(69, 139)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(52, 13)
        Me.lblTelefono.TabIndex = 11
        Me.lblTelefono.Text = "Telefono:"
        '
        'lblCorreo
        '
        Me.lblCorreo.AutoSize = True
        Me.lblCorreo.Location = New System.Drawing.Point(75, 180)
        Me.lblCorreo.Name = "lblCorreo"
        Me.lblCorreo.Size = New System.Drawing.Size(41, 13)
        Me.lblCorreo.TabIndex = 10
        Me.lblCorreo.Text = "Correo:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(69, 95)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Nombre:"
        '
        'frmAgregarCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(308, 379)
        Me.Controls.Add(Me.tbCorreo)
        Me.Controls.Add(Me.tbTelefono)
        Me.Controls.Add(Me.tbNombre)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.lblTelefono)
        Me.Controls.Add(Me.lblCorreo)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmAgregarCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmAgregarCliente"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbCorreo As TextBox
    Friend WithEvents tbTelefono As TextBox
    Friend WithEvents tbNombre As TextBox
    Friend WithEvents btnGuardar As Button
    Friend WithEvents lblTelefono As Label
    Friend WithEvents lblCorreo As Label
    Friend WithEvents Label1 As Label
End Class
