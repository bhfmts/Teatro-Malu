Imports System.Data.SqlClient
Public Class ClassConexion
    Public Shared Cadena As String = "Data Source=BERNARDO;Initial Catalog=Teatro;Persist Security Info=True;User ID=bernardo;Password=123"
    Public Shared Conexion As New SqlConnection(Cadena)
    Public Shared Sub ConectarBD()
        Try
            If Conexion.State = ConnectionState.Closed Then
                Conexion.Open()
            End If
        Catch ex As SqlException
            MsgBox("Error de conexión :( Verifique la conexión de su cable de red" + ex.Message)
        End Try
    End Sub
End Class
