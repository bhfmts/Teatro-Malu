Public Class ClassMesas
    Inherits ClassEquipos
    Public StrTipoEntrada As String 'Canon, plus
    Public IntNumeroEntradas As Integer
    Public strValor
    Public Property CamposNulosTextBox(ByVal ErrorProviderMesas As ErrorProvider, ByVal txtValor As TextBox) As String
        Get
            Return strValor
        End Get
        Set(ByVal value As String)
            If txtValor.TextLength = 0 Then
                ErrorProviderMesas.SetError(txtValor, "Campo obligatorio")
                ErrorProviderMesas.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
                Exit Property
            Else
                ErrorProviderMesas.SetError(txtValor, "")
            End If
        End Set
    End Property

    Public Property CamposNulosComboBox(ByVal ErrorProviderMesas As ErrorProvider, ByVal cmbValor As ComboBox) As String
        Get
            Return strValor
        End Get
        Set(ByVal value As String)
            If cmbValor.Text = "" Then
                ErrorProviderMesas.SetError(cmbValor, "Campo obligatorio")
                ErrorProviderMesas.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
            Else
                ErrorProviderMesas.SetError(cmbValor, "")
            End If
        End Set
    End Property

End Class
