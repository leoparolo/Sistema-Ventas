Imports System.Configuration
Imports System.Data.SqlClient

Public Class Conexion
    Private conexion As String = ConfigurationManager.ConnectionStrings("pruebademoConnectionString").ConnectionString
    Private conn As SqlConnection

    Public Function AbrirConexion() As SqlConnection
        Try
            If conn Is Nothing Then
                conn = New SqlConnection(conexion)
            End If

            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
        Catch ex As Exception

        End Try
        Return conn
    End Function

    Public Function CerrarConexion() As SqlConnection
        Try
            If conn IsNot Nothing AndAlso conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        Catch ex As Exception

        End Try
        Return conn
    End Function

End Class
