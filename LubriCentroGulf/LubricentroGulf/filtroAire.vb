Imports System.Data.SqlClient
Imports System.Configuration
Imports Menu.vb
Public Class filtroAire
    Sub cargargrillaFiltroAire()
        Dim conexion As SqlConnection
        Dim comando As New SqlCommand

        conexion = New SqlConnection("Data Source =168.197.51.109; Initial Catalog = LUBRICENTRO; user id = LUBRICENTRO; password = LUBRICENTRO123")

        conexion.Open()
        comando.Connection = conexion
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = ("cargargrillaFiltroAire")

        Dim datadapter As New SqlDataAdapter(comando)
        Dim oDs As New DataSet
        datadapter.Fill(oDs)


        If oDs.Tables(0).Rows.Count > 0 Then
            grillaFiltroAire.AutoGenerateColumns = True
            grillaFiltroAire.DataSource = oDs.Tables(0)
            grillaFiltroAire.Refresh()
        End If

        oDs = Nothing
        conexion.Close()
    End Sub

    Private Sub filtroAire_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargargrillaFiltroAire()
    End Sub

    Private Sub btncargar_Click(sender As Object, e As EventArgs) Handles btncargar.Click
        If txtFiltroAire.Text = Nothing Then
            MsgBox("Porfavor rellene los campos para poder agregar.")
        Else
            Dim conexion As SqlConnection
            Dim comando As New SqlCommand

            conexion = New SqlConnection("Data Source =168.197.51.109; Initial Catalog = LUBRICENTRO; user id = LUBRICENTRO; password = LUBRICENTRO123")


            conexion.Open()
            comando.Connection = conexion
            comando.CommandType = CommandType.StoredProcedure
            comando.CommandText = ("botoncargarFiltroAire")

            With comando.Parameters
                .AddWithValue("@nombre", txtFiltroAire.Text)

            End With
            comando.ExecuteScalar()
            cargargrillaFiltroAire()
            conexion.Close()
            txtFiltroAire.Clear()
            txtarray.Clear()
        End If
    End Sub

    Private Sub btnmodificar_Click(sender As Object, e As EventArgs) Handles btnmodificar.Click
        If txtFiltroAire.Text = Nothing Then
            MsgBox("Porfavor rellene los campos para poder modificar.")
        Else
            Dim conexion As SqlConnection
            Dim comando As New SqlCommand

            conexion = New SqlConnection("Data Source =168.197.51.109; Initial Catalog = LUBRICENTRO; user id = LUBRICENTRO; password = LUBRICENTRO123")


            conexion.Open()
            comando.Connection = conexion
            comando.CommandType = CommandType.StoredProcedure
            comando.CommandText = ("botonmodificarFiltroAire")

            With comando.Parameters
                .AddWithValue("@nombre", txtFiltroAire.Text)
                .AddWithValue("@array", txtarray.Text)
            End With
            comando.ExecuteScalar()
            cargargrillaFiltroAire()
            conexion.Close()
            txtFiltroAire.Clear()
            txtarray.Clear()
        End If
    End Sub

    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        Dim conexion As SqlConnection
        Dim comando As New SqlCommand

        conexion = New SqlConnection("Data Source =168.197.51.109; Initial Catalog = LUBRICENTRO; user id = LUBRICENTRO; password = LUBRICENTRO123")


        conexion.Open()
        comando.Connection = conexion
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = ("botoneliminarFiltroAire")

        With comando.Parameters

            .AddWithValue("@array", txtFiltroAire.Text)
        End With
        comando.ExecuteScalar()
        cargargrillaFiltroAire()
        conexion.Close()
        txtFiltroAire.Clear()
        txtarray.Clear()
    End Sub

    Private Sub grillaFiltroAire_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grillaFiltroAire.CellContentClick
        If txtFiltroAire.Text = Nothing Then
            txtFiltroAire.Text = grillaFiltroAire.SelectedCells.Item(0).Value
            txtarray.Text = grillaFiltroAire.SelectedCells.Item(0).Value
        Else
            txtFiltroAire.Clear()
            txtarray.Clear()
        End If
    End Sub

    Sub buscarFiltroAire()
        Dim shape As New DataTable
        Dim data As New SqlDataAdapter
        Dim sss As String = "Data Source =168.197.51.109; Initial Catalog = LUBRICENTRO; user id = LUBRICENTRO; password = LUBRICENTRO123"

        data = New SqlDataAdapter("buscarFiltroAire", sss)
        shape = New DataTable
        data.SelectCommand.CommandType = CommandType.StoredProcedure
        data.SelectCommand.CommandText = ("buscarFiltroAire")
        data.SelectCommand.Parameters.Add("@nombre", SqlDbType.VarChar).Value = barra.Text
        data.Fill(shape)
        grillaFiltroAire.DataSource = shape


    End Sub

    Private Sub barra_TextChanged(sender As Object, e As EventArgs) Handles barra.TextChanged
        buscarFiltroAire()
    End Sub
End Class