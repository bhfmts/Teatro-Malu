<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultarDisponibilidad
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
        Me.components = New System.ComponentModel.Container
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.groParametros = New System.Windows.Forms.GroupBox
        Me.dgEventos = New System.Windows.Forms.DataGridView
        Me.IDEVENTODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NOMBREEVENTODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FECHAEVENTODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ENTRADAGENERALDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.RUNENCARGADODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EVENTOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TeatroDataSet = New Teatro.TeatroDataSet
        Me.btnConsultar = New System.Windows.Forms.Button
        Me.lblJornada = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker
        Me.cmbJornada = New System.Windows.Forms.ComboBox
        Me.EventosjornadasTableAdapter1 = New Teatro.TeatroDataSetTableAdapters.EVENTOSJORNADASTableAdapter
        Me.EventosTableAdapter1 = New Teatro.TeatroDataSetTableAdapters.EVENTOSTableAdapter
        Me.ErrorProviderDisponibilidad = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.groParametros.SuspendLayout()
        CType(Me.dgEventos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EVENTOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TeatroDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProviderDisponibilidad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'groParametros
        '
        Me.groParametros.Controls.Add(Me.dgEventos)
        Me.groParametros.Controls.Add(Me.btnConsultar)
        Me.groParametros.Controls.Add(Me.lblJornada)
        Me.groParametros.Controls.Add(Me.Label2)
        Me.groParametros.Controls.Add(Me.dtpFecha)
        Me.groParametros.Controls.Add(Me.cmbJornada)
        Me.groParametros.Location = New System.Drawing.Point(12, 12)
        Me.groParametros.Name = "groParametros"
        Me.groParametros.Size = New System.Drawing.Size(928, 184)
        Me.groParametros.TabIndex = 1
        Me.groParametros.TabStop = False
        Me.groParametros.Text = "Parámetros"
        '
        'dgEventos
        '
        Me.dgEventos.AllowUserToAddRows = False
        Me.dgEventos.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.dgEventos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgEventos.AutoGenerateColumns = False
        Me.dgEventos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgEventos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgEventos.BackgroundColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgEventos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgEventos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgEventos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDEVENTODataGridViewTextBoxColumn, Me.NOMBREEVENTODataGridViewTextBoxColumn, Me.FECHAEVENTODataGridViewTextBoxColumn, Me.ENTRADAGENERALDataGridViewTextBoxColumn, Me.RUNENCARGADODataGridViewTextBoxColumn})
        Me.dgEventos.DataSource = Me.EVENTOSBindingSource
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgEventos.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgEventos.Location = New System.Drawing.Point(228, 26)
        Me.dgEventos.Name = "dgEventos"
        Me.dgEventos.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgEventos.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.dgEventos.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgEventos.Size = New System.Drawing.Size(655, 65)
        Me.dgEventos.TabIndex = 16
        '
        'IDEVENTODataGridViewTextBoxColumn
        '
        Me.IDEVENTODataGridViewTextBoxColumn.DataPropertyName = "IDEVENTO"
        Me.IDEVENTODataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDEVENTODataGridViewTextBoxColumn.Name = "IDEVENTODataGridViewTextBoxColumn"
        Me.IDEVENTODataGridViewTextBoxColumn.ReadOnly = True
        '
        'NOMBREEVENTODataGridViewTextBoxColumn
        '
        Me.NOMBREEVENTODataGridViewTextBoxColumn.DataPropertyName = "NOMBREEVENTO"
        Me.NOMBREEVENTODataGridViewTextBoxColumn.HeaderText = "Evento"
        Me.NOMBREEVENTODataGridViewTextBoxColumn.Name = "NOMBREEVENTODataGridViewTextBoxColumn"
        Me.NOMBREEVENTODataGridViewTextBoxColumn.ReadOnly = True
        '
        'FECHAEVENTODataGridViewTextBoxColumn
        '
        Me.FECHAEVENTODataGridViewTextBoxColumn.DataPropertyName = "FECHAEVENTO"
        Me.FECHAEVENTODataGridViewTextBoxColumn.HeaderText = "Fecha"
        Me.FECHAEVENTODataGridViewTextBoxColumn.Name = "FECHAEVENTODataGridViewTextBoxColumn"
        Me.FECHAEVENTODataGridViewTextBoxColumn.ReadOnly = True
        '
        'ENTRADAGENERALDataGridViewTextBoxColumn
        '
        Me.ENTRADAGENERALDataGridViewTextBoxColumn.DataPropertyName = "ENTRADAGENERAL"
        Me.ENTRADAGENERALDataGridViewTextBoxColumn.HeaderText = "Precio"
        Me.ENTRADAGENERALDataGridViewTextBoxColumn.Name = "ENTRADAGENERALDataGridViewTextBoxColumn"
        Me.ENTRADAGENERALDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RUNENCARGADODataGridViewTextBoxColumn
        '
        Me.RUNENCARGADODataGridViewTextBoxColumn.DataPropertyName = "RUNENCARGADO"
        Me.RUNENCARGADODataGridViewTextBoxColumn.HeaderText = "Encargado"
        Me.RUNENCARGADODataGridViewTextBoxColumn.Name = "RUNENCARGADODataGridViewTextBoxColumn"
        Me.RUNENCARGADODataGridViewTextBoxColumn.ReadOnly = True
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
        'btnConsultar
        '
        Me.btnConsultar.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnConsultar.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConsultar.Location = New System.Drawing.Point(111, 119)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(100, 34)
        Me.btnConsultar.TabIndex = 15
        Me.btnConsultar.Text = "Consultar"
        Me.btnConsultar.UseVisualStyleBackColor = False
        '
        'lblJornada
        '
        Me.lblJornada.AutoSize = True
        Me.lblJornada.Location = New System.Drawing.Point(19, 75)
        Me.lblJornada.Name = "lblJornada"
        Me.lblJornada.Size = New System.Drawing.Size(66, 16)
        Me.lblJornada.TabIndex = 2
        Me.lblJornada.Text = "Jornada"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Fecha"
        '
        'dtpFecha
        '
        Me.dtpFecha.Location = New System.Drawing.Point(90, 31)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(121, 23)
        Me.dtpFecha.TabIndex = 1
        '
        'cmbJornada
        '
        Me.cmbJornada.FormattingEnabled = True
        Me.cmbJornada.Items.AddRange(New Object() {"MATINÉ", "TARDE", "NOCHE"})
        Me.cmbJornada.Location = New System.Drawing.Point(90, 72)
        Me.cmbJornada.Name = "cmbJornada"
        Me.cmbJornada.Size = New System.Drawing.Size(121, 24)
        Me.cmbJornada.TabIndex = 0
        '
        'EventosjornadasTableAdapter1
        '
        Me.EventosjornadasTableAdapter1.ClearBeforeFill = True
        '
        'EventosTableAdapter1
        '
        Me.EventosTableAdapter1.ClearBeforeFill = True
        '
        'ErrorProviderDisponibilidad
        '
        Me.ErrorProviderDisponibilidad.ContainerControl = Me
        '
        'frmConsultarDisponibilidad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(952, 215)
        Me.Controls.Add(Me.groParametros)
        Me.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.Name = "frmConsultarDisponibilidad"
        Me.Text = "Consultar disponibilidad"
        Me.Controls.SetChildIndex(Me.groParametros, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.groParametros.ResumeLayout(False)
        Me.groParametros.PerformLayout()
        CType(Me.dgEventos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EVENTOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TeatroDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProviderDisponibilidad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents groParametros As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbJornada As System.Windows.Forms.ComboBox
    Friend WithEvents lblJornada As System.Windows.Forms.Label
    Friend WithEvents btnConsultar As System.Windows.Forms.Button
    Friend WithEvents dgEventos As System.Windows.Forms.DataGridView
    Friend WithEvents EventosjornadasTableAdapter1 As Teatro.TeatroDataSetTableAdapters.EVENTOSJORNADASTableAdapter
    Friend WithEvents EventosTableAdapter1 As Teatro.TeatroDataSetTableAdapters.EVENTOSTableAdapter
    Friend WithEvents EVENTOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TeatroDataSet As Teatro.TeatroDataSet
    Friend WithEvents IDEVENTODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOMBREEVENTODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FECHAEVENTODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ENTRADAGENERALDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RUNENCARGADODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ErrorProviderDisponibilidad As System.Windows.Forms.ErrorProvider
End Class
