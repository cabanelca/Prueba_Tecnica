<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Clientes
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
        Me.TextBoxCliente = New System.Windows.Forms.TextBox()
        Me.TextBoxCorreo = New System.Windows.Forms.TextBox()
        Me.TextBoxTelefono = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.PanelCliente = New System.Windows.Forms.Panel()
        Me.IconButtonHome = New FontAwesome.Sharp.IconButton()
        Me.LabelClientes = New System.Windows.Forms.Label()
        Me.LabelNombreCliente = New System.Windows.Forms.Label()
        Me.LabelTelefonoCliente = New System.Windows.Forms.Label()
        Me.LabelCorreoCliente = New System.Windows.Forms.Label()
        Me.IconButtonClienteAgregar = New FontAwesome.Sharp.IconButton()
        Me.IconButtonClienteModif = New FontAwesome.Sharp.IconButton()
        Me.IconButtonClienteEliminar = New FontAwesome.Sharp.IconButton()
        Me.IconButtonBuscarCLientes = New FontAwesome.Sharp.IconButton()
        Me.DgvClientes = New System.Windows.Forms.DataGridView()
        Me.PanelCliente.SuspendLayout()
        CType(Me.DgvClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBoxCliente
        '
        Me.TextBoxCliente.Location = New System.Drawing.Point(152, 114)
        Me.TextBoxCliente.Name = "TextBoxCliente"
        Me.TextBoxCliente.Size = New System.Drawing.Size(184, 20)
        Me.TextBoxCliente.TabIndex = 0
        '
        'TextBoxCorreo
        '
        Me.TextBoxCorreo.Location = New System.Drawing.Point(152, 233)
        Me.TextBoxCorreo.Name = "TextBoxCorreo"
        Me.TextBoxCorreo.Size = New System.Drawing.Size(184, 20)
        Me.TextBoxCorreo.TabIndex = 1
        '
        'TextBoxTelefono
        '
        Me.TextBoxTelefono.Location = New System.Drawing.Point(152, 176)
        Me.TextBoxTelefono.Name = "TextBoxTelefono"
        Me.TextBoxTelefono.Size = New System.Drawing.Size(184, 20)
        Me.TextBoxTelefono.TabIndex = 2
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(418, 114)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(174, 20)
        Me.TextBox4.TabIndex = 3
        '
        'PanelCliente
        '
        Me.PanelCliente.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.PanelCliente.Controls.Add(Me.IconButtonHome)
        Me.PanelCliente.Controls.Add(Me.LabelClientes)
        Me.PanelCliente.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelCliente.Location = New System.Drawing.Point(0, 0)
        Me.PanelCliente.Name = "PanelCliente"
        Me.PanelCliente.Size = New System.Drawing.Size(800, 58)
        Me.PanelCliente.TabIndex = 4
        '
        'IconButtonHome
        '
        Me.IconButtonHome.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.IconButtonHome.IconChar = FontAwesome.Sharp.IconChar.HomeUser
        Me.IconButtonHome.IconColor = System.Drawing.Color.Black
        Me.IconButtonHome.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButtonHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButtonHome.Location = New System.Drawing.Point(641, 9)
        Me.IconButtonHome.Name = "IconButtonHome"
        Me.IconButtonHome.Size = New System.Drawing.Size(89, 46)
        Me.IconButtonHome.TabIndex = 3
        Me.IconButtonHome.Text = "Home"
        Me.IconButtonHome.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IconButtonHome.UseVisualStyleBackColor = False
        '
        'LabelClientes
        '
        Me.LabelClientes.AutoSize = True
        Me.LabelClientes.Font = New System.Drawing.Font("Stencil", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelClientes.Location = New System.Drawing.Point(343, 20)
        Me.LabelClientes.Name = "LabelClientes"
        Me.LabelClientes.Size = New System.Drawing.Size(104, 22)
        Me.LabelClientes.TabIndex = 0
        Me.LabelClientes.Text = "Clientes"
        '
        'LabelNombreCliente
        '
        Me.LabelNombreCliente.AutoSize = True
        Me.LabelNombreCliente.Location = New System.Drawing.Point(82, 114)
        Me.LabelNombreCliente.Name = "LabelNombreCliente"
        Me.LabelNombreCliente.Size = New System.Drawing.Size(44, 13)
        Me.LabelNombreCliente.TabIndex = 5
        Me.LabelNombreCliente.Text = "Nombre"
        '
        'LabelTelefonoCliente
        '
        Me.LabelTelefonoCliente.AutoSize = True
        Me.LabelTelefonoCliente.Location = New System.Drawing.Point(82, 176)
        Me.LabelTelefonoCliente.Name = "LabelTelefonoCliente"
        Me.LabelTelefonoCliente.Size = New System.Drawing.Size(49, 13)
        Me.LabelTelefonoCliente.TabIndex = 6
        Me.LabelTelefonoCliente.Text = "Telefono"
        '
        'LabelCorreoCliente
        '
        Me.LabelCorreoCliente.AutoSize = True
        Me.LabelCorreoCliente.Location = New System.Drawing.Point(82, 233)
        Me.LabelCorreoCliente.Name = "LabelCorreoCliente"
        Me.LabelCorreoCliente.Size = New System.Drawing.Size(38, 13)
        Me.LabelCorreoCliente.TabIndex = 7
        Me.LabelCorreoCliente.Text = "Correo"
        '
        'IconButtonClienteAgregar
        '
        Me.IconButtonClienteAgregar.IconChar = FontAwesome.Sharp.IconChar.None
        Me.IconButtonClienteAgregar.IconColor = System.Drawing.Color.Black
        Me.IconButtonClienteAgregar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButtonClienteAgregar.Location = New System.Drawing.Point(76, 357)
        Me.IconButtonClienteAgregar.Name = "IconButtonClienteAgregar"
        Me.IconButtonClienteAgregar.Size = New System.Drawing.Size(75, 23)
        Me.IconButtonClienteAgregar.TabIndex = 8
        Me.IconButtonClienteAgregar.Text = "Agregar"
        Me.IconButtonClienteAgregar.UseVisualStyleBackColor = True
        '
        'IconButtonClienteModif
        '
        Me.IconButtonClienteModif.IconChar = FontAwesome.Sharp.IconChar.None
        Me.IconButtonClienteModif.IconColor = System.Drawing.Color.Black
        Me.IconButtonClienteModif.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButtonClienteModif.Location = New System.Drawing.Point(168, 357)
        Me.IconButtonClienteModif.Name = "IconButtonClienteModif"
        Me.IconButtonClienteModif.Size = New System.Drawing.Size(75, 23)
        Me.IconButtonClienteModif.TabIndex = 9
        Me.IconButtonClienteModif.Text = "Modificar"
        Me.IconButtonClienteModif.UseVisualStyleBackColor = True
        '
        'IconButtonClienteEliminar
        '
        Me.IconButtonClienteEliminar.IconChar = FontAwesome.Sharp.IconChar.None
        Me.IconButtonClienteEliminar.IconColor = System.Drawing.Color.Black
        Me.IconButtonClienteEliminar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButtonClienteEliminar.Location = New System.Drawing.Point(261, 357)
        Me.IconButtonClienteEliminar.Name = "IconButtonClienteEliminar"
        Me.IconButtonClienteEliminar.Size = New System.Drawing.Size(75, 23)
        Me.IconButtonClienteEliminar.TabIndex = 10
        Me.IconButtonClienteEliminar.Text = "Eliminar"
        Me.IconButtonClienteEliminar.UseVisualStyleBackColor = True
        '
        'IconButtonBuscarCLientes
        '
        Me.IconButtonBuscarCLientes.IconChar = FontAwesome.Sharp.IconChar.None
        Me.IconButtonBuscarCLientes.IconColor = System.Drawing.Color.Black
        Me.IconButtonBuscarCLientes.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButtonBuscarCLientes.Location = New System.Drawing.Point(641, 114)
        Me.IconButtonBuscarCLientes.Name = "IconButtonBuscarCLientes"
        Me.IconButtonBuscarCLientes.Size = New System.Drawing.Size(75, 23)
        Me.IconButtonBuscarCLientes.TabIndex = 11
        Me.IconButtonBuscarCLientes.Text = "Buscar"
        Me.IconButtonBuscarCLientes.UseVisualStyleBackColor = True
        '
        'DgvClientes
        '
        Me.DgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvClientes.Location = New System.Drawing.Point(355, 151)
        Me.DgvClientes.Name = "DgvClientes"
        Me.DgvClientes.Size = New System.Drawing.Size(444, 297)
        Me.DgvClientes.TabIndex = 12
        '
        'Clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DgvClientes)
        Me.Controls.Add(Me.IconButtonBuscarCLientes)
        Me.Controls.Add(Me.IconButtonClienteEliminar)
        Me.Controls.Add(Me.IconButtonClienteModif)
        Me.Controls.Add(Me.IconButtonClienteAgregar)
        Me.Controls.Add(Me.LabelCorreoCliente)
        Me.Controls.Add(Me.LabelTelefonoCliente)
        Me.Controls.Add(Me.LabelNombreCliente)
        Me.Controls.Add(Me.PanelCliente)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBoxTelefono)
        Me.Controls.Add(Me.TextBoxCorreo)
        Me.Controls.Add(Me.TextBoxCliente)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Clientes"
        Me.Text = "Clientes"
        Me.PanelCliente.ResumeLayout(False)
        Me.PanelCliente.PerformLayout()
        CType(Me.DgvClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBoxCliente As TextBox
    Friend WithEvents TextBoxCorreo As TextBox
    Friend WithEvents TextBoxTelefono As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents PanelCliente As Panel
    Friend WithEvents LabelNombreCliente As Label
    Friend WithEvents LabelTelefonoCliente As Label
    Friend WithEvents LabelCorreoCliente As Label
    Friend WithEvents LabelClientes As Label
    Friend WithEvents IconButtonClienteAgregar As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButtonClienteModif As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButtonClienteEliminar As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButtonBuscarCLientes As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButtonHome As FontAwesome.Sharp.IconButton
    Friend WithEvents DgvClientes As DataGridView
End Class
