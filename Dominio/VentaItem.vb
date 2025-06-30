Public Class VentaItem
    Private _Id As Integer
    Private _IdVenta As Integer
    Private _IdProducto As Integer
    Private _PrecioUnitario As Decimal
    Private _Cantidad As Integer
    Private _PrecioTotal As Decimal

    Public Property Id As Integer
        Get
            Return _Id
        End Get
        Set(value As Integer)
            _Id = value
        End Set
    End Property

    Public Property IdVenta As Integer
        Get
            Return _IdVenta
        End Get
        Set(value As Integer)
            _IdVenta = value
        End Set
    End Property

    Public Property IdProducto As Integer
        Get
            Return _IdProducto
        End Get
        Set(value As Integer)
            _IdProducto = value
        End Set
    End Property

    Public Property PrecioUnitario As Decimal
        Get
            Return _PrecioUnitario
        End Get
        Set(value As Decimal)
            _PrecioUnitario = value
        End Set
    End Property

    Public Property Cantidad As Integer
        Get
            Return _Cantidad
        End Get
        Set(value As Integer)
            _Cantidad = value
        End Set
    End Property

    Public Property PrecioTotal As Decimal
        Get
            Return _PrecioTotal
        End Get
        Set(value As Decimal)
            _PrecioTotal = value
        End Set
    End Property
End Class
