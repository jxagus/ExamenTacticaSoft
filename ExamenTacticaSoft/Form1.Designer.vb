<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.txtFiltroAvanzado = New System.Windows.Forms.TextBox()
        Me.lblFiltroAvanzado = New System.Windows.Forms.Label()
        Me.cboCriterio = New System.Windows.Forms.ComboBox()
        Me.lblCriterio = New System.Windows.Forms.Label()
        Me.cboCampo = New System.Windows.Forms.ComboBox()
        Me.lblCampo = New System.Windows.Forms.Label()
        Me.btnFiltro = New System.Windows.Forms.Button()
        Me.txtFiltro = New System.Windows.Forms.TextBox()
        Me.lblFiltro = New System.Windows.Forms.Label()
        Me.btnEliminarLogico = New System.Windows.Forms.Button()
        Me.btnEliminarFisico = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.pbxPokemon = New System.Windows.Forms.PictureBox()
        Me.dgvPokemons = New System.Windows.Forms.DataGridView()
        CType(Me.pbxPokemon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvPokemons, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtFiltroAvanzado
        '
        Me.txtFiltroAvanzado.Location = New System.Drawing.Point(420, 371)
        Me.txtFiltroAvanzado.Name = "txtFiltroAvanzado"
        Me.txtFiltroAvanzado.Size = New System.Drawing.Size(100, 20)
        Me.txtFiltroAvanzado.TabIndex = 29
        '
        'lblFiltroAvanzado
        '
        Me.lblFiltroAvanzado.AutoSize = True
        Me.lblFiltroAvanzado.Location = New System.Drawing.Point(364, 374)
        Me.lblFiltroAvanzado.Name = "lblFiltroAvanzado"
        Me.lblFiltroAvanzado.Size = New System.Drawing.Size(29, 13)
        Me.lblFiltroAvanzado.TabIndex = 28
        Me.lblFiltroAvanzado.Text = "Filtro"
        '
        'cboCriterio
        '
        Me.cboCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCriterio.FormattingEnabled = True
        Me.cboCriterio.Location = New System.Drawing.Point(224, 370)
        Me.cboCriterio.Name = "cboCriterio"
        Me.cboCriterio.Size = New System.Drawing.Size(121, 21)
        Me.cboCriterio.TabIndex = 27
        '
        'lblCriterio
        '
        Me.lblCriterio.AutoSize = True
        Me.lblCriterio.Location = New System.Drawing.Point(168, 374)
        Me.lblCriterio.Name = "lblCriterio"
        Me.lblCriterio.Size = New System.Drawing.Size(42, 13)
        Me.lblCriterio.TabIndex = 26
        Me.lblCriterio.Text = "Criterio:"
        '
        'cboCampo
        '
        Me.cboCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCampo.FormattingEnabled = True
        Me.cboCampo.Location = New System.Drawing.Point(28, 370)
        Me.cboCampo.Name = "cboCampo"
        Me.cboCampo.Size = New System.Drawing.Size(121, 21)
        Me.cboCampo.TabIndex = 25
        '
        'lblCampo
        '
        Me.lblCampo.AutoSize = True
        Me.lblCampo.Location = New System.Drawing.Point(-28, 374)
        Me.lblCampo.Name = "lblCampo"
        Me.lblCampo.Size = New System.Drawing.Size(43, 13)
        Me.lblCampo.TabIndex = 24
        Me.lblCampo.Text = "Campo:"
        '
        'btnFiltro
        '
        Me.btnFiltro.Location = New System.Drawing.Point(540, 368)
        Me.btnFiltro.Name = "btnFiltro"
        Me.btnFiltro.Size = New System.Drawing.Size(75, 23)
        Me.btnFiltro.TabIndex = 23
        Me.btnFiltro.Text = "Buscar"
        Me.btnFiltro.UseVisualStyleBackColor = True
        '
        'txtFiltro
        '
        Me.txtFiltro.Location = New System.Drawing.Point(48, 60)
        Me.txtFiltro.Name = "txtFiltro"
        Me.txtFiltro.Size = New System.Drawing.Size(185, 20)
        Me.txtFiltro.TabIndex = 22
        '
        'lblFiltro
        '
        Me.lblFiltro.AutoSize = True
        Me.lblFiltro.Location = New System.Drawing.Point(-27, 63)
        Me.lblFiltro.Name = "lblFiltro"
        Me.lblFiltro.Size = New System.Drawing.Size(69, 13)
        Me.lblFiltro.TabIndex = 21
        Me.lblFiltro.Text = "Filtro Rápido:"
        '
        'btnEliminarLogico
        '
        Me.btnEliminarLogico.Location = New System.Drawing.Point(245, 324)
        Me.btnEliminarLogico.Name = "btnEliminarLogico"
        Me.btnEliminarLogico.Size = New System.Drawing.Size(104, 23)
        Me.btnEliminarLogico.TabIndex = 20
        Me.btnEliminarLogico.Text = "Eliminar Lógico"
        Me.btnEliminarLogico.UseVisualStyleBackColor = True
        '
        'btnEliminarFisico
        '
        Me.btnEliminarFisico.Location = New System.Drawing.Point(135, 324)
        Me.btnEliminarFisico.Name = "btnEliminarFisico"
        Me.btnEliminarFisico.Size = New System.Drawing.Size(104, 23)
        Me.btnEliminarFisico.TabIndex = 19
        Me.btnEliminarFisico.Text = "Eliminar Físico"
        Me.btnEliminarFisico.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(54, 324)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(75, 23)
        Me.btnModificar.TabIndex = 18
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(-27, 324)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregar.TabIndex = 17
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'pbxPokemon
        '
        Me.pbxPokemon.Location = New System.Drawing.Point(589, 86)
        Me.pbxPokemon.Name = "pbxPokemon"
        Me.pbxPokemon.Size = New System.Drawing.Size(199, 232)
        Me.pbxPokemon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxPokemon.TabIndex = 16
        Me.pbxPokemon.TabStop = False
        '
        'dgvPokemons
        '
        Me.dgvPokemons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPokemons.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvPokemons.Location = New System.Drawing.Point(-27, 86)
        Me.dgvPokemons.MultiSelect = False
        Me.dgvPokemons.Name = "dgvPokemons"
        Me.dgvPokemons.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPokemons.Size = New System.Drawing.Size(610, 232)
        Me.dgvPokemons.TabIndex = 15
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtFiltroAvanzado)
        Me.Controls.Add(Me.lblFiltroAvanzado)
        Me.Controls.Add(Me.cboCriterio)
        Me.Controls.Add(Me.lblCriterio)
        Me.Controls.Add(Me.cboCampo)
        Me.Controls.Add(Me.lblCampo)
        Me.Controls.Add(Me.btnFiltro)
        Me.Controls.Add(Me.txtFiltro)
        Me.Controls.Add(Me.lblFiltro)
        Me.Controls.Add(Me.btnEliminarLogico)
        Me.Controls.Add(Me.btnEliminarFisico)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.pbxPokemon)
        Me.Controls.Add(Me.dgvPokemons)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.pbxPokemon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvPokemons, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents txtFiltroAvanzado As TextBox
    Private WithEvents lblFiltroAvanzado As Label
    Private WithEvents cboCriterio As ComboBox
    Private WithEvents lblCriterio As Label
    Private WithEvents cboCampo As ComboBox
    Private WithEvents lblCampo As Label
    Private WithEvents btnFiltro As Button
    Private WithEvents txtFiltro As TextBox
    Private WithEvents lblFiltro As Label
    Private WithEvents btnEliminarLogico As Button
    Private WithEvents btnEliminarFisico As Button
    Private WithEvents btnModificar As Button
    Private WithEvents btnAgregar As Button
    Private WithEvents pbxPokemon As PictureBox
    Private WithEvents dgvPokemons As DataGridView
End Class
