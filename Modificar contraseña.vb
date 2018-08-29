Imports Teatro.ClassAdministrador
Imports Teatro.ClassVendedor
Imports Teatro.ClassProductor
Public Class frmModificarContraseña
    'Se realiza la operación de modificar la contraseña según el perfil que esté identificado
    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        If BuscarRUNVendedor(strRUNUsuario) = True Then
            If Me.VendedoresTableAdapter1.SelectContraseVendedor(strRUNUsuario) = txtContraseñaActual.Text Then
                If txtContraseñaNueva.Text = txtConfirmarContraseña.Text Then
                    Me.VendedoresTableAdapter1.UpdateContraseña(txtContraseñaNueva.Text, strRUNUsuario)
                    MsgBox("Contraseña modificada satisfactoriamente", MsgBoxStyle.Information, "Modificar contraseña")
                Else
                    MsgBox("Las contraseñas no coinciden", MsgBoxStyle.Critical, "Modificar contraseña")
                End If
            Else
                MsgBox("Su contraseña está incorrecta", MsgBoxStyle.Critical, "Modificar contraseña")
            End If
        ElseIf BuscarRUNProductor(strRUNUsuario) = True Then
            If Me.ProduccionTableAdapter1.SelectContrasenaEncargado(strRUNUsuario) = txtContraseñaActual.Text Then
                If txtContraseñaNueva.Text = txtConfirmarContraseña.Text Then
                    Me.ProduccionTableAdapter1.UpdateContraseña(txtContraseñaNueva.Text, strRUNUsuario)
                    MsgBox("Contraseña modificada satisfactoriamente", MsgBoxStyle.Information, "Modificar contraseña")
                Else
                    MsgBox("Las contraseñas no coinciden", MsgBoxStyle.Critical, "Modificar contraseña")
                End If
            Else
                MsgBox("Su contraseña está incorrecta", MsgBoxStyle.Critical, "Modificar contraseña")
            End If
        ElseIf BuscarRUNAdministrador(strRUNUsuario) = True Then
            If Me.AdministradoresTableAdapter1.SelectContraseñaAdministrador(strRUNUsuario) = txtContraseñaActual.Text Then
                If txtContraseñaNueva.Text = txtConfirmarContraseña.Text Then
                    Me.AdministradoresTableAdapter1.UpdateContraseña(txtContraseñaNueva.Text, strRUNUsuario)
                    MsgBox("Contraseña modificada satisfactoriamente", MsgBoxStyle.Information, "Modificar contraseña")
                Else
                    MsgBox("Las contraseñas no coinciden", MsgBoxStyle.Critical, "Modificar contraseña")
                End If
            Else
                MsgBox("Su contraseña está incorrecta", MsgBoxStyle.Critical, "Modificar contraseña")
            End If

        End If
    End Sub

    Private Sub frmModificarContraseña_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim drResultado As DialogResult = MsgBox("Asegúrese de haber completado correctamente sus operaciones. ¿Está seguro que desea cerrar? ", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Registro eventos")
        If drResultado = vbNo Then
            e.Cancel = True
        Else
            Me.Dispose()
        End If
    End Sub
End Class