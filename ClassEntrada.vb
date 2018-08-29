Imports System.Text.RegularExpressions
Imports Teatro.ClassConexion
Imports System.Data.SqlClient
Public Class ClassEntrada

  
    Private Shared _cardNumber As String
    Private Shared CreditCardPatterns As New List(Of String) _
                      (New String() { _
                      "^(4\d{12})|(4\d{15})$", _
                      "^5[1-5]\d{14}$", _
                      "(^(6011)\d{12}$)|(^(65)\d{14}$)", _
                      "^3[47]\d{13}$"})
    Public Enum CreditCardTypes
        Invalid = -1
        Visa
        Mastercard
        Discover
        Amex
    End Enum
    Private Shared Function FindPattern(ByVal value As String) As Boolean
        If Regex.IsMatch(_cardNumber, value) Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function Validate(ByVal cardNumber As String) As CreditCardTypes
        Dim CardType As CreditCardTypes = CreditCardTypes.Invalid
        _cardNumber = Regex.Replace(cardNumber, "[^\d]", String.Empty)
        CardType = CType(CreditCardPatterns.FindIndex(AddressOf FindPattern), CreditCardTypes)
        If CardType = CreditCardTypes.Invalid Then
            _cardNumber = String.Empty
            Return CreditCardTypes.Invalid
        End If
        Dim Digits As Char() = _cardNumber.ToCharArray
        _cardNumber = String.Empty
        Dim Digit As Integer
        Dim Sum As Integer = 0
        Dim Alt As Boolean = False
        Array.Reverse(Digits)
        For Each Value As Char In Digits
            Digit = Integer.Parse(Value)
            If Alt Then
                Digit *= 2
                If Digit > 9 Then
                    Digit -= 9
                End If
            End If
            Sum += Digit
            Alt = Not Alt
        Next
        If Sum Mod 10 = 0 Then
            Return CardType
        Else
            Return CreditCardTypes.Invalid
        End If
    End Function
    Public Shared Function FechaMatine(ByVal strFecha As Date, ByVal intIDEvento As Integer) As Boolean
        Try
            Conexion.Open()
            Dim Cadena As String = "SELECT  FECHAEVENTO, MATINÉ, TARDE, NOCHE FROM EVENTOSJORNADAS;"
            Dim DAdapter As New SqlDataAdapter(Cadena, Conexion)
            Dim DTable As New DataTable
            Dim DRow As DataRow = Nothing
            DAdapter.Fill(DTable)
            '1= Matiné está libre 2= Tarde está libre 12= Matiné y tarde libre
            '3= Noche está libre  9= Está todo lleno  13= Matiné y noche libre
            '23= Tarde y noche libre. 123= Todo libre 0= Ninguna de las anteriores
            For Each DRow In DTable.Rows
                If DRow("FECHAEVENTO") = strFecha And DRow("TARDE") = intIDEvento Then
                    Return True
                    Exit Function
                ElseIf DRow("FECHAEVENTO") = strFecha And DRow("NOCHE") = intIDEvento Then
                    Return True
                    Exit Function
                Else
                    Return False
                End If
            Next

        Catch ex As Exception
            MsgBox("Se ha producido el siguiente error: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            Conexion.Close()
        End Try
    End Function

    Public Shared Function BuscarRUN(ByVal strRUNBuscar As String) As Boolean
        Try
            Conexion.Open()
            Dim Cadena As String = "SELECT RUNCLIENTE FROM CLIENTES;"
            Dim DAdapter As New SqlDataAdapter(Cadena, Conexion)
            Dim DTable As New DataTable
            Dim DRow As DataRow = Nothing
            DAdapter.Fill(DTable)
            '1= Matiné está libre 2= Tarde está libre 12= Matiné y tarde libre
            '3= Noche está libre  9= Está todo lleno  13= Matiné y noche libre
            '23= Tarde y noche libre. 123= Todo libre 0= Ninguna de las anteriores
            For Each DRow In DTable.Rows
                If strRUNBuscar = DRow("RUNCLIENTE") Then
                    Return True
                    Exit Function
                End If
            Next
            'Return 0
        Catch ex As Exception
            MsgBox("Se ha producido el siguiente error: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            Conexion.Close()
        End Try
    End Function


End Class
