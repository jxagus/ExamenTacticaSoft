Public Class Venta
    Private _Id As Integer
    Private _IdCliente As Integer
    Private _Fecha As Date
    Private _Total As Decimal

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
            Return _Fecha
        End Get
        Set(value As Date)
            _Fecha = value
        End Set
    End Property

    Public Property Total As Decimal
        Get
            Return _Total
        End Get
        Set(value As Decimal)
            _Total = value
        End Set
    End Property
End Class
