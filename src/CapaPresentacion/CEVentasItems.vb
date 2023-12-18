Public Class CEVentasItems
    Private _ID As Integer
    Private _IDVenta As Integer
    Private _IDProducto As Integer
    Private _precioUnitario As Decimal
    Private _precioTotal As Decimal

    Public Property ID As Integer
        Get
            Return _ID
        End Get
        Set(value As Integer)
            _ID = value
        End Set
    End Property

    Public Property IDVenta As Integer
        Get
            Return _IDVenta
        End Get
        Set(value As Integer)
            _IDVenta = value
        End Set
    End Property

    Public Property IDProducto As Integer
        Get
            Return _IDProducto
        End Get
        Set(value As Integer)
            _IDProducto = value
        End Set
    End Property

    Public Property PrecioUnitario As Decimal
        Get
            Return _precioUnitario
        End Get
        Set(value As Decimal)
            _precioUnitario = value
        End Set
    End Property

    Public Property PrecioTotal As Decimal
        Get
            Return _precioTotal
        End Get
        Set(value As Decimal)
            _precioTotal = value
        End Set
    End Property
End Class
