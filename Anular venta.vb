Imports System.Data.SqlClient
Imports Teatro.ClassConexion
Imports Teatro.ClassAdministrador
Imports Teatro.ClassCliente
Imports System.Transactions
Public Class frmAnularVenta
    '**************************************************************************************************************
    'Declaración de variables a utilizar
    Dim intNumeroBoleta As Integer
    Dim strFechaVenta As String
    Dim intMontoPagar As Integer
    Dim intMontoEfectivo As Integer
    Dim intVuelto As Integer
    Dim intMontoTarjeta As Integer
    Dim intNumeroCuotas As Integer
    Dim strTipoTarjeta As String
    Dim drResultado As DialogResult
    Dim strFormaPago As String
    Dim blnTeclaBorrar As Boolean
    Dim intDias As Integer
    Dim dtFechaEvento As Date
    Dim strRUNCliente
    '**************************************************************************************************************
    'Al escribir el número de boleta correcto se cargan los datos de la boleta a anular según el numero de boleta ingresado
    Private Sub txtNumeroBoleta_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNumeroBoleta.TextChanged
        Conexion.Close()
        Try
            Me.dgDetalleBoleta.RowHeadersVisible = False
            If blnTeclaBorrar = True Then
                blnTeclaBorrar = False
                Me.dgDetalleBoleta.DataSource = Nothing
                Exit Sub
            End If
            If txtNumeroBoleta.Text <> "" Or txtNumeroBoleta.Text <> Nothing Or txtNumeroBoleta.TextLength <> 0 Then
                strFormaPago = Me.VENTAENTRADASTableAdapter.SelectFormaPago(Integer.Parse(txtNumeroBoleta.Text))
            Else
                Exit Sub
            End If
            '**************************************************************************************************************
            'Se cargan los datos correspondientes a una venta en efectivo

            If strFormaPago = "Efectivo" Then

                Conexion.Open()
                Dim DSET As New DataSet
                Dim DAD As New SqlDataAdapter("SELECT DISTINCT BOLETAS.NUMEROBOLETA, boletas.FECHAVENTA, MONTOPAGAR, MONTOEFECTIVO, VUELTO FROM BOLETAS, PAGOEFECTIVO WHERE BOLETAS.NUMEROBOLETA='" & Integer.Parse(txtNumeroBoleta.Text) & "' AND BOLETAS.NUMEROBOLETA = PAGOEFECTIVO.NUMEROBOLETA", Conexion)
                DAD.Fill(DSET)
                dgDetalleBoleta.DataSource = DSET
                dgDetalleBoleta.DataMember = "TABLE"
                Me.dgDetalleBoleta.Columns(0).HeaderText = "N° boleta"
                Me.dgDetalleBoleta.Columns(1).HeaderText = "Fecha venta"
                Me.dgDetalleBoleta.Columns(2).HeaderText = "Monto pagar"
                Me.dgDetalleBoleta.Columns(3).HeaderText = "Monto efectivo"
                Me.dgDetalleBoleta.Columns(4).HeaderText = "Vuelto"
                intNumeroBoleta = Me.dgDetalleBoleta.Rows(0).Cells(0).Value
                strFechaVenta = Me.dgDetalleBoleta.Rows(0).Cells(1).Value
                intMontoPagar = Me.dgDetalleBoleta.Rows(0).Cells(2).Value
                intMontoEfectivo = Me.dgDetalleBoleta.Rows(0).Cells(3).Value
                intVuelto = Me.dgDetalleBoleta.Rows(0).Cells(4).Value
            


            Else
                Me.dgDetalleBoleta.DataSource = Nothing
            End If
        Catch ex As Exception
            MsgBox("Se ha producido el siguiente error: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    '**************************************************************************************************************
    'Operaciones que se realizan al presionar el botón anular
    Private Sub btnAnular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnular.Click
        Try
            Dim strJornadaAnula As String
            Dim strUbicacionAnula As String
            Dim intEntradasVendidas As Integer
            Dim intIDEventoActualizarEstadoEntradas As Integer
            Dim dtFechaActualizarEstadoEntradas As Date
            Dim intCompruebaAnulacion As Integer = Me.AnulacionventaspeTableAdapter1.ComprobarAnulacion(intNumeroBoleta)
            'Validaciones de campo nulo


            If BuscarRUNCliente(strRUNCliente) = True Then

                If String.IsNullOrEmpty(txtNumeroBoleta.Text) Then
                    ErrorProviderAnularVenta.SetError(txtNumeroBoleta, "Campo obligatorio")
                    ErrorProviderAnularVenta.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
                    Exit Sub
                Else
                    ErrorProviderAnularVenta.SetError(txtNumeroBoleta, "")
                End If

                If String.IsNullOrEmpty(txtMotivo.Text) Then
                    ErrorProviderAnularVenta.SetError(txtMotivo, "Campo obligatorio")
                    ErrorProviderAnularVenta.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
                    Exit Sub
                Else
                    ErrorProviderAnularVenta.SetError(txtMotivo, "")
                End If
                'Validación de campos
                If Not IsNumeric(txtRUNusuario.Text) OrElse String.IsNullOrEmpty(txtRUNusuario.Text) Then
                    ErrorProviderAnularVenta.SetError(txtRUNusuario, "Ingrese un valor númerico")
                    Exit Sub
                Else
                    ErrorProviderAnularVenta.SetError(txtRUNusuario, "")
                End If
                dtFechaEvento = Me.VENTAENTRADASTableAdapter.SelectFechaEvento(intNumeroBoleta)
                intDias = DateDiff(DateInterval.Day, Date.Now, dtFechaEvento)
                If intCompruebaAnulacion = 0 Then
                    'Aquí valido que la compra debe ser anulada tres días antes de producirse el evento
                    If intDias < 2 And BuscarRUNAdministrador(strRUNUsuario) = False Then
                        MsgBox("¡Lo sentimos! El plazo para hacer anulación de compras son 3 días antes de la producción del evento.", MsgBoxStyle.Critical, "Anular venta")
                        MsgBox("Un administrador del sistema puede hacer las anulaciones de compras por fuerza mayor", MsgBoxStyle.Information, "Anular venta")
                        Exit Sub
                    ElseIf BuscarRUNAdministrador(strRUNUsuario) = True And intDias < 2 Then
                        MsgBox("Ud. tiene los permisos para hacer anulaciones de compras por motivos de fuerza mayor", MsgBoxStyle.Information, "Anular venta")
                    End If
                    dtFechaActualizarEstadoEntradas = Me.VENTAENTRADASTableAdapter.SelectFechaEvento(intNumeroBoleta)
                    intIDEventoActualizarEstadoEntradas = Me.EventosTableAdapter1.SelectIDEventoPaActualizarEstadoEntradas(intNumeroBoleta)
                    intEntradasVendidas = Me.VentasjornadasTableAdapter1.SelectCantidadVendidas(intNumeroBoleta)
                    strUbicacionAnula = Me.VentasubicacionesTableAdapter1.SelectUbicacionAnula(intNumeroBoleta)
                    strJornadaAnula = Me.VentasjornadasTableAdapter1.SelectJornadaAnula(intNumeroBoleta)
                    'Aquí verifico en que jornada fue emitida la boleta a anular
                    If Me.VentasjornadasTableAdapter1.SelectJornadaAnula(intNumeroBoleta) = 3 Then
                        strJornadaAnula = "Noche"
                    ElseIf Me.VentasjornadasTableAdapter1.SelectJornadaAnula(intNumeroBoleta) = 2 Then
                        strJornadaAnula = "Tarde"
                    ElseIf Me.VentasjornadasTableAdapter1.SelectJornadaAnula(intNumeroBoleta) = 1 Then
                        strJornadaAnula = "Matiné"
                    End If

                    drResultado = MsgBox("¿Está seguro que desea anular la venta?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Anular venta")
                    '**************************************************************************************************************
                    'Se borran los datos respecto a si la venta fue hecha en efectivo

                    If drResultado = vbYes And strFormaPago = "Efectivo" Then
                        'Me.PagoefectivoTableAdapter1.DeletePagoEfectivo(intNumeroBoleta)
                        'Me.VENTAENTRADASTableAdapter.DeleteVenta(intNumeroBoleta)
                        'Me.BoletasTableAdapter1.DeleteBoleta(intNumeroBoleta)
                        Me.BoletasTableAdapter1.UpdateEstadoBoleta(intNumeroBoleta)
                        Me.AnulacionventaspeTableAdapter1.Insert(strRUNUsuario, intNumeroBoleta, intMontoPagar, intMontoEfectivo, _
                        intVuelto, txtMotivo.Text, Now, strFechaVenta, strRUNCliente)
                        'Me.VentasjornadasTableAdapter1.DeleteVentasJornadas(intNumeroBoleta)
                        'Me.VentasubicacionesTableAdapter1.DeleteVentasUbicaciones(intNumeroBoleta)
                        'Aquí se actualiza el estado de entradas después de la anulación
                        If strUbicacionAnula = "Balcones" Then
                            Me.EstadoentradasTableAdapter1.UpdateBalcones(intEntradasVendidas, intIDEventoActualizarEstadoEntradas, dtFechaActualizarEstadoEntradas, strJornadaAnula)
                        ElseIf strUbicacion = "Platea" Then
                            Me.EstadoentradasTableAdapter1.UpdatePlatea(intEntradasVendidas, intIDEventoActualizarEstadoEntradas, dtFechaActualizarEstadoEntradas, strJornadaAnula)
                        ElseIf strUbicacion = "Platea numerada" Then
                            Me.EstadoentradasTableAdapter1.UpdateBalcones(intEntradasVendidas, intIDEventoActualizarEstadoEntradas, dtFechaActualizarEstadoEntradas, strJornadaAnula)
                        End If
                        Me.dgDetalleBoleta.DataSource = Nothing
                        MsgBox("Venta anulada satisfactoriamente", MsgBoxStyle.Information)
                        txtNumeroBoleta.Text = Nothing
                        txtMotivo.Clear()
                        'Se borran los datos respecto a si la venta fue hecha con tarjeta bancaria
                    End If
                Else
                    MsgBox("Esta boleta ya fue anulada", MsgBoxStyle.Exclamation, "Anular venta")
                End If
            Else
                MsgBox("Debe registrar el cliente que está anulando la venta antes de realizar la operación", MsgBoxStyle.Critical, "Anular venta")
            End If
        Catch ex As Exception
            MsgBox("Se produjo el siguiente error: " & ex.Message, MsgBoxStyle.Critical, "Teatro")
        End Try
    End Sub
    '**************************************************************************************************************
    'Validación para ingresar sólo números
    Private Sub txtNumeroBoleta_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNumeroBoleta.KeyPress
        If (Asc(e.KeyChar)) >= 48 And (Asc(e.KeyChar)) <= 57 Or (Asc(e.KeyChar)) = System.Windows.Forms.Keys.Back Or Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
        If e.KeyChar = ChrW(Keys.Back) Then
            blnTeclaBorrar = True
        End If
    End Sub
    '**************************************************************************************************************
    'Cerrar ventana
    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        drResultado = MsgBox("Asegúrese de haber completado correctamente sus operaciones. ¿Está seguro que desea cerrar? ", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Registro eventos")
        If drResultado = vbYes Then
            Me.Close()
        End If
    End Sub


    Private Sub frmAnularVenta_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim drResultado As DialogResult = MsgBox("Asegúrese de haber completado correctamente sus operaciones. ¿Está seguro que desea cerrar? ", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Registro eventos")
        If drResultado = vbNo Then
            e.Cancel = True
        Else
            Me.Dispose()
        End If
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Try
            strRUNCliente = txtRUNusuario.Text & "-" & txtGuion.Text
            'Validación de campos
            If Not IsNumeric(txtRUNusuario.Text) OrElse String.IsNullOrEmpty(txtRUNusuario.Text) Then
                ErrorProviderAnularVenta.SetError(txtRUNusuario, "Ingrese un valor númerico")
                Exit Sub
            Else
                ErrorProviderAnularVenta.SetError(txtRUNusuario, "")
            End If
            If String.IsNullOrEmpty(txtGuion.Text) Then
                ErrorProviderAnularVenta.SetError(txtGuion, "Campo obligatorio")
                Exit Sub
            Else
                ErrorProviderAnularVenta.SetError(txtGuion, "")
            End If
            'Aquí verifico si el cliente está registrado, si no para registrarlo
            If BuscarRUNCliente(strRUNCliente) = False Then
                MsgBox("Para anular una venta, por políticas del Teatro es de carácter obligatorio registrar el cliente", MsgBoxStyle.Information, "Anular venta")
                frmRegistrarUsuario.rbdVendedor.Enabled = False
                frmRegistrarUsuario.rdbAdministrador.Enabled = False
                frmRegistrarUsuario.rdbProductor.Enabled = False
                frmRegistrarUsuario.rdbCliente.Enabled = True
                frmRegistrarUsuario.txtRUNUsuario.Text = txtRUNusuario.Text
                frmRegistrarUsuario.txtGuion.Text = txtGuion.Text
                frmRegistrarUsuario.rdbCliente.Checked = True
                frmRegistrarUsuario.ShowDialog()
            Else
                MsgBox("El cliente fue encontrado", MsgBoxStyle.Information, "Anular venta")
            End If
        Catch ex As Exception
            MsgBox("Se ha producido el siguiente error: " & ex.Message, MsgBoxStyle.Critical)
        End Try

    End Sub
    'Ayuda para el formulario
    Private Sub frmAnularVenta_HelpRequested(ByVal sender As Object, ByVal hlpevent As System.Windows.Forms.HelpEventArgs) Handles Me.HelpRequested
        Try
            System.Diagnostics.Process.Start("\\BERNARDO\Manuales\Anular venta.avi")
        Catch ex As Exception
            MsgBox("Se ha producido el siguiente error: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
End Class