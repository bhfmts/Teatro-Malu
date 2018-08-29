<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListadoAdministradores
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
        Me.ADMINISTRADORESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TeatroDataSet = New Teatro.TeatroDataSet
        Me.rvListadoAdministradores = New Microsoft.Reporting.WinForms.ReportViewer
        Me.ADMINISTRADORESTableAdapter = New Teatro.TeatroDataSetTableAdapters.ADMINISTRADORESTableAdapter
        CType(Me.ADMINISTRADORESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TeatroDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ADMINISTRADORESBindingSource
        '
        Me.ADMINISTRADORESBindingSource.DataMember = "ADMINISTRADORES"
        Me.ADMINISTRADORESBindingSource.DataSource = Me.TeatroDataSet
        '
        'TeatroDataSet
        '
        Me.TeatroDataSet.DataSetName = "TeatroDataSet"
        Me.TeatroDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'rvListadoAdministradores
        '
        Me.rvListadoAdministradores.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "TeatroDataSet_ADMINISTRADORES"
        ReportDataSource1.Value = Me.ADMINISTRADORESBindingSource
        Me.rvListadoAdministradores.LocalReport.DataSources.Add(ReportDataSource1)
        Me.rvListadoAdministradores.LocalReport.ReportEmbeddedResource = "Teatro.Listado de administradores.rdlc"
        Me.rvListadoAdministradores.Location = New System.Drawing.Point(0, 0)
        Me.rvListadoAdministradores.Name = "rvListadoAdministradores"
        Me.rvListadoAdministradores.Size = New System.Drawing.Size(1041, 357)
        Me.rvListadoAdministradores.TabIndex = 1
        '
        'ADMINISTRADORESTableAdapter
        '
        Me.ADMINISTRADORESTableAdapter.ClearBeforeFill = True
        '
        'frmListadoAdministradores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1041, 357)
        Me.Controls.Add(Me.rvListadoAdministradores)
        Me.Name = "frmListadoAdministradores"
        Me.Text = "Listado de administradores"
        Me.Controls.SetChildIndex(Me.rvListadoAdministradores, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        CType(Me.ADMINISTRADORESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TeatroDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rvListadoAdministradores As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ADMINISTRADORESBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TeatroDataSet As Teatro.TeatroDataSet
    Friend WithEvents ADMINISTRADORESTableAdapter As Teatro.TeatroDataSetTableAdapters.ADMINISTRADORESTableAdapter
End Class
