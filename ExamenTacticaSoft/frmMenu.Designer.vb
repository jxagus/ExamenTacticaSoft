<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMenu
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMenu))
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnVentas = New System.Windows.Forms.Button()
        Me.btnProductos = New System.Windows.Forms.Button()
        Me.btnClientes = New System.Windows.Forms.Button()
        Me.PanelLogo = New System.Windows.Forms.Panel()
        Me.ptbImagenLogo = New System.Windows.Forms.PictureBox()
        Me.PanelTitulo = New System.Windows.Forms.Panel()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.PanelContenedor = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PanelMenu.SuspendLayout()
        Me.PanelLogo.SuspendLayout()
        CType(Me.ptbImagenLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelTitulo.SuspendLayout()
        Me.PanelContenedor.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelMenu
        '
        Me.PanelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.PanelMenu.Controls.Add(Me.btnSalir)
        Me.PanelMenu.Controls.Add(Me.btnVentas)
        Me.PanelMenu.Controls.Add(Me.btnProductos)
        Me.PanelMenu.Controls.Add(Me.btnClientes)
        Me.PanelMenu.Controls.Add(Me.PanelLogo)
        resources.ApplyResources(Me.PanelMenu, "PanelMenu")
        Me.PanelMenu.Name = "PanelMenu"
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        resources.ApplyResources(Me.btnSalir, "btnSalir")
        Me.btnSalir.FlatAppearance.BorderSize = 0
        Me.btnSalir.ForeColor = System.Drawing.Color.Black
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'btnVentas
        '
        Me.btnVentas.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        resources.ApplyResources(Me.btnVentas, "btnVentas")
        Me.btnVentas.FlatAppearance.BorderSize = 0
        Me.btnVentas.ForeColor = System.Drawing.Color.Black
        Me.btnVentas.Name = "btnVentas"
        Me.btnVentas.UseVisualStyleBackColor = False
        '
        'btnProductos
        '
        Me.btnProductos.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        resources.ApplyResources(Me.btnProductos, "btnProductos")
        Me.btnProductos.FlatAppearance.BorderSize = 0
        Me.btnProductos.ForeColor = System.Drawing.Color.Black
        Me.btnProductos.Name = "btnProductos"
        Me.btnProductos.UseVisualStyleBackColor = False
        '
        'btnClientes
        '
        Me.btnClientes.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(67, Byte), Integer))
        resources.ApplyResources(Me.btnClientes, "btnClientes")
        Me.btnClientes.FlatAppearance.BorderSize = 0
        Me.btnClientes.ForeColor = System.Drawing.Color.Black
        Me.btnClientes.Name = "btnClientes"
        Me.btnClientes.UseVisualStyleBackColor = False
        '
        'PanelLogo
        '
        Me.PanelLogo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.PanelLogo.Controls.Add(Me.ptbImagenLogo)
        resources.ApplyResources(Me.PanelLogo, "PanelLogo")
        Me.PanelLogo.Name = "PanelLogo"
        '
        'ptbImagenLogo
        '
        Me.ptbImagenLogo.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        resources.ApplyResources(Me.ptbImagenLogo, "ptbImagenLogo")
        Me.ptbImagenLogo.Name = "ptbImagenLogo"
        Me.ptbImagenLogo.TabStop = False
        '
        'PanelTitulo
        '
        Me.PanelTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.PanelTitulo.Controls.Add(Me.lblTitulo)
        resources.ApplyResources(Me.PanelTitulo, "PanelTitulo")
        Me.PanelTitulo.ForeColor = System.Drawing.SystemColors.Control
        Me.PanelTitulo.Name = "PanelTitulo"
        '
        'lblTitulo
        '
        resources.ApplyResources(Me.lblTitulo, "lblTitulo")
        Me.lblTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Name = "lblTitulo"
        '
        'PanelContenedor
        '
        Me.PanelContenedor.Controls.Add(Me.PictureBox1)
        resources.ApplyResources(Me.PanelContenedor, "PanelContenedor")
        Me.PanelContenedor.Name = "PanelContenedor"
        '
        'PictureBox1
        '
        resources.ApplyResources(Me.PictureBox1, "PictureBox1")
        Me.PictureBox1.Image = Global.ExamenTacticaSoft.My.Resources.Resources.Logo
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.TabStop = False
        '
        'frmMenu
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.PanelContenedor)
        Me.Controls.Add(Me.PanelTitulo)
        Me.Controls.Add(Me.PanelMenu)
        Me.MaximizeBox = False
        Me.Name = "frmMenu"
        Me.PanelMenu.ResumeLayout(False)
        Me.PanelLogo.ResumeLayout(False)
        CType(Me.ptbImagenLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelTitulo.ResumeLayout(False)
        Me.PanelTitulo.PerformLayout()
        Me.PanelContenedor.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelMenu As Panel
    Friend WithEvents btnClientes As Button
    Friend WithEvents PanelLogo As Panel
    Friend WithEvents btnVentas As Button
    Friend WithEvents btnProductos As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents PanelTitulo As Panel
    Friend WithEvents lblTitulo As Label
    Friend WithEvents ptbImagenLogo As PictureBox
    Friend WithEvents PanelContenedor As Panel
    Friend WithEvents PictureBox1 As PictureBox
End Class
