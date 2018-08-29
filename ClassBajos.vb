Public Class ClassBajos
    Public strValor
    Public Property CamposNulosTextBox(ByVal ErrorProviderAmplificadores As ErrorProvider, ByVal txtValor As TextBox) As String
        Get
            Return strValor
        End Get
        Set(ByVal value As String)
            If txtValor.TextLength = 0 Then
                ErrorProviderAmplificadores.SetError(txtValor, "Campo obligatorio")
                ErrorProviderAmplificadores.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
                Exit Property
            Else
                ErrorProviderAmplificadores.SetError(txtValor, "")
            End If
        End Set
    End Property

    Public Property CamposNulosComboBox(ByVal ErrorProviderAmplificadores As ErrorProvider, ByVal cmbValor As ComboBox) As String
        Get
            Return strValor
        End Get
        Set(ByVal value As String)
            If cmbValor.Text = "" Then
                ErrorProviderAmplificadores.SetError(cmbValor, "Campo obligatorio")
                ErrorProviderAmplificadores.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
            Else
                ErrorProviderAmplificadores.SetError(cmbValor, "")
            End If
        End Set
    End Property
End Class
