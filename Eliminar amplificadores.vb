Imports System.Transactions
Public Class frmEliminarAmplificadores
    Dim Amplificadores As New ClassAmplificadores
    Dim blnOpcionBusqueda As Boolean
    Dim drResultado As DialogResult

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Try
            If Me.rdbIDAmplificador.Checked = False And Me.rdbIDEquipo.Checked = False Then
                Me.ErrorProviderEliminarAmplificadores.SetError(Me.groOpcionesBusqueda, "Campo obligatorio")
                Me.ErrorProviderEliminarAmplificadores.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
                Exit Sub
            Else
                Me.ErrorProviderEliminarAmplificadores.SetError(Me.groOpcionesBusqueda, "")
            End If
            If txtDatoBusqueda.TextLength = 0 Then
                Amplificadores.CamposNulosTextBox(Me.ErrorProviderEliminarAmplificadores, txtDatoBusqueda) = txtDatoBusqueda.Text
                Exit Sub
            Else
                Amplificadores.CamposNulosTextBox(Me.ErrorProviderEliminarAmplificadores, txtDatoBusqueda) = txtDatoBusqueda.Text
            End If
            dgResultados.RowHeadersVisible = False
            If rdbIDEquipo.Checked = True And rdbIDAmplificador.Checked = False Then
                blnOpcionBusqueda = True
            ElseIf rdbIDEquipo.Checked = False And rdbIDAmplificador.Checked = True Then
                blnOpcionBusqueda = False
            End If
            Amplificadores.BuscarAmplificador(dgResultados, txtDatoBusqueda, blnOpcionBusqueda)
        Catch ex As Exception
            MsgBox("Se produjo el siguiente error: " & ex.Message, MsgBoxStyle.Critical, "Teatro")
        End Try
    End Sub

    'Borrado de registros según dato de búsqueda
    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        'Validación de campos
        Try
            If dgResultados.RowCount = 0 Then
                dgResultados.DataSource = Nothing
                MsgBox("No existen registros respecto a la información ingresada", MsgBoxStyle.Information, "Eliminar usuario")
                Exit Sub
            End If
            If Me.rdbIDAmplificador.Checked = False And Me.rdbIDEquipo.Checked = False Then
                Me.ErrorProviderEliminarAmplificadores.SetError(Me.groOpcionesBusqueda, "Campo obligatorio")
                Me.ErrorProviderEliminarAmplificadores.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
                Exit Sub
            Else
                Me.ErrorProviderEliminarAmplificadores.SetError(Me.groOpcionesBusqueda, "")
            End If
            If txtDatoBusqueda.TextLength = 0 Then
                Amplificadores.CamposNulosTextBox(Me.ErrorProviderEliminarAmplificadores, txtDatoBusqueda) = txtDatoBusqueda.Text
                Exit Sub
            Else
                Amplificadores.CamposNulosTextBox(Me.ErrorProviderEliminarAmplificadores, txtDatoBusqueda) = txtDatoBusqueda.Text
            End If
            'Transacción con la base de datos
            drResultado = MsgBox("¿Está seguro que quiere eliminar este amplificador del sistema?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Eliminar amplificador")
            If drResultado = vbYes Then
                If Me.rdbIDAmplificador.Checked = True And Me.rdbIDEquipo.Checked = False Then
                    Me.EquiposTableAdapter1.DeleteEquipo(Me.AmplificadoresTableAdapter1.SelectIDEquipo(txtDatoBusqueda.Text))
                    Me.AmplificadoresTableAdapter1.DeleteAmplificadorPorIDAmplificador(txtDatoBusqueda.Text)
                    MsgBox("Amplificador eliminado correctamente", MsgBoxStyle.Information, "Eliminar amplificador")
                    LimpiarControles()
                ElseIf Me.rdbIDEquipo.Checked = True And Me.rdbIDAmplificador.Checked = False Then
                    Me.EquiposTableAdapter1.DeleteEquipo(txtDatoBusqueda.Text)
                    Me.AmplificadoresTableAdapter1.DeleteAmplificadorPorIDEquipo(txtDatoBusqueda.Text)
                    MsgBox("Amplificador eliminado correctamente", MsgBoxStyle.Information, "Eliminar amplificador")
                    LimpiarControles()
                End If

            End If
        Catch ex As Exception
            MsgBox("Se produjo el siguiente error: " & ex.Message, MsgBoxStyle.Critical, "Teatro")
        End Try
    End Sub
    'Limpiar controles
    Public Sub LimpiarControles()
        Me.rdbIDAmplificador.Checked = False
        Me.rdbIDEquipo.Checked = False
        Me.txtDatoBusqueda.Clear()
        Me.dgResultados.DataSource = Nothing
    End Sub
    'Cerrando formulario
    Private Sub frmEliminarAmplificadores_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim drResultado As DialogResult = MsgBox("Asegúrese de haber completado correctamente sus operaciones. ¿Está seguro que desea cerrar? ", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Registro eventos")
        If drResultado = vbNo Then
            e.Cancel = True
        Else
            LimpiarControles()
        End If
    End Sub
    'Validación sólo números
    Private Sub txtDatoBusqueda_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDatoBusqueda.KeyPress
        If (Asc(e.KeyChar)) >= 48 And (Asc(e.KeyChar)) <= 57 Or (Asc(e.KeyChar)) = System.Windows.Forms.Keys.Back Or Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
End Class