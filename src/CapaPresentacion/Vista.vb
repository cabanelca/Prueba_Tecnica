Imports System.Data.SqlClient
Public Class Vista
    Dim conexion As New SqlConnection
    Dim comando As New SqlCommand
    Private Sub Vista_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub IconButtonProductos_Click(sender As Object, e As EventArgs) Handles IconButtonProductos.Click
        Productos.ShowDialog()

    End Sub

    Private Sub IconButtonClientes_Click(sender As Object, e As EventArgs) Handles IconButtonClientes.Click
        Clientes.ShowDialog()
    End Sub

    Private Sub IconButtonVentas_Click(sender As Object, e As EventArgs) Handles IconButtonVentas.Click
        Ventas.ShowDialog()
    End Sub
End Class
