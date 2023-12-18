Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Data.Sql
Imports MS.Internal
Public Class CProductosNegocio


    Public Function ListarProductos() As List(Of CEProducto)
        Dim lista As List(Of CEProducto) = New List(Of CEProducto)()
        Dim conexion As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("StrCon").ConnectionString)
        Dim comando As SqlCommand = New SqlCommand()
        Dim lector As SqlDataReader

        Try

            comando.CommandType = System.Data.CommandType.Text
            comando.CommandText = "Select Id, Nombre, Precio, Categoria, Cantidad From Productos"
            comando.Connection = conexion
            conexion.Open()
            lector = comando.ExecuteReader()

            While lector.Read()
                Dim aux As CEProducto = New CEProducto()
                aux.Id = CInt(lector("Id"))
                aux.Nombre = CStr(lector("Nombre"))
                aux.Precio = CDbl(lector("Precio"))
                aux.Categoria = CStr(lector("Categoria"))
                aux.Cantidad = CInt(lector("Cantidad"))
                lista.Add(aux)
            End While


            Return lista
        Catch ex As Exception
            Throw ex
        Finally
            conexion.Close()
        End Try

    End Function



    Public Function agregarProductos(ByVal nuevo As CEProducto)

        Dim conexion As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("StrCon").ConnectionString)
        Dim comando As SqlCommand = New SqlCommand()

        Try
            comando.CommandType = System.Data.CommandType.Text
            comando.CommandText = "INSERT INTO Productos (Nombre, Precio, Categoria, Cantidad) VALUES (@Nombre, @Precio, @Categoria, @Cantidad)"
            comando.Connection = conexion
            comando.Parameters.AddWithValue("@Nombre", nuevo.Nombre)
            comando.Parameters.AddWithValue("@Precio", Convert.ToDouble(nuevo.Precio))
            comando.Parameters.AddWithValue("@Categoria", nuevo.Categoria)
            comando.Parameters.AddWithValue("@Cantidad", Convert.ToInt32(nuevo.Cantidad))
            comando.Parameters.AddWithValue("@ID", Convert.ToInt32(nuevo.Id))
            conexion.Open()
            comando.ExecuteNonQuery()
            ListarProductos()
        Catch ex As Exception
            Throw ex
        Finally

            conexion.Close()
        End Try
    End Function
    Public Function ModificarDatosProductos(ByVal modificar As CEProducto)


        Dim conexion As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("StrCon").ConnectionString)

        Dim consulta As String = "UPDATE Productos SET Nombre=@Nombre, Precio=@Precio, Categoria=@Categoria, Cantidad=@Cantidad WHERE ID=@ID"
        Dim command As New SqlCommand(consulta, conexion)


        command.Parameters.AddWithValue("@Nombre", modificar.Nombre)
        command.Parameters.AddWithValue("@Precio", Convert.ToDouble(modificar.Precio))
            command.Parameters.AddWithValue("@Categoria", modificar.Categoria)
            command.Parameters.AddWithValue("@Cantidad", Convert.ToInt32(modificar.Cantidad))

            command.Parameters.AddWithValue("@ID", Convert.ToInt32(modificar.Id))
        conexion.Open()
        command.ExecuteNonQuery()
        conexion.Close()
        ListarProductos()

    End Function
    Public Function EliminarDatos(ByVal eliminar As CEProducto)

        Dim conexion As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("StrCon").ConnectionString)

        Dim consulta As String = "DELETE  FROM Productos WHERE ID=@ID"
        Dim command As New SqlCommand(consulta, conexion)

        command.Parameters.AddWithValue("@ID", Convert.ToInt32(eliminar.Id))
        conexion.Open()
        command.ExecuteNonQuery()
        conexion.Close()

        ListarProductos()

    End Function
    Public Function BuscarDatos(ByVal buscar As CEProducto)


    End Function

End class