
Imports System.Data.SqlClient
Public Class Ventas
    Dim conexion As New SqlConnection
    Dim comando As New SqlCommand

    Private Sub IconButtonHome_Click(sender As Object, e As EventArgs) Handles IconButtonHome.Click
        Close()
    End Sub

    Private Sub Ventas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class