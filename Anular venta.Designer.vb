<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAnularVenta
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
        Me.groAnularVenta = New System.Windows.Forms.GroupBox
        Me.btnBuscar = New System.Windows.Forms.Button
        Me.lblGuion = New System.Windows.Forms.Label
        Me.txtGuion = New System.Windows.Forms.TextBox
        Me.lblRUNCliente = New System.Windows.Forms.Label
        Me.txtRUNusuario = New System.Windows.Forms.TextBox
        Me.txtMotivo = New System.Windows.Forms.TextBox
        Me.lblMotivo = New System.Windows.Forms.Label
        Me.dgDetalleBoleta = New System.Windows.Forms.DataGridView
        Me.lblNumeroBoleta = New System.Windows.Forms.Label
        Me.txtNumeroBoleta = New System.Windows.Forms.TextBox
        Me.ErrorProviderAnularVenta = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.VENTAENTRADASTableAdapter = New Teatro.TeatroDataSetTableAdapters.VENTASENTRADASTableAdapter
        Me.BoletasTableAdapter1 = New Teatro.TeatroDataSetTableAdapters.BOLETASTableAdapter
        Me.PagoefectivoTableAdapter1 = New Teatro.TeatroDataSetTableAdapters.PAGOEFECTIVOTableAdapter
        Me.AnulacionventaspeTableAdapter1 = New Teatro.TeatroDataSetTableAdapters.ANULACIONVENTASPETableAdapter
        Me.VentasjornadasTableAdapter1 = New Teatro.TeatroDataSetTableAdapters.VENTASJORNADASTableAdapter
        Me.VentasubicacionesTableAdapter1 = New Teatro.TeatroDataSetTableAdapters.VENTASUBICACIONESTableAdapter
        Me.EstadoentradasTableAdapter1 = New Teatro.TeatroDataSetTableAdapters.ESTADOENTRADASTableAdapter
        Me.EventosTableAdapter1 = New Teatro.TeatroDataSetTableAdapters.EVENTOSTableAdapter
        Me.btnAnular = New System.Windows.Forms.Button
        Me.groAnularVenta.SuspendLayout()
        CType(Me.dgDetalleBoleta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProviderAnularVenta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'groAnularVenta
        '
        Me.groAnularVenta.BackColor = System.Drawing.Color.DarkSlateGray
        Me.groAnularVenta.Controls.Add(Me.btnBuscar)
        Me.groAnularVenta.Controls.Add(Me.lblGuion)
        Me.groAnularVenta.Controls.Add(Me.txtGuion)
        Me.groAnularVenta.Controls.Add(Me.lblRUNCliente)
        Me.groAnularVenta.Controls.Add(Me.txtRUNusuario)
        Me.groAnularVenta.Controls.Add(Me.txtMotivo)
        Me.groAnularVenta.Controls.Add(Me.lblMotivo)
        Me.groAnularVenta.Controls.Add(Me.dgDetalleBoleta)
        Me.groAnularVenta.Controls.Add(Me.lblNumeroBoleta)
        Me.groAnularVenta.Controls.Add(Me.txtNumeroBoleta)
        Me.groAnularVenta.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groAnularVenta.ForeColor = System.Drawing.Color.White
        Me.groAnularVenta.Location = New System.Drawing.Point(18, 13)
        Me.groAnularVenta.Name = "groAnularVenta"
        Me.groAnularVenta.Size = New System.Drawing.Size(783, 220)
        Me.groAnularVenta.TabIndex = 10
        Me.groAnularVenta.TabStop = False
        Me.groAnularVenta.Text = "Anular venta"
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnBuscar.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.ForeColor = System.Drawing.Color.White
        Me.btnBuscar.Location = New System.Drawing.Point(541, 20)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(73, 32)
        Me.btnBuscar.TabIndex = 17
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'lblGuion
        '
        Me.lblGuion.AutoSize = True
        Me.lblGuion.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGuion.Location = New System.Drawing.Point(465, 28)
        Me.lblGuion.Name = "lblGuion"
        Me.lblGuion.Size = New System.Drawing.Size(15, 16)
        Me.lblGuion.TabIndex = 16
        Me.lblGuion.Text = "-"
        '
        'txtGuion
        '
        Me.txtGuion.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGuion.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.txtGuion.Location = New System.Drawing.Point(486, 25)
        Me.txtGuion.MaxLength = 1
        Me.txtGuion.Name = "txtGuion"
        Me.txtGuion.Size = New System.Drawing.Size(24, 23)
        Me.txtGuion.TabIndex = 15
        '
        'lblRUNCliente
        '
        Me.lblRUNCliente.AutoSize = True
        Me.lblRUNCliente.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRUNCliente.Location = New System.Drawing.Point(248, 28)
        Me.lblRUNCliente.Name = "lblRUNCliente"
        Me.lblRUNCliente.Size = New System.Drawing.Size(107, 16)
        Me.lblRUNCliente.TabIndex = 14
        Me.lblRUNCliente.Text = "R.U.N. Cliente"
        '
        'txtRUNusuario
        '
        Me.txtRUNusuario.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRUNusuario.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.txtRUNusuario.Location = New System.Drawing.Point(361, 25)
        Me.txtRUNusuario.MaxLength = 8
        Me.txtRUNusuario.Name = "txtRUNusuario"
        Me.txtRUNusuario.Size = New System.Drawing.Size(96, 23)
        Me.txtRUNusuario.TabIndex = 13
        '
        'txtMotivo
        '
        Me.txtMotivo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMotivo.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.txtMotivo.Location = New System.Drawing.Point(108, 145)
        Me.txtMotivo.MaxLength = 50
        Me.txtMotivo.Multiline = True
        Me.txtMotivo.Name = "txtMotivo"
        Me.txtMotivo.Size = New System.Drawing.Size(172, 53)
        Me.txtMotivo.TabIndex = 12
        '
        'lblMotivo
        '
        Me.lblMotivo.AutoSize = True
        Me.lblMotivo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMotivo.Location = New System.Drawing.Point(26, 148)
        Me.lblMotivo.Name = "lblMotivo"
        Me.lblMotivo.Size = New System.Drawing.Size(57, 16)
        Me.lblMotivo.TabIndex = 11
        Me.lblMotivo.Text = "Motivo"
        '
        'dgDetalleBoleta
        '
        Me.dgDetalleBoleta.AllowUserToAddRows = False
        Me.dgDetalleBoleta.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.dgDetalleBoleta.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgDetalleBoleta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgDetalleBoleta.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgDetalleBoleta.BackgroundColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgDetalleBoleta.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgDetalleBoleta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgDetalleBoleta.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgDetalleBoleta.Location = New System.Drawing.Point(18, 59)
        Me.dgDetalleBoleta.Name = "dgDetalleBoleta"
        Me.dgDetalleBoleta.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgDetalleBoleta.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.dgDetalleBoleta.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgDetalleBoleta.Size = New System.Drawing.Size(747, 67)
        Me.dgDetalleBoleta.TabIndex = 8
        '
        'lblNumeroBoleta
        '
        Me.lblNumeroBoleta.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblNumeroBoleta.AutoSize = True
        Me.lblNumeroBoleta.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumeroBoleta.Location = New System.Drawing.Point(44, 28)
        Me.lblNumeroBoleta.Name = "lblNumeroBoleta"
        Me.lblNumeroBoleta.Size = New System.Drawing.Size(115, 16)
        Me.lblNumeroBoleta.TabIndex = 5
        Me.lblNumeroBoleta.Text = "Número boleta"
        '
        'txtNumeroBoleta
        '
        Me.txtNumeroBoleta.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtNumeroBoleta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroBoleta.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumeroBoleta.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.txtNumeroBoleta.Location = New System.Drawing.Point(165, 25)
        Me.txtNumeroBoleta.MaxLength = 6
        Me.txtNumeroBoleta.Name = "txtNumeroBoleta"
        Me.txtNumeroBoleta.Size = New System.Drawing.Size(30, 23)
        Me.txtNumeroBoleta.TabIndex = 1
        '
        'ErrorProviderAnularVenta
        '
        Me.ErrorProviderAnularVenta.ContainerControl = Me
        '
        'VENTAENTRADASTableAdapter
        '
        Me.VENTAENTRADASTableAdapter.ClearBeforeFill = True
        '
        'BoletasTableAdapter1
        '
        Me.BoletasTableAdapter1.ClearBeforeFill = True
        '
        'PagoefectivoTableAdapter1
        '
        Me.PagoefectivoTableAdapter1.ClearBeforeFill = True
        '
        'AnulacionventaspeTableAdapter1
        '
        Me.AnulacionventaspeTableAdapter1.ClearBeforeFill = True
        '
        'VentasjornadasTableAdapter1
        '
        Me.VentasjornadasTableAdapter1.ClearBeforeFill = True
        '
        'VentasubicacionesTableAdapter1
        '
        Me.VentasubicacionesTableAdapter1.ClearBeforeFill = True
        '
        'EstadoentradasTableAdapter1
        '
        Me.EstadoentradasTableAdapter1.ClearBeforeFill = True
        '
        'EventosTableAdapter1
        '
        Me.EventosTableAdapter1.ClearBeforeFill = True
        '
        'btnAnular
        '
        Me.btnAnular.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnAnular.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnular.ForeColor = System.Drawing.Color.White
        Me.btnAnular.Location = New System.Drawing.Point(467, 252)
        Me.btnAnular.Name = "btnAnular"
        Me.btnAnular.Size = New System.Drawing.Size(73, 47)
        Me.btnAnular.TabIndex = 14
        Me.btnAnular.Text = "Anular"
        Me.btnAnular.UseVisualStyleBackColor = False
        '
        'frmAnularVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSlateGray
        Me.ClientSize = New System.Drawing.Size(813, 324)
        Me.Controls.Add(Me.btnAnular)
        Me.Controls.Add(Me.groAnularVenta)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAnularVenta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Anular venta"
        Me.groAnularVenta.ResumeLayout(False)
        Me.groAnularVenta.PerformLayout()
        CType(Me.dgDetalleBoleta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProviderAnularVenta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents groAnularVenta As System.Windows.Forms.GroupBox
    Friend WithEvents dgDetalleBoleta As System.Windows.Forms.DataGridView
    Friend WithEvents lblNumeroBoleta As System.Windows.Forms.Label
    Friend WithEvents txtNumeroBoleta As System.Windows.Forms.TextBox
    Friend WithEvents VENTAENTRADASTableAdapter As Teatro.TeatroDataSetTableAdapters.VENTASENTRADASTableAdapter
    Friend WithEvents txtMotivo As System.Windows.Forms.TextBox
    Friend WithEvents lblMotivo As System.Windows.Forms.Label
    Friend WithEvents BoletasTableAdapter1 As Teatro.TeatroDataSetTableAdapters.BOLETASTableAdapter
    Friend WithEvents PagoefectivoTableAdapter1 As Teatro.TeatroDataSetTableAdapters.PAGOEFECTIVOTableAdapter
    Friend WithEvents AnulacionventaspeTableAdapter1 As Teatro.TeatroDataSetTableAdapters.ANULACIONVENTASPETableAdapter
    Friend WithEvents ErrorProviderAnularVenta As System.Windows.Forms.ErrorProvider
    Friend WithEvents VentasjornadasTableAdapter1 As Teatro.TeatroDataSetTableAdapters.VENTASJORNADASTableAdapter
    Friend WithEvents VentasubicacionesTableAdapter1 As Teatro.TeatroDataSetTableAdapters.VENTASUBICACIONESTableAdapter
    Friend WithEvents EstadoentradasTableAdapter1 As Teatro.TeatroDataSetTableAdapters.ESTADOENTRADASTableAdapter
    Friend WithEvents EventosTableAdapter1 As Teatro.TeatroDataSetTableAdapters.EVENTOSTableAdapter
    Friend WithEvents btnAnular As System.Windows.Forms.Button
    Friend WithEvents lblGuion As System.Windows.Forms.Label
    Friend WithEvents txtGuion As System.Windows.Forms.TextBox
    Friend WithEvents lblRUNCliente As System.Windows.Forms.Label
    Friend WithEvents txtRUNusuario As System.Windows.Forms.TextBox
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
End Class
