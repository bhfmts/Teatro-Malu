Public Class ClassBaterias
    Inherits ClassEquipos
    Public IntNumeroToms As Integer
    Public IntNumeroBombos As Integer
    Public IntNumeroPlatillos As Integer
    Public strValor
    Public Property CamposNulosTextBox(ByVal ErrorProviderBaterias As ErrorProvider, ByVal txtValor As TextBox) As String
        Get
            Return strValor
        End Get
        Set(ByVal value As String)
            If txtValor.TextLength = 0 Then
                ErrorProviderBaterias.SetError(txtValor, "Campo obligatorio")
                ErrorProviderBaterias.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
                Exit Property
            Else
                ErrorProviderBaterias.SetError(txtValor, "")
            End If
        End Set
    End Property

    Public Property CamposNulosComboBox(ByVal ErrorProviderBaterias As ErrorProvider, ByVal cmbValor As ComboBox) As String
        Get
            Return strValor
        End Get
        Set(ByVal value As String)
            If cmbValor.Text = "" Then
                ErrorProviderBaterias.SetError(cmbValor, "Campo obligatorio")
                ErrorProviderBaterias.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
            Else
                ErrorProviderBaterias.SetError(cmbValor, "")
            End If
        End Set
    End Property
End Class
