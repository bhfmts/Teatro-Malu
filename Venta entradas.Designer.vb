<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVentasEntradas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVentasEntradas))
        Me.ErrorProviderVentaEntradas = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolTipVentraEntradas = New System.Windows.Forms.ToolTip(Me.components)
        Me.ErrorProviderCantUbic = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ErrorProviderEfectivo = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.groInfoPersonal = New System.Windows.Forms.GroupBox
        Me.btnRegistrarCliente = New System.Windows.Forms.Button
        Me.btnOcultar = New System.Windows.Forms.Button
        Me.btnLimpiar = New System.Windows.Forms.Button
        Me.cmbAño = New System.Windows.Forms.ComboBox
        Me.Label23 = New System.Windows.Forms.Label
        Me.cmbMes = New System.Windows.Forms.ComboBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.cmbDia = New System.Windows.Forms.ComboBox
        Me.txtTelefonoUsuario = New System.Windows.Forms.TextBox
        Me.lblFechaNacVendedor = New System.Windows.Forms.Label
        Me.lblGuionEmpleado = New System.Windows.Forms.Label
        Me.txtGuion = New System.Windows.Forms.TextBox
        Me.txtApellidosUsuario = New System.Windows.Forms.TextBox
        Me.lblApellidosVendedor = New System.Windows.Forms.Label
        Me.txtNombresUsuario = New System.Windows.Forms.TextBox
        Me.lblRUNEmpleado = New System.Windows.Forms.Label
        Me.lblTelefonoEmpleado = New System.Windows.Forms.Label
        Me.lblNombreVendedor = New System.Windows.Forms.Label
        Me.lblDireccionVendedor = New System.Windows.Forms.Label
        Me.txtRUNUsuario = New System.Windows.Forms.TextBox
        Me.txtDireccionUsuario = New System.Windows.Forms.TextBox
        Me.groBuscarCliente = New System.Windows.Forms.GroupBox
        Me.btnBuscarCliente = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtRUNBuscar = New System.Windows.Forms.TextBox
        Me.txtGuionBuscar = New System.Windows.Forms.TextBox
        Me.lblRUNBuscar = New System.Windows.Forms.Label
        Me.groTarjetaBancaria = New System.Windows.Forms.GroupBox
        Me.btnPagarTarjeBanca = New System.Windows.Forms.Button
        Me.rdbCuotasFijas = New System.Windows.Forms.RadioButton
        Me.cmbTipoTarjeta = New System.Windows.Forms.ComboBox
        Me.cmbCantidadCuotas = New System.Windows.Forms.ComboBox
        Me.rdbSincuotas = New System.Windows.Forms.RadioButton
        Me.lblNumeroCuenta = New System.Windows.Forms.Label
        Me.txtMontoTarjeta = New System.Windows.Forms.TextBox
        Me.txtNumeroCuenta = New System.Windows.Forms.TextBox
        Me.lblMontoTarjeta = New System.Windows.Forms.Label
        Me.lblTipoTarjeta = New System.Windows.Forms.Label
        Me.GroPagoEfectivo = New System.Windows.Forms.GroupBox
        Me.btnPagarEfectivo = New System.Windows.Forms.Button
        Me.txtVuelto = New System.Windows.Forms.TextBox
        Me.txtMontoEfectivo = New System.Windows.Forms.TextBox
        Me.lblMonto = New System.Windows.Forms.Label
        Me.txtMonto = New System.Windows.Forms.TextBox
        Me.lblVuelto = New System.Windows.Forms.Label
        Me.lblMontoEfetivo = New System.Windows.Forms.Label
        Me.groInfoEvento = New System.Windows.Forms.GroupBox
        Me.btnCualquierDia = New System.Windows.Forms.Button
        Me.btnListoInfoEvento = New System.Windows.Forms.Button
        Me.btnHoy = New System.Windows.Forms.Button
        Me.cmbFechasEvento = New System.Windows.Forms.ComboBox
        Me.lblNombreEvento = New System.Windows.Forms.Label
        Me.txtFechaVenta = New System.Windows.Forms.TextBox
        Me.lblEntraGeneral = New System.Windows.Forms.Label
        Me.lblFechaVenta = New System.Windows.Forms.Label
        Me.lblTipoEntrada = New System.Windows.Forms.Label
        Me.cmbNombreEvento = New System.Windows.Forms.ComboBox
        Me.lblFechaEvento = New System.Windows.Forms.Label
        Me.txtEntradaGeneral = New System.Windows.Forms.TextBox
        Me.cmbTipoEntrada = New System.Windows.Forms.ComboBox
        Me.groUbicaciones = New System.Windows.Forms.GroupBox
        Me.lblDisponible = New System.Windows.Forms.Label
        Me.lblDisponibilidad = New System.Windows.Forms.Label
        Me.btnAtrasUbicaciones = New System.Windows.Forms.Button
        Me.btnListo = New System.Windows.Forms.Button
        Me.cmbUbicacion = New System.Windows.Forms.ComboBox
        Me.nupCantidad = New System.Windows.Forms.NumericUpDown
        Me.lblCantidad = New System.Windows.Forms.Label
        Me.lblUbicacion = New System.Windows.Forms.Label
        Me.groJornadas = New System.Windows.Forms.GroupBox
        Me.btnAtrasJornadas = New System.Windows.Forms.Button
        Me.chkMatine = New System.Windows.Forms.CheckBox
        Me.chkTarde = New System.Windows.Forms.CheckBox
        Me.chkNoche = New System.Windows.Forms.CheckBox
        Me.groTipoPago = New System.Windows.Forms.GroupBox
        Me.rdbEfectivo = New System.Windows.Forms.RadioButton
        Me.rdbTarBancaria = New System.Windows.Forms.RadioButton
        Me.btnAtrasTipoPago = New System.Windows.Forms.Button
        Me.EVENTOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TeatroDataSet = New Teatro.TeatroDataSet
        Me.VENTAENTRADASTableAdapter = New Teatro.TeatroDataSetTableAdapters.VENTASENTRADASTableAdapter
        Me.RegistraclienteTableAdapter1 = New Teatro.TeatroDataSetTableAdapters.REGISTRACLIENTETableAdapter
        Me.ComprasclientesTableAdapter1 = New Teatro.TeatroDataSetTableAdapters.COMPRASCLIENTESTableAdapter
        Me.EVENTOSTableAdapter = New Teatro.TeatroDataSetTableAdapters.EVENTOSTableAdapter
        Me.ClientesTableAdapter1 = New Teatro.TeatroDataSetTableAdapters.CLIENTESTableAdapter
        Me.VentasjornadasTableAdapter1 = New Teatro.TeatroDataSetTableAdapters.VENTASJORNADASTableAdapter
        Me.PAGOEFECTIVOTableAdapter = New Teatro.TeatroDataSetTableAdapters.PAGOEFECTIVOTableAdapter
        Me.EventosTableAdapter1 = New Teatro.TeatroDataSetTableAdapters.EVENTOSTableAdapter
        Me.BOLETASTableAdapter = New Teatro.TeatroDataSetTableAdapters.BOLETASTableAdapter
        Me.VentasubicacionesTableAdapter1 = New Teatro.TeatroDataSetTableAdapters.VENTASUBICACIONESTableAdapter
        Me.PAGOTARJETACREDITOTableAdapter = New Teatro.TeatroDataSetTableAdapters.PAGOTARJETACREDITOTableAdapter
        Me.EstadoentradasTableAdapter1 = New Teatro.TeatroDataSetTableAdapters.ESTADOENTRADASTableAdapter
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.ErrorProviderVentaEntradas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProviderCantUbic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProviderEfectivo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groInfoPersonal.SuspendLayout()
        Me.groBuscarCliente.SuspendLayout()
        Me.groTarjetaBancaria.SuspendLayout()
        Me.GroPagoEfectivo.SuspendLayout()
        Me.groInfoEvento.SuspendLayout()
        Me.groUbicaciones.SuspendLayout()
        CType(Me.nupCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groJornadas.SuspendLayout()
        Me.groTipoPago.SuspendLayout()
        CType(Me.EVENTOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TeatroDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ErrorProviderVentaEntradas
        '
        Me.ErrorProviderVentaEntradas.ContainerControl = Me
        '
        'ToolTipVentraEntradas
        '
        Me.ToolTipVentraEntradas.IsBalloon = True
        '
        'ErrorProviderCantUbic
        '
        Me.ErrorProviderCantUbic.ContainerControl = Me
        '
        'Timer1
        '
        '
        'ErrorProviderEfectivo
        '
        Me.ErrorProviderEfectivo.ContainerControl = Me
        '
        'groInfoPersonal
        '
        Me.groInfoPersonal.BackColor = System.Drawing.Color.DarkSlateGray
        Me.groInfoPersonal.Controls.Add(Me.btnRegistrarCliente)
        Me.groInfoPersonal.Controls.Add(Me.btnOcultar)
        Me.groInfoPersonal.Controls.Add(Me.btnLimpiar)
        Me.groInfoPersonal.Controls.Add(Me.cmbAño)
        Me.groInfoPersonal.Controls.Add(Me.Label23)
        Me.groInfoPersonal.Controls.Add(Me.cmbMes)
        Me.groInfoPersonal.Controls.Add(Me.Label22)
        Me.groInfoPersonal.Controls.Add(Me.Label21)
        Me.groInfoPersonal.Controls.Add(Me.cmbDia)
        Me.groInfoPersonal.Controls.Add(Me.txtTelefonoUsuario)
        Me.groInfoPersonal.Controls.Add(Me.lblFechaNacVendedor)
        Me.groInfoPersonal.Controls.Add(Me.lblGuionEmpleado)
        Me.groInfoPersonal.Controls.Add(Me.txtGuion)
        Me.groInfoPersonal.Controls.Add(Me.txtApellidosUsuario)
        Me.groInfoPersonal.Controls.Add(Me.lblApellidosVendedor)
        Me.groInfoPersonal.Controls.Add(Me.txtNombresUsuario)
        Me.groInfoPersonal.Controls.Add(Me.lblRUNEmpleado)
        Me.groInfoPersonal.Controls.Add(Me.lblTelefonoEmpleado)
        Me.groInfoPersonal.Controls.Add(Me.lblNombreVendedor)
        Me.groInfoPersonal.Controls.Add(Me.lblDireccionVendedor)
        Me.groInfoPersonal.Controls.Add(Me.txtRUNUsuario)
        Me.groInfoPersonal.Controls.Add(Me.txtDireccionUsuario)
        Me.groInfoPersonal.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groInfoPersonal.ForeColor = System.Drawing.Color.White
        Me.groInfoPersonal.Location = New System.Drawing.Point(666, 10)
        Me.groInfoPersonal.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.groInfoPersonal.Name = "groInfoPersonal"
        Me.groInfoPersonal.Padding = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.groInfoPersonal.Size = New System.Drawing.Size(320, 320)
        Me.groInfoPersonal.TabIndex = 0
        Me.groInfoPersonal.TabStop = False
        Me.groInfoPersonal.Text = "Información personal"
        '
        'btnRegistrarCliente
        '
        Me.btnRegistrarCliente.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnRegistrarCliente.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistrarCliente.ForeColor = System.Drawing.Color.GhostWhite
        Me.btnRegistrarCliente.Location = New System.Drawing.Point(214, 258)
        Me.btnRegistrarCliente.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.btnRegistrarCliente.Name = "btnRegistrarCliente"
        Me.btnRegistrarCliente.Size = New System.Drawing.Size(72, 35)
        Me.btnRegistrarCliente.TabIndex = 43
        Me.btnRegistrarCliente.Text = "Registrar"
        Me.btnRegistrarCliente.UseVisualStyleBackColor = False
        '
        'btnOcultar
        '
        Me.btnOcultar.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnOcultar.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOcultar.Location = New System.Drawing.Point(39, 258)
        Me.btnOcultar.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.btnOcultar.Name = "btnOcultar"
        Me.btnOcultar.Size = New System.Drawing.Size(72, 35)
        Me.btnOcultar.TabIndex = 41
        Me.btnOcultar.Text = "Ocultar"
        Me.btnOcultar.UseVisualStyleBackColor = False
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnLimpiar.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiar.Location = New System.Drawing.Point(131, 258)
        Me.btnLimpiar.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(72, 35)
        Me.btnLimpiar.TabIndex = 42
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = False
        '
        'cmbAño
        '
        Me.cmbAño.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAño.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.cmbAño.FormattingEnabled = True
        Me.cmbAño.Location = New System.Drawing.Point(248, 128)
        Me.cmbAño.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.cmbAño.Name = "cmbAño"
        Me.cmbAño.Size = New System.Drawing.Size(59, 20)
        Me.cmbAño.TabIndex = 38
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(261, 111)
        Me.Label23.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(25, 12)
        Me.Label23.TabIndex = 0
        Me.Label23.Text = "Año"
        '
        'cmbMes
        '
        Me.cmbMes.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMes.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.cmbMes.FormattingEnabled = True
        Me.cmbMes.Location = New System.Drawing.Point(168, 128)
        Me.cmbMes.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.cmbMes.Name = "cmbMes"
        Me.cmbMes.Size = New System.Drawing.Size(67, 20)
        Me.cmbMes.TabIndex = 37
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(189, 111)
        Me.Label22.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(24, 12)
        Me.Label22.TabIndex = 0
        Me.Label22.Text = "Mes"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(122, 111)
        Me.Label21.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(21, 12)
        Me.Label21.TabIndex = 0
        Me.Label21.Text = "Día"
        '
        'cmbDia
        '
        Me.cmbDia.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDia.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.cmbDia.FormattingEnabled = True
        Me.cmbDia.ItemHeight = 12
        Me.cmbDia.Location = New System.Drawing.Point(115, 128)
        Me.cmbDia.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.cmbDia.Name = "cmbDia"
        Me.cmbDia.Size = New System.Drawing.Size(36, 20)
        Me.cmbDia.TabIndex = 36
        '
        'txtTelefonoUsuario
        '
        Me.txtTelefonoUsuario.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefonoUsuario.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.txtTelefonoUsuario.Location = New System.Drawing.Point(115, 223)
        Me.txtTelefonoUsuario.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.txtTelefonoUsuario.MaxLength = 7
        Me.txtTelefonoUsuario.Name = "txtTelefonoUsuario"
        Me.txtTelefonoUsuario.Size = New System.Drawing.Size(84, 18)
        Me.txtTelefonoUsuario.TabIndex = 40
        '
        'lblFechaNacVendedor
        '
        Me.lblFechaNacVendedor.AutoSize = True
        Me.lblFechaNacVendedor.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaNacVendedor.Location = New System.Drawing.Point(17, 131)
        Me.lblFechaNacVendedor.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFechaNacVendedor.Name = "lblFechaNacVendedor"
        Me.lblFechaNacVendedor.Size = New System.Drawing.Size(92, 12)
        Me.lblFechaNacVendedor.TabIndex = 0
        Me.lblFechaNacVendedor.Text = "Fecha nacimiento"
        '
        'lblGuionEmpleado
        '
        Me.lblGuionEmpleado.AutoSize = True
        Me.lblGuionEmpleado.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGuionEmpleado.Location = New System.Drawing.Point(204, 25)
        Me.lblGuionEmpleado.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblGuionEmpleado.Name = "lblGuionEmpleado"
        Me.lblGuionEmpleado.Size = New System.Drawing.Size(9, 12)
        Me.lblGuionEmpleado.TabIndex = 7
        Me.lblGuionEmpleado.Text = "-"
        '
        'txtGuion
        '
        Me.txtGuion.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGuion.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.txtGuion.Location = New System.Drawing.Point(218, 23)
        Me.txtGuion.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.txtGuion.MaxLength = 1
        Me.txtGuion.Name = "txtGuion"
        Me.txtGuion.Size = New System.Drawing.Size(19, 18)
        Me.txtGuion.TabIndex = 33
        '
        'txtApellidosUsuario
        '
        Me.txtApellidosUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtApellidosUsuario.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApellidosUsuario.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.txtApellidosUsuario.Location = New System.Drawing.Point(115, 84)
        Me.txtApellidosUsuario.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.txtApellidosUsuario.MaxLength = 30
        Me.txtApellidosUsuario.Name = "txtApellidosUsuario"
        Me.txtApellidosUsuario.Size = New System.Drawing.Size(171, 18)
        Me.txtApellidosUsuario.TabIndex = 35
        '
        'lblApellidosVendedor
        '
        Me.lblApellidosVendedor.AutoSize = True
        Me.lblApellidosVendedor.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApellidosVendedor.Location = New System.Drawing.Point(17, 89)
        Me.lblApellidosVendedor.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblApellidosVendedor.Name = "lblApellidosVendedor"
        Me.lblApellidosVendedor.Size = New System.Drawing.Size(51, 12)
        Me.lblApellidosVendedor.TabIndex = 0
        Me.lblApellidosVendedor.Text = "Apellidos"
        '
        'txtNombresUsuario
        '
        Me.txtNombresUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombresUsuario.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombresUsuario.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.txtNombresUsuario.Location = New System.Drawing.Point(115, 55)
        Me.txtNombresUsuario.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.txtNombresUsuario.MaxLength = 30
        Me.txtNombresUsuario.Name = "txtNombresUsuario"
        Me.txtNombresUsuario.Size = New System.Drawing.Size(171, 18)
        Me.txtNombresUsuario.TabIndex = 34
        '
        'lblRUNEmpleado
        '
        Me.lblRUNEmpleado.AutoSize = True
        Me.lblRUNEmpleado.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRUNEmpleado.Location = New System.Drawing.Point(17, 25)
        Me.lblRUNEmpleado.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblRUNEmpleado.Name = "lblRUNEmpleado"
        Me.lblRUNEmpleado.Size = New System.Drawing.Size(35, 12)
        Me.lblRUNEmpleado.TabIndex = 0
        Me.lblRUNEmpleado.Text = "R.U.N."
        '
        'lblTelefonoEmpleado
        '
        Me.lblTelefonoEmpleado.AutoSize = True
        Me.lblTelefonoEmpleado.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefonoEmpleado.Location = New System.Drawing.Point(17, 223)
        Me.lblTelefonoEmpleado.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTelefonoEmpleado.Name = "lblTelefonoEmpleado"
        Me.lblTelefonoEmpleado.Size = New System.Drawing.Size(49, 12)
        Me.lblTelefonoEmpleado.TabIndex = 0
        Me.lblTelefonoEmpleado.Text = "Teléfono"
        '
        'lblNombreVendedor
        '
        Me.lblNombreVendedor.AutoSize = True
        Me.lblNombreVendedor.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreVendedor.Location = New System.Drawing.Point(17, 59)
        Me.lblNombreVendedor.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNombreVendedor.Name = "lblNombreVendedor"
        Me.lblNombreVendedor.Size = New System.Drawing.Size(48, 12)
        Me.lblNombreVendedor.TabIndex = 0
        Me.lblNombreVendedor.Text = "Nombres"
        '
        'lblDireccionVendedor
        '
        Me.lblDireccionVendedor.AutoSize = True
        Me.lblDireccionVendedor.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDireccionVendedor.Location = New System.Drawing.Point(17, 170)
        Me.lblDireccionVendedor.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDireccionVendedor.Name = "lblDireccionVendedor"
        Me.lblDireccionVendedor.Size = New System.Drawing.Size(50, 12)
        Me.lblDireccionVendedor.TabIndex = 0
        Me.lblDireccionVendedor.Text = "Dirección"
        '
        'txtRUNUsuario
        '
        Me.txtRUNUsuario.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRUNUsuario.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.txtRUNUsuario.Location = New System.Drawing.Point(115, 23)
        Me.txtRUNUsuario.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.txtRUNUsuario.MaxLength = 8
        Me.txtRUNUsuario.Name = "txtRUNUsuario"
        Me.txtRUNUsuario.Size = New System.Drawing.Size(84, 18)
        Me.txtRUNUsuario.TabIndex = 32
        '
        'txtDireccionUsuario
        '
        Me.txtDireccionUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDireccionUsuario.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDireccionUsuario.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.txtDireccionUsuario.Location = New System.Drawing.Point(115, 160)
        Me.txtDireccionUsuario.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.txtDireccionUsuario.MaxLength = 50
        Me.txtDireccionUsuario.Multiline = True
        Me.txtDireccionUsuario.Name = "txtDireccionUsuario"
        Me.txtDireccionUsuario.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDireccionUsuario.Size = New System.Drawing.Size(171, 41)
        Me.txtDireccionUsuario.TabIndex = 39
        '
        'groBuscarCliente
        '
        Me.groBuscarCliente.BackColor = System.Drawing.Color.DarkSlateGray
        Me.groBuscarCliente.Controls.Add(Me.btnBuscarCliente)
        Me.groBuscarCliente.Controls.Add(Me.Label1)
        Me.groBuscarCliente.Controls.Add(Me.txtRUNBuscar)
        Me.groBuscarCliente.Controls.Add(Me.txtGuionBuscar)
        Me.groBuscarCliente.Controls.Add(Me.lblRUNBuscar)
        Me.groBuscarCliente.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groBuscarCliente.ForeColor = System.Drawing.Color.White
        Me.groBuscarCliente.Location = New System.Drawing.Point(11, 277)
        Me.groBuscarCliente.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.groBuscarCliente.Name = "groBuscarCliente"
        Me.groBuscarCliente.Padding = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.groBuscarCliente.Size = New System.Drawing.Size(186, 108)
        Me.groBuscarCliente.TabIndex = 0
        Me.groBuscarCliente.TabStop = False
        Me.groBuscarCliente.Text = "Buscar cliente"
        '
        'btnBuscarCliente
        '
        Me.btnBuscarCliente.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnBuscarCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarCliente.Image = Global.Teatro.My.Resources.Resources.search
        Me.btnBuscarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBuscarCliente.Location = New System.Drawing.Point(56, 48)
        Me.btnBuscarCliente.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.btnBuscarCliente.Name = "btnBuscarCliente"
        Me.btnBuscarCliente.Size = New System.Drawing.Size(95, 35)
        Me.btnBuscarCliente.TabIndex = 46
        Me.btnBuscarCliente.Text = "Buscar"
        Me.btnBuscarCliente.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(119, 23)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(9, 12)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "-"
        '
        'txtRUNBuscar
        '
        Me.txtRUNBuscar.Enabled = False
        Me.txtRUNBuscar.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRUNBuscar.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.txtRUNBuscar.Location = New System.Drawing.Point(60, 23)
        Me.txtRUNBuscar.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.txtRUNBuscar.MaxLength = 8
        Me.txtRUNBuscar.Name = "txtRUNBuscar"
        Me.txtRUNBuscar.Size = New System.Drawing.Size(55, 18)
        Me.txtRUNBuscar.TabIndex = 44
        '
        'txtGuionBuscar
        '
        Me.txtGuionBuscar.Enabled = False
        Me.txtGuionBuscar.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGuionBuscar.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.txtGuionBuscar.Location = New System.Drawing.Point(132, 23)
        Me.txtGuionBuscar.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.txtGuionBuscar.MaxLength = 1
        Me.txtGuionBuscar.Name = "txtGuionBuscar"
        Me.txtGuionBuscar.Size = New System.Drawing.Size(19, 18)
        Me.txtGuionBuscar.TabIndex = 45
        '
        'lblRUNBuscar
        '
        Me.lblRUNBuscar.AutoSize = True
        Me.lblRUNBuscar.Enabled = False
        Me.lblRUNBuscar.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRUNBuscar.Location = New System.Drawing.Point(15, 23)
        Me.lblRUNBuscar.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblRUNBuscar.Name = "lblRUNBuscar"
        Me.lblRUNBuscar.Size = New System.Drawing.Size(35, 12)
        Me.lblRUNBuscar.TabIndex = 35
        Me.lblRUNBuscar.Text = "R.U.N."
        '
        'groTarjetaBancaria
        '
        Me.groTarjetaBancaria.BackColor = System.Drawing.Color.DarkSlateGray
        Me.groTarjetaBancaria.Controls.Add(Me.btnPagarTarjeBanca)
        Me.groTarjetaBancaria.Controls.Add(Me.rdbCuotasFijas)
        Me.groTarjetaBancaria.Controls.Add(Me.cmbTipoTarjeta)
        Me.groTarjetaBancaria.Controls.Add(Me.cmbCantidadCuotas)
        Me.groTarjetaBancaria.Controls.Add(Me.rdbSincuotas)
        Me.groTarjetaBancaria.Controls.Add(Me.lblNumeroCuenta)
        Me.groTarjetaBancaria.Controls.Add(Me.txtMontoTarjeta)
        Me.groTarjetaBancaria.Controls.Add(Me.txtNumeroCuenta)
        Me.groTarjetaBancaria.Controls.Add(Me.lblMontoTarjeta)
        Me.groTarjetaBancaria.Controls.Add(Me.lblTipoTarjeta)
        Me.groTarjetaBancaria.Enabled = False
        Me.groTarjetaBancaria.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groTarjetaBancaria.ForeColor = System.Drawing.Color.White
        Me.groTarjetaBancaria.Location = New System.Drawing.Point(244, 228)
        Me.groTarjetaBancaria.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.groTarjetaBancaria.Name = "groTarjetaBancaria"
        Me.groTarjetaBancaria.Padding = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.groTarjetaBancaria.Size = New System.Drawing.Size(194, 166)
        Me.groTarjetaBancaria.TabIndex = 0
        Me.groTarjetaBancaria.TabStop = False
        Me.groTarjetaBancaria.Text = "Pago con tarjeta bancaria"
        '
        'btnPagarTarjeBanca
        '
        Me.btnPagarTarjeBanca.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnPagarTarjeBanca.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPagarTarjeBanca.Image = Global.Teatro.My.Resources.Resources.money
        Me.btnPagarTarjeBanca.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPagarTarjeBanca.Location = New System.Drawing.Point(31, 121)
        Me.btnPagarTarjeBanca.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.btnPagarTarjeBanca.Name = "btnPagarTarjeBanca"
        Me.btnPagarTarjeBanca.Size = New System.Drawing.Size(72, 36)
        Me.btnPagarTarjeBanca.TabIndex = 30
        Me.btnPagarTarjeBanca.Text = "Pagar"
        Me.btnPagarTarjeBanca.UseVisualStyleBackColor = False
        '
        'rdbCuotasFijas
        '
        Me.rdbCuotasFijas.AutoSize = True
        Me.rdbCuotasFijas.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbCuotasFijas.Location = New System.Drawing.Point(102, 96)
        Me.rdbCuotasFijas.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.rdbCuotasFijas.Name = "rdbCuotasFijas"
        Me.rdbCuotasFijas.Size = New System.Drawing.Size(83, 16)
        Me.rdbCuotasFijas.TabIndex = 28
        Me.rdbCuotasFijas.TabStop = True
        Me.rdbCuotasFijas.Text = "Cuotas fijas"
        Me.rdbCuotasFijas.UseVisualStyleBackColor = True
        '
        'cmbTipoTarjeta
        '
        Me.cmbTipoTarjeta.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTipoTarjeta.ForeColor = System.Drawing.Color.MediumBlue
        Me.cmbTipoTarjeta.FormattingEnabled = True
        Me.cmbTipoTarjeta.Items.AddRange(New Object() {"Visa", "Mastercard", "Amex"})
        Me.cmbTipoTarjeta.Location = New System.Drawing.Point(90, 45)
        Me.cmbTipoTarjeta.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.cmbTipoTarjeta.Name = "cmbTipoTarjeta"
        Me.cmbTipoTarjeta.Size = New System.Drawing.Size(75, 22)
        Me.cmbTipoTarjeta.TabIndex = 25
        '
        'cmbCantidadCuotas
        '
        Me.cmbCantidadCuotas.Enabled = False
        Me.cmbCantidadCuotas.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCantidadCuotas.ForeColor = System.Drawing.Color.MediumBlue
        Me.cmbCantidadCuotas.FormattingEnabled = True
        Me.cmbCantidadCuotas.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48"})
        Me.cmbCantidadCuotas.Location = New System.Drawing.Point(131, 110)
        Me.cmbCantidadCuotas.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.cmbCantidadCuotas.Name = "cmbCantidadCuotas"
        Me.cmbCantidadCuotas.Size = New System.Drawing.Size(43, 22)
        Me.cmbCantidadCuotas.TabIndex = 29
        '
        'rdbSincuotas
        '
        Me.rdbSincuotas.AutoSize = True
        Me.rdbSincuotas.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbSincuotas.Location = New System.Drawing.Point(8, 97)
        Me.rdbSincuotas.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.rdbSincuotas.Name = "rdbSincuotas"
        Me.rdbSincuotas.Size = New System.Drawing.Size(74, 16)
        Me.rdbSincuotas.TabIndex = 27
        Me.rdbSincuotas.TabStop = True
        Me.rdbSincuotas.Text = "Sin cuotas"
        Me.rdbSincuotas.UseVisualStyleBackColor = True
        '
        'lblNumeroCuenta
        '
        Me.lblNumeroCuenta.AutoSize = True
        Me.lblNumeroCuenta.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumeroCuenta.Location = New System.Drawing.Point(9, 22)
        Me.lblNumeroCuenta.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNumeroCuenta.Name = "lblNumeroCuenta"
        Me.lblNumeroCuenta.Size = New System.Drawing.Size(69, 12)
        Me.lblNumeroCuenta.TabIndex = 0
        Me.lblNumeroCuenta.Text = "N° de cuenta"
        '
        'txtMontoTarjeta
        '
        Me.txtMontoTarjeta.Enabled = False
        Me.txtMontoTarjeta.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMontoTarjeta.ForeColor = System.Drawing.Color.MediumBlue
        Me.txtMontoTarjeta.Location = New System.Drawing.Point(90, 76)
        Me.txtMontoTarjeta.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.txtMontoTarjeta.Name = "txtMontoTarjeta"
        Me.txtMontoTarjeta.Size = New System.Drawing.Size(71, 18)
        Me.txtMontoTarjeta.TabIndex = 26
        '
        'txtNumeroCuenta
        '
        Me.txtNumeroCuenta.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumeroCuenta.ForeColor = System.Drawing.Color.MediumBlue
        Me.txtNumeroCuenta.Location = New System.Drawing.Point(90, 19)
        Me.txtNumeroCuenta.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.txtNumeroCuenta.Name = "txtNumeroCuenta"
        Me.txtNumeroCuenta.Size = New System.Drawing.Size(91, 18)
        Me.txtNumeroCuenta.TabIndex = 24
        '
        'lblMontoTarjeta
        '
        Me.lblMontoTarjeta.AutoSize = True
        Me.lblMontoTarjeta.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMontoTarjeta.Location = New System.Drawing.Point(9, 76)
        Me.lblMontoTarjeta.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblMontoTarjeta.Name = "lblMontoTarjeta"
        Me.lblMontoTarjeta.Size = New System.Drawing.Size(75, 12)
        Me.lblMontoTarjeta.TabIndex = 0
        Me.lblMontoTarjeta.Text = "Monto tarjeta"
        '
        'lblTipoTarjeta
        '
        Me.lblTipoTarjeta.AutoSize = True
        Me.lblTipoTarjeta.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoTarjeta.Location = New System.Drawing.Point(9, 49)
        Me.lblTipoTarjeta.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTipoTarjeta.Name = "lblTipoTarjeta"
        Me.lblTipoTarjeta.Size = New System.Drawing.Size(65, 12)
        Me.lblTipoTarjeta.TabIndex = 0
        Me.lblTipoTarjeta.Text = "Tipo tarjeta"
        '
        'GroPagoEfectivo
        '
        Me.GroPagoEfectivo.BackColor = System.Drawing.Color.DarkSlateGray
        Me.GroPagoEfectivo.Controls.Add(Me.btnPagarEfectivo)
        Me.GroPagoEfectivo.Controls.Add(Me.txtVuelto)
        Me.GroPagoEfectivo.Controls.Add(Me.txtMontoEfectivo)
        Me.GroPagoEfectivo.Controls.Add(Me.lblMonto)
        Me.GroPagoEfectivo.Controls.Add(Me.txtMonto)
        Me.GroPagoEfectivo.Controls.Add(Me.lblVuelto)
        Me.GroPagoEfectivo.Controls.Add(Me.lblMontoEfetivo)
        Me.GroPagoEfectivo.Enabled = False
        Me.GroPagoEfectivo.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroPagoEfectivo.ForeColor = System.Drawing.Color.White
        Me.GroPagoEfectivo.Location = New System.Drawing.Point(447, 228)
        Me.GroPagoEfectivo.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.GroPagoEfectivo.Name = "GroPagoEfectivo"
        Me.GroPagoEfectivo.Padding = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.GroPagoEfectivo.Size = New System.Drawing.Size(188, 166)
        Me.GroPagoEfectivo.TabIndex = 0
        Me.GroPagoEfectivo.TabStop = False
        Me.GroPagoEfectivo.Text = "Pago en efectivo"
        '
        'btnPagarEfectivo
        '
        Me.btnPagarEfectivo.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnPagarEfectivo.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPagarEfectivo.Image = Global.Teatro.My.Resources.Resources.money
        Me.btnPagarEfectivo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPagarEfectivo.Location = New System.Drawing.Point(95, 121)
        Me.btnPagarEfectivo.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.btnPagarEfectivo.Name = "btnPagarEfectivo"
        Me.btnPagarEfectivo.Size = New System.Drawing.Size(84, 36)
        Me.btnPagarEfectivo.TabIndex = 23
        Me.btnPagarEfectivo.Text = "Pagar"
        Me.btnPagarEfectivo.UseVisualStyleBackColor = False
        '
        'txtVuelto
        '
        Me.txtVuelto.Enabled = False
        Me.txtVuelto.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVuelto.ForeColor = System.Drawing.Color.MediumBlue
        Me.txtVuelto.Location = New System.Drawing.Point(95, 92)
        Me.txtVuelto.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.txtVuelto.Name = "txtVuelto"
        Me.txtVuelto.Size = New System.Drawing.Size(84, 18)
        Me.txtVuelto.TabIndex = 22
        '
        'txtMontoEfectivo
        '
        Me.txtMontoEfectivo.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMontoEfectivo.ForeColor = System.Drawing.Color.MediumBlue
        Me.txtMontoEfectivo.Location = New System.Drawing.Point(95, 57)
        Me.txtMontoEfectivo.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.txtMontoEfectivo.Name = "txtMontoEfectivo"
        Me.txtMontoEfectivo.Size = New System.Drawing.Size(84, 18)
        Me.txtMontoEfectivo.TabIndex = 21
        '
        'lblMonto
        '
        Me.lblMonto.AutoSize = True
        Me.lblMonto.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMonto.Location = New System.Drawing.Point(19, 28)
        Me.lblMonto.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblMonto.Name = "lblMonto"
        Me.lblMonto.Size = New System.Drawing.Size(36, 12)
        Me.lblMonto.TabIndex = 0
        Me.lblMonto.Text = "Monto"
        '
        'txtMonto
        '
        Me.txtMonto.Enabled = False
        Me.txtMonto.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMonto.ForeColor = System.Drawing.Color.MediumBlue
        Me.txtMonto.Location = New System.Drawing.Point(95, 25)
        Me.txtMonto.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.txtMonto.MaxLength = 9
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.Size = New System.Drawing.Size(84, 18)
        Me.txtMonto.TabIndex = 20
        '
        'lblVuelto
        '
        Me.lblVuelto.AutoSize = True
        Me.lblVuelto.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVuelto.Location = New System.Drawing.Point(17, 96)
        Me.lblVuelto.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblVuelto.Name = "lblVuelto"
        Me.lblVuelto.Size = New System.Drawing.Size(38, 12)
        Me.lblVuelto.TabIndex = 0
        Me.lblVuelto.Text = "Vuelto"
        '
        'lblMontoEfetivo
        '
        Me.lblMontoEfetivo.AutoSize = True
        Me.lblMontoEfetivo.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMontoEfetivo.Location = New System.Drawing.Point(6, 60)
        Me.lblMontoEfetivo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblMontoEfetivo.Name = "lblMontoEfetivo"
        Me.lblMontoEfetivo.Size = New System.Drawing.Size(81, 12)
        Me.lblMontoEfetivo.TabIndex = 0
        Me.lblMontoEfetivo.Text = "Monto efectivo"
        '
        'groInfoEvento
        '
        Me.groInfoEvento.BackColor = System.Drawing.Color.DarkSlateGray
        Me.groInfoEvento.Controls.Add(Me.btnCualquierDia)
        Me.groInfoEvento.Controls.Add(Me.btnListoInfoEvento)
        Me.groInfoEvento.Controls.Add(Me.btnHoy)
        Me.groInfoEvento.Controls.Add(Me.cmbFechasEvento)
        Me.groInfoEvento.Controls.Add(Me.lblNombreEvento)
        Me.groInfoEvento.Controls.Add(Me.txtFechaVenta)
        Me.groInfoEvento.Controls.Add(Me.lblEntraGeneral)
        Me.groInfoEvento.Controls.Add(Me.lblFechaVenta)
        Me.groInfoEvento.Controls.Add(Me.lblTipoEntrada)
        Me.groInfoEvento.Controls.Add(Me.cmbNombreEvento)
        Me.groInfoEvento.Controls.Add(Me.lblFechaEvento)
        Me.groInfoEvento.Controls.Add(Me.txtEntradaGeneral)
        Me.groInfoEvento.Controls.Add(Me.cmbTipoEntrada)
        Me.groInfoEvento.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groInfoEvento.ForeColor = System.Drawing.Color.White
        Me.groInfoEvento.Location = New System.Drawing.Point(11, 10)
        Me.groInfoEvento.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.groInfoEvento.Name = "groInfoEvento"
        Me.groInfoEvento.Padding = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.groInfoEvento.Size = New System.Drawing.Size(217, 261)
        Me.groInfoEvento.TabIndex = 0
        Me.groInfoEvento.TabStop = False
        Me.groInfoEvento.Text = "Información evento"
        '
        'btnCualquierDia
        '
        Me.btnCualquierDia.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnCualquierDia.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCualquierDia.Image = Global.Teatro.My.Resources.Resources.tooloptions
        Me.btnCualquierDia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCualquierDia.Location = New System.Drawing.Point(97, 50)
        Me.btnCualquierDia.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.btnCualquierDia.Name = "btnCualquierDia"
        Me.btnCualquierDia.Size = New System.Drawing.Size(99, 31)
        Me.btnCualquierDia.TabIndex = 3
        Me.btnCualquierDia.Text = "Otros días"
        Me.btnCualquierDia.UseVisualStyleBackColor = False
        '
        'btnListoInfoEvento
        '
        Me.btnListoInfoEvento.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnListoInfoEvento.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnListoInfoEvento.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnListoInfoEvento.Image = Global.Teatro.My.Resources.Resources.forward2
        Me.btnListoInfoEvento.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnListoInfoEvento.Location = New System.Drawing.Point(111, 223)
        Me.btnListoInfoEvento.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.btnListoInfoEvento.Name = "btnListoInfoEvento"
        Me.btnListoInfoEvento.Size = New System.Drawing.Size(75, 30)
        Me.btnListoInfoEvento.TabIndex = 8
        Me.btnListoInfoEvento.Text = "Listo"
        Me.btnListoInfoEvento.UseVisualStyleBackColor = False
        '
        'btnHoy
        '
        Me.btnHoy.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnHoy.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHoy.ForeColor = System.Drawing.Color.GhostWhite
        Me.btnHoy.Image = Global.Teatro.My.Resources.Resources.today
        Me.btnHoy.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnHoy.Location = New System.Drawing.Point(9, 51)
        Me.btnHoy.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.btnHoy.Name = "btnHoy"
        Me.btnHoy.Size = New System.Drawing.Size(73, 29)
        Me.btnHoy.TabIndex = 2
        Me.btnHoy.Text = "Hoy"
        Me.btnHoy.UseVisualStyleBackColor = False
        '
        'cmbFechasEvento
        '
        Me.cmbFechasEvento.Enabled = False
        Me.cmbFechasEvento.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbFechasEvento.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.cmbFechasEvento.FormattingEnabled = True
        Me.cmbFechasEvento.Location = New System.Drawing.Point(97, 100)
        Me.cmbFechasEvento.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.cmbFechasEvento.Name = "cmbFechasEvento"
        Me.cmbFechasEvento.Size = New System.Drawing.Size(76, 20)
        Me.cmbFechasEvento.TabIndex = 4
        '
        'lblNombreEvento
        '
        Me.lblNombreEvento.AutoSize = True
        Me.lblNombreEvento.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreEvento.Location = New System.Drawing.Point(5, 23)
        Me.lblNombreEvento.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNombreEvento.Name = "lblNombreEvento"
        Me.lblNombreEvento.Size = New System.Drawing.Size(81, 12)
        Me.lblNombreEvento.TabIndex = 6
        Me.lblNombreEvento.Text = "Nombre evento"
        '
        'txtFechaVenta
        '
        Me.txtFechaVenta.Enabled = False
        Me.txtFechaVenta.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFechaVenta.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.txtFechaVenta.Location = New System.Drawing.Point(97, 199)
        Me.txtFechaVenta.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.txtFechaVenta.Name = "txtFechaVenta"
        Me.txtFechaVenta.Size = New System.Drawing.Size(100, 18)
        Me.txtFechaVenta.TabIndex = 7
        '
        'lblEntraGeneral
        '
        Me.lblEntraGeneral.AutoSize = True
        Me.lblEntraGeneral.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEntraGeneral.Location = New System.Drawing.Point(8, 170)
        Me.lblEntraGeneral.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblEntraGeneral.Name = "lblEntraGeneral"
        Me.lblEntraGeneral.Size = New System.Drawing.Size(85, 12)
        Me.lblEntraGeneral.TabIndex = 1
        Me.lblEntraGeneral.Text = "Entrada General"
        '
        'lblFechaVenta
        '
        Me.lblFechaVenta.AutoSize = True
        Me.lblFechaVenta.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaVenta.Location = New System.Drawing.Point(8, 202)
        Me.lblFechaVenta.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFechaVenta.Name = "lblFechaVenta"
        Me.lblFechaVenta.Size = New System.Drawing.Size(66, 12)
        Me.lblFechaVenta.TabIndex = 8
        Me.lblFechaVenta.Text = "Fecha venta"
        '
        'lblTipoEntrada
        '
        Me.lblTipoEntrada.AutoSize = True
        Me.lblTipoEntrada.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoEntrada.Location = New System.Drawing.Point(8, 135)
        Me.lblTipoEntrada.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTipoEntrada.Name = "lblTipoEntrada"
        Me.lblTipoEntrada.Size = New System.Drawing.Size(68, 12)
        Me.lblTipoEntrada.TabIndex = 1
        Me.lblTipoEntrada.Text = "Tipo entrada"
        '
        'cmbNombreEvento
        '
        Me.cmbNombreEvento.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbNombreEvento.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.cmbNombreEvento.FormattingEnabled = True
        Me.cmbNombreEvento.Location = New System.Drawing.Point(97, 20)
        Me.cmbNombreEvento.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.cmbNombreEvento.Name = "cmbNombreEvento"
        Me.cmbNombreEvento.Size = New System.Drawing.Size(89, 20)
        Me.cmbNombreEvento.TabIndex = 1
        '
        'lblFechaEvento
        '
        Me.lblFechaEvento.AutoSize = True
        Me.lblFechaEvento.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaEvento.Location = New System.Drawing.Point(7, 103)
        Me.lblFechaEvento.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFechaEvento.Name = "lblFechaEvento"
        Me.lblFechaEvento.Size = New System.Drawing.Size(72, 12)
        Me.lblFechaEvento.TabIndex = 0
        Me.lblFechaEvento.Text = "Fecha evento"
        '
        'txtEntradaGeneral
        '
        Me.txtEntradaGeneral.AccessibleName = ""
        Me.txtEntradaGeneral.Enabled = False
        Me.txtEntradaGeneral.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEntradaGeneral.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.txtEntradaGeneral.Location = New System.Drawing.Point(97, 167)
        Me.txtEntradaGeneral.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.txtEntradaGeneral.Name = "txtEntradaGeneral"
        Me.txtEntradaGeneral.Size = New System.Drawing.Size(75, 18)
        Me.txtEntradaGeneral.TabIndex = 6
        '
        'cmbTipoEntrada
        '
        Me.cmbTipoEntrada.Enabled = False
        Me.cmbTipoEntrada.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTipoEntrada.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.cmbTipoEntrada.Items.AddRange(New Object() {"NIÑO", "ESTUDIANTE", "ADULTO", "TERCERA EDAD"})
        Me.cmbTipoEntrada.Location = New System.Drawing.Point(97, 132)
        Me.cmbTipoEntrada.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.cmbTipoEntrada.Name = "cmbTipoEntrada"
        Me.cmbTipoEntrada.Size = New System.Drawing.Size(76, 20)
        Me.cmbTipoEntrada.TabIndex = 5
        '
        'groUbicaciones
        '
        Me.groUbicaciones.BackColor = System.Drawing.Color.DarkSlateGray
        Me.groUbicaciones.Controls.Add(Me.lblDisponible)
        Me.groUbicaciones.Controls.Add(Me.lblDisponibilidad)
        Me.groUbicaciones.Controls.Add(Me.btnAtrasUbicaciones)
        Me.groUbicaciones.Controls.Add(Me.btnListo)
        Me.groUbicaciones.Controls.Add(Me.cmbUbicacion)
        Me.groUbicaciones.Controls.Add(Me.nupCantidad)
        Me.groUbicaciones.Controls.Add(Me.lblCantidad)
        Me.groUbicaciones.Controls.Add(Me.lblUbicacion)
        Me.groUbicaciones.Enabled = False
        Me.groUbicaciones.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groUbicaciones.ForeColor = System.Drawing.Color.White
        Me.groUbicaciones.Location = New System.Drawing.Point(428, 10)
        Me.groUbicaciones.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.groUbicaciones.Name = "groUbicaciones"
        Me.groUbicaciones.Padding = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.groUbicaciones.Size = New System.Drawing.Size(209, 115)
        Me.groUbicaciones.TabIndex = 0
        Me.groUbicaciones.TabStop = False
        Me.groUbicaciones.Text = "Ubicaciones"
        '
        'lblDisponible
        '
        Me.lblDisponible.AutoSize = True
        Me.lblDisponible.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDisponible.Location = New System.Drawing.Point(116, 35)
        Me.lblDisponible.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDisponible.Name = "lblDisponible"
        Me.lblDisponible.Size = New System.Drawing.Size(74, 12)
        Me.lblDisponible.TabIndex = 18
        Me.lblDisponible.Text = "Disponibilidad"
        '
        'lblDisponibilidad
        '
        Me.lblDisponibilidad.AutoSize = True
        Me.lblDisponibilidad.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDisponibilidad.ForeColor = System.Drawing.Color.White
        Me.lblDisponibilidad.Location = New System.Drawing.Point(139, 52)
        Me.lblDisponibilidad.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDisponibilidad.Name = "lblDisponibilidad"
        Me.lblDisponibilidad.Size = New System.Drawing.Size(0, 12)
        Me.lblDisponibilidad.TabIndex = 17
        '
        'btnAtrasUbicaciones
        '
        Me.btnAtrasUbicaciones.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnAtrasUbicaciones.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAtrasUbicaciones.Image = CType(resources.GetObject("btnAtrasUbicaciones.Image"), System.Drawing.Image)
        Me.btnAtrasUbicaciones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAtrasUbicaciones.Location = New System.Drawing.Point(13, 70)
        Me.btnAtrasUbicaciones.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.btnAtrasUbicaciones.Name = "btnAtrasUbicaciones"
        Me.btnAtrasUbicaciones.Size = New System.Drawing.Size(83, 32)
        Me.btnAtrasUbicaciones.TabIndex = 15
        Me.btnAtrasUbicaciones.Text = "Atrás"
        Me.btnAtrasUbicaciones.UseVisualStyleBackColor = False
        '
        'btnListo
        '
        Me.btnListo.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnListo.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnListo.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnListo.Image = Global.Teatro.My.Resources.Resources.forward2
        Me.btnListo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnListo.Location = New System.Drawing.Point(118, 69)
        Me.btnListo.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.btnListo.Name = "btnListo"
        Me.btnListo.Size = New System.Drawing.Size(70, 32)
        Me.btnListo.TabIndex = 16
        Me.btnListo.Text = "Listo"
        Me.btnListo.UseVisualStyleBackColor = False
        '
        'cmbUbicacion
        '
        Me.cmbUbicacion.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbUbicacion.ForeColor = System.Drawing.Color.MediumBlue
        Me.cmbUbicacion.FormattingEnabled = True
        Me.cmbUbicacion.Items.AddRange(New Object() {"Balcones", "Platea", "Platea numerada"})
        Me.cmbUbicacion.Location = New System.Drawing.Point(69, 12)
        Me.cmbUbicacion.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.cmbUbicacion.Name = "cmbUbicacion"
        Me.cmbUbicacion.Size = New System.Drawing.Size(101, 20)
        Me.cmbUbicacion.TabIndex = 13
        '
        'nupCantidad
        '
        Me.nupCantidad.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nupCantidad.ForeColor = System.Drawing.Color.MediumBlue
        Me.nupCantidad.Location = New System.Drawing.Point(69, 44)
        Me.nupCantidad.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.nupCantidad.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.nupCantidad.Name = "nupCantidad"
        Me.nupCantidad.Size = New System.Drawing.Size(43, 18)
        Me.nupCantidad.TabIndex = 14
        Me.nupCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.nupCantidad.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lblCantidad
        '
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantidad.Location = New System.Drawing.Point(14, 46)
        Me.lblCantidad.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(49, 12)
        Me.lblCantidad.TabIndex = 0
        Me.lblCantidad.Text = "Cantidad"
        '
        'lblUbicacion
        '
        Me.lblUbicacion.AutoSize = True
        Me.lblUbicacion.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUbicacion.Location = New System.Drawing.Point(11, 13)
        Me.lblUbicacion.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblUbicacion.Name = "lblUbicacion"
        Me.lblUbicacion.Size = New System.Drawing.Size(52, 12)
        Me.lblUbicacion.TabIndex = 0
        Me.lblUbicacion.Text = "Ubicación"
        '
        'groJornadas
        '
        Me.groJornadas.BackColor = System.Drawing.Color.DarkSlateGray
        Me.groJornadas.Controls.Add(Me.btnAtrasJornadas)
        Me.groJornadas.Controls.Add(Me.chkMatine)
        Me.groJornadas.Controls.Add(Me.chkTarde)
        Me.groJornadas.Controls.Add(Me.chkNoche)
        Me.groJornadas.Enabled = False
        Me.groJornadas.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groJornadas.ForeColor = System.Drawing.Color.White
        Me.groJornadas.Location = New System.Drawing.Point(235, 10)
        Me.groJornadas.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.groJornadas.Name = "groJornadas"
        Me.groJornadas.Padding = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.groJornadas.Size = New System.Drawing.Size(186, 115)
        Me.groJornadas.TabIndex = 0
        Me.groJornadas.TabStop = False
        Me.groJornadas.Text = "Jornadas"
        '
        'btnAtrasJornadas
        '
        Me.btnAtrasJornadas.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnAtrasJornadas.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAtrasJornadas.Image = Global.Teatro.My.Resources.Resources.back1
        Me.btnAtrasJornadas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAtrasJornadas.Location = New System.Drawing.Point(56, 60)
        Me.btnAtrasJornadas.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.btnAtrasJornadas.Name = "btnAtrasJornadas"
        Me.btnAtrasJornadas.Size = New System.Drawing.Size(73, 29)
        Me.btnAtrasJornadas.TabIndex = 12
        Me.btnAtrasJornadas.Text = "Atrás"
        Me.btnAtrasJornadas.UseVisualStyleBackColor = False
        '
        'chkMatine
        '
        Me.chkMatine.AutoSize = True
        Me.chkMatine.Enabled = False
        Me.chkMatine.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMatine.Location = New System.Drawing.Point(17, 28)
        Me.chkMatine.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.chkMatine.Name = "chkMatine"
        Me.chkMatine.Size = New System.Drawing.Size(58, 16)
        Me.chkMatine.TabIndex = 9
        Me.chkMatine.Text = "Matiné"
        Me.chkMatine.UseVisualStyleBackColor = True
        '
        'chkTarde
        '
        Me.chkTarde.AutoSize = True
        Me.chkTarde.Enabled = False
        Me.chkTarde.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkTarde.Location = New System.Drawing.Point(77, 28)
        Me.chkTarde.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.chkTarde.Name = "chkTarde"
        Me.chkTarde.Size = New System.Drawing.Size(52, 16)
        Me.chkTarde.TabIndex = 10
        Me.chkTarde.Text = "Tarde"
        Me.chkTarde.UseVisualStyleBackColor = True
        '
        'chkNoche
        '
        Me.chkNoche.AutoSize = True
        Me.chkNoche.Enabled = False
        Me.chkNoche.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkNoche.Location = New System.Drawing.Point(128, 28)
        Me.chkNoche.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.chkNoche.Name = "chkNoche"
        Me.chkNoche.Size = New System.Drawing.Size(54, 16)
        Me.chkNoche.TabIndex = 11
        Me.chkNoche.Text = "Noche"
        Me.chkNoche.UseVisualStyleBackColor = True
        '
        'groTipoPago
        '
        Me.groTipoPago.BackColor = System.Drawing.Color.DarkSlateGray
        Me.groTipoPago.Controls.Add(Me.rdbEfectivo)
        Me.groTipoPago.Controls.Add(Me.rdbTarBancaria)
        Me.groTipoPago.Controls.Add(Me.btnAtrasTipoPago)
        Me.groTipoPago.Enabled = False
        Me.groTipoPago.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groTipoPago.ForeColor = System.Drawing.Color.White
        Me.groTipoPago.Location = New System.Drawing.Point(334, 130)
        Me.groTipoPago.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.groTipoPago.Name = "groTipoPago"
        Me.groTipoPago.Padding = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.groTipoPago.Size = New System.Drawing.Size(196, 81)
        Me.groTipoPago.TabIndex = 0
        Me.groTipoPago.TabStop = False
        Me.groTipoPago.Text = "Tipo pago"
        '
        'rdbEfectivo
        '
        Me.rdbEfectivo.AutoSize = True
        Me.rdbEfectivo.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbEfectivo.Location = New System.Drawing.Point(122, 24)
        Me.rdbEfectivo.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.rdbEfectivo.Name = "rdbEfectivo"
        Me.rdbEfectivo.Size = New System.Drawing.Size(65, 16)
        Me.rdbEfectivo.TabIndex = 18
        Me.rdbEfectivo.TabStop = True
        Me.rdbEfectivo.Text = "Efectivo"
        Me.rdbEfectivo.UseVisualStyleBackColor = True
        '
        'rdbTarBancaria
        '
        Me.rdbTarBancaria.AutoSize = True
        Me.rdbTarBancaria.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbTarBancaria.Location = New System.Drawing.Point(11, 24)
        Me.rdbTarBancaria.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.rdbTarBancaria.Name = "rdbTarBancaria"
        Me.rdbTarBancaria.Size = New System.Drawing.Size(105, 16)
        Me.rdbTarBancaria.TabIndex = 17
        Me.rdbTarBancaria.TabStop = True
        Me.rdbTarBancaria.Text = "Tarjeta bancaria"
        Me.rdbTarBancaria.UseVisualStyleBackColor = True
        '
        'btnAtrasTipoPago
        '
        Me.btnAtrasTipoPago.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnAtrasTipoPago.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAtrasTipoPago.ForeColor = System.Drawing.Color.GhostWhite
        Me.btnAtrasTipoPago.Image = Global.Teatro.My.Resources.Resources.back1
        Me.btnAtrasTipoPago.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAtrasTipoPago.Location = New System.Drawing.Point(53, 42)
        Me.btnAtrasTipoPago.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.btnAtrasTipoPago.Name = "btnAtrasTipoPago"
        Me.btnAtrasTipoPago.Size = New System.Drawing.Size(89, 32)
        Me.btnAtrasTipoPago.TabIndex = 19
        Me.btnAtrasTipoPago.Text = "Atrás"
        Me.btnAtrasTipoPago.UseVisualStyleBackColor = False
        '
        'EVENTOSBindingSource
        '
        Me.EVENTOSBindingSource.DataMember = "EVENTOS"
        Me.EVENTOSBindingSource.DataSource = Me.TeatroDataSet
        '
        'TeatroDataSet
        '
        Me.TeatroDataSet.DataSetName = "TeatroDataSet"
        Me.TeatroDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VENTAENTRADASTableAdapter
        '
        Me.VENTAENTRADASTableAdapter.ClearBeforeFill = True
        '
        'RegistraclienteTableAdapter1
        '
        Me.RegistraclienteTableAdapter1.ClearBeforeFill = True
        '
        'ComprasclientesTableAdapter1
        '
        Me.ComprasclientesTableAdapter1.ClearBeforeFill = True
        '
        'EVENTOSTableAdapter
        '
        Me.EVENTOSTableAdapter.ClearBeforeFill = True
        '
        'ClientesTableAdapter1
        '
        Me.ClientesTableAdapter1.ClearBeforeFill = True
        '
        'VentasjornadasTableAdapter1
        '
        Me.VentasjornadasTableAdapter1.ClearBeforeFill = True
        '
        'PAGOEFECTIVOTableAdapter
        '
        Me.PAGOEFECTIVOTableAdapter.ClearBeforeFill = True
        '
        'EventosTableAdapter1
        '
        Me.EventosTableAdapter1.ClearBeforeFill = True
        '
        'BOLETASTableAdapter
        '
        Me.BOLETASTableAdapter.ClearBeforeFill = True
        '
        'VentasubicacionesTableAdapter1
        '
        Me.VentasubicacionesTableAdapter1.ClearBeforeFill = True
        '
        'PAGOTARJETACREDITOTableAdapter
        '
        Me.PAGOTARJETACREDITOTableAdapter.ClearBeforeFill = True
        '
        'EstadoentradasTableAdapter1
        '
        Me.EstadoentradasTableAdapter1.ClearBeforeFill = True
        '
        'frmVentasEntradas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSlateGray
        Me.ClientSize = New System.Drawing.Size(997, 458)
        Me.Controls.Add(Me.groBuscarCliente)
        Me.Controls.Add(Me.groTarjetaBancaria)
        Me.Controls.Add(Me.GroPagoEfectivo)
        Me.Controls.Add(Me.groInfoEvento)
        Me.Controls.Add(Me.groUbicaciones)
        Me.Controls.Add(Me.groJornadas)
        Me.Controls.Add(Me.groTipoPago)
        Me.Controls.Add(Me.groInfoPersonal)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1003, 486)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(651, 486)
        Me.Name = "frmVentasEntradas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Venta de entradas"
        CType(Me.ErrorProviderVentaEntradas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProviderCantUbic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProviderEfectivo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groInfoPersonal.ResumeLayout(False)
        Me.groInfoPersonal.PerformLayout()
        Me.groBuscarCliente.ResumeLayout(False)
        Me.groBuscarCliente.PerformLayout()
        Me.groTarjetaBancaria.ResumeLayout(False)
        Me.groTarjetaBancaria.PerformLayout()
        Me.GroPagoEfectivo.ResumeLayout(False)
        Me.GroPagoEfectivo.PerformLayout()
        Me.groInfoEvento.ResumeLayout(False)
        Me.groInfoEvento.PerformLayout()
        Me.groUbicaciones.ResumeLayout(False)
        Me.groUbicaciones.PerformLayout()
        CType(Me.nupCantidad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groJornadas.ResumeLayout(False)
        Me.groJornadas.PerformLayout()
        Me.groTipoPago.ResumeLayout(False)
        Me.groTipoPago.PerformLayout()
        CType(Me.EVENTOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TeatroDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ErrorProviderVentaEntradas As System.Windows.Forms.ErrorProvider
    Friend WithEvents EVENTOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TeatroDataSet As Teatro.TeatroDataSet
    Friend WithEvents ToolTipVentraEntradas As System.Windows.Forms.ToolTip
    Friend WithEvents VENTAENTRADASTableAdapter As Teatro.TeatroDataSetTableAdapters.VENTASENTRADASTableAdapter
    Friend WithEvents RegistraclienteTableAdapter1 As Teatro.TeatroDataSetTableAdapters.REGISTRACLIENTETableAdapter
    Friend WithEvents ComprasclientesTableAdapter1 As Teatro.TeatroDataSetTableAdapters.COMPRASCLIENTESTableAdapter
    Friend WithEvents ErrorProviderCantUbic As System.Windows.Forms.ErrorProvider
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents EVENTOSTableAdapter As Teatro.TeatroDataSetTableAdapters.EVENTOSTableAdapter
    Friend WithEvents ClientesTableAdapter1 As Teatro.TeatroDataSetTableAdapters.CLIENTESTableAdapter
    Friend WithEvents ErrorProviderEfectivo As System.Windows.Forms.ErrorProvider
    Friend WithEvents VentasjornadasTableAdapter1 As Teatro.TeatroDataSetTableAdapters.VENTASJORNADASTableAdapter
    Friend WithEvents PAGOEFECTIVOTableAdapter As Teatro.TeatroDataSetTableAdapters.PAGOEFECTIVOTableAdapter
    Friend WithEvents EventosTableAdapter1 As Teatro.TeatroDataSetTableAdapters.EVENTOSTableAdapter
    Friend WithEvents BOLETASTableAdapter As Teatro.TeatroDataSetTableAdapters.BOLETASTableAdapter
    Friend WithEvents VentasubicacionesTableAdapter1 As Teatro.TeatroDataSetTableAdapters.VENTASUBICACIONESTableAdapter
    Friend WithEvents PAGOTARJETACREDITOTableAdapter As Teatro.TeatroDataSetTableAdapters.PAGOTARJETACREDITOTableAdapter
    Friend WithEvents EstadoentradasTableAdapter1 As Teatro.TeatroDataSetTableAdapters.ESTADOENTRADASTableAdapter
    Friend WithEvents groInfoPersonal As System.Windows.Forms.GroupBox
    Friend WithEvents btnOcultar As System.Windows.Forms.Button
    Friend WithEvents btnLimpiar As System.Windows.Forms.Button
    Friend WithEvents cmbAño As System.Windows.Forms.ComboBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents cmbMes As System.Windows.Forms.ComboBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents cmbDia As System.Windows.Forms.ComboBox
    Friend WithEvents txtTelefonoUsuario As System.Windows.Forms.TextBox
    Friend WithEvents lblFechaNacVendedor As System.Windows.Forms.Label
    Friend WithEvents lblGuionEmpleado As System.Windows.Forms.Label
    Friend WithEvents txtGuion As System.Windows.Forms.TextBox
    Friend WithEvents txtApellidosUsuario As System.Windows.Forms.TextBox
    Friend WithEvents lblApellidosVendedor As System.Windows.Forms.Label
    Friend WithEvents txtNombresUsuario As System.Windows.Forms.TextBox
    Friend WithEvents lblRUNEmpleado As System.Windows.Forms.Label
    Friend WithEvents lblTelefonoEmpleado As System.Windows.Forms.Label
    Friend WithEvents lblNombreVendedor As System.Windows.Forms.Label
    Friend WithEvents lblDireccionVendedor As System.Windows.Forms.Label
    Friend WithEvents txtRUNUsuario As System.Windows.Forms.TextBox
    Friend WithEvents txtDireccionUsuario As System.Windows.Forms.TextBox
    Friend WithEvents btnRegistrarCliente As System.Windows.Forms.Button
    Friend WithEvents groBuscarCliente As System.Windows.Forms.GroupBox
    Friend WithEvents btnBuscarCliente As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtRUNBuscar As System.Windows.Forms.TextBox
    Friend WithEvents txtGuionBuscar As System.Windows.Forms.TextBox
    Friend WithEvents lblRUNBuscar As System.Windows.Forms.Label
    Friend WithEvents groTarjetaBancaria As System.Windows.Forms.GroupBox
    Friend WithEvents btnPagarTarjeBanca As System.Windows.Forms.Button
    Friend WithEvents rdbCuotasFijas As System.Windows.Forms.RadioButton
    Friend WithEvents cmbTipoTarjeta As System.Windows.Forms.ComboBox
    Friend WithEvents cmbCantidadCuotas As System.Windows.Forms.ComboBox
    Friend WithEvents rdbSincuotas As System.Windows.Forms.RadioButton
    Friend WithEvents lblNumeroCuenta As System.Windows.Forms.Label
    Friend WithEvents txtMontoTarjeta As System.Windows.Forms.TextBox
    Friend WithEvents txtNumeroCuenta As System.Windows.Forms.TextBox
    Friend WithEvents lblMontoTarjeta As System.Windows.Forms.Label
    Friend WithEvents lblTipoTarjeta As System.Windows.Forms.Label
    Friend WithEvents GroPagoEfectivo As System.Windows.Forms.GroupBox
    Friend WithEvents btnPagarEfectivo As System.Windows.Forms.Button
    Friend WithEvents txtVuelto As System.Windows.Forms.TextBox
    Friend WithEvents txtMontoEfectivo As System.Windows.Forms.TextBox
    Friend WithEvents lblMonto As System.Windows.Forms.Label
    Friend WithEvents txtMonto As System.Windows.Forms.TextBox
    Friend WithEvents lblVuelto As System.Windows.Forms.Label
    Friend WithEvents lblMontoEfetivo As System.Windows.Forms.Label
    Friend WithEvents groInfoEvento As System.Windows.Forms.GroupBox
    Friend WithEvents btnCualquierDia As System.Windows.Forms.Button
    Friend WithEvents btnListoInfoEvento As System.Windows.Forms.Button
    Friend WithEvents btnHoy As System.Windows.Forms.Button
    Public WithEvents cmbFechasEvento As System.Windows.Forms.ComboBox
    Friend WithEvents lblNombreEvento As System.Windows.Forms.Label
    Friend WithEvents txtFechaVenta As System.Windows.Forms.TextBox
    Friend WithEvents lblEntraGeneral As System.Windows.Forms.Label
    Friend WithEvents lblFechaVenta As System.Windows.Forms.Label
    Friend WithEvents lblTipoEntrada As System.Windows.Forms.Label
    Public WithEvents cmbNombreEvento As System.Windows.Forms.ComboBox
    Friend WithEvents lblFechaEvento As System.Windows.Forms.Label
    Public WithEvents txtEntradaGeneral As System.Windows.Forms.TextBox
    Public WithEvents cmbTipoEntrada As System.Windows.Forms.ComboBox
    Friend WithEvents groUbicaciones As System.Windows.Forms.GroupBox
    Friend WithEvents lblDisponible As System.Windows.Forms.Label
    Friend WithEvents lblDisponibilidad As System.Windows.Forms.Label
    Friend WithEvents btnAtrasUbicaciones As System.Windows.Forms.Button
    Friend WithEvents btnListo As System.Windows.Forms.Button
    Friend WithEvents cmbUbicacion As System.Windows.Forms.ComboBox
    Friend WithEvents nupCantidad As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblCantidad As System.Windows.Forms.Label
    Friend WithEvents lblUbicacion As System.Windows.Forms.Label
    Friend WithEvents groJornadas As System.Windows.Forms.GroupBox
    Friend WithEvents btnAtrasJornadas As System.Windows.Forms.Button
    Friend WithEvents chkMatine As System.Windows.Forms.CheckBox
    Friend WithEvents chkTarde As System.Windows.Forms.CheckBox
    Friend WithEvents chkNoche As System.Windows.Forms.CheckBox
    Friend WithEvents groTipoPago As System.Windows.Forms.GroupBox
    Friend WithEvents rdbEfectivo As System.Windows.Forms.RadioButton
    Friend WithEvents rdbTarBancaria As System.Windows.Forms.RadioButton
    Public WithEvents btnAtrasTipoPago As System.Windows.Forms.Button
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
End Class
