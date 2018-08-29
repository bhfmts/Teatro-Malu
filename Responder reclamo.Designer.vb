<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmResponderReclamo
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
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.groRespuestaReclamo = New System.Windows.Forms.GroupBox
        Me.dgFechasReclamos = New System.Windows.Forms.DataGridView
        Me.lblReclamo = New System.Windows.Forms.Label
        Me.txtReclamo = New System.Windows.Forms.TextBox
        Me.lblFechaReclamo = New System.Windows.Forms.Label
        Me.ErrorProviderReclamos = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ReclamosTableAdapter1 = New Teatro.TeatroDataSetTableAdapters.RECLAMOSTableAdapter
        Me.txtRespuesta = New System.Windows.Forms.TextBox
        Me.lblRespuesta = New System.Windows.Forms.Label
        Me.btnEnviar = New System.Windows.Forms.Button
        Me.groRespuestaReclamo.SuspendLayout()
        CType(Me.dgFechasReclamos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProviderReclamos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'groRespuestaReclamo
        '
        Me.groRespuestaReclamo.Controls.Add(Me.dgFechasReclamos)
        Me.groRespuestaReclamo.Controls.Add(Me.btnEnviar)
        Me.groRespuestaReclamo.Controls.Add(Me.lblRespuesta)
        Me.groRespuestaReclamo.Controls.Add(Me.lblReclamo)
        Me.groRespuestaReclamo.Controls.Add(Me.txtRespuesta)
        Me.groRespuestaReclamo.Controls.Add(Me.txtReclamo)
        Me.groRespuestaReclamo.Controls.Add(Me.lblFechaReclamo)
        Me.groRespuestaReclamo.Location = New System.Drawing.Point(12, 7)
        Me.groRespuestaReclamo.Name = "groRespuestaReclamo"
        Me.groRespuestaReclamo.Size = New System.Drawing.Size(529, 542)
        Me.groRespuestaReclamo.TabIndex = 0
        Me.groRespuestaReclamo.TabStop = False
        Me.groRespuestaReclamo.Text = "Respuesta reclamo"
        '
        'dgFechasReclamos
        '
        Me.dgFechasReclamos.AllowUserToAddRows = False
        Me.dgFechasReclamos.AllowUserToDeleteRows = False
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.dgFechasReclamos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle11
        Me.dgFechasReclamos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgFechasReclamos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgFechasReclamos.BackgroundColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle12.Format = "G"
        DataGridViewCellStyle12.NullValue = Nothing
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgFechasReclamos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.dgFechasReclamos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle13.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle13.Format = "F"
        DataGridViewCellStyle13.NullValue = Nothing
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgFechasReclamos.DefaultCellStyle = DataGridViewCellStyle13
        Me.dgFechasReclamos.Location = New System.Drawing.Point(165, 49)
        Me.dgFechasReclamos.Name = "dgFechasReclamos"
        Me.dgFechasReclamos.ReadOnly = True
        DataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle14.Format = "G"
        DataGridViewCellStyle14.NullValue = Nothing
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgFechasReclamos.RowHeadersDefaultCellStyle = DataGridViewCellStyle14
        Me.dgFechasReclamos.RowHeadersVisible = False
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle15.ForeColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle15.Format = "G"
        DataGridViewCellStyle15.NullValue = Nothing
        Me.dgFechasReclamos.RowsDefaultCellStyle = DataGridViewCellStyle15
        Me.dgFechasReclamos.Size = New System.Drawing.Size(345, 94)
        Me.dgFechasReclamos.TabIndex = 16
        '
        'lblReclamo
        '
        Me.lblReclamo.AutoSize = True
        Me.lblReclamo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReclamo.Location = New System.Drawing.Point(46, 159)
        Me.lblReclamo.Name = "lblReclamo"
        Me.lblReclamo.Size = New System.Drawing.Size(70, 16)
        Me.lblReclamo.TabIndex = 2
        Me.lblReclamo.Text = "Reclamo"
        '
        'txtReclamo
        '
        Me.txtReclamo.BackColor = System.Drawing.Color.White
        Me.txtReclamo.Enabled = False
        Me.txtReclamo.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.txtReclamo.Location = New System.Drawing.Point(165, 156)
        Me.txtReclamo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtReclamo.MaxLength = 6
        Me.txtReclamo.Multiline = True
        Me.txtReclamo.Name = "txtReclamo"
        Me.txtReclamo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtReclamo.Size = New System.Drawing.Size(345, 146)
        Me.txtReclamo.TabIndex = 4
        '
        'lblFechaReclamo
        '
        Me.lblFechaReclamo.AutoSize = True
        Me.lblFechaReclamo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaReclamo.Location = New System.Drawing.Point(31, 60)
        Me.lblFechaReclamo.Name = "lblFechaReclamo"
        Me.lblFechaReclamo.Size = New System.Drawing.Size(115, 16)
        Me.lblFechaReclamo.TabIndex = 2
        Me.lblFechaReclamo.Text = "Fecha reclamo"
        '
        'ErrorProviderReclamos
        '
        Me.ErrorProviderReclamos.ContainerControl = Me
        '
        'ReclamosTableAdapter1
        '
        Me.ReclamosTableAdapter1.ClearBeforeFill = True
        '
        'txtRespuesta
        '
        Me.txtRespuesta.BackColor = System.Drawing.Color.White
        Me.txtRespuesta.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.txtRespuesta.Location = New System.Drawing.Point(165, 317)
        Me.txtRespuesta.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtRespuesta.MaxLength = 300
        Me.txtRespuesta.Multiline = True
        Me.txtRespuesta.Name = "txtRespuesta"
        Me.txtRespuesta.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtRespuesta.Size = New System.Drawing.Size(345, 137)
        Me.txtRespuesta.TabIndex = 4
        '
        'lblRespuesta
        '
        Me.lblRespuesta.AutoSize = True
        Me.lblRespuesta.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRespuesta.Location = New System.Drawing.Point(46, 320)
        Me.lblRespuesta.Name = "lblRespuesta"
        Me.lblRespuesta.Size = New System.Drawing.Size(84, 16)
        Me.lblRespuesta.TabIndex = 2
        Me.lblRespuesta.Text = "Respuesta"
        '
        'btnEnviar
        '
        Me.btnEnviar.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnEnviar.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnEnviar.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnviar.Location = New System.Drawing.Point(423, 492)
        Me.btnEnviar.Name = "btnEnviar"
        Me.btnEnviar.Size = New System.Drawing.Size(87, 36)
        Me.btnEnviar.TabIndex = 8
        Me.btnEnviar.Text = "Enviar"
        Me.btnEnviar.UseVisualStyleBackColor = False
        '
        'frmResponderReclamo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSlateGray
        Me.ClientSize = New System.Drawing.Size(597, 571)
        Me.Controls.Add(Me.groRespuestaReclamo)
        Me.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmResponderReclamo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Responder reclamo"
        Me.groRespuestaReclamo.ResumeLayout(False)
        Me.groRespuestaReclamo.PerformLayout()
        CType(Me.dgFechasReclamos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProviderReclamos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents groRespuestaReclamo As System.Windows.Forms.GroupBox
    Friend WithEvents lblFechaReclamo As System.Windows.Forms.Label
    Friend WithEvents txtReclamo As System.Windows.Forms.TextBox
    Friend WithEvents lblReclamo As System.Windows.Forms.Label
    Friend WithEvents ReclamosTableAdapter1 As Teatro.TeatroDataSetTableAdapters.RECLAMOSTableAdapter
    Friend WithEvents ErrorProviderReclamos As System.Windows.Forms.ErrorProvider
    Friend WithEvents dgFechasReclamos As System.Windows.Forms.DataGridView
    Friend WithEvents btnEnviar As System.Windows.Forms.Button
    Friend WithEvents lblRespuesta As System.Windows.Forms.Label
    Friend WithEvents txtRespuesta As System.Windows.Forms.TextBox
End Class
