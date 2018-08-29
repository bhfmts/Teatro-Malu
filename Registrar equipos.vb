Public Class frmRegistrarEquipos

    Private Sub btnGuitarras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuitarras.Click
        frmGuitarras.ShowDialog()
    End Sub

    Private Sub btnMicrofonos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMicrofonos.Click
        frmMicrofonos.ShowDialog()
    End Sub

    Private Sub btnMesas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMesas.Click
        frmMesas.ShowDialog()
    End Sub

    Private Sub btnAtriles_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAtriles.Click
        frmAtriles.ShowDialog()
    End Sub

    Private Sub frmRegistrarEquipos_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim drResultado As DialogResult = MsgBox("Asegúrese de haber completado correctamente sus operaciones. ¿Está seguro que desea cerrar? ", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Registro eventos")
        If drResultado = vbNo Then
            e.Cancel = True
        End If
    End Sub

    Private Sub btnAmplificadores_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAmplificadores.Click
        frmAmplificadores.ShowDialog()
    End Sub

    Private Sub btnBajos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBajos.Click
        frmBajos.ShowDialog()
    End Sub

    Private Sub btnTeclados_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTeclados.Click
        frmTeclados.ShowDialog()
    End Sub

    Private Sub btnBaquetas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBaquetas.Click
        frmBaquetas.ShowDialog()
    End Sub

    Private Sub btnBaterias_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBaterias.Click
        frmBaterias.ShowDialog()
    End Sub
End Class