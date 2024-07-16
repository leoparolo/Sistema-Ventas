Imports System.ComponentModel
Imports System.Threading
Imports Controlador
Imports Modelo

Public Class FrmBajaModifVentas
    Private ReadOnly _productoController As New ProductoController
    Private ReadOnly _ventaController As New VentaController


    Private pedidoDetalle As New BindingList(Of VentaDetalle)
    Private orden As Integer = 1
    Private ImporteTotal As Double = 0.0

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

    Private Sub btnBuscarPedido_Click(sender As Object, e As EventArgs) Handles btnBuscarPedido.Click
        'MY REFACTOR





        If ValidarBusqueda() Then
            pnlPedido.Visible = True
            pnlBusqProducto.Visible = True
            CargarPedido()
            btnBuscarPedido.Enabled = False
            txtBusqNroPedido.Enabled = False
        End If
    End Sub

    Private Function ValidarBusqueda() As Boolean
        Dim result As Boolean = True
        Dim venta As New CLVentas
        Return venta.ValidaExistePedido(CInt(txtBusqNroPedido.Text))
    End Function

    Private Sub CargarPedido()
        Dim venta As New CLVentas
        Dim pedidoEntero As Tuple(Of DataTable, DataTable) = venta.TraerPedido(CInt(txtBusqNroPedido.Text))
        Dim dtCabecera As DataTable = pedidoEntero.Item1
        Dim dtDetalle As DataTable = pedidoEntero.item2
        For Each cabecera As DataRow In dtCabecera.Rows
            lblNroPedido.Text = cabecera("ID")
            lblCliente.Text = $"{cabecera("IDCliente")} - {cabecera("Cliente")}"
            idCliente = cabecera("IDCliente")
            lblFechaPedido.Text = cabecera("Fecha")
            lblImporteTotal.Text = cabecera("Total")
        Next
        For Each detalle In dtDetalle.Rows
            Dim rowDetalle As DataRow = dtPedidoDetalle.NewRow()

            rowDetalle("Orden") = orden
            rowDetalle("IDProducto") = detalle("IDProducto")
            rowDetalle("Producto") = detalle("Nombre")
            rowDetalle("Cantidad") = detalle("Cantidad")
            rowDetalle("PrecioUnitario") = detalle("PrecioUnitario")
            rowDetalle("PrecioTotal") = detalle("PrecioTotal")

            dtPedidoDetalle.Rows.Add(rowDetalle)

            orden = orden + 1
            ImporteTotal += rowDetalle("PrecioTotal")
            lblImporteTotal.Text = ImporteTotal
        Next
    End Sub

    Private Sub btnEliminarSeleccionados_Click(sender As Object, e As EventArgs) Handles btnEliminarSeleccionados.Click
        ' Obtener el DataTable del DataGridView
        Dim table As DataTable = CType(gvDetallePedido.DataSource, DataTable)

        ' Crear una lista para almacenar las filas a eliminar
        Dim filasAEliminar As New List(Of DataRow)()

        ' Recorrer las filas del DataGridView
        For Each row As DataGridViewRow In gvDetallePedido.Rows
            ' Verificar si la fila está seleccionada (CheckBox marcado)
            If Not row.IsNewRow AndAlso Convert.ToBoolean(row.Cells("Sel.").Value) Then
                ' Obtener el DataRow correspondiente y agregarlo a la lista de filas a eliminar
                Dim dataRow As DataRow = CType(row.DataBoundItem, DataRowView).Row
                filasAEliminar.Add(dataRow)
            End If
        Next

        ' Eliminar las filas del DataTable
        For Each dataRow As DataRow In filasAEliminar
            ImporteTotal = ImporteTotal - dataRow("PrecioTotal")
            table.Rows.Remove(dataRow)
        Next
        lblImporteTotal.Text = ImporteTotal
        ' Refrescar el DataGridView
        gvDetallePedido.DataSource = table
    End Sub

    Private Sub chkProductoBusqAvanzada_CheckedChanged(sender As Object, e As EventArgs)
        If chkProductoBusqAvanzada.Checked Then
            pnlProducto.Visible = True
        Else
            pnlProducto.Visible = False
            CargarProductos()
            cmbProductos.BackColor = Color.White
            btnProdBorrarBusq.Visible = False
        End If
    End Sub

    Private Sub btnAgregarProducto_Click(sender As Object, e As EventArgs)
        Dim rowDetalle As DataRow = dtPedidoDetalle.NewRow()
        Dim productSelect As DataRowView = CType(cmbProductos.SelectedItem, DataRowView)

        rowDetalle("Orden") = orden
        rowDetalle("IDProducto") = productSelect("ID")
        rowDetalle("Producto") = productSelect("Nombre").ToString()
        rowDetalle("Cantidad") = CInt(txtCantidad.Text)
        rowDetalle("PrecioUnitario") = CDbl(productSelect("Precio"))
        rowDetalle("PrecioTotal") = CInt(txtCantidad.Text) * CDbl(productSelect("Precio"))

        dtPedidoDetalle.Rows.Add(rowDetalle)

        orden = orden + 1
        ImporteTotal += rowDetalle("PrecioTotal")
        lblImporteTotal.Text = ImporteTotal
    End Sub

    Private Sub btnProductoBuscar_Click(sender As Object, e As EventArgs)
        Dim metodo As String = cmbProductoTipoBusq.Text
        Dim controlador As New CLProductos
        cmbProductos.DataSource = controlador.BuscarProducto(metodo, txtProductoBusqueda.Text)
        cmbProductos.DisplayMember = "Nombre"
        cmbProductos.ValueMember = "Nombre"
        cmbProductos.BackColor = Color.Orange
        btnProdBorrarBusq.Visible = True
    End Sub

    Private Sub btnProdBorrarBusq_Click(sender As Object, e As EventArgs)
        CargarProductos()
        cmbProductos.BackColor = Color.White
        btnProdBorrarBusq.Visible = False
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        If MessageBox.Show("¿Desea salir sin guardar?", "Confirmar cancelar modificacion pedido", MessageBoxButtons.YesNo, MessageBoxIcon.Question) Then
            Me.Close()
        End If
    End Sub

    Private Sub btnBorrarPedido_Click(sender As Object, e As EventArgs) Handles btnBorrarPedido.Click
        If MessageBox.Show("¿Desea eliminar el pedido?", "Confirmar eliminar pedido", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Dim venta As New CLVentas
            venta.EliminarPedido(CInt(lblNroPedido.Text))
            MessageBox.Show("Pedido eliminado", "Confirmación pedido eliminado")
            pnlPedido.Visible = False
            pnlBusqProducto.Visible = False
            pnlProducto.Visible = False
            chkProductoBusqAvanzada.Checked = False
            txtBusqNroPedido.Enabled = True
            btnBuscarPedido.Enabled = True
        End If
    End Sub

    Private Sub btnGuardarCambios_Click(sender As Object, e As EventArgs) Handles btnGuardarCambios.Click
        'Limpio registros en bd
        Dim venta As New CLVentas
        venta.EliminarPedido(CInt(lblNroPedido.Text), CDbl(lblImporteTotal.Text))

        venta.InsertarPedido(CInt(lblNroPedido.Text), idCliente, CDate(lblFechaPedido.Text), CDbl(lblImporteTotal.Text))

        For Each artDetalle In dtPedidoDetalle.Rows
            venta.InsertarDetallePedido(CInt(lblNroPedido.Text), artDetalle("IDProducto"), artDetalle("PrecioUnitario"), artDetalle("Cantidad"), artDetalle("PrecioTotal"))
        Next
        MessageBox.Show($"Pedido nro. {lblNroPedido.Text} actualizado con exito!")
        Me.Close()
    End Sub
End Class