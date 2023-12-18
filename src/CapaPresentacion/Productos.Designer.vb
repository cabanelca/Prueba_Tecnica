<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Productos
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
        Me.IconButtonAgregar = New FontAwesome.Sharp.IconButton()
        Me.IconButtonModificar = New FontAwesome.Sharp.IconButton()
        Me.IconButtonEliminar = New FontAwesome.Sharp.IconButton()
        Me.LabelNombre = New System.Windows.Forms.Label()
        Me.LabelPrecio = New System.Windows.Forms.Label()
        Me.LabelCategoria = New System.Windows.Forms.Label()
        Me.PanelProductos = New System.Windows.Forms.Panel()
        Me.IconButtonHome = New FontAwesome.Sharp.IconButton()
        Me.LabelProductos = New System.Windows.Forms.Label()
        Me.TextBoxNombre = New System.Windows.Forms.TextBox()
        Me.TextBoxPrecio = New System.Windows.Forms.TextBox()
        Me.TextBoxCategoria = New System.Windows.Forms.TextBox()
        Me.TextBoxBuscar = New System.Windows.Forms.TextBox()
        Me.IconButtonBuscar = New FontAwesome.Sharp.IconButton()
        Me.DtvProductos = New System.Windows.Forms.DataGridView()
        Me.LabelCantidad = New System.Windows.Forms.Label()
        Me.TextBoxCantidad = New System.Windows.Forms.TextBox()
        Me.PanelProductos.SuspendLayout()
        CType(Me.DtvProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IconButtonAgregar
        '
        Me.IconButtonAgregar.IconChar = FontAwesome.Sharp.IconChar.None
        Me.IconButtonAgregar.IconColor = System.Drawing.Color.Black
        Me.IconButtonAgregar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButtonAgregar.Location = New System.Drawing.Point(65, 358)
        Me.IconButtonAgregar.Name = "IconButtonAgregar"
        Me.IconButtonAgregar.Size = New System.Drawing.Size(75, 23)
        Me.IconButtonAgregar.TabIndex = 0
        Me.IconButtonAgregar.Text = "Agregar"
        Me.IconButtonAgregar.UseVisualStyleBackColor = True
        '
        'IconButtonModificar
        '
        Me.IconButtonModificar.IconChar = FontAwesome.Sharp.IconChar.None
        Me.IconButtonModificar.IconColor = System.Drawing.Color.Black
        Me.IconButtonModificar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButtonModificar.Location = New System.Drawing.Point(169, 358)
        Me.IconButtonModificar.Name = "IconButtonModificar"
        Me.IconButtonModificar.Size = New System.Drawing.Size(75, 23)
        Me.IconButtonModificar.TabIndex = 1
        Me.IconButtonModificar.Text = "Modificar"
        Me.IconButtonModificar.UseVisualStyleBackColor = True
        '
        'IconButtonEliminar
        '
        Me.IconButtonEliminar.IconChar = FontAwesome.Sharp.IconChar.None
        Me.IconButtonEliminar.IconColor = System.Drawing.Color.Black
        Me.IconButtonEliminar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButtonEliminar.Location = New System.Drawing.Point(262, 358)
        Me.IconButtonEliminar.Name = "IconButtonEliminar"
        Me.IconButtonEliminar.Size = New System.Drawing.Size(75, 23)
        Me.IconButtonEliminar.TabIndex = 2
        Me.IconButtonEliminar.Text = "Eliminar"
        Me.IconButtonEliminar.UseVisualStyleBackColor = True
        '
        'LabelNombre
        '
        Me.LabelNombre.AutoSize = True
        Me.LabelNombre.Location = New System.Drawing.Point(64, 116)
        Me.LabelNombre.Name = "LabelNombre"
        Me.LabelNombre.Size = New System.Drawing.Size(44, 13)
        Me.LabelNombre.TabIndex = 3
        Me.LabelNombre.Text = "Nombre"
        '
        'LabelPrecio
        '
        Me.LabelPrecio.AutoSize = True
        Me.LabelPrecio.Location = New System.Drawing.Point(64, 164)
        Me.LabelPrecio.Name = "LabelPrecio"
        Me.LabelPrecio.Size = New System.Drawing.Size(37, 13)
        Me.LabelPrecio.TabIndex = 4
        Me.LabelPrecio.Text = "Precio"
        '
        'LabelCategoria
        '
        Me.LabelCategoria.AutoSize = True
        Me.LabelCategoria.Location = New System.Drawing.Point(62, 217)
        Me.LabelCategoria.Name = "LabelCategoria"
        Me.LabelCategoria.Size = New System.Drawing.Size(52, 13)
        Me.LabelCategoria.TabIndex = 5
        Me.LabelCategoria.Text = "Categoria"
        '
        'PanelProductos
        '
        Me.PanelProductos.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.PanelProductos.Controls.Add(Me.IconButtonHome)
        Me.PanelProductos.Controls.Add(Me.LabelProductos)
        Me.PanelProductos.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelProductos.Location = New System.Drawing.Point(0, 0)
        Me.PanelProductos.Name = "PanelProductos"
        Me.PanelProductos.Size = New System.Drawing.Size(800, 51)
        Me.PanelProductos.TabIndex = 6
        '
        'IconButtonHome
        '
        Me.IconButtonHome.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.IconButtonHome.IconChar = FontAwesome.Sharp.IconChar.HomeUser
        Me.IconButtonHome.IconColor = System.Drawing.Color.Black
        Me.IconButtonHome.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButtonHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButtonHome.Location = New System.Drawing.Point(658, 3)
        Me.IconButtonHome.Name = "IconButtonHome"
        Me.IconButtonHome.Size = New System.Drawing.Size(89, 46)
        Me.IconButtonHome.TabIndex = 2
        Me.IconButtonHome.Text = "Home"
        Me.IconButtonHome.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IconButtonHome.UseVisualStyleBackColor = False
        '
        'LabelProductos
        '
        Me.LabelProductos.AutoSize = True
        Me.LabelProductos.Font = New System.Drawing.Font("Stencil", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelProductos.Location = New System.Drawing.Point(292, 14)
        Me.LabelProductos.Name = "LabelProductos"
        Me.LabelProductos.Size = New System.Drawing.Size(126, 22)
        Me.LabelProductos.TabIndex = 0
        Me.LabelProductos.Text = "Productos"
        '
        'TextBoxNombre
        '
        Me.TextBoxNombre.Location = New System.Drawing.Point(169, 109)
        Me.TextBoxNombre.Name = "TextBoxNombre"
        Me.TextBoxNombre.Size = New System.Drawing.Size(168, 20)
        Me.TextBoxNombre.TabIndex = 7
        '
        'TextBoxPrecio
        '
        Me.TextBoxPrecio.Location = New System.Drawing.Point(169, 157)
        Me.TextBoxPrecio.Name = "TextBoxPrecio"
        Me.TextBoxPrecio.Size = New System.Drawing.Size(168, 20)
        Me.TextBoxPrecio.TabIndex = 8
        '
        'TextBoxCategoria
        '
        Me.TextBoxCategoria.Location = New System.Drawing.Point(169, 217)
        Me.TextBoxCategoria.Name = "TextBoxCategoria"
        Me.TextBoxCategoria.Size = New System.Drawing.Size(168, 20)
        Me.TextBoxCategoria.TabIndex = 9
        '
        'TextBoxBuscar
        '
        Me.TextBoxBuscar.Location = New System.Drawing.Point(439, 109)
        Me.TextBoxBuscar.Name = "TextBoxBuscar"
        Me.TextBoxBuscar.Size = New System.Drawing.Size(168, 20)
        Me.TextBoxBuscar.TabIndex = 10
        '
        'IconButtonBuscar
        '
        Me.IconButtonBuscar.IconChar = FontAwesome.Sharp.IconChar.None
        Me.IconButtonBuscar.IconColor = System.Drawing.Color.Black
        Me.IconButtonBuscar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButtonBuscar.Location = New System.Drawing.Point(658, 107)
        Me.IconButtonBuscar.Name = "IconButtonBuscar"
        Me.IconButtonBuscar.Size = New System.Drawing.Size(75, 23)
        Me.IconButtonBuscar.TabIndex = 11
        Me.IconButtonBuscar.Text = "Buscar"
        Me.IconButtonBuscar.UseVisualStyleBackColor = True
        '
        'DtvProductos
        '
        Me.DtvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtvProductos.Location = New System.Drawing.Point(343, 135)
        Me.DtvProductos.Name = "DtvProductos"
        Me.DtvProductos.Size = New System.Drawing.Size(457, 312)
        Me.DtvProductos.TabIndex = 12
        '
        'LabelCantidad
        '
        Me.LabelCantidad.AutoSize = True
        Me.LabelCantidad.Location = New System.Drawing.Point(62, 272)
        Me.LabelCantidad.Name = "LabelCantidad"
        Me.LabelCantidad.Size = New System.Drawing.Size(49, 13)
        Me.LabelCantidad.TabIndex = 13
        Me.LabelCantidad.Text = "Cantidad"
        '
        'TextBoxCantidad
        '
        Me.TextBoxCantidad.Location = New System.Drawing.Point(169, 265)
        Me.TextBoxCantidad.Name = "TextBoxCantidad"
        Me.TextBoxCantidad.Size = New System.Drawing.Size(168, 20)
        Me.TextBoxCantidad.TabIndex = 14
        '
        'Productos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TextBoxCantidad)
        Me.Controls.Add(Me.LabelCantidad)
        Me.Controls.Add(Me.DtvProductos)
        Me.Controls.Add(Me.IconButtonBuscar)
        Me.Controls.Add(Me.TextBoxBuscar)
        Me.Controls.Add(Me.TextBoxCategoria)
        Me.Controls.Add(Me.TextBoxPrecio)
        Me.Controls.Add(Me.TextBoxNombre)
        Me.Controls.Add(Me.PanelProductos)
        Me.Controls.Add(Me.LabelCategoria)
        Me.Controls.Add(Me.LabelPrecio)
        Me.Controls.Add(Me.LabelNombre)
        Me.Controls.Add(Me.IconButtonEliminar)
        Me.Controls.Add(Me.IconButtonModificar)
        Me.Controls.Add(Me.IconButtonAgregar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Productos"
        Me.Text = "Productos"
        Me.PanelProductos.ResumeLayout(False)
        Me.PanelProductos.PerformLayout()
        CType(Me.DtvProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents IconButtonAgregar As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButtonModificar As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButtonEliminar As FontAwesome.Sharp.IconButton
    Friend WithEvents LabelNombre As Label
    Friend WithEvents LabelPrecio As Label
    Friend WithEvents LabelCategoria As Label
    Friend WithEvents PanelProductos As Panel
    Friend WithEvents LabelProductos As Label
    Friend WithEvents TextBoxNombre As TextBox
    Friend WithEvents TextBoxPrecio As TextBox
    Friend WithEvents TextBoxCategoria As TextBox
    Friend WithEvents TextBoxBuscar As TextBox
    Friend WithEvents IconButtonBuscar As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButtonHome As FontAwesome.Sharp.IconButton
    Friend WithEvents DtvProductos As DataGridView
    Friend WithEvents LabelCantidad As Label
    Friend WithEvents TextBoxCantidad As TextBox
End Class
