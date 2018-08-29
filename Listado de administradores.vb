Imports Microsoft.Reporting.WinForms
Public Class frmListadoAdministradores
    Dim dtFechaActual As Date = Date.Now

    Private Sub frmListadoAdministradores_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim drResultado As DialogResult = MsgBox("Asegúrese de haber completado correctamente sus operaciones. ¿Está seguro que desea cerrar? ", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Registro eventos")
        If drResultado = vbNo Then
            e.Cancel = True
        Else
            Me.Dispose()
        End If
    End Sub
   

    Private Sub frmListadoAdministradores_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        TeatroDataSet.EnforceConstraints = False
        Me.ADMINISTRADORESTableAdapter.SelectAdministradores(Me.TeatroDataSet.ADMINISTRADORES)
        Dim parametros As New List(Of ReportParameter)
        Me.ADMINISTRADORESTableAdapter.SelectAdministradores(Me.TeatroDataSet.ADMINISTRADORES)
        parametros.Add(New ReportParameter("dtFechaActual", Me.dtFechaActual))
        Me.rvListadoAdministradores.LocalReport.SetParameters(parametros)
        '' Añado los parámetros al ReportViewer.
        Me.rvListadoAdministradores.RefreshReport()
    End Sub
End Class