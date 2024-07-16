Imports Controlador
Imports Modelo

Public Class FrmClientes
    Private ReadOnly _clienteController As New ClienteController

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub FrmClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GVClientes.DataSource = _clienteController.GetClientes(txtBusqueda.Text)
        ConfigInicial()
    End Sub

    Private Sub ConfigInicial()
        txtID.Enabled = False
        btnEliminar.Enabled = False
        txtBusqueda.Text = ""
        FormatColumns(GVClientes)
    End Sub

    Private Sub LimpiarDatos()
        btnEliminar.Enabled = False
        txtID.Text = ""
        txtCliente.Text = ""
        txtTelefono.Text = ""
        txtCorreo.Text = ""
    End Sub

    Private Sub TxtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles txtBusqueda.TextChanged
        GVClientes.DataSource = _clienteController.GetClientes(txtBusqueda.Text)
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

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If MessageBox.Show("¿Esta seguro que desea eliminar este cliente?", "Confirmar eliminar cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            _clienteController.EliminarCliente(txtID.Text)
            MessageBox.Show("Cliente eliminado con exito!", "Eliminando cliente")
            GVClientes.DataSource = _clienteController.GetClientes("")
            LimpiarDatos()
        End If
    End Sub

    Private Sub BtnInsertar_Click(sender As Object, e As EventArgs) Handles btnInsertar.Click
        Dim clienteDatos As New Cliente(txtCliente.Text, txtTelefono.Text, txtCorreo.Text)
        Dim message As CustomMessage = _clienteController.InsertarCliente(clienteDatos)
        If message.Accion = "Exito" Then
            MessageBox.Show(message.Mensaje, "Cliente ingresado con exito!")
            GVClientes.DataSource = _clienteController.GetClientes("")
            LimpiarDatos()
        Else
            MessageBox.Show(message.Mensaje, message.Accion)
        End If
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If MessageBox.Show($"Desea modificar el cliente {txtID.Text} ? ", "Confirmar modificar cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Dim clienteDatos As New Cliente(txtCliente.Text, txtTelefono.Text, txtCorreo.Text)
            _clienteController.ModificarCliente(clienteDatos)
            MessageBox.Show("Cliente modificado con exito!", "Modificación exitosa!")
            GVClientes.DataSource = _clienteController.GetClientes("")
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