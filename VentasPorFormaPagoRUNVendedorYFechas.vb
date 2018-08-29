Imports Microsoft.Reporting.WinForms
Public Class frmVentasPorFormaPagoRUNVendedorYFechas
    'Este formulario sirve para visualizar el reporte filtrado por los atributos indicados en el nombre del mismo formulario.
    'Además en el evento Load del formulario, paso parámetros hacia el reporte propiamente tal, los cuales son necesarios para entregar más información al usuario

    Private Sub frmVentasPorFormaPagoRUNVendedorYFechas_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim drResultado As DialogResult = MsgBox("Asegúrese de haber completado correctamente sus operaciones. ¿Está seguro que desea cerrar? ", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Registro eventos")
        If drResultado = vbNo Then
            e.Cancel = True
        Else
            Me.Dispose()
        End If
    End Sub

    Private Sub frmVentasPorFormaPagoRUNVendedorYFechas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim intVentasMatine As Integer
            Dim intVentasTarde As Integer
            Dim intVentasNoche As Integer
            Dim intVentasBalcones As Integer
            Dim intVentasPlateaNumerada As Integer
            Dim intVentasPlatea As Integer
            intVentasBalcones = Me.REPORTEDEVENTASTableAdapter.LlenarPorFormaPagoRUNVendedorYFechasBalcones(strRUNVendedorr, strFormaPago, strDesde, strHasta)
            intVentasPlatea = Me.REPORTEDEVENTASTableAdapter.LlenarPorFormaPagoRUNVendedorYFechasPlatea(strRUNVendedorr, strFormaPago, strDesde, strHasta)
            intVentasPlateaNumerada = Me.REPORTEDEVENTASTableAdapter.LlenarPorFormaPagoRUNVendedorYFechasPlateaNumerada(strRUNVendedorr, strFormaPago, strDesde, strHasta)
            intVentasMatine = Me.REPORTEDEVENTASTableAdapter.LlenarPorFormaPagoRUNVendedorYFechasMatine(strRUNVendedorr, strFormaPago, strDesde, strHasta)
            intVentasTarde = Me.REPORTEDEVENTASTableAdapter.LlenarPorFormaPagoRUNVendedorYFechasTarde(strRUNVendedorr, strFormaPago, strDesde, strHasta)
            intVentasNoche = Me.REPORTEDEVENTASTableAdapter.LlenarPorFormaPagoRUNVendedorYFechasNoche(strRUNVendedorr, strFormaPago, strDesde, strHasta)
            Me.REPORTEDEVENTASTableAdapter.LlenarPorFormaPagoRUNVendedorYFechas(Me.TeatroDataSet.REPORTEDEVENTAS, strFormaPago, strRUNVendedorr, strDesde, strHasta)
            Dim parametros As New List(Of ReportParameter)
            parametros.Add(New ReportParameter("intVentasBalcones", intVentasBalcones))
            parametros.Add(New ReportParameter("intVentasPlatea", intVentasPlatea))
            parametros.Add(New ReportParameter("intVentasPlateaNumerada", intVentasPlateaNumerada))
            parametros.Add(New ReportParameter("strDesde", strDesde))
            parametros.Add(New ReportParameter("strHasta", strHasta))
            parametros.Add(New ReportParameter("strFormaPago", strFormaPago))
            parametros.Add(New ReportParameter("strRUNVendedor", strRUNVendedorr))
            parametros.Add(New ReportParameter("intVentasMatine", intVentasMatine))
            parametros.Add(New ReportParameter("intVentasTarde", intVentasTarde))
            parametros.Add(New ReportParameter("intVentasNoche", intVentasNoche))
            Me.rvVentasPorFormaPagoRUNVendedorYFechas.LocalReport.SetParameters(parametros)
            Me.rvVentasPorFormaPagoRUNVendedorYFechas.RefreshReport()
        Catch ex As Exception
            MsgBox("Se produjo el siguiente error: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
End Class