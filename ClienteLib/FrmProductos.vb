Imports ControladorLib

Public Class FrmProductos
    Private Sub FrmProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConfigInicial()
        TraerProductos()
    End Sub

    Private Sub ConfigInicial()
        txtID.Enabled = False
        btnEliminar.Enabled = False
    End Sub

    Private Sub TraerProductos()
        Dim controlador As New CLProductos
        GVProductos.DataSource = controlador.MostrarProductos()
        For Each column As DataGridViewColumn In GVProductos.Columns
            column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            column.HeaderCell.Style.Font = New Font(GVProductos.Font, FontStyle.Bold)
        Next
    End Sub

    Private Sub LimpiarDatos()
        txtID.Text = ""
        txtNombre.Text = ""
        txtPrecio.Text = ""
        txtCategoria.Text = ""
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If MessageBox.Show("¿Esta seguro que desea eliminar este producto?", "Confirmar eliminar producto", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Dim controlador As New CLProductos
            controlador.EliminarProducto(txtID.Text)
            MessageBox.Show("Producto eliminado con exito!", "Eliminando producto")
            TraerProductos()
            LimpiarDatos()
            btnEliminar.Enabled = False
        End If
    End Sub
    Private Sub btnInsertar_Click(sender As Object, e As EventArgs) Handles btnInsertar.Click
        If ValidarDatos() Then
            Dim precio As Double
            Double.TryParse(txtPrecio.Text, precio)
            Dim controlador As New CLProductos
            controlador.InsertarProducto(txtNombre.Text, precio, txtCategoria.Text)
            MessageBox.Show("Producto ingresado con exito!", "Ingreso exitoso!")
            TraerProductos()
            LimpiarDatos()
            btnEliminar.Enabled = False
        End If
    End Sub
    Private Function ValidarDatos() As Boolean
        Dim result As Boolean = True
        Dim precio As Double
        Dim controlador As New CLProductos
        txtPrecio.Text = txtPrecio.Text.Replace(".", ",")
        If Not Double.TryParse(txtPrecio.Text, precio) Then
            result = False
            MessageBox.Show("Ingrese un precio válido", "Formato incorrecto de precio")
        End If
        If controlador.ValidarDatosProducto(txtNombre.Text) Then
            MessageBox.Show("El nombre del producto ya existe, por favor ingrese otro nombre")
            result = False
        End If
        Return result
    End Function
    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If MessageBox.Show($"Desea modificar el producto {txtID.Text} ? ", "Confirmar modificar producto", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Dim precio As Double
            Double.TryParse(txtPrecio.Text, precio)
            Dim controlador As New CLProductos
            controlador.ModificarProducto(txtID.Text, txtNombre.Text, precio, txtCategoria.Text)
            MessageBox.Show("Producto modificado con exito!", "Modificación exitosa!")
            TraerProductos()
            LimpiarDatos()
            btnEliminar.Enabled = False
        End If
    End Sub
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub
    Private Sub btnLimpiarDatos_Click(sender As Object, e As EventArgs) Handles btnLimpiarDatos.Click
        LimpiarDatos()
        btnEliminar.Enabled = False
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










End Class