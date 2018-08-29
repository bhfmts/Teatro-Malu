<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVentasPorTipoEntradaFormaPagoEventoYFechas
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
        Me.rvVentasPorTipoEntradaFormaPagoEventoYFechas = New Microsoft.Reporting.WinForms.ReportViewer
        Me.TeatroDataSet = New Teatro.TeatroDataSet
        Me.REPORTEDEVENTASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.REPORTEDEVENTASTableAdapter = New Teatro.TeatroDataSetTableAdapters.REPORTEDEVENTASTableAdapter
        CType(Me.TeatroDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REPORTEDEVENTASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rvVentasPorTipoEntradaFormaPagoEventoYFechas
        '
        Me.rvVentasPorTipoEntradaFormaPagoEventoYFechas.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "TeatroDataSet_REPORTEDEVENTAS"
        ReportDataSource1.Value = Me.REPORTEDEVENTASBindingSource
        Me.rvVentasPorTipoEntradaFormaPagoEventoYFechas.LocalReport.DataSources.Add(ReportDataSource1)
        Me.rvVentasPorTipoEntradaFormaPagoEventoYFechas.LocalReport.ReportEmbeddedResource = "Teatro.VentasPorTipoEntradaFormaPagoEventoYFechas.rdlc"
        Me.rvVentasPorTipoEntradaFormaPagoEventoYFechas.Location = New System.Drawing.Point(0, 0)
        Me.rvVentasPorTipoEntradaFormaPagoEventoYFechas.Name = "rvVentasPorTipoEntradaFormaPagoEventoYFechas"
        Me.rvVentasPorTipoEntradaFormaPagoEventoYFechas.Size = New System.Drawing.Size(1162, 434)
        Me.rvVentasPorTipoEntradaFormaPagoEventoYFechas.TabIndex = 1
        '
        'TeatroDataSet
        '
        Me.TeatroDataSet.DataSetName = "TeatroDataSet"
        Me.TeatroDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'REPORTEDEVENTASBindingSource
        '
        Me.REPORTEDEVENTASBindingSource.DataMember = "REPORTEDEVENTAS"
        Me.REPORTEDEVENTASBindingSource.DataSource = Me.TeatroDataSet
        '
        'REPORTEDEVENTASTableAdapter
        '
        Me.REPORTEDEVENTASTableAdapter.ClearBeforeFill = True
        '
        'frmVentasPorTipoEntradaFormaPagoEventoYFechas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1162, 434)
        Me.Controls.Add(Me.rvVentasPorTipoEntradaFormaPagoEventoYFechas)
        Me.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.Name = "frmVentasPorTipoEntradaFormaPagoEventoYFechas"
        Me.Text = "Reporte de ventas por tipo entrada, forma pago , evento e intervalo de fechas"
        Me.Controls.SetChildIndex(Me.rvVentasPorTipoEntradaFormaPagoEventoYFechas, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        CType(Me.TeatroDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REPORTEDEVENTASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rvVentasPorTipoEntradaFormaPagoEventoYFechas As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents REPORTEDEVENTASBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TeatroDataSet As Teatro.TeatroDataSet
    Friend WithEvents REPORTEDEVENTASTableAdapter As Teatro.TeatroDataSetTableAdapters.REPORTEDEVENTASTableAdapter
End Class
