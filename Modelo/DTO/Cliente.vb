Public Class Cliente
    Private _cliente As String
    Private _telefono As String
    Private _correo As String
    Private _id As Integer

    Public Property ID As Integer
        Get
            Return _id
        End Get
        Set
            _id = Value
        End Set
    End Property

    Public Property Cliente As String
        Get
            Return _cliente
        End Get
        Set
            _cliente = Value
        End Set
    End Property

    Public Property Telefono As String
        Get
            Return _telefono
        End Get
        Set
            _telefono = Value
        End Set
    End Property

    Public Property Correo As String
        Get
            Return _correo
        End Get
        Set
            _correo = Value
        End Set
    End Property
    Public Sub New(id As Integer, cliente As String, telefono As String, correo As String)
        Me._id = id
        Me._cliente = cliente
        Me._telefono = telefono
        Me._correo = correo
    End Sub
    Public Sub New(cliente As String, telefono As String, correo As String)
        Me._cliente = cliente
        Me._telefono = telefono
        Me._correo = correo
    End Sub
End Class
