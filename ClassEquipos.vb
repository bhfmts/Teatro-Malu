Public Class ClassEquipos
    Public strMarca As String
    Public strModelo As String
    Private intPrecioArriendo As Integer
    Public Property PrecioArriendo(ByVal ErrorProviderEquipos As ErrorProvider, ByVal txtPrecioArriendo As TextBox) As Integer
        Get
            Return intPrecioArriendo
        End Get
        Set(ByVal value As Integer)
            If txtPrecioArriendo.Text > 500000 Then
                ErrorProviderEquipos.SetError(txtPrecioArriendo, "El valor de arriendo no debe ser mayor a $500.000")
                ErrorProviderEquipos.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
                Exit Property
            Else
                ErrorProviderEquipos.SetError(txtPrecioArriendo, "")
            End If
        End Set
    End Property

End Class
