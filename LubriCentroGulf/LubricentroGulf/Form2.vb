Imports System.Data.SqlClient
Imports System.Configuration
Public Class Form2
#Region "LIMPIAR"
    Private Sub limpiar()
        txt_caja.Clear()
        cbo_patente.Text = ""
        txt_fecha.Clear()
        cbo_filtroaceite.Text = ""
        cbo_filtroaire.Text = ""
        cbo_filtrocombustible.Text = ""
        txt_idcambio.Clear()
        txt_kmini.Clear()
        txt_proximocambio.Clear()
        txt_total.Clear()
        cbo_vehiculo.Text = ""

        cbo_patente.Text = ""
        cbo_filtroaceite.Text = ""
        cbo_filtroaire.Text = ""
        cbo_filtrocombustible.Text = ""
        cbo_lubricante.Text = ""
        cbo_vehiculo.Text = ""

        CargarGrilla()
    End Sub
    Private Sub CargarGrilla()
        Dim conexion As SqlConnection
        Dim comando As New SqlCommand

        conexion = New SqlConnection("Data Source =168.197.51.109; Initial Catalog = LUBRICENTRO; user id = LUBRICENTRO; password = LUBRICENTRO123")

        conexion.Open()
        comando.Connection = conexion
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = ("MostrarServiciosTodos")

        Dim datadapter As New SqlDataAdapter(comando)
        Dim oDs As New DataSet
        datadapter.Fill(oDs)


        If oDs.Tables(0).Rows.Count > 0 Then
            dgb_grilla.AutoGenerateColumns = True
            dgb_grilla.DataSource = oDs.Tables(0)
            dgb_grilla.Refresh()
        End If

        oDs = Nothing
        conexion.Close()
    End Sub

    Private Sub CargarComboPatente()
        Dim conexion As SqlConnection
        Dim comando As New SqlCommand

        conexion = New SqlConnection("Data Source =168.197.51.109; Initial Catalog = LUBRICENTRO; user id = LUBRICENTRO; password = LUBRICENTRO123")

        conexion.Open()
        comando.Connection = conexion
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = ("CargarComboPatente")

        Dim datadapter As New SqlDataAdapter(comando)
        Dim oDs As New DataSet
        datadapter.Fill(oDs)


        If oDs.Tables(0).Rows.Count > 0 Then
            cbo_patente.DataSource = oDs.Tables(0)
            cbo_patente.ValueMember = oDs.Tables(0).Columns(0).ToString
            cbo_patente.DisplayMember = oDs.Tables(0).Columns(0).ToString

        End If

        oDs = Nothing
        conexion.Close()
    End Sub

    Private Sub CargarComboVehiculo()
        Dim conexion As SqlConnection
        Dim comando As New SqlCommand

        conexion = New SqlConnection("Data Source =168.197.51.109; Initial Catalog = LUBRICENTRO; user id = LUBRICENTRO; password = LUBRICENTRO123")

        conexion.Open()
        comando.Connection = conexion
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = ("CargarComboVehiculo")

        Dim datadapter As New SqlDataAdapter(comando)
        Dim oDs As New DataSet
        datadapter.Fill(oDs)


        If oDs.Tables(0).Rows.Count > 0 Then
            cbo_vehiculo.DataSource = oDs.Tables(0)
            cbo_vehiculo.ValueMember = oDs.Tables(0).Columns(0).ToString
            cbo_vehiculo.DisplayMember = oDs.Tables(0).Columns(0).ToString

        End If

        oDs = Nothing
        conexion.Close()
    End Sub
    Private Sub CargarComboLubricante()
        Dim conexion As SqlConnection
        Dim comando As New SqlCommand

        conexion = New SqlConnection("Data Source =168.197.51.109; Initial Catalog = LUBRICENTRO; user id = LUBRICENTRO; password = LUBRICENTRO123")

        conexion.Open()
        comando.Connection = conexion
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = ("CargarComboLubricante")

        Dim datadapter As New SqlDataAdapter(comando)
        Dim oDs As New DataSet
        datadapter.Fill(oDs)


        If oDs.Tables(0).Rows.Count > 0 Then
            cbo_lubricante.DataSource = oDs.Tables(0)
            cbo_lubricante.ValueMember = oDs.Tables(0).Columns(0).ToString
            cbo_lubricante.DisplayMember = oDs.Tables(0).Columns(0).ToString

        End If

        oDs = Nothing
        conexion.Close()
    End Sub

    Private Sub CargarComboFiltroCombustible()
        Dim conexion As SqlConnection
        Dim comando As New SqlCommand

        conexion = New SqlConnection("Data Source =168.197.51.109; Initial Catalog = LUBRICENTRO; user id = LUBRICENTRO; password = LUBRICENTRO123")

        conexion.Open()
        comando.Connection = conexion
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = ("CargarComboFiltroCombustible")

        Dim datadapter As New SqlDataAdapter(comando)
        Dim oDs As New DataSet
        datadapter.Fill(oDs)


        If oDs.Tables(0).Rows.Count > 0 Then
            cbo_filtrocombustible.DataSource = oDs.Tables(0)
            cbo_filtrocombustible.ValueMember = oDs.Tables(0).Columns(0).ToString
            cbo_filtrocombustible.DisplayMember = oDs.Tables(0).Columns(0).ToString

        End If

        oDs = Nothing
        conexion.Close()
    End Sub

    Private Sub CargarComboFiltroAceite()
        Dim conexion As SqlConnection
        Dim comando As New SqlCommand

        conexion = New SqlConnection("Data Source =168.197.51.109; Initial Catalog = LUBRICENTRO; user id = LUBRICENTRO; password = LUBRICENTRO123")

        conexion.Open()
        comando.Connection = conexion
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = ("CargarComboFiltroAceite")

        Dim datadapter As New SqlDataAdapter(comando)
        Dim oDs As New DataSet
        datadapter.Fill(oDs)


        If oDs.Tables(0).Rows.Count > 0 Then
            cbo_filtroaceite.DataSource = oDs.Tables(0)
            cbo_filtroaceite.ValueMember = oDs.Tables(0).Columns(0).ToString
            cbo_filtroaceite.DisplayMember = oDs.Tables(0).Columns(0).ToString

        End If

        oDs = Nothing
        conexion.Close()
    End Sub

    Private Sub CargarComboFiltroAire()
        Dim conexion As SqlConnection
        Dim comando As New SqlCommand

        conexion = New SqlConnection("Data Source =168.197.51.109; Initial Catalog = LUBRICENTRO; user id = LUBRICENTRO; password = LUBRICENTRO123")

        conexion.Open()
        comando.Connection = conexion
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = ("CargarComboFiltroAire")

        Dim datadapter As New SqlDataAdapter(comando)
        Dim oDs As New DataSet
        datadapter.Fill(oDs)


        If oDs.Tables(0).Rows.Count > 0 Then
            cbo_filtroaire.DataSource = oDs.Tables(0)
            cbo_filtroaire.ValueMember = oDs.Tables(0).Columns(0).ToString
            cbo_filtroaire.DisplayMember = oDs.Tables(0).Columns(0).ToString

        End If

        oDs = Nothing
        conexion.Close()
    End Sub

#End Region

    'LOAD '
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarGrilla()
        CargarComboPatente()
        CargarComboVehiculo()
        CargarComboLubricante()
        CargarComboFiltroCombustible()
        CargarComboFiltroAceite()
        CargarComboFiltroAire()
        limpiar()

    End Sub

    Private Sub btn_cargar_Click(sender As Object, e As EventArgs) Handles btn_cargar.Click

        If cbo_patente.Text <> "" And cbo_filtroaceite.Text <> "" And cbo_filtroaire.Text <> "" And cbo_filtrocombustible.Text <> "" And cbo_lubricante.Text <> "" And cbo_vehiculo.Text <> "" And txt_fecha.Text <> "" And txt_kmini.Text <> "" And txt_proximocambio.Text <> "" And txt_caja.Text <> "" Then
            Dim conexion As SqlConnection
            Dim comando As New SqlCommand

            conexion = New SqlConnection("Data Source =168.197.51.109; Initial Catalog = LUBRICENTRO; user id = LUBRICENTRO; password = LUBRICENTRO123")


            conexion.Open()
            comando.Connection = conexion
            comando.CommandType = CommandType.StoredProcedure
            comando.CommandText = ("CargarServicio")

            With comando.Parameters

                .AddWithValue("@Patente", cbo_patente.Text)
                .AddWithValue("@Fecha", txt_fecha.Text)
                .AddWithValue("@Vehiculo", cbo_vehiculo.Text)
                .AddWithValue("@FiltroCombustible", cbo_filtrocombustible.Text)
                .AddWithValue("@Lubricante", cbo_lubricante.Text)
                .AddWithValue("@FiltroAceite", cbo_filtroaceite.Text)
                .AddWithValue("@FiltroAire", cbo_filtroaire.Text)
                .AddWithValue("@KMIniciales", txt_kmini.Text)
                .AddWithValue("@ProximoCambio", txt_proximocambio.Text)
                .AddWithValue("@RevisionCaja", txt_caja.Text)
                .AddWithValue("@Total", txt_total.Text)


            End With

            comando.ExecuteScalar()

            MsgBox("El Cambio De Aceite  a " & cbo_patente.Text & "' Se Registro CORECTAMENTE", vbInformation, "GULF")

            limpiar()

            conexion.Close()

        Else
            MsgBox("Complete todos los campos para cargar porfavor", vbInformation, "GULF")
        End If

    End Sub

    Private Sub btn_modificar_Click(sender As Object, e As EventArgs) Handles btn_modificar.Click
        If txt_idcambio.Text <> "" And cbo_patente.Text <> "" And cbo_filtroaceite.Text <> "" And cbo_filtroaire.Text <> "" And cbo_filtrocombustible.Text <> "" And cbo_lubricante.Text <> "" And cbo_vehiculo.Text <> "" And txt_fecha.Text <> "" And txt_kmini.Text <> "" And txt_proximocambio.Text <> "" And txt_caja.Text <> "" Then
            Dim conexion As SqlConnection
            Dim comando As New SqlCommand

            conexion = New SqlConnection("Data Source =168.197.51.109; Initial Catalog = LUBRICENTRO; user id = LUBRICENTRO; password = LUBRICENTRO123")


            conexion.Open()
            comando.Connection = conexion
            comando.CommandType = CommandType.StoredProcedure
            comando.CommandText = ("ModificarServicios")

            With comando.Parameters
                .AddWithValue("@ID_Servicio", txt_idcambio.Text)
                .AddWithValue("@Patente", cbo_patente.Text)
                .AddWithValue("@Fecha", txt_fecha.Text)
                .AddWithValue("@Vehiculo", cbo_vehiculo.Text)
                .AddWithValue("@Lubricante", cbo_lubricante.Text)
                .AddWithValue("@FiltroCombustible", cbo_filtrocombustible.Text)
                .AddWithValue("@FiltroAceite", cbo_filtroaceite.Text)
                .AddWithValue("@FiltroAire", cbo_filtroaire.Text)
                .AddWithValue("@KMIniciales", txt_kmini.Text)
                .AddWithValue("@ProximoCambio", txt_proximocambio.Text)
                .AddWithValue("@RevisionCaja", txt_caja.Text)
                .AddWithValue("@Total", txt_total.Text)



            End With

            comando.ExecuteScalar()

            MsgBox("El Cambio De Aceite a: ' " & cbo_patente.Text & "' Se Modifico CORECTAMENTE", vbInformation, "GULF")

            limpiar()

            conexion.Close()
        Else
            MsgBox("Complete los Campos Porfavor", vbInformation, "MODIFICAR")
        End If
    End Sub

    Private Sub btn_reset_Click(sender As Object, e As EventArgs) Handles btn_reset.Click
        Dim conexion As SqlConnection
        Dim comando As New SqlCommand

        conexion = New SqlConnection("Data Source =168.197.51.109; Initial Catalog = LUBRICENTRO; user id = LUBRICENTRO; password = LUBRICENTRO123")

        conexion.Open()
        comando.Connection = conexion
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = ("MostrarServiciosTodos")

        Dim datadapter As New SqlDataAdapter(comando)
        Dim oDs As New DataSet
        datadapter.Fill(oDs)


        If oDs.Tables(0).Rows.Count > 0 Then
            dgb_grilla.AutoGenerateColumns = True
            dgb_grilla.DataSource = oDs.Tables(0)
            dgb_grilla.Refresh()
        End If

        oDs = Nothing
        conexion.Close()
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        If txt_idcambio.Text <> "" Then
            Dim conexion As SqlConnection
            Dim comando As New SqlCommand

            conexion = New SqlConnection("Data Source =168.197.51.109; Initial Catalog = LUBRICENTRO; user id = LUBRICENTRO; password = LUBRICENTRO123")

            conexion.Open()
            comando.Connection = conexion
            comando.CommandType = CommandType.StoredProcedure
            comando.CommandText = ("EliminarServicio")

            With comando.Parameters

                .AddWithValue("@ID_Servicio", txt_idcambio.Text)



            End With
            comando.ExecuteNonQuery()

            MsgBox("El Servicio a ' " & cbo_patente.Text & "' se ha eliminado correctamente", vbInformation, "GULF")

            limpiar()
            conexion.Close()

        Else
            MsgBox("Ingrese el ID Porfavor", vbInformation, "ELIMINAR")
        End If

    End Sub

    Private Sub btn_consultar_Click(sender As Object, e As EventArgs) Handles btn_consultar.Click
        If txt_idcambio.Text <> "" Then


            Dim conexion As SqlConnection
            Dim comando As New SqlCommand

            conexion = New SqlConnection("Data Source =168.197.51.109; Initial Catalog = LUBRICENTRO; user id = LUBRICENTRO; password = LUBRICENTRO123")

            conexion.Open()
            comando.Connection = conexion
            comando.CommandType = CommandType.StoredProcedure
            comando.CommandText = ("ConsultarServicioxID")

            With comando.Parameters

                .AddWithValue("@ID_Servicio", txt_idcambio.Text)

            End With

            Dim datadapter As New SqlDataAdapter(comando)
            Dim oDs As New DataSet
            datadapter.Fill(oDs)


            If oDs.Tables(0).Rows.Count > 0 Then
                dgb_grilla.AutoGenerateColumns = True
                dgb_grilla.DataSource = oDs.Tables(0)
                dgb_grilla.Refresh()
            End If

            Dim datoleido As SqlDataReader = comando.ExecuteReader

            If datoleido.Read = True Then
                cbo_patente.Text = datoleido("Cliente").ToString
                txt_fecha.Text = datoleido("Fecha").ToString
                cbo_vehiculo.Text = datoleido("Vehiculo").ToString
                cbo_lubricante.Text = datoleido("Lubricante").ToString

                cbo_filtrocombustible.Text = datoleido("FiltroCombustible").ToString
                cbo_filtroaceite.Text = datoleido("FiltroAceite").ToString
                cbo_filtroaire.Text = datoleido("FiltroAire").ToString
                txt_kmini.Text = datoleido("KMIniciales").ToString
                txt_proximocambio.Text = datoleido("ProximoCambio").ToString
                txt_caja.Text = datoleido("RevisionCaja").ToString
                txt_total.Text = datoleido("Total").ToString

            Else
                MsgBox("No se encontraron resultados", MsgBoxStyle.Exclamation, "GULF")
                limpiar()
            End If

            datoleido.Close()
            conexion.Close()
        Else
            MsgBox("Ingrese el ID para consultar", vbInformation, "CONSULTAR ID")
        End If
    End Sub

    Private Sub btn_consultarxnom_Click(sender As Object, e As EventArgs) Handles btn_consultarxnom.Click
        If cbo_patente.Text <> "" Then
            Dim conexion As SqlConnection
            Dim comando As New SqlCommand

            conexion = New SqlConnection("Data Source =168.197.51.109; Initial Catalog = LUBRICENTRO; user id = LUBRICENTRO; password = LUBRICENTRO123")

            conexion.Open()
            comando.Connection = conexion
            comando.CommandType = CommandType.StoredProcedure
            comando.CommandText = ("ConsultarServicioxCliente")

            With comando.Parameters

                .AddWithValue("@Patente", cbo_patente.Text)


            End With

            Dim datadapter As New SqlDataAdapter(comando)
            Dim oDs As New DataSet
            datadapter.Fill(oDs)


            If oDs.Tables(0).Rows.Count > 0 Then
                dgb_grilla.AutoGenerateColumns = True
                dgb_grilla.DataSource = oDs.Tables(0)
                dgb_grilla.Refresh()
            End If

            Dim datoleido As SqlDataReader = comando.ExecuteReader
            If datoleido.Read = True Then
                txt_idcambio.Text = datoleido("ID_Servicio").ToString
                cbo_patente.Text = datoleido("Cliente").ToString
                txt_fecha.Text = datoleido("Fecha").ToString
                cbo_vehiculo.Text = datoleido("Vehiculo").ToString
                cbo_lubricante.Text = datoleido("Lubricante").ToString

                cbo_filtrocombustible.Text = datoleido("FiltroCombustible").ToString
                cbo_filtroaceite.Text = datoleido("FiltroAceite").ToString
                cbo_filtroaire.Text = datoleido("FiltroAire").ToString
                txt_kmini.Text = datoleido("KMIniciales").ToString
                txt_proximocambio.Text = datoleido("ProximoCambio").ToString
                txt_caja.Text = datoleido("RevisionCaja").ToString
                txt_total.Text = datoleido("Total").ToString

            Else
                MsgBox("No se encontraron resultados", MsgBoxStyle.Exclamation, "GULF")
                limpiar()
            End If


            datoleido.Close()
            oDs = Nothing
            conexion.Close()
        Else
            MsgBox("ingrese el cliente a consultar", vbInformation, "CONSULTAR CLIENTE")
        End If
    End Sub


#Region "FiltroPiloto"
    Sub filtroPiloto()
        Dim conexion As SqlConnection
        Dim comando As New SqlCommand

        conexion = New SqlConnection("Data Source =168.197.51.109; Initial Catalog = LUBRICENTRO; user id = LUBRICENTRO; password = LUBRICENTRO123")

        conexion.Open()
        comando.Connection = conexion
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = ("filtroPiloto")

        With comando.Parameters


            .AddWithValue("@buscar", txt_barra.Text)



        End With

        Dim datadapter As New SqlDataAdapter(comando)
        Dim oDs As New DataSet
        datadapter.Fill(oDs)


        If oDs.Tables(0).Rows.Count > 0 Then
            dgb_grilla.AutoGenerateColumns = True
            dgb_grilla.DataSource = oDs.Tables(0)
            dgb_grilla.Refresh()
        End If

        Dim datoleido As SqlDataReader = comando.ExecuteReader
        If datoleido.Read = True Then
            txt_idcambio.Text = datoleido("ID_Servicio").ToString
            cbo_patente.Text = datoleido("Cliente").ToString
            txt_fecha.Text = datoleido("Fecha").ToString
            cbo_vehiculo.Text = datoleido("Vehiculo").ToString
            cbo_lubricante.Text = datoleido("Lubricante").ToString

            cbo_filtrocombustible.Text = datoleido("FiltroCombustible").ToString
            cbo_filtroaceite.Text = datoleido("FiltroAceite").ToString
            cbo_filtroaire.Text = datoleido("FiltroAire").ToString
            txt_kmini.Text = datoleido("KMIniciales").ToString
            txt_proximocambio.Text = datoleido("ProximoCambio").ToString
            txt_caja.Text = datoleido("RevisionCaja").ToString
            txt_total.Text = datoleido("Total").ToString

        Else
            MsgBox("No se encontraron resultados", MsgBoxStyle.Exclamation, "GULF")
            limpiar()
        End If


        datoleido.Close()
        oDs = Nothing
        conexion.Close()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txt_barra.TextChanged
        filtroPiloto()
    End Sub

    Private Sub dgb_grilla_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgb_grilla.CellContentClick

    End Sub

    Private Sub dgb_grilla_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgb_grilla.CellContentDoubleClick

    End Sub
#End Region


End Class