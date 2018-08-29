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
    Dim strContraseña As String
    Dim strConfirmaContraseña As String
    Dim blnNoValidarEdad As Boolean
    Dim blnRegistroCorrecto As Boolean

    Private Sub frmRegistrarUsuario_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim drResultado As DialogResult = MsgBox("Asegúrese de haber completado correctamente sus operaciones. ¿Está seguro que desea cerrar? ", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Registro eventos")
        If drResultado = vbNo Then
            e.Cancel = True
        Else
            Me.Dispose()
        End If
    End Sub
    '************************************************************************************************************************
    'Validación de super usuario
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
    'Método para cargar los combobox para seleccionar la fecha de nacimiento
    Private Sub Cargar()
        'Llenado de los días
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
    End Sub
    '*********************************************************************************************************************************************************************************
    'Operaciones que se realizan en el evento click del botón registrar
    Private Sub btnRegistrarUsuario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegistrarUsuario.Click
        ca = VerificaRut(txtRUNUsuario.Text, txtGuion.Text)
        'Validación del campo RUN
        If ca = True Then
        ElseIf ca = False And txtGuion.Text <> "" And txtRUNUsuario.Text <> "" Then
            ErrorProviderUsuario.Clear()
            ErrorProviderUsuario.SetError(txtGuion, "El R.U.N. está incorrecto")
            txtRUNUsuario.Focus()
            Exit Sub
        End If
        If ca = True Then
            ErrorProviderUsuario.SetError(txtGuion, "")
        End If

        '*********************************************************************************************************************************************************************************
        'Validación de campos nulos
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
        'Campo día
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
        'Campo año
        If cmbAño.Text = "" Then
            ErrorProviderUsuario.SetError(cmbAño, "Campo obligatorio")
            Exit Sub
        Else
            ErrorProviderUsuario.SetError(cmbAño, "")
        End If
        'Campo dirección
        If txtDireccionUsuario.TextLength = 0 Then
            ErrorProviderUsuario.SetError(txtDireccionUsuario, "Campo obligatorio")
            ErrorProviderUsuario.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
            Exit Sub
        Else
            ErrorProviderUsuario.SetError(txtDireccionUsuario, "")
        End If
        'Campo teléfono
        If txtTelefonoUsuario.TextLength = 0 Then
            ErrorProviderUsuario.SetError(txtTelefonoUsuario, "Campo obligatorio")
            ErrorProviderUsuario.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
            Exit Sub
        Else
            ErrorProviderUsuario.SetError(txtTelefonoUsuario, "")
        End If

        'Validación ingreso sólo letras en el campo nombres y apellidos
        ValidaSoloLetras(ErrorProviderUsuario, txtNombresUsuario)
        ValidaSoloLetras(ErrorProviderUsuario, txtApellidosUsuario)

        '*********************************************************************************************************************************************************************************
        'Validación de la cantidad de días de los meses
        If cmbMes.Text = "junio" Or cmbMes.Text = "abril" Or _
       cmbMes.Text = "septiembre" Or cmbMes.GetItemText(cmbMes.Text) = "noviembre" Then
            If Integer.Parse(cmbDia.Text) > 30 Then
                ErrorProviderUsuario.SetError(cmbDia, "El mes seleccionado tiene sólo 30 días")
                ErrorProviderUsuario.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
                cmbDia.Focus()
                Exit Sub
            Else
                ErrorProviderUsuario.SetError(cmbDia, "")
            End If
        ElseIf cmbMes.Text = "febrero" Then
            If Integer.Parse(cmbDia.Text) > 28 Then
                ErrorProviderUsuario.SetError(cmbDia, "El mes seleccionado tiene sólo 28 días")
                ErrorProviderUsuario.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
                cmbDia.Focus()
                Exit Sub
            Else
                ErrorProviderUsuario.SetError(cmbDia, "")
            End If
        End If
        'Validación de la edad del vendedor
        If ValidaEdad() = True Then
            Exit Sub
        End If
        Try
            dtFecha = Trim(cmbDia.Text) & "/" & Trim(Str(cmbMes.SelectedIndex + 1)) & "/" & Trim(cmbAño.Text)
            ca = VerificaRut(txtRUNUsuario.Text, txtGuion.Text)
            strRUNRegistrar = txtRUNUsuario.Text & "-" & txtGuion.Text
            '*********************************************************************************************************************************************************************************
            'Inserción de información del vendedor en la base de datos
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
                cmbAño.Text = ""
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
                cmbAño.Text = ""
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
                cmbAño.Text = ""
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
                cmbAño.Text = ""
                Me.groTipoUsuario.Focus()
                Me.ErrorProviderUsuario.Clear()
            End If
        Catch ex As SqlException
            MsgBox("El usuario que está intentando ingresar, ya está registrado en el sistema", MsgBoxStyle.Critical, "Registro usuario")
        Catch ex As Exception
            MsgBox("Error : " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    '*********************************************************************************************************************************************************************************
    'Validación para que se ingresen sólo números en el campo teléfono
    Private Sub txtTelefonoVendedor_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If (Asc(e.KeyChar)) >= 48 And (Asc(e.KeyChar)) <= 57 Or (Asc(e.KeyChar)) = System.Windows.Forms.Keys.Back Or Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    '*********************************************************************************************************************************************************************************
    'Validación para que se ingresen sólo números en el campo run
    Private Sub txtRUNVendedor_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRUNUsuario.KeyPress
        If (Asc(e.KeyChar)) >= 48 And (Asc(e.KeyChar)) <= 57 Or (Asc(e.KeyChar)) = System.Windows.Forms.Keys.Back Or Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    '*********************************************************************************************************************************************************************************
    'Validación del campo run
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
        drResultado = MsgBox("Asegúrese de haber completado correctamente sus operaciones. ¿Está seguro que desea cerrar? ", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Registro vendedor")
        If drResultado = vbYes Then
            Me.Close()
            LimpiaControles()
        End If
    End Sub
    '********************************************************************************************************************************************************
    'Validación de todos los campos del formulario cuando pierda el focus
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
        'Campo dirección
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
        'Campo teléfono
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
        'Validación del campo RUN
        ca = VerificaRut(txtRUNUsuario.Text, txtGuion.Text)
        If ca = True Then
        ElseIf ca = False Then
            ErrorProviderUsuario.Clear()
            ErrorProviderUsuario.SetError(txtGuion, "El R.U.N. está incorrecto")
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
    'Validación de la cantidad de días de los meses
    Private Sub cmbMes_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbMes.SelectedIndexChanged
        Try
            If cmbMes.GetItemText(cmbMes.SelectedItem) = "junio" Or cmbMes.GetItemText(cmbMes.SelectedItem) = "abril" Or _
            cmbMes.GetItemText(cmbMes.SelectedItem) = "septiembre" Or cmbMes.GetItemText(cmbMes.SelectedItem) = "noviembre" Then
                If Integer.Parse(cmbDia.SelectedItem) > 30 Then
                    ErrorProviderUsuario.SetError(cmbDia, "El mes seleccionado tiene sólo 30 días")
                    ErrorProviderUsuario.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
                    cmbDia.Focus()
                    Exit Sub
                Else
                    ErrorProviderUsuario.SetError(cmbDia, "")
                End If
            ElseIf cmbMes.GetItemText(cmbMes.SelectedItem) = "febrero" Then
                If Integer.Parse(cmbDia.SelectedItem) > 28 Then
                    ErrorProviderUsuario.SetError(cmbDia, "El mes seleccionado tiene sólo 28 días")
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
                    strContraseña = DR("CONTRASENAVENDEDOR")
                    strConfirmaContraseña = DR("CONTRASENAVENDEDOR")
                    'Asigno la fecha a variable tipo date
                    dtFechaNac = DR("FECHANACVENDEDOR")
                    'Descompongo la fecha en dia, mes y año
                    strDia = Format(CDate(dtFechaNac), "dd")
                    strMes = Format(Month(dtFechaNac), "")
                    strAño = Format(Year(dtFechaNac), "")
                    blnNoValidarEdad = True
                    cmbAño.Text = strAño
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
                    strContraseña = DR("CONTRASENAENCARGADO")
                    strConfirmaContraseña = DR("CONTRASENAENCARGADO")
                    'Asigno la fecha a variable tipo date
                    dtFechaNac = DR("FECHANACENCARGADO")
                    'Descompongo la fecha en dia, mes y año
                    strDia = Format(CDate(dtFechaNac), "dd")
                    strMes = Format(Month(dtFechaNac), "")
                    strAño = Format(Year(dtFechaNac), "")
                    blnNoValidarEdad = True
                    cmbAño.Text = strAño
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
                    strContraseña = DR("CONTRASENACLIENTE")
                    strConfirmaContraseña = DR("CONTRASENACLIENTE")
                    'Asigno la fecha a variable tipo date
                    dtFechaNac = DR("FECHANACCLIENTE")
                    'Descompongo la fecha en dia, mes y año
                    strDia = Format(CDate(dtFechaNac), "dd")
                    strMes = Format(Month(dtFechaNac), "")
                    strAño = Format(Year(dtFechaNac), "")
                    blnNoValidarEdad = True
                    cmbAño.Text = strAño
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
                    strContraseña = DR("CONTRASENAADMINISTRADOR")
                    strConfirmaContraseña = DR("CONTRASENAADMINISTRADOR")
                    'Asigno la fecha a variable tipo date
                    dtFechaNac = DR("FECHANACADMINISTRADOR")
                    'Descompongo la fecha en dia, mes y año
                    strDia = Format(CDate(dtFechaNac), "dd")
                    strMes = Format(Month(dtFechaNac), "")
                    strAño = Format(Year(dtFechaNac), "")
                    blnNoValidarEdad = True
                    cmbAño.Text = strAño
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

    Private Sub cmbAño_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbAño.KeyPress
        e.Handled = True
    End Sub
    '*********************************************************************************************************************************************************************************
    'Validación de la edad de vendedor
    Private Sub cmbAño_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbAño.SelectedIndexChanged
        If blnNoValidarEdad = False Then
            ValidaEdad()
        End If
        blnNoValidarEdad = False
    End Sub
    '*********************************************************************************************************************************************************************************
    'Función validación de la edad de vendedor
    Public Function ValidaEdad() As Boolean
        Dim intAños As Integer
        Try
            dtFecha = Trim(cmbDia.Text) & "/" & Trim(Str(cmbMes.SelectedIndex + 1)) & "/" & Trim(cmbAño.Text)
            intAños = DateDiff(DateInterval.Year, dtFecha, Date.Now.Date)
            If intAños >= 18 And dtFecha.Subtract(Date.Now.Date).TotalHours <= -157800 Then
                Return False
            Else
                MsgBox("El usuario debe ser mayor de 18 años", MsgBoxStyle.Critical, "Registro usuario")
                cmbAño.Focus()
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