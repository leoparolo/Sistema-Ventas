Imports System.Configuration
Imports System.Data.SqlClient
''' <summary>
''' Utilizo patrón Singleton para asegurar que tenga una sola instancia de conexion a la base de datos. Evitando la sobrecarga de sesiones de la aplicacion al instancia la clase para cada conexion, 
''' es decir, utilizo una unica sesion que se abre y cierra para realizar peticiones de datos.
''' </summary>
Public Class Conexion

    Private Shared _instancia As Conexion

    Private ReadOnly _conexion As SqlConnection
    Private Sub New()
        _conexion = New SqlConnection(ConfigurationManager.ConnectionStrings("pruebademoConnectionString").ConnectionString)
    End Sub
    ''' <summary>
    ''' Instancia la clase Conexion
    ''' </summary>
    ''' <returns></returns>
    Public Shared Function ObtenerInstancia() As Conexion
        If _instancia Is Nothing Then
            _instancia = New Conexion
        End If
        Return _instancia
    End Function

    Public Function ObtenerConexion() As SqlConnection
        Return _conexion
    End Function
    Public Function AbrirConexion() As SqlConnection
        If _conexion.State = Nothing Then
            _conexion.Open()
        End If
        Return _conexion
    End Function

    Public Sub CerrarConexion()
        If _conexion.State = ConnectionState.Open Then
            _conexion.Close()
        End If
    End Sub


End Class
