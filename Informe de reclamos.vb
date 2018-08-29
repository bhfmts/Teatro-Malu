Imports Microsoft.Reporting.WinForms
Public Class frmInformeReclamos
    'Consulto la cantidad de reclamos según el tipo y paso los parámetros hacia el informe
    Private Sub btnGenerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerar.Click
        Try
            If dtpDesde.Value >= dtpHasta.Value Then
                MsgBox("El valor de campo ""Desde"" no debe ser igual o mayor que el campo ""Hasta""", MsgBoxStyle.Critical, "Informe de reclamos")
                Exit Sub
            End If
            If dtpDesde.Value.Date > Date.Now.Date Then
                MsgBox("La fecha seleccionada no debe ser mayor que la fecha actual. Verifique si la fecha actual del equipo está correcta.", MsgBoxStyle.Critical, "Informe de reclamos")
                Exit Sub
            End If
            Dim intAseo As Integer
            Dim intIluminacion As Integer
            Dim intSonido As Integer
            Dim intAtencion As Integer
            Dim intOtro As Integer
            Dim intSeguridad As Integer
            intAseo = Me.ReclamosTableAdapter1.ContarReclamosPorAseoFechas(dtpDesde.Value, dtpHasta.Value)
            intIluminacion = Me.ReclamosTableAdapter1.ContarReclamosPorIluminacionYFechas(dtpDesde.Value, dtpHasta.Value)
            intSonido = Me.ReclamosTableAdapter1.ContarReclamosPorSonidoYFechas(dtpDesde.Value, dtpHasta.Value)
            intOtro = Me.ReclamosTableAdapter1.ContarReclamosPorOtroYFechas(dtpDesde.Value, dtpHasta.Value)
            intSeguridad = Me.ReclamosTableAdapter1.ContarReclamosPorSeguridadYFechas(dtpDesde.Value, dtpHasta.Value)
            intAtencion = Me.ReclamosTableAdapter1.ContarReclamosPorAtenciónYFechas(dtpDesde.Value, dtpHasta.Value)
            Dim parametros As New List(Of ReportParameter)
            parametros.Add(New ReportParameter("intAseo", intAseo))
            parametros.Add(New ReportParameter("intIluminacion", intIluminacion))
            parametros.Add(New ReportParameter("intSonido", intSonido))
            parametros.Add(New ReportParameter("strDesde", dtpDesde.Value.Date))
            parametros.Add(New ReportParameter("strHasta", dtpHasta.Value.Date))
            parametros.Add(New ReportParameter("intAtencion", intAtencion))
            parametros.Add(New ReportParameter("intOtro", intOtro))
            parametros.Add(New ReportParameter("intSeguridad", intSeguridad))
            Me.rvInformeReclamos.LocalReport.SetParameters(parametros)
            Me.rvInformeReclamos.RefreshReport()
        Catch ex As Exception
            MsgBox("Se produjo el siguiente error: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    'Cerrando el formulario
    Private Sub frmInformeReclamos_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim drResultado As DialogResult = MsgBox("Asegúrese de haber completado correctamente sus operaciones. ¿Está seguro que desea cerrar? ", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Registro eventos")
        If drResultado = vbNo Then
            e.Cancel = True
        Else
            Me.Dispose()
        End If
    End Sub

    Private Sub frmInformeReclamos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        MsgBox("Si desea obtener información para la fecha actual, debe hacer lo siguiente: en el campo ""Desde"" debe incluir la fecha actual (" + Date.Now.Date + ") y en el campo ""Hasta"" la fecha del día siguiente (" + Date.Now.Date.AddDays(1) + ").", MsgBoxStyle.Information, "Reporte de ventas")
    End Sub
End Class