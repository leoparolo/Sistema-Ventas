Imports ControladorLib

Public Class FrmClientes
    Private Sub FrmClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConfigInicial()
        TraerClientes()
    End Sub

    Private Sub ConfigInicial()
        txtID.Enabled = False
        btnEliminar.Enabled = False
    End Sub
    Private Sub TraerClientes()
        Dim controlador As New CLClientes
        GVClientes.DataSource = controlador.MostrarCliente()
        For Each column As DataGridViewColumn In GVClientes.Columns
            column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            column.HeaderCell.Style.Font = New Font(GVClientes.Font, FontStyle.Bold)
        Next
    End Sub
    Private Sub LimpiarDatos()
        txtID.Text = ""
        txtCliente.Text = ""
        txtTelefono.Text = ""
        txtCorreo.Text = ""
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If MessageBox.Show("¿Esta seguro que desea eliminar este cliente?", "Confirmar eliminar cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Dim controlador As New CLClientes
            controlador.EliminarCliente(txtID.Text)
            MessageBox.Show("Cliente eliminado con exito!", "Eliminando cliente")
            TraerClientes()
            LimpiarDatos()
            btnEliminar.Enabled = False
        End If

    End Sub

    Private Sub btnInsertar_Click(sender As Object, e As EventArgs) Handles btnInsertar.Click
        If ValidarDatos() Then
            Dim controlador As New CLClientes
            controlador.InsertarCliente(txtCliente.Text, txtTelefono.Text, txtCorreo.Text)
            MessageBox.Show("Cliente ingresado con exito!", "Ingreso exitoso!")
            TraerClientes()
            LimpiarDatos()
            btnEliminar.Enabled = False
        End If
    End Sub
    Private Function ValidarDatos() As Boolean
        Dim result As Boolean = True
        Dim controlador As New CLClientes
        If controlador.ValidarDatosCliente(txtCliente.Text) Then
            MessageBox.Show("El cliente ya existe, por favor ingrese otro nombre")
            result = False
        End If
        Return result
    End Function
    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If MessageBox.Show($"Desea modificar el cliente {txtID.Text} ? ", "Confirmar modificar cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Dim controlador As New CLClientes
            controlador.ModificarCliente(txtID.Text, txtCliente.Text, txtTelefono.Text, txtCorreo.Text)
            MessageBox.Show("Cliente modificado con exito!", "Modificación exitosa!")
            TraerClientes()
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
    Private Sub GVClientes_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles GVClientes.CellDoubleClick

        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            Dim selectedRow = GVClientes.Rows(e.RowIndex)
            txtID.Text = selectedRow.Cells("ID").Value.ToString()
            txtCliente.Text = selectedRow.Cells("Cliente").Value.ToString()
            txtTelefono.Text = selectedRow.Cells("Telefono").Value.ToString()
            txtCorreo.Text = selectedRow.Cells("Correo").Value.ToString()

            btnEliminar.Enabled = True
        End If
    End Sub










End Class