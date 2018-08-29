Public Class frmVentasAnuladas
    Dim blnPorUsuario As Boolean
    Private Sub btnGenerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerar.Click
        ErrorProviderVentasAnuladas.Clear()
        Try
            strDesde = dtpDesde.Value.Date
            strHasta = dtpHasta.Value.Date
            strRUNUsuarioAnular = txtRUNusuario.Text & "-" & txtGuion.Text
            If dtpDesde.Value >= dtpHasta.Value Then
                MsgBox("El valor de campo ""Desde"" no debe ser igual o mayor que el campo ""Hasta""", MsgBoxStyle.Critical, "Informe de ventas anuladas")
                Exit Sub
            End If
            If dtpDesde.Value.Date > Date.Now.Date Then
                MsgBox("La fecha seleccionada no debe ser mayor que la fecha actual. Verifique si la fecha actual del equipo está correcta.", MsgBoxStyle.Critical, "Informe de ventas anuladas")
                Exit Sub
            End If
            'Aquí abro los distintos formularios con los informes dependiendo la selección del usuario
            If rdbFechaAnulacion.Checked = True And chkPorUsuario.Checked = True Then
                'Informe por fecha de anulación y vendedor
                'Validación de los campos
                If Not IsNumeric(txtRUNusuario.Text) OrElse String.IsNullOrEmpty(txtRUNusuario.Text) Then
                    ErrorProviderVentasAnuladas.SetError(txtRUNusuario, "Ingrese un valor númerico")
                    ErrorProviderVentasAnuladas.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
                    Exit Sub
                Else
                    ErrorProviderVentasAnuladas.SetError(txtRUNusuario, "")
                End If
                'Validación campo guión
                If String.IsNullOrEmpty(txtGuion.Text) Then
                    ErrorProviderVentasAnuladas.SetError(txtGuion, "Campo obligatorio")
                    ErrorProviderVentasAnuladas.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
                    Exit Sub
                Else
                    ErrorProviderVentasAnuladas.SetError(txtGuion, "")
                End If
                frmFechaAnuVende.ShowDialog()
            ElseIf rdbFechaAnulacion.Checked = True And chkPorUsuario.Checked = False Then
                'Informe por fecha de anulación
                frmFechaAnu.ShowDialog()
            ElseIf rdbFechaVenta.Checked = True And chkPorUsuario.Checked = True Then
                If Not IsNumeric(txtRUNusuario.Text) OrElse String.IsNullOrEmpty(txtRUNusuario.Text) Then
                    ErrorProviderVentasAnuladas.SetError(txtRUNusuario, "Ingrese un valor númerico")
                    ErrorProviderVentasAnuladas.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
                    Exit Sub
                Else
                    ErrorProviderVentasAnuladas.SetError(txtRUNusuario, "")
                End If
                'Validación campo guión
                If String.IsNullOrEmpty(txtGuion.Text) Then
                    ErrorProviderVentasAnuladas.SetError(txtGuion, "Campo obligatorio")
                    ErrorProviderVentasAnuladas.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
                    Exit Sub
                Else
                    ErrorProviderVentasAnuladas.SetError(txtGuion, "")
                End If
                frmFechaVentaVende.ShowDialog()
            ElseIf rdbFechaVenta.Checked = True And chkPorUsuario.Checked = False Then
                frmFechaVenta.ShowDialog()
            End If
        Catch ex As Exception
            MsgBox("Se produjo el siguiente error: " & ex.Message, MsgBoxStyle.Critical, "Informes de ventas anuladas")
        End Try



    End Sub
    'Aquí activamos o desactivamos los controles relaciones con el run del usuario en caso de click del checkbox
    Private Sub chkPorVendedor_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkPorUsuario.Click
        If chkPorUsuario.Checked = True Then
            txtRUNusuario.Visible = True
            txtGuion.Visible = True
            lblRUN.Visible = True
            lblGuion.Visible = True
            blnPorUsuario = True
        ElseIf chkPorUsuario.Checked = False Then
            txtRUNusuario.Visible = False
            txtGuion.Visible = False
            lblRUN.Visible = False
            lblGuion.Visible = False
            blnPorUsuario = False
        End If
    End Sub
    'Se confirma el cierre del formulario
    Private Sub frmVentasAnuladas_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim drResultado As DialogResult = MsgBox("Asegúrese de haber completado correctamente sus operaciones. ¿Está seguro que desea cerrar? ", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Informe de ventas anuladas")
        If drResultado = vbNo Then
            e.Cancel = True
        Else
            Me.Dispose()
        End If
    End Sub

    Private Sub frmVentasAnuladas_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        MsgBox("Si desea obtener información para la fecha actual, debe hacer lo siguiente: en el campo ""Desde"" debe incluir la fecha actual (" + Date.Now.Date + ") y en el campo ""Hasta"" la fecha del día siguiente (" + Date.Now.Date.AddDays(1) + ").", MsgBoxStyle.Information, "Informe de ventas anuladas")
    End Sub
End Class