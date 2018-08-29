<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIngreso
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
        Me.txtRUNusuario = New System.Windows.Forms.TextBox
        Me.txtContraseñaUsuario = New System.Windows.Forms.TextBox
        Me.lblRUN = New System.Windows.Forms.Label
        Me.lblContraseña = New System.Windows.Forms.Label
        Me.GroIdentificacion = New System.Windows.Forms.GroupBox
        Me.lblGuion = New System.Windows.Forms.Label
        Me.txtGuion = New System.Windows.Forms.TextBox
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.btnSalir = New System.Windows.Forms.Button
        Me.btnIngresar = New System.Windows.Forms.Button
        Me.TeatroDataSet = New Teatro.TeatroDataSet
        Me.VENDEDORESTableAdapter = New Teatro.TeatroDataSetTableAdapters.VENDEDORESTableAdapter
        Me.ADMINISTRADORESTableAdapter = New Teatro.TeatroDataSetTableAdapters.ADMINISTRADORESTableAdapter
        Me.PRODUCCIONTableAdapter = New Teatro.TeatroDataSetTableAdapters.PRODUCCIONTableAdapter
        Me.VendedoresTableAdapter1 = New Teatro.TeatroDataSetTableAdapters.VENDEDORESTableAdapter
        Me.GroIdentificacion.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TeatroDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtRUNusuario
        '
        Me.txtRUNusuario.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRUNusuario.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.txtRUNusuario.Location = New System.Drawing.Point(125, 24)
        Me.txtRUNusuario.MaxLength = 8
        Me.txtRUNusuario.Name = "txtRUNusuario"
        Me.txtRUNusuario.Size = New System.Drawing.Size(96, 23)
        Me.txtRUNusuario.TabIndex = 0
        '
        'txtContraseñaUsuario
        '
        Me.txtContraseñaUsuario.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContraseñaUsuario.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.txtContraseñaUsuario.Location = New System.Drawing.Point(125, 69)
        Me.txtContraseñaUsuario.MaxLength = 20
        Me.txtContraseñaUsuario.Name = "txtContraseñaUsuario"
        Me.txtContraseñaUsuario.Size = New System.Drawing.Size(96, 23)
        Me.txtContraseñaUsuario.TabIndex = 2
        Me.txtContraseñaUsuario.UseSystemPasswordChar = True
        '
        'lblRUN
        '
        Me.lblRUN.AutoSize = True
        Me.lblRUN.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRUN.Location = New System.Drawing.Point(42, 27)
        Me.lblRUN.Name = "lblRUN"
        Me.lblRUN.Size = New System.Drawing.Size(52, 16)
        Me.lblRUN.TabIndex = 1
        Me.lblRUN.Text = "R.U.N."
        '
        'lblContraseña
        '
        Me.lblContraseña.AutoSize = True
        Me.lblContraseña.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContraseña.Location = New System.Drawing.Point(24, 72)
        Me.lblContraseña.Name = "lblContraseña"
        Me.lblContraseña.Size = New System.Drawing.Size(92, 16)
        Me.lblContraseña.TabIndex = 1
        Me.lblContraseña.Text = "Contraseña"
        '
        'GroIdentificacion
        '
        Me.GroIdentificacion.Controls.Add(Me.lblGuion)
        Me.GroIdentificacion.Controls.Add(Me.txtGuion)
        Me.GroIdentificacion.Controls.Add(Me.lblContraseña)
        Me.GroIdentificacion.Controls.Add(Me.lblRUN)
        Me.GroIdentificacion.Controls.Add(Me.txtContraseñaUsuario)
        Me.GroIdentificacion.Controls.Add(Me.txtRUNusuario)
        Me.GroIdentificacion.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroIdentificacion.ForeColor = System.Drawing.Color.White
        Me.GroIdentificacion.Location = New System.Drawing.Point(12, 12)
        Me.GroIdentificacion.Name = "GroIdentificacion"
        Me.GroIdentificacion.Size = New System.Drawing.Size(309, 101)
        Me.GroIdentificacion.TabIndex = 2
        Me.GroIdentificacion.TabStop = False
        Me.GroIdentificacion.Text = "Identificación"
        '
        'lblGuion
        '
        Me.lblGuion.AutoSize = True
        Me.lblGuion.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGuion.Location = New System.Drawing.Point(229, 27)
        Me.lblGuion.Name = "lblGuion"
        Me.lblGuion.Size = New System.Drawing.Size(15, 16)
        Me.lblGuion.TabIndex = 4
        Me.lblGuion.Text = "-"
        '
        'txtGuion
        '
        Me.txtGuion.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGuion.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.txtGuion.Location = New System.Drawing.Point(250, 24)
        Me.txtGuion.MaxLength = 1
        Me.txtGuion.Name = "txtGuion"
        Me.txtGuion.Size = New System.Drawing.Size(24, 23)
        Me.txtGuion.TabIndex = 1
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Teatro.My.Resources.Resources.password
        Me.PictureBox1.Location = New System.Drawing.Point(338, 43)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(53, 61)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnSalir.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Image = Global.Teatro.My.Resources.Resources._exit
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSalir.Location = New System.Drawing.Point(57, 129)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(107, 30)
        Me.btnSalir.TabIndex = 5
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'btnIngresar
        '
        Me.btnIngresar.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnIngresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnIngresar.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIngresar.Image = Global.Teatro.My.Resources.Resources.button_ok
        Me.btnIngresar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnIngresar.Location = New System.Drawing.Point(189, 129)
        Me.btnIngresar.Name = "btnIngresar"
        Me.btnIngresar.Size = New System.Drawing.Size(132, 30)
        Me.btnIngresar.TabIndex = 3
        Me.btnIngresar.Text = "Ingresar"
        Me.btnIngresar.UseVisualStyleBackColor = False
        '
        'TeatroDataSet
        '
        Me.TeatroDataSet.DataSetName = "TeatroDataSet"
        Me.TeatroDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VENDEDORESTableAdapter
        '
        Me.VENDEDORESTableAdapter.ClearBeforeFill = True
        '
        'ADMINISTRADORESTableAdapter
        '
        Me.ADMINISTRADORESTableAdapter.ClearBeforeFill = True
        '
        'PRODUCCIONTableAdapter
        '
        Me.PRODUCCIONTableAdapter.ClearBeforeFill = True
        '
        'VendedoresTableAdapter1
        '
        Me.VendedoresTableAdapter1.ClearBeforeFill = True
        '
        'frmIngreso
        '
        Me.AcceptButton = Me.btnIngresar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSlateGray
        Me.ClientSize = New System.Drawing.Size(403, 179)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.GroIdentificacion)
        Me.Controls.Add(Me.btnIngresar)
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.ForeColor = System.Drawing.Color.White
        Me.Name = "frmIngreso"
        Me.Text = "Ingreso"
        Me.GroIdentificacion.ResumeLayout(False)
        Me.GroIdentificacion.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TeatroDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtRUNusuario As System.Windows.Forms.TextBox
    Friend WithEvents txtContraseñaUsuario As System.Windows.Forms.TextBox
    Friend WithEvents lblRUN As System.Windows.Forms.Label
    Friend WithEvents lblContraseña As System.Windows.Forms.Label
    Friend WithEvents GroIdentificacion As System.Windows.Forms.GroupBox
    Friend WithEvents btnIngresar As System.Windows.Forms.Button
    Friend WithEvents lblGuion As System.Windows.Forms.Label
    Friend WithEvents txtGuion As System.Windows.Forms.TextBox
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents TeatroDataSet As Teatro.TeatroDataSet
    Friend WithEvents VENDEDORESTableAdapter As Teatro.TeatroDataSetTableAdapters.VENDEDORESTableAdapter
    Friend WithEvents ADMINISTRADORESTableAdapter As Teatro.TeatroDataSetTableAdapters.ADMINISTRADORESTableAdapter
    Friend WithEvents PRODUCCIONTableAdapter As Teatro.TeatroDataSetTableAdapters.PRODUCCIONTableAdapter
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents VendedoresTableAdapter1 As Teatro.TeatroDataSetTableAdapters.VENDEDORESTableAdapter
End Class
