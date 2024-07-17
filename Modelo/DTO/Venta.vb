Imports System.ComponentModel

Public Class Ventas
    Private _Ventas As BindingList(Of Venta)
    Public Property Ventas As BindingList(Of Venta)
        Get
            Return _Ventas
        End Get
        Set
            _Ventas = Value
        End Set
    End Property
End Class
Public Class Venta
    Private _ID As Integer
    Private _IDCliente As Integer
    Private _Fecha As DateTime
    Private _Total As Double
    Private _Detalle As BindingList(Of VentaDetalle)

    Public Property Detalle As BindingList(Of VentaDetalle)
        Get
            Return _Detalle
        End Get
        Set
            _Detalle = Value
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
