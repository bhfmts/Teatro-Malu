<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGuitarras
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
        Me.groInformacionGeneral = New System.Windows.Forms.GroupBox
        Me.txtModelo = New System.Windows.Forms.TextBox
        Me.txtValorArriendo = New System.Windows.Forms.TextBox
        Me.lblValorArriendo = New System.Windows.Forms.Label
        Me.lblMarca = New System.Windows.Forms.Label
        Me.lblModelo = New System.Windows.Forms.Label
        Me.txtMarca = New System.Windows.Forms.TextBox
        Me.txtNumeroEspacios = New System.Windows.Forms.TextBox
        Me.cmbTipoGuitarra = New System.Windows.Forms.ComboBox
        Me.Label23 = New System.Windows.Forms.Label
        Me.cmbAmplificacion = New System.Windows.Forms.ComboBox
        Me.lblCantidadEspacios = New System.Windows.Forms.Label
        Me.lblTipoGuitarra = New System.Windows.Forms.Label
        Me.cmbTipoCuerda = New System.Windows.Forms.ComboBox
        Me.lblTipoCuerda = New System.Windows.Forms.Label
        Me.lbMarcaCuerda = New System.Windows.Forms.Label
        Me.lblDireccionVendedor = New System.Windows.Forms.Label
        Me.txtMarcaCuerda = New System.Windows.Forms.TextBox
        Me.groInformacionEspecifica = New System.Windows.Forms.GroupBox
        Me.lblAmplificacion = New System.Windows.Forms.Label
        Me.ErrorProviderGuitarras = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GuitarrasTableAdapter1 = New Teatro.TeatroDataSetTableAdapters.GUITARRASTableAdapter
        Me.EquiposTableAdapter1 = New Teatro.TeatroDataSetTableAdapters.EQUIPOSTableAdapter
        Me.btnLimpiar = New System.Windows.Forms.Button
        Me.btnRegistrar = New System.Windows.Forms.Button
        Me.groInformacionGeneral.SuspendLayout()
        Me.groInformacionEspecifica.SuspendLayout()
        CType(Me.ErrorProviderGuitarras, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'groInformacionGeneral
        '
        Me.groInformacionGeneral.Controls.Add(Me.txtModelo)
        Me.groInformacionGeneral.Controls.Add(Me.txtValorArriendo)
        Me.groInformacionGeneral.Controls.Add(Me.lblValorArriendo)
        Me.groInformacionGeneral.Controls.Add(Me.lblMarca)
        Me.groInformacionGeneral.Controls.Add(Me.lblModelo)
        Me.groInformacionGeneral.Controls.Add(Me.txtMarca)
        Me.groInformacionGeneral.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groInformacionGeneral.ForeColor = System.Drawing.Color.White
        Me.groInformacionGeneral.Location = New System.Drawing.Point(13, 13)
        Me.groInformacionGeneral.Margin = New System.Windows.Forms.Padding(4)
        Me.groInformacionGeneral.Name = "groInformacionGeneral"
        Me.groInformacionGeneral.Padding = New System.Windows.Forms.Padding(4)
        Me.groInformacionGeneral.Size = New System.Drawing.Size(272, 177)
        Me.groInformacionGeneral.TabIndex = 6
        Me.groInformacionGeneral.TabStop = False
        Me.groInformacionGeneral.Text = "Información general"
        '
        'txtModelo
        '
        Me.txtModelo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtModelo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtModelo.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.txtModelo.Location = New System.Drawing.Point(138, 77)
        Me.txtModelo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtModelo.MaxLength = 20
        Me.txtModelo.Name = "txtModelo"
        Me.txtModelo.Size = New System.Drawing.Size(101, 23)
        Me.txtModelo.TabIndex = 2
        '
        'txtValorArriendo
        '
        Me.txtValorArriendo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtValorArriendo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValorArriendo.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.txtValorArriendo.Location = New System.Drawing.Point(138, 123)
        Me.txtValorArriendo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtValorArriendo.MaxLength = 6
        Me.txtValorArriendo.Name = "txtValorArriendo"
        Me.txtValorArriendo.Size = New System.Drawing.Size(101, 23)
        Me.txtValorArriendo.TabIndex = 9
        '
        'lblValorArriendo
        '
        Me.lblValorArriendo.AutoSize = True
        Me.lblValorArriendo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValorArriendo.Location = New System.Drawing.Point(12, 127)
        Me.lblValorArriendo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblValorArriendo.Name = "lblValorArriendo"
        Me.lblValorArriendo.Size = New System.Drawing.Size(111, 16)
        Me.lblValorArriendo.TabIndex = 0
        Me.lblValorArriendo.Text = "Valor arriendo"
        '
        'lblMarca
        '
        Me.lblMarca.AutoSize = True
        Me.lblMarca.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMarca.Location = New System.Drawing.Point(31, 36)
        Me.lblMarca.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMarca.Name = "lblMarca"
        Me.lblMarca.Size = New System.Drawing.Size(52, 16)
        Me.lblMarca.TabIndex = 0
        Me.lblMarca.Text = "Marca"
        '
        'lblModelo
        '
        Me.lblModelo.AutoSize = True
        Me.lblModelo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModelo.Location = New System.Drawing.Point(27, 80)
        Me.lblModelo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblModelo.Name = "lblModelo"
        Me.lblModelo.Size = New System.Drawing.Size(60, 16)
        Me.lblModelo.TabIndex = 0
        Me.lblModelo.Text = "Modelo"
        '
        'txtMarca
        '
        Me.txtMarca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMarca.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMarca.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.txtMarca.Location = New System.Drawing.Point(138, 33)
        Me.txtMarca.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMarca.MaxLength = 20
        Me.txtMarca.Name = "txtMarca"
        Me.txtMarca.Size = New System.Drawing.Size(101, 23)
        Me.txtMarca.TabIndex = 1
        '
        'txtNumeroEspacios
        '
        Me.txtNumeroEspacios.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroEspacios.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumeroEspacios.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.txtNumeroEspacios.Location = New System.Drawing.Point(139, 30)
        Me.txtNumeroEspacios.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNumeroEspacios.MaxLength = 2
        Me.txtNumeroEspacios.Name = "txtNumeroEspacios"
        Me.txtNumeroEspacios.Size = New System.Drawing.Size(49, 23)
        Me.txtNumeroEspacios.TabIndex = 2
        '
        'cmbTipoGuitarra
        '
        Me.cmbTipoGuitarra.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTipoGuitarra.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.cmbTipoGuitarra.FormattingEnabled = True
        Me.cmbTipoGuitarra.Items.AddRange(New Object() {"CLASICA", "ELECTRO ACUSTICA", "ELECTRICA"})
        Me.cmbTipoGuitarra.Location = New System.Drawing.Point(139, 151)
        Me.cmbTipoGuitarra.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbTipoGuitarra.Name = "cmbTipoGuitarra"
        Me.cmbTipoGuitarra.Size = New System.Drawing.Size(104, 24)
        Me.cmbTipoGuitarra.TabIndex = 12
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(587, 272)
        Me.Label23.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(36, 16)
        Me.Label23.TabIndex = 0
        Me.Label23.Text = "Año"
        '
        'cmbAmplificacion
        '
        Me.cmbAmplificacion.Enabled = False
        Me.cmbAmplificacion.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAmplificacion.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.cmbAmplificacion.FormattingEnabled = True
        Me.cmbAmplificacion.Items.AddRange(New Object() {"CANON", "PLUS"})
        Me.cmbAmplificacion.Location = New System.Drawing.Point(139, 193)
        Me.cmbAmplificacion.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbAmplificacion.Name = "cmbAmplificacion"
        Me.cmbAmplificacion.Size = New System.Drawing.Size(104, 24)
        Me.cmbAmplificacion.TabIndex = 11
        '
        'lblCantidadEspacios
        '
        Me.lblCantidadEspacios.AutoSize = True
        Me.lblCantidadEspacios.BackColor = System.Drawing.Color.Transparent
        Me.lblCantidadEspacios.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantidadEspacios.Location = New System.Drawing.Point(26, 33)
        Me.lblCantidadEspacios.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCantidadEspacios.Name = "lblCantidadEspacios"
        Me.lblCantidadEspacios.Size = New System.Drawing.Size(93, 16)
        Me.lblCantidadEspacios.TabIndex = 0
        Me.lblCantidadEspacios.Text = "N° espacios"
        '
        'lblTipoGuitarra
        '
        Me.lblTipoGuitarra.AutoSize = True
        Me.lblTipoGuitarra.BackColor = System.Drawing.Color.Transparent
        Me.lblTipoGuitarra.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoGuitarra.Location = New System.Drawing.Point(28, 154)
        Me.lblTipoGuitarra.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTipoGuitarra.Name = "lblTipoGuitarra"
        Me.lblTipoGuitarra.Size = New System.Drawing.Size(100, 16)
        Me.lblTipoGuitarra.TabIndex = 0
        Me.lblTipoGuitarra.Text = "Tipo guitarra"
        '
        'cmbTipoCuerda
        '
        Me.cmbTipoCuerda.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTipoCuerda.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.cmbTipoCuerda.FormattingEnabled = True
        Me.cmbTipoCuerda.ItemHeight = 16
        Me.cmbTipoCuerda.Items.AddRange(New Object() {"NYLON", "ACERO"})
        Me.cmbTipoCuerda.Location = New System.Drawing.Point(139, 112)
        Me.cmbTipoCuerda.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbTipoCuerda.Name = "cmbTipoCuerda"
        Me.cmbTipoCuerda.Size = New System.Drawing.Size(104, 24)
        Me.cmbTipoCuerda.TabIndex = 10
        '
        'lblTipoCuerda
        '
        Me.lblTipoCuerda.AutoSize = True
        Me.lblTipoCuerda.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoCuerda.Location = New System.Drawing.Point(26, 115)
        Me.lblTipoCuerda.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTipoCuerda.Name = "lblTipoCuerda"
        Me.lblTipoCuerda.Size = New System.Drawing.Size(92, 16)
        Me.lblTipoCuerda.TabIndex = 0
        Me.lblTipoCuerda.Text = "Tipo cuerda"
        '
        'lbMarcaCuerda
        '
        Me.lbMarcaCuerda.AutoSize = True
        Me.lbMarcaCuerda.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbMarcaCuerda.Location = New System.Drawing.Point(18, 74)
        Me.lbMarcaCuerda.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbMarcaCuerda.Name = "lbMarcaCuerda"
        Me.lbMarcaCuerda.Size = New System.Drawing.Size(106, 16)
        Me.lbMarcaCuerda.TabIndex = 0
        Me.lbMarcaCuerda.Text = "Marca cuerda"
        '
        'lblDireccionVendedor
        '
        Me.lblDireccionVendedor.AutoSize = True
        Me.lblDireccionVendedor.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDireccionVendedor.Location = New System.Drawing.Point(180, 371)
        Me.lblDireccionVendedor.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDireccionVendedor.Name = "lblDireccionVendedor"
        Me.lblDireccionVendedor.Size = New System.Drawing.Size(75, 16)
        Me.lblDireccionVendedor.TabIndex = 0
        Me.lblDireccionVendedor.Text = "Dirección"
        '
        'txtMarcaCuerda
        '
        Me.txtMarcaCuerda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMarcaCuerda.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMarcaCuerda.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.txtMarcaCuerda.Location = New System.Drawing.Point(139, 71)
        Me.txtMarcaCuerda.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMarcaCuerda.MaxLength = 20
        Me.txtMarcaCuerda.Name = "txtMarcaCuerda"
        Me.txtMarcaCuerda.Size = New System.Drawing.Size(101, 23)
        Me.txtMarcaCuerda.TabIndex = 13
        '
        'groInformacionEspecifica
        '
        Me.groInformacionEspecifica.Controls.Add(Me.lblCantidadEspacios)
        Me.groInformacionEspecifica.Controls.Add(Me.cmbTipoCuerda)
        Me.groInformacionEspecifica.Controls.Add(Me.cmbTipoGuitarra)
        Me.groInformacionEspecifica.Controls.Add(Me.txtNumeroEspacios)
        Me.groInformacionEspecifica.Controls.Add(Me.cmbAmplificacion)
        Me.groInformacionEspecifica.Controls.Add(Me.txtMarcaCuerda)
        Me.groInformacionEspecifica.Controls.Add(Me.lbMarcaCuerda)
        Me.groInformacionEspecifica.Controls.Add(Me.lblAmplificacion)
        Me.groInformacionEspecifica.Controls.Add(Me.lblTipoGuitarra)
        Me.groInformacionEspecifica.Controls.Add(Me.lblTipoCuerda)
        Me.groInformacionEspecifica.Location = New System.Drawing.Point(13, 211)
        Me.groInformacionEspecifica.Name = "groInformacionEspecifica"
        Me.groInformacionEspecifica.Size = New System.Drawing.Size(273, 239)
        Me.groInformacionEspecifica.TabIndex = 15
        Me.groInformacionEspecifica.TabStop = False
        Me.groInformacionEspecifica.Text = "Información específica"
        '
        'lblAmplificacion
        '
        Me.lblAmplificacion.AutoSize = True
        Me.lblAmplificacion.BackColor = System.Drawing.Color.Transparent
        Me.lblAmplificacion.Enabled = False
        Me.lblAmplificacion.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmplificacion.Location = New System.Drawing.Point(24, 196)
        Me.lblAmplificacion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAmplificacion.Name = "lblAmplificacion"
        Me.lblAmplificacion.Size = New System.Drawing.Size(105, 16)
        Me.lblAmplificacion.TabIndex = 0
        Me.lblAmplificacion.Text = "Amplificación"
        '
        'ErrorProviderGuitarras
        '
        Me.ErrorProviderGuitarras.ContainerControl = Me
        '
        'GuitarrasTableAdapter1
        '
        Me.GuitarrasTableAdapter1.ClearBeforeFill = True
        '
        'EquiposTableAdapter1
        '
        Me.EquiposTableAdapter1.ClearBeforeFill = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnLimpiar.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiar.Image = Global.Teatro.My.Resources.Resources.page
        Me.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnLimpiar.Location = New System.Drawing.Point(39, 466)
        Me.btnLimpiar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(105, 38)
        Me.btnLimpiar.TabIndex = 21
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = False
        '
        'btnRegistrar
        '
        Me.btnRegistrar.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnRegistrar.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistrar.Image = Global.Teatro.My.Resources.Resources.button_ok
        Me.btnRegistrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRegistrar.Location = New System.Drawing.Point(152, 466)
        Me.btnRegistrar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(123, 38)
        Me.btnRegistrar.TabIndex = 20
        Me.btnRegistrar.Text = "Registrar"
        Me.btnRegistrar.UseVisualStyleBackColor = False
        '
        'frmGuitarras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(301, 517)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnRegistrar)
        Me.Controls.Add(Me.groInformacionEspecifica)
        Me.Controls.Add(Me.groInformacionGeneral)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.lblDireccionVendedor)
        Me.Name = "frmGuitarras"
        Me.Text = "Guitarras"
        Me.Controls.SetChildIndex(Me.lblDireccionVendedor, 0)
        Me.Controls.SetChildIndex(Me.Label23, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.groInformacionGeneral, 0)
        Me.Controls.SetChildIndex(Me.groInformacionEspecifica, 0)
        Me.Controls.SetChildIndex(Me.btnRegistrar, 0)
        Me.Controls.SetChildIndex(Me.btnLimpiar, 0)
        Me.groInformacionGeneral.ResumeLayout(False)
        Me.groInformacionGeneral.PerformLayout()
        Me.groInformacionEspecifica.ResumeLayout(False)
        Me.groInformacionEspecifica.PerformLayout()
        CType(Me.ErrorProviderGuitarras, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents groInformacionGeneral As System.Windows.Forms.GroupBox
    Friend WithEvents txtNumeroEspacios As System.Windows.Forms.TextBox
    Friend WithEvents cmbTipoGuitarra As System.Windows.Forms.ComboBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents cmbAmplificacion As System.Windows.Forms.ComboBox
    Friend WithEvents lblCantidadEspacios As System.Windows.Forms.Label
    Friend WithEvents lblTipoGuitarra As System.Windows.Forms.Label
    Friend WithEvents cmbTipoCuerda As System.Windows.Forms.ComboBox
    Friend WithEvents lblTipoCuerda As System.Windows.Forms.Label
    Public WithEvents txtModelo As System.Windows.Forms.TextBox
    Friend WithEvents txtValorArriendo As System.Windows.Forms.TextBox
    Friend WithEvents lblValorArriendo As System.Windows.Forms.Label
    Friend WithEvents lblMarca As System.Windows.Forms.Label
    Friend WithEvents lbMarcaCuerda As System.Windows.Forms.Label
    Friend WithEvents lblModelo As System.Windows.Forms.Label
    Friend WithEvents lblDireccionVendedor As System.Windows.Forms.Label
    Public WithEvents txtMarca As System.Windows.Forms.TextBox
    Friend WithEvents txtMarcaCuerda As System.Windows.Forms.TextBox
    Friend WithEvents groInformacionEspecifica As System.Windows.Forms.GroupBox
    Friend WithEvents lblAmplificacion As System.Windows.Forms.Label
    Friend WithEvents ErrorProviderGuitarras As System.Windows.Forms.ErrorProvider
    Friend WithEvents GuitarrasTableAdapter1 As Teatro.TeatroDataSetTableAdapters.GUITARRASTableAdapter
    Friend WithEvents EquiposTableAdapter1 As Teatro.TeatroDataSetTableAdapters.EQUIPOSTableAdapter
    Friend WithEvents btnLimpiar As System.Windows.Forms.Button
    Friend WithEvents btnRegistrar As System.Windows.Forms.Button
End Class
