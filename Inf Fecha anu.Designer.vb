<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFechaAnu
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
        Me.ANULACIONVENTASPEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TeatroDataSet = New Teatro.TeatroDataSet
        Me.rvFechaAnu = New Microsoft.Reporting.WinForms.ReportViewer
        Me.ANULACIONVENTASPETableAdapter = New Teatro.TeatroDataSetTableAdapters.ANULACIONVENTASPETableAdapter
        CType(Me.ANULACIONVENTASPEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TeatroDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ANULACIONVENTASPEBindingSource
        '
        Me.ANULACIONVENTASPEBindingSource.DataMember = "ANULACIONVENTASPE"
        Me.ANULACIONVENTASPEBindingSource.DataSource = Me.TeatroDataSet
        '
        'TeatroDataSet
        '
        Me.TeatroDataSet.DataSetName = "TeatroDataSet"
        Me.TeatroDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'rvFechaAnu
        '
        Me.rvFechaAnu.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "TeatroDataSet_ANULACIONVENTASPE"
        ReportDataSource1.Value = Me.ANULACIONVENTASPEBindingSource
        Me.rvFechaAnu.LocalReport.DataSources.Add(ReportDataSource1)
        Me.rvFechaAnu.LocalReport.ReportEmbeddedResource = "Teatro.Inf Fecha anu.rdlc"
        Me.rvFechaAnu.Location = New System.Drawing.Point(0, 0)
        Me.rvFechaAnu.Name = "rvFechaAnu"
        Me.rvFechaAnu.Size = New System.Drawing.Size(1124, 499)
        Me.rvFechaAnu.TabIndex = 1
        '
        'ANULACIONVENTASPETableAdapter
        '
        Me.ANULACIONVENTASPETableAdapter.ClearBeforeFill = True
        '
        'frmFechaAnu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1124, 499)
        Me.Controls.Add(Me.rvFechaAnu)
        Me.Name = "frmFechaAnu"
        Me.Text = "Informe por fecha de anulación"
        Me.Controls.SetChildIndex(Me.rvFechaAnu, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        CType(Me.ANULACIONVENTASPEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TeatroDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rvFechaAnu As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ANULACIONVENTASPEBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TeatroDataSet As Teatro.TeatroDataSet
    Friend WithEvents ANULACIONVENTASPETableAdapter As Teatro.TeatroDataSetTableAdapters.ANULACIONVENTASPETableAdapter
End Class
