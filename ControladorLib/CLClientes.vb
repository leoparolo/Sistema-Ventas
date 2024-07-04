Imports ModeloLib
Public Class CLClientes

    Public Function MostrarCliente() As DataTable
        Dim cliente As New MLClientes
        Return cliente.Mostrar()
    End Function

    Public Sub EliminarCliente(id As Integer)
        Dim cliente As New MLClientes(id, "", "", "")
        cliente.Eliminar()
    End Sub

    Public Sub InsertarCliente(cliente As String, telefono As String, correo As String)
        Dim clienteDatos As New MLClientes(0, cliente, telefono, correo)
        clienteDatos.Insertar()
    End Sub

    Public Function ValidarDatosCliente(cliente As String) As Boolean
        Dim clienteDatos As New MLClientes(0, cliente, "", "")
        Return clienteDatos.ExisteCliente()
    End Function

    Public Sub ModificarCliente(id As Integer, cliente As String, telefono As String, correo As String)
        Dim clienteDatos As New MLClientes(id, cliente, telefono, correo)
        clienteDatos.Actualizar()
    End Sub

    Public Function BuscarCliente(metodo As String, valorFiltro As String) As DataTable
        Dim clienteDatos As New MLClientes
        Return clienteDatos.BuscarCliente(metodo, valorFiltro)
    End Function

End Class
