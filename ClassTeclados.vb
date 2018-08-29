Public Class ClassTeclados
    Inherits ClassEquipos
    Public IntNumeroOctavas As Integer
    Public StrTipoTecla As String
    Public strValor
    Public Property CamposNulosTextBox(ByVal ErrorProviderTeclados As ErrorProvider, ByVal txtValor As TextBox) As String
        Get
            Return strValor
        End Get
        Set(ByVal value As String)
            If txtValor.TextLength = 0 Then
                ErrorProviderTeclados.SetError(txtValor, "Campo obligatorio")
                ErrorProviderTeclados.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
                Exit Property
            Else
                ErrorProviderTeclados.SetError(txtValor, "")
            End If
        End Set
    End Property

    Public Property CamposNulosComboBox(ByVal ErrorProviderTeclados As ErrorProvider, ByVal cmbValor As ComboBox) As String
        Get
            Return strValor
        End Get
        Set(ByVal value As String)
            If cmbValor.Text = "" Then
                ErrorProviderTeclados.SetError(cmbValor, "Campo obligatorio")
                ErrorProviderTeclados.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
            Else
                ErrorProviderTeclados.SetError(cmbValor, "")
            End If
        End Set
    End Property
End Class
