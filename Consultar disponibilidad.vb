Public Class frmConsultarDisponibilidad
    Dim intIDEvento As Integer = -1
    'Verifico la selección del usuario y luego compruebo en la base de datos la disponibilidad de cada jornada y muestro el
    'evento con su información asociada en caso que se encuentre programado
    Private Sub btnConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultar.Click
        Me.dgEventos.RowHeadersVisible = False
        Try
            If cmbJornada.Text = "" Then
                ErrorProviderDisponibilidad.SetError(cmbJornada, "Campo obligatorio")
                ErrorProviderDisponibilidad.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
                Exit Sub
            Else
                ErrorProviderDisponibilidad.SetError(cmbJornada, "")
            End If
            If cmbJornada.Text = "MATINÉ" And Me.EventosjornadasTableAdapter1.SelectDisponibilidadMatiné(dtpFecha.Value.Date).HasValue = True Then
                intIDEvento = Me.EventosjornadasTableAdapter1.SelectDisponibilidadMatiné(dtpFecha.Value.Date)
                Me.EventosTableAdapter1.LlenarEventos(Me.TeatroDataSet.EVENTOS, intIDEvento, dtpFecha.Value.Date)
                If intIDEvento = 0 Then
                    MsgBox("La jornada se encuentra disponible", MsgBoxStyle.Information, "Disponibilidad")
                End If
            ElseIf cmbJornada.Text = "TARDE" And Me.EventosjornadasTableAdapter1.SelectDisponibilidadTarde(dtpFecha.Value.Date).HasValue = True Then
                intIDEvento = Me.EventosjornadasTableAdapter1.SelectDisponibilidadTarde(dtpFecha.Value.Date)
                Me.EventosTableAdapter1.LlenarEventos(Me.TeatroDataSet.EVENTOS, intIDEvento, dtpFecha.Value.Date)
                If intIDEvento = 0 Then
                    MsgBox("La jornada se encuentra disponible", MsgBoxStyle.Information, "Disponibilidad")
                End If
            ElseIf cmbJornada.Text = "NOCHE" And Me.EventosjornadasTableAdapter1.SelectDisponibilidadNoche(dtpFecha.Value.Date).HasValue = True Then
                intIDEvento = Me.EventosjornadasTableAdapter1.SelectDisponibilidadNoche(dtpFecha.Value.Date)
                Me.EventosTableAdapter1.LlenarEventos(Me.TeatroDataSet.EVENTOS, intIDEvento, dtpFecha.Value.Date)
                If intIDEvento = 0 Then
                    MsgBox("La jornada se encuentra disponible", MsgBoxStyle.Information, "Disponibilidad")
                End If
            Else
                MsgBox("La fecha seleccionada no se encuentra registrada para ningún evento", MsgBoxStyle.Information, "Disponibilidad")
            End If
        Catch ex As Exception
            MsgBox("Se produjo el siguiente error: " & ex.Message, MsgBoxStyle.Critical, "Disponibilidad")
        End Try
    End Sub
    'Cerrando el formulario
    Private Sub frmConsultarDisponibilidad_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim drResultado As DialogResult = MsgBox("Asegúrese de haber completado correctamente sus operaciones. ¿Está seguro que desea cerrar? ", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Registro eventos")
        If drResultado = vbNo Then
            e.Cancel = True
        Else
            Me.Dispose()
        End If
    End Sub

    Private Sub cmbJornada_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbJornada.KeyPress
        e.Handled = True
    End Sub

    Private Sub frmConsultarDisponibilidad_HelpRequested(ByVal sender As Object, ByVal hlpevent As System.Windows.Forms.HelpEventArgs) Handles Me.HelpRequested
        Try
            System.Diagnostics.Process.Start("\\BERNARDO\Consultar disponibilidad.avi")
        Catch ex As Exception
            MsgBox("Se ha producido el siguiente error: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
End Class