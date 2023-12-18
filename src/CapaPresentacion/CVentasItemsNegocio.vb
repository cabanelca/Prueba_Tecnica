Imports System.Data.SqlClient
Imports System.Configuration
Public Class CVentasItemsNegocio
    Public Function GuardarrVtas(ByVal nuevo As CEVentasItems)
        Dim conexion As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("StrCon").ConnectionString)
        Dim comando As SqlCommand = New SqlCommand()

        Try
            comando.CommandType = System.Data.CommandType.Text
            comando.CommandText = "INSERT INTO Ventas (Id, IDVenta, IDProducto,PrecioUnitario, Precio Total) VALUES (@Id, @IDVenta, @IDProducto, @PrecioUnitario, @PrecioTotal)"
            comando.Connection = conexion

            comando.Parameters.AddWithValue("@Id", nuevo.Id)
            comando.Parameters.AddWithValue("@IDCliente", Convert.ToInt32(nuevo.IDVenta))
            comando.Parameters.AddWithValue("@Fecha", Convert.ToInt32(nuevo.IDProducto))
            comando.Parameters.AddWithValue("@Total", Convert.ToInt32(nuevo.IDProducto))
            comando.Parameters.AddWithValue("@NroVta", Convert.ToDecimal(nuevo.PrecioUnitario))
            comando.Parameters.AddWithValue("@NroVta", Convert.ToDecimal(nuevo.PrecioTotal))


            conexion.Open()
            comando.ExecuteNonQuery()

        Catch ex As Exception
            Throw ex
        Finally

            conexion.Close()
        End Try
    End Function
End Class
