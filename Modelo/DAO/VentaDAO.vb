Imports System.Data.SqlClient
Imports System.Threading

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
    Public Function ValidarBusquedaPedido(nroPedido As Integer) As CustomMessage
        If Not ExistePedido(nroPedido) Then
            _customMsg = New CustomMessage With {
                .Mensaje = "El número de pedido no existe",
                .Accion = "Error"}
        End If
        _customMsg = New CustomMessage With {
            .Mensaje = "Validación exitosa",
        .Accion = "Exito"}
        Return _customMsg
    End Function
    Public Function ExistePedido(nroPedido As Integer) As Boolean
        Using cmd As New SqlCommand
            cmd.CommandType = CommandType.Text
            cmd.CommandText = $"SELECT 1 FROM ventas WHERE ID = {nroPedido}"
            cmd.Connection = dbContext.AbrirConexion()
            Using reader As SqlDataReader = cmd.ExecuteReader()
                Return reader.HasRows
            End Using
        End Using
    End Function

    Public Function TraerPedido(nroPedido As Integer) As Venta
        Dim ventaDatos As New Venta
        Using cmd As New SqlCommand
            cmd.CommandType = CommandType.Text
            cmd.CommandText = $"SELECT * FROM ventas WHERE ID = {nroPedido}"
            cmd.Connection = dbContext.AbrirConexion()
            Using reader As SqlDataReader = cmd.ExecuteReader()
                While reader.Read()
                    ventaDatos.ID = reader("ID")
                    ventaDatos.IDCliente = reader("IDCliente")
                    ventaDatos.Fecha = reader("Fecha")
                    ventaDatos.Total = reader("Total")

                End While
            End Using
            cmd.CommandText = $"SELECT * FROM ventasitems WHERE IDVenta = {nroPedido}"
            Using reader As SqlDataReader = cmd.ExecuteReader()
                While reader.Read()
                    Dim ventaDetalleDatos As New VentaDetalle With {
                        .ID = reader("ID"),
                        .IDVenta = reader("IDVenta"),
                        .IDProducto = reader("IDProducto"),
                        .PrecioUnitario = reader("PrecioUnitario"),
                        .Cantidad = reader("Cantidad"),
                        .PrecioTotal = reader("PrecioTotal")}
                    ventaDatos.Detalle.Add(ventaDetalleDatos)
                End While
            End Using
        End Using
        Return ventaDatos
    End Function

    Public Function TraerPedido(_clienteCondicion As String, _fechaCondicion As DateTime, _nroPedidoCondicion As Integer) As Ventas

        Dim rptVentas As New Ventas
        Using cmd As New SqlCommand
            cmd.CommandType = CommandType.Text
            cmd.CommandText = $"SELECT * FROM ventas WHERE ID LIKE '%{_nroPedidoCondicion}%' OR Fecha LIKE '%{_fechaCondicion}%' OR IDCliente LIKE '%{_clienteCondicion}%'"
            cmd.Connection = dbContext.AbrirConexion()
            Using reader As SqlDataReader = cmd.ExecuteReader()
                While reader.Read()
                    Dim ventaDatos As New Venta With {
                        .ID = reader("ID"),
                        .IDCliente = reader("IDCliente"),
                        .Fecha = reader("Fecha"),
                        .Total = reader("Total")
                    }
                    rptVentas.Ventas.Add(ventaDatos)
                End While
            End Using
        End Using
        Return rptVentas
    End Function

    Public Sub Eliminar(nroPedido As Integer)
        Using cmd As New SqlCommand
            cmd.CommandType = CommandType.Text
            cmd.CommandText = $"DELETE FROM ventas WHERE ID = {nroPedido}"
            cmd.Connection = dbContext.AbrirConexion()
            cmd.ExecuteNonQuery()
            cmd.CommandText = $"DELETE FROM ventasitems WHERE IDVenta = {nroPedido}"
            cmd.ExecuteNonQuery()
        End Using
    End Sub

End Class
