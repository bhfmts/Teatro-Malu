Public Class frmComisiones
    Dim drResultado As DialogResult

    Private Sub frmComisiones_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim drResultado As DialogResult = MsgBox("Asegúrese de haber completado correctamente sus operaciones. ¿Está seguro que desea cerrar? ", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Registro eventos")
        If drResultado = vbNo Then
            e.Cancel = True
        Else
            Me.Dispose()
        End If
    End Sub

    Private Sub btnComision_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnComision.Click
        Try
            If cmbFormaPago.GetItemText(cmbFormaPago.SelectedItem) = "Efectivo" Then
                txtComision.Text = Me.PagoefectivoTableAdapter1.TotalComision(strRUNUsuario, dtpDesde.Value.Date, dtpHasta.Value.Date)
            ElseIf cmbFormaPago.GetItemText(cmbFormaPago.SelectedItem) = "Tarjeta bancaria" Then
                txtComision.Text = Me.PagotarjetacreditoTableAdapter1.TotalComision(strRUNUsuario, dtpDesde.Value.Date, dtpHasta.Value.Date)
            ElseIf cmbFormaPago.GetItemText(cmbFormaPago.SelectedItem) = "Ambas" Then
                txtComision.Text = Me.PagoefectivoTableAdapter1.TotalComision(strRUNUsuario, dtpDesde.Value.Date, dtpHasta.Value.Date) + Me.PagotarjetacreditoTableAdapter1.TotalComision(strRUNUsuario, dtpDesde.Value.Date, dtpHasta.Value.Date)
            End If
        Catch ex As Exception
            MsgBox("Se produjo el siguiente error: " & ex.Message, MsgBoxStyle.Critical)
        End Try
       

    End Sub

End Class