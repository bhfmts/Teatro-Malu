<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEntradas
    Inherits Teatro.frmModelo

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
        Me.VENTASENTRADASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TeatroDataSet = New Teatro.TeatroDataSet
        Me.ENTRADASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.rvEntradas = New Microsoft.Reporting.WinForms.ReportViewer
        Me.VENTASENTRADASTableAdapter = New Teatro.TeatroDataSetTableAdapters.VENTASENTRADASTableAdapter
        Me.ENTRADASTableAdapter = New Teatro.TeatroDataSetTableAdapters.ENTRADASTableAdapter
        CType(Me.VENTASENTRADASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TeatroDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ENTRADASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'VENTASENTRADASBindingSource
        '
        Me.VENTASENTRADASBindingSource.DataMember = "VENTASENTRADAS"
        Me.VENTASENTRADASBindingSource.DataSource = Me.TeatroDataSet
        '
        'TeatroDataSet
        '
        Me.TeatroDataSet.DataSetName = "TeatroDataSet"
        Me.TeatroDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ENTRADASBindingSource
        '
        Me.ENTRADASBindingSource.DataMember = "ENTRADAS"
        Me.ENTRADASBindingSource.DataSource = Me.TeatroDataSet
        '
        'rvEntradas
        '
        Me.rvEntradas.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "TeatroDataSet_VENTASENTRADAS"
        ReportDataSource1.Value = Me.VENTASENTRADASBindingSource
        ReportDataSource2.Name = "TeatroDataSet_ENTRADAS"
        ReportDataSource2.Value = Me.ENTRADASBindingSource
        Me.rvEntradas.LocalReport.DataSources.Add(ReportDataSource1)
        Me.rvEntradas.LocalReport.DataSources.Add(ReportDataSource2)
        Me.rvEntradas.LocalReport.ReportEmbeddedResource = "Teatro.Entradas.rdlc"
        Me.rvEntradas.Location = New System.Drawing.Point(0, 0)
        Me.rvEntradas.Name = "rvEntradas"
        Me.rvEntradas.Size = New System.Drawing.Size(1052, 411)
        Me.rvEntradas.TabIndex = 1
        '
        'VENTASENTRADASTableAdapter
        '
        Me.VENTASENTRADASTableAdapter.ClearBeforeFill = True
        '
        'ENTRADASTableAdapter
        '
        Me.ENTRADASTableAdapter.ClearBeforeFill = True
        '
        'frmEntradas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1052, 411)
        Me.Controls.Add(Me.rvEntradas)
        Me.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.Name = "frmEntradas"
        Me.Text = "Entradas"
        Me.Controls.SetChildIndex(Me.rvEntradas, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        CType(Me.VENTASENTRADASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TeatroDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ENTRADASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rvEntradas As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents VENTASENTRADASBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TeatroDataSet As Teatro.TeatroDataSet
    Friend WithEvents ENTRADASBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VENTASENTRADASTableAdapter As Teatro.TeatroDataSetTableAdapters.VENTASENTRADASTableAdapter
    Friend WithEvents ENTRADASTableAdapter As Teatro.TeatroDataSetTableAdapters.ENTRADASTableAdapter
End Class
