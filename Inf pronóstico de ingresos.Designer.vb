<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInfPronosticoIngresos
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
        Me.rvPronosticoIngresos = New Microsoft.Reporting.WinForms.ReportViewer
        Me.SuspendLayout()
        '
        'rvPronosticoIngresos
        '
        Me.rvPronosticoIngresos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rvPronosticoIngresos.LocalReport.ReportEmbeddedResource = "Teatro.Pronóstico de ingresos.rdlc"
        Me.rvPronosticoIngresos.Location = New System.Drawing.Point(0, 0)
        Me.rvPronosticoIngresos.Name = "rvPronosticoIngresos"
        Me.rvPronosticoIngresos.Size = New System.Drawing.Size(638, 444)
        Me.rvPronosticoIngresos.TabIndex = 1
        '
        'frmInfPronosticoIngresos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(638, 444)
        Me.Controls.Add(Me.rvPronosticoIngresos)
        Me.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.Name = "frmInfPronosticoIngresos"
        Me.Text = "Pronóstico de ingresos"
        Me.Controls.SetChildIndex(Me.rvPronosticoIngresos, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rvPronosticoIngresos As Microsoft.Reporting.WinForms.ReportViewer
End Class
