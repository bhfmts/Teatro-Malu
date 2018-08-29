Imports Microsoft.Reporting.WinForms
Public Class frmFechaVentaVende

    Private Sub frmFechaVentaVende_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim drResultado As DialogResult = MsgBox("Aseg�rese de haber completado correctamente sus operaciones. �Est� seguro que desea cerrar? ", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Registro eventos")
        If drResultado = vbNo Then
            e.Cancel = True
        Else
            Me.Dispose()
        End If
    End Sub
    Private Sub frmFechaVentaVende_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta l�nea de c�digo carga datos en la tabla 'TeatroDataSet.ANULACIONVENTASPE' Puede moverla o quitarla seg�n sea necesario.
        Try
            Me.ANULACIONVENTASPETableAdapter.SelectFechaVentaVende(Me.TeatroDataSet.ANULACIONVENTASPE, strDesde, strHasta, strRUNUsuario)
            Dim parametros As New List(Of ReportParameter)
            parametros.Add(New ReportParameter("strDesde", strDesde))
            parametros.Add(New ReportParameter("strHasta", strHasta))
            parametros.Add(New ReportParameter("strRUNUsuario", strRUNUsuarioAnular))
            Me.rvFechaVentaVende.LocalReport.SetParameters(parametros)
            Me.rvFechaVentaVende.RefreshReport()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Informes")
        End Try
    End Sub

    Private Sub rvFechaVentaVende_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rvFechaVentaVende.Load

    End Sub
End Class