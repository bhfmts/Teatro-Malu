Public Class frmAmplificadores
    Dim intIDEquipo As Integer
    'Registro de amplificadores
    Private Sub btnRegistrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegistrar.Click
        Dim Amplificadores As New ClassAmplificadores
        Dim Equipos As New ClassEquipos
        Try
            If txtMarca.TextLength = 0 Then
                Amplificadores.CamposNulosTextBox(ErrorProviderAmplificadores, txtMarca) = txtMarca.Text
                Exit Sub
            Else
                Amplificadores.CamposNulosTextBox(ErrorProviderAmplificadores, txtMarca) = txtMarca.Text
            End If

            If txtModelo.TextLength = 0 Then
                Amplificadores.CamposNulosTextBox(ErrorProviderAmplificadores, txtModelo) = txtModelo.Text
                Exit Sub
            Else
                Amplificadores.CamposNulosTextBox(ErrorProviderAmplificadores, txtModelo) = txtModelo.Text
            End If

            If txtValorArriendo.TextLength = 0 Then
                Amplificadores.CamposNulosTextBox(ErrorProviderAmplificadores, txtValorArriendo) = txtValorArriendo.Text
                Exit Sub
            Else
                Amplificadores.CamposNulosTextBox(ErrorProviderAmplificadores, txtValorArriendo) = txtValorArriendo.Text
            End If

            If txtValorArriendo.Text > 500000 Then
                Equipos.PrecioArriendo(ErrorProviderAmplificadores, txtValorArriendo) = txtValorArriendo.Text
                Exit Sub
            Else
                Equipos.PrecioArriendo(ErrorProviderAmplificadores, txtValorArriendo) = txtValorArriendo.Text
            End If

            If txtWatts.TextLength = 0 Then
                Amplificadores.CamposNulosTextBox(ErrorProviderAmplificadores, txtWatts) = txtWatts.Text
                Exit Sub
            Else
                Amplificadores.CamposNulosTextBox(ErrorProviderAmplificadores, txtWatts) = txtWatts.Text
            End If

            If cmbTipoAmpli.Text = "" Then
                Amplificadores.CamposNulosComboBox(ErrorProviderAmplificadores, cmbTipoAmpli) = cmbTipoAmpli.Text
                Exit Sub
            Else
                Amplificadores.CamposNulosComboBox(ErrorProviderAmplificadores, cmbTipoAmpli) = cmbTipoAmpli.Text
            End If

            'Registro de amplificadores en la base de datos

            Me.EquiposTableAdapter1.InsertEquipos(txtMarca.Text, "DISPONIBLE", txtModelo.Text, Integer.Parse(txtValorArriendo.Text))
            intIDEquipo = Me.EquiposTableAdapter1.SelectIDEquipo()
            Me.AmplificadoresTableAdapter1.Insert(intIDEquipo, Integer.Parse(txtWatts.Text), cmbTipoAmpli.Text)
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
        txtWatts.Clear()
        cmbTipoAmpli.SelectedIndex = -1
        ErrorProviderAmplificadores.Clear()

    End Sub
    'Validación ingreso sólo números
    Private Sub txtWatts_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtWatts.KeyPress
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

    'Cerrar formulario
    Private Sub Amplificadores_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim drResultado As DialogResult = MsgBox("Asegúrese de haber completado correctamente sus operaciones. ¿Está seguro que desea cerrar? ", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Registro eventos")
        If drResultado = vbNo Then
            e.Cancel = True
        Else
            LimpiarControles()
            Me.Dispose()
        End If

    End Sub

    Private Sub btnLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpiar.Click
        LimpiarControles()
    End Sub
End Class