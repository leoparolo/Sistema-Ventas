Public Class CustomMessage
    Private _Accion As String
    Private _Mensaje As String

    Public Property Accion As String
        Get
            Return _Accion
        End Get
        Set
            _Accion = Value
        End Set
    End Property

    Public Property Mensaje As String
        Get
            Return _Mensaje
        End Get
        Set
            _Mensaje = Value
        End Set
    End Property
End Class
