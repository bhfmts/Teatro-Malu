<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEliminarAtriles
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.groResultados = New System.Windows.Forms.GroupBox
        Me.dgResultados = New System.Windows.Forms.DataGridView
        Me.btnEliminar = New System.Windows.Forms.Button
        Me.groBusqueda = New System.Windows.Forms.GroupBox
        Me.btnBuscar = New System.Windows.Forms.Button
        Me.lblDatoBusqueda = New System.Windows.Forms.Label
        Me.txtDatoBusqueda = New System.Windows.Forms.TextBox
        Me.groOpcionesBusqueda = New System.Windows.Forms.GroupBox
        Me.rdbIDAtril = New System.Windows.Forms.RadioButton
        Me.rdbIDEquipo = New System.Windows.Forms.RadioButton
        Me.ErrorProviderEliminarAtriles = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.AtrilesTableAdapter1 = New Teatro.TeatroDataSetTableAdapters.ATRILESTableAdapter
        Me.EquiposTableAdapter1 = New Teatro.TeatroDataSetTableAdapters.EQUIPOSTableAdapter
        Me.groResultados.SuspendLayout()
        CType(Me.dgResultados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groBusqueda.SuspendLayout()
        Me.groOpcionesBusqueda.SuspendLayout()
        CType(Me.ErrorProviderEliminarAtriles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'groResultados
        '
        Me.groResultados.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.groResultados.BackColor = System.Drawing.Color.DarkSlateGray
        Me.groResultados.Controls.Add(Me.dgResultados)
        Me.groResultados.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groResultados.ForeColor = System.Drawing.Color.White
        Me.groResultados.Location = New System.Drawing.Point(25, 92)
        Me.groResultados.Name = "groResultados"
        Me.groResultados.Size = New System.Drawing.Size(585, 111)
        Me.groResultados.TabIndex = 24
        Me.groResultados.TabStop = False
        Me.groResultados.Text = "Resultados"
        '
        'dgResultados
        '
        Me.dgResultados.AllowUserToAddRows = False
        Me.dgResultados.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.dgResultados.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgResultados.BackgroundColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgResultados.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgResultados.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgResultados.Enabled = False
        Me.dgResultados.GridColor = System.Drawing.Color.MidnightBlue
        Me.dgResultados.Location = New System.Drawing.Point(18, 22)
        Me.dgResultados.Name = "dgResultados"
        Me.dgResultados.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgResultados.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.dgResultados.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgResultados.Size = New System.Drawing.Size(554, 73)
        Me.dgResultados.TabIndex = 8
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnEliminar.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.Image = Global.Teatro.My.Resources.Resources._stop
        Me.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEliminar.Location = New System.Drawing.Point(234, 213)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(121, 30)
        Me.btnEliminar.TabIndex = 21
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'groBusqueda
        '
        Me.groBusqueda.Controls.Add(Me.btnBuscar)
        Me.groBusqueda.Controls.Add(Me.lblDatoBusqueda)
        Me.groBusqueda.Controls.Add(Me.txtDatoBusqueda)
        Me.groBusqueda.Location = New System.Drawing.Point(297, 12)
        Me.groBusqueda.Name = "groBusqueda"
        Me.groBusqueda.Size = New System.Drawing.Size(321, 74)
        Me.groBusqueda.TabIndex = 23
        Me.groBusqueda.TabStop = False
        Me.groBusqueda.Text = "Búsqueda"
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnBuscar.Location = New System.Drawing.Point(218, 22)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(80, 30)
        Me.btnBuscar.TabIndex = 18
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'lblDatoBusqueda
        '
        Me.lblDatoBusqueda.AutoSize = True
        Me.lblDatoBusqueda.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDatoBusqueda.Location = New System.Drawing.Point(20, 29)
        Me.lblDatoBusqueda.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDatoBusqueda.Name = "lblDatoBusqueda"
        Me.lblDatoBusqueda.Size = New System.Drawing.Size(117, 16)
        Me.lblDatoBusqueda.TabIndex = 15
        Me.lblDatoBusqueda.Text = "Dato búsqueda"
        '
        'txtDatoBusqueda
        '
        Me.txtDatoBusqueda.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDatoBusqueda.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.txtDatoBusqueda.Location = New System.Drawing.Point(160, 26)
        Me.txtDatoBusqueda.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDatoBusqueda.MaxLength = 8
        Me.txtDatoBusqueda.Name = "txtDatoBusqueda"
        Me.txtDatoBusqueda.Size = New System.Drawing.Size(39, 23)
        Me.txtDatoBusqueda.TabIndex = 17
        '
        'groOpcionesBusqueda
        '
        Me.groOpcionesBusqueda.Controls.Add(Me.rdbIDAtril)
        Me.groOpcionesBusqueda.Controls.Add(Me.rdbIDEquipo)
        Me.groOpcionesBusqueda.Location = New System.Drawing.Point(12, 12)
        Me.groOpcionesBusqueda.Name = "groOpcionesBusqueda"
        Me.groOpcionesBusqueda.Size = New System.Drawing.Size(269, 74)
        Me.groOpcionesBusqueda.TabIndex = 22
        Me.groOpcionesBusqueda.TabStop = False
        Me.groOpcionesBusqueda.Text = "Opciones búsqueda"
        '
        'rdbIDAtril
        '
        Me.rdbIDAtril.AutoSize = True
        Me.rdbIDAtril.Location = New System.Drawing.Point(141, 32)
        Me.rdbIDAtril.Name = "rdbIDAtril"
        Me.rdbIDAtril.Size = New System.Drawing.Size(76, 20)
        Me.rdbIDAtril.TabIndex = 1
        Me.rdbIDAtril.TabStop = True
        Me.rdbIDAtril.Text = "ID Atril"
        Me.rdbIDAtril.UseVisualStyleBackColor = True
        '
        'rdbIDEquipo
        '
        Me.rdbIDEquipo.AutoSize = True
        Me.rdbIDEquipo.Location = New System.Drawing.Point(31, 32)
        Me.rdbIDEquipo.Name = "rdbIDEquipo"
        Me.rdbIDEquipo.Size = New System.Drawing.Size(95, 20)
        Me.rdbIDEquipo.TabIndex = 0
        Me.rdbIDEquipo.TabStop = True
        Me.rdbIDEquipo.Text = "ID equipo"
        Me.rdbIDEquipo.UseVisualStyleBackColor = True
        '
        'ErrorProviderEliminarAtriles
        '
        Me.ErrorProviderEliminarAtriles.ContainerControl = Me
        '
        'AtrilesTableAdapter1
        '
        Me.AtrilesTableAdapter1.ClearBeforeFill = True
        '
        'EquiposTableAdapter1
        '
        Me.EquiposTableAdapter1.ClearBeforeFill = True
        '
        'frmEliminarAtriles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(642, 266)
        Me.Controls.Add(Me.groResultados)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.groBusqueda)
        Me.Controls.Add(Me.groOpcionesBusqueda)
        Me.Name = "frmEliminarAtriles"
        Me.Text = "Eliminar atriles"
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.groOpcionesBusqueda, 0)
        Me.Controls.SetChildIndex(Me.groBusqueda, 0)
        Me.Controls.SetChildIndex(Me.btnEliminar, 0)
        Me.Controls.SetChildIndex(Me.groResultados, 0)
        Me.groResultados.ResumeLayout(False)
        CType(Me.dgResultados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groBusqueda.ResumeLayout(False)
        Me.groBusqueda.PerformLayout()
        Me.groOpcionesBusqueda.ResumeLayout(False)
        Me.groOpcionesBusqueda.PerformLayout()
        CType(Me.ErrorProviderEliminarAtriles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents groResultados As System.Windows.Forms.GroupBox
    Friend WithEvents dgResultados As System.Windows.Forms.DataGridView
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents groBusqueda As System.Windows.Forms.GroupBox
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents lblDatoBusqueda As System.Windows.Forms.Label
    Friend WithEvents txtDatoBusqueda As System.Windows.Forms.TextBox
    Friend WithEvents groOpcionesBusqueda As System.Windows.Forms.GroupBox
    Friend WithEvents rdbIDAtril As System.Windows.Forms.RadioButton
    Friend WithEvents rdbIDEquipo As System.Windows.Forms.RadioButton
    Friend WithEvents AtrilesTableAdapter1 As Teatro.TeatroDataSetTableAdapters.ATRILESTableAdapter
    Friend WithEvents EquiposTableAdapter1 As Teatro.TeatroDataSetTableAdapters.EQUIPOSTableAdapter
    Friend WithEvents ErrorProviderEliminarAtriles As System.Windows.Forms.ErrorProvider
End Class
