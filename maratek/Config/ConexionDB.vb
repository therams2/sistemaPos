Imports MySql.Data.MySqlClient

Public Class ConexionDB
    Private conexion As MySqlConnection
    Private ReadOnly cadenaConexion As String

    Public Sub New()
        ' Define la cadena de conexión
        cadenaConexion = "server=62.72.5.222; port=3306; database=maratec; uid=rams; pwd=12345;"
        conexion = New MySqlConnection(cadenaConexion)
    End Sub
    ' Método para abrir la conexión
    Public Function AbrirConexion() As MySqlConnection
        Try
            If conexion.State = ConnectionState.Closed Then
                conexion.Open()


            End If
            Return conexion
        Catch ex As Exception
            Throw New Exception("Error al abrir la conexión: " & ex.Message)
            MessageBox.Show("Error al abrir la conexión")
        End Try
    End Function

    ' Método para cerrar la conexión
    Public Sub CerrarConexion()
        Try
            If conexion.State = ConnectionState.Open Then
                conexion.Close()
                Console.WriteLine("Conexión cerrada exitosamente.")
            End If
        Catch ex As Exception
            Throw New Exception("Error al cerrar la conexión: " & ex.Message)
        End Try
    End Sub
End Class
