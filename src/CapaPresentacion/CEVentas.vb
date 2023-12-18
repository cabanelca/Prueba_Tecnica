Public Class CEVentas
    Private _Id As Integer
    Private _IdCliente As Integer
    Private _fecha As DateTime
    Private _total As Decimal
    Private _nroVta As Decimal
    Public Property Id As Integer
        Get
            Return _Id
        End Get
        Set(value As Integer)
            _Id = value
        End Set
    End Property

    Public Property IdCliente As Integer
        Get
            Return _IdCliente
        End Get
        Set(value As Integer)
            _IdCliente = value
        End Set
    End Property

    Public Property Fecha As Date
        Get
            Return _fecha
        End Get
        Set(value As Date)
            _fecha = value
        End Set
    End Property

    Public Property Total As Decimal
        Get
            Return _total
        End Get
        Set(value As Decimal)
            _total = value
        End Set
    End Property

    Public Property NroVta As Decimal
        Get
            Return _nroVta
        End Get
        Set(value As Decimal)
            _nroVta = value
        End Set
    End Property
End Class
