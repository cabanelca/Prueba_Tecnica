Imports System.Configuration
Imports System.Data.SqlClient
Public Class Clientes
    Dim clienteId As Integer
    Dim comando As New SqlCommand
    Private Sub LimpiarDatosClientes()
        TextBoxCliente.Clear()
        TextBoxCorreo.Clear()
        TextBoxTelefono.Clear()

    End Sub
    Private Sub Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conexion As New SqlConnection(ConfigurationManager.ConnectionStrings("StrCon").ConnectionString)
        Dim producto As CClienteNegocio = New CClienteNegocio()

        DgvClientes.DataSource = producto.ListarClientes()

    End Sub
    Private Sub PanelCliente_Paint(sender As Object, e As PaintEventArgs) Handles PanelCliente.Paint

    End Sub

    Private Sub IconButtonHome_Click(sender As Object, e As EventArgs) Handles IconButtonHome.Click
        Close()
    End Sub

    Private Sub IconButtonClienteAgregar_Click(sender As Object, e As EventArgs) Handles IconButtonClienteAgregar.Click
        Dim cliente As CECliente = New CECliente()
        Dim agregar As CClienteNegocio = New CClienteNegocio()
        Dim conexion As New SqlConnection(ConfigurationManager.ConnectionStrings("StrCon").ConnectionString)
        Try
            cliente.Cliente = TextBoxCliente.Text
            cliente.Telefono = CInt(TextBoxTelefono.Text)
            cliente.Correo = TextBoxCorreo.Text


            agregar.agregarClientes(cliente)
            MessageBox.Show("Agregaste el producto")

            LimpiarDatosClientes()

            Close()
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub IconButtonClienteModif_Click(sender As Object, e As EventArgs) Handles IconButtonClienteModif.Click
        Dim cliente As CECliente = New CECliente()
        Dim agregar As CClienteNegocio = New CClienteNegocio()

        DgvClientes.DataSource = agregar.ListarClientes()
        Try
            cliente.Id = clienteId
            cliente.Cliente = TextBoxCliente.Text
            cliente.Telefono = CInt(TextBoxTelefono.Text)
            cliente.Correo = TextBoxCorreo.Text


            agregar.ModificarDatosClientes(cliente)
            MessageBox.Show("Modificaste el producto")

            LimpiarDatosClientes()
            Close()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub IconButtonClienteEliminar_Click(sender As Object, e As EventArgs) Handles IconButtonClienteEliminar.Click
        Dim cliente As CECliente = New CECliente()
        Dim agregar As CClienteNegocio = New CClienteNegocio()

        DgvClientes.DataSource = agregar.ListarClientes()
        Try
            cliente.Id = clienteId
            agregar.EliminarClientes(cliente)
            MessageBox.Show("Eliminado")

            LimpiarDatosClientes()
            Close()
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub DgvClientes_Click(sender As Object, e As EventArgs) Handles DgvClientes.Click
        If DgvClientes.CurrentRow Is Nothing Then Return
        clienteId = CInt(DgvClientes.CurrentRow.Cells("ID").Value)
        TextBoxCliente.Text = DgvClientes.CurrentRow.Cells("Cliente").Value
        TextBoxTelefono.Text = DgvClientes.CurrentRow.Cells("Telefono").Value

        TextBoxCorreo.Text = DgvClientes.CurrentRow.Cells("Correo").Value

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        Dim filtro = TextBox4.Text
        If filtro.Length < 3 Then Return
        Dim listaProducto As List(Of CEProducto) = New List(Of CEProducto)()
        Dim producto As CProductosNegocio = New CProductosNegocio()
        listaProducto = producto.ListarProductos()
        Dim listaFiltrada = listaProducto.FindAll(Function(x) x.Nombre.ToUpper().Contains(filtro.ToUpper()))
        DgvClientes.DataSource = Nothing
        DgvClientes.DataSource = listaFiltrada
    End Sub
End Class