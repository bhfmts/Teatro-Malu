Imports Teatro.ClassConexion
Imports Teatro.Validaciones
Imports System.Data.SqlClient
Imports Teatro.ClassVendedor
Imports Teatro.ClassProductor
Imports Teatro.ClassAdministrador
Imports Teatro.ClassCliente
Imports Teatro.ClassPersona

Public Class frmEliminarUsuario
    Dim ca As Boolean
    Dim strNombreUsuario As String
    Dim strApellidosUsuario As String
    Dim strDireccionUsuario As String
    Dim dtFechaNacUsuario As Date
    Dim intTelefonoUsuario As Integer
    Dim intPerfil As Integer
    Dim strRUNEliminar As String
    Dim drResultado As DialogResult

    Private Sub frmEliminarUsuario_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim drResultado As DialogResult = MsgBox("Asegúrese de haber completado correctamente sus operaciones. ¿Está seguro que desea cerrar? ", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Registro baterías")
        If drResultado = vbNo Then
            e.Cancel = True
        Else
            Me.Dispose()
        End If
    End Sub


    '************************************************************************************************************************
    'Validación de super usuario
    Private Sub frmEliminarUsuario_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Me.AdministradoresTableAdapter1.SelectSuperAdministrador(strRUNUsuario) = "4741033-9" Then
            Me.rdbAdministrador.Enabled = True
        Else
            Me.rdbAdministrador.Enabled = False
        End If
        Me.groTipoUsuario.Select()
    End Sub
    '**************************************************************************************************************
    'Al escribir el run correcto se cargan los datos de la boleta a anular según el numero de boleta ingresado
    Private Sub txtGuion_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtGuion.TextChanged
        strRUNEliminar = txtRUNUsuario.Text & "-" & txtGuion.Text
        Me.dgUsuarios.RowHeadersVisible = False
        Conexion.Close()
        Me.dgUsuarios.RowHeadersVisible = False
        If btnEliminar.Enabled = True Then
            If CamposNulos(Me.ErrorProviderEliminarUsuario, txtRUNUsuario) = True Then
                Exit Sub
            ElseIf CamposNulos(Me.ErrorProviderEliminarUsuario, txtGuion) = True Then
                Exit Sub
            End If
            ca = VerificaRut(txtRUNUsuario.Text, txtGuion.Text)
            If ca = True Then
            ElseIf ca = False Then
                ErrorProviderEliminarUsuario.Clear()
                ErrorProviderEliminarUsuario.SetError(txtGuion, "El R.U.N. está incorrecto")
                txtRUNUsuario.Focus()
                Exit Sub
            End If
            If ca = True Then
                ErrorProviderEliminarUsuario.SetError(txtGuion, "")
            End If

            '**************************************************************************************************************
            'Se cargan los datos correspondientes al usuario vendedor
            If Me.rbdVendedor.Checked = True And Me.rdbProductor.Checked = False Then
                CargarVendedor()

            End If

            '**************************************************************************************************************
            'Se cargan los datos correspondientes a un productor
            If rdbProductor.Checked = True And Me.rbdVendedor.Checked = False Then
                CargarProductor()
            End If

            'Se cargan los datos correspondientes a un administrador
            If rdbAdministrador.Checked = True Then
                CargarAdministrador()
            End If

            'Se cargan los datos correspondientes a un cliente
            If rdbCliente.Checked = True Then
                CargarCliente()
            End If
        End If
        If Me.rdbProductor.Checked = False And Me.rbdVendedor.Checked = False And Me.rdbAdministrador.Checked = False And Me.rdbCliente.Checked = False Then
            Me.ErrorProviderEliminarUsuario.SetError(groTipoUsuario, "Campo obligatorio")
            Exit Sub
        Else
            Me.ErrorProviderEliminarUsuario.SetError(groTipoUsuario, "")
        End If

        Me.btnEliminar.Enabled = True
    End Sub
    '**************************************************************************************************************
    'Procedimiento para cargar los datos de un Administrador
    Public Sub CargarAdministrador()
        'Se cargan los datos correspondientes al usuario Administrador
        If Me.rdbAdministrador.Checked = True Then
            Try
                Conexion.Open()
                Dim DSET As New DataSet
                Dim DAD As New SqlDataAdapter("SELECT RUNADMINISTRADOR,NOMBREADMINISTRADOR, APELLIDOADMINISTRADOR FROM ADMINISTRADORES WHERE RUNADMINISTRADOR='" & strRUNEliminar & "'", Conexion)
                DAD.Fill(DSET)
                dgUsuarios.DataSource = DSET
                dgUsuarios.DataMember = "TABLE"
                Me.dgUsuarios.Columns(0).HeaderText = "R.U.N."
                Me.dgUsuarios.Columns(1).HeaderText = "Nombres"
                Me.dgUsuarios.Columns(2).HeaderText = "Apellidos"
                Me.dgUsuarios.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                Me.dgUsuarios.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                Me.dgUsuarios.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            Finally
                Conexion.Close()
            End Try
        End If
        If dgUsuarios.RowCount = 0 Then
            Me.dgUsuarios.DataSource = Nothing
            MsgBox("No existen registros respecto a la información ingresada", MsgBoxStyle.Information, "Eliminar usuario")
            Exit Sub
        End If
    End Sub
    '**************************************************************************************************************
    'Procedimiento para cargar los datos de un vendedor
    Public Sub CargarVendedor()
        'Se cargan los datos correspondientes al usuario vendedor
        If Me.rbdVendedor.Checked = True And Me.rdbProductor.Checked = False Then
            Try
                Conexion.Open()
                Dim DSET As New DataSet
                Dim DAD As New SqlDataAdapter("SELECT RUNVENDEDOR,NOMBREVENDEDOR, APELLIDOVENDEDOR FROM VENDEDORES WHERE RUNVENDEDOR='" & strRUNEliminar & "'", Conexion)
                DAD.Fill(DSET)
                dgUsuarios.DataSource = DSET
                dgUsuarios.DataMember = "TABLE"
                Me.dgUsuarios.Columns(0).HeaderText = "R.U.N."
                Me.dgUsuarios.Columns(1).HeaderText = "Nombres"
                Me.dgUsuarios.Columns(2).HeaderText = "Apellidos"
                Me.dgUsuarios.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                Me.dgUsuarios.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                Me.dgUsuarios.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            Finally
                Conexion.Close()
            End Try
        End If
        If dgUsuarios.RowCount = 0 Then
            Me.dgUsuarios.DataSource = Nothing
            MsgBox("No existen registros respecto a la información ingresada", MsgBoxStyle.Information, "Eliminar usuario")
            Exit Sub
        End If
    End Sub

    '**************************************************************************************************************
    'Procedimiento para cargar los datos de un productor
    Public Sub CargarProductor()
        '**************************************************************************************************************
        'Se cargan los datos correspondientes a un productor
        If rdbProductor.Checked = True And Me.rbdVendedor.Checked = False Then
            Conexion.Close()
            Try
                Conexion.Open()
                Dim DSET As New DataSet
                Dim DAD As New SqlDataAdapter("SELECT RUNENCARGADO,NOMBREENCARGADO, APELLIDOENCARGADO FROM PRODUCCION WHERE RUNENCARGADO='" & strRUNEliminar & "'", Conexion)
                DAD.Fill(DSET)
                dgUsuarios.DataSource = DSET
                dgUsuarios.DataMember = "TABLE"
                Me.dgUsuarios.Columns(0).HeaderText = "R.U.N."
                Me.dgUsuarios.Columns(1).HeaderText = "Nombres"
                Me.dgUsuarios.Columns(2).HeaderText = "Apellidos"
                Me.dgUsuarios.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                Me.dgUsuarios.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                Me.dgUsuarios.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            Finally
                Conexion.Close()
            End Try
        End If
        If dgUsuarios.RowCount = 0 Then
            Me.dgUsuarios.DataSource = Nothing
            MsgBox("No existen registros respecto a la información ingresada", MsgBoxStyle.Information, "Eliminar usuario")
            Exit Sub
        End If
    End Sub
    '**************************************************************************************************************
    'Procedimiento para cargar los datos de un Administrador
    Public Sub CargarCliente()
        'Se cargan los datos correspondientes al usuario Administrador
        If Me.rdbCliente.Checked = True Then
            Try
                Conexion.Open()
                Dim DSET As New DataSet
                Dim DAD As New SqlDataAdapter("SELECT RUNCLIENTE,NOMBRECLIENTE, APELLIDOCLIENTE FROM CLIENTES WHERE RUNCLIENTE='" & strRUNEliminar & "'", Conexion)
                DAD.Fill(DSET)
                dgUsuarios.DataSource = DSET
                dgUsuarios.DataMember = "TABLE"
                Me.dgUsuarios.Columns(0).HeaderText = "R.U.N."
                Me.dgUsuarios.Columns(1).HeaderText = "Nombres"
                Me.dgUsuarios.Columns(2).HeaderText = "Apellidos"
                Me.dgUsuarios.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                Me.dgUsuarios.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                Me.dgUsuarios.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            Finally
                Conexion.Close()
            End Try
        End If
        If dgUsuarios.RowCount = 0 Then
            Me.dgUsuarios.DataSource = Nothing
            MsgBox("No existen registros respecto a la información ingresada", MsgBoxStyle.Information, "Eliminar usuario")
            Exit Sub
        End If
    End Sub
   

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Try
            If strRUNUsuario = strRUNEliminar Then
                If BuscarRUNAdministrador(strRUNUsuario) = True And rdbAdministrador.Checked = True Then
                    MsgBox("Una cuenta de usuario no se puede eliminar a si mismo", MsgBoxStyle.Critical, "Eliminar usuario")
                    Exit Sub
                End If
            End If
            If CamposNulos(Me.ErrorProviderEliminarUsuario, txtRUNUsuario) = True Then
                Exit Sub
            ElseIf CamposNulos(Me.ErrorProviderEliminarUsuario, txtGuion) = True Then
                Exit Sub
            End If
            ca = VerificaRut(txtRUNUsuario.Text, txtGuion.Text)
            If ca = True Then
            ElseIf ca = False Then
                ErrorProviderEliminarUsuario.Clear()
                ErrorProviderEliminarUsuario.SetError(txtGuion, "El R.U.N. está incorrecto")
                txtRUNUsuario.Focus()
                Exit Sub
            End If
            If ca = True Then
                ErrorProviderEliminarUsuario.SetError(txtGuion, "")
            End If
            If Me.rdbProductor.Checked = False And Me.rbdVendedor.Checked = False And Me.rdbAdministrador.Checked = False And Me.rdbCliente.Checked = False Then
                Me.ErrorProviderEliminarUsuario.SetError(groTipoUsuario, "Campo obligatorio")
                Exit Sub
            Else
                Me.ErrorProviderEliminarUsuario.SetError(groTipoUsuario, "")
            End If
            drResultado = MsgBox("¿Está seguro que quiere eliminar este usuario del sistema?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Eliminar usuario")
            If drResultado = vbYes Then

                'Borrar vendedor
                If Me.rbdVendedor.Checked = True Then
                    Me.VendedoresTableAdapter1.DeleteVendedor(strRUNEliminar)
                    MsgBox("Vendedor eliminado satisfactoriamente", MsgBoxStyle.Information, "Eliminar usuario")
                    Me.dgUsuarios.DataSource = Nothing
                    Me.btnEliminar.Enabled = False
                    Me.txtGuion.Clear()
                    Me.txtRUNUsuario.Clear()
                    Me.txtRUNUsuario.Focus()
                    'Borrar productor
                ElseIf Me.rdbProductor.Checked = True Then
                    Me.ProduccionTableAdapter1.DeleteProductor(strRUNEliminar)
                    MsgBox("Productor eliminado satisfactoriamente", MsgBoxStyle.Information, "Eliminar usuario")
                    Me.dgUsuarios.DataSource = Nothing
                    Me.btnEliminar.Enabled = False
                    Me.txtGuion.Clear()
                    Me.txtRUNUsuario.Clear()
                    Me.txtRUNUsuario.Focus()
                    'Borrar administrador
                ElseIf Me.rdbAdministrador.Checked = True Then
                    Me.AdministradoresTableAdapter1.DeleteAdministrador(strRUNEliminar)
                    MsgBox("Administrador eliminado satisfactoriamente", MsgBoxStyle.Information, "Eliminar usuario")
                    Me.dgUsuarios.DataSource = Nothing
                    Me.btnEliminar.Enabled = False
                    Me.txtGuion.Clear()
                    Me.txtRUNUsuario.Clear()
                    Me.txtRUNUsuario.Focus()
                    'Borrar cliente
                ElseIf Me.rdbCliente.Checked = True Then
                    Me.ClientesTableAdapter1.DeleteCliente(strRUNEliminar)
                    MsgBox("Cliente eliminado satisfactoriamente", MsgBoxStyle.Information, "Eliminar usuario")
                    Me.dgUsuarios.DataSource = Nothing
                    Me.btnEliminar.Enabled = False
                    Me.txtGuion.Clear()
                    Me.txtRUNUsuario.Clear()
                    Me.txtRUNUsuario.Focus()
                End If


            End If
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, "Eliminar usuario")
        End Try
    End Sub
    '**************************************************************************************************************
    'Válido que primero selecciona un valor antes de ingresar un dato
    Private Sub groTipoUsuario_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs)
        Try

        
            If Me.rdbProductor.Checked = False And Me.rbdVendedor.Checked = False And Me.rdbAdministrador.Checked = False And Me.rdbCliente.Checked = False Then
                Me.ErrorProviderEliminarUsuario.SetError(groTipoUsuario, "Campo obligatorio")
                Exit Sub
            Else
                Me.ErrorProviderEliminarUsuario.SetError(groTipoUsuario, "")
            End If
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, "Eliminar usuario")
        End Try
    End Sub
    '**************************************************************************************************************
    'Cargar los datos del vendedor al hacer click en el radiobutton
    Private Sub rbdVendedor_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbdVendedor.Click
        If txtRUNUsuario.TextLength <> 0 And txtGuion.TextLength <> 0 Then
            CargarVendedor()
        End If
    End Sub
    '**************************************************************************************************************
    'Cargar los datos del productor al hacer click en el radiobutton
    Private Sub rdbProductor_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdbProductor.Click
        If txtRUNUsuario.TextLength <> 0 And txtGuion.TextLength <> 0 Then
            CargarProductor()
        End If
    End Sub
    '**************************************************************************************************************
    'Cargar los datos del administrador al hacer click en el radiobutton
    Private Sub rdbAdministrador_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdbAdministrador.Click
        If txtRUNUsuario.TextLength <> 0 And txtGuion.TextLength <> 0 Then
            CargarAdministrador()
        End If
    End Sub
    '**************************************************************************************************************
    'Permitir el ingreso de sólo números
    Private Sub txtRUNUsuario_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRUNUsuario.KeyPress
        If (Asc(e.KeyChar)) >= 48 And (Asc(e.KeyChar)) <= 57 Or (Asc(e.KeyChar)) = System.Windows.Forms.Keys.Back Or Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    '**************************************************************************************************************
    'Cargar los datos del cliente al hacer click en el radiobutton
    Private Sub rdbCliente_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdbCliente.Click
        If txtRUNUsuario.TextLength <> 0 And txtGuion.TextLength <> 0 Then
            CargarCliente()
        End If
    End Sub

  
End Class



