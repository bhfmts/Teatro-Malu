Imports System.Data.SqlClient
Imports Teatro.Validaciones
Imports Teatro.ClassConexion
Imports Teatro.ClassVendedor
Imports Teatro.ClassProductor
Imports Teatro.ClassAdministrador
Imports Teatro.ClassCliente
Imports System.Transactions

Public Class frmModificarUsuario
    Dim ca As Boolean
    Dim strRUNModificar As String
    Dim drResultado As DialogResult
    '*********************************************************************************************************************************************************************************
    'Procedimiento para cargar los combox con la fecha
    Private Sub Cargar()
        'Llenar el Día
        Dim i As Integer
        For i = 1 To 31
            cmbDia.Items.Add(i)
        Next
        'Llenar los Meses del Año
        For i = 1 To 12
            cmbMes.Items.Add(MonthName(i, False))
        Next
        'Al ingresar el rango para los años existen
        'ingreso del año 1960 hasta el año actual
        For i = 1940 To Year(Now)
            cmbAño.Items.Add(i)
        Next
    End Sub
    '*********************************************************************************************************************************************************************************
    'Operaciones que se realizan en el evento click del botón buscar
    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        CamposNulos(Me.ErrorProviderModificarUsuario, txtRUNUsuario)
        CamposNulos(Me.ErrorProviderModificarUsuario, txtGuion)
        'Validación del campo RUN
        ca = VerificaRut(txtRUNUsuario.Text, txtGuion.Text)
        If ca = True Then
        ElseIf ca = False Then
            ErrorProviderModificarUsuario.Clear()
            ErrorProviderModificarUsuario.SetError(txtGuion, "El R.U.N. está incorrecto")
            txtRUNUsuario.Focus()
            Exit Sub
        End If
        If ca = True Then
            ErrorProviderModificarUsuario.SetError(txtGuion, "")
        End If
        'Groupbox Tipo usuario
        If Me.rbdVendedor.Checked = False And Me.rdbProductor.Checked = False And Me.rdbAdministrador.Checked = False And Me.rdbCliente.Checked = False Then
            ErrorProviderModificarUsuario.SetError(groTipoUsuario, "Campo obligatorio")
            ErrorProviderModificarUsuario.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
            Exit Sub
        Else
            ErrorProviderModificarUsuario.SetError(groTipoUsuario, "")
        End If
        strRUNModificar = txtRUNUsuario.Text & "-" & txtGuion.Text
        If BuscarRUNVendedor(strRUNModificar) = True And Me.rbdVendedor.Checked = True Then
            Conexion.Close()
            Try
                Conexion.Open()
                Dim Sentencia As String = "SELECT NOMBREVENDEDOR, APELLIDOVENDEDOR, FECHANACVENDEDOR,DIRECCIONVENDEDOR,TELEFONOVENDEDOR,CONTRASENAVENDEDOR FROM VENDEDORES WHERE RUNVENDEDOR ='" & strRUNModificar & "'"
                Dim SQL As New SqlCommand(Sentencia, Conexion)
                Dim DR As SqlDataReader
                DR = SQL.ExecuteReader
                DR.Read()
                'se llenan los controles con el data reader
                txtNombresUsuario.Text = DR("NOMBREVENDEDOR")
                Me.txtApellidosUsuario.Text = DR("APELLIDOVENDEDOR")
                Me.txtDireccionUsuario.Text = DR("DIRECCIONVENDEDOR")
                Me.txtTelefonoUsuario.Text = DR("TELEFONOVENDEDOR")
                Me.txtContraseña.Text = DR("CONTRASENAVENDEDOR")
                Me.txtConfirmaContraseña.Text = DR("CONTRASENAVENDEDOR")
                'Asigno la fecha a variable tipo date
                dtFechaNac = DR("FECHANACVENDEDOR")
                'Descompongo la fecha en dia, mes y año
                strDia = Format(CDate(dtFechaNac), "dd")
                strMes = Format(Month(dtFechaNac), "")
                strAño = Format(Year(dtFechaNac), "")
                cmbAño.Text = strAño
                cmbDia.Text = strDia
                cmbMes.SelectedIndex = strMes - 1
                DR.Close()
            Catch ex As Exception
                MsgBox("Se ha producido el siguiente error: " & ex.Message, MsgBoxStyle.Critical)
            Finally
                Conexion.Close()
            End Try
            btnActualizarVendedor.Enabled = True
        ElseIf BuscarRUNProductor(strRUNModificar) = True And Me.rdbProductor.Checked = True Then
            Conexion.Close()
            Try
                Conexion.Open()
                Dim Sentencia As String = "SELECT RUNENCARGADO, NOMBREENCARGADO, APELLIDOENCARGADO, FECHANACENCARGADO, DIRECCIONENCARGADO, TELEFONOENCARGADO, CONTRASENAENCARGADO FROM PRODUCCION WHERE RUNENCARGADO='" & strRUNModificar & "'"
                Dim SQL As New SqlCommand(Sentencia, Conexion)
                Dim DR As SqlDataReader
                DR = SQL.ExecuteReader
                DR.Read()
                'se llenan los controles con el data reader
                txtNombresUsuario.Text = DR("NOMBREENCARGADO")
                Me.txtApellidosUsuario.Text = DR("APELLIDOENCARGADO")
                Me.txtDireccionUsuario.Text = DR("DIRECCIONENCARGADO")
                Me.txtTelefonoUsuario.Text = DR("TELEFONOENCARGADO")
                Me.txtContraseña.Text = DR("CONTRASENAENCARGADO")
                Me.txtConfirmaContraseña.Text = DR("CONTRASENAENCARGADO")
                'Asigno la fecha a variable tipo date
                dtFechaNac = DR("FECHANACENCARGADO")
                'Descompongo la fecha en dia, mes y año
                strDia = Format(CDate(dtFechaNac), "dd")
                strMes = Format(Month(dtFechaNac), "")
                strAño = Format(Year(dtFechaNac), "")
                cmbAño.Text = strAño
                cmbDia.Text = strDia
                cmbMes.SelectedIndex = strMes - 1
                DR.Close()
            Catch ex As Exception
                MsgBox("Se ha producido el siguiente error: " & ex.Message, MsgBoxStyle.Critical)
            Finally
                Conexion.Close()
            End Try
            btnActualizarVendedor.Enabled = True
        ElseIf BuscarRUNAdministrador(strRUNModificar) = True And Me.rdbAdministrador.Checked = True Then
            Conexion.Close()
            Try
                Conexion.Open()
                Dim Sentencia As String = "SELECT RUNADMINISTRADOR, NOMBREADMINISTRADOR, APELLIDOADMINISTRADOR, FECHANACADMINISTRADOR, DIRECCIONADMINISTRADOR, TELEFONOADMINISTRADOR, CONTRASENAADMINISTRADOR FROM ADMINISTRADORES WHERE RUNADMINISTRADOR = '" & strRUNModificar & "'"
                Dim SQL As New SqlCommand(Sentencia, Conexion)
                Dim DR As SqlDataReader
                DR = SQL.ExecuteReader
                DR.Read()
                'se llenan los controles con el data reader
                txtNombresUsuario.Text = DR("NOMBREADMINISTRADOR")
                Me.txtApellidosUsuario.Text = DR("APELLIDOADMINISTRADOR")
                Me.txtDireccionUsuario.Text = DR("DIRECCIONADMINISTRADOR")
                Me.txtTelefonoUsuario.Text = DR("TELEFONOADMINISTRADOR")
                Me.txtContraseña.Text = DR("CONTRASENAADMINISTRADOR")
                Me.txtConfirmaContraseña.Text = DR("CONTRASENAADMINISTRADOR")
                'Asigno la fecha a variable tipo date
                dtFechaNac = DR("FECHANACADMINISTRADOR")
                'Descompongo la fecha en dia, mes y año
                strDia = Format(CDate(dtFechaNac), "dd")
                strMes = Format(Month(dtFechaNac), "")
                strAño = Format(Year(dtFechaNac), "")
                cmbAño.Text = strAño
                cmbDia.Text = strDia
                cmbMes.SelectedIndex = strMes - 1
                DR.Close()
            Catch ex As Exception
                MsgBox("Se ha producido el siguiente error: " & ex.Message, MsgBoxStyle.Critical)
            Finally
                Conexion.Close()
            End Try
            btnActualizarVendedor.Enabled = True
        ElseIf BuscarRUNCliente(strRUNModificar) = True And Me.rdbCliente.Checked = True Then
            Conexion.Close()
            Try
                Conexion.Open()
                Dim Sentencia As String = "SELECT RUNCLIENTE, NOMBRECLIENTE, APELLIDOCLIENTE, FECHANACCLIENTE, DIRECCIONCLIENTE, TELEFONOCLIENTE, CONTRASENACLIENTE FROM CLIENTES WHERE RUNCLIENTE = '" & strRUNModificar & "'"
                Dim SQL As New SqlCommand(Sentencia, Conexion)
                Dim DR As SqlDataReader
                DR = SQL.ExecuteReader
                DR.Read()
                'se llenan los controles con el data reader
                txtNombresUsuario.Text = DR("NOMBRECLIENTE")
                Me.txtApellidosUsuario.Text = DR("APELLIDOCLIENTE")
                Me.txtDireccionUsuario.Text = DR("DIRECCIONCLIENTE")
                Me.txtTelefonoUsuario.Text = DR("TELEFONOCLIENTE")
                Me.txtContraseña.Text = DR("CONTRASENACLIENTE")
                Me.txtConfirmaContraseña.Text = DR("CONTRASENACLIENTE")
                'Asigno la fecha a variable tipo date
                dtFechaNac = DR("FECHANACCLIENTE")
                'Descompongo la fecha en dia, mes y año
                strDia = Format(CDate(dtFechaNac), "dd")
                strMes = Format(Month(dtFechaNac), "")
                strAño = Format(Year(dtFechaNac), "")
                cmbAño.Text = strAño
                cmbDia.Text = strDia
                cmbMes.SelectedIndex = strMes - 1
                DR.Close()
            Catch ex As Exception
                MsgBox("Se ha producido el siguiente error: " & ex.Message, MsgBoxStyle.Critical)
            Finally
                Conexion.Close()
            End Try
            btnActualizarVendedor.Enabled = True
        Else
            MsgBox("El R.U.N. ingresado no está registrado en el sistema", MsgBoxStyle.Critical)
            txtRUNUsuario.Clear()
            txtGuion.Clear()
            txtNombresUsuario.Clear()
            txtApellidosUsuario.Clear()
            txtDireccionUsuario.Clear()
            txtTelefonoUsuario.Clear()
            cmbDia.Text = ""
            cmbMes.Text = ""
            cmbAño.Text = ""
            Me.txtConfirmaContraseña.Clear()
            Me.txtContraseña.Clear()
        End If

    End Sub
    'Cerrando formulario...
    Private Sub frmModificarUsuario_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim drResultado As DialogResult = MsgBox("Asegúrese de haber completado correctamente sus operaciones. ¿Está seguro que desea cerrar? ", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Registro eventos")
        If drResultado = vbNo Then
            e.Cancel = True
        Else
            Me.Dispose()
        End If
    End Sub

    Private Sub frmModificarUsuario_HelpRequested(ByVal sender As Object, ByVal hlpevent As System.Windows.Forms.HelpEventArgs) Handles Me.HelpRequested
        Try
            System.Diagnostics.Process.Start("\\BERNARDO\Manuales\Modificar usuario.avi")
        Catch ex As Exception
            MsgBox("Se ha producido el siguiente error: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    '************************************************************************************************************************
    'Validación de super usuario
    Private Sub frmModificarVendedor_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            Cargar()
            Me.txtRUNUsuario.Select()
            If Me.AdministradoresTableAdapter1.SelectSuperAdministrador(strRUNUsuario) = "4741033-9" Then
                Me.rdbAdministrador.Enabled = True
            Else
                Me.rdbAdministrador.Enabled = False
            End If
        Catch ex As Exception
            MsgBox("Se produjo el siguiente error: " & ex.Message, MsgBoxStyle.Critical, "Teatro")
        End Try
    End Sub
    '*********************************************************************************************************************************************************************************
    'Operaciones que se realizan en el evento click del botón actualizar
    Private Sub btnActualizarVendedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizarVendedor.Click
        Dim Persona As New ClassPersona
        'Persona.strContraseña = Me.txtContraseña.Text
        'Persona.strContraseña = Me.txtConfirmaContraseña.Text
        Try
            'Validación campos nulos
            If CamposNulos(ErrorProviderModificarUsuario, txtRUNUsuario) = True Then
                Exit Sub
            ElseIf CamposNulos(ErrorProviderModificarUsuario, txtGuion) = True Then
                Exit Sub
                'Groupbox Tipo usuario
            ElseIf Me.rbdVendedor.Checked = False And Me.rdbProductor.Checked = False And Me.rdbAdministrador.Checked = False And Me.rdbCliente.Checked = False Then
                ErrorProviderModificarUsuario.SetError(groTipoUsuario, "Campo obligatorio")
                ErrorProviderModificarUsuario.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
                Exit Sub
            Else
                ErrorProviderModificarUsuario.SetError(groTipoUsuario, "")
            End If
            If CamposNulos(ErrorProviderModificarUsuario, txtNombresUsuario) = True Then
                Exit Sub
            ElseIf CamposNulos(ErrorProviderModificarUsuario, txtApellidosUsuario) = True Then
                Exit Sub
            ElseIf CamposNulos(ErrorProviderModificarUsuario, txtTelefonoUsuario) = True Then
                Exit Sub
            ElseIf CamposNulos(ErrorProviderModificarUsuario, txtDireccionUsuario) = True Then
                Exit Sub
            ElseIf CamposNulos(ErrorProviderModificarUsuario, txtContraseña) = True Then
                Exit Sub
            ElseIf CamposNulos(ErrorProviderModificarUsuario, txtConfirmaContraseña) = True Then
                Exit Sub
            ElseIf ValidaSoloLetras(ErrorProviderModificarUsuario, txtNombresUsuario) = True Then
                Exit Sub
            ElseIf ValidaSoloLetras(ErrorProviderModificarUsuario, txtApellidosUsuario) = True Then
                Exit Sub
            End If
            If txtContraseña.Text <> txtConfirmaContraseña.Text Then
                ErrorProviderModificarUsuario.SetError(txtContraseña, "Los datos no coinciden")
                Me.txtContraseña.Focus()
                Exit Sub
            Else
                ErrorProviderModificarUsuario.SetError(txtContraseña, "")
            End If

            If txtContraseña.TextLength < 7 Then
                ErrorProviderModificarUsuario.SetError(txtContraseña, "Mínimo 7 caracteres")
                Me.txtContraseña.Focus()
                Exit Sub
            Else
                ErrorProviderModificarUsuario.SetError(txtContraseña, "")
            End If
            Dim vfecha As String
            Dim sfecha As String
            vfecha = Trim(cmbDia.Text) & "/" & Trim(Str(cmbMes.SelectedIndex + 1)) & "/" & Trim(cmbAño.Text)
            If Microsoft.VisualBasic.IsDate(vfecha) = False Then
                Me.ErrorProviderModificarUsuario.SetError(Me.cmbAño, " Fecha inválida")
                Exit Sub
            Else
                If ValidaEdad() = True Then
                    Exit Sub
                End If
                Me.ErrorProviderModificarUsuario.SetError(Me.cmbAño, "")
            End If
            sfecha = vfecha
            'Actualización de vendedor
            If Me.rbdVendedor.Checked = True And BuscarRUNVendedor(strRUNModificar) = True Then

                Me.VendedoresTableAdapter1.UpdateVendedor(txtNombresUsuario.Text, txtApellidosUsuario.Text, _
                 Date.Parse(sfecha), txtDireccionUsuario.Text, txtTelefonoUsuario.Text, txtContraseña.Text, strRUNModificar)
                drResultado = MsgBox("Actualización realizada satisfactoriamente." & vbCrLf & "¿Desea continuar modificando el mismo Vendedor?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Modificar evento")
                If drResultado = vbNo Then
                    txtRUNUsuario.Clear()
                    txtGuion.Clear()
                    txtNombresUsuario.Clear()
                    txtApellidosUsuario.Clear()
                    txtDireccionUsuario.Clear()
                    txtTelefonoUsuario.Clear()
                    cmbDia.Text = ""
                    cmbMes.SelectedIndex = -1
                    cmbAño.Text = ""
                    txtContraseña.Clear()
                    txtConfirmaContraseña.Clear()
                    btnActualizarVendedor.Enabled = False
                    txtRUNUsuario.Focus()
                    Me.ErrorProviderModificarUsuario.Clear()
                End If

                'Actualización de productor
            ElseIf Me.rdbProductor.Checked = True And BuscarRUNProductor(strRUNModificar) = True Then
                Try
                    Me.ProduccionTableAdapter1.UpdateProduccion(txtNombresUsuario.Text, txtApellidosUsuario.Text, _
                     Date.Parse(sfecha), txtDireccionUsuario.Text, txtTelefonoUsuario.Text, txtContraseña.Text, strRUNModificar)
                    drResultado = MsgBox("Actualización realizada satisfactoriamente." & vbCrLf & "¿Desea continuar modificando el mismo Productor?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Modificar evento")
                    If drResultado = vbNo Then
                        txtRUNUsuario.Clear()
                        txtGuion.Clear()
                        txtNombresUsuario.Clear()
                        txtApellidosUsuario.Clear()
                        txtDireccionUsuario.Clear()
                        txtTelefonoUsuario.Clear()
                        cmbDia.Text = ""
                        cmbMes.SelectedIndex = -1
                        cmbAño.Text = ""
                        txtContraseña.Clear()
                        txtConfirmaContraseña.Clear()
                        btnActualizarVendedor.Enabled = False
                        txtRUNUsuario.Focus()
                        Me.ErrorProviderModificarUsuario.Clear()
                    End If
                Catch ex As SqlException
                    MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, "Modificar usuario")
                Catch ex As Exception
                    MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, "Modificar usuario")
                End Try
                'Actualización de administrador
            ElseIf Me.rdbAdministrador.Checked = True And BuscarRUNAdministrador(strRUNModificar) = True Then

                Me.AdministradoresTableAdapter1.UpdateAdministrador(txtNombresUsuario.Text, txtApellidosUsuario.Text, _
                 Date.Parse(sfecha), txtDireccionUsuario.Text, txtTelefonoUsuario.Text, txtContraseña.Text, strRUNModificar)
                drResultado = MsgBox("Actualización realizada satisfactoriamente." & vbCrLf & "¿Desea continuar modificando el mismo Administrador?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Modificar evento")
                If drResultado = vbNo Then
                    txtRUNUsuario.Clear()
                    txtGuion.Clear()
                    txtNombresUsuario.Clear()
                    txtApellidosUsuario.Clear()
                    txtDireccionUsuario.Clear()
                    txtTelefonoUsuario.Clear()
                    cmbDia.Text = ""
                    cmbMes.SelectedIndex = -1
                    cmbAño.Text = ""
                    txtContraseña.Clear()
                    txtConfirmaContraseña.Clear()
                    btnActualizarVendedor.Enabled = False
                    txtRUNUsuario.Focus()
                    Me.ErrorProviderModificarUsuario.Clear()
                End If


                'Actualización cliente
            ElseIf Me.rdbCliente.Checked = True And BuscarRUNCliente(strRUNModificar) = True Then

                Me.ClientesTableAdapter1.UpdateCliente(txtNombresUsuario.Text, txtApellidosUsuario.Text, _
                 Date.Parse(sfecha), txtDireccionUsuario.Text, txtTelefonoUsuario.Text, txtContraseña.Text, strRUNModificar)
                drResultado = MsgBox("Actualización realizada satisfactoriamente." & vbCrLf & "¿Desea continuar modificando el mismo Cliente?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Modificar evento")
                If drResultado = vbNo Then
                    txtRUNUsuario.Clear()
                    txtGuion.Clear()
                    txtNombresUsuario.Clear()
                    txtApellidosUsuario.Clear()
                    txtDireccionUsuario.Clear()
                    txtTelefonoUsuario.Clear()
                    cmbDia.Text = ""
                    cmbMes.SelectedIndex = -1
                    cmbAño.Text = ""
                    txtContraseña.Clear()
                    txtConfirmaContraseña.Clear()
                    btnActualizarVendedor.Enabled = False
                    txtRUNUsuario.Focus()
                    Me.ErrorProviderModificarUsuario.Clear()
                End If

            Else
                MsgBox("Seleccione el tipo de usuario correcto", MsgBoxStyle.Critical, "Modificar usuario")
            End If
        Catch ex As SqlException
            MsgBox("Error SQL: " & ex.Message, MsgBoxStyle.Critical, "Modificar usuario")
        Catch ex As Exception
            MsgBox("Error general: " & ex.Message, MsgBoxStyle.Critical, "Modificar usuario")
        End Try
    End Sub
    'Validación de contraseña
    Private Sub txtConfirmaContraseña_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtConfirmaContraseña.Validating
        If txtContraseña.Text <> txtConfirmaContraseña.Text Then
            ErrorProviderModificarUsuario.SetError(txtContraseña, "Los datos no coinciden")
            Me.txtContraseña.Focus()
            Exit Sub
        Else
            ErrorProviderModificarUsuario.SetError(txtContraseña, "")
        End If

        If txtContraseña.TextLength < 7 Then
            ErrorProviderModificarUsuario.SetError(txtContraseña, "Mínimo 7 caracteres")
            Me.txtContraseña.Focus()
            Exit Sub
        Else
            ErrorProviderModificarUsuario.SetError(txtContraseña, "")
        End If
        CamposNulos(ErrorProviderModificarUsuario, txtConfirmaContraseña)
    End Sub
    '*********************************************************************************************************************************************************************************
    'Función validación de la edad de vendedor
    Public Function ValidaEdad() As Boolean
        Dim intAños As Integer
        Try
            dtFechaNac = Trim(cmbDia.Text) & "/" & Trim(Str(cmbMes.SelectedIndex + 1)) & "/" & Trim(cmbAño.SelectedItem)
            intAños = DateDiff(DateInterval.Year, dtFechaNac, Date.Now.Date)
            If intAños >= 18 And dtFechaNac.Subtract(Date.Now.Date).TotalHours <= -157800 Then
                Return False
            Else
                MsgBox("El vendedor debe ser mayor de 18 años", MsgBoxStyle.Critical, "Registro vendedor")
                cmbAño.Focus()
                Return True
                Exit Function
            End If
        Catch ex As Exception
            MsgBox("Faltan datos", MsgBoxStyle.Critical, "Registro vendedor")
        End Try
    End Function
    '*********************************************************************************************************************************************************************************
    'Validación para que se ingresen sólo números en el campo telefono
    Private Sub txtTelefonoVendedor_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTelefonoUsuario.KeyPress
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
    'Validación de la edad del vendedor
    'Private Sub cmbAño_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cmbAño.Validating
    '    ValidaEdad()
    'End Sub

    Private Sub txtGuion_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtGuion.Validating
        'Validación del campo RUN
        ca = VerificaRut(txtRUNUsuario.Text, txtGuion.Text)
        If ca = True Then
        ElseIf ca = False Then
            ErrorProviderModificarUsuario.Clear()
            ErrorProviderModificarUsuario.SetError(txtGuion, "El R.U.N. está incorrecto")
            txtRUNUsuario.Focus()
            Exit Sub
        End If
        If ca = True Then
            ErrorProviderModificarUsuario.SetError(txtGuion, "")
        End If
    End Sub
    'Validación de campos nulos
    Private Sub txtRUNVendedor_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtRUNUsuario.Validating
        'CamposNulos(ErrorProviderModificarUsuario, txtRUNUsuario)
    End Sub

    Private Sub txtApellidosVendedor_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtApellidosUsuario.Validating
        CamposNulos(ErrorProviderModificarUsuario, txtApellidosUsuario)
    End Sub

    Private Sub txtNombresVendedor_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtNombresUsuario.Validating
        CamposNulos(ErrorProviderModificarUsuario, txtNombresUsuario)
    End Sub

    Private Sub txtTelefonoVendedor_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtTelefonoUsuario.Validating
        CamposNulos(ErrorProviderModificarUsuario, txtTelefonoUsuario)
    End Sub

    Private Sub txtDireccionVendedor_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtDireccionUsuario.Validating
        CamposNulos(ErrorProviderModificarUsuario, txtDireccionUsuario)
    End Sub

    Private Sub txtContraseña_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtContraseña.Validating
        CamposNulos(ErrorProviderModificarUsuario, txtContraseña)
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
                If Integer.Parse(cmbDia.Text) > 30 Then
                    ErrorProviderModificarUsuario.SetError(cmbDia, "El mes seleccionado tiene sólo 30 días")
                    ErrorProviderModificarUsuario.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
                    cmbDia.Focus()
                    Exit Sub
                Else
                    ErrorProviderModificarUsuario.SetError(cmbDia, "")
                End If
            ElseIf cmbMes.GetItemText(cmbMes.Text) = "febrero" Then
                If Integer.Parse(cmbDia.Text) > 28 Then
                    ErrorProviderModificarUsuario.SetError(cmbDia, "El mes seleccionado tiene sólo 28 días")
                    ErrorProviderModificarUsuario.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
                    cmbDia.Focus()
                    Exit Sub
                Else
                    ErrorProviderModificarUsuario.SetError(cmbDia, "")
                End If
            ElseIf cmbMes.GetItemText(cmbMes.Text) = "enero" Or cmbMes.GetItemText(cmbMes.Text) = "marzo" Or _
            cmbMes.GetItemText(cmbMes.Text) = "mayo" Or cmbMes.GetItemText(cmbMes.Text) = "julio" Or _
            cmbMes.GetItemText(cmbMes.Text) = "agosto" Or cmbMes.GetItemText(cmbMes.Text) = "octubre" Or _
            cmbMes.GetItemText(cmbMes.Text) = "diciembre" Then
                ErrorProviderModificarUsuario.SetError(cmbDia, "")
            End If
        Catch ex As Exception
            MsgBox("Se produjo el siguiente error: " & ex.Message, MsgBoxStyle.Critical, "Teatro")
        End Try
    End Sub

    Private Sub cmbAño_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbAño.KeyPress
        e.Handled = True
    End Sub

    Private Sub cmbDia_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbDia.KeyPress
        e.Handled = True
    End Sub
End Class