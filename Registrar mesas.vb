Public Class frmMesas
    Dim intIDEquipo
    Private Sub btnRegistrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegistrar.Click
        Dim Mesas As New ClassMesas
        Dim Equipos As New ClassEquipos
        Try
            If txtMarca.TextLength = 0 Then
                Mesas.CamposNulosTextBox(ErrorProviderMesas, txtMarca) = txtMarca.Text
                Exit Sub
            Else
                Mesas.CamposNulosTextBox(ErrorProviderMesas, txtMarca) = txtMarca.Text
            End If

            If txtModelo.TextLength = 0 Then
                Mesas.CamposNulosTextBox(ErrorProviderMesas, txtModelo) = txtModelo.Text
                Exit Sub
            Else
                Mesas.CamposNulosTextBox(ErrorProviderMesas, txtModelo) = txtModelo.Text
            End If

            If txtValorArriendo.TextLength = 0 Then
                Mesas.CamposNulosTextBox(ErrorProviderMesas, txtValorArriendo) = txtValorArriendo.Text
                Exit Sub
            Else
                Mesas.CamposNulosTextBox(ErrorProviderMesas, txtValorArriendo) = txtValorArriendo.Text
            End If

            If txtValorArriendo.Text > 500000 Then
                Equipos.PrecioArriendo(ErrorProviderMesas, txtValorArriendo) = txtValorArriendo.Text
                Exit Sub
            Else
                Equipos.PrecioArriendo(ErrorProviderMesas, txtValorArriendo) = txtValorArriendo.Text
            End If

            If txtNumeroEntradas.TextLength = 0 Then
                Mesas.CamposNulosTextBox(ErrorProviderMesas, txtNumeroEntradas) = txtNumeroEntradas.Text
                Exit Sub
            Else
                Mesas.CamposNulosTextBox(ErrorProviderMesas, txtNumeroEntradas) = txtNumeroEntradas.Text
            End If

            If cmbTipoEntrada.Text = "" Then
                Mesas.CamposNulosComboBox(ErrorProviderMesas, cmbTipoEntrada) = cmbTipoEntrada.Text
                Exit Sub
            Else
                Mesas.CamposNulosComboBox(ErrorProviderMesas, cmbTipoEntrada) = cmbTipoEntrada.Text
            End If

            'Registro de micrófonos en la base de datos

            Me.EquiposTableAdapter1.InsertEquipos(txtMarca.Text, "DISPONIBLE", txtModelo.Text, Integer.Parse(txtValorArriendo.Text))
            intIDEquipo = Me.EquiposTableAdapter1.SelectIDEquipo()
            Me.MesasTableAdapter1.Insert(intIDEquipo, cmbTipoEntrada.Text, Integer.Parse(txtNumeroEntradas.Text))
            MsgBox("Registro correcto", MsgBoxStyle.Information, "Registro mesas")
            LimpiarControles()
            Me.EquiposTableAdapter1.Dispose()
        Catch ex As Exception
            MsgBox("Se produjo el siguiente error: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    'Validación ingreso sólo números
    Private Sub txtValorArriendo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtValorArriendo.KeyPress
        If (Asc(e.KeyChar)) >= 48 And (Asc(e.KeyChar)) <= 57 Or (Asc(e.KeyChar)) = System.Windows.Forms.Keys.Back Or Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    'Validación ingreso sólo números
    Private Sub txtNumeroEntradas_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNumeroEntradas.KeyPress
        If (Asc(e.KeyChar)) >= 48 And (Asc(e.KeyChar)) <= 57 Or (Asc(e.KeyChar)) = System.Windows.Forms.Keys.Back Or Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    'Limpiar controles
    Public Sub LimpiarControles()
        txtMarca.Clear()
        txtModelo.Clear()
        txtValorArriendo.Clear()
        txtNumeroEntradas.Clear()
        cmbTipoEntrada.SelectedIndex = -1
        ErrorProviderMesas.Clear()

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

    Private Sub btnLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpiar.Click
        LimpiarControles()
    End Sub
End Class