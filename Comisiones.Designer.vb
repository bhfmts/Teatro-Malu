<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmComisiones
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
        Me.dtpDesde = New System.Windows.Forms.DateTimePicker
        Me.dtpHasta = New System.Windows.Forms.DateTimePicker
        Me.groTotalComisiones = New System.Windows.Forms.GroupBox
        Me.btnComision = New System.Windows.Forms.Button
        Me.txtComision = New System.Windows.Forms.TextBox
        Me.cmbFormaPago = New System.Windows.Forms.ComboBox
        Me.lblComision = New System.Windows.Forms.Label
        Me.lblFormaPago = New System.Windows.Forms.Label
        Me.lblHasta = New System.Windows.Forms.Label
        Me.lblDesde = New System.Windows.Forms.Label
        Me.PagoefectivoTableAdapter1 = New Teatro.TeatroDataSetTableAdapters.PAGOEFECTIVOTableAdapter
        Me.PagotarjetacreditoTableAdapter1 = New Teatro.TeatroDataSetTableAdapters.PAGOTARJETACREDITOTableAdapter
        Me.groTotalComisiones.SuspendLayout()
        Me.SuspendLayout()
        '
        'dtpDesde
        '
        Me.dtpDesde.Location = New System.Drawing.Point(129, 36)
        Me.dtpDesde.Name = "dtpDesde"
        Me.dtpDesde.Size = New System.Drawing.Size(200, 23)
        Me.dtpDesde.TabIndex = 0
        '
        'dtpHasta
        '
        Me.dtpHasta.Location = New System.Drawing.Point(129, 83)
        Me.dtpHasta.Name = "dtpHasta"
        Me.dtpHasta.Size = New System.Drawing.Size(200, 23)
        Me.dtpHasta.TabIndex = 1
        '
        'groTotalComisiones
        '
        Me.groTotalComisiones.Controls.Add(Me.btnComision)
        Me.groTotalComisiones.Controls.Add(Me.txtComision)
        Me.groTotalComisiones.Controls.Add(Me.cmbFormaPago)
        Me.groTotalComisiones.Controls.Add(Me.lblComision)
        Me.groTotalComisiones.Controls.Add(Me.lblFormaPago)
        Me.groTotalComisiones.Controls.Add(Me.lblHasta)
        Me.groTotalComisiones.Controls.Add(Me.lblDesde)
        Me.groTotalComisiones.Controls.Add(Me.dtpDesde)
        Me.groTotalComisiones.Controls.Add(Me.dtpHasta)
        Me.groTotalComisiones.Location = New System.Drawing.Point(12, 3)
        Me.groTotalComisiones.Name = "groTotalComisiones"
        Me.groTotalComisiones.Size = New System.Drawing.Size(356, 258)
        Me.groTotalComisiones.TabIndex = 2
        Me.groTotalComisiones.TabStop = False
        Me.groTotalComisiones.Text = "Total comisiones"
        '
        'btnComision
        '
        Me.btnComision.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnComision.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnComision.Location = New System.Drawing.Point(229, 214)
        Me.btnComision.Name = "btnComision"
        Me.btnComision.Size = New System.Drawing.Size(100, 34)
        Me.btnComision.TabIndex = 14
        Me.btnComision.Text = "Calcular"
        Me.btnComision.UseVisualStyleBackColor = False
        '
        'txtComision
        '
        Me.txtComision.Enabled = False
        Me.txtComision.Location = New System.Drawing.Point(129, 173)
        Me.txtComision.Name = "txtComision"
        Me.txtComision.Size = New System.Drawing.Size(100, 23)
        Me.txtComision.TabIndex = 5
        '
        'cmbFormaPago
        '
        Me.cmbFormaPago.FormattingEnabled = True
        Me.cmbFormaPago.Items.AddRange(New Object() {"Efectivo", "Tarjeta bancaria", "Ambas"})
        Me.cmbFormaPago.Location = New System.Drawing.Point(129, 123)
        Me.cmbFormaPago.Name = "cmbFormaPago"
        Me.cmbFormaPago.Size = New System.Drawing.Size(155, 24)
        Me.cmbFormaPago.TabIndex = 4
        '
        'lblComision
        '
        Me.lblComision.AutoSize = True
        Me.lblComision.Location = New System.Drawing.Point(22, 173)
        Me.lblComision.Name = "lblComision"
        Me.lblComision.Size = New System.Drawing.Size(75, 16)
        Me.lblComision.TabIndex = 3
        Me.lblComision.Text = "Comisión"
        '
        'lblFormaPago
        '
        Me.lblFormaPago.AutoSize = True
        Me.lblFormaPago.Location = New System.Drawing.Point(22, 126)
        Me.lblFormaPago.Name = "lblFormaPago"
        Me.lblFormaPago.Size = New System.Drawing.Size(95, 16)
        Me.lblFormaPago.TabIndex = 3
        Me.lblFormaPago.Text = "Forma pago"
        '
        'lblHasta
        '
        Me.lblHasta.AutoSize = True
        Me.lblHasta.Location = New System.Drawing.Point(35, 88)
        Me.lblHasta.Name = "lblHasta"
        Me.lblHasta.Size = New System.Drawing.Size(51, 16)
        Me.lblHasta.TabIndex = 2
        Me.lblHasta.Text = "Hasta"
        '
        'lblDesde
        '
        Me.lblDesde.AutoSize = True
        Me.lblDesde.Location = New System.Drawing.Point(35, 41)
        Me.lblDesde.Name = "lblDesde"
        Me.lblDesde.Size = New System.Drawing.Size(53, 16)
        Me.lblDesde.TabIndex = 2
        Me.lblDesde.Text = "Desde"
        '
        'PagoefectivoTableAdapter1
        '
        Me.PagoefectivoTableAdapter1.ClearBeforeFill = True
        '
        'PagotarjetacreditoTableAdapter1
        '
        Me.PagotarjetacreditoTableAdapter1.ClearBeforeFill = True
        '
        'frmComisiones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSlateGray
        Me.ClientSize = New System.Drawing.Size(385, 277)
        Me.Controls.Add(Me.groTotalComisiones)
        Me.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmComisiones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Comisiones"
        Me.groTotalComisiones.ResumeLayout(False)
        Me.groTotalComisiones.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dtpDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents groTotalComisiones As System.Windows.Forms.GroupBox
    Friend WithEvents cmbFormaPago As System.Windows.Forms.ComboBox
    Friend WithEvents lblFormaPago As System.Windows.Forms.Label
    Friend WithEvents lblHasta As System.Windows.Forms.Label
    Friend WithEvents lblDesde As System.Windows.Forms.Label
    Friend WithEvents txtComision As System.Windows.Forms.TextBox
    Friend WithEvents lblComision As System.Windows.Forms.Label
    Friend WithEvents btnComision As System.Windows.Forms.Button
    Friend WithEvents PagoefectivoTableAdapter1 As Teatro.TeatroDataSetTableAdapters.PAGOEFECTIVOTableAdapter
    Friend WithEvents PagotarjetacreditoTableAdapter1 As Teatro.TeatroDataSetTableAdapters.PAGOTARJETACREDITOTableAdapter
End Class
