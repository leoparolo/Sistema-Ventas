Imports System.Data.SqlClient

Public Class VentaDAO

    Private ReadOnly dbContext As Conexion = Conexion.ObtenerInstancia()
    Private _customMsg As CustomMessage

    Public Function TraerUltimoNroPedido() As Integer
        Dim nroPedido As Integer
        Using cmd As New SqlCommand
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "SELECT MAX(ID) FROM ventas"
            cmd.Connection = dbContext.AbrirConexion()
            Dim result = cmd.ExecuteScalar()

            If result IsNot DBNull.Value Then
                nroPedido = Convert.ToInt32(result)
            Else
                nroPedido = 0
            End If
        End Using
        Return nroPedido
    End Function

    Public Sub InsertarCabecera(ventaCabeceraDatos As Venta)
        Using cmd As New SqlCommand
            cmd.CommandType = CommandType.Text
            cmd.CommandText = $"SET IDENTITY_INSERT ventas ON 
                                INSERT INTO ventas (ID,IDCliente,Fecha,Total) VALUES ({ventaCabeceraDatos.ID},{ventaCabeceraDatos.IDCliente},'{ventaCabeceraDatos.Fecha:yyyy-MM-dd HH:mm:ss}',@Total) 
                                SET IDENTITY_INSERT ventas OFF"
            cmd.Parameters.AddWithValue("@Total", ventaCabeceraDatos.Total)
            cmd.Connection = dbContext.AbrirConexion()
            cmd.ExecuteNonQuery()
            dbContext.CerrarConexion()
        End Using
    End Sub

    Public Sub InsertarDetalle(ventaDetalleDatos As VentaDetalle)
        Using cmd As New SqlCommand
            cmd.CommandType = CommandType.Text
            cmd.CommandText = $"INSERT INTO ventasitems 
                                (IDVenta,IDProducto,PrecioUnitario,Cantidad,PrecioTotal) 
                                VALUES ({ventaDetalleDatos.IDVenta},{ventaDetalleDatos.IDProducto},@Unitario,{ventaDetalleDatos.Cantidad},@Total)"
            cmd.Parameters.AddWithValue("@Unitario", ventaDetalleDatos.PrecioUnitario)
            cmd.Parameters.AddWithValue("@Total", ventaDetalleDatos.PrecioTotal)
            cmd.Connection = dbContext.AbrirConexion()
            cmd.ExecuteNonQuery()
            dbContext.CerrarConexion()
        End Using
    End Sub
End Class
