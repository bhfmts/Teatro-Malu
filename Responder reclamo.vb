Imports System.Data.SqlClient
Imports Teatro.ClassConexion
Public Class frmResponderReclamo
    Dim strFechaReclamo As String
    Dim intIDReclamo As Integer
    Dim drResultado As DialogResult

    'Aquí cargo todas las fechas de los reclamos que estan sin responder.
    Private Sub frmResponderReclamo_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        RefrescarFechas()
    End Sub
    'Aquí ingresamos la respuesta del administrador a la base de datos, con su respectiva fecha de respuesta
    Private Sub btnEnviar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnviar.Click
        Try
            If txtRespuesta.TextLength = 0 Then
                ErrorProviderReclamos.SetError(txtRespuesta, "Campo obligatorio")
                ErrorProviderReclamos.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
                Exit Sub
            Else
                ErrorProviderReclamos.SetError(txtRespuesta, "")
            End If
            If txtReclamo.TextLength = 0 Then
                ErrorProviderReclamos.SetError(txtReclamo, "Campo obligatorio")
                ErrorProviderReclamos.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
                Exit Sub
            Else
                ErrorProviderReclamos.SetError(txtReclamo, "")
            End If


            Me.ReclamosTableAdapter1.UpdateReclamo(txtRespuesta.Text, Date.Now, intIDReclamo)
            MsgBox("Respuesta enviada satisfactoriamente", MsgBoxStyle.Information)
            Me.txtRespuesta.Clear()
            Me.txtReclamo.Clear()
            RefrescarFechas()
        Catch ex As Exception
            MsgBox("Se producido el siguiente error: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    'Aquí se selecciona la fecha del reclamo que se quiere responder.
    Private Sub dgFechasReclamos_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgFechasReclamos.CellClick
        Try
            txtReclamo.Text = Me.ReclamosTableAdapter1.SelectReclamo(Me.dgFechasReclamos.Rows(e.RowIndex).Cells(0).Value)
            intIDReclamo = Me.dgFechasReclamos.Rows(e.RowIndex).Cells(0).Value
        Catch ex As Exception
            MsgBox("Se producido el siguiente error: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    'Procedimiento para refrescar las fechas de los reclamos
    Public Sub RefrescarFechas()
        Conexion.Close()
        Try
            Conexion.Open()
            Dim Sentencia As String = "SELECT IDRECLAMO,FECHARECLAMO, TIPORECLAMO FROM RECLAMOS WHERE FECHARESPUESTA IS NULL"
            Dim DAdapter As New SqlDataAdapter(Sentencia, Conexion)
            Dim DSet As New DataSet
            DAdapter.Fill(DSet)
            dgFechasReclamos.DataSource = DSet
            Me.dgFechasReclamos.DataMember = "TABLE"
            Me.dgFechasReclamos.Columns(0).Visible = False
        Catch ex As Exception
            MsgBox("Se ha producido el siguiente error: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    'Aquí se cierra el formulario.
    Private Sub frmResponderReclamo_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim drResultado As DialogResult = MsgBox("Asegúrese de haber completado correctamente sus operaciones. ¿Está seguro que desea cerrar? ", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Registro eventos")
        If drResultado = vbNo Then
            e.Cancel = True
        Else
            Me.Dispose()
        End If
    End Sub
    Private Sub frmResponderReclamo_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        Me.RefrescarFechas()
    End Sub


End Class