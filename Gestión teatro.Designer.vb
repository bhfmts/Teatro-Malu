<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mdiTeatro
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub


    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim menuItemMisVentas As System.Windows.Forms.ToolStripMenuItem
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mdiTeatro))
        Me.menuItemDeHoy = New System.Windows.Forms.ToolStripMenuItem
        Me.menuItemIngresarIntervalo = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStrip = New System.Windows.Forms.MenuStrip
        Me.menuItemVendedor = New System.Windows.Forms.ToolStripMenuItem
        Me.mitVenderEntrada = New System.Windows.Forms.ToolStripMenuItem
        Me.menuItemAnularVenta = New System.Windows.Forms.ToolStripMenuItem
        Me.menuItemTotalComisiones = New System.Windows.Forms.ToolStripMenuItem
        Me.menuItemModificarContraseña = New System.Windows.Forms.ToolStripMenuItem
        Me.menuItemCerrarSesiónV = New System.Windows.Forms.ToolStripMenuItem
        Me.menuItemProduccion = New System.Windows.Forms.ToolStripMenuItem
        Me.menuItemRegistrarEventos = New System.Windows.Forms.ToolStripMenuItem
        Me.ModificarDatosEventosProMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.menuItemRegistrarEquipos = New System.Windows.Forms.ToolStripMenuItem
        Me.menuItemEliminarEquipos = New System.Windows.Forms.ToolStripMenuItem
        Me.menuItemPronosticarIngresos = New System.Windows.Forms.ToolStripMenuItem
        Me.menuItemDisponibilidadFechas = New System.Windows.Forms.ToolStripMenuItem
        Me.menuItemModificarContraseñaPro = New System.Windows.Forms.ToolStripMenuItem
        Me.menuItemSalirCerrarSesiónP = New System.Windows.Forms.ToolStripMenuItem
        Me.menuItemAdministrador = New System.Windows.Forms.ToolStripMenuItem
        Me.menuItemRegistrarUsuario = New System.Windows.Forms.ToolStripMenuItem
        Me.menuItemModificarUsuario = New System.Windows.Forms.ToolStripMenuItem
        Me.menuItemEliminarUsuario = New System.Windows.Forms.ToolStripMenuItem
        Me.menuItemResponderReclamo = New System.Windows.Forms.ToolStripMenuItem
        Me.menuItemListadoUsuarios = New System.Windows.Forms.ToolStripMenuItem
        Me.menuItemVendedores = New System.Windows.Forms.ToolStripMenuItem
        Me.menuItemProductores = New System.Windows.Forms.ToolStripMenuItem
        Me.menuItemAdministradores = New System.Windows.Forms.ToolStripMenuItem
        Me.menuItemClientes = New System.Windows.Forms.ToolStripMenuItem
        Me.menuItemModificarUbicaciones = New System.Windows.Forms.ToolStripMenuItem
        Me.menuItemVentasAnuladas = New System.Windows.Forms.ToolStripMenuItem
        Me.InformeDeVentaDeEntradasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.menuItemRankingVentas = New System.Windows.Forms.ToolStripMenuItem
        Me.menuItemInformeReclamos = New System.Windows.Forms.ToolStripMenuItem
        Me.menuItemModificarContraseñaAdmin = New System.Windows.Forms.ToolStripMenuItem
        Me.menuItemCerrarSesiónA = New System.Windows.Forms.ToolStripMenuItem
        Me.StatusGestionTeatro = New System.Windows.Forms.StatusStrip
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.TeatroDataSet = New Teatro.TeatroDataSet
        Me.AnulacionventaspeTableAdapter1 = New Teatro.TeatroDataSetTableAdapters.ANULACIONVENTASPETableAdapter
        Me.EventosjornadasTableAdapter1 = New Teatro.TeatroDataSetTableAdapters.EVENTOSJORNADASTableAdapter
        Me.AdministradoresTableAdapter1 = New Teatro.TeatroDataSetTableAdapters.ADMINISTRADORESTableAdapter
        Me.VendedoresTableAdapter1 = New Teatro.TeatroDataSetTableAdapters.VENDEDORESTableAdapter
        Me.ProduccionTableAdapter1 = New Teatro.TeatroDataSetTableAdapters.PRODUCCIONTableAdapter
        menuItemMisVentas = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStrip.SuspendLayout()
        Me.StatusGestionTeatro.SuspendLayout()
        CType(Me.TeatroDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'menuItemMisVentas
        '
        menuItemMisVentas.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        menuItemMisVentas.BackColor = System.Drawing.Color.DarkSlateGray
        menuItemMisVentas.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuItemDeHoy, Me.menuItemIngresarIntervalo})
        menuItemMisVentas.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        menuItemMisVentas.ForeColor = System.Drawing.Color.White
        menuItemMisVentas.Image = Global.Teatro.My.Resources.Resources.page_go
        menuItemMisVentas.ImageTransparentColor = System.Drawing.Color.Black
        menuItemMisVentas.Name = "menuItemMisVentas"
        menuItemMisVentas.Size = New System.Drawing.Size(254, 22)
        menuItemMisVentas.Text = "&Mis ventas"
        '
        'menuItemDeHoy
        '
        Me.menuItemDeHoy.BackColor = System.Drawing.Color.DarkSlateGray
        Me.menuItemDeHoy.ForeColor = System.Drawing.Color.White
        Me.menuItemDeHoy.Image = Global.Teatro.My.Resources.Resources._1day
        Me.menuItemDeHoy.Name = "menuItemDeHoy"
        Me.menuItemDeHoy.ShortcutKeys = System.Windows.Forms.Keys.F4
        Me.menuItemDeHoy.Size = New System.Drawing.Size(233, 22)
        Me.menuItemDeHoy.Text = "De hoy"
        '
        'menuItemIngresarIntervalo
        '
        Me.menuItemIngresarIntervalo.BackColor = System.Drawing.Color.DarkSlateGray
        Me.menuItemIngresarIntervalo.ForeColor = System.Drawing.Color.White
        Me.menuItemIngresarIntervalo.Image = Global.Teatro.My.Resources.Resources._5days
        Me.menuItemIngresarIntervalo.Name = "menuItemIngresarIntervalo"
        Me.menuItemIngresarIntervalo.ShortcutKeys = System.Windows.Forms.Keys.F5
        Me.menuItemIngresarIntervalo.Size = New System.Drawing.Size(233, 22)
        Me.menuItemIngresarIntervalo.Text = "Ingresar intervalo"
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuItemVendedor, Me.menuItemProduccion, Me.menuItemAdministrador})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Padding = New System.Windows.Forms.Padding(9, 2, 0, 2)
        Me.MenuStrip.Size = New System.Drawing.Size(1276, 24)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'menuItemVendedor
        '
        Me.menuItemVendedor.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.menuItemVendedor.BackColor = System.Drawing.Color.DarkSlateGray
        Me.menuItemVendedor.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mitVenderEntrada, Me.menuItemAnularVenta, menuItemMisVentas, Me.menuItemTotalComisiones, Me.menuItemModificarContraseña, Me.menuItemCerrarSesiónV})
        Me.menuItemVendedor.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.menuItemVendedor.ForeColor = System.Drawing.Color.Black
        Me.menuItemVendedor.ImageTransparentColor = System.Drawing.Color.DarkSlateGray
        Me.menuItemVendedor.Name = "menuItemVendedor"
        Me.menuItemVendedor.Size = New System.Drawing.Size(90, 20)
        Me.menuItemVendedor.Text = "&Vendedor"
        '
        'mitVenderEntrada
        '
        Me.mitVenderEntrada.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.mitVenderEntrada.BackColor = System.Drawing.Color.DarkSlateGray
        Me.mitVenderEntrada.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mitVenderEntrada.ForeColor = System.Drawing.Color.White
        Me.mitVenderEntrada.Image = CType(resources.GetObject("mitVenderEntrada.Image"), System.Drawing.Image)
        Me.mitVenderEntrada.ImageTransparentColor = System.Drawing.Color.Black
        Me.mitVenderEntrada.Name = "mitVenderEntrada"
        Me.mitVenderEntrada.ShortcutKeyDisplayString = ""
        Me.mitVenderEntrada.ShortcutKeys = System.Windows.Forms.Keys.F2
        Me.mitVenderEntrada.Size = New System.Drawing.Size(254, 22)
        Me.mitVenderEntrada.Text = "&Vender entrada"
        '
        'menuItemAnularVenta
        '
        Me.menuItemAnularVenta.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.menuItemAnularVenta.BackColor = System.Drawing.Color.DarkSlateGray
        Me.menuItemAnularVenta.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.menuItemAnularVenta.ForeColor = System.Drawing.Color.White
        Me.menuItemAnularVenta.Image = Global.Teatro.My.Resources.Resources.money_delete
        Me.menuItemAnularVenta.ImageTransparentColor = System.Drawing.Color.DarkRed
        Me.menuItemAnularVenta.Name = "menuItemAnularVenta"
        Me.menuItemAnularVenta.ShortcutKeys = System.Windows.Forms.Keys.F3
        Me.menuItemAnularVenta.Size = New System.Drawing.Size(254, 22)
        Me.menuItemAnularVenta.Text = "&Anular venta"
        '
        'menuItemTotalComisiones
        '
        Me.menuItemTotalComisiones.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.menuItemTotalComisiones.BackColor = System.Drawing.Color.DarkSlateGray
        Me.menuItemTotalComisiones.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.menuItemTotalComisiones.ForeColor = System.Drawing.Color.White
        Me.menuItemTotalComisiones.Image = Global.Teatro.My.Resources.Resources.money_dollar
        Me.menuItemTotalComisiones.ImageTransparentColor = System.Drawing.Color.Black
        Me.menuItemTotalComisiones.Name = "menuItemTotalComisiones"
        Me.menuItemTotalComisiones.ShortcutKeys = System.Windows.Forms.Keys.F6
        Me.menuItemTotalComisiones.Size = New System.Drawing.Size(254, 22)
        Me.menuItemTotalComisiones.Text = "Total comisiones"
        '
        'menuItemModificarContraseña
        '
        Me.menuItemModificarContraseña.BackColor = System.Drawing.Color.DarkSlateGray
        Me.menuItemModificarContraseña.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.menuItemModificarContraseña.ForeColor = System.Drawing.Color.White
        Me.menuItemModificarContraseña.Image = Global.Teatro.My.Resources.Resources.password1
        Me.menuItemModificarContraseña.Name = "menuItemModificarContraseña"
        Me.menuItemModificarContraseña.ShortcutKeys = System.Windows.Forms.Keys.F7
        Me.menuItemModificarContraseña.Size = New System.Drawing.Size(254, 22)
        Me.menuItemModificarContraseña.Text = "Modificar contraseña"
        '
        'menuItemCerrarSesiónV
        '
        Me.menuItemCerrarSesiónV.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.menuItemCerrarSesiónV.BackColor = System.Drawing.Color.DarkSlateGray
        Me.menuItemCerrarSesiónV.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.menuItemCerrarSesiónV.ForeColor = System.Drawing.Color.White
        Me.menuItemCerrarSesiónV.Image = Global.Teatro.My.Resources.Resources._exit
        Me.menuItemCerrarSesiónV.Name = "menuItemCerrarSesiónV"
        Me.menuItemCerrarSesiónV.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Q), System.Windows.Forms.Keys)
        Me.menuItemCerrarSesiónV.Size = New System.Drawing.Size(254, 22)
        Me.menuItemCerrarSesiónV.Text = "&Cerrar sesión"
        '
        'menuItemProduccion
        '
        Me.menuItemProduccion.BackColor = System.Drawing.Color.DarkSlateGray
        Me.menuItemProduccion.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuItemRegistrarEventos, Me.ModificarDatosEventosProMenuItem, Me.menuItemRegistrarEquipos, Me.menuItemEliminarEquipos, Me.menuItemPronosticarIngresos, Me.menuItemDisponibilidadFechas, Me.menuItemModificarContraseñaPro, Me.menuItemSalirCerrarSesiónP})
        Me.menuItemProduccion.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.menuItemProduccion.ForeColor = System.Drawing.Color.Black
        Me.menuItemProduccion.Name = "menuItemProduccion"
        Me.menuItemProduccion.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.menuItemProduccion.Size = New System.Drawing.Size(91, 20)
        Me.menuItemProduccion.Text = "Productor"
        '
        'menuItemRegistrarEventos
        '
        Me.menuItemRegistrarEventos.BackColor = System.Drawing.Color.DarkSlateGray
        Me.menuItemRegistrarEventos.ForeColor = System.Drawing.Color.White
        Me.menuItemRegistrarEventos.Image = Global.Teatro.My.Resources.Resources.date_go
        Me.menuItemRegistrarEventos.Name = "menuItemRegistrarEventos"
        Me.menuItemRegistrarEventos.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.menuItemRegistrarEventos.Size = New System.Drawing.Size(305, 22)
        Me.menuItemRegistrarEventos.Text = "Registrar eventos"
        '
        'ModificarDatosEventosProMenuItem
        '
        Me.ModificarDatosEventosProMenuItem.BackColor = System.Drawing.Color.DarkSlateGray
        Me.ModificarDatosEventosProMenuItem.ForeColor = System.Drawing.Color.White
        Me.ModificarDatosEventosProMenuItem.Image = Global.Teatro.My.Resources.Resources.date_edit
        Me.ModificarDatosEventosProMenuItem.Name = "ModificarDatosEventosProMenuItem"
        Me.ModificarDatosEventosProMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.ModificarDatosEventosProMenuItem.Size = New System.Drawing.Size(305, 22)
        Me.ModificarDatosEventosProMenuItem.Text = "Modificar eventos"
        '
        'menuItemRegistrarEquipos
        '
        Me.menuItemRegistrarEquipos.BackColor = System.Drawing.Color.DarkSlateGray
        Me.menuItemRegistrarEquipos.ForeColor = System.Drawing.Color.White
        Me.menuItemRegistrarEquipos.Image = Global.Teatro.My.Resources.Resources.kcmmidi
        Me.menuItemRegistrarEquipos.Name = "menuItemRegistrarEquipos"
        Me.menuItemRegistrarEquipos.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.menuItemRegistrarEquipos.Size = New System.Drawing.Size(305, 22)
        Me.menuItemRegistrarEquipos.Text = "Registrar equipos"
        '
        'menuItemEliminarEquipos
        '
        Me.menuItemEliminarEquipos.BackColor = System.Drawing.Color.DarkSlateGray
        Me.menuItemEliminarEquipos.ForeColor = System.Drawing.Color.White
        Me.menuItemEliminarEquipos.Image = Global.Teatro.My.Resources.Resources.application_form_delete
        Me.menuItemEliminarEquipos.Name = "menuItemEliminarEquipos"
        Me.menuItemEliminarEquipos.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.H), System.Windows.Forms.Keys)
        Me.menuItemEliminarEquipos.Size = New System.Drawing.Size(305, 22)
        Me.menuItemEliminarEquipos.Text = "Eliminar equipos"
        '
        'menuItemPronosticarIngresos
        '
        Me.menuItemPronosticarIngresos.BackColor = System.Drawing.Color.DarkSlateGray
        Me.menuItemPronosticarIngresos.ForeColor = System.Drawing.Color.White
        Me.menuItemPronosticarIngresos.Image = Global.Teatro.My.Resources.Resources.calc
        Me.menuItemPronosticarIngresos.Name = "menuItemPronosticarIngresos"
        Me.menuItemPronosticarIngresos.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.G), System.Windows.Forms.Keys)
        Me.menuItemPronosticarIngresos.Size = New System.Drawing.Size(305, 22)
        Me.menuItemPronosticarIngresos.Text = "Pronosticar ingresos"
        '
        'menuItemDisponibilidadFechas
        '
        Me.menuItemDisponibilidadFechas.BackColor = System.Drawing.Color.DarkSlateGray
        Me.menuItemDisponibilidadFechas.ForeColor = System.Drawing.Color.White
        Me.menuItemDisponibilidadFechas.Image = Global.Teatro.My.Resources.Resources.search
        Me.menuItemDisponibilidadFechas.Name = "menuItemDisponibilidadFechas"
        Me.menuItemDisponibilidadFechas.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Y), System.Windows.Forms.Keys)
        Me.menuItemDisponibilidadFechas.Size = New System.Drawing.Size(305, 22)
        Me.menuItemDisponibilidadFechas.Text = "Consultar disponibilidad"
        '
        'menuItemModificarContraseñaPro
        '
        Me.menuItemModificarContraseñaPro.BackColor = System.Drawing.Color.DarkSlateGray
        Me.menuItemModificarContraseñaPro.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.menuItemModificarContraseñaPro.ForeColor = System.Drawing.Color.White
        Me.menuItemModificarContraseñaPro.Image = Global.Teatro.My.Resources.Resources.password1
        Me.menuItemModificarContraseñaPro.Name = "menuItemModificarContraseñaPro"
        Me.menuItemModificarContraseñaPro.ShortcutKeys = System.Windows.Forms.Keys.F7
        Me.menuItemModificarContraseñaPro.Size = New System.Drawing.Size(305, 22)
        Me.menuItemModificarContraseñaPro.Text = "Modificar contraseña"
        '
        'menuItemSalirCerrarSesiónP
        '
        Me.menuItemSalirCerrarSesiónP.BackColor = System.Drawing.Color.DarkSlateGray
        Me.menuItemSalirCerrarSesiónP.ForeColor = System.Drawing.Color.White
        Me.menuItemSalirCerrarSesiónP.Image = Global.Teatro.My.Resources.Resources._exit
        Me.menuItemSalirCerrarSesiónP.Name = "menuItemSalirCerrarSesiónP"
        Me.menuItemSalirCerrarSesiónP.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Q), System.Windows.Forms.Keys)
        Me.menuItemSalirCerrarSesiónP.Size = New System.Drawing.Size(305, 22)
        Me.menuItemSalirCerrarSesiónP.Text = "Cerrar sesión"
        '
        'menuItemAdministrador
        '
        Me.menuItemAdministrador.BackColor = System.Drawing.Color.DarkSlateGray
        Me.menuItemAdministrador.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuItemRegistrarUsuario, Me.menuItemModificarUsuario, Me.menuItemEliminarUsuario, Me.menuItemResponderReclamo, Me.menuItemListadoUsuarios, Me.menuItemModificarUbicaciones, Me.menuItemVentasAnuladas, Me.InformeDeVentaDeEntradasToolStripMenuItem, Me.menuItemRankingVentas, Me.menuItemInformeReclamos, Me.menuItemModificarContraseñaAdmin, Me.menuItemCerrarSesiónA})
        Me.menuItemAdministrador.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.menuItemAdministrador.ForeColor = System.Drawing.Color.Black
        Me.menuItemAdministrador.Name = "menuItemAdministrador"
        Me.menuItemAdministrador.Size = New System.Drawing.Size(123, 20)
        Me.menuItemAdministrador.Text = "Administrador"
        '
        'menuItemRegistrarUsuario
        '
        Me.menuItemRegistrarUsuario.BackColor = System.Drawing.Color.DarkSlateGray
        Me.menuItemRegistrarUsuario.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.menuItemRegistrarUsuario.ForeColor = System.Drawing.Color.White
        Me.menuItemRegistrarUsuario.Image = Global.Teatro.My.Resources.Resources.add_user
        Me.menuItemRegistrarUsuario.Name = "menuItemRegistrarUsuario"
        Me.menuItemRegistrarUsuario.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
        Me.menuItemRegistrarUsuario.Size = New System.Drawing.Size(338, 22)
        Me.menuItemRegistrarUsuario.Text = "Registrar usuario"
        '
        'menuItemModificarUsuario
        '
        Me.menuItemModificarUsuario.BackColor = System.Drawing.Color.DarkSlateGray
        Me.menuItemModificarUsuario.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.menuItemModificarUsuario.ForeColor = System.Drawing.Color.White
        Me.menuItemModificarUsuario.Image = Global.Teatro.My.Resources.Resources.user_properties
        Me.menuItemModificarUsuario.Name = "menuItemModificarUsuario"
        Me.menuItemModificarUsuario.ShortcutKeyDisplayString = ""
        Me.menuItemModificarUsuario.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.menuItemModificarUsuario.Size = New System.Drawing.Size(338, 22)
        Me.menuItemModificarUsuario.Text = "Modificar usuario"
        '
        'menuItemEliminarUsuario
        '
        Me.menuItemEliminarUsuario.BackColor = System.Drawing.Color.DarkSlateGray
        Me.menuItemEliminarUsuario.ForeColor = System.Drawing.Color.White
        Me.menuItemEliminarUsuario.Image = Global.Teatro.My.Resources.Resources.delete_user
        Me.menuItemEliminarUsuario.Name = "menuItemEliminarUsuario"
        Me.menuItemEliminarUsuario.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.menuItemEliminarUsuario.Size = New System.Drawing.Size(338, 22)
        Me.menuItemEliminarUsuario.Text = "Eliminar usuario"
        '
        'menuItemResponderReclamo
        '
        Me.menuItemResponderReclamo.BackColor = System.Drawing.Color.DarkSlateGray
        Me.menuItemResponderReclamo.ForeColor = System.Drawing.Color.White
        Me.menuItemResponderReclamo.Image = Global.Teatro.My.Resources.Resources.email_go
        Me.menuItemResponderReclamo.Name = "menuItemResponderReclamo"
        Me.menuItemResponderReclamo.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.menuItemResponderReclamo.Size = New System.Drawing.Size(338, 22)
        Me.menuItemResponderReclamo.Text = "Responder reclamo"
        '
        'menuItemListadoUsuarios
        '
        Me.menuItemListadoUsuarios.BackColor = System.Drawing.Color.DarkSlateGray
        Me.menuItemListadoUsuarios.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuItemVendedores, Me.menuItemProductores, Me.menuItemAdministradores, Me.menuItemClientes})
        Me.menuItemListadoUsuarios.ForeColor = System.Drawing.Color.White
        Me.menuItemListadoUsuarios.Image = Global.Teatro.My.Resources.Resources.report_go
        Me.menuItemListadoUsuarios.Name = "menuItemListadoUsuarios"
        Me.menuItemListadoUsuarios.Size = New System.Drawing.Size(338, 22)
        Me.menuItemListadoUsuarios.Text = "Listado de usuarios"
        '
        'menuItemVendedores
        '
        Me.menuItemVendedores.BackColor = System.Drawing.Color.DarkSlateGray
        Me.menuItemVendedores.ForeColor = System.Drawing.Color.White
        Me.menuItemVendedores.Image = Global.Teatro.My.Resources.Resources.report_go
        Me.menuItemVendedores.Name = "menuItemVendedores"
        Me.menuItemVendedores.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.B), System.Windows.Forms.Keys)
        Me.menuItemVendedores.Size = New System.Drawing.Size(253, 22)
        Me.menuItemVendedores.Text = "Vendedores"
        '
        'menuItemProductores
        '
        Me.menuItemProductores.BackColor = System.Drawing.Color.DarkSlateGray
        Me.menuItemProductores.ForeColor = System.Drawing.Color.White
        Me.menuItemProductores.Image = Global.Teatro.My.Resources.Resources.report_go
        Me.menuItemProductores.Name = "menuItemProductores"
        Me.menuItemProductores.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.menuItemProductores.Size = New System.Drawing.Size(253, 22)
        Me.menuItemProductores.Text = "Productores"
        '
        'menuItemAdministradores
        '
        Me.menuItemAdministradores.BackColor = System.Drawing.Color.DarkSlateGray
        Me.menuItemAdministradores.ForeColor = System.Drawing.Color.White
        Me.menuItemAdministradores.Image = Global.Teatro.My.Resources.Resources.report_go
        Me.menuItemAdministradores.Name = "menuItemAdministradores"
        Me.menuItemAdministradores.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.M), System.Windows.Forms.Keys)
        Me.menuItemAdministradores.Size = New System.Drawing.Size(253, 22)
        Me.menuItemAdministradores.Text = "Administradores"
        '
        'menuItemClientes
        '
        Me.menuItemClientes.BackColor = System.Drawing.Color.DarkSlateGray
        Me.menuItemClientes.ForeColor = System.Drawing.Color.White
        Me.menuItemClientes.Image = Global.Teatro.My.Resources.Resources.report_go
        Me.menuItemClientes.Name = "menuItemClientes"
        Me.menuItemClientes.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.L), System.Windows.Forms.Keys)
        Me.menuItemClientes.Size = New System.Drawing.Size(253, 22)
        Me.menuItemClientes.Text = "Clientes"
        '
        'menuItemModificarUbicaciones
        '
        Me.menuItemModificarUbicaciones.BackColor = System.Drawing.Color.DarkSlateGray
        Me.menuItemModificarUbicaciones.ForeColor = System.Drawing.Color.White
        Me.menuItemModificarUbicaciones.Image = Global.Teatro.My.Resources.Resources.page_edit
        Me.menuItemModificarUbicaciones.Name = "menuItemModificarUbicaciones"
        Me.menuItemModificarUbicaciones.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.K), System.Windows.Forms.Keys)
        Me.menuItemModificarUbicaciones.Size = New System.Drawing.Size(338, 22)
        Me.menuItemModificarUbicaciones.Text = "Modificar capacidad"
        '
        'menuItemVentasAnuladas
        '
        Me.menuItemVentasAnuladas.BackColor = System.Drawing.Color.DarkSlateGray
        Me.menuItemVentasAnuladas.ForeColor = System.Drawing.Color.White
        Me.menuItemVentasAnuladas.Image = Global.Teatro.My.Resources.Resources.report_go
        Me.menuItemVentasAnuladas.Name = "menuItemVentasAnuladas"
        Me.menuItemVentasAnuladas.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.J), System.Windows.Forms.Keys)
        Me.menuItemVentasAnuladas.Size = New System.Drawing.Size(338, 22)
        Me.menuItemVentasAnuladas.Text = "Informe ventas anuladas"
        '
        'InformeDeVentaDeEntradasToolStripMenuItem
        '
        Me.InformeDeVentaDeEntradasToolStripMenuItem.BackColor = System.Drawing.Color.DarkSlateGray
        Me.InformeDeVentaDeEntradasToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.InformeDeVentaDeEntradasToolStripMenuItem.Image = Global.Teatro.My.Resources.Resources.money
        Me.InformeDeVentaDeEntradasToolStripMenuItem.Name = "InformeDeVentaDeEntradasToolStripMenuItem"
        Me.InformeDeVentaDeEntradasToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.W), System.Windows.Forms.Keys)
        Me.InformeDeVentaDeEntradasToolStripMenuItem.Size = New System.Drawing.Size(338, 22)
        Me.InformeDeVentaDeEntradasToolStripMenuItem.Text = "Informe ventas de entradas"
        '
        'menuItemRankingVentas
        '
        Me.menuItemRankingVentas.BackColor = System.Drawing.Color.DarkSlateGray
        Me.menuItemRankingVentas.ForeColor = System.Drawing.Color.White
        Me.menuItemRankingVentas.Image = Global.Teatro.My.Resources.Resources.chart
        Me.menuItemRankingVentas.Name = "menuItemRankingVentas"
        Me.menuItemRankingVentas.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.menuItemRankingVentas.Size = New System.Drawing.Size(338, 22)
        Me.menuItemRankingVentas.Text = "Ranking de ventas"
        '
        'menuItemInformeReclamos
        '
        Me.menuItemInformeReclamos.BackColor = System.Drawing.Color.DarkSlateGray
        Me.menuItemInformeReclamos.ForeColor = System.Drawing.Color.White
        Me.menuItemInformeReclamos.Image = Global.Teatro.My.Resources.Resources.report_go
        Me.menuItemInformeReclamos.Name = "menuItemInformeReclamos"
        Me.menuItemInformeReclamos.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.menuItemInformeReclamos.Size = New System.Drawing.Size(338, 22)
        Me.menuItemInformeReclamos.Text = "Informe reclamos"
        '
        'menuItemModificarContraseñaAdmin
        '
        Me.menuItemModificarContraseñaAdmin.BackColor = System.Drawing.Color.DarkSlateGray
        Me.menuItemModificarContraseñaAdmin.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.menuItemModificarContraseñaAdmin.ForeColor = System.Drawing.Color.White
        Me.menuItemModificarContraseñaAdmin.Image = Global.Teatro.My.Resources.Resources.password1
        Me.menuItemModificarContraseñaAdmin.Name = "menuItemModificarContraseñaAdmin"
        Me.menuItemModificarContraseñaAdmin.ShortcutKeys = System.Windows.Forms.Keys.F7
        Me.menuItemModificarContraseñaAdmin.Size = New System.Drawing.Size(338, 22)
        Me.menuItemModificarContraseñaAdmin.Text = "Modificar contraseña"
        '
        'menuItemCerrarSesiónA
        '
        Me.menuItemCerrarSesiónA.BackColor = System.Drawing.Color.DarkSlateGray
        Me.menuItemCerrarSesiónA.ForeColor = System.Drawing.Color.White
        Me.menuItemCerrarSesiónA.Image = Global.Teatro.My.Resources.Resources._exit
        Me.menuItemCerrarSesiónA.Name = "menuItemCerrarSesiónA"
        Me.menuItemCerrarSesiónA.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Q), System.Windows.Forms.Keys)
        Me.menuItemCerrarSesiónA.Size = New System.Drawing.Size(338, 22)
        Me.menuItemCerrarSesiónA.Text = "Cerrar sesión"
        '
        'StatusGestionTeatro
        '
        Me.StatusGestionTeatro.BackColor = System.Drawing.Color.DarkSlateGray
        Me.StatusGestionTeatro.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel})
        Me.StatusGestionTeatro.Location = New System.Drawing.Point(0, 752)
        Me.StatusGestionTeatro.Name = "StatusGestionTeatro"
        Me.StatusGestionTeatro.Padding = New System.Windows.Forms.Padding(2, 0, 21, 0)
        Me.StatusGestionTeatro.Size = New System.Drawing.Size(1276, 22)
        Me.StatusGestionTeatro.TabIndex = 7
        Me.StatusGestionTeatro.Text = "StatusStrip"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripStatusLabel.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel.ForeColor = System.Drawing.Color.White
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(51, 17)
        Me.ToolStripStatusLabel.Text = "Estado"
        '
        'TeatroDataSet
        '
        Me.TeatroDataSet.DataSetName = "TeatroDataSet"
        Me.TeatroDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AnulacionventaspeTableAdapter1
        '
        Me.AnulacionventaspeTableAdapter1.ClearBeforeFill = True
        '
        'EventosjornadasTableAdapter1
        '
        Me.EventosjornadasTableAdapter1.ClearBeforeFill = True
        '
        'AdministradoresTableAdapter1
        '
        Me.AdministradoresTableAdapter1.ClearBeforeFill = True
        '
        'VendedoresTableAdapter1
        '
        Me.VendedoresTableAdapter1.ClearBeforeFill = True
        '
        'ProduccionTableAdapter1
        '
        Me.ProduccionTableAdapter1.ClearBeforeFill = True
        '
        'mdiTeatro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSlateGray
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1276, 774)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.StatusGestionTeatro)
        Me.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "mdiTeatro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestión Teatro"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.StatusGestionTeatro.ResumeLayout(False)
        Me.StatusGestionTeatro.PerformLayout()
        CType(Me.TeatroDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusGestionTeatro As System.Windows.Forms.StatusStrip
    Friend WithEvents menuItemTotalComisiones As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuItemCerrarSesiónV As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuItemVendedor As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuItemAnularVenta As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mitVenderEntrada As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents menuItemProduccion As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuItemAdministrador As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuItemModificarContraseña As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuItemListadoUsuarios As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuItemVentasAnuladas As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InformeDeVentaDeEntradasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuItemRankingVentas As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TeatroDataSet As Teatro.TeatroDataSet
    Friend WithEvents menuItemModificarUbicaciones As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuItemSalirCerrarSesiónP As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuItemCerrarSesiónA As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuItemRegistrarEventos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModificarDatosEventosProMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuItemRegistrarUsuario As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuItemModificarUsuario As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuItemEliminarUsuario As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuItemDeHoy As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuItemIngresarIntervalo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AnulacionventaspeTableAdapter1 As Teatro.TeatroDataSetTableAdapters.ANULACIONVENTASPETableAdapter
    Friend WithEvents menuItemResponderReclamo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuItemVendedores As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuItemProductores As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuItemAdministradores As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuItemClientes As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EventosjornadasTableAdapter1 As Teatro.TeatroDataSetTableAdapters.EVENTOSJORNADASTableAdapter
    Friend WithEvents menuItemEliminarEquipos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuItemRegistrarEquipos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuItemPronosticarIngresos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdministradoresTableAdapter1 As Teatro.TeatroDataSetTableAdapters.ADMINISTRADORESTableAdapter
    Friend WithEvents VendedoresTableAdapter1 As Teatro.TeatroDataSetTableAdapters.VENDEDORESTableAdapter
    Friend WithEvents ProduccionTableAdapter1 As Teatro.TeatroDataSetTableAdapters.PRODUCCIONTableAdapter
    Friend WithEvents menuItemModificarContraseñaPro As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuItemModificarContraseñaAdmin As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuItemInformeReclamos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuItemDisponibilidadFechas As System.Windows.Forms.ToolStripMenuItem

End Class
