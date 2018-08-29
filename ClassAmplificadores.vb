Imports System.Data.SqlClient
Imports Teatro.ClassConexion
Public Class ClassAmplificadores
    Inherits ClassEquipos
    Public IntWatts As Integer
    Public StrTipoAmpli As String
    Public strValor
    Public Property CamposNulosTextBox(ByVal ErrorProviderAmplificadores As ErrorProvider, ByVal txtValor As TextBox) As String
        Get
            Return strValor
        End Get
        Set(ByVal value As String)
            If txtValor.TextLength = 0 Then
                ErrorProviderAmplificadores.SetError(txtValor, "Campo obligatorio")
                ErrorProviderAmplificadores.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
                Exit Property
            Else
                ErrorProviderAmplificadores.SetError(txtValor, "")
            End If
        End Set
    End Property

    Public Property CamposNulosComboBox(ByVal ErrorProviderAmplificadores As ErrorProvider, ByVal cmbValor As ComboBox) As String
        Get
            Return strValor
        End Get
        Set(ByVal value As String)
            If cmbValor.Text = "" Then
                ErrorProviderAmplificadores.SetError(cmbValor, "Campo obligatorio")
                ErrorProviderAmplificadores.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
            Else
                ErrorProviderAmplificadores.SetError(cmbValor, "")
            End If
        End Set
    End Property

  
    'Búsqueda de datos por idequipo o por idamplificador
    Public Sub BuscarAmplificador(ByVal dgResultados As DataGridView, ByVal txtDatoBusqueda As TextBox, ByVal blnOpcionBusqueda As Boolean)
        Conexion.Close()
        Try
            If blnOpcionBusqueda = True Then
                Conexion.Open()
                Dim DSET As New DataSet
                Dim DAD As New SqlDataAdapter("SELECT EQUIPOS.IDEQUIPO,IDAMPLIFICADOR,MARCA,MODELO,TIPO,WATTS FROM AMPLIFICADORES, EQUIPOS WHERE EQUIPOS.IDEQUIPO='" & txtDatoBusqueda.Text & "' AND EQUIPOS.IDEQUIPO=AMPLIFICADORES.IDEQUIPO", Conexion)
                DAD.Fill(DSET)
                dgResultados.DataSource = DSET
                dgResultados.DataMember = "TABLE"
                dgResultados.Columns(0).HeaderText = "ID Eq."
                dgResultados.Columns(1).HeaderText = "ID Amp."
                dgResultados.Columns(2).HeaderText = "Marca"
                dgResultados.Columns(3).HeaderText = "Modelo"
                dgResultados.Columns(4).HeaderText = "Tipo"
                dgResultados.Columns(5).HeaderText = "Watts"
                dgResultados.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                dgResultados.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                dgResultados.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                dgResultados.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                dgResultados.Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                dgResultados.Columns(5).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
           
            ElseIf blnOpcionBusqueda = False Then
                Conexion.Open()
                Dim DSET As New DataSet
                Dim DAD As New SqlDataAdapter("SELECT EQUIPOS.IDEQUIPO,IDAMPLIFICADOR,MARCA,MODELO,TIPO,WATTS FROM AMPLIFICADORES, EQUIPOS WHERE IDAMPLIFICADOR='" & txtDatoBusqueda.Text & "'AND EQUIPOS.IDEQUIPO=AMPLIFICADORES.IDEQUIPO", Conexion)
                DAD.Fill(DSET)
                dgResultados.DataSource = DSET
                dgResultados.DataMember = "TABLE"
                dgResultados.Columns(0).HeaderText = "ID equipo"
                dgResultados.Columns(1).HeaderText = "ID amplificador"
                dgResultados.Columns(2).HeaderText = "Marca"
                dgResultados.Columns(3).HeaderText = "Modelo"
                dgResultados.Columns(4).HeaderText = "Tipo"
                dgResultados.Columns(5).HeaderText = "Watts"
                dgResultados.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                dgResultados.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                dgResultados.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                dgResultados.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                dgResultados.Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                dgResultados.Columns(5).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells

            End If
        Catch ex As Exception
            MsgBox("Se produjo el siguiente error: " & ex.Message, MsgBoxStyle.Critical, "Teatro")
        Finally
            Conexion.Close()
        End Try
        If dgResultados.RowCount = 0 Then
            dgResultados.DataSource = Nothing
            MsgBox("No existen registros respecto a la información ingresada", MsgBoxStyle.Information, "Eliminar usuario")
            Exit Sub
        End If
    End Sub
End Class
