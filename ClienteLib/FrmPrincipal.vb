Public Class FrmPrincipal
    Private Sub FrmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Esto sirve para poder mostrar formularios hijos dentro de FrmPrincipal.
        'Haciendo esto, el panel1 tiene el espacio para que aparezca la barra de tareas
        SplitContainer1.SplitterDistance = 1
    End Sub

    Private Sub ClientesToolStrip_Click(sender As Object, e As EventArgs) Handles ClientesToolStrip.Click
        Dim frmClientes As New FrmClientes()
        SeleccionarForm(frmClientes)
    End Sub

    Private Sub ProductosToolStrip_Click(sender As Object, e As EventArgs) Handles ProductosToolStrip.Click
        Dim frmProductos As New FrmProductos()
        SeleccionarForm(frmProductos)
    End Sub

    Private Sub GenerarPedidoToolStrip_Click(sender As Object, e As EventArgs) Handles GenerarPedidoToolStrip.Click
        Dim frmVentaProductos As New FrmVentaProductos()
        SeleccionarForm(frmVentaProductos)
    End Sub

    Private Sub EliminarModificarPedidoToolStrip_Click(sender As Object, e As EventArgs) Handles EliminarModificarPedidoToolStrip.Click
        Dim frmBajaModifVentas As New FrmBajaModifVentas()
        SeleccionarForm(frmBajaModifVentas)
    End Sub

    Private Sub VentasRealizadasToolStrip_Click(sender As Object, e As EventArgs) Handles VentasRealizadasToolStrip.Click
        Dim frmVentasRealizadas As New FrmVentasRealizadas()
        SeleccionarForm(frmVentasRealizadas)
    End Sub
    Private Sub PresupuestoMensualToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PresupuestoMensualToolStripMenuItem.Click
        Dim frmPresupuestos As New FrmPresupuestos()
        SeleccionarForm(frmPresupuestos)
    End Sub

    ''' <summary>
    ''' Permite abrir un formulario con un estilo determinado
    ''' </summary>
    ''' <param name="nombreForm"></param>
    Private Sub SeleccionarForm(nombreForm As Form)
        nombreForm.TopLevel = False
        nombreForm.FormBorderStyle = FormBorderStyle.None
        nombreForm.Dock = DockStyle.Fill

        SplitContainer1.Panel2.Controls.Clear()
        SplitContainer1.Panel2.Controls.Add(nombreForm)
        nombreForm.Show()
    End Sub


End Class
