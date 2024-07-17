Imports System.Data.SqlClient
Public Class ClienteDAO

    Private ReadOnly dbContext As Conexion = Conexion.ObtenerInstancia()
    Private _customMsg As CustomMessage
    ''' <summary>
    ''' Trae la tabla clientes a traves de una condición, lo que permite utilizarlo como un buscador
    ''' </summary>
    ''' <param name="condicion"></param>
    ''' <returns></returns>
    Public Function Mostrar(condicion As String) As List(Of Cliente)
        Dim clientes As New List(Of Cliente)
        Using cmd As New SqlCommand
            cmd.CommandType = CommandType.Text
            cmd.CommandText = $"SELECT ID,Cliente,Telefono,Correo FROM clientes WHERE id LIKE '%{condicion}%' OR cliente LIKE '%{condicion}' OR telefono LIKE '%{condicion}%' OR correo LIKE '%{condicion}%'"
            cmd.Connection = dbContext.AbrirConexion()
            Using dr As SqlDataReader = cmd.ExecuteReader()
                While dr.Read()
                    Dim readerCliente As New Cliente(dr.GetInt32(0), dr.GetString(1), dr.GetString(2), dr.GetString(3))
                    clientes.Add(readerCliente)
                End While
            End Using
            dbContext.CerrarConexion()
        End Using
        Return clientes
    End Function

    Public Sub Eliminar(ID As Integer)
        Using cmd As New SqlCommand
            cmd.CommandType = CommandType.Text
            cmd.CommandText = $"DELETE FROM clientes WHERE ID={ID}"
            cmd.Connection = dbContext.AbrirConexion()
            cmd.ExecuteNonQuery()
            dbContext.CerrarConexion()
        End Using
    End Sub

    Public Function Insertar(_clienteDatos As Cliente) As CustomMessage
        If _clienteDatos Is Nothing Then
            _customMsg = New CustomMessage With {
                .Mensaje = "No existen datos para insertar",
                .Accion = "Error"
            }
            Return _customMsg
        ElseIf Not ValidarExistencia(_clienteDatos.Cliente, dbContext.AbrirConexion()) Then
            _customMsg = New CustomMessage With {
                    .Mensaje = "El nombre del cliente ya existe",
                    .Accion = "Error"
                }
            Return _customMsg
        End If
        Using cmd As New SqlCommand
            cmd.CommandType = CommandType.Text
            cmd.CommandText = $"INSERT INTO clientes (Cliente,Telefono,Correo) VALUES('{_clienteDatos.Cliente}','{_clienteDatos.Telefono}','{_clienteDatos.Correo}')"
            cmd.Connection = dbContext.ObtenerConexion()
            cmd.ExecuteNonQuery()
            dbContext.CerrarConexion()
        End Using
        _customMsg = New CustomMessage With {
            .Mensaje = "Cliente insertado con exito!",
            .Accion = "Exito"}
        Return _customMsg
    End Function

    Private Function ValidarExistencia(cliente As String, conexion As SqlConnection)
        Using cmd As New SqlCommand
            cmd.CommandType = CommandType.Text
            cmd.CommandText = $"SELECT 1 FROM clientes WHERE Cliente='{cliente}'"
            cmd.Connection = conexion
            Using reader As SqlDataReader = cmd.ExecuteReader()
                Return reader.HasRows
            End Using
        End Using
    End Function

    Public Sub Modificar(_clienteDatos As Cliente)
        Using cmd As New SqlCommand
            cmd.CommandType = CommandType.Text
            cmd.CommandText = $"UPDATE clientes SET Cliente='{_clienteDatos.Cliente}',Telefono='{_clienteDatos.Telefono}',Correo='{_clienteDatos.Correo}' WHERE ID={_clienteDatos.ID}"
            cmd.Connection = dbContext.AbrirConexion()
            cmd.ExecuteNonQuery()
            dbContext.CerrarConexion()
        End Using
    End Sub
End Class
