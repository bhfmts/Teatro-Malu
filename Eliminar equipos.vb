Public Class frmEliminarEquipos

    Private Sub btnAmplificadores_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAmplificadores.Click
        frmEliminarAmplificadores.ShowDialog()
    End Sub

    Private Sub frmEliminarEquipos_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim drResultado As DialogResult = MsgBox("Asegúrese de haber completado correctamente sus operaciones. ¿Está seguro que desea cerrar? ", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Registro eventos")
        If drResultado = vbNo Then
            e.Cancel = True
        End If
    End Sub

    Private Sub btnAtriles_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAtriles.Click
        frmEliminarAtriles.ShowDialog()
    End Sub
End Class