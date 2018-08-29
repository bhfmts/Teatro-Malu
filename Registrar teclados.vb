Public Class frmTeclados
    Dim Teclados As New ClassTeclados
    Dim Equipos As New ClassEquipos
    Dim intIDEquipo As Integer

    Private Sub btnRegistrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegistrar.Click
        Try
            If txtMarca.TextLength = 0 Then
                Teclados.CamposNulosTextBox(ErrorProviderTeclados, txtMarca) = txtMarca.Text
                Exit Sub
            Else
                Teclados.CamposNulosTextBox(ErrorProviderTeclados, txtMarca) = txtMarca.Text
            End If

            If txtModelo.TextLength = 0 Then
                Teclados.CamposNulosTextBox(ErrorProviderTeclados, txtModelo) = txtModelo.Text
                Exit Sub
            Else
                Teclados.CamposNulosTextBox(ErrorProviderTeclados, txtModelo) = txtModelo.Text
            End If

            If txtValorArriendo.TextLength = 0 Then
                Teclados.CamposNulosTextBox(ErrorProviderTeclados, txtValorArriendo) = txtValorArriendo.Text
                Exit Sub
            Else
                Teclados.CamposNulosTextBox(ErrorProviderTeclados, txtValorArriendo) = txtValorArriendo.Text
            End If

            If txtValorArriendo.Text > 500000 Then
                Equipos.PrecioArriendo(ErrorProviderTeclados, txtValorArriendo) = txtValorArriendo.Text
                Exit Sub
            Else
                Equipos.PrecioArriendo(ErrorProviderTeclados, txtValorArriendo) = txtValorArriendo.Text
            End If

            If txtNumeroOctavas.TextLength = 0 Then
                Teclados.CamposNulosTextBox(ErrorProviderTeclados, txtNumeroOctavas) = txtNumeroOctavas.Text
                Exit Sub
            Else
                Teclados.CamposNulosTextBox(ErrorProviderTeclados, txtNumeroOctavas) = txtNumeroOctavas.Text
            End If

            If cmbTipoTecla.Text = "" Then
                Teclados.CamposNulosComboBox(ErrorProviderTeclados, cmbTipoTecla) = cmbTipoTecla.Text
                Exit Sub
            Else
                Teclados.CamposNulosComboBox(ErrorProviderTeclados, cmbTipoTecla) = cmbTipoTecla.Text
            End If

            'Registro de teclados en la base de datos

            Me.EquiposTableAdapter1.InsertEquipos(txtMarca.Text, "DISPONIBLE", txtModelo.Text, Integer.Parse(txtValorArriendo.Text))
            intIDEquipo = Me.EquiposTableAdapter1.SelectIDEquipo()
            Me.TecladosTableAdapter1.Insert(intIDEquipo, txtNumeroOctavas.Text, cmbTipoTecla.Text)
            MsgBox("Registro correcto", MsgBoxStyle.Information, "Registro mesas")
            LimpiarControles()
        Catch ex As Exception
            MsgBox("Se produjo el siguiente error: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    'Limpiar controles
    Public Sub LimpiarControles()
        txtMarca.Clear()
        txtModelo.Clear()
        txtValorArriendo.Clear()
        txtNumeroOctavas.Clear()
        cmbTipoTecla.SelectedIndex = -1
        ErrorProviderTeclados.Clear()
    End Sub
    'Validación ingreso sólo números
    Private Sub txtNumeroOctavas_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNumeroOctavas.KeyPress
        If (Asc(e.KeyChar)) >= 48 And (Asc(e.KeyChar)) <= 57 Or (Asc(e.KeyChar)) = System.Windows.Forms.Keys.Back Or Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    'Validación ingreso sólo números
    Private Sub txtValorArriendo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtValorArriendo.KeyPress
        If (Asc(e.KeyChar)) >= 48 And (Asc(e.KeyChar)) <= 57 Or (Asc(e.KeyChar)) = System.Windows.Forms.Keys.Back Or Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    'Cerrando formulario
    Private Sub Teclados_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim drResultado As DialogResult = MsgBox("Asegúrese de haber completado correctamente sus operaciones. ¿Está seguro que desea cerrar? ", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Registro eventos")
        If drResultado = vbNo Then
            e.Cancel = True
        Else
            LimpiarControles()
        End If
    End Sub

    Private Sub btnLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpiar.Click
        LimpiarControles()
    End Sub
End Class