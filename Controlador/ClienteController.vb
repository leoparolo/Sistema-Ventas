Imports Modelo

Public Class ClienteController
    Private ReadOnly _clienteDAO As New ClienteDAO
    Public Function GetClientes(condicion As String) As List(Of Cliente)
        Return _clienteDAO.Mostrar(condicion)
    End Function

    Public Sub EliminarCliente(ID As Integer)
        _clienteDAO.Eliminar(ID)
    End Sub

    Public Function InsertarCliente(clienteDatos As Cliente) As CustomMessage
        Return _clienteDAO.Insertar(clienteDatos)
    End Function

    Public Sub ModificarCliente(clienteDatos As Cliente)
        _clienteDAO.Modificar(clienteDatos)
    End Sub

End Class
