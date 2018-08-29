<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmModificarContraseña
    Inherits frmModelo

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
        Me.groModificarContraseña = New System.Windows.Forms.GroupBox
        Me.txtTelefonoUsuario = New System.Windows.Forms.TextBox
        Me.txtConfirmarContraseña = New System.Windows.Forms.TextBox
        Me.txtContraseñaNueva = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblApellidosVendedor = New System.Windows.Forms.Label
        Me.txtContraseñaActual = New System.Windows.Forms.TextBox
        Me.lblTelefonoEmpleado = New System.Windows.Forms.Label
        Me.lblNombreVendedor = New System.Windows.Forms.Label
        Me.btnModificar = New System.Windows.Forms.Button
        Me.AdministradoresTableAdapter1 = New Teatro.TeatroDataSetTableAdapters.ADMINISTRADORESTableAdapter
        Me.VendedoresTableAdapter1 = New Teatro.TeatroDataSetTableAdapters.VENDEDORESTableAdapter
        Me.ProduccionTableAdapter1 = New Teatro.TeatroDataSetTableAdapters.PRODUCCIONTableAdapter
        Me.groModificarContraseña.SuspendLayout()
        Me.SuspendLayout()
        '
        'groModificarContraseña
        '
        Me.groModificarContraseña.Controls.Add(Me.txtTelefonoUsuario)
        Me.groModificarContraseña.Controls.Add(Me.txtConfirmarContraseña)
        Me.groModificarContraseña.Controls.Add(Me.txtContraseñaNueva)
        Me.groModificarContraseña.Controls.Add(Me.Label2)
        Me.groModificarContraseña.Controls.Add(Me.lblApellidosVendedor)
        Me.groModificarContraseña.Controls.Add(Me.txtContraseñaActual)
        Me.groModificarContraseña.Controls.Add(Me.lblTelefonoEmpleado)
        Me.groModificarContraseña.Controls.Add(Me.lblNombreVendedor)
        Me.groModificarContraseña.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groModificarContraseña.ForeColor = System.Drawing.Color.White
        Me.groModificarContraseña.Location = New System.Drawing.Point(13, 13)
        Me.groModificarContraseña.Margin = New System.Windows.Forms.Padding(4)
        Me.groModificarContraseña.Name = "groModificarContraseña"
        Me.groModificarContraseña.Padding = New System.Windows.Forms.Padding(4)
        Me.groModificarContraseña.Size = New System.Drawing.Size(404, 172)
        Me.groModificarContraseña.TabIndex = 5
        Me.groModificarContraseña.TabStop = False
        Me.groModificarContraseña.Text = "Modificar contraseña"
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
        'txtConfirmarContraseña
        '
        Me.txtConfirmarContraseña.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtConfirmarContraseña.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConfirmarContraseña.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.txtConfirmarContraseña.Location = New System.Drawing.Point(198, 120)
        Me.txtConfirmarContraseña.Margin = New System.Windows.Forms.Padding(4)
        Me.txtConfirmarContraseña.MaxLength = 30
        Me.txtConfirmarContraseña.Name = "txtConfirmarContraseña"
        Me.txtConfirmarContraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtConfirmarContraseña.Size = New System.Drawing.Size(174, 23)
        Me.txtConfirmarContraseña.TabIndex = 3
        '
        'txtContraseñaNueva
        '
        Me.txtContraseñaNueva.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtContraseñaNueva.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContraseñaNueva.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.txtContraseñaNueva.Location = New System.Drawing.Point(198, 81)
        Me.txtContraseñaNueva.Margin = New System.Windows.Forms.Padding(4)
        Me.txtContraseñaNueva.MaxLength = 30
        Me.txtContraseñaNueva.Name = "txtContraseñaNueva"
        Me.txtContraseñaNueva.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtContraseñaNueva.Size = New System.Drawing.Size(174, 23)
        Me.txtContraseñaNueva.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(25, 123)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(166, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Confirmar contraseña"
        '
        'lblApellidosVendedor
        '
        Me.lblApellidosVendedor.AutoSize = True
        Me.lblApellidosVendedor.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApellidosVendedor.Location = New System.Drawing.Point(25, 84)
        Me.lblApellidosVendedor.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblApellidosVendedor.Name = "lblApellidosVendedor"
        Me.lblApellidosVendedor.Size = New System.Drawing.Size(141, 16)
        Me.lblApellidosVendedor.TabIndex = 0
        Me.lblApellidosVendedor.Text = "Contraseña nueva"
        '
        'txtContraseñaActual
        '
        Me.txtContraseñaActual.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtContraseñaActual.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContraseñaActual.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.txtContraseñaActual.Location = New System.Drawing.Point(199, 41)
        Me.txtContraseñaActual.Margin = New System.Windows.Forms.Padding(4)
        Me.txtContraseñaActual.MaxLength = 30
        Me.txtContraseñaActual.Name = "txtContraseñaActual"
        Me.txtContraseñaActual.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtContraseñaActual.Size = New System.Drawing.Size(173, 23)
        Me.txtContraseñaActual.TabIndex = 1
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
        Me.lblNombreVendedor.Location = New System.Drawing.Point(26, 44)
        Me.lblNombreVendedor.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNombreVendedor.Name = "lblNombreVendedor"
        Me.lblNombreVendedor.Size = New System.Drawing.Size(141, 16)
        Me.lblNombreVendedor.TabIndex = 0
        Me.lblNombreVendedor.Text = "Contraseña actual"
        '
        'btnModificar
        '
        Me.btnModificar.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnModificar.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.Location = New System.Drawing.Point(283, 193)
        Me.btnModificar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(102, 38)
        Me.btnModificar.TabIndex = 4
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = False
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
        'frmModificarContraseña
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(440, 241)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.groModificarContraseña)
        Me.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.Name = "frmModificarContraseña"
        Me.Text = "Modificar contraseña"
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.groModificarContraseña, 0)
        Me.Controls.SetChildIndex(Me.btnModificar, 0)
        Me.groModificarContraseña.ResumeLayout(False)
        Me.groModificarContraseña.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents groModificarContraseña As System.Windows.Forms.GroupBox
    Friend WithEvents txtTelefonoUsuario As System.Windows.Forms.TextBox
    Friend WithEvents txtConfirmarContraseña As System.Windows.Forms.TextBox
    Friend WithEvents txtContraseñaNueva As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblApellidosVendedor As System.Windows.Forms.Label
    Friend WithEvents txtContraseñaActual As System.Windows.Forms.TextBox
    Friend WithEvents lblTelefonoEmpleado As System.Windows.Forms.Label
    Friend WithEvents lblNombreVendedor As System.Windows.Forms.Label
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents AdministradoresTableAdapter1 As Teatro.TeatroDataSetTableAdapters.ADMINISTRADORESTableAdapter
    Friend WithEvents VendedoresTableAdapter1 As Teatro.TeatroDataSetTableAdapters.VENDEDORESTableAdapter
    Friend WithEvents ProduccionTableAdapter1 As Teatro.TeatroDataSetTableAdapters.PRODUCCIONTableAdapter
End Class
