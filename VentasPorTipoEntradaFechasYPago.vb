Imports Microsoft.Reporting.WinForms
Public Class frmVentasPorTipoEntradaFechasYPago
    'Este formulario sirve para visualizar el reporte filtrado por los atributos indicados en el nombre del mismo formulario.
    'Además en el evento Load del formulario, paso parámetros hacia el reporte propiamente tal, los cuales son necesarios para entregar más información al usuario

    Private Sub frmVentasPorTipoEntradaFechasYPago_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim drResultado As DialogResult = MsgBox("Asegúrese de haber completado correctamente sus operaciones. ¿Está seguro que desea cerrar? ", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Registro eventos")
        If drResultado = vbNo Then
            e.Cancel = True
        Else
            Me.Dispose()
        End If
    End Sub
    Private Sub VentasPorTipoEntradaFechasYPago_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim intVentasMatine As Integer
            Dim intVentasTarde As Integer
            Dim intVentasNoche As Integer
            Dim intVentasBalcones As Integer
            Dim intVentasPlatea As Integer
            Dim intVentasPlateaNumerada As Integer
            intVentasPlatea = Me.REPORTEDEVENTASTableAdapter.LlenarPorTipoEntradaFormaPagoYFechasPlatea(strTipoEntrada, strFormaPago, strDesde, strHasta)
            intVentasPlateaNumerada = Me.REPORTEDEVENTASTableAdapter.LlenarPorTipoEntradaFormaPagoYFechasPlateaNumerada(strTipoEntrada, strFormaPago, strDesde, strHasta)
            intVentasBalcones = Me.REPORTEDEVENTASTableAdapter.LlenarPorTipoEntradaFormaPagoYFechasBalcones(strTipoEntrada, strFormaPago, strDesde, strHasta)
            intVentasMatine = Me.REPORTEDEVENTASTableAdapter.LlenarPorTipoEntradaFormaPagoYFechasMatine(strTipoEntrada, strFormaPago, strDesde, strHasta)
            intVentasTarde = Me.REPORTEDEVENTASTableAdapter.LlenarPorTipoEntradaFormaPagoYFechasTarde(strTipoEntrada, strFormaPago, strDesde, strHasta)
            intVentasNoche = Me.REPORTEDEVENTASTableAdapter.LlenarPorTipoEntradaFormaPagoYFechasNoche(strTipoEntrada, strFormaPago, strDesde, strHasta)
            Me.REPORTEDEVENTASTableAdapter.LlenarPorTipoEntradaFormaPagoYFechas(Me.TeatroDataSet.REPORTEDEVENTAS, strTipoEntrada, strFormaPago, strDesde, strHasta)
            Dim parametros As New List(Of ReportParameter)
            parametros.Add(New ReportParameter("intVentasBalcones", intVentasBalcones))
            parametros.Add(New ReportParameter("intVentasPlatea", intVentasPlatea))
            parametros.Add(New ReportParameter("intVentasPlateaNumerada", intVentasPlateaNumerada))
            parametros.Add(New ReportParameter("strDesde", strDesde))
            parametros.Add(New ReportParameter("strHasta", strHasta))
            parametros.Add(New ReportParameter("strTipoEntrada", strTipoEntrada))
            parametros.Add(New ReportParameter("strFormaPago", strFormaPago))
            parametros.Add(New ReportParameter("intVentasMatine", intVentasMatine))
            parametros.Add(New ReportParameter("intVentasTarde", intVentasTarde))
            parametros.Add(New ReportParameter("intVentasNoche", intVentasNoche))
            Me.rvVentasPorTipoEntradaFechasYPago.LocalReport.SetParameters(parametros)
            Me.rvVentasPorTipoEntradaFechasYPago.RefreshReport()
        Catch ex As Exception
            MsgBox("Se produjo el siguiente error: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

End Class