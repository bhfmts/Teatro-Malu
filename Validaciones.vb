Module Validaciones

    '' Public Sub SoloNumeros(ByVal eProvSoloNumeros As ErrorProvider, ByVal varSoloNumeros As TextBox)
    'Validación TelefonoEmpleado
    '       eProvSoloNumeros.Clear()
    '       If Not IsNumeric(varSoloNumeros.Text) OrElse String.IsNullOrEmpty(varSoloNumeros.Text) Then
    '           eProvSoloNumeros.SetError(varSoloNumeros, "Ingrese un valor númerico")
    '           ValidaNumero = ValidaNumero + 1
    '           Exit Sub
    '       Else
    '           eProvSoloNumeros.SetError(varSoloNumeros, "")
    '       End If
    '   End Sub

 
    Public Function CamposNulos(ByVal eProvCamposNulos As ErrorProvider, ByVal varCamposNulos As TextBox) As Boolean

        eProvCamposNulos.Clear()
        If varCamposNulos.TextLength = 0 Then
            eProvCamposNulos.SetError(varCamposNulos, "Campo obligatorio")
            eProvCamposNulos.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
            varCamposNulos.Focus()
            Return True
            Exit Function
        Else
            eProvCamposNulos.SetError(varCamposNulos, "")
        End If
    End Function
    Public Function ValidaSoloLetras(ByVal eProvSoloLetras As ErrorProvider, ByVal varSoloLetras As TextBox) As Boolean
        eProvSoloLetras.Clear()
        If letra(varSoloLetras.Text) = False Then
            eProvSoloLetras.SetError(varSoloLetras, "Ingrese sólo letras")
            eProvSoloLetras.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
            varSoloLetras.Focus()
            Return True
            Exit Function
        Else
            eProvSoloLetras.SetError(varSoloLetras, "")
        End If

    End Function

    '' Función valida solo letras
    Public Function letra(ByVal texto As String) As Boolean
        Dim bandera As Boolean
        Dim carac1 As String
        Dim tam, i, posicion As Integer

        bandera = True
        tam = Len(texto)
        posicion = 1
        bandera = False

        For i = 1 To tam
            carac1 = Mid(texto, posicion, 1)

            'discriminación según el código ascii
            If Asc(carac1) >= 65 And Asc(carac1) <= 90 Or Asc(carac1) >= 97 And Asc(carac1) <= 122 Or Asc(carac1) = 32 Or Asc(carac1) = 209 Or Asc(carac1) = 241 Then

                bandera = True
            Else
                bandera = False
                Return (False)
            End If

            posicion = posicion + 1
        Next

        Return (bandera)
    End Function
    Public Sub SoloTexto(ByVal e As System.Windows.Forms.KeyPressEventArgs)

        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If

    End Sub
    Public Sub SoloAlfaNum(ByVal e As System.Windows.Forms.KeyPressEventArgs)

        If Char.IsLetterOrDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If

    End Sub
End Module
