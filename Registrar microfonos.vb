Public Class frmMicrofonos
    Dim intIDEquipo As Integer
    Dim Equipos As New ClassEquipos

    Private Sub btnRegistrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegistrar.Click
        Dim Microfono As New ClassMicrofonos
        Try
            If txtMarca.TextLength = 0 Then
                Microfono.CamposNulosTextBox(ErrorProviderMicrofonos, txtMarca) = txtMarca.Text
                Exit Sub
            Else
                Microfono.CamposNulosTextBox(ErrorProviderMicrofonos, txtMarca) = txtMarca.Text
            End If

            If txtModelo.TextLength = 0 Then
                Microfono.CamposNulosTextBox(ErrorProviderMicrofonos, txtModelo) = txtModelo.Text
                Exit Sub
            Else
                Microfono.CamposNulosTextBox(ErrorProviderMicrofonos, txtModelo) = txtModelo.Text
            End If

            If txtValorArriendo.TextLength = 0 Then
                Microfono.CamposNulosTextBox(ErrorProviderMicrofonos, txtValorArriendo) = txtValorArriendo.Text
                Exit Sub
            Else
                Microfono.CamposNulosTextBox(ErrorProviderMicrofonos, txtValorArriendo) = txtValorArriendo.Text
            End If

            If txtValorArriendo.Text > 500000 Then
                Equipos.PrecioArriendo(ErrorProviderMicrofonos, txtValorArriendo) = txtValorArriendo.Text
                Exit Sub
            Else
                Equipos.PrecioArriendo(ErrorProviderMicrofonos, txtValorArriendo) = txtValorArriendo.Text
            End If

            If cmbTipo.Text = "" Then
                Microfono.CamposNulosComboBox(ErrorProviderMicrofonos, cmbTipo) = cmbTipo.Text
                Exit Sub
            Else
                Microfono.CamposNulosComboBox(ErrorProviderMicrofonos, cmbTipo) = cmbTipo.Text
            End If
            'Registro de micrófonos en la base de datos

            Me.EquiposTableAdapter1.InsertEquipos(txtMarca.Text, "DISPONIBLE", txtModelo.Text, txtValorArriendo.Text)
            intIDEquipo = Me.EquiposTableAdapter1.SelectIDEquipo()
            Me.MicrofonosTableAdapter1.InsertMicrofonos(intIDEquipo, cmbTipo.Text)
            MsgBox("Registro correcto", MsgBoxStyle.Information, "Registro micrófono")
            LimpiarControles()
            Me.EquiposTableAdapter1.Dispose()
        Catch ex As Exception
            MsgBox("Se produjo el siguiente error: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    'Limpiar controles
    Public Sub LimpiarControles()
        txtMarca.Clear()
        txtModelo.Clear()
        txtValorArriendo.Clear()
        cmbTipo.SelectedIndex = -1
        ErrorProviderMicrofonos.Clear()

    End Sub
    'Limpiar los controles
    Private Sub btnLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpiar.Click
        LimpiarControles()
    End Sub

    'Validación para evitar modificar el contenido del control
    Private Sub cmbTipo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbTipo.KeyPress
        e.Handled = True
    End Sub
    'Validación ingreso sólo números
    Private Sub txtValorArriendo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtValorArriendo.KeyPress
        If (Asc(e.KeyChar)) >= 48 And (Asc(e.KeyChar)) <= 57 Or (Asc(e.KeyChar)) = System.Windows.Forms.Keys.Back Or Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    'Cerrando el formulario
    Private Sub frmMicrofonos_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim drResultado As DialogResult = MsgBox("Asegúrese de haber completado correctamente sus operaciones. ¿Está seguro que desea cerrar? ", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Registro eventos")
        If drResultado = vbNo Then
            e.Cancel = True
        Else
            LimpiarControles()
        End If
    End Sub


End Class