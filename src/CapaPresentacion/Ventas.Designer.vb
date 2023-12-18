<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ventas
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
        Me.LabelClienteId = New System.Windows.Forms.Label()
        Me.LabelFecha = New System.Windows.Forms.Label()
        Me.LabelTotalVta = New System.Windows.Forms.Label()
        Me.LabelVentasTitulo = New System.Windows.Forms.Label()
        Me.PanelVentas = New System.Windows.Forms.Panel()
        Me.IconButtonHome = New FontAwesome.Sharp.IconButton()
        Me.TextBoxNroCliente = New System.Windows.Forms.TextBox()
        Me.TextBoxFecha = New System.Windows.Forms.TextBox()
        Me.TextBoxTotalVta = New System.Windows.Forms.TextBox()
        Me.TextBoxBuscarVta = New System.Windows.Forms.TextBox()
        Me.IconButtonAgregarVta = New FontAwesome.Sharp.IconButton()
        Me.IconButtonModificarVta = New FontAwesome.Sharp.IconButton()
        Me.IconButtonEliminarVta = New FontAwesome.Sharp.IconButton()
        Me.IconButtonBuscarVta = New FontAwesome.Sharp.IconButton()
        Me.DgvVentas = New System.Windows.Forms.DataGridView()
        Me.LabelNroVta = New System.Windows.Forms.Label()
        Me.TextBoxNroDeVta = New System.Windows.Forms.TextBox()
        Me.PanelVentas.SuspendLayout()
        CType(Me.DgvVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelClienteId
        '
        Me.LabelClienteId.AutoSize = True
        Me.LabelClienteId.Location = New System.Drawing.Point(95, 122)
        Me.LabelClienteId.Name = "LabelClienteId"
        Me.LabelClienteId.Size = New System.Drawing.Size(56, 13)
        Me.LabelClienteId.TabIndex = 0
        Me.LabelClienteId.Text = "NroCliente"
        '
        'LabelFecha
        '
        Me.LabelFecha.AutoSize = True
        Me.LabelFecha.Location = New System.Drawing.Point(95, 188)
        Me.LabelFecha.Name = "LabelFecha"
        Me.LabelFecha.Size = New System.Drawing.Size(37, 13)
        Me.LabelFecha.TabIndex = 1
        Me.LabelFecha.Text = "Fecha"
        '
        'LabelTotalVta
        '
        Me.LabelTotalVta.AutoSize = True
        Me.LabelTotalVta.Location = New System.Drawing.Point(95, 253)
        Me.LabelTotalVta.Name = "LabelTotalVta"
        Me.LabelTotalVta.Size = New System.Drawing.Size(65, 13)
        Me.LabelTotalVta.TabIndex = 2
        Me.LabelTotalVta.Text = "Total de Vta"
        '
        'LabelVentasTitulo
        '
        Me.LabelVentasTitulo.AutoSize = True
        Me.LabelVentasTitulo.Font = New System.Drawing.Font("Stencil", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelVentasTitulo.Location = New System.Drawing.Point(342, 18)
        Me.LabelVentasTitulo.Name = "LabelVentasTitulo"
        Me.LabelVentasTitulo.Size = New System.Drawing.Size(85, 22)
        Me.LabelVentasTitulo.TabIndex = 6
        Me.LabelVentasTitulo.Text = "Ventas"
        '
        'PanelVentas
        '
        Me.PanelVentas.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.PanelVentas.Controls.Add(Me.IconButtonHome)
        Me.PanelVentas.Controls.Add(Me.LabelVentasTitulo)
        Me.PanelVentas.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelVentas.Location = New System.Drawing.Point(0, 0)
        Me.PanelVentas.Name = "PanelVentas"
        Me.PanelVentas.Size = New System.Drawing.Size(800, 53)
        Me.PanelVentas.TabIndex = 7
        '
        'IconButtonHome
        '
        Me.IconButtonHome.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.IconButtonHome.IconChar = FontAwesome.Sharp.IconChar.HomeUser
        Me.IconButtonHome.IconColor = System.Drawing.Color.Black
        Me.IconButtonHome.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButtonHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButtonHome.Location = New System.Drawing.Point(670, 3)
        Me.IconButtonHome.Name = "IconButtonHome"
        Me.IconButtonHome.Size = New System.Drawing.Size(89, 46)
        Me.IconButtonHome.TabIndex = 7
        Me.IconButtonHome.Text = "Home"
        Me.IconButtonHome.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IconButtonHome.UseVisualStyleBackColor = False
        '
        'TextBoxNroCliente
        '
        Me.TextBoxNroCliente.Location = New System.Drawing.Point(195, 122)
        Me.TextBoxNroCliente.Name = "TextBoxNroCliente"
        Me.TextBoxNroCliente.Size = New System.Drawing.Size(143, 20)
        Me.TextBoxNroCliente.TabIndex = 8
        '
        'TextBoxFecha
        '
        Me.TextBoxFecha.Location = New System.Drawing.Point(195, 185)
        Me.TextBoxFecha.Name = "TextBoxFecha"
        Me.TextBoxFecha.Size = New System.Drawing.Size(143, 20)
        Me.TextBoxFecha.TabIndex = 9
        '
        'TextBoxTotalVta
        '
        Me.TextBoxTotalVta.Location = New System.Drawing.Point(195, 250)
        Me.TextBoxTotalVta.Name = "TextBoxTotalVta"
        Me.TextBoxTotalVta.Size = New System.Drawing.Size(143, 20)
        Me.TextBoxTotalVta.TabIndex = 10
        '
        'TextBoxBuscarVta
        '
        Me.TextBoxBuscarVta.Location = New System.Drawing.Point(487, 122)
        Me.TextBoxBuscarVta.Name = "TextBoxBuscarVta"
        Me.TextBoxBuscarVta.Size = New System.Drawing.Size(143, 20)
        Me.TextBoxBuscarVta.TabIndex = 11
        '
        'IconButtonAgregarVta
        '
        Me.IconButtonAgregarVta.IconChar = FontAwesome.Sharp.IconChar.None
        Me.IconButtonAgregarVta.IconColor = System.Drawing.Color.Black
        Me.IconButtonAgregarVta.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButtonAgregarVta.Location = New System.Drawing.Point(57, 375)
        Me.IconButtonAgregarVta.Name = "IconButtonAgregarVta"
        Me.IconButtonAgregarVta.Size = New System.Drawing.Size(75, 23)
        Me.IconButtonAgregarVta.TabIndex = 12
        Me.IconButtonAgregarVta.Text = "Agregar"
        Me.IconButtonAgregarVta.UseVisualStyleBackColor = True
        '
        'IconButtonModificarVta
        '
        Me.IconButtonModificarVta.IconChar = FontAwesome.Sharp.IconChar.None
        Me.IconButtonModificarVta.IconColor = System.Drawing.Color.Black
        Me.IconButtonModificarVta.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButtonModificarVta.Location = New System.Drawing.Point(147, 375)
        Me.IconButtonModificarVta.Name = "IconButtonModificarVta"
        Me.IconButtonModificarVta.Size = New System.Drawing.Size(75, 23)
        Me.IconButtonModificarVta.TabIndex = 13
        Me.IconButtonModificarVta.Text = "Modificar"
        Me.IconButtonModificarVta.UseVisualStyleBackColor = True
        '
        'IconButtonEliminarVta
        '
        Me.IconButtonEliminarVta.IconChar = FontAwesome.Sharp.IconChar.None
        Me.IconButtonEliminarVta.IconColor = System.Drawing.Color.Black
        Me.IconButtonEliminarVta.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButtonEliminarVta.Location = New System.Drawing.Point(239, 375)
        Me.IconButtonEliminarVta.Name = "IconButtonEliminarVta"
        Me.IconButtonEliminarVta.Size = New System.Drawing.Size(75, 23)
        Me.IconButtonEliminarVta.TabIndex = 14
        Me.IconButtonEliminarVta.Text = "Eliminar"
        Me.IconButtonEliminarVta.UseVisualStyleBackColor = True
        '
        'IconButtonBuscarVta
        '
        Me.IconButtonBuscarVta.IconChar = FontAwesome.Sharp.IconChar.None
        Me.IconButtonBuscarVta.IconColor = System.Drawing.Color.Black
        Me.IconButtonBuscarVta.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButtonBuscarVta.Location = New System.Drawing.Point(684, 122)
        Me.IconButtonBuscarVta.Name = "IconButtonBuscarVta"
        Me.IconButtonBuscarVta.Size = New System.Drawing.Size(75, 23)
        Me.IconButtonBuscarVta.TabIndex = 15
        Me.IconButtonBuscarVta.Text = "Buscar"
        Me.IconButtonBuscarVta.UseVisualStyleBackColor = True
        '
        'DgvVentas
        '
        Me.DgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvVentas.Location = New System.Drawing.Point(364, 156)
        Me.DgvVentas.Name = "DgvVentas"
        Me.DgvVentas.Size = New System.Drawing.Size(435, 293)
        Me.DgvVentas.TabIndex = 16
        '
        'LabelNroVta
        '
        Me.LabelNroVta.AutoSize = True
        Me.LabelNroVta.Location = New System.Drawing.Point(95, 306)
        Me.LabelNroVta.Name = "LabelNroVta"
        Me.LabelNroVta.Size = New System.Drawing.Size(90, 13)
        Me.LabelNroVta.TabIndex = 17
        Me.LabelNroVta.Text = "Numero de Venta"
        '
        'TextBoxNroDeVta
        '
        Me.TextBoxNroDeVta.Location = New System.Drawing.Point(195, 303)
        Me.TextBoxNroDeVta.Name = "TextBoxNroDeVta"
        Me.TextBoxNroDeVta.Size = New System.Drawing.Size(143, 20)
        Me.TextBoxNroDeVta.TabIndex = 18
        '
        'Ventas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TextBoxNroDeVta)
        Me.Controls.Add(Me.LabelNroVta)
        Me.Controls.Add(Me.DgvVentas)
        Me.Controls.Add(Me.IconButtonBuscarVta)
        Me.Controls.Add(Me.IconButtonEliminarVta)
        Me.Controls.Add(Me.IconButtonModificarVta)
        Me.Controls.Add(Me.IconButtonAgregarVta)
        Me.Controls.Add(Me.TextBoxBuscarVta)
        Me.Controls.Add(Me.TextBoxTotalVta)
        Me.Controls.Add(Me.TextBoxFecha)
        Me.Controls.Add(Me.TextBoxNroCliente)
        Me.Controls.Add(Me.PanelVentas)
        Me.Controls.Add(Me.LabelTotalVta)
        Me.Controls.Add(Me.LabelFecha)
        Me.Controls.Add(Me.LabelClienteId)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Ventas"
        Me.Text = "Ventas"
        Me.PanelVentas.ResumeLayout(False)
        Me.PanelVentas.PerformLayout()
        CType(Me.DgvVentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelClienteId As Label
    Friend WithEvents LabelFecha As Label
    Friend WithEvents LabelTotalVta As Label
    Friend WithEvents LabelVentasTitulo As Label
    Friend WithEvents PanelVentas As Panel
    Friend WithEvents TextBoxNroCliente As TextBox
    Friend WithEvents TextBoxFecha As TextBox
    Friend WithEvents TextBoxTotalVta As TextBox
    Friend WithEvents TextBoxBuscarVta As TextBox
    Friend WithEvents IconButtonAgregarVta As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButtonModificarVta As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButtonEliminarVta As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButtonBuscarVta As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButtonHome As FontAwesome.Sharp.IconButton
    Friend WithEvents DgvVentas As DataGridView
    Friend WithEvents LabelNroVta As Label
    Friend WithEvents TextBoxNroDeVta As TextBox
End Class
