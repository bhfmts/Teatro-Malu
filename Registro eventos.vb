''Imports System.Data
Imports System.Data.SqlClient
Imports Teatro.ClassConexion
Imports Teatro.ClassEvento

Public Class frmRegistroEvento
    'Declaración de variables
    Dim objUltimo As Object
    Dim intIDEvento As Integer = 1
    Dim blnConfirmar As DialogResult
    Dim strFecha As String
    Dim eventos As New ClassEvento
    Dim blnNuevoEvento As Boolean
    Dim blnSalto As Boolean = True
    Dim strNombreEvento As String
    Dim intPrimeraPasa As Boolean = True
    Dim vNombreEvento As Boolean
    Dim vEntradaGeneral As Boolean
    Dim intRegistroCorrecto As Integer
    Dim drResultado As DialogResult
    Dim dtFechaSeleccionada As Date

    Private Sub frmRegistroEventos_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        txtNombreEvento.Focus()
        'dtpFechaEvento.MinDate = Date.Now
        'dtpFechaEvento.Value = Date.Now
    End Sub

  

    Private Sub frmRegistroEvento_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim drResultado As DialogResult = MsgBox("Asegúrese de haber completado correctamente sus operaciones. ¿Está seguro que desea cerrar? ", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Registro eventos")
        If drResultado = vbNo Then
            e.Cancel = True
        Else
            Me.Dispose()
        End If
    End Sub

    Private Sub frmRegistroEvento_HelpRequested(ByVal sender As Object, ByVal hlpevent As System.Windows.Forms.HelpEventArgs) Handles Me.HelpRequested
        Try
            System.Diagnostics.Process.Start("\\BERNARDO\Manuales\Registrar eventos.avi")
        Catch ex As Exception
            MsgBox("Se ha producido el siguiente error: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    'Procesos que se ejecutan durante el evento Load
    Private Sub frmRegistroEventos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'TeatroDataSet.UBICACIONES' Puede moverla o quitarla según sea necesario.
        Try
            Me.UBICACIONESTableAdapter.Fill(Me.TeatroDataSet.UBICACIONES)
            'TODO: esta línea de código carga datos en la tabla 'TeatroDataSet.JORNADAS' Puede moverla o quitarla según sea necesario.
            TeatroDataSet.EnforceConstraints = False
            Me.PRODUCCIONTableAdapter.Fill(Me.TeatroDataSet.PRODUCCION)
            Me.EVENTOSTableAdapter.Fill(Me.TeatroDataSet.EVENTOS)
            'Inicializo los checkbox en false
            chkMatine.Checked = False
            chkTarde.Checked = False
            chkNoche.Checked = False
            blnNuevoEvento = True
            txtNombreEvento.Focus()
        Catch ex As Exception
            MsgBox("Se ha producido el siguiente error: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    'Procesos que se ejecutan durante el evento Click
    Private Sub btnRegistrarEvento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegistrarEvento.Click
        'Validación de los campos del formulario
        Try
            If txtNombreEvento.TextLength = 0 Then
                ErrorProviderEventos.SetError(txtNombreEvento, "Campo obligatorio")
                ErrorProviderEventos.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
                Exit Sub
            Else
                ErrorProviderEventos.SetError(txtNombreEvento, "")
            End If
            If txtEntradaGeneral.TextLength = 0 Then
                ErrorProviderEventos.SetError(txtEntradaGeneral, "Campo obligatorio")
                Exit Sub
            Else
                ErrorProviderEventos.SetError(txtEntradaGeneral, "")
            End If
            'Validación del precio de la entrada general
            If txtEntradaGeneral.Text > 200000 Then
                ErrorProviderEventos.SetError(txtEntradaGeneral, "El precio de entrada no puede ser mayor a 200.000 pesos")
                Exit Sub
            Else
                ErrorProviderEventos.SetError(txtEntradaGeneral, "")
            End If
            If lstboxFechas.GetItemText(lstboxFechas.SelectedItem) = "" Then
                ErrorProviderEventos.SetError(lstboxFechas, "Campo obligatorio")
                Exit Sub
            Else
                ErrorProviderEventos.SetError(lstboxFechas, "")
            End If
            If txtBalcones.TextLength = 0 Then
                ErrorProviderEventos.SetError(txtBalcones, "Campo obligatorio")
                Exit Sub
            Else
                ErrorProviderEventos.SetError(txtBalcones, "")
            End If
            If txtPlatea.TextLength = 0 Then
                ErrorProviderEventos.SetError(txtPlatea, "Campo obligatorio")
                Exit Sub
            Else
                ErrorProviderEventos.SetError(txtPlatea, "")
            End If
            If txtPlateaNumerada.TextLength = 0 Then
                ErrorProviderEventos.SetError(txtPlateaNumerada, "Campo obligatorio")
                Exit Sub
            Else
                ErrorProviderEventos.SetError(txtPlateaNumerada, "")
            End If
            If chkMatine.Checked = False And chkTarde.Checked = False And chkNoche.Checked = False Then
                ErrorProviderEventos.SetError(groJornadas, "Campo obligatorio")
                Exit Sub
            Else
                ErrorProviderEventos.SetError(groJornadas, "")
            End If
            If Integer.Parse(txtBalcones.Text) > Integer.Parse(lblMaxBalcones.Text) Then
                ErrorProviderEventos.SetError(txtBalcones, "Hay sólo " & lblMaxBalcones.Text & " asientos disponibles")
                ErrorProviderEventos.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
                txtBalcones.Focus()
                Exit Sub
            Else
                ErrorProviderEventos.SetError(txtBalcones, "")
            End If
            If Integer.Parse(txtPlateaNumerada.Text) > Integer.Parse(lblMaxPlateaNumerada.Text) Then
                ErrorProviderEventos.SetError(txtPlateaNumerada, "Hay sólo " & lblMaxPlateaNumerada.Text & " asientos disponibles")
                ErrorProviderEventos.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
                txtPlateaNumerada.Focus()
                Exit Sub
            Else
                ErrorProviderEventos.SetError(txtPlateaNumerada, "")
            End If

            If Integer.Parse(txtPlatea.Text) > Integer.Parse(lblMaxPlatea.Text) Then
                ErrorProviderEventos.SetError(txtPlatea, "Hay sólo " & lblMaxPlatea.Text & " asientos disponibles")
                ErrorProviderEventos.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
                txtPlatea.Focus()
                Exit Sub
            Else
                ErrorProviderEventos.SetError(txtPlatea, "")
            End If
            'Hasta aquí llega la validación
            Dim hola As Boolean = True


            Me.EVENTOSTableAdapter.Fill(Me.TeatroDataSet.EVENTOS)
            If chkMatine.Checked = False And chkTarde.Checked = False And chkNoche.Checked = False Then
                hola = False
            End If
            If vNombreEvento = True And vEntradaGeneral = True And hola = True Then
                eventos.strNombreEvento = txtNombreEvento.Text
                eventos.intEntradaGeneral = Integer.Parse(txtEntradaGeneral.Text)
                'Inserción datos evento
                If Me.TeatroDataSet.EVENTOS.Rows.Count = 0 Then
                    Me.PrimerRegistro()
                    Exit Sub
                End If
                Me.EVENTOSTableAdapter.Fill(Me.TeatroDataSet.EVENTOS)
                intUltimoRegisEven = Me.EVENTOSTableAdapter.SelectMaxIDEvento()
                strNombreEvento = Me.EVENTOSTableAdapter.SelectNombreEvento(intUltimoRegisEven)
                If txtNombreEvento.Text = strNombreEvento Then
                    If intPrimeraPasa = True Then
                        Me.RegistroEvenIgualNombre()
                        Exit Sub
                    End If
                End If
                Me.EVENTOSTableAdapter.Fill(Me.TeatroDataSet.EVENTOS)
                intUltimoRegisEven = Me.EVENTOSTableAdapter.SelectMaxIDEvento()
                strNombreEvento = Me.EVENTOSTableAdapter.SelectNombreEvento(intUltimoRegisEven)
                If strNombreEvento <> txtNombreEvento.Text Then
                    Me.RegistroEvenNombreDistinto()

                    Exit Sub
                End If

            Else
                MsgBox("Verificar datos", MsgBoxStyle.Critical)

            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    'Selecciono las fechas para cada evento
    Private Sub dtpFechaEvento_CloseUp(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpFechaEvento.CloseUp
        Try
            'Valido que la fecha seleccionada sea mayor que la actual
            dtFechaSeleccionada = (CDate(dtpFechaEvento.Text))

            If Date.Now.Date = dtFechaSeleccionada And Date.Now.Hour >= 22 Then
                MsgBox("Ya es tarde! No se pueden agregar más eventos para hoy (Son más de las 22:00 horas)", MsgBoxStyle.Critical)
                Exit Sub
            End If
            If dtFechaSeleccionada >= Date.Now.Date Then
                Dim b As Boolean = True
                For x As Integer = 0 To Me.lstboxFechas.Items.Count - 1
                    If dtpFechaEvento.Text = lstboxFechas.Items.Item(x) Then
                        MsgBox("La fecha seleccionada ya existe para este evento", MsgBoxStyle.Critical)
                        b = False
                        Exit For
                    End If
                Next
                If b = True Then
                    lstboxFechas.Items.Add(dtFechaSeleccionada)
                End If
            Else
                MsgBox("La fecha actual debe ser mayor a la actual", MsgBoxStyle.Information)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    'Operaciones que realizo una vez que el registro esté correcto
    Private Sub RegistroCorrecto()
        Try
            eventos.strRUNEncargado = strRUNEncargadoo
            MsgBox("Registro correcto", MsgBoxStyle.Information)
            'Aquí valido si todo esta programado para la fecha que se está ingresando
            'para borrarla del listbox.
            If Me.ValidarNombreYFecha() = 9 Then
                lstboxFechas.Items.Remove(lstboxFechas.SelectedItem)
            End If
            intRegistroCorrecto = intRegistroCorrecto + 1
            groJornadas.Enabled = False
            groUbicaciones.Enabled = False
            intPrimeraPasa = True
            'Limpieza de campos al terminar el registro
            LimpiarCamposRegistroEvento(txtBalcones, txtPlatea, txtPlateaNumerada)
            'Volver al estado "false" la propieda "checked
            chkMatine.Checked = False
            chkTarde.Checked = False
            chkNoche.Checked = False
            Me.btnRegistrarEvento.Enabled = False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try

    End Sub
    'Aquí verifico la disponibilidad de jornadas para las fechas seleccionadas
    Private Sub lstboxFechas_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstboxFechas.Click
        Me.EVENTOSTableAdapter.Fill(Me.TeatroDataSet.EVENTOS)
        Me.EventosjornadasTableAdapter1.Fill(Me.TeatroDataSet.EVENTOSJORNADAS)
        strFecha = Me.lstboxFechas.SelectedItem()
        If strFecha = "" Then
            MsgBox("Seleccione una fecha", MsgBoxStyle.Critical)

            Exit Sub
        End If
        If Me.ValidarNombreYFecha() = 9 Then
            MsgBox("Esta todo programado para esta fecha", MsgBoxStyle.Critical)
            lstboxFechas.Items.Remove(lstboxFechas.SelectedItem)
            intRegistroCorrecto = 0
            Exit Sub
        ElseIf Me.ValidarNombreYFecha() = 1 Then
            'MsgBox("La jornada matiné esta disponible para la fecha seleccionada", MsgBoxStyle.Information)
            groJornadas.Enabled = True
            'groUbicaciones.Enabled = True
            chkMatine.Enabled = True
            chkTarde.Enabled = False
            chkNoche.Enabled = False
            Exit Sub
        ElseIf Me.ValidarNombreYFecha() = 2 Then
            'MsgBox("La jornada tarde esta disponible para la fecha seleccionada", MsgBoxStyle.Information)
            groJornadas.Enabled = True
            'groUbicaciones.Enabled = True
            chkMatine.Enabled = False
            chkTarde.Enabled = True
            chkNoche.Enabled = False
            Exit Sub
        ElseIf Me.ValidarNombreYFecha() = 3 Then
            'MsgBox("La jornada noche esta disponible para la fecha seleccionada", MsgBoxStyle.Information)
            groJornadas.Enabled = True
            'groUbicaciones.Enabled = True
            chkMatine.Enabled = False
            chkTarde.Enabled = False
            chkNoche.Enabled = True
            Exit Sub
        ElseIf Me.ValidarNombreYFecha() = 12 Then
            'MsgBox("La jornada matiné y tarde están disponibles para la fecha seleccionada", MsgBoxStyle.Information)
            groJornadas.Enabled = True
            'groUbicaciones.Enabled = True
            chkMatine.Enabled = True
            chkTarde.Enabled = True
            chkNoche.Enabled = False
            Exit Sub
        ElseIf Me.ValidarNombreYFecha() = 13 Then
            'MsgBox("La jornada matiné y noche están disponibles para la fecha seleccionada", MsgBoxStyle.Information)
            groJornadas.Enabled = True
            'groUbicaciones.Enabled = True
            chkMatine.Enabled = True
            chkTarde.Enabled = False
            chkNoche.Enabled = True
        ElseIf Me.ValidarNombreYFecha() = 23 Then
            'MsgBox("La jornada tarde y noche están disponibles para la fecha seleccionada", MsgBoxStyle.Information)
            groJornadas.Enabled = True
            'groUbicaciones.Enabled = True
            chkMatine.Enabled = False
            chkTarde.Enabled = True
            chkNoche.Enabled = True
            Exit Sub
        ElseIf Me.ValidarNombreYFecha() = 0 Then
            groJornadas.Enabled = True
            'groUbicaciones.Enabled = True
            chkMatine.Enabled = True
            chkTarde.Enabled = True
            chkNoche.Enabled = True
            Exit Sub
        End If
    End Sub
    'Validación campo nombres en el evento "KeyPress"
    Private Sub txtNombreevento_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNombreEvento.KeyPress
        txtNombreEvento.Text.ToUpper()
        SoloTexto(e)
    End Sub
    'VALIDACION CAMPO ENTRADAGENERAL PARA SOLO INGRESAR NUMEROS
    Private Sub txtentradageneral_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtEntradaGeneral.KeyPress, txtEntradaGeneral.KeyPress
        If (Asc(e.KeyChar)) >= 48 And (Asc(e.KeyChar)) <= 57 Or (Asc(e.KeyChar)) = System.Windows.Forms.Keys.Back Or Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    'VALIDACION CAMPO CAPACIDAD PARA SOLO INGRESAR NUMEROS
    Private Sub txtCAPACIDAD_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If (Asc(e.KeyChar)) >= 48 And (Asc(e.KeyChar)) <= 57 Or (Asc(e.KeyChar)) = System.Windows.Forms.Keys.Back Or Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtBalcones_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBalcones.GotFocus
        Me.btnRegistrarEvento.Enabled = True
    End Sub
    'VALIDACION CAMPO BALCONES PARA SOLO INGRESAR NUMEROS
    Private Sub txtBalcones_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBalcones.KeyPress
        If (Asc(e.KeyChar)) >= 48 And (Asc(e.KeyChar)) <= 57 Or (Asc(e.KeyChar)) = System.Windows.Forms.Keys.Back Or Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    'VALIDACION CAMPO PLATEA PARA SOLO INGRESAR NUMEROS.
    Private Sub txtPlatea_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPlatea.KeyPress
        If (Asc(e.KeyChar)) >= 48 And (Asc(e.KeyChar)) <= 57 Or (Asc(e.KeyChar)) = System.Windows.Forms.Keys.Back Or Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    'VALIDACION CAMPO PLATEANUMERADA PARA SOLO INGRESAR NUMEROS.
    Private Sub txtPlateaNumerada_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPlateaNumerada.KeyPress
        If (Asc(e.KeyChar)) >= 48 And (Asc(e.KeyChar)) <= 57 Or (Asc(e.KeyChar)) = System.Windows.Forms.Keys.Back Or Char.IsDigit(e.KeyChar) Then

            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    'Operaciones que realizo cuando se quiere agregar un nuevo evento.
    Private Sub btnNuevoEvento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevoEvento.Click
        blnNuevoEvento = True
        txtNombreEvento.Clear()
        lstboxFechas.Items.Clear()
        txtEntradaGeneral.Clear()
        LimpiarCamposRegistroEvento(txtBalcones, txtPlatea, txtPlateaNumerada)
    End Sub
    'Aquí borro del listbox la fecha seleccionada
    Private Sub btnBorrarFecha_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrarFecha.Click
        lstboxFechas.Items.Remove(lstboxFechas.SelectedItem)
        If lstboxFechas.Items.Count() = 0 Then
            groJornadas.Enabled = False
        End If
        groUbicaciones.Enabled = False
    End Sub
    Private Sub PrimerRegistro()
        Try

        
            intPrimeraPasa = False
            blnNuevoEvento = False
            intIDEvento = 1
            Me.EVENTOSTableAdapter.InsertarEventos(intIDEvento, (txtNombreEvento.Text), strFecha, txtEntradaGeneral.Text, strRUNEncargadoo)
            'Acá verifico las opciones que están seleccionadas y a partir de eso registro la información en la base datos.
            If chkMatine.Checked = True And chkTarde.Checked = True And chkNoche.Checked = True And Me.TeatroDataSet.EVENTOS.Rows.Count = 0 Then
                Me.EventosjornadasTableAdapter1.InsertJornadas(intIDEvento, strFecha, intIDEvento, intIDEvento, intIDEvento)
                If chkMatine.Checked = True Then
                    Me.EVENTOSUBICACIONESTableAdapter.InsertEventosUbicaciones(intIDEvento, strFecha, Integer.Parse(txtBalcones.Text), Integer.Parse(txtPlatea.Text), Integer.Parse(txtPlateaNumerada.Text), "Matiné")
                End If
                If chkTarde.Checked = True Then
                    Me.EVENTOSUBICACIONESTableAdapter.InsertEventosUbicaciones(intIDEvento, strFecha, Integer.Parse(txtBalcones.Text), Integer.Parse(txtPlatea.Text), Integer.Parse(txtPlateaNumerada.Text), "Tarde")
                End If
                If chkNoche.Checked = False Then
                    Me.EVENTOSUBICACIONESTableAdapter.InsertEventosUbicaciones(intIDEvento, strFecha, Integer.Parse(txtBalcones.Text), Integer.Parse(txtPlatea.Text), Integer.Parse(txtPlateaNumerada.Text), "Noche")
                End If
                Me.RegistroCorrecto()
                Exit Sub
            ElseIf chkMatine.Checked = True And chkTarde.Checked = False And chkNoche.Checked = False And Me.TeatroDataSet.EVENTOS.Rows.Count = 0 Then
                Me.EventosjornadasTableAdapter1.InsertJornadas(intIDEvento, strFecha, intIDEvento, 0, 0)
                Me.EVENTOSUBICACIONESTableAdapter.InsertEventosUbicaciones(intIDEvento, strFecha, Integer.Parse(txtBalcones.Text), Integer.Parse(txtPlatea.Text), Integer.Parse(txtPlateaNumerada.Text), "Matiné")
                Me.RegistroCorrecto()
                Exit Sub

            ElseIf chkTarde.Checked = True And chkMatine.Checked = False And chkNoche.Checked = False And Me.TeatroDataSet.EVENTOS.Rows.Count = 0 Then
                Me.EventosjornadasTableAdapter1.InsertJornadas(intIDEvento, strFecha, 0, intIDEvento, 0)
                Me.EVENTOSUBICACIONESTableAdapter.InsertEventosUbicaciones(intIDEvento, strFecha, Integer.Parse(txtBalcones.Text), Integer.Parse(txtPlatea.Text), Integer.Parse(txtPlateaNumerada.Text), "Tarde")
                Me.RegistroCorrecto()
                Exit Sub

            ElseIf chkNoche.Checked = True And chkMatine.Checked = False And chkTarde.Checked = False And Me.TeatroDataSet.EVENTOS.Rows.Count = 0 Then
                Me.EventosjornadasTableAdapter1.InsertJornadas(intIDEvento, strFecha, 0, 0, intIDEvento)
                Me.EVENTOSUBICACIONESTableAdapter.InsertEventosUbicaciones(intIDEvento, strFecha, Integer.Parse(txtBalcones.Text), Integer.Parse(txtPlatea.Text), Integer.Parse(txtPlateaNumerada.Text), "Noche")
                Me.RegistroCorrecto()
                Exit Sub
            ElseIf chkMatine.Checked = True And chkTarde.Checked = True And chkNoche.Checked = False And Me.TeatroDataSet.EVENTOS.Rows.Count = 0 Then
                Me.EventosjornadasTableAdapter1.InsertJornadas(intIDEvento, strFecha, intIDEvento, intIDEvento, 0)
                If chkMatine.Checked = True Then
                    Me.EVENTOSUBICACIONESTableAdapter.InsertEventosUbicaciones(intIDEvento, strFecha, Integer.Parse(txtBalcones.Text), Integer.Parse(txtPlatea.Text), Integer.Parse(txtPlateaNumerada.Text), "Matiné")
                End If
                If chkTarde.Checked = True Then
                    Me.EVENTOSUBICACIONESTableAdapter.InsertEventosUbicaciones(intIDEvento, strFecha, Integer.Parse(txtBalcones.Text), Integer.Parse(txtPlatea.Text), Integer.Parse(txtPlateaNumerada.Text), "Tarde")
                End If
                Me.RegistroCorrecto()
                Exit Sub
            ElseIf chkMatine.Checked = True And chkNoche.Checked = True And chkTarde.Checked = False And Me.TeatroDataSet.EVENTOS.Rows.Count = 0 Then
                Me.EventosjornadasTableAdapter1.InsertJornadas(intIDEvento, strFecha, intIDEvento, 0, intIDEvento)
                If chkMatine.Checked = True Then
                    Me.EVENTOSUBICACIONESTableAdapter.InsertEventosUbicaciones(intIDEvento, strFecha, Integer.Parse(txtBalcones.Text), Integer.Parse(txtPlatea.Text), Integer.Parse(txtPlateaNumerada.Text), "Matiné")
                End If
                If chkNoche.Checked = True Then
                    Me.EVENTOSUBICACIONESTableAdapter.InsertEventosUbicaciones(intIDEvento, strFecha, Integer.Parse(txtBalcones.Text), Integer.Parse(txtPlatea.Text), Integer.Parse(txtPlateaNumerada.Text), "Noche")
                End If
                Me.RegistroCorrecto()
                Exit Sub
            ElseIf chkTarde.Checked = True And chkNoche.Checked = True And chkMatine.Checked = False And Me.TeatroDataSet.EVENTOS.Rows.Count = 0 Then
                Me.EventosjornadasTableAdapter1.InsertJornadas(intIDEvento, strFecha, 0, intIDEvento, intIDEvento)
                If chkMatine.Checked = True Then
                    Me.EVENTOSUBICACIONESTableAdapter.InsertEventosUbicaciones(intIDEvento, strFecha, Integer.Parse(txtBalcones.Text), Integer.Parse(txtPlatea.Text), Integer.Parse(txtPlateaNumerada.Text), "Tarde")
                End If
                If chkNoche.Checked = True Then
                    Me.EVENTOSUBICACIONESTableAdapter.InsertEventosUbicaciones(intIDEvento, strFecha, Integer.Parse(txtBalcones.Text), Integer.Parse(txtPlatea.Text), Integer.Parse(txtPlateaNumerada.Text), "Noche")
                End If
                Me.RegistroCorrecto()
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox("Se produjo el siguiente error: " & ex.Message, MsgBoxStyle.Critical, "Teatro")
        End Try
    End Sub

    'Aquí ingreso la información del evento cuando la IDEVENTO es igual a la IDEVENTO del ultimo registro en l DB,
    'entonces se registra la misma IDEVENTO 
    'Registro de los datos de un evento cuando es el mismo evento
    Private Sub RegistroEvenIgualNombre()
        'Primero verifico si es una actualización o no, si no genero un nuevo registro
        Try

       
            If Me.ValidarNombreYFecha() = 1 Or Me.ValidarNombreYFecha() = 12 Or Me.ValidarNombreYFecha() = 13 Or Me.ValidarNombreYFecha() = 2 Or Me.ValidarNombreYFecha() = 23 Or Me.ValidarNombreYFecha() = 3 Then
                Me.EVENTOSTableAdapter.Fill(Me.TeatroDataSet.EVENTOS)
                If Me.EVENTOSTableAdapter.SelectNombreEvento(Me.EVENTOSTableAdapter.SelectMaxIDEvento()) <> txtNombreEvento.Text Then
                    Me.EVENTOSTableAdapter.InsertarEventos(intUltimoRegisEven, txtNombreEvento.Text, strFecha, txtEntradaGeneral.Text, strRUNEncargadoo)
                ElseIf chkMatine.Checked = True Then
                    Me.EventosjornadasTableAdapter1.UpdateMatiné(intUltimoRegisEven, strFechaTemporal, intIDEventoTemporal)
                    Me.EVENTOSUBICACIONESTableAdapter.InsertEventosUbicaciones(intUltimoRegisEven, strFecha, Integer.Parse(txtBalcones.Text), Integer.Parse(txtPlatea.Text), Integer.Parse(txtPlateaNumerada.Text), "Matiné")
                    Me.RegistroCorrecto()
                    Exit Sub
                ElseIf chkTarde.Checked = True Then
                    Me.EventosjornadasTableAdapter1.UpdateTarde(intUltimoRegisEven, strFechaTemporal, intIDEventoTemporal)
                    Me.EVENTOSUBICACIONESTableAdapter.InsertEventosUbicaciones(intUltimoRegisEven, strFecha, Integer.Parse(txtBalcones.Text), Integer.Parse(txtPlatea.Text), Integer.Parse(txtPlateaNumerada.Text), "Tarde")
                    Me.RegistroCorrecto()
                    Exit Sub
                ElseIf chkNoche.Checked = True Then
                    Me.EventosjornadasTableAdapter1.UpdateNoche(intUltimoRegisEven, strFechaTemporal, intIDEventoTemporal)
                    Me.EVENTOSUBICACIONESTableAdapter.InsertEventosUbicaciones(intUltimoRegisEven, strFecha, Integer.Parse(txtBalcones.Text), Integer.Parse(txtPlatea.Text), Integer.Parse(txtPlateaNumerada.Text), "Noche")
                    Me.RegistroCorrecto()
                    Exit Sub
                End If
            End If
            intUltimoRegisEven = Me.EVENTOSTableAdapter.SelectMaxIDEvento()
            strNombreEvento = Me.EVENTOSTableAdapter.SelectNombreEvento(intUltimoRegisEven)
            intUltimoRegisEven = Me.EVENTOSTableAdapter.SelectMaxIDEvento()
            'Acá genero los nuevos registros
            Me.EVENTOSTableAdapter.InsertarEventos(intUltimoRegisEven, txtNombreEvento.Text, strFecha, txtEntradaGeneral.Text, strRUNEncargadoo)
            If chkMatine.Checked = True And chkTarde.Checked = True And chkNoche.Checked = True And txtNombreEvento.Text = strNombreEvento Then
                Me.EventosjornadasTableAdapter1.InsertJornadas(intUltimoRegisEven, strFecha, intUltimoRegisEven, intUltimoRegisEven, intUltimoRegisEven)
                If chkMatine.Checked = True Then
                    Me.EVENTOSUBICACIONESTableAdapter.InsertEventosUbicaciones(intUltimoRegisEven, strFecha, Integer.Parse(txtBalcones.Text), Integer.Parse(txtPlatea.Text), Integer.Parse(txtPlateaNumerada.Text), "Matiné")
                End If
                If chkTarde.Checked = True Then
                    Me.EVENTOSUBICACIONESTableAdapter.InsertEventosUbicaciones(intUltimoRegisEven, strFecha, Integer.Parse(txtBalcones.Text), Integer.Parse(txtPlatea.Text), Integer.Parse(txtPlateaNumerada.Text), "Tarde")
                End If
                If chkNoche.Checked = False Then
                    Me.EVENTOSUBICACIONESTableAdapter.InsertEventosUbicaciones(intUltimoRegisEven, strFecha, Integer.Parse(txtBalcones.Text), Integer.Parse(txtPlatea.Text), Integer.Parse(txtPlateaNumerada.Text), "Noche")
                End If
                Me.RegistroCorrecto()
                Exit Sub
            End If
            If chkMatine.Checked = True And chkTarde.Checked = False And chkNoche.Checked = False And txtNombreEvento.Text = strNombreEvento Then
                Me.EventosjornadasTableAdapter1.InsertJornadas(intUltimoRegisEven, strFecha, intUltimoRegisEven, 0, 0)
                Me.EVENTOSUBICACIONESTableAdapter.InsertEventosUbicaciones(intUltimoRegisEven, strFecha, Integer.Parse(txtBalcones.Text), Integer.Parse(txtPlatea.Text), Integer.Parse(txtPlateaNumerada.Text), "Matiné")
                Me.RegistroCorrecto()
                Exit Sub
            End If
            If chkTarde.Checked = True And chkMatine.Checked = False And chkNoche.Checked = False And txtNombreEvento.Text = strNombreEvento Then
                Me.EventosjornadasTableAdapter1.InsertJornadas(intUltimoRegisEven, strFecha, 0, intUltimoRegisEven, 0)
                Me.EVENTOSUBICACIONESTableAdapter.InsertEventosUbicaciones(intUltimoRegisEven, strFecha, Integer.Parse(txtBalcones.Text), Integer.Parse(txtPlatea.Text), Integer.Parse(txtPlateaNumerada.Text), "Tarde")
                Me.RegistroCorrecto()
                Exit Sub
            End If
            If chkNoche.Checked = True And chkMatine.Checked = False And chkTarde.Checked = False And txtNombreEvento.Text = strNombreEvento Then
                Me.EventosjornadasTableAdapter1.InsertJornadas(intUltimoRegisEven, strFecha, 0, 0, intUltimoRegisEven)
                Me.EVENTOSUBICACIONESTableAdapter.InsertEventosUbicaciones(intUltimoRegisEven, strFecha, Integer.Parse(txtBalcones.Text), Integer.Parse(txtPlatea.Text), Integer.Parse(txtPlateaNumerada.Text), "Noche")
                Me.RegistroCorrecto()
                Exit Sub
            End If
            If chkMatine.Checked = True And chkTarde.Checked = True And chkNoche.Checked = False And txtNombreEvento.Text = strNombreEvento Then
                Me.EventosjornadasTableAdapter1.InsertJornadas(intUltimoRegisEven, strFecha, intUltimoRegisEven, intUltimoRegisEven, 0)
                If chkMatine.Checked = True Then
                    Me.EVENTOSUBICACIONESTableAdapter.InsertEventosUbicaciones(intUltimoRegisEven, strFecha, Integer.Parse(txtBalcones.Text), Integer.Parse(txtPlatea.Text), Integer.Parse(txtPlateaNumerada.Text), "Matiné")
                End If
                If chkTarde.Checked = True Then
                    Me.EVENTOSUBICACIONESTableAdapter.InsertEventosUbicaciones(intUltimoRegisEven, strFecha, Integer.Parse(txtBalcones.Text), Integer.Parse(txtPlatea.Text), Integer.Parse(txtPlateaNumerada.Text), "Tarde")
                End If
                Me.RegistroCorrecto()
                Exit Sub
            End If
            If chkMatine.Checked = True And chkNoche.Checked = True And chkTarde.Checked = False And txtNombreEvento.Text = strNombreEvento Then
                Me.EventosjornadasTableAdapter1.InsertJornadas(intUltimoRegisEven, strFecha, intUltimoRegisEven, 0, intUltimoRegisEven)
                If chkMatine.Checked = True Then
                    Me.EVENTOSUBICACIONESTableAdapter.InsertEventosUbicaciones(intUltimoRegisEven, strFecha, Integer.Parse(txtBalcones.Text), Integer.Parse(txtPlatea.Text), Integer.Parse(txtPlateaNumerada.Text), "Matiné")
                End If
                If chkNoche.Checked = True Then
                    Me.EVENTOSUBICACIONESTableAdapter.InsertEventosUbicaciones(intUltimoRegisEven, strFecha, Integer.Parse(txtBalcones.Text), Integer.Parse(txtPlatea.Text), Integer.Parse(txtPlateaNumerada.Text), "Noche")
                End If
                Me.RegistroCorrecto()
                Exit Sub
            End If
            If chkTarde.Checked = True And chkNoche.Checked = True And chkMatine.Checked = False And txtNombreEvento.Text = strNombreEvento Then
                Me.EventosjornadasTableAdapter1.InsertJornadas(intUltimoRegisEven, strFecha, 0, intUltimoRegisEven, intUltimoRegisEven)
                If chkTarde.Checked = True Then
                    Me.EVENTOSUBICACIONESTableAdapter.InsertEventosUbicaciones(intUltimoRegisEven, strFecha, Integer.Parse(txtBalcones.Text), Integer.Parse(txtPlatea.Text), Integer.Parse(txtPlateaNumerada.Text), "Tarde")
                End If
                If chkNoche.Checked = True Then
                    Me.EVENTOSUBICACIONESTableAdapter.InsertEventosUbicaciones(intUltimoRegisEven, strFecha, Integer.Parse(txtBalcones.Text), Integer.Parse(txtPlatea.Text), Integer.Parse(txtPlateaNumerada.Text), "Noche")
                End If
                Me.RegistroCorrecto()
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox("Se produjo el siguiente error: " & ex.Message, MsgBoxStyle.Critical, "Teatro")
        End Try
    End Sub
    'Acá registro la información de un evento nuevo
    'Aquí registro la información del evento cuando el NOMBREEVENTO de la base datos es distinto al NOMBREEVENTO que ese está ingresando,
    'por lo tanto se considera que es un nuevo evento y entonces la IDEVENTO se incrementa en 1
    Private Sub RegistroEvenNombreDistinto()
        'Primero verifico si es una actualización o no
        Try

            If Me.ValidarNombreYFecha() = 1 Or Me.ValidarNombreYFecha() = 12 Or Me.ValidarNombreYFecha() = 13 Or Me.ValidarNombreYFecha() = 2 Or Me.ValidarNombreYFecha() = 23 Or Me.ValidarNombreYFecha() = 3 Then
                Me.EVENTOSTableAdapter.Fill(Me.TeatroDataSet.EVENTOS)
                intUltimoRegisEven = Me.EVENTOSTableAdapter.SelectMaxIDEvento()
                Me.EVENTOSTableAdapter.InsertarEventos(intUltimoRegisEven + 1, txtNombreEvento.Text, strFecha, txtEntradaGeneral.Text, strRUNEncargadoo)
                If chkMatine.Checked = True Then
                    Me.EventosjornadasTableAdapter1.UpdateMatiné(intUltimoRegisEven + 1, strFechaTemporal, intIDEventoTemporal)
                    Me.EVENTOSUBICACIONESTableAdapter.InsertEventosUbicaciones(intUltimoRegisEven + 1, strFecha, Integer.Parse(txtBalcones.Text), Integer.Parse(txtPlatea.Text), Integer.Parse(txtPlateaNumerada.Text), "Matiné")
                    Me.RegistroCorrecto()
                    Exit Sub
                ElseIf chkTarde.Checked = True Then
                    Me.EventosjornadasTableAdapter1.UpdateTarde(intUltimoRegisEven + 1, strFechaTemporal, intIDEventoTemporal)
                    Me.EVENTOSUBICACIONESTableAdapter.InsertEventosUbicaciones(intUltimoRegisEven + 1, strFecha, Integer.Parse(txtBalcones.Text), Integer.Parse(txtPlatea.Text), Integer.Parse(txtPlateaNumerada.Text), "Tarde")
                    Me.RegistroCorrecto()
                    Exit Sub
                ElseIf chkNoche.Checked = True Then
                    Me.EventosjornadasTableAdapter1.UpdateNoche(intUltimoRegisEven + 1, strFechaTemporal, intIDEventoTemporal)
                    Me.EVENTOSUBICACIONESTableAdapter.InsertEventosUbicaciones(intUltimoRegisEven + 1, strFecha, Integer.Parse(txtBalcones.Text), Integer.Parse(txtPlatea.Text), Integer.Parse(txtPlateaNumerada.Text), "Noche")
                    Me.RegistroCorrecto()
                    Exit Sub
                End If
            End If
            'Acá genero un nuevo registro y no una actualización
            Me.EVENTOSTableAdapter.InsertarEventos(intUltimoRegisEven + 1, txtNombreEvento.Text, strFecha, txtEntradaGeneral.Text, strRUNEncargadoo)
            If chkMatine.Checked = True And chkTarde.Checked = True And chkNoche.Checked = True And strNombreEvento <> txtNombreEvento.Text Then
                Me.EventosjornadasTableAdapter1.InsertJornadas(intUltimoRegisEven + 1, strFecha, intUltimoRegisEven + 1, intUltimoRegisEven + 1, intUltimoRegisEven + 1)
                If chkMatine.Checked = True Then
                    Me.EVENTOSUBICACIONESTableAdapter.InsertEventosUbicaciones(intUltimoRegisEven + 1, strFecha, Integer.Parse(txtBalcones.Text), Integer.Parse(txtPlatea.Text), Integer.Parse(txtPlateaNumerada.Text), "Matiné")
                End If
                If chkTarde.Checked = True Then
                    Me.EVENTOSUBICACIONESTableAdapter.InsertEventosUbicaciones(intUltimoRegisEven + 1, strFecha, Integer.Parse(txtBalcones.Text), Integer.Parse(txtPlatea.Text), Integer.Parse(txtPlateaNumerada.Text), "Tarde")
                End If
                If chkNoche.Checked = False Then
                    Me.EVENTOSUBICACIONESTableAdapter.InsertEventosUbicaciones(intUltimoRegisEven + 1, strFecha, Integer.Parse(txtBalcones.Text), Integer.Parse(txtPlatea.Text), Integer.Parse(txtPlateaNumerada.Text), "Noche")
                End If
                Me.RegistroCorrecto()
                Exit Sub
            End If
            If chkTarde.Checked = True And chkMatine.Checked = False And chkNoche.Checked = False And strNombreEvento <> txtNombreEvento.Text Then
                Me.EventosjornadasTableAdapter1.InsertJornadas(intUltimoRegisEven + 1, strFecha, 0, intUltimoRegisEven + 1, 0)
                Me.EVENTOSUBICACIONESTableAdapter.InsertEventosUbicaciones(intUltimoRegisEven + 1, strFecha, Integer.Parse(txtBalcones.Text), Integer.Parse(txtPlatea.Text), Integer.Parse(txtPlateaNumerada.Text), "Tarde")
                Me.RegistroCorrecto()
                Exit Sub
            ElseIf chkNoche.Checked = True And chkMatine.Checked = False And chkTarde.Checked = False And strNombreEvento <> txtNombreEvento.Text Then
                Me.EventosjornadasTableAdapter1.InsertJornadas(intUltimoRegisEven + 1, strFecha, 0, 0, intUltimoRegisEven + 1)
                Me.EVENTOSUBICACIONESTableAdapter.InsertEventosUbicaciones(intUltimoRegisEven + 1, strFecha, Integer.Parse(txtBalcones.Text), Integer.Parse(txtPlatea.Text), Integer.Parse(txtPlateaNumerada.Text), "Noche")
                Me.RegistroCorrecto()
                Exit Sub
            ElseIf chkMatine.Checked = True And chkTarde.Checked = False And chkNoche.Checked = False And strNombreEvento <> txtNombreEvento.Text Then
                Me.EventosjornadasTableAdapter1.InsertJornadas(intUltimoRegisEven + 1, strFecha, intUltimoRegisEven + 1, 0, 0)
                Me.EVENTOSUBICACIONESTableAdapter.InsertEventosUbicaciones(intUltimoRegisEven + 1, strFecha, Integer.Parse(txtBalcones.Text), Integer.Parse(txtPlatea.Text), Integer.Parse(txtPlateaNumerada.Text), "Matiné")
                Me.RegistroCorrecto()
                Exit Sub
            ElseIf chkMatine.Checked = True And chkTarde.Checked = True And chkNoche.Checked = False And strNombreEvento <> txtNombreEvento.Text Then
                Me.EventosjornadasTableAdapter1.InsertJornadas(intUltimoRegisEven + 1, strFecha, intUltimoRegisEven + 1, intUltimoRegisEven + 1, 0)
                If chkMatine.Checked = True Then
                    Me.EVENTOSUBICACIONESTableAdapter.InsertEventosUbicaciones(intUltimoRegisEven + 1, strFecha, Integer.Parse(txtBalcones.Text), Integer.Parse(txtPlatea.Text), Integer.Parse(txtPlateaNumerada.Text), "Matiné")
                End If
                If chkTarde.Checked = True Then
                    Me.EVENTOSUBICACIONESTableAdapter.InsertEventosUbicaciones(intUltimoRegisEven + 1, strFecha, Integer.Parse(txtBalcones.Text), Integer.Parse(txtPlatea.Text), Integer.Parse(txtPlateaNumerada.Text), "Tarde")
                End If
                Me.RegistroCorrecto()
                Exit Sub
            ElseIf chkMatine.Checked = True And chkNoche.Checked = True And chkTarde.Checked = False And strNombreEvento <> txtNombreEvento.Text Then
                Me.EventosjornadasTableAdapter1.InsertJornadas(intUltimoRegisEven + 1, strFecha, intUltimoRegisEven + 1, 0, intUltimoRegisEven + 1)
                If chkMatine.Checked = True Then
                    Me.EVENTOSUBICACIONESTableAdapter.InsertEventosUbicaciones(intUltimoRegisEven + 1, strFecha, Integer.Parse(txtBalcones.Text), Integer.Parse(txtPlatea.Text), Integer.Parse(txtPlateaNumerada.Text), "Matiné")
                End If
                If chkNoche.Checked = True Then
                    Me.EVENTOSUBICACIONESTableAdapter.InsertEventosUbicaciones(intUltimoRegisEven + 1, strFecha, Integer.Parse(txtBalcones.Text), Integer.Parse(txtPlatea.Text), Integer.Parse(txtPlateaNumerada.Text), "Noche")
                End If
                Me.RegistroCorrecto()
                Exit Sub
            ElseIf chkTarde.Checked = True And chkNoche.Checked = True And chkMatine.Checked = False And strNombreEvento <> txtNombreEvento.Text Then
                Me.EventosjornadasTableAdapter1.InsertJornadas(intUltimoRegisEven + 1, strFecha, 0, intUltimoRegisEven + 1, intUltimoRegisEven + 1)
                If chkNoche.Checked = True Then
                    Me.EVENTOSUBICACIONESTableAdapter.InsertEventosUbicaciones(intUltimoRegisEven + 1, strFecha, Integer.Parse(txtBalcones.Text), Integer.Parse(txtPlatea.Text), Integer.Parse(txtPlateaNumerada.Text), "Noche")
                End If
                If chkTarde.Checked = True Then
                    Me.EVENTOSUBICACIONESTableAdapter.InsertEventosUbicaciones(intUltimoRegisEven + 1, strFecha, Integer.Parse(txtBalcones.Text), Integer.Parse(txtPlatea.Text), Integer.Parse(txtPlateaNumerada.Text), "Tarde")
                End If
                Me.RegistroCorrecto()
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox("Se produjo el siguiente error: " & ex.Message, MsgBoxStyle.Critical, "Teatro")
        End Try
    End Sub
    Private Sub txtNombreEvento_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtNombreEvento.Validating
        ''VALIDACION DEL CAMPO NOMBREEVENTO
        If txtNombreEvento.TextLength = 0 Then
            ErrorProviderEventos.Clear()
            ErrorProviderEventos.SetError(txtNombreEvento, "Campo obligatorio")
            ErrorProviderEventos.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
            txtNombreEvento.Focus()
            vNombreEvento = False
            Exit Sub
        Else
            ErrorProviderEventos.SetError(txtNombreEvento, "")
            vNombreEvento = True
        End If
    End Sub

    Private Sub txtEntradaGeneral_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtEntradaGeneral.Validating
        If txtEntradaGeneral.TextLength = 0 Then
            ErrorProviderEventos.Clear()
            ErrorProviderEventos.SetError(txtEntradaGeneral, "Campo obligatorio")
            ErrorProviderEventos.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
            txtEntradaGeneral.Focus()
            vEntradaGeneral = False
            Exit Sub
        Else
            ErrorProviderEventos.SetError(txtEntradaGeneral, "")
            vEntradaGeneral = True
        End If
    End Sub

    Private Sub txtBalcones_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtBalcones.Validating
        If txtBalcones.TextLength = 0 Then
            ErrorProviderEventos.Clear()
            ErrorProviderEventos.SetError(txtBalcones, "Campo obligatorio")
            ErrorProviderEventos.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
            txtBalcones.Focus()
            Exit Sub
        Else
            ErrorProviderEventos.SetError(txtBalcones, "")
        End If
        If Integer.Parse(txtBalcones.Text) > Integer.Parse(lblMaxBalcones.Text) Then
            ErrorProviderEventos.SetError(txtBalcones, "Hay sólo " & lblMaxBalcones.Text & " asientos disponibles")
            ErrorProviderEventos.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
            txtBalcones.Focus()
            Exit Sub
        Else
            ErrorProviderEventos.SetError(txtBalcones, "")
        End If
    End Sub


    Private Sub txtPlateaNumerada_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtPlateaNumerada.Validating
        If txtPlateaNumerada.TextLength = 0 Then
            ErrorProviderEventos.Clear()
            ErrorProviderEventos.SetError(txtPlateaNumerada, "Campo obligatorio")
            ErrorProviderEventos.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
            txtPlateaNumerada.Focus()
            Exit Sub
        Else
            ErrorProviderEventos.SetError(txtPlateaNumerada, "")
        End If
        If Integer.Parse(txtPlateaNumerada.Text) > Integer.Parse(lblMaxPlateaNumerada.Text) Then
            ErrorProviderEventos.SetError(txtPlateaNumerada, "Hay sólo " & lblMaxPlateaNumerada.Text & " asientos disponibles")
            ErrorProviderEventos.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
            txtPlateaNumerada.Focus()
            Exit Sub
        Else
            ErrorProviderEventos.SetError(txtPlateaNumerada, "")
        End If
    End Sub

    Private Sub txtPlatea_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtPlatea.Validating
        If txtPlatea.TextLength = 0 Then
            ErrorProviderEventos.Clear()
            ErrorProviderEventos.SetError(txtPlatea, "Campo platea obligatorio")
            ErrorProviderEventos.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
            txtPlatea.Focus()
            Exit Sub
        Else
            ErrorProviderEventos.SetError(txtPlatea, "")
        End If
        If Integer.Parse(txtPlatea.Text) > Integer.Parse(lblMaxPlatea.Text) Then
            ErrorProviderEventos.SetError(txtPlatea, "Hay sólo " & lblMaxPlatea.Text & " asientos disponibles")
            ErrorProviderEventos.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
            txtPlatea.Focus()
            Exit Sub
        Else
            ErrorProviderEventos.SetError(txtPlatea, "")
        End If
    End Sub



    'Aca valido cuando hacen click en el checkbox tarde y hay otro checkbox seleccionada. Entonces digo que se termine con el que está primero seleccionado
    Private Sub chkTarde_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkTarde.Click
        Try
            If chkTarde.Checked = True Then
                groUbicaciones.Enabled = True
                If Date.Now.Hour >= 18 And Date.Now.Minute >= 0 And dtFechaSeleccionada = Date.Now.Date Then
                    MsgBox("Error: Según la hora del sistema, el evento que está registrando está fuera del horario de la jornada Tarde (Entre 15:00 y 18 horas)", MsgBoxStyle.Critical)
                    chkTarde.Checked = False
                    Exit Sub
                Else
                    If chkMatine.Checked = True Then
                        MsgBox("Termine primero con la jornada MATINÉ", MsgBoxStyle.Critical)
                        chkTarde.Checked = False
                        Me.txtBalcones.Focus()
                        Exit Sub
                    ElseIf chkNoche.Checked = True Then
                        MsgBox("Termine primero con la jornada NOCHE", MsgBoxStyle.Critical)
                        chkTarde.Checked = False
                        Me.txtBalcones.Focus()
                        Exit Sub

                    End If
                End If
            Else
                groUbicaciones.Enabled = False
            End If
        Catch ex As Exception
            MsgBox("Se produjo el siguiente error: " & ex.Message, MsgBoxStyle.Critical, "Teatro")
        End Try
    End Sub
    'Aca valido cuando hacen click en el checkbox matiné y hay otro checkbox seleccionada. Entonces digo que se termine con el que está primero seleccionado
    Private Sub chkMatine_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkMatine.Click
        Try

            If chkMatine.Checked = True Then
                groUbicaciones.Enabled = True
                If Date.Now.Hour >= 12 And Date.Now.Minute >= 0 And dtFechaSeleccionada = Date.Now.Date Then
                    MsgBox("Error: Según la hora del sistema, el evento que está registrando, está fuera del horario de la jornada Matiné (Entre 10:00 y 12:00 horas)", MsgBoxStyle.Critical)
                    chkMatine.Checked = False
                    Exit Sub
                Else
                    If chkTarde.Checked = True Then
                        MsgBox("Termine primero con la jornada TARDE", MsgBoxStyle.Critical)
                        chkMatine.Checked = False
                        Me.txtBalcones.Focus()
                        Exit Sub
                    ElseIf chkNoche.Checked = True Then
                        MsgBox("Termine primero con la jornada NOCHE", MsgBoxStyle.Critical)
                        chkMatine.Checked = False
                        Me.txtBalcones.Focus()
                        Exit Sub
                    End If
                End If
            Else
                groUbicaciones.Enabled = False
            End If
        Catch ex As Exception
            MsgBox("Se produjo el siguiente error: " & ex.Message, MsgBoxStyle.Critical, "Teatro")
        End Try
    End Sub
    ''Aca valido cuando hacen click en el checkbox noche y hay otro checkbox seleccionada. Entonces digo que se termine con el que está primero seleccionado
    Private Sub chkNoche_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkNoche.Click
        Try
            If chkNoche.Checked = True Then
                groUbicaciones.Enabled = True
                If Date.Now.Hour >= 22 And Date.Now.Minute >= 0 And dtFechaSeleccionada = Date.Now.Date Then
                    MsgBox("Error: Según la hora del sistema, el evento que está registrando, está fuera del horario de la jornada Noche (Entre 20:00 y 22:00 horas)", MsgBoxStyle.Critical)
                    chkNoche.Checked = False
                    Exit Sub
                Else
                    If chkTarde.Checked = True Then
                        MsgBox("Termine primero con la jornada TARDE", MsgBoxStyle.Critical)
                        chkNoche.Checked = False
                        Me.txtBalcones.Focus()
                        Exit Sub
                    ElseIf chkMatine.Checked = True Then
                        MsgBox("Termine primero con la jornada MATINE", MsgBoxStyle.Critical)
                        chkNoche.Checked = False
                        Me.txtBalcones.Focus()
                        Exit Sub
                    End If
                End If
            Else
                'groJornadas.Enabled = False
                groUbicaciones.Enabled = False
            End If
        Catch ex As Exception
            MsgBox("Se produjo el siguiente error: " & ex.Message, MsgBoxStyle.Critical, "Teatro")
        End Try
    End Sub
    'Acá verifico el estado de las jornadas en una determinada fecha. Recorro todos los datos de la tabla
    Public Function ValidarNombreYFecha() As Integer
        Conexion.Close()
        Try
            Conexion.Open()
            Dim Cadena As String = "Select IDEVENTO, FECHAEVENTO,MATINÉ,TARDE,NOCHE FROM EVENTOSJORNADAS;"
            Dim DAdapter As New SqlDataAdapter(Cadena, Conexion)
            Dim DTable As New DataTable
            Dim DRow As DataRow = Nothing
            DAdapter.Fill(DTable)
            'Una vez validado el Rut, se evalua si los datos pertenecen a algún usuario registrado
            For Each DRow In DTable.Rows
                If strFecha = DRow("FECHAEVENTO") And DRow("MATINÉ") <> 0 And DRow("TARDE") <> 0 And DRow("NOCHE") <> 0 Then
                    Return 9
                    Exit Function
                ElseIf strFecha = DRow("FECHAEVENTO") And DRow("MATINÉ") = 0 And DRow("TARDE") <> 0 And DRow("NOCHE") <> 0 Then
                    intIDEventoTemporal = DRow("IDEVENTO")
                    strFechaTemporal = DRow("FECHAEVENTO")
                    Return 1
                    Exit Function
                ElseIf strFecha = DRow("FECHAEVENTO") And DRow("TARDE") = 0 And DRow("MATINÉ") <> 0 And DRow("NOCHE") <> 0 Then
                    intIDEventoTemporal = DRow("IDEVENTO")
                    strFechaTemporal = DRow("FECHAEVENTO")
                    Return 2
                    Exit Function
                ElseIf strFecha = DRow("FECHAEVENTO") And DRow("NOCHE") = 0 And DRow("TARDE") <> 0 And DRow("MATINÉ") <> 0 Then
                    intIDEventoTemporal = DRow("IDEVENTO")
                    strFechaTemporal = DRow("FECHAEVENTO")
                    Return 3
                    Exit Function
                ElseIf strFecha = DRow("FECHAEVENTO") And DRow("MATINÉ") = 0 And DRow("TARDE") = 0 And DRow("NOCHE") <> 0 Then
                    intIDEventoTemporal = DRow("IDEVENTO")
                    strFechaTemporal = DRow("FECHAEVENTO")
                    Return 12
                    Exit Function
                ElseIf strFecha = DRow("FECHAEVENTO") And DRow("MATINÉ") = 0 And DRow("NOCHE") = 0 And DRow("TARDE") <> 0 Then
                    intIDEventoTemporal = DRow("IDEVENTO")
                    strFechaTemporal = DRow("FECHAEVENTO")
                    Return 13
                    Exit Function
                ElseIf strFecha = DRow("FECHAEVENTO") And DRow("TARDE") = 0 And DRow("NOCHE") = 0 And DRow("MATINÉ") <> 0 Then
                    intIDEventoTemporal = DRow("IDEVENTO")
                    strFechaTemporal = DRow("FECHAEVENTO")
                    Return 23
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
    'Actualizo el estado de las fechas (las jornadas activas)
    Private Sub frmRegistroEvento_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        Try
            strFecha = Me.lstboxFechas.SelectedItem
            Me.ValidarNombreYFecha()
            If Me.ValidarNombreYFecha() = 9 Then
                MsgBox("Esta todo programado para esta fecha", MsgBoxStyle.Critical)
                lstboxFechas.Items.Remove(lstboxFechas.SelectedItem)
                intRegistroCorrecto = 0
                chkMatine.Enabled = False
                chkTarde.Enabled = False
                chkNoche.Enabled = False
                chkMatine.Checked = False
                chkTarde.Checked = False
                chkNoche.Checked = False
                btnRegistrarEvento.Enabled = False
                Exit Sub
            ElseIf Me.ValidarNombreYFecha() = 1 Then
                'MsgBox("La jornada matiné esta disponible para la fecha seleccionada", MsgBoxStyle.Information)
                groJornadas.Enabled = True
                'groUbicaciones.Enabled = True
                chkMatine.Enabled = True
                chkTarde.Enabled = False
                chkNoche.Enabled = False
                chkTarde.Checked = False
                chkNoche.Checked = False
                Exit Sub
            ElseIf Me.ValidarNombreYFecha() = 2 Then
                'MsgBox("La jornada tarde esta disponible para la fecha seleccionada", MsgBoxStyle.Information)
                groJornadas.Enabled = True
                'groUbicaciones.Enabled = True
                chkMatine.Enabled = False
                chkTarde.Enabled = True
                chkNoche.Enabled = False
                chkMatine.Checked = False
                chkNoche.Checked = False
                Exit Sub
            ElseIf Me.ValidarNombreYFecha() = 3 Then
                'MsgBox("La jornada noche esta disponible para la fecha seleccionada", MsgBoxStyle.Information)
                groJornadas.Enabled = True
                'groUbicaciones.Enabled = True
                chkMatine.Enabled = False
                chkTarde.Enabled = False
                chkNoche.Enabled = True
                chkMatine.Checked = False
                chkTarde.Checked = False
                Exit Sub
            ElseIf Me.ValidarNombreYFecha() = 12 Then
                'MsgBox("La jornada matiné y tarde están disponibles para la fecha seleccionada", MsgBoxStyle.Information)
                groJornadas.Enabled = True
                'groUbicaciones.Enabled = True
                chkMatine.Enabled = True
                chkTarde.Enabled = True
                chkNoche.Enabled = False
                chkNoche.Checked = False
                Exit Sub
            ElseIf Me.ValidarNombreYFecha() = 13 Then
                'MsgBox("La jornada matiné y noche están disponibles para la fecha seleccionada", MsgBoxStyle.Information)
                groJornadas.Enabled = True
                'groUbicaciones.Enabled = True
                chkMatine.Enabled = True
                chkTarde.Enabled = False
                chkNoche.Enabled = True
                chkTarde.Checked = False
            ElseIf Me.ValidarNombreYFecha() = 23 Then
                'MsgBox("La jornada tarde y noche están disponibles para la fecha seleccionada", MsgBoxStyle.Information)
                groJornadas.Enabled = True
                'groUbicaciones.Enabled = True
                chkMatine.Enabled = False
                chkTarde.Enabled = True
                chkNoche.Enabled = True
                chkMatine.Checked = False
                Exit Sub
            ElseIf Me.ValidarNombreYFecha() = 0 Then
                groJornadas.Enabled = True
                'groUbicaciones.Enabled = True
                chkMatine.Enabled = True
                chkTarde.Enabled = True
                chkNoche.Enabled = True
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox("Se ha producido el siguiente error: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
End Class