Public Class ClassMicrofonos
    Inherits ClassEquipos
    Public strValor
    Public StrTipo As String 'alámbrico o inalámbrico
    Public Property CamposNulosTextBox(ByVal ErrorProviderMicrofonos As ErrorProvider, ByVal txtValor As TextBox) As String
        Get
            Return strValor
        End Get
        Set(ByVal value As String)
            If txtValor.TextLength = 0 Then
                ErrorProviderMicrofonos.SetError(txtValor, "Campo obligatorio")
                ErrorProviderMicrofonos.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
                Exit Property
            Else
                ErrorProviderMicrofonos.SetError(txtValor, "")
            End If
        End Set
    End Property

    Public Property CamposNulosComboBox(ByVal ErrorProviderMicrofonos As ErrorProvider, ByVal cmbValor As ComboBox) As String
        Get
            Return strValor
        End Get
        Set(ByVal value As String)
            If cmbValor.Text = "" Then
                ErrorProviderMicrofonos.SetError(cmbValor, "Campo obligatorio")
                ErrorProviderMicrofonos.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
            Else
                ErrorProviderMicrofonos.SetError(cmbValor, "")
            End If
        End Set
    End Property

End Class
