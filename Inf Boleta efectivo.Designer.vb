<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBoletaEfectivo
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
        Me.BOLETAEFECTIVOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TeatroDataSet = New Teatro.TeatroDataSet
        Me.rvEfectivo = New Microsoft.Reporting.WinForms.ReportViewer
        Me.BOLETAEFECTIVOTableAdapter = New Teatro.TeatroDataSetTableAdapters.BOLETAEFECTIVOTableAdapter
        CType(Me.BOLETAEFECTIVOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TeatroDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BOLETAEFECTIVOBindingSource
        '
        Me.BOLETAEFECTIVOBindingSource.DataMember = "BOLETAEFECTIVO"
        Me.BOLETAEFECTIVOBindingSource.DataSource = Me.TeatroDataSet
        '
        'TeatroDataSet
        '
        Me.TeatroDataSet.DataSetName = "TeatroDataSet"
        Me.TeatroDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'rvEfectivo
        '
        Me.rvEfectivo.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "TeatroDataSet_BOLETAEFECTIVO"
        ReportDataSource1.Value = Me.BOLETAEFECTIVOBindingSource
        Me.rvEfectivo.LocalReport.DataSources.Add(ReportDataSource1)
        Me.rvEfectivo.LocalReport.ReportEmbeddedResource = "Teatro.Inf Boleta efectivo.rdlc"
        Me.rvEfectivo.Location = New System.Drawing.Point(0, 0)
        Me.rvEfectivo.Name = "rvEfectivo"
        Me.rvEfectivo.Size = New System.Drawing.Size(462, 429)
        Me.rvEfectivo.TabIndex = 1
        '
        'BOLETAEFECTIVOTableAdapter
        '
        Me.BOLETAEFECTIVOTableAdapter.ClearBeforeFill = True
        '
        'frmBoletaEfectivo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(462, 429)
        Me.Controls.Add(Me.rvEfectivo)
        Me.Name = "frmBoletaEfectivo"
        Me.Text = "Boleta efectivo"
        Me.Controls.SetChildIndex(Me.rvEfectivo, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        CType(Me.BOLETAEFECTIVOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TeatroDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rvEfectivo As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents BOLETAEFECTIVOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TeatroDataSet As Teatro.TeatroDataSet
    Friend WithEvents BOLETAEFECTIVOTableAdapter As Teatro.TeatroDataSetTableAdapters.BOLETAEFECTIVOTableAdapter
End Class
