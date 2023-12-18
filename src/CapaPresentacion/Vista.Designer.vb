<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Vista
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
        Me.PanelSuperior = New System.Windows.Forms.Panel()
        Me.LabelTitulo = New System.Windows.Forms.Label()
        Me.PanelLateral = New System.Windows.Forms.Panel()
        Me.IconButtonVentas = New FontAwesome.Sharp.IconButton()
        Me.IconButtonClientes = New FontAwesome.Sharp.IconButton()
        Me.IconButtonProductos = New FontAwesome.Sharp.IconButton()
        Me.IconButtonHome = New FontAwesome.Sharp.IconButton()
        Me.PanelSuperior.SuspendLayout()
        Me.PanelLateral.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelSuperior
        '
        Me.PanelSuperior.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.PanelSuperior.Controls.Add(Me.LabelTitulo)
        Me.PanelSuperior.Controls.Add(Me.IconButtonHome)
        Me.PanelSuperior.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelSuperior.Location = New System.Drawing.Point(0, 0)
        Me.PanelSuperior.Name = "PanelSuperior"
        Me.PanelSuperior.Size = New System.Drawing.Size(800, 65)
        Me.PanelSuperior.TabIndex = 0
        '
        'LabelTitulo
        '
        Me.LabelTitulo.AutoSize = True
        Me.LabelTitulo.Font = New System.Drawing.Font("Goudy Stout", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTitulo.Location = New System.Drawing.Point(164, 19)
        Me.LabelTitulo.Name = "LabelTitulo"
        Me.LabelTitulo.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.LabelTitulo.Size = New System.Drawing.Size(472, 26)
        Me.LabelTitulo.TabIndex = 1
        Me.LabelTitulo.Text = "Servicios Cabanellas"
        Me.LabelTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PanelLateral
        '
        Me.PanelLateral.Controls.Add(Me.IconButtonVentas)
        Me.PanelLateral.Controls.Add(Me.IconButtonClientes)
        Me.PanelLateral.Controls.Add(Me.IconButtonProductos)
        Me.PanelLateral.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelLateral.Location = New System.Drawing.Point(0, 65)
        Me.PanelLateral.Name = "PanelLateral"
        Me.PanelLateral.Size = New System.Drawing.Size(200, 433)
        Me.PanelLateral.TabIndex = 1
        '
        'IconButtonVentas
        '
        Me.IconButtonVentas.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart
        Me.IconButtonVentas.IconColor = System.Drawing.Color.Black
        Me.IconButtonVentas.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButtonVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButtonVentas.Location = New System.Drawing.Point(37, 283)
        Me.IconButtonVentas.Name = "IconButtonVentas"
        Me.IconButtonVentas.Size = New System.Drawing.Size(118, 48)
        Me.IconButtonVentas.TabIndex = 5
        Me.IconButtonVentas.Text = "Ventas"
        Me.IconButtonVentas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IconButtonVentas.UseVisualStyleBackColor = True
        '
        'IconButtonClientes
        '
        Me.IconButtonClientes.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup
        Me.IconButtonClientes.IconColor = System.Drawing.Color.Black
        Me.IconButtonClientes.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButtonClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButtonClientes.Location = New System.Drawing.Point(37, 190)
        Me.IconButtonClientes.Name = "IconButtonClientes"
        Me.IconButtonClientes.Size = New System.Drawing.Size(118, 53)
        Me.IconButtonClientes.TabIndex = 4
        Me.IconButtonClientes.Text = "Clientes"
        Me.IconButtonClientes.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IconButtonClientes.UseVisualStyleBackColor = True
        '
        'IconButtonProductos
        '
        Me.IconButtonProductos.IconChar = FontAwesome.Sharp.IconChar.Laptop
        Me.IconButtonProductos.IconColor = System.Drawing.Color.Black
        Me.IconButtonProductos.IconFont = FontAwesome.Sharp.IconFont.Solid
        Me.IconButtonProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButtonProductos.Location = New System.Drawing.Point(37, 119)
        Me.IconButtonProductos.Name = "IconButtonProductos"
        Me.IconButtonProductos.Size = New System.Drawing.Size(118, 49)
        Me.IconButtonProductos.TabIndex = 3
        Me.IconButtonProductos.Text = "Productos"
        Me.IconButtonProductos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IconButtonProductos.UseVisualStyleBackColor = True
        '
        'IconButtonHome
        '
        Me.IconButtonHome.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.IconButtonHome.IconChar = FontAwesome.Sharp.IconChar.X
        Me.IconButtonHome.IconColor = System.Drawing.Color.Black
        Me.IconButtonHome.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButtonHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButtonHome.Location = New System.Drawing.Point(743, 3)
        Me.IconButtonHome.Name = "IconButtonHome"
        Me.IconButtonHome.Size = New System.Drawing.Size(54, 55)
        Me.IconButtonHome.TabIndex = 2
        Me.IconButtonHome.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IconButtonHome.UseVisualStyleBackColor = False
        '
        'Vista
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 498)
        Me.Controls.Add(Me.PanelLateral)
        Me.Controls.Add(Me.PanelSuperior)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Vista"
        Me.Text = "Form1"
        Me.PanelSuperior.ResumeLayout(False)
        Me.PanelSuperior.PerformLayout()
        Me.PanelLateral.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelSuperior As Panel
    Friend WithEvents PanelLateral As Panel
    Friend WithEvents LabelTitulo As Label
    Friend WithEvents IconButtonHome As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButtonProductos As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButtonClientes As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButtonVentas As FontAwesome.Sharp.IconButton
End Class
