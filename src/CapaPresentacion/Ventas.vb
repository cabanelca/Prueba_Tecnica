
Imports System.Configuration
Imports System.Data.SqlClient
Public Class Ventas

    Dim ventaId As Integer
    Dim comando As New SqlCommand
    Dim productosel As CEProducto = New CEProducto()
    Dim totalVta As Decimal
    Private Sub LimpiarVtas()
        'ComboBoxIDCliente.Clear()
        TextBoxFecha.Clear()
        TextBoxTotalVta.Clear()
        TextBoxNroDeVta.Clear()

    End Sub

    Private Sub IconButtonHome_Click(sender As Object, e As EventArgs) Handles IconButtonHome.Click
        Close()
    End Sub

    Private Sub Ventas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conexion As New SqlConnection(ConfigurationManager.ConnectionStrings("StrCon").ConnectionString)
        Dim producto As CVentasNegocio = New CVentasNegocio()
        Dim cliente As CClienteNegocio = New CClienteNegocio()
        Dim clientes = cliente.ListarClientes()
        For Each cli As CECliente In clientes
            ComboBoxIDCliente.Items.Add(cli.Id)
        Next
        CargarColumnaGrillaProd()
        ' ComboBoxIDCliente.DataSource = 'clientes

        ' DgvVentas.DataSource = producto.ListarVentas()
    End Sub
    Private Sub CargarColumnaGrillaProd()
        DgvVentas.Columns.Add("Nombre", "Nombre")
        DgvVentas.Columns.Add("Id", "Codigo Producto")
        DgvVentas.Columns.Add("Precio", "Precio")

    End Sub



    Private Sub IconButtonModificarVta_Click(sender As Object, e As EventArgs) Handles IconButtonModificarVta.Click
        Dim venta As CEVentas = New CEVentas()
        Dim agregar As CVentasNegocio = New CVentasNegocio()

        DgvVentas.DataSource = agregar.ListarVentas()
        Try
            venta.IdCliente = CInt(ComboBoxIDCliente.Text)
            venta.Fecha = CDate(TextBoxFecha.Text)
            venta.Total = CDec(TextBoxTotalVta.Text)
            venta.NroVta = TextBoxNroDeVta.Text


            agregar.ModificarDatosVentas(venta)
            MessageBox.Show("Modificaste el producto")

            LimpiarVtas()
            Close()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub IconButtonEliminarVta_Click(sender As Object, e As EventArgs) Handles IconButtonEliminarVta.Click
        Dim venta As CEVentas = New CEVentas()
        Dim agregar As CVentasNegocio = New CVentasNegocio()

        DgvVentas.DataSource = agregar.ListarVentas()
        Try
            venta.Id = ventaId
            agregar.EliminarVtas(venta)
            MessageBox.Show("Eliminado")

            LimpiarVtas()
            Close()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub DgvVentas_Click(sender As Object, e As EventArgs) Handles DgvVentas.Click
        If DgvVentas.CurrentRow Is Nothing Then Return
        ventaId = CInt(DgvVentas.CurrentRow.Cells("ID").Value)
        ComboBoxIDCliente.Text = DgvVentas.CurrentRow.Cells("IDCliente").Value
        TextBoxFecha.Text = DgvVentas.CurrentRow.Cells("Fecha").Value
        TextBoxTotalVta.Text = DgvVentas.CurrentRow.Cells("Total").Value
        TextBoxNroDeVta.Text = DgvVentas.CurrentRow.Cells("NroVta").Value
    End Sub

    Private Sub TextBoxBuscarVta_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBoxBuscarPro_TextChanged(sender As Object, e As EventArgs) Handles TextBoxBuscarPro.TextChanged
        Dim filtro = TextBoxBuscarPro.Text
        If filtro.Length < 3 Then Return
        Dim listaProducto As List(Of CEProducto) = New List(Of CEProducto)()
        Dim producto As CProductosNegocio = New CProductosNegocio()
        listaProducto = producto.ListarProductos()
        Dim productofil = listaProducto.FirstOrDefault(Function(x) x.Nombre.ToUpper().Contains(filtro.ToUpper()))
        If productofil Is Nothing Then Return
        TextBoxProducNoEditab.Text = productofil.Nombre
        productosel = productofil

    End Sub


    Private Sub IconButtonAgregarProd_Click(sender As Object, e As EventArgs) Handles IconButtonAgregarProd.Click


        DgvVentas.Rows.Add()
        Dim nuevaPosicion As Integer = DgvVentas.Rows.Count - 1
        DgvVentas(0, nuevaPosicion).Value = productosel.Nombre
        DgvVentas(1, nuevaPosicion).Value = productosel.Id
        DgvVentas(2, nuevaPosicion).Value = productosel.Precio
        totalVta += productosel.Precio
        TextBoxTotalVta.Text = totalVta
    End Sub

    Private Sub IconButtonGuardarVta_Click(sender As Object, e As EventArgs) Handles IconButtonGuardarVta.Click
        Dim venta As CEVentas = New CEVentas()
        Dim agregar As CVentasNegocio = New CVentasNegocio()
        Dim idVenta As Integer
        venta.Fecha = DateTime.Now
        venta.Total = totalVta
        venta.NroVta = TextBoxNroDeVta.Text
        venta.IdCliente = ComboBoxIDCliente.Text
        idVenta = agregar.agregarVtas(venta)
    End Sub

    Private Sub TextBoxTotalVta_TextChanged(sender As Object, e As EventArgs) Handles TextBoxTotalVta.TextChanged

    End Sub
End Class