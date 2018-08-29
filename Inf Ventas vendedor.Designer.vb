<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVentasVendedor
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Me.VENTASVENDEDORBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TeatroDataSet = New Teatro.TeatroDataSet
        Me.groRangoFechas = New System.Windows.Forms.GroupBox
        Me.btnGenerar = New System.Windows.Forms.Button
        Me.dtpHasta = New System.Windows.Forms.DateTimePicker
        Me.dtpDesde = New System.Windows.Forms.DateTimePicker
        Me.lblHasta = New System.Windows.Forms.Label
        Me.lblDesde = New System.Windows.Forms.Label
        Me.rvVentasVendedor = New Microsoft.Reporting.WinForms.ReportViewer
        Me.VENTASVENDEDORTableAdapter = New Teatro.TeatroDataSetTableAdapters.VENTASVENDEDORTableAdapter
        Me.VENTASENTRADASTableAdapter = New Teatro.TeatroDataSetTableAdapters.VENTASENTRADASTableAdapter
        CType(Me.VENTASVENDEDORBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TeatroDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groRangoFechas.SuspendLayout()
        Me.SuspendLayout()
        '
        'VENTASVENDEDORBindingSource
        '
        Me.VENTASVENDEDORBindingSource.DataMember = "VENTASVENDEDOR"
        Me.VENTASVENDEDORBindingSource.DataSource = Me.TeatroDataSet
        '
        'TeatroDataSet
        '
        Me.TeatroDataSet.DataSetName = "TeatroDataSet"
        Me.TeatroDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'groRangoFechas
        '
        Me.groRangoFechas.Controls.Add(Me.btnGenerar)
        Me.groRangoFechas.Controls.Add(Me.dtpHasta)
        Me.groRangoFechas.Controls.Add(Me.dtpDesde)
        Me.groRangoFechas.Controls.Add(Me.lblHasta)
        Me.groRangoFechas.Controls.Add(Me.lblDesde)
        Me.groRangoFechas.Location = New System.Drawing.Point(81, 12)
        Me.groRangoFechas.Name = "groRangoFechas"
        Me.groRangoFechas.Size = New System.Drawing.Size(672, 133)
        Me.groRangoFechas.TabIndex = 0
        Me.groRangoFechas.TabStop = False
        Me.groRangoFechas.Text = "Rango de fechas"
        '
        'btnGenerar
        '
        Me.btnGenerar.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnGenerar.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerar.Location = New System.Drawing.Point(556, 76)
        Me.btnGenerar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.Size = New System.Drawing.Size(90, 38)
        Me.btnGenerar.TabIndex = 16
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
        'rvVentasVendedor
        '
        ReportDataSource1.Name = "TeatroDataSet_VENTASVENDEDOR"
        ReportDataSource1.Value = Me.VENTASVENDEDORBindingSource
        Me.rvVentasVendedor.LocalReport.DataSources.Add(ReportDataSource1)
        Me.rvVentasVendedor.LocalReport.ReportEmbeddedResource = "Teatro.Ventas vendedor.rdlc"
        Me.rvVentasVendedor.Location = New System.Drawing.Point(21, 173)
        Me.rvVentasVendedor.Name = "rvVentasVendedor"
        Me.rvVentasVendedor.Size = New System.Drawing.Size(1038, 334)
        Me.rvVentasVendedor.TabIndex = 1
        '
        'VENTASVENDEDORTableAdapter
        '
        Me.VENTASVENDEDORTableAdapter.ClearBeforeFill = True
        '
        'VENTASENTRADASTableAdapter
        '
        Me.VENTASENTRADASTableAdapter.ClearBeforeFill = True
        '
        'frmVentasVendedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSlateGray
        Me.ClientSize = New System.Drawing.Size(1071, 517)
        Me.Controls.Add(Me.rvVentasVendedor)
        Me.Controls.Add(Me.groRangoFechas)
        Me.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmVentasVendedor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ventas vendedor"
        CType(Me.VENTASVENDEDORBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TeatroDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groRangoFechas.ResumeLayout(False)
        Me.groRangoFechas.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents groRangoFechas As System.Windows.Forms.GroupBox
    Friend WithEvents dtpHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblHasta As System.Windows.Forms.Label
    Friend WithEvents lblDesde As System.Windows.Forms.Label
    Friend WithEvents btnGenerar As System.Windows.Forms.Button
    Friend WithEvents rvVentasVendedor As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents VENTASVENDEDORBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TeatroDataSet As Teatro.TeatroDataSet
    Friend WithEvents VENTASVENDEDORTableAdapter As Teatro.TeatroDataSetTableAdapters.VENTASVENDEDORTableAdapter
    Friend WithEvents VENTASENTRADASTableAdapter As Teatro.TeatroDataSetTableAdapters.VENTASENTRADASTableAdapter
End Class
