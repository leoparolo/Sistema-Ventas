Imports System.Data.SqlClient

Public Class MLClientes
    Private id As Integer
    Private cliente As String
    Private telefono As String
    Private correo As String

    Public Sub New()

    End Sub
    Public Sub New(id As Integer, cliente As String, telefono As String, correo As String)
        Me.id = id
        Me.cliente = cliente
        Me.telefono = telefono
        Me.correo = correo
    End Sub


    Public Function Mostrar() As DataTable
        Dim dt As New DataTable

        Dim conexion As New Conexion

        Using cmd As New SqlCommand
            cmd.Connection = conexion.AbrirConexion()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "SELECT * FROM clientes"
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
            cmd.CommandText = $"INSERT INTO clientes (Cliente,Telefono,Correo) VALUES('{Me.cliente}','{Me.telefono}','{Me.correo}')"
            cmd.ExecuteNonQuery()
        End Using
        conexion.CerrarConexion()
    End Sub

    Public Sub Eliminar()
        Dim conexion As New Conexion
        Using cmd As New SqlCommand
            cmd.Connection = conexion.AbrirConexion()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = $"DELETE FROM clientes WHERE ID={Me.id}"
            cmd.ExecuteNonQuery()
        End Using
        conexion.CerrarConexion()
    End Sub

    Public Sub Actualizar()
        Dim conexion As New Conexion
        Using cmd As New SqlCommand
            cmd.Connection = conexion.AbrirConexion()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = $"UPDATE clientes SET Cliente='{Me.cliente}',Telefono='{Me.telefono}',Correo='{Me.correo}' WHERE ID={Me.id}"
            cmd.ExecuteNonQuery()
        End Using
    End Sub

    Public Function ExisteCliente() As Boolean
        Dim result As Boolean = False
        Dim conexion As New Conexion
        Using cmd As New SqlCommand
            cmd.Connection = conexion.AbrirConexion()
            cmd.CommandType = CommandType.Text
            Try
                cmd.CommandText = $"SELECT 1 FROM clientes WHERE Cliente='{Me.cliente}'"
                Using reader As SqlDataReader = cmd.ExecuteReader()
                    result = reader.HasRows
                End Using
            Catch ex As Exception
                result = False
            End Try
        End Using
        Return result
    End Function

    Public Function BuscarCliente(metodo As String, valorBuscado As String) As DataTable
        Dim dt As New DataTable
        Dim conexion As New Conexion
        Using cmd As New SqlCommand
            cmd.Connection = conexion.AbrirConexion()
            cmd.CommandType = CommandType.Text
            Try
                cmd.CommandText = $"SELECT * FROM clientes WHERE {metodo} LIKE '%{valorBuscado}%'"
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
