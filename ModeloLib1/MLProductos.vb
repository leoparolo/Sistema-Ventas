Imports System.Data.SqlClient

Public Class MLProductos
    Private id As Integer
    Private nombre As String
    Private precio As Double
    Private categoria As String

    Public Sub New()

    End Sub
    Public Sub New(id As Integer, nombre As String, precio As Double, categoria As String)
        Me.id = id
        Me.nombre = nombre
        Me.precio = precio
        Me.categoria = categoria
    End Sub


    Public Function Mostrar() As DataTable
        Dim dt As New DataTable

        Dim conexion As New Conexion

        Using cmd As New SqlCommand
            cmd.Connection = conexion.AbrirConexion()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "SELECT * FROM productos"
            cmd.ExecuteNonQuery()
            Using adapter As New SqlDataAdapter(cmd)
                adapter.Fill(dt)
            End Using
        End Using
        conexion.CerrarConexion()
        Return dt
    End Function

    Public Sub Insertar()
        Dim conexion As New Conexion
        Using cmd As New SqlCommand
            cmd.Connection = conexion.AbrirConexion()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = $"INSERT INTO productos (Nombre,Precio,Categoria) VALUES ('{Me.nombre}',@precio,'{Me.categoria}')"
            cmd.Parameters.Add("@precio", SqlDbType.Float).Value = Me.precio
            cmd.ExecuteNonQuery()
        End Using
        conexion.CerrarConexion()
    End Sub

    Public Sub Eliminar()
        Dim conexion As New Conexion
        Using cmd As New SqlCommand
            cmd.Connection = conexion.AbrirConexion()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = $"DELETE FROM productos WHERE ID={Me.id}"
            cmd.ExecuteNonQuery()
        End Using
        conexion.CerrarConexion()
    End Sub

    Public Sub Actualizar()
        Dim conexion As New Conexion
        Using cmd As New SqlCommand
            cmd.Connection = conexion.AbrirConexion()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = $"UPDATE productos SET Nombre='{Me.nombre}',Precio=@precio,Categoria='{Me.categoria}' WHERE ID={Me.id}"
            cmd.Parameters.Add("@precio", SqlDbType.Float).Value = Me.precio
            cmd.ExecuteNonQuery()
        End Using
    End Sub

    Public Function ExisteProducto() As Boolean
        Dim result As Boolean = False
        Dim conexion As New Conexion
        Using cmd As New SqlCommand
            cmd.Connection = conexion.AbrirConexion()
            cmd.CommandType = CommandType.Text
            Try
                cmd.CommandText = $"SELECT 1 FROM productos WHERE Nombre='{Me.nombre}'"
                Using reader As SqlDataReader = cmd.ExecuteReader()
                    Result = reader.HasRows
                End Using
            Catch ex As Exception
                Result = False
            End Try
        End Using
        Return result
    End Function

    Public Function BuscarProducto(metodo As String, valorBuscado As String) As DataTable
        Dim dt As New DataTable
        Dim conexion As New Conexion
        Using cmd As New SqlCommand
            cmd.Connection = conexion.AbrirConexion()
            cmd.CommandType = CommandType.Text
            Try
                cmd.CommandText = $"SELECT * FROM productos WHERE {metodo} LIKE '%{valorBuscado}%'"
                cmd.ExecuteNonQuery()
                Using adapter As New SqlDataAdapter(cmd)
                    adapter.Fill(dt)
                End Using
            Catch ex As Exception
                dt.Clear()
            End Try
        End Using

        Return dt
    End Function

End Class
