Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Runtime.Remoting.Contexts
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
    Public Function VerificarExistenciaPedido(nroPedido As Integer) As CustomMessage
        Return _ventaDAO.ValidarBusquedaPedido(nroPedido)
    End Function

    Public Function BuscarPedido(nroPedido As Integer) As Venta
        Return _ventaDAO.TraerPedido(nroPedido)
    End Function

    Public Function BuscarPedido(cliente As String, fecha As DateTime, nroPedido As Integer) As Ventas
        Return _ventaDAO.TraerPedido(cliente, fecha, nroPedido)
    End Function

    Public Sub EliminarPedido(nroPedido As Integer)
        _ventaDAO.Eliminar(nroPedido)
    End Sub

End Class
