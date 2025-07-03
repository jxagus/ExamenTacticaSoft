<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHistorialVentas
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
        Me.lblHistorial = New System.Windows.Forms.Label()
        Me.dgvHistorial = New System.Windows.Forms.DataGridView()
        Me.btnModificarHistorial = New System.Windows.Forms.Button()
        Me.btnEliminarHistorial = New System.Windows.Forms.Button()
        CType(Me.dgvHistorial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblHistorial
        '
        Me.lblHistorial.AutoSize = True
        Me.lblHistorial.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHistorial.Location = New System.Drawing.Point(269, 26)
        Me.lblHistorial.Name = "lblHistorial"
        Me.lblHistorial.Size = New System.Drawing.Size(205, 31)
        Me.lblHistorial.TabIndex = 43
        Me.lblHistorial.Text = "Historial Ventas"
        '
        'dgvHistorial
        '
        Me.dgvHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvHistorial.Location = New System.Drawing.Point(69, 138)
        Me.dgvHistorial.Name = "dgvHistorial"
        Me.dgvHistorial.Size = New System.Drawing.Size(626, 219)
        Me.dgvHistorial.TabIndex = 44
        '
        'btnModificarHistorial
        '
        Me.btnModificarHistorial.Location = New System.Drawing.Point(69, 109)
        Me.btnModificarHistorial.Name = "btnModificarHistorial"
        Me.btnModificarHistorial.Size = New System.Drawing.Size(75, 23)
        Me.btnModificarHistorial.TabIndex = 45
        Me.btnModificarHistorial.Text = "Modificar"
        Me.btnModificarHistorial.UseVisualStyleBackColor = True
        '
        'btnEliminarHistorial
        '
        Me.btnEliminarHistorial.Location = New System.Drawing.Point(150, 109)
        Me.btnEliminarHistorial.Name = "btnEliminarHistorial"
        Me.btnEliminarHistorial.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminarHistorial.TabIndex = 46
        Me.btnEliminarHistorial.Text = "Eliminar"
        Me.btnEliminarHistorial.UseVisualStyleBackColor = True
        '
        'frmHistorialVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(761, 460)
        Me.Controls.Add(Me.btnEliminarHistorial)
        Me.Controls.Add(Me.btnModificarHistorial)
        Me.Controls.Add(Me.dgvHistorial)
        Me.Controls.Add(Me.lblHistorial)
        Me.Name = "frmHistorialVentas"
        Me.Text = "frmHistorialVentas"
        CType(Me.dgvHistorial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHistorial As Label
    Friend WithEvents dgvHistorial As DataGridView
    Friend WithEvents btnModificarHistorial As Button
    Friend WithEvents btnEliminarHistorial As Button
End Class
