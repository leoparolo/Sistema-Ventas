Public Class Producto
    Private _ID As Integer
    Private _Nombre As String
    Private _Precio As Double
    Private _Categoria As String

    Public Property ID As Integer
        Get
            Return _ID
        End Get
        Set
            _ID = Value
        End Set
    End Property

    Public Property Nombre As String
        Get
            Return _Nombre
        End Get
        Set
            _Nombre = Value
        End Set
    End Property

    Public Property Precio As Double
        Get
            Return _Precio
        End Get
        Set
            _Precio = Value
        End Set
    End Property

    Public Property Categoria As String
        Get
            Return _Categoria
        End Get
        Set
            _Categoria = Value
        End Set
    End Property

    Public Sub New(iD As Integer, nombre As String, precio As Double, categoria As String)
        Me.ID = iD
        Me.Nombre = nombre
        Me.Precio = precio
        Me.Categoria = categoria
    End Sub
    Public Sub New(nombre As String, precio As Double, categoria As String)
        Me.Nombre = nombre
        Me.Precio = precio
        Me.Categoria = categoria
    End Sub
End Class
