Imports System.Data.SqlClient
Imports Teatro.ClassConexion
Imports Teatro.ClassEvento
Public Class frmModificarEventos
    '**************************************************************************************************************
    'Declaración de variables a utilizar
    Public strFechaMod As String
    Public strNombreEventoMod As String
    Public intIDEventoMod As Integer
    Public blnMatine As Boolean
    Public blnTarde As Boolean
    Public blnNoche As Boolean
    Public strRUNEncargado As String
    Public intSelecNombreEvento As Integer
    Public intMatine As Integer
    Public intTarde As Integer
    Public intNoche As Integer
    Public blnModificaNombre As Boolean
    Public drResultado As DialogResult
    Public blnMatUbi As Boolean = False
    Public blnTarUbi As Boolean = False
    Public blnNocUbi As Boolean = False
    Public blnFechaExiste As Boolean = False
    Dim blnActualizarEvento As Boolean

    Private Sub frmModificarEventos_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim drResultado As DialogResult = MsgBox("Asegúrese de haber completado correctamente sus operaciones. ¿Está seguro que desea cerrar? ", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Registro eventos")
        If drResultado = vbNo Then
            e.Cancel = True
        Else
            Me.Dispose()
        End If
    End Sub

    Private Sub frmModificarEventos_HelpRequested(ByVal sender As Object, ByVal hlpevent As System.Windows.Forms.HelpEventArgs) Handles Me.HelpRequested
        Try
            System.Diagnostics.Process.Start("\\BERNARDO\Manuales\Modificar eventos.avi")
        Catch ex As Exception
            MsgBox("Se ha producido el siguiente error: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub frmModificarEventos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'TeatroDataSet.UBICACIONES' Puede moverla o quitarla según sea necesario.
        Me.UBICACIONESTableAdapter.Fill(Me.TeatroDataSet.UBICACIONES)

        NotifyIcon1.ShowBalloonTip(5)
        Me.dgProduccion.RowHeadersVisible = False
        'Aquí cargo la lista de eventos que se encuentra en la base de datos
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
    'Aquí reseteo los checkbox.checked a false
    Private Sub cmbNombreEvento_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbNombreEvento.Click
        lblNombreMod.Visible = False
        chkNoche.Checked = False
        chkTarde.Checked = False
        chkMatine.Checked = False
        ActualizarNombreEvento(cmbNombreEvento, txtEntradaGeneral)
    End Sub

    'Capturo el nombre de evento en caso que se modifique. Lo hago cuando se apreta la tecla enter
    Private Sub cmbNombreEvento_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbNombreEvento.KeyPress
        blnModificaNombre = True
        Try
            If e.KeyChar = ChrW(Keys.Enter) Then
                strNombreEventoMod = cmbNombreEvento.Text
                If CompruebaNombreEvento(strNombreEventoMod) = False Then
                    Me.EVENTOSTableAdapter.UpdateNombresEvento(strNombreEventoMod, intIDEventoMod)
                    'End If
                    MsgBox("Actualizado satisfactoriamente", MsgBoxStyle.Information)
                    lblNombreMod.Visible = True
                    Me.btnActualizarEvento.Enabled = False
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
                Else
                    MsgBox("El nombre del evento que está ingresando ya existe en nuestros registros", MsgBoxStyle.Critical)
                End If
            End If
        Catch ex As Exception
            MsgBox("Se ha producido el siguiente error: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub cmbNombreEvento_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbNombreEvento.SelectedIndexChanged
        tcFechas.Enabled = True
        'If intSelecNombreEvento > 1 Then
        Try
            intSelecNombreEvento = intSelecNombreEvento + 1
            strNombreEventoMod = cmbNombreEvento.GetItemText(cmbNombreEvento.SelectedValue)
            intIDEventoMod = Me.EVENTOSTableAdapter.SelectIDEvento(strNombreEventoMod)
            'Aquí cargo las fechas que tiene un evento, según el nombre de evento que se seleccione
            'en el combobox

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

        'Dim hola As String

        'hola = 
        'Me.lstboxFechas.SelectedIndex = Me.lstboxFechas.Items.Count - 1
        'Me.lstboxFechas.TopIndex = Me.lstboxFechas.SelectedIndex
        'lstboxFechas.TopIndex = hola
        'End If
    End Sub
    Private Sub lstboxFechas_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstboxFechas.Click
        Try
            Me.groUbicaciones.Enabled = False
            strFechaMod = lstboxFechas.GetItemText(lstboxFechas.SelectedValue)
            strFechaMod = Date.Parse(strFechaMod)
            If Me.VENTAENTRADASTableAdapter.SelectNombreEvento(strNombreEventoMod) = strNombreEventoMod And Me.VENTAENTRADASTableAdapter.SelectFechaEvento2(strFechaMod) = strFechaMod Then
                'Me.tcFechas.Enabled = False
                MsgBox("Este evento no puede ser modificado porque ya se vendieron una o más entradas y por políticas de la empresa, esta operación no está permitida", MsgBoxStyle.Critical, "Políticas del teatro")
                Me.groJornadas.Enabled = False
                Me.groSeleccionJornada.Enabled = False
                Me.groUbicaciones.Enabled = False
                Me.btnBorrarFechaActual.Enabled = False
                Me.txtEntradaGeneral.Enabled = False
                Me.txtNombreEncargado.Enabled = False
                Exit Sub
            Else
                Me.tcFechas.Enabled = True
                Me.btnBorrarFechaActual.Enabled = True
            End If
            Me.btnBorrarFechaActual.Enabled = True
            If lstboxFechas.SelectedIndex < 0 Then
                MsgBox("Error: Debe seleccionar al menos una fecha", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
            'Aquí capturo el runencargado de un evento
            groSeleccionJornada.Enabled = True
            txtNombreEncargado.Enabled = True
            txtEntradaGeneral.Enabled = True
            groJornadas.Enabled = True
            cmbJornadas.Enabled = True
            cmbJornadas.Items.Clear()
            cmbJornadas.Text = ""
            chkMatine.Checked = False
            chkTarde.Checked = False
            chkNoche.Checked = False
            chkMatine.Enabled = True
            chkTarde.Enabled = True
            chkNoche.Enabled = True
            blnMatUbi = False
            blnNocUbi = False
            blnTarUbi = False
            blnMatine = False
            blnTarde = False
            blnNoche = False
            groJornadas.Enabled = True
            LimpiarCamposRegistroEvento(txtBalcones, txtPlatea, txtPlateaNumerada)

            txtEntradaGeneral.Text = Me.EVENTOSTableAdapter.SelectEntradaGeneral(intIDEventoMod, strFechaMod)
            strRUNEncargado = Me.EVENTOSTableAdapter.SelectRUNEncargado(intIDEventoMod, strFechaMod)
            cmbJornadas.Items.Clear()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            Conexion.Close()
        End Try

        Conexion.Close()
        Try
            Conexion.Open()
            'Aquí selecciono las fechas correspondientes al nombre de evento seleccionado
            Dim Cadena As String = "SELECT rtrim(PRODUCCION.NOMBREENCARGADO) as NOMBREENCARGADO, RTRIM(PRODUCCION.APELLIDOENCARGADO) AS APELLIDOENCARGADO FROM EVENTOS," & _
            "PRODUCCION WHERE EVENTOS.RUNENCARGADO = PRODUCCION.RUNENCARGADO AND EVENTOS.RUNENCARGADO = '" & strRUNEncargado & "' AND" & _
            " EVENTOS.IDEVENTO = '" & intIDEventoMod & "';"
            Dim SQL As New SqlCommand(Cadena, Conexion)
            Dim DR As SqlDataReader
            Dim nombre As String
            Dim apellido As String
            DR = SQL.ExecuteReader
            DR.Read()
            nombre = DR("NOMBREENCARGADO")
            apellido = DR("APELLIDOENCARGADO")
            DR.Close()
            txtNombreEncargado.Text = nombre & " " & apellido
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            Conexion.Close()
        End Try
        'Dim array(strRUNEncargado.Length) As String
        'Dim strRUNsinGuion As String = ""
        'Dim strGuion As String = ""
        'Dim blnGuion As Boolean = False
        'For i As Integer = 0 To strRUNEncargado.Length - 1
        '    array(i) = strRUNEncargado.Chars(i)
        '    If array(i) = "-" Then
        '        blnGuion = True
        '    End If
        '    If array(i) <> "-" Then
        '        If blnGuion = False Then
        '            strRUNsinGuion = strRUNsinGuion & String.Concat(array(i))
        '        End If
        '    End If
        '    strGuion = array(i)
        'Next
        'Me.txtRUNEncargado.Text = strRUNsinGuion
        'Me.txtGuion.Text = strGuion

        'Aquí al seleccionar una fecha se activan los checkbox de las jornadas que están
        'programadas para la fecha que se seleccionó
        'También agrego las jornadas que tiene una fecha seleccionada al combobox Jornadas
        Try
            Conexion.Open()
            Dim Cadena As String = "Select FECHAEVENTO, MATINÉ,TARDE,NOCHE FROM EVENTOSJORNADAS WHERE FECHAEVENTO ='" & strFechaMod & "';"
            Dim DAdapter As New SqlDataAdapter(Cadena, Conexion)
            Dim DTable As New DataTable
            Dim DRow As DataRow = Nothing
            DAdapter.Fill(DTable)
            For Each DRow In DTable.Rows
                If strFechaMod = DRow("FECHAEVENTO") And DRow("MATINÉ") = intIDEventoMod And DRow("TARDE") = intIDEventoMod And DRow("NOCHE") = intIDEventoMod Then
                    blnMatine = True
                    blnTarde = True
                    blnNoche = True
                    Exit For
                ElseIf strFechaMod = DRow("FECHAEVENTO") And DRow("MATINÉ") = intIDEventoMod And DRow("TARDE") <> intIDEventoMod And DRow("NOCHE") <> intIDEventoMod Then
                    blnMatine = True
                    blnTarde = False
                    blnNoche = False
                    Exit For
                ElseIf strFechaMod = DRow("FECHAEVENTO") And DRow("TARDE") = intIDEventoMod And DRow("MATINÉ") <> intIDEventoMod And DRow("NOCHE") <> intIDEventoMod Then
                    blnTarde = True
                    blnMatine = False
                    blnNoche = False

                    Exit For
                ElseIf strFechaMod = DRow("FECHAEVENTO") And DRow("NOCHE") = intIDEventoMod And DRow("MATINÉ") <> intIDEventoMod And DRow("TARDE") <> intIDEventoMod Then
                    blnNoche = True
                    blnMatine = False
                    blnTarde = False
                    Exit For
                ElseIf strFechaMod = DRow("FECHAEVENTO") And DRow("MATINÉ") = intIDEventoMod And DRow("TARDE") = intIDEventoMod And DRow("NOCHE") <> intIDEventoMod Then
                    blnMatine = True
                    blnTarde = True
                    blnNoche = False
                    Exit For
                ElseIf strFechaMod = DRow("FECHAEVENTO") And DRow("MATINÉ") = intIDEventoMod And DRow("NOCHE") = intIDEventoMod And DRow("TARDE") <> intIDEventoMod Then
                    blnTarde = False
                    blnMatine = True
                    blnNoche = True
                    Exit For
                ElseIf strFechaMod = DRow("FECHAEVENTO") And DRow("TARDE") = intIDEventoMod And DRow("NOCHE") = intIDEventoMod And DRow("MATINÉ") <> intIDEventoMod Then
                    blnTarde = True
                    blnMatine = False
                    blnNoche = True
                    Exit For
                End If
            Next
            'Aquí evalúo las variables booleanas para activar los checkbox de las jornadas según corresponda

            If blnMatine = True And blnTarde = True And blnNoche = True Then
                chkMatine.Checked = True
                chkTarde.Checked = True
                chkNoche.Checked = True
                cmbJornadas.Items.Add("Matiné")
                cmbJornadas.Items.Add("Tarde")
                cmbJornadas.Items.Add("Noche")
                Exit Sub

            ElseIf blnMatine = True And blnTarde = False And blnNoche = False Then
                chkMatine.Checked = True
                chkTarde.Checked = False
                chkNoche.Checked = False
                cmbJornadas.Items.Add("Matiné")
                Exit Sub
            ElseIf blnTarde = True And blnMatine = False And blnNoche = False Then
                chkMatine.Checked = False
                chkTarde.Checked = True
                chkNoche.Checked = False
                cmbJornadas.Items.Add("Tarde")
                Exit Sub
            ElseIf blnNoche = True And blnTarde = False And blnMatine = False Then
                chkNoche.Checked = True
                chkTarde.Checked = False
                chkMatine.Checked = False
                cmbJornadas.Items.Add("Noche")
                Exit Sub
            ElseIf blnMatine = True And blnTarde = True And blnNoche = False Then
                chkMatine.Checked = True
                chkTarde.Checked = True
                chkNoche.Checked = False
                cmbJornadas.Items.Add("Matiné")
                cmbJornadas.Items.Add("Tarde")
                Exit Sub
            ElseIf blnMatine = True And blnNoche = True And blnTarde = False Then
                chkMatine.Checked = True
                chkTarde.Checked = False
                chkNoche.Checked = True
                cmbJornadas.Items.Add("Matiné")
                cmbJornadas.Items.Add("Noche")
                Exit Sub
            ElseIf blnMatine = False And blnTarde = True And blnNoche = True Then
                chkMatine.Checked = False
                chkTarde.Checked = True
                chkNoche.Checked = True
                cmbJornadas.Items.Add("Tarde")
                cmbJornadas.Items.Add("Noche")
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox("Se ha producido el siguiente error: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            Conexion.Close()
            dgProduccion.DataSource = Nothing

        End Try

    End Sub
    'Aqui al seleccionar una jornada, se carga la información de las ubicaciones (balcones, platea, plateanumerada)
    Private Sub cmbJornadas_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbJornadas.SelectedIndexChanged

        blnMatUbi = False

        blnTarUbi = False

        blnNocUbi = False

        groUbicaciones.Enabled = True
        txtPlatea.Enabled = True
        txtPlateaNumerada.Enabled = True
        txtBalcones.Enabled = True
        strJornadaSeleccion = cmbJornadas.SelectedItem
        'Aquí cargo la capacidad de balcones, platea y plateanumerada, según la jornada seleccionada
        Try
            Conexion.Open()
            Dim Cadena As String = "select balcones, platea, plateanumerada from eventosubicaciones where idevento='" & intIDEventoMod & "' and fechaevento='" & strFechaMod & "' and jornada='" & strJornadaSeleccion & "';"
            Dim SQL As New SqlCommand(Cadena, Conexion)
            Dim DR As SqlDataReader
            DR = SQL.ExecuteReader
            DR.Read()
            'Con el método LTrim quito los espacios que se devuelven desde la BD
            If String.IsNullOrEmpty(DR("PLATEA")).ToString Then
                txtPlatea.Text = ""
            ElseIf String.IsNullOrEmpty(DR("PLATEANUMERADA")).ToString Then
                txtPlateaNumerada.Text = ""
            ElseIf String.IsNullOrEmpty(DR("BALCONES")).ToString Then
                txtBalcones.Text = ""
            Else
                txtPlatea.Text = LTrim(Replace(DR("PLATEA"), " ", ""))
                txtPlateaNumerada.Text = LTrim(Replace(DR("PLATEANUMERADA"), " ", ""))
                txtBalcones.Text = LTrim(Replace(DR("BALCONES"), " ", ""))
                DR.Close()
            End If
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            Conexion.Close()
        End Try
    End Sub




    Private Sub dtpFechasEventos_CloseUp(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFechasEventos.CloseUp
        chkMatine.Checked = False
        chkTarde.Checked = False
        chkNoche.Checked = False
        TeatroDataSet.EnforceConstraints = False
        Try


            Me.EVENTOSTableAdapter.Fill(Me.TeatroDataSet.EVENTOS)
            'Aquí valido que no ingrese una fecha existente en el listbox y que también la fecha
            'que se agrega al listbox se mayo a la fecha actual
            ClassEvento.CompruebaJornadas(CDate(dtpFechasEventos.Text), intMatine, blnFechaExiste, intTarde, intNoche, intIDEventoMod)
            If dtpFechasEventos.Value >= Date.Now.Date Then
                Dim b As Boolean = True
                For x As Integer = 0 To Me.lstboxFechasNuevas.Items.Count - 1
                    If CDate(dtpFechasEventos.Text) = lstboxFechasNuevas.Items.Item(x) Then
                        MsgBox("La fecha seleccionada ya existe para este evento", MsgBoxStyle.Critical)
                        b = False
                        Exit For
                    End If
                Next
                If intMatine = 1 Or intTarde = 1 Or intNoche = 1 Then
                    ActivaJornadas(intMatine, intTarde, intNoche, chkMatine, chkTarde, chkNoche)
                    'Aquí compruebo si la fecha ya existe para el evento
                ElseIf CompruebaExisteFecha(intIDEventoMod, CDate(dtpFechasEventos.Text)) = True Then
                    MsgBox("La fecha seleccionada ya está registrada para este evento", MsgBoxStyle.Critical)
                    Exit Sub
                End If
                If b = True Then
                    lstboxFechasNuevas.Items.Add(CDate((dtpFechasEventos.Text)))
                End If
            Else
                MsgBox("La fecha actual debe ser mayor a la actual", MsgBoxStyle.Information)
            End If
        Catch ex As Exception
            MsgBox("Se produjo el siguiente error: " & ex.Message, MsgBoxStyle.Critical, "Teatro")
        End Try

    End Sub

    'Aquí actualizo la tabla eventos  
    Private Sub btnActualizarEvento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizarEvento.Click
        'Validación del combobox que contiene el nombre de los eventos
        Try
            If cmbNombreEvento.GetItemText(cmbNombreEvento.SelectedItem) = "" Then
                ErrorProviderModificarEventos.SetError(cmbNombreEvento, "Campo obligatorio")
                ErrorProviderModificarEventos.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
                Exit Sub
            Else
                ErrorProviderModificarEventos.SetError(cmbNombreEvento, "")
            End If
            'Validación del precio de la entrada general
            If txtEntradaGeneral.Text > 200000 Then
                ErrorProviderModificarEventos.SetError(txtEntradaGeneral, "El precio de entrada no puede ser mayor a 200.000 pesos")
                Exit Sub
            Else
                ErrorProviderModificarEventos.SetError(txtEntradaGeneral, "")
            End If
            'Validación del listbox con las fechas del evento seleccionado
            If lstboxFechas.GetItemText(lstboxFechas.SelectedItem) = "" Then
                ErrorProviderModificarEventos.SetError(lstboxFechas, "Campo obligatorio")
                ErrorProviderModificarEventos.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
                Exit Sub
            Else
                ErrorProviderModificarEventos.SetError(lstboxFechas, "")
            End If
            'Validación del campo textbox entrada general
            If txtEntradaGeneral.TextLength = 0 Then
                ErrorProviderModificarEventos.SetError(txtEntradaGeneral, "Campo obligatorio")
                ErrorProviderModificarEventos.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
                Exit Sub
            Else
                ErrorProviderModificarEventos.SetError(txtEntradaGeneral, "")
            End If
            'Validación de textbox nombre encargado
            If txtNombreEncargado.TextLength = 0 Then
                ErrorProviderModificarEventos.SetError(txtNombreEncargado, "Campo obligatorio")
                ErrorProviderModificarEventos.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
                Exit Sub
            Else
                ErrorProviderModificarEventos.SetError(txtNombreEncargado, "")
            End If

            Me.EVENTOSTableAdapter.UpdateEventos(strNombreEventoMod, strFechaMod, txtEntradaGeneral.Text, strRUNEncargado, intIDEventoMod)
            'If blnModificaNombre = True Then
            '    Me.EVENTOSTableAdapter.UpdateNombresEvento(strNombreEventoMod, intIDEventoMod)
            'End If
            MsgBox("Actualizado satisfactoriamente", MsgBoxStyle.Information)
            Me.btnActualizarEvento.Enabled = False
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            Conexion.Close()
        End Try
    End Sub


    'Aquí capturo los datos del productor para ponerlos en el textbox nombre encargado
    'También capturo el RUN del encargado para la actualización de la tabla eventos
    Private Sub dgProduccion_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgProduccion.CellClick
        btnActualizarEvento.Enabled = True
        Try
            Dim nombre As String
            Dim apellido As String
            nombre = dgProduccion.CurrentRow.Cells("NombreEncargado").Value
            apellido = dgProduccion.CurrentRow.Cells("Apellidoencargado").Value
            strRUNEncargado = Me.EVENTOSTableAdapter.SelectRUNEncargadoModEven(nombre, apellido)
            txtNombreEncargado.Text = nombre & " " & apellido
            'Me.EVENTOSTableAdapter.UpdateEventos(strNombreEventoMod, strFechaMod, txtEntradaGeneral.Text, strRUNEncargado, intIDEventoMod)
            dgProduccion.DataSource = Nothing
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try

    End Sub
    'Aquí recupero la información de productor mientras se escribe
    Private Sub txtNombreEncargado_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNombreEncargado.TextChanged
        dgProduccion.Enabled = True
        Me.txtNombreEncargado.Text = LTrim(Replace(txtNombreEncargado.Text, "  ", " "))
        'If Validaciones.letra(Me.txtNombreEncargado.Text) = False Then
        '    Me.Label2.Text = "INGRESE SOLO LETRAS EN EL CAMPO"
        '    Exit Sub
        'Else
        Try
            Dim DSET As New DataSet
            Dim DAD As New SqlDataAdapter("SELECT RTRIM(NOMBREENCARGADO) AS NOMBREENCARGADO, RTRIM(APELLIDOENCARGADO) AS APELLIDOENCARGADO FROM PRODUCCION WHERE NOMBREENCARGADO LIKE" & _
            "'%" & Me.txtNombreEncargado.Text & "%'" & " OR APELLIDOENCARGADO LIKE '%" & Me.txtNombreEncargado.Text & "%';", Conexion)
            DAD.Fill(DSET)
            dgProduccion.DataSource = DSET
            dgProduccion.DataMember = "TABLE"
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        Finally


            Me.dgProduccion.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            Me.dgProduccion.Columns(0).HeaderText = "Nombre"
            Me.dgProduccion.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            Me.dgProduccion.Columns(1).HeaderText = "Apellido"
        End Try
        'End If
    End Sub
    'Aquí compruebo la disponibilidad de las jornadas para actualizar los eventos
    'En caso que la variable sea = 1 significa que está desocupado, en caso que sea 2
    'significa que está ocupado.

    'Aquí borro la fecha seleccionada del listbox para las fechas nuevas
    Private Sub btnBorrarFecha_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrarFecha.Click
        lstboxFechasNuevas.Items.Remove(lstboxFechasNuevas.SelectedItem)
    End Sub
    'Aquí actualizo la jornada
    'En caso que el control al momento de hacer click esté true se agrega la jornada a la fecha seleccionada
    'En caso que esté false, se elimina.
    Private Sub chkMatine_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkMatine.Click
        Try
            If Date.Now.Hour >= 12 And Date.Now.Minute >= 0 And strFechaMod = Date.Now.Date Then
                MsgBox("Error: Según la hora del sistema, el evento que está registrando, está fuera del horario de la jornada Matiné (Entre 10:00 y 12:00 horas)", MsgBoxStyle.Critical)
                chkMatine.Checked = False
                Exit Sub
            End If
            blnActualizarEvento = True
            LimpiarCamposRegistroEvento(txtBalcones, txtPlatea, txtPlateaNumerada)
            cmbJornadas.Items.Clear()
            intMatine = 1
            'intTarde = 9
            'intNoche = 9
            Me.EventosjornadasTableAdapter1.Fill(Me.TeatroDataSet.EVENTOSJORNADAS)
            ClassEvento.CompruebaSinJornadas(CDate(lstboxFechas.Text), intMatine, intTarde, intNoche, intIDEventoMod)
            If chkMatine.Checked = True Then
                ClassEvento.CompruebaJornadas(CDate(lstboxFechas.Text), intMatine, blnFechaExiste, intTarde, intNoche, intIDEventoMod)
                If blnFechaExiste = True Then
                    If intMatine = 1 Then
                        drResultado = MsgBox("Desea agregar la jornada Matiné a la fecha seleccionada", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Agregar jornada")
                        If drResultado = vbYes Then
                            Me.EventosjornadasTableAdapter1.UpdateMatinéMod(intIDEventoMod, strFechaMod)
                            MsgBox("Jornada Matiné: Agregada correctamente a la fecha seleccionada del evento", MsgBoxStyle.Information)
                            chkMatine.Checked = True
                            cmbJornadas.Text = "Matiné"
                            cmbJornadas.Enabled = True
                            groUbicaciones.Enabled = True
                            txtBalcones.Focus()
                            blnMatUbi = True
                            'Exit Sub
                        Else
                            chkMatine.Checked = False
                        End If
                        drResultado = Nothing
                    ElseIf intMatine = 2 Then
                        MsgBox("Jornada ocupado por otro evento", MsgBoxStyle.Critical)
                        chkMatine.Checked = False
                        'Exit Sub
                        'Else
                        '    Me.EventosjornadasTableAdapter1.InsertJornadas(intIDEventoMod, strFechaMod, intIDEventoMod, 0, 0)
                        '    MsgBox("Jornada Matiné: Agregada correctamente a la fecha seleccionada del evento", MsgBoxStyle.Information)
                        '    chkMatine.Checked = True
                    End If
                Else
                    If intMatine = 2 Then
                        MsgBox("Jornada ocupado por otro evento", MsgBoxStyle.Critical)
                        chkMatine.Checked = False
                    Else

                        drResultado = MsgBox("Desea agregar la jornada Matiné a la fecha seleccionada", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Agregar jornada")
                        If drResultado = vbYes Then
                            Me.EventosjornadasTableAdapter1.InsertJornadas(intIDEventoMod, strFechaMod, intIDEventoMod, 0, 0)
                            MsgBox("Jornada Matiné: Agregada correctamente a la fecha seleccionada del evento", MsgBoxStyle.Information)
                            chkMatine.Checked = True
                            cmbJornadas.Text = "Matiné"
                            cmbJornadas.Enabled = True
                            groUbicaciones.Enabled = True
                            txtBalcones.Focus()
                            blnMatUbi = True
                        Else
                            chkMatine.Checked = False
                            Exit Sub
                        End If
                    End If
                End If


            ElseIf chkMatine.Checked = False Then
                If Me.EventosjornadasTableAdapter1.CompruebaMatiné(strFechaMod) = intIDEventoMod Then
                    drResultado = MsgBox("¿Esta seguro que quiere eliminar la jornada Matiné de la fecha seleccionada?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Eliminar Jornada")
                    If drResultado = vbYes Then
                        If CompruebaFechas(strFechaMod) = 23 Or CompruebaFechas(strFechaMod, intIDEventoMod) = 23 Then
                            drResultado = MsgBox("El evento que está modificando, no tiene más fechas programadas. Si elimina esta jornada, se borrará la fecha junto con el evento seleccionado automáticamente, ¿Desea continuar?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Eliminar fecha")
                            If drResultado = vbYes And CompruebaFechas(strFechaMod) = 23 Then
                                Me.EVENTOSTableAdapter.DeleteEventos(intIDEventoMod, strFechaMod)
                                Me.EventosjornadasTableAdapter1.DeleteJornada(strFechaMod)
                                Me.EventosubicacionesTableAdapter1.DeleteUbicacionTodo(intIDEventoMod, strFechaMod)
                                MsgBox("Fecha seleccionada borrada satisfactoriamente", MsgBoxStyle.Information)
                                groJornadas.Enabled = False
                                Me.btnBorrarFecha.Enabled = False
                                cmbJornadas.Enabled = False
                                Me.groUbicaciones.Enabled = False
                                cmbJornadas.Text = ""
                                txtNombreEncargado.Text = ""
                                Me.dgProduccion.DataSource = Nothing
                                Me.groInfoEventos.Enabled = True
                                Me.cmbNombreEvento.Enabled = True
                                Me.tcFechas.Enabled = True
                                cmbNombreEvento.Focus()
                                Me.ErrorProviderModificarEventos.SetError(txtBalcones, "")
                            ElseIf drResultado = vbNo Then
                                chkMatine.Checked = True
                                Exit Sub
                            ElseIf CompruebaFechas(strFechaMod, intIDEventoMod) = 23 Then
                                Me.EventosjornadasTableAdapter1.UpdateMatinéMod(0, strFechaMod)
                                Me.EVENTOSTableAdapter.DeleteEventos(intIDEventoMod, strFechaMod)
                                MsgBox("Jornada Matiné: Eliminada correctamente de la fecha seleccionada del evento", MsgBoxStyle.Information)
                                chkMatine.Checked = False
                                Me.EventosubicacionesTableAdapter1.DeleteUbicacion(intIDEventoMod, strFechaMod, chkMatine.Text)
                                LimpiarCamposRegistroEvento(txtBalcones, txtPlatea, txtPlateaNumerada)
                                cmbJornadas.Text = ""
                                groJornadas.Enabled = False
                                Me.cmbNombreEvento.Focus()
                                Me.groUbicaciones.Enabled = False
                                Me.ErrorProviderModificarEventos.SetError(txtBalcones, "")
                                Me.groInfoEventos.Enabled = True
                            ElseIf drResultado = vbNo Then
                                Exit Sub
                            End If
                        Else
                            Me.EventosjornadasTableAdapter1.UpdateMatinéMod(0, strFechaMod)
                            MsgBox("Jornada Matiné: Eliminada correctamente de la fecha seleccionada del evento", MsgBoxStyle.Information)
                            chkMatine.Checked = False
                            Me.EventosubicacionesTableAdapter1.DeleteUbicacion(intIDEventoMod, strFechaMod, chkMatine.Text)
                            LimpiarCamposRegistroEvento(txtBalcones, txtPlatea, txtPlateaNumerada)
                            cmbJornadas.Text = ""
                            Me.groUbicaciones.Enabled = False
                            Me.ErrorProviderModificarEventos.SetError(txtBalcones, "")
                        End If
                    ElseIf drResultado = vbNo Then
                        chkMatine.Checked = True
                    Else
                        MsgBox("Jornada Matiné: No se puede eliminar, está programada para el evento: " & Me.EVENTOSTableAdapter.SelectNombreEvento _
                        (Me.EventosjornadasTableAdapter1.CompruebaMatiné(strFechaMod)) & "", MsgBoxStyle.Critical)
                        chkMatine.Checked = True
                    End If
                End If
            End If
            drResultado = Nothing
            'Aquí compruebo los checkbox para llenar el combobox Jornadas
            'Me.EventosjornadasTableAdapter1.Fill(Me.TeatroDataSet.EVENTOSJORNADAS)
            If CompruebaCheckbox(chkMatine, chkTarde, chkNoche) = 123 Then
                cmbJornadas.Items.Add("Matiné")
                cmbJornadas.Items.Add("Tarde")
                cmbJornadas.Items.Add("Noche")
                Exit Sub
            ElseIf CompruebaCheckbox(chkMatine, chkTarde, chkNoche) = 1 Then
                cmbJornadas.Items.Add("Matiné")
                Exit Sub
            ElseIf CompruebaCheckbox(chkMatine, chkTarde, chkNoche) = 2 Then
                cmbJornadas.Items.Add("Tarde")
                Exit Sub
            ElseIf CompruebaCheckbox(chkMatine, chkTarde, chkNoche) = 3 Then
                cmbJornadas.Items.Add("Noche")
                Exit Sub
            ElseIf CompruebaCheckbox(chkMatine, chkTarde, chkNoche) = 12 Then
                cmbJornadas.Items.Add("Matiné")
                cmbJornadas.Items.Add("Tarde")
                Exit Sub
            ElseIf CompruebaCheckbox(chkMatine, chkTarde, chkNoche) = 13 Then
                cmbJornadas.Items.Add("Matiné")
                cmbJornadas.Items.Add("Noche")
                Exit Sub
            ElseIf CompruebaCheckbox(chkMatine, chkTarde, chkNoche) = 23 Then
                cmbJornadas.Items.Add("Tarde")
                cmbJornadas.Items.Add("Noche")
                Exit Sub
                'ElseIf CompruebaCheckbox(chkMatine, chkTarde, chkNoche) = 111 Then
                '    MsgBox("Debe seleccionar al menos una jornada... como tan...", MsgBoxStyle.Critical)
                '    Exit Sub
            End If

            Me.ErrorProviderModificarEventos.SetError(txtBalcones, "")
        Catch ex As Exception
            MsgBox("Se produjo el siguiente error: " & ex.Message, MsgBoxStyle.Critical, "Teatro")
        End Try

    End Sub

    'Aquí actualizo la jornada
    'En caso que el control al momento de hacer click esté true se agrega la jornada a la fecha seleccionada
    'En caso que esté false, se elimina.
    Private Sub chkTarde_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkTarde.Click
        Try
            blnActualizarEvento = True
            LimpiarCamposRegistroEvento(txtBalcones, txtPlatea, txtPlateaNumerada)
            cmbJornadas.Items.Clear()
            'intMatine = 9
            intTarde = 1
            'intNoche = 9
            Me.EventosjornadasTableAdapter1.Fill(Me.TeatroDataSet.EVENTOSJORNADAS)
            ClassEvento.CompruebaSinJornadas(CDate(lstboxFechas.Text), intMatine, intTarde, intNoche, intIDEventoMod)
            If chkTarde.Checked = True Then
                ClassEvento.CompruebaJornadas(CDate(lstboxFechas.Text), intMatine, blnFechaExiste, intTarde, intNoche, intIDEventoMod)
                If blnFechaExiste = True Then
                    If intTarde = 1 Then
                        drResultado = MsgBox("Desea agregar la jornada Tarde a la fecha seleccionada", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Agregar jornada")
                        If drResultado = vbYes Then
                            Me.EventosjornadasTableAdapter1.UpdateTardeMod(intIDEventoMod, strFechaMod)
                            MsgBox("Jornada Tarde: Agregada correctamente a la fecha seleccionada del evento", MsgBoxStyle.Information)
                            chkTarde.Checked = True
                            cmbJornadas.Text = "Tarde"
                            blnTarUbi = True 'Aquí la pongo true para insertar las ubicaciones en vez de actualizar
                            groUbicaciones.Enabled = True
                            txtBalcones.Focus()
                        Else
                            chkTarde.Checked = False
                        End If
                        drResultado = Nothing
                    ElseIf intTarde = 2 Then
                        MsgBox("Jornada ocupado por otro evento", MsgBoxStyle.Critical)
                        chkTarde.Checked = False
                    End If
                Else
                    If intTarde = 2 Then
                        MsgBox("Jornada ocupado por otro evento", MsgBoxStyle.Critical)
                        chkTarde.Checked = False
                    Else
                        drResultado = MsgBox("Desea agregar la jornada Tarde a la fecha seleccionada", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Agregar jornada")
                        If drResultado = vbYes Then
                            Me.EventosjornadasTableAdapter1.InsertJornadas(intIDEventoMod, strFechaMod, 0, intIDEventoMod, 0)
                            MsgBox("Jornada Tarde: Agregada correctamente a la fecha seleccionada del evento", MsgBoxStyle.Information)
                            chkTarde.Checked = True
                            cmbJornadas.Enabled = True
                            cmbJornadas.Text = "Tarde"
                            groUbicaciones.Enabled = True
                            txtBalcones.Focus()
                            blnTarUbi = True
                        Else
                            chkTarde.Checked = False
                            Exit Sub
                        End If
                    End If
                End If
            ElseIf chkTarde.Checked = False Then
                If Me.EventosjornadasTableAdapter1.CompruebaTarde(strFechaMod) = intIDEventoMod Then
                    drResultado = MsgBox("Esta seguro que quiere eliminar la jornada Tarde de la fecha seleccionada", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Eliminar Jornada")
                    If drResultado = vbYes Then
                        If CompruebaFechas(strFechaMod) = 13 Or CompruebaFechas(strFechaMod, intIDEventoMod) = 13 Then
                            drResultado = MsgBox("El evento que está modificando, no tiene más fechas programadas. Si elimina esta jornada, se borrará la fecha junto con el evento seleccionado automáticamente, ¿Desea continuar?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Eliminar fecha")
                            If drResultado = vbYes And CompruebaFechas(strFechaMod) = 13 Then
                                Me.EVENTOSTableAdapter.DeleteEventos(intIDEventoMod, strFechaMod)
                                Me.EventosjornadasTableAdapter1.DeleteJornada(strFechaMod)
                                Me.EventosubicacionesTableAdapter1.DeleteUbicacionTodo(intIDEventoMod, strFechaMod)
                                MsgBox("Fecha seleccionada borrada satisfactoriamente", MsgBoxStyle.Information)
                                groJornadas.Enabled = False
                                cmbJornadas.Text = ""
                                txtNombreEncargado.Text = ""
                                Me.dgProduccion.DataSource = Nothing
                                Me.btnBorrarFecha.Enabled = False
                                cmbJornadas.Enabled = False
                                Me.groUbicaciones.Enabled = False
                                Me.ErrorProviderModificarEventos.SetError(txtBalcones, "")
                                Me.groInfoEventos.Enabled = True
                                Me.cmbNombreEvento.Enabled = True
                                Me.tcFechas.Enabled = True
                                cmbNombreEvento.Focus()
                            ElseIf drResultado = vbNo Then
                                chkTarde.Checked = True
                                Exit Sub
                            ElseIf CompruebaFechas(strFechaMod, intIDEventoMod) = 13 Then
                                Me.EVENTOSTableAdapter.DeleteEventos(intIDEventoMod, strFechaMod)
                                Me.EventosjornadasTableAdapter1.UpdateTardeMod(0, strFechaMod)
                                MsgBox("Jornada Tarde: Eliminada correctamente de la fecha seleccionada del evento", MsgBoxStyle.Information)
                                chkTarde.Checked = False
                                groJornadas.Enabled = False
                                LimpiarCamposRegistroEvento(txtBalcones, txtPlatea, txtPlateaNumerada)
                                cmbJornadas.Text = ""
                                Me.EventosubicacionesTableAdapter1.DeleteUbicacion(intIDEventoMod, strFechaMod, chkTarde.Text)
                                cmbJornadas.Enabled = False
                                Me.cmbNombreEvento.Focus()
                                Me.groUbicaciones.Enabled = False
                                Me.ErrorProviderModificarEventos.SetError(txtBalcones, "")
                                Me.groInfoEventos.Enabled = True
                            ElseIf drResultado = vbNo Then
                                Exit Sub
                            End If
                        Else
                            Me.EventosjornadasTableAdapter1.UpdateTardeMod(0, strFechaMod)
                            MsgBox("Jornada Tarde: Eliminada correctamente de la fecha seleccionada del evento", MsgBoxStyle.Information)
                            chkTarde.Checked = False
                            LimpiarCamposRegistroEvento(txtBalcones, txtPlatea, txtPlateaNumerada)
                            cmbJornadas.Text = ""
                            Me.EventosubicacionesTableAdapter1.DeleteUbicacion(intIDEventoMod, strFechaMod, chkTarde.Text)
                            Me.groUbicaciones.Enabled = False
                            Me.ErrorProviderModificarEventos.SetError(txtBalcones, "")
                        End If
                    ElseIf drResultado = vbNo Then
                        chkTarde.Checked = True
                    Else
                        MsgBox("Jornada Tarde: No se puede eliminar, está programada para el evento: " & Me.EVENTOSTableAdapter.SelectNombreEvento _
                        (Me.EventosjornadasTableAdapter1.CompruebaTarde(strFechaMod)) & "", MsgBoxStyle.Critical)
                        chkTarde.Checked = True
                    End If
                End If
            End If
            drResultado = Nothing

            'Aquí compruebo los checkbox para llenar el combobox Jornadas
            If CompruebaCheckbox(chkMatine, chkTarde, chkNoche) = 123 Then
                cmbJornadas.Items.Add("Matiné")
                cmbJornadas.Items.Add("Tarde")
                cmbJornadas.Items.Add("Noche")
                Exit Sub
            ElseIf CompruebaCheckbox(chkMatine, chkTarde, chkNoche) = 1 Then
                cmbJornadas.Items.Add("Matiné")
                Exit Sub
            ElseIf CompruebaCheckbox(chkMatine, chkTarde, chkNoche) = 2 Then
                cmbJornadas.Items.Add("Tarde")
                Exit Sub
            ElseIf CompruebaCheckbox(chkMatine, chkTarde, chkNoche) = 3 Then
                cmbJornadas.Items.Add("Noche")
                Exit Sub
            ElseIf CompruebaCheckbox(chkMatine, chkTarde, chkNoche) = 12 Then
                cmbJornadas.Items.Add("Matiné")
                cmbJornadas.Items.Add("Tarde")
                Exit Sub
            ElseIf CompruebaCheckbox(chkMatine, chkTarde, chkNoche) = 13 Then
                cmbJornadas.Items.Add("Matiné")
                cmbJornadas.Items.Add("Noche")
                Exit Sub
            ElseIf CompruebaCheckbox(chkMatine, chkTarde, chkNoche) = 23 Then
                cmbJornadas.Items.Add("Tarde")
                cmbJornadas.Items.Add("Noche")
                Exit Sub
                'ElseIf CompruebaCheckbox(chkMatine, chkTarde, chkNoche) = 111 Then
                '    MsgBox("Debe seleccionar al menos una jornada... como tan...", MsgBoxStyle.Critical)
                '    Exit Sub

            End If
            Me.ErrorProviderModificarEventos.SetError(txtBalcones, "")
        Catch ex As Exception
            MsgBox("Se produjo el siguiente error: " & ex.Message, MsgBoxStyle.Critical, "Teatro")
        End Try
    End Sub

    'Aquí actualizo la jornada
    'En caso que el control al momento de hacer click esté true se agrega la jornada a la fecha seleccionada
    'En caso que esté false, se elimina.
    Private Sub chkNoche_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkNoche.Click
        Try
            blnActualizarEvento = True
            LimpiarCamposRegistroEvento(txtBalcones, txtPlatea, txtPlateaNumerada)
            drResultado = Nothing
            cmbJornadas.Items.Clear()
            'intMatine = 9
            intNoche = 1
            'intNoche = 9
            Me.EventosjornadasTableAdapter1.Fill(Me.TeatroDataSet.EVENTOSJORNADAS)
            ClassEvento.CompruebaSinJornadas(CDate(lstboxFechas.Text), intMatine, intTarde, intNoche, intIDEventoMod)

            If chkNoche.Checked = True Then
                ClassEvento.CompruebaJornadas(CDate(lstboxFechas.Text), intMatine, blnFechaExiste, intTarde, intNoche, intIDEventoMod)
                If blnFechaExiste = True Then
                    If intNoche = 1 Then
                        drResultado = MsgBox("Desea agregar la jornada Noche a la fecha seleccionada", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Agregar jornada")
                        If drResultado = vbYes Then
                            Me.EventosjornadasTableAdapter1.UpdateNocheMod(intIDEventoMod, strFechaMod)
                            MsgBox("Jornada Noche: Agregada correctamente a la fecha seleccionada del evento", MsgBoxStyle.Information)
                            chkNoche.Checked = True
                            cmbJornadas.Text = "Noche"
                            blnNocUbi = True
                            groUbicaciones.Enabled = True
                            txtBalcones.Focus()
                            'Exit Sub
                        Else
                            chkNoche.Checked = False
                        End If
                        drResultado = Nothing
                    ElseIf intNoche = 2 Then
                        MsgBox("Jornada ocupado por otro evento", MsgBoxStyle.Critical)
                        chkNoche.Checked = False
                        'Else
                        '    Me.EventosjornadasTableAdapter1.InsertJornadas(intIDEventoMod, strFechaMod, 0, 0, intIDEventoMod)
                        '    MsgBox("Jornada Noche: Agregada correctamente a la fecha seleccionada del evento", MsgBoxStyle.Information)
                        '    chkNoche.Checked = True
                    End If
                Else
                    If intNoche = 2 Then
                        MsgBox("Jornada ocupado por otro evento", MsgBoxStyle.Critical)
                        chkNoche.Checked = False
                    Else
                        drResultado = MsgBox("Desea agregar la jornada Noche a la fecha seleccionada", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Agregar jornada")
                        If drResultado = vbYes Then
                            Me.EventosjornadasTableAdapter1.InsertJornadas(intIDEventoMod, strFechaMod, 0, 0, intIDEventoMod)
                            MsgBox("Jornada Noche: Agregada correctamente a la fecha seleccionada del evento", MsgBoxStyle.Information)
                            chkNoche.Checked = True
                            cmbJornadas.Text = "Noche"
                            cmbJornadas.Enabled = True
                            groUbicaciones.Enabled = True
                            txtBalcones.Focus()
                            blnNocUbi = True
                        Else
                            chkNoche.Checked = False
                            Exit Sub
                        End If
                    End If
                End If
            ElseIf chkNoche.Checked = False Then
                If Me.EventosjornadasTableAdapter1.CompruebaNoche(strFechaMod) = intIDEventoMod Then
                    drResultado = MsgBox("¿Esta seguro que quiere eliminar la jornada Noche de la fecha seleccionada?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Eliminar Jornada")
                    If drResultado = vbYes Then
                        If CompruebaFechas(strFechaMod) = 12 Or CompruebaFechas(strFechaMod, intIDEventoMod) = 12 Then
                            drResultado = MsgBox("El evento que está modificando, no tiene más fechas programadas. Si elimina esta jornada, se borrará la fecha junto con el evento seleccionado automáticamente, ¿Desea continuar?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Eliminar fecha")
                            If drResultado = vbYes And CompruebaFechas(strFechaMod) = 12 Then
                                Me.EVENTOSTableAdapter.DeleteEventos(intIDEventoMod, strFechaMod)
                                Me.EventosjornadasTableAdapter1.DeleteJornada(strFechaMod)
                                Me.EventosubicacionesTableAdapter1.DeleteUbicacionTodo(intIDEventoMod, strFechaMod)
                                MsgBox("Fecha seleccionada borrada satisfactoriamente", MsgBoxStyle.Information)
                                groJornadas.Enabled = False
                                Me.btnBorrarFecha.Enabled = False
                                cmbJornadas.Enabled = False
                                Me.groUbicaciones.Enabled = False
                                cmbJornadas.Text = ""
                                txtNombreEncargado.Text = ""
                                Me.dgProduccion.DataSource = Nothing
                                Me.ErrorProviderModificarEventos.SetError(txtBalcones, "")
                                Me.groInfoEventos.Enabled = True
                                Me.cmbNombreEvento.Enabled = True
                                Me.tcFechas.Enabled = True
                                cmbNombreEvento.Focus()
                            ElseIf drResultado = vbNo Then
                                chkNoche.Checked = True
                                Exit Sub
                            ElseIf CompruebaFechas(strFechaMod, intIDEventoMod) = 12 Then
                                Me.EventosjornadasTableAdapter1.UpdateNocheMod(0, strFechaMod)
                                Me.EVENTOSTableAdapter.DeleteEventos(intIDEventoMod, strFechaMod)
                                MsgBox("Jornada Noche: Eliminada correctamente de la fecha seleccionada del evento", MsgBoxStyle.Information)
                                groJornadas.Enabled = False
                                chkNoche.Checked = False
                                LimpiarCamposRegistroEvento(txtBalcones, txtPlatea, txtPlateaNumerada)
                                cmbJornadas.Text = ""
                                Me.EventosubicacionesTableAdapter1.DeleteUbicacion(intIDEventoMod, strFechaMod, chkNoche.Text)
                                cmbJornadas.Enabled = False
                                Me.cmbNombreEvento.Focus()
                                Me.ErrorProviderModificarEventos.SetError(txtBalcones, "")
                                Me.groUbicaciones.Enabled = False
                                Me.groInfoEventos.Enabled = True
                            ElseIf drResultado = vbNo Then
                                Exit Sub
                            End If
                        Else
                            Me.EventosjornadasTableAdapter1.UpdateNocheMod(0, strFechaMod)
                            MsgBox("Jornada Noche: Eliminada correctamente de la fecha seleccionada del evento", MsgBoxStyle.Information)
                            chkNoche.Checked = False
                            LimpiarCamposRegistroEvento(txtBalcones, txtPlatea, txtPlateaNumerada)
                            cmbJornadas.Text = ""
                            Me.EventosubicacionesTableAdapter1.DeleteUbicacion(intIDEventoMod, strFechaMod, chkNoche.Text)
                            Me.groUbicaciones.Enabled = False
                            Me.ErrorProviderModificarEventos.SetError(txtBalcones, "")
                        End If
                    ElseIf drResultado = vbNo Then
                        chkNoche.Checked = True
                    Else
                        MsgBox("Jornada Noche: No se puede eliminar, está programada para stá programada para el evento: " & Me.EVENTOSTableAdapter.SelectNombreEvento _
                        (Me.EventosjornadasTableAdapter1.CompruebaNoche(strFechaMod)) & "", MsgBoxStyle.Critical)
                        chkNoche.Checked = True
                    End If
                End If
            End If
            drResultado = Nothing

            'Aquí compruebo los checkbox para llenar el combobox Jornadas
            If CompruebaCheckbox(chkMatine, chkTarde, chkNoche) = 123 Then
                cmbJornadas.Items.Add("Matiné")
                cmbJornadas.Items.Add("Tarde")
                cmbJornadas.Items.Add("Noche")
                Exit Sub
            ElseIf CompruebaCheckbox(chkMatine, chkTarde, chkNoche) = 1 Then
                cmbJornadas.Items.Add("Matiné")
                Exit Sub
            ElseIf CompruebaCheckbox(chkMatine, chkTarde, chkNoche) = 2 Then
                cmbJornadas.Items.Add("Tarde")
                Exit Sub
            ElseIf CompruebaCheckbox(chkMatine, chkTarde, chkNoche) = 3 Then
                cmbJornadas.Items.Add("Noche")
                Exit Sub
            ElseIf CompruebaCheckbox(chkMatine, chkTarde, chkNoche) = 12 Then
                cmbJornadas.Items.Add("Matiné")
                cmbJornadas.Items.Add("Tarde")
                Exit Sub
            ElseIf CompruebaCheckbox(chkMatine, chkTarde, chkNoche) = 13 Then
                cmbJornadas.Items.Add("Matiné")
                cmbJornadas.Items.Add("Noche")
                Exit Sub
            ElseIf CompruebaCheckbox(chkMatine, chkTarde, chkNoche) = 23 Then
                cmbJornadas.Items.Add("Tarde")
                cmbJornadas.Items.Add("Noche")
                Exit Sub
                'ElseIf CompruebaCheckbox(chkMatine, chkTarde, chkNoche) = 111 Then
                '    MsgBox("Debe seleccionar al menos una jornada... como tan...", MsgBoxStyle.Critical)
                '    Exit Sub
            End If
            Me.ErrorProviderModificarEventos.SetError(txtBalcones, "")
        Catch ex As Exception
            MsgBox("Se produjo el siguiente error: " & ex.Message, MsgBoxStyle.Critical, "Teatro")
        End Try
    End Sub


    Private Sub tcFechas_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tcFechas.SelectedIndexChanged
        Try
            Me.TeatroDataSet.EnforceConstraints = False
            Me.EVENTOSTableAdapter.Fill(Me.TeatroDataSet.EVENTOS)
            If Me.tcFechas.SelectedTab.Text = "Agregar nuevas fecha" Then
                groJornadas.Enabled = False
                groUbicaciones.Enabled = False
                cmbJornadas.Enabled = False
                chkMatine.Enabled = False
                chkTarde.Enabled = False
                chkNoche.Enabled = False
                If strNombreEventoMod = Nothing Then
                    MsgBox("Debe seleccionar un evento antes de agregar una nueva fecha", MsgBoxStyle.Critical)
                    Me.tcFechas.SelectTab("tpFechasActuales")
                ElseIf lstboxFechas.Text = Nothing Then
                    MsgBox("Debe seleccionar una fecha antes de agregar una nueva fecha", MsgBoxStyle.Critical)
                    Me.tcFechas.SelectTab("tpFechasActuales")
                End If
            ElseIf Me.tcFechas.SelectedTab.Text = "Fechas actuales" Then


                'Aquí cargo el listbox con las nuevas fechas

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
                'groJornadas.Enabled = True
                'groUbicaciones.Enabled = True
                chkMatine.Enabled = False
                chkTarde.Enabled = False
                chkNoche.Enabled = False
                'lstboxFechas.SelectedItem = lstboxFechas.Items.Item(1)

            End If
        Catch ex As Exception
            MsgBox("Se ha producido el siguiente error: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            Conexion.Close()
        End Try

    End Sub


    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Try
            TeatroDataSet.EnforceConstraints = False
            Me.EVENTOSTableAdapter.Fill(Me.TeatroDataSet.EVENTOS)
            Dim strFechaNueva As String
            Dim strPriFechaListBox As String
            strPriFechaListBox = Me.lstboxFechas.GetItemText(Me.lstboxFechas.Items.Item(0))
            strFechaNueva = lstboxFechasNuevas.SelectedItem

            While strFechaNueva <> Nothing
                If CompruebaFechas(strFechaNueva) = 9 Then
                    MsgBox("Esta todo programado", MsgBoxStyle.Critical)
                    lstboxFechasNuevas.Items.Remove(lstboxFechasNuevas.SelectedItem)
                    Exit Sub
                ElseIf CompruebaFechaJornada(strFechaNueva, intIDEventoMod) = 0 And CompruebaExisteFecha(intIDEventoMod, strFechaNueva) = False Then
                    Me.EVENTOSTableAdapter.InsertarEventos(intIDEventoMod, strNombreEventoMod, strFechaNueva, Integer.Parse(Me.EVENTOSTableAdapter.SelectEntraGeneral(strNombreEventoMod)), Me.EVENTOSTableAdapter.SelectRUNEncargado(intIDEventoMod, strPriFechaListBox))
                    MsgBox("Fecha agregada al evento satisfactoriamente. Agréguele las jornadas y las ubicaciones en la pestaña Fechas actuales", MsgBoxStyle.Information)
                    lstboxFechasNuevas.Items.Remove(lstboxFechasNuevas.SelectedItem)
                    Exit Sub
                ElseIf CompruebaFechas(strFechaNueva) = 1 Or CompruebaFechas(strFechaNueva) = 3 Or _
            CompruebaFechas(strFechaNueva) = 2 Or CompruebaFechas(strFechaNueva) = 12 Or CompruebaFechas(strFechaNueva) = 13 Or _
            CompruebaFechas(strFechaNueva) = 23 Then
                    MsgBox("La fecha ya está registrada en este evento! Agréguele las jornadas disponibles seleccionándola en la pestaña Fechas actuales", MsgBoxStyle.Information)
                    lstboxFechasNuevas.Items.Remove(lstboxFechasNuevas.SelectedItem)
                    Exit Sub
                ElseIf CompruebaExisteFecha(intIDEventoMod, strFechaNueva) = True Then
                    MsgBox("La fecha seleccionada ya está registrada para este evento", MsgBoxStyle.Critical)
                    lstboxFechasNuevas.Items.Remove(lstboxFechasNuevas.SelectedItem)
                    Exit Sub
                End If
            End While
            MsgBox("Seleccione la fecha antes de guardar", MsgBoxStyle.Critical)
        Catch ex As Exception
            MsgBox("Se produjo el siguiente error: " & ex.Message, MsgBoxStyle.Critical, "Teatro")
        End Try
    End Sub

    Private Sub txtEntradaGeneral_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtEntradaGeneral.KeyPress
        If (Asc(e.KeyChar)) >= 48 And (Asc(e.KeyChar)) <= 57 Or (Asc(e.KeyChar)) = System.Windows.Forms.Keys.Back Or Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
        btnActualizarEvento.Enabled = True
    End Sub
    Private Sub txtEntradaGeneral_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtEntradaGeneral.Validating
        If txtEntradaGeneral.TextLength = 0 Then
            ErrorProviderModificarEventos.Clear()
            ErrorProviderModificarEventos.SetError(txtEntradaGeneral, "Campo obligatorio")
            ErrorProviderModificarEventos.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
            txtEntradaGeneral.Focus()
            Exit Sub
        Else
            ErrorProviderModificarEventos.SetError(txtEntradaGeneral, "")
        End If
    End Sub
    'Validación de que no tenga campos nulos el campo txtNombrEncargado
    Private Sub txtNombreEncargado_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtNombreEncargado.Validating
        If txtNombreEncargado.TextLength = 0 Then
            ErrorProviderModificarEventos.Clear()
            ErrorProviderModificarEventos.SetError(txtNombreEncargado, "Campo obligatorio")
            ErrorProviderModificarEventos.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
            txtEntradaGeneral.Focus()
            Exit Sub
        Else
            ErrorProviderModificarEventos.SetError(txtNombreEncargado, "")
        End If
    End Sub

    Private Sub txtBalcones_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBalcones.GotFocus
        Me.btnActualizarUbicaciones.Enabled = True
        Me.groJornadas.Enabled = False
        Me.tcFechas.Enabled = False
        cmbJornadas.Enabled = False
        cmbNombreEvento.Enabled = False
    End Sub

    Private Sub txtBalcones_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBalcones.KeyPress
        If (Asc(e.KeyChar)) >= 48 And (Asc(e.KeyChar)) <= 57 Or (Asc(e.KeyChar)) = System.Windows.Forms.Keys.Back Or Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    'Validación de que no tenga campos nulos el campo txtBalcones
    Private Sub txtBalcones_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtBalcones.Validating
        If txtBalcones.TextLength = 0 Then
            ErrorProviderModificarEventos.Clear()
            ErrorProviderModificarEventos.SetError(txtBalcones, "Campo obligatorio")
            ErrorProviderModificarEventos.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
            txtBalcones.Focus()
            Exit Sub
        Else
            ErrorProviderModificarEventos.SetError(txtBalcones, "")
        End If
        If Integer.Parse(txtBalcones.Text) > Integer.Parse(lblMaxBalcones.Text) Then
            ErrorProviderModificarEventos.SetError(txtBalcones, "Hay sólo " & lblMaxBalcones.Text & " asientos disponibles")
            ErrorProviderModificarEventos.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
            txtBalcones.Focus()
            Exit Sub
        Else
            ErrorProviderModificarEventos.SetError(txtBalcones, "")
        End If
        Me.ErrorProviderModificarEventos.SetError(txtBalcones, "")
    End Sub

    Private Sub txtPlatea_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPlatea.GotFocus
        Me.btnActualizarUbicaciones.Enabled = True
        Me.groJornadas.Enabled = False
        Me.tcFechas.Enabled = False
        cmbJornadas.Enabled = False
        cmbNombreEvento.Enabled = False
    End Sub

    Private Sub txtPlatea_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPlatea.KeyPress
        If (Asc(e.KeyChar)) >= 48 And (Asc(e.KeyChar)) <= 57 Or (Asc(e.KeyChar)) = System.Windows.Forms.Keys.Back Or Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub


    'Validación de que no tenga campos nulos el campo txtPlatea
    Private Sub txtPlatea_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtPlatea.Validating
        If txtPlatea.TextLength = 0 Then
            ErrorProviderModificarEventos.Clear()
            ErrorProviderModificarEventos.SetError(txtPlatea, "Campo obligatorio")
            ErrorProviderModificarEventos.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
            txtPlatea.Focus()
            Exit Sub
        Else
            ErrorProviderModificarEventos.SetError(txtPlatea, "")
        End If
        If Integer.Parse(txtPlatea.Text) > Integer.Parse(lblMaxPlatea.Text) Then
            ErrorProviderModificarEventos.SetError(txtPlatea, "Hay sólo " & lblMaxPlatea.Text & " asientos disponibles")
            ErrorProviderModificarEventos.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
            txtPlatea.Focus()
            Exit Sub
        Else
            ErrorProviderModificarEventos.SetError(txtPlatea, "")
        End If
        Me.ErrorProviderModificarEventos.SetError(txtBalcones, "")
    End Sub

    Private Sub txtPlateaNumerada_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPlateaNumerada.GotFocus
        Me.btnActualizarUbicaciones.Enabled = True
        Me.groJornadas.Enabled = False
        Me.tcFechas.Enabled = False
        cmbJornadas.Enabled = False
        cmbNombreEvento.Enabled = False
    End Sub

    Private Sub txtPlateaNumerada_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPlateaNumerada.KeyPress
        If (Asc(e.KeyChar)) >= 48 And (Asc(e.KeyChar)) <= 57 Or (Asc(e.KeyChar)) = System.Windows.Forms.Keys.Back Or Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    'Validación de que no tenga campos nulos el campo txtPlateaNumerada
    Private Sub txtPlateaNumerada_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtPlateaNumerada.Validating
        If txtPlateaNumerada.TextLength = 0 Then
            ErrorProviderModificarEventos.Clear()
            ErrorProviderModificarEventos.SetError(txtPlateaNumerada, "Campo obligatorio")
            ErrorProviderModificarEventos.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
            txtPlateaNumerada.Focus()
            Exit Sub
        Else
            ErrorProviderModificarEventos.SetError(txtPlatea, "")
        End If
        If Integer.Parse(txtPlateaNumerada.Text) > Integer.Parse(lblMaxPlateaNumerada.Text) Then
            ErrorProviderModificarEventos.SetError(txtPlateaNumerada, "Hay sólo " & lblMaxPlateaNumerada.Text & " asientos disponibles")
            ErrorProviderModificarEventos.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
            txtPlateaNumerada.Focus()
            Exit Sub
        Else
            ErrorProviderModificarEventos.SetError(txtPlateaNumerada, "")
        End If
        Me.ErrorProviderModificarEventos.SetError(txtBalcones, "")
    End Sub
    'Actualizo las valores de los campos correspodientes a las ubicaciones al hacer click en el boton de actualizar ubicaciones
    Private Sub btnActualizarUbicaciones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizarUbicaciones.Click
        Try
            If txtBalcones.TextLength = 0 Then
                ErrorProviderModificarEventos.SetError(txtBalcones, "Campo obligatorio")
                ErrorProviderModificarEventos.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
                txtBalcones.Focus()
                Exit Sub
            Else
                ErrorProviderModificarEventos.SetError(txtBalcones, "")
            End If
            If txtPlatea.TextLength = 0 Then
                ErrorProviderModificarEventos.SetError(txtPlatea, "Campo obligatorio")
                ErrorProviderModificarEventos.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
                txtBalcones.Focus()
                Exit Sub
            Else
                ErrorProviderModificarEventos.SetError(txtPlatea, "")
            End If
            If txtPlateaNumerada.TextLength = 0 Then
                ErrorProviderModificarEventos.SetError(txtPlateaNumerada, "Campo obligatorio")
                ErrorProviderModificarEventos.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
                txtPlateaNumerada.Focus()
                Exit Sub
            Else
                ErrorProviderModificarEventos.SetError(txtPlateaNumerada, "")
            End If
            If Integer.Parse(txtBalcones.Text) > Integer.Parse(lblMaxBalcones.Text) Then
                ErrorProviderModificarEventos.SetError(txtBalcones, "Hay sólo " & lblMaxBalcones.Text & " asientos disponibles")
                ErrorProviderModificarEventos.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
                txtBalcones.Focus()
                Exit Sub
            Else
                ErrorProviderModificarEventos.SetError(txtBalcones, "")
            End If
            If Integer.Parse(txtPlateaNumerada.Text) > Integer.Parse(lblMaxPlateaNumerada.Text) Then
                ErrorProviderModificarEventos.SetError(txtPlateaNumerada, "Hay sólo " & lblMaxPlateaNumerada.Text & " asientos disponibles")
                ErrorProviderModificarEventos.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
                txtPlateaNumerada.Focus()
                Exit Sub
            Else
                ErrorProviderModificarEventos.SetError(txtPlateaNumerada, "")
            End If

            If Integer.Parse(txtPlatea.Text) > Integer.Parse(lblMaxPlatea.Text) Then
                ErrorProviderModificarEventos.SetError(txtPlatea, "Hay sólo " & lblMaxPlatea.Text & " asientos disponibles")
                ErrorProviderModificarEventos.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
                txtPlatea.Focus()
                Exit Sub
            Else
                ErrorProviderModificarEventos.SetError(txtPlatea, "")
            End If
            If txtBalcones.TextLength = 0 Then
                ErrorProviderModificarEventos.SetError(txtBalcones, "Campo obligatorio")
                ErrorProviderModificarEventos.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
                Exit Sub
            Else
                ErrorProviderModificarEventos.SetError(txtBalcones, "")
            End If
            If txtPlatea.TextLength = 0 Then
                ErrorProviderModificarEventos.SetError(txtPlatea, "Campo obligatorio")
                ErrorProviderModificarEventos.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
                Exit Sub
            Else
                ErrorProviderModificarEventos.SetError(txtPlatea, "")
            End If
            If txtPlateaNumerada.TextLength = 0 Then
                ErrorProviderModificarEventos.SetError(txtPlateaNumerada, "Campo obligatorio")
                ErrorProviderModificarEventos.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
                Exit Sub
            Else
                ErrorProviderModificarEventos.SetError(txtPlateaNumerada, "")
            End If
            If chkMatine.Checked = False And chkTarde.Checked = False And chkNoche.Checked = False Then
                ErrorProviderModificarEventos.SetError(groJornadas, "Campo obligatorio")
                ErrorProviderModificarEventos.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
                Exit Sub
            Else
                ErrorProviderModificarEventos.SetError(groJornadas, "")
            End If
            If cmbJornadas.Text = "" Then
                ErrorProviderModificarEventos.SetError(cmbJornadas, "Campo obligatorio")
                ErrorProviderModificarEventos.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
                Exit Sub
            Else
                ErrorProviderModificarEventos.SetError(cmbJornadas, "")
            End If

            'strNombreEventoMod = ""
            'strFechaMod = ""
            'dgProduccion.Columns.Clear()
            'dgProduccion.Rows.Clear()
            If blnMatUbi = True Then
                Me.EventosubicacionesTableAdapter1.InsertEventosUbicaciones(intIDEventoMod, strFechaMod, Integer.Parse(txtBalcones.Text), Integer.Parse(txtPlatea.Text), _
                Integer.Parse(txtPlateaNumerada.Text), chkMatine.Text)
                MsgBox("Actualización de ubicaciones realizada satisfactoriamente", MsgBoxStyle.Information)
            ElseIf blnTarUbi = True Then
                Me.EventosubicacionesTableAdapter1.InsertEventosUbicaciones(intIDEventoMod, strFechaMod, Integer.Parse(txtBalcones.Text), Integer.Parse(txtPlatea.Text), _
                Integer.Parse(txtPlateaNumerada.Text), chkTarde.Text)
                MsgBox("Actualización de ubicaciones realizada satisfactoriamente", MsgBoxStyle.Information)
            ElseIf blnNocUbi = True Then
                Me.EventosubicacionesTableAdapter1.InsertEventosUbicaciones(intIDEventoMod, strFechaMod, Integer.Parse(txtBalcones.Text), Integer.Parse(txtPlatea.Text), _
                Integer.Parse(txtPlateaNumerada.Text), chkNoche.Text)
                MsgBox("Actualización de ubicaciones realizada satisfactoriamente", MsgBoxStyle.Information)
            Else
                Me.EventosubicacionesTableAdapter1.UpdateUbicaciones(intIDEventoMod, strFechaMod, Integer.Parse(txtBalcones.Text), Integer.Parse(txtPlatea.Text), Integer.Parse(txtPlateaNumerada.Text), cmbJornadas.Text)
                MsgBox("Actualización de ubicaciones realizada satisfactoriamente", MsgBoxStyle.Information)
                'LimpiarComboAndMore(cmbJornadas, cmbNombreEvento, lstboxFechas, lstboxFechasNuevas, dgProduccion)
                'LimpiarCamposModificarEvento(txtBalcones, txtPlatea, txtPlateaNumerada, cmbNombreEvento, txtNombreEncargado, cmbJornadas)
                'LimpiarComboAndMore(cmbJornadas, cmbNombreEvento, lstboxFechas, lstboxFechasNuevas, dgProduccion)
                'ResetearCheckbox(chkMatine, chkTarde, chkNoche)
                'cmbNombreEvento.Focus()
            End If
            btnActualizarUbicaciones.Enabled = False
            blnMatUbi = False
            blnTarUbi = False
            blnMatUbi = False
            Me.groJornadas.Enabled = True
            Me.tcFechas.Enabled = True
            cmbJornadas.Enabled = True
            cmbNombreEvento.Enabled = True
            Me.ErrorProviderModificarEventos.Clear()
            'LimpiarCamposRegistroEvento(txtBalcones, txtPlatea, txtPlateaNumerada)
        Catch ex As Exception
            MsgBox("Se produjo el siguiente error: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub



    Private Sub lblPlateaNumerada_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblPlateaNumerada.GotFocus
        Me.btnActualizarUbicaciones.Enabled = True
        Me.groJornadas.Enabled = False
        Me.tcFechas.Enabled = False
        cmbJornadas.Enabled = False
        cmbNombreEvento.Enabled = False
    End Sub

    '************************************************************************************************************************
    'Aquí ejecuto las operaciones para borrar una fecha. Verifico si una fecha esta programada para un evento solamente
    'Si es así borro toda la fila. Si no actualizo solo cada jornada
    'Trabajo con la función EliminaJornada la cual verifica el estado de las jornadas de la seleccionada
    Private Sub btnBorrarFechaActual_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrarFechaActual.Click
        Try
            If EliminaJornada(intIDEventoMod, strFechaMod) = 123 Then
                drResultado = MsgBox("Está seguro que desea borrar la fecha seleccionada", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Borrar fecha")
                If drResultado = vbYes Then
                    Me.EVENTOSTableAdapter.DeleteEventos(intIDEventoMod, strFechaMod)
                    Me.EventosjornadasTableAdapter1.DeleteJornada(strFechaMod)
                    Me.EventosubicacionesTableAdapter1.DeleteUbicacionTodo(intIDEventoMod, strFechaMod)
                    MsgBox("Fecha seleccionada borrada satisfactoriamente", MsgBoxStyle.Information)
                    ActualizarFechasEvento(lstboxFechas, intIDEventoMod, strNombreEventoMod, txtEntradaGeneral)
                    Me.btnBorrarFecha.Enabled = False
                    Exit Sub
                Else
                    Exit Sub
                End If
            ElseIf EliminaJornada(intIDEventoMod, strFechaMod) = 1 Then
                If EliminaJornada(intIDEventoMod, strFechaMod) = 123 Then
                    Resultado123()
                    Exit Sub
                End If
                drResultado = MsgBox("Está seguro que desea borrar la fecha seleccionada", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Borrar fecha")
                If drResultado = vbYes Then
                    Me.EVENTOSTableAdapter.DeleteEventos(intIDEventoMod, strFechaMod)
                    Me.EventosjornadasTableAdapter1.UpdateMatinéMod(0, strFechaMod)
                    Me.EventosubicacionesTableAdapter1.DeleteUbicacion(intIDEventoMod, strFechaMod, chkMatine.Text)
                    MsgBox("Fecha seleccionada borrada satisfactoriamente", MsgBoxStyle.Information)
                    ActualizarFechasEvento(lstboxFechas, intIDEventoMod, strNombreEventoMod, txtEntradaGeneral)
                    Me.btnBorrarFecha.Enabled = False
                    Exit Sub
                Else
                    Exit Sub
                End If
            ElseIf EliminaJornada(intIDEventoMod, strFechaMod) = 2 Then
                If EliminaJornada(intIDEventoMod, strFechaMod) = 123 Then
                    Resultado123()
                    Exit Sub
                End If
                drResultado = MsgBox("Está seguro que desea borrar la fecha seleccionada", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Borrar fecha")
                If drResultado = vbYes Then
                    Me.EVENTOSTableAdapter.DeleteEventos(intIDEventoMod, strFechaMod)
                    Me.EventosjornadasTableAdapter1.UpdateTardeMod(0, strFechaMod)
                    Me.EventosubicacionesTableAdapter1.DeleteUbicacion(intIDEventoMod, strFechaMod, chkTarde.Text)
                    MsgBox("Fecha seleccionada borrada satisfactoriamente", MsgBoxStyle.Information)
                    ActualizarFechasEvento(lstboxFechas, intIDEventoMod, strNombreEventoMod, txtEntradaGeneral)
                    Me.btnBorrarFecha.Enabled = False
                    Exit Sub
                Else
                    Exit Sub
                End If
            ElseIf EliminaJornada(intIDEventoMod, strFechaMod) = 3 Then
                If EliminaJornada(intIDEventoMod, strFechaMod) = 123 Then
                    Resultado123()
                    Exit Sub
                End If
                drResultado = MsgBox("Está seguro que desea borrar la fecha seleccionada", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Borrar fecha")
                If drResultado = vbYes Then
                    Me.EVENTOSTableAdapter.DeleteEventos(intIDEventoMod, strFechaMod)
                    Me.EventosjornadasTableAdapter1.UpdateNocheMod(0, strFechaMod)
                    Me.EventosubicacionesTableAdapter1.DeleteUbicacion(intIDEventoMod, strFechaMod, chkNoche.Text)
                    MsgBox("Fecha seleccionada borrada satisfactoriamente", MsgBoxStyle.Information)
                    ActualizarFechasEvento(lstboxFechas, intIDEventoMod, strNombreEventoMod, txtEntradaGeneral)
                    Me.btnBorrarFecha.Enabled = False
                    Exit Sub
                Else
                    Exit Sub
                End If
            ElseIf EliminaJornada(intIDEventoMod, strFechaMod) = 12 Then
                If EliminaJornada(intIDEventoMod, strFechaMod) = 123 Then
                    Resultado123()
                    Exit Sub
                End If
                drResultado = MsgBox("Está seguro que desea borrar la fecha seleccionada", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Borrar fecha")
                If drResultado = vbYes Then
                    Me.EVENTOSTableAdapter.DeleteEventos(intIDEventoMod, strFechaMod)
                    Me.EventosjornadasTableAdapter1.UpdateTardeMod(0, strFechaMod)
                    Me.EventosjornadasTableAdapter1.UpdateMatinéMod(0, strFechaMod)
                    Me.EventosubicacionesTableAdapter1.DeleteUbicacion(intIDEventoMod, strFechaMod, chkTarde.Text)
                    Me.EventosubicacionesTableAdapter1.DeleteUbicacion(intIDEventoMod, strFechaMod, chkMatine.Text)
                    MsgBox("Fecha seleccionada borrada satisfactoriamente", MsgBoxStyle.Information)
                    ActualizarFechasEvento(lstboxFechas, intIDEventoMod, strNombreEventoMod, txtEntradaGeneral)
                    Me.btnBorrarFecha.Enabled = False
                    Exit Sub
                Else
                    Exit Sub
                End If
            ElseIf EliminaJornada(intIDEventoMod, strFechaMod) = 13 Then
                If EliminaJornada(intIDEventoMod, strFechaMod) = 123 Then
                    Resultado123()
                    Exit Sub
                End If
                drResultado = MsgBox("Está seguro que desea borrar la fecha seleccionada", MsgBoxStyle.YesNo, "Borrar fecha")
                If drResultado = vbYes Then
                    Me.EVENTOSTableAdapter.DeleteEventos(intIDEventoMod, strFechaMod)
                    Me.EventosjornadasTableAdapter1.UpdateNocheMod(0, strFechaMod)
                    Me.EventosjornadasTableAdapter1.UpdateMatinéMod(0, strFechaMod)
                    Me.EventosubicacionesTableAdapter1.DeleteUbicacion(intIDEventoMod, strFechaMod, chkMatine.Text)
                    Me.EventosubicacionesTableAdapter1.DeleteUbicacion(intIDEventoMod, strFechaMod, chkNoche.Text)
                    MsgBox("Fecha seleccionada borrada satisfactoriamente", MsgBoxStyle.Information)
                    ActualizarFechasEvento(lstboxFechas, intIDEventoMod, strNombreEventoMod, txtEntradaGeneral)
                    Me.btnBorrarFecha.Enabled = False
                    Exit Sub
                Else
                    Exit Sub
                End If
            ElseIf EliminaJornada(intIDEventoMod, strFechaMod) = 23 Then
                If EliminaJornada(intIDEventoMod, strFechaMod) = 123 Then
                    Resultado123()
                    Exit Sub
                End If
                drResultado = MsgBox("Está seguro que desea borrar la fecha seleccionada", MsgBoxStyle.YesNo, "Borrar fecha")
                If drResultado = vbYes Then

                    Me.EVENTOSTableAdapter.DeleteEventos(intIDEventoMod, strFechaMod)
                    Me.EventosjornadasTableAdapter1.UpdateTardeMod(0, strFechaMod)
                    Me.EventosjornadasTableAdapter1.UpdateNocheMod(0, strFechaMod)
                    Me.EventosubicacionesTableAdapter1.DeleteUbicacion(intIDEventoMod, strFechaMod, chkTarde.Text)
                    Me.EventosubicacionesTableAdapter1.DeleteUbicacion(intIDEventoMod, strFechaMod, chkNoche.Text)
                    MsgBox("Fecha seleccionada borrada satisfactoriamente", MsgBoxStyle.Information)
                    ActualizarFechasEvento(lstboxFechas, intIDEventoMod, strNombreEventoMod, txtEntradaGeneral)
                    Me.btnBorrarFecha.Enabled = False
                    Exit Sub
                Else
                    Exit Sub
                End If
            ElseIf EliminaJornada(intIDEventoMod, strFechaMod) = 0 Then
                drResultado = MsgBox("Está seguro que desea borrar la fecha seleccionada", MsgBoxStyle.YesNo, "Borrar fecha")
                If drResultado = vbYes Then
                    Me.EVENTOSTableAdapter.DeleteEventos(intIDEventoMod, strFechaMod)
                    MsgBox("Fecha seleccionada borrada satisfactoriamente", MsgBoxStyle.Information)
                    ActualizarFechasEvento(lstboxFechas, intIDEventoMod, strNombreEventoMod, txtEntradaGeneral)
                    Me.btnBorrarFecha.Enabled = False
                    Exit Sub
                Else
                    Exit Sub
                End If
            End If
        Catch ex As Exception
            MsgBox("Se produjo el siguiente error: " & ex.Message, MsgBoxStyle.Critical, "Teatro")
        End Try
    End Sub
    'Hasta aquí llega el proceso de eliminar un fecha de un evento
    '************************************************************************************************************************


    '************************************************************************************************************************
    'Funciones y procedimientos

    Public Sub Resultado123()
        Try
            EVENTOSTableAdapter.DeleteEventos(intIDEventoMod, strFechaMod)
            EventosjornadasTableAdapter1.DeleteJornada(strFechaMod)
            EventosubicacionesTableAdapter1.DeleteUbicacionTodo(intIDEventoMod, strFechaMod)
            MsgBox("Fecha seleccionada borrada satisfactoriamente", MsgBoxStyle.Exclamation)
            ActualizarFechasEvento(lstboxFechas, intIDEventoMod, strNombreEventoMod, txtEntradaGeneral)
            ActualizarNombreEvento(cmbNombreEvento, txtEntradaGeneral)
            btnBorrarFecha.Enabled = False
        Catch ex As Exception
            MsgBox("Se produjo el siguiente error: " & ex.Message, MsgBoxStyle.Critical, "Teatro")
        End Try
    End Sub
    Public Sub LimpiarControles()
        Dim obj As Control
        'Este procedimiento me borra las cajas de texto
        For Each obj In Controls
            If TypeOf obj Is TextBox Then  'Cambiar esta linea para inicializar diferentes tipos de controles
                CType(obj, TextBox).Text = ""
            End If
        Next obj
    End Sub
End Class