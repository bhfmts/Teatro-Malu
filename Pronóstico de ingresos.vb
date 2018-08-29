Public Class frmPronosticoIngresos
    Public dbBalconesAdulto As Double
    Public dbBalconesTerceraEdad As Double
    Public dbBalconesNiño As Double
    Public dbBalconesEstudiante As Double
    Public dbPlateaAdulto As Double
    Public dbPlateaTerceraEdad As Double
    Public dbPlateaNiño As Double
    Public dbPlateaEstudiante As Double
    Public dbPlateaNuAdulto As Double
    Public dbPlateaNuTerceraEdad As Double
    Public dbPlateaNuNiño As Double
    Public dbPlateaNuEstudiante As Double
    Public dbPlatea As Double = 2000
    Public dbPlateaNumerada As Double = 3500
    Public dbTotalBalcones As Double
    Public dbTotalPlatea As Double
    Public dbTotalPlateaNumerada As Double
    Public dbSumaBalcones As Double
    Public dbSumaPlatea As Double
    Public dbSumaPlateaNu As Double
    Dim Eventos As New ClassEvento
    'Cerrando el formulario
    Private Sub frmPronosticoIngresos_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim drResultado As DialogResult = MsgBox("Asegúrese de haber completado correctamente sus operaciones. ¿Está seguro que desea cerrar? ", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Registro eventos")
        If drResultado = vbNo Then
            e.Cancel = True
        Else
            Me.txtValorEntradaGeneral.Clear()
            Me.Dispose()
        End If
    End Sub

    Private Sub frmPronosticoIngresos_HelpRequested(ByVal sender As Object, ByVal hlpevent As System.Windows.Forms.HelpEventArgs) Handles Me.HelpRequested
        Try
            System.Diagnostics.Process.Start("\\BERNARDO\Manuales\Pronóstico de ingresos.avi")
        Catch ex As Exception
            MsgBox("Se ha producido el siguiente error: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    'Establezco el valor máximo a ingresar obteniendo la información de la base de datos
    Private Sub frmPronosticoIngresos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            Me.nupBalcones.Maximum = Me.UbicacionesTableAdapter1.SelectBalcones
            Me.nupPlatea.Maximum = Me.UbicacionesTableAdapter1.SelectPlatea
            Me.nupPlateaNumerada.Maximum = Me.UbicacionesTableAdapter1.SelectPlateaNumerada
            Me.nupAdulto.Maximum = Me.UbicacionesTableAdapter1.SelectBalcones
            Me.nupEstudiante.Maximum = Me.UbicacionesTableAdapter1.SelectBalcones
            Me.nupTerceraEdad.Maximum = Me.UbicacionesTableAdapter1.SelectBalcones
            Me.nupNiño.Maximum = Me.UbicacionesTableAdapter1.SelectBalcones
            Me.nupAdulto2.Maximum = Me.UbicacionesTableAdapter1.SelectBalcones
            Me.nupEstudiante2.Maximum = Me.UbicacionesTableAdapter1.SelectBalcones
            Me.nupTerceraEdad2.Maximum = Me.UbicacionesTableAdapter1.SelectBalcones
            Me.nupNiño2.Maximum = Me.UbicacionesTableAdapter1.SelectBalcones
            Me.nupAdulto3.Maximum = Me.UbicacionesTableAdapter1.SelectBalcones
            Me.nupEstudiante3.Maximum = Me.UbicacionesTableAdapter1.SelectBalcones
            Me.nupTerceraEdad3.Maximum = Me.UbicacionesTableAdapter1.SelectBalcones
            Me.nupNiño3.Maximum = Me.UbicacionesTableAdapter1.SelectBalcones
        Catch ex As Exception
            MsgBox("Se produjo el siguiente error: " & ex.Message, MsgBoxStyle.Critical, "Teatro")
        End Try
    End Sub
    Private Sub btnPronosticar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPronosticar.Click
        'Sumo las cantidad de cada groupbox para validarlos con la cantidad permitida
        Try
            dbSumaBalcones = Me.nupAdulto.Value + Me.nupEstudiante.Value + Me.nupTerceraEdad.Value + Me.nupNiño.Value
            dbSumaPlateaNu = Me.nupAdulto2.Value + Me.nupEstudiante2.Value + Me.nupTerceraEdad2.Value + Me.nupNiño2.Value
            dbSumaPlatea = Me.nupAdulto3.Value + Me.nupEstudiante3.Value + Me.nupTerceraEdad3.Value + Me.nupNiño3.Value
            If txtValorEntradaGeneral.TextLength = 0 Then
                Eventos.CamposNulosTextBox(Me.ErrorProviderEventos, txtValorEntradaGeneral) = txtValorEntradaGeneral.Text
                Exit Sub
            Else
                Eventos.CamposNulosTextBox(Me.ErrorProviderEventos, txtValorEntradaGeneral) = txtValorEntradaGeneral.Text
            End If

            If dbSumaBalcones > Me.nupBalcones.Value Then
                Me.ErrorProviderEventos.SetError(groBalcones, "La suma de los valores excede el límite permitido")
                ErrorProviderEventos.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
                Exit Sub
            Else
                Me.ErrorProviderEventos.SetError(groBalcones, "")
            End If

            If dbSumaPlatea > Me.nupPlatea.Value Then
                Me.ErrorProviderEventos.SetError(groPlatea, "La suma de los valores excede el límite permitido")
                ErrorProviderEventos.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
                Exit Sub
            Else
                Me.ErrorProviderEventos.SetError(groPlatea, "")
            End If

            If dbSumaPlateaNu > Me.nupPlateaNumerada.Value Then
                Me.ErrorProviderEventos.SetError(groPlateaNumerada, "La suma de los valores excede el límite permitido")
                ErrorProviderEventos.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
                Exit Sub
            Else
                Me.ErrorProviderEventos.SetError(groPlateaNumerada, "")
            End If
            dbValorEntradaGeneral = Double.Parse(txtValorEntradaGeneral.Text)
            dbBalconesAdulto = dbValorEntradaGeneral * Me.nupAdulto.Value
            dbBalconesTerceraEdad = (dbValorEntradaGeneral * dbPorcentTerceraEdad) * Me.nupTerceraEdad.Value
            dbBalconesNiño = (dbValorEntradaGeneral * dbPorcentNiño) * Me.nupNiño.Value
            dbBalconesEstudiante = (dbValorEntradaGeneral * dbPorcentEstudiante) * Me.nupEstudiante.Value
            If Me.nupAdulto3.Value <> 0 Then
                dbPlateaAdulto = (dbValorEntradaGeneral + dbPlatea) * Me.nupAdulto3.Value
            Else
                dbPlateaAdulto = 0
            End If
            If Me.nupTerceraEdad3.Value <> 0 Then
                dbPlateaTerceraEdad = ((dbValorEntradaGeneral + dbPlatea) * dbPorcentTerceraEdad) * Me.nupTerceraEdad3.Value
            Else
                dbPlateaTerceraEdad = 0
            End If
            If Me.nupNiño3.Value <> 0 Then
                dbPlateaNiño = ((dbValorEntradaGeneral + dbPlatea) * dbPorcentNiño) * Me.nupNiño3.Value
            Else
                dbPlateaNiño = 0
            End If
            If Me.nupEstudiante3.Value <> 0 Then
                dbPlateaEstudiante = ((dbValorEntradaGeneral + dbPlatea) * dbPorcentEstudiante) * Me.nupEstudiante3.Value
            Else
                dbPlateaEstudiante = 0
            End If
            If Me.nupEstudiante2.Value <> 0 Then
                dbPlateaNuEstudiante = ((dbValorEntradaGeneral + dbPlateaNumerada) * dbPorcentEstudiante) * Me.nupEstudiante2.Value
            Else
                dbPlateaNuEstudiante = 0
            End If
            If Me.nupAdulto2.Value Then
                dbPlateaNuAdulto = (dbValorEntradaGeneral + dbPlateaNumerada) * Me.nupAdulto2.Value
            Else
                dbPlateaNuAdulto = 0
            End If
            If Me.nupNiño2.Value Then
                dbPlateaNuNiño = ((dbValorEntradaGeneral + dbPlateaNumerada) * dbPorcentNiño) * nupNiño2.Value
            Else
                dbPlateaNuNiño = 0
            End If
            If Me.nupTerceraEdad2.Value Then
                dbPlateaNuTerceraEdad = ((dbValorEntradaGeneral + dbPlateaNumerada) * dbPorcentTerceraEdad) * Me.nupTerceraEdad2.Value
            Else
                dbPlateaNuTerceraEdad = 0
            End If
            dbTotalBalcones = dbBalconesAdulto + dbBalconesTerceraEdad + dbBalconesNiño + dbBalconesEstudiante
            dbTotalPlatea = dbPlateaAdulto + dbPlateaTerceraEdad + dbPlateaNiño + dbPlateaEstudiante
            dbTotalPlateaNumerada = dbPlateaNuAdulto + dbPlateaNuTerceraEdad + dbPlateaNuNiño + dbPlateaNuEstudiante
            dbTotalPronostico = dbTotalBalcones + dbTotalPlatea + dbTotalPlateaNumerada
            intBalconesAdulto = nupAdulto.Value
            intBalconesTerceraEdad = nupTerceraEdad.Value
            intBalconesNiño = nupNiño.Value
            intBalconesEstudiante = nupEstudiante.Value
            intPlateaAdulto = nupAdulto3.Value
            intPlateaTerceraEdad = nupTerceraEdad3.Value
            intPlateaNiño = nupNiño3.Value
            intPlateaEstudiante = nupEstudiante3.Value
            intPlateaNuAdulto = nupAdulto2.Value
            intPlateaNuTerceraEdad = nupTerceraEdad2.Value
            intPlateaNuNiño = nupNiño2.Value
            intPlateaNuEstudiante = nupEstudiante2.Value
            frmInfPronosticoIngresos.ShowDialog()
        Catch ex As Exception
            MsgBox("Se produjo el siguiente error: " & ex.Message, MsgBoxStyle.Critical, "Teatro")
        End Try
    End Sub
End Class