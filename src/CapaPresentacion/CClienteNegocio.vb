Imports System.Data.SqlClient
Imports System.Configuration
Public Class CClienteNegocio

    Public Function ListarClientes() As List(Of CECliente)

        Dim lista As List(Of CECliente) = New List(Of CECliente)()
        Dim conexion As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("StrCon").ConnectionString)
        Dim comando As SqlCommand = New SqlCommand()
        Dim lector As SqlDataReader

        Try

            comando.CommandType = System.Data.CommandType.Text
            comando.CommandText = "Select Id, Cliente, Telefono, COrreo From Clientes"
            comando.Connection = conexion
            conexion.Open()
            lector = comando.ExecuteReader()

            While lector.Read()
                Dim aux As CECliente = New CECliente()
                aux.Id = CInt(lector("Id"))
                aux.Cliente = CStr(lector("Cliente"))
                aux.Telefono = CInt(lector("Telefono"))
                aux.Correo = CStr(lector("Correo"))

                lista.Add(aux)
            End While


            Return lista
        Catch ex As Exception
            Throw ex
        Finally
            conexion.Close()
        End Try

    End Function



    Public Function agregarClientes(ByVal nuevo As CECliente)

        Dim conexion As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("StrCon").ConnectionString)
        Dim comando As SqlCommand = New SqlCommand()

        Try
            comando.CommandType = System.Data.CommandType.Text
            comando.CommandText = "INSERT INTO Clientes (Cliente, Telefono, Correo) VALUES (@Cliente, @Telefono, @Correo)"
            comando.Connection = conexion

            comando.Parameters.AddWithValue("@Cliente", nuevo.Cliente)
            comando.Parameters.AddWithValue("@Telefono", Convert.ToInt32(nuevo.Telefono))
            comando.Parameters.AddWithValue("@Correo", nuevo.Correo)


            conexion.Open()
            comando.ExecuteNonQuery()
            ListarClientes()
        Catch ex As Exception
            Throw ex
        Finally

            conexion.Close()
        End Try
    End Function
    Public Function ModificarDatosClientes(ByVal modificar As CECliente)

        Dim conexion As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("StrCon").ConnectionString)

        Dim consulta As String = "UPDATE Clientes Set Clinte=@Nombre, Telefono=@Telefono, Correo=@Correo WHERE ID=@ID"
        Dim command As New SqlCommand(consulta)
        command.Parameters.AddWithValue("@Nombre", modificar.Cliente)
        command.Parameters.AddWithValue("@Telefono", Convert.ToInt32(modificar.Telefono))
        command.Parameters.AddWithValue("@Correo", modificar.Correo)
        command.Parameters.AddWithValue("@ID", Convert.ToInt32(modificar.Id))

        command.Parameters.AddWithValue("@ID", Convert.ToInt32(modificar.Id))
        conexion.Open()
        command.ExecuteNonQuery()
        conexion.Close()
        ListarClientes()

    End Function
    Public Function EliminarClientes(ByVal eliminar As CECliente)

        Dim conexion As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("StrCon").ConnectionString)

        Dim consulta As String = "DELETE  FROM Productos WHERE ID=@ID"
        Dim command As New SqlCommand(consulta)

        command.Parameters.AddWithValue("@ID", Convert.ToInt32(eliminar.Id))
        conexion.Open()
        command.ExecuteNonQuery()
        conexion.Close()

        ListarClientes()

    End Function
    Public Function BuscarClintes(ByVal buscar As CEProducto)


    End Function

End Class
