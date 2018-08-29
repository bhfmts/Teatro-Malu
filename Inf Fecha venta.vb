Imports Microsoft.Reporting.WinForms
Public Class frmFechaVenta
    'Se confirma el cierre del formulario
    Private Sub frmFechaVenta_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim drResultado As DialogResult = MsgBox("Asegúrese de haber completado correctamente sus operaciones. ¿Está seguro que desea cerrar? ", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Registro eventos")
        If drResultado = vbNo Then
            e.Cancel = True
        Else
            Me.Dispose()
        End If
    End Sub

    Private Sub frmFechaVenta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'TeatroDataSet.ANULACIONVENTASPE' Puede moverla o quitarla según sea necesario.
        Try
            Me.ANULACIONVENTASPETableAdapter.SelectPorFechaVenta(Me.TeatroDataSet.ANULACIONVENTASPE, strDesde, strHasta)
            Dim parametros As New List(Of ReportParameter)
            parametros.Add(New ReportParameter("strDesde", strDesde))
            parametros.Add(New ReportParameter("strHasta", strHasta))
            Me.rvFechaVenta.LocalReport.SetParameters(parametros)
            Me.rvFechaVenta.RefreshReport()
        Catch ex As Exception
            MsgBox("Se produjo el siguiente error: " & ex.Message, MsgBoxStyle.Critical)
        End Try

    End Sub
End Class