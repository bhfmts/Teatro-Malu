Imports Microsoft.Reporting.WinForms
Public Class frmVentasPorRUNVendedorTipoEntradaFormaPagoYFechas

    'Este formulario sirve para visualizar el reporte filtrado por los atributos indicados en el nombre del mismo formulario.
    'Además en el evento Load del formulario, paso parámetros hacia el reporte propiamente tal, los cuales son necesarios para entregar más información al usuario

    Private Sub frmVentasPorRUNVendedorTipoEntradaFormaPagoYFechas_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim drResultado As DialogResult = MsgBox("Asegúrese de haber completado correctamente sus operaciones. ¿Está seguro que desea cerrar? ", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Registro eventos")
        If drResultado = vbNo Then
            e.Cancel = True
        Else
            Me.Dispose()
        End If
    End Sub

    Private Sub frmVentasPorRUNVendedorTipoEntradaFormaPagoYFechas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim intVentasMatine As Integer
            Dim intVentasTarde As Integer
            Dim intVentasNoche As Integer
            Dim intVentasBalcones As Integer
            Dim intVentasPlateaNumerada As Integer
            Dim intVentasPlatea As Integer
            intVentasBalcones = Me.REPORTEDEVENTASTableAdapter.LlenarPorRUNVendedorTipoEntradaFormaPagoYFechasBalcones(strRUNVendedorr, strTipoEntrada, strFormaPago, strDesde, strHasta)
            intVentasPlatea = Me.REPORTEDEVENTASTableAdapter.LlenarPorRUNVendedorTipoEntradaFormaPagoYFechasPlatea(strRUNVendedorr, strTipoEntrada, strFormaPago, strDesde, strHasta)
            intVentasPlateaNumerada = Me.REPORTEDEVENTASTableAdapter.LlenarPorRUNVendedorTipoEntradaFormaPagoYFechasPlateaNumerada(strRUNVendedorr, strTipoEntrada, strFormaPago, strDesde, strHasta)
            intVentasMatine = Me.REPORTEDEVENTASTableAdapter.LlenarPorRUNVendedorTipoEntradaFormaPagoYFechasMatine(strRUNVendedorr, strTipoEntrada, strFormaPago, strDesde, strHasta)
            intVentasTarde = Me.REPORTEDEVENTASTableAdapter.LlenarPorRUNVendedorTipoEntradaFormaPagoYFechasTarde(strRUNVendedorr, strTipoEntrada, strFormaPago, strDesde, strHasta)
            intVentasNoche = Me.REPORTEDEVENTASTableAdapter.LlenarPorRUNVendedorTipoEntradaFormaPagoYFechasNoche(strRUNVendedorr, strTipoEntrada, strFormaPago, strDesde, strHasta)
            Me.REPORTEDEVENTASTableAdapter.LlenarPorRUNVendedorTipoEntradaFormaPagoYFechas(Me.TeatroDataSet.REPORTEDEVENTAS, strTipoEntrada, strFormaPago, strRUNVendedorr, strDesde, strHasta)
            Dim parametros As New List(Of ReportParameter)
            parametros.Add(New ReportParameter("strDesde", strDesde))
            parametros.Add(New ReportParameter("strHasta", strHasta))
            parametros.Add(New ReportParameter("strTipoEntrada", strTipoEntrada))
            parametros.Add(New ReportParameter("strFormaPago", strFormaPago))
            parametros.Add(New ReportParameter("strRUNVendedor", strRUNVendedorr))
            parametros.Add(New ReportParameter("intVentasMatine", intVentasMatine))
            parametros.Add(New ReportParameter("intVentasTarde", intVentasTarde))
            parametros.Add(New ReportParameter("intVentasNoche", intVentasNoche))
            parametros.Add(New ReportParameter("intVentasBalcones", intVentasBalcones))
            parametros.Add(New ReportParameter("intVentasPlatea", intVentasPlatea))
            parametros.Add(New ReportParameter("intVentasPlateaNumerada", intVentasPlateaNumerada))
            Me.rvVentasPorRUNVendedorTipoEntradaFormaPagoYFechas.LocalReport.SetParameters(parametros)
            Me.rvVentasPorRUNVendedorTipoEntradaFormaPagoYFechas.RefreshReport()
        Catch ex As Exception
            MsgBox("Se produjo el siguiente error: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
End Class