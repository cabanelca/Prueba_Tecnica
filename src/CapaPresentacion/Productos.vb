﻿Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Configuration




Public Class Productos

    Dim productoId As Integer

    Dim lista As List(Of CEProducto) = New List(Of CEProducto)()

    Private Sub LimpiarDatos()
        TextBoxNombre.Clear()
        TextBoxPrecio.Clear()
        TextBoxCategoria.Clear()
        TextBoxCantidad.Clear()
    End Sub


    Public Sub Productos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim producto As CProductosNegocio = New CProductosNegocio()
        DtvProductos.DataSource = producto.ListarProductos()



    End Sub
    Public Sub IconButtonAgregar_Click(sender As Object, e As EventArgs) Handles IconButtonAgregar.Click
        Dim conexion As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("StrCon").ConnectionString)
        Dim producto As CEProducto = New CEProducto()
        Dim agregar As CProductosNegocio = New CProductosNegocio()

        Try
            producto.Nombre = TextBoxNombre.Text
            producto.Precio = CDbl(TextBoxPrecio.Text)
            producto.Categoria = TextBoxCategoria.Text
            producto.Cantidad = CInt(TextBoxCantidad.Text)

            agregar.agregarProductos(producto)
            MessageBox.Show("Agregaste el producto")
            LimpiarDatos()
            Close()
        Catch ex As Exception
            Throw ex
        End Try


    End Sub

    Public Sub IconButtonHome_Click(sender As Object, e As EventArgs) Handles IconButtonHome.Click
        Close()
    End Sub

    Public Sub IconButtonModificar_Click(sender As Object, e As EventArgs) Handles IconButtonModificar.Click
        Dim producto As CEProducto = New CEProducto()
        Dim agregar As CProductosNegocio = New CProductosNegocio()

        DtvProductos.DataSource = agregar.ListarProductos()
        Try
            producto.Id = productoId
            producto.Nombre = TextBoxNombre.Text
            producto.Precio = CDbl(TextBoxPrecio.Text)
            producto.Categoria = TextBoxCategoria.Text
            producto.Cantidad = CInt(TextBoxCantidad.Text)

            agregar.ModificarDatosProductos(producto)
            MessageBox.Show("Modificaste el producto")

            LimpiarDatos()
            Close()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub IconButtonEliminar_Click(sender As Object, e As EventArgs) Handles IconButtonEliminar.Click
        Dim producto As CEProducto = New CEProducto()
        Dim agregar As CProductosNegocio = New CProductosNegocio()

        DtvProductos.DataSource = agregar.ListarProductos()
        Try
            producto.Id = productoId
            agregar.EliminarDatos(producto)
            MessageBox.Show("Eliminado")

            LimpiarDatos()
            Close()
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub IconButtonBuscar_Click(sender As Object, e As EventArgs) Handles IconButtonBuscar.Click



    End Sub
    Private Sub DtvProductos_Click(sender As Object, e As EventArgs) Handles DtvProductos.Click
        If DtvProductos.CurrentRow Is Nothing Then Return
        productoId = CInt(DtvProductos.CurrentRow.Cells("ID").Value)
        TextBoxNombre.Text = DtvProductos.CurrentRow.Cells("Nombre").Value
        TextBoxPrecio.Text = DtvProductos.CurrentRow.Cells("Precio").Value

        TextBoxCategoria.Text = DtvProductos.CurrentRow.Cells("Categoria").Value
        TextBoxCantidad.Text = DtvProductos.CurrentRow.Cells("Cantidad").Value

    End Sub

    Private Sub TextBoxBuscar_TextChanged(sender As Object, e As EventArgs) Handles TextBoxBuscar.TextChanged
        Dim filtro = TextBoxBuscar.Text
        If filtro.Length < 3 Then Return
        Dim listaProducto As List(Of CEProducto) = New List(Of CEProducto)()
        Dim producto As CProductosNegocio = New CProductosNegocio()
        listaProducto = producto.ListarProductos()
        Dim listaFiltrada = listaProducto.FindAll(Function(x) x.Nombre.ToUpper().Contains(filtro.ToUpper()))
        DtvProductos.DataSource = Nothing
        DtvProductos.DataSource = listaFiltrada
    End Sub
End Class