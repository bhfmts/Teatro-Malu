Imports System.Data.SqlClient
Imports Teatro.ClassConexion
Public Class ClassPersona
    Public strRUNPersona As String
    Public strNombrePersona As String
    Public strApellidoPersona As String
    Public strDireccionPersona As String          ''<--- Declaración de atributos de la clase persona''
    Public strTelefonoPersona As Integer
    Private _strContraseñaPersona As String
    Public strFechaNacimientoPersona As Date

    'Public Property strContraseña() As String
    '    Get
    '        Return Me._strContraseñaPersona
    '    End Get
    '    Set(ByVal value As String)
    '        If strContraseña.Length >= 7 Then
    '            Me._strContraseñaPersona = value
    '        End If
    '    End Set
    'End Property
    Public Shared Function VerificaRut(ByVal rut, ByVal guion) As Boolean
        Dim resultado As String
        Dim numX As Integer = 2
        Dim total As String = 0
        Dim tamRut As Integer = Len(rut)
        Dim i As Integer = 1
        Dim posicion As Integer
        Dim tamGuion As Integer = Len(guion)
        Dim total_final = 0
        posicion = tamRut
        Dim posicion1 As Integer = tamGuion
        For i = 1 To tamRut
            If numX > 7 Then
                numX = 2
            End If
            total = numX * Val(Mid(rut, posicion, 1))
            total_final = total_final + total
            numX = numX + 1
            posicion = posicion - 1
        Next
        resultado = (total_final Mod 11)
        resultado = 11 - resultado

        If (guion = "k" And resultado = "10") Or (guion = "0" And resultado = "11") Or (resultado = Mid(guion, 1, 1)) Then
            Return True

        End If

        Return False

    End Function
End Class
