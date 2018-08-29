<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegistroEvento
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.PRODUCCIONBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TeatroDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TeatroDataSet = New Teatro.TeatroDataSet
        Me.groInfoEventos = New System.Windows.Forms.GroupBox
        Me.lblFechaEvento = New System.Windows.Forms.Label
        Me.dtpFechaEvento = New System.Windows.Forms.DateTimePicker
        Me.lstboxFechas = New System.Windows.Forms.ListBox
        Me.txtEntradaGeneral = New System.Windows.Forms.TextBox
        Me.btnBorrarFecha = New System.Windows.Forms.Button
        Me.lblValorEntradaGeneral = New System.Windows.Forms.Label
        Me.lblNombreEvento = New System.Windows.Forms.Label
        Me.lblSeleccionFecha = New System.Windows.Forms.Label
        Me.txtNombreEvento = New System.Windows.Forms.TextBox
        Me.chkNoche = New System.Windows.Forms.CheckBox
        Me.chkTarde = New System.Windows.Forms.CheckBox
        Me.chkMatine = New System.Windows.Forms.CheckBox
        Me.ErrorProviderEventos = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.lblBalcones = New System.Windows.Forms.Label
        Me.groJornadas = New System.Windows.Forms.GroupBox
        Me.groUbicaciones = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblMaxPlateaNumerada = New System.Windows.Forms.Label
        Me.UBICACIONESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.lblMaxPlatea = New System.Windows.Forms.Label
        Me.lblMaxBalcones = New System.Windows.Forms.Label
        Me.lblPlateaNumerada = New System.Windows.Forms.Label
        Me.txtPlateaNumerada = New System.Windows.Forms.TextBox
        Me.txtPlatea = New System.Windows.Forms.TextBox
        Me.lblPlatea = New System.Windows.Forms.Label
        Me.txtBalcones = New System.Windows.Forms.TextBox
        Me.ttipRegistroEventos = New System.Windows.Forms.ToolTip(Me.components)
        Me.EVENTOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EVENTOSTableAdapter = New Teatro.TeatroDataSetTableAdapters.EVENTOSTableAdapter
        Me.PRODUCCIONTableAdapter = New Teatro.TeatroDataSetTableAdapters.PRODUCCIONTableAdapter
        Me.EventosjornadasTableAdapter1 = New Teatro.TeatroDataSetTableAdapters.EVENTOSJORNADASTableAdapter
        Me.EventosTableAdapter1 = New Teatro.TeatroDataSetTableAdapters.EVENTOSTableAdapter
        Me.EVENTOSUBICACIONESTableAdapter = New Teatro.TeatroDataSetTableAdapters.EVENTOSUBICACIONESTableAdapter
        Me.UBICACIONESTableAdapter = New Teatro.TeatroDataSetTableAdapters.UBICACIONESTableAdapter
        Me.btnNuevoEvento = New System.Windows.Forms.Button
        Me.btnRegistrarEvento = New System.Windows.Forms.Button
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PRODUCCIONBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TeatroDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TeatroDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groInfoEventos.SuspendLayout()
        CType(Me.ErrorProviderEventos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groJornadas.SuspendLayout()
        Me.groUbicaciones.SuspendLayout()
        CType(Me.UBICACIONESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EVENTOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PRODUCCIONBindingSource
        '
        Me.PRODUCCIONBindingSource.DataMember = "PRODUCCION"
        Me.PRODUCCIONBindingSource.DataSource = Me.TeatroDataSetBindingSource
        '
        'TeatroDataSetBindingSource
        '
        Me.TeatroDataSetBindingSource.DataSource = Me.TeatroDataSet
        Me.TeatroDataSetBindingSource.Position = 0
        '
        'TeatroDataSet
        '
        Me.TeatroDataSet.DataSetName = "TeatroDataSet"
        Me.TeatroDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'groInfoEventos
        '
        Me.groInfoEventos.Controls.Add(Me.lblFechaEvento)
        Me.groInfoEventos.Controls.Add(Me.dtpFechaEvento)
        Me.groInfoEventos.Controls.Add(Me.lstboxFechas)
        Me.groInfoEventos.Controls.Add(Me.txtEntradaGeneral)
        Me.groInfoEventos.Controls.Add(Me.btnBorrarFecha)
        Me.groInfoEventos.Controls.Add(Me.lblValorEntradaGeneral)
        Me.groInfoEventos.Controls.Add(Me.lblNombreEvento)
        Me.groInfoEventos.Controls.Add(Me.lblSeleccionFecha)
        Me.groInfoEventos.Controls.Add(Me.txtNombreEvento)
        Me.groInfoEventos.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groInfoEventos.ForeColor = System.Drawing.Color.White
        Me.groInfoEventos.Location = New System.Drawing.Point(12, 12)
        Me.groInfoEventos.Name = "groInfoEventos"
        Me.groInfoEventos.Size = New System.Drawing.Size(330, 347)
        Me.groInfoEventos.TabIndex = 18
        Me.groInfoEventos.TabStop = False
        Me.groInfoEventos.Text = "Información de eventos"
        '
        'lblFechaEvento
        '
        Me.lblFechaEvento.AutoSize = True
        Me.lblFechaEvento.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaEvento.Location = New System.Drawing.Point(21, 229)
        Me.lblFechaEvento.Name = "lblFechaEvento"
        Me.lblFechaEvento.Size = New System.Drawing.Size(115, 16)
        Me.lblFechaEvento.TabIndex = 6
        Me.lblFechaEvento.Text = "Fechas evento"
        '
        'dtpFechaEvento
        '
        Me.dtpFechaEvento.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dtpFechaEvento.Location = New System.Drawing.Point(164, 138)
        Me.dtpFechaEvento.Name = "dtpFechaEvento"
        Me.dtpFechaEvento.Size = New System.Drawing.Size(143, 23)
        Me.dtpFechaEvento.TabIndex = 3
        '
        'lstboxFechas
        '
        Me.lstboxFechas.FormattingEnabled = True
        Me.lstboxFechas.ItemHeight = 16
        Me.lstboxFechas.Location = New System.Drawing.Point(164, 196)
        Me.lstboxFechas.Name = "lstboxFechas"
        Me.lstboxFechas.Size = New System.Drawing.Size(143, 84)
        Me.lstboxFechas.TabIndex = 4
        Me.ttipRegistroEventos.SetToolTip(Me.lstboxFechas, "Seleccione una fecha")
        '
        'txtEntradaGeneral
        '
        Me.txtEntradaGeneral.Location = New System.Drawing.Point(164, 86)
        Me.txtEntradaGeneral.MaxLength = 6
        Me.txtEntradaGeneral.Name = "txtEntradaGeneral"
        Me.txtEntradaGeneral.Size = New System.Drawing.Size(143, 23)
        Me.txtEntradaGeneral.TabIndex = 2
        '
        'btnBorrarFecha
        '
        Me.btnBorrarFecha.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnBorrarFecha.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnBorrarFecha.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBorrarFecha.Image = Global.Teatro.My.Resources.Resources._stop
        Me.btnBorrarFecha.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBorrarFecha.Location = New System.Drawing.Point(182, 299)
        Me.btnBorrarFecha.Name = "btnBorrarFecha"
        Me.btnBorrarFecha.Size = New System.Drawing.Size(125, 36)
        Me.btnBorrarFecha.TabIndex = 5
        Me.btnBorrarFecha.Text = "Borrar"
        Me.btnBorrarFecha.UseVisualStyleBackColor = False
        '
        'lblValorEntradaGeneral
        '
        Me.lblValorEntradaGeneral.AutoSize = True
        Me.lblValorEntradaGeneral.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValorEntradaGeneral.Location = New System.Drawing.Point(20, 89)
        Me.lblValorEntradaGeneral.Name = "lblValorEntradaGeneral"
        Me.lblValorEntradaGeneral.Size = New System.Drawing.Size(137, 16)
        Me.lblValorEntradaGeneral.TabIndex = 4
        Me.lblValorEntradaGeneral.Text = "Entrada general $"
        '
        'lblNombreEvento
        '
        Me.lblNombreEvento.AutoSize = True
        Me.lblNombreEvento.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreEvento.Location = New System.Drawing.Point(20, 42)
        Me.lblNombreEvento.Name = "lblNombreEvento"
        Me.lblNombreEvento.Size = New System.Drawing.Size(120, 16)
        Me.lblNombreEvento.TabIndex = 0
        Me.lblNombreEvento.Text = "Nombre evento"
        '
        'lblSeleccionFecha
        '
        Me.lblSeleccionFecha.AutoSize = True
        Me.lblSeleccionFecha.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeleccionFecha.Location = New System.Drawing.Point(21, 143)
        Me.lblSeleccionFecha.Name = "lblSeleccionFecha"
        Me.lblSeleccionFecha.Size = New System.Drawing.Size(121, 16)
        Me.lblSeleccionFecha.TabIndex = 1
        Me.lblSeleccionFecha.Text = "Selección fecha"
        '
        'txtNombreEvento
        '
        Me.txtNombreEvento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombreEvento.Location = New System.Drawing.Point(164, 39)
        Me.txtNombreEvento.MaxLength = 20
        Me.txtNombreEvento.Name = "txtNombreEvento"
        Me.txtNombreEvento.Size = New System.Drawing.Size(143, 23)
        Me.txtNombreEvento.TabIndex = 1
        '
        'chkNoche
        '
        Me.chkNoche.AutoSize = True
        Me.chkNoche.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkNoche.Location = New System.Drawing.Point(213, 42)
        Me.chkNoche.Name = "chkNoche"
        Me.chkNoche.Size = New System.Drawing.Size(72, 20)
        Me.chkNoche.TabIndex = 8
        Me.chkNoche.Text = "Noche"
        Me.chkNoche.UseVisualStyleBackColor = True
        '
        'chkTarde
        '
        Me.chkTarde.AutoSize = True
        Me.chkTarde.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkTarde.Location = New System.Drawing.Point(122, 42)
        Me.chkTarde.Name = "chkTarde"
        Me.chkTarde.Size = New System.Drawing.Size(68, 20)
        Me.chkTarde.TabIndex = 7
        Me.chkTarde.Text = "Tarde"
        Me.chkTarde.UseVisualStyleBackColor = True
        '
        'chkMatine
        '
        Me.chkMatine.AutoSize = True
        Me.chkMatine.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMatine.Location = New System.Drawing.Point(22, 42)
        Me.chkMatine.Name = "chkMatine"
        Me.chkMatine.Size = New System.Drawing.Size(76, 20)
        Me.chkMatine.TabIndex = 6
        Me.chkMatine.Text = "Matiné"
        Me.chkMatine.UseVisualStyleBackColor = True
        '
        'ErrorProviderEventos
        '
        Me.ErrorProviderEventos.ContainerControl = Me
        '
        'lblBalcones
        '
        Me.lblBalcones.AutoSize = True
        Me.lblBalcones.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBalcones.Location = New System.Drawing.Point(30, 51)
        Me.lblBalcones.Name = "lblBalcones"
        Me.lblBalcones.Size = New System.Drawing.Size(74, 16)
        Me.lblBalcones.TabIndex = 26
        Me.lblBalcones.Text = "Balcones"
        '
        'groJornadas
        '
        Me.groJornadas.Controls.Add(Me.chkMatine)
        Me.groJornadas.Controls.Add(Me.chkTarde)
        Me.groJornadas.Controls.Add(Me.chkNoche)
        Me.groJornadas.Enabled = False
        Me.groJornadas.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groJornadas.ForeColor = System.Drawing.Color.White
        Me.groJornadas.Location = New System.Drawing.Point(360, 12)
        Me.groJornadas.Name = "groJornadas"
        Me.groJornadas.Size = New System.Drawing.Size(294, 102)
        Me.groJornadas.TabIndex = 5
        Me.groJornadas.TabStop = False
        Me.groJornadas.Text = "Jornadas"
        '
        'groUbicaciones
        '
        Me.groUbicaciones.Controls.Add(Me.Label1)
        Me.groUbicaciones.Controls.Add(Me.lblMaxPlateaNumerada)
        Me.groUbicaciones.Controls.Add(Me.lblMaxPlatea)
        Me.groUbicaciones.Controls.Add(Me.lblMaxBalcones)
        Me.groUbicaciones.Controls.Add(Me.lblPlateaNumerada)
        Me.groUbicaciones.Controls.Add(Me.txtPlateaNumerada)
        Me.groUbicaciones.Controls.Add(Me.txtPlatea)
        Me.groUbicaciones.Controls.Add(Me.lblPlatea)
        Me.groUbicaciones.Controls.Add(Me.txtBalcones)
        Me.groUbicaciones.Controls.Add(Me.lblBalcones)
        Me.groUbicaciones.Enabled = False
        Me.groUbicaciones.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groUbicaciones.ForeColor = System.Drawing.Color.White
        Me.groUbicaciones.Location = New System.Drawing.Point(360, 133)
        Me.groUbicaciones.Name = "groUbicaciones"
        Me.groUbicaciones.Size = New System.Drawing.Size(294, 226)
        Me.groUbicaciones.TabIndex = 9
        Me.groUbicaciones.TabStop = False
        Me.groUbicaciones.Text = "Cantidad de asientos para:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(235, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 16)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Max."
        '
        'lblMaxPlateaNumerada
        '
        Me.lblMaxPlateaNumerada.AutoSize = True
        Me.lblMaxPlateaNumerada.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UBICACIONESBindingSource, "PLATEANUMERADA", True))
        Me.lblMaxPlateaNumerada.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMaxPlateaNumerada.ForeColor = System.Drawing.Color.Chocolate
        Me.lblMaxPlateaNumerada.Location = New System.Drawing.Point(235, 158)
        Me.lblMaxPlateaNumerada.Name = "lblMaxPlateaNumerada"
        Me.lblMaxPlateaNumerada.Size = New System.Drawing.Size(17, 16)
        Me.lblMaxPlateaNumerada.TabIndex = 31
        Me.lblMaxPlateaNumerada.Text = ". "
        '
        'UBICACIONESBindingSource
        '
        Me.UBICACIONESBindingSource.DataMember = "UBICACIONES"
        Me.UBICACIONESBindingSource.DataSource = Me.TeatroDataSet
        '
        'lblMaxPlatea
        '
        Me.lblMaxPlatea.AutoSize = True
        Me.lblMaxPlatea.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UBICACIONESBindingSource, "PLATEA", True))
        Me.lblMaxPlatea.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMaxPlatea.ForeColor = System.Drawing.Color.Chocolate
        Me.lblMaxPlatea.Location = New System.Drawing.Point(235, 103)
        Me.lblMaxPlatea.Name = "lblMaxPlatea"
        Me.lblMaxPlatea.Size = New System.Drawing.Size(13, 16)
        Me.lblMaxPlatea.TabIndex = 30
        Me.lblMaxPlatea.Text = "."
        '
        'lblMaxBalcones
        '
        Me.lblMaxBalcones.AutoSize = True
        Me.lblMaxBalcones.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UBICACIONESBindingSource, "BALCONES", True))
        Me.lblMaxBalcones.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMaxBalcones.ForeColor = System.Drawing.Color.Chocolate
        Me.lblMaxBalcones.Location = New System.Drawing.Point(235, 51)
        Me.lblMaxBalcones.Name = "lblMaxBalcones"
        Me.lblMaxBalcones.Size = New System.Drawing.Size(13, 16)
        Me.lblMaxBalcones.TabIndex = 29
        Me.lblMaxBalcones.Text = "."
        '
        'lblPlateaNumerada
        '
        Me.lblPlateaNumerada.AutoSize = True
        Me.lblPlateaNumerada.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlateaNumerada.Location = New System.Drawing.Point(11, 158)
        Me.lblPlateaNumerada.Name = "lblPlateaNumerada"
        Me.lblPlateaNumerada.Size = New System.Drawing.Size(132, 16)
        Me.lblPlateaNumerada.TabIndex = 28
        Me.lblPlateaNumerada.Text = "Platea numerada"
        '
        'txtPlateaNumerada
        '
        Me.txtPlateaNumerada.Location = New System.Drawing.Point(152, 155)
        Me.txtPlateaNumerada.MaxLength = 3
        Me.txtPlateaNumerada.Name = "txtPlateaNumerada"
        Me.txtPlateaNumerada.Size = New System.Drawing.Size(47, 23)
        Me.txtPlateaNumerada.TabIndex = 12
        '
        'txtPlatea
        '
        Me.txtPlatea.Location = New System.Drawing.Point(152, 100)
        Me.txtPlatea.MaxLength = 3
        Me.txtPlatea.Name = "txtPlatea"
        Me.txtPlatea.Size = New System.Drawing.Size(47, 23)
        Me.txtPlatea.TabIndex = 11
        '
        'lblPlatea
        '
        Me.lblPlatea.AutoSize = True
        Me.lblPlatea.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlatea.Location = New System.Drawing.Point(41, 103)
        Me.lblPlatea.Name = "lblPlatea"
        Me.lblPlatea.Size = New System.Drawing.Size(54, 16)
        Me.lblPlatea.TabIndex = 28
        Me.lblPlatea.Text = "Platea"
        '
        'txtBalcones
        '
        Me.txtBalcones.Location = New System.Drawing.Point(152, 51)
        Me.txtBalcones.MaxLength = 3
        Me.txtBalcones.Name = "txtBalcones"
        Me.txtBalcones.Size = New System.Drawing.Size(47, 23)
        Me.txtBalcones.TabIndex = 10
        '
        'ttipRegistroEventos
        '
        Me.ttipRegistroEventos.IsBalloon = True
        Me.ttipRegistroEventos.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        '
        'EVENTOSBindingSource
        '
        Me.EVENTOSBindingSource.DataMember = "EVENTOS"
        Me.EVENTOSBindingSource.DataSource = Me.TeatroDataSet
        '
        'EVENTOSTableAdapter
        '
        Me.EVENTOSTableAdapter.ClearBeforeFill = True
        '
        'PRODUCCIONTableAdapter
        '
        Me.PRODUCCIONTableAdapter.ClearBeforeFill = True
        '
        'EventosjornadasTableAdapter1
        '
        Me.EventosjornadasTableAdapter1.ClearBeforeFill = True
        '
        'EventosTableAdapter1
        '
        Me.EventosTableAdapter1.ClearBeforeFill = True
        '
        'EVENTOSUBICACIONESTableAdapter
        '
        Me.EVENTOSUBICACIONESTableAdapter.ClearBeforeFill = True
        '
        'UBICACIONESTableAdapter
        '
        Me.UBICACIONESTableAdapter.ClearBeforeFill = True
        '
        'btnNuevoEvento
        '
        Me.btnNuevoEvento.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnNuevoEvento.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevoEvento.Image = Global.Teatro.My.Resources.Resources.application_add
        Me.btnNuevoEvento.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNuevoEvento.Location = New System.Drawing.Point(57, 365)
        Me.btnNuevoEvento.Name = "btnNuevoEvento"
        Me.btnNuevoEvento.Size = New System.Drawing.Size(97, 37)
        Me.btnNuevoEvento.TabIndex = 15
        Me.btnNuevoEvento.Text = "Nuevo"
        Me.btnNuevoEvento.UseVisualStyleBackColor = False
        '
        'btnRegistrarEvento
        '
        Me.btnRegistrarEvento.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnRegistrarEvento.Enabled = False
        Me.btnRegistrarEvento.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistrarEvento.Image = Global.Teatro.My.Resources.Resources.button_ok
        Me.btnRegistrarEvento.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRegistrarEvento.Location = New System.Drawing.Point(504, 365)
        Me.btnRegistrarEvento.Name = "btnRegistrarEvento"
        Me.btnRegistrarEvento.Size = New System.Drawing.Size(134, 37)
        Me.btnRegistrarEvento.TabIndex = 13
        Me.btnRegistrarEvento.Text = "Registrar"
        Me.btnRegistrarEvento.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 10
        '
        'frmRegistroEvento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSlateGray
        Me.ClientSize = New System.Drawing.Size(668, 420)
        Me.Controls.Add(Me.btnNuevoEvento)
        Me.Controls.Add(Me.groUbicaciones)
        Me.Controls.Add(Me.groJornadas)
        Me.Controls.Add(Me.btnRegistrarEvento)
        Me.Controls.Add(Me.groInfoEventos)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRegistroEvento"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro de eventos"
        CType(Me.PRODUCCIONBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TeatroDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TeatroDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groInfoEventos.ResumeLayout(False)
        Me.groInfoEventos.PerformLayout()
        CType(Me.ErrorProviderEventos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groJornadas.ResumeLayout(False)
        Me.groJornadas.PerformLayout()
        Me.groUbicaciones.ResumeLayout(False)
        Me.groUbicaciones.PerformLayout()
        CType(Me.UBICACIONESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EVENTOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TeatroDataSet As Teatro.TeatroDataSet
    Friend WithEvents EVENTOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EVENTOSTableAdapter As Teatro.TeatroDataSetTableAdapters.EVENTOSTableAdapter
    Friend WithEvents PRODUCCIONTableAdapter As Teatro.TeatroDataSetTableAdapters.PRODUCCIONTableAdapter
    Friend WithEvents PRODUCCIONBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TeatroDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents groInfoEventos As System.Windows.Forms.GroupBox
    Friend WithEvents txtEntradaGeneral As System.Windows.Forms.TextBox
    Friend WithEvents lblValorEntradaGeneral As System.Windows.Forms.Label
    Friend WithEvents lblNombreEvento As System.Windows.Forms.Label
    Friend WithEvents lblSeleccionFecha As System.Windows.Forms.Label
    Friend WithEvents txtNombreEvento As System.Windows.Forms.TextBox
    Friend WithEvents btnRegistrarEvento As System.Windows.Forms.Button
    Friend WithEvents ErrorProviderEventos As System.Windows.Forms.ErrorProvider
    Friend WithEvents chkNoche As System.Windows.Forms.CheckBox
    Friend WithEvents chkTarde As System.Windows.Forms.CheckBox
    Friend WithEvents chkMatine As System.Windows.Forms.CheckBox
    Friend WithEvents EventosjornadasTableAdapter1 As Teatro.TeatroDataSetTableAdapters.EVENTOSJORNADASTableAdapter
    Friend WithEvents groJornadas As System.Windows.Forms.GroupBox
    Friend WithEvents EventosTableAdapter1 As Teatro.TeatroDataSetTableAdapters.EVENTOSTableAdapter
    Friend WithEvents EVENTOSUBICACIONESTableAdapter As Teatro.TeatroDataSetTableAdapters.EVENTOSUBICACIONESTableAdapter
    Friend WithEvents btnBorrarFecha As System.Windows.Forms.Button
    Friend WithEvents btnNuevoEvento As System.Windows.Forms.Button
    Friend WithEvents lstboxFechas As System.Windows.Forms.ListBox
    Friend WithEvents dtpFechaEvento As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblFechaEvento As System.Windows.Forms.Label
    Friend WithEvents ttipRegistroEventos As System.Windows.Forms.ToolTip
    Protected WithEvents lblBalcones As System.Windows.Forms.Label
    Protected WithEvents groUbicaciones As System.Windows.Forms.GroupBox
    Protected WithEvents lblPlatea As System.Windows.Forms.Label
    Protected WithEvents txtBalcones As System.Windows.Forms.TextBox
    Protected WithEvents lblPlateaNumerada As System.Windows.Forms.Label
    Protected WithEvents txtPlateaNumerada As System.Windows.Forms.TextBox
    Protected WithEvents txtPlatea As System.Windows.Forms.TextBox
    Protected WithEvents lblMaxPlateaNumerada As System.Windows.Forms.Label
    Protected WithEvents lblMaxPlatea As System.Windows.Forms.Label
    Protected WithEvents lblMaxBalcones As System.Windows.Forms.Label
    Friend WithEvents UBICACIONESBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UBICACIONESTableAdapter As Teatro.TeatroDataSetTableAdapters.UBICACIONESTableAdapter
    Protected WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
