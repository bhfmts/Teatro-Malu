<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVentasDiarias
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
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Me.VENTASDIARIASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TeatroDataSet = New Teatro.TeatroDataSet
        Me.VENTASENTRADASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.rvVentasDiarias = New Microsoft.Reporting.WinForms.ReportViewer
        Me.VENTASDIARIASTableAdapter = New Teatro.TeatroDataSetTableAdapters.VENTASDIARIASTableAdapter
        Me.VENTASENTRADASTableAdapter = New Teatro.TeatroDataSetTableAdapters.VENTASENTRADASTableAdapter
        CType(Me.VENTASDIARIASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TeatroDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VENTASENTRADASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'VENTASDIARIASBindingSource
        '
        Me.VENTASDIARIASBindingSource.DataMember = "VENTASDIARIAS"
        Me.VENTASDIARIASBindingSource.DataSource = Me.TeatroDataSet
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
        'rvVentasDiarias
        '
        Me.rvVentasDiarias.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "TeatroDataSet_VENTASDIARIAS"
        ReportDataSource1.Value = Me.VENTASDIARIASBindingSource
        ReportDataSource2.Name = "TeatroDataSet_VENTASENTRADAS"
        ReportDataSource2.Value = Me.VENTASENTRADASBindingSource
        Me.rvVentasDiarias.LocalReport.DataSources.Add(ReportDataSource1)
        Me.rvVentasDiarias.LocalReport.DataSources.Add(ReportDataSource2)
        Me.rvVentasDiarias.LocalReport.ReportEmbeddedResource = "Teatro.VentasDiarias.rdlc"
        Me.rvVentasDiarias.Location = New System.Drawing.Point(0, 0)
        Me.rvVentasDiarias.Name = "rvVentasDiarias"
        Me.rvVentasDiarias.Size = New System.Drawing.Size(1004, 570)
        Me.rvVentasDiarias.TabIndex = 50
        '
        'VENTASDIARIASTableAdapter
        '
        Me.VENTASDIARIASTableAdapter.ClearBeforeFill = True
        '
        'VENTASENTRADASTableAdapter
        '
        Me.VENTASENTRADASTableAdapter.ClearBeforeFill = True
        '
        'frmVentasDiarias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSlateGray
        Me.ClientSize = New System.Drawing.Size(1004, 570)
        Me.Controls.Add(Me.rvVentasDiarias)
        Me.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmVentasDiarias"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ventas diarias"
        CType(Me.VENTASDIARIASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TeatroDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VENTASENTRADASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents rvVentasDiarias As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents VENTASDIARIASBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TeatroDataSet As Teatro.TeatroDataSet
    Friend WithEvents VENTASENTRADASBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VENTASDIARIASTableAdapter As Teatro.TeatroDataSetTableAdapters.VENTASDIARIASTableAdapter
    Friend WithEvents VENTASENTRADASTableAdapter As Teatro.TeatroDataSetTableAdapters.VENTASENTRADASTableAdapter

End Class
