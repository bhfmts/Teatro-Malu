Public Class frmGuitarras
    Dim Guitarras As New ClassGuitarras
    Dim intIDEquipo As Integer
    Dim blnPermite As Boolean
    Dim Equipos As New ClassEquipos

    Private Sub Guitarras_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim drResultado As DialogResult = MsgBox("Asegúrese de haber completado correctamente sus operaciones. ¿Está seguro que desea cerrar? ", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Registro eventos")
        If drResultado = vbNo Then
            e.Cancel = True
        Else
            LimpiarControles()
        End If
    End Sub

    Private Sub btnRegistrarGuitarra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegistrar.Click
        'Validación de campos nulos
        Try
            If txtMarca.TextLength = 0 Then
                Guitarras.CamposNulosTextBox(ErrorProviderGuitarras, txtMarca) = txtMarca.Text
                Exit Sub
            Else
                Guitarras.CamposNulosTextBox(ErrorProviderGuitarras, txtMarca) = txtMarca.Text
            End If

            If txtModelo.TextLength = 0 Then
                Guitarras.CamposNulosTextBox(ErrorProviderGuitarras, txtModelo) = txtModelo.Text
                Exit Sub
            Else
                Guitarras.CamposNulosTextBox(ErrorProviderGuitarras, txtModelo) = txtModelo.Text
            End If

            If txtValorArriendo.TextLength = 0 Then
                Guitarras.CamposNulosTextBox(ErrorProviderGuitarras, txtValorArriendo) = txtValorArriendo.Text
                Exit Sub
            Else
                Guitarras.CamposNulosTextBox(ErrorProviderGuitarras, txtValorArriendo) = txtValorArriendo.Text
            End If

            If txtValorArriendo.Text > 500000 Then
                Equipos.PrecioArriendo(ErrorProviderGuitarras, txtValorArriendo) = txtValorArriendo.Text
                Exit Sub
            Else
                Equipos.PrecioArriendo(ErrorProviderGuitarras, txtValorArriendo) = txtValorArriendo.Text
            End If

            If txtNumeroEspacios.TextLength = 0 Then
                Guitarras.CamposNulosTextBox(ErrorProviderGuitarras, txtNumeroEspacios) = txtNumeroEspacios.Text
                Exit Sub
            Else
                Guitarras.CamposNulosTextBox(ErrorProviderGuitarras, txtNumeroEspacios) = txtNumeroEspacios.Text
            End If

            If txtMarcaCuerda.TextLength = 0 Then
                Guitarras.CamposNulosTextBox(ErrorProviderGuitarras, txtMarcaCuerda) = txtMarcaCuerda.Text
                Exit Sub
            Else
                Guitarras.CamposNulosTextBox(ErrorProviderGuitarras, txtMarcaCuerda) = txtMarcaCuerda.Text
            End If

            If cmbTipoCuerda.Text = "" Then
                Guitarras.CamposNulosComboBox(ErrorProviderGuitarras, cmbTipoCuerda) = cmbTipoCuerda.Text
                Exit Sub
            Else
                Guitarras.CamposNulosComboBox(ErrorProviderGuitarras, cmbTipoCuerda) = cmbTipoCuerda.Text
            End If

            If cmbTipoGuitarra.Text = "" Then
                Guitarras.CamposNulosComboBox(ErrorProviderGuitarras, cmbTipoGuitarra) = cmbTipoGuitarra.Text
                Exit Sub
            Else
                Guitarras.CamposNulosComboBox(ErrorProviderGuitarras, cmbTipoGuitarra) = cmbTipoGuitarra.Text
            End If

            If blnPermite = False Then
                If cmbAmplificacion.Text = "" Then
                    Guitarras.CamposNulosComboBox(ErrorProviderGuitarras, cmbAmplificacion) = cmbAmplificacion.Text
                    Exit Sub
                Else
                    Guitarras.CamposNulosComboBox(ErrorProviderGuitarras, cmbAmplificacion) = cmbAmplificacion.Text
                End If
            End If
            'Registro de guitarra según la selección del combobox
            If cmbTipoGuitarra.Text = "ELECTRO ACUSTICA" Or cmbTipoGuitarra.SelectedText = "ELECTRICA" Then

                Me.EquiposTableAdapter1.InsertEquipos(txtMarca.Text, "DISPONIBLE", txtModelo.Text, Double.Parse(txtValorArriendo.Text))
                intIDEquipo = Me.EquiposTableAdapter1.SelectIDEquipo()
                Me.GuitarrasTableAdapter1.InsertarGuitarras(intIDEquipo, Integer.Parse(Me.txtNumeroEspacios.Text), txtMarcaCuerda.Text, cmbTipoCuerda.Text, cmbTipoGuitarra.Text, cmbAmplificacion.Text)
                MsgBox("Registro correcto", MsgBoxStyle.Information, "Registro guitarra")
                LimpiarControles()
                Me.EquiposTableAdapter1.Dispose()
            Else
                Me.cmbAmplificacion.Enabled = False
                Me.EquiposTableAdapter1.InsertEquipos(txtMarca.Text, "DISPONIBLE", txtModelo.Text, Double.Parse(txtValorArriendo.Text))
                Me.GuitarrasTableAdapter1.InsertarGuitarras(intIDEquipo, Integer.Parse(Me.txtNumeroEspacios.Text), txtMarcaCuerda.Text, cmbTipoCuerda.Text, cmbTipoGuitarra.Text, "")
                MsgBox("Registro correcto", MsgBoxStyle.Information, "Registro guitarra")
                LimpiarControles()
                Me.EquiposTableAdapter1.Dispose()
            End If
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
        txtMarcaCuerda.Clear()
        cmbTipoGuitarra.SelectedIndex = -1
        cmbTipoCuerda.SelectedIndex = -1
        cmbAmplificacion.SelectedIndex = -1
        ErrorProviderGuitarras.Clear()
    End Sub


    Private Sub cmbTipoGuitarra_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbTipoGuitarra.SelectedIndexChanged
        'Activación del control amplificación
        Try
            If cmbTipoGuitarra.Text = "ELECTRO ACUSTICA" Or cmbTipoGuitarra.Text = "ELECTRICA" Then
                Me.cmbAmplificacion.Enabled = True
                lblAmplificacion.Enabled = True
                blnPermite = False
            Else
                blnPermite = True
                Me.cmbAmplificacion.Enabled = False
                lblAmplificacion.Enabled = False
            End If
        Catch ex As Exception
            MsgBox("Se produjo el siguiente error: " & ex.Message, MsgBoxStyle.Critical, "Teatro")
        End Try
    End Sub

    Private Sub btnLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpiar.Click
        LimpiarControles()
    End Sub
    'Validación ingreso sólo números
    Private Sub txtNumeroEspacios_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNumeroEspacios.KeyPress
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
    'Validación para evitar modificar el contenido del control
    Private Sub cmbAmplificacion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbAmplificacion.KeyPress
        e.Handled = True
    End Sub

    'Validación para evitar modificar el contenido del control
    Private Sub cmbTipoCuerda_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbTipoCuerda.KeyPress
        e.Handled = True
    End Sub

    'Validación para evitar modificar el contenido del control
    Private Sub cmbTipoGuitarra_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbTipoGuitarra.KeyPress
        e.Handled = True
    End Sub




End Class