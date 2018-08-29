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
        'Llenar el D�a
        Dim i As Integer
        For i = 1 To 31
            cmbDia.Items.Add(i)
        Next
        'Llenar los Meses del A�o
        For i = 1 To 12
            cmbMes.Items.Add(MonthName(i, False))
        Next
        'Al ingresar el rango para los a�os existen
        'ingreso del a�o 1960 hasta el a�o actual
        For i = 1940 To Year(Now)
            cmbA�o.Items.Add(i)
        Next
    End Sub
    '*********************************************************************************************************************************************************************************
    'Operaciones que se realizan en el evento click del bot�n buscar
    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        CamposNulos(Me.ErrorProviderModificarUsuario, txtRUNUsuario)
        CamposNulos(Me.ErrorProviderModificarUsuario, txtGuion)
        'Validaci�n del campo RUN
        ca = VerificaRut(txtRUNUsuario.Text, txtGuion.Text)
        If ca = True Then
        ElseIf ca = False Then
            ErrorProviderModificarUsuario.Clear()
            ErrorProviderModificarUsuario.SetError(txtGuion, "El R.U.N. est� incorrecto")
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
                Me.txtContrase�a.Text = DR("CONTRASENAVENDEDOR")
                Me.txtConfirmaContrase�a.Text = DR("CONTRASENAVENDEDOR")
                'Asigno la fecha a variable tipo date
                dtFechaNac = DR("FECHANACVENDEDOR")
                'Descompongo la fecha en dia, mes y a�o
                strDia = Format(CDate(dtFechaNac), "dd")
                strMes = Format(Month(dtFechaNac), "")
                strA�o = Format(Year(dtFechaNac), "")
                cmbA�o.Text = strA�o
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
                Me.txtContrase�a.Text = DR("CONTRASENAENCARGADO")
                Me.txtConfirmaContrase�a.Text = DR("CONTRASENAENCARGADO")
                'Asigno la fecha a variable tipo date
                dtFechaNac = DR("FECHANACENCARGADO")
                'Descompongo la fecha en dia, mes y a�o
                strDia = Format(CDate(dtFechaNac), "dd")
                strMes = Format(Month(dtFechaNac), "")
                strA�o = Format(Year(dtFechaNac), "")
                cmbA�o.Text = strA�o
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
                Me.txtContrase�a.Text = DR("CONTRASENAADMINISTRADOR")
                Me.txtConfirmaContrase�a.Text = DR("CONTRASENAADMINISTRADOR")
                'Asigno la fecha a variable tipo date
                dtFechaNac = DR("FECHANACADMINISTRADOR")
                'Descompongo la fecha en dia, mes y a�o
                strDia = Format(CDate(dtFechaNac), "dd")
                strMes = Format(Month(dtFechaNac), "")
                strA�o = Format(Year(dtFechaNac), "")
                cmbA�o.Text = strA�o
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
                Me.txtContrase�a.Text = DR("CONTRASENACLIENTE")
                Me.txtConfirmaContrase�a.Text = DR("CONTRASENACLIENTE")
                'Asigno la fecha a variable tipo date
                dtFechaNac = DR("FECHANACCLIENTE")
                'Descompongo la fecha en dia, mes y a�o
                strDia = Format(CDate(dtFechaNac), "dd")
                strMes = Format(Month(dtFechaNac), "")
                strA�o = Format(Year(dtFechaNac), "")
                cmbA�o.Text = strA�o
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
            MsgBox("El R.U.N. ingresado no est� registrado en el sistema", MsgBoxStyle.Critical)
            txtRUNUsuario.Clear()
            txtGuion.Clear()
            txtNombresUsuario.Clear()
            txtApellidosUsuario.Clear()
            txtDireccionUsuario.Clear()
            txtTelefonoUsuario.Clear()
            cmbDia.Text = ""
            cmbMes.Text = ""
            cmbA�o.Text = ""
            Me.txtConfirmaContrase�a.Clear()
            Me.txtContrase�a.Clear()
        End If

    End Sub
    'Cerrando formulario...
    Private Sub frmModificarUsuario_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim drResultado As DialogResult = MsgBox("Aseg�rese de haber completado correctamente sus operaciones. �Est� seguro que desea cerrar? ", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Registro eventos")
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
    'Validaci�n de super usuario
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
    'Operaciones que se realizan en el evento click del bot�n actualizar
    Private Sub btnActualizarVendedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizarVendedor.Click
        Dim Persona As New ClassPersona
        'Persona.strContrase�a = Me.txtContrase�a.Text
        'Persona.strContrase�a = Me.txtConfirmaContrase�a.Text
        Try
            'Validaci�n campos nulos
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
            ElseIf CamposNulos(ErrorProviderModificarUsuario, txtContrase�a) = True Then
                Exit Sub
            ElseIf CamposNulos(ErrorProviderModificarUsuario, txtConfirmaContrase�a) = True Then
                Exit Sub
            ElseIf ValidaSoloLetras(ErrorProviderModificarUsuario, txtNombresUsuario) = True Then
                Exit Sub
            ElseIf ValidaSoloLetras(ErrorProviderModificarUsuario, txtApellidosUsuario) = True Then
                Exit Sub
            End If
            If txtContrase�a.Text <> txtConfirmaContrase�a.Text Then
                ErrorProviderModificarUsuario.SetError(txtContrase�a, "Los datos no coinciden")
                Me.txtContrase�a.Focus()
                Exit Sub
            Else
                ErrorProviderModificarUsuario.SetError(txtContrase�a, "")
            End If

            If txtContrase�a.TextLength < 7 Then
                ErrorProviderModificarUsuario.SetError(txtContrase�a, "M�nimo 7 caracteres")
                Me.txtContrase�a.Focus()
                Exit Sub
            Else
                ErrorProviderModificarUsuario.SetError(txtContrase�a, "")
            End If
            Dim vfecha As String
            Dim sfecha As String
            vfecha = Trim(cmbDia.Text) & "/" & Trim(Str(cmbMes.SelectedIndex + 1)) & "/" & Trim(cmbA�o.Text)
            If Microsoft.VisualBasic.IsDate(vfecha) = False Then
                Me.ErrorProviderModificarUsuario.SetError(Me.cmbA�o, " Fecha inv�lida")
                Exit Sub
            Else
                If ValidaEdad() = True Then
                    Exit Sub
                End If
                Me.ErrorProviderModificarUsuario.SetError(Me.cmbA�o, "")
            End If
            sfecha = vfecha
            'Actualizaci�n de vendedor
            If Me.rbdVendedor.Checked = True And BuscarRUNVendedor(strRUNModificar) = True Then

                Me.VendedoresTableAdapter1.UpdateVendedor(txtNombresUsuario.Text, txtApellidosUsuario.Text, _
                 Date.Parse(sfecha), txtDireccionUsuario.Text, txtTelefonoUsuario.Text, txtContrase�a.Text, strRUNModificar)
                drResultado = MsgBox("Actualizaci�n realizada satisfactoriamente." & vbCrLf & "�Desea continuar modificando el mismo Vendedor?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Modificar evento")
                If drResultado = vbNo Then
                    txtRUNUsuario.Clear()
                    txtGuion.Clear()
                    txtNombresUsuario.Clear()
                    txtApellidosUsuario.Clear()
                    txtDireccionUsuario.Clear()
                    txtTelefonoUsuario.Clear()
                    cmbDia.Text = ""
                    cmbMes.SelectedIndex = -1
                    cmbA�o.Text = ""
                    txtContrase�a.Clear()
                    txtConfirmaContrase�a.Clear()
                    btnActualizarVendedor.Enabled = False
                    txtRUNUsuario.Focus()
                    Me.ErrorProviderModificarUsuario.Clear()
                End If

                'Actualizaci�n de productor
            ElseIf Me.rdbProductor.Checked = True And BuscarRUNProductor(strRUNModificar) = True Then
                Try
                    Me.ProduccionTableAdapter1.UpdateProduccion(txtNombresUsuario.Text, txtApellidosUsuario.Text, _
                     Date.Parse(sfecha), txtDireccionUsuario.Text, txtTelefonoUsuario.Text, txtContrase�a.Text, strRUNModificar)
                    drResultado = MsgBox("Actualizaci�n realizada satisfactoriamente." & vbCrLf & "�Desea continuar modificando el mismo Productor?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Modificar evento")
                    If drResultado = vbNo Then
                        txtRUNUsuario.Clear()
                        txtGuion.Clear()
                        txtNombresUsuario.Clear()
                        txtApellidosUsuario.Clear()
                        txtDireccionUsuario.Clear()
                        txtTelefonoUsuario.Clear()
                        cmbDia.Text = ""
                        cmbMes.SelectedIndex = -1
                        cmbA�o.Text = ""
                        txtContrase�a.Clear()
                        txtConfirmaContrase�a.Clear()
                        btnActualizarVendedor.Enabled = False
                        txtRUNUsuario.Focus()
                        Me.ErrorProviderModificarUsuario.Clear()
                    End If
                Catch ex As SqlException
                    MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, "Modificar usuario")
                Catch ex As Exception
                    MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, "Modificar usuario")
                End Try
                'Actualizaci�n de administrador
            ElseIf Me.rdbAdministrador.Checked = True And BuscarRUNAdministrador(strRUNModificar) = True Then

                Me.AdministradoresTableAdapter1.UpdateAdministrador(txtNombresUsuario.Text, txtApellidosUsuario.Text, _
                 Date.Parse(sfecha), txtDireccionUsuario.Text, txtTelefonoUsuario.Text, txtContrase�a.Text, strRUNModificar)
                drResultado = MsgBox("Actualizaci�n realizada satisfactoriamente." & vbCrLf & "�Desea continuar modificando el mismo Administrador?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Modificar evento")
                If drResultado = vbNo Then
                    txtRUNUsuario.Clear()
                    txtGuion.Clear()
                    txtNombresUsuario.Clear()
                    txtApellidosUsuario.Clear()
                    txtDireccionUsuario.Clear()
                    txtTelefonoUsuario.Clear()
                    cmbDia.Text = ""
                    cmbMes.SelectedIndex = -1
                    cmbA�o.Text = ""
                    txtContrase�a.Clear()
                    txtConfirmaContrase�a.Clear()
                    btnActualizarVendedor.Enabled = False
                    txtRUNUsuario.Focus()
                    Me.ErrorProviderModificarUsuario.Clear()
                End If


                'Actualizaci�n cliente
            ElseIf Me.rdbCliente.Checked = True And BuscarRUNCliente(strRUNModificar) = True Then

                Me.ClientesTableAdapter1.UpdateCliente(txtNombresUsuario.Text, txtApellidosUsuario.Text, _
                 Date.Parse(sfecha), txtDireccionUsuario.Text, txtTelefonoUsuario.Text, txtContrase�a.Text, strRUNModificar)
                drResultado = MsgBox("Actualizaci�n realizada satisfactoriamente." & vbCrLf & "�Desea continuar modificando el mismo Cliente?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Modificar evento")
                If drResultado = vbNo Then
                    txtRUNUsuario.Clear()
                    txtGuion.Clear()
                    txtNombresUsuario.Clear()
                    txtApellidosUsuario.Clear()
                    txtDireccionUsuario.Clear()
                    txtTelefonoUsuario.Clear()
                    cmbDia.Text = ""
                    cmbMes.SelectedIndex = -1
                    cmbA�o.Text = ""
                    txtContrase�a.Clear()
                    txtConfirmaContrase�a.Clear()
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
    'Validaci�n de contrase�a
    Private Sub txtConfirmaContrase�a_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtConfirmaContrase�a.Validating
        If txtContrase�a.Text <> txtConfirmaContrase�a.Text Then
            ErrorProviderModificarUsuario.SetError(txtContrase�a, "Los datos no coinciden")
            Me.txtContrase�a.Focus()
            Exit Sub
        Else
            ErrorProviderModificarUsuario.SetError(txtContrase�a, "")
        End If

        If txtContrase�a.TextLength < 7 Then
            ErrorProviderModificarUsuario.SetError(txtContrase�a, "M�nimo 7 caracteres")
            Me.txtContrase�a.Focus()
            Exit Sub
        Else
            ErrorProviderModificarUsuario.SetError(txtContrase�a, "")
        End If
        CamposNulos(ErrorProviderModificarUsuario, txtConfirmaContrase�a)
    End Sub
    '*********************************************************************************************************************************************************************************
    'Funci�n validaci�n de la edad de vendedor
    Public Function ValidaEdad() As Boolean
        Dim intA�os As Integer
        Try
            dtFechaNac = Trim(cmbDia.Text) & "/" & Trim(Str(cmbMes.SelectedIndex + 1)) & "/" & Trim(cmbA�o.SelectedItem)
            intA�os = DateDiff(DateInterval.Year, dtFechaNac, Date.Now.Date)
            If intA�os >= 18 And dtFechaNac.Subtract(Date.Now.Date).TotalHours <= -157800 Then
                Return False
            Else
                MsgBox("El vendedor debe ser mayor de 18 a�os", MsgBoxStyle.Critical, "Registro vendedor")
                cmbA�o.Focus()
                Return True
                Exit Function
            End If
        Catch ex As Exception
            MsgBox("Faltan datos", MsgBoxStyle.Critical, "Registro vendedor")
        End Try
    End Function
    '*********************************************************************************************************************************************************************************
    'Validaci�n para que se ingresen s�lo n�meros en el campo telefono
    Private Sub txtTelefonoVendedor_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTelefonoUsuario.KeyPress
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
    'Validaci�n de la edad del vendedor
    'Private Sub cmbA�o_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cmbA�o.Validating
    '    ValidaEdad()
    'End Sub

    Private Sub txtGuion_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtGuion.Validating
        'Validaci�n del campo RUN
        ca = VerificaRut(txtRUNUsuario.Text, txtGuion.Text)
        If ca = True Then
        ElseIf ca = False Then
            ErrorProviderModificarUsuario.Clear()
            ErrorProviderModificarUsuario.SetError(txtGuion, "El R.U.N. est� incorrecto")
            txtRUNUsuario.Focus()
            Exit Sub
        End If
        If ca = True Then
            ErrorProviderModificarUsuario.SetError(txtGuion, "")
        End If
    End Sub
    'Validaci�n de campos nulos
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

    Private Sub txtContrase�a_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtContrase�a.Validating
        CamposNulos(ErrorProviderModificarUsuario, txtContrase�a)
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
                If Integer.Parse(cmbDia.Text) > 30 Then
                    ErrorProviderModificarUsuario.SetError(cmbDia, "El mes seleccionado tiene s�lo 30 d�as")
                    ErrorProviderModificarUsuario.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
                    cmbDia.Focus()
                    Exit Sub
                Else
                    ErrorProviderModificarUsuario.SetError(cmbDia, "")
                End If
            ElseIf cmbMes.GetItemText(cmbMes.Text) = "febrero" Then
                If Integer.Parse(cmbDia.Text) > 28 Then
                    ErrorProviderModificarUsuario.SetError(cmbDia, "El mes seleccionado tiene s�lo 28 d�as")
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

    Private Sub cmbA�o_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbA�o.KeyPress
        e.Handled = True
    End Sub

    Private Sub cmbDia_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbDia.KeyPress
        e.Handled = True
    End Sub
End Class