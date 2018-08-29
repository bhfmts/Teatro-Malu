<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUbicaciones
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
        Dim BALCONESLabel As System.Windows.Forms.Label
        Dim PLATEALabel As System.Windows.Forms.Label
        Dim lblPlateaNumerada As System.Windows.Forms.Label
        Me.groUbicaciones = New System.Windows.Forms.GroupBox
        Me.txtBalcones = New System.Windows.Forms.TextBox
        Me.UBICACIONESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TeatroDataSet = New Teatro.TeatroDataSet
        Me.txtPlatea = New System.Windows.Forms.TextBox
        Me.txtPlateaNumerada = New System.Windows.Forms.TextBox
        Me.btnGuardar = New System.Windows.Forms.Button
        Me.UBICACIONESTableAdapter = New Teatro.TeatroDataSetTableAdapters.UBICACIONESTableAdapter
        BALCONESLabel = New System.Windows.Forms.Label
        PLATEALabel = New System.Windows.Forms.Label
        lblPlateaNumerada = New System.Windows.Forms.Label
        Me.groUbicaciones.SuspendLayout()
        CType(Me.UBICACIONESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TeatroDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        '
        'BALCONESLabel
        '
        BALCONESLabel.AutoSize = True
        BALCONESLabel.Location = New System.Drawing.Point(21, 32)
        BALCONESLabel.Name = "BALCONESLabel"
        BALCONESLabel.Size = New System.Drawing.Size(74, 16)
        BALCONESLabel.TabIndex = 2
        BALCONESLabel.Text = "Balcones"
        '
        'PLATEALabel
        '
        PLATEALabel.AutoSize = True
        PLATEALabel.Location = New System.Drawing.Point(21, 61)
        PLATEALabel.Name = "PLATEALabel"
        PLATEALabel.Size = New System.Drawing.Size(54, 16)
        PLATEALabel.TabIndex = 4
        PLATEALabel.Text = "Platea"
        '
        'lblPlateaNumerada
        '
        lblPlateaNumerada.AutoSize = True
        lblPlateaNumerada.Location = New System.Drawing.Point(21, 90)
        lblPlateaNumerada.Name = "lblPlateaNumerada"
        lblPlateaNumerada.Size = New System.Drawing.Size(132, 16)
        lblPlateaNumerada.TabIndex = 6
        lblPlateaNumerada.Text = "Platea numerada"
        '
        'groUbicaciones
        '
        Me.groUbicaciones.Controls.Add(BALCONESLabel)
        Me.groUbicaciones.Controls.Add(Me.txtBalcones)
        Me.groUbicaciones.Controls.Add(PLATEALabel)
        Me.groUbicaciones.Controls.Add(Me.txtPlatea)
        Me.groUbicaciones.Controls.Add(lblPlateaNumerada)
        Me.groUbicaciones.Controls.Add(Me.txtPlateaNumerada)
        Me.groUbicaciones.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groUbicaciones.ForeColor = System.Drawing.Color.White
        Me.groUbicaciones.Location = New System.Drawing.Point(15, 12)
        Me.groUbicaciones.Name = "groUbicaciones"
        Me.groUbicaciones.Size = New System.Drawing.Size(302, 131)
        Me.groUbicaciones.TabIndex = 11
        Me.groUbicaciones.TabStop = False
        Me.groUbicaciones.Text = "Disponibilidad de asientos para:"
        '
        'txtBalcones
        '
        Me.txtBalcones.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UBICACIONESBindingSource, "BALCONES", True))
        Me.txtBalcones.Location = New System.Drawing.Point(174, 29)
        Me.txtBalcones.Name = "txtBalcones"
        Me.txtBalcones.Size = New System.Drawing.Size(100, 23)
        Me.txtBalcones.TabIndex = 3
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
        'txtPlatea
        '
        Me.txtPlatea.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UBICACIONESBindingSource, "PLATEA", True))
        Me.txtPlatea.Location = New System.Drawing.Point(174, 58)
        Me.txtPlatea.Name = "txtPlatea"
        Me.txtPlatea.Size = New System.Drawing.Size(100, 23)
        Me.txtPlatea.TabIndex = 5
        '
        'txtPlateaNumerada
        '
        Me.txtPlateaNumerada.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UBICACIONESBindingSource, "PLATEANUMERADA", True))
        Me.txtPlateaNumerada.Location = New System.Drawing.Point(174, 87)
        Me.txtPlateaNumerada.Name = "txtPlateaNumerada"
        Me.txtPlateaNumerada.Size = New System.Drawing.Size(100, 23)
        Me.txtPlateaNumerada.TabIndex = 7
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnGuardar.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnGuardar.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.Image = Global.Teatro.My.Resources.Resources.filesave
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGuardar.Location = New System.Drawing.Point(177, 160)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(112, 36)
        Me.btnGuardar.TabIndex = 12
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'UBICACIONESTableAdapter
        '
        Me.UBICACIONESTableAdapter.ClearBeforeFill = True
        '
        'frmUbicaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(333, 216)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.groUbicaciones)
        Me.Name = "frmUbicaciones"
        Me.Text = "Ubicaciones"
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.groUbicaciones, 0)
        Me.Controls.SetChildIndex(Me.btnGuardar, 0)
        Me.groUbicaciones.ResumeLayout(False)
        Me.groUbicaciones.PerformLayout()
        CType(Me.UBICACIONESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TeatroDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Protected WithEvents groUbicaciones As System.Windows.Forms.GroupBox
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents TeatroDataSet As Teatro.TeatroDataSet
    Friend WithEvents UBICACIONESTableAdapter As Teatro.TeatroDataSetTableAdapters.UBICACIONESTableAdapter
    Friend WithEvents txtBalcones As System.Windows.Forms.TextBox
    Friend WithEvents txtPlatea As System.Windows.Forms.TextBox
    Friend WithEvents txtPlateaNumerada As System.Windows.Forms.TextBox
    Friend WithEvents UBICACIONESBindingSource As System.Windows.Forms.BindingSource
End Class
