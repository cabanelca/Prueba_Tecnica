Imports System.Data.SqlClient
Imports System.Configuration
Imports MS.Internal
Public Class CVentasNegocio

    Public Function ListarVentas() As List(Of CEVentas)

        Dim lista As List(Of CEVentas) = New List(Of CEVentas)()
        Dim conexion As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("StrCon").ConnectionString)
        Dim comando As SqlCommand = New SqlCommand()
        Dim lector As SqlDataReader

        Try

            comando.CommandType = System.Data.CommandType.Text
            comando.CommandText = "Select Id, IDCliente, Fecha, Total, NroVta From Ventas"
            comando.Connection = conexion
            conexion.Open()
            lector = comando.ExecuteReader()

            While lector.Read()
                Dim aux As CEVentas = New CEVentas()
                aux.Id = CInt(lector("Id"))
                aux.IdCliente = CInt(lector("IDCliente"))
                aux.Fecha = CDate(lector("Fecha"))
                aux.Total = CDec(lector("Total"))
                aux.NroVta = CInt(lector("NroVta"))

                lista.Add(aux)
            End While


            Return lista
        Catch ex As Exception
            Throw ex
        Finally
            conexion.Close()
        End Try

    End Function



    Public Function agregarVtas(ByVal nuevo As CEVentas) As Integer

        Dim conexion As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("StrCon").ConnectionString)
        Dim comando As SqlCommand = New SqlCommand()
        Dim id As Integer
        Try
            comando.CommandType = System.Data.CommandType.Text
            comando.CommandText = "INSERT INTO Ventas (IDCliente, Fecha,Total, NroVta) VALUES (@IDCliente, @Fecha, @Total, @NroVta); select scope_identity()"
            comando.Connection = conexion


            comando.Parameters.AddWithValue("@IDCliente", Convert.ToInt32(nuevo.IdCliente))
            comando.Parameters.AddWithValue("@Fecha", Convert.ToDateTime(nuevo.Fecha))
            comando.Parameters.AddWithValue("@Total", Convert.ToDecimal(nuevo.Total))
            comando.Parameters.AddWithValue("@NroVta", Convert.ToInt32(nuevo.NroVta))

            conexion.Open()
            id = comando.ExecuteScalar()

        Catch ex As Exception
            Throw ex
        Finally

            conexion.Close()
        End Try
        Return id
    End Function
    Public Function ModificarDatosVentas(ByVal nuevo As CEVentas)

        Dim conexion As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("StrCon").ConnectionString)

        Dim consulta As String = "UPDATE Ventas Set IDCliente=@IDCliente, Fecha=@Fecha, Total=@Total, NroVta=@NroVta WHERE ID=@ID"
        Dim comando As New SqlCommand(consulta, conexion)
        comando.Parameters.AddWithValue("@Id", nuevo.Id)
        comando.Parameters.AddWithValue("@IDCliente", Convert.ToInt32(nuevo.IdCliente))
        comando.Parameters.AddWithValue("@Fecha", Convert.ToDateTime(nuevo.Fecha))
        comando.Parameters.AddWithValue("@Total", Convert.ToDecimal(nuevo.Total))
        comando.Parameters.AddWithValue("@NroVta", nuevo.NroVta)
        conexion.Open()
        comando.ExecuteNonQuery()
        conexion.Close()
        ListarVentas()

    End Function
    Public Function EliminarVtas(ByVal eliminar As CEVentas)

        Dim conexion As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("StrCon").ConnectionString)

        Dim consulta As String = "DELETE  FROM Ventas WHERE ID=@ID"
        Dim comando As New SqlCommand(consulta, conexion)

        comando.Parameters.AddWithValue("@ID", Convert.ToInt32(eliminar.Id))
        conexion.Open()
        comando.ExecuteNonQuery()
        conexion.Close()

        ListarVentas()

    End Function


End Class
