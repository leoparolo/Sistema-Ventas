Imports System.Data.SqlClient

Public Class MLVentasitems
    Private id As Integer
    Private idVenta As Integer
    Private idProducto As Integer
    Private precioUnitario As Double
    Private cantidad As Double
    Private precioTotal As Double

    Public Sub New()

    End Sub
    Public Sub New(idVenta As Integer, idProducto As Integer, precioUnitario As Double, cantidad As Double, precioTotal As Double)
        Me.idVenta = idVenta
        Me.idProducto = idProducto
        Me.precioUnitario = precioUnitario
        Me.cantidad = cantidad
        Me.precioTotal = precioTotal
    End Sub

    Public Sub Insertar()
        Dim conexion As New Conexion
        Using cmd As New SqlCommand
            cmd.Connection = conexion.AbrirConexion()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = $"INSERT INTO ventasitems (IDVenta,IDProducto,PrecioUnitario,Cantidad,PrecioTotal) VALUES ({Me.idVenta},{Me.idProducto},@PrecioUnitario,{Me.cantidad},@PrecioTotal)"
            cmd.Parameters.Add("@PrecioUnitario", SqlDbType.Float).Value = precioUnitario
            cmd.Parameters.Add("@PrecioTotal", SqlDbType.Float).Value = precioTotal
            cmd.ExecuteNonQuery()
        End Using
        conexion.CerrarConexion()
    End Sub

    Public Function BuscarDetallePedido(nroPedido As Integer) As DataTable
        Dim conexion As New Conexion
        Dim dt As New DataTable
        Using cmd As New SqlCommand
            cmd.Connection = conexion.AbrirConexion()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = $"SELECT ventasitems.IDProducto AS ID,productos.Nombre,PrecioUnitario as 'Unitario ($)',Cantidad,PrecioTotal as 'Total ($)' FROM ventasitems INNER JOIN productos ON ventasitems.IDProducto = productos.ID WHERE IDVenta = {nroPedido}"
            Using adapter As New SqlDataAdapter(cmd)
                adapter.Fill(dt)
            End Using
        End Using
        conexion.CerrarConexion()
        Return dt
    End Function

    Public Sub Eliminar(nroPedido As Integer)
        Dim conexion As New Conexion
        Using cmd As New SqlCommand
            cmd.Connection = conexion.AbrirConexion()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = $"DELETE FROM ventasitems WHERE IDVenta = {nroPedido}"
            cmd.ExecuteNonQuery()
        End Using
        conexion.CerrarConexion()
    End Sub

End Class
