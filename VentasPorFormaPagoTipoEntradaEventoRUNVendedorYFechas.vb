Imports Microsoft.Reporting.WinForms
Public Class frmVentasPorFormaPagoTipoEntradaEventoRUNVendedorYFechas
    'Este formulario sirve para visualizar el reporte filtrado por los atributos indicados en el nombre del mismo formulario.
    'Además en el evento Load del formulario, paso parámetros hacia el reporte propiamente tal, los cuales son necesarios para entregar más información al usuario
    Private Sub VentasPorFormaPagoTipoEntradaEventoRUNVendedorYFechas_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim drResultado As DialogResult = MsgBox("Asegúrese de haber completado correctamente sus operaciones. ¿Está seguro que desea cerrar? ", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Registro eventos")
        If drResultado = vbNo Then
            e.Cancel = True
        Else
            Me.Dispose()
        End If
    End Sub

    Private Sub VentasPorFormaPagoTipoEntradaEventoRUNVendedorYFechas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim intVentasMatine As Integer
            Dim intVentasTarde As Integer
            Dim intVentasNoche As Integer
            Dim intVentasBalcones As Integer
            Dim intVentasPlateaNumerada As Integer
            Dim intVentasPlatea As Integer
            intVentasBalcones = Me.REPORTEDEVENTASTableAdapter.LlenarPorFormaPagoTipoEntradaEventoRUNVendedorYFechasBalcones(strRUNVendedorr, strFormaPago, strNombreEvento, strTipoEntrada, strDesde, strHasta)
            intVentasPlatea = Me.REPORTEDEVENTASTableAdapter.LlenarPorFormaPagoTipoEntradaEventoRUNVendedorYFechasPlatea(strRUNVendedorr, strFormaPago, strNombreEvento, strTipoEntrada, strDesde, strHasta)
            intVentasPlateaNumerada = Me.REPORTEDEVENTASTableAdapter.LlenarPorFormaPagoTipoEntradaEventoRUNVendedorYFechasPlateaNumerada(strRUNVendedorr, strFormaPago, strNombreEvento, strTipoEntrada, strDesde, strHasta)
            intVentasMatine = Me.REPORTEDEVENTASTableAdapter.LlenarPorFormaPagoTipoEntradaEventoRUNVendedorYFechasMatine(strRUNVendedorr, strFormaPago, strNombreEvento, strTipoEntrada, strDesde, strHasta)
            intVentasTarde = Me.REPORTEDEVENTASTableAdapter.LlenarPorFormaPagoTipoEntradaEventoRUNVendedorYFechasTarde(strRUNVendedorr, strFormaPago, strNombreEvento, strTipoEntrada, strDesde, strHasta)
            intVentasNoche = Me.REPORTEDEVENTASTableAdapter.LlenarPorFormaPagoTipoEntradaEventoRUNVendedorYFechasNoche(strRUNVendedorr, strFormaPago, strNombreEvento, strTipoEntrada, strDesde, strHasta)
            Me.REPORTEDEVENTASTableAdapter.LlenarPorFormaPagoTipoEntradaEventoRUNVendedorYFechas(Me.TeatroDataSet.REPORTEDEVENTAS, strFormaPago, strRUNVendedorr, strNombreEvento, strTipoEntrada, strDesde, strHasta)
            Dim parametros As New List(Of ReportParameter)
            parametros.Add(New ReportParameter("intVentasBalcones", intVentasBalcones))
            parametros.Add(New ReportParameter("intVentasPlatea", intVentasPlatea))
            parametros.Add(New ReportParameter("intVentasPlateaNumerada", intVentasPlateaNumerada))
            parametros.Add(New ReportParameter("strDesde", strDesde))
            parametros.Add(New ReportParameter("strHasta", strHasta))
            parametros.Add(New ReportParameter("strTipoEntrada", strTipoEntrada))
            parametros.Add(New ReportParameter("strFormaPago", strFormaPago))
            parametros.Add(New ReportParameter("strNombreEvento", strNombreEvento))
            parametros.Add(New ReportParameter("strRUNVendedor", strRUNVendedorr))
            parametros.Add(New ReportParameter("intVentasMatine", intVentasMatine))
            parametros.Add(New ReportParameter("intVentasTarde", intVentasTarde))
            parametros.Add(New ReportParameter("intVentasNoche", intVentasNoche))
            Me.rvPorFormaPagoTipoEntradaEventoRUNVendedorYFechas.LocalReport.SetParameters(parametros)
            Me.rvPorFormaPagoTipoEntradaEventoRUNVendedorYFechas.RefreshReport()
        Catch ex As Exception
            MsgBox("Se produjo el siguiente error: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
End Class