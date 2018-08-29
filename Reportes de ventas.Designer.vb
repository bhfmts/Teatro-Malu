<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReporteVentas
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.btnGenerar = New System.Windows.Forms.Button
        Me.groFiltro = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnOn4 = New System.Windows.Forms.Button
        Me.btnOn3 = New System.Windows.Forms.Button
        Me.btnOn2 = New System.Windows.Forms.Button
        Me.btnOn1 = New System.Windows.Forms.Button
        Me.lblResultados = New System.Windows.Forms.Label
        Me.dgEventos = New System.Windows.Forms.DataGridView
        Me.lblTipoPago = New System.Windows.Forms.Label
        Me.lblRUNVendedor = New System.Windows.Forms.Label
        Me.cmbTipoPago = New System.Windows.Forms.ComboBox
        Me.lblBuscarEvento = New System.Windows.Forms.Label
        Me.txtRUNVendedor = New System.Windows.Forms.TextBox
        Me.txtNombreEvento = New System.Windows.Forms.TextBox
        Me.lblTipoEntrada = New System.Windows.Forms.Label
        Me.cmbTipoEntrada = New System.Windows.Forms.ComboBox
        Me.dtpHasta = New System.Windows.Forms.DateTimePicker
        Me.dtpDesde = New System.Windows.Forms.DateTimePicker
        Me.lblHasta = New System.Windows.Forms.Label
        Me.lblDesde = New System.Windows.Forms.Label
        Me.ReportedeventasTableAdapter1 = New Teatro.TeatroDataSetTableAdapters.REPORTEDEVENTASTableAdapter
        Me.TeatroDataSet = New Teatro.TeatroDataSet
        Me.groFiltro.SuspendLayout()
        CType(Me.dgEventos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TeatroDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnGenerar
        '
        Me.btnGenerar.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnGenerar.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerar.Location = New System.Drawing.Point(327, 382)
        Me.btnGenerar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.Size = New System.Drawing.Size(90, 38)
        Me.btnGenerar.TabIndex = 12
        Me.btnGenerar.Text = "Generar"
        Me.btnGenerar.UseVisualStyleBackColor = False
        '
        'groFiltro
        '
        Me.groFiltro.Controls.Add(Me.Label2)
        Me.groFiltro.Controls.Add(Me.btnOn4)
        Me.groFiltro.Controls.Add(Me.btnOn3)
        Me.groFiltro.Controls.Add(Me.btnOn2)
        Me.groFiltro.Controls.Add(Me.btnOn1)
        Me.groFiltro.Controls.Add(Me.lblResultados)
        Me.groFiltro.Controls.Add(Me.dgEventos)
        Me.groFiltro.Controls.Add(Me.lblTipoPago)
        Me.groFiltro.Controls.Add(Me.lblRUNVendedor)
        Me.groFiltro.Controls.Add(Me.cmbTipoPago)
        Me.groFiltro.Controls.Add(Me.lblBuscarEvento)
        Me.groFiltro.Controls.Add(Me.txtRUNVendedor)
        Me.groFiltro.Controls.Add(Me.txtNombreEvento)
        Me.groFiltro.Controls.Add(Me.lblTipoEntrada)
        Me.groFiltro.Controls.Add(Me.cmbTipoEntrada)
        Me.groFiltro.Controls.Add(Me.dtpHasta)
        Me.groFiltro.Controls.Add(Me.dtpDesde)
        Me.groFiltro.Controls.Add(Me.lblHasta)
        Me.groFiltro.Controls.Add(Me.lblDesde)
        Me.groFiltro.ForeColor = System.Drawing.Color.White
        Me.groFiltro.Location = New System.Drawing.Point(12, 12)
        Me.groFiltro.Name = "groFiltro"
        Me.groFiltro.Size = New System.Drawing.Size(417, 354)
        Me.groFiltro.TabIndex = 18
        Me.groFiltro.TabStop = False
        Me.groFiltro.Text = "Filtro"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(179, 306)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 16)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "Ej.: 15519461-8"
        '
        'btnOn4
        '
        Me.btnOn4.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnOn4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOn4.Location = New System.Drawing.Point(326, 277)
        Me.btnOn4.Margin = New System.Windows.Forms.Padding(4)
        Me.btnOn4.Name = "btnOn4"
        Me.btnOn4.Size = New System.Drawing.Size(46, 27)
        Me.btnOn4.TabIndex = 11
        Me.btnOn4.Text = "On"
        Me.btnOn4.UseVisualStyleBackColor = False
        '
        'btnOn3
        '
        Me.btnOn3.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnOn3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOn3.Location = New System.Drawing.Point(326, 159)
        Me.btnOn3.Margin = New System.Windows.Forms.Padding(4)
        Me.btnOn3.Name = "btnOn3"
        Me.btnOn3.Size = New System.Drawing.Size(46, 27)
        Me.btnOn3.TabIndex = 8
        Me.btnOn3.Text = "On"
        Me.btnOn3.UseVisualStyleBackColor = False
        '
        'btnOn2
        '
        Me.btnOn2.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnOn2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOn2.Location = New System.Drawing.Point(326, 124)
        Me.btnOn2.Margin = New System.Windows.Forms.Padding(4)
        Me.btnOn2.Name = "btnOn2"
        Me.btnOn2.Size = New System.Drawing.Size(46, 27)
        Me.btnOn2.TabIndex = 6
        Me.btnOn2.Text = "On"
        Me.btnOn2.UseVisualStyleBackColor = False
        '
        'btnOn1
        '
        Me.btnOn1.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnOn1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOn1.Location = New System.Drawing.Point(326, 93)
        Me.btnOn1.Margin = New System.Windows.Forms.Padding(4)
        Me.btnOn1.Name = "btnOn1"
        Me.btnOn1.Size = New System.Drawing.Size(46, 27)
        Me.btnOn1.TabIndex = 4
        Me.btnOn1.Text = "On"
        Me.btnOn1.UseVisualStyleBackColor = False
        '
        'lblResultados
        '
        Me.lblResultados.AutoSize = True
        Me.lblResultados.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResultados.ForeColor = System.Drawing.Color.White
        Me.lblResultados.Location = New System.Drawing.Point(38, 218)
        Me.lblResultados.Name = "lblResultados"
        Me.lblResultados.Size = New System.Drawing.Size(88, 16)
        Me.lblResultados.TabIndex = 35
        Me.lblResultados.Text = "Resultados"
        '
        'dgEventos
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.dgEventos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgEventos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgEventos.BackgroundColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgEventos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgEventos.ColumnHeadersHeight = 20
        Me.dgEventos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgEventos.Location = New System.Drawing.Point(166, 192)
        Me.dgEventos.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dgEventos.Name = "dgEventos"
        Me.dgEventos.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgEventos.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgEventos.RowHeadersWidth = 150
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.dgEventos.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgEventos.Size = New System.Drawing.Size(224, 67)
        Me.dgEventos.TabIndex = 9
        '
        'lblTipoPago
        '
        Me.lblTipoPago.AutoSize = True
        Me.lblTipoPago.ForeColor = System.Drawing.Color.White
        Me.lblTipoPago.Location = New System.Drawing.Point(38, 131)
        Me.lblTipoPago.Name = "lblTipoPago"
        Me.lblTipoPago.Size = New System.Drawing.Size(78, 16)
        Me.lblTipoPago.TabIndex = 33
        Me.lblTipoPago.Text = "Tipo pago"
        '
        'lblRUNVendedor
        '
        Me.lblRUNVendedor.AutoSize = True
        Me.lblRUNVendedor.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRUNVendedor.ForeColor = System.Drawing.Color.White
        Me.lblRUNVendedor.Location = New System.Drawing.Point(38, 282)
        Me.lblRUNVendedor.Name = "lblRUNVendedor"
        Me.lblRUNVendedor.Size = New System.Drawing.Size(125, 16)
        Me.lblRUNVendedor.TabIndex = 31
        Me.lblRUNVendedor.Text = "R.U.N. vendedor"
        '
        'cmbTipoPago
        '
        Me.cmbTipoPago.Enabled = False
        Me.cmbTipoPago.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTipoPago.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.cmbTipoPago.Items.AddRange(New Object() {"EFECTIVO", "TARJETA BANCARIA"})
        Me.cmbTipoPago.Location = New System.Drawing.Point(167, 131)
        Me.cmbTipoPago.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.cmbTipoPago.Name = "cmbTipoPago"
        Me.cmbTipoPago.Size = New System.Drawing.Size(136, 20)
        Me.cmbTipoPago.TabIndex = 5
        Me.cmbTipoPago.Text = "Seleccione tipo pago"
        '
        'lblBuscarEvento
        '
        Me.lblBuscarEvento.AutoSize = True
        Me.lblBuscarEvento.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBuscarEvento.ForeColor = System.Drawing.Color.White
        Me.lblBuscarEvento.Location = New System.Drawing.Point(36, 164)
        Me.lblBuscarEvento.Name = "lblBuscarEvento"
        Me.lblBuscarEvento.Size = New System.Drawing.Size(113, 16)
        Me.lblBuscarEvento.TabIndex = 31
        Me.lblBuscarEvento.Text = "Buscar evento"
        '
        'txtRUNVendedor
        '
        Me.txtRUNVendedor.BackColor = System.Drawing.Color.White
        Me.txtRUNVendedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRUNVendedor.Enabled = False
        Me.txtRUNVendedor.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.txtRUNVendedor.Location = New System.Drawing.Point(169, 279)
        Me.txtRUNVendedor.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtRUNVendedor.MaxLength = 10
        Me.txtRUNVendedor.Name = "txtRUNVendedor"
        Me.txtRUNVendedor.Size = New System.Drawing.Size(136, 23)
        Me.txtRUNVendedor.TabIndex = 10
        '
        'txtNombreEvento
        '
        Me.txtNombreEvento.BackColor = System.Drawing.Color.White
        Me.txtNombreEvento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombreEvento.Enabled = False
        Me.txtNombreEvento.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.txtNombreEvento.Location = New System.Drawing.Point(167, 161)
        Me.txtNombreEvento.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtNombreEvento.MaxLength = 20
        Me.txtNombreEvento.Name = "txtNombreEvento"
        Me.txtNombreEvento.Size = New System.Drawing.Size(136, 23)
        Me.txtNombreEvento.TabIndex = 7
        '
        'lblTipoEntrada
        '
        Me.lblTipoEntrada.AutoSize = True
        Me.lblTipoEntrada.ForeColor = System.Drawing.Color.White
        Me.lblTipoEntrada.Location = New System.Drawing.Point(38, 98)
        Me.lblTipoEntrada.Name = "lblTipoEntrada"
        Me.lblTipoEntrada.Size = New System.Drawing.Size(99, 16)
        Me.lblTipoEntrada.TabIndex = 19
        Me.lblTipoEntrada.Text = "Tipo entrada"
        '
        'cmbTipoEntrada
        '
        Me.cmbTipoEntrada.Enabled = False
        Me.cmbTipoEntrada.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTipoEntrada.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.cmbTipoEntrada.Items.AddRange(New Object() {"NIÑO", "ESTUDIANTE", "ADULTO", "TERCERA EDAD"})
        Me.cmbTipoEntrada.Location = New System.Drawing.Point(167, 98)
        Me.cmbTipoEntrada.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.cmbTipoEntrada.Name = "cmbTipoEntrada"
        Me.cmbTipoEntrada.Size = New System.Drawing.Size(99, 20)
        Me.cmbTipoEntrada.TabIndex = 3
        Me.cmbTipoEntrada.Text = "Seleccione tipo entrada"
        '
        'dtpHasta
        '
        Me.dtpHasta.Location = New System.Drawing.Point(167, 61)
        Me.dtpHasta.Name = "dtpHasta"
        Me.dtpHasta.Size = New System.Drawing.Size(223, 23)
        Me.dtpHasta.TabIndex = 2
        '
        'dtpDesde
        '
        Me.dtpDesde.Location = New System.Drawing.Point(167, 26)
        Me.dtpDesde.Name = "dtpDesde"
        Me.dtpDesde.Size = New System.Drawing.Size(223, 23)
        Me.dtpDesde.TabIndex = 1
        '
        'lblHasta
        '
        Me.lblHasta.AutoSize = True
        Me.lblHasta.ForeColor = System.Drawing.Color.White
        Me.lblHasta.Location = New System.Drawing.Point(38, 66)
        Me.lblHasta.Name = "lblHasta"
        Me.lblHasta.Size = New System.Drawing.Size(51, 16)
        Me.lblHasta.TabIndex = 0
        Me.lblHasta.Text = "Hasta"
        '
        'lblDesde
        '
        Me.lblDesde.AutoSize = True
        Me.lblDesde.ForeColor = System.Drawing.Color.White
        Me.lblDesde.Location = New System.Drawing.Point(36, 33)
        Me.lblDesde.Name = "lblDesde"
        Me.lblDesde.Size = New System.Drawing.Size(53, 16)
        Me.lblDesde.TabIndex = 0
        Me.lblDesde.Text = "Desde"
        '
        'ReportedeventasTableAdapter1
        '
        Me.ReportedeventasTableAdapter1.ClearBeforeFill = True
        '
        'TeatroDataSet
        '
        Me.TeatroDataSet.DataSetName = "TeatroDataSet"
        Me.TeatroDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'frmReporteVentas
        '
        Me.AcceptButton = Me.btnGenerar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(445, 436)
        Me.Controls.Add(Me.groFiltro)
        Me.Controls.Add(Me.btnGenerar)
        Me.Name = "frmReporteVentas"
        Me.Text = "Reportes de ventas"
        Me.Controls.SetChildIndex(Me.btnGenerar, 0)
        Me.Controls.SetChildIndex(Me.groFiltro, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.groFiltro.ResumeLayout(False)
        Me.groFiltro.PerformLayout()
        CType(Me.dgEventos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TeatroDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnGenerar As System.Windows.Forms.Button
    Friend WithEvents groFiltro As System.Windows.Forms.GroupBox
    Friend WithEvents lblBuscarEvento As System.Windows.Forms.Label
    Friend WithEvents txtNombreEvento As System.Windows.Forms.TextBox
    Friend WithEvents lblTipoEntrada As System.Windows.Forms.Label
    Public WithEvents cmbTipoEntrada As System.Windows.Forms.ComboBox
    Friend WithEvents dtpHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblHasta As System.Windows.Forms.Label
    Friend WithEvents lblDesde As System.Windows.Forms.Label
    Friend WithEvents lblTipoPago As System.Windows.Forms.Label
    Public WithEvents cmbTipoPago As System.Windows.Forms.ComboBox
    Friend WithEvents dgEventos As System.Windows.Forms.DataGridView
    Friend WithEvents lblResultados As System.Windows.Forms.Label
    Friend WithEvents btnOn1 As System.Windows.Forms.Button
    Friend WithEvents btnOn3 As System.Windows.Forms.Button
    Friend WithEvents btnOn2 As System.Windows.Forms.Button
    Friend WithEvents btnOn4 As System.Windows.Forms.Button
    Friend WithEvents lblRUNVendedor As System.Windows.Forms.Label
    Friend WithEvents txtRUNVendedor As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ReportedeventasTableAdapter1 As Teatro.TeatroDataSetTableAdapters.REPORTEDEVENTASTableAdapter
    Friend WithEvents TeatroDataSet As Teatro.TeatroDataSet
End Class
