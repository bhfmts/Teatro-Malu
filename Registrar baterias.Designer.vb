<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBaterias
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
        Me.btnLimpiar = New System.Windows.Forms.Button
        Me.btnRegistrar = New System.Windows.Forms.Button
        Me.groInformacionEspecifica = New System.Windows.Forms.GroupBox
        Me.lblNumeroToms = New System.Windows.Forms.Label
        Me.txtNumeroToms = New System.Windows.Forms.TextBox
        Me.txtNumeroPlatillos = New System.Windows.Forms.TextBox
        Me.lblNumeroPlatillos = New System.Windows.Forms.Label
        Me.lblNumeroBombos = New System.Windows.Forms.Label
        Me.groInformacionGeneral = New System.Windows.Forms.GroupBox
        Me.txtModelo = New System.Windows.Forms.TextBox
        Me.txtValorArriendo = New System.Windows.Forms.TextBox
        Me.lblValorArriendo = New System.Windows.Forms.Label
        Me.lblMarca = New System.Windows.Forms.Label
        Me.lblModelo = New System.Windows.Forms.Label
        Me.txtMarca = New System.Windows.Forms.TextBox
        Me.txtNumeroBombos = New System.Windows.Forms.TextBox
        Me.BateriasTableAdapter1 = New Teatro.TeatroDataSetTableAdapters.BATERIASTableAdapter
        Me.EquiposTableAdapter1 = New Teatro.TeatroDataSetTableAdapters.EQUIPOSTableAdapter
        Me.ErrorProviderBaterias = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.groInformacionEspecifica.SuspendLayout()
        Me.groInformacionGeneral.SuspendLayout()
        CType(Me.ErrorProviderBaterias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnLimpiar.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiar.Image = Global.Teatro.My.Resources.Resources.page
        Me.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnLimpiar.Location = New System.Drawing.Point(39, 391)
        Me.btnLimpiar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(105, 38)
        Me.btnLimpiar.TabIndex = 27
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = False
        '
        'btnRegistrar
        '
        Me.btnRegistrar.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnRegistrar.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistrar.Image = Global.Teatro.My.Resources.Resources.button_ok
        Me.btnRegistrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRegistrar.Location = New System.Drawing.Point(163, 391)
        Me.btnRegistrar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(123, 38)
        Me.btnRegistrar.TabIndex = 26
        Me.btnRegistrar.Text = "Registrar"
        Me.btnRegistrar.UseVisualStyleBackColor = False
        '
        'groInformacionEspecifica
        '
        Me.groInformacionEspecifica.Controls.Add(Me.txtNumeroBombos)
        Me.groInformacionEspecifica.Controls.Add(Me.lblNumeroToms)
        Me.groInformacionEspecifica.Controls.Add(Me.txtNumeroToms)
        Me.groInformacionEspecifica.Controls.Add(Me.txtNumeroPlatillos)
        Me.groInformacionEspecifica.Controls.Add(Me.lblNumeroPlatillos)
        Me.groInformacionEspecifica.Controls.Add(Me.lblNumeroBombos)
        Me.groInformacionEspecifica.Location = New System.Drawing.Point(25, 211)
        Me.groInformacionEspecifica.Name = "groInformacionEspecifica"
        Me.groInformacionEspecifica.Size = New System.Drawing.Size(273, 157)
        Me.groInformacionEspecifica.TabIndex = 25
        Me.groInformacionEspecifica.TabStop = False
        Me.groInformacionEspecifica.Text = "Información específica"
        '
        'lblNumeroToms
        '
        Me.lblNumeroToms.AutoSize = True
        Me.lblNumeroToms.BackColor = System.Drawing.Color.Transparent
        Me.lblNumeroToms.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumeroToms.Location = New System.Drawing.Point(26, 33)
        Me.lblNumeroToms.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNumeroToms.Name = "lblNumeroToms"
        Me.lblNumeroToms.Size = New System.Drawing.Size(66, 16)
        Me.lblNumeroToms.TabIndex = 0
        Me.lblNumeroToms.Text = "N° toms"
        '
        'txtNumeroToms
        '
        Me.txtNumeroToms.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroToms.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumeroToms.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.txtNumeroToms.Location = New System.Drawing.Point(139, 30)
        Me.txtNumeroToms.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNumeroToms.MaxLength = 2
        Me.txtNumeroToms.Name = "txtNumeroToms"
        Me.txtNumeroToms.Size = New System.Drawing.Size(49, 23)
        Me.txtNumeroToms.TabIndex = 2
        '
        'txtNumeroPlatillos
        '
        Me.txtNumeroPlatillos.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroPlatillos.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumeroPlatillos.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.txtNumeroPlatillos.Location = New System.Drawing.Point(139, 71)
        Me.txtNumeroPlatillos.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNumeroPlatillos.MaxLength = 20
        Me.txtNumeroPlatillos.Name = "txtNumeroPlatillos"
        Me.txtNumeroPlatillos.Size = New System.Drawing.Size(49, 23)
        Me.txtNumeroPlatillos.TabIndex = 13
        '
        'lblNumeroPlatillos
        '
        Me.lblNumeroPlatillos.AutoSize = True
        Me.lblNumeroPlatillos.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumeroPlatillos.Location = New System.Drawing.Point(26, 74)
        Me.lblNumeroPlatillos.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNumeroPlatillos.Name = "lblNumeroPlatillos"
        Me.lblNumeroPlatillos.Size = New System.Drawing.Size(86, 16)
        Me.lblNumeroPlatillos.TabIndex = 0
        Me.lblNumeroPlatillos.Text = "N° platillos"
        '
        'lblNumeroBombos
        '
        Me.lblNumeroBombos.AutoSize = True
        Me.lblNumeroBombos.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumeroBombos.Location = New System.Drawing.Point(26, 115)
        Me.lblNumeroBombos.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNumeroBombos.Name = "lblNumeroBombos"
        Me.lblNumeroBombos.Size = New System.Drawing.Size(87, 16)
        Me.lblNumeroBombos.TabIndex = 0
        Me.lblNumeroBombos.Text = "N° bombos"
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
        Me.groInformacionGeneral.Location = New System.Drawing.Point(25, 13)
        Me.groInformacionGeneral.Margin = New System.Windows.Forms.Padding(4)
        Me.groInformacionGeneral.Name = "groInformacionGeneral"
        Me.groInformacionGeneral.Padding = New System.Windows.Forms.Padding(4)
        Me.groInformacionGeneral.Size = New System.Drawing.Size(272, 177)
        Me.groInformacionGeneral.TabIndex = 24
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
        'txtNumeroBombos
        '
        Me.txtNumeroBombos.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroBombos.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumeroBombos.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.txtNumeroBombos.Location = New System.Drawing.Point(139, 112)
        Me.txtNumeroBombos.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNumeroBombos.MaxLength = 20
        Me.txtNumeroBombos.Name = "txtNumeroBombos"
        Me.txtNumeroBombos.Size = New System.Drawing.Size(49, 23)
        Me.txtNumeroBombos.TabIndex = 14
        '
        'BateriasTableAdapter1
        '
        Me.BateriasTableAdapter1.ClearBeforeFill = True
        '
        'EquiposTableAdapter1
        '
        Me.EquiposTableAdapter1.ClearBeforeFill = True
        '
        'ErrorProviderBaterias
        '
        Me.ErrorProviderBaterias.ContainerControl = Me
        '
        'frmBaterias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(322, 458)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnRegistrar)
        Me.Controls.Add(Me.groInformacionEspecifica)
        Me.Controls.Add(Me.groInformacionGeneral)
        Me.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.Name = "frmBaterias"
        Me.Text = "Baterias"
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.groInformacionGeneral, 0)
        Me.Controls.SetChildIndex(Me.groInformacionEspecifica, 0)
        Me.Controls.SetChildIndex(Me.btnRegistrar, 0)
        Me.Controls.SetChildIndex(Me.btnLimpiar, 0)
        Me.groInformacionEspecifica.ResumeLayout(False)
        Me.groInformacionEspecifica.PerformLayout()
        Me.groInformacionGeneral.ResumeLayout(False)
        Me.groInformacionGeneral.PerformLayout()
        CType(Me.ErrorProviderBaterias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnLimpiar As System.Windows.Forms.Button
    Friend WithEvents btnRegistrar As System.Windows.Forms.Button
    Friend WithEvents groInformacionEspecifica As System.Windows.Forms.GroupBox
    Friend WithEvents txtNumeroBombos As System.Windows.Forms.TextBox
    Friend WithEvents lblNumeroToms As System.Windows.Forms.Label
    Friend WithEvents txtNumeroToms As System.Windows.Forms.TextBox
    Friend WithEvents txtNumeroPlatillos As System.Windows.Forms.TextBox
    Friend WithEvents lblNumeroPlatillos As System.Windows.Forms.Label
    Friend WithEvents lblNumeroBombos As System.Windows.Forms.Label
    Friend WithEvents groInformacionGeneral As System.Windows.Forms.GroupBox
    Public WithEvents txtModelo As System.Windows.Forms.TextBox
    Friend WithEvents txtValorArriendo As System.Windows.Forms.TextBox
    Friend WithEvents lblValorArriendo As System.Windows.Forms.Label
    Friend WithEvents lblMarca As System.Windows.Forms.Label
    Friend WithEvents lblModelo As System.Windows.Forms.Label
    Public WithEvents txtMarca As System.Windows.Forms.TextBox
    Friend WithEvents BateriasTableAdapter1 As Teatro.TeatroDataSetTableAdapters.BATERIASTableAdapter
    Friend WithEvents EquiposTableAdapter1 As Teatro.TeatroDataSetTableAdapters.EQUIPOSTableAdapter
    Friend WithEvents ErrorProviderBaterias As System.Windows.Forms.ErrorProvider
End Class
