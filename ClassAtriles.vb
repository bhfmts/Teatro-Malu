Imports System.Data.SqlClient
Imports Teatro.ClassConexion
Public Class ClassAtriles
    Inherits ClassEquipos
    Public StrTipo As String 'baterias, cantantes, guitarra, bajos.
    Public strValor
    Public Property CamposNulosTextBox(ByVal ErrorProviderAtriles As ErrorProvider, ByVal txtValor As TextBox) As String
        Get
            Return strValor
        End Get
        Set(ByVal value As String)
            If txtValor.TextLength = 0 Then
                ErrorProviderAtriles.SetError(txtValor, "Campo obligatorio")
                ErrorProviderAtriles.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
                Exit Property
            Else
                ErrorProviderAtriles.SetError(txtValor, "")
            End If
        End Set
    End Property

    Public Property CamposNulosComboBox(ByVal ErrorProviderAtriles As ErrorProvider, ByVal cmbValor As ComboBox) As String
        Get
            Return strValor
        End Get
        Set(ByVal value As String)
            If cmbValor.Text = "" Then
                ErrorProviderAtriles.SetError(cmbValor, "Campo obligatorio")
                ErrorProviderAtriles.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
            Else
                ErrorProviderAtriles.SetError(cmbValor, "")
            End If
        End Set
    End Property
    'Búsqueda de datos por idequipo o por idatril
    Public Sub BuscarAtril(ByVal dgResultados As DataGridView, ByVal txtDatoBusqueda As TextBox, ByVal blnOpcionBusqueda As Boolean)
        Conexion.Close()
        Try
            If blnOpcionBusqueda = True Then
                Conexion.Open()
                Dim DSET As New DataSet
                Dim DAD As New SqlDataAdapter("SELECT EQUIPOS.IDEQUIPO,IDATRIL,MARCA,MODELO,TIPO FROM EQUIPOS, ATRILES WHERE EQUIPOS.IDEQUIPO='" & txtDatoBusqueda.Text & "' AND EQUIPOS.IDEQUIPO=ATRILES.IDEQUIPO", Conexion)
                DAD.Fill(DSET)
                dgResultados.DataSource = DSET
                dgResultados.DataMember = "TABLE"
                dgResultados.Columns(0).HeaderText = "ID Eq."
                dgResultados.Columns(1).HeaderText = "ID Atr."
                dgResultados.Columns(2).HeaderText = "Marca"
                dgResultados.Columns(3).HeaderText = "Modelo"
                dgResultados.Columns(4).HeaderText = "Tipo"
                dgResultados.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                dgResultados.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                dgResultados.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                dgResultados.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                dgResultados.Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            ElseIf blnOpcionBusqueda = False Then
                Conexion.Open()
                Dim DSET As New DataSet
                Dim DAD As New SqlDataAdapter("SELECT EQUIPOS.IDEQUIPO,IDATRIL,MARCA,MODELO,TIPO FROM ATRILES, EQUIPOS WHERE IDATRIL='" & txtDatoBusqueda.Text & "'AND EQUIPOS.IDEQUIPO=ATRILES.IDEQUIPO", Conexion)
                DAD.Fill(DSET)
                dgResultados.DataSource = DSET
                dgResultados.DataMember = "TABLE"
                dgResultados.Columns(0).HeaderText = "ID Eq."
                dgResultados.Columns(1).HeaderText = "ID Atr."
                dgResultados.Columns(2).HeaderText = "Marca"
                dgResultados.Columns(3).HeaderText = "Modelo"
                dgResultados.Columns(4).HeaderText = "Tipo"
                dgResultados.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                dgResultados.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                dgResultados.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                dgResultados.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                dgResultados.Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
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
