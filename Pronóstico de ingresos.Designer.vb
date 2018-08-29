<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPronosticoIngresos
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
        Me.groBalcones = New System.Windows.Forms.GroupBox
        Me.nupEstudiante = New System.Windows.Forms.NumericUpDown
        Me.nupNiño = New System.Windows.Forms.NumericUpDown
        Me.nupTerceraEdad = New System.Windows.Forms.NumericUpDown
        Me.nupAdulto = New System.Windows.Forms.NumericUpDown
        Me.lblEstudiante = New System.Windows.Forms.Label
        Me.lblTerceraEdad = New System.Windows.Forms.Label
        Me.lblNiño = New System.Windows.Forms.Label
        Me.lblAdulto = New System.Windows.Forms.Label
        Me.groPlatea = New System.Windows.Forms.GroupBox
        Me.nupEstudiante3 = New System.Windows.Forms.NumericUpDown
        Me.nupNiño3 = New System.Windows.Forms.NumericUpDown
        Me.nupTerceraEdad3 = New System.Windows.Forms.NumericUpDown
        Me.nupAdulto3 = New System.Windows.Forms.NumericUpDown
        Me.lblEstudiante3 = New System.Windows.Forms.Label
        Me.lblTerceraEdad3 = New System.Windows.Forms.Label
        Me.lblNiño3 = New System.Windows.Forms.Label
        Me.lblAdulto3 = New System.Windows.Forms.Label
        Me.groPlateaNumerada = New System.Windows.Forms.GroupBox
        Me.nupEstudiante2 = New System.Windows.Forms.NumericUpDown
        Me.nupNiño2 = New System.Windows.Forms.NumericUpDown
        Me.nupTerceraEdad2 = New System.Windows.Forms.NumericUpDown
        Me.nupAdulto2 = New System.Windows.Forms.NumericUpDown
        Me.lblEstudiante2 = New System.Windows.Forms.Label
        Me.lblTerceraEdad2 = New System.Windows.Forms.Label
        Me.lblNiño2 = New System.Windows.Forms.Label
        Me.lblAdulto2 = New System.Windows.Forms.Label
        Me.groUbicaciones = New System.Windows.Forms.GroupBox
        Me.txtValorEntradaGeneral = New System.Windows.Forms.TextBox
        Me.nupPlateaNumerada = New System.Windows.Forms.NumericUpDown
        Me.nupPlatea = New System.Windows.Forms.NumericUpDown
        Me.nupBalcones = New System.Windows.Forms.NumericUpDown
        Me.lblPlatea = New System.Windows.Forms.Label
        Me.lblPrecioEntradaGeneral = New System.Windows.Forms.Label
        Me.lblPlateaNumerada = New System.Windows.Forms.Label
        Me.lblBalcones = New System.Windows.Forms.Label
        Me.btnPronosticar = New System.Windows.Forms.Button
        Me.UbicacionesTableAdapter1 = New Teatro.TeatroDataSetTableAdapters.UBICACIONESTableAdapter
        Me.ErrorProviderEventos = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.groBalcones.SuspendLayout()
        CType(Me.nupEstudiante, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nupNiño, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nupTerceraEdad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nupAdulto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groPlatea.SuspendLayout()
        CType(Me.nupEstudiante3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nupNiño3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nupTerceraEdad3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nupAdulto3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groPlateaNumerada.SuspendLayout()
        CType(Me.nupEstudiante2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nupNiño2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nupTerceraEdad2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nupAdulto2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groUbicaciones.SuspendLayout()
        CType(Me.nupPlateaNumerada, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nupPlatea, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nupBalcones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProviderEventos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'groBalcones
        '
        Me.groBalcones.Controls.Add(Me.nupEstudiante)
        Me.groBalcones.Controls.Add(Me.nupNiño)
        Me.groBalcones.Controls.Add(Me.nupTerceraEdad)
        Me.groBalcones.Controls.Add(Me.nupAdulto)
        Me.groBalcones.Controls.Add(Me.lblEstudiante)
        Me.groBalcones.Controls.Add(Me.lblTerceraEdad)
        Me.groBalcones.Controls.Add(Me.lblNiño)
        Me.groBalcones.Controls.Add(Me.lblAdulto)
        Me.groBalcones.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groBalcones.ForeColor = System.Drawing.Color.White
        Me.groBalcones.Location = New System.Drawing.Point(12, 188)
        Me.groBalcones.Name = "groBalcones"
        Me.groBalcones.Size = New System.Drawing.Size(205, 144)
        Me.groBalcones.TabIndex = 19
        Me.groBalcones.TabStop = False
        Me.groBalcones.Text = "Balcones"
        '
        'nupEstudiante
        '
        Me.nupEstudiante.Location = New System.Drawing.Point(135, 108)
        Me.nupEstudiante.Name = "nupEstudiante"
        Me.nupEstudiante.Size = New System.Drawing.Size(54, 23)
        Me.nupEstudiante.TabIndex = 8
        '
        'nupNiño
        '
        Me.nupNiño.Location = New System.Drawing.Point(135, 80)
        Me.nupNiño.Name = "nupNiño"
        Me.nupNiño.Size = New System.Drawing.Size(54, 23)
        Me.nupNiño.TabIndex = 7
        '
        'nupTerceraEdad
        '
        Me.nupTerceraEdad.Location = New System.Drawing.Point(135, 52)
        Me.nupTerceraEdad.Name = "nupTerceraEdad"
        Me.nupTerceraEdad.Size = New System.Drawing.Size(54, 23)
        Me.nupTerceraEdad.TabIndex = 6
        '
        'nupAdulto
        '
        Me.nupAdulto.Location = New System.Drawing.Point(135, 25)
        Me.nupAdulto.Name = "nupAdulto"
        Me.nupAdulto.Size = New System.Drawing.Size(54, 23)
        Me.nupAdulto.TabIndex = 5
        '
        'lblEstudiante
        '
        Me.lblEstudiante.AutoSize = True
        Me.lblEstudiante.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstudiante.Location = New System.Drawing.Point(16, 110)
        Me.lblEstudiante.Name = "lblEstudiante"
        Me.lblEstudiante.Size = New System.Drawing.Size(86, 16)
        Me.lblEstudiante.TabIndex = 2
        Me.lblEstudiante.Text = "Estudiante"
        '
        'lblTerceraEdad
        '
        Me.lblTerceraEdad.AutoSize = True
        Me.lblTerceraEdad.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTerceraEdad.Location = New System.Drawing.Point(16, 54)
        Me.lblTerceraEdad.Name = "lblTerceraEdad"
        Me.lblTerceraEdad.Size = New System.Drawing.Size(103, 16)
        Me.lblTerceraEdad.TabIndex = 2
        Me.lblTerceraEdad.Text = "Tercera edad"
        '
        'lblNiño
        '
        Me.lblNiño.AutoSize = True
        Me.lblNiño.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNiño.Location = New System.Drawing.Point(16, 82)
        Me.lblNiño.Name = "lblNiño"
        Me.lblNiño.Size = New System.Drawing.Size(40, 16)
        Me.lblNiño.TabIndex = 2
        Me.lblNiño.Text = "Niño"
        '
        'lblAdulto
        '
        Me.lblAdulto.AutoSize = True
        Me.lblAdulto.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdulto.Location = New System.Drawing.Point(16, 27)
        Me.lblAdulto.Name = "lblAdulto"
        Me.lblAdulto.Size = New System.Drawing.Size(55, 16)
        Me.lblAdulto.TabIndex = 1
        Me.lblAdulto.Text = "Adulto"
        '
        'groPlatea
        '
        Me.groPlatea.Controls.Add(Me.nupEstudiante3)
        Me.groPlatea.Controls.Add(Me.nupNiño3)
        Me.groPlatea.Controls.Add(Me.nupTerceraEdad3)
        Me.groPlatea.Controls.Add(Me.nupAdulto3)
        Me.groPlatea.Controls.Add(Me.lblEstudiante3)
        Me.groPlatea.Controls.Add(Me.lblTerceraEdad3)
        Me.groPlatea.Controls.Add(Me.lblNiño3)
        Me.groPlatea.Controls.Add(Me.lblAdulto3)
        Me.groPlatea.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groPlatea.ForeColor = System.Drawing.Color.White
        Me.groPlatea.Location = New System.Drawing.Point(12, 342)
        Me.groPlatea.Name = "groPlatea"
        Me.groPlatea.Size = New System.Drawing.Size(205, 144)
        Me.groPlatea.TabIndex = 20
        Me.groPlatea.TabStop = False
        Me.groPlatea.Text = "Platea"
        '
        'nupEstudiante3
        '
        Me.nupEstudiante3.Location = New System.Drawing.Point(134, 106)
        Me.nupEstudiante3.Name = "nupEstudiante3"
        Me.nupEstudiante3.Size = New System.Drawing.Size(54, 23)
        Me.nupEstudiante3.TabIndex = 12
        '
        'nupNiño3
        '
        Me.nupNiño3.Location = New System.Drawing.Point(134, 78)
        Me.nupNiño3.Name = "nupNiño3"
        Me.nupNiño3.Size = New System.Drawing.Size(54, 23)
        Me.nupNiño3.TabIndex = 11
        '
        'nupTerceraEdad3
        '
        Me.nupTerceraEdad3.Location = New System.Drawing.Point(134, 50)
        Me.nupTerceraEdad3.Name = "nupTerceraEdad3"
        Me.nupTerceraEdad3.Size = New System.Drawing.Size(54, 23)
        Me.nupTerceraEdad3.TabIndex = 10
        '
        'nupAdulto3
        '
        Me.nupAdulto3.Location = New System.Drawing.Point(134, 23)
        Me.nupAdulto3.Name = "nupAdulto3"
        Me.nupAdulto3.Size = New System.Drawing.Size(54, 23)
        Me.nupAdulto3.TabIndex = 9
        '
        'lblEstudiante3
        '
        Me.lblEstudiante3.AutoSize = True
        Me.lblEstudiante3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstudiante3.Location = New System.Drawing.Point(15, 108)
        Me.lblEstudiante3.Name = "lblEstudiante3"
        Me.lblEstudiante3.Size = New System.Drawing.Size(86, 16)
        Me.lblEstudiante3.TabIndex = 2
        Me.lblEstudiante3.Text = "Estudiante"
        '
        'lblTerceraEdad3
        '
        Me.lblTerceraEdad3.AutoSize = True
        Me.lblTerceraEdad3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTerceraEdad3.Location = New System.Drawing.Point(15, 52)
        Me.lblTerceraEdad3.Name = "lblTerceraEdad3"
        Me.lblTerceraEdad3.Size = New System.Drawing.Size(103, 16)
        Me.lblTerceraEdad3.TabIndex = 2
        Me.lblTerceraEdad3.Text = "Tercera edad"
        '
        'lblNiño3
        '
        Me.lblNiño3.AutoSize = True
        Me.lblNiño3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNiño3.Location = New System.Drawing.Point(15, 80)
        Me.lblNiño3.Name = "lblNiño3"
        Me.lblNiño3.Size = New System.Drawing.Size(40, 16)
        Me.lblNiño3.TabIndex = 2
        Me.lblNiño3.Text = "Niño"
        '
        'lblAdulto3
        '
        Me.lblAdulto3.AutoSize = True
        Me.lblAdulto3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdulto3.Location = New System.Drawing.Point(15, 25)
        Me.lblAdulto3.Name = "lblAdulto3"
        Me.lblAdulto3.Size = New System.Drawing.Size(55, 16)
        Me.lblAdulto3.TabIndex = 1
        Me.lblAdulto3.Text = "Adulto"
        '
        'groPlateaNumerada
        '
        Me.groPlateaNumerada.Controls.Add(Me.nupEstudiante2)
        Me.groPlateaNumerada.Controls.Add(Me.nupNiño2)
        Me.groPlateaNumerada.Controls.Add(Me.nupTerceraEdad2)
        Me.groPlateaNumerada.Controls.Add(Me.nupAdulto2)
        Me.groPlateaNumerada.Controls.Add(Me.lblEstudiante2)
        Me.groPlateaNumerada.Controls.Add(Me.lblTerceraEdad2)
        Me.groPlateaNumerada.Controls.Add(Me.lblNiño2)
        Me.groPlateaNumerada.Controls.Add(Me.lblAdulto2)
        Me.groPlateaNumerada.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groPlateaNumerada.ForeColor = System.Drawing.Color.White
        Me.groPlateaNumerada.Location = New System.Drawing.Point(232, 188)
        Me.groPlateaNumerada.Name = "groPlateaNumerada"
        Me.groPlateaNumerada.Size = New System.Drawing.Size(205, 144)
        Me.groPlateaNumerada.TabIndex = 21
        Me.groPlateaNumerada.TabStop = False
        Me.groPlateaNumerada.Text = "Platea numerada"
        '
        'nupEstudiante2
        '
        Me.nupEstudiante2.Location = New System.Drawing.Point(134, 106)
        Me.nupEstudiante2.Name = "nupEstudiante2"
        Me.nupEstudiante2.Size = New System.Drawing.Size(54, 23)
        Me.nupEstudiante2.TabIndex = 16
        '
        'nupNiño2
        '
        Me.nupNiño2.Location = New System.Drawing.Point(134, 78)
        Me.nupNiño2.Name = "nupNiño2"
        Me.nupNiño2.Size = New System.Drawing.Size(54, 23)
        Me.nupNiño2.TabIndex = 15
        '
        'nupTerceraEdad2
        '
        Me.nupTerceraEdad2.Location = New System.Drawing.Point(134, 50)
        Me.nupTerceraEdad2.Name = "nupTerceraEdad2"
        Me.nupTerceraEdad2.Size = New System.Drawing.Size(54, 23)
        Me.nupTerceraEdad2.TabIndex = 14
        '
        'nupAdulto2
        '
        Me.nupAdulto2.Location = New System.Drawing.Point(134, 23)
        Me.nupAdulto2.Name = "nupAdulto2"
        Me.nupAdulto2.Size = New System.Drawing.Size(54, 23)
        Me.nupAdulto2.TabIndex = 13
        '
        'lblEstudiante2
        '
        Me.lblEstudiante2.AutoSize = True
        Me.lblEstudiante2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstudiante2.Location = New System.Drawing.Point(15, 108)
        Me.lblEstudiante2.Name = "lblEstudiante2"
        Me.lblEstudiante2.Size = New System.Drawing.Size(86, 16)
        Me.lblEstudiante2.TabIndex = 2
        Me.lblEstudiante2.Text = "Estudiante"
        '
        'lblTerceraEdad2
        '
        Me.lblTerceraEdad2.AutoSize = True
        Me.lblTerceraEdad2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTerceraEdad2.Location = New System.Drawing.Point(15, 52)
        Me.lblTerceraEdad2.Name = "lblTerceraEdad2"
        Me.lblTerceraEdad2.Size = New System.Drawing.Size(103, 16)
        Me.lblTerceraEdad2.TabIndex = 2
        Me.lblTerceraEdad2.Text = "Tercera edad"
        '
        'lblNiño2
        '
        Me.lblNiño2.AutoSize = True
        Me.lblNiño2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNiño2.Location = New System.Drawing.Point(15, 80)
        Me.lblNiño2.Name = "lblNiño2"
        Me.lblNiño2.Size = New System.Drawing.Size(40, 16)
        Me.lblNiño2.TabIndex = 2
        Me.lblNiño2.Text = "Niño"
        '
        'lblAdulto2
        '
        Me.lblAdulto2.AutoSize = True
        Me.lblAdulto2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdulto2.Location = New System.Drawing.Point(15, 25)
        Me.lblAdulto2.Name = "lblAdulto2"
        Me.lblAdulto2.Size = New System.Drawing.Size(55, 16)
        Me.lblAdulto2.TabIndex = 1
        Me.lblAdulto2.Text = "Adulto"
        '
        'groUbicaciones
        '
        Me.groUbicaciones.Controls.Add(Me.txtValorEntradaGeneral)
        Me.groUbicaciones.Controls.Add(Me.nupPlateaNumerada)
        Me.groUbicaciones.Controls.Add(Me.nupPlatea)
        Me.groUbicaciones.Controls.Add(Me.nupBalcones)
        Me.groUbicaciones.Controls.Add(Me.lblPlatea)
        Me.groUbicaciones.Controls.Add(Me.lblPrecioEntradaGeneral)
        Me.groUbicaciones.Controls.Add(Me.lblPlateaNumerada)
        Me.groUbicaciones.Controls.Add(Me.lblBalcones)
        Me.groUbicaciones.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groUbicaciones.ForeColor = System.Drawing.Color.White
        Me.groUbicaciones.Location = New System.Drawing.Point(12, 12)
        Me.groUbicaciones.Name = "groUbicaciones"
        Me.groUbicaciones.Size = New System.Drawing.Size(326, 161)
        Me.groUbicaciones.TabIndex = 18
        Me.groUbicaciones.TabStop = False
        Me.groUbicaciones.Text = "Ubicaciones"
        '
        'txtValorEntradaGeneral
        '
        Me.txtValorEntradaGeneral.Location = New System.Drawing.Point(202, 118)
        Me.txtValorEntradaGeneral.Name = "txtValorEntradaGeneral"
        Me.txtValorEntradaGeneral.Size = New System.Drawing.Size(100, 23)
        Me.txtValorEntradaGeneral.TabIndex = 4
        '
        'nupPlateaNumerada
        '
        Me.nupPlateaNumerada.Location = New System.Drawing.Point(202, 85)
        Me.nupPlateaNumerada.Name = "nupPlateaNumerada"
        Me.nupPlateaNumerada.Size = New System.Drawing.Size(64, 23)
        Me.nupPlateaNumerada.TabIndex = 3
        '
        'nupPlatea
        '
        Me.nupPlatea.Location = New System.Drawing.Point(202, 55)
        Me.nupPlatea.Name = "nupPlatea"
        Me.nupPlatea.Size = New System.Drawing.Size(64, 23)
        Me.nupPlatea.TabIndex = 2
        '
        'nupBalcones
        '
        Me.nupBalcones.Location = New System.Drawing.Point(202, 25)
        Me.nupBalcones.Name = "nupBalcones"
        Me.nupBalcones.Size = New System.Drawing.Size(64, 23)
        Me.nupBalcones.TabIndex = 1
        '
        'lblPlatea
        '
        Me.lblPlatea.AutoSize = True
        Me.lblPlatea.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlatea.Location = New System.Drawing.Point(24, 57)
        Me.lblPlatea.Name = "lblPlatea"
        Me.lblPlatea.Size = New System.Drawing.Size(54, 16)
        Me.lblPlatea.TabIndex = 2
        Me.lblPlatea.Text = "Platea"
        '
        'lblPrecioEntradaGeneral
        '
        Me.lblPrecioEntradaGeneral.AutoSize = True
        Me.lblPrecioEntradaGeneral.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrecioEntradaGeneral.Location = New System.Drawing.Point(24, 121)
        Me.lblPrecioEntradaGeneral.Name = "lblPrecioEntradaGeneral"
        Me.lblPrecioEntradaGeneral.Size = New System.Drawing.Size(173, 16)
        Me.lblPrecioEntradaGeneral.TabIndex = 2
        Me.lblPrecioEntradaGeneral.Text = "Precio entrada general"
        '
        'lblPlateaNumerada
        '
        Me.lblPlateaNumerada.AutoSize = True
        Me.lblPlateaNumerada.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlateaNumerada.Location = New System.Drawing.Point(24, 87)
        Me.lblPlateaNumerada.Name = "lblPlateaNumerada"
        Me.lblPlateaNumerada.Size = New System.Drawing.Size(132, 16)
        Me.lblPlateaNumerada.TabIndex = 2
        Me.lblPlateaNumerada.Text = "Platea numerada"
        '
        'lblBalcones
        '
        Me.lblBalcones.AutoSize = True
        Me.lblBalcones.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBalcones.Location = New System.Drawing.Point(24, 27)
        Me.lblBalcones.Name = "lblBalcones"
        Me.lblBalcones.Size = New System.Drawing.Size(74, 16)
        Me.lblBalcones.TabIndex = 1
        Me.lblBalcones.Text = "Balcones"
        '
        'btnPronosticar
        '
        Me.btnPronosticar.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnPronosticar.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPronosticar.Image = Global.Teatro.My.Resources.Resources.button_ok
        Me.btnPronosticar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPronosticar.Location = New System.Drawing.Point(260, 423)
        Me.btnPronosticar.Name = "btnPronosticar"
        Me.btnPronosticar.Size = New System.Drawing.Size(142, 41)
        Me.btnPronosticar.TabIndex = 17
        Me.btnPronosticar.Text = "Pronosticar"
        Me.btnPronosticar.UseVisualStyleBackColor = False
        '
        'UbicacionesTableAdapter1
        '
        Me.UbicacionesTableAdapter1.ClearBeforeFill = True
        '
        'ErrorProviderEventos
        '
        Me.ErrorProviderEventos.ContainerControl = Me
        '
        'frmPronosticoIngresos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(451, 526)
        Me.Controls.Add(Me.btnPronosticar)
        Me.Controls.Add(Me.groUbicaciones)
        Me.Controls.Add(Me.groPlateaNumerada)
        Me.Controls.Add(Me.groPlatea)
        Me.Controls.Add(Me.groBalcones)
        Me.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.Name = "frmPronosticoIngresos"
        Me.Text = "Pronóstico de ingresos"
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.groBalcones, 0)
        Me.Controls.SetChildIndex(Me.groPlatea, 0)
        Me.Controls.SetChildIndex(Me.groPlateaNumerada, 0)
        Me.Controls.SetChildIndex(Me.groUbicaciones, 0)
        Me.Controls.SetChildIndex(Me.btnPronosticar, 0)
        Me.groBalcones.ResumeLayout(False)
        Me.groBalcones.PerformLayout()
        CType(Me.nupEstudiante, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nupNiño, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nupTerceraEdad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nupAdulto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groPlatea.ResumeLayout(False)
        Me.groPlatea.PerformLayout()
        CType(Me.nupEstudiante3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nupNiño3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nupTerceraEdad3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nupAdulto3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groPlateaNumerada.ResumeLayout(False)
        Me.groPlateaNumerada.PerformLayout()
        CType(Me.nupEstudiante2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nupNiño2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nupTerceraEdad2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nupAdulto2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groUbicaciones.ResumeLayout(False)
        Me.groUbicaciones.PerformLayout()
        CType(Me.nupPlateaNumerada, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nupPlatea, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nupBalcones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProviderEventos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents groBalcones As System.Windows.Forms.GroupBox
    Friend WithEvents lblAdulto As System.Windows.Forms.Label
    Friend WithEvents nupEstudiante As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblEstudiante As System.Windows.Forms.Label
    Friend WithEvents lblTerceraEdad As System.Windows.Forms.Label
    Friend WithEvents lblNiño As System.Windows.Forms.Label
    Friend WithEvents groPlatea As System.Windows.Forms.GroupBox
    Friend WithEvents lblEstudiante3 As System.Windows.Forms.Label
    Friend WithEvents lblTerceraEdad3 As System.Windows.Forms.Label
    Friend WithEvents lblNiño3 As System.Windows.Forms.Label
    Friend WithEvents lblAdulto3 As System.Windows.Forms.Label
    Friend WithEvents groPlateaNumerada As System.Windows.Forms.GroupBox
    Friend WithEvents lblEstudiante2 As System.Windows.Forms.Label
    Friend WithEvents lblTerceraEdad2 As System.Windows.Forms.Label
    Friend WithEvents lblNiño2 As System.Windows.Forms.Label
    Friend WithEvents lblAdulto2 As System.Windows.Forms.Label
    Friend WithEvents groUbicaciones As System.Windows.Forms.GroupBox
    Friend WithEvents nupPlateaNumerada As System.Windows.Forms.NumericUpDown
    Friend WithEvents nupPlatea As System.Windows.Forms.NumericUpDown
    Friend WithEvents nupBalcones As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblPlatea As System.Windows.Forms.Label
    Friend WithEvents lblPlateaNumerada As System.Windows.Forms.Label
    Friend WithEvents lblBalcones As System.Windows.Forms.Label
    Friend WithEvents lblPrecioEntradaGeneral As System.Windows.Forms.Label
    Friend WithEvents btnPronosticar As System.Windows.Forms.Button
    Friend WithEvents UbicacionesTableAdapter1 As Teatro.TeatroDataSetTableAdapters.UBICACIONESTableAdapter
    Friend WithEvents ErrorProviderEventos As System.Windows.Forms.ErrorProvider
    Public WithEvents nupNiño As System.Windows.Forms.NumericUpDown
    Public WithEvents nupTerceraEdad As System.Windows.Forms.NumericUpDown
    Public WithEvents nupAdulto As System.Windows.Forms.NumericUpDown
    Public WithEvents nupEstudiante3 As System.Windows.Forms.NumericUpDown
    Public WithEvents nupNiño3 As System.Windows.Forms.NumericUpDown
    Public WithEvents nupTerceraEdad3 As System.Windows.Forms.NumericUpDown
    Public WithEvents nupAdulto3 As System.Windows.Forms.NumericUpDown
    Public WithEvents nupEstudiante2 As System.Windows.Forms.NumericUpDown
    Public WithEvents nupNiño2 As System.Windows.Forms.NumericUpDown
    Public WithEvents nupTerceraEdad2 As System.Windows.Forms.NumericUpDown
    Public WithEvents nupAdulto2 As System.Windows.Forms.NumericUpDown
    Public WithEvents txtValorEntradaGeneral As System.Windows.Forms.TextBox
End Class
