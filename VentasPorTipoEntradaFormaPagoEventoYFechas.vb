Imports Microsoft.Reporting.WinForms
Public Class frmVentasPorTipoEntradaFormaPagoEventoYFechas
    'Este formulario sirve para visualizar el reporte filtrado por los atributos indicados en el nombre del mismo formulario.
    'Adem�s en el evento Load del formulario, paso par�metros hacia el reporte propiamente tal, los cuales son necesarios para entregar m�s informaci�n al usuario

    Private Sub frmVentasPorTipoEntradaFormaPagoEventoYFechas_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim drResultado As DialogResult = MsgBox("Aseg�rese de haber completado correctamente sus operaciones. �Est� seguro que desea cerrar? ", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Registro eventos")
        If drResultado = vbNo Then
            e.Cancel = True
        Else
            Me.Dispose()
        End If
    End Sub

    Private Sub frmVentasPorTipoEntradaFormaPagoEventoYFechas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim intVentasMatine As Integer
            Dim intVentasTarde As Integer
            Dim intVentasNoche As Integer
            Dim intVentasBalcones As Integer
            Dim intVentasPlatea As Integer
            Dim intVentasPlateaNumerada As Integer
            intVentasBalcones = Me.REPORTEDEVENTASTableAdapter.LlenarPorTipoEntradaFormaPagoEventoYFechasBalcones(strNombreEvento, strTipoEntrada, strFormaPago, strDesde, strHasta)
            intVentasPlatea = Me.REPORTEDEVENTASTableAdapter.LlenarPorTipoEntradaFormaPagoEventoYFechasPlatea(strNombreEvento, strTipoEntrada, strFormaPago, strDesde, strHasta)
            intVentasPlateaNumerada = Me.REPORTEDEVENTASTableAdapter.LlenarPorTipoEntradaFormaPagoEventoYFechasPlateaNumerada(strNombreEvento, strTipoEntrada, strFormaPago, strDesde, strHasta)
            intVentasMatine = Me.REPORTEDEVENTASTableAdapter.LlenarPorTipoEntradaFormaPagoEventoYFechasMatine(strNombreEvento, strTipoEntrada, strFormaPago, strDesde, strHasta)
            intVentasTarde = Me.REPORTEDEVENTASTableAdapter.LlenarPorTipoEntradaFormaPagoEventoYFechasTarde(strNombreEvento, strTipoEntrada, strFormaPago, strDesde, strHasta)
            intVentasNoche = Me.REPORTEDEVENTASTableAdapter.LlenarPorTipoEntradaFormaPagoEventoYFechasNoche(strNombreEvento, strTipoEntrada, strFormaPago, strDesde, strHasta)
            Me.REPORTEDEVENTASTableAdapter.LlenarPorTipoEntradaFormaPagoEventoYFechas(Me.TeatroDataSet.REPORTEDEVENTAS, strTipoEntrada, strFormaPago, strNombreEvento, strDesde, strHasta)
            Dim parametros As New List(Of ReportParameter)
            parametros.Add(New ReportParameter("intVentasBalcones", intVentasBalcones))
            parametros.Add(New ReportParameter("intVentasPlatea", intVentasPlatea))
            parametros.Add(New ReportParameter("intVentasPlateaNumerada", intVentasPlateaNumerada))
            parametros.Add(New ReportParameter("strDesde", strDesde))
            parametros.Add(New ReportParameter("strHasta", strHasta))
            parametros.Add(New ReportParameter("strTipoEntrada", strTipoEntrada))
            parametros.Add(New ReportParameter("strFormaPago", strFormaPago))
            parametros.Add(New ReportParameter("strNombreEvento", strNombreEvento))
            parametros.Add(New ReportParameter("intVentasMatine", intVentasMatine))
            parametros.Add(New ReportParameter("intVentasTarde", intVentasTarde))
            parametros.Add(New ReportParameter("intVentasNoche", intVentasNoche))
            Me.rvVentasPorTipoEntradaFormaPagoEventoYFechas.LocalReport.SetParameters(parametros)
            Me.rvVentasPorTipoEntradaFormaPagoEventoYFechas.RefreshReport()
        Catch ex As Exception
            MsgBox("Se produjo el siguiente error: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
End Class