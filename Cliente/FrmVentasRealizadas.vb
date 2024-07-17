Imports Controlador

Public Class FrmVentasRealizadas
    Private ReadOnly _ventaController As New VentaController
    Private Sub FrmVentasRealizadas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gvPedidos.DataSource = _ventaController.BuscarPedido("", DateTime.Now, "")
        FormatColumns(gvPedidos)
    End Sub

    Private Sub gvPedidos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles gvPedidos.CellDoubleClick
        If e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = gvPedidos.Rows(e.RowIndex)
            Dim nroPedido As Integer = Convert.ToInt32(selectedRow.Cells("Pedido").Value)
            Dim pedidoDatos = _ventaController.BuscarPedido(nroPedido)

            gvDetallePedido.DataSource = pedidoDatos.Detalle
            FormatColumns(gvDetallePedido)
        End If
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        gvPedidos.DataSource = _ventaController.BuscarPedido(txtCliente.Text, datePedido.Value, txtNroPedido.Text)
    End Sub
End Class