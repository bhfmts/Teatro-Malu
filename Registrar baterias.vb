Public Class frmBaterias
    Dim intIDEquipo As Integer
    Dim Baterias As New ClassBaterias
    Dim Equipos As New ClassEquipos

    Private Sub btnRegistrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegistrar.Click
        'Validación de campos nulos
        Try
            If txtMarca.TextLength = 0 Then
                Baterias.CamposNulosTextBox(ErrorProviderBaterias, txtMarca) = txtMarca.Text
                Exit Sub
            Else
                Baterias.CamposNulosTextBox(ErrorProviderBaterias, txtMarca) = txtMarca.Text
            End If

            If txtModelo.TextLength = 0 Then
                Baterias.CamposNulosTextBox(ErrorProviderBaterias, txtModelo) = txtModelo.Text
                Exit Sub
            Else
                Baterias.CamposNulosTextBox(ErrorProviderBaterias, txtModelo) = txtModelo.Text
            End If

            If txtValorArriendo.TextLength = 0 Then
                Baterias.CamposNulosTextBox(ErrorProviderBaterias, txtValorArriendo) = txtValorArriendo.Text
                Exit Sub
            Else
                Baterias.CamposNulosTextBox(ErrorProviderBaterias, txtValorArriendo) = txtValorArriendo.Text
            End If

            If txtValorArriendo.Text > 500000 Then
                Equipos.PrecioArriendo(ErrorProviderBaterias, txtValorArriendo) = txtValorArriendo.Text
                Exit Sub
            Else
                Equipos.PrecioArriendo(ErrorProviderBaterias, txtValorArriendo) = txtValorArriendo.Text
            End If

            If txtNumeroToms.TextLength = 0 Then
                Baterias.CamposNulosTextBox(ErrorProviderBaterias, txtNumeroToms) = txtNumeroToms.Text
                Exit Sub
            Else
                Baterias.CamposNulosTextBox(ErrorProviderBaterias, txtNumeroToms) = txtNumeroToms.Text
            End If

            If txtNumeroPlatillos.TextLength = 0 Then
                Baterias.CamposNulosTextBox(ErrorProviderBaterias, txtNumeroPlatillos) = txtNumeroPlatillos.Text
                Exit Sub
            Else
                Baterias.CamposNulosTextBox(ErrorProviderBaterias, txtNumeroPlatillos) = txtNumeroPlatillos.Text
            End If

            If txtNumeroBombos.TextLength = 0 Then
                Baterias.CamposNulosTextBox(ErrorProviderBaterias, txtNumeroBombos) = txtNumeroBombos.Text
                Exit Sub
            Else
                Baterias.CamposNulosTextBox(ErrorProviderBaterias, txtNumeroBombos) = txtNumeroBombos.Text
            End If
            'Registro de bajos
            Me.EquiposTableAdapter1.InsertEquipos(txtMarca.Text, "DISPONIBLE", txtModelo.Text, Double.Parse(txtValorArriendo.Text))
            intIDEquipo = Me.EquiposTableAdapter1.SelectIDEquipo()
            Me.BateriasTableAdapter1.Insert(intIDEquipo, Integer.Parse(txtNumeroToms.Text), Integer.Parse(txtNumeroBombos.Text), Integer.Parse(txtNumeroPlatillos.Text))
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
        txtNumeroToms.Clear()
        txtNumeroPlatillos.Clear()
        txtNumeroBombos.Clear()
        ErrorProviderBaterias.Clear()
    End Sub

    Private Sub frmBaterias_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim drResultado As DialogResult = MsgBox("Asegúrese de haber completado correctamente sus operaciones. ¿Está seguro que desea cerrar? ", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Registro baterías")
        If drResultado = vbNo Then
            e.Cancel = True
        Else
            LimpiarControles()
        End If
    End Sub
    'Validación sólo números
    Private Sub txtNumeroBombos_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNumeroBombos.KeyPress
        If (Asc(e.KeyChar)) >= 48 And (Asc(e.KeyChar)) <= 57 Or (Asc(e.KeyChar)) = System.Windows.Forms.Keys.Back Or Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    'Validación sólo números
    Private Sub txtNumeroPlatillos_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNumeroPlatillos.KeyPress
        If (Asc(e.KeyChar)) >= 48 And (Asc(e.KeyChar)) <= 57 Or (Asc(e.KeyChar)) = System.Windows.Forms.Keys.Back Or Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    'Validación sólo números
    Private Sub txtNumeroToms_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNumeroToms.KeyPress
        If (Asc(e.KeyChar)) >= 48 And (Asc(e.KeyChar)) <= 57 Or (Asc(e.KeyChar)) = System.Windows.Forms.Keys.Back Or Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
End Class