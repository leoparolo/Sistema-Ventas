Imports ModeloLib

Public Class CLVentas

    Public Function TraerProximoNroPedido() As Integer
        Dim venta As New MLVentas
        Return venta.UltimoNroPedido() + 1
    End Function

    Public Sub InsertarPedido(id As Integer, idCliente As Integer, fecha As DateTime, total As Double)
        Dim ventaCabecera As New MLVentas(id, idCliente, fecha, total)
        ventaCabecera.Insertar()

    End Sub

    Public Sub InsertarDetallePedido(idVenta As Integer, idProducto As Integer, precioUnitario As Double, cantidad As Double, precioTotal As Double)
        Dim ventaDetalle As New MLVentasitems(idVenta, idProducto, precioUnitario, cantidad, precioTotal)
        ventaDetalle.Insertar()
    End Sub

    Public Function ValidaExistePedido(idPedido As Integer) As Boolean
        Dim venta As New MLVentas
        Return venta.ExisteNroPedido(idPedido)
    End Function

    Public Function TraerPedido(nroPedido As Integer) As Tuple(Of DataTable, DataTable)
        Dim dtCabecera As New DataTable
        Dim dtDetalle As New DataTable
        Dim venta As New MLVentas
        Dim detalle As New MLVentasitems
        dtCabecera = venta.BuscarPedido(nroPedido)
        dtDetalle = detalle.BuscarDetallePedido(nroPedido)
        Return Tuple.Create(dtCabecera, dtDetalle)
    End Function

    Public Function TraerPedido() As DataTable
        Dim dtCabecera As New DataTable
        Dim venta As New MLVentas
        dtCabecera = venta.BuscarPedido()
        Return dtCabecera
    End Function

    Public Function TraerDetalle(nroPedido As Integer) As DataTable
        Dim dtDetalle As New DataTable
        Dim detalle As New MLVentasitems
        dtDetalle = detalle.BuscarDetallePedido(nroPedido)
        Return dtDetalle
    End Function

    Public Sub EliminarPedido(nroPedido As Integer, precioTotal As Double)
        Dim cabecera As New MLVentas
        cabecera.Actualizar(precioTotal, nroPedido)

        Dim detalle As New MLVentasitems
        detalle.Eliminar(nroPedido)

    End Sub

    Public Sub EliminarPedido(nroPedido As Integer)
        Dim cabecera As New MLVentas
        cabecera.Eliminar(nroPedido)

        Dim detalle As New MLVentasitems
        detalle.Eliminar(nroPedido)

    End Sub

    Public Function TraerPedidoFiltrado(chkCliente As Boolean, Cliente As String, chkFecha As Boolean, Fecha As DateTime, chkNroPedido As Boolean, NroPedido As Integer) As DataTable
        Dim venta As New MLVentas
        Return venta.BuscarPedido(chkCliente, Cliente, chkFecha, Fecha, chkNroPedido, NroPedido)
    End Function

    Public Function TraerPrespuestoMensual(Año As Integer, Mes As Integer) As DataTable
        Dim venta As New MLVentas
        Return venta.PresupuestoMensual(Año, Mes)
    End Function

End Class
