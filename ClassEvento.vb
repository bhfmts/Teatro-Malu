Imports System.Data.SqlClient
'Imports teatro.classconexion

Public Class ClassEvento
    Inherits ClassConexion
    Public strNombreEvento As String
    Public _dtFechaevento As Date
    Public _intEntradaGeneral As Integer
    Public intCapacidad As Integer
    Public intEstadoEvento As Integer
    Public strRUNEncargado As String
    Public strValor
    Public Property intEntradaGeneral() As Integer
        Get
            Return Me._intEntradaGeneral
        End Get
        Set(ByVal value As Integer)
            If value > 200000 Then
                _intEntradaGeneral = value

            Else
                Me._intEntradaGeneral = value
            End If

        End Set
    End Property
    Public Property dtFechaEvento() As Date
        Get
            Return Me._dtFechaevento
        End Get
        Set(ByVal value As Date)
            If value > Date.Now Then
                _dtFechaevento = value
            End If
        End Set
    End Property

    Public Property CamposNulosTextBox(ByVal ErrorProviderEventos As ErrorProvider, ByVal txtValor As TextBox) As String
        Get
            Return strValor
        End Get
        Set(ByVal value As String)
            If txtValor.TextLength = 0 Then
                ErrorProviderEventos.SetError(txtValor, "Campo obligatorio")
                ErrorProviderEventos.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
                Exit Property
            Else
                ErrorProviderEventos.SetError(txtValor, "")
            End If
        End Set
    End Property
    Public Shared Sub ResetearCheckbox(ByVal chkMatine As CheckBox, ByVal chkTarde As CheckBox, ByVal chkNoche As CheckBox)
        chkMatine.Checked = False
        chkTarde.Checked = False
        chkNoche.Checked = False

    End Sub
    Public Shared Sub LimpiarCamposRegistroEvento(ByVal TXTBALCONES As TextBox, ByVal TXTPLATEA As TextBox, _
    ByVal TXTPLATEANUMERADA As TextBox)
        TXTBALCONES.Clear()
        TXTPLATEA.Clear()
        TXTPLATEANUMERADA.Clear()
        'cmbNombreEvento.Items.Clear()
    End Sub
    Public Shared Sub LimpiarCamposModificarEvento(ByVal TXTBALCONES As TextBox, ByVal TXTPLATEA As TextBox, _
ByVal TXTPLATEANUMERADA As TextBox, ByVal cmbNombreEvento As ComboBox, ByVal txtNombreEncargado As TextBox, ByVal cmbJornadas As ComboBox)
        TXTBALCONES.Clear()
        TXTPLATEA.Clear()
        TXTPLATEANUMERADA.Clear()
        cmbNombreEvento.Items.Clear()
        cmbJornadas.Items.Clear()
        cmbJornadas.Text = ""
        cmbNombreEvento.Text = ""
        txtNombreEncargado.Clear()
    End Sub
    Public Shared Sub LimpiarComboAndMore(ByVal cmbJornadas As ComboBox, ByVal cmbNombreEvento As ComboBox, ByVal lstboxFechas As ListBox, _
    ByVal lstboxFechasNuevas As ListBox, ByVal dgProduccion As DataGridView)
        cmbJornadas.Items.Clear()
        cmbNombreEvento.DataSource = Nothing
        lstboxFechas.DataSource = Nothing
        lstboxFechasNuevas.Items.Clear()
        dgProduccion.DataSource = Nothing
        'dgProduccion.Rows.Clear()

    End Sub

    Public Sub Solo_txt(ByVal e As System.Windows.Forms.KeyPressEventArgs)

        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If

    End Sub
    Public Shared Function CompruebaFechas(ByVal strFechaComprueba As String) As Integer
        Try
            Conexion.Open()
            Dim Cadena As String = "Select IDEVENTO, FECHAEVENTO,MATINÉ,TARDE,NOCHE FROM EVENTOSJORNADAS;"
            Dim DAdapter As New SqlDataAdapter(Cadena, Conexion)
            Dim DTable As New DataTable
            Dim DRow As DataRow = Nothing
            DAdapter.Fill(DTable)
            '1= Matiné está libre 2= Tarde está libre 12= Matiné y tarde libre
            '3= Noche está libre  9= Está todo lleno  13= Matiné y noche libre
            '23= Tarde y noche libre. 123= Todo libre 0= Ninguna de las anteriores
            For Each DRow In DTable.Rows
                If strFechaComprueba = DRow("FECHAEVENTO") And DRow("MATINÉ") <> 0 And DRow("TARDE") <> 0 And DRow("NOCHE") <> 0 Then
                    Return 9
                    Exit Function
                ElseIf strFechaComprueba = DRow("FECHAEVENTO") And DRow("MATINÉ") = 0 And DRow("TARDE") <> 0 And DRow("NOCHE") <> 0 Then
                    Return 1
                    Exit Function
                ElseIf strFechaComprueba = DRow("FECHAEVENTO") And DRow("TARDE") = 0 And DRow("MATINÉ") <> 0 And DRow("NOCHE") <> 0 Then
                    Return 2
                    Exit Function
                ElseIf strFechaComprueba = DRow("FECHAEVENTO") And DRow("NOCHE") = 0 And DRow("TARDE") <> 0 And DRow("MATINÉ") <> 0 Then
                    Return 3
                    Exit Function
                ElseIf strFechaComprueba = DRow("FECHAEVENTO") And DRow("MATINÉ") = 0 And DRow("TARDE") = 0 And DRow("NOCHE") <> 0 Then
                    Return 12
                    Exit Function
                ElseIf strFechaComprueba = DRow("FECHAEVENTO") And DRow("MATINÉ") = 0 And DRow("NOCHE") = 0 And DRow("TARDE") <> 0 Then
                    Return 13
                    Exit Function
                ElseIf strFechaComprueba = DRow("FECHAEVENTO") And DRow("TARDE") = 0 And DRow("NOCHE") = 0 And DRow("MATINÉ") <> 0 Then
                    Return 23
                    Exit Function
                ElseIf strFechaComprueba = DRow("FECHAEVENTO") And DRow("TARDE") = 0 And DRow("NOCHE") = 0 And DRow("MATINÉ") = 0 Then
                    Return 123
                    Exit Function
                End If
            Next
            Return 0
        Catch ex As Exception
            MsgBox("Se ha producido el siguiente error: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            Conexion.Close()
        End Try
    End Function
    'Función que me sirve para verificar si la jornada tiene un valor distinto a la id del evento. Lo cual me sirve para eliminar completamente
    'una fecha programada para un evento. La otra función ve que los valores de las jornadas sean distintos de 0 para eliminar las fechas.
    Public Shared Function CompruebaFechaJornada(ByVal strFechaComprueba As String, ByVal intIDeventoComprueba As Integer) As Integer
        Try
            Conexion.Open()
            Dim Cadena As String = "Select IDEVENTO, FECHAEVENTO,MATINÉ,TARDE,NOCHE FROM EVENTOSJORNADAS;"
            Dim DAdapter As New SqlDataAdapter(Cadena, Conexion)
            Dim DTable As New DataTable
            Dim DRow As DataRow = Nothing
            DAdapter.Fill(DTable)
            '1= Matiné está libre 2= Tarde está libre 12= Matiné y tarde libre
            '3= Noche está libre  9= Está todo lleno  13= Matiné y noche libre
            '23= Tarde y noche libre. 123= Todo libre 0= Ninguna de las anteriores
            For Each DRow In DTable.Rows
                If strFechaComprueba = DRow("FECHAEVENTO") And DRow("MATINÉ") <> intIDeventoComprueba Or DRow("TARDE") <> intIDeventoComprueba Or DRow("NOCHE") <> intIDeventoComprueba Then
                    Return 0
                    Exit Function
                End If
            Next
            'Return 0
        Catch ex As Exception
            MsgBox("Se ha producido el siguiente error: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            Conexion.Close()
        End Try
    End Function
    Public Shared Function CompruebaFechas(ByVal strFechaComprueba As String, ByVal intIDEventoComprueba As Integer) As Integer
        Try
            Conexion.Open()
            Dim Cadena As String = "Select IDEVENTO, FECHAEVENTO,MATINÉ,TARDE,NOCHE FROM EVENTOSJORNADAS;"
            Dim DAdapter As New SqlDataAdapter(Cadena, Conexion)
            Dim DTable As New DataTable
            Dim DRow As DataRow = Nothing
            DAdapter.Fill(DTable)
            '1= Matiné está libre 2= Tarde está libre 12= Matiné y tarde libre
            '3= Noche está libre  9= Está todo lleno  13= Matiné y noche libre
            '23= Tarde y noche libre. 123= Todo libre 0= Ninguna de las anteriores
            For Each DRow In DTable.Rows
                If strFechaComprueba = DRow("FECHAEVENTO") And DRow("TARDE") <> intIDEventoComprueba And DRow("NOCHE") <> intIDEventoComprueba Then
                    Return 23
                    Exit Function
                    'ElseIf strFechaComprueba = DRow("FECHAEVENTO") And DRow("TARDE") <> intIDEventoComprueba And DRow("NOCHE") = 0 Then
                    '    Return 23
                    '    Exit Function
                    'ElseIf strFechaComprueba = DRow("FECHAEVENTO") And DRow("TARDE") = 0 And DRow("NOCHE") <> intIDEventoComprueba Then
                    '    Return 23
                    '    Exit Function
                ElseIf strFechaComprueba = DRow("FECHAEVENTO") And DRow("MATINÉ") <> intIDEventoComprueba And DRow("TARDE") <> intIDEventoComprueba Then
                    Return 12
                    Exit Function
                    'ElseIf strFechaComprueba = DRow("FECHAEVENTO") And DRow("MATINÉ") = 0 And DRow("TARDE") <> intIDEventoComprueba Then
                    '    Return 12
                    '    Exit Function
                    'ElseIf strFechaComprueba = DRow("FECHAEVENTO") And DRow("MATINÉ") <> intIDEventoComprueba And DRow("TARDE") = 0 Then
                    '    Return 12
                    '    Exit Function
                ElseIf strFechaComprueba = DRow("FECHAEVENTO") And DRow("MATINÉ") <> intIDEventoComprueba And DRow("NOCHE") <> intIDEventoComprueba Then
                    Return 13
                    Exit Function
                    'ElseIf strFechaComprueba = DRow("FECHAEVENTO") And DRow("MATINÉ") = 0 And DRow("NOCHE") <> intIDEventoComprueba Then
                    '    Return 13
                    '    Exit Function
                    'ElseIf strFechaComprueba = DRow("FECHAEVENTO") And DRow("MATINÉ") <> intIDEventoComprueba And DRow("NOCHE") = 0 Then
                    '    Return 13
                    '    Exit Function
                End If
            Next
            Return 0
        Catch ex As Exception
            MsgBox("Se ha producido el siguiente error: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            Conexion.Close()
        End Try
    End Function

    Public Shared Function CompruebaCheckbox(ByVal chkMatine As CheckBox, ByVal chkTarde As CheckBox, ByVal chkNoche As CheckBox) As Integer
        If chkMatine.Checked = True And chkTarde.Checked = True And chkNoche.Checked = True Then
            Return 123
            Exit Function
        ElseIf chkMatine.Checked = True And chkTarde.Checked = False And chkNoche.Checked = False Then
            Return 1
            Exit Function
        ElseIf chkMatine.Checked = False And chkTarde.Checked = True And chkNoche.Checked = False Then
            Return 2
            Exit Function
        ElseIf chkMatine.Checked = False And chkTarde.Checked = False And chkNoche.Checked = True Then
            Return 3
            Exit Function
        ElseIf chkMatine.Checked = True And chkTarde.Checked = True And chkNoche.Checked = False Then
            Return 12
            Exit Function
        ElseIf chkMatine.Checked = True And chkTarde.Checked = False And chkNoche.Checked = True Then
            Return 13
            Exit Function
        ElseIf chkMatine.Checked = False And chkTarde.Checked = True And chkNoche.Checked = True Then
            Return 23
            Exit Function
        ElseIf chkMatine.Checked = False And chkTarde.Checked = False And chkNoche.Checked = False Then
            Return 111
        End If
    End Function

    Public Shared Function CompruebaExisteFecha(ByVal intIDEvento As Integer, ByVal strFechaEvento As String) As Boolean

        Try
            Conexion.Open()
            Dim Cadena As String = "SELECT IDEVENTO, FECHAEVENTO FROM EVENTOS"
            Dim DAdapter As New SqlDataAdapter(Cadena, Conexion)
            Dim DTable As New DataTable
            Dim DRow As DataRow = Nothing
            DAdapter.Fill(DTable)
            For Each DRow In DTable.Rows
                If strFechaEvento = DRow("FECHAEVENTO") And DRow("IDEVENTO") = intIDEvento Then
                    Return True
                    Exit Function
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        Finally
            Conexion.Close()
        End Try


    End Function
    Public Shared Function CompruebaNombreEvento(ByVal strNombre As String) As Boolean
        Try
            Conexion.Open()
            Dim Cadena As String = "SELECT distinct NOMBREEVENTO FROM EVENTOS"
            Dim DAdapter As New SqlDataAdapter(Cadena, Conexion)
            Dim DTable As New DataTable
            Dim DRow As DataRow = Nothing
            DAdapter.Fill(DTable)
            For Each DRow In DTable.Rows
                If strNombre = DRow("NOMBREEVENTO") Then
                    Return True
                    Exit For
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        Finally
            Conexion.Close()
        End Try
    End Function
    Public Shared Function EliminaJornada(ByVal intIDEvento As Integer, ByVal strFecha As String) As Integer
        Try
            Conexion.Open()
            Dim Cadena As String = "Select IDEVENTO, FECHAEVENTO,MATINÉ,TARDE,NOCHE FROM EVENTOSJORNADAS;"
            Dim DAdapter As New SqlDataAdapter(Cadena, Conexion)
            Dim DTable As New DataTable
            Dim DRow As DataRow = Nothing
            DAdapter.Fill(DTable)
            '1= Matiné está libre 2= Tarde está libre 12= Matiné y tarde libre
            '3= Noche está libre  9= Está todo lleno  13= Matiné y noche libre
            '23= Tarde y noche libre. 123= Todo libre 0= Ninguna de las anteriores
            For Each DRow In DTable.Rows
                If strFecha = DRow("FECHAEVENTO") And DRow("MATINÉ") = intIDEvento And DRow("TARDE") <> intIDEvento And DRow("NOCHE") <> intIDEvento Then
                    If DRow("TARDE") = 0 And DRow("NOCHE") = 0 Then
                        Return 123
                        Exit Function
                    End If
                    Return 1
                    Exit Function
                ElseIf strFecha = DRow("FECHAEVENTO") And DRow("TARDE") = intIDEvento And DRow("MATINÉ") <> intIDEvento And DRow("NOCHE") <> intIDEvento Then
                    If DRow("MATINÉ") = 0 And DRow("NOCHE") = 0 Then
                        Return 123
                        Exit Function
                    End If
                    Return 2
                    Exit Function
                ElseIf strFecha = DRow("FECHAEVENTO") And DRow("NOCHE") = intIDEvento And DRow("TARDE") <> intIDEvento And DRow("MATINÉ") <> intIDEvento Then
                    If DRow("TARDE") = 0 And DRow("MATINÉ") = 0 Then
                        Return 123
                        Exit Function
                    End If
                    Return 3
                    Exit Function
                ElseIf strFecha = DRow("FECHAEVENTO") And DRow("MATINÉ") = intIDEvento And DRow("TARDE") = intIDEvento And DRow("NOCHE") <> intIDEvento Then
                    If DRow("NOCHE") = 0 Then
                        Return 123
                        Exit Function
                    End If
                    Return 12
                    Exit Function
                ElseIf strFecha = DRow("FECHAEVENTO") And DRow("MATINÉ") = intIDEvento And DRow("NOCHE") = intIDEvento And DRow("TARDE") <> intIDEvento Then
                    If DRow("TARDE") = 0 Then
                        Return 123
                        Exit Function
                    End If
                    Return 13
                    Exit Function
                ElseIf strFecha = DRow("FECHAEVENTO") And DRow("TARDE") = intIDEvento And DRow("NOCHE") = intIDEvento And DRow("MATINÉ") <> intIDEvento Then
                    If DRow("MATINÉ") = 0 Then
                        Return 123
                        Exit Function
                    End If
                    Return 23
                    Exit Function
                ElseIf strFecha = DRow("FECHAEVENTO") And DRow("TARDE") = intIDEvento And DRow("NOCHE") = intIDEvento And DRow("MATINÉ") = intIDEvento Then
                    Return 123
                    Exit Function
                End If
            Next
            Return 0
        Catch ex As Exception
            MsgBox("Se ha producido el siguiente error: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            Conexion.Close()
        End Try
    End Function
    Public Shared Sub ActualizarNombreEvento(ByVal cmbNombreEvento As ComboBox, ByVal txtEntradaGeneral As TextBox)
        Try
            Dim Sentencia As String = "SELECT DISTINCT NOMBREEVENTO FROM EVENTOS;"
            Dim DAdapter As New SqlDataAdapter(Sentencia, Conexion)
            Dim DSet As New DataSet
            Dim dt As New DataTable
            DAdapter.Fill(dt)
            cmbNombreEvento.DataSource = dt
            cmbNombreEvento.DisplayMember = dt.Columns(0).ToString()
            cmbNombreEvento.ValueMember = dt.Columns(0).ToString()
            cmbNombreEvento.SelectedIndex = -1
            cmbNombreEvento.Text = ""
            txtEntradaGeneral.Text = ""
        Catch ex As Exception
            MsgBox("Se ha producido el siguiente error: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    'Comprobación de Jornadas pasando el párametro FechaEvento
    Public Shared Sub CompruebaJornadas(ByVal dtAgregarFecha As Date, ByRef intMatine As Integer, ByRef blnFechaExiste As Boolean, ByRef intTarde As Integer, ByRef intNoche As Integer, ByVal intIDEventoMod As Integer)
        Try
            Conexion.Open()
            Dim Cadena As String = "Select IDEVENTO, FECHAEVENTO,MATINÉ,TARDE,NOCHE FROM EVENTOSJORNADAS;"
            Dim DAdapter As New SqlDataAdapter(Cadena, Conexion)
            Dim DTable As New DataTable
            Dim DRow As DataRow = Nothing
            DAdapter.Fill(DTable)
            For Each DRow In DTable.Rows
                If dtAgregarFecha = DRow("FECHAEVENTO") And DRow("MATINÉ") = 0 Then
                    intMatine = 1
                    If dtAgregarFecha = DRow("FECHAEVENTO") Then
                        blnFechaExiste = True
                    Else
                        blnFechaExiste = False
                        'Exit Sub
                    End If
                    'Exit Sub
                ElseIf dtAgregarFecha = DRow("FECHAEVENTO") And DRow("MATINÉ") <> intIDEventoMod And DRow("MATINÉ") <> 0 Then
                    intMatine = 2
                    'Exit Sub
                End If
                If dtAgregarFecha = DRow("FECHAEVENTO") And DRow("TARDE") = 0 Then
                    intTarde = 1
                    If dtAgregarFecha = DRow("FECHAEVENTO") Then
                        blnFechaExiste = True
                    Else
                        blnFechaExiste = False
                        'Exit Sub
                    End If
                    'Exit Sub
                ElseIf dtAgregarFecha = DRow("FECHAEVENTO") And DRow("TARDE") <> intIDEventoMod And DRow("TARDE") <> 0 Then
                    intTarde = 2
                    'Exit Sub
                End If
                If dtAgregarFecha = DRow("FECHAEVENTO") And DRow("NOCHE") = 0 Then
                    intNoche = 1
                    If dtAgregarFecha = DRow("FECHAEVENTO") Then
                        blnFechaExiste = True
                    Else
                        blnFechaExiste = False
                        'Exit Sub
                    End If
                    'Exit Sub
                ElseIf dtAgregarFecha = DRow("FECHAEVENTO") And DRow("NOCHE") <> intIDEventoMod And DRow("NOCHE") <> 0 Then
                    intNoche = 2
                    'Exit Sub
                End If
            Next
        Catch ex As Exception
            MsgBox("Se ha producido el siguiente error: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            Conexion.Close()
        End Try
    End Sub

    'Comprobación de jornada sin pasar el párametro de la FechaEvento
    Public Shared Sub CompruebaSinJornadas(ByVal dtFechaMod As Date, ByRef intMatine As Integer, ByRef intTarde As Integer, ByVal intNoche As Integer, ByRef intIDEventoMod As Integer)
        Dim jornada As New ClassJornada
        jornada.intMatinee = intMatine
        jornada.intNochee = intNoche
        jornada._intTardee = intTarde
        Try
            Conexion.Open()
            Dim Cadena As String = "Select IDEVENTO, FECHAEVENTO,MATINÉ,TARDE,NOCHE FROM EVENTOSJORNADAS;"
            Dim DAdapter As New SqlDataAdapter(Cadena, Conexion)
            Dim DTable As New DataTable
            Dim DRow As DataRow = Nothing
            DAdapter.Fill(DTable)
            'intMatine=1 significa que la jornada esta libre
            'intMatine=2 significa que la jornada está ocupada
            For Each DRow In DTable.Rows
                If dtFechaMod = DRow("FECHAEVENTO") And DRow("MATINÉ") = 0 Then
                    intMatine = 1
                    'Exit Sub
                ElseIf dtFechaMod = DRow("FECHAEVENTO") And DRow("MATINÉ") <> intIDEventoMod And DRow("MATINÉ") <> 0 Then
                    intMatine = 2
                    'Exit Sub
                End If
                If dtFechaMod = DRow("FECHAEVENTO") And DRow("TARDE") = 0 Then
                    intTarde = 1
                    'Exit Sub
                ElseIf dtFechaMod = DRow("FECHAEVENTO") And DRow("TARDE") <> intIDEventoMod And DRow("TARDE") <> 0 Then
                    intTarde = 2
                    'Exit Sub
                End If
                If dtFechaMod = DRow("FECHAEVENTO") And DRow("NOCHE") = 0 Then
                    intNoche = 1
                    'Exit Sub

                ElseIf dtFechaMod = DRow("FECHAEVENTO") And DRow("NOCHE") <> intIDEventoMod And DRow("NOCHE") <> 0 Then
                    intNoche = 2
                    'Exit Sub
                End If
            Next
        Catch ex As Exception
            MsgBox("Se ha producido el siguiente error: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            Conexion.Close()
        End Try
    End Sub
    Public Shared Sub ActualizarFechasEvento(ByVal lstboxFechas As ListBox, ByVal intIDEventoMod As Integer, ByVal strNombreEventoMod As String, ByVal txtEntradaGeneral As TextBox)
        Try
            Dim Sentencia As String = "SELECT FECHAEVENTO FROM EVENTOS WHERE IDEVENTO  ='" & intIDEventoMod & "' AND NOMBREEVENTO='" & strNombreEventoMod & "';"
            Dim DAdapter As New SqlDataAdapter(Sentencia, Conexion)
            Dim DSet As New DataSet
            Dim dt As New DataTable
            DAdapter.Fill(dt)
            lstboxFechas.DataSource = dt
            lstboxFechas.DisplayMember = dt.Columns(0).ToString()
            lstboxFechas.ValueMember = dt.Columns(0).ToString()
            lstboxFechas.SelectedIndex = -1
            lstboxFechas.Text = ""
            txtEntradaGeneral.Text = ""
        Catch ex As Exception
            MsgBox("Se ha producido el siguiente error: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            Conexion.Close()
        End Try
    End Sub
    Public Shared Sub ActivaJornadas(ByVal intMatine As Integer, ByVal intTarde As Integer, ByVal intNoche As Integer, ByVal chkMatine As CheckBox, ByVal chkTarde As CheckBox, ByVal chkNoche As CheckBox)
        If intMatine = 1 Then
            chkMatine.Enabled = True
        Else
            chkMatine.Enabled = False
        End If
        If intTarde = 1 Then
            chkTarde.Enabled = True
        Else
            chkTarde.Enabled = False
        End If
        If intNoche = 1 Then
            chkNoche.Enabled = True
        Else
            chkNoche.Enabled = False
        End If
    End Sub
End Class
