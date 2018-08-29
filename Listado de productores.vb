Imports Microsoft.Reporting.WinForms
Public Class frmListadoProductores
    Dim dtFechaActual As Date = Date.Now

    Private Sub frmListadoProductores_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim drResultado As DialogResult = MsgBox("Asegúrese de haber completado correctamente sus operaciones. ¿Está seguro que desea cerrar? ", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Registro eventos")
        If drResultado = vbNo Then
            e.Cancel = True
        Else
            Me.Dispose()
        End If
    End Sub
    Private Sub frmListadoProductores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.PRODUCCIONTableAdapter.SelectProductores(Me.TeatroDataSet.PRODUCCION)
            Dim parametros As New List(Of ReportParameter)
            Me.PRODUCCIONTableAdapter.SelectProductores(Me.TeatroDataSet.PRODUCCION)
            parametros.Add(New ReportParameter("dtFechaActual", Me.dtFechaActual))
            Me.rvListadoProductores.LocalReport.SetParameters(parametros)
            '' Añado los parámetros al ReportViewer.
            Me.rvListadoProductores.RefreshReport()
        Catch ex As Exception
            MsgBox("Se produjo el siguiente error: " & ex.Message, MsgBoxStyle.Critical, "Teatro")
        End Try
    End Sub

   
End Class