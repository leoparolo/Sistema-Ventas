Imports System.ComponentModel
Imports Modelo

Public Class VentaController
    Private ReadOnly _ventaDAO As New VentaDAO

    Public Function TraerProximoNroPedido() As Integer
        Return _ventaDAO.TraerUltimoNroPedido() + 1
    End Function

    Public Sub InsertarVenta(cabecera As Venta, detalles As BindingList(Of VentaDetalle))
        'Cabecera
        _ventaDAO.InsertarCabecera(cabecera)
        'Detalle
        For Each _detalle In detalles
            _ventaDAO.InsertarDetalle(_detalle)
        Next

    End Sub

    Public Function ValidarBusqueda() As CustomMessage

    End Function
    Public Function TraerPedido()

    End Function

End Class
