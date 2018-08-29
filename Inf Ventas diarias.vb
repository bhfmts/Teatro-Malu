Imports System.Data.SqlClient
Imports Teatro.ClassConexion
Imports Microsoft.Reporting.WinForms
Public Class frmVentasDiarias
    Dim drResultado As DialogResult

    Private Sub frmVentasDiarias_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim drResultado As DialogResult = MsgBox("Asegúrese de haber completado correctamente sus operaciones. ¿Está seguro que desea cerrar? ", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Registro eventos")
        If drResultado = vbNo Then
            e.Cancel = True
        Else
            Me.rvVentasDiarias.Clear()
        End If
    End Sub
    'Se carga el informe de las ventas diarias
    Private Sub frmMisVentas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'TeatroDataSet.VENTASDIARIAS' Puede moverla o quitarla según sea necesario.
        Try
            Dim intVentasEfectivo As Integer
            Dim intVentasTarjeta As Integer
            Me.VENTASDIARIASTableAdapter.Fill(Me.TeatroDataSet.VENTASDIARIAS, Date.Now.Day, Date.Now.Month, strRUNUsuario)
            Dim parametros As New List(Of ReportParameter)
            intVentasEfectivo = Me.VENTASENTRADASTableAdapter.ContarVentasEfectivo(strRUNUsuario, Date.Now.Day, Date.Now.Month)
            intVentasTarjeta = Me.VENTASENTRADASTableAdapter.ContarVentasTarjeBancaria(strRUNUsuario, Date.Now.Day, Date.Now.Month)
            parametros.Add(New ReportParameter("intVentasEfectivo", intVentasEfectivo))
            parametros.Add(New ReportParameter("intVentasTarjeta", intVentasTarjeta))
            Me.rvVentasDiarias.LocalReport.SetParameters(parametros)
            Me.rvVentasDiarias.RefreshReport()
        Catch ex As Exception
            MsgBox("Se produjo el siguiente error: " & ex.Message, MsgBoxStyle.Critical, "Teatro")
        End Try
    End Sub
   
End Class
