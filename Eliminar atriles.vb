Imports System.Transactions
Public Class frmEliminarAtriles
    Dim Atriles As New ClassAtriles
    Dim blnOpcionBusqueda As Boolean
    Dim drResultado As DialogResult
    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        'Validación de campos
        Try
            If Me.rdbIDAtril.Checked = False And Me.rdbIDEquipo.Checked = False Then
                Me.ErrorProviderEliminarAtriles.SetError(Me.groOpcionesBusqueda, "Campo obligatorio")
                Me.ErrorProviderEliminarAtriles.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
                Exit Sub
            Else
                Me.ErrorProviderEliminarAtriles.SetError(Me.groOpcionesBusqueda, "")
            End If
            If txtDatoBusqueda.TextLength = 0 Then
                Atriles.CamposNulosTextBox(Me.ErrorProviderEliminarAtriles, txtDatoBusqueda) = txtDatoBusqueda.Text
                Exit Sub
            Else
                Atriles.CamposNulosTextBox(Me.ErrorProviderEliminarAtriles, txtDatoBusqueda) = txtDatoBusqueda.Text
            End If
            dgResultados.RowHeadersVisible = False
            If rdbIDEquipo.Checked = True And rdbIDAtril.Checked = False Then
                blnOpcionBusqueda = True
            ElseIf rdbIDEquipo.Checked = False And rdbIDAtril.Checked = True Then
                blnOpcionBusqueda = False
            End If
            Atriles.buscarAtril(dgResultados, txtDatoBusqueda, blnOpcionBusqueda)
        Catch ex As Exception
            MsgBox("Se produjo el siguiente error: " & ex.Message, MsgBoxStyle.Critical, "Teatro")
        End Try

    End Sub
    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Try
            If dgResultados.RowCount = 0 Then
                dgResultados.DataSource = Nothing
                MsgBox("No existen registros respecto a la información ingresada", MsgBoxStyle.Information, "Eliminar usuario")
                Exit Sub
            End If
            If Me.rdbIDAtril.Checked = False And Me.rdbIDEquipo.Checked = False Then
                Me.ErrorProviderEliminarAtriles.SetError(Me.groOpcionesBusqueda, "Campo obligatorio")
                Me.ErrorProviderEliminarAtriles.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
                Exit Sub
            Else
                Me.ErrorProviderEliminarAtriles.SetError(Me.groOpcionesBusqueda, "")
            End If
            If txtDatoBusqueda.TextLength = 0 Then
                Atriles.CamposNulosTextBox(Me.ErrorProviderEliminarAtriles, txtDatoBusqueda) = txtDatoBusqueda.Text
                Exit Sub
            Else
                Atriles.CamposNulosTextBox(Me.ErrorProviderEliminarAtriles, txtDatoBusqueda) = txtDatoBusqueda.Text
            End If
            'Transacción con la base de datos
            drResultado = MsgBox("¿Está seguro que quiere eliminar este amplificador del sistema?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Eliminar atril")
            If drResultado = vbYes Then
                If Me.rdbIDAtril.Checked = True And Me.rdbIDEquipo.Checked = False Then
                    Me.EquiposTableAdapter1.DeleteEquipo(Me.AtrilesTableAdapter1.SelectIDEquipo(txtDatoBusqueda.Text))
                    Me.AtrilesTableAdapter1.DeletePorIDAtril(txtDatoBusqueda.Text)
                    MsgBox("Atril eliminado correctamente", MsgBoxStyle.Information, "Eliminar atril")
                    LimpiarControles()
                ElseIf Me.rdbIDEquipo.Checked = True And Me.rdbIDAtril.Checked = False Then
                    Me.EquiposTableAdapter1.DeleteEquipo(txtDatoBusqueda.Text)
                    Me.AtrilesTableAdapter1.DeleteAtrilesPorIDEquipo(txtDatoBusqueda.Text)
                    MsgBox("Atril eliminado correctamente", MsgBoxStyle.Information, "Eliminar atril")
                    LimpiarControles()
                End If
            End If
        Catch ex As Exception
            MsgBox("Se produjo el siguiente error: " & ex.Message, MsgBoxStyle.Critical, "Teatro")
        End Try
    End Sub
    'Limpiar controles
    Public Sub LimpiarControles()
        Me.rdbIDAtril.Checked = False
        Me.rdbIDEquipo.Checked = False
        Me.txtDatoBusqueda.Clear()
        Me.dgResultados.DataSource = Nothing
    End Sub
    'Cerrando formulario
    Private Sub frmEliminarAtriles_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim drResultado As DialogResult = MsgBox("Asegúrese de haber completado correctamente sus operaciones. ¿Está seguro que desea cerrar? ", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Registro eventos")
        If drResultado = vbNo Then
            e.Cancel = True
        Else
            LimpiarControles()
        End If
    End Sub
End Class