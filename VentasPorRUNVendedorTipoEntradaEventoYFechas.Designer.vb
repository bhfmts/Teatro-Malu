<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVentasPorRUNVendedorTipoEntradaEventoYFechas
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
        Me.rvrPorRUNVendedorTipoEntradaEventoYFechas = New Microsoft.Reporting.WinForms.ReportViewer
        Me.REPORTEDEVENTASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TeatroDataSet = New Teatro.TeatroDataSet
        Me.REPORTEDEVENTASTableAdapter = New Teatro.TeatroDataSetTableAdapters.REPORTEDEVENTASTableAdapter
        CType(Me.REPORTEDEVENTASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TeatroDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rvrPorRUNVendedorTipoEntradaEventoYFechas
        '
        Me.rvrPorRUNVendedorTipoEntradaEventoYFechas.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "TeatroDataSet_REPORTEDEVENTAS"
        ReportDataSource1.Value = Me.REPORTEDEVENTASBindingSource
        Me.rvrPorRUNVendedorTipoEntradaEventoYFechas.LocalReport.DataSources.Add(ReportDataSource1)
        Me.rvrPorRUNVendedorTipoEntradaEventoYFechas.LocalReport.ReportEmbeddedResource = "Teatro.VentasPorRUNVendedorTipoEntradaEventoYFechas.rdlc"
        Me.rvrPorRUNVendedorTipoEntradaEventoYFechas.Location = New System.Drawing.Point(0, 0)
        Me.rvrPorRUNVendedorTipoEntradaEventoYFechas.Name = "rvrPorRUNVendedorTipoEntradaEventoYFechas"
        Me.rvrPorRUNVendedorTipoEntradaEventoYFechas.Size = New System.Drawing.Size(1152, 424)
        Me.rvrPorRUNVendedorTipoEntradaEventoYFechas.TabIndex = 0
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
        'REPORTEDEVENTASTableAdapter
        '
        Me.REPORTEDEVENTASTableAdapter.ClearBeforeFill = True
        '
        'frmVentasPorRUNVendedorTipoEntradaEventoYFechas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1152, 424)
        Me.Controls.Add(Me.rvrPorRUNVendedorTipoEntradaEventoYFechas)
        Me.Name = "frmVentasPorRUNVendedorTipoEntradaEventoYFechas"
        Me.Text = "Reporte de ventas por vendedor, tipo entrada, evento e intervalo de fechas"
        CType(Me.REPORTEDEVENTASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TeatroDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents rvrPorRUNVendedorTipoEntradaEventoYFechas As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents REPORTEDEVENTASBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TeatroDataSet As Teatro.TeatroDataSet
    Friend WithEvents REPORTEDEVENTASTableAdapter As Teatro.TeatroDataSetTableAdapters.REPORTEDEVENTASTableAdapter
End Class
