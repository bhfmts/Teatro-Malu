<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBoletaTarjeta
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
        Me.BOLETATARJETABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TeatroDataSet = New Teatro.TeatroDataSet
        Me.rvTarjeta = New Microsoft.Reporting.WinForms.ReportViewer
        Me.BOLETATARJETATableAdapter = New Teatro.TeatroDataSetTableAdapters.BOLETATARJETATableAdapter
        CType(Me.BOLETATARJETABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TeatroDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BOLETATARJETABindingSource
        '
        Me.BOLETATARJETABindingSource.DataMember = "BOLETATARJETA"
        Me.BOLETATARJETABindingSource.DataSource = Me.TeatroDataSet
        '
        'TeatroDataSet
        '
        Me.TeatroDataSet.DataSetName = "TeatroDataSet"
        Me.TeatroDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'rvTarjeta
        '
        Me.rvTarjeta.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "TeatroDataSet_BOLETATARJETA"
        ReportDataSource1.Value = Me.BOLETATARJETABindingSource
        Me.rvTarjeta.LocalReport.DataSources.Add(ReportDataSource1)
        Me.rvTarjeta.LocalReport.ReportEmbeddedResource = "Teatro.Inf Boleta tarjeta.rdlc"
        Me.rvTarjeta.Location = New System.Drawing.Point(0, 0)
        Me.rvTarjeta.Name = "rvTarjeta"
        Me.rvTarjeta.Size = New System.Drawing.Size(473, 429)
        Me.rvTarjeta.TabIndex = 1
        '
        'BOLETATARJETATableAdapter
        '
        Me.BOLETATARJETATableAdapter.ClearBeforeFill = True
        '
        'frmBoletaTarjeta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(473, 429)
        Me.Controls.Add(Me.rvTarjeta)
        Me.Name = "frmBoletaTarjeta"
        Me.Text = "Boleta tarjeta"
        Me.Controls.SetChildIndex(Me.rvTarjeta, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        CType(Me.BOLETATARJETABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TeatroDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rvTarjeta As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents BOLETATARJETABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TeatroDataSet As Teatro.TeatroDataSet
    Friend WithEvents BOLETATARJETATableAdapter As Teatro.TeatroDataSetTableAdapters.BOLETATARJETATableAdapter
End Class
