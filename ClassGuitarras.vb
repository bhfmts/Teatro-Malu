Public Class ClassGuitarras
    Inherits ClassEquipos
    Public IntCantidadEspacios As Integer
    Public StrMarcaCuerda As String
    Public StrTipoCuerda As String
    Public IntNumeroCuerdas As Integer
    Public StrTipoGuitarra As String
    Public strValor As String

    Public Property CamposNulosTextBox(ByVal ErrorProviderGuitarras As ErrorProvider, ByVal txtValor As TextBox) As String
        Get
            Return strValor
        End Get
        Set(ByVal value As String)
            If txtValor.TextLength = 0 Then
                ErrorProviderGuitarras.SetError(txtValor, "Campo obligatorio")
                ErrorProviderGuitarras.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
                Exit Property
            Else
                ErrorProviderGuitarras.SetError(txtValor, "")
            End If
        End Set
    End Property

    Public Property CamposNulosComboBox(ByVal ErrorProviderGuitarras As ErrorProvider, ByVal cmbValor As ComboBox) As String
        Get
            Return strValor
        End Get
        Set(ByVal value As String)
            If cmbValor.Text = "" Then
                ErrorProviderGuitarras.SetError(cmbValor, "Campo obligatorio")
                ErrorProviderGuitarras.BlinkStyle = ErrorBlinkStyle.AlwaysBlink

            Else
                ErrorProviderGuitarras.SetError(cmbValor, "")
            End If
        End Set
    End Property

End Class
