<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmModificarUsuario
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
        Me.groInfoEmpleado = New System.Windows.Forms.GroupBox
        Me.lblFechaNacVendedor = New System.Windows.Forms.Label
        Me.cmbDia = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtConfirmaContraseña = New System.Windows.Forms.TextBox
        Me.lblConfirmaContraseña = New System.Windows.Forms.Label
        Me.txtContraseña = New System.Windows.Forms.TextBox
        Me.lblContraseña = New System.Windows.Forms.Label
        Me.txtTelefonoUsuario = New System.Windows.Forms.TextBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.txtApellidosUsuario = New System.Windows.Forms.TextBox
        Me.cmbAño = New System.Windows.Forms.ComboBox
        Me.lblApellidosVendedor = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.txtNombresUsuario = New System.Windows.Forms.TextBox
        Me.Label23 = New System.Windows.Forms.Label
        Me.lblTelefonoEmpleado = New System.Windows.Forms.Label
        Me.cmbMes = New System.Windows.Forms.ComboBox
        Me.lblNombreVendedor = New System.Windows.Forms.Label
        Me.lblDireccionVendedor = New System.Windows.Forms.Label
        Me.txtDireccionUsuario = New System.Windows.Forms.TextBox
        Me.lblGuionEmpleado = New System.Windows.Forms.Label
        Me.txtGuion = New System.Windows.Forms.TextBox
        Me.lblRUNUsuario = New System.Windows.Forms.Label
        Me.txtRUNUsuario = New System.Windows.Forms.TextBox
        Me.groBuscarUsuario = New System.Windows.Forms.GroupBox
        Me.btnBuscar = New System.Windows.Forms.Button
        Me.btnActualizarVendedor = New System.Windows.Forms.Button
        Me.ErrorProviderModificarUsuario = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.groTipoUsuario = New System.Windows.Forms.GroupBox
        Me.rdbCliente = New System.Windows.Forms.RadioButton
        Me.rdbAdministrador = New System.Windows.Forms.RadioButton
        Me.rdbProductor = New System.Windows.Forms.RadioButton
        Me.rbdVendedor = New System.Windows.Forms.RadioButton
        Me.VendedoresTableAdapter1 = New Teatro.TeatroDataSetTableAdapters.VENDEDORESTableAdapter
        Me.AdministradoresTableAdapter1 = New Teatro.TeatroDataSetTableAdapters.ADMINISTRADORESTableAdapter
        Me.ProduccionTableAdapter1 = New Teatro.TeatroDataSetTableAdapters.PRODUCCIONTableAdapter
        Me.ClientesTableAdapter1 = New Teatro.TeatroDataSetTableAdapters.CLIENTESTableAdapter
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.groInfoEmpleado.SuspendLayout()
        Me.groBuscarUsuario.SuspendLayout()
        CType(Me.ErrorProviderModificarUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groTipoUsuario.SuspendLayout()
        Me.SuspendLayout()
        '
        'groInfoEmpleado
        '
        Me.groInfoEmpleado.Controls.Add(Me.lblFechaNacVendedor)
        Me.groInfoEmpleado.Controls.Add(Me.cmbDia)
        Me.groInfoEmpleado.Controls.Add(Me.Label1)
        Me.groInfoEmpleado.Controls.Add(Me.txtConfirmaContraseña)
        Me.groInfoEmpleado.Controls.Add(Me.lblConfirmaContraseña)
        Me.groInfoEmpleado.Controls.Add(Me.txtContraseña)
        Me.groInfoEmpleado.Controls.Add(Me.lblContraseña)
        Me.groInfoEmpleado.Controls.Add(Me.txtTelefonoUsuario)
        Me.groInfoEmpleado.Controls.Add(Me.Label21)
        Me.groInfoEmpleado.Controls.Add(Me.txtApellidosUsuario)
        Me.groInfoEmpleado.Controls.Add(Me.cmbAño)
        Me.groInfoEmpleado.Controls.Add(Me.lblApellidosVendedor)
        Me.groInfoEmpleado.Controls.Add(Me.Label22)
        Me.groInfoEmpleado.Controls.Add(Me.txtNombresUsuario)
        Me.groInfoEmpleado.Controls.Add(Me.Label23)
        Me.groInfoEmpleado.Controls.Add(Me.lblTelefonoEmpleado)
        Me.groInfoEmpleado.Controls.Add(Me.cmbMes)
        Me.groInfoEmpleado.Controls.Add(Me.lblNombreVendedor)
        Me.groInfoEmpleado.Controls.Add(Me.lblDireccionVendedor)
        Me.groInfoEmpleado.Controls.Add(Me.txtDireccionUsuario)
        Me.groInfoEmpleado.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groInfoEmpleado.ForeColor = System.Drawing.Color.White
        Me.groInfoEmpleado.Location = New System.Drawing.Point(14, 97)
        Me.groInfoEmpleado.Name = "groInfoEmpleado"
        Me.groInfoEmpleado.Size = New System.Drawing.Size(999, 204)
        Me.groInfoEmpleado.TabIndex = 15
        Me.groInfoEmpleado.TabStop = False
        Me.groInfoEmpleado.Text = "Información personal"
        Me.ToolTip1.SetToolTip(Me.groInfoEmpleado, "Modifique la información personal del usuario y luego guarde los cambios haciendo" & _
                " click en el botón Actualizar")
        '
        'lblFechaNacVendedor
        '
        Me.lblFechaNacVendedor.AutoSize = True
        Me.lblFechaNacVendedor.Location = New System.Drawing.Point(23, 123)
        Me.lblFechaNacVendedor.Name = "lblFechaNacVendedor"
        Me.lblFechaNacVendedor.Size = New System.Drawing.Size(137, 16)
        Me.lblFechaNacVendedor.TabIndex = 9
        Me.lblFechaNacVendedor.Text = "Fecha nacimiento"
        '
        'cmbDia
        '
        Me.cmbDia.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.cmbDia.FormattingEnabled = True
        Me.cmbDia.Location = New System.Drawing.Point(190, 120)
        Me.cmbDia.Name = "cmbDia"
        Me.cmbDia.Size = New System.Drawing.Size(47, 24)
        Me.cmbDia.TabIndex = 70
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(836, 100)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(155, 16)
        Me.Label1.TabIndex = 69
        Me.Label1.Text = "Mínimo 7 caracteres"
        '
        'txtConfirmaContraseña
        '
        Me.txtConfirmaContraseña.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.txtConfirmaContraseña.Location = New System.Drawing.Point(706, 130)
        Me.txtConfirmaContraseña.MaxLength = 20
        Me.txtConfirmaContraseña.Name = "txtConfirmaContraseña"
        Me.txtConfirmaContraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtConfirmaContraseña.Size = New System.Drawing.Size(116, 23)
        Me.txtConfirmaContraseña.TabIndex = 12
        '
        'lblConfirmaContraseña
        '
        Me.lblConfirmaContraseña.AutoSize = True
        Me.lblConfirmaContraseña.Location = New System.Drawing.Point(529, 132)
        Me.lblConfirmaContraseña.Name = "lblConfirmaContraseña"
        Me.lblConfirmaContraseña.Size = New System.Drawing.Size(166, 16)
        Me.lblConfirmaContraseña.TabIndex = 68
        Me.lblConfirmaContraseña.Text = "Confirmar contraseña"
        '
        'txtContraseña
        '
        Me.txtContraseña.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.txtContraseña.Location = New System.Drawing.Point(706, 95)
        Me.txtContraseña.MaxLength = 20
        Me.txtContraseña.Name = "txtContraseña"
        Me.txtContraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtContraseña.Size = New System.Drawing.Size(116, 23)
        Me.txtContraseña.TabIndex = 11
        '
        'lblContraseña
        '
        Me.lblContraseña.AutoSize = True
        Me.lblContraseña.Location = New System.Drawing.Point(556, 99)
        Me.lblContraseña.Name = "lblContraseña"
        Me.lblContraseña.Size = New System.Drawing.Size(92, 16)
        Me.lblContraseña.TabIndex = 66
        Me.lblContraseña.Text = "Contraseña"
        '
        'txtTelefonoUsuario
        '
        Me.txtTelefonoUsuario.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.txtTelefonoUsuario.Location = New System.Drawing.Point(190, 164)
        Me.txtTelefonoUsuario.MaxLength = 7
        Me.txtTelefonoUsuario.Name = "txtTelefonoUsuario"
        Me.txtTelefonoUsuario.Size = New System.Drawing.Size(116, 23)
        Me.txtTelefonoUsuario.TabIndex = 10
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(198, 99)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(31, 16)
        Me.Label21.TabIndex = 62
        Me.Label21.Text = "Día"
        '
        'txtApellidosUsuario
        '
        Me.txtApellidosUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtApellidosUsuario.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.txtApellidosUsuario.Location = New System.Drawing.Point(190, 67)
        Me.txtApellidosUsuario.MaxLength = 30
        Me.txtApellidosUsuario.Name = "txtApellidosUsuario"
        Me.txtApellidosUsuario.Size = New System.Drawing.Size(237, 23)
        Me.txtApellidosUsuario.TabIndex = 5
        '
        'cmbAño
        '
        Me.cmbAño.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.cmbAño.FormattingEnabled = True
        Me.cmbAño.Location = New System.Drawing.Point(380, 120)
        Me.cmbAño.Name = "cmbAño"
        Me.cmbAño.Size = New System.Drawing.Size(81, 24)
        Me.cmbAño.TabIndex = 8
        '
        'lblApellidosVendedor
        '
        Me.lblApellidosVendedor.AutoSize = True
        Me.lblApellidosVendedor.Location = New System.Drawing.Point(23, 70)
        Me.lblApellidosVendedor.Name = "lblApellidosVendedor"
        Me.lblApellidosVendedor.Size = New System.Drawing.Size(74, 16)
        Me.lblApellidosVendedor.TabIndex = 4
        Me.lblApellidosVendedor.Text = "Apellidos"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(289, 99)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(37, 16)
        Me.Label22.TabIndex = 63
        Me.Label22.Text = "Mes"
        '
        'txtNombresUsuario
        '
        Me.txtNombresUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombresUsuario.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.txtNombresUsuario.Location = New System.Drawing.Point(190, 29)
        Me.txtNombresUsuario.MaxLength = 30
        Me.txtNombresUsuario.Name = "txtNombresUsuario"
        Me.txtNombresUsuario.Size = New System.Drawing.Size(237, 23)
        Me.txtNombresUsuario.TabIndex = 4
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(403, 99)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(36, 16)
        Me.Label23.TabIndex = 65
        Me.Label23.Text = "Año"
        '
        'lblTelefonoEmpleado
        '
        Me.lblTelefonoEmpleado.AutoSize = True
        Me.lblTelefonoEmpleado.Location = New System.Drawing.Point(23, 167)
        Me.lblTelefonoEmpleado.Name = "lblTelefonoEmpleado"
        Me.lblTelefonoEmpleado.Size = New System.Drawing.Size(70, 16)
        Me.lblTelefonoEmpleado.TabIndex = 1
        Me.lblTelefonoEmpleado.Text = "Teléfono"
        '
        'cmbMes
        '
        Me.cmbMes.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.cmbMes.FormattingEnabled = True
        Me.cmbMes.Location = New System.Drawing.Point(266, 120)
        Me.cmbMes.Name = "cmbMes"
        Me.cmbMes.Size = New System.Drawing.Size(93, 24)
        Me.cmbMes.TabIndex = 7
        '
        'lblNombreVendedor
        '
        Me.lblNombreVendedor.AutoSize = True
        Me.lblNombreVendedor.Location = New System.Drawing.Point(23, 32)
        Me.lblNombreVendedor.Name = "lblNombreVendedor"
        Me.lblNombreVendedor.Size = New System.Drawing.Size(73, 16)
        Me.lblNombreVendedor.TabIndex = 1
        Me.lblNombreVendedor.Text = "Nombres"
        '
        'lblDireccionVendedor
        '
        Me.lblDireccionVendedor.AutoSize = True
        Me.lblDireccionVendedor.Location = New System.Drawing.Point(563, 50)
        Me.lblDireccionVendedor.Name = "lblDireccionVendedor"
        Me.lblDireccionVendedor.Size = New System.Drawing.Size(75, 16)
        Me.lblDireccionVendedor.TabIndex = 1
        Me.lblDireccionVendedor.Text = "Dirección"
        '
        'txtDireccionUsuario
        '
        Me.txtDireccionUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDireccionUsuario.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.txtDireccionUsuario.Location = New System.Drawing.Point(706, 29)
        Me.txtDireccionUsuario.MaxLength = 50
        Me.txtDireccionUsuario.Multiline = True
        Me.txtDireccionUsuario.Name = "txtDireccionUsuario"
        Me.txtDireccionUsuario.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDireccionUsuario.Size = New System.Drawing.Size(144, 54)
        Me.txtDireccionUsuario.TabIndex = 9
        '
        'lblGuionEmpleado
        '
        Me.lblGuionEmpleado.AutoSize = True
        Me.lblGuionEmpleado.Location = New System.Drawing.Point(234, 30)
        Me.lblGuionEmpleado.Name = "lblGuionEmpleado"
        Me.lblGuionEmpleado.Size = New System.Drawing.Size(15, 16)
        Me.lblGuionEmpleado.TabIndex = 7
        Me.lblGuionEmpleado.Text = "-"
        '
        'txtGuion
        '
        Me.txtGuion.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.txtGuion.Location = New System.Drawing.Point(251, 26)
        Me.txtGuion.MaxLength = 1
        Me.txtGuion.Name = "txtGuion"
        Me.txtGuion.Size = New System.Drawing.Size(25, 23)
        Me.txtGuion.TabIndex = 2
        '
        'lblRUNUsuario
        '
        Me.lblRUNUsuario.AutoSize = True
        Me.lblRUNUsuario.Location = New System.Drawing.Point(23, 29)
        Me.lblRUNUsuario.Name = "lblRUNUsuario"
        Me.lblRUNUsuario.Size = New System.Drawing.Size(52, 16)
        Me.lblRUNUsuario.TabIndex = 0
        Me.lblRUNUsuario.Text = "R.U.N."
        '
        'txtRUNUsuario
        '
        Me.txtRUNUsuario.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.txtRUNUsuario.Location = New System.Drawing.Point(111, 27)
        Me.txtRUNUsuario.MaxLength = 8
        Me.txtRUNUsuario.Name = "txtRUNUsuario"
        Me.txtRUNUsuario.Size = New System.Drawing.Size(116, 23)
        Me.txtRUNUsuario.TabIndex = 1
        '
        'groBuscarUsuario
        '
        Me.groBuscarUsuario.Controls.Add(Me.btnBuscar)
        Me.groBuscarUsuario.Controls.Add(Me.lblRUNUsuario)
        Me.groBuscarUsuario.Controls.Add(Me.lblGuionEmpleado)
        Me.groBuscarUsuario.Controls.Add(Me.txtGuion)
        Me.groBuscarUsuario.Controls.Add(Me.txtRUNUsuario)
        Me.groBuscarUsuario.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groBuscarUsuario.ForeColor = System.Drawing.Color.White
        Me.groBuscarUsuario.Location = New System.Drawing.Point(14, 12)
        Me.groBuscarUsuario.Name = "groBuscarUsuario"
        Me.groBuscarUsuario.Size = New System.Drawing.Size(451, 67)
        Me.groBuscarUsuario.TabIndex = 10
        Me.groBuscarUsuario.TabStop = False
        Me.groBuscarUsuario.Text = "Buscar usuario"
        Me.ToolTip1.SetToolTip(Me.groBuscarUsuario, "Ingrese el R.U.N. del usuario que desea modificar")
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnBuscar.Location = New System.Drawing.Point(323, 17)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(87, 37)
        Me.btnBuscar.TabIndex = 3
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'btnActualizarVendedor
        '
        Me.btnActualizarVendedor.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnActualizarVendedor.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActualizarVendedor.Location = New System.Drawing.Point(829, 307)
        Me.btnActualizarVendedor.Name = "btnActualizarVendedor"
        Me.btnActualizarVendedor.Size = New System.Drawing.Size(100, 34)
        Me.btnActualizarVendedor.TabIndex = 13
        Me.btnActualizarVendedor.Text = "Actualizar"
        Me.btnActualizarVendedor.UseVisualStyleBackColor = False
        '
        'ErrorProviderModificarUsuario
        '
        Me.ErrorProviderModificarUsuario.ContainerControl = Me
        '
        'groTipoUsuario
        '
        Me.groTipoUsuario.Controls.Add(Me.rdbCliente)
        Me.groTipoUsuario.Controls.Add(Me.rdbAdministrador)
        Me.groTipoUsuario.Controls.Add(Me.rdbProductor)
        Me.groTipoUsuario.Controls.Add(Me.rbdVendedor)
        Me.groTipoUsuario.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groTipoUsuario.ForeColor = System.Drawing.Color.White
        Me.groTipoUsuario.Location = New System.Drawing.Point(492, 12)
        Me.groTipoUsuario.Name = "groTipoUsuario"
        Me.groTipoUsuario.Size = New System.Drawing.Size(475, 67)
        Me.groTipoUsuario.TabIndex = 19
        Me.groTipoUsuario.TabStop = False
        Me.groTipoUsuario.Text = "Tipo usuario"
        Me.ToolTip1.SetToolTip(Me.groTipoUsuario, "Seleccione el tipo de usuario")
        '
        'rdbCliente
        '
        Me.rdbCliente.AutoSize = True
        Me.rdbCliente.Location = New System.Drawing.Point(379, 32)
        Me.rdbCliente.Name = "rdbCliente"
        Me.rdbCliente.Size = New System.Drawing.Size(77, 20)
        Me.rdbCliente.TabIndex = 6
        Me.rdbCliente.TabStop = True
        Me.rdbCliente.Text = "Cliente"
        Me.rdbCliente.UseVisualStyleBackColor = True
        '
        'rdbAdministrador
        '
        Me.rdbAdministrador.AutoSize = True
        Me.rdbAdministrador.Enabled = False
        Me.rdbAdministrador.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbAdministrador.Location = New System.Drawing.Point(238, 32)
        Me.rdbAdministrador.Name = "rdbAdministrador"
        Me.rdbAdministrador.Size = New System.Drawing.Size(129, 20)
        Me.rdbAdministrador.TabIndex = 4
        Me.rdbAdministrador.TabStop = True
        Me.rdbAdministrador.Text = "Administrador"
        Me.rdbAdministrador.UseVisualStyleBackColor = True
        '
        'rdbProductor
        '
        Me.rdbProductor.AutoSize = True
        Me.rdbProductor.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbProductor.Location = New System.Drawing.Point(14, 32)
        Me.rdbProductor.Name = "rdbProductor"
        Me.rdbProductor.Size = New System.Drawing.Size(97, 20)
        Me.rdbProductor.TabIndex = 2
        Me.rdbProductor.TabStop = True
        Me.rdbProductor.Text = "Productor"
        Me.rdbProductor.UseVisualStyleBackColor = True
        '
        'rbdVendedor
        '
        Me.rbdVendedor.AutoSize = True
        Me.rbdVendedor.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbdVendedor.Location = New System.Drawing.Point(128, 32)
        Me.rbdVendedor.Name = "rbdVendedor"
        Me.rbdVendedor.Size = New System.Drawing.Size(96, 20)
        Me.rbdVendedor.TabIndex = 3
        Me.rbdVendedor.TabStop = True
        Me.rbdVendedor.Text = "Vendedor"
        Me.rbdVendedor.UseVisualStyleBackColor = True
        '
        'VendedoresTableAdapter1
        '
        Me.VendedoresTableAdapter1.ClearBeforeFill = True
        '
        'AdministradoresTableAdapter1
        '
        Me.AdministradoresTableAdapter1.ClearBeforeFill = True
        '
        'ProduccionTableAdapter1
        '
        Me.ProduccionTableAdapter1.ClearBeforeFill = True
        '
        'ClientesTableAdapter1
        '
        Me.ClientesTableAdapter1.ClearBeforeFill = True
        '
        'ToolTip1
        '
        Me.ToolTip1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.ToolTip1.ForeColor = System.Drawing.Color.White
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.ToolTipTitle = "Modificar usuario"
        '
        'frmModificarUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSlateGray
        Me.ClientSize = New System.Drawing.Size(1026, 350)
        Me.Controls.Add(Me.groTipoUsuario)
        Me.Controls.Add(Me.btnActualizarVendedor)
        Me.Controls.Add(Me.groBuscarUsuario)
        Me.Controls.Add(Me.groInfoEmpleado)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmModificarUsuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modificar usuario"
        Me.groInfoEmpleado.ResumeLayout(False)
        Me.groInfoEmpleado.PerformLayout()
        Me.groBuscarUsuario.ResumeLayout(False)
        Me.groBuscarUsuario.PerformLayout()
        CType(Me.ErrorProviderModificarUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groTipoUsuario.ResumeLayout(False)
        Me.groTipoUsuario.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents groInfoEmpleado As System.Windows.Forms.GroupBox
    Friend WithEvents cmbAño As System.Windows.Forms.ComboBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents cmbMes As System.Windows.Forms.ComboBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtTelefonoUsuario As System.Windows.Forms.TextBox
    Friend WithEvents lblFechaNacVendedor As System.Windows.Forms.Label
    Friend WithEvents lblGuionEmpleado As System.Windows.Forms.Label
    Friend WithEvents txtGuion As System.Windows.Forms.TextBox
    Friend WithEvents txtApellidosUsuario As System.Windows.Forms.TextBox
    Friend WithEvents lblApellidosVendedor As System.Windows.Forms.Label
    Friend WithEvents txtNombresUsuario As System.Windows.Forms.TextBox
    Friend WithEvents lblRUNUsuario As System.Windows.Forms.Label
    Friend WithEvents lblTelefonoEmpleado As System.Windows.Forms.Label
    Friend WithEvents lblNombreVendedor As System.Windows.Forms.Label
    Friend WithEvents lblDireccionVendedor As System.Windows.Forms.Label
    Friend WithEvents txtRUNUsuario As System.Windows.Forms.TextBox
    Friend WithEvents txtDireccionUsuario As System.Windows.Forms.TextBox
    Friend WithEvents groBuscarUsuario As System.Windows.Forms.GroupBox
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents btnActualizarVendedor As System.Windows.Forms.Button
    Friend WithEvents ErrorProviderModificarUsuario As System.Windows.Forms.ErrorProvider
    Friend WithEvents txtConfirmaContraseña As System.Windows.Forms.TextBox
    Friend WithEvents lblConfirmaContraseña As System.Windows.Forms.Label
    Friend WithEvents txtContraseña As System.Windows.Forms.TextBox
    Friend WithEvents lblContraseña As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents VendedoresTableAdapter1 As Teatro.TeatroDataSetTableAdapters.VENDEDORESTableAdapter
    Friend WithEvents cmbDia As System.Windows.Forms.ComboBox
    Friend WithEvents groTipoUsuario As System.Windows.Forms.GroupBox
    Friend WithEvents rdbAdministrador As System.Windows.Forms.RadioButton
    Friend WithEvents rdbProductor As System.Windows.Forms.RadioButton
    Friend WithEvents rbdVendedor As System.Windows.Forms.RadioButton
    Friend WithEvents AdministradoresTableAdapter1 As Teatro.TeatroDataSetTableAdapters.ADMINISTRADORESTableAdapter
    Friend WithEvents ProduccionTableAdapter1 As Teatro.TeatroDataSetTableAdapters.PRODUCCIONTableAdapter
    Friend WithEvents rdbCliente As System.Windows.Forms.RadioButton
    Friend WithEvents ClientesTableAdapter1 As Teatro.TeatroDataSetTableAdapters.CLIENTESTableAdapter
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
