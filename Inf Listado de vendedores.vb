Imports Microsoft.Reporting.WinForms
Public Class frmListadoVendedores
    Dim dtFechaActual As Date = Date.Now

    Private Sub frmListadoVendedores_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim drResultado As DialogResult = MsgBox("Asegúrese de haber completado correctamente sus operaciones. ¿Está seguro que desea cerrar? ", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Registro eventos")
        If drResultado = vbNo Then
            e.Cancel = True
        Else
            Me.Dispose()
        End If
    End Sub
    Private Sub frmListadoVendedores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.VENDEDORESTableAdapter.Fill(Me.TeatroDataSet.VENDEDORES)
            Dim parametros As New List(Of ReportParameter)
            Me.VendedoresTableAdapter1.FillBy(Me.TeatroDataSet.VENDEDORES)
            parametros.Add(New ReportParameter("dtFechaActual", Me.dtFechaActual))
            Me.rvListadoVendedores.LocalReport.SetParameters(parametros)
            '' Añado los parámetros al ReportViewer.
            Me.rvListadoVendedores.RefreshReport()
        Catch ex As Exception
            MsgBox("Se produjo el siguiente error: " & ex.Message, MsgBoxStyle.Critical, "Teatro")
        End Try
        'TODO: esta línea de código carga datos en la tabla 'TeatroDataSet.VENDEDORES' Puede moverla o quitarla según sea necesario.
    End Sub
End Class