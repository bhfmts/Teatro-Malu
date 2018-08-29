<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListadoProductores
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
        Me.PRODUCCIONBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TeatroDataSet = New Teatro.TeatroDataSet
        Me.rvListadoProductores = New Microsoft.Reporting.WinForms.ReportViewer
        Me.PRODUCCIONTableAdapter = New Teatro.TeatroDataSetTableAdapters.PRODUCCIONTableAdapter
        CType(Me.PRODUCCIONBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TeatroDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PRODUCCIONBindingSource
        '
        Me.PRODUCCIONBindingSource.DataMember = "PRODUCCION"
        Me.PRODUCCIONBindingSource.DataSource = Me.TeatroDataSet
        '
        'TeatroDataSet
        '
        Me.TeatroDataSet.DataSetName = "TeatroDataSet"
        Me.TeatroDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'rvListadoProductores
        '
        Me.rvListadoProductores.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "TeatroDataSet_PRODUCCION"
        ReportDataSource1.Value = Me.PRODUCCIONBindingSource
        Me.rvListadoProductores.LocalReport.DataSources.Add(ReportDataSource1)
        Me.rvListadoProductores.LocalReport.ReportEmbeddedResource = "Teatro.Listado de productores.rdlc"
        Me.rvListadoProductores.Location = New System.Drawing.Point(0, 0)
        Me.rvListadoProductores.Name = "rvListadoProductores"
        Me.rvListadoProductores.Size = New System.Drawing.Size(1041, 400)
        Me.rvListadoProductores.TabIndex = 1
        '
        'PRODUCCIONTableAdapter
        '
        Me.PRODUCCIONTableAdapter.ClearBeforeFill = True
        '
        'frmListadoProductores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1041, 400)
        Me.Controls.Add(Me.rvListadoProductores)
        Me.Name = "frmListadoProductores"
        Me.Text = "Listado de productores"
        Me.Controls.SetChildIndex(Me.rvListadoProductores, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        CType(Me.PRODUCCIONBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TeatroDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rvListadoProductores As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents PRODUCCIONBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TeatroDataSet As Teatro.TeatroDataSet
    Friend WithEvents PRODUCCIONTableAdapter As Teatro.TeatroDataSetTableAdapters.PRODUCCIONTableAdapter
End Class
