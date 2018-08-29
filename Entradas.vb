Imports Microsoft.Reporting.WinForms
Public Class frmEntradas



    Private Sub frmEntradas_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim drResultado As DialogResult = MsgBox("Aseg�rese de haber completado correctamente sus operaciones. �Est� seguro que desea cerrar? ", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Registro eventos")
        If drResultado = vbNo Then
            e.Cancel = True
        Else
            Me.rvEntradas.Clear()
            If strFormaPago = "Efectivo" Then
                frmBoletaEfectivo.ShowDialog()
                Me.Dispose()
            ElseIf strFormaPago = "Tarjeta bancaria" Then
                frmBoletaTarjeta.ShowDialog()
                Me.Dispose()
            End If
        End If
    End Sub

    Private Sub frmEntradas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

        
            'TODO: esta l�nea de c�digo carga datos en la tabla 'TeatroDataSet.ENTRADAS' Puede moverla o quitarla seg�n sea necesario.
            Me.ENTRADASTableAdapter.Fill(Me.TeatroDataSet.ENTRADAS, intEntradasVendidas)
            'TODO: esta l�nea de c�digo carga datos en la tabla 'TeatroDataSet.ENTRADAS' Puede moverla o quitarla seg�n sea necesario.
            Dim parametros As New List(Of ReportParameter)
            'Me.VENTASENTRADASTableAdapter.Fill(Me.TeatroDataSet.VENTASENTRADAS)
            If strJornada = "Matin�" Then
                parametros.Add(New ReportParameter("strNota", strNotaMatine))
            ElseIf strJornada = "Tarde" Then
                parametros.Add(New ReportParameter("strNota", strNotaTarde))
            ElseIf strJornada = "Noche" Then
                parametros.Add(New ReportParameter("strNota", strNotaNoche))
            End If
            parametros.Add(New ReportParameter("strJornada", strJornada))
            parametros.Add(New ReportParameter("strUbicacion", strUbicacion))
            Me.rvEntradas.LocalReport.SetParameters(parametros)
            Me.rvEntradas.RefreshReport()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, "Eliminar usuario")
        End Try
    End Sub


End Class