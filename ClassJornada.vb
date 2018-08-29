Public Class ClassJornada
    'Declaración de variables
    Public _intMatinee As Integer
    Public _intTardee As Integer
    Public _intNochee As Integer
    'Validación de los atributos de la clase
    Public Property intMatinee() As Integer
        Get
            Return Me._intMatinee
        End Get
        Set(ByVal value As Integer)
            If Me._intMatinee >= 0 Then
                _intMatinee = value
            End If
        End Set

    End Property
    Public Property intTardee() As Integer
        Get
            Return Me._intTardee
        End Get
        Set(ByVal value As Integer)
            If Me._intTardee >= 0 Then
                _intTardee = value
            End If
        End Set
    End Property
    Public Property intNochee() As Integer
        Get
            Return Me._intNochee
        End Get
        Set(ByVal value As Integer)
            If Me._intNochee >= 0 Then
                _intNochee = value
            End If
        End Set
    End Property
End Class
