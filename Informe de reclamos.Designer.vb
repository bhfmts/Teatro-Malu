<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInformeReclamos
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
        Me.rvInformeReclamos = New Microsoft.Reporting.WinForms.ReportViewer
        Me.ReclamosTableAdapter1 = New Teatro.TeatroDataSetTableAdapters.RECLAMOSTableAdapter
        Me.btnGenerar = New System.Windows.Forms.Button
        Me.dtpDesde = New System.Windows.Forms.DateTimePicker
        Me.dtpHasta = New System.Windows.Forms.DateTimePicker
        Me.lblHasta = New System.Windows.Forms.Label
        Me.lblDesde = New System.Windows.Forms.Label
        Me.groIntervalo = New System.Windows.Forms.GroupBox
        Me.groIntervalo.SuspendLayout()
        Me.SuspendLayout()
        '
        'rvInformeReclamos
        '
        Me.rvInformeReclamos.LocalReport.ReportEmbeddedResource = "Teatro.Informe de reclamos.rdlc"
        Me.rvInformeReclamos.Location = New System.Drawing.Point(37, 179)
        Me.rvInformeReclamos.Name = "rvInformeReclamos"
        Me.rvInformeReclamos.Size = New System.Drawing.Size(465, 295)
        Me.rvInformeReclamos.TabIndex = 1
        '
        'ReclamosTableAdapter1
        '
        Me.ReclamosTableAdapter1.ClearBeforeFill = True
        '
        'btnGenerar
        '
        Me.btnGenerar.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnGenerar.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerar.Location = New System.Drawing.Point(421, 113)
        Me.btnGenerar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.Size = New System.Drawing.Size(90, 38)
        Me.btnGenerar.TabIndex = 13
        Me.btnGenerar.Text = "Generar"
        Me.btnGenerar.UseVisualStyleBackColor = False
        '
        'dtpDesde
        '
        Me.dtpDesde.Location = New System.Drawing.Point(81, 37)
        Me.dtpDesde.Name = "dtpDesde"
        Me.dtpDesde.Size = New System.Drawing.Size(178, 23)
        Me.dtpDesde.TabIndex = 5
        '
        'dtpHasta
        '
        Me.dtpHasta.Location = New System.Drawing.Point(340, 37)
        Me.dtpHasta.Name = "dtpHasta"
        Me.dtpHasta.Size = New System.Drawing.Size(171, 23)
        Me.dtpHasta.TabIndex = 6
        '
        'lblHasta
        '
        Me.lblHasta.AutoSize = True
        Me.lblHasta.ForeColor = System.Drawing.Color.White
        Me.lblHasta.Location = New System.Drawing.Point(279, 42)
        Me.lblHasta.Name = "lblHasta"
        Me.lblHasta.Size = New System.Drawing.Size(51, 16)
        Me.lblHasta.TabIndex = 3
        Me.lblHasta.Text = "Hasta"
        '
        'lblDesde
        '
        Me.lblDesde.AutoSize = True
        Me.lblDesde.ForeColor = System.Drawing.Color.White
        Me.lblDesde.Location = New System.Drawing.Point(21, 42)
        Me.lblDesde.Name = "lblDesde"
        Me.lblDesde.Size = New System.Drawing.Size(53, 16)
        Me.lblDesde.TabIndex = 4
        Me.lblDesde.Text = "Desde"
        '
        'groIntervalo
        '
        Me.groIntervalo.Controls.Add(Me.lblDesde)
        Me.groIntervalo.Controls.Add(Me.lblHasta)
        Me.groIntervalo.Controls.Add(Me.dtpHasta)
        Me.groIntervalo.Controls.Add(Me.dtpDesde)
        Me.groIntervalo.Location = New System.Drawing.Point(10, 12)
        Me.groIntervalo.Name = "groIntervalo"
        Me.groIntervalo.Size = New System.Drawing.Size(524, 94)
        Me.groIntervalo.TabIndex = 7
        Me.groIntervalo.TabStop = False
        Me.groIntervalo.Text = "Intervalo de fechas"
        '
        'frmInformeReclamos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(551, 490)
        Me.Controls.Add(Me.groIntervalo)
        Me.Controls.Add(Me.rvInformeReclamos)
        Me.Controls.Add(Me.btnGenerar)
        Me.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.Name = "frmInformeReclamos"
        Me.Text = "Informe de reclamos"
        Me.Controls.SetChildIndex(Me.btnGenerar, 0)
        Me.Controls.SetChildIndex(Me.rvInformeReclamos, 0)
        Me.Controls.SetChildIndex(Me.groIntervalo, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.groIntervalo.ResumeLayout(False)
        Me.groIntervalo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rvInformeReclamos As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ReclamosTableAdapter1 As Teatro.TeatroDataSetTableAdapters.RECLAMOSTableAdapter
    Friend WithEvents btnGenerar As System.Windows.Forms.Button
    Friend WithEvents dtpDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblHasta As System.Windows.Forms.Label
    Friend WithEvents lblDesde As System.Windows.Forms.Label
    Friend WithEvents groIntervalo As System.Windows.Forms.GroupBox
End Class
