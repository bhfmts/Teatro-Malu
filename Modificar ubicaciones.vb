Imports System.Transactions
Public Class frmUbicaciones

    Private Sub frmUbicaciones_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim drResultado As DialogResult = MsgBox("Asegúrese de haber completado correctamente sus operaciones. ¿Está seguro que desea cerrar? ", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Registro eventos")
        If drResultado = vbNo Then
            e.Cancel = True
        Else
            Me.Dispose()
        End If
    End Sub



    Private Sub frmUbicaciones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.UBICACIONESTableAdapter.Fill(Me.TeatroDataSet.UBICACIONES)

    End Sub


    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Using Scope As New TransactionScope
            Try
                Me.Validate()
                Me.UBICACIONESBindingSource.EndEdit()
                Me.UBICACIONESTableAdapter.Update(Me.TeatroDataSet.UBICACIONES)
                MsgBox("Datos guardados correctamente", MsgBoxStyle.Information)
                Scope.Complete()
            Catch ex As Exception
                MsgBox("Se produjo el siguiente error: " & ex.Message, MsgBoxStyle.Critical, "Teatro")
            End Try
        End Using
    End Sub
    'VALIDACION CAMPO BALCONES PARA SOLO INGRESAR NUMEROS
    Private Sub txtBalcones_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBalcones.KeyPress
        If (Asc(e.KeyChar)) >= 48 And (Asc(e.KeyChar)) <= 57 Or (Asc(e.KeyChar)) = System.Windows.Forms.Keys.Back Or Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    'VALIDACION CAMPO PLATEA PARA SOLO INGRESAR NUMEROS.
    Private Sub txtPlatea_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPlatea.KeyPress
        If (Asc(e.KeyChar)) >= 48 And (Asc(e.KeyChar)) <= 57 Or (Asc(e.KeyChar)) = System.Windows.Forms.Keys.Back Or Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    'VALIDACION CAMPO PLATEANUMERADA PARA SOLO INGRESAR NUMEROS.
    Private Sub txtPlateaNumerada_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPlateaNumerada.KeyPress
        If (Asc(e.KeyChar)) >= 48 And (Asc(e.KeyChar)) <= 57 Or (Asc(e.KeyChar)) = System.Windows.Forms.Keys.Back Or Char.IsDigit(e.KeyChar) Then

            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
End Class