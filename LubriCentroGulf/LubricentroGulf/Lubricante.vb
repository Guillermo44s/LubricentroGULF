Imports System.Data.SqlClient
Imports System.Configuration
Public Class Lubricante
    Sub cargargrillaLubricante()
        Dim conexion As SqlConnection
        Dim comando As New SqlCommand

        conexion = New SqlConnection("Data Source =168.197.51.109; Initial Catalog = LUBRICENTRO; user id = LUBRICENTRO; password = LUBRICENTRO123")

        conexion.Open()
        comando.Connection = conexion
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = ("cargargrillaLubricante")

        Dim datadapter As New SqlDataAdapter(comando)
        Dim oDs As New DataSet
        datadapter.Fill(oDs)


        If oDs.Tables(0).Rows.Count > 0 Then
            grillaLubricante.AutoGenerateColumns = True
            grillaLubricante.DataSource = oDs.Tables(0)
            grillaLubricante.Refresh()
        End If

        oDs = Nothing
        conexion.Close()
    End Sub

    Private Sub Lubricante_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargargrillaLubricante()
    End Sub

    Private Sub btncargarL_Click(sender As Object, e As EventArgs) Handles btncargarL.Click
        If txtNombreL.Text <> Nothing Then
            Dim conexion As SqlConnection
            Dim comando As New SqlCommand

            conexion = New SqlConnection("Data Source =168.197.51.109; Initial Catalog = LUBRICENTRO; user id = LUBRICENTRO; password = LUBRICENTRO123")


            conexion.Open()
            comando.Connection = conexion
            comando.CommandType = CommandType.StoredProcedure
            comando.CommandText = ("botoncargarLubricante")

            With comando.Parameters
                .AddWithValue("@nombre", txtNombreL.Text)
            End With
            comando.ExecuteScalar()
            cargargrillaLubricante()
            conexion.Close()
            txtNombreL.Clear()
            txtarray.Clear()
        Else

            MsgBox("Por favor rellene los campos para poder cargar")
        End If
    End Sub

    Private Sub btnmodificarL_Click(sender As Object, e As EventArgs) Handles btnmodificarL.Click
        If txtNombreL.Text <> Nothing Then
            Dim conexion As SqlConnection
            Dim comando As New SqlCommand

            conexion = New SqlConnection("Data Source =168.197.51.109; Initial Catalog = LUBRICENTRO; user id = LUBRICENTRO; password = LUBRICENTRO123")


            conexion.Open()
            comando.Connection = conexion
            comando.CommandType = CommandType.StoredProcedure
            comando.CommandText = ("botonmodificarLubricante")

            With comando.Parameters
                .AddWithValue("@nombre", txtNombreL.Text)
                .AddWithValue("@array", txtarray.Text)
            End With

            comando.ExecuteScalar()
            cargargrillaLubricante()
            conexion.Close()
            txtNombreL.Clear()
            txtarray.Clear()
        Else

            MsgBox("Pr favor rellene los campos para poder modificar")
        End If
    End Sub

    Private Sub btneliminarL_Click(sender As Object, e As EventArgs) Handles btneliminarL.Click
        Dim conexion As SqlConnection
        Dim comando As New SqlCommand

        conexion = New SqlConnection("Data Source =168.197.51.109; Initial Catalog = LUBRICENTRO; user id = LUBRICENTRO; password = LUBRICENTRO123")


        conexion.Open()
        comando.Connection = conexion
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = ("botoneliminarLubricante")

        With comando.Parameters
            '.AddWithValue("@nombre", txtNombreL.Text)
            .AddWithValue("@array", txtarray.Text)
        End With

        comando.ExecuteScalar()
        cargargrillaLubricante()
        conexion.Close()
        txtNombreL.Clear()
        txtarray.Clear()
    End Sub

    Private Sub grillaLubricante_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grillaLubricante.CellContentClick
        If txtNombreL.Text = Nothing Then
            txtNombreL.Text = grillaLubricante.SelectedCells.Item(0).Value
            txtarray.Text = grillaLubricante.SelectedCells.Item(0).Value
        Else
            txtarray.Clear()
            txtNombreL.Clear()

        End If
    End Sub

    Sub buscarLubricante()
        Dim shape As New DataTable
        Dim data As New SqlDataAdapter
        Dim sss As String = "Data Source =168.197.51.109; Initial Catalog = LUBRICENTRO; user id = LUBRICENTRO; password = LUBRICENTRO123"

        data = New SqlDataAdapter("buscarLubricante", sss)
        shape = New DataTable
        data.SelectCommand.CommandType = CommandType.StoredProcedure
        data.SelectCommand.CommandText = ("buscarLubricante")
        data.SelectCommand.Parameters.Add("@nombre", SqlDbType.VarChar).Value = barra.Text
        data.Fill(shape)
        grillaLubricante.DataSource = shape


    End Sub

    Private Sub barra_TextChanged(sender As Object, e As EventArgs) Handles barra.TextChanged
        buscarLubricante()
    End Sub
End Class