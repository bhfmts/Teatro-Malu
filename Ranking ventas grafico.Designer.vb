<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRankingVentasGrafico
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Me.REPORTEDEVENTASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TeatroDataSet = New Teatro.TeatroDataSet
        Me.VENTASENTRADASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.rvRankingGrafico = New Microsoft.Reporting.WinForms.ReportViewer
        Me.REPORTEDEVENTASTableAdapter = New Teatro.TeatroDataSetTableAdapters.REPORTEDEVENTASTableAdapter
        Me.VENTASENTRADASTableAdapter = New Teatro.TeatroDataSetTableAdapters.VENTASENTRADASTableAdapter
        Me.groIntervalo = New System.Windows.Forms.GroupBox
        Me.lblDesde = New System.Windows.Forms.Label
        Me.btnGenerar = New System.Windows.Forms.Button
        Me.lblHasta = New System.Windows.Forms.Label
        Me.dtpHasta = New System.Windows.Forms.DateTimePicker
        Me.dtpDesde = New System.Windows.Forms.DateTimePicker
        CType(Me.REPORTEDEVENTASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TeatroDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VENTASENTRADASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groIntervalo.SuspendLayout()
        Me.SuspendLayout()
        '
        'REPORTEDEVENTASBindingSource
        '
        Me.REPORTEDEVENTASBindingSource.DataMember = "REPORTEDEVENTAS"
        Me.REPORTEDEVENTASBindingSource.DataSource = Me.TeatroDataSet
        '
        'TeatroDataSet
        '
        Me.TeatroDataSet.DataSetName = "TeatroDataSet"
        Me.TeatroDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VENTASENTRADASBindingSource
        '
        Me.VENTASENTRADASBindingSource.DataMember = "VENTASENTRADAS"
        Me.VENTASENTRADASBindingSource.DataSource = Me.TeatroDataSet
        '
        'rvRankingGrafico
        '
        ReportDataSource1.Name = "TeatroDataSet_REPORTEDEVENTAS"
        ReportDataSource1.Value = Me.REPORTEDEVENTASBindingSource
        ReportDataSource2.Name = "TeatroDataSet_VENTASENTRADAS"
        ReportDataSource2.Value = Me.VENTASENTRADASBindingSource
        Me.rvRankingGrafico.LocalReport.DataSources.Add(ReportDataSource1)
        Me.rvRankingGrafico.LocalReport.DataSources.Add(ReportDataSource2)
        Me.rvRankingGrafico.LocalReport.ReportEmbeddedResource = "Teatro.Grafico.rdlc"
        Me.rvRankingGrafico.Location = New System.Drawing.Point(12, 173)
        Me.rvRankingGrafico.Name = "rvRankingGrafico"
        Me.rvRankingGrafico.Size = New System.Drawing.Size(900, 516)
        Me.rvRankingGrafico.TabIndex = 1
        '
        'REPORTEDEVENTASTableAdapter
        '
        Me.REPORTEDEVENTASTableAdapter.ClearBeforeFill = True
        '
        'VENTASENTRADASTableAdapter
        '
        Me.VENTASENTRADASTableAdapter.ClearBeforeFill = True
        '
        'groIntervalo
        '
        Me.groIntervalo.Controls.Add(Me.lblDesde)
        Me.groIntervalo.Controls.Add(Me.btnGenerar)
        Me.groIntervalo.Controls.Add(Me.lblHasta)
        Me.groIntervalo.Controls.Add(Me.dtpHasta)
        Me.groIntervalo.Controls.Add(Me.dtpDesde)
        Me.groIntervalo.Location = New System.Drawing.Point(12, 12)
        Me.groIntervalo.Name = "groIntervalo"
        Me.groIntervalo.Size = New System.Drawing.Size(550, 130)
        Me.groIntervalo.TabIndex = 15
        Me.groIntervalo.TabStop = False
        Me.groIntervalo.Text = "Intervalo de fechas"
        '
        'lblDesde
        '
        Me.lblDesde.AutoSize = True
        Me.lblDesde.ForeColor = System.Drawing.Color.White
        Me.lblDesde.Location = New System.Drawing.Point(21, 42)
        Me.lblDesde.Name = "lblDesde"
        Me.lblDesde.Size = New System.Drawing.Size(53, 16)
        Me.lblDesde.TabIndex = 4
        Me.lblDesde.Text = "Desde"
        '
        'btnGenerar
        '
        Me.btnGenerar.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnGenerar.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerar.Location = New System.Drawing.Point(421, 78)
        Me.btnGenerar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.Size = New System.Drawing.Size(90, 38)
        Me.btnGenerar.TabIndex = 15
        Me.btnGenerar.Text = "Generar"
        Me.btnGenerar.UseVisualStyleBackColor = False
        '
        'lblHasta
        '
        Me.lblHasta.AutoSize = True
        Me.lblHasta.ForeColor = System.Drawing.Color.White
        Me.lblHasta.Location = New System.Drawing.Point(279, 42)
        Me.lblHasta.Name = "lblHasta"
        Me.lblHasta.Size = New System.Drawing.Size(51, 16)
        Me.lblHasta.TabIndex = 3
        Me.lblHasta.Text = "Hasta"
        '
        'dtpHasta
        '
        Me.dtpHasta.Location = New System.Drawing.Point(340, 37)
        Me.dtpHasta.Name = "dtpHasta"
        Me.dtpHasta.Size = New System.Drawing.Size(171, 23)
        Me.dtpHasta.TabIndex = 6
        '
        'dtpDesde
        '
        Me.dtpDesde.Location = New System.Drawing.Point(81, 37)
        Me.dtpDesde.Name = "dtpDesde"
        Me.dtpDesde.Size = New System.Drawing.Size(178, 23)
        Me.dtpDesde.TabIndex = 5
        '
        'frmRankingVentasGrafico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(924, 701)
        Me.Controls.Add(Me.groIntervalo)
        Me.Controls.Add(Me.rvRankingGrafico)
        Me.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.Name = "frmRankingVentasGrafico"
        Me.Text = "Gráfico ranking de ventas"
        Me.Controls.SetChildIndex(Me.rvRankingGrafico, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.groIntervalo, 0)
        CType(Me.REPORTEDEVENTASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TeatroDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VENTASENTRADASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groIntervalo.ResumeLayout(False)
        Me.groIntervalo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rvRankingGrafico As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents REPORTEDEVENTASBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TeatroDataSet As Teatro.TeatroDataSet
    Friend WithEvents VENTASENTRADASBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents REPORTEDEVENTASTableAdapter As Teatro.TeatroDataSetTableAdapters.REPORTEDEVENTASTableAdapter
    Friend WithEvents VENTASENTRADASTableAdapter As Teatro.TeatroDataSetTableAdapters.VENTASENTRADASTableAdapter
    Friend WithEvents groIntervalo As System.Windows.Forms.GroupBox
    Friend WithEvents lblDesde As System.Windows.Forms.Label
    Friend WithEvents btnGenerar As System.Windows.Forms.Button
    Friend WithEvents lblHasta As System.Windows.Forms.Label
    Friend WithEvents dtpHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpDesde As System.Windows.Forms.DateTimePicker
End Class
