<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEliminarUsuario
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.groEliminarUsuario = New System.Windows.Forms.GroupBox
        Me.groTipoUsuario = New System.Windows.Forms.GroupBox
        Me.rdbCliente = New System.Windows.Forms.RadioButton
        Me.rdbAdministrador = New System.Windows.Forms.RadioButton
        Me.rdbProductor = New System.Windows.Forms.RadioButton
        Me.rbdVendedor = New System.Windows.Forms.RadioButton
        Me.lblGuionEmpleado = New System.Windows.Forms.Label
        Me.txtGuion = New System.Windows.Forms.TextBox
        Me.lblRUNUsuario = New System.Windows.Forms.Label
        Me.txtRUNUsuario = New System.Windows.Forms.TextBox
        Me.dgUsuarios = New System.Windows.Forms.DataGridView
        Me.btnEliminar = New System.Windows.Forms.Button
        Me.ErrorProviderEliminarUsuario = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.VendedoresTableAdapter1 = New Teatro.TeatroDataSetTableAdapters.VENDEDORESTableAdapter
        Me.ProduccionTableAdapter1 = New Teatro.TeatroDataSetTableAdapters.PRODUCCIONTableAdapter
        Me.AdministradoresTableAdapter1 = New Teatro.TeatroDataSetTableAdapters.ADMINISTRADORESTableAdapter
        Me.ClientesTableAdapter1 = New Teatro.TeatroDataSetTableAdapters.CLIENTESTableAdapter
        Me.groEliminarUsuario.SuspendLayout()
        Me.groTipoUsuario.SuspendLayout()
        CType(Me.dgUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProviderEliminarUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'groEliminarUsuario
        '
        Me.groEliminarUsuario.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.groEliminarUsuario.BackColor = System.Drawing.Color.DarkSlateGray
        Me.groEliminarUsuario.Controls.Add(Me.groTipoUsuario)
        Me.groEliminarUsuario.Controls.Add(Me.lblGuionEmpleado)
        Me.groEliminarUsuario.Controls.Add(Me.txtGuion)
        Me.groEliminarUsuario.Controls.Add(Me.lblRUNUsuario)
        Me.groEliminarUsuario.Controls.Add(Me.txtRUNUsuario)
        Me.groEliminarUsuario.Controls.Add(Me.dgUsuarios)
        Me.groEliminarUsuario.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groEliminarUsuario.ForeColor = System.Drawing.Color.White
        Me.groEliminarUsuario.Location = New System.Drawing.Point(13, 4)
        Me.groEliminarUsuario.Name = "groEliminarUsuario"
        Me.groEliminarUsuario.Size = New System.Drawing.Size(602, 247)
        Me.groEliminarUsuario.TabIndex = 11
        Me.groEliminarUsuario.TabStop = False
        Me.groEliminarUsuario.Text = "Eliminar usuario"
        '
        'groTipoUsuario
        '
        Me.groTipoUsuario.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.groTipoUsuario.Controls.Add(Me.rdbCliente)
        Me.groTipoUsuario.Controls.Add(Me.rdbAdministrador)
        Me.groTipoUsuario.Controls.Add(Me.rdbProductor)
        Me.groTipoUsuario.Controls.Add(Me.rbdVendedor)
        Me.groTipoUsuario.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groTipoUsuario.ForeColor = System.Drawing.Color.White
        Me.groTipoUsuario.Location = New System.Drawing.Point(21, 31)
        Me.groTipoUsuario.Name = "groTipoUsuario"
        Me.groTipoUsuario.Size = New System.Drawing.Size(556, 76)
        Me.groTipoUsuario.TabIndex = 18
        Me.groTipoUsuario.TabStop = False
        Me.groTipoUsuario.Text = "Tipo usuario"
        '
        'rdbCliente
        '
        Me.rdbCliente.AutoSize = True
        Me.rdbCliente.Location = New System.Drawing.Point(447, 32)
        Me.rdbCliente.Name = "rdbCliente"
        Me.rdbCliente.Size = New System.Drawing.Size(77, 20)
        Me.rdbCliente.TabIndex = 7
        Me.rdbCliente.TabStop = True
        Me.rdbCliente.Text = "Cliente"
        Me.rdbCliente.UseVisualStyleBackColor = True
        '
        'rdbAdministrador
        '
        Me.rdbAdministrador.AutoSize = True
        Me.rdbAdministrador.Enabled = False
        Me.rdbAdministrador.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbAdministrador.Location = New System.Drawing.Point(293, 32)
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
        Me.rdbProductor.Location = New System.Drawing.Point(44, 32)
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
        Me.rbdVendedor.Location = New System.Drawing.Point(172, 32)
        Me.rbdVendedor.Name = "rbdVendedor"
        Me.rbdVendedor.Size = New System.Drawing.Size(96, 20)
        Me.rbdVendedor.TabIndex = 3
        Me.rbdVendedor.TabStop = True
        Me.rbdVendedor.Text = "Vendedor"
        Me.rbdVendedor.UseVisualStyleBackColor = True
        '
        'lblGuionEmpleado
        '
        Me.lblGuionEmpleado.AutoSize = True
        Me.lblGuionEmpleado.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGuionEmpleado.Location = New System.Drawing.Point(328, 125)
        Me.lblGuionEmpleado.Name = "lblGuionEmpleado"
        Me.lblGuionEmpleado.Size = New System.Drawing.Size(15, 16)
        Me.lblGuionEmpleado.TabIndex = 17
        Me.lblGuionEmpleado.Text = "-"
        '
        'txtGuion
        '
        Me.txtGuion.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGuion.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.txtGuion.Location = New System.Drawing.Point(345, 122)
        Me.txtGuion.MaxLength = 1
        Me.txtGuion.Name = "txtGuion"
        Me.txtGuion.Size = New System.Drawing.Size(22, 23)
        Me.txtGuion.TabIndex = 16
        '
        'lblRUNUsuario
        '
        Me.lblRUNUsuario.AutoSize = True
        Me.lblRUNUsuario.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRUNUsuario.Location = New System.Drawing.Point(170, 125)
        Me.lblRUNUsuario.Name = "lblRUNUsuario"
        Me.lblRUNUsuario.Size = New System.Drawing.Size(52, 16)
        Me.lblRUNUsuario.TabIndex = 14
        Me.lblRUNUsuario.Text = "R.U.N."
        '
        'txtRUNUsuario
        '
        Me.txtRUNUsuario.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRUNUsuario.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.txtRUNUsuario.Location = New System.Drawing.Point(222, 122)
        Me.txtRUNUsuario.MaxLength = 8
        Me.txtRUNUsuario.Name = "txtRUNUsuario"
        Me.txtRUNUsuario.Size = New System.Drawing.Size(100, 23)
        Me.txtRUNUsuario.TabIndex = 15
        '
        'dgUsuarios
        '
        Me.dgUsuarios.AllowUserToAddRows = False
        Me.dgUsuarios.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.dgUsuarios.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgUsuarios.BackgroundColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgUsuarios.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgUsuarios.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgUsuarios.Enabled = False
        Me.dgUsuarios.GridColor = System.Drawing.Color.MidnightBlue
        Me.dgUsuarios.Location = New System.Drawing.Point(80, 172)
        Me.dgUsuarios.Name = "dgUsuarios"
        Me.dgUsuarios.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgUsuarios.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.dgUsuarios.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgUsuarios.Size = New System.Drawing.Size(410, 51)
        Me.dgUsuarios.TabIndex = 8
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnEliminar.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.Image = Global.Teatro.My.Resources.Resources._stop
        Me.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEliminar.Location = New System.Drawing.Point(237, 266)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(121, 30)
        Me.btnEliminar.TabIndex = 10
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'ErrorProviderEliminarUsuario
        '
        Me.ErrorProviderEliminarUsuario.ContainerControl = Me
        '
        'VendedoresTableAdapter1
        '
        Me.VendedoresTableAdapter1.ClearBeforeFill = True
        '
        'ProduccionTableAdapter1
        '
        Me.ProduccionTableAdapter1.ClearBeforeFill = True
        '
        'AdministradoresTableAdapter1
        '
        Me.AdministradoresTableAdapter1.ClearBeforeFill = True
        '
        'ClientesTableAdapter1
        '
        Me.ClientesTableAdapter1.ClearBeforeFill = True
        '
        'frmEliminarUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSlateGray
        Me.ClientSize = New System.Drawing.Size(632, 308)
        Me.Controls.Add(Me.groEliminarUsuario)
        Me.Controls.Add(Me.btnEliminar)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmEliminarUsuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Eliminar usuario"
        Me.groEliminarUsuario.ResumeLayout(False)
        Me.groEliminarUsuario.PerformLayout()
        Me.groTipoUsuario.ResumeLayout(False)
        Me.groTipoUsuario.PerformLayout()
        CType(Me.dgUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProviderEliminarUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents groEliminarUsuario As System.Windows.Forms.GroupBox
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents dgUsuarios As System.Windows.Forms.DataGridView
    Friend WithEvents lblGuionEmpleado As System.Windows.Forms.Label
    Friend WithEvents txtGuion As System.Windows.Forms.TextBox
    Friend WithEvents lblRUNUsuario As System.Windows.Forms.Label
    Friend WithEvents txtRUNUsuario As System.Windows.Forms.TextBox
    Friend WithEvents ErrorProviderEliminarUsuario As System.Windows.Forms.ErrorProvider
    Friend WithEvents VendedoresTableAdapter1 As Teatro.TeatroDataSetTableAdapters.VENDEDORESTableAdapter
    Friend WithEvents ProduccionTableAdapter1 As Teatro.TeatroDataSetTableAdapters.PRODUCCIONTableAdapter
    Friend WithEvents groTipoUsuario As System.Windows.Forms.GroupBox
    Friend WithEvents rdbAdministrador As System.Windows.Forms.RadioButton
    Friend WithEvents rdbProductor As System.Windows.Forms.RadioButton
    Friend WithEvents rbdVendedor As System.Windows.Forms.RadioButton
    Friend WithEvents AdministradoresTableAdapter1 As Teatro.TeatroDataSetTableAdapters.ADMINISTRADORESTableAdapter
    Friend WithEvents rdbCliente As System.Windows.Forms.RadioButton
    Friend WithEvents ClientesTableAdapter1 As Teatro.TeatroDataSetTableAdapters.CLIENTESTableAdapter
End Class
