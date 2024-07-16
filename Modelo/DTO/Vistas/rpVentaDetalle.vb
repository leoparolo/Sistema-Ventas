Public Class rpVentaDetalle
    Private _Seleccionado As Boolean
    Private _Orden As Integer
    Private _ID As Integer
    Private _ProductoNombre As String
    Private _PrecioUnitario As Double
    Private _Cantidad As Double
    Private _PrecioTotal As Double

    Public Property Seleccionado As Boolean
        Get
            Return _Seleccionado
        End Get
        Set
            _Seleccionado = Value
        End Set
    End Property

    Public Property Orden As Integer
        Get
            Return _Orden
        End Get
        Set
            _Orden = Value
        End Set
    End Property

    Public Property ID As Integer
        Get
            Return _ID
        End Get
        Set
            _ID = Value
        End Set
    End Property

    Public Property ProductoNombre As String
        Get
            Return _ProductoNombre
        End Get
        Set
            _ProductoNombre = Value
        End Set
    End Property

    Public Property PrecioUnitario As Double
        Get
            Return _PrecioUnitario
        End Get
        Set
            _PrecioUnitario = Value
        End Set
    End Property

    Public Property Cantidad As Double
        Get
            Return _Cantidad
        End Get
        Set
            _Cantidad = Value
        End Set
    End Property

    Public Property PrecioTotal As Double
        Get
            Return _PrecioTotal
        End Get
        Set
            _PrecioTotal = Value
        End Set
    End Property
End Class
