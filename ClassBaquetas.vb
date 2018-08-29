Public Class ClassBaquetas
    Inherits ClassEquipos
    Public StrTipoBaqueta
    Public strValor
    Public Property CamposNulosTextBox(ByVal ErrorProviderBaquetas As ErrorProvider, ByVal txtValor As TextBox) As String
        Get
            Return strValor
        End Get
        Set(ByVal value As String)
            If txtValor.TextLength = 0 Then
                ErrorProviderBaquetas.SetError(txtValor, "Campo obligatorio")
                ErrorProviderBaquetas.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
                Exit Property
            Else
                ErrorProviderBaquetas.SetError(txtValor, "")
            End If
        End Set
    End Property

    Public Property CamposNulosComboBox(ByVal ErrorProviderBaquetas As ErrorProvider, ByVal cmbValor As ComboBox) As String
        Get
            Return strValor
        End Get
        Set(ByVal value As String)
            If cmbValor.Text = "" Then
                ErrorProviderBaquetas.SetError(cmbValor, "Campo obligatorio")
                ErrorProviderBaquetas.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
            Else
                ErrorProviderBaquetas.SetError(cmbValor, "")
            End If
        End Set
    End Property
End Class
