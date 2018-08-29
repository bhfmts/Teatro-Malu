Imports Microsoft.Reporting.WinForms
Public Class frmRankingVentasGrafico
    Private Sub btnGenerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerar.Click
        If dtpDesde.Value >= dtpHasta.Value Then
            MsgBox("La fecha seleccionada del campo ""Desde"" no debe ser igual o mayor que la fecha seleccionada del campo ""Hasta"".", MsgBoxStyle.Critical, "Ranking de ventas")
            Exit Sub
        End If
        If dtpDesde.Value.Date > Date.Now.Date Then
            MsgBox("La fecha seleccionada no debe ser mayor que la fecha actual. Verifique si la fecha actual del equipo est� correcta.", MsgBoxStyle.Critical, "Ranking de ventas")
            Exit Sub
        End If
        TeatroDataSet.EnforceConstraints = False
        dtDesde = dtpDesde.Value.Date
        dtHasta = dtpHasta.Value.Date
        Me.VENTASENTRADASTableAdapter.Fill(Me.TeatroDataSet.VENTASENTRADAS)
        Dim parametros As New List(Of ReportParameter)
        parametros.Add(New ReportParameter("dtDesde", dtDesde))
        parametros.Add(New ReportParameter("dtHasta", dtHasta))
        Me.rvRankingGrafico.LocalReport.SetParameters(parametros)
        Me.rvRankingGrafico.RefreshReport()
    End Sub

    Private Sub frmRankingVentasGrafico_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim drResultado As DialogResult = MsgBox("Aseg�rese de haber completado correctamente sus operaciones. �Est� seguro que desea cerrar? ", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Ranking de ventas")
        If drResultado = vbNo Then
            e.Cancel = True
        Else
            Me.Dispose()
        End If
    End Sub

    Private Sub frmRankingVentasGrafico_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        MsgBox("Si desea obtener informaci�n para la fecha actual, debe hacer lo siguiente: en el campo ""Desde"" debe incluir la fecha actual (" + Date.Now.Date + ") y en el campo ""Hasta"" la fecha del d�a siguiente (" + Date.Now.Date.AddDays(1) + ").", MsgBoxStyle.Information, "Reporte de ventas")

    End Sub
End Class