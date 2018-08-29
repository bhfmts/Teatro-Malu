Public Class frmBaquetas
    Dim intIDEquipo As Integer
    Dim Baquetas As New ClassBaquetas
    Dim Equipos As New ClassEquipos
    Private Sub btnRegistrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegistrar.Click
        Try
            If txtMarca.TextLength = 0 Then
                Baquetas.CamposNulosTextBox(ErrorProviderBaquetas, txtMarca) = txtMarca.Text
                Exit Sub
            Else
                Baquetas.CamposNulosTextBox(ErrorProviderBaquetas, txtMarca) = txtMarca.Text
            End If

            If txtModelo.TextLength = 0 Then
                Baquetas.CamposNulosTextBox(ErrorProviderBaquetas, txtModelo) = txtModelo.Text
                Exit Sub
            Else
                Baquetas.CamposNulosTextBox(ErrorProviderBaquetas, txtModelo) = txtModelo.Text
            End If

            If txtValorArriendo.TextLength = 0 Then
                Baquetas.CamposNulosTextBox(ErrorProviderBaquetas, txtValorArriendo) = txtValorArriendo.Text
                Exit Sub
            Else
                Baquetas.CamposNulosTextBox(ErrorProviderBaquetas, txtValorArriendo) = txtValorArriendo.Text
            End If

            If txtValorArriendo.Text > 500000 Then
                Equipos.PrecioArriendo(ErrorProviderBaquetas, txtValorArriendo) = txtValorArriendo.Text
                Exit Sub
            Else
                Equipos.PrecioArriendo(ErrorProviderBaquetas, txtValorArriendo) = txtValorArriendo.Text
            End If


            If cmbTipo.Text = "" Then
                Baquetas.CamposNulosComboBox(ErrorProviderBaquetas, cmbTipo) = cmbTipo.Text
                Exit Sub
            Else
                Baquetas.CamposNulosComboBox(ErrorProviderBaquetas, cmbTipo) = cmbTipo.Text
            End If

            'Registro de baquetas en la base de datos
            Me.EquiposTableAdapter1.InsertEquipos(txtMarca.Text, "DISPONIBLE", txtModelo.Text, Integer.Parse(txtValorArriendo.Text))
            intIDEquipo = Me.EquiposTableAdapter1.SelectIDEquipo()
            Me.BaquetasTableAdapter1.Insert(intIDEquipo, cmbTipo.Text)
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
        ErrorProviderBaquetas.Clear()
    End Sub
    'Cerrar formulario
    Private Sub frmBaquetas_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim drResultado As DialogResult = MsgBox("Asegúrese de haber completado correctamente sus operaciones. ¿Está seguro que desea cerrar? ", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Registro eventos")
        If drResultado = vbNo Then
            e.Cancel = True
        Else
            LimpiarControles()
        End If
    End Sub
    'Validación ingreso sólo números
    Private Sub frmBaquetas_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If (Asc(e.KeyChar)) >= 48 And (Asc(e.KeyChar)) <= 57 Or (Asc(e.KeyChar)) = System.Windows.Forms.Keys.Back Or Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
End Class