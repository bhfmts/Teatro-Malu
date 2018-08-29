<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVentasPorRUNVendedorTipoEntradaFormaPagoYFechas
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
        Me.rvVentasPorRUNVendedorTipoEntradaFormaPagoYFechas = New Microsoft.Reporting.WinForms.ReportViewer
        Me.TeatroDataSet = New Teatro.TeatroDataSet
        Me.REPORTEDEVENTASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.REPORTEDEVENTASTableAdapter = New Teatro.TeatroDataSetTableAdapters.REPORTEDEVENTASTableAdapter
        CType(Me.TeatroDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REPORTEDEVENTASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rvVentasPorRUNVendedorTipoEntradaFormaPagoYFechas
        '
        Me.rvVentasPorRUNVendedorTipoEntradaFormaPagoYFechas.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "TeatroDataSet_REPORTEDEVENTAS"
        ReportDataSource1.Value = Me.REPORTEDEVENTASBindingSource
        Me.rvVentasPorRUNVendedorTipoEntradaFormaPagoYFechas.LocalReport.DataSources.Add(ReportDataSource1)
        Me.rvVentasPorRUNVendedorTipoEntradaFormaPagoYFechas.LocalReport.ReportEmbeddedResource = "Teatro.VentasPorRUNVendedorTipoEntradaFormaPagoYFechas.rdlc"
        Me.rvVentasPorRUNVendedorTipoEntradaFormaPagoYFechas.Location = New System.Drawing.Point(0, 0)
        Me.rvVentasPorRUNVendedorTipoEntradaFormaPagoYFechas.Name = "rvVentasPorRUNVendedorTipoEntradaFormaPagoYFechas"
        Me.rvVentasPorRUNVendedorTipoEntradaFormaPagoYFechas.Size = New System.Drawing.Size(1162, 434)
        Me.rvVentasPorRUNVendedorTipoEntradaFormaPagoYFechas.TabIndex = 1
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
        'frmVentasPorRUNVendedorTipoEntradaFormaPagoYFechas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1162, 434)
        Me.Controls.Add(Me.rvVentasPorRUNVendedorTipoEntradaFormaPagoYFechas)
        Me.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.Name = "frmVentasPorRUNVendedorTipoEntradaFormaPagoYFechas"
        Me.Text = "Reporte de ventas por vendedor, tipo entrada, forma pago e intervalo de fechas"
        Me.Controls.SetChildIndex(Me.rvVentasPorRUNVendedorTipoEntradaFormaPagoYFechas, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        CType(Me.TeatroDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REPORTEDEVENTASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rvVentasPorRUNVendedorTipoEntradaFormaPagoYFechas As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents REPORTEDEVENTASBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TeatroDataSet As Teatro.TeatroDataSet
    Friend WithEvents REPORTEDEVENTASTableAdapter As Teatro.TeatroDataSetTableAdapters.REPORTEDEVENTASTableAdapter
End Class
