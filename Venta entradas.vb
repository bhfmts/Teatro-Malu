Imports System.Data.SqlClient
Imports Teatro.ClassConexion
Imports Teatro.ClassEntrada
Imports Teatro.Validaciones
Imports Teatro.ClassVendedor
Imports Teatro.ClassProductor
Imports Teatro.ClassAdministrador
Imports Teatro.ClassCliente
Imports System.Transactions

Public Class frmVentasEntradas
    '***********************************************************************************************************
    'Declaración de variables
    Dim intJornada1 As Integer
    Dim intJornada2 As Integer
    Dim intJornada3 As Integer
    Dim intIDEvento As Integer
    Dim intVuelto As Integer
    Dim intTotalPagar As Integer
    Dim intAuxFor As Integer
    Dim intI As Integer
    Dim drResultado As DialogResult
    Dim drRegistrarCliente As DialogResult
    Dim fecha As String
    Dim strFechaEvento As String
    Dim strRUNBuscar
    Dim blnPremiado As Boolean
    Dim blnMasDe50 As Boolean
   


    Private Sub frmVentasEntradas_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim drResultado As DialogResult = MsgBox("Asegúrese de haber completado correctamente sus operaciones. ¿Está seguro que desea cerrar? ", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Registro eventos")
        If drResultado = vbNo Then
            e.Cancel = True
        Else
            Me.LimpiaControles()
            Me.Dispose()
        End If
    End Sub

    Private Sub frmVentasEntradas_HelpRequested(ByVal sender As Object, ByVal hlpevent As System.Windows.Forms.HelpEventArgs) Handles Me.HelpRequested
        Try
            System.Diagnostics.Process.Start("\\BERNARDO\Manuales\Venta de entradas.avi")
        Catch ex As Exception
            MsgBox("Se ha producido el siguiente error: " & ex.Message, MsgBoxStyle.Critical)
        End Try

    End Sub
    '***********************************************************************************************************
    'Operaciones que realizo al cargar el formulario
    'Básicamente selecciono todos los nombre de eventos disponibles en la base de datos
    'De acuerdo a la selección se guarda en una variable auxiliar el NombreEvento seleccionada
    'para luego ocuparlo en la consulta para cargar las fechas que están programadas para ese evento
    Private Sub frmVentaEntrada_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Size = Me.MinimumSize
        Conexion.Close()
        Me.ErrorProviderCantUbic.Clear()
        Me.ErrorProviderEfectivo.Clear()
        Me.ErrorProviderVentaEntradas.Clear()
        Try
            Conexion.Open()
            Dim Sentencia As String = "SELECT DISTINCT NOMBREEVENTO FROM EVENTOS WHERE FECHAEVENTO >= '" & Date.Now.Date & "';"
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
            cmbTipoEntrada.Text = ""
            Timer1.Enabled = True
            Timer1.Interval = 1
            Timer1.Start()
        Catch ex As Exception
            MsgBox("Se ha producido el siguiente error: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub


    '***********************************************************************************************************
    'Cargo las fechas programadas para la fecha actual
    Private Sub btnHoy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHoy.Click
        Conexion.Close()
        Try
            cmbTipoEntrada.Text = ""
            chkMatine.Checked = False
            chkTarde.Checked = False
            chkNoche.Checked = False
            cmbTipoEntrada.Enabled = False
            cmbFechasEvento.Enabled = True
            strNombreEvento = cmbNombreEvento.GetItemText(cmbNombreEvento.SelectedValue) 'Se asigna el "nombreevento" a una variable auxiliar
            intIDEvento = Me.EVENTOSTableAdapter.SelectIDEvento(strNombreEvento)
            fecha = String.Format("{0:dd/MM/yy}", Date.Now.Date)

            Conexion.Open()
            Dim Sentencia2 As String = "SELECT DISTINCT EVENTOS.FECHAEVENTO FROM EVENTOS WHERE NOMBREEVENTO ='" & strNombreEvento & "' AND EVENTOS.FECHAEVENTO='" & Date.Now.Date & "';"
            Dim DAdapter As New SqlDataAdapter(Sentencia2, Conexion)
            Dim DSet As New DataSet
            Dim dt As New DataTable
            DAdapter.Fill(dt)
            cmbFechasEvento.DataSource = dt
            cmbFechasEvento.DisplayMember = "FechaEvento"
            cmbFechasEvento.SelectedIndex = -1
            cmbFechasEvento.Text = ""
            'Truquito para que los checkbox de las jornadas se activen cuando se 
            'seleccione la fecha y no cuando se seleccione el nombre
            chkMatine.Enabled = False
            chkTarde.Enabled = False
            chkNoche.Enabled = False
            txtEntradaGeneral.Text = ""
            cmbTipoEntrada.Enabled = False
            'Hasta aquí es el truquito
        Catch ex As Exception
            MsgBox("Se ha producido el siguiente error: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            Conexion.Close()
        End Try

        'Else
        '   
        'End If
    End Sub

    '***********************************************************************************************************
    'Cargo las fechas correspondientes a otros días
    Private Sub btnCualquierDia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCualquierDia.Click
        Conexion.Close()
        Try
            strNombreEvento = cmbNombreEvento.GetItemText(cmbNombreEvento.SelectedValue) 'Se asigna el "nombreevento" a una variable auxiliar
            intIDEvento = Me.EVENTOSTableAdapter.SelectIDEvento(strNombreEvento)
            cmbTipoEntrada.Text = ""
            cmbFechasEvento.Enabled = True
            Conexion.Open()
            Dim Sentencia2 As String = "SELECT FECHAEVENTO FROM EVENTOS WHERE NOMBREEVENTO ='" & strNombreEvento & "' AND EVENTOS.FECHAEVENTO >'" & Date.Now.Date & "';"
            Dim DAdapter As New SqlDataAdapter(Sentencia2, Conexion)
            Dim DSet As New DataSet
            Dim dt As New DataTable
            DAdapter.Fill(dt)
            cmbFechasEvento.DataSource = dt
            cmbFechasEvento.DisplayMember = "FechaEvento"
            cmbFechasEvento.SelectedIndex = -1
            cmbFechasEvento.Text = ""
            'Truquito para que los checkbox de las jornadas se activen cuando se 
            'seleccione la fecha y no cuando se seleccione el nombre
            chkMatine.Enabled = False
            chkTarde.Enabled = False
            chkNoche.Enabled = False
            txtEntradaGeneral.Text = ""
            cmbTipoEntrada.Enabled = False
            'Hasta aquí es el truquito
        Catch ex As Exception
            MsgBox("Se ha producido el siguiente error: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            Conexion.Close()
        End Try
    End Sub

    '***********************************************************************************************************
    'Operaciones que se realizan al seleccionar un nombre de evento
    'Básicamente aquí cargo el combobox cmbFechasEvento de acuerdo al nombre de evento seleccionado
    Private Sub cmbNombreEvento_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbNombreEvento.SelectedIndexChanged
        cmbFechasEvento.Text = ""
        cmbTipoEntrada.Text = ""
        txtEntradaGeneral.Text = ""
    End Sub

    '***********************************************************************************************************
    'Operaciones que se realizan cuando se selecciona una fecha
    'Se llama al procedimiento CompruebaJornadas y luego se llama 
    'al procedimiento ActivaJornadas para activar los checkbox correspondientes
    Private Sub cmbFechasEvento_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbFechasEvento.SelectedIndexChanged
        Try
        
            If cmbFechasEvento.GetItemText(cmbFechasEvento.SelectedItem) <> "" Then
                ErrorProviderVentaEntradas.SetError(cmbFechasEvento, "")
            End If
            chkMatine.Checked = False
            chkTarde.Checked = False
            chkNoche.Checked = False

            If cmbFechasEvento.GetItemText(cmbFechasEvento.SelectedItem) <> "" Then
                cmbTipoEntrada.Enabled = True

            End If
            If cmbFechasEvento.GetItemText(cmbFechasEvento.SelectedItem) <> "System.Data.DataRowView" Then
                strFechaEvento = cmbFechasEvento.GetItemText(cmbFechasEvento.SelectedItem)
                'cmbTipoEntrada.SelectedIndex = -1
                txtEntradaGeneral.Text = Me.EVENTOSTableAdapter.SelectEntradaPorFecha(intIDEvento, strFechaEvento)
            End If
        Catch ex As Exception
            MsgBox("Se produjo el siguiente error: " & ex.Message, MsgBoxStyle.Critical, "Teatro")
        End Try
    End Sub

    '***********************************************************************************************************
    ' En este evento se asigna el precio de la entrada al textbox según la selección del usuario (estudiante, niño, etc)
    Private Sub cmbTipoEntrada_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbTipoEntrada.SelectedIndexChanged
        Try
            If chkMatine.Checked = False And chkTarde.Checked = False And chkNoche.Checked = False Then
                strUbicacion = ""
            End If
            If cmbTipoEntrada.SelectedItem <> "" Then
                ErrorProviderVentaEntradas.SetError(cmbTipoEntrada, "")
            End If

            ErrorProviderVentaEntradas.SetError(cmbTipoEntrada, "")
            If cmbFechasEvento.GetItemText(cmbFechasEvento.SelectedItem) = "" Then
                ErrorProviderVentaEntradas.SetError(cmbFechasEvento, "Seleccione la fecha del evento")
                ErrorProviderVentaEntradas.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
                cmbFechasEvento.Focus()
                Me.cmbTipoEntrada.Enabled = False
                cmbTipoEntrada.SelectedIndex = -1
                Exit Sub
            Else
                ErrorProviderVentaEntradas.SetError(cmbFechasEvento, "")
            End If
            dbEntradaGeneral = Me.EVENTOSTableAdapter.SelectEntradaPorFecha(intIDEvento, strFechaEvento)
            'dbEntradaNiño = dbEntradaGeneral * dbPorcentNiño
            'dbEntradaTerceraEdad = dbEntradaGeneral * dbPorcentTerceraEdad 'precioentrada tercera edad  
            'dbEntradaEstudiante = dbEntradaGeneral * dbPorcentEstudiante 'precioentrada estudiante
            If cmbTipoEntrada.SelectedItem = "NIÑO" Then
                txtEntradaGeneral.Text = dbEntradaGeneral * dbPorcentNiño ' precioentrada niño
                dbEntradaNiño = Double.Parse(txtEntradaGeneral.Text)
            End If
            If cmbTipoEntrada.SelectedItem = "NIÑO" And strUbicacion = "Platea" Then
                txtEntradaGeneral.Text = (dbEntradaGeneral + 2000) * dbPorcentNiño
                dbEntradaNiño = Double.Parse(txtEntradaGeneral.Text)
            End If
            If cmbTipoEntrada.SelectedItem = "NIÑO" And strUbicacion = "Platea numerada" Then
                txtEntradaGeneral.Text = (dbEntradaGeneral + 3500) * dbPorcentNiño
                dbEntradaNiño = Double.Parse(txtEntradaGeneral.Text)
            End If
            If cmbTipoEntrada.SelectedItem = "ESTUDIANTE" Then
                txtEntradaGeneral.Text = dbEntradaGeneral * dbPorcentEstudiante
                dbEntradaEstudiante = Double.Parse(txtEntradaGeneral.Text)
            End If
            If cmbTipoEntrada.SelectedItem = "ESTUDIANTE" And strUbicacion = "Platea" Then
                txtEntradaGeneral.Text = (dbEntradaGeneral + 2000) * dbPorcentEstudiante
                dbEntradaEstudiante = Double.Parse(txtEntradaGeneral.Text)
            End If
            If cmbTipoEntrada.SelectedItem = "ESTUDIANTE" And strUbicacion = "Platea numerada" Then
                txtEntradaGeneral.Text = (dbEntradaGeneral + 3500) * dbPorcentEstudiante
                dbEntradaEstudiante = Double.Parse(txtEntradaGeneral.Text)
            End If
            If cmbTipoEntrada.SelectedItem = "TERCERA EDAD" Then
                txtEntradaGeneral.Text = dbEntradaGeneral * dbPorcentTerceraEdad
                dbEntradaTerceraEdad = Double.Parse(txtEntradaGeneral.Text)
            End If
            If cmbTipoEntrada.SelectedItem = "TERCERA EDAD" And strUbicacion = "Platea" Then
                txtEntradaGeneral.Text = (dbEntradaGeneral + 2000) * dbPorcentTerceraEdad
                dbEntradaTerceraEdad = Double.Parse(txtEntradaGeneral.Text)
            End If
            If cmbTipoEntrada.SelectedItem = "TERCERA EDAD" And strUbicacion = "Platea numerada" Then
                txtEntradaGeneral.Text = (dbEntradaGeneral + 3500) * dbPorcentTerceraEdad
                dbEntradaTerceraEdad = Double.Parse(txtEntradaGeneral.Text)
            End If
            If cmbTipoEntrada.SelectedItem = "ADULTO" Then
                txtEntradaGeneral.Text = dbEntradaGeneral
                dbPrecioTipo = Double.Parse(txtEntradaGeneral.Text)
            End If
            If cmbTipoEntrada.SelectedItem = "ADULTO" And strUbicacion = "Platea" Then
                txtEntradaGeneral.Text = dbEntradaGeneral + 2000
                dbPrecioTipo = Double.Parse(txtEntradaGeneral.Text)
            End If
            If cmbTipoEntrada.SelectedItem = "ADULTO" And strUbicacion = "Platea numerada" Then
                txtEntradaGeneral.Text = dbEntradaGeneral + 3500
                dbPrecioTipo = Double.Parse(txtEntradaGeneral.Text)
            End If
            'strTipoEntrada = cmbTipoEntrada.SelectedItem
            CompruebaJornadas()
            ActivaJornadas()
            'Reseteo de variables
            intJornada1 = 0
            intJornada2 = 0
            intJornada3 = 0
            'dbEntradaNiño = 0
            'dbEntradaEstudiante = 0
            'dbEntradaTerceraEdad = 0
            'dbEntradaGeneral = 0
        Catch ex As Exception
            MsgBox("Se produjo el siguiente error: " & ex.Message, MsgBoxStyle.Critical, "Teatro")
        End Try
    End Sub

    '**************************************************************************************************************
    'De aquí se realizan las operaciones del evento click de los checkbox de las jornadas
    Private Sub chkMatine_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkMatine.Click
        Try
       
            strJornada = chkMatine.Text
            If cmbTipoEntrada.SelectedItem = "" Then
                ErrorProviderVentaEntradas.SetError(cmbTipoEntrada, "Seleccione el tipo de entrada")
                ErrorProviderVentaEntradas.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
                chkMatine.Checked = False
                Me.cmbTipoEntrada.Focus()
                Exit Sub
            Else
                ErrorProviderVentaEntradas.SetError(cmbTipoEntrada, "")
            End If
            If chkNoche.Checked = True Then
                MsgBox("Termine con la jornada NOCHE primero", MsgBoxStyle.Critical)
                chkMatine.Checked = False
                Exit Sub
            End If
            If chkTarde.Checked = True Then
                MsgBox("Termine con la jornada TARDE primero", MsgBoxStyle.Critical)
                chkMatine.Checked = False
                Exit Sub
            End If
            'Operaciones que se realizan en el evento click del checkbox chkNoche
            'Dim cantidad As New frmCantidad
            'Se comprueba si esta con ticket para mostrar el form Cantidad
            If chkMatine.Checked = True Then
                groUbicaciones.Enabled = True
                Me.cmbUbicacion.Focus()
                groJornadas.Enabled = False
                intJornada = 1
            End If
        Catch ex As Exception
            MsgBox("Se produjo el siguiente error: " & ex.Message, MsgBoxStyle.Critical, "Teatro")
        End Try
    End Sub
    '***********************************************************************************************************
    'Operaciones que se realizan en el evento click del checkbox chkTarde
    Private Sub chkTarde_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkTarde.Click
        Try
      
            strJornada = chkTarde.Text
            If cmbTipoEntrada.SelectedItem = "" Then
                ErrorProviderVentaEntradas.SetError(cmbTipoEntrada, "Seleccione el tipo de entrada")
                ErrorProviderVentaEntradas.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
                chkTarde.Checked = False
                Me.cmbTipoEntrada.Focus()
                Exit Sub
            Else
                ErrorProviderVentaEntradas.SetError(cmbTipoEntrada, "")
            End If
            If chkMatine.Checked = True Then
                MsgBox("Termine con la jornada MATINÉ primero", MsgBoxStyle.Critical)
                chkTarde.Checked = False
                Exit Sub
            End If
            If chkNoche.Checked = True Then
                MsgBox("Termine con la jornada NOCHE primero", MsgBoxStyle.Critical)
                chkTarde.Checked = False
                Exit Sub
            End If
            If chkTarde.Checked = True Then
                groUbicaciones.Enabled = True
                Me.cmbUbicacion.Focus()
                groJornadas.Enabled = False
                intJornada = 2
            End If
        Catch ex As Exception
            MsgBox("Se produjo el siguiente error: " & ex.Message, MsgBoxStyle.Critical, "Teatro")
        End Try
    End Sub

    '***********************************************************************************************************
    'Operaciones que realizo cuando en el evento click del checkbok chkNoche
    Private Sub chkNoche_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkNoche.Click
        Try
      
            strJornada = chkNoche.Text
            If cmbTipoEntrada.SelectedItem = "" Then
                ErrorProviderVentaEntradas.SetError(cmbTipoEntrada, "Seleccione el tipo de entrada")
                ErrorProviderVentaEntradas.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
                chkNoche.Checked = False
                Me.cmbTipoEntrada.Focus()
                Exit Sub
            Else
                ErrorProviderVentaEntradas.SetError(cmbTipoEntrada, "")
            End If
            If chkMatine.Checked = True Then
                MsgBox("Termine con la jornada MATINÉ primero", MsgBoxStyle.Critical)
                chkNoche.Checked = False
                Exit Sub
            End If
            If chkTarde.Checked = True Then
                MsgBox("Termine con la jornada TARDE primero", MsgBoxStyle.Critical)
                chkNoche.Checked = False
                Exit Sub
            End If
            If chkNoche.Checked = True Then
                groUbicaciones.Enabled = True
                Me.cmbUbicacion.Focus()
                groJornadas.Enabled = False
                intJornada = 3
            End If
        Catch ex As Exception
            MsgBox("Se produjo el siguiente error: " & ex.Message, MsgBoxStyle.Critical, "Teatro")
        End Try
    End Sub
    'Hasta aquí llegan las operaciones que se realizan en los eventos clicks del los checkbox de las jornadas
    '**************************************************************************************************************


    '**************************************************************************************************************
    'PROCEDIMIENTOS
    'Procedimiento donde compruebo que jornadas (matiné, tarde o noche) están programadas para la fecha seleccionada en el cmbFechaEvento
    Public Sub CompruebaJornadas()
        Conexion.Close()
        Try
            strFechaEvento = cmbFechasEvento.GetItemText(cmbFechasEvento.SelectedValue)


            Conexion.Open()
            Dim Cadena As String = "Select FECHAEVENTO,MATINÉ,TARDE,NOCHE FROM EVENTOSJORNADAS WHERE FECHAEVENTO ='" & strFechaEvento & "';"
            Dim DAdapter As New SqlDataAdapter(Cadena, Conexion)
            Dim DTable As New DataTable
            Dim DRow As DataRow = Nothing
            DAdapter.Fill(DTable)
            For Each DRow In DTable.Rows
                If strFechaEvento = DRow("FECHAEVENTO") And DRow("MATINÉ") = intIDEvento Then
                    intJornada1 = 1
                Else
                    intJornada1 = 0
                End If
                If strFechaEvento = DRow("FECHAEVENTO") And DRow("TARDE") = intIDEvento Then
                    intJornada2 = 2
                Else
                    intJornada2 = 0
                End If
                If strFechaEvento = DRow("FECHAEVENTO") And DRow("NOCHE") = intIDEvento Then
                    intJornada3 = 3
                Else
                    intJornada3 = 0
                End If
            Next
        Catch ex As Exception
            MsgBox("Se ha producido el siguiente error: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            Conexion.Close()
        End Try
    End Sub
    '***********************************************************************************************************
    'Procedimiento donde activo los checkbox de cada jornada según el resultado del procedimiento CompruebaJornadas()
    Public Sub ActivaJornadas()
        If intJornada1 = 1 Then
            chkMatine.Enabled = True
        Else
            chkMatine.Enabled = False
        End If
        If intJornada2 = 2 Then
            chkTarde.Enabled = True
        Else
            chkTarde.Enabled = False
        End If
        If intJornada3 = 3 Then
            chkNoche.Enabled = True
        Else
            chkNoche.Enabled = False
        End If

    End Sub
    '***********************************************************************************************************
    'Actualización de estado de las entradas
    Public Sub ActualizacionEstadoEntradas()
        Try
       
            If cmbUbicacion.GetItemText(cmbUbicacion.SelectedItem) = "Balcones" And chkMatine.Checked = True Then
                Me.EstadoentradasTableAdapter1.UpdateEstadoBalcones(intAuxFor, intIDEvento, strFechaEvento, chkMatine.Text)
            ElseIf cmbUbicacion.GetItemText(cmbUbicacion.SelectedItem) = "Balcones" And chkTarde.Checked = True Then
                Me.EstadoentradasTableAdapter1.UpdateEstadoBalcones(intAuxFor, intIDEvento, strFechaEvento, chkTarde.Text)
            ElseIf cmbUbicacion.GetItemText(cmbUbicacion.SelectedItem) = "Balcones" And chkNoche.Checked = True Then
                Me.EstadoentradasTableAdapter1.UpdateEstadoBalcones(intAuxFor, intIDEvento, strFechaEvento, chkNoche.Text)
            End If

            If cmbUbicacion.GetItemText(cmbUbicacion.SelectedItem) = "Platea" And chkMatine.Checked = True Then
                Me.EstadoentradasTableAdapter1.UpdateEstadoPlatea(intAuxFor, intIDEvento, strFechaEvento, chkMatine.Text)
            ElseIf cmbUbicacion.GetItemText(cmbUbicacion.SelectedItem) = "Platea" And chkTarde.Checked = True Then
                Me.EstadoentradasTableAdapter1.UpdateEstadoPlatea(intAuxFor, intIDEvento, strFechaEvento, chkTarde.Text)
            ElseIf cmbUbicacion.GetItemText(cmbUbicacion.SelectedItem) = "Platea" And chkNoche.Checked = True Then
                Me.EstadoentradasTableAdapter1.UpdateEstadoPlatea(intAuxFor, intIDEvento, strFechaEvento, chkNoche.Text)
            End If

            If cmbUbicacion.GetItemText(cmbUbicacion.SelectedItem) = "Platea numerada" And chkMatine.Checked = True Then
                Me.EstadoentradasTableAdapter1.UpdateEstadoPlateaNumerada(intAuxFor, intIDEvento, strFechaEvento, chkMatine.Text)
            ElseIf cmbUbicacion.GetItemText(cmbUbicacion.SelectedItem) = "Platea numerada" And chkTarde.Checked = True Then
                Me.EstadoentradasTableAdapter1.UpdateEstadoPlateaNumerada(intAuxFor, intIDEvento, strFechaEvento, chkTarde.Text)
            ElseIf cmbUbicacion.GetItemText(cmbUbicacion.SelectedItem) = "Platea numerada" And chkNoche.Checked = True Then
                Me.EstadoentradasTableAdapter1.UpdateEstadoPlateaNumerada(intAuxFor, intIDEvento, strFechaEvento, chkNoche.Text)
            End If
        Catch ex As Exception
            MsgBox("Se produjo el siguiente error: " & ex.Message, MsgBoxStyle.Critical, "Teatro")
        End Try
    End Sub

    'TERMINAN LOS PROCEDIMIENTOS
    '**************************************************************************************************************

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        txtFechaVenta.Text = Date.Today & " " & Date.Now().ToLongTimeString
    End Sub
    '***********************************************************************************************************
    'Aqui hago las operaciones del evento click del botón listo de cuando se selecciona la ubicación
    'y la cantidad de entradas que se va a vender
    Private Sub btnListo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListo.Click
        Try
            Dim intDisponibilidadPlatea = Me.EstadoentradasTableAdapter1.SelectEstadoPlatea(intIDEvento, strFechaEvento, strJornada)
            Dim intDisponibilidadPlateaNumerada = Me.EstadoentradasTableAdapter1.SelectEstadoPlateaNumerada(intIDEvento, strFechaEvento, strJornada)
            Dim intDisponibilidadBalcones = Me.EstadoentradasTableAdapter1.SelectEstadoBalcones(intIDEvento, strFechaEvento, strJornada)
            'Dim intDisponibilidadPlateaTarde = Me.EstadoentradasTableAdapter1.SelectEstadoPlatea(intIDEvento, strFechaEvento, chkTarde.Text)
            'Dim intDisponibilidadPlateaNumeradaTarde = Me.EstadoentradasTableAdapter1.SelectEstadoPlateaNumerada(intIDEvento, strFechaEvento, chkTarde.Text)
            'Dim intDisponibilidadBalconesNoche = Me.EstadoentradasTableAdapter1.SelectEstadoBalcones(intIDEvento, strFechaEvento, chkNoche.Text)
            'Dim intDisponibilidadPlateaNoche = Me.EstadoentradasTableAdapter1.SelectEstadoPlatea(intIDEvento, strFechaEvento, chkNoche.Text)
            'Dim intDisponibilidadPlateaNumeradaNoche = Me.EstadoentradasTableAdapter1.SelectEstadoPlateaNumerada(intIDEvento, strFechaEvento, chkNoche.Text)


            intCantidadEntradas = nupCantidad.Value
            If cmbUbicacion.GetItemText(cmbUbicacion.SelectedItem) = "Platea" Then

                If intDisponibilidadPlatea = 0 Then
                    MsgBox("No hay asientos disponibles en platea", MsgBoxStyle.Critical, "Ubicaciones")

                    Exit Sub
                ElseIf intDisponibilidadPlatea - intCantidadEntradas < 0 Then
                    MsgBox("No hay asientos disponibles para la cantidad de entradas que quiere vender en platea", MsgBoxStyle.Critical, "Ubicaciones")

                    Exit Sub

                End If
            ElseIf cmbUbicacion.GetItemText(cmbUbicacion.SelectedItem) = "Platea numerada" Then

                If intDisponibilidadPlateaNumerada = 0 Then
                    MsgBox("No hay asientos disponibles en platea numerada", MsgBoxStyle.Critical, "Ubicaciones")

                    Exit Sub
                ElseIf intDisponibilidadPlateaNumerada - intCantidadEntradas < 0 Then
                    MsgBox("No hay asientos disponibles para la cantidad de entradas que quiere vender en platea numerada", MsgBoxStyle.Critical, "Ubicaciones")

                    Exit Sub
                End If
            ElseIf cmbUbicacion.GetItemText(cmbUbicacion.SelectedItem) = "Balcones" Then

                If intDisponibilidadBalcones = 0 Then
                    MsgBox("No hay asientos disponibles en Balcones", MsgBoxStyle.Critical, "Ubicaciones")
                    Exit Sub
                ElseIf intDisponibilidadBalcones - intCantidadEntradas < 0 Then
                    MsgBox("No hay asientos disponibles para la cantidad de entradas que quiere vender en Balcones", MsgBoxStyle.Critical, "Ubicaciones")
                    Exit Sub
                End If
            End If
            If cmbUbicacion.SelectedItem = "" Then
                Me.ErrorProviderCantUbic.SetError(cmbUbicacion, "Seleccione la ubicación")
                Exit Sub
            Else
                Me.ErrorProviderCantUbic.SetError(cmbUbicacion, "")
            End If

            If nupCantidad.Value = 0 Then
                Me.ErrorProviderCantUbic.SetError(nupCantidad, "La cantidad debe ser mayor que 0")
                Exit Sub
            Else
                Me.ErrorProviderCantUbic.SetError(nupCantidad, "")
            End If

            If cmbUbicacion.SelectedItem = "Balcones" Then
                strUbicacion = "Balcones"
            ElseIf cmbUbicacion.SelectedItem = "Platea" Then
                strUbicacion = "Platea"
            ElseIf cmbUbicacion.SelectedItem = "Platea numerada" Then
                strUbicacion = "Platea numerada"
            End If


            If cmbTipoEntrada.SelectedItem = "TERCERA EDAD" And strUbicacion = "Balcones" Then
                txtEntradaGeneral.Text = dbEntradaTerceraEdad
                dbEntradaGeneral = txtEntradaGeneral.Text
            ElseIf strUbicacion = "Platea" And cmbTipoEntrada.SelectedItem = "TERCERA EDAD" Then
                txtEntradaGeneral.Text = (dbEntradaGeneral + 2000) * dbPorcentTerceraEdad
                dbEntradaGeneral = Double.Parse(txtEntradaGeneral.Text)
            ElseIf strUbicacion = "Platea numerada" And cmbTipoEntrada.SelectedItem = "TERCERA EDAD" Then
                txtEntradaGeneral.Text = (dbEntradaGeneral + 3500) * dbPorcentTerceraEdad
                dbEntradaGeneral = Double.Parse(txtEntradaGeneral.Text)

            ElseIf cmbTipoEntrada.SelectedItem = "NIÑO" And strUbicacion = "Balcones" Then
                txtEntradaGeneral.Text = dbEntradaNiño
                dbEntradaGeneral = txtEntradaGeneral.Text
            ElseIf strUbicacion = "Platea" And cmbTipoEntrada.SelectedItem = "NIÑO" Then
                txtEntradaGeneral.Text = (dbEntradaGeneral + 2000) * dbPorcentNiño
                dbEntradaGeneral = Double.Parse(txtEntradaGeneral.Text)
            ElseIf strUbicacion = "Platea numerada" And cmbTipoEntrada.SelectedItem = "NIÑO" Then
                txtEntradaGeneral.Text = (dbEntradaGeneral + 3500) * dbPorcentNiño
                dbEntradaGeneral = Double.Parse(txtEntradaGeneral.Text)


            ElseIf strUbicacion = "Platea" And cmbTipoEntrada.SelectedItem = "ESTUDIANTE" Then
                txtEntradaGeneral.Text = (dbEntradaGeneral + 2000) * dbPorcentEstudiante
                dbEntradaGeneral = Double.Parse(txtEntradaGeneral.Text)
            ElseIf strUbicacion = "Platea numerada" And cmbTipoEntrada.SelectedItem = "ESTUDIANTE" Then
                txtEntradaGeneral.Text = (dbEntradaGeneral + 3500) * dbPorcentEstudiante
                dbEntradaGeneral = Double.Parse(txtEntradaGeneral.Text)
            ElseIf cmbTipoEntrada.SelectedItem = "ESTUDIANTE" And strUbicacion = "Balcones" Then
                txtEntradaGeneral.Text = dbEntradaEstudiante
                dbEntradaGeneral = txtEntradaGeneral.Text

            ElseIf cmbTipoEntrada.SelectedItem = "ADULTO" And strUbicacion = "Platea" Then
                txtEntradaGeneral.Text = dbEntradaGeneral + 2000
                dbPrecioTipo = Double.Parse(txtEntradaGeneral.Text)
            ElseIf cmbTipoEntrada.SelectedItem = "ADULTO" And strUbicacion = "Platea numerada" Then
                txtEntradaGeneral.Text = dbEntradaGeneral + 3500
                dbPrecioTipo = Double.Parse(txtEntradaGeneral.Text)
            ElseIf cmbTipoEntrada.SelectedItem = "ADULTO" And strUbicacion = "Balcones" Then
                txtEntradaGeneral.Text = dbEntradaGeneral
                dbEntradaGeneral = txtEntradaGeneral.Text
            End If
            Me.groUbicaciones.Enabled = False
            Me.groTipoPago.Enabled = True
            Me.rdbTarBancaria.Checked = False
            Me.rdbEfectivo.Checked = False
            drRegistrarCliente = MsgBox("¿Desea ingresar un cliente a nuestro sistema de premios?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Venta entradas")
            If drRegistrarCliente = vbYes Then
                Me.groBuscarCliente.Enabled = True
                Me.txtGuionBuscar.Enabled = True
                Me.txtRUNBuscar.Enabled = True
                Me.lblRUNBuscar.Enabled = True
                Me.txtRUNBuscar.Select()
            Else
                If nupCantidad.Value >= 50 Then
                    MsgBox("Si el cliente le está comprando más de 50 entradas, debe obligatoriamente registrarlo en el sistema", MsgBoxStyle.Critical, "Venta entradas")
                    Me.groBuscarCliente.Enabled = True
                    Me.txtGuionBuscar.Enabled = True
                    Me.txtRUNBuscar.Enabled = True
                    Me.lblRUNBuscar.Enabled = True
                    Me.txtRUNBuscar.Select()
                    blnMasDe50 = True
                    Exit Sub
                Else

                    blnMasDe50 = False
                End If
                Me.groBuscarCliente.Enabled = False
                Me.txtGuionBuscar.Enabled = False
                Me.txtRUNBuscar.Enabled = False
                Me.lblRUNBuscar.Enabled = False
            End If
        Catch ex As Exception
            MsgBox("Se produjo el siguiente error: " & ex.Message, MsgBoxStyle.Critical, "Teatro")
        End Try
    End Sub
    '***********************************************************************************************************
    'Aquí activo el combobox que tiene la cantidad de cuotas
    Private Sub rdbCuotasFijas_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdbCuotasFijas.Click
        If rdbCuotasFijas.Checked = True Then
            Me.cmbCantidadCuotas.Enabled = True
        End If
    End Sub
    '***********************************************************************************************************
    'Operaciones que realizo en el evento click del botón listo del groupbox infoevento
    Private Sub btnListoInfoEvento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListoInfoEvento.Click
        Try
       
            If cmbNombreEvento.GetItemText(cmbNombreEvento.SelectedItem) = "" Then
                ErrorProviderVentaEntradas.SetError(cmbNombreEvento, "Seleccione el nombre del evento")
                ErrorProviderVentaEntradas.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
                Exit Sub
            Else
                ErrorProviderVentaEntradas.SetError(cmbNombreEvento, "")
            End If
            If cmbFechasEvento.GetItemText(cmbFechasEvento.SelectedItem) = "" Then
                ErrorProviderVentaEntradas.SetError(cmbFechasEvento, "Seleccione la fecha del evento")
                ErrorProviderVentaEntradas.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
                Exit Sub
            Else
                ErrorProviderVentaEntradas.SetError(cmbFechasEvento, "")
            End If
            If cmbTipoEntrada.SelectedItem = "" Then
                ErrorProviderVentaEntradas.SetError(cmbTipoEntrada, "Seleccione el tipo de entrada")
                ErrorProviderVentaEntradas.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
                Exit Sub
            Else
                ErrorProviderVentaEntradas.SetError(cmbTipoEntrada, "")
            End If
            Me.groInfoEvento.Enabled = False
            Me.groJornadas.Enabled = True
            CompruebaJornadas()
            ActivaJornadas()

            strFechaEvento = cmbFechasEvento.GetItemText(cmbFechasEvento.SelectedItem)
            If Date.Now.Hour >= 12 And strFechaEvento = Date.Now.Date Then
                Me.chkMatine.Enabled = False
            End If
            If Date.Now.Hour >= 18 And strFechaEvento = Date.Now.Date Then
                Me.chkTarde.Enabled = False
            End If
            If Date.Now.Hour >= 22 And strFechaEvento = Date.Now.Date Then
                Me.chkNoche.Enabled = False
            End If
        Catch ex As Exception
            MsgBox("Se produjo el siguiente error: " & ex.Message, MsgBoxStyle.Critical, "Teatro")
        End Try
    End Sub

    '********************************************************************************************************
    'Operaciones que se realizan cuando se apretan los botones atras
    Private Sub btnAtrasUbicaciones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAtrasUbicaciones.Click
        Me.groJornadas.Enabled = True
        Me.groUbicaciones.Enabled = False
    End Sub
    Private Sub btnAtrasJornadas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAtrasJornadas.Click
        Me.groInfoEvento.Enabled = True
        Me.groJornadas.Enabled = False
    End Sub
    Private Sub btnAtrasTipoPago_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAtrasTipoPago.Click
        Try

       
        Me.rdbEfectivo.Checked = False
        Me.rdbTarBancaria.Checked = False
        Me.groUbicaciones.Enabled = True
        Me.groTipoPago.Enabled = False
        Me.GroPagoEfectivo.Enabled = False
        Me.groTarjetaBancaria.Enabled = False
        txtEntradaGeneral.Text = Me.EVENTOSTableAdapter.SelectEntradaPorFecha(intIDEvento, strFechaEvento)
        dbEntradaGeneral = txtEntradaGeneral.Text
        Catch ex As Exception
            MsgBox("Se produjo el siguiente error: " & ex.Message, MsgBoxStyle.Critical, "Teatro")
        End Try
    End Sub
    'Hasta aquí llega las operaciones de los botones atras
    '********************************************************************************************************


    '********************************************************************************************************
    'Operaciones que realizo cuando selecciono una opción de pago
    Private Sub rdbEfectivo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdbEfectivo.Click
        Try
       
            If blnMasDe50 = True Then
                MsgBox("El cliente debe ser obligatoriamente registrado en el sistema para concretar la venta", MsgBoxStyle.Critical)
                Me.txtRUNBuscar.Select()
                Exit Sub
            End If
            Me.ErrorProviderVentaEntradas.Clear()
            If rdbEfectivo.Checked = True Then
                Me.txtMontoTarjeta.Clear()
                Me.GroPagoEfectivo.Enabled = True
                Me.groTarjetaBancaria.Enabled = False
                If intCantidadEntradas <> 0 Then
                    intTotalPagar = dbEntradaGeneral * intCantidadEntradas
                    txtMonto.Text = intTotalPagar
                    intAuxFor = intCantidadEntradas
                End If
                AsignaPremios()
                CompruebaPremios()
            End If
        Catch ex As Exception
            MsgBox("Se produjo el siguiente error: " & ex.Message, MsgBoxStyle.Critical, "Teatro")
        End Try
    End Sub
    Private Sub rdbTarBancaria_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdbTarBancaria.Click
        Try
       
            If blnMasDe50 = True Then
                MsgBox("El cliente debe ser obligatoriamente registrado en el sistema para concretar la venta", MsgBoxStyle.Critical)
                Me.txtRUNBuscar.Select()
                Exit Sub
            End If
            Me.ErrorProviderVentaEntradas.Clear()
            If Me.rdbTarBancaria.Enabled = True Then
                Me.txtMonto.Clear()
                Me.groTarjetaBancaria.Enabled = True
                Me.GroPagoEfectivo.Enabled = False
                If intCantidadEntradas <> 0 Then
                    intTotalPagar = dbEntradaGeneral * intCantidadEntradas
                    txtMontoTarjeta.Text = intTotalPagar
                    intAuxFor = intCantidadEntradas
                End If
                CompruebaPremios()
            End If
        Catch ex As Exception
            MsgBox("Se produjo el siguiente error: " & ex.Message, MsgBoxStyle.Critical, "Teatro")
        End Try
    End Sub
    'Hasta aquí llegan las operaciones cuando se selecciona una opción de pag
    '********************************************************************************************************


    '********************************************************************************************************
    'Operaciones que realizo cuando se hace click en el botón para pagar en efectivo
    Private Sub btnPagarEfectivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPagarEfectivo.Click
        'Using Scope As New TransactionScope()
        Try

            drResultado = MsgBox("¿Desea continuar con el pago en Efectivo?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Pago efectivo")
            If drResultado = vbYes Then
                If txtMontoEfectivo.TextLength = 0 Then
                    ErrorProviderVentaEntradas.SetError(txtMontoEfectivo, "Debe ingresar el monto efectivo")
                    ErrorProviderVentaEntradas.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
                    Exit Sub
                Else
                    ErrorProviderVentaEntradas.SetError(txtMontoEfectivo, "")
                End If
                Try
                    strTipoEntrada = cmbTipoEntrada.SelectedItem
                    strFechaEvento = cmbFechasEvento.Text
                    strFechaVenta = txtFechaVenta.Text
                    dbEntradaGeneral = Double.Parse(txtEntradaGeneral.Text)
                    strFormaPago = "Efectivo"
                    intEntradasVendidas = nupCantidad.Value
                    If chkMatine.Checked = True Then
                        strJornada = "Matiné"
                    ElseIf chkTarde.Checked = True Then
                        strJornada = "Tarde"
                    ElseIf chkNoche.Checked = True Then
                        strJornada = "Noche"
                    End If


                    'Aquí compruebo si el monto ingresado por el usuario es mayor que el monto a pagar
                    If Integer.Parse(txtMontoEfectivo.Text) >= Integer.Parse(txtMonto.Text) Then
                        'Comprobación para multiplicar el valor de la entrada por la cantidad que quiere el cliente
                        'Cálculo del vuelto para el cliente
                        intVuelto = Integer.Parse(txtMontoEfectivo.Text) - Integer.Parse(txtMonto.Text)
                        txtVuelto.Text = intVuelto

                        'Guardo la información para las boletas (una venta, puede incluir más de una entrada)

                        Me.BOLETASTableAdapter.InsertBoletas(strFechaVenta, "VIGENTE")
                        intUltimaBoleta = Me.BOLETASTableAdapter.SelectUltimaBoleta()
                        Me.PAGOEFECTIVOTableAdapter.InsertPagoEfectivo(intUltimaBoleta, strRUNUsuario, strFechaVenta, Integer.Parse(txtMonto.Text), Integer.Parse(txtMontoEfectivo.Text), Integer.Parse(txtVuelto.Text), Double.Parse(txtMonto.Text) * 0.01)
                        'Guardo la información de las entradas vendidas
                        For intI = 1 To intAuxFor
                            'Inserción en la tabla VENTAENTRADAS según la jornada para agregar la nota correspondiente
                            If strJornada = "Matiné" Then
                                Me.VENTAENTRADASTableAdapter.InsertarVenta(strRUNUsuario, strNombreEvento, strFechaVenta, strFechaEvento, strTipoEntrada, dbEntradaGeneral, strFormaPago, intUltimaBoleta)
                            ElseIf strJornada = "Tarde" Then
                                Me.VENTAENTRADASTableAdapter.InsertarVenta(strRUNUsuario, strNombreEvento, strFechaVenta, strFechaEvento, strTipoEntrada, dbEntradaGeneral, strFormaPago, intUltimaBoleta)
                            ElseIf strJornada = "Noche" Then
                                Me.VENTAENTRADASTableAdapter.InsertarVenta(strRUNUsuario, strNombreEvento, strFechaVenta, strFechaEvento, strTipoEntrada, dbEntradaGeneral, strFormaPago, intUltimaBoleta)
                            End If
                            'Obtención del último registro del campo numeroventa
                            intUltimaVenta = Me.VENTAENTRADASTableAdapter.SelectUltimoRegistro()
                            'intUltimaVenta = intUltimaVenta + 1
                            Me.VentasjornadasTableAdapter1.InsertVentasJornadas(intUltimaVenta, intJornada, intUltimaBoleta)
                            Me.VentasubicacionesTableAdapter1.InsertVentasUbicaciones(intUltimaVenta, strUbicacion, intUltimaBoleta)
                            If txtRUNBuscar.Text <> "" And txtGuionBuscar.Text <> "" Then
                                Me.ComprasclientesTableAdapter1.Insert(strRUNBuscar, intUltimaVenta)
                            End If
                        Next
                        ActualizacionEstadoEntradas()
                        MsgBox("Venta realizada satisfactoriamente", MsgBoxStyle.Information)
                        If txtGuionBuscar.Text <> "" And txtRUNBuscar.Text <> "" Then
                            'Verifico que el cliente no haya recibido ningún premio antes o ningún premio actualmente.
                            If Me.ClientesTableAdapter1.SelectPremiado(strRUNBuscar) <> 0 And blnPremiado = True Then
                                'Hago el registro que el cliente fue premiado por más de 100 compras y menos de 200
                                If Me.ComprasclientesTableAdapter1.ContarCompras(strRUNBuscar) >= 100 And Me.ComprasclientesTableAdapter1.ContarCompras(strRUNBuscar) < 200 Then
                                    Me.ClientesTableAdapter1.UpdatePremiado(11, strRUNBuscar)
                                    'Hago el registro que el cliente fue premiado por más de 200 compras y menos de 300
                                ElseIf Me.ComprasclientesTableAdapter1.ContarCompras(strRUNBuscar) >= 200 And Me.ComprasclientesTableAdapter1.ContarCompras(strRUNBuscar) < 300 Then
                                    Me.ClientesTableAdapter1.UpdatePremiado(22, strRUNBuscar)
                                    'Hago el registro que el cliente fue premiado por más de 300 compras
                                ElseIf Me.ComprasclientesTableAdapter1.ContarCompras(strRUNBuscar) >= 300 Then
                                    Me.ClientesTableAdapter1.UpdatePremiado(33, strRUNBuscar)
                                End If
                            End If
                        End If
                        Me.groInfoEvento.Enabled = True
                        lblDisponibilidad.Visible = False
                        Me.txtEntradaGeneral.Clear()
                        Me.cmbTipoEntrada.Text = ""
                        Me.cmbNombreEvento.Text = ""
                        Me.chkMatine.Checked = False
                        Me.chkTarde.Checked = False
                        Me.chkNoche.Checked = False
                        blnPremiado = False
                        txtRUNBuscar.Clear()
                        txtGuionBuscar.Clear()
                        Me.cmbUbicacion.Text = ""
                        Me.nupCantidad.Value = 0
                        Me.txtMonto.Clear()
                        Me.txtMontoEfectivo.Clear()
                        Me.txtVuelto.Clear()
                        Me.cmbFechasEvento.Text = ""
                        Me.cmbFechasEvento.DataSource = Nothing
                        Me.GroPagoEfectivo.Enabled = False
                        Me.groJornadas.Enabled = False
                        Me.groTipoPago.Enabled = False
                        Me.groUbicaciones.Enabled = False
                        Me.rdbEfectivo.Checked = False
                        Me.rdbTarBancaria.Checked = False
                        Me.ErrorProviderVentaEntradas.Clear()
                        frmEntradas.ShowDialog()
                        Try
                            Dim Sentencia As String = "SELECT DISTINCT NOMBREEVENTO FROM EVENTOS WHERE FECHAEVENTO >= '" & Date.Now.Date & "';"
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
                            cmbNombreEvento.Focus()
                            'Timer1.Enabled = True
                            'Timer1.Interval = 1
                            'Timer1.Start()
                        Catch ex As Exception
                            MsgBox("Se ha producido el siguiente error: " & ex.Message, MsgBoxStyle.Critical)
                        End Try
                    Else
                        MsgBox("El monto efectivo debe ser mayor o igual que el monto a pagar", MsgBoxStyle.Information)
                    End If

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
            'Scope.Complete()
        Catch ex As Exception
            MsgBox("Se produjo el siguiente error: " & ex.Message, MsgBoxStyle.Critical, "Teatro")
        End Try
        'End Using
    End Sub
    'Hasta aquí llegan las operaciones del botón para pagar en efectivo
    '********************************************************************************************************


    '********************************************************************************************************
    'Operaciones que realizo cuando hace click en el botón para pagar con tarjeta de crédito
    Private Sub btnPagarTarjeBanca_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPagarTarjeBanca.Click
        'Using Scope2 As New TransactionScope()
        drResultado = MsgBox("¿Desea continuar con el pago Tarjeta bancaria?", MsgBoxStyle.YesNo + MsgBoxStyle.Question)
        If drResultado = vbYes Then
            If txtNumeroCuenta.TextLength = 0 Then
                ErrorProviderVentaEntradas.SetError(txtNumeroCuenta, "Debe ingresar el numero de cuenta")
                ErrorProviderVentaEntradas.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
                txtNumeroCuenta.Focus()
                Exit Sub
            Else
                ErrorProviderVentaEntradas.SetError(txtNumeroCuenta, "")
            End If
            If cmbTipoTarjeta.Text = "" Then
                ErrorProviderVentaEntradas.SetError(cmbTipoTarjeta, "Debe seleccionar el tipo tarjeta")
                ErrorProviderVentaEntradas.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
                cmbTipoTarjeta.Focus()
                Exit Sub
            Else
                ErrorProviderVentaEntradas.SetError(cmbTipoTarjeta, "")
            End If
            If Me.rdbCuotasFijas.Checked = False And rdbSincuotas.Checked = False Then
                ErrorProviderVentaEntradas.SetError(rdbSincuotas, "Debe seleccionar al menos una opción   ")
                ErrorProviderVentaEntradas.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
                Exit Sub
            Else
                ErrorProviderVentaEntradas.SetError(rdbSincuotas, "")
            End If
            If cmbCantidadCuotas.Text = "" And cmbCantidadCuotas.Enabled = True Then
                ErrorProviderVentaEntradas.SetError(cmbCantidadCuotas, "Debe seleccionar la cantidad de cuotas")
                ErrorProviderVentaEntradas.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
                cmbCantidadCuotas.Focus()
                Exit Sub
            Else
                ErrorProviderVentaEntradas.SetError(cmbCantidadCuotas, "")
            End If
            Try
                strTipoEntrada = cmbTipoEntrada.SelectedItem
                strFechaEvento = cmbFechasEvento.Text
                strFechaVenta = txtFechaVenta.Text
                dbEntradaGeneral = Double.Parse(txtEntradaGeneral.Text)
                strFormaPago = "Tarjeta bancaria"
                intEntradasVendidas = nupCantidad.Value
                If chkMatine.Checked = True Then
                    strJornada = "Matiné"
                ElseIf chkTarde.Checked = True Then
                    strJornada = "Tarde"
                ElseIf chkNoche.Checked = True Then
                    strJornada = "Noche"
                End If

                Dim entrada As New ClassEntrada
                'rdbSincuotas.Checked = False 'Inicializar propiedad checked en false
                Dim intValidaTarjeCredit As Integer 'Declaración de variable que obtendrá 
                Dim strTipoTarjeta As String 'Declaración de variable
                Dim intCantidadCuotas As Integer

                'la validez del número de cuenta de la tarjeta de crédito
                intValidaTarjeCredit = entrada.Validate(txtNumeroCuenta.Text) 'Se obtiene valor de la función que valida la tarjeta crédito
                strTipoTarjeta = cmbTipoTarjeta.SelectedItem 'Se guarda el tipo de tarjeta seleccionada
                If rdbSincuotas.Checked = True Then
                    intCantidadCuotas = 0
                ElseIf rdbCuotasFijas.Checked = True Then
                    intCantidadCuotas = Integer.Parse(cmbCantidadCuotas.SelectedItem)
                End If
                'Guardo la información para las boletas (una venta, puede incluir más de una entrada)
                Me.BOLETASTableAdapter.InsertBoletas(strFechaVenta, "VIGENTE")
                intUltimaBoleta = Me.BOLETASTableAdapter.SelectUltimaBoleta()
                Me.PAGOTARJETACREDITOTableAdapter.InsertPagoTarjetaCredito(intUltimaBoleta, strRUNUsuario, txtFechaVenta.Text, strTipoTarjeta, intCantidadCuotas, Integer.Parse(txtMontoTarjeta.Text), Double.Parse(txtMontoTarjeta.Text) * 0.005)
                If intValidaTarjeCredit = 0 Then
                    'Guardo la información de las entradas vendidas según la jornada para agregar la nota correspondiente
                    For intI = 1 To intAuxFor
                        If strJornada = "Matiné" Then
                            Me.VENTAENTRADASTableAdapter.InsertarVenta(strRUNUsuario, strNombreEvento, strFechaVenta, strFechaEvento, strTipoEntrada, dbEntradaGeneral, strFormaPago, intUltimaBoleta)
                        ElseIf strJornada = "Tarde" Then
                            Me.VENTAENTRADASTableAdapter.InsertarVenta(strRUNUsuario, strNombreEvento, strFechaVenta, strFechaEvento, strTipoEntrada, dbEntradaGeneral, strFormaPago, intUltimaBoleta)
                        ElseIf strJornada = "Noche" Then
                            Me.VENTAENTRADASTableAdapter.InsertarVenta(strRUNUsuario, strNombreEvento, strFechaVenta, strFechaEvento, strTipoEntrada, dbEntradaGeneral, strFormaPago, intUltimaBoleta)
                        End If
                        intUltimaVenta = Me.VENTAENTRADASTableAdapter.SelectUltimoRegistro() 'Se obtiene el numeroventa del ultimo registro
                        Me.VentasjornadasTableAdapter1.InsertVentasJornadas(intUltimaVenta, intJornada, intUltimaBoleta)
                        Me.VentasubicacionesTableAdapter1.InsertVentasUbicaciones(intUltimaVenta, strUbicacion, intUltimaBoleta)
                        If txtRUNBuscar.Text <> "" And txtGuionBuscar.Text <> "" Then
                            Me.ComprasclientesTableAdapter1.Insert(strRUNBuscar, intUltimaVenta)
                        End If
                    Next
                    ActualizacionEstadoEntradas()
                    MsgBox("Venta realizada satisfactoriamente", MsgBoxStyle.Information)
                    If txtGuionBuscar.Text <> "" And txtRUNBuscar.Text <> "" Then
                        'Verifico que el cliente no haya recibido ningún premio antes o ningún premio actualmente.
                        If Me.ClientesTableAdapter1.SelectPremiado(strRUNBuscar) <> 0 And blnPremiado = True Then
                            'Hago el registro que el cliente fue premiado por más de 100 compras y menos de 200
                            If Me.ComprasclientesTableAdapter1.ContarCompras(strRUNBuscar) >= 100 And Me.ComprasclientesTableAdapter1.ContarCompras(strRUNBuscar) < 200 Then
                                Me.ClientesTableAdapter1.UpdatePremiado(11, strRUNBuscar)
                                'Hago el registro que el cliente fue premiado por más de 200 compras y menos de 300
                            ElseIf Me.ComprasclientesTableAdapter1.ContarCompras(strRUNBuscar) >= 200 And Me.ComprasclientesTableAdapter1.ContarCompras(strRUNBuscar) < 300 Then
                                Me.ClientesTableAdapter1.UpdatePremiado(22, strRUNBuscar)
                                'Hago el registro que el cliente fue premiado por más de 300 compras
                            ElseIf Me.ComprasclientesTableAdapter1.ContarCompras(strRUNBuscar) >= 300 Then
                                Me.ClientesTableAdapter1.UpdatePremiado(33, strRUNBuscar)
                            End If
                        End If
                    End If
                    Me.groInfoEvento.Enabled = True
                    lblDisponibilidad.Visible = False
                    Me.txtEntradaGeneral.Clear()
                    Me.cmbTipoEntrada.Text = ""
                    Me.cmbNombreEvento.Text = ""
                    Me.chkMatine.Checked = False
                    Me.chkTarde.Checked = False
                    Me.chkNoche.Checked = False
                    blnPremiado = False
                    txtRUNBuscar.Clear()
                    txtGuionBuscar.Clear()
                    Me.cmbUbicacion.Text = ""
                    Me.nupCantidad.Value = 0
                    Me.txtMontoTarjeta.Clear()
                    Me.txtNumeroCuenta.Clear()
                    Me.rdbSincuotas.Checked = False
                    Me.rdbCuotasFijas.Checked = False
                    Me.cmbCantidadCuotas.Text = ""
                    Me.cmbTipoTarjeta.Text = ""
                    Me.cmbFechasEvento.Text = ""
                    Me.cmbFechasEvento.DataSource = Nothing
                    Me.groTarjetaBancaria.Enabled = False
                    Me.groJornadas.Enabled = False
                    Me.groTipoPago.Enabled = False
                    Me.groUbicaciones.Enabled = False
                    Me.rdbEfectivo.Checked = False
                    Me.rdbTarBancaria.Checked = False
                    frmEntradas.ShowDialog()
                Else
                    MsgBox("Numero de cuenta incorrecto ", MsgBoxStyle.Critical)
                    Exit Sub
                End If
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            End Try
            Try
                Dim Sentencia As String = "SELECT DISTINCT NOMBREEVENTO FROM EVENTOS WHERE FECHAEVENTO >= '" & Date.Now.Date & "';"
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
                cmbNombreEvento.Focus()
                'Timer1.Enabled = True
                'Timer1.Interval = 1
                'Timer1.Start()
                'Scope2.Complete()
            Catch ex As Exception
                MsgBox("Se ha producido el siguiente error: " & ex.Message, MsgBoxStyle.Critical)
            End Try
        End If
        'End Using
    End Sub
    'Hasta aquí llegan las operaciones del evento click del botón para pagar con tarjeta de crédito
    '********************************************************************************************************


    '********************************************************************************************************
    'Validaciones que realizo en los textbox cuando se apreta una tecla. Por ejemplo que no ingrese letras en un
    'textbox que debe ingresar números. También que no modifique lo que hay en un combobox
    Private Sub txtMontoEfectivo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMontoEfectivo.KeyPress
        If (Asc(e.KeyChar)) >= 48 And (Asc(e.KeyChar)) <= 57 Or (Asc(e.KeyChar)) = System.Windows.Forms.Keys.Back Or Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    '  Aquí impido que el usuario modifique el contenido del combobox
    Private Sub cmbTipoEntrada_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbTipoEntrada.KeyPress
        e.Handled = True
    End Sub
    'Aquí impido que el usuario modifique el contenido del combobox
    Private Sub cmbNombreEvento_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbNombreEvento.KeyPress
        e.Handled = True
    End Sub
    Private Sub cmbFechasEvento_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbFechasEvento.KeyPress
        e.Handled = True
    End Sub
    Private Sub cmbUbicacion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbUbicacion.KeyPress
        e.Handled = True
    End Sub
    Private Sub cmbCantidadCuotas_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbCantidadCuotas.KeyPress
        e.Handled = True
    End Sub
    Private Sub cmbTipoTarjeta_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbTipoTarjeta.KeyPress
        e.Handled = True
    End Sub
    Private Sub cmbDia_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbDia.KeyPress
        e.Handled = True
    End Sub

    Private Sub cmbMes_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbMes.KeyPress
        e.Handled = True
    End Sub

    Private Sub cmbAño_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbAño.KeyPress
        e.Handled = True
    End Sub
    Private Sub txtMontoTarjeta_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMontoTarjeta.KeyPress
        If (Asc(e.KeyChar)) >= 48 And (Asc(e.KeyChar)) <= 57 Or (Asc(e.KeyChar)) = System.Windows.Forms.Keys.Back Or Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub txtNumeroCuenta_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNumeroCuenta.KeyPress
        If (Asc(e.KeyChar)) >= 48 And (Asc(e.KeyChar)) <= 57 Or (Asc(e.KeyChar)) = System.Windows.Forms.Keys.Back Or Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub txtTelefonoUsuario_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTelefonoUsuario.KeyPress
        If (Asc(e.KeyChar)) >= 48 And (Asc(e.KeyChar)) <= 57 Or (Asc(e.KeyChar)) = System.Windows.Forms.Keys.Back Or Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub txtRUNUsuario_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRUNUsuario.KeyPress
        If (Asc(e.KeyChar)) >= 48 And (Asc(e.KeyChar)) <= 57 Or (Asc(e.KeyChar)) = System.Windows.Forms.Keys.Back Or Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtRUNBuscar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRUNBuscar.KeyPress
        If (Asc(e.KeyChar)) >= 48 And (Asc(e.KeyChar)) <= 57 Or (Asc(e.KeyChar)) = System.Windows.Forms.Keys.Back Or Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    'Hasta aquí llegan las validaciones de KeyPress



    Private Sub rdbSincuotas_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdbSincuotas.Click
        If rdbSincuotas.Checked = True Then
            cmbCantidadCuotas.Enabled = False
        End If

    End Sub
    '***********************************************************************************************************
    'Aquí muestro la disponibilidad de entradas de la ubicación seleccionada
    Private Sub cmbUbicacion_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbUbicacion.SelectedIndexChanged
        Try
       
            If cmbUbicacion.SelectedItem = "Balcones" And chkMatine.Checked = True Then
                lblDisponibilidad.Text = Me.EstadoentradasTableAdapter1.SelectEstadoBalcones(intIDEvento, strFechaEvento, chkMatine.Text)
                Exit Sub
            ElseIf cmbUbicacion.SelectedItem = "Platea numerada" And chkMatine.Checked = True Then
                lblDisponibilidad.Text = Me.EstadoentradasTableAdapter1.SelectEstadoPlateaNumerada(intIDEvento, strFechaEvento, chkMatine.Text)
                Exit Sub
            ElseIf cmbUbicacion.SelectedItem = "Platea" And chkMatine.Checked = True Then
                lblDisponibilidad.Text = Me.EstadoentradasTableAdapter1.SelectEstadoPlatea(intIDEvento, strFechaEvento, chkMatine.Text)
                Exit Sub
            End If

            If cmbUbicacion.SelectedItem = "Balcones" And chkTarde.Checked = True Then
                lblDisponibilidad.Text = Me.EstadoentradasTableAdapter1.SelectEstadoBalcones(intIDEvento, strFechaEvento, chkTarde.Text)
                Exit Sub
            ElseIf cmbUbicacion.SelectedItem = "Platea numerada" And chkTarde.Checked = True Then
                lblDisponibilidad.Text = Me.EstadoentradasTableAdapter1.SelectEstadoPlateaNumerada(intIDEvento, strFechaEvento, chkTarde.Text)
                Exit Sub
            ElseIf cmbUbicacion.SelectedItem = "Platea" And chkTarde.Checked = True Then
                lblDisponibilidad.Text = Me.EstadoentradasTableAdapter1.SelectEstadoPlatea(intIDEvento, strFechaEvento, chkTarde.Text)
                Exit Sub
            End If

            If cmbUbicacion.SelectedItem = "Balcones" And chkNoche.Checked = True Then
                lblDisponibilidad.Text = Me.EstadoentradasTableAdapter1.SelectEstadoBalcones(intIDEvento, strFechaEvento, chkNoche.Text)
                Exit Sub
            ElseIf cmbUbicacion.SelectedItem = "Platea numerada" And chkNoche.Checked = True Then
                lblDisponibilidad.Text = Me.EstadoentradasTableAdapter1.SelectEstadoPlateaNumerada(intIDEvento, strFechaEvento, chkNoche.Text)
                Exit Sub
            ElseIf cmbUbicacion.SelectedItem = "Platea" And chkNoche.Checked = True Then
                lblDisponibilidad.Text = Me.EstadoentradasTableAdapter1.SelectEstadoPlatea(intIDEvento, strFechaEvento, chkNoche.Text)
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox("Se produjo el siguiente error: " & ex.Message, MsgBoxStyle.Critical, "Teatro")
        End Try

    End Sub

    '***********************************************************************************************************
    'Aquí también muestro la disponibilidad de entradas según la ubicación seleccionada, pero cuando 
    'el control recupera el focus
    Private Sub cmbUbicacion_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbUbicacion.GotFocus
        Try
       
            lblDisponibilidad.Visible = True
            If cmbUbicacion.SelectedItem = "Balcones" And chkMatine.Checked = True Then
                lblDisponibilidad.Text = Me.EstadoentradasTableAdapter1.SelectEstadoBalcones(intIDEvento, strFechaEvento, chkMatine.Text)
                Exit Sub
            ElseIf cmbUbicacion.SelectedItem = "Platea numerada" And chkMatine.Checked = True Then
                lblDisponibilidad.Text = Me.EstadoentradasTableAdapter1.SelectEstadoPlateaNumerada(intIDEvento, strFechaEvento, chkMatine.Text)
                Exit Sub
            ElseIf cmbUbicacion.SelectedItem = "Platea" And chkMatine.Checked = True Then
                lblDisponibilidad.Text = Me.EstadoentradasTableAdapter1.SelectEstadoPlatea(intIDEvento, strFechaEvento, chkMatine.Text)
                Exit Sub
            End If

            If cmbUbicacion.SelectedItem = "Balcones" And chkTarde.Checked = True Then
                lblDisponibilidad.Text = Me.EstadoentradasTableAdapter1.SelectEstadoBalcones(intIDEvento, strFechaEvento, chkTarde.Text)
                Exit Sub
            ElseIf cmbUbicacion.SelectedItem = "Platea numerada" And chkTarde.Checked = True Then
                lblDisponibilidad.Text = Me.EstadoentradasTableAdapter1.SelectEstadoPlateaNumerada(intIDEvento, strFechaEvento, chkTarde.Text)
                Exit Sub
            ElseIf cmbUbicacion.SelectedItem = "Platea" And chkTarde.Checked = True Then
                lblDisponibilidad.Text = Me.EstadoentradasTableAdapter1.SelectEstadoPlatea(intIDEvento, strFechaEvento, chkTarde.Text)
                Exit Sub
            End If

            If cmbUbicacion.SelectedItem = "Balcones" And chkNoche.Checked = True Then
                lblDisponibilidad.Text = Me.EstadoentradasTableAdapter1.SelectEstadoBalcones(intIDEvento, strFechaEvento, chkNoche.Text)
                Exit Sub
            ElseIf cmbUbicacion.SelectedItem = "Platea numerada" And chkNoche.Checked = True Then
                lblDisponibilidad.Text = Me.EstadoentradasTableAdapter1.SelectEstadoPlateaNumerada(intIDEvento, strFechaEvento, chkNoche.Text)
                Exit Sub
            ElseIf cmbUbicacion.SelectedItem = "Platea" And chkNoche.Checked = True Then
                lblDisponibilidad.Text = Me.EstadoentradasTableAdapter1.SelectEstadoPlatea(intIDEvento, strFechaEvento, chkNoche.Text)
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox("Se produjo el siguiente error: " & ex.Message, MsgBoxStyle.Critical, "Teatro")
        End Try
    End Sub
    'Operaciones cuando apreto el botón buscar cliente
    Private Sub btnBuscarCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarCliente.Click
        Me.txtGuionBuscar.Enabled = True
        Me.txtRUNBuscar.Enabled = True
        Me.lblRUNBuscar.Enabled = True

    End Sub

    Private Sub btnOcultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOcultar.Click
        Me.Size = Me.MinimumSize
    End Sub
    'Aquí registro un nuevo cliente
    Private Sub btnRegistrarCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegistrarCliente.Click
        Dim ca As String
        Dim dtFecha As Date
        Dim strRUNCliente
        Try
            ca = VerificaRut(txtRUNUsuario.Text, txtGuion.Text)
            'Validación del campo RUN
            If ca = True Then
            ElseIf ca = False And txtGuion.Text <> "" And txtRUNUsuario.Text <> "" Then
                ErrorProviderVentaEntradas.Clear()
                ErrorProviderVentaEntradas.SetError(txtGuion, "El R.U.N. está incorrecto")
                txtRUNUsuario.Focus()
                Exit Sub
            End If
            If ca = True Then
                ErrorProviderVentaEntradas.SetError(txtGuion, "")
            End If
            '*********************************************************************************************************************************************************************************
            'Validación de campos nulos
            'Campo run
            If txtRUNUsuario.TextLength = 0 Then
                ErrorProviderVentaEntradas.SetError(txtRUNUsuario, "Campo obligatorio")
                ErrorProviderVentaEntradas.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
                Exit Sub
            Else
                ErrorProviderVentaEntradas.SetError(txtRUNUsuario, "")
            End If
            'Campo guion
            If txtGuion.TextLength = 0 Then
                ErrorProviderVentaEntradas.SetError(txtGuion, "Campo obligatorio")
                ErrorProviderVentaEntradas.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
                Exit Sub
            Else
                ErrorProviderVentaEntradas.SetError(txtGuion, "")
            End If
            'Campo nombres
            If txtNombresUsuario.TextLength = 0 Then
                ErrorProviderVentaEntradas.SetError(txtNombresUsuario, "Campo obligatorio")
                ErrorProviderVentaEntradas.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
                Exit Sub
            Else
                ErrorProviderVentaEntradas.SetError(txtNombresUsuario, "")
            End If
            'Campo apellidos
            If txtApellidosUsuario.TextLength = 0 Then
                ErrorProviderVentaEntradas.SetError(txtApellidosUsuario, "Campo obligatorio")
                ErrorProviderVentaEntradas.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
                Exit Sub
            Else
                ErrorProviderVentaEntradas.SetError(txtApellidosUsuario, "")
            End If
            'Campo día
            If cmbDia.Text = "" Then
                ErrorProviderVentaEntradas.SetError(cmbDia, "Campo obligatorio")
                Exit Sub
            Else
                ErrorProviderVentaEntradas.SetError(cmbDia, "")
            End If
            'Campo mes
            If cmbMes.Text = "" Then
                ErrorProviderVentaEntradas.SetError(cmbMes, "Campo obligatorio")
                Exit Sub
            Else
                ErrorProviderVentaEntradas.SetError(cmbMes, "")
            End If
            'Campo año
            If cmbAño.Text = "" Then
                ErrorProviderVentaEntradas.SetError(cmbAño, "Campo obligatorio")
                Exit Sub
            Else
                ErrorProviderVentaEntradas.SetError(cmbAño, "")
            End If
            'Campo dirección
            If txtDireccionUsuario.TextLength = 0 Then
                ErrorProviderVentaEntradas.SetError(txtDireccionUsuario, "Campo obligatorio")
                ErrorProviderVentaEntradas.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
                Exit Sub
            Else
                ErrorProviderVentaEntradas.SetError(txtDireccionUsuario, "")
            End If
            'Campo teléfono
            If txtTelefonoUsuario.TextLength = 0 Then
                ErrorProviderVentaEntradas.SetError(txtTelefonoUsuario, "Campo obligatorio")
                ErrorProviderVentaEntradas.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
                Exit Sub
            Else
                ErrorProviderVentaEntradas.SetError(txtTelefonoUsuario, "")
            End If

            'Validación ingreso sólo letras en el campo nombres y apellidos
            ValidaSoloLetras(ErrorProviderVentaEntradas, txtNombresUsuario)
            ValidaSoloLetras(ErrorProviderVentaEntradas, txtApellidosUsuario)

            '*********************************************************************************************************************************************************************************
            'Validación de la cantidad de días de los meses
            If cmbMes.GetItemText(cmbMes.SelectedItem) = "junio" Or cmbMes.GetItemText(cmbMes.SelectedItem) = "abril" Or _
           cmbMes.GetItemText(cmbMes.SelectedItem) = "septiembre" Or cmbMes.GetItemText(cmbMes.SelectedItem) = "noviembre" Then
                If Integer.Parse(cmbDia.SelectedItem) > 30 Then
                    ErrorProviderVentaEntradas.SetError(cmbDia, "El mes seleccionado tiene sólo 30 días")
                    ErrorProviderVentaEntradas.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
                    cmbDia.Focus()
                    Exit Sub
                Else
                    ErrorProviderVentaEntradas.SetError(cmbDia, "")
                End If
            ElseIf cmbMes.GetItemText(cmbMes.SelectedItem) = "febrero" Then
                If Integer.Parse(cmbDia.SelectedItem) > 28 Then
                    ErrorProviderVentaEntradas.SetError(cmbDia, "El mes seleccionado tiene sólo 28 días")
                    ErrorProviderVentaEntradas.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
                    cmbDia.Focus()
                    Exit Sub
                Else
                    ErrorProviderVentaEntradas.SetError(cmbDia, "")
                End If
            End If
            dtFecha = Trim(cmbDia.Text) & "/" & Trim(Str(cmbMes.SelectedIndex + 1)) & "/" & Trim(cmbAño.Text)
            ca = VerificaRut(txtRUNUsuario.Text, txtGuion.Text)
            strRUNCliente = txtRUNUsuario.Text & "-" & txtGuion.Text
            Me.ClientesTableAdapter1.InsertarClientes(strRUNCliente, txtNombresUsuario.Text, txtApellidosUsuario.Text, dtFecha, txtDireccionUsuario.Text, Integer.Parse(txtTelefonoUsuario.Text), "1234567", 4, 0)
            'Me.RegistraclienteTableAdapter1.InsertarRegistroCliente(strRUNUsuario, strRUNCliente, Date.Now.Date)
            MsgBox("Registro correcto", MsgBoxStyle.Information, "Registro usuario")
            Me.Size = Me.MinimumSize
            txtRUNUsuario.Clear()
            txtGuion.Clear()
            txtNombresUsuario.Clear()
            txtApellidosUsuario.Clear()
            txtDireccionUsuario.Clear()
            txtTelefonoUsuario.Clear()
            cmbDia.Text = ""
            cmbMes.Text = ""
            cmbAño.Text = ""
            blnMasDe50 = False
        Catch ex As SqlException
            MsgBox("El cliente que está intentando ingresar, ya está registrado en el sistema", MsgBoxStyle.Critical, "Registro cliente")
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, "Registro cliente")

        End Try
    End Sub

    '*********************************************************************************************************************************************************************************
    'Busco un si el cliente está registrado y si no pregunto si se desea registrar
    Private Sub txtGuionBuscar_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtGuionBuscar.TextChanged
        Dim ca As String
        Dim drResultado As DialogResult
        strRUNBuscar = txtRUNBuscar.Text & "-" & Me.txtGuionBuscar.Text
        Conexion.Close()
        'If CamposNulos(Me.ErrorProviderVentaEntradas, txtRUNBuscar) = True Then
        '    Exit Sub
        'ElseIf CamposNulos(Me.ErrorProviderVentaEntradas, txtGuionBuscar) = True Then
        '    Exit Sub
        'End If
        ca = VerificaRut(txtRUNBuscar.Text, txtGuionBuscar.Text)
        If ca = True Then
        ElseIf ca = False Then
            Me.ErrorProviderVentaEntradas.Clear()
            ErrorProviderVentaEntradas.SetError(txtGuionBuscar, "El R.U.N. está incorrecto")
            txtRUNBuscar.Focus()
            Exit Sub
        End If
        If ca = True Then
            ErrorProviderVentaEntradas.SetError(txtGuionBuscar, "")
        End If
        If BuscarRUN(strRUNBuscar) = True Then
            MsgBox("El cliente fue encontrado", MsgBoxStyle.Information, "Venta entradas")
            Me.txtGuionBuscar.Enabled = False
            Me.txtRUNBuscar.Enabled = False
            blnMasDe50 = False
        Else
            drResultado = MsgBox("El cliente no está registrado, ¿Desea registrarlo?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Venta entradas")
            If drResultado = vbYes Then
                Me.txtGuionBuscar.Enabled = False
                Me.txtRUNBuscar.Enabled = False
                Me.Size = Me.MaximumSize
                txtRUNUsuario.Text = txtRUNBuscar.Text
                txtGuion.Text = txtGuionBuscar.Text
                Me.txtRUNUsuario.Focus()
                Me.Size = Me.MaximumSize
                Dim i As Integer
                cmbDia.Text = ""
                For i = 1 To 31
                    cmbDia.Items.Add(i)
                Next
                'Llenado de los meses del año
                For i = 1 To 12
                    cmbMes.Items.Add(MonthName(i, False))
                Next
                'Llenado del año 1940 hasta el año actual
                For i = 1940 To Year(Now)
                    cmbAño.Items.Add(i)
                Next
                Conexion.Close()
                If BuscarRUNVendedor(strRUNBuscar) = True Then
                    Try
                        Conexion.Open()
                        Dim Sentencia As String = "SELECT NOMBREVENDEDOR, APELLIDOVENDEDOR, FECHANACVENDEDOR,DIRECCIONVENDEDOR,TELEFONOVENDEDOR,CONTRASENAVENDEDOR FROM VENDEDORES WHERE RUNVENDEDOR ='" & strRUNBuscar & "'"
                        Dim SQL As New SqlCommand(Sentencia, Conexion)
                        Dim DR As SqlDataReader
                        DR = SQL.ExecuteReader
                        DR.Read()
                        'se llenan los controles con el data reader
                        txtNombresUsuario.Text = DR("NOMBREVENDEDOR")
                        Me.txtApellidosUsuario.Text = DR("APELLIDOVENDEDOR")
                        Me.txtDireccionUsuario.Text = DR("DIRECCIONVENDEDOR")
                        Me.txtTelefonoUsuario.Text = DR("TELEFONOVENDEDOR")
                        'strContraseña = DR("CONTRASENAVENDEDOR")
                        'strConfirmaContraseña = DR("CONTRASENAVENDEDOR")
                        'Asigno la fecha a variable tipo date
                        dtFechaNac = DR("FECHANACVENDEDOR")
                        'dtFechaNac = Trim(cmbDia.Text) & "/" & Trim(Str(cmbMes.SelectedIndex + 1)) & "/" & Trim(cmbAño.Text)
                        'Descompongo la fecha en dia, mes y año
                        strDia = Format(CDate(dtFechaNac), "dd")
                        strMes = Format(Month(dtFechaNac), "")
                        strAño = Format(Year(dtFechaNac), "")
                        'blnNoValidarEdad = True
                        cmbAño.Text = strAño
                        cmbDia.Text = strDia
                        cmbMes.SelectedIndex = strMes - 1
                        DR.Close()
                    Catch ex As Exception
                        MsgBox("Se ha producido el siguiente error: " & ex.Message, MsgBoxStyle.Critical)
                    Finally
                        Conexion.Close()
                    End Try
                ElseIf BuscarRUNProductor(strRUNBuscar) = True Then
                    Try
                        Conexion.Open()
                        Dim Sentencia As String = "SELECT RUNENCARGADO, NOMBREENCARGADO, APELLIDOENCARGADO, FECHANACENCARGADO, DIRECCIONENCARGADO, TELEFONOENCARGADO, CONTRASENAENCARGADO FROM PRODUCCION WHERE RUNENCARGADO='" & strRUNBuscar & "'"
                        Dim SQL As New SqlCommand(Sentencia, Conexion)
                        Dim DR As SqlDataReader
                        DR = SQL.ExecuteReader
                        DR.Read()
                        'se llenan los controles con el data reader
                        txtNombresUsuario.Text = DR("NOMBREENCARGADO")
                        Me.txtApellidosUsuario.Text = DR("APELLIDOENCARGADO")
                        Me.txtDireccionUsuario.Text = DR("DIRECCIONENCARGADO")
                        Me.txtTelefonoUsuario.Text = DR("TELEFONOENCARGADO")
                        'strContraseña = DR("CONTRASENAENCARGADO")
                        'strConfirmaContraseña = DR("CONTRASENAENCARGADO")
                        'Asigno la fecha a variable tipo date
                        dtFechaNac = DR("FECHANACENCARGADO")
                        'Descompongo la fecha en dia, mes y año
                        strDia = Format(CDate(dtFechaNac), "dd")
                        strMes = Format(Month(dtFechaNac), "")
                        strAño = Format(Year(dtFechaNac), "")
                        'blnNoValidarEdad = True
                        cmbAño.Text = strAño
                        cmbDia.Text = strDia
                        cmbMes.SelectedIndex = strMes - 1
                        DR.Close()
                    Catch ex As Exception
                        MsgBox("Se ha producido el siguiente error: " & ex.Message, MsgBoxStyle.Critical)
                    Finally
                        Conexion.Close()
                    End Try
                ElseIf BuscarRUNAdministrador(strRUNBuscar) = True Then
                    Try
                        Conexion.Open()
                        Dim Sentencia As String = "SELECT RUNADMINISTRADOR, NOMBREADMINISTRADOR, APELLIDOADMINISTRADOR, FECHANACADMINISTRADOR, DIRECCIONADMINISTRADOR, TELEFONOADMINISTRADOR, CONTRASENAADMINISTRADOR FROM ADMINISTRADORES WHERE RUNADMINISTRADOR = '" & strRUNBuscar & "'"
                        Dim SQL As New SqlCommand(Sentencia, Conexion)
                        Dim DR As SqlDataReader
                        DR = SQL.ExecuteReader
                        DR.Read()
                        'se llenan los controles con el data reader
                        txtNombresUsuario.Text = DR("NOMBREADMINISTRADOR")
                        Me.txtApellidosUsuario.Text = DR("APELLIDOADMINISTRADOR")
                        Me.txtDireccionUsuario.Text = DR("DIRECCIONADMINISTRADOR")
                        Me.txtTelefonoUsuario.Text = DR("TELEFONOADMINISTRADOR")
                        'strContraseña = DR("CONTRASENAADMINISTRADOR")
                        'strConfirmaContraseña = DR("CONTRASENAADMINISTRADOR")
                        ''Asigno la fecha a variable tipo date
                        dtFechaNac = DR("FECHANACADMINISTRADOR")
                        'Descompongo la fecha en dia, mes y año
                        strDia = Format(CDate(dtFechaNac), "dd")
                        strMes = Format(Month(dtFechaNac), "")
                        strAño = Format(Year(dtFechaNac), "")
                        'blnNoValidarEdad = True
                        cmbAño.Text = strAño
                        cmbDia.Text = strDia
                        cmbMes.SelectedIndex = strMes - 1
                        DR.Close()
                    Catch ex As Exception
                        MsgBox("Se ha producido el siguiente error: " & ex.Message, MsgBoxStyle.Critical)
                    Finally
                        Conexion.Close()
                    End Try
                End If
            Else
                txtRUNBuscar.Clear()
                txtGuionBuscar.Clear()
                blnMasDe50 = False
            End If
        End If
    End Sub
    '******************************************************************************************************************************
    'Aquí cuento las entradas que ha comprado el cliente y asigno los premios correspondientes
    Public Sub CompruebaPremios()
        Try
            If txtRUNBuscar.Text <> "" And txtGuionBuscar.Text <> "" Then
                If Me.ComprasclientesTableAdapter1.ContarCompras(strRUNBuscar) >= 100 And Me.ComprasclientesTableAdapter1.ContarCompras(strRUNBuscar) < 200 And Me.ClientesTableAdapter1.SelectPremiado(strRUNBuscar) = 1 Then
                    MsgBox("¡¡¡El cliente ha sido premiado!!! 20% Descuento en esta compra", MsgBoxStyle.Information, "Cliente premiado")
                    If rdbEfectivo.Checked = True Then
                        Me.txtMonto.Text = intTotalPagar - (intTotalPagar * 0.2)
                    ElseIf rdbTarBancaria.Checked = True Then
                        Me.txtMontoTarjeta.Text = intTotalPagar - (intTotalPagar * 0.2)
                    End If
                    blnPremiado = True
                    Exit Sub
                ElseIf Me.ComprasclientesTableAdapter1.ContarCompras(strRUNBuscar) >= 200 And Me.ComprasclientesTableAdapter1.ContarCompras(strRUNBuscar) < 300 And Me.ClientesTableAdapter1.SelectPremiado(strRUNBuscar) = 2 Then
                    MsgBox("¡¡¡El cliente ha sido premiado!!! 30% Descuento en la esta compra", MsgBoxStyle.Information, "Cliente premiado")
                    If rdbEfectivo.Checked = True Then
                        Me.txtMonto.Text = intTotalPagar - (intTotalPagar * 0.3)
                    ElseIf rdbTarBancaria.Checked = True Then
                        Me.txtMontoTarjeta.Text = intTotalPagar - (intTotalPagar * 0.3)
                    End If
                    blnPremiado = True
                    Exit Sub
                ElseIf Me.ComprasclientesTableAdapter1.ContarCompras(strRUNBuscar) >= 300 And Me.ClientesTableAdapter1.SelectPremiado(strRUNBuscar) = 3 Then
                    MsgBox("¡¡¡El cliente ha sido premiado!!! 2X1 en esta compra", MsgBoxStyle.Information, "Cliente premiado")
                    If rdbEfectivo.Checked = True Then
                        Me.txtMonto.Text = intTotalPagar - (intTotalPagar * 0.5)
                    ElseIf rdbTarBancaria.Checked = True Then
                        Me.txtMontoTarjeta.Text = intTotalPagar - (intTotalPagar * 0.5)
                    End If
                    blnPremiado = True
                    Exit Sub
                End If
            End If
        Catch ex As Exception
            MsgBox("Se produjo el siguiente error: " & ex.Message, MsgBoxStyle.Critical, "Teatro")
        End Try
    End Sub
    '******************************************************************************************************************************
    'Aquí asigno los premios al cliente. Para que no sea premiado otra vez con el mismo premio
    Public Sub AsignaPremios()
        Try
            If txtRUNBuscar.Text <> "" And txtGuionBuscar.Text <> "" Then
                If Me.ComprasclientesTableAdapter1.ContarCompras(strRUNBuscar) >= 100 And Me.ComprasclientesTableAdapter1.ContarCompras(strRUNBuscar) < 200 And Me.ClientesTableAdapter1.SelectPremiado(strRUNBuscar) <> 11 Then
                    Me.ClientesTableAdapter1.UpdatePremiado(1, strRUNBuscar)
                    Exit Sub
                ElseIf Me.ComprasclientesTableAdapter1.ContarCompras(strRUNBuscar) >= 200 And Me.ComprasclientesTableAdapter1.ContarCompras(strRUNBuscar) < 300 And Me.ClientesTableAdapter1.SelectPremiado(strRUNBuscar) <> 22 Then
                    Me.ClientesTableAdapter1.UpdatePremiado(2, strRUNBuscar)
                    Exit Sub
                ElseIf Me.ComprasclientesTableAdapter1.ContarCompras(strRUNBuscar) >= 300 And Me.ClientesTableAdapter1.SelectPremiado(strRUNBuscar) <> 33 Then
                    Me.ClientesTableAdapter1.UpdatePremiado(3, strRUNBuscar)
                    Exit Sub
                End If
            End If
        Catch ex As Exception
            MsgBox("Se produjo el siguiente error: " & ex.Message, MsgBoxStyle.Critical, "Teatro")
        End Try
    End Sub
    Public Sub LimpiaControles()
        Dim objCtrl1 As Object
        Dim objCtrl2 As Object
        Dim objCtrl3 As Object
        Dim objCtrl4 As Object
        Dim objCtrl5 As Object
        Try
            Me.ErrorProviderCantUbic.Clear()
            Me.ErrorProviderEfectivo.Clear()
            Me.ErrorProviderVentaEntradas.Clear()
            Me.cmbNombreEvento.DataSource = Nothing
            Me.cmbTipoEntrada.SelectedIndex = -1
            Me.cmbFechasEvento.DataSource = Nothing
            Me.cmbUbicacion.SelectedIndex = -1
            Me.nupCantidad.Value = 0
            Me.lblDisponible.Enabled = False
            Me.cmbTipoTarjeta.SelectedIndex = -1
            Me.cmbCantidadCuotas.SelectedIndex = -1
            Me.rdbCuotasFijas.Checked = False
            Me.rdbEfectivo.Checked = False
            Me.rdbTarBancaria.Checked = False
            Me.rdbSincuotas.Checked = False
            Me.txtNumeroCuenta.Clear()
            Me.txtMonto.Clear()
            Me.lblDisponibilidad.Text = ""
            For Each objCtrl1 In groInfoEvento.Controls
                If TypeOf objCtrl1 Is TextBox Then objCtrl1.Clear()
                Application.DoEvents()
            Next
            For Each objCtrl2 In groBuscarCliente.Controls
                If TypeOf objCtrl2 Is TextBox Then objCtrl2.Clear()
                Application.DoEvents()
            Next
            For Each objCtrl3 In groJornadas.Controls
                If TypeOf objCtrl3 Is CheckBox Then objCtrl3.checked = False
                Application.DoEvents()
            Next
            For Each objCtrl4 In GroPagoEfectivo.Controls
                If TypeOf objCtrl4 Is TextBox Then objCtrl4.CLEAR()
                Application.DoEvents()
            Next
            For Each objCtrl5 In groInfoPersonal.Controls
                If TypeOf objCtrl5 Is TextBox Then objCtrl5.Clear()
                Application.DoEvents()
            Next
            Me.cmbMes.SelectedIndex = -1
            Me.cmbAño.SelectedIndex = -1
            Me.cmbDia.SelectedIndex = -1
        Catch ex As Exception
            MsgBox("Se produjo el siguiente error: " & ex.Message, MsgBoxStyle.Critical, "Teatro")
        End Try
    End Sub
End Class