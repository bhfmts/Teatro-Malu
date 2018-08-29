Public Class frmAtriles
    Dim intIDEquipo As Integer

    Private Sub btnRegistrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegistrar.Click
        Dim Atriles As New ClassAtriles
        Dim Equipos As New ClassEquipos
        If txtMarca.TextLength = 0 Then
            Atriles.CamposNulosTextBox(ErrorProviderAtriles, txtMarca) = txtMarca.Text
            Exit Sub
        Else
            Atriles.CamposNulosTextBox(ErrorProviderAtriles, txtMarca) = txtMarca.Text
        End If

        If txtModelo.TextLength = 0 Then
            Atriles.CamposNulosTextBox(ErrorProviderAtriles, txtModelo) = txtModelo.Text
            Exit Sub
        Else
            Atriles.CamposNulosTextBox(ErrorProviderAtriles, txtModelo) = txtModelo.Text
        End If

        If txtValorArriendo.TextLength = 0 Then
            Atriles.CamposNulosTextBox(ErrorProviderAtriles, txtValorArriendo) = txtValorArriendo.Text
            Exit Sub
        Else
            Atriles.CamposNulosTextBox(ErrorProviderAtriles, txtValorArriendo) = txtValorArriendo.Text
        End If

        If txtValorArriendo.Text > 500000 Then
            Equipos.PrecioArriendo(ErrorProviderAtriles, txtValorArriendo) = txtValorArriendo.Text
            Exit Sub
        Else
            Equipos.PrecioArriendo(ErrorProviderAtriles, txtValorArriendo) = txtValorArriendo.Text
        End If

        If cmbTipo.Text = "" Then
            Atriles.CamposNulosComboBox(ErrorProviderAtriles, cmbTipo) = cmbTipo.Text
            Exit Sub
        Else
            Atriles.CamposNulosComboBox(ErrorProviderAtriles, cmbTipo) = cmbTipo.Text
        End If
        'Registro de micrófonos en la base de datos
        Try
            Me.EquiposTableAdapter1.InsertEquipos(txtMarca.Text, "DISPONIBLE", txtModelo.Text, Integer.Parse(txtValorArriendo.Text))
            intIDEquipo = Me.EquiposTableAdapter1.SelectIDEquipo()
            Me.AtrilesTableAdapter1.Insert(intIDEquipo, cmbTipo.Text)
            MsgBox("Registro correcto", MsgBoxStyle.Information, "Registro mesas")
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
        ErrorProviderAtriles.Clear()

    End Sub

    'Cerrando formulario
    Private Sub Mesas_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim drResultado As DialogResult = MsgBox("Asegúrese de haber completado correctamente sus operaciones. ¿Está seguro que desea cerrar? ", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Registro eventos")
        If drResultado = vbNo Then
            e.Cancel = True
        Else
            LimpiarControles()
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

    Private Sub btnLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpiar.Click
        LimpiarControles()
    End Sub
End Class