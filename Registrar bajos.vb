Public Class frmBajos
    Dim intIDEquipo As Integer
    Dim Equipos As New ClassEquipos
    Dim Bajos As New ClassBajos
    Private Sub btnRegistrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegistrar.Click
        'Validación de campos nulos
        Try
            If txtMarca.TextLength = 0 Then
                Bajos.CamposNulosTextBox(ErrorProviderBajos, txtMarca) = txtMarca.Text
                Exit Sub
            Else
                Bajos.CamposNulosTextBox(ErrorProviderBajos, txtMarca) = txtMarca.Text
            End If

            If txtModelo.TextLength = 0 Then
                Bajos.CamposNulosTextBox(ErrorProviderBajos, txtModelo) = txtModelo.Text
                Exit Sub
            Else
                Bajos.CamposNulosTextBox(ErrorProviderBajos, txtModelo) = txtModelo.Text
            End If

            If txtValorArriendo.TextLength = 0 Then
                Bajos.CamposNulosTextBox(ErrorProviderBajos, txtValorArriendo) = txtValorArriendo.Text
                Exit Sub
            Else
                Bajos.CamposNulosTextBox(ErrorProviderBajos, txtValorArriendo) = txtValorArriendo.Text
            End If

            If txtValorArriendo.Text > 500000 Then
                Equipos.PrecioArriendo(ErrorProviderBajos, txtValorArriendo) = txtValorArriendo.Text
                Exit Sub
            Else
                Equipos.PrecioArriendo(ErrorProviderBajos, txtValorArriendo) = txtValorArriendo.Text
            End If

            If txtNumeroEspacios.TextLength = 0 Then
                Bajos.CamposNulosTextBox(ErrorProviderBajos, txtNumeroEspacios) = txtNumeroEspacios.Text
                Exit Sub
            Else
                Bajos.CamposNulosTextBox(ErrorProviderBajos, txtNumeroEspacios) = txtNumeroEspacios.Text
            End If

            If txtNumeroCuerdas.TextLength = 0 Then
                Bajos.CamposNulosTextBox(ErrorProviderBajos, txtNumeroCuerdas) = txtNumeroCuerdas.Text
                Exit Sub
            Else
                Bajos.CamposNulosTextBox(ErrorProviderBajos, txtNumeroCuerdas) = txtNumeroCuerdas.Text
            End If

            If cmbTipoCuerda.Text = "" Then
                Bajos.CamposNulosComboBox(ErrorProviderBajos, cmbTipoCuerda) = cmbTipoCuerda.Text
                Exit Sub
            Else
                Bajos.CamposNulosComboBox(ErrorProviderBajos, cmbTipoCuerda) = cmbTipoCuerda.Text
            End If

            If cmbPastillas.Text = "" Then
                Bajos.CamposNulosComboBox(ErrorProviderBajos, cmbPastillas) = cmbPastillas.Text
                Exit Sub
            Else
                Bajos.CamposNulosComboBox(ErrorProviderBajos, cmbPastillas) = cmbPastillas.Text
            End If


            If cmbAmplificacion.Text = "" Then
                Bajos.CamposNulosComboBox(ErrorProviderBajos, cmbAmplificacion) = cmbAmplificacion.Text
                Exit Sub
            Else
                Bajos.CamposNulosComboBox(ErrorProviderBajos, cmbAmplificacion) = cmbAmplificacion.Text
            End If
            'Registro de bajos
            Me.EquiposTableAdapter1.InsertEquipos(txtMarca.Text, "DISPONIBLE", txtModelo.Text, Double.Parse(txtValorArriendo.Text))
            intIDEquipo = Me.EquiposTableAdapter1.SelectIDEquipo()
            Me.BajosTableAdapter1.Insert(intIDEquipo, cmbTipoCuerda.Text, txtNumeroEspacios.Text, txtNumeroCuerdas.Text, cmbPastillas.Text, cmbAmplificacion.Text)
            MsgBox("Registro correcto", MsgBoxStyle.Information, "Registro guitarra")
            LimpiarControles()
            Me.EquiposTableAdapter1.Dispose()
        Catch ex As Exception
            MsgBox("Se produjo el siguiente error: " & ex.Message, MsgBoxStyle.Critical, "Teatro")
        End Try
    End Sub

    'Limpiar controles
    Public Sub LimpiarControles()
        txtMarca.Clear()
        txtModelo.Clear()
        txtValorArriendo.Clear()
        txtNumeroEspacios.Clear()
        txtNumeroCuerdas.Clear()
        cmbPastillas.SelectedIndex = -1
        cmbTipoCuerda.SelectedIndex = -1
        cmbAmplificacion.SelectedIndex = -1
        ErrorProviderBajos.Clear()
    End Sub
    'Validación sólo números
    Private Sub txtValorArriendo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtValorArriendo.KeyPress
        If (Asc(e.KeyChar)) >= 48 And (Asc(e.KeyChar)) <= 57 Or (Asc(e.KeyChar)) = System.Windows.Forms.Keys.Back Or Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    'Validación sólo números
    Private Sub txtNumeroEspacios_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNumeroEspacios.KeyPress
        If (Asc(e.KeyChar)) >= 48 And (Asc(e.KeyChar)) <= 57 Or (Asc(e.KeyChar)) = System.Windows.Forms.Keys.Back Or Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    'Validación sólo números
    Private Sub txtNumeroCuerdas_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNumeroCuerdas.KeyPress
        If (Asc(e.KeyChar)) >= 48 And (Asc(e.KeyChar)) <= 57 Or (Asc(e.KeyChar)) = System.Windows.Forms.Keys.Back Or Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub


    Private Sub btnLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpiar.Click
        LimpiarControles()
    End Sub

    'Cerrar formulario
    Private Sub frmBajos_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim drResultado As DialogResult = MsgBox("Asegúrese de haber completado correctamente sus operaciones. ¿Está seguro que desea cerrar? ", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Registro bajos")
        If drResultado = vbNo Then
            e.Cancel = True
        Else
            LimpiarControles()
        End If
    End Sub
End Class