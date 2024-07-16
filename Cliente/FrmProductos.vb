Imports Controlador
Imports Modelo

Public Class FrmProductos
    Private ReadOnly _productoController As New ProductoController
    Public Sub New()
        InitializeComponent()
    End Sub
    Private Sub FrmProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GVProductos.DataSource = _productoController.GetProducto(txtBusqueda.Text)
        ConfigInicial()
    End Sub

    Private Sub ConfigInicial()
        txtID.Enabled = False
        btnEliminar.Enabled = False
        txtBusqueda.Text = ""
        FormatColumns(GVProductos)
    End Sub
    Private Sub LimpiarDatos()
        btnEliminar.Enabled = False
        txtID.Text = ""
        txtNombre.Text = ""
        txtPrecio.Text = ""
        txtCategoria.Text = ""
    End Sub

    Private Sub TxtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles txtBusqueda.TextChanged
        GVProductos.DataSource = _productoController.GetProducto(txtBusqueda.Text)
    End Sub

    Private Sub GVProductos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles GVProductos.CellDoubleClick

        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            Dim selectedRow = GVProductos.Rows(e.RowIndex)
            txtID.Text = selectedRow.Cells("ID").Value.ToString()
            txtNombre.Text = selectedRow.Cells("Nombre").Value.ToString()
            txtPrecio.Text = selectedRow.Cells("Precio").Value.ToString()
            txtCategoria.Text = selectedRow.Cells("Categoria").Value.ToString()

            btnEliminar.Enabled = True
        End If
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If MessageBox.Show("¿Esta seguro que desea eliminar este producto?", "Confirmar eliminar producto", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            _productoController.EliminarProducto(txtID.Text)
            MessageBox.Show("Producto eliminado con exito!", "Eliminando producto")
            GVProductos.DataSource = _productoController.GetProducto("")
            LimpiarDatos()
        End If
    End Sub
    Private Sub BtnInsertar_Click(sender As Object, e As EventArgs) Handles btnInsertar.Click
        Dim precio As Double
        Double.TryParse(txtPrecio.Text, precio)
        Dim productoDatos As New Producto(txtNombre.Text, precio, txtCategoria.Text)
        Dim message As CustomMessage = _productoController.InsertarProducto(productoDatos)
        If message.Accion = "Exito" Then
            MessageBox.Show(message.Mensaje, "Cliente ingresado con exito!")
            GVProductos.DataSource = _productoController.GetProducto("")
            LimpiarDatos()
        Else
            MessageBox.Show(message.Mensaje, message.Accion)
        End If
    End Sub
    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If MessageBox.Show($"Desea modificar el producto {txtID.Text} ? ", "Confirmar modificar producto", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Dim precio As Double
            Double.TryParse(txtPrecio.Text, precio)
            Dim productoDatos As New Producto(txtNombre.Text, precio, txtCategoria.Text)
            _productoController.ModificarProducto(productoDatos)
            MessageBox.Show("Producto modificado con exito!", "Modificación exitosa!")
            GVProductos.DataSource = _productoController.GetProducto("")
            LimpiarDatos()
        End If
    End Sub
    Private Sub BtnLimpiarDatos_Click(sender As Object, e As EventArgs) Handles btnLimpiarDatos.Click
        LimpiarDatos()
    End Sub
    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub




End Class