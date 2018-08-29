<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegistrarUsuario
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
        Me.txtTelefonoUsuario = New System.Windows.Forms.TextBox
        Me.cmbAño = New System.Windows.Forms.ComboBox
        Me.Label23 = New System.Windows.Forms.Label
        Me.cmbMes = New System.Windows.Forms.ComboBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.cmbDia = New System.Windows.Forms.ComboBox
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
        Me.ErrorProviderUsuario = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.btnRegistrarUsuario = New System.Windows.Forms.Button
        Me.groTipoUsuario = New System.Windows.Forms.GroupBox
        Me.rdbCliente = New System.Windows.Forms.RadioButton
        Me.rdbAdministrador = New System.Windows.Forms.RadioButton
        Me.rdbProductor = New System.Windows.Forms.RadioButton
        Me.rbdVendedor = New System.Windows.Forms.RadioButton
        Me.VendedoresTableAdapter1 = New Teatro.TeatroDataSetTableAdapters.VENDEDORESTableAdapter
        Me.AdministradoresTableAdapter1 = New Teatro.TeatroDataSetTableAdapters.ADMINISTRADORESTableAdapter
        Me.ProduccionTableAdapter1 = New Teatro.TeatroDataSetTableAdapters.PRODUCCIONTableAdapter
        Me.ClientesTableAdapter1 = New Teatro.TeatroDataSetTableAdapters.CLIENTESTableAdapter
        Me.groInfoEmpleado.SuspendLayout()
        CType(Me.ErrorProviderUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groTipoUsuario.SuspendLayout()
        Me.SuspendLayout()
        '
        'groInfoEmpleado
        '
        Me.groInfoEmpleado.Controls.Add(Me.txtTelefonoUsuario)
        Me.groInfoEmpleado.Controls.Add(Me.cmbAño)
        Me.groInfoEmpleado.Controls.Add(Me.Label23)
        Me.groInfoEmpleado.Controls.Add(Me.cmbMes)
        Me.groInfoEmpleado.Controls.Add(Me.Label22)
        Me.groInfoEmpleado.Controls.Add(Me.Label21)
        Me.groInfoEmpleado.Controls.Add(Me.cmbDia)
        Me.groInfoEmpleado.Controls.Add(Me.lblFechaNacVendedor)
        Me.groInfoEmpleado.Controls.Add(Me.lblGuionEmpleado)
        Me.groInfoEmpleado.Controls.Add(Me.txtGuion)
        Me.groInfoEmpleado.Controls.Add(Me.txtApellidosUsuario)
        Me.groInfoEmpleado.Controls.Add(Me.lblApellidosVendedor)
        Me.groInfoEmpleado.Controls.Add(Me.txtNombresUsuario)
        Me.groInfoEmpleado.Controls.Add(Me.lblRUNEmpleado)
        Me.groInfoEmpleado.Controls.Add(Me.lblTelefonoEmpleado)
        Me.groInfoEmpleado.Controls.Add(Me.lblNombreVendedor)
        Me.groInfoEmpleado.Controls.Add(Me.lblDireccionVendedor)
        Me.groInfoEmpleado.Controls.Add(Me.txtRUNUsuario)
        Me.groInfoEmpleado.Controls.Add(Me.txtDireccionUsuario)
        Me.groInfoEmpleado.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groInfoEmpleado.ForeColor = System.Drawing.Color.White
        Me.groInfoEmpleado.Location = New System.Drawing.Point(18, 132)
        Me.groInfoEmpleado.Margin = New System.Windows.Forms.Padding(4)
        Me.groInfoEmpleado.Name = "groInfoEmpleado"
        Me.groInfoEmpleado.Padding = New System.Windows.Forms.Padding(4)
        Me.groInfoEmpleado.Size = New System.Drawing.Size(552, 388)
        Me.groInfoEmpleado.TabIndex = 5
        Me.groInfoEmpleado.TabStop = False
        Me.groInfoEmpleado.Text = "Información personal"
        '
        'txtTelefonoUsuario
        '
        Me.txtTelefonoUsuario.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefonoUsuario.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.txtTelefonoUsuario.Location = New System.Drawing.Point(179, 337)
        Me.txtTelefonoUsuario.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTelefonoUsuario.MaxLength = 8
        Me.txtTelefonoUsuario.Name = "txtTelefonoUsuario"
        Me.txtTelefonoUsuario.Size = New System.Drawing.Size(121, 23)
        Me.txtTelefonoUsuario.TabIndex = 14
        '
        'cmbAño
        '
        Me.cmbAño.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAño.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.cmbAño.FormattingEnabled = True
        Me.cmbAño.Location = New System.Drawing.Point(402, 210)
        Me.cmbAño.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbAño.Name = "cmbAño"
        Me.cmbAño.Size = New System.Drawing.Size(75, 24)
        Me.cmbAño.TabIndex = 12
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(420, 182)
        Me.Label23.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(36, 16)
        Me.Label23.TabIndex = 0
        Me.Label23.Text = "Año"
        '
        'cmbMes
        '
        Me.cmbMes.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMes.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.cmbMes.FormattingEnabled = True
        Me.cmbMes.Location = New System.Drawing.Point(261, 210)
        Me.cmbMes.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbMes.Name = "cmbMes"
        Me.cmbMes.Size = New System.Drawing.Size(112, 24)
        Me.cmbMes.TabIndex = 11
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(304, 182)
        Me.Label22.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(37, 16)
        Me.Label22.TabIndex = 0
        Me.Label22.Text = "Mes"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(190, 182)
        Me.Label21.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(31, 16)
        Me.Label21.TabIndex = 0
        Me.Label21.Text = "Día"
        '
        'cmbDia
        '
        Me.cmbDia.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDia.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.cmbDia.FormattingEnabled = True
        Me.cmbDia.ItemHeight = 16
        Me.cmbDia.Location = New System.Drawing.Point(181, 210)
        Me.cmbDia.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbDia.Name = "cmbDia"
        Me.cmbDia.Size = New System.Drawing.Size(56, 24)
        Me.cmbDia.TabIndex = 10
        '
        'lblFechaNacVendedor
        '
        Me.lblFechaNacVendedor.AutoSize = True
        Me.lblFechaNacVendedor.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaNacVendedor.Location = New System.Drawing.Point(30, 214)
        Me.lblFechaNacVendedor.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFechaNacVendedor.Name = "lblFechaNacVendedor"
        Me.lblFechaNacVendedor.Size = New System.Drawing.Size(137, 16)
        Me.lblFechaNacVendedor.TabIndex = 0
        Me.lblFechaNacVendedor.Text = "Fecha nacimiento"
        '
        'lblGuionEmpleado
        '
        Me.lblGuionEmpleado.AutoSize = True
        Me.lblGuionEmpleado.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGuionEmpleado.Location = New System.Drawing.Point(337, 50)
        Me.lblGuionEmpleado.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblGuionEmpleado.Name = "lblGuionEmpleado"
        Me.lblGuionEmpleado.Size = New System.Drawing.Size(15, 16)
        Me.lblGuionEmpleado.TabIndex = 7
        Me.lblGuionEmpleado.Text = "-"
        '
        'txtGuion
        '
        Me.txtGuion.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGuion.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.txtGuion.Location = New System.Drawing.Point(359, 46)
        Me.txtGuion.Margin = New System.Windows.Forms.Padding(4)
        Me.txtGuion.MaxLength = 1
        Me.txtGuion.Name = "txtGuion"
        Me.txtGuion.Size = New System.Drawing.Size(25, 23)
        Me.txtGuion.TabIndex = 7
        '
        'txtApellidosUsuario
        '
        Me.txtApellidosUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtApellidosUsuario.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApellidosUsuario.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.txtApellidosUsuario.Location = New System.Drawing.Point(179, 144)
        Me.txtApellidosUsuario.Margin = New System.Windows.Forms.Padding(4)
        Me.txtApellidosUsuario.MaxLength = 30
        Me.txtApellidosUsuario.Name = "txtApellidosUsuario"
        Me.txtApellidosUsuario.Size = New System.Drawing.Size(298, 23)
        Me.txtApellidosUsuario.TabIndex = 9
        '
        'lblApellidosVendedor
        '
        Me.lblApellidosVendedor.AutoSize = True
        Me.lblApellidosVendedor.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApellidosVendedor.Location = New System.Drawing.Point(30, 147)
        Me.lblApellidosVendedor.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblApellidosVendedor.Name = "lblApellidosVendedor"
        Me.lblApellidosVendedor.Size = New System.Drawing.Size(74, 16)
        Me.lblApellidosVendedor.TabIndex = 0
        Me.lblApellidosVendedor.Text = "Apellidos"
        '
        'txtNombresUsuario
        '
        Me.txtNombresUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombresUsuario.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombresUsuario.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.txtNombresUsuario.Location = New System.Drawing.Point(179, 97)
        Me.txtNombresUsuario.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNombresUsuario.MaxLength = 30
        Me.txtNombresUsuario.Name = "txtNombresUsuario"
        Me.txtNombresUsuario.Size = New System.Drawing.Size(298, 23)
        Me.txtNombresUsuario.TabIndex = 8
        '
        'lblRUNEmpleado
        '
        Me.lblRUNEmpleado.AutoSize = True
        Me.lblRUNEmpleado.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRUNEmpleado.Location = New System.Drawing.Point(30, 49)
        Me.lblRUNEmpleado.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRUNEmpleado.Name = "lblRUNEmpleado"
        Me.lblRUNEmpleado.Size = New System.Drawing.Size(52, 16)
        Me.lblRUNEmpleado.TabIndex = 0
        Me.lblRUNEmpleado.Text = "R.U.N."
        '
        'lblTelefonoEmpleado
        '
        Me.lblTelefonoEmpleado.AutoSize = True
        Me.lblTelefonoEmpleado.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefonoEmpleado.Location = New System.Drawing.Point(35, 340)
        Me.lblTelefonoEmpleado.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTelefonoEmpleado.Name = "lblTelefonoEmpleado"
        Me.lblTelefonoEmpleado.Size = New System.Drawing.Size(70, 16)
        Me.lblTelefonoEmpleado.TabIndex = 0
        Me.lblTelefonoEmpleado.Text = "Teléfono"
        '
        'lblNombreVendedor
        '
        Me.lblNombreVendedor.AutoSize = True
        Me.lblNombreVendedor.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreVendedor.Location = New System.Drawing.Point(30, 100)
        Me.lblNombreVendedor.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNombreVendedor.Name = "lblNombreVendedor"
        Me.lblNombreVendedor.Size = New System.Drawing.Size(73, 16)
        Me.lblNombreVendedor.TabIndex = 0
        Me.lblNombreVendedor.Text = "Nombres"
        '
        'lblDireccionVendedor
        '
        Me.lblDireccionVendedor.AutoSize = True
        Me.lblDireccionVendedor.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDireccionVendedor.Location = New System.Drawing.Point(30, 279)
        Me.lblDireccionVendedor.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDireccionVendedor.Name = "lblDireccionVendedor"
        Me.lblDireccionVendedor.Size = New System.Drawing.Size(75, 16)
        Me.lblDireccionVendedor.TabIndex = 0
        Me.lblDireccionVendedor.Text = "Dirección"
        '
        'txtRUNUsuario
        '
        Me.txtRUNUsuario.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRUNUsuario.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.txtRUNUsuario.Location = New System.Drawing.Point(179, 47)
        Me.txtRUNUsuario.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRUNUsuario.MaxLength = 8
        Me.txtRUNUsuario.Name = "txtRUNUsuario"
        Me.txtRUNUsuario.Size = New System.Drawing.Size(142, 23)
        Me.txtRUNUsuario.TabIndex = 6
        '
        'txtDireccionUsuario
        '
        Me.txtDireccionUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDireccionUsuario.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDireccionUsuario.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.txtDireccionUsuario.Location = New System.Drawing.Point(179, 258)
        Me.txtDireccionUsuario.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDireccionUsuario.MaxLength = 50
        Me.txtDireccionUsuario.Multiline = True
        Me.txtDireccionUsuario.Name = "txtDireccionUsuario"
        Me.txtDireccionUsuario.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDireccionUsuario.Size = New System.Drawing.Size(298, 56)
        Me.txtDireccionUsuario.TabIndex = 13
        '
        'ErrorProviderUsuario
        '
        Me.ErrorProviderUsuario.ContainerControl = Me
        '
        'btnRegistrarUsuario
        '
        Me.btnRegistrarUsuario.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnRegistrarUsuario.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistrarUsuario.Location = New System.Drawing.Point(372, 543)
        Me.btnRegistrarUsuario.Margin = New System.Windows.Forms.Padding(4)
        Me.btnRegistrarUsuario.Name = "btnRegistrarUsuario"
        Me.btnRegistrarUsuario.Size = New System.Drawing.Size(123, 38)
        Me.btnRegistrarUsuario.TabIndex = 15
        Me.btnRegistrarUsuario.Text = "Registrar"
        Me.btnRegistrarUsuario.UseVisualStyleBackColor = False
        '
        'groTipoUsuario
        '
        Me.groTipoUsuario.Controls.Add(Me.rdbCliente)
        Me.groTipoUsuario.Controls.Add(Me.rdbAdministrador)
        Me.groTipoUsuario.Controls.Add(Me.rdbProductor)
        Me.groTipoUsuario.Controls.Add(Me.rbdVendedor)
        Me.groTipoUsuario.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groTipoUsuario.ForeColor = System.Drawing.Color.White
        Me.groTipoUsuario.Location = New System.Drawing.Point(30, 13)
        Me.groTipoUsuario.Margin = New System.Windows.Forms.Padding(4)
        Me.groTipoUsuario.Name = "groTipoUsuario"
        Me.groTipoUsuario.Padding = New System.Windows.Forms.Padding(4)
        Me.groTipoUsuario.Size = New System.Drawing.Size(530, 94)
        Me.groTipoUsuario.TabIndex = 1
        Me.groTipoUsuario.TabStop = False
        Me.groTipoUsuario.Text = "Tipo usuario"
        '
        'rdbCliente
        '
        Me.rdbCliente.AutoSize = True
        Me.rdbCliente.Location = New System.Drawing.Point(411, 39)
        Me.rdbCliente.Name = "rdbCliente"
        Me.rdbCliente.Size = New System.Drawing.Size(77, 20)
        Me.rdbCliente.TabIndex = 5
        Me.rdbCliente.TabStop = True
        Me.rdbCliente.Text = "Cliente"
        Me.rdbCliente.UseVisualStyleBackColor = True
        '
        'rdbAdministrador
        '
        Me.rdbAdministrador.AutoSize = True
        Me.rdbAdministrador.Enabled = False
        Me.rdbAdministrador.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbAdministrador.Location = New System.Drawing.Point(262, 39)
        Me.rdbAdministrador.Margin = New System.Windows.Forms.Padding(4)
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
        Me.rdbProductor.Location = New System.Drawing.Point(16, 39)
        Me.rdbProductor.Margin = New System.Windows.Forms.Padding(4)
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
        Me.rbdVendedor.Location = New System.Drawing.Point(135, 39)
        Me.rbdVendedor.Margin = New System.Windows.Forms.Padding(4)
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
        'frmRegistrarUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSlateGray
        Me.ClientSize = New System.Drawing.Size(601, 594)
        Me.Controls.Add(Me.groTipoUsuario)
        Me.Controls.Add(Me.btnRegistrarUsuario)
        Me.Controls.Add(Me.groInfoEmpleado)
        Me.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRegistrarUsuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registrar usuario"
        Me.groInfoEmpleado.ResumeLayout(False)
        Me.groInfoEmpleado.PerformLayout()
        CType(Me.ErrorProviderUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groTipoUsuario.ResumeLayout(False)
        Me.groTipoUsuario.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents groInfoEmpleado As System.Windows.Forms.GroupBox
    Friend WithEvents lblFechaNacVendedor As System.Windows.Forms.Label
    Friend WithEvents lblGuionEmpleado As System.Windows.Forms.Label
    Friend WithEvents txtApellidosUsuario As System.Windows.Forms.TextBox
    Friend WithEvents lblApellidosVendedor As System.Windows.Forms.Label
    Friend WithEvents txtNombresUsuario As System.Windows.Forms.TextBox
    Friend WithEvents lblRUNEmpleado As System.Windows.Forms.Label
    Friend WithEvents lblTelefonoEmpleado As System.Windows.Forms.Label
    Friend WithEvents lblNombreVendedor As System.Windows.Forms.Label
    Friend WithEvents lblDireccionVendedor As System.Windows.Forms.Label
    Friend WithEvents txtDireccionUsuario As System.Windows.Forms.TextBox
    Friend WithEvents cmbAño As System.Windows.Forms.ComboBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents cmbMes As System.Windows.Forms.ComboBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents cmbDia As System.Windows.Forms.ComboBox
    Friend WithEvents ErrorProviderUsuario As System.Windows.Forms.ErrorProvider
    Friend WithEvents VendedoresTableAdapter1 As Teatro.TeatroDataSetTableAdapters.VENDEDORESTableAdapter
    Friend WithEvents btnRegistrarUsuario As System.Windows.Forms.Button
    Friend WithEvents groTipoUsuario As System.Windows.Forms.GroupBox
    Friend WithEvents AdministradoresTableAdapter1 As Teatro.TeatroDataSetTableAdapters.ADMINISTRADORESTableAdapter
    Friend WithEvents ProduccionTableAdapter1 As Teatro.TeatroDataSetTableAdapters.PRODUCCIONTableAdapter
    Friend WithEvents txtTelefonoUsuario As System.Windows.Forms.TextBox
    Friend WithEvents ClientesTableAdapter1 As Teatro.TeatroDataSetTableAdapters.CLIENTESTableAdapter
    Public WithEvents rdbProductor As System.Windows.Forms.RadioButton
    Public WithEvents rbdVendedor As System.Windows.Forms.RadioButton
    Public WithEvents rdbAdministrador As System.Windows.Forms.RadioButton
    Public WithEvents rdbCliente As System.Windows.Forms.RadioButton
    Public WithEvents txtGuion As System.Windows.Forms.TextBox
    Public WithEvents txtRUNUsuario As System.Windows.Forms.TextBox
End Class
