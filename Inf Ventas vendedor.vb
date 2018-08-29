Imports Microsoft.Reporting.WinForms
Public Class frmVentasVendedor
    Dim drResultado As DialogResult
    Private Sub btnGenerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerar.Click
        Try
            Me.VENTASVENDEDORTableAdapter.Fill(Me.TeatroDataSet.VENTASVENDEDOR, dtpDesde.Value.Date, dtpHasta.Value.Date, strRUNUsuario)
            Dim parametros As New List(Of ReportParameter)
            Dim intVentasEfectivoRango As Integer
            Dim intVentasTarjetaRango As Integer
            Dim intTotalVentas As Integer
            Dim strDesde As String = dtpDesde.Value.Date
            Dim strHasta As String = dtpHasta.Value.Date
            intVentasEfectivoRango = Me.VENTASENTRADASTableAdapter.ContarVentasEfectivoRango(dtpDesde.Value.Date, dtpHasta.Value.Date, strRUNUsuario)
            intVentasTarjetaRango = Me.VENTASENTRADASTableAdapter.ContarVentasTarjeBancariaRango(dtpDesde.Value.Date, dtpHasta.Value.Date, strRUNUsuario)
            intTotalVentas = intVentasEfectivoRango + intVentasTarjetaRango
            parametros.Add(New ReportParameter("intVentasEfectivoRango", intVentasEfectivoRango))
            parametros.Add(New ReportParameter("intVentasTarjetaRango", intVentasTarjetaRango))
            parametros.Add(New ReportParameter("strDesde", strDesde))
            parametros.Add(New ReportParameter("strHasta", strHasta))
            parametros.Add(New ReportParameter("strRUNUsuario", strRUNUsuario))
            parametros.Add(New ReportParameter("intTotalVentas", intTotalVentas))
            Me.rvVentasVendedor.LocalReport.SetParameters(parametros)
            Me.rvVentasVendedor.RefreshReport()
        Catch ex As Exception
            MsgBox("Se produjo el siguiente error: " & ex.Message, MsgBoxStyle.Critical, "Teatro")
        End Try
    End Sub

    
    Private Sub frmVentasVendedor_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim drResultado As DialogResult = MsgBox("Asegúrese de haber completado correctamente sus operaciones. ¿Está seguro que desea cerrar? ", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Registro eventos")
        If drResultado = vbNo Then
            e.Cancel = True
        Else
            Me.rvVentasVendedor.Clear()
        End If
    End Sub
End Class