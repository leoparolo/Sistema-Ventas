Imports System.Net.Sockets
Imports ModeloLib

Public Class CLProductos

    Public Function MostrarProductos() As DataTable
        Dim producto As New MLProductos
        Return producto.Mostrar()
    End Function

    Public Sub EliminarProducto(id As Integer)
        Dim producto As New MLProductos(id, "", 0, "")
        producto.Eliminar()
    End Sub

    Public Sub InsertarProducto(nombre As String, precio As Double, categoria As String)
        Dim productoDatos As New MLProductos(0, nombre, precio, categoria)
        productoDatos.Insertar()
    End Sub

    Public Function ValidarDatosProducto(nombre As String) As Boolean
        Dim productoDatos As New MLProductos(0, nombre, 0, "")
        Return productoDatos.ExisteProducto()
    End Function

    Public Sub ModificarProducto(id As Integer, nombre As String, precio As Double, categoria As String)
        Dim productoDatos As New MLProductos(id, nombre, precio, categoria)
        productoDatos.Actualizar()
    End Sub

    Public Function BuscarProducto(metodo As String, valorFiltro As String) As DataTable
        Dim productoDatos As New MLProductos
        Return productoDatos.BuscarProducto(metodo, valorFiltro)
    End Function
End Class
