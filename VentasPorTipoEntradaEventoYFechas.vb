Imports Microsoft.Reporting.WinForms
Public Class frmVentasPorTipoEntradaEventoYFechas
    'Este formulario sirve para visualizar el reporte filtrado por los atributos indicados en el nombre del mismo formulario.
    'Además en el evento Load del formulario, paso parámetros hacia el reporte propiamente tal, los cuales son necesarios para entregar más información al usuario

    Private Sub frmVentasPorTipoEntradaEventoYFechas_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim drResultado As DialogResult = MsgBox("Asegúrese de haber completado correctamente sus operaciones. ¿Está seguro que desea cerrar? ", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Registro eventos")
        If drResultado = vbNo Then
            e.Cancel = True
        Else
            Me.Dispose()
        End If
    End Sub

    Private Sub frmVentasPorTipoEntradaEventoYFechas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim intVentasMatine As Integer
            Dim intVentasTarde As Integer
            Dim intVentasNoche As Integer
            Dim intVentasBalcones As Integer
            Dim intVentasPlateaNumerada As Integer
            Dim intVentasPlatea As Integer
            intVentasBalcones = Me.REPORTEDEVENTASTableAdapter.LlenarPorTipoEntradaEventoYFechasBalcones(strNombreEvento, strTipoEntrada, strDesde, strHasta)
            intVentasMatine = Me.REPORTEDEVENTASTableAdapter.LlenarPorTipoEntradaEventoYFechasMatine(strNombreEvento, strTipoEntrada, strDesde, strHasta)
            intVentasTarde = Me.REPORTEDEVENTASTableAdapter.LlenarPorTipoEntradaEventoYFechasTarde(strNombreEvento, strTipoEntrada, strDesde, strHasta)
            intVentasNoche = Me.REPORTEDEVENTASTableAdapter.LlenarPorTipoEntradaEventoYFechasNoche(strNombreEvento, strTipoEntrada, strDesde, strHasta)
            intVentasBalcones = Me.REPORTEDEVENTASTableAdapter.LlenarPorTipoEntradaEventoYFechasBalcones(strNombreEvento, strTipoEntrada, strDesde, strHasta)
            intVentasPlatea = Me.REPORTEDEVENTASTableAdapter.LlenarPorTipoEntradaEventoYFechasPlatea(strNombreEvento, strTipoEntrada, strDesde, strHasta)
            intVentasPlateanumerada = Me.REPORTEDEVENTASTableAdapter.LlenarPorTipoEntradaEventoYFechasPlateaNumerada(strNombreEvento, strTipoEntrada, strDesde, strHasta)
            Me.REPORTEDEVENTASTableAdapter.LlenarPorTipoEntradaEventoYFechas(Me.TeatroDataSet.REPORTEDEVENTAS, strTipoEntrada, strNombreEvento, strDesde, strHasta)
            Dim parametros As New List(Of ReportParameter)
            parametros.Add(New ReportParameter("intVentasBalcones", intVentasBalcones))
            parametros.Add(New ReportParameter("intVentasPlatea", intVentasPlatea))
            parametros.Add(New ReportParameter("intVentasPlateaNumerada", intVentasPlateaNumerada))
            parametros.Add(New ReportParameter("strDesde", strDesde))
            parametros.Add(New ReportParameter("strHasta", strHasta))
            parametros.Add(New ReportParameter("strTipoEntrada", strTipoEntrada))
            parametros.Add(New ReportParameter("strNombreEvento", strNombreEvento))
            parametros.Add(New ReportParameter("intVentasMatine", intVentasMatine))
            parametros.Add(New ReportParameter("intVentasTarde", intVentasTarde))
            parametros.Add(New ReportParameter("intVentasNoche", intVentasNoche))
            Me.rvVentasPorTipoEntradaEventoYFechas.LocalReport.SetParameters(parametros)
            Me.rvVentasPorTipoEntradaEventoYFechas.RefreshReport()
        Catch ex As Exception
            MsgBox("Se produjo el siguiente error: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
End Class