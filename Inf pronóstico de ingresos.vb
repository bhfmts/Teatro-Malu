Imports Microsoft.Reporting.WinForms
Public Class frmInfPronosticoIngresos

    Private Sub frmInfPronosticoIngresos_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim drResultado As DialogResult = MsgBox("Asegúrese de haber completado correctamente sus operaciones. ¿Está seguro que desea cerrar? ", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Registro eventos")
        If drResultado = vbNo Then
            e.Cancel = True
        Else
            Me.Dispose()
        End If
    End Sub


    Private Sub frmInfPronosticoIngresos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim parametros As New List(Of ReportParameter)
            parametros.Add(New ReportParameter("FechaActual", Date.Now))
            parametros.Add(New ReportParameter("ValorEntradaGeneral", dbValorEntradaGeneral))
            parametros.Add(New ReportParameter("BalconesAdulto", intBalconesAdulto))
            parametros.Add(New ReportParameter("BalconesEstudiante", intBalconesEstudiante))
            parametros.Add(New ReportParameter("BalconesTerceraEdad", intBalconesTerceraEdad))
            parametros.Add(New ReportParameter("BalconesNino", intBalconesNiño))
            parametros.Add(New ReportParameter("PlateaAdulto", intPlateaAdulto))
            parametros.Add(New ReportParameter("PlateaEstudiante", intPlateaEstudiante))
            parametros.Add(New ReportParameter("PlateaTerceraEdad", intPlateaTerceraEdad))
            parametros.Add(New ReportParameter("PlateaNino", intPlateaNiño))
            parametros.Add(New ReportParameter("PlateaNumeradaTerceraEdad", intPlateaNuTerceraEdad))
            parametros.Add(New ReportParameter("PlateaNumeradaAdulto", intPlateaNuAdulto))
            parametros.Add(New ReportParameter("PlateaNumeradaEstudiante", intPlateaNuEstudiante))
            parametros.Add(New ReportParameter("PlateaNumeradaNino", intPlateaNuNiño))
            parametros.Add(New ReportParameter("TotalPronostico", dbTotalPronostico))
            Me.rvPronosticoIngresos.LocalReport.SetParameters(parametros)
            Me.rvPronosticoIngresos.RefreshReport()
        Catch ex As Exception
            MsgBox("Se produjo el siguiente error: " & ex.Message, MsgBoxStyle.Critical)
        End Try

    End Sub
End Class