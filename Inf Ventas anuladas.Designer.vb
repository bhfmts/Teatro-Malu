<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVentasAnuladas
    Inherits Teatro.frmModelo

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
        Me.groParametros = New System.Windows.Forms.GroupBox
        Me.chkPorUsuario = New System.Windows.Forms.CheckBox
        Me.lblGuion = New System.Windows.Forms.Label
        Me.txtGuion = New System.Windows.Forms.TextBox
        Me.lblRUN = New System.Windows.Forms.Label
        Me.txtRUNusuario = New System.Windows.Forms.TextBox
        Me.rdbFechaVenta = New System.Windows.Forms.RadioButton
        Me.rdbFechaAnulacion = New System.Windows.Forms.RadioButton
        Me.btnGenerar = New System.Windows.Forms.Button
        Me.dtpHasta = New System.Windows.Forms.DateTimePicker
        Me.dtpDesde = New System.Windows.Forms.DateTimePicker
        Me.lblHasta = New System.Windows.Forms.Label
        Me.lblDesde = New System.Windows.Forms.Label
        Me.ErrorProviderVentasAnuladas = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.groParametros.SuspendLayout()
        CType(Me.ErrorProviderVentasAnuladas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'groParametros
        '
        Me.groParametros.Controls.Add(Me.chkPorUsuario)
        Me.groParametros.Controls.Add(Me.lblGuion)
        Me.groParametros.Controls.Add(Me.txtGuion)
        Me.groParametros.Controls.Add(Me.lblRUN)
        Me.groParametros.Controls.Add(Me.txtRUNusuario)
        Me.groParametros.Controls.Add(Me.rdbFechaVenta)
        Me.groParametros.Controls.Add(Me.rdbFechaAnulacion)
        Me.groParametros.Controls.Add(Me.btnGenerar)
        Me.groParametros.Controls.Add(Me.dtpHasta)
        Me.groParametros.Controls.Add(Me.dtpDesde)
        Me.groParametros.Controls.Add(Me.lblHasta)
        Me.groParametros.Controls.Add(Me.lblDesde)
        Me.groParametros.Location = New System.Drawing.Point(12, 12)
        Me.groParametros.Name = "groParametros"
        Me.groParametros.Size = New System.Drawing.Size(693, 165)
        Me.groParametros.TabIndex = 2
        Me.groParametros.TabStop = False
        Me.groParametros.Text = "Rango de fechas"
        '
        'chkPorUsuario
        '
        Me.chkPorUsuario.AutoSize = True
        Me.chkPorUsuario.Location = New System.Drawing.Point(35, 116)
        Me.chkPorUsuario.Name = "chkPorUsuario"
        Me.chkPorUsuario.Size = New System.Drawing.Size(109, 20)
        Me.chkPorUsuario.TabIndex = 5
        Me.chkPorUsuario.Text = "Por usuario"
        Me.chkPorUsuario.UseVisualStyleBackColor = True
        '
        'lblGuion
        '
        Me.lblGuion.AutoSize = True
        Me.lblGuion.Enabled = False
        Me.lblGuion.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGuion.Location = New System.Drawing.Point(390, 117)
        Me.lblGuion.Name = "lblGuion"
        Me.lblGuion.Size = New System.Drawing.Size(15, 16)
        Me.lblGuion.TabIndex = 21
        Me.lblGuion.Text = "-"
        Me.lblGuion.Visible = False
        '
        'txtGuion
        '
        Me.txtGuion.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGuion.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.txtGuion.Location = New System.Drawing.Point(411, 114)
        Me.txtGuion.MaxLength = 1
        Me.txtGuion.Name = "txtGuion"
        Me.txtGuion.Size = New System.Drawing.Size(24, 23)
        Me.txtGuion.TabIndex = 7
        Me.txtGuion.Visible = False
        '
        'lblRUN
        '
        Me.lblRUN.AutoSize = True
        Me.lblRUN.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRUN.Location = New System.Drawing.Point(157, 117)
        Me.lblRUN.Name = "lblRUN"
        Me.lblRUN.Size = New System.Drawing.Size(126, 16)
        Me.lblRUN.TabIndex = 19
        Me.lblRUN.Text = "R.U.N. Vendedor"
        Me.lblRUN.Visible = False
        '
        'txtRUNusuario
        '
        Me.txtRUNusuario.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRUNusuario.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.txtRUNusuario.Location = New System.Drawing.Point(288, 114)
        Me.txtRUNusuario.MaxLength = 8
        Me.txtRUNusuario.Name = "txtRUNusuario"
        Me.txtRUNusuario.Size = New System.Drawing.Size(96, 23)
        Me.txtRUNusuario.TabIndex = 6
        Me.txtRUNusuario.Visible = False
        '
        'rdbFechaVenta
        '
        Me.rdbFechaVenta.AutoSize = True
        Me.rdbFechaVenta.Location = New System.Drawing.Point(184, 83)
        Me.rdbFechaVenta.Name = "rdbFechaVenta"
        Me.rdbFechaVenta.Size = New System.Drawing.Size(116, 20)
        Me.rdbFechaVenta.TabIndex = 4
        Me.rdbFechaVenta.TabStop = True
        Me.rdbFechaVenta.Text = "Fecha venta"
        Me.rdbFechaVenta.UseVisualStyleBackColor = True
        '
        'rdbFechaAnulacion
        '
        Me.rdbFechaAnulacion.AutoSize = True
        Me.rdbFechaAnulacion.Location = New System.Drawing.Point(34, 83)
        Me.rdbFechaAnulacion.Name = "rdbFechaAnulacion"
        Me.rdbFechaAnulacion.Size = New System.Drawing.Size(144, 20)
        Me.rdbFechaAnulacion.TabIndex = 3
        Me.rdbFechaAnulacion.TabStop = True
        Me.rdbFechaAnulacion.Text = "Fecha anulación"
        Me.rdbFechaAnulacion.UseVisualStyleBackColor = True
        '
        'btnGenerar
        '
        Me.btnGenerar.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnGenerar.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerar.Location = New System.Drawing.Point(498, 97)
        Me.btnGenerar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.Size = New System.Drawing.Size(90, 38)
        Me.btnGenerar.TabIndex = 8
        Me.btnGenerar.Text = "Generar"
        Me.btnGenerar.UseVisualStyleBackColor = False
        '
        'dtpHasta
        '
        Me.dtpHasta.Location = New System.Drawing.Point(413, 40)
        Me.dtpHasta.Name = "dtpHasta"
        Me.dtpHasta.Size = New System.Drawing.Size(242, 23)
        Me.dtpHasta.TabIndex = 1
        '
        'dtpDesde
        '
        Me.dtpDesde.Location = New System.Drawing.Point(98, 40)
        Me.dtpDesde.Name = "dtpDesde"
        Me.dtpDesde.Size = New System.Drawing.Size(223, 23)
        Me.dtpDesde.TabIndex = 1
        '
        'lblHasta
        '
        Me.lblHasta.AutoSize = True
        Me.lblHasta.Location = New System.Drawing.Point(347, 45)
        Me.lblHasta.Name = "lblHasta"
        Me.lblHasta.Size = New System.Drawing.Size(51, 16)
        Me.lblHasta.TabIndex = 0
        Me.lblHasta.Text = "Hasta"
        '
        'lblDesde
        '
        Me.lblDesde.AutoSize = True
        Me.lblDesde.Location = New System.Drawing.Point(27, 45)
        Me.lblDesde.Name = "lblDesde"
        Me.lblDesde.Size = New System.Drawing.Size(53, 16)
        Me.lblDesde.TabIndex = 0
        Me.lblDesde.Text = "Desde"
        '
        'ErrorProviderVentasAnuladas
        '
        Me.ErrorProviderVentasAnuladas.ContainerControl = Me
        '
        'frmVentasAnuladas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(734, 206)
        Me.Controls.Add(Me.groParametros)
        Me.Name = "frmVentasAnuladas"
        Me.Text = "Ventas anuladas"
        Me.Controls.SetChildIndex(Me.groParametros, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.groParametros.ResumeLayout(False)
        Me.groParametros.PerformLayout()
        CType(Me.ErrorProviderVentasAnuladas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents groParametros As System.Windows.Forms.GroupBox
    Friend WithEvents rdbFechaVenta As System.Windows.Forms.RadioButton
    Friend WithEvents rdbFechaAnulacion As System.Windows.Forms.RadioButton
    Friend WithEvents btnGenerar As System.Windows.Forms.Button
    Friend WithEvents dtpHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblHasta As System.Windows.Forms.Label
    Friend WithEvents lblDesde As System.Windows.Forms.Label
    Friend WithEvents lblGuion As System.Windows.Forms.Label
    Friend WithEvents txtGuion As System.Windows.Forms.TextBox
    Friend WithEvents lblRUN As System.Windows.Forms.Label
    Friend WithEvents txtRUNusuario As System.Windows.Forms.TextBox
    Friend WithEvents chkPorUsuario As System.Windows.Forms.CheckBox
    Friend WithEvents ErrorProviderVentasAnuladas As System.Windows.Forms.ErrorProvider
End Class
