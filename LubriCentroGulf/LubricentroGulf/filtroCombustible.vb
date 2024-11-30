Imports System.Data.SqlClient
Imports System.Configuration
Public Class filtroCombustible
    Sub cargargrillaFiltroCombustible()
        Dim conexion As SqlConnection
        Dim comando As New SqlCommand

        conexion = New SqlConnection("Data Source =168.197.51.109; Initial Catalog = LUBRICENTRO; user id = LUBRICENTRO; password = LUBRICENTRO123")

        conexion.Open()
        comando.Connection = conexion
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = ("cargargrillaFiltroCombustible")

        Dim datadapter As New SqlDataAdapter(comando)
        Dim oDs As New DataSet
        datadapter.Fill(oDs)


        If oDs.Tables(0).Rows.Count > 0 Then
            grillaFiltroCombustible.AutoGenerateColumns = True
            grillaFiltroCombustible.DataSource = oDs.Tables(0)
            grillaFiltroCombustible.Refresh()
        End If

        oDs = Nothing
        conexion.Close()
    End Sub
    Private Sub filtroCombustible_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargargrillaFiltroCombustible()
    End Sub

    Private Sub btncargar_Click(sender As Object, e As EventArgs) Handles btncargar.Click
        If txtFiltroCombustible.Text <> Nothing Then
            Dim conexion As SqlConnection
            Dim comando As New SqlCommand

            conexion = New SqlConnection("Data Source =168.197.51.109; Initial Catalog = LUBRICENTRO; user id = LUBRICENTRO; password = LUBRICENTRO123")


            conexion.Open()
            comando.Connection = conexion
            comando.CommandType = CommandType.StoredProcedure
            comando.CommandText = ("botoncargerFiltroCombustible")

            With comando.Parameters
                .AddWithValue("@nombre", txtFiltroCombustible.Text)
            End With
            comando.ExecuteScalar()
            cargargrillaFiltroCombustible()
            conexion.Close()
            txtFiltroCombustible.Clear()
            txtarray.Clear()
        Else
            MsgBox("Por favor rellene los campos para poder  cargar...")
        End If
    End Sub

    Private Sub btnmodificar_Click(sender As Object, e As EventArgs) Handles btnmodificar.Click
        If txtFiltroCombustible.Text <> Nothing Then
            Dim conexion As SqlConnection
            Dim comando As New SqlCommand

            conexion = New SqlConnection("Data Source =168.197.51.109; Initial Catalog = LUBRICENTRO; user id = LUBRICENTRO; password = LUBRICENTRO123")


            conexion.Open()
            comando.Connection = conexion
            comando.CommandType = CommandType.StoredProcedure
            comando.CommandText = ("botonmodificarFiltroCombustible")

            With comando.Parameters
                .AddWithValue("@nombre", txtFiltroCombustible.Text)
                .AddWithValue("@array", txtarray.Text)
            End With
            comando.ExecuteScalar()
            cargargrillaFiltroCombustible()
            conexion.Close()
            txtFiltroCombustible.Clear()
            txtarray.Clear()
        Else
            MsgBox("Por favor rellene los campos para poder  modificar...")
        End If
    End Sub

    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        Dim conexion As SqlConnection
        Dim comando As New SqlCommand

        conexion = New SqlConnection("Data Source =168.197.51.109; Initial Catalog = LUBRICENTRO; user id = LUBRICENTRO; password = LUBRICENTRO123")


        conexion.Open()
        comando.Connection = conexion
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = ("botoneliminarFiltroCombustible")

        With comando.Parameters
            .AddWithValue("@nombre", txtFiltroCombustible.Text)
            .AddWithValue("@array", txtarray.Text)
        End With
        comando.ExecuteScalar()
        cargargrillaFiltroCombustible()
        conexion.Close()
        txtFiltroCombustible.Clear()
        txtarray.Clear()
    End Sub

    Private Sub grillaFiltroCombustible_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grillaFiltroCombustible.CellContentClick
        If txtFiltroCombustible.Text = Nothing Then
            txtFiltroCombustible.Text = grillaFiltroCombustible.SelectedCells.Item(0).Value
            txtarray.Text = grillaFiltroCombustible.SelectedCells.Item(0).Value
        Else
            txtFiltroCombustible.Clear()
            txtarray.Clear()
        End If
    End Sub

    Sub buscarFiltroCombustible()
        Dim shape As New DataTable
        Dim data As New SqlDataAdapter
        Dim sss As String = "Data Source =168.197.51.109; Initial Catalog = LUBRICENTRO; user id = LUBRICENTRO; password = LUBRICENTRO123"

        data = New SqlDataAdapter("buscarFiltroCombustible", sss)
        shape = New DataTable
        data.SelectCommand.CommandType = CommandType.StoredProcedure
        data.SelectCommand.CommandText = ("buscarFiltroCombustible")
        data.SelectCommand.Parameters.Add("@nombre", SqlDbType.VarChar).Value = barra.Text
        data.Fill(shape)
        grillaFiltroCombustible.DataSource = shape
    End Sub

    Private Sub barra_TextChanged(sender As Object, e As EventArgs) Handles barra.TextChanged
        buscarFiltroCombustible()
    End Sub
End Class