<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMicrofonos
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
        Me.groInformacionEspecifica = New System.Windows.Forms.GroupBox
        Me.cmbTipo = New System.Windows.Forms.ComboBox
        Me.lblTipo = New System.Windows.Forms.Label
        Me.groInformacionGeneral = New System.Windows.Forms.GroupBox
        Me.txtModelo = New System.Windows.Forms.TextBox
        Me.txtValorArriendo = New System.Windows.Forms.TextBox
        Me.lblValorArriendo = New System.Windows.Forms.Label
        Me.lblMarca = New System.Windows.Forms.Label
        Me.lblModelo = New System.Windows.Forms.Label
        Me.txtMarca = New System.Windows.Forms.TextBox
        Me.ErrorProviderMicrofonos = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.EquiposTableAdapter1 = New Teatro.TeatroDataSetTableAdapters.EQUIPOSTableAdapter
        Me.MicrofonosTableAdapter1 = New Teatro.TeatroDataSetTableAdapters.MICROFONOSTableAdapter
        Me.btnLimpiar = New System.Windows.Forms.Button
        Me.btnRegistrar = New System.Windows.Forms.Button
        Me.groInformacionEspecifica.SuspendLayout()
        Me.groInformacionGeneral.SuspendLayout()
        CType(Me.ErrorProviderMicrofonos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'groInformacionEspecifica
        '
        Me.groInformacionEspecifica.Controls.Add(Me.cmbTipo)
        Me.groInformacionEspecifica.Controls.Add(Me.lblTipo)
        Me.groInformacionEspecifica.Location = New System.Drawing.Point(13, 220)
        Me.groInformacionEspecifica.Name = "groInformacionEspecifica"
        Me.groInformacionEspecifica.Size = New System.Drawing.Size(273, 83)
        Me.groInformacionEspecifica.TabIndex = 21
        Me.groInformacionEspecifica.TabStop = False
        Me.groInformacionEspecifica.Text = "Información específica"
        '
        'cmbTipo
        '
        Me.cmbTipo.FormattingEnabled = True
        Me.cmbTipo.Items.AddRange(New Object() {"ALAMBRICO", "INALAMBRICO"})
        Me.cmbTipo.Location = New System.Drawing.Point(127, 34)
        Me.cmbTipo.Name = "cmbTipo"
        Me.cmbTipo.Size = New System.Drawing.Size(121, 24)
        Me.cmbTipo.TabIndex = 15
        '
        'lblTipo
        '
        Me.lblTipo.AutoSize = True
        Me.lblTipo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipo.Location = New System.Drawing.Point(49, 37)
        Me.lblTipo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(38, 16)
        Me.lblTipo.TabIndex = 0
        Me.lblTipo.Text = "Tipo"
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
        Me.groInformacionGeneral.Location = New System.Drawing.Point(13, 7)
        Me.groInformacionGeneral.Margin = New System.Windows.Forms.Padding(4)
        Me.groInformacionGeneral.Name = "groInformacionGeneral"
        Me.groInformacionGeneral.Padding = New System.Windows.Forms.Padding(4)
        Me.groInformacionGeneral.Size = New System.Drawing.Size(272, 196)
        Me.groInformacionGeneral.TabIndex = 20
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
        Me.txtModelo.TabIndex = 7
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
        Me.txtMarca.TabIndex = 6
        '
        'ErrorProviderMicrofonos
        '
        Me.ErrorProviderMicrofonos.ContainerControl = Me
        '
        'EquiposTableAdapter1
        '
        Me.EquiposTableAdapter1.ClearBeforeFill = True
        '
        'MicrofonosTableAdapter1
        '
        Me.MicrofonosTableAdapter1.ClearBeforeFill = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnLimpiar.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiar.Image = Global.Teatro.My.Resources.Resources.page
        Me.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnLimpiar.Location = New System.Drawing.Point(38, 323)
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
        Me.btnRegistrar.Location = New System.Drawing.Point(151, 323)
        Me.btnRegistrar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(123, 38)
        Me.btnRegistrar.TabIndex = 20
        Me.btnRegistrar.Text = "Registrar"
        Me.btnRegistrar.UseVisualStyleBackColor = False
        '
        'frmMicrofonos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(305, 384)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.groInformacionEspecifica)
        Me.Controls.Add(Me.btnRegistrar)
        Me.Controls.Add(Me.groInformacionGeneral)
        Me.Name = "frmMicrofonos"
        Me.Text = "Microfonos"
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.groInformacionGeneral, 0)
        Me.Controls.SetChildIndex(Me.btnRegistrar, 0)
        Me.Controls.SetChildIndex(Me.groInformacionEspecifica, 0)
        Me.Controls.SetChildIndex(Me.btnLimpiar, 0)
        Me.groInformacionEspecifica.ResumeLayout(False)
        Me.groInformacionEspecifica.PerformLayout()
        Me.groInformacionGeneral.ResumeLayout(False)
        Me.groInformacionGeneral.PerformLayout()
        CType(Me.ErrorProviderMicrofonos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents groInformacionEspecifica As System.Windows.Forms.GroupBox
    Friend WithEvents lblTipo As System.Windows.Forms.Label
    Friend WithEvents groInformacionGeneral As System.Windows.Forms.GroupBox
    Public WithEvents txtModelo As System.Windows.Forms.TextBox
    Friend WithEvents txtValorArriendo As System.Windows.Forms.TextBox
    Friend WithEvents lblValorArriendo As System.Windows.Forms.Label
    Friend WithEvents lblMarca As System.Windows.Forms.Label
    Friend WithEvents lblModelo As System.Windows.Forms.Label
    Public WithEvents txtMarca As System.Windows.Forms.TextBox
    Friend WithEvents ErrorProviderMicrofonos As System.Windows.Forms.ErrorProvider
    Friend WithEvents EquiposTableAdapter1 As Teatro.TeatroDataSetTableAdapters.EQUIPOSTableAdapter
    Friend WithEvents MicrofonosTableAdapter1 As Teatro.TeatroDataSetTableAdapters.MICROFONOSTableAdapter
    Friend WithEvents cmbTipo As System.Windows.Forms.ComboBox
    Friend WithEvents btnLimpiar As System.Windows.Forms.Button
    Friend WithEvents btnRegistrar As System.Windows.Forms.Button
End Class
