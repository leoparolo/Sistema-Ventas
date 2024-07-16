Imports System.ComponentModel
Imports Controlador
Imports Modelo

Public Class FrmVentaProductos
    Private ReadOnly _clienteController As New ClienteController
    Private ReadOnly _productoController As New ProductoController
    Private ReadOnly _ventaController As New VentaController

    Private orden As Integer = 1
    Private ImporteTotal As Double = 0.0
    Private pedidoDetalle As New BindingList(Of VentaDetalle)
    Private Sub FrmVentaProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConfigInicial()

    End Sub

    Private Sub ConfigInicial()
        cmbClientes.DataSource = _clienteController.GetClientes("")
        cmbProductos.DataSource = _productoController.GetProducto("")
        lblFechaPedido.Text = DateTime.Now
        ImporteTotal = 0.0
        lblNroPedido.Text = _ventaController.TraerProximoNroPedido()
        lblImporteTotal.Text = ImporteTotal
        pedidoDetalle = New BindingList(Of VentaDetalle)
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
    Private Sub CmbClientes_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbClientes.KeyPress

        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            If cmbClientes.Text = "" Then
                cmbClientes.BackColor = Color.White
            Else
                cmbClientes.BackColor = Color.Orange
            End If
            cmbClientes.DataSource = _clienteController.GetClientes(cmbClientes.Text)

        End If
    End Sub
    Private Sub CmbClientes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbClientes.SelectedIndexChanged
        If cmbClientes.SelectedItem IsNot Nothing Then
            Dim clienteDatos As Cliente = cmbClientes.SelectedItem

            lblCliente.Text = $"{clienteDatos.ID} - {clienteDatos.Cliente}"
        End If

    End Sub
    Private Sub CmbProductos_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbProductos.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            If cmbProductos.Text IsNot Nothing Or cmbProductos.Text = "" Then
                cmbProductos.BackColor = Color.White
            Else
                cmbProductos.BackColor = Color.Orange
            End If
            cmbProductos.DataSource = _productoController.GetProducto(cmbProductos.Text)
        End If
    End Sub

    Private Sub TxtCantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCantidad.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso e.KeyChar <> "." Then
            e.Handled = True
        End If
    End Sub

    Private Sub BtnAgregarProducto_Click(sender As Object, e As EventArgs) Handles btnAgregarProducto.Click

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

    Private Sub BtnEliminarSeleccionados_Click(sender As Object, e As EventArgs) Handles btnEliminarSeleccionados.Click

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

    Private Sub BtnCerrarPedido_Click(sender As Object, e As EventArgs) Handles btnCerrarPedido.Click
        Dim clienteDatos As Cliente = cmbClientes.SelectedItem
        Dim cabeceraVenta As New Venta With {
            .ID = CInt(lblNroPedido.Text),
            .IDCliente = clienteDatos.ID,
            .Fecha = lblFechaPedido.Text,
            .Total = CDbl(lblImporteTotal.Text)}

        _ventaController.InsertarVenta(cabeceraVenta, pedidoDetalle)

        MessageBox.Show($"Pedido nro. {lblNroPedido.Text} creado con exito!")

        pedidoDetalle.Clear()
        lblImporteTotal.Text = 0
        ConfigInicial()
    End Sub


End Class