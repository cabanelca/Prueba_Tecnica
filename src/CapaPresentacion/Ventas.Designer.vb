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
        Me.TextBoxFecha = New System.Windows.Forms.TextBox()
        Me.TextBoxTotalVta = New System.Windows.Forms.TextBox()
        Me.TextBoxBuscarPro = New System.Windows.Forms.TextBox()
        Me.IconButtonGuardarVta = New FontAwesome.Sharp.IconButton()
        Me.IconButtonModificarVta = New FontAwesome.Sharp.IconButton()
        Me.IconButtonEliminarVta = New FontAwesome.Sharp.IconButton()
        Me.IconButtonAgregarProd = New FontAwesome.Sharp.IconButton()
        Me.DgvVentas = New System.Windows.Forms.DataGridView()
        Me.LabelNroVta = New System.Windows.Forms.Label()
        Me.TextBoxNroDeVta = New System.Windows.Forms.TextBox()
        Me.ComboBoxIDCliente = New System.Windows.Forms.ComboBox()
        Me.TextBoxProducNoEditab = New System.Windows.Forms.TextBox()
        Me.PanelVentas.SuspendLayout()
        CType(Me.DgvVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelClienteId
        '
        Me.LabelClienteId.AutoSize = True
        Me.LabelClienteId.Location = New System.Drawing.Point(3, 73)
        Me.LabelClienteId.Name = "LabelClienteId"
        Me.LabelClienteId.Size = New System.Drawing.Size(56, 13)
        Me.LabelClienteId.TabIndex = 0
        Me.LabelClienteId.Text = "NroCliente"
        '
        'LabelFecha
        '
        Me.LabelFecha.AutoSize = True
        Me.LabelFecha.Location = New System.Drawing.Point(589, 124)
        Me.LabelFecha.Name = "LabelFecha"
        Me.LabelFecha.Size = New System.Drawing.Size(37, 13)
        Me.LabelFecha.TabIndex = 1
        Me.LabelFecha.Text = "Fecha"
        '
        'LabelTotalVta
        '
        Me.LabelTotalVta.AutoSize = True
        Me.LabelTotalVta.Location = New System.Drawing.Point(561, 399)
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
        'TextBoxFecha
        '
        Me.TextBoxFecha.Location = New System.Drawing.Point(645, 121)
        Me.TextBoxFecha.Name = "TextBoxFecha"
        Me.TextBoxFecha.Size = New System.Drawing.Size(143, 20)
        Me.TextBoxFecha.TabIndex = 9
        '
        'TextBoxTotalVta
        '
        Me.TextBoxTotalVta.Location = New System.Drawing.Point(645, 396)
        Me.TextBoxTotalVta.Name = "TextBoxTotalVta"
        Me.TextBoxTotalVta.Size = New System.Drawing.Size(143, 20)
        Me.TextBoxTotalVta.TabIndex = 10
        '
        'TextBoxBuscarPro
        '
        Me.TextBoxBuscarPro.Location = New System.Drawing.Point(87, 145)
        Me.TextBoxBuscarPro.Name = "TextBoxBuscarPro"
        Me.TextBoxBuscarPro.Size = New System.Drawing.Size(143, 20)
        Me.TextBoxBuscarPro.TabIndex = 11
        '
        'IconButtonGuardarVta
        '
        Me.IconButtonGuardarVta.IconChar = FontAwesome.Sharp.IconChar.None
        Me.IconButtonGuardarVta.IconColor = System.Drawing.Color.Black
        Me.IconButtonGuardarVta.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButtonGuardarVta.Location = New System.Drawing.Point(6, 415)
        Me.IconButtonGuardarVta.Name = "IconButtonGuardarVta"
        Me.IconButtonGuardarVta.Size = New System.Drawing.Size(75, 23)
        Me.IconButtonGuardarVta.TabIndex = 12
        Me.IconButtonGuardarVta.Text = "Guardar"
        Me.IconButtonGuardarVta.UseVisualStyleBackColor = True
        '
        'IconButtonModificarVta
        '
        Me.IconButtonModificarVta.IconChar = FontAwesome.Sharp.IconChar.None
        Me.IconButtonModificarVta.IconColor = System.Drawing.Color.Black
        Me.IconButtonModificarVta.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButtonModificarVta.Location = New System.Drawing.Point(87, 415)
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
        Me.IconButtonEliminarVta.Location = New System.Drawing.Point(168, 415)
        Me.IconButtonEliminarVta.Name = "IconButtonEliminarVta"
        Me.IconButtonEliminarVta.Size = New System.Drawing.Size(75, 23)
        Me.IconButtonEliminarVta.TabIndex = 14
        Me.IconButtonEliminarVta.Text = "Eliminar"
        Me.IconButtonEliminarVta.UseVisualStyleBackColor = True
        '
        'IconButtonAgregarProd
        '
        Me.IconButtonAgregarProd.IconChar = FontAwesome.Sharp.IconChar.None
        Me.IconButtonAgregarProd.IconColor = System.Drawing.Color.Black
        Me.IconButtonAgregarProd.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButtonAgregarProd.Location = New System.Drawing.Point(6, 142)
        Me.IconButtonAgregarProd.Name = "IconButtonAgregarProd"
        Me.IconButtonAgregarProd.Size = New System.Drawing.Size(75, 23)
        Me.IconButtonAgregarProd.TabIndex = 15
        Me.IconButtonAgregarProd.Text = "Agregar"
        Me.IconButtonAgregarProd.UseVisualStyleBackColor = True
        '
        'DgvVentas
        '
        Me.DgvVentas.AllowUserToAddRows = False
        Me.DgvVentas.AllowUserToDeleteRows = False
        Me.DgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvVentas.Location = New System.Drawing.Point(0, 171)
        Me.DgvVentas.Name = "DgvVentas"
        Me.DgvVentas.ReadOnly = True
        Me.DgvVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvVentas.Size = New System.Drawing.Size(800, 209)
        Me.DgvVentas.TabIndex = 16
        '
        'LabelNroVta
        '
        Me.LabelNroVta.AutoSize = True
        Me.LabelNroVta.Location = New System.Drawing.Point(549, 69)
        Me.LabelNroVta.Name = "LabelNroVta"
        Me.LabelNroVta.Size = New System.Drawing.Size(90, 13)
        Me.LabelNroVta.TabIndex = 17
        Me.LabelNroVta.Text = "Numero de Venta"
        '
        'TextBoxNroDeVta
        '
        Me.TextBoxNroDeVta.Location = New System.Drawing.Point(645, 66)
        Me.TextBoxNroDeVta.Name = "TextBoxNroDeVta"
        Me.TextBoxNroDeVta.Size = New System.Drawing.Size(143, 20)
        Me.TextBoxNroDeVta.TabIndex = 18
        '
        'ComboBoxIDCliente
        '
        Me.ComboBoxIDCliente.FormattingEnabled = True
        Me.ComboBoxIDCliente.Location = New System.Drawing.Point(87, 73)
        Me.ComboBoxIDCliente.Name = "ComboBoxIDCliente"
        Me.ComboBoxIDCliente.Size = New System.Drawing.Size(143, 21)
        Me.ComboBoxIDCliente.TabIndex = 19
        '
        'TextBoxProducNoEditab
        '
        Me.TextBoxProducNoEditab.Enabled = False
        Me.TextBoxProducNoEditab.Location = New System.Drawing.Point(248, 144)
        Me.TextBoxProducNoEditab.Name = "TextBoxProducNoEditab"
        Me.TextBoxProducNoEditab.ReadOnly = True
        Me.TextBoxProducNoEditab.Size = New System.Drawing.Size(240, 20)
        Me.TextBoxProducNoEditab.TabIndex = 20
        '
        'Ventas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TextBoxProducNoEditab)
        Me.Controls.Add(Me.ComboBoxIDCliente)
        Me.Controls.Add(Me.TextBoxNroDeVta)
        Me.Controls.Add(Me.LabelNroVta)
        Me.Controls.Add(Me.DgvVentas)
        Me.Controls.Add(Me.IconButtonAgregarProd)
        Me.Controls.Add(Me.IconButtonEliminarVta)
        Me.Controls.Add(Me.IconButtonModificarVta)
        Me.Controls.Add(Me.IconButtonGuardarVta)
        Me.Controls.Add(Me.TextBoxBuscarPro)
        Me.Controls.Add(Me.TextBoxTotalVta)
        Me.Controls.Add(Me.TextBoxFecha)
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
    Friend WithEvents TextBoxFecha As TextBox
    Friend WithEvents TextBoxTotalVta As TextBox
    Friend WithEvents TextBoxBuscarPro As TextBox
    Friend WithEvents IconButtonGuardarVta As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButtonModificarVta As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButtonEliminarVta As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButtonAgregarProd As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButtonHome As FontAwesome.Sharp.IconButton
    Friend WithEvents DgvVentas As DataGridView
    Friend WithEvents LabelNroVta As Label
    Friend WithEvents TextBoxNroDeVta As TextBox
    Friend WithEvents ComboBoxIDCliente As ComboBox
    Friend WithEvents TextBoxProducNoEditab As TextBox
End Class
