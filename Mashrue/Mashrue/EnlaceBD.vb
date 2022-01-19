Imports System.Data
Imports System.Configuration
Imports System.Data.SqlClient
Public Class EnlaceBD
    Private conexion As SqlConnection
    Private comandosql As SqlCommand = New SqlCommand
    Private adaptador As SqlDataAdapter = New SqlDataAdapter
    Private ds, Auxds, Consultds, ConsultdsAux As DataSet
    Private AUXBMP As Bitmap
    Private iposicion As Integer
    Private Valor_String, Valor_StringAux As String


    Private Sub conectar()
        ' conexion = New SqlConnection(ConfigurationManager.ConnectionString("desaoper").ConnectionString)
        conexion = New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("desaoper").ConnectionString)
    End Sub

    Private Sub Desconectar()
        conexion.Close()
    End Sub

    Public Function GetValorString() As String
        Return Valor_String
    End Function

    Public Function GetValorStringAux() As String
        Return Valor_StringAux
    End Function

    Public Function ObtenerCmbValorId(ByVal cmd As ComboBox, ByVal Tabla As String, ByVal Campo As String) As String
        Dim AuxCount As Integer = cmd.SelectedIndex
        Dim IdValor As String = ds.Tables(Tabla).Rows(AuxCount).Item(Campo)
        Return IdValor
    End Function

    'ListEliminar es al que le voy a quitar el elemento para pasarselo a ListAgregar
    Public Sub PasarValoresdeLstToLst(ByVal ListAgregar As ListBox, ByVal ListEliminar As ListBox)
        Try
            If (ListEliminar.SelectedIndex <> -1) Then
                Dim AuxCount As Integer = ListEliminar.SelectedIndex
                Dim value As Object = ListEliminar.Items(AuxCount)
                ListAgregar.Items.Add(value)
                ListEliminar.Items.RemoveAt(AuxCount)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Function ObtenerNombUsuarioDepartamento(Id As String) As String

        conectar()
        Dim BuscarIdCons As String = "SELECT * FROM Departamento WHERE Departamento_Id = '" & Id & "'"
        Dim adap As New SqlDataAdapter(BuscarIdCons, conexion) 'Crear comando
        Auxds = New DataSet
        conexion.Open()
        adap.Fill(Auxds, "Departamento")
        Dim DNombre As String = Auxds.Tables("Departamento").Rows(0).Item("DNombre")

        Desconectar()

        Return DNombre
    End Function

    'Tabla = Nombre de la Tabla de la BD
    'Campo = Es la Id a comparar
    'CampoABuscar = Es el campo con el que comparare en la BD
    'CampoAObtener = es el valor buscado de la Consulta
    Private Function ObtenerCampo(Campo As String, Tabla As String, CampoABuscar As String, CampoAObtener As String) As String

        conectar()
        Dim BuscarIdCons As String = "SELECT * FROM " & Tabla & " WHERE " & CampoABuscar & " = '" & Campo & "'"
        Dim adap As New SqlDataAdapter(BuscarIdCons, conexion) 'Crear comando
        Auxds = New DataSet
        conexion.Open()
        adap.Fill(Auxds, Tabla)
        Dim DNombre As String = Auxds.Tables(Tabla).Rows(0).Item(CampoAObtener)

        Desconectar()

        Return DNombre
    End Function

    Public Function LlenarCmbTipoActividades(ByVal cmb As ComboBox) As Boolean
        Dim Estado = True
        Try
            cmb.Items().Clear()
            conectar()
            Dim sSql As String = "SELECT * FROM TipoActividad"
            Dim adap As New SqlDataAdapter(sSql, conexion) 'Crear comando
            Dim consulta1 As SqlCommandBuilder = New SqlCommandBuilder(adap)
            ds = New DataSet
            conexion.Open()
            adap.Fill(ds, "TipoActividad")
            conexion.Close()
            iposicion = 0

            Dim drow As DataRow
            drow = ds.Tables("TipoActividad").Rows(iposicion)
            cmb.Items.Add(drow("TNombre"))
            Dim Bandera As Boolean = True
            Do While (Bandera = True)
                If iposicion = ds.Tables("TipoActividad").Rows.Count - 1 Then
                    Bandera = False
                Else
                    iposicion += 1
                    drow = ds.Tables("TipoActividad").Rows(iposicion)
                    cmb.Items.Add(drow("TNombre"))
                End If
            Loop

        Catch ex As SqlException
            Estado = False
        Finally
            Desconectar()
        End Try
        Return Estado
    End Function

    Public Function LlenarCmbUsuario(ByVal cmb As ComboBox) As Boolean
        Dim Estado = True
        Try
            cmb.Items().Clear()
            conectar()
            Dim sSql As String = "SELECT * FROM Usuario"
            Dim adap As New SqlDataAdapter(sSql, conexion) 'Crear comando
            Dim consulta1 As SqlCommandBuilder = New SqlCommandBuilder(adap)
            ds = New DataSet
            conexion.Open()
            adap.Fill(ds, "Usuario")
            conexion.Close()
            iposicion = 0

            Dim drow As DataRow
            drow = ds.Tables("Usuario").Rows(iposicion)
            cmb.Items.Add(drow("UNombre"))
            Dim Bandera As Boolean = True
            Do While (Bandera = True)
                If iposicion = ds.Tables("Usuario").Rows.Count - 1 Then
                    Bandera = False
                Else
                    iposicion += 1
                    drow = ds.Tables("Usuario").Rows(iposicion)
                    cmb.Items.Add(drow("UNombre"))
                End If
            Loop

        Catch ex As SqlException
            Estado = False
        Finally
            Desconectar()
        End Try
        Return Estado
    End Function

    Public Function LlenarCmbProyecto(ByVal cmb As ComboBox) As Boolean
        Dim Estado = True
        Try
            cmb.Items().Clear()
            conectar()
            Dim sSql As String = "SELECT * FROM Proyecto"
            Dim adap As New SqlDataAdapter(sSql, conexion) 'Crear comando
            Dim consulta1 As SqlCommandBuilder = New SqlCommandBuilder(adap)
            ds = New DataSet
            conexion.Open()
            adap.Fill(ds, "Proyecto")
            conexion.Close()
            iposicion = 0

            Dim drow As DataRow
            drow = ds.Tables("Proyecto").Rows(iposicion)
            cmb.Items.Add(drow("PNombre"))
            Dim Bandera As Boolean = True
            Do While (Bandera = True)
                If iposicion = ds.Tables("Proyecto").Rows.Count - 1 Then
                    Bandera = False
                Else
                    iposicion += 1
                    drow = ds.Tables("Proyecto").Rows(iposicion)
                    cmb.Items.Add(drow("PNombre"))
                End If
            Loop

        Catch ex As SqlException
            Estado = False
        Finally
            Desconectar()
        End Try
        Return Estado
    End Function

    Public Function LlenarCmbDepartamento(ByVal cmb As ComboBox) As Boolean
        Dim Estado = True
        Try
            cmb.Items().Clear()
            conectar()
            Dim sSql As String = "SELECT * FROM Departamento"
            Dim adap As New SqlDataAdapter(sSql, conexion) 'Crear comando
            Dim consulta1 As SqlCommandBuilder = New SqlCommandBuilder(adap)
            ds = New DataSet
            conexion.Open()
            adap.Fill(ds, "Departamento")
            conexion.Close()
            iposicion = 0

            Dim drow As DataRow
            drow = ds.Tables("Departamento").Rows(iposicion)
            cmb.Items.Add(drow("DNombre"))
            Dim Bandera As Boolean = True
            Do While (Bandera = True)
                If iposicion = ds.Tables("Departamento").Rows.Count - 1 Then
                    Bandera = False
                Else
                    iposicion += 1
                    drow = ds.Tables("Departamento").Rows(iposicion)
                    cmb.Items.Add(drow("DNombre"))
                End If
            Loop

        Catch ex As SqlException
            Estado = False
        Finally
            Desconectar()
        End Try
        Return Estado
    End Function

    'Funciones de llenado de los Proyectos
    Public Function LlenarLstProyecto(ByVal list As ListBox) As Boolean
        Dim Estado = True
        Try
            list.Items().Clear()
            conectar()
            Dim sSql As String = "SELECT * FROM Usuario"
            Dim adap As New SqlDataAdapter(sSql, conexion) 'Crear comando
            'Dim consulta1 As SqlCommandBuilder = New SqlCommandBuilder(adap)
            ds = New DataSet
            conexion.Open()
            adap.Fill(ds, "Usuario")
            conexion.Close()
            iposicion = 0

            Dim drow As DataRow
            drow = ds.Tables("Usuario").Rows(iposicion)
            list.Items.Add(drow("UNombre"))
            Dim Bandera As Boolean = True
            Do While (Bandera = True)
                If iposicion = ds.Tables("Usuario").Rows.Count - 1 Then
                    Bandera = False
                Else
                    iposicion += 1
                    drow = ds.Tables("Usuario").Rows(iposicion)
                    list.Items.Add(drow("UNombre"))
                End If
            Loop

        Catch ex As SqlException
            Estado = False
        Finally
            Desconectar()
        End Try
        Return Estado
    End Function

    'Funciones del inicio
    'Consulta de usuarios
    Public Function ConsIndex(Data As DataGridView) As Boolean
        Dim Estado = True
        Try
            conectar()
            Dim table As New DataTable()
            Dim sSql As String = "SELECT * FROM Proyecto Where PEncargado = '" & GetValUsernameID() & "'"
            Dim adap As New SqlDataAdapter(sSql, conexion) 'Crear comando
            'Dim consulta1 As SqlCommandBuilder = New SqlCommandBuilder(adap)

            conexion.Open()
            adap.Fill(table)
            Data.DataSource = table
            conexion.Close()

        Catch ex As SqlException
            Estado = False
        Finally
            Desconectar()
        End Try
        Return Estado

    End Function

    'Funciones para Agregado de Actividades
    Public Function RegActividad(ByVal Actividad_Id As String, ByVal Descp As String, ByVal AFechaInicio As Date,
                                ByVal AFechaFinal As Date, ByVal ANumHEstim As Integer, ByVal AAutorizada As Boolean,
                                ByVal AUsuario_Id As String, ByVal ATipoActividad_Id As String, ByVal AProyecto_Id As String) As Boolean
        Dim Estado = True
        Try

            'ATipoActividad_Id = ObtenerCampo(IdUsuario, "Usuario", "UNombre", "Usuario_Id")
            ATipoActividad_Id = ObtenerCampo(ATipoActividad_Id, "TipoActividad", "TNombre", "TipoActividad_Id")

            conectar()

            comandosql = New SqlCommand("ST_ADDActividad", conexion)
            comandosql.CommandType = CommandType.StoredProcedure

            Dim parametro1 As SqlParameter = comandosql.Parameters.Add("@Actividad_Id", SqlDbType.VarChar, 50)
            parametro1.Value = Actividad_Id

            Dim parametro2 As SqlParameter = comandosql.Parameters.Add("@Descp", SqlDbType.VarChar, 100)
            parametro2.Value = Descp

            Dim parametro3 As SqlParameter = comandosql.Parameters.Add("@AFechaInicio", SqlDbType.Date, 10)
            parametro3.Value = AFechaInicio

            Dim parametro4 As SqlParameter = comandosql.Parameters.Add("@AFechaFinal", SqlDbType.Date, 10)
            parametro4.Value = AFechaFinal

            Dim parametro5 As SqlParameter = comandosql.Parameters.Add("@ANumHEstim", SqlDbType.Int, 50)
            parametro5.Value = ANumHEstim

            Dim parametro6 As SqlParameter = comandosql.Parameters.Add("@AAutorizada", SqlDbType.Bit, 50)
            parametro6.Value = AAutorizada

            Dim parametro7 As SqlParameter = comandosql.Parameters.Add("@AUsuario_Id", SqlDbType.VarChar, 50)
            parametro7.Value = AUsuario_Id

            Dim parametro8 As SqlParameter = comandosql.Parameters.Add("@ATipoActividad_Id", SqlDbType.VarChar, 50)
            parametro8.Value = ATipoActividad_Id

            Dim parametro9 As SqlParameter = comandosql.Parameters.Add("@AProyecto_Id", SqlDbType.VarChar, 50)
            parametro9.Value = AProyecto_Id

            conexion.Open()
            adaptador.InsertCommand = comandosql
            comandosql.ExecuteNonQuery()

        Catch ex As SqlException
            Estado = False
        Finally
            Desconectar()
        End Try
        Return Estado
    End Function

    'Funciones para Agregado de Actividades
    Public Function ModActividad(ByVal Actividad_Id As String, ByVal Descp As String, ByVal AFechaInicio As Date,
                                ByVal AFechaFinal As Date, ByVal ANumHEstim As Integer, ByVal AAutorizada As Boolean,
                                ByVal AUsuario_Id As String, ByVal ATipoActividad_Id As String, ByVal AProyecto_Id As String) As Boolean
        Dim Estado = True
        Try

            'ATipoActividad_Id = ObtenerCampo(IdUsuario, "Usuario", "UNombre", "Usuario_Id")
            ATipoActividad_Id = ObtenerCampo(ATipoActividad_Id, "TipoActividad", "TNombre", "TipoActividad_Id")

            conectar()

            comandosql = New SqlCommand("[ST_MODActividad]", conexion)
            comandosql.CommandType = CommandType.StoredProcedure

            Dim parametro1 As SqlParameter = comandosql.Parameters.Add("@Actividad_Id", SqlDbType.VarChar, 50)
            parametro1.Value = Actividad_Id

            Dim parametro2 As SqlParameter = comandosql.Parameters.Add("@Descp", SqlDbType.VarChar, 100)
            parametro2.Value = Descp

            Dim parametro3 As SqlParameter = comandosql.Parameters.Add("@AFechaInicio", SqlDbType.Date, 10)
            parametro3.Value = AFechaInicio

            Dim parametro4 As SqlParameter = comandosql.Parameters.Add("@AFechaFinal", SqlDbType.Date, 10)
            parametro4.Value = AFechaFinal

            Dim parametro5 As SqlParameter = comandosql.Parameters.Add("@ANumHEstim", SqlDbType.Int, 50)
            parametro5.Value = ANumHEstim

            Dim parametro6 As SqlParameter = comandosql.Parameters.Add("@AAutorizada", SqlDbType.Bit, 50)
            parametro6.Value = AAutorizada

            Dim parametro7 As SqlParameter = comandosql.Parameters.Add("@AUsuario_Id", SqlDbType.VarChar, 50)
            parametro7.Value = AUsuario_Id

            Dim parametro8 As SqlParameter = comandosql.Parameters.Add("@ATipoActividad_Id", SqlDbType.VarChar, 50)
            parametro8.Value = ATipoActividad_Id

            Dim parametro9 As SqlParameter = comandosql.Parameters.Add("@AProyecto_Id", SqlDbType.VarChar, 50)
            parametro9.Value = AProyecto_Id

            conexion.Open()
            adaptador.InsertCommand = comandosql
            comandosql.ExecuteNonQuery()

        Catch ex As SqlException
            Estado = False

        Finally
            Desconectar()
        End Try
        Return Estado
    End Function

    'Aprobación de los estados de las actividades
    Public Function CargarDatActividad(Sentencia As String, lblConteo As Label, ByVal Actividad_Id As TextBox, ByVal Descp As TextBox, ByVal AFechaInicio As DateTimePicker,
                                ByVal AFechaFinal As DateTimePicker, ByVal ANumHEstim As TextBox, ByVal ATipoActividad_Id As ComboBox, ByVal AProyecto_Id As TextBox) As Boolean
        Dim Estado = True
        Try
            conectar()
            ds = New DataSet
            'Dim sSql As String = "SELECT * FROM Actividad WHERE AAutorizada = '0' AND AUsuario_Id = '" & GetValUsernameID() & "'"
            'Dim sSql As String = "SELECT * from Proyecto Inner Join Actividad ON Proyecto.Proyecto_Id = Actividad.AProyecto_Id WHERE AAutorizada = '0' AND Proyecto.PEncargado = '" & GetValUsernameID() & "'"
            Dim sSql As String = Sentencia
            Dim adap As New SqlDataAdapter(sSql, conexion) 'Crear comando
            'Dim consulta1 As SqlCommandBuilder = New SqlCommandBuilder(adap)

            conexion.Open()

            adap.Fill(ds, "Actividad")

            conexion.Close()

            iposicion = 0
            ActualizarActividad(ds, lblConteo, Actividad_Id, Descp, AFechaInicio, AFechaFinal, ANumHEstim, ATipoActividad_Id, AProyecto_Id)

        Catch ex As SqlException
            Estado = False
        Finally
            Desconectar()
        End Try
        Return Estado

    End Function

    'Carga los actividades actuales
    Private Sub ActualizarActividad(ds As DataSet, lblConteo As Label, ByVal Actividad_Id As TextBox, ByVal Descp As TextBox, ByVal AFechaInicio As DateTimePicker,
                                ByVal AFechaFinal As DateTimePicker, ByVal ANumHEstim As TextBox, ByVal ATipoActividad_Id As ComboBox, ByVal AProyecto_Id As TextBox)
        Dim DataFilas As DataRow
        DataFilas = ds.Tables("Actividad").Rows(iposicion)

        'Dim consulta1 As SqlCommandBuilder = New SqlCommandBuilder(adap)

        Actividad_Id.Text = DataFilas("Actividad_Id")
        Descp.Text = DataFilas("ADescripcion")
        AFechaInicio.Value = DataFilas("AFechaInicio")
        AFechaFinal.Value = DataFilas("AFechaFinal")
        ANumHEstim.Text = DataFilas("ANumHEstim")
        AProyecto_Id.Text = DataFilas("AProyecto_Id")
        Dim AuxIdDepartamentoAct As String = DataFilas("ATipoActividad_Id")
        ATipoActividad_Id.SelectedIndex = ATipoActividad_Id.FindStringExact(ObtenerCampo(AuxIdDepartamentoAct, "TipoActividad", "TipoActividad_Id", "TNombre"))


        lblConteo.Text = "Registro: " & iposicion + 1 & " de " & ds.Tables("Actividad").Rows.Count

    End Sub

    Public Sub ActividadSiguiente(lblConteo As Label, ByVal Actividad_Id As TextBox, ByVal Descp As TextBox, ByVal AFechaInicio As DateTimePicker,
                                ByVal AFechaFinal As DateTimePicker, ByVal ANumHEstim As TextBox, ByVal ATipoActividad_Id As ComboBox, ByVal AProyecto_Id As TextBox)
        If (iposicion = (ds.Tables("Actividad").Rows.Count - 1)) Then
            MessageBox.Show("Ulimo registro")
        Else
            iposicion += 1
            ActualizarActividad(ds, lblConteo, Actividad_Id, Descp, AFechaInicio, AFechaFinal, ANumHEstim, ATipoActividad_Id, AProyecto_Id)
        End If

    End Sub

    Public Sub ActividadAnterior(lblConteo As Label, ByVal Actividad_Id As TextBox, ByVal Descp As TextBox, ByVal AFechaInicio As DateTimePicker,
                                ByVal AFechaFinal As DateTimePicker, ByVal ANumHEstim As TextBox, ByVal ATipoActividad_Id As ComboBox, ByVal AProyecto_Id As TextBox)
        If (iposicion = 0) Then
            MessageBox.Show("Primer registro")
        Else
            iposicion -= 1
            ActualizarActividad(ds, lblConteo, Actividad_Id, Descp, AFechaInicio, AFechaFinal, ANumHEstim, ATipoActividad_Id, AProyecto_Id)
        End If

    End Sub

    'Consulta de Proyectos
    Public Function ConsProyectoINActividad(Data As DataGridView) As Boolean
        Dim Estado = True
        Try
            conectar()
            Dim table As New DataTable()
            Dim sSql As String = "SELECT * FROM Proyecto_Resumen"
            Dim adap As New SqlDataAdapter(sSql, conexion) 'Crear comando
            'Dim consulta1 As SqlCommandBuilder = New SqlCommandBuilder(adap)

            conexion.Open()
            adap.Fill(table)
            Data.DataSource = table
            conexion.Close()

        Catch ex As SqlException
            Estado = False
        Finally
            Desconectar()
        End Try
        Return Estado

    End Function

    'Consulta de Proyectos
    Public Function ConsProyecto(Data As DataGridView) As Boolean
        Dim Estado = True
        Try
            conectar()
            Dim table As New DataTable()
            Dim sSql As String = "SELECT * FROM Proyecto"
            Dim adap As New SqlDataAdapter(sSql, conexion) 'Crear comando
            'Dim consulta1 As SqlCommandBuilder = New SqlCommandBuilder(adap)

            conexion.Open()
            adap.Fill(table)
            Data.DataSource = table
            conexion.Close()

        Catch ex As SqlException
            Estado = False
        Finally
            Desconectar()
        End Try
        Return Estado

    End Function


    'Modificación de Proyectos
    Public Function CargarDatProyecto(lblConteo As Label, ProyectID As TextBox, Nomb As TextBox, FechaInicio As DateTimePicker,
                                      FechaFinal As DateTimePicker, Presupuesto As TextBox, HorasEstim As TextBox,
                                      Departamento As ComboBox, Encargado As TextBox, CompDisp As ListBox,
                                      CompSelect As ListBox, EstadoPro As CheckBox, HorasReales As TextBox, FechaRealFinal As DateTimePicker) As Boolean
        Dim Estado = True
        Try
            conectar()
            ds = New DataSet


            Dim sSql As String = "SELECT * FROM Proyecto Where PEncargado = '" & GetValUsernameID() & "'"


            Dim adap As New SqlDataAdapter(sSql, conexion) 'Crear comando


            'Dim consulta1 As SqlCommandBuilder = New SqlCommandBuilder(adap)

            conexion.Open()

            adap.Fill(ds, "Proyecto")


            conexion.Close()

            iposicion = 0
            ActualizarProyecto(ds, lblConteo, ProyectID, Nomb, FechaInicio, FechaFinal, Presupuesto, HorasEstim, Departamento, Encargado, CompDisp, CompSelect, EstadoPro, HorasReales, FechaRealFinal)

        Catch ex As SqlException
            Estado = False
        Finally
            Desconectar()
        End Try
        Return Estado

    End Function

    'Carga los Usuarios actuales
    Private Sub ActualizarProyecto(ds As DataSet, lblConteo As Label, ProyectID As TextBox, Nomb As TextBox, FechaInicio As DateTimePicker,
                                      FechaFinal As DateTimePicker, Presupuesto As TextBox, HorasEstim As TextBox,
                                      Departamento As ComboBox, Encargado As TextBox, CompDisp As ListBox,
                                      CompSelect As ListBox, EstadoPro As CheckBox, HorasReales As TextBox, FechaRealFinal As DateTimePicker)

        Dim DataFilas As DataRow
        DataFilas = ds.Tables("Proyecto").Rows(iposicion)
        ProyectID.Text = DataFilas("Proyecto_Id")
        Nomb.Text = DataFilas("PNombre")
        FechaInicio.Value = DataFilas("PFechaInicio")
        FechaFinal.Value = DataFilas("PFechaFinal")
        Presupuesto.Text = DataFilas("PPresupuesto")
        HorasEstim.Text = DataFilas("PNumHEstim")
        Encargado.Text = DataFilas("PEncargado")

        If (DataFilas("PRealFechaF").ToString() = "") Then
            FechaRealFinal.ResetText()
            'HorasReales.Text = "0"
        Else
            FechaRealFinal.Value = DataFilas("PRealFechaF")
            'HorasReales.Text = DataFilas("PRealHorasT")
        End If

        Auxds = New DataSet
        Dim sSqlCommander As String = "SELECT * FROM Actividad WHERE AProyecto_Id ='" & ProyectID.Text & "'"
        Dim adap3 As New SqlDataAdapter(sSqlCommander, conexion) 'Crear comando
        adap3.Fill(Auxds, "Actividad")
        Dim Conteo3 As Integer = Auxds.Tables("Actividad").Rows.Count - 1
        Dim Ciclo2 As Integer = 0
        Dim HorasSumador As Integer = 0
        Do While (Ciclo2 <= Conteo3)
            HorasSumador += Auxds.Tables("Actividad").Rows(Ciclo2).Item("ANumHEstim")
            Ciclo2 += 1
        Loop
        HorasReales.Text = HorasSumador


        EstadoPro.Checked = DataFilas("PProyActivo")


        lblConteo.Text = "Registro: " & iposicion + 1 & " de " & ds.Tables("Proyecto").Rows.Count

        CompSelect.Items().Clear()
        conectar()

        Consultds = New DataSet
        ConsultdsAux = New DataSet
        Dim sSqlAux As String = "SELECT * FROM Departamento_Proyecto Where Proyecto_id = '" & ProyectID.Text & "'"
        Dim sSqlAuxSec As String = "SELECT * FROM Usuario_Proyecto Where Proyecto_id = '" & ProyectID.Text & "'"
        Dim adap1 As New SqlDataAdapter(sSqlAux, conexion) 'Crear comando
        Dim adap2 As New SqlDataAdapter(sSqlAuxSec, conexion) 'Crear comando
        adap1.Fill(Consultds, "Departamento_Proyecto")
        adap2.Fill(ConsultdsAux, "Usuario_Proyecto")

        conexion.Close()
        Desconectar()
        Dim Conteo As Integer = Consultds.Tables("Departamento_Proyecto").Rows.Count - 1
        If (Conteo = 0) Then
            Dim IdDepa As String = Consultds.Tables("Departamento_Proyecto").Rows(0).Item("Departamento_Id")
            Departamento.SelectedIndex = Departamento.FindStringExact(ObtenerNombUsuarioDepartamento(IdDepa))
        End If

        Dim Conteo2 As Integer = ConsultdsAux.Tables("Usuario_Proyecto").Rows.Count - 1
        Dim ciclo As Integer = 0
        If (Conteo2 >= 0) Then
            Do While (ciclo <= Conteo2)
                Dim IdUsua As String = ConsultdsAux.Tables("Usuario_Proyecto").Rows(ciclo).Item("Usuario_Id")
                CompSelect.Items.Add(ObtenerCampo(IdUsua, "Usuario", "Usuario_Id", "UNombre"))
                ciclo = ciclo + 1
            Loop
        End If
        'Dim consulta1 As SqlCommandBuilder = New SqlCommandBuilder(adap)

    End Sub

    Public Sub ProyectoSiguiente(lblConteo As Label, ProyectID As TextBox, Nomb As TextBox, FechaInicio As DateTimePicker,
                                      FechaFinal As DateTimePicker, Presupuesto As TextBox, HorasEstim As TextBox,
                                      Departamento As ComboBox, Encargado As TextBox, CompDisp As ListBox,
                                      CompSelect As ListBox, EstadoPro As CheckBox, HorasReales As TextBox, FechaRealFinal As DateTimePicker)
        If (iposicion = (ds.Tables("Proyecto").Rows.Count - 1)) Then
            MessageBox.Show("Ulimo registro")
        Else
            iposicion += 1
            ActualizarProyecto(ds, lblConteo, ProyectID, Nomb, FechaInicio, FechaFinal, Presupuesto, HorasEstim, Departamento, Encargado, CompDisp, CompSelect, EstadoPro, HorasReales, FechaRealFinal)
            'ActualizarProyecto(ds, lblConteo, ProyectID, Nomb, FechaInicio, FechaFinal, Presupuesto, HorasEstim, Departamento, Encargado, CompDisp, CompSelect)
        End If

    End Sub

    Public Sub ProyectoAnterior(lblConteo As Label, ProyectID As TextBox, Nomb As TextBox, FechaInicio As DateTimePicker,
                                      FechaFinal As DateTimePicker, Presupuesto As TextBox, HorasEstim As TextBox,
                                      Departamento As ComboBox, Encargado As TextBox, CompDisp As ListBox,
                                      CompSelect As ListBox, EstadoPro As CheckBox, HorasReales As TextBox, FechaRealFinal As DateTimePicker)
        If (iposicion = 0) Then
            MessageBox.Show("Primer registro")
        Else
            iposicion -= 1
            ActualizarProyecto(ds, lblConteo, ProyectID, Nomb, FechaInicio, FechaFinal, Presupuesto, HorasEstim, Departamento, Encargado, CompDisp, CompSelect, EstadoPro, HorasReales, FechaRealFinal)
            'ActualizarProyecto(ds, lblConteo, ProyectID, Nomb, FechaInicio, FechaFinal, Presupuesto, HorasEstim, Departamento, Encargado, CompDisp, CompSelect)
        End If

    End Sub



    'Registro Departamento_Proyecto
    Public Function RegDepartamento_Proyecto(ByVal IdDept As String, ByVal IdProy As String) As Boolean
        Dim Estado = True
        Try
            conectar()

            comandosql = New SqlCommand("ST_ADDDepartamento_Proyecto", conexion)
            comandosql.CommandType = CommandType.StoredProcedure

            Dim parametro1 As SqlParameter = comandosql.Parameters.Add("@Departamento_Id", SqlDbType.VarChar, 50)
            parametro1.Value = IdDept

            Dim parametro2 As SqlParameter = comandosql.Parameters.Add("@Proyecto_Id", SqlDbType.VarChar, 50)
            parametro2.Value = IdProy

            conexion.Open()
            adaptador.InsertCommand = comandosql
            comandosql.ExecuteNonQuery()

        Catch ex As SqlException
            Estado = False
        Finally
            Desconectar()
        End Try
        Return Estado
    End Function

    'Registro Departamento_Proyecto
    Public Function RegUsuario_Proyecto(ByVal IdUsuario As String, ByVal IdProy As String) As Boolean
        Dim Estado = True
        Try

            IdUsuario = ObtenerCampo(IdUsuario, "Usuario", "UNombre", "Usuario_Id")

            conectar()

            comandosql = New SqlCommand("ST_ADDUsuario_Proyecto", conexion)
            comandosql.CommandType = CommandType.StoredProcedure

            Dim parametro1 As SqlParameter = comandosql.Parameters.Add("@Usuario_Id", SqlDbType.VarChar, 50)
            parametro1.Value = IdUsuario

            Dim parametro2 As SqlParameter = comandosql.Parameters.Add("@Proyecto_Id", SqlDbType.VarChar, 50)
            parametro2.Value = IdProy

            Dim parametro3 As SqlParameter = comandosql.Parameters.Add("@Permisos", SqlDbType.VarChar, 50)
            parametro3.Value = DBNull.Value

            conexion.Open()
            adaptador.InsertCommand = comandosql
            comandosql.ExecuteNonQuery()

        Catch ex As SqlException
            Estado = False
        Finally
            Desconectar()
        End Try
        Return Estado
    End Function

    'Funciones para Eliminar de Proyecto---------------------------------------------------------------
    Public Function DelProyecto(ByVal IdPro As String) As Boolean
        Dim Estado = True
        Try
            conectar()

            comandosql = New SqlCommand("ST_DELProyecto", conexion)
            comandosql.CommandType = CommandType.StoredProcedure

            Dim parametro1 As SqlParameter = comandosql.Parameters.Add("@Proyecto_Id", SqlDbType.VarChar, 50)
            parametro1.Value = IdPro

            conexion.Open()
            adaptador.InsertCommand = comandosql
            comandosql.ExecuteNonQuery()

        Catch ex As SqlException
            Estado = False
        Finally
            Desconectar()
        End Try
        Return Estado
    End Function

    'Funciones para modificar el proyecto ------------------------------------------------------------

    Public Function DelDepartamento_Proyecto(ByVal IdPro As String) As Boolean
        Dim Estado = True
        Try
            conectar()

            comandosql = New SqlCommand("ST_MODDepartamento_Proyecto", conexion)
            comandosql.CommandType = CommandType.StoredProcedure

            Dim parametro1 As SqlParameter = comandosql.Parameters.Add("@Proyecto_Id", SqlDbType.VarChar, 50)
            parametro1.Value = IdPro

            conexion.Open()
            adaptador.InsertCommand = comandosql
            comandosql.ExecuteNonQuery()

        Catch ex As SqlException
            Estado = False
        Finally
            Desconectar()
        End Try
        Return Estado
    End Function

    Public Function DelUsuario_Proyecto(ByVal IdPro As String) As Boolean
        Dim Estado = True
        Try
            conectar()

            comandosql = New SqlCommand("ST_MODUsuario_Proyecto", conexion)
            comandosql.CommandType = CommandType.StoredProcedure

            Dim parametro1 As SqlParameter = comandosql.Parameters.Add("@Proyecto_Id", SqlDbType.VarChar, 50)
            parametro1.Value = IdPro

            conexion.Open()
            adaptador.InsertCommand = comandosql
            comandosql.ExecuteNonQuery()

        Catch ex As SqlException
            Estado = False
        Finally
            Desconectar()
        End Try
        Return Estado
    End Function

    Public Function ModProyecto(ByVal Proyecto_Id As String, ByVal PNombre As String, ByVal PFechaInicio As Date,
                                ByVal PFechaFinal As Date, ByVal PNumHEstim As Integer, ByVal PPresupuesto As Double,
                                ByVal PRealFechaF As Date, ByVal PRealHorasT As Double, ByVal PProyActivo As Boolean,
                                ByVal PEncargado As String) As Boolean
        Dim Estado = True
        Try
            conectar()

            comandosql = New SqlCommand("ST_MODProyecto", conexion)
            comandosql.CommandType = CommandType.StoredProcedure

            Dim parametro1 As SqlParameter = comandosql.Parameters.Add("@Proyecto_Id", SqlDbType.VarChar, 50)
            parametro1.Value = Proyecto_Id

            Dim parametro2 As SqlParameter = comandosql.Parameters.Add("@PNombre", SqlDbType.VarChar, 50)
            parametro2.Value = PNombre

            Dim parametro3 As SqlParameter = comandosql.Parameters.Add("@PFechaInicio", SqlDbType.Date, 10)
            parametro3.Value = PFechaInicio

            Dim parametro4 As SqlParameter = comandosql.Parameters.Add("@PFechaFinal", SqlDbType.Date, 10)
            parametro4.Value = PFechaFinal

            Dim parametro5 As SqlParameter = comandosql.Parameters.Add("@PNumHEstim", SqlDbType.Int, 50)
            parametro5.Value = PNumHEstim

            Dim parametro6 As SqlParameter = comandosql.Parameters.Add("@PPresupuesto", SqlDbType.Float, 50)
            parametro6.Value = PPresupuesto

            Dim parametro7 As SqlParameter = comandosql.Parameters.Add("@PRealFechaF", SqlDbType.Date, 50)
            parametro7.Value = PRealFechaF

            Dim parametro8 As SqlParameter = comandosql.Parameters.Add("@PRealHorasT", SqlDbType.Float, 50)
            parametro8.Value = PRealHorasT

            Dim parametro9 As SqlParameter = comandosql.Parameters.Add("@PProyActivo", SqlDbType.Bit, 10)
            parametro9.Value = PProyActivo

            Dim parametro10 As SqlParameter = comandosql.Parameters.Add("@PEncargado", SqlDbType.VarChar, 50)
            parametro10.Value = PEncargado

            conexion.Open()
            adaptador.InsertCommand = comandosql
            comandosql.ExecuteNonQuery()

        Catch ex As SqlException
            Estado = False
        Finally
            Desconectar()
        End Try
        Return Estado
    End Function

    '------------------------------------------------------------------------------------------------------


    Public Function RegProyecto(ByVal Proyecto_Id As String, ByVal PNombre As String, ByVal PFechaInicio As Date,
                                ByVal PFechaFinal As Date, ByVal PNumHEstim As Integer, ByVal PPresupuesto As Double,
                                ByVal PProyActivo As Boolean,
                                ByVal PEncargado As String) As Boolean
        Dim Estado = True
        Try
            conectar()

            comandosql = New SqlCommand("ST_ADDProyecto", conexion)
            comandosql.CommandType = CommandType.StoredProcedure

            Dim parametro1 As SqlParameter = comandosql.Parameters.Add("@Proyecto_Id", SqlDbType.VarChar, 50)
            parametro1.Value = Proyecto_Id

            Dim parametro2 As SqlParameter = comandosql.Parameters.Add("@PNombre", SqlDbType.VarChar, 50)
            parametro2.Value = PNombre

            Dim parametro3 As SqlParameter = comandosql.Parameters.Add("@PFechaInicio", SqlDbType.Date, 10)
            parametro3.Value = PFechaInicio

            Dim parametro4 As SqlParameter = comandosql.Parameters.Add("@PFechaFinal", SqlDbType.Date, 10)
            parametro4.Value = PFechaFinal

            Dim parametro5 As SqlParameter = comandosql.Parameters.Add("@PNumHEstim", SqlDbType.Int, 50)
            parametro5.Value = PNumHEstim

            Dim parametro6 As SqlParameter = comandosql.Parameters.Add("@PPresupuesto", SqlDbType.Float, 50)
            parametro6.Value = PPresupuesto

            Dim parametro7 As SqlParameter = comandosql.Parameters.Add("@PRealFechaF", SqlDbType.Date, 50)
            parametro7.Value = DBNull.Value

            Dim parametro8 As SqlParameter = comandosql.Parameters.Add("@PRealHorasT", SqlDbType.Float, 50)
            parametro8.Value = DBNull.Value

            Dim parametro9 As SqlParameter = comandosql.Parameters.Add("@PProyActivo", SqlDbType.Bit, 10)
            parametro9.Value = PProyActivo

            Dim parametro10 As SqlParameter = comandosql.Parameters.Add("@PEncargado", SqlDbType.VarChar, 50)
            parametro10.Value = PEncargado

            conexion.Open()
            adaptador.InsertCommand = comandosql
            comandosql.ExecuteNonQuery()

        Catch ex As SqlException
            Estado = False
        Finally
            Desconectar()
        End Try
        Return Estado
    End Function

    Public Function RegUsuario(ByVal IdUsuario As String, ByVal Nombre As String, ByVal Password As String, ByVal Email As String, ByVal Tel As String, ByVal Rol As Integer, ByVal Departamento As String, ByVal Img As PictureBox) As Boolean
        Dim Estado = True
        Try
            conectar()
            Dim ms As New System.IO.MemoryStream()
            Img.BackgroundImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
            Dim sSql As String = "INSERT INTO Usuario VALUES (@Usuario_Id, @Nombre, @Email, @Contraseña, @Tel, @Rol, @Logotipo, @Departamento)" 'Creamos el Query.
            Dim cmd As New SqlCommand(sSql, conexion) 'Creamos el comando.
            cmd.Parameters.Add("@Usuario_Id", System.Data.SqlDbType.VarChar)
            cmd.Parameters.Add("@Nombre", System.Data.SqlDbType.VarChar)
            cmd.Parameters.Add("@Email", System.Data.SqlDbType.VarChar)
            cmd.Parameters.Add("@Contraseña", System.Data.SqlDbType.VarChar)
            cmd.Parameters.Add("@Tel", System.Data.SqlDbType.VarChar)
            cmd.Parameters.Add("@Rol", System.Data.SqlDbType.Int)
            cmd.Parameters.Add("@Logotipo", System.Data.SqlDbType.Image)
            cmd.Parameters.Add("@Departamento", System.Data.SqlDbType.VarChar)

            cmd.Parameters("@Usuario_Id").Value = IdUsuario
            cmd.Parameters("@Nombre").Value = Nombre
            cmd.Parameters("@Email").Value = Email
            cmd.Parameters("@Contraseña").Value = Password
            cmd.Parameters("@Tel").Value = Tel
            cmd.Parameters("@Rol").Value = Rol
            cmd.Parameters("@Logotipo").Value = ms.GetBuffer()
            cmd.Parameters("@Departamento").Value = Departamento

            'cmd.Parameters.Add(New SqlParameter("@Logotipo", ms.GetBuffer())) 'Agregamos el MemoryStream a los parametros para poderlos guardar en la base de datos.

            conexion.Open()
            cmd.ExecuteNonQuery() 'ejecutamos el query.
            conexion.Close()

            cmd = Nothing
            ms.Dispose()
            ms.Close()

        Catch ex As SqlException
            Estado = False
        Finally
            Desconectar()
        End Try
        Return Estado

    End Function

    'Consulta de usuarios
    Public Function ConsUsuario(Data As DataGridView) As Boolean
        Dim Estado = True
        Try
            conectar()
            Dim table As New DataTable()
            Dim sSql As String = "SELECT * FROM Usuario"
            Dim adap As New SqlDataAdapter(sSql, conexion) 'Crear comando
            'Dim consulta1 As SqlCommandBuilder = New SqlCommandBuilder(adap)

            conexion.Open()
            adap.Fill(table)
            Data.DataSource = table
            conexion.Close()

        Catch ex As SqlException
            Estado = False
        Finally
            Desconectar()
        End Try
        Return Estado

    End Function

    'Modificación de Dep
    Public Function CargarDatUsuario(lblConteo As Label, UsuID As TextBox, Nomb As TextBox, Con As TextBox, Tel As TextBox, Email As TextBox, ByVal Rol As ComboBox, ByVal Departamento As ComboBox, ByVal Img As PictureBox) As Boolean
        Dim Estado = True
        Try
            conectar()
            ds = New DataSet
            Dim sSql As String = "SELECT * FROM Usuario"
            Dim adap As New SqlDataAdapter(sSql, conexion) 'Crear comando
            'Dim consulta1 As SqlCommandBuilder = New SqlCommandBuilder(adap)

            conexion.Open()

            adap.Fill(ds, "Usuario")

            conexion.Close()

            iposicion = 0
            ActualizarUsuario(ds, lblConteo, UsuID, Nomb, Con, Tel, Email, Rol, Departamento, Img)

        Catch ex As SqlException
            Estado = False
        Finally
            Desconectar()
        End Try
        Return Estado

    End Function

    'Carga los Usuarios actuales
    Private Sub ActualizarUsuario(ds As DataSet, lblConteo As Label, UsuID As TextBox, Nomb As TextBox, Con As TextBox, Tel As TextBox, Email As TextBox, ByVal Rol As ComboBox, ByVal Departamento As ComboBox, ByVal Img As PictureBox)
        Dim ms As New System.IO.MemoryStream() 'Creamos el MemoryStream y poder cargar la imagen.
        Dim DataFilas As DataRow
        DataFilas = ds.Tables("Usuario").Rows(iposicion)

        'Dim consulta1 As SqlCommandBuilder = New SqlCommandBuilder(adap)

        UsuID.Text = DataFilas("Usuario_Id")
        Nomb.Text = DataFilas("UNombre")
        Email.Text = DataFilas("UEmail")
        Con.Text = DataFilas("UContraseña")
        Tel.Text = DataFilas("UTel")
        Rol.SelectedIndex = DataFilas("URol")
        Dim AuxIdDepartamentoAct As String = DataFilas("UDepartamento_Id")
        Departamento.SelectedIndex = Departamento.FindStringExact(ObtenerNombUsuarioDepartamento(AuxIdDepartamentoAct))

        Dim imageBuffer() As Byte = CType(DataFilas("UImage"), Byte()) 'Conbertimos la imagen cargada en el datatable a Bytes.
        ms = New System.IO.MemoryStream(imageBuffer) 'Cargamos el MemoryStream con la imagen ya convertida en Bytes.
        Img.BackgroundImage = Nothing 'Si existe una imagen cargada en el PictureBox la borramos.
        Img.BackgroundImage = (Image.FromStream(ms)) 'Cargamos la imagen al PictureBox, Nota: Lo hacemos como .BackgroundImage pero igual lo podemos hacer como .Image.
        Img.BackgroundImageLayout = ImageLayout.Stretch 'Ajustamos la imagen al todo el PictureBox.
        AUXBMP = New Bitmap(Image.FromStream(ms))
        AUXBMP = AUXBMP.GetThumbnailImage(480, 480, Nothing, IntPtr.Zero) 'Redimencionamos pixeles deimagen (Opcional).

        ms.Dispose()
        ms.Close()

        lblConteo.Text = "Registro: " & iposicion + 1 & " de " & ds.Tables("Usuario").Rows.Count

    End Sub

    Public Sub UsuarioSiguiente(lblConteo As Label, UsuID As TextBox, Nomb As TextBox, Con As TextBox, Tel As TextBox, Email As TextBox, ByVal Rol As ComboBox, ByVal Departamento As ComboBox, ByVal Img As PictureBox)
        If (iposicion = (ds.Tables("Usuario").Rows.Count - 1)) Then
            MessageBox.Show("Ulimo registro")
        Else
            iposicion += 1
            ActualizarUsuario(ds, lblConteo, UsuID, Nomb, Con, Tel, Email, Rol, Departamento, Img)
        End If

    End Sub

    Public Sub UsuarioAnterior(lblConteo As Label, UsuID As TextBox, Nomb As TextBox, Con As TextBox, Tel As TextBox, Email As TextBox, ByVal Rol As ComboBox, ByVal Departamento As ComboBox, ByVal Img As PictureBox)
        If (iposicion = 0) Then
            MessageBox.Show("Primer registro")
        Else
            iposicion -= 1
            ActualizarUsuario(ds, lblConteo, UsuID, Nomb, Con, Tel, Email, Rol, Departamento, Img)
        End If

    End Sub

    ''Guarda las modificaciones de los Usuarios
    Public Function ModUsuario(ByVal IdUsuario As String, ByVal Nombre As String, ByVal Password As String, ByVal Email As String, ByVal Tel As String, ByVal Rol As Integer, ByVal Departamento As String, ByVal Img As PictureBox, ByVal Bandera As Boolean) As Boolean
        Dim Estado = True
        Try

            Departamento = ObtenerCampo(Departamento, "Departamento", "DNombre", "Departamento_Id")

            conectar()
            Dim ms As New System.IO.MemoryStream()

            If (Bandera = False) Then
                Img.BackgroundImage = Nothing
                Img.BackgroundImageLayout = ImageLayout.Stretch 'Ajustamos la imagen a todo el picturebox.
                Img.BackgroundImage = AUXBMP 'Cargamos la imagen al PictureBox.
            End If
            Img.BackgroundImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)


            Dim sSql As String = "UPDATE Usuario SET Usuario_Id = @Usuario_Id, UNombre = @Nombre, UEmail= @Email, UContraseña = @Contraseña, UTel = @Tel, URol = @Rol, UImage = @Logotipo, UDepartamento_Id = @Departamento where Usuario_Id = @Usuario_Id" 'Creamos el Query.

            Dim cmd As New SqlCommand(sSql, conexion) 'Creamos el comando.
                cmd.Parameters.Add("@Usuario_Id", System.Data.SqlDbType.VarChar)
                cmd.Parameters.Add("@Nombre", System.Data.SqlDbType.VarChar)
                cmd.Parameters.Add("@Email", System.Data.SqlDbType.VarChar)
                cmd.Parameters.Add("@Contraseña", System.Data.SqlDbType.VarChar)
                cmd.Parameters.Add("@Tel", System.Data.SqlDbType.VarChar)
                cmd.Parameters.Add("@Rol", System.Data.SqlDbType.Int)
                cmd.Parameters.Add("@Logotipo", System.Data.SqlDbType.Image)
                cmd.Parameters.Add("@Departamento", System.Data.SqlDbType.VarChar)

                cmd.Parameters("@Usuario_Id").Value = IdUsuario
                cmd.Parameters("@Nombre").Value = Nombre
                cmd.Parameters("@Email").Value = Email
                cmd.Parameters("@Contraseña").Value = Password
                cmd.Parameters("@Tel").Value = Tel
                cmd.Parameters("@Rol").Value = Rol
                cmd.Parameters("@Logotipo").Value = ms.GetBuffer()
                cmd.Parameters("@Departamento").Value = Departamento

                conexion.Open()
                cmd.ExecuteNonQuery() 'ejecutamos el query.
                conexion.Close()

                cmd = Nothing
                ms.Dispose()
                ms.Close()

            'cmd.Parameters.Add(New SqlParameter("@Logotipo", ms.GetBuffer())) 'Agregamos el MemoryStream a los parametros para poderlos guardar en la base de datos.

        Catch ex As SqlException
            Estado = False
        Finally
            Desconectar()
        End Try
        Return Estado

    End Function



    'Funciones para Departamento

    'Registro Departamento
    Public Function RegDep(ByVal IdDept As String, ByVal Nombre As String, ByVal Descp As String, ByVal Ext As Integer, ByVal Ubic As String) As Boolean
        Dim Estado = True
        Try
            conectar()

            comandosql = New SqlCommand("ST_ADDDepartamento", conexion)
            comandosql.CommandType = CommandType.StoredProcedure

            Dim parametro1 As SqlParameter = comandosql.Parameters.Add("@Departamento_Id", SqlDbType.VarChar, 50)
            parametro1.Value = IdDept

            Dim parametro2 As SqlParameter = comandosql.Parameters.Add("@Nombre", SqlDbType.VarChar, 50)
            parametro2.Value = Nombre

            Dim parametro3 As SqlParameter = comandosql.Parameters.Add("@Descp", SqlDbType.VarChar, 100)
            parametro3.Value = Descp

            Dim parametro5 As SqlParameter = comandosql.Parameters.Add("@Ext", SqlDbType.Int, 50)
            parametro5.Value = Ext

            Dim parametro6 As SqlParameter = comandosql.Parameters.Add("@Ubicacion", SqlDbType.VarChar, 50)
            parametro6.Value = Ubic

            conexion.Open()
            adaptador.InsertCommand = comandosql
            comandosql.ExecuteNonQuery()

        Catch ex As SqlException
            Estado = False
        Finally
            Desconectar()
        End Try
        Return Estado
    End Function

    'Funciones para eliminar de Tipo de Actividad
    Public Function DelTActividad(ByVal IdTAct As String, ByVal Nombre As String, ByVal Descp As String, ByVal Costo As Double) As Boolean
        Dim Estado = True
        Try
            conectar()

            comandosql = New SqlCommand("ST_DELTipoActividad", conexion)
            comandosql.CommandType = CommandType.StoredProcedure

            Dim parametro1 As SqlParameter = comandosql.Parameters.Add("@TipoActividad_Id", SqlDbType.VarChar, 50)
            parametro1.Value = IdTAct

            Dim parametro2 As SqlParameter = comandosql.Parameters.Add("@Nombre", SqlDbType.VarChar, 50)
            parametro2.Value = Nombre

            Dim parametro3 As SqlParameter = comandosql.Parameters.Add("@Descp", SqlDbType.VarChar, 100)
            parametro3.Value = Descp

            Dim parametro4 As SqlParameter = comandosql.Parameters.Add("@Costo", SqlDbType.Float, 50)
            parametro4.Value = Costo

            conexion.Open()
            adaptador.InsertCommand = comandosql
            comandosql.ExecuteNonQuery()

        Catch ex As SqlException
            Estado = False
        Finally
            Desconectar()
        End Try
        Return Estado
    End Function

    'Eliminar Departamento
    Public Function DeleteDep(ByVal IdDept As String, ByVal Nombre As String, ByVal Descp As String, ByVal Ext As Integer, ByVal Ubic As String) As Boolean
        Dim Estado = True
        Try
            conectar()

            comandosql = New SqlCommand("ST_DELDepartamento", conexion)
            comandosql.CommandType = CommandType.StoredProcedure

            Dim parametro1 As SqlParameter = comandosql.Parameters.Add("@Departamento_Id", SqlDbType.VarChar, 50)
            parametro1.Value = IdDept

            Dim parametro2 As SqlParameter = comandosql.Parameters.Add("@Nombre", SqlDbType.VarChar, 50)
            parametro2.Value = Nombre

            Dim parametro3 As SqlParameter = comandosql.Parameters.Add("@Descp", SqlDbType.VarChar, 100)
            parametro3.Value = Descp

            Dim parametro5 As SqlParameter = comandosql.Parameters.Add("@Ext", SqlDbType.Int, 50)
            parametro5.Value = Ext

            Dim parametro6 As SqlParameter = comandosql.Parameters.Add("@Ubicacion", SqlDbType.VarChar, 50)
            parametro6.Value = Ubic

            conexion.Open()
            adaptador.InsertCommand = comandosql
            comandosql.ExecuteNonQuery()

        Catch ex As SqlException
            Estado = False
        Finally
            Desconectar()
        End Try
        Return Estado
    End Function

    'Eliminar Departamento
    Public Function DeleteUsuario(ByVal IdUsu As String, ByVal Nombre As String) As Boolean
        Dim Estado = True
        Try
            conectar()

            comandosql = New SqlCommand("ST_DELUsuario", conexion)
            comandosql.CommandType = CommandType.StoredProcedure

            Dim parametro1 As SqlParameter = comandosql.Parameters.Add("@Usuario_Id", SqlDbType.VarChar, 50)
            parametro1.Value = IdUsu

            Dim parametro2 As SqlParameter = comandosql.Parameters.Add("@UNombre", SqlDbType.VarChar, 50)
            parametro2.Value = Nombre

            conexion.Open()
            adaptador.InsertCommand = comandosql
            comandosql.ExecuteNonQuery()

        Catch ex As SqlException
            Estado = False
        Finally
            Desconectar()
        End Try
        Return Estado
    End Function

    'Consulta de Departamento
    Public Function ConsDep(Data As DataGridView) As Boolean
        Dim Estado = True
        Try
            conectar()
            Dim table As New DataTable()
            Dim sSql As String = "SELECT * FROM Departamento"
            Dim adap As New SqlDataAdapter(sSql, conexion) 'Crear comando
            'Dim consulta1 As SqlCommandBuilder = New SqlCommandBuilder(adap)

            conexion.Open()
            adap.Fill(table)
            Data.DataSource = table
            conexion.Close()


        Catch ex As SqlException
            Estado = False
        Finally
            Desconectar()
        End Try
        Return Estado

    End Function

    'Modificación de Dep
    Public Function CargarDatDep(lblConteo As Label, DepID As TextBox, Nomb As TextBox, Descp As TextBox, Ext As TextBox, Ubic As TextBox) As Boolean
        Dim Estado = True
        Try
            conectar()
            ds = New DataSet
            Dim sSql As String = "SELECT * FROM Departamento"
            Dim adap As New SqlDataAdapter(sSql, conexion) 'Crear comando
            'Dim consulta1 As SqlCommandBuilder = New SqlCommandBuilder(adap)

            conexion.Open()

            adap.Fill(ds, "Departamento")

            conexion.Close()

            iposicion = 0
            ActualizarDepartamento(ds, lblConteo, DepID, Nomb, Descp, Ext, Ubic)

        Catch ex As SqlException
            Estado = False
        Finally
            Desconectar()
        End Try
        Return Estado

    End Function

    'Carga los departamentos actuales
    Private Sub ActualizarDepartamento(ds As DataSet, lblConteo As Label, DepID As TextBox, Nomb As TextBox, Descp As TextBox, Ext As TextBox, Ubic As TextBox)

        Dim DataFilas As DataRow
        DataFilas = ds.Tables("Departamento").Rows(iposicion)

        'Dim consulta1 As SqlCommandBuilder = New SqlCommandBuilder(adap)

        DepID.Text = DataFilas("Departamento_Id")
        Nomb.Text = DataFilas("DNombre")
        Descp.Text = DataFilas("DDescripcion")
        Ext.Text = DataFilas("DExt")
        Ubic.Text = DataFilas("DUbicacion")

        lblConteo.Text = "Regsitro: " & iposicion + 1 & " de " & ds.Tables("Departamento").Rows.Count

    End Sub

    Public Sub DepatamentoSiguiente(lblConteo As Label, DepID As TextBox, Nomb As TextBox, Descp As TextBox, Ext As TextBox, Ubic As TextBox)
        If (iposicion = (ds.Tables("Departamento").Rows.Count - 1)) Then
            MessageBox.Show("Ulimo registro")
        Else
            iposicion += 1
            ActualizarDepartamento(ds, lblConteo, DepID, Nomb, Descp, Ext, Ubic)
        End If

    End Sub

    Public Sub DepatamentoAnterior(lblConteo As Label, DepID As TextBox, Nomb As TextBox, Descp As TextBox, Ext As TextBox, Ubic As TextBox)
        If (iposicion = 0) Then
            MessageBox.Show("Primer registro")
        Else
            iposicion -= 1
            ActualizarDepartamento(ds, lblConteo, DepID, Nomb, Descp, Ext, Ubic)
        End If

    End Sub

    'Guarda las modificaciones del Departamento
    Public Function ModDep(ByVal IdDept As String, ByVal Nombre As String, ByVal Descp As String, ByVal Ext As Integer, ByVal Ubic As String) As Boolean
        Dim Estado = True
        Try
            conectar()

            comandosql = New SqlCommand("ST_MODDepartamento", conexion)
            comandosql.CommandType = CommandType.StoredProcedure

            Dim parametro1 As SqlParameter = comandosql.Parameters.Add("@Departamento_Id", SqlDbType.VarChar, 50)
            parametro1.Value = IdDept

            Dim parametro2 As SqlParameter = comandosql.Parameters.Add("@Nombre", SqlDbType.VarChar, 50)
            parametro2.Value = Nombre

            Dim parametro3 As SqlParameter = comandosql.Parameters.Add("@Descp", SqlDbType.VarChar, 100)
            parametro3.Value = Descp

            Dim parametro5 As SqlParameter = comandosql.Parameters.Add("@Ext", SqlDbType.Int, 50)
            parametro5.Value = Ext

            Dim parametro6 As SqlParameter = comandosql.Parameters.Add("@Ubicacion", SqlDbType.VarChar, 50)
            parametro6.Value = Ubic

            conexion.Open()
            adaptador.InsertCommand = comandosql
            comandosql.ExecuteNonQuery()

        Catch ex As SqlException
            Estado = False
        Finally
            Desconectar()
        End Try
        Return Estado
    End Function

    'Funciones para registo de Tipo de Actividad
    Public Function RegTActividad(ByVal IdTAct As String, ByVal Nombre As String, ByVal Descp As String, ByVal Costo As Double) As Boolean
        Dim Estado = True
        Try
            conectar()

            comandosql = New SqlCommand("ST_ADDTipoActividad", conexion)
            comandosql.CommandType = CommandType.StoredProcedure

            Dim parametro1 As SqlParameter = comandosql.Parameters.Add("@TipoActividad_Id", SqlDbType.VarChar, 50)
            parametro1.Value = IdTAct

            Dim parametro2 As SqlParameter = comandosql.Parameters.Add("@Nombre", SqlDbType.VarChar, 50)
            parametro2.Value = Nombre

            Dim parametro3 As SqlParameter = comandosql.Parameters.Add("@Descp", SqlDbType.VarChar, 100)
            parametro3.Value = Descp

            Dim parametro4 As SqlParameter = comandosql.Parameters.Add("@Costo", SqlDbType.Float, 50)
            parametro4.Value = Costo

            conexion.Open()
            adaptador.InsertCommand = comandosql
            comandosql.ExecuteNonQuery()

        Catch ex As SqlException
            Estado = False
        Finally
            Desconectar()
        End Try
        Return Estado
    End Function

    'Consulta de Tipo de Actividad
    Public Function ConsTActividad(Data As DataGridView) As Boolean
        Dim Estado = True
        Try
            conectar()
            Dim table As New DataTable()
            Dim sSql As String = "SELECT * FROM TipoActividad"
            Dim adap As New SqlDataAdapter(sSql, conexion) 'Crear comando
            'Dim consulta1 As SqlCommandBuilder = New SqlCommandBuilder(adap)

            conexion.Open()
            adap.Fill(table)
            Data.DataSource = table
            conexion.Close()


        Catch ex As SqlException
            Estado = False
        Finally
            Desconectar()
        End Try
        Return Estado

    End Function

    'Modificación de Tipo de Actividad
    Public Function CargarDatTActividad(lblConteo As Label, TActID As TextBox, Nomb As TextBox, Descp As TextBox, Costo As TextBox) As Boolean
        Dim Estado = True
        Try
            conectar()
            ds = New DataSet
            Dim sSql As String = "SELECT * FROM TipoActividad"
            Dim adap As New SqlDataAdapter(sSql, conexion) 'Crear comando
            'Dim consulta1 As SqlCommandBuilder = New SqlCommandBuilder(adap)

            conexion.Open()

            adap.Fill(ds, "TipoActividad")

            conexion.Close()

            iposicion = 0
            ActualizarTActividad(ds, lblConteo, TActID, Nomb, Descp, Costo)

        Catch ex As SqlException
            Estado = False
        Finally
            Desconectar()
        End Try
        Return Estado

    End Function

    'Carga los Tipos de Actividades actuales
    Private Sub ActualizarTActividad(ds As DataSet, lblConteo As Label, TActID As TextBox, Nomb As TextBox, Descp As TextBox, Costo As TextBox)

        Dim DataFilas As DataRow
        DataFilas = ds.Tables("TipoActividad").Rows(iposicion)

        'Dim consulta1 As SqlCommandBuilder = New SqlCommandBuilder(adap)

        TActID.Text = DataFilas("TipoActividad_Id")
        Nomb.Text = DataFilas("TNombre")
        Descp.Text = DataFilas("TDescripcion")
        Costo.Text = DataFilas("TCostoHLaborada")

        lblConteo.Text = "Registro: " & iposicion + 1 & " de " & ds.Tables("TipoActividad").Rows.Count

    End Sub

    Public Sub TActividadSiguiente(lblConteo As Label, TActID As TextBox, Nomb As TextBox, Descp As TextBox, Costo As TextBox)
        If (iposicion = (ds.Tables("TipoActividad").Rows.Count - 1)) Then
            MessageBox.Show("Ulimo registro")
        Else
            iposicion += 1
            ActualizarTActividad(ds, lblConteo, TActID, Nomb, Descp, Costo)
        End If

    End Sub

    Public Sub TActividadAnterior(lblConteo As Label, TActID As TextBox, Nomb As TextBox, Descp As TextBox, Costo As TextBox)
        If (iposicion = 0) Then
            MessageBox.Show("Primer registro")
        Else
            iposicion -= 1
            ActualizarTActividad(ds, lblConteo, TActID, Nomb, Descp, Costo)
        End If

    End Sub

    'Guarda las modificaciones del Tipo de Actividad
    Public Function ModTActividad(ByVal IdTAct As String, ByVal Nombre As String, ByVal Descp As String, ByVal Costo As Double) As Boolean
        Dim Estado = True
        Try
            conectar()

            comandosql = New SqlCommand("ST_MODTipoActividad", conexion)
            comandosql.CommandType = CommandType.StoredProcedure

            Dim parametro1 As SqlParameter = comandosql.Parameters.Add("@TipoActividad_Id", SqlDbType.VarChar, 50)
            parametro1.Value = IdTAct

            Dim parametro2 As SqlParameter = comandosql.Parameters.Add("@Nombre", SqlDbType.VarChar, 50)
            parametro2.Value = Nombre

            Dim parametro3 As SqlParameter = comandosql.Parameters.Add("@Descp", SqlDbType.VarChar, 100)
            parametro3.Value = Descp

            Dim parametro5 As SqlParameter = comandosql.Parameters.Add("@Costo", SqlDbType.Float, 50)
            parametro5.Value = Costo

            conexion.Open()
            adaptador.InsertCommand = comandosql
            comandosql.ExecuteNonQuery()

        Catch ex As SqlException
            Estado = False
        Finally
            Desconectar()
        End Try
        Return Estado
    End Function

    'Verificación de Usuarios
    Public Function VerificarCuenta(Usuario As String, Contraseña As String) As Boolean
        Dim Estado = True, Entrada = False
        Try
            conectar()
            Dim BuscarIdCons As String = "SELECT * FROM Usuario WHERE UNombre = '" & Usuario & "' AND UContraseña = '" & Contraseña & "'"
            Dim adap As New SqlDataAdapter(BuscarIdCons, conexion) 'Crear comando
            Auxds = New DataSet
            conexion.Open()
            adap.Fill(Auxds, "Usuario")
            Dim Conteo As Integer = Auxds.Tables("Usuario").Rows.Count - 1
            'Dim Username As String = Auxds.Tables("Usuario").Rows(0).Item("UNombre")
            'Dim Password As String = Auxds.Tables("Usuario").Rows(0).Item("UContraseña")

            'If (Username = Usuario And Password = Contraseña) Then
            '    Entrada = True
            'End If
            If (Conteo = 0) Then
                SetValorSession(Auxds.Tables("Usuario").Rows(0).Item("Usuario_Id"), Auxds.Tables("Usuario").Rows(0).Item("UNombre"),
                                Auxds.Tables("Usuario").Rows(0).Item("UEmail"), Auxds.Tables("Usuario").Rows(0).Item("UContraseña"),
                                Auxds.Tables("Usuario").Rows(0).Item("UTel"), Auxds.Tables("Usuario").Rows(0).Item("URol"), Auxds.Tables("Usuario").Rows(0).Item("UDepartamento_Id"))

                Entrada = True
            End If

        Catch ex As SqlException
            Estado = False
        Finally
            Desconectar()
        End Try
        Return Entrada

    End Function

    'Verificación de Sentencias SQL
    Public Function VerificarDatosDB(Sentencia As String, Tabla As String) As Boolean
        Dim Entrada = False
        Try
            conectar()
            Dim BuscarIdCons As String = Sentencia
            Dim adap As New SqlDataAdapter(BuscarIdCons, conexion) 'Crear comando
            Auxds = New DataSet
            conexion.Open()
            adap.Fill(Auxds, Tabla)
            Dim Conteo As Integer = Auxds.Tables(Tabla).Rows.Count - 1
            'Dim Username As String = Auxds.Tables("Usuario").Rows(0).Item("UNombre")
            'Dim Password As String = Auxds.Tables("Usuario").Rows(0).Item("UContraseña")

            'If (Username = Usuario And Password = Contraseña) Then
            '    Entrada = True
            'End If
            If (Conteo >= 0) Then
                Entrada = True
            End If

        Catch ex As SqlException
            MessageBox.Show("No se han encontrado registros previamente")
        Finally
            Desconectar()
        End Try
        Return Entrada

    End Function

    'Modificación de mi perfil
    Public Function MyProfile(UsuID As TextBox, Nomb As TextBox, Con As TextBox, Tel As TextBox, Email As TextBox, ByVal Rol As ComboBox, ByVal Departamento As ComboBox, ByVal Img As PictureBox) As Boolean
        Dim Estado = True
        Try
            conectar()
            ds = New DataSet
            Dim sSql As String = "SELECT * FROM Usuario Where Usuario_Id = '" & GetValUsernameID() & "'"
            Dim adap As New SqlDataAdapter(sSql, conexion) 'Crear comando
            'Dim consulta1 As SqlCommandBuilder = New SqlCommandBuilder(adap)

            conexion.Open()

            adap.Fill(ds, "Usuario")

            conexion.Close()

            iposicion = 0
            ActualizarMyProfile(ds, UsuID, Nomb, Con, Tel, Email, Rol, Departamento, Img)

        Catch ex As SqlException
            Estado = False
        Finally
            Desconectar()
        End Try
        Return Estado

    End Function

    'Carga los Usuarios actuales
    Private Sub ActualizarMyProfile(ds As DataSet, UsuID As TextBox, Nomb As TextBox, Con As TextBox, Tel As TextBox, Email As TextBox, ByVal Rol As ComboBox, ByVal Departamento As ComboBox, ByVal Img As PictureBox)
        Dim ms As New System.IO.MemoryStream() 'Creamos el MemoryStream y poder cargar la imagen.
        Dim DataFilas As DataRow
        DataFilas = ds.Tables("Usuario").Rows(iposicion)

        'Dim consulta1 As SqlCommandBuilder = New SqlCommandBuilder(adap)

        UsuID.Text = DataFilas("Usuario_Id")
        Nomb.Text = DataFilas("UNombre")
        Email.Text = DataFilas("UEmail")
        Con.Text = DataFilas("UContraseña")
        Tel.Text = DataFilas("UTel")
        Rol.SelectedIndex = DataFilas("URol")
        Dim AuxIdDepartamentoAct As String = DataFilas("UDepartamento_Id")
        Departamento.SelectedIndex = Departamento.FindStringExact(ObtenerNombUsuarioDepartamento(AuxIdDepartamentoAct))

        Dim imageBuffer() As Byte = CType(DataFilas("UImage"), Byte()) 'Conbertimos la imagen cargada en el datatable a Bytes.
        ms = New System.IO.MemoryStream(imageBuffer) 'Cargamos el MemoryStream con la imagen ya convertida en Bytes.
        Img.BackgroundImage = Nothing 'Si existe una imagen cargada en el PictureBox la borramos.
        Img.BackgroundImage = (Image.FromStream(ms)) 'Cargamos la imagen al PictureBox, Nota: Lo hacemos como .BackgroundImage pero igual lo podemos hacer como .Image.
        Img.BackgroundImageLayout = ImageLayout.Stretch 'Ajustamos la imagen al todo el PictureBox.
        AUXBMP = New Bitmap(Image.FromStream(ms))
        AUXBMP = AUXBMP.GetThumbnailImage(480, 480, Nothing, IntPtr.Zero) 'Redimencionamos pixeles deimagen (Opcional).

        ms.Dispose()
        ms.Close()

        'lblConteo.Text = "Registro: " & iposicion + 1 & " de " & ds.Tables("Usuario").Rows.Count

    End Sub



    'Consulta de Proyectos
    Public Function Consulta_Uno(Data As DataGridView, Pro_Id As String) As Boolean
        Dim Estado = True
        Try
            Pro_Id = ObtenerCampo(Pro_Id, "Proyecto", "PNombre", "Proyecto_Id")

            conectar()
            Dim table As New DataTable()
            Dim sSql As String = "Select  Actividad.AFechaInicio, TipoActividad.TNombre as Tipo, ANumHEstim As Horas_Estimadas, Proyecto.PRealHorasT as Horas_total_Proyecto from ((Actividad
                                    INNER JOIN Proyecto ON Actividad.AProyecto_Id = Proyecto.Proyecto_Id)
                                    INNER JOIN TipoActividad ON Actividad.ATipoActividad_Id = TipoActividad.TipoActividad_Id)
                                    Where Proyecto.Proyecto_Id = '" & Pro_Id & "'"
            Dim adap As New SqlDataAdapter(sSql, conexion) 'Crear comando
            'Dim consulta1 As SqlCommandBuilder = New SqlCommandBuilder(adap)

            conexion.Open()
            adap.Fill(table)
            Data.DataSource = table
            conexion.Close()

        Catch ex As SqlException
            Estado = False
        Finally
            Desconectar()
        End Try
        Return Estado

    End Function

    'Consulta de Proyectos
    Public Function Consulta_Dos(Data As DataGridView, Usu_Id As String, Project_Id As String) As Boolean
        Dim Estado = True
        Try
            Usu_Id = ObtenerCampo(Usu_Id, "Usuario", "UNombre", "Usuario_Id")
            Project_Id = ObtenerCampo(Project_Id, "Proyecto", "PNombre", "Proyecto_Id")

            conectar()
            Dim table As New DataTable()
            Dim sSql As String = "Select AFechaInicio As Fecha_Inicio, ADescripcion as Descripción, ANumHEstim as HorasPuestas from Actividad Where AUsuario_Id = '" & Usu_Id & "' and AProyecto_Id = '" & Project_Id & "'"
            Dim adap As New SqlDataAdapter(sSql, conexion) 'Crear comando
            'Dim consulta1 As SqlCommandBuilder = New SqlCommandBuilder(adap)

            conexion.Open()
            adap.Fill(table)
            Data.DataSource = table
            conexion.Close()

        Catch ex As SqlException
            Estado = False
        Finally
            Desconectar()
        End Try
        Return Estado

    End Function

    Public Function Consulta_Tres(Data As DataGridView, FechaInicial As Date, FechaFinal As Date) As Boolean
        Dim Estado = True
        Try
            '            'Usu_Id = ObtenerCampo(Usu_Id, "Usuario", "UNombre", "Usuario_Id")

            '            conectar()
            '            Dim table As New DataTable()
            '            Dim sSql As String = "Select Proyecto.PNombre, Usuario.UNombre as Encargado,Proyecto.PFechaInicio as Fecha_Inicio, Proyecto.PNumHEstim as Horas_Estimadas, Proyecto.PRealHorasT as Horas_Reales, Proyecto.PPresupuesto as Costo_Estimado, TipoActividad.TNombre as Nombre, (TipoActividad.TCostoHLaborada * Actividad.ANumHEstim) as Costo_Real from (((Proyecto Inner Join Usuario ON Proyecto.PEncargado = Usuario.Usuario_Id)"
            'Inner Join Actividad ON Proyecto.Proyecto_Id = Actividad.AProyecto_Id)
            'Inner join TipoActividad On Actividad.ATipoActividad_Id = TipoActividad.TipoActividad_Id)
            '                                    Where PFechaFinal <='" & FechaFinal.ToShortDateString() & "' and PFechaInicio >= '" & FechaInicial.ToShortDateString() & "'"
            '            Dim adap As New SqlDataAdapter(sSql, conexion) 'Crear comando
            '            'Dim consulta1 As SqlCommandBuilder = New SqlCommandBuilder(adap)

            '            conexion.Open()
            '            adap.Fill(table)
            '            Data.DataSource = table
            '            conexion.Close()

        Catch ex As SqlException
            Estado = False
        Finally
            Desconectar()
        End Try
        Return Estado

    End Function

    Public Function Consulta_Cuatro(Data As DataGridView) As Boolean
        Dim Estado = True
        Try
            'Usu_Id = ObtenerCampo(Usu_Id, "Usuario", "UNombre", "Usuario_Id")

            conectar()
            Dim table As New DataTable()
            Dim sSql As String = "Select Proyecto.PNombre, Usuario.UNombre, DATEDIFF(DAY,Proyecto.PFechaFinal,GETDATE()) as Dias_Retrasados from Proyecto
                                    Inner Join Usuario ON Proyecto.PEncargado = Usuario.Usuario_Id
									where PProyActivo = '1' Order By Dias_Retrasados DESC "
            Dim adap As New SqlDataAdapter(sSql, conexion) 'Crear comando
            'Dim consulta1 As SqlCommandBuilder = New SqlCommandBuilder(adap)

            conexion.Open()
            adap.Fill(table)
            Data.DataSource = table
            conexion.Close()

        Catch ex As SqlException
            Estado = False
        Finally
            Desconectar()
        End Try
        Return Estado

    End Function

End Class
