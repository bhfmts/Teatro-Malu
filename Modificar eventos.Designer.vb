<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmModificarEventos
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.groUbicaciones = New System.Windows.Forms.GroupBox
        Me.lblMaxPlateaNumerada = New System.Windows.Forms.Label
        Me.UBICACIONESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TeatroDataSet = New Teatro.TeatroDataSet
        Me.lblMaxPlatea = New System.Windows.Forms.Label
        Me.lblMaxBalcones = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblPlateaNumerada = New System.Windows.Forms.Label
        Me.btnActualizarUbicaciones = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtPlateaNumerada = New System.Windows.Forms.TextBox
        Me.txtPlatea = New System.Windows.Forms.TextBox
        Me.lblPlatea = New System.Windows.Forms.Label
        Me.txtBalcones = New System.Windows.Forms.TextBox
        Me.lblBalcones = New System.Windows.Forms.Label
        Me.groJornadas = New System.Windows.Forms.GroupBox
        Me.chkMatine = New System.Windows.Forms.CheckBox
        Me.chkTarde = New System.Windows.Forms.CheckBox
        Me.chkNoche = New System.Windows.Forms.CheckBox
        Me.groInfoEventos = New System.Windows.Forms.GroupBox
        Me.lblNombreMod = New System.Windows.Forms.Label
        Me.tcFechas = New System.Windows.Forms.TabControl
        Me.tpFechasActuales = New System.Windows.Forms.TabPage
        Me.btnBorrarFechaActual = New System.Windows.Forms.Button
        Me.lstboxFechas = New System.Windows.Forms.ListBox
        Me.tpAgregarNuevasFechas = New System.Windows.Forms.TabPage
        Me.btnGuardar = New System.Windows.Forms.Button
        Me.lstboxFechasNuevas = New System.Windows.Forms.ListBox
        Me.dtpFechasEventos = New System.Windows.Forms.DateTimePicker
        Me.btnBorrarFecha = New System.Windows.Forms.Button
        Me.dgProduccion = New System.Windows.Forms.DataGridView
        Me.txtNombreEncargado = New System.Windows.Forms.TextBox
        Me.cmbNombreEvento = New System.Windows.Forms.ComboBox
        Me.btnActualizarEvento = New System.Windows.Forms.Button
        Me.lblRUNEncargado = New System.Windows.Forms.Label
        Me.lblNombreEvento = New System.Windows.Forms.Label
        Me.lblValorEntradaGeneral = New System.Windows.Forms.Label
        Me.txtEntradaGeneral = New System.Windows.Forms.TextBox
        Me.cmbJornadas = New System.Windows.Forms.ComboBox
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblJornadas = New System.Windows.Forms.Label
        Me.ErrorProviderModificarEventos = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.groSeleccionJornada = New System.Windows.Forms.GroupBox
        Me.EVENTOSTableAdapter = New Teatro.TeatroDataSetTableAdapters.EVENTOSTableAdapter
        Me.EVENTOSBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.EVENTOSBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.EVENTOSBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.EVENTOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EventosjornadasTableAdapter1 = New Teatro.TeatroDataSetTableAdapters.EVENTOSJORNADASTableAdapter
        Me.EventosubicacionesTableAdapter1 = New Teatro.TeatroDataSetTableAdapters.EVENTOSUBICACIONESTableAdapter
        Me.VENTAENTRADASTableAdapter = New Teatro.TeatroDataSetTableAdapters.VENTASENTRADASTableAdapter
        Me.UBICACIONESTableAdapter = New Teatro.TeatroDataSetTableAdapters.UBICACIONESTableAdapter
        Me.EstadoentradasTableAdapter1 = New Teatro.TeatroDataSetTableAdapters.ESTADOENTRADASTableAdapter
        Me.groUbicaciones.SuspendLayout()
        CType(Me.UBICACIONESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TeatroDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groJornadas.SuspendLayout()
        Me.groInfoEventos.SuspendLayout()
        Me.tcFechas.SuspendLayout()
        Me.tpFechasActuales.SuspendLayout()
        Me.tpAgregarNuevasFechas.SuspendLayout()
        CType(Me.dgProduccion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProviderModificarEventos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groSeleccionJornada.SuspendLayout()
        CType(Me.EVENTOSBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EVENTOSBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EVENTOSBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EVENTOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'groUbicaciones
        '
        Me.groUbicaciones.Controls.Add(Me.lblMaxPlateaNumerada)
        Me.groUbicaciones.Controls.Add(Me.lblMaxPlatea)
        Me.groUbicaciones.Controls.Add(Me.lblMaxBalcones)
        Me.groUbicaciones.Controls.Add(Me.Label2)
        Me.groUbicaciones.Controls.Add(Me.lblPlateaNumerada)
        Me.groUbicaciones.Controls.Add(Me.btnActualizarUbicaciones)
        Me.groUbicaciones.Controls.Add(Me.Label1)
        Me.groUbicaciones.Controls.Add(Me.txtPlateaNumerada)
        Me.groUbicaciones.Controls.Add(Me.txtPlatea)
        Me.groUbicaciones.Controls.Add(Me.lblPlatea)
        Me.groUbicaciones.Controls.Add(Me.txtBalcones)
        Me.groUbicaciones.Controls.Add(Me.lblBalcones)
        Me.groUbicaciones.Enabled = False
        Me.groUbicaciones.Location = New System.Drawing.Point(448, 226)
        Me.groUbicaciones.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.groUbicaciones.Name = "groUbicaciones"
        Me.groUbicaciones.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.groUbicaciones.Size = New System.Drawing.Size(295, 242)
        Me.groUbicaciones.TabIndex = 12
        Me.groUbicaciones.TabStop = False
        Me.groUbicaciones.Text = "Cantidad de asientos para:"
        '
        'lblMaxPlateaNumerada
        '
        Me.lblMaxPlateaNumerada.AutoSize = True
        Me.lblMaxPlateaNumerada.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UBICACIONESBindingSource, "PLATEANUMERADA", True))
        Me.lblMaxPlateaNumerada.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMaxPlateaNumerada.ForeColor = System.Drawing.Color.Sienna
        Me.lblMaxPlateaNumerada.Location = New System.Drawing.Point(235, 129)
        Me.lblMaxPlateaNumerada.Name = "lblMaxPlateaNumerada"
        Me.lblMaxPlateaNumerada.Size = New System.Drawing.Size(17, 16)
        Me.lblMaxPlateaNumerada.TabIndex = 38
        Me.lblMaxPlateaNumerada.Text = ". "
        '
        'UBICACIONESBindingSource
        '
        Me.UBICACIONESBindingSource.DataMember = "UBICACIONES"
        Me.UBICACIONESBindingSource.DataSource = Me.TeatroDataSet
        '
        'TeatroDataSet
        '
        Me.TeatroDataSet.DataSetName = "TeatroDataSet"
        Me.TeatroDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lblMaxPlatea
        '
        Me.lblMaxPlatea.AutoSize = True
        Me.lblMaxPlatea.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UBICACIONESBindingSource, "PLATEA", True))
        Me.lblMaxPlatea.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMaxPlatea.ForeColor = System.Drawing.Color.Sienna
        Me.lblMaxPlatea.Location = New System.Drawing.Point(235, 91)
        Me.lblMaxPlatea.Name = "lblMaxPlatea"
        Me.lblMaxPlatea.Size = New System.Drawing.Size(13, 16)
        Me.lblMaxPlatea.TabIndex = 37
        Me.lblMaxPlatea.Text = "."
        '
        'lblMaxBalcones
        '
        Me.lblMaxBalcones.AutoSize = True
        Me.lblMaxBalcones.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UBICACIONESBindingSource, "BALCONES", True))
        Me.lblMaxBalcones.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMaxBalcones.ForeColor = System.Drawing.Color.Sienna
        Me.lblMaxBalcones.Location = New System.Drawing.Point(235, 54)
        Me.lblMaxBalcones.Name = "lblMaxBalcones"
        Me.lblMaxBalcones.Size = New System.Drawing.Size(13, 16)
        Me.lblMaxBalcones.TabIndex = 36
        Me.lblMaxBalcones.Text = "."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(235, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 16)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Max."
        '
        'lblPlateaNumerada
        '
        Me.lblPlateaNumerada.AutoSize = True
        Me.lblPlateaNumerada.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlateaNumerada.Location = New System.Drawing.Point(14, 129)
        Me.lblPlateaNumerada.Name = "lblPlateaNumerada"
        Me.lblPlateaNumerada.Size = New System.Drawing.Size(132, 16)
        Me.lblPlateaNumerada.TabIndex = 28
        Me.lblPlateaNumerada.Text = "Platea numerada"
        '
        'btnActualizarUbicaciones
        '
        Me.btnActualizarUbicaciones.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnActualizarUbicaciones.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActualizarUbicaciones.Image = Global.Teatro.My.Resources.Resources.reload3
        Me.btnActualizarUbicaciones.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnActualizarUbicaciones.Location = New System.Drawing.Point(94, 183)
        Me.btnActualizarUbicaciones.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnActualizarUbicaciones.Name = "btnActualizarUbicaciones"
        Me.btnActualizarUbicaciones.Size = New System.Drawing.Size(128, 36)
        Me.btnActualizarUbicaciones.TabIndex = 16
        Me.btnActualizarUbicaciones.Text = "Actualizar"
        Me.btnActualizarUbicaciones.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 129)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 16)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Platea"
        '
        'txtPlateaNumerada
        '
        Me.txtPlateaNumerada.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.txtPlateaNumerada.Location = New System.Drawing.Point(163, 125)
        Me.txtPlateaNumerada.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtPlateaNumerada.MaxLength = 3
        Me.txtPlateaNumerada.Name = "txtPlateaNumerada"
        Me.txtPlateaNumerada.Size = New System.Drawing.Size(59, 23)
        Me.txtPlateaNumerada.TabIndex = 15
        '
        'txtPlatea
        '
        Me.txtPlatea.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.txtPlatea.Location = New System.Drawing.Point(163, 89)
        Me.txtPlatea.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtPlatea.MaxLength = 3
        Me.txtPlatea.Name = "txtPlatea"
        Me.txtPlatea.Size = New System.Drawing.Size(59, 23)
        Me.txtPlatea.TabIndex = 14
        '
        'lblPlatea
        '
        Me.lblPlatea.AutoSize = True
        Me.lblPlatea.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlatea.Location = New System.Drawing.Point(44, 93)
        Me.lblPlatea.Name = "lblPlatea"
        Me.lblPlatea.Size = New System.Drawing.Size(54, 16)
        Me.lblPlatea.TabIndex = 28
        Me.lblPlatea.Text = "Platea"
        '
        'txtBalcones
        '
        Me.txtBalcones.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.txtBalcones.Location = New System.Drawing.Point(163, 54)
        Me.txtBalcones.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtBalcones.MaxLength = 3
        Me.txtBalcones.Name = "txtBalcones"
        Me.txtBalcones.Size = New System.Drawing.Size(59, 23)
        Me.txtBalcones.TabIndex = 13
        '
        'lblBalcones
        '
        Me.lblBalcones.AutoSize = True
        Me.lblBalcones.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBalcones.Location = New System.Drawing.Point(34, 54)
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
        Me.groJornadas.Location = New System.Drawing.Point(448, 5)
        Me.groJornadas.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.groJornadas.Name = "groJornadas"
        Me.groJornadas.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.groJornadas.Size = New System.Drawing.Size(295, 87)
        Me.groJornadas.TabIndex = 7
        Me.groJornadas.TabStop = False
        Me.groJornadas.Text = "Jornadas"
        '
        'chkMatine
        '
        Me.chkMatine.AutoSize = True
        Me.chkMatine.Location = New System.Drawing.Point(21, 37)
        Me.chkMatine.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.chkMatine.Name = "chkMatine"
        Me.chkMatine.Size = New System.Drawing.Size(76, 20)
        Me.chkMatine.TabIndex = 8
        Me.chkMatine.Text = "Matiné"
        Me.chkMatine.UseVisualStyleBackColor = True
        '
        'chkTarde
        '
        Me.chkTarde.AutoSize = True
        Me.chkTarde.ForeColor = System.Drawing.Color.White
        Me.chkTarde.Location = New System.Drawing.Point(116, 37)
        Me.chkTarde.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.chkTarde.Name = "chkTarde"
        Me.chkTarde.Size = New System.Drawing.Size(68, 20)
        Me.chkTarde.TabIndex = 9
        Me.chkTarde.Text = "Tarde"
        Me.chkTarde.UseVisualStyleBackColor = True
        '
        'chkNoche
        '
        Me.chkNoche.AutoSize = True
        Me.chkNoche.Location = New System.Drawing.Point(206, 37)
        Me.chkNoche.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.chkNoche.Name = "chkNoche"
        Me.chkNoche.Size = New System.Drawing.Size(72, 20)
        Me.chkNoche.TabIndex = 10
        Me.chkNoche.Text = "Noche"
        Me.chkNoche.UseVisualStyleBackColor = True
        '
        'groInfoEventos
        '
        Me.groInfoEventos.Controls.Add(Me.lblNombreMod)
        Me.groInfoEventos.Controls.Add(Me.tcFechas)
        Me.groInfoEventos.Controls.Add(Me.dgProduccion)
        Me.groInfoEventos.Controls.Add(Me.txtNombreEncargado)
        Me.groInfoEventos.Controls.Add(Me.cmbNombreEvento)
        Me.groInfoEventos.Controls.Add(Me.btnActualizarEvento)
        Me.groInfoEventos.Controls.Add(Me.lblRUNEncargado)
        Me.groInfoEventos.Controls.Add(Me.lblNombreEvento)
        Me.groInfoEventos.Controls.Add(Me.lblValorEntradaGeneral)
        Me.groInfoEventos.Controls.Add(Me.txtEntradaGeneral)
        Me.groInfoEventos.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groInfoEventos.Location = New System.Drawing.Point(12, 5)
        Me.groInfoEventos.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.groInfoEventos.Name = "groInfoEventos"
        Me.groInfoEventos.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.groInfoEventos.Size = New System.Drawing.Size(412, 553)
        Me.groInfoEventos.TabIndex = 32
        Me.groInfoEventos.TabStop = False
        Me.groInfoEventos.Text = "Información de eventos"
        '
        'lblNombreMod
        '
        Me.lblNombreMod.AutoSize = True
        Me.lblNombreMod.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreMod.Location = New System.Drawing.Point(190, 62)
        Me.lblNombreMod.Name = "lblNombreMod"
        Me.lblNombreMod.Size = New System.Drawing.Size(149, 16)
        Me.lblNombreMod.TabIndex = 40
        Me.lblNombreMod.Text = "Nombre modificado"
        Me.lblNombreMod.Visible = False
        '
        'tcFechas
        '
        Me.tcFechas.Controls.Add(Me.tpFechasActuales)
        Me.tcFechas.Controls.Add(Me.tpAgregarNuevasFechas)
        Me.tcFechas.Enabled = False
        Me.tcFechas.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tcFechas.Location = New System.Drawing.Point(25, 97)
        Me.tcFechas.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tcFechas.Name = "tcFechas"
        Me.tcFechas.SelectedIndex = 0
        Me.tcFechas.Size = New System.Drawing.Size(367, 204)
        Me.tcFechas.TabIndex = 2
        '
        'tpFechasActuales
        '
        Me.tpFechasActuales.BackColor = System.Drawing.Color.DarkSlateGray
        Me.tpFechasActuales.Controls.Add(Me.btnBorrarFechaActual)
        Me.tpFechasActuales.Controls.Add(Me.lstboxFechas)
        Me.tpFechasActuales.Location = New System.Drawing.Point(4, 25)
        Me.tpFechasActuales.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tpFechasActuales.Name = "tpFechasActuales"
        Me.tpFechasActuales.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tpFechasActuales.Size = New System.Drawing.Size(359, 175)
        Me.tpFechasActuales.TabIndex = 0
        Me.tpFechasActuales.Text = "Fechas actuales"
        '
        'btnBorrarFechaActual
        '
        Me.btnBorrarFechaActual.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnBorrarFechaActual.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnBorrarFechaActual.Enabled = False
        Me.btnBorrarFechaActual.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBorrarFechaActual.Image = Global.Teatro.My.Resources.Resources._stop
        Me.btnBorrarFechaActual.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBorrarFechaActual.Location = New System.Drawing.Point(190, 132)
        Me.btnBorrarFechaActual.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnBorrarFechaActual.Name = "btnBorrarFechaActual"
        Me.btnBorrarFechaActual.Size = New System.Drawing.Size(106, 37)
        Me.btnBorrarFechaActual.TabIndex = 17
        Me.btnBorrarFechaActual.Text = "Borrar"
        Me.btnBorrarFechaActual.UseVisualStyleBackColor = False
        '
        'lstboxFechas
        '
        Me.lstboxFechas.FormattingEnabled = True
        Me.lstboxFechas.ItemHeight = 16
        Me.lstboxFechas.Location = New System.Drawing.Point(35, 14)
        Me.lstboxFechas.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lstboxFechas.Name = "lstboxFechas"
        Me.lstboxFechas.Size = New System.Drawing.Size(283, 116)
        Me.lstboxFechas.TabIndex = 16
        '
        'tpAgregarNuevasFechas
        '
        Me.tpAgregarNuevasFechas.BackColor = System.Drawing.Color.DarkSlateGray
        Me.tpAgregarNuevasFechas.Controls.Add(Me.btnGuardar)
        Me.tpAgregarNuevasFechas.Controls.Add(Me.lstboxFechasNuevas)
        Me.tpAgregarNuevasFechas.Controls.Add(Me.dtpFechasEventos)
        Me.tpAgregarNuevasFechas.Controls.Add(Me.btnBorrarFecha)
        Me.tpAgregarNuevasFechas.Location = New System.Drawing.Point(4, 25)
        Me.tpAgregarNuevasFechas.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tpAgregarNuevasFechas.Name = "tpAgregarNuevasFechas"
        Me.tpAgregarNuevasFechas.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tpAgregarNuevasFechas.Size = New System.Drawing.Size(359, 175)
        Me.tpAgregarNuevasFechas.TabIndex = 1
        Me.tpAgregarNuevasFechas.Text = "Agregar nuevas fecha"
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnGuardar.Image = Global.Teatro.My.Resources.Resources.filesave
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGuardar.Location = New System.Drawing.Point(216, 133)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(103, 36)
        Me.btnGuardar.TabIndex = 20
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'lstboxFechasNuevas
        '
        Me.lstboxFechasNuevas.FormattingEnabled = True
        Me.lstboxFechasNuevas.ItemHeight = 16
        Me.lstboxFechasNuevas.Location = New System.Drawing.Point(35, 47)
        Me.lstboxFechasNuevas.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lstboxFechasNuevas.Name = "lstboxFechasNuevas"
        Me.lstboxFechasNuevas.Size = New System.Drawing.Size(283, 84)
        Me.lstboxFechasNuevas.TabIndex = 17
        '
        'dtpFechasEventos
        '
        Me.dtpFechasEventos.Location = New System.Drawing.Point(35, 7)
        Me.dtpFechasEventos.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dtpFechasEventos.Name = "dtpFechasEventos"
        Me.dtpFechasEventos.Size = New System.Drawing.Size(283, 23)
        Me.dtpFechasEventos.TabIndex = 19
        '
        'btnBorrarFecha
        '
        Me.btnBorrarFecha.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnBorrarFecha.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnBorrarFecha.Image = Global.Teatro.My.Resources.Resources._stop
        Me.btnBorrarFecha.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBorrarFecha.Location = New System.Drawing.Point(93, 133)
        Me.btnBorrarFecha.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnBorrarFecha.Name = "btnBorrarFecha"
        Me.btnBorrarFecha.Size = New System.Drawing.Size(104, 36)
        Me.btnBorrarFecha.TabIndex = 14
        Me.btnBorrarFecha.Text = "Borrar"
        Me.btnBorrarFecha.UseVisualStyleBackColor = False
        '
        'dgProduccion
        '
        Me.dgProduccion.AllowUserToResizeColumns = False
        Me.dgProduccion.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.dgProduccion.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgProduccion.BackgroundColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgProduccion.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgProduccion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgProduccion.Enabled = False
        Me.dgProduccion.Location = New System.Drawing.Point(57, 390)
        Me.dgProduccion.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dgProduccion.Name = "dgProduccion"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgProduccion.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.dgProduccion.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgProduccion.Size = New System.Drawing.Size(327, 111)
        Me.dgProduccion.TabIndex = 5
        '
        'txtNombreEncargado
        '
        Me.txtNombreEncargado.BackColor = System.Drawing.Color.White
        Me.txtNombreEncargado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombreEncargado.Enabled = False
        Me.txtNombreEncargado.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.txtNombreEncargado.Location = New System.Drawing.Point(208, 342)
        Me.txtNombreEncargado.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtNombreEncargado.Name = "txtNombreEncargado"
        Me.txtNombreEncargado.Size = New System.Drawing.Size(178, 23)
        Me.txtNombreEncargado.TabIndex = 4
        '
        'cmbNombreEvento
        '
        Me.cmbNombreEvento.BackColor = System.Drawing.Color.White
        Me.cmbNombreEvento.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbNombreEvento.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.cmbNombreEvento.FormattingEnabled = True
        Me.cmbNombreEvento.Location = New System.Drawing.Point(169, 33)
        Me.cmbNombreEvento.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmbNombreEvento.Name = "cmbNombreEvento"
        Me.cmbNombreEvento.Size = New System.Drawing.Size(178, 24)
        Me.cmbNombreEvento.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.cmbNombreEvento, "Presione ENTER para modificar el nombre del evento")
        '
        'btnActualizarEvento
        '
        Me.btnActualizarEvento.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnActualizarEvento.Enabled = False
        Me.btnActualizarEvento.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActualizarEvento.Image = Global.Teatro.My.Resources.Resources.reload3
        Me.btnActualizarEvento.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnActualizarEvento.Location = New System.Drawing.Point(259, 509)
        Me.btnActualizarEvento.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnActualizarEvento.Name = "btnActualizarEvento"
        Me.btnActualizarEvento.Size = New System.Drawing.Size(125, 35)
        Me.btnActualizarEvento.TabIndex = 6
        Me.btnActualizarEvento.Text = "Actualizar"
        Me.btnActualizarEvento.UseVisualStyleBackColor = False
        '
        'lblRUNEncargado
        '
        Me.lblRUNEncargado.AutoSize = True
        Me.lblRUNEncargado.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRUNEncargado.Location = New System.Drawing.Point(52, 345)
        Me.lblRUNEncargado.Name = "lblRUNEncargado"
        Me.lblRUNEncargado.Size = New System.Drawing.Size(146, 16)
        Me.lblRUNEncargado.TabIndex = 22
        Me.lblRUNEncargado.Text = "Nombre encargado"
        '
        'lblNombreEvento
        '
        Me.lblNombreEvento.AutoSize = True
        Me.lblNombreEvento.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreEvento.Location = New System.Drawing.Point(17, 36)
        Me.lblNombreEvento.Name = "lblNombreEvento"
        Me.lblNombreEvento.Size = New System.Drawing.Size(120, 16)
        Me.lblNombreEvento.TabIndex = 0
        Me.lblNombreEvento.Text = "Nombre evento"
        '
        'lblValorEntradaGeneral
        '
        Me.lblValorEntradaGeneral.AutoSize = True
        Me.lblValorEntradaGeneral.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValorEntradaGeneral.Location = New System.Drawing.Point(56, 312)
        Me.lblValorEntradaGeneral.Name = "lblValorEntradaGeneral"
        Me.lblValorEntradaGeneral.Size = New System.Drawing.Size(137, 16)
        Me.lblValorEntradaGeneral.TabIndex = 4
        Me.lblValorEntradaGeneral.Text = "Entrada general $"
        '
        'txtEntradaGeneral
        '
        Me.txtEntradaGeneral.BackColor = System.Drawing.Color.White
        Me.txtEntradaGeneral.Enabled = False
        Me.txtEntradaGeneral.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.txtEntradaGeneral.Location = New System.Drawing.Point(208, 308)
        Me.txtEntradaGeneral.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtEntradaGeneral.MaxLength = 6
        Me.txtEntradaGeneral.Name = "txtEntradaGeneral"
        Me.txtEntradaGeneral.Size = New System.Drawing.Size(178, 23)
        Me.txtEntradaGeneral.TabIndex = 3
        '
        'cmbJornadas
        '
        Me.cmbJornadas.Enabled = False
        Me.cmbJornadas.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.cmbJornadas.FormattingEnabled = True
        Me.cmbJornadas.Location = New System.Drawing.Point(116, 38)
        Me.cmbJornadas.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmbJornadas.Name = "cmbJornadas"
        Me.cmbJornadas.Size = New System.Drawing.Size(130, 24)
        Me.cmbJornadas.TabIndex = 11
        '
        'lblJornadas
        '
        Me.lblJornadas.AutoSize = True
        Me.lblJornadas.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJornadas.Location = New System.Drawing.Point(18, 41)
        Me.lblJornadas.Name = "lblJornadas"
        Me.lblJornadas.Size = New System.Drawing.Size(74, 16)
        Me.lblJornadas.TabIndex = 40
        Me.lblJornadas.Text = "Jornadas"
        '
        'ErrorProviderModificarEventos
        '
        Me.ErrorProviderModificarEventos.ContainerControl = Me
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.NotifyIcon1.BalloonTipText = "Agregue la wea"
        Me.NotifyIcon1.BalloonTipTitle = "Hola"
        Me.NotifyIcon1.Text = "NotifyIcon1"
        Me.NotifyIcon1.Visible = True
        '
        'groSeleccionJornada
        '
        Me.groSeleccionJornada.Controls.Add(Me.lblJornadas)
        Me.groSeleccionJornada.Controls.Add(Me.cmbJornadas)
        Me.groSeleccionJornada.Enabled = False
        Me.groSeleccionJornada.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groSeleccionJornada.Location = New System.Drawing.Point(448, 114)
        Me.groSeleccionJornada.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.groSeleccionJornada.Name = "groSeleccionJornada"
        Me.groSeleccionJornada.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.groSeleccionJornada.Size = New System.Drawing.Size(295, 87)
        Me.groSeleccionJornada.TabIndex = 42
        Me.groSeleccionJornada.TabStop = False
        Me.groSeleccionJornada.Text = "Seleccionar jornada"
        '
        'EVENTOSTableAdapter
        '
        Me.EVENTOSTableAdapter.ClearBeforeFill = True
        '
        'EVENTOSBindingSource1
        '
        Me.EVENTOSBindingSource1.DataMember = "EVENTOS"
        Me.EVENTOSBindingSource1.DataSource = Me.TeatroDataSet
        '
        'EVENTOSBindingSource2
        '
        Me.EVENTOSBindingSource2.DataMember = "EVENTOS"
        Me.EVENTOSBindingSource2.DataSource = Me.TeatroDataSet
        '
        'EVENTOSBindingSource3
        '
        Me.EVENTOSBindingSource3.DataMember = "EVENTOS"
        Me.EVENTOSBindingSource3.DataSource = Me.TeatroDataSet
        '
        'EVENTOSBindingSource
        '
        Me.EVENTOSBindingSource.DataMember = "EVENTOS"
        Me.EVENTOSBindingSource.DataSource = Me.TeatroDataSet
        '
        'EventosjornadasTableAdapter1
        '
        Me.EventosjornadasTableAdapter1.ClearBeforeFill = True
        '
        'EventosubicacionesTableAdapter1
        '
        Me.EventosubicacionesTableAdapter1.ClearBeforeFill = True
        '
        'VENTAENTRADASTableAdapter
        '
        Me.VENTAENTRADASTableAdapter.ClearBeforeFill = True
        '
        'UBICACIONESTableAdapter
        '
        Me.UBICACIONESTableAdapter.ClearBeforeFill = True
        '
        'EstadoentradasTableAdapter1
        '
        Me.EstadoentradasTableAdapter1.ClearBeforeFill = True
        '
        'frmModificarEventos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSlateGray
        Me.ClientSize = New System.Drawing.Size(763, 579)
        Me.Controls.Add(Me.groSeleccionJornada)
        Me.Controls.Add(Me.groUbicaciones)
        Me.Controls.Add(Me.groJornadas)
        Me.Controls.Add(Me.groInfoEventos)
        Me.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmModificarEventos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modificar eventos"
        Me.groUbicaciones.ResumeLayout(False)
        Me.groUbicaciones.PerformLayout()
        CType(Me.UBICACIONESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TeatroDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groJornadas.ResumeLayout(False)
        Me.groJornadas.PerformLayout()
        Me.groInfoEventos.ResumeLayout(False)
        Me.groInfoEventos.PerformLayout()
        Me.tcFechas.ResumeLayout(False)
        Me.tpFechasActuales.ResumeLayout(False)
        Me.tpAgregarNuevasFechas.ResumeLayout(False)
        CType(Me.dgProduccion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProviderModificarEventos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groSeleccionJornada.ResumeLayout(False)
        Me.groSeleccionJornada.PerformLayout()
        CType(Me.EVENTOSBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EVENTOSBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EVENTOSBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EVENTOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TeatroDataSet As Teatro.TeatroDataSet
    Friend WithEvents EVENTOSTableAdapter As Teatro.TeatroDataSetTableAdapters.EVENTOSTableAdapter
    Friend WithEvents CAPACIDADDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ESTADOEVENTODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents groUbicaciones As System.Windows.Forms.GroupBox
    Friend WithEvents lblPlateaNumerada As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtPlateaNumerada As System.Windows.Forms.TextBox
    Friend WithEvents txtPlatea As System.Windows.Forms.TextBox
    Friend WithEvents lblPlatea As System.Windows.Forms.Label
    Friend WithEvents txtBalcones As System.Windows.Forms.TextBox
    Friend WithEvents lblBalcones As System.Windows.Forms.Label
    Friend WithEvents groJornadas As System.Windows.Forms.GroupBox
    Friend WithEvents chkMatine As System.Windows.Forms.CheckBox
    Friend WithEvents chkTarde As System.Windows.Forms.CheckBox
    Friend WithEvents chkNoche As System.Windows.Forms.CheckBox
    Friend WithEvents groInfoEventos As System.Windows.Forms.GroupBox
    Friend WithEvents txtEntradaGeneral As System.Windows.Forms.TextBox
    Friend WithEvents lblValorEntradaGeneral As System.Windows.Forms.Label
    Friend WithEvents lblNombreEvento As System.Windows.Forms.Label
    Friend WithEvents btnActualizarEvento As System.Windows.Forms.Button
    Friend WithEvents cmbNombreEvento As System.Windows.Forms.ComboBox
    Friend WithEvents dgProduccion As System.Windows.Forms.DataGridView
    Friend WithEvents EVENTOSBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents EVENTOSBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents cmbJornadas As System.Windows.Forms.ComboBox
    Friend WithEvents txtNombreEncargado As System.Windows.Forms.TextBox
    Friend WithEvents lblRUNEncargado As System.Windows.Forms.Label
    Friend WithEvents btnActualizarUbicaciones As System.Windows.Forms.Button
    Friend WithEvents EVENTOSBindingSource3 As System.Windows.Forms.BindingSource
    Friend WithEvents EVENTOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EventosjornadasTableAdapter1 As Teatro.TeatroDataSetTableAdapters.EVENTOSJORNADASTableAdapter
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents lblNombreMod As System.Windows.Forms.Label
    Friend WithEvents lblJornadas As System.Windows.Forms.Label
    Friend WithEvents ErrorProviderModificarEventos As System.Windows.Forms.ErrorProvider
    Friend WithEvents EventosubicacionesTableAdapter1 As Teatro.TeatroDataSetTableAdapters.EVENTOSUBICACIONESTableAdapter
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents tcFechas As System.Windows.Forms.TabControl
    Friend WithEvents tpFechasActuales As System.Windows.Forms.TabPage
    Friend WithEvents btnBorrarFechaActual As System.Windows.Forms.Button
    Friend WithEvents lstboxFechas As System.Windows.Forms.ListBox
    Friend WithEvents tpAgregarNuevasFechas As System.Windows.Forms.TabPage
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents lstboxFechasNuevas As System.Windows.Forms.ListBox
    Friend WithEvents dtpFechasEventos As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnBorrarFecha As System.Windows.Forms.Button
    Friend WithEvents VENTAENTRADASTableAdapter As Teatro.TeatroDataSetTableAdapters.VENTASENTRADASTableAdapter
    Friend WithEvents groSeleccionJornada As System.Windows.Forms.GroupBox
    Friend WithEvents UBICACIONESBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UBICACIONESTableAdapter As Teatro.TeatroDataSetTableAdapters.UBICACIONESTableAdapter
    Protected WithEvents Label2 As System.Windows.Forms.Label
    Protected WithEvents lblMaxPlateaNumerada As System.Windows.Forms.Label
    Protected WithEvents lblMaxPlatea As System.Windows.Forms.Label
    Protected WithEvents lblMaxBalcones As System.Windows.Forms.Label
    Friend WithEvents EstadoentradasTableAdapter1 As Teatro.TeatroDataSetTableAdapters.ESTADOENTRADASTableAdapter
End Class
