Imports System.Data.SqlClient

Public Class ProductoDAO

    Private ReadOnly dbContext As Conexion = Conexion.ObtenerInstancia()
    Private _customMsg As CustomMessage

    Public Function Mostrar(condicion As String) As List(Of Producto)
        Dim productos As New List(Of Producto)
        Using cmd As New SqlCommand
            cmd.CommandType = CommandType.Text
            cmd.CommandText = $"SELECT * FROM productos WHERE ID LIKE '%{condicion}%' OR Nombre LIKE '%{condicion}%' OR Categoria LIKE '%{condicion}%' OR Precio LIKE '%{condicion}%'"
            cmd.Connection = dbContext.AbrirConexion()
            Using dr As SqlDataReader = cmd.ExecuteReader()
                While dr.Read()
                    Dim readerProducto As New Producto(dr.GetInt32(0), dr.GetString(1), dr.GetDouble(2), dr.GetString(3))
                    productos.Add(readerProducto)
                End While
            End Using
            dbContext.CerrarConexion()
        End Using
        Return productos
    End Function

    Public Sub Eliminar(ID As Integer)
        Using cmd As New SqlCommand
            cmd.CommandType = CommandType.Text
            cmd.CommandText = $"DELETE FROM productos WHERE ID={ID}"
            cmd.Connection = dbContext.AbrirConexion()
            cmd.ExecuteNonQuery()
            dbContext.CerrarConexion()
        End Using
    End Sub

    Public Function Insertar(_productosDatos As Producto)
        If _productosDatos Is Nothing Then
            _customMsg = New CustomMessage With {
                .Mensaje = "No existen datos para insertar",
                .Accion = "Error"
            }
        ElseIf Not ValidarExistencia(_productosDatos.Nombre, dbContext.AbrirConexion()) Then
            _customMsg = New CustomMessage With {
                .Mensaje = "El nombre del producto ya existe",
                .Accion = "Error"
            }
            Return _customMsg
        End If
        Using cmd As New SqlCommand
            cmd.CommandType = CommandType.Text
            cmd.CommandText = $"INSERT INTO productos (Nombre,Precio,Categoria) VALUES ('{_productosDatos.Nombre}',@precio,'{_productosDatos.Categoria}')"
            cmd.Parameters.Add("@precio", SqlDbType.Float).Value = _productosDatos.Precio
            cmd.Connection = dbContext.ObtenerConexion()
            cmd.ExecuteNonQuery()
            dbContext.CerrarConexion()
        End Using
        _customMsg = New CustomMessage With {
            .Mensaje = "Producto ingresado con exito!",
            .Accion = "Exito"}
        Return _customMsg
    End Function

    Private Function ValidarExistencia(producto As String, conexion As SqlConnection)
        Using cmd As New SqlCommand
            cmd.CommandType = CommandType.Text
            cmd.CommandText = $"SELECT 1 FROM productos WHERE Nombre = {producto}"
            cmd.Connection = conexion
            Using reader As SqlDataReader = cmd.ExecuteReader()
                Return reader.HasRows
            End Using
        End Using
    End Function

    Public Sub Modificar(_productoDatos As Producto)
        Using cmd As New SqlCommand
            cmd.CommandType = CommandType.Text
            cmd.CommandText = $"UPDATE productos SET Nombre='{_productoDatos.Nombre}',Precio=@precio,Categoria='{_productoDatos.Categoria}' WHERE ID={_productoDatos.ID}"
            cmd.Parameters.Add("@precio", SqlDbType.Float).Value = _productoDatos.Precio
            cmd.Connection = dbContext.AbrirConexion()
            cmd.ExecuteNonQuery()
            dbContext.CerrarConexion()
        End Using
    End Sub
End Class
