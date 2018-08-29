Imports System.Data.SqlClient
Imports Teatro.ClassConexion
Public Class ClassProductor
    Public Shared Function BuscarRUNProductor(ByVal strRUNProductor As String) As Boolean
        Conexion.Close()
        Try
            Conexion.Open()
            Dim Cadena As String = "SELECT RUNENCARGADO FROM PRODUCCION;"
            Dim DAdapter As New SqlDataAdapter(Cadena, Conexion)
            Dim DTable As New DataTable
            Dim DRow As DataRow = Nothing
            DAdapter.Fill(DTable)
            'Una vez validado el Rut, se evalua si los datos pertenecen a algún usuario registrado
            For Each DRow In DTable.Rows
                If strRUNProductor = DRow("RUNENCARGADO").ToString Then
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
