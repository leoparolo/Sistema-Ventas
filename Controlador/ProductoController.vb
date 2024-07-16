Imports Modelo

Public Class ProductoController
    Private ReadOnly _productoDAO As New ProductoDAO

    Public Function GetProducto(condicion As String) As List(Of Producto)
        Return _productoDAO.Mostrar(condicion)
    End Function

    Public Sub EliminarProducto(ID As Integer)
        _productoDAO.Eliminar(ID)
    End Sub

    Public Function InsertarProducto(productoDatos As Producto) As CustomMessage
        Return _productoDAO.Insertar(productoDatos)
    End Function

    Public Sub ModificarProducto(productoDatos As Producto)
        _productoDAO.Modificar(productoDatos)
    End Sub
End Class
