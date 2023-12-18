Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Configuration
Class CDatos
    Friend Class CDatos
        ' Private con As SqlConnection = ConBase()
        Private Comando As SqlCommand
        Private Conexion As SqlConnection
        Private lector As SqlDataReader
        'Public Shared Function ConBase() As SqlConnection

        '    Dim StrConectar As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("StrCon").ConnectionString)
        '    Return StrConectar

        'End Function

        Public ReadOnly Property Lectura As SqlDataReader
            Get
                Return lector
            End Get
        End Property
        Public Sub New()
            Conexion = New SqlConnection(ConfigurationManager.ConnectionStrings("StrCon").ConnectionString)
            Comando = New SqlCommand()
        End Sub
        Public Sub setearConsulta(ByVal consulta As String)
            Comando.CommandType = System.Data.CommandType.Text
            Comando.CommandText = consulta
        End Sub

        Public Sub ejecutarLectura()
            Comando.Connection = Conexion

            Try
                Conexion.Open()
                lector = Comando.ExecuteReader()
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
        Public Sub ejecutarAccion()
            Comando.Connection = Conexion

            Try
                Conexion.Open()
                Comando.ExecuteNonQuery()
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Sub setearParametro(ByVal nombre As String, ByVal valor As Object)
            Comando.Parameters.AddWithValue(nombre, valor)
        End Sub

        Public Sub cerrarConexion()
            If lector IsNot Nothing Then Conexion.Close()
            lector.Close()
        End Sub
    End Class
End Class
