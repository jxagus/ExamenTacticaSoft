Public Class Clientes 'Id, NombreCliente, Telefono, Correo

    Public Class Cliente
        Private _Id As Integer
        Private _NombreCliente As String
        Private _Telefono As String
        Private _Correo As String

        Public Property Id As Integer
            Get
                Return _Id
            End Get
            Set(value As Integer)
                _Id = value
            End Set
        End Property

        Public Property NombreCliente As String
            Get
                Return _NombreCliente
            End Get
            Set(value As String)
                _NombreCliente = value
            End Set
        End Property

        Public Property Telefono As String
            Get
                Return _Telefono
            End Get
            Set(value As String)
                _Telefono = value
            End Set
        End Property

        Public Property Correo As String
            Get
                Return _Correo
            End Get
            Set(value As String)
                _Correo = value
            End Set
        End Property
    End Class


End Class
