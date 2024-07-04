Imports ControladorLib

Public Class FrmVentasRealizadas
    Private Sub FrmVentasRealizadas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ventas As New CLVentas
        gvPedidos.DataSource = ventas.TraerPedido()
        CargarClientes()
        EstiloGrids()
        chkSinFiltro.Checked = True
    End Sub
    Private Sub CargarClientes()
        Dim cliente As New CLClientes()
        cmbClientes.DataSource = cliente.MostrarCliente()
    End Sub
    Private Sub EstiloGrids()
        For Each column As DataGridViewColumn In gvPedidos.Columns
            column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            column.HeaderCell.Style.Font = New Font(gvPedidos.Font, FontStyle.Bold)
            column.ReadOnly = True
        Next
        For Each column As DataGridViewColumn In gvDetallePedido.Columns
            column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            column.HeaderCell.Style.Font = New Font(gvDetallePedido.Font, FontStyle.Bold)
            column.ReadOnly = True
        Next
    End Sub

    Private Sub gvPedidos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles gvPedidos.CellDoubleClick
        If e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = gvPedidos.Rows(e.RowIndex)
            Dim nroPedido As Integer = Convert.ToInt32(selectedRow.Cells("Pedido").Value)
            Dim detalle As New CLVentas
            gvDetallePedido.DataSource = detalle.TraerDetalle(nroPedido)
        End If
    End Sub

    Private Sub chkCliente_CheckedChanged(sender As Object, e As EventArgs) Handles chkCliente.CheckedChanged
        If chkCliente.Checked Then
            cmbClientes.Enabled = True
        Else
            cmbClientes.Enabled = False
        End If
    End Sub

    Private Sub chkFechaPedido_CheckedChanged(sender As Object, e As EventArgs) Handles chkFechaPedido.CheckedChanged
        If chkFechaPedido.Checked Then
            datePedido.Enabled = True
        Else
            datePedido.Enabled = False
        End If
    End Sub

    Private Sub chkNroPedido_CheckedChanged(sender As Object, e As EventArgs) Handles chkNroPedido.CheckedChanged
        If chkNroPedido.Checked Then
            txtNroPedido.Enabled = True
        Else
            txtNroPedido.Enabled = False
        End If
    End Sub

    Private Sub chkSinFiltro_CheckedChanged(sender As Object, e As EventArgs) Handles chkSinFiltro.CheckedChanged
        If chkSinFiltro.Checked Then
            pnlFiltros.Visible = False
        Else
            pnlFiltros.Visible = True
            chkNroPedido.Checked = True
            chkFechaPedido.Checked = True
            chkNroPedido.Checked = True
        End If
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim ventas As New CLVentas
        If chkSinFiltro.Checked Then
            gvPedidos.DataSource = ventas.TraerPedido()
        Else
            Dim clienteSelect As DataRowView = CType(cmbClientes.SelectedItem, DataRowView)
            Dim nombre As String = clienteSelect("Cliente").ToString()
            Dim nroPedido As Integer = 0
            If txtNroPedido.Text = "" Or txtNroPedido.Text Is Nothing Then
                nroPedido = 0
            Else
                nroPedido = CInt(txtNroPedido.Text)
            End If
            gvPedidos.DataSource = ventas.TraerPedidoFiltrado(chkCliente.Checked, nombre, chkFechaPedido.Checked, datePedido.Value, chkNroPedido.Checked, nroPedido)
        End If
    End Sub
End Class