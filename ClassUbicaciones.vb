Public Class ClassUbicaciones
    'Declaración de variables
    Public _intBalconess As Integer
    Public _intPlateaa As Integer
    Public _intPlateaNumeradaa As Integer
    'Validación de los atributos de la clase
    Public Property intBalcones() As Integer
        Get
            Return Me._intBalconess
        End Get
        Set(ByVal value As Integer)
            If Me._intBalconess >= 0 Then
                Me._intBalconess = value
            End If
        End Set
    End Property

    Public Property intPlatea() As Integer
        Get
            Return Me._intPlateaa
        End Get
        Set(ByVal value As Integer)
            If Me._intPlateaa >= 0 Then
                Me._intPlateaa = value
            End If
        End Set
    End Property

    Public Property intPlateaNumerada() As Integer
        Get
            Return Me._intPlateaNumeradaa
        End Get
        Set(ByVal value As Integer)
            If Me._intPlateaNumeradaa >= 0 Then
                Me._intPlateaNumeradaa = value
            End If
        End Set
    End Property


End Class
