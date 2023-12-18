Public Class CProductoVta
    Private _nombre As String
    Private _Id As Integer
    Private _precio As Decimal

    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

    Public Property Id As Integer
        Get
            Return _Id
        End Get
        Set(value As Integer)
            _Id = value
        End Set
    End Property

    Public Property Precio As Decimal
        Get
            Return _precio
        End Get
        Set(value As Decimal)
            _precio = value
        End Set
    End Property
End Class
