Imports Teatro.ClassConexion
Imports System.Data.SqlClient
Public Class frmReporteVentas
    Dim blnBuscarEvento As Boolean
    Private Sub txtNombreEvento_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNombreEvento.TextChanged
        Me.txtNombreEvento.Text = LTrim(Replace(txtNombreEvento.Text, "  ", " "))
        Me.dgEventos.RowHeadersVisible = False
        blnBuscarEvento = False
        Try
            Dim DSET As New DataSet
            Dim DAD As New SqlDataAdapter("SELECT DISTINCT RTRIM(NOMBREEVENTO) AS NOMBREEVENTO FROM EVENTOS WHERE NOMBREEVENTO LIKE" & _
            "'%" & Me.txtNombreEvento.Text & "%'", Conexion)
            DAD.Fill(DSET)
            dgEventos.DataSource = DSET
            dgEventos.DataMember = "TABLE"
            Me.dgEventos.Columns("nombreevento").AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        Finally
            Me.dgEventos.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            Me.dgEventos.Columns(0).HeaderText = "Nombre evento"
        End Try
    End Sub
    'Genero los distintos reportes, según la selección del usuario
    Private Sub btnGenerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerar.Click
        Try
            If dtpDesde.Value >= dtpHasta.Value Then
                MsgBox("La fecha seleccionada del campo ""Desde"" no debe ser igual o mayor que la fecha seleccionada del campo ""Hasta"".", MsgBoxStyle.Critical, "Reporte ventas")
                Exit Sub
            End If
            If dtpDesde.Value.Date > Date.Now.Date Then
                MsgBox("La fecha seleccionada no debe ser mayor que la fecha actual. Verifique si la fecha actual del equipo está correcta.", MsgBoxStyle.Critical, "Reporte de ventas")
                Exit Sub
            End If
            strDesde = dtpDesde.Value.Date
            strHasta = dtpHasta.Value.Date
            strTipoEntrada = cmbTipoEntrada.Text
            strFormaPago = cmbTipoPago.Text
            strNombreEvento = txtNombreEvento.Text
            strRUNVendedorr = txtRUNVendedor.Text
            If btnOn1.Text = "Off" And btnOn2.Text = "On" And btnOn3.Text = "On" And btnOn4.Text = "On" Then
                frmVentasPorTipoEntradaYFechas.ShowDialog()
            ElseIf btnOn2.Text = "Off" And btnOn1.Text = "On" And btnOn3.Text = "On" And btnOn4.Text = "On" Then
                frmVentasPorFormaPagoYFechas.ShowDialog()
            ElseIf btnOn3.Text = "Off" And btnOn1.Text = "On" And btnOn2.Text = "On" And btnOn4.Text = "On" Then
                frmVentasPorEventoYFechas.ShowDialog()
            ElseIf btnOn4.Text = "Off" And btnOn1.Text = "On" And btnOn2.Text = "On" And btnOn3.Text = "On" Then
                frmVentasPorRUNVendedorYFechas.ShowDialog()
            ElseIf btnOn3.Text = "On" And btnOn1.Text = "On" And btnOn2.Text = "On" And btnOn4.Text = "On" Then
                frmVentasPorFechas.ShowDialog()
            ElseIf btnOn1.Text = "Off" And btnOn2.Text = "Off" And btnOn3.Text = "On" And btnOn4.Text = "On" Then
                frmVentasPorTipoEntradaFechasYPago.ShowDialog()
            ElseIf btnOn1.Text = "Off" And btnOn2.Text = "Off" And btnOn3.Text = "Off" And btnOn4.Text = "On" Then
                frmVentasPorTipoEntradaFormaPagoEventoYFechas.ShowDialog()
            ElseIf btnOn1.Text = "On" And btnOn2.Text = "Off" And btnOn3.Text = "Off" And btnOn4.Text = "On" Then
                frmVentasPorFormaPagoEventoYFechas.ShowDialog()
            ElseIf btnOn1.Text = "On" And btnOn2.Text = "Off" And btnOn3.Text = "On" And btnOn4.Text = "Off" Then
                frmVentasPorFormaPagoRUNVendedorYFechas.ShowDialog()
            ElseIf btnOn1.Text = "On" And btnOn2.Text = "On" And btnOn3.Text = "Off" And btnOn4.Text = "Off" Then
                frmVentasPorEventoRUNVendedorYFechas.ShowDialog()
            ElseIf btnOn1.Text = "Off" And btnOn2.Text = "On" And btnOn3.Text = "Off" And btnOn4.Text = "On" Then
                frmVentasPorTipoEntradaEventoYFechas.ShowDialog()
            ElseIf btnOn1.Text = "Off" And btnOn2.Text = "Off" And btnOn3.Text = "Off" And btnOn4.Text = "Off" Then
                frmVentasPorFormaPagoTipoEntradaEventoRUNVendedorYFechas.ShowDialog()
            ElseIf btnOn1.Text = "On" And btnOn2.Text = "Off" And btnOn3.Text = "Off" And btnOn4.Text = "Off" Then
                frmVentasPorRUNVendedorEventoFormaPagoYFechas.ShowDialog()
            ElseIf btnOn1.Text = "Off" And btnOn2.Text = "On" And btnOn3.Text = "On" And btnOn4.Text = "Off" Then
                frmVentasPorRUNVendedorTipoEntradaYFechas.ShowDialog()
            ElseIf btnOn1.Text = "Off" And btnOn2.Text = "On" And btnOn3.Text = "Off" And btnOn4.Text = "Off" Then
                frmVentasPorRUNVendedorTipoEntradaEventoYFechas.ShowDialog()
            ElseIf btnOn1.Text = "Off" And btnOn2.Text = "Off" And btnOn3.Text = "On" And btnOn4.Text = "Off" Then
                frmVentasPorRUNVendedorTipoEntradaFormaPagoYFechas.ShowDialog()
            Else
                MsgBox("El filtro seleccionado, no se encuentra disponible", MsgBoxStyle.Information, "Reportes")

            End If
        Catch ex As Exception
            MsgBox("Se produjo el siguiente error: " & ex.Message, MsgBoxStyle.Critical)
        End Try

    End Sub
    'Seleccion el nombre del evento
    Private Sub dgEventos_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgEventos.CellClick
        Try
            strNombreEvento = dgEventos.CurrentRow.Cells("NOMBREEVENTO").Value
            Me.txtNombreEvento.Text = strNombreEvento
            dgEventos.DataSource = Nothing
            blnBuscarEvento = True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub frmReporteVentas_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim drResultado As DialogResult = MsgBox("Asegúrese de haber completado correctamente sus operaciones. ¿Está seguro que desea cerrar? ", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Reporte de ventas")
        If drResultado = vbNo Then
            e.Cancel = True
        Else
            Me.Dispose()
        End If
    End Sub

    Private Sub btnOn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOn1.Click
        If btnOn1.Text = "On" Then
            cmbTipoEntrada.Enabled = True
            btnOn1.Text = "Off"
        Else
            cmbTipoEntrada.Enabled = False
            btnOn1.Text = "On"
        End If
    End Sub

    Private Sub btnOn2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOn2.Click
        If btnOn2.Text = "On" Then
            cmbTipoPago.Enabled = True
            btnOn2.Text = "Off"
        Else
            cmbTipoPago.Enabled = False
            btnOn2.Text = "On"
        End If
    End Sub

    Private Sub btnOn3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOn3.Click
        If btnOn3.Text = "On" Then
            txtNombreEvento.Enabled = True
            btnOn3.Text = "Off"
        Else
            txtNombreEvento.Enabled = False
            btnOn3.Text = "On"
        End If
    End Sub

    Private Sub btnOn4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOn4.Click
        If btnOn4.Text = "On" Then
            txtRUNVendedor.Enabled = True
            btnOn4.Text = "Off"
        Else
            txtRUNVendedor.Enabled = False
            btnOn4.Text = "On"
        End If
    End Sub

    Private Sub cmbTipoEntrada_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbTipoEntrada.KeyPress
        e.Handled = True
    End Sub

    Private Sub cmbTipoPago_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbTipoPago.KeyPress
        e.Handled = True
    End Sub

    Private Sub frmReporteVentas_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        MsgBox("Si desea obtener información para la fecha actual, debe hacer lo siguiente: en el campo ""Desde"" debe incluir la fecha actual (" + Date.Now.Date + ") y en el campo ""Hasta"" la fecha del día siguiente (" + Date.Now.Date.AddDays(1) + ").", MsgBoxStyle.Information, "Reporte de ventas")
    End Sub
End Class