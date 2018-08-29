Imports Teatro.ClassConexion
Imports System.Data.SqlClient
Public Class ClassAdministrador
    Public Shared Function BuscarRUNAdministrador(ByVal strRUNAdministrador As String) As Boolean
        Conexion.Close()
        Try
            Conexion.Open()
            Dim Cadena As String = "SELECT RUNADMINISTRADOR FROM ADMINISTRADORES;"
            Dim DAdapter As New SqlDataAdapter(Cadena, Conexion)
            Dim DTable As New DataTable
            Dim DRow As DataRow = Nothing
            DAdapter.Fill(DTable)
            'Una vez validado el Rut, se evalua si los datos pertenecen a algún usuario registrado
            For Each DRow In DTable.Rows
                If strRUNAdministrador = DRow("RUNADMINISTRADOR").ToString Then
                    Return True
                    Exit Function
                End If
            Next
            Return False
        Catch ex As Exception
            MsgBox("Se ha producido el siguiente error: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            Conexion.Close()
        End Try
    End Function
End Class
