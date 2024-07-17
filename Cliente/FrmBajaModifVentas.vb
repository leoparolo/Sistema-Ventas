Imports System.ComponentModel
Imports System.Threading
Imports Controlador
Imports Modelo

Public Class FrmBajaModifVentas
    Private ReadOnly _productoController As New ProductoController
    Private ReadOnly _ventaController As New VentaController

    Private Pedido As Venta
    Private pedidoDetalle As New BindingList(Of VentaDetalle)
    Private orden As Integer = 1
    Private ImporteTotal As Double = 0.0
    Private idCliente As Integer

    Private Sub FrmBajaModifVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConfigInicial()
    End Sub

    Private Sub ConfigInicial()
        pnlPedido.Visible = False
        pnlBusqProducto.Visible = False
        cmbProductos.DataSource = _productoController.GetProducto("")

        gvDetallePedido.DataSource = pedidoDetalle
        gvDetallePedido.Columns.Item("ID").Visible = False
        gvDetallePedido.Columns.Item("IDVenta").Visible = False
        gvDetallePedido.Columns.Item("IDProducto").Visible = False

        gvDetallePedido.Columns.Item("Seleccionado").DisplayIndex = 0
        gvDetallePedido.Columns.Item("Orden").DisplayIndex = 1
        gvDetallePedido.Columns.Item("ProductoNombre").DisplayIndex = 2
        gvDetallePedido.Columns.Item("PrecioUnitario").DisplayIndex = 3
        gvDetallePedido.Columns.Item("Cantidad").DisplayIndex = 4
        gvDetallePedido.Columns.Item("PrecioTotal").DisplayIndex = 5

        gvDetallePedido.Columns.Item("ProductoNombre").HeaderText = "Producto"
        gvDetallePedido.Columns.Item("Seleccionado").HeaderText = "Sel."
        gvDetallePedido.Columns.Item("PrecioUnitario").HeaderText = "Unitario"
        gvDetallePedido.Columns.Item("PrecioTotal").HeaderText = "Total"

        FormatColumns(gvDetallePedido)
        gvDetallePedido.Columns(0).ReadOnly = False
    End Sub

    Private Sub BtnBuscarPedido_Click(sender As Object, e As EventArgs) Handles btnBuscarPedido.Click
        'MY REFACTOR
        Dim Validacion As CustomMessage = _ventaController.VerificarExistenciaPedido(txtBusqNroPedido.Text)
        If Validacion.Accion = "Exito" Then
            pnlPedido.Visible = True
            pnlBusqProducto.Visible = True
            Pedido = _ventaController.BuscarPedido(txtBusqNroPedido.Text)
            btnBuscarPedido.Enabled = False
            txtBusqNroPedido.Enabled = False
            CargarPedido(Pedido)
        Else
            MessageBox.Show(Validacion.Mensaje, Validacion.Accion)
        End If
    End Sub

    Private Sub CargarPedido(Pedido As Venta)
        lblNroPedido.Text = Pedido.ID
        lblCliente.Text = Pedido.IDCliente
        idCliente = Pedido.IDCliente
        lblFechaPedido.Text = Pedido.Fecha
        lblImporteTotal.Text = Pedido.Total
        ImporteTotal = Pedido.Total
        pedidoDetalle = Pedido.Detalle
    End Sub

    Private Sub btnEliminarSeleccionados_Click(sender As Object, e As EventArgs) Handles btnEliminarSeleccionados.Click
        Dim listEliminar As New BindingList(Of VentaDetalle)

        For Each detalle In pedidoDetalle
            If detalle.Seleccionado Then
                listEliminar.Add(detalle)
            End If
        Next

        For Each detalleEliminar In listEliminar
            pedidoDetalle.Remove(detalleEliminar)
            ImporteTotal -= detalleEliminar.PrecioTotal
        Next

        lblImporteTotal.Text = ImporteTotal
        gvDetallePedido.DataSource = pedidoDetalle
    End Sub

    Private Sub btnAgregarProducto_Click(sender As Object, e As EventArgs)
        Dim productoDatos As Producto = cmbProductos.SelectedItem
        Dim detalleDatos As New VentaDetalle With {
            .Seleccionado = False,
            .Orden = orden,
            .IDProducto = productoDatos.ID,
            .IDVenta = lblNroPedido.Text,
            .ProductoNombre = productoDatos.Nombre,
            .Cantidad = CInt(txtCantidad.Text),
            .PrecioUnitario = productoDatos.Precio,
            .PrecioTotal = CInt(txtCantidad.Text) * productoDatos.Precio}

        pedidoDetalle.Add(detalleDatos)

        orden += 1
        ImporteTotal += detalleDatos.PrecioTotal

        lblImporteTotal.Text = ImporteTotal
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        If MessageBox.Show("¿Desea salir sin guardar?", "Confirmar cancelar modificacion pedido", MessageBoxButtons.YesNo, MessageBoxIcon.Question) Then
            Me.Close()
        End If
    End Sub

    Private Sub btnBorrarPedido_Click(sender As Object, e As EventArgs) Handles btnBorrarPedido.Click
        If MessageBox.Show("¿Desea eliminar el pedido?", "Confirmar eliminar pedido", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            _ventaController.EliminarPedido(CInt(lblNroPedido.Text))
            MessageBox.Show("Pedido eliminado", "Confirmación pedido eliminado")
            pnlPedido.Visible = False
            pnlBusqProducto.Visible = False
            txtBusqNroPedido.Enabled = True
            btnBuscarPedido.Enabled = True
        End If
    End Sub

    Private Sub btnGuardarCambios_Click(sender As Object, e As EventArgs) Handles btnGuardarCambios.Click
        Dim cabeceraVenta As New Venta With {
            .ID = CInt(lblNroPedido.Text),
            .IDCliente = idCliente,
            .Fecha = lblFechaPedido.Text,
            .Total = CDbl(lblImporteTotal.Text)}
        _ventaController.EliminarPedido(cabeceraVenta.ID)
        _ventaController.InsertarVenta(cabeceraVenta, pedidoDetalle)

        MessageBox.Show($"Pedido nro. {lblNroPedido.Text} creado con exito!")

        pedidoDetalle.Clear()
        lblImporteTotal.Text = 0
        ConfigInicial()
    End Sub
End Class