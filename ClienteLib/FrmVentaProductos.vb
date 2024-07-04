Imports ControladorLib

Public Class FrmVentaProductos

    Private dtPedidoDetalle As New DataTable
    Private orden As Integer = 1
    Private ImporteTotal As Double = 0.0
    Private Sub FrmVentaProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarClientes()
        CargarProductos()
        CrearDatatablePedidoDetalle()
        CargarTipoBusquedaCliente()
        CargarTipoBusquedaProducto()
        lblFechaPedido.Text = DateTime.Now

        Dim venta As New CLVentas

        lblNroPedido.Text = venta.TraerProximoNroPedido()


        lblImporteTotal.Text = ImporteTotal
        pnlCliente.Visible = False
        pnlProducto.Visible = False
        chkClienteBusqAvanzada.Checked = False
        chkProductoBusqAvanzada.Checked = False
        btnClienteBorrarBusq.Visible = False
        btnProdBorrarBusq.Visible = False

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

    Private Sub CargarTipoBusquedaCliente()
        Dim dtTipoBusqCliente As New DataTable
        dtTipoBusqCliente.Columns.Add("ID")
        dtTipoBusqCliente.Columns.Add("Metodo")
        dtTipoBusqCliente.Columns(0).AutoIncrement = True

        Dim metodos As New List(Of String)({"Cliente", "Telefono", "Correo"})

        For Each metodo In metodos
            Dim row As DataRow = dtTipoBusqCliente.NewRow
            row("Metodo") = metodo
            dtTipoBusqCliente.Rows.Add(row)
        Next

        cmbClienteTipoBusq.DataSource = dtTipoBusqCliente
        cmbClienteTipoBusq.DisplayMember = "Metodo"
        cmbClienteTipoBusq.ValueMember = "Metodo"

    End Sub
    Private Sub CrearDatatablePedidoDetalle()
        Dim chkColumn As New DataGridViewCheckBoxColumn() With {
            .Name = "Sel.",
            .HeaderText = "Sel.",
            .Width = 50}
        gvDetallePedido.Columns.Add(chkColumn)


        dtPedidoDetalle.Columns.Add("Orden")
        dtPedidoDetalle.Columns.Add("ID")
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

    Private Sub CargarClientes()
        Dim cliente As New CLClientes()
        cmbClientes.DataSource = cliente.MostrarCliente()
    End Sub

    Private Sub CargarProductos()
        Dim producto As New CLProductos
        cmbProductos.DataSource = producto.MostrarProductos()
    End Sub

    Private Sub chkClienteBusqAvanzada_CheckedChanged(sender As Object, e As EventArgs) Handles chkClienteBusqAvanzada.CheckedChanged
        If chkClienteBusqAvanzada.Checked Then
            pnlCliente.Visible = True
        Else
            pnlCliente.Visible = False
            CargarClientes()
            cmbClientes.BackColor = Color.White
            btnClienteBorrarBusq.Visible = False
        End If
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

    Private Sub cmbClientes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbClientes.SelectedIndexChanged
        Dim clienteSelect As DataRowView = CType(cmbClientes.SelectedItem, DataRowView)
        Dim id As Integer = CInt(clienteSelect("ID"))
        Dim nombre As String = clienteSelect("Cliente").ToString()

        lblCliente.Text = $"{id} - {nombre}"
    End Sub



    Private Sub txtCantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCantidad.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso e.KeyChar <> "." Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnAgregarProducto_Click(sender As Object, e As EventArgs) Handles btnAgregarProducto.Click
        Dim rowDetalle As DataRow = dtPedidoDetalle.NewRow()
        Dim productSelect As DataRowView = CType(cmbProductos.SelectedItem, DataRowView)

        rowDetalle("Orden") = orden
        rowDetalle("ID") = productSelect("ID")
        rowDetalle("Producto") = productSelect("Nombre").ToString()
        rowDetalle("Cantidad") = CInt(txtCantidad.Text)
        rowDetalle("PrecioUnitario") = CDbl(productSelect("Precio"))
        rowDetalle("PrecioTotal") = CInt(txtCantidad.Text) * CDbl(productSelect("Precio"))

        dtPedidoDetalle.Rows.Add(rowDetalle)

        orden = orden + 1
        ImporteTotal += rowDetalle("PrecioTotal")
        lblImporteTotal.Text = ImporteTotal
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

    Private Sub btnCerrarPedido_Click(sender As Object, e As EventArgs) Handles btnCerrarPedido.Click
        Dim venta As New CLVentas
        Dim clienteSelect As DataRowView = CType(cmbClientes.SelectedItem, DataRowView)
        venta.InsertarPedido(CInt(lblNroPedido.Text), CInt(clienteSelect("ID")), CDate(lblFechaPedido.Text), CDbl(lblImporteTotal.Text))

        For Each artDetalle In dtPedidoDetalle.Rows
            venta.InsertarDetallePedido(CInt(lblNroPedido.Text), artDetalle("ID"), artDetalle("PrecioUnitario"), artDetalle("Cantidad"), artDetalle("PrecioTotal"))
        Next
        MessageBox.Show($"Pedido nro. {lblNroPedido.Text} creado con exito!")

        dtPedidoDetalle.Clear()
        lblNroPedido.Text = venta.TraerProximoNroPedido()
    End Sub

    Private Sub btnClienteBuscar_Click(sender As Object, e As EventArgs) Handles btnClienteBuscar.Click
        Dim metodo As String = cmbClienteTipoBusq.Text
        Dim controlador As New CLClientes
        cmbClientes.DataSource = controlador.BuscarCliente(metodo, txtClienteBusqueda.Text)
        cmbClientes.BackColor = Color.Orange
        btnClienteBorrarBusq.Visible = True
    End Sub

    Private Sub btnClienteBorrarBusq_Click(sender As Object, e As EventArgs) Handles btnClienteBorrarBusq.Click
        CargarClientes()
        cmbClientes.BackColor = Color.White
        btnClienteBorrarBusq.Visible = False
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
End Class