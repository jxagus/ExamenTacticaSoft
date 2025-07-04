<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProductos
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
        Me.txtFiltroRapido = New System.Windows.Forms.TextBox()
        Me.lblFiltroRapido = New System.Windows.Forms.Label()
        Me.lbltitulo = New System.Windows.Forms.Label()
        Me.dgvProductos = New System.Windows.Forms.DataGridView()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblCampo = New System.Windows.Forms.Label()
        Me.cbCriterio = New System.Windows.Forms.ComboBox()
        Me.cbCampo = New System.Windows.Forms.ComboBox()
        Me.txtFiltro = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtFiltroRapido
        '
        Me.txtFiltroRapido.Location = New System.Drawing.Point(81, 54)
        Me.txtFiltroRapido.Name = "txtFiltroRapido"
        Me.txtFiltroRapido.Size = New System.Drawing.Size(100, 20)
        Me.txtFiltroRapido.TabIndex = 38
        '
        'lblFiltroRapido
        '
        Me.lblFiltroRapido.AutoSize = True
        Me.lblFiltroRapido.Location = New System.Drawing.Point(12, 54)
        Me.lblFiltroRapido.Name = "lblFiltroRapido"
        Me.lblFiltroRapido.Size = New System.Drawing.Size(66, 13)
        Me.lblFiltroRapido.TabIndex = 27
        Me.lblFiltroRapido.Text = "FiltroRapido:"
        '
        'lbltitulo
        '
        Me.lbltitulo.AutoSize = True
        Me.lbltitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitulo.Location = New System.Drawing.Point(321, 9)
        Me.lbltitulo.Name = "lbltitulo"
        Me.lbltitulo.Size = New System.Drawing.Size(137, 31)
        Me.lbltitulo.TabIndex = 40
        Me.lbltitulo.Text = "Productos"
        '
        'dgvProductos
        '
        Me.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProductos.Location = New System.Drawing.Point(17, 80)
        Me.dgvProductos.Name = "dgvProductos"
        Me.dgvProductos.Size = New System.Drawing.Size(660, 300)
        Me.dgvProductos.TabIndex = 41
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(710, 89)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(108, 56)
        Me.btnAgregar.TabIndex = 48
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(363, 410)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 54
        Me.Label3.Text = "Filtro:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(178, 410)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 53
        Me.Label2.Text = "Criterio:"
        '
        'lblCampo
        '
        Me.lblCampo.AutoSize = True
        Me.lblCampo.Location = New System.Drawing.Point(14, 410)
        Me.lblCampo.Name = "lblCampo"
        Me.lblCampo.Size = New System.Drawing.Size(43, 13)
        Me.lblCampo.TabIndex = 52
        Me.lblCampo.Text = "Campo:"
        '
        'cbCriterio
        '
        Me.cbCriterio.FormattingEnabled = True
        Me.cbCriterio.Location = New System.Drawing.Point(223, 407)
        Me.cbCriterio.Name = "cbCriterio"
        Me.cbCriterio.Size = New System.Drawing.Size(134, 21)
        Me.cbCriterio.TabIndex = 50
        '
        'cbCampo
        '
        Me.cbCampo.FormattingEnabled = True
        Me.cbCampo.Location = New System.Drawing.Point(59, 407)
        Me.cbCampo.Name = "cbCampo"
        Me.cbCampo.Size = New System.Drawing.Size(102, 21)
        Me.cbCampo.TabIndex = 49
        '
        'txtFiltro
        '
        Me.txtFiltro.Location = New System.Drawing.Point(401, 408)
        Me.txtFiltro.Name = "txtFiltro"
        Me.txtFiltro.Size = New System.Drawing.Size(100, 20)
        Me.txtFiltro.TabIndex = 55
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(667, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(176, 13)
        Me.Label1.TabIndex = 56
        Me.Label1.Text = "Desea agregar un nuevo producto?"
        '
        'frmProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(876, 456)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtFiltro)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblCampo)
        Me.Controls.Add(Me.cbCriterio)
        Me.Controls.Add(Me.cbCampo)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.dgvProductos)
        Me.Controls.Add(Me.lbltitulo)
        Me.Controls.Add(Me.txtFiltroRapido)
        Me.Controls.Add(Me.lblFiltroRapido)
        Me.Name = "frmProductos"
        Me.Text = "frmProductos"
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtFiltroRapido As TextBox
    Friend WithEvents lblFiltroRapido As Label
    Friend WithEvents lbltitulo As Label
    Friend WithEvents dgvProductos As DataGridView
    Friend WithEvents btnAgregar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblCampo As Label
    Friend WithEvents cbCriterio As ComboBox
    Friend WithEvents cbCampo As ComboBox
    Friend WithEvents txtFiltro As TextBox
    Friend WithEvents Label1 As Label
End Class
