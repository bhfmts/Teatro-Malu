<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListadoVendedores
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
        Me.VENDEDORESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TeatroDataSet = New Teatro.TeatroDataSet
        Me.rvListadoVendedores = New Microsoft.Reporting.WinForms.ReportViewer
        Me.VendedoresTableAdapter1 = New Teatro.TeatroDataSetTableAdapters.VENDEDORESTableAdapter
        Me.VENDEDORESTableAdapter = New Teatro.TeatroDataSetTableAdapters.VENDEDORESTableAdapter
        CType(Me.VENDEDORESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TeatroDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'VENDEDORESBindingSource
        '
        Me.VENDEDORESBindingSource.DataMember = "VENDEDORES"
        Me.VENDEDORESBindingSource.DataSource = Me.TeatroDataSet
        '
        'TeatroDataSet
        '
        Me.TeatroDataSet.DataSetName = "TeatroDataSet"
        Me.TeatroDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'rvListadoVendedores
        '
        Me.rvListadoVendedores.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "TeatroDataSet_VENDEDORES"
        ReportDataSource1.Value = Me.VENDEDORESBindingSource
        Me.rvListadoVendedores.LocalReport.DataSources.Add(ReportDataSource1)
        Me.rvListadoVendedores.LocalReport.ReportEmbeddedResource = "Teatro.Listado vendedores.rdlc"
        Me.rvListadoVendedores.Location = New System.Drawing.Point(0, 0)
        Me.rvListadoVendedores.Name = "rvListadoVendedores"
        Me.rvListadoVendedores.Size = New System.Drawing.Size(1041, 379)
        Me.rvListadoVendedores.TabIndex = 0
        '
        'VendedoresTableAdapter1
        '
        Me.VendedoresTableAdapter1.ClearBeforeFill = True
        '
        'VENDEDORESTableAdapter
        '
        Me.VENDEDORESTableAdapter.ClearBeforeFill = True
        '
        'frmListadoVendedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSlateGray
        Me.ClientSize = New System.Drawing.Size(1041, 379)
        Me.Controls.Add(Me.rvListadoVendedores)
        Me.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmListadoVendedores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Listado de vendedores"
        CType(Me.VENDEDORESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TeatroDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents rvListadoVendedores As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents VendedoresTableAdapter1 As Teatro.TeatroDataSetTableAdapters.VENDEDORESTableAdapter
    Friend WithEvents TeatroDataSet As Teatro.TeatroDataSet
    Friend WithEvents VENDEDORESBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VENDEDORESTableAdapter As Teatro.TeatroDataSetTableAdapters.VENDEDORESTableAdapter
End Class
