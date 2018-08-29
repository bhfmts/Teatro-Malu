Imports System.Windows.Forms
Imports Teatro.ClassConexion


Public Class mdiTeatro
    Private Sub mdiTeatro_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try
            Dim drResultado As DialogResult = MsgBox("Asegúrese de haber completado correctamente sus operaciones. ¿Está seguro que desea cerrar? ", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Registro eventos")
            If drResultado = vbNo Then
                e.Cancel = True
            ElseIf intPerfilUsuario = 1 Then
                Me.AdministradoresTableAdapter1.ActualizaEstadoSesion(0, strRUNUsuario)
            ElseIf intPerfilUsuario = 23 Then
                Me.ProduccionTableAdapter1.ActualizaEstadoSesion(0, strRUNUsuario)
                Me.VendedoresTableAdapter1.ActualizaEstadoSesion(0, strRUNUsuario)
            ElseIf intPerfilUsuario = 2 Then
                Me.ProduccionTableAdapter1.ActualizaEstadoSesion(0, strRUNUsuario)
            ElseIf intPerfilUsuario = 3 Then
                Me.VendedoresTableAdapter1.ActualizaEstadoSesion(0, strRUNUsuario)
            End If
        Catch ex As Exception
            MsgBox("Se produjo el siguiente error: " & ex.Message, MsgBoxStyle.Critical)
        End Try

    End Sub
    Private Sub mdiTeatro_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.GotFocus

        'Verificación de perfil del vendedor, para activar o desactivar los MenuItems.
        Try

            If intPerfilUsuario = 3 Then
                menuItemProduccion.Enabled = False
                menuItemAdministrador.Enabled = False
                menuItemVendedor.Enabled = True
                ToolStripStatusLabel.Text = "Vendedor:" + " " + strNombreVendedor
            End If
            If intPerfilUsuario = 1 Then
                ToolStripStatusLabel.Text = "Administrador:" + " " + strNombreAdministrador
                menuItemAdministrador.Enabled = True
                menuItemProduccion.Enabled = True
                menuItemVendedor.Enabled = True
            End If
            If intPerfilUsuario = 2 Then
                ToolStripStatusLabel.Text = "Productor:" + " " + strNombreProduccion
                menuItemAdministrador.Enabled = False
                menuItemVendedor.Enabled = False
                menuItemProduccion.Enabled = True
            End If
            If intPerfilUsuario = 23 Then
                ToolStripStatusLabel.Text = "Productor Y Vendedor:" + " " + strNombreProduccion
                menuItemAdministrador.Enabled = False
                menuItemVendedor.Enabled = True
                menuItemProduccion.Enabled = True
            End If
        Catch ex As Exception
            MsgBox("Se produjo el siguiente error: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub mdiTeatro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim hola As New frmIngreso
        'hola.MdiParent = Me
        hola.ShowDialog()
        'MsgBox("Aplicación en etapa de desarrollo, disculpe las molestias", MsgBoxStyle.Information)

    End Sub
    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticleToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Cierre todos los formularios secundarios del primario.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer = 0
    Private Sub mitVenderEntrada_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mitVenderEntrada.Click
        'frmVentasEntradas.MdiParent = Me
        frmVentasEntradas.ShowDialog()
    End Sub








    Private Sub ModificarDatosEventosMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim modificarEventos As New frmModificarEventos
        'modificarEventos.MdiParent = Me
        'modificarEventos.Show()
        frmModificarEventos.ShowDialog()
    End Sub




    'Cerrar sesión vendedor
    Private Sub menuItemSalirVendedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuItemCerrarSesiónV.Click
        Try
            ToolStripStatusLabel.Text = ""
            'intPerfilUsuario = 4
            For Each ChildForm As Form In Me.MdiChildren
                ChildForm.Close()
            Next
            If intPerfilUsuario = 1 Then
                Me.AdministradoresTableAdapter1.ActualizaEstadoSesion(0, strRUNUsuario)
                intPerfilUsuario = 8
            ElseIf intPerfilUsuario = 3 Then
                Me.VendedoresTableAdapter1.ActualizaEstadoSesion(0, strRUNUsuario)
                intPerfilUsuario = 8
            ElseIf intPerfilUsuario = 23 Then
                Me.VendedoresTableAdapter1.ActualizaEstadoSesion(0, strRUNUsuario)
                Me.ProduccionTableAdapter1.ActualizaEstadoSesion(0, strRUNUsuario)
                intPerfilUsuario = 8
            ElseIf intPerfilUsuario = 2 Then
                Me.ProduccionTableAdapter1.ActualizaEstadoSesion(0, strRUNUsuario)
                intPerfilUsuario = 8
            End If
            Dim hola As New frmIngreso
            hola.ShowDialog()
        Catch ex As Exception
            MsgBox("Se produjo el siguiente error: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    'Cerrar sesión productor
    Private Sub menuItemSalirProductor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuItemSalirCerrarSesiónP.Click
        Try
            ToolStripStatusLabel.Text = ""
            'intPerfilUsuario = 4
            For Each ChildForm As Form In Me.MdiChildren
                ChildForm.Close()
            Next
            If intPerfilUsuario = 1 Then
                Me.AdministradoresTableAdapter1.ActualizaEstadoSesion(0, strRUNUsuario)
            ElseIf intPerfilUsuario = 3 Then
                Me.VendedoresTableAdapter1.ActualizaEstadoSesion(0, strRUNUsuario)
            ElseIf intPerfilUsuario = 23 Then
                Me.VendedoresTableAdapter1.ActualizaEstadoSesion(0, strRUNUsuario)
                Me.ProduccionTableAdapter1.ActualizaEstadoSesion(0, strRUNUsuario)
            ElseIf intPerfilUsuario = 2 Then
                Me.ProduccionTableAdapter1.ActualizaEstadoSesion(0, strRUNUsuario)
            End If
            Dim hola As New frmIngreso
            hola.ShowDialog()
        Catch ex As Exception
            MsgBox("Se produjo el siguiente error: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub menuItemSalirAdministrador_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuItemCerrarSesiónA.Click
        ToolStripStatusLabel.Text = ""
        'intPerfilUsuario = 4
        Try
            For Each ChildForm As Form In Me.MdiChildren
                ChildForm.Close()
            Next
            Me.AdministradoresTableAdapter1.ActualizaEstadoSesion(0, strRUNUsuario)
            Dim hola As New frmIngreso
            hola.ShowDialog()
        Catch ex As Exception
            MsgBox("Se produjo el siguiente error: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    'Registrar eventos
    Private Sub MenuItemRegistrarEventos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuItemRegistrarEventos.Click
        'frmRegistroEvento.MdiParent = Me
        frmRegistroEvento.ShowDialog()
    End Sub

    'Modificar eventos
    Private Sub ModificarDatosEventosProMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModificarDatosEventosProMenuItem.Click
        'frmModificarEventos.MdiParent = Me
        frmModificarEventos.ShowDialog()
    End Sub

    Private Sub menuItemAnularVenta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuItemAnularVenta.Click
        'frmAnularVenta.MdiParent = Me
        frmAnularVenta.ShowDialog()
    End Sub

    Private Sub menuItemRegistrarUsuario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuItemRegistrarUsuario.Click
        frmRegistrarUsuario.rbdVendedor.Enabled = True
        frmRegistrarUsuario.rdbAdministrador.Enabled = True
        frmRegistrarUsuario.rdbProductor.Enabled = True
        frmRegistrarUsuario.rdbCliente.Enabled = True
        frmRegistrarUsuario.ShowDialog()
    End Sub

    Private Sub menuItemModificarVendedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuItemModificarUsuario.Click
        'frmModificarUsuario.MdiParent = Me
        frmModificarUsuario.ShowDialog()
    End Sub

    Private Sub menuItemEliminarUsuario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuItemEliminarUsuario.Click
        'frmEliminarUsuario.MdiParent = Me
        frmEliminarUsuario.ShowDialog()
    End Sub

    Private Sub menuItemDeHoy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuItemDeHoy.Click
        frmVentasDiarias.ShowDialog()
    End Sub

    Private Sub menuItemIngresarIntervalo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuItemIngresarIntervalo.Click
        'My.Forms.frmVentasVendedor.ShowDialog()
        frmVentasVendedor.ShowDialog()
    End Sub


    Private Sub menuItemTotalComisiones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuItemTotalComisiones.Click
        frmComisiones.ShowDialog()
    End Sub

    Private Sub menuItemResponderReclamo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuItemResponderReclamo.Click
        frmResponderReclamo.ShowDialog()
    End Sub

    Private Sub menuItemVendedores_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuItemVendedores.Click
        frmListadoVendedores.ShowDialog()
    End Sub

    Private Sub menuItemModificarUbicaciones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuItemModificarUbicaciones.Click
        frmUbicaciones.ShowDialog()
    End Sub


    Private Sub menuItemVentasAnuladas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuItemVentasAnuladas.Click
        frmVentasAnuladas.ShowDialog()
    End Sub


    Private Sub menuItemRegistrarEquipos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuItemRegistrarEquipos.Click
        frmRegistrarEquipos.ShowDialog()
    End Sub

    Private Sub menuItemEliminarEquipos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuItemEliminarEquipos.Click
        frmEliminarEquipos.ShowDialog()
    End Sub

    Private Sub menuItemPronosticarIngresos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuItemPronosticarIngresos.Click
        frmPronosticoIngresos.ShowDialog()
    End Sub

    Private Sub InformeDeVentaDeEntradasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InformeDeVentaDeEntradasToolStripMenuItem.Click
        frmReporteVentas.ShowDialog()
    End Sub

    Private Sub menuItemRankingVentas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuItemRankingVentas.Click
        frmRankingVentasGrafico.ShowDialog()
    End Sub
    Private Sub menuItemModificarContraseña_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuItemModificarContraseña.Click
        frmModificarContraseña.ShowDialog()
    End Sub

    Private Sub menuItemModificarContraseñaAdmin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuItemModificarContraseñaAdmin.Click
        frmModificarContraseña.ShowDialog()
    End Sub

    Private Sub menuItemModificarContraseñaPro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuItemModificarContraseñaPro.Click
        frmModificarContraseña.ShowDialog()
    End Sub

    Private Sub menuItemInformeReclamos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuItemInformeReclamos.Click
        frmInformeReclamos.ShowDialog()
    End Sub
    Private Sub menuItemProductores_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuItemProductores.Click
        frmListadoProductores.ShowDialog()
    End Sub
  
    Private Sub menuItemClientes_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItemClientes.Click
        frmListadoClientes.ShowDialog()
    End Sub

    Private Sub menuItemAdministradores_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuItemAdministradores.Click
        frmListadoAdministradores.ShowDialog()
    End Sub

    Private Sub menuItemDisponibilidadFechas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuItemDisponibilidadFechas.Click
        frmConsultarDisponibilidad.ShowDialog()
    End Sub
End Class