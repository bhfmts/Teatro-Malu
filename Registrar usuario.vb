Imports Teatro.Validaciones
Imports System.Data.SqlClient
Imports Teatro.ClassVendedor
Imports Teatro.ClassProductor
Imports Teatro.ClassAdministrador
Imports Teatro.ClassCliente
Imports Teatro.ClassConexion

Public Class frmRegistrarUsuario
    Dim ca As Boolean
    Dim dtFecha As Date
    Dim strRUNRegistrar As String
    Dim drResultado As DialogResult
    Dim strContrase�a As String
    Dim strConfirmaContrase�a As String
    Dim blnNoValidarEdad As Boolean
    Dim blnRegistroCorrecto As Boolean

    Private Sub frmRegistrarUsuario_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim drResultado As DialogResult = MsgBox("Aseg�rese de haber completado correctamente sus operaciones. �Est� seguro que desea cerrar? ", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Registro eventos")
        If drResultado = vbNo Then
            e.Cancel = True
        Else
            Me.Dispose()
        End If
    End Sub
    '************************************************************************************************************************
    'Validaci�n de super usuario
    Private Sub frmRegistrarVendedores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            If Me.AdministradoresTableAdapter1.SelectSuperAdministrador(strRUNUsuario) = "4741033-9" Then
                Me.rdbAdministrador.Enabled = True
            Else
                Me.rdbAdministrador.Enabled = False
            End If
            Cargar()
            Me.groTipoUsuario.Select()
        Catch ex As Exception
            MsgBox("Se produjo el siguiente error: " & ex.Message, MsgBoxStyle.Critical, "Teatro")
        End Try
    End Sub
    '************************************************************************************************************************
    'M�todo para cargar los combobox para seleccionar la fecha de nacimiento
    Private Sub Cargar()
        'Llenado de los d�as
        Dim i As Integer
        cmbDia.Text = ""
        For i = 1 To 31
            cmbDia.Items.Add(i)
        Next
        'Llenado de los meses del a�o
        For i = 1 To 12
            cmbMes.Items.Add(MonthName(i, False))
        Next
        'Llenado del a�o 1940 hasta el a�o actual
        For i = 1940 To Year(Now)
            cmbA�o.Items.Add(i)
        Next
    End Sub
    '*********************************************************************************************************************************************************************************
    'Operaciones que se realizan en el evento click del bot�n registrar
    Private Sub btnRegistrarUsuario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegistrarUsuario.Click
        ca = VerificaRut(txtRUNUsuario.Text, txtGuion.Text)
        'Validaci�n del campo RUN
        If ca = True Then
        ElseIf ca = False And txtGuion.Text <> "" And txtRUNUsuario.Text <> "" Then
            ErrorProviderUsuario.Clear()
            ErrorProviderUsuario.SetError(txtGuion, "El R.U.N. est� incorrecto")
            txtRUNUsuario.Focus()
            Exit Sub
        End If
        If ca = True Then
            ErrorProviderUsuario.SetError(txtGuion, "")
        End If

        '*********************************************************************************************************************************************************************************
        'Validaci�n de campos nulos
        'Groupbox Tipo usuario
        If Me.rbdVendedor.Checked = False And Me.rdbProductor.Checked = False And Me.rdbAdministrador.Checked = False And Me.rdbCliente.Checked = False Then
            ErrorProviderUsuario.SetError(groTipoUsuario, "Campo obligatorio")
            ErrorProviderUsuario.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
            Exit Sub
        Else
            ErrorProviderUsuario.SetError(groTipoUsuario, "")
        End If
        'Campo run
        If txtRUNUsuario.TextLength = 0 Then
            ErrorProviderUsuario.SetError(txtRUNUsuario, "Campo obligatorio")
            ErrorProviderUsuario.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
            Exit Sub
        Else
            ErrorProviderUsuario.SetError(txtRUNUsuario, "")
        End If
        'Campo guion
        If txtGuion.TextLength = 0 Then
            ErrorProviderUsuario.SetError(txtGuion, "Campo obligatorio")
            ErrorProviderUsuario.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
            Exit Sub
        Else
            ErrorProviderUsuario.SetError(txtGuion, "")
        End If
        'Campo nombres
        If txtNombresUsuario.TextLength = 0 Then
            ErrorProviderUsuario.SetError(txtNombresUsuario, "Campo obligatorio")
            ErrorProviderUsuario.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
            Exit Sub
        Else
            ErrorProviderUsuario.SetError(txtNombresUsuario, "")
        End If
        'Campo apellidos
        If txtApellidosUsuario.TextLength = 0 Then
            ErrorProviderUsuario.SetError(txtApellidosUsuario, "Campo obligatorio")
            ErrorProviderUsuario.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
            Exit Sub
        Else
            ErrorProviderUsuario.SetError(txtApellidosUsuario, "")
        End If
        'Campo d�a
        If cmbDia.Text = "" Then
            ErrorProviderUsuario.SetError(cmbDia, "Campo obligatorio")
            Exit Sub
        Else
            ErrorProviderUsuario.SetError(cmbDia, "")
        End If
        'Campo mes
        If cmbMes.Text = "" Then
            ErrorProviderUsuario.SetError(cmbMes, "Campo obligatorio")
            Exit Sub
        Else
            ErrorProviderUsuario.SetError(cmbMes, "")
        End If
        'Campo a�o
        If cmbA�o.Text = "" Then
            ErrorProviderUsuario.SetError(cmbA�o, "Campo obligatorio")
            Exit Sub
        Else
            ErrorProviderUsuario.SetError(cmbA�o, "")
        End If
        'Campo direcci�n
        If txtDireccionUsuario.TextLength = 0 Then
            ErrorProviderUsuario.SetError(txtDireccionUsuario, "Campo obligatorio")
            ErrorProviderUsuario.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
            Exit Sub
        Else
            ErrorProviderUsuario.SetError(txtDireccionUsuario, "")
        End If
        'Campo tel�fono
        If txtTelefonoUsuario.TextLength = 0 Then
            ErrorProviderUsuario.SetError(txtTelefonoUsuario, "Campo obligatorio")
            ErrorProviderUsuario.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
            Exit Sub
        Else
            ErrorProviderUsuario.SetError(txtTelefonoUsuario, "")
        End If

        'Validaci�n ingreso s�lo letras en el campo nombres y apellidos
        ValidaSoloLetras(ErrorProviderUsuario, txtNombresUsuario)
        ValidaSoloLetras(ErrorProviderUsuario, txtApellidosUsuario)

        '*********************************************************************************************************************************************************************************
        'Validaci�n de la cantidad de d�as de los meses
        If cmbMes.Text = "junio" Or cmbMes.Text = "abril" Or _
       cmbMes.Text = "septiembre" Or cmbMes.GetItemText(cmbMes.Text) = "noviembre" Then
            If Integer.Parse(cmbDia.Text) > 30 Then
                ErrorProviderUsuario.SetError(cmbDia, "El mes seleccionado tiene s�lo 30 d�as")
                ErrorProviderUsuario.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
                cmbDia.Focus()
                Exit Sub
            Else
                ErrorProviderUsuario.SetError(cmbDia, "")
            End If
        ElseIf cmbMes.Text = "febrero" Then
            If Integer.Parse(cmbDia.Text) > 28 Then
                ErrorProviderUsuario.SetError(cmbDia, "El mes seleccionado tiene s�lo 28 d�as")
                ErrorProviderUsuario.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
                cmbDia.Focus()
                Exit Sub
            Else
                ErrorProviderUsuario.SetError(cmbDia, "")
            End If
        End If
        'Validaci�n de la edad del vendedor
        If ValidaEdad() = True Then
            Exit Sub
        End If
        Try
            dtFecha = Trim(cmbDia.Text) & "/" & Trim(Str(cmbMes.SelectedIndex + 1)) & "/" & Trim(cmbA�o.Text)
            ca = VerificaRut(txtRUNUsuario.Text, txtGuion.Text)
            strRUNRegistrar = txtRUNUsuario.Text & "-" & txtGuion.Text
            '*********************************************************************************************************************************************************************************
            'Inserci�n de informaci�n del vendedor en la base de datos
            If Me.rbdVendedor.Checked = True Then
                Me.VendedoresTableAdapter1.InsertVendedores(strRUNRegistrar, txtNombresUsuario.Text, txtApellidosUsuario.Text, dtFecha, txtDireccionUsuario.Text, txtTelefonoUsuario.Text, "1234567", 3, 0)
                MsgBox("Registro correcto", MsgBoxStyle.Information, "Registro usuario")
                blnRegistroCorrecto = True
                txtRUNUsuario.Clear()
                txtGuion.Clear()
                txtNombresUsuario.Clear()
                txtApellidosUsuario.Clear()
                txtDireccionUsuario.Clear()
                txtTelefonoUsuario.Clear()
                cmbDia.Text = ""
                cmbMes.Text = ""
                cmbA�o.Text = ""
                Me.groTipoUsuario.Focus()
                Me.ErrorProviderUsuario.Clear()
            ElseIf Me.rdbAdministrador.Checked = True Then
                Me.AdministradoresTableAdapter1.InsertarAdministrador(strRUNRegistrar, txtNombresUsuario.Text, txtApellidosUsuario.Text, dtFecha, txtDireccionUsuario.Text, txtTelefonoUsuario.Text, "1234567", 1, 0)
                Me.VendedoresTableAdapter1.InsertVendedores(strRUNRegistrar, txtNombresUsuario.Text, txtApellidosUsuario.Text, dtFecha, txtDireccionUsuario.Text, txtTelefonoUsuario.Text, "1234567", 3, 0)
                Me.ProduccionTableAdapter1.InsertarProductor(strRUNRegistrar, txtNombresUsuario.Text, txtApellidosUsuario.Text, dtFecha, txtDireccionUsuario.Text, txtTelefonoUsuario.Text, "1234567", 2, 0)
                blnRegistroCorrecto = True
                MsgBox("Registro correcto", MsgBoxStyle.Information, "Registro usuario")
                txtRUNUsuario.Clear()
                txtGuion.Clear()
                txtNombresUsuario.Clear()
                txtApellidosUsuario.Clear()
                txtDireccionUsuario.Clear()
                txtTelefonoUsuario.Clear()
                cmbDia.Text = ""
                cmbMes.Text = ""
                cmbA�o.Text = ""
                Me.groTipoUsuario.Focus()
                Me.ErrorProviderUsuario.Clear()
            ElseIf Me.rdbProductor.Checked = True Then
                Me.ProduccionTableAdapter1.InsertarProductor(strRUNRegistrar, txtNombresUsuario.Text, txtApellidosUsuario.Text, dtFecha, txtDireccionUsuario.Text, txtTelefonoUsuario.Text, "1234567", 2, 0)
                MsgBox("Registro correcto", MsgBoxStyle.Information, "Registro usuario")
                blnRegistroCorrecto = True
                txtRUNUsuario.Clear()
                txtGuion.Clear()
                txtNombresUsuario.Clear()
                txtApellidosUsuario.Clear()
                txtDireccionUsuario.Clear()
                txtTelefonoUsuario.Clear()
                cmbDia.Text = ""
                cmbMes.Text = ""
                cmbA�o.Text = ""
                Me.groTipoUsuario.Focus()
                Me.ErrorProviderUsuario.Clear()
            ElseIf Me.rdbCliente.Checked = True Then
                Me.ClientesTableAdapter1.InsertarClientes(strRUNRegistrar, txtNombresUsuario.Text, txtApellidosUsuario.Text, dtFecha, txtDireccionUsuario.Text, Integer.Parse(txtTelefonoUsuario.Text), "1234567", 4, 0)
                MsgBox("Registro correcto", MsgBoxStyle.Information, "Registro usuario")
                blnRegistroCorrecto = True
                txtRUNUsuario.Clear()
                txtGuion.Clear()
                txtNombresUsuario.Clear()
                txtApellidosUsuario.Clear()
                txtDireccionUsuario.Clear()
                txtTelefonoUsuario.Clear()
                cmbDia.Text = ""
                cmbMes.Text = ""
                cmbA�o.Text = ""
                Me.groTipoUsuario.Focus()
                Me.ErrorProviderUsuario.Clear()
            End If
        Catch ex As SqlException
            MsgBox("El usuario que est� intentando ingresar, ya est� registrado en el sistema", MsgBoxStyle.Critical, "Registro usuario")
        Catch ex As Exception
            MsgBox("Error : " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    '*********************************************************************************************************************************************************************************
    'Validaci�n para que se ingresen s�lo n�meros en el campo tel�fono
    Private Sub txtTelefonoVendedor_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If (Asc(e.KeyChar)) >= 48 And (Asc(e.KeyChar)) <= 57 Or (Asc(e.KeyChar)) = System.Windows.Forms.Keys.Back Or Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    '*********************************************************************************************************************************************************************************
    'Validaci�n para que se ingresen s�lo n�meros en el campo run
    Private Sub txtRUNVendedor_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRUNUsuario.KeyPress
        If (Asc(e.KeyChar)) >= 48 And (Asc(e.KeyChar)) <= 57 Or (Asc(e.KeyChar)) = System.Windows.Forms.Keys.Back Or Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    '*********************************************************************************************************************************************************************************
    'Validaci�n del campo run
    Private Sub txtRUNVendedor_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtRUNUsuario.Validating
        If txtRUNUsuario.TextLength = 0 Then
            ErrorProviderUsuario.SetError(txtRUNUsuario, "Campo obligatorio")
            ErrorProviderUsuario.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
            Exit Sub
        Else
            ErrorProviderUsuario.SetError(txtRUNUsuario, "")
        End If
    End Sub

   
    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        drResultado = MsgBox("Aseg�rese de haber completado correctamente sus operaciones. �Est� seguro que desea cerrar? ", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Registro vendedor")
        If drResultado = vbYes Then
            Me.Close()
            LimpiaControles()
        End If
    End Sub
    '********************************************************************************************************************************************************
    'Validaci�n de todos los campos del formulario cuando pierda el focus
    Private Sub txtApellidosVendedor_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtApellidosUsuario.Validating
        'Campo apellidos
        If txtApellidosUsuario.TextLength = 0 Then
            ErrorProviderUsuario.SetError(txtApellidosUsuario, "Campo obligatorio")
            ErrorProviderUsuario.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
            txtApellidosUsuario.Focus()
            Exit Sub
        Else
            ErrorProviderUsuario.SetError(txtApellidosUsuario, "")
        End If
        ValidaSoloLetras(ErrorProviderUsuario, txtApellidosUsuario)
    End Sub

    Private Sub txtDireccionVendedor_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtDireccionUsuario.Validating
        'Campo direcci�n
        If txtDireccionUsuario.TextLength = 0 Then
            ErrorProviderUsuario.SetError(txtDireccionUsuario, "Campo obligatorio")
            ErrorProviderUsuario.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
            txtDireccionUsuario.Focus()
            Exit Sub
        Else
            ErrorProviderUsuario.SetError(txtDireccionUsuario, "")
        End If
    End Sub
    Private Sub txtTelefonoVendedor_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs)
        'Campo tel�fono
        If txtTelefonoUsuario.TextLength = 0 Then
            ErrorProviderUsuario.SetError(txtTelefonoUsuario, "Campo obligatorio")
            ErrorProviderUsuario.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
            txtTelefonoUsuario.Focus()
            Exit Sub
        Else
            ErrorProviderUsuario.SetError(txtTelefonoUsuario, "")
        End If
    End Sub

    Private Sub txtGuion_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtGuion.Validating
        'Validaci�n del campo RUN
        ca = VerificaRut(txtRUNUsuario.Text, txtGuion.Text)
        If ca = True Then
        ElseIf ca = False Then
            ErrorProviderUsuario.Clear()
            ErrorProviderUsuario.SetError(txtGuion, "El R.U.N. est� incorrecto")
            txtRUNUsuario.Focus()
            Exit Sub
        End If
        If ca = True Then
            ErrorProviderUsuario.SetError(txtGuion, "")
        End If
        blnRegistroCorrecto = False
    End Sub

    Private Sub txtNombresVendedor_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtNombresUsuario.Validating
        'Campo nombres
        If blnRegistroCorrecto = False Then
            If txtNombresUsuario.TextLength = 0 Then
                ErrorProviderUsuario.SetError(txtNombresUsuario, "Campo obligatorio")
                ErrorProviderUsuario.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
                txtNombresUsuario.Focus()
                Exit Sub
            Else
                ErrorProviderUsuario.SetError(txtNombresUsuario, "")
            End If
            ValidaSoloLetras(ErrorProviderUsuario, txtNombresUsuario)
        End If
    End Sub

    Private Sub cmbMes_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbMes.KeyPress
        e.Handled = True
    End Sub


    '*********************************************************************************************************************************************************************************
    'Validaci�n de la cantidad de d�as de los meses
    Private Sub cmbMes_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbMes.SelectedIndexChanged
        Try
            If cmbMes.GetItemText(cmbMes.SelectedItem) = "junio" Or cmbMes.GetItemText(cmbMes.SelectedItem) = "abril" Or _
            cmbMes.GetItemText(cmbMes.SelectedItem) = "septiembre" Or cmbMes.GetItemText(cmbMes.SelectedItem) = "noviembre" Then
                If Integer.Parse(cmbDia.SelectedItem) > 30 Then
                    ErrorProviderUsuario.SetError(cmbDia, "El mes seleccionado tiene s�lo 30 d�as")
                    ErrorProviderUsuario.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
                    cmbDia.Focus()
                    Exit Sub
                Else
                    ErrorProviderUsuario.SetError(cmbDia, "")
                End If
            ElseIf cmbMes.GetItemText(cmbMes.SelectedItem) = "febrero" Then
                If Integer.Parse(cmbDia.SelectedItem) > 28 Then
                    ErrorProviderUsuario.SetError(cmbDia, "El mes seleccionado tiene s�lo 28 d�as")
                    ErrorProviderUsuario.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
                    cmbDia.Focus()
                    Exit Sub
                Else
                    ErrorProviderUsuario.SetError(cmbDia, "")
                End If
            ElseIf cmbMes.GetItemText(cmbMes.SelectedItem) = "enero" Or cmbMes.GetItemText(cmbMes.SelectedItem) = "marzo" Or _
            cmbMes.GetItemText(cmbMes.SelectedItem) = "mayo" Or cmbMes.GetItemText(cmbMes.SelectedItem) = "julio" Or _
            cmbMes.GetItemText(cmbMes.SelectedItem) = "agosto" Or cmbMes.GetItemText(cmbMes.SelectedItem) = "octubre" Or _
            cmbMes.GetItemText(cmbMes.SelectedItem) = "diciembre" Then
                ErrorProviderUsuario.SetError(cmbDia, "")
            End If
        Catch ex As Exception
            MsgBox("Se produjo el siguiente error: " & ex.Message, MsgBoxStyle.Critical, "Teatro")
        End Try
    End Sub
    Private Sub txtGuion_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtGuion.TextChanged
        Try
            If blnRegistroCorrecto = False Then
                strRUNRegistrar = txtRUNUsuario.Text & "-" & txtGuion.Text
                Conexion.Close()
                If BuscarRUNVendedor(strRUNRegistrar) = False And BuscarRUNCliente(strRUNRegistrar) = False And BuscarRUNProductor(strRUNRegistrar) = False And BuscarRUNAdministrador(strRUNRegistrar) = False Then
                    Exit Sub
                End If
                If BuscarRUNVendedor(strRUNRegistrar) = True And Me.rdbProductor.Checked = True Or Me.rdbAdministrador.Checked = True Or Me.rdbCliente.Checked = True Then

                    Conexion.Open()
                    Dim Sentencia As String = "SELECT NOMBREVENDEDOR, APELLIDOVENDEDOR, FECHANACVENDEDOR,DIRECCIONVENDEDOR,TELEFONOVENDEDOR,CONTRASENAVENDEDOR FROM VENDEDORES WHERE RUNVENDEDOR ='" & strRUNRegistrar & "'"
                    Dim SQL As New SqlCommand(Sentencia, Conexion)
                    Dim DR As SqlDataReader
                    DR = SQL.ExecuteReader
                    DR.Read()
                    'se llenan los controles con el data reader
                    txtNombresUsuario.Text = DR("NOMBREVENDEDOR")
                    Me.txtApellidosUsuario.Text = DR("APELLIDOVENDEDOR")
                    Me.txtDireccionUsuario.Text = DR("DIRECCIONVENDEDOR")
                    Me.txtTelefonoUsuario.Text = DR("TELEFONOVENDEDOR")
                    strContrase�a = DR("CONTRASENAVENDEDOR")
                    strConfirmaContrase�a = DR("CONTRASENAVENDEDOR")
                    'Asigno la fecha a variable tipo date
                    dtFechaNac = DR("FECHANACVENDEDOR")
                    'Descompongo la fecha en dia, mes y a�o
                    strDia = Format(CDate(dtFechaNac), "dd")
                    strMes = Format(Month(dtFechaNac), "")
                    strA�o = Format(Year(dtFechaNac), "")
                    blnNoValidarEdad = True
                    cmbA�o.Text = strA�o
                    cmbDia.Text = strDia
                    cmbMes.SelectedIndex = strMes - 1
                    DR.Close()
          

                ElseIf BuscarRUNProductor(strRUNRegistrar) = True And Me.rbdVendedor.Checked = True Or Me.rdbAdministrador.Checked = True Or Me.rdbCliente.Checked = True Then

                    Conexion.Open()
                    Dim Sentencia As String = "SELECT RUNENCARGADO, NOMBREENCARGADO, APELLIDOENCARGADO, FECHANACENCARGADO, DIRECCIONENCARGADO, TELEFONOENCARGADO, CONTRASENAENCARGADO FROM PRODUCCION WHERE RUNENCARGADO='" & strRUNRegistrar & "'"
                    Dim SQL As New SqlCommand(Sentencia, Conexion)
                    Dim DR As SqlDataReader
                    DR = SQL.ExecuteReader
                    DR.Read()
                    'se llenan los controles con el data reader
                    txtNombresUsuario.Text = DR("NOMBREENCARGADO")
                    Me.txtApellidosUsuario.Text = DR("APELLIDOENCARGADO")
                    Me.txtDireccionUsuario.Text = DR("DIRECCIONENCARGADO")
                    Me.txtTelefonoUsuario.Text = DR("TELEFONOENCARGADO")
                    strContrase�a = DR("CONTRASENAENCARGADO")
                    strConfirmaContrase�a = DR("CONTRASENAENCARGADO")
                    'Asigno la fecha a variable tipo date
                    dtFechaNac = DR("FECHANACENCARGADO")
                    'Descompongo la fecha en dia, mes y a�o
                    strDia = Format(CDate(dtFechaNac), "dd")
                    strMes = Format(Month(dtFechaNac), "")
                    strA�o = Format(Year(dtFechaNac), "")
                    blnNoValidarEdad = True
                    cmbA�o.Text = strA�o
                    cmbDia.Text = strDia
                    cmbMes.SelectedIndex = strMes - 1
                    DR.Close()
                   
                ElseIf BuscarRUNCliente(strRUNRegistrar) = True And Me.rbdVendedor.Checked = True Or Me.rdbAdministrador.Checked = True Or Me.rdbProductor.Checked = True Then

                    Conexion.Open()
                    Dim Sentencia As String = "SELECT RUNCLIENTE, NOMBRECLIENTE, APELLIDOCLIENTE, FECHANACCLIENTE, DIRECCIONCLIENTE, TELEFONOCLIENTE, CONTRASENACLIENTE FROM CLIENTES WHERE RUNCLIENTE='" & strRUNRegistrar & "'"
                    Dim SQL As New SqlCommand(Sentencia, Conexion)
                    Dim DR As SqlDataReader
                    DR = SQL.ExecuteReader
                    DR.Read()
                    'se llenan los controles con el data reader
                    txtNombresUsuario.Text = DR("NOMBRECLIENTE")
                    Me.txtApellidosUsuario.Text = DR("APELLIDOCLIENTE")
                    Me.txtDireccionUsuario.Text = DR("DIRECCIONCLIENTE")
                    Me.txtTelefonoUsuario.Text = DR("TELEFONOCLIENTE")
                    strContrase�a = DR("CONTRASENACLIENTE")
                    strConfirmaContrase�a = DR("CONTRASENACLIENTE")
                    'Asigno la fecha a variable tipo date
                    dtFechaNac = DR("FECHANACCLIENTE")
                    'Descompongo la fecha en dia, mes y a�o
                    strDia = Format(CDate(dtFechaNac), "dd")
                    strMes = Format(Month(dtFechaNac), "")
                    strA�o = Format(Year(dtFechaNac), "")
                    blnNoValidarEdad = True
                    cmbA�o.Text = strA�o
                    cmbDia.Text = strDia
                    cmbMes.SelectedIndex = strMes - 1
                    DR.Close()

                ElseIf BuscarRUNAdministrador(strRUNRegistrar) = True And Me.rdbProductor.Checked = True Or Me.rbdVendedor.Checked = True Or Me.rdbCliente.Checked = True Then

                    Conexion.Open()
                    Dim Sentencia As String = "SELECT RUNADMINISTRADOR, NOMBREADMINISTRADOR, APELLIDOADMINISTRADOR, FECHANACADMINISTRADOR, DIRECCIONADMINISTRADOR, TELEFONOADMINISTRADOR, CONTRASENAADMINISTRADOR FROM ADMINISTRADORES WHERE RUNADMINISTRADOR = '" & strRUNRegistrar & "'"
                    Dim SQL As New SqlCommand(Sentencia, Conexion)
                    Dim DR As SqlDataReader
                    DR = SQL.ExecuteReader
                    DR.Read()
                    'se llenan los controles con el data reader
                    txtNombresUsuario.Text = DR("NOMBREADMINISTRADOR")
                    Me.txtApellidosUsuario.Text = DR("APELLIDOADMINISTRADOR")
                    Me.txtDireccionUsuario.Text = DR("DIRECCIONADMINISTRADOR")
                    Me.txtTelefonoUsuario.Text = DR("TELEFONOADMINISTRADOR")
                    strContrase�a = DR("CONTRASENAADMINISTRADOR")
                    strConfirmaContrase�a = DR("CONTRASENAADMINISTRADOR")
                    'Asigno la fecha a variable tipo date
                    dtFechaNac = DR("FECHANACADMINISTRADOR")
                    'Descompongo la fecha en dia, mes y a�o
                    strDia = Format(CDate(dtFechaNac), "dd")
                    strMes = Format(Month(dtFechaNac), "")
                    strA�o = Format(Year(dtFechaNac), "")
                    blnNoValidarEdad = True
                    cmbA�o.Text = strA�o
                    cmbDia.Text = strDia
                    cmbMes.SelectedIndex = strMes - 1
                    DR.Close()

                End If
            End If
        Catch ex As Exception
            MsgBox("Se ha producido el siguiente error: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            Conexion.Close()
        End Try
    End Sub

    Private Sub cmbA�o_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbA�o.KeyPress
        e.Handled = True
    End Sub
    '*********************************************************************************************************************************************************************************
    'Validaci�n de la edad de vendedor
    Private Sub cmbA�o_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbA�o.SelectedIndexChanged
        If blnNoValidarEdad = False Then
            ValidaEdad()
        End If
        blnNoValidarEdad = False
    End Sub
    '*********************************************************************************************************************************************************************************
    'Funci�n validaci�n de la edad de vendedor
    Public Function ValidaEdad() As Boolean
        Dim intA�os As Integer
        Try
            dtFecha = Trim(cmbDia.Text) & "/" & Trim(Str(cmbMes.SelectedIndex + 1)) & "/" & Trim(cmbA�o.Text)
            intA�os = DateDiff(DateInterval.Year, dtFecha, Date.Now.Date)
            If intA�os >= 18 And dtFecha.Subtract(Date.Now.Date).TotalHours <= -157800 Then
                Return False
            Else
                MsgBox("El usuario debe ser mayor de 18 a�os", MsgBoxStyle.Critical, "Registro usuario")
                cmbA�o.Focus()
                Return True
                Exit Function
            End If
        Catch ex As Exception
            MsgBox("Faltan datos", MsgBoxStyle.Critical, "Registro vendedor")
        End Try

    End Function

    Private Sub rbdVendedor_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbdVendedor.Click
        blnRegistroCorrecto = False
        cmbMes.SelectedIndex = -1
    End Sub

    Private Sub rdbAdministrador_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdbAdministrador.Click
        blnRegistroCorrecto = False
        cmbMes.SelectedIndex = -1
    End Sub

    Private Sub rdbProductor_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdbProductor.Click
        blnRegistroCorrecto = False
        cmbMes.SelectedIndex = -1



    End Sub
    Public Sub LimpiaControles()
        Dim objCtrl As Object
        Dim objCtrl2 As Object
        'Dim objCtrl3 As Object

        For Each objCtrl In groInfoEmpleado.Controls
            If TypeOf objCtrl Is TextBox Then objCtrl.Clear()
            Application.DoEvents()
        Next
        For Each objCtrl2 In groTipoUsuario.Controls
            If TypeOf objCtrl2 Is CheckBox Then objCtrl2.checked = False
            Application.DoEvents()
        Next
        'For Each objCtrl In groInfoEmpleado.Controls
        '    If TypeOf objCtrl3 Is ComboBox Then objCtrl3.items.clear()
        '    Application.DoEvents()
        'Next

    End Sub

    Private Sub txtTelefonoUsuario_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTelefonoUsuario.KeyPress
        If (Asc(e.KeyChar)) >= 48 And (Asc(e.KeyChar)) <= 57 Or (Asc(e.KeyChar)) = System.Windows.Forms.Keys.Back Or Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub cmbDia_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbDia.KeyPress
        e.Handled = True
    End Sub
End Class