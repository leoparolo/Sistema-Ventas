Imports System.Data.SqlClient
Imports System.Data.SqlTypes

Public Class MLVentas
    Private id As Integer
    Private idCliente As Integer
    Private fecha As DateTime
    Private total As Double
    Public Sub New()

    End Sub
    Public Sub New(id As Integer, idCliente As Integer, fecha As Date, total As Double)
        Me.id = id
        Me.idCliente = idCliente
        Me.fecha = fecha
        Me.total = total
    End Sub

    Public Function UltimoNroPedido() As Integer
        Dim nroPedido As Integer = 0

        Dim conexion As New Conexion
        Using cmd As New SqlCommand
            cmd.Connection = conexion.AbrirConexion()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "SELECT MAX(ID) FROM ventas"
            Dim result = cmd.ExecuteScalar()

            If result IsNot DBNull.Value Then
                nroPedido = Convert.ToInt32(result)
            Else
                nroPedido = 0
            End If
        End Using
        conexion.CerrarConexion()
        Return nroPedido
    End Function

    Public Sub Insertar()
        Dim conexion As New Conexion
        Using cmd As New SqlCommand
            cmd.Connection = conexion.AbrirConexion()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = $"SET IDENTITY_INSERT ventas ON INSERT INTO ventas (ID,IDCliente,Fecha,Total) VALUES ({Me.id},{Me.idCliente},'{Me.fecha}',@precioTotal) SET IDENTITY_INSERT ventas OFF"
            cmd.Parameters.Add("@precioTotal", SqlDbType.Float).Value = Me.total
            cmd.ExecuteNonQuery()
        End Using
        conexion.CerrarConexion()
    End Sub

    Public Function ExisteNroPedido(nroPedido As Integer) As Boolean
        Dim result As Boolean = False
        Dim conexion As New Conexion
        Using cmd As New SqlCommand
            cmd.Connection = conexion.AbrirConexion()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = $"SELECT 1 FROM ventas WHERE ID = {nroPedido}"
            Using reader As SqlDataReader = cmd.ExecuteReader()
                result = reader.HasRows
            End Using
        End Using
        Return result
    End Function
    ''' <summary>
    ''' Busca un pedido por su numero de pedido
    ''' </summary>
    ''' <param name="nroPedido"></param>
    ''' <returns></returns>
    Public Function BuscarPedido(nroPedido As Integer) As DataTable
        Dim dt As New DataTable
        Dim conexion As New Conexion
        Using cmd As New SqlCommand
            cmd.Connection = conexion.AbrirConexion()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = $"SELECT ventas.ID,IDCliente,clientes.Cliente,Fecha,Total FROM ventas INNER JOIN clientes ON ventas.IDCliente = clientes.ID WHERE ventas.ID = {nroPedido}"
            Using adapter As New SqlDataAdapter(cmd)
                adapter.Fill(dt)
            End Using
        End Using
        conexion.CerrarConexion()
        Return dt
    End Function

    ''' <summary>
    ''' Busca todos los pedidos confeccionados
    ''' </summary>
    ''' <returns></returns>
    Public Function BuscarPedido() As DataTable
        Dim dt As New DataTable
        Dim conexion As New Conexion
        Using cmd As New SqlCommand
            cmd.Connection = conexion.AbrirConexion()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "SELECT ventas.ID AS Pedido,clientes.Cliente,ventas.Fecha,ventas.Total as Importe FROM ventas INNER JOIN clientes ON ventas.IDCliente = clientes.ID"
            Using adapter As New SqlDataAdapter(cmd)
                adapter.Fill(dt)
            End Using
        End Using
        conexion.CerrarConexion()
        Return dt
    End Function
    ''' <summary>
    ''' Busca un pedido segun los filtros aplicados
    ''' </summary>
    ''' <param name="chkCliente"></param>
    ''' <param name="Cliente"></param>
    ''' <param name="chkFecha"></param>
    ''' <param name="Fecha"></param>
    ''' <param name="chkNroPedido"></param>
    ''' <param name="NroPedido"></param>
    ''' <returns></returns>
    Public Function BuscarPedido(chkCliente As Boolean, Cliente As String, chkFecha As Boolean, Fecha As DateTime, chkNroPedido As Boolean, NroPedido As Integer) As DataTable

        Dim dt As New DataTable
        Dim conexion As New Conexion
        Using cmd As New SqlCommand
            cmd.Connection = conexion.AbrirConexion()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "SELECT ventas.ID AS Pedido,clientes.Cliente,ventas.Fecha,ventas.Total as Importe FROM ventas INNER JOIN clientes ON ventas.IDCliente = clientes.ID WHERE " + ArmaCadenaFiltro(chkCliente, Cliente, chkFecha, Fecha, chkNroPedido, NroPedido)
            Using adapter As New SqlDataAdapter(cmd)
                adapter.Fill(dt)
            End Using
        End Using
        conexion.CerrarConexion()
        Return dt
    End Function
    Private Function ArmaCadenaFiltro(chkCliente As Boolean, Cliente As String, chkFecha As Boolean, Fecha As DateTime, chkNroPedido As Boolean, NroPedido As Integer) As String
        Dim filtro As New List(Of String)
        If chkCliente Then
            filtro.Add($" clientes.Cliente LIKE '%{Cliente}%'")
        End If
        If chkFecha Then
            filtro.Add($" ventas.Fecha = '{Fecha}'")
        End If
        If chkNroPedido Then
            filtro.Add($" ventas.ID = {NroPedido}")
        End If

        Return String.Join(" AND ", filtro)

    End Function
    Public Sub Eliminar(nroPedido As Integer)
        Dim conexion As New Conexion
        Using cmd As New SqlCommand
            cmd.Connection = conexion.AbrirConexion()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = $"DELETE FROM ventas WHERE ID = {nroPedido}"
            cmd.ExecuteNonQuery()
        End Using
        conexion.CerrarConexion()
    End Sub

    Public Sub Actualizar(total As Double, nroPedido As Integer)
        Dim conexion As New Conexion
        Using cmd As New SqlCommand
            cmd.Connection = conexion.AbrirConexion()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = $"UPDATE ventas SET Total = {total} WHERE ID = {nroPedido}"
            cmd.ExecuteNonQuery()
        End Using
        conexion.CerrarConexion()
    End Sub

    Public Function PresupuestoMensual(Año As Integer, Mes As Integer) As DataTable
        Dim dt As New DataTable
        Dim conexion As New Conexion
        Using cmd As New SqlCommand
            cmd.Connection = conexion.AbrirConexion()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = $"SELECT productos.Nombre AS Producto, YEAR(ventas.Fecha) AS Año, MONTH(ventas.Fecha) AS Mes, SUM(ventasitems.Cantidad) AS 'Total vendido' FROM ventas INNER JOIN ventasitems ON ventas.ID = ventasitems.IDVenta INNER JOIN productos ON ventasitems.IDProducto = productos.ID WHERE YEAR(ventas.Fecha) = {Año} AND MONTH(ventas.Fecha) = {Mes} GROUP BY productos.Nombre, YEAR(ventas.Fecha), MONTH(ventas.Fecha) ORDER BY Nombre, Año, Mes"
            Using adapter As New SqlDataAdapter(cmd)
                adapter.Fill(dt)
            End Using
        End Using
        conexion.CerrarConexion()
        Return dt
    End Function
End Class
