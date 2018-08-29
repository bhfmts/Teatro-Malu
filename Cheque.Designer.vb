<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCheque
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
        Me.groCheque = New System.Windows.Forms.GroupBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.txtNumeroPlaza = New System.Windows.Forms.TextBox
        Me.txtNumeroCuenta = New System.Windows.Forms.TextBox
        Me.lblMontoCheque = New System.Windows.Forms.Label
        Me.lblNumeroSerie = New System.Windows.Forms.Label
        Me.txtNumeroSerie = New System.Windows.Forms.TextBox
        Me.lblNumeroBanco = New System.Windows.Forms.Label
        Me.lblNumeroPlaza = New System.Windows.Forms.Label
        Me.lblNumeroCuenta = New System.Windows.Forms.Label
        Me.btnPagarCheque = New System.Windows.Forms.Button
        Me.groCheque.SuspendLayout()
        Me.SuspendLayout()
        '
        'groCheque
        '
        Me.groCheque.Controls.Add(Me.TextBox2)
        Me.groCheque.Controls.Add(Me.TextBox1)
        Me.groCheque.Controls.Add(Me.txtNumeroPlaza)
        Me.groCheque.Controls.Add(Me.txtNumeroCuenta)
        Me.groCheque.Controls.Add(Me.lblMontoCheque)
        Me.groCheque.Controls.Add(Me.lblNumeroSerie)
        Me.groCheque.Controls.Add(Me.txtNumeroSerie)
        Me.groCheque.Controls.Add(Me.lblNumeroBanco)
        Me.groCheque.Controls.Add(Me.lblNumeroPlaza)
        Me.groCheque.Controls.Add(Me.lblNumeroCuenta)
        Me.groCheque.Location = New System.Drawing.Point(12, 21)
        Me.groCheque.Name = "groCheque"
        Me.groCheque.Size = New System.Drawing.Size(249, 314)
        Me.groCheque.TabIndex = 3
        Me.groCheque.TabStop = False
        Me.groCheque.Text = "Pago con cheque"
        '
        'TextBox2
        '
        Me.TextBox2.Enabled = False
        Me.TextBox2.Location = New System.Drawing.Point(126, 257)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 1
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(126, 203)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 1
        '
        'txtNumeroPlaza
        '
        Me.txtNumeroPlaza.Enabled = False
        Me.txtNumeroPlaza.Location = New System.Drawing.Point(126, 146)
        Me.txtNumeroPlaza.Name = "txtNumeroPlaza"
        Me.txtNumeroPlaza.Size = New System.Drawing.Size(100, 20)
        Me.txtNumeroPlaza.TabIndex = 1
        '
        'txtNumeroCuenta
        '
        Me.txtNumeroCuenta.Location = New System.Drawing.Point(127, 91)
        Me.txtNumeroCuenta.Name = "txtNumeroCuenta"
        Me.txtNumeroCuenta.Size = New System.Drawing.Size(100, 20)
        Me.txtNumeroCuenta.TabIndex = 1
        '
        'lblMontoCheque
        '
        Me.lblMontoCheque.AutoSize = True
        Me.lblMontoCheque.Location = New System.Drawing.Point(26, 260)
        Me.lblMontoCheque.Name = "lblMontoCheque"
        Me.lblMontoCheque.Size = New System.Drawing.Size(76, 13)
        Me.lblMontoCheque.TabIndex = 0
        Me.lblMontoCheque.Text = "Monto cheque"
        '
        'lblNumeroSerie
        '
        Me.lblNumeroSerie.AutoSize = True
        Me.lblNumeroSerie.Location = New System.Drawing.Point(26, 44)
        Me.lblNumeroSerie.Name = "lblNumeroSerie"
        Me.lblNumeroSerie.Size = New System.Drawing.Size(69, 13)
        Me.lblNumeroSerie.TabIndex = 0
        Me.lblNumeroSerie.Text = "Número serie"
        '
        'txtNumeroSerie
        '
        Me.txtNumeroSerie.Location = New System.Drawing.Point(126, 41)
        Me.txtNumeroSerie.Name = "txtNumeroSerie"
        Me.txtNumeroSerie.Size = New System.Drawing.Size(100, 20)
        Me.txtNumeroSerie.TabIndex = 1
        '
        'lblNumeroBanco
        '
        Me.lblNumeroBanco.AutoSize = True
        Me.lblNumeroBanco.Location = New System.Drawing.Point(26, 206)
        Me.lblNumeroBanco.Name = "lblNumeroBanco"
        Me.lblNumeroBanco.Size = New System.Drawing.Size(92, 13)
        Me.lblNumeroBanco.TabIndex = 0
        Me.lblNumeroBanco.Text = "Número de banco"
        '
        'lblNumeroPlaza
        '
        Me.lblNumeroPlaza.AutoSize = True
        Me.lblNumeroPlaza.Location = New System.Drawing.Point(26, 149)
        Me.lblNumeroPlaza.Name = "lblNumeroPlaza"
        Me.lblNumeroPlaza.Size = New System.Drawing.Size(87, 13)
        Me.lblNumeroPlaza.TabIndex = 0
        Me.lblNumeroPlaza.Text = "Numero de plaza"
        '
        'lblNumeroCuenta
        '
        Me.lblNumeroCuenta.AutoSize = True
        Me.lblNumeroCuenta.Location = New System.Drawing.Point(26, 98)
        Me.lblNumeroCuenta.Name = "lblNumeroCuenta"
        Me.lblNumeroCuenta.Size = New System.Drawing.Size(95, 13)
        Me.lblNumeroCuenta.TabIndex = 0
        Me.lblNumeroCuenta.Text = "Número de cuenta"
        '
        'btnPagarCheque
        '
        Me.btnPagarCheque.Location = New System.Drawing.Point(186, 358)
        Me.btnPagarCheque.Name = "btnPagarCheque"
        Me.btnPagarCheque.Size = New System.Drawing.Size(75, 23)
        Me.btnPagarCheque.TabIndex = 4
        Me.btnPagarCheque.Text = "Pagar"
        Me.btnPagarCheque.UseVisualStyleBackColor = True
        '
        'frmCheque
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(272, 404)
        Me.Controls.Add(Me.btnPagarCheque)
        Me.Controls.Add(Me.groCheque)
        Me.Name = "frmCheque"
        Me.Text = "Cheque"
        Me.groCheque.ResumeLayout(False)
        Me.groCheque.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents groCheque As System.Windows.Forms.GroupBox
    Friend WithEvents txtNumeroPlaza As System.Windows.Forms.TextBox
    Friend WithEvents txtNumeroCuenta As System.Windows.Forms.TextBox
    Friend WithEvents lblNumeroSerie As System.Windows.Forms.Label
    Friend WithEvents txtNumeroSerie As System.Windows.Forms.TextBox
    Friend WithEvents lblNumeroPlaza As System.Windows.Forms.Label
    Friend WithEvents lblNumeroCuenta As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents lblMontoCheque As System.Windows.Forms.Label
    Friend WithEvents lblNumeroBanco As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents btnPagarCheque As System.Windows.Forms.Button
End Class
