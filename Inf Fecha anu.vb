Imports Microsoft.Reporting.WinForms
Public Class frmFechaAnu

    Private Sub frmFechaAnu_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim drResultado As DialogResult = MsgBox("Asegúrese de haber completado correctamente sus operaciones. ¿Está seguro que desea cerrar? ", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Registro eventos")
        If drResultado = vbNo Then
            e.Cancel = True
        Else
            Me.Dispose()
        End If
    End Sub

    Private Sub frmFechaAnu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'TeatroDataSet.ANULACIONVENTASPE' Puede moverla o quitarla según sea necesario.
        Me.ANULACIONVENTASPETableAdapter.Fill(Me.TeatroDataSet.ANULACIONVENTASPE)
        'TODO: esta línea de código carga datos en la tabla 'TeatroDataSet.REPORTEDEVENTAS' Puede moverla o quitarla según sea necesario.
        Try
            Me.ANULACIONVENTASPETableAdapter.SelecFechaAnu(Me.TeatroDataSet.ANULACIONVENTASPE, strDesde, strHasta)
            Dim parametros As New List(Of ReportParameter)
            parametros.Add(New ReportParameter("strDesde", strDesde))
            parametros.Add(New ReportParameter("strHasta", strHasta))
            Me.rvFechaAnu.LocalReport.SetParameters(parametros)
            Me.rvFechaAnu.RefreshReport()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Informes")
        End Try


    End Sub
End Class