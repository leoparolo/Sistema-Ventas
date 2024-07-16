Public Class Venta
    Private _ID As Integer
    Private _IDCliente As Integer
    Private _Fecha As DateTime
    Private _Total As Double

    Public Property ID As Integer
        Get
            Return _ID
        End Get
        Set
            _ID = Value
        End Set
    End Property

    Public Property IDCliente As Integer
        Get
            Return _IDCliente
        End Get
        Set
            _IDCliente = Value
        End Set
    End Property

    Public Property Fecha As DateTime
        Get
            Return _Fecha
        End Get
        Set
            _Fecha = Value.ToString("yyyy-MM-dd HH:mm:ss")
        End Set
    End Property

    Public Property Total As Double
        Get
            Return _Total
        End Get
        Set
            _Total = Value
        End Set
    End Property
End Class
