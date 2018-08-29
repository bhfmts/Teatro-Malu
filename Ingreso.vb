Imports Teatro.ClassVendedor
Imports Teatro.ClassProductor
Imports Teatro.ClassAdministrador
Public Class frmIngreso

   

    Private Sub Ingreso_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CenterToParent()
        'Me.txtRUNusuario.Text = "77777775"
        'Me.txtGuion.Text = "0"
        'Me.txtContraseñaUsuario.Text = "1234"
        'Me.txtRUNusuario.Text = "15519461"
        'Me.txtGuion.Text = "8"
        'Me.txtContraseñaUsuario.Text = "1234567"
        Me.txtRUNusuario.Text = "4741033"
        Me.txtGuion.Text = "9"
        Me.txtContraseñaUsuario.Text = "1234567"

        'Me.AcceptButton = btnIngresar
        'Me.CancelButton = btnSalir

    End Sub

    Private Sub btnIngresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIngresar.Click
        'Concatenación del campo RUNusuario con el valor del campo guión
        Try
            strRUNUsuario = txtRUNusuario.Text + "-" + txtGuion.Text

            If Not IsNumeric(txtRUNusuario.Text) OrElse String.IsNullOrEmpty(txtRUNusuario.Text) Then
                ErrorProvider1.SetError(txtRUNusuario, "Ingrese un valor númerico")
                Exit Sub
            Else
                ErrorProvider1.SetError(txtRUNusuario, "")
            End If

            'If String.IsNullOrEmpty(txtContraseñaUsuario.Text) Then
            '    ErrorProvider1.SetError(txtContraseñaUsuario, "Este campo es obligatorio")
            '    Exit Sub
            'Else
            '    ErrorProvider1.SetError(txtContraseñaUsuario, "")
            'End If
            If String.IsNullOrEmpty(txtGuion.Text) Then
                ErrorProvider1.SetError(txtGuion, "Campo obligatorio")
                Exit Sub
            Else
                ErrorProvider1.SetError(txtGuion, "")
            End If
            Dim ca As Boolean
            ca = VerificaRut(txtRUNusuario.Text, txtGuion.Text)
            'Validación del campo RUN
            If ca = True Then
            ElseIf ca = False And txtGuion.Text <> "" And txtRUNusuario.Text <> "" Then
                ErrorProvider1.Clear()
                ErrorProvider1.SetError(txtGuion, "El R.U.N. está incorrecto")
                txtRUNusuario.Focus()
                Exit Sub
            End If
            If ca = True Then
                ErrorProvider1.SetError(txtGuion, "")
            End If
            'Capturación del perfil del vendedor según el RUN ingresado

            If BuscarRUNAdministrador(strRUNUsuario) = True Then
                intPerfilUsuario = 1

            ElseIf BuscarRUNVendedor(strRUNUsuario) = True And BuscarRUNProductor(strRUNUsuario) = True Then
                intPerfilUsuario = 23

            ElseIf BuscarRUNVendedor(strRUNUsuario) = True And BuscarRUNProductor(strRUNUsuario) = False Then
                intPerfilUsuario = 3

            ElseIf BuscarRUNVendedor(strRUNUsuario) = False And BuscarRUNProductor(strRUNUsuario) = True Then
                intPerfilUsuario = 2
            End If


            If ca = True Then

                'Validación de usuario y contraseña

                If intPerfilUsuario = 1 Then
                    If Me.ADMINISTRADORESTableAdapter.SelectRUNAdministrador(strRUNUsuario) = "1" And txtContraseñaUsuario.Text = Me.ADMINISTRADORESTableAdapter.SelectContraseñaAdministrador(strRUNUsuario).ToString Then
                        strNombreAdministrador = Me.ADMINISTRADORESTableAdapter.SelectNombreAdministrador(strRUNUsuario)
                        If Me.ADMINISTRADORESTableAdapter.SelectEstadoSesion(strRUNUsuario).Value = 0 Then
                            Me.ADMINISTRADORESTableAdapter.ActualizaEstadoSesion(1, strRUNUsuario)
                            strRUNEncargadoo = strRUNUsuario
                            Me.Close()
                        Else
                            'Me.ADMINISTRADORESTableAdapter.ActualizaEstadoSesion(1, strRUNUsuario)
                            MsgBox("Este perfil está actualmente activo en el sistema", MsgBoxStyle.Information, "Ingreso")
                            intPerfilUsuario = 8
                            Exit Sub
                        End If
                    Else
                        MsgBox("Usuario o contraseña incorrecta", MsgBoxStyle.Critical)
                        Exit Sub
                    End If

                End If
                If intPerfilUsuario = 3 Then
                    If Me.VENDEDORESTableAdapter.SelectRUNVendedor(strRUNUsuario) = 1 And txtContraseñaUsuario.Text = Me.VENDEDORESTableAdapter.SelectContraseVendedor(strRUNUsuario).ToString Then
                        'Capturación del nombre del vendedor según el RUN ingresado
                        strNombreVendedor = Me.VENDEDORESTableAdapter.SelectNombreVendedor(strRUNUsuario)
                        If Me.VENDEDORESTableAdapter.SelectEstadoSesion(strRUNUsuario) = 0 Then
                            Me.VENDEDORESTableAdapter.ActualizaEstadoSesion(1, strRUNUsuario)
                            strRUNEncargadoo = strRUNUsuario
                            Me.Close()
                        Else
                            'Me.ADMINISTRADORESTableAdapter.ActualizaEstadoSesion(1, strRUNUsuario)
                            MsgBox("Este perfil está actualmente activo en el sistema", MsgBoxStyle.Information, "Ingreso")
                            intPerfilUsuario = 8
                            Exit Sub
                        End If
                        Me.Close()
                    Else
                        MsgBox("Usuario o contraseña incorrecta", MsgBoxStyle.Critical)
                    End If

                End If
            End If
            If intPerfilUsuario = 2 Then
                If Me.PRODUCCIONTableAdapter.SelectRUNEncargado(strRUNUsuario) = 1 And txtContraseñaUsuario.Text = Me.PRODUCCIONTableAdapter.SelectContrasenaEncargado(strRUNUsuario).ToString Then
                    strNombreProduccion = Me.PRODUCCIONTableAdapter.SelectNombreEncargado(strRUNUsuario)
                    If Me.PRODUCCIONTableAdapter.SelectEstadoSesion(strRUNUsuario) = 0 Then
                        Me.PRODUCCIONTableAdapter.ActualizaEstadoSesion(1, strRUNUsuario)
                        strRUNEncargadoo = strRUNUsuario
                        Me.Close()
                    Else
                        'Me.ADMINISTRADORESTableAdapter.ActualizaEstadoSesion(1, strRUNUsuario)
                        MsgBox("Este perfil está actualmente activo en el sistema", MsgBoxStyle.Information, "Ingreso")
                        intPerfilUsuario = 8
                        Exit Sub
                    End If
                    strRUNEncargadoo = strRUNUsuario
                    Me.Close()
                Else
                    MsgBox("Usuario o contraseña incorrecta", MsgBoxStyle.Critical)
                End If
            End If
            If intPerfilUsuario = 23 Then
                If Me.PRODUCCIONTableAdapter.SelectRUNEncargado(strRUNUsuario) = 1 And txtContraseñaUsuario.Text = Me.PRODUCCIONTableAdapter.SelectContrasenaEncargado(strRUNUsuario).ToString Then
                    strNombreProduccion = Me.PRODUCCIONTableAdapter.SelectNombreEncargado(strRUNUsuario)
                    If Me.PRODUCCIONTableAdapter.SelectEstadoSesion(strRUNUsuario) = 0 Or Me.VENDEDORESTableAdapter.SelectEstadoSesion(strRUNUsuario) = 0 Then
                        Me.PRODUCCIONTableAdapter.ActualizaEstadoSesion(1, strRUNUsuario)
                        Me.VENDEDORESTableAdapter.ActualizaEstadoSesion(1, strRUNUsuario)
                        strRUNEncargadoo = strRUNUsuario
                        Me.Close()
                    Else
                        'Me.ADMINISTRADORESTableAdapter.ActualizaEstadoSesion(1, strRUNUsuario)
                        MsgBox("Este perfil está actualmente activo en el sistema", MsgBoxStyle.Information, "Ingreso")
                        intPerfilUsuario = 8
                        Exit Sub
                    End If
                    strRUNEncargadoo = strRUNUsuario
                    Me.Close()
                Else
                    MsgBox("Usuario o contraseña incorrecta", MsgBoxStyle.Critical)
                End If
            End If
            If intPerfilUsuario <> 1 And intPerfilUsuario <> 2 And intPerfilUsuario <> 3 And intPerfilUsuario <> 23 Then
                MsgBox("La cuenta de usuario no existe", MsgBoxStyle.Critical, "Ingreso")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub
    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Try
            If intPerfilUsuario = 1 Then
                Me.ADMINISTRADORESTableAdapter.ActualizaEstadoSesion(0, strRUNUsuario)
            ElseIf intPerfilUsuario = 23 Then
                Me.PRODUCCIONTableAdapter.ActualizaEstadoSesion(0, strRUNUsuario)
                Me.VendedoresTableAdapter1.ActualizaEstadoSesion(0, strRUNUsuario)
            ElseIf intPerfilUsuario = 2 Then
                Me.PRODUCCIONTableAdapter.ActualizaEstadoSesion(0, strRUNUsuario)
            ElseIf intPerfilUsuario = 3 Then
                Me.VENDEDORESTableAdapter.ActualizaEstadoSesion(0, strRUNUsuario)
            End If
            Application.Exit()
        Catch ex As Exception
            MsgBox("Se produjo el siguiente error: " & ex.Message, MsgBoxStyle.Critical)
        End Try

    End Sub
    '***************************************************************************************************************************************************
    'Aquí impido el ingreso de letras y otros, sólo números
    Private Sub txtRUNusuario_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRUNusuario.KeyPress
        If (Asc(e.KeyChar)) >= 48 And (Asc(e.KeyChar)) <= 57 Or (Asc(e.KeyChar)) = System.Windows.Forms.Keys.Back Or Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtGuion_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtGuion.Validating
        Dim ca As Boolean
        ca = VerificaRut(txtRUNusuario.Text, txtGuion.Text)
        'Validación del campo RUN
        If ca = True Then
        ElseIf ca = False And txtGuion.Text <> "" And txtRUNusuario.Text <> "" Then
            ErrorProvider1.Clear()
            ErrorProvider1.SetError(txtGuion, "El R.U.N. está incorrecto")
            txtRUNusuario.Focus()
            Exit Sub
        End If
    End Sub
End Class
