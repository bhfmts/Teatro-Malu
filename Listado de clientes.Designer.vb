<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListadoClientes
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
        Me.rvListadoClientes = New Microsoft.Reporting.WinForms.ReportViewer
        Me.TeatroDataSet = New Teatro.TeatroDataSet
        Me.CLIENTESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CLIENTESTableAdapter = New Teatro.TeatroDataSetTableAdapters.CLIENTESTableAdapter
        CType(Me.TeatroDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CLIENTESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rvListadoClientes
        '
        Me.rvListadoClientes.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "TeatroDataSet_CLIENTES"
        ReportDataSource1.Value = Me.CLIENTESBindingSource
        Me.rvListadoClientes.LocalReport.DataSources.Add(ReportDataSource1)
        Me.rvListadoClientes.LocalReport.ReportEmbeddedResource = "Teatro.Listado clientes.rdlc"
        Me.rvListadoClientes.Location = New System.Drawing.Point(0, 0)
        Me.rvListadoClientes.Name = "rvListadoClientes"
        Me.rvListadoClientes.Size = New System.Drawing.Size(1041, 379)
        Me.rvListadoClientes.TabIndex = 1
        '
        'TeatroDataSet
        '
        Me.TeatroDataSet.DataSetName = "TeatroDataSet"
        Me.TeatroDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CLIENTESBindingSource
        '
        Me.CLIENTESBindingSource.DataMember = "CLIENTES"
        Me.CLIENTESBindingSource.DataSource = Me.TeatroDataSet
        '
        'CLIENTESTableAdapter
        '
        Me.CLIENTESTableAdapter.ClearBeforeFill = True
        '
        'frmListadoClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1041, 379)
        Me.Controls.Add(Me.rvListadoClientes)
        Me.Name = "frmListadoClientes"
        Me.Text = "Listado de clientes"
        Me.Controls.SetChildIndex(Me.rvListadoClientes, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        CType(Me.TeatroDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CLIENTESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rvListadoClientes As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents CLIENTESBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TeatroDataSet As Teatro.TeatroDataSet
    Friend WithEvents CLIENTESTableAdapter As Teatro.TeatroDataSetTableAdapters.CLIENTESTableAdapter
End Class
