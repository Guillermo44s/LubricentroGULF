Imports System.Data.SqlClient
Imports System.Configuration
Public Class FiltroAceite
#Region "cargar grilla y el combo"
    Sub cargargrillaFiltroAceite()
        Dim conexion As SqlConnection
        Dim comando As New SqlCommand

        conexion = New SqlConnection("Data Source =168.197.51.109; Initial Catalog = LUBRICENTRO; user id = LUBRICENTRO; password = LUBRICENTRO123")

        conexion.Open()
        comando.Connection = conexion
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = ("cargargrilla")

        Dim datadapter As New SqlDataAdapter(comando)
        Dim oDs As New DataSet
        datadapter.Fill(oDs)


        If oDs.Tables(0).Rows.Count > 0 Then
            grillaFiltroAceite.AutoGenerateColumns = True
            grillaFiltroAceite.DataSource = oDs.Tables(0)
            grillaFiltroAceite.Refresh()
        End If

        oDs = Nothing
        conexion.Close()
    End Sub

#End Region
    Private Sub FiltroAceite_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargargrillaFiltroAceite()
    End Sub

    Private Sub cargarFiltroAceite_Click(sender As Object, e As EventArgs) Handles cargarFiltroAceite.Click
        If txtModelo.Text <> Nothing Then
            Dim conexion As SqlConnection
            Dim comando As New SqlCommand

            conexion = New SqlConnection("Data Source =168.197.51.109; Initial Catalog = LUBRICENTRO; user id = LUBRICENTRO; password = LUBRICENTRO123")


            conexion.Open()
            comando.Connection = conexion
            comando.CommandType = CommandType.StoredProcedure
            comando.CommandText = ("botoncargarFiltroAceite")

            With comando.Parameters
                .AddWithValue("@modelo", txtModelo.Text)
            End With
            comando.ExecuteScalar()
            cargargrillaFiltroAceite()

            conexion.Close()
            txtModelo.Clear()
            array.Clear()
        Else
            MsgBox("No se puede agregar un filtro sin colocar el nombre del modelo...")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If txtModelo.Text <> Nothing Then
            Dim conexion As SqlConnection
            Dim comando As New SqlCommand

            conexion = New SqlConnection("Data Source =168.197.51.109; Initial Catalog = LUBRICENTRO; user id = LUBRICENTRO; password = LUBRICENTRO123")


            conexion.Open()
            comando.Connection = conexion
            comando.CommandType = CommandType.StoredProcedure
            comando.CommandText = ("botonmodificarFiltroAceite")

            With comando.Parameters
                .AddWithValue("@modelo", txtModelo.Text)
                .AddWithValue("@array", array.Text)
            End With

            comando.ExecuteScalar()
            cargargrillaFiltroAceite()
            conexion.Close()
            txtModelo.Clear()
            array.Clear()
        Else
            MsgBox("No se puede modificar si no rellana los campos")
        End If
    End Sub

    Private Sub grillaFiltroAceite_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles grillaFiltroAceite.CellContentDoubleClick
        If txtModelo.Text = Nothing Then
            txtModelo.Text = grillaFiltroAceite.SelectedCells.Item(0).Value
            array.Text = grillaFiltroAceite.SelectedCells.Item(0).Value

        Else
            array.Clear()
            txtModelo.Clear()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim conexion As SqlConnection
        Dim comando As New SqlCommand

        conexion = New SqlConnection("Data Source =168.197.51.109; Initial Catalog = LUBRICENTRO; user id = LUBRICENTRO; password = LUBRICENTRO123")


        conexion.Open()
        comando.Connection = conexion
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = ("botoneliminarFiltroAceite")

        With comando.Parameters
            .AddWithValue("@modelo", txtModelo.Text)
        End With
        cargargrillaFiltroAceite()
        comando.ExecuteNonQuery()

        conexion.Close()
        cargargrillaFiltroAceite()
        txtModelo.Clear()
        array.Clear()
    End Sub

    Sub buscarFiltroAceite()
        Dim shape As New DataTable
        Dim data As New SqlDataAdapter
        Dim sss As String = "Data Source =168.197.51.109; Initial Catalog = LUBRICENTRO; user id = LUBRICENTRO; password = LUBRICENTRO123"

        data = New SqlDataAdapter("buscarFiltroAceite", sss)
        shape = New DataTable
        data.SelectCommand.CommandType = CommandType.StoredProcedure
        data.SelectCommand.CommandText = ("buscarFiltroAceite")
        data.SelectCommand.Parameters.Add("@modelo", SqlDbType.VarChar).Value = barraFiltroAceite.Text
        data.Fill(shape)
        grillaFiltroAceite.DataSource = shape


    End Sub
    Private Sub barraFiltroAceite_TextChanged(sender As Object, e As EventArgs) Handles barraFiltroAceite.TextChanged
        buscarFiltroAceite()
    End Sub
End Class