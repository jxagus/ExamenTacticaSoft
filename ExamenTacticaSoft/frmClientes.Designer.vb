<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClientes
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblCampo = New System.Windows.Forms.Label()
        Me.cbCriterio = New System.Windows.Forms.ComboBox()
        Me.cbCampo = New System.Windows.Forms.ComboBox()
        Me.lblFiltroRapido = New System.Windows.Forms.Label()
        Me.lblClientes = New System.Windows.Forms.Label()
        Me.dgvClientes = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.txtFiltro = New System.Windows.Forms.TextBox()
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtFiltroRapido
        '
        Me.txtFiltroRapido.Location = New System.Drawing.Point(76, 48)
        Me.txtFiltroRapido.Name = "txtFiltroRapido"
        Me.txtFiltroRapido.Size = New System.Drawing.Size(100, 20)
        Me.txtFiltroRapido.TabIndex = 25
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(359, 409)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Filtro:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(174, 409)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Criterio:"
        '
        'lblCampo
        '
        Me.lblCampo.AutoSize = True
        Me.lblCampo.Location = New System.Drawing.Point(10, 409)
        Me.lblCampo.Name = "lblCampo"
        Me.lblCampo.Size = New System.Drawing.Size(43, 13)
        Me.lblCampo.TabIndex = 21
        Me.lblCampo.Text = "Campo:"
        '
        'cbCriterio
        '
        Me.cbCriterio.FormattingEnabled = True
        Me.cbCriterio.Location = New System.Drawing.Point(219, 406)
        Me.cbCriterio.Name = "cbCriterio"
        Me.cbCriterio.Size = New System.Drawing.Size(134, 21)
        Me.cbCriterio.TabIndex = 19
        '
        'cbCampo
        '
        Me.cbCampo.FormattingEnabled = True
        Me.cbCampo.Location = New System.Drawing.Point(55, 406)
        Me.cbCampo.Name = "cbCampo"
        Me.cbCampo.Size = New System.Drawing.Size(102, 21)
        Me.cbCampo.TabIndex = 18
        '
        'lblFiltroRapido
        '
        Me.lblFiltroRapido.AutoSize = True
        Me.lblFiltroRapido.Location = New System.Drawing.Point(12, 51)
        Me.lblFiltroRapido.Name = "lblFiltroRapido"
        Me.lblFiltroRapido.Size = New System.Drawing.Size(66, 13)
        Me.lblFiltroRapido.TabIndex = 14
        Me.lblFiltroRapido.Text = "FiltroRapido:"
        '
        'lblClientes
        '
        Me.lblClientes.AutoSize = True
        Me.lblClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClientes.Location = New System.Drawing.Point(317, 9)
        Me.lblClientes.Name = "lblClientes"
        Me.lblClientes.Size = New System.Drawing.Size(113, 31)
        Me.lblClientes.TabIndex = 41
        Me.lblClientes.Text = "Clientes"
        '
        'dgvClientes
        '
        Me.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvClientes.Location = New System.Drawing.Point(12, 85)
        Me.dgvClientes.Name = "dgvClientes"
        Me.dgvClientes.Size = New System.Drawing.Size(640, 301)
        Me.dgvClientes.TabIndex = 24
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(664, 166)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(165, 13)
        Me.Label1.TabIndex = 58
        Me.Label1.Text = "Desea agregar un nuevo cliente?"
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(697, 182)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(108, 56)
        Me.btnAgregar.TabIndex = 57
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'txtFiltro
        '
        Me.txtFiltro.Location = New System.Drawing.Point(397, 407)
        Me.txtFiltro.Name = "txtFiltro"
        Me.txtFiltro.Size = New System.Drawing.Size(100, 20)
        Me.txtFiltro.TabIndex = 59
        '
        'frmClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(861, 450)
        Me.Controls.Add(Me.txtFiltro)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.lblClientes)
        Me.Controls.Add(Me.txtFiltroRapido)
        Me.Controls.Add(Me.dgvClientes)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblCampo)
        Me.Controls.Add(Me.cbCriterio)
        Me.Controls.Add(Me.cbCampo)
        Me.Controls.Add(Me.lblFiltroRapido)
        Me.Name = "frmClientes"
        Me.Text = "frmClientes"
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtFiltroRapido As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblCampo As Label
    Friend WithEvents cbCriterio As ComboBox
    Friend WithEvents cbCampo As ComboBox
    Friend WithEvents lblFiltroRapido As Label
    Friend WithEvents lblClientes As Label
    Friend WithEvents dgvClientes As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAgregar As Button
    Friend WithEvents txtFiltro As TextBox
End Class
