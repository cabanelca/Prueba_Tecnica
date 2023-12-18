Imports System.Data.SqlClient
Imports System.Configuration
Public Class CVentasItemsNegocio
    Public Function GuardarVtasItems(ByVal nuevo As CEVentasItems)
        Dim conexion As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("StrCon").ConnectionString)
        Dim comando As SqlCommand = New SqlCommand()

        Try
            comando.CommandType = System.Data.CommandType.Text
            comando.CommandText = "INSERT INTO VentasItems (IDVenta, IDProducto,PrecioUnitario,Cantidad, PrecioTotal) VALUES (@IDVenta, @IDProducto, @PrecioUnitario,@Cantidad, @PrecioTotal)"
            comando.Connection = conexion


            comando.Parameters.AddWithValue("@IDVenta", Convert.ToInt32(nuevo.IDVenta))
            comando.Parameters.AddWithValue("@IDProducto", Convert.ToInt32(nuevo.IDProducto))
            comando.Parameters.AddWithValue("@PrecioUnitario", Convert.ToDecimal(nuevo.PrecioUnitario))
            comando.Parameters.AddWithValue("@Cantidad", Convert.ToDecimal(nuevo.Cantidad))
            comando.Parameters.AddWithValue("@PrecioTotal", Convert.ToDecimal(nuevo.PrecioTotal))



            conexion.Open()
            comando.ExecuteNonQuery()

        Catch ex As Exception
            Throw ex
        Finally

            conexion.Close()
        End Try
    End Function
End Class
