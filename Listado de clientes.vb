Imports Microsoft.Reporting.WinForms
Public Class frmListadoClientes
    Dim dtFechaActual As Date = Date.Now

    Private Sub frmListadoClientes_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim drResultado As DialogResult = MsgBox("Asegúrese de haber completado correctamente sus operaciones. ¿Está seguro que desea cerrar? ", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Registro eventos")
        If drResultado = vbNo Then
            e.Cancel = True
        Else
            Me.Dispose()
        End If
    End Sub
   
    Private Sub frmListadoClientes_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            ' TODO: esta línea de código carga datos en la tabla 'TeatroDataSet.CLIENTES' Puede moverla o quitarla según sea necesario.
            ' Me.CLIENTESTableAdapter.Fill(Me.TeatroDataSet.CLIENTES)
            '  'TODO: esta línea de código carga datos en la tabla 'TeatroDataSet.VENDEDORES' Puede moverla o quitarla según sea necesario.
            Me.CLIENTESTableAdapter.SelectClientes(Me.TeatroDataSet.CLIENTES)
            Dim parametros As New List(Of ReportParameter)
            Me.CLIENTESTableAdapter.SelectClientes(Me.TeatroDataSet.CLIENTES)
            parametros.Add(New ReportParameter("dtFechaActual", Me.dtFechaActual))
            Me.rvListadoClientes.LocalReport.SetParameters(parametros)
            '' Añado los parámetros al ReportViewer.
            Me.rvListadoClientes.RefreshReport()
        Catch ex As Exception
            MsgBox("Se produjo el siguiente error: " & ex.Message, MsgBoxStyle.Critical, "Teatro")
        End Try
    End Sub
End Class