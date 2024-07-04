Imports System.Threading
Imports ControladorLib

Public Class FrmBajaModifVentas

    Private dtPedidoDetalle As New DataTable
    Private orden As Integer = 1
    Private ImporteTotal As Double = 0.0
    Private idCliente As Integer

    Private Sub FrmBajaModifVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pnlPedido.Visible = False
        pnlBusqProducto.Visible = False
        pnlProducto.Visible = False
        chkProductoBusqAvanzada.Checked = False

        CargarProductos()
        CrearDatatablePedidoDetalle()
        CargarTipoBusquedaProducto()

    End Sub
    Private Sub CargarTipoBusquedaProducto()
        Dim dtTipoBusqProducto As New DataTable
        dtTipoBusqProducto.Columns.Add("ID")
        dtTipoBusqProducto.Columns.Add("Metodo")
        dtTipoBusqProducto.Columns(0).AutoIncrement = True

        Dim metodos As New List(Of String)({"Nombre", "Categoria"})

        For Each metodo In metodos
            Dim row As DataRow = dtTipoBusqProducto.NewRow
            row("Metodo") = metodo
            dtTipoBusqProducto.Rows.Add(row)
        Next
        cmbProductoTipoBusq.DataSource = dtTipoBusqProducto
        cmbProductoTipoBusq.DisplayMember = "Metodo"
        cmbProductoTipoBusq.ValueMember = "Metodo"
    End Sub

    Private Sub CargarProductos()
        Dim producto As New CLProductos
        cmbProductos.DataSource = producto.MostrarProductos()
    End Sub

    Private Sub CrearDatatablePedidoDetalle()
        Dim chkColumn As New DataGridViewCheckBoxColumn() With {
            .Name = "Sel.",
            .HeaderText = "Sel.",
            .Width = 50}
        gvDetallePedido.Columns.Add(chkColumn)


        dtPedidoDetalle.Columns.Add("Orden")
        dtPedidoDetalle.Columns.Add("IDProducto")
        dtPedidoDetalle.Columns.Add("Producto")
        dtPedidoDetalle.Columns.Add("Cantidad")
        dtPedidoDetalle.Columns.Add("PrecioUnitario")
        dtPedidoDetalle.Columns.Add("PrecioTotal")

        gvDetallePedido.DataSource = dtPedidoDetalle
        gvDetallePedido.Columns("PrecioUnitario").HeaderText = "Unitario ($)"
        gvDetallePedido.Columns("PrecioTotal").HeaderText = "Total ($)"

        For Each column As DataGridViewColumn In gvDetallePedido.Columns
            column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            column.HeaderCell.Style.Font = New Font(gvDetallePedido.Font, FontStyle.Bold)
            column.ReadOnly = True
        Next
        gvDetallePedido.Columns(0).ReadOnly = False
    End Sub

    Private Sub txtBusqNroPedido_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBusqNroPedido.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso e.KeyChar <> "." Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnBuscarPedido_Click(sender As Object, e As EventArgs) Handles btnBuscarPedido.Click
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
        Dim dtCabecera As DataTable = pedidoEntero.item1
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

    Private Sub chkProductoBusqAvanzada_CheckedChanged(sender As Object, e As EventArgs) Handles chkProductoBusqAvanzada.CheckedChanged
        If chkProductoBusqAvanzada.Checked Then
            pnlProducto.Visible = True
        Else
            pnlProducto.Visible = False
            CargarProductos()
            cmbProductos.BackColor = Color.White
            btnProdBorrarBusq.Visible = False
        End If
    End Sub

    Private Sub btnAgregarProducto_Click(sender As Object, e As EventArgs) Handles btnAgregarProducto.Click
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

    Private Sub btnProductoBuscar_Click(sender As Object, e As EventArgs) Handles btnProductoBuscar.Click
        Dim metodo As String = cmbProductoTipoBusq.Text
        Dim controlador As New CLProductos
        cmbProductos.DataSource = controlador.BuscarProducto(metodo, txtProductoBusqueda.Text)
        cmbProductos.DisplayMember = "Nombre"
        cmbProductos.ValueMember = "Nombre"
        cmbProductos.BackColor = Color.Orange
        btnProdBorrarBusq.Visible = True
    End Sub

    Private Sub btnProdBorrarBusq_Click(sender As Object, e As EventArgs) Handles btnProdBorrarBusq.Click
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