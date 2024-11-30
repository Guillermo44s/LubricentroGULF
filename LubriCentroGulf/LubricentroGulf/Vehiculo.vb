Imports System.Data.SqlClient
Imports System.Configuration
Public Class Vehiculo
    Sub cargargrillaVehiculo()
        Dim conexion As SqlConnection
        Dim comando As New SqlCommand

        conexion = New SqlConnection("Data Source =168.197.51.109; Initial Catalog = LUBRICENTRO; user id = LUBRICENTRO; password = LUBRICENTRO123")

        conexion.Open()
        comando.Connection = conexion
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = ("cargargrillaVehiculo")

        Dim datadapter As New SqlDataAdapter(comando)
        Dim oDs As New DataSet
        datadapter.Fill(oDs)


        If oDs.Tables(0).Rows.Count > 0 Then
            grillaVehiculo.AutoGenerateColumns = True
            grillaVehiculo.DataSource = oDs.Tables(0)
            grillaVehiculo.Refresh()
        End If

        oDs = Nothing
        conexion.Close()
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtModeloV.Text <> Nothing Then
            Dim conexion As SqlConnection
            Dim comando As New SqlCommand

            conexion = New SqlConnection("Data Source =168.197.51.109; Initial Catalog = LUBRICENTRO; user id = LUBRICENTRO; password = LUBRICENTRO123")


            conexion.Open()
            comando.Connection = conexion
            comando.CommandType = CommandType.StoredProcedure
            comando.CommandText = ("botoncargarVehiulo")

            With comando.Parameters
                .AddWithValue("@modelo", txtModeloV.Text)
            End With
            comando.ExecuteScalar()
            cargargrillaVehiculo()
            conexion.Close()
            txtModeloV.Clear()
            txtarray.Clear()
        Else
            MsgBox("No se puede cargar si no rellena los campos.")
        End If

    End Sub

    Private Sub Vehiculo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargargrillaVehiculo()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If txtModeloV.Text <> Nothing Then
            Dim conexion As SqlConnection
            Dim comando As New SqlCommand

            conexion = New SqlConnection("Data Source =168.197.51.109; Initial Catalog = LUBRICENTRO; user id = LUBRICENTRO; password = LUBRICENTRO123")


            conexion.Open()
            comando.Connection = conexion
            comando.CommandType = CommandType.StoredProcedure
            comando.CommandText = ("botonmodificarVehiculo")

            With comando.Parameters
                .AddWithValue("@modelo", txtModeloV.Text)
                .AddWithValue("@array", txtarray.Text)
            End With

            comando.ExecuteScalar()
            cargargrillaVehiculo()
            conexion.Close()
            txtModeloV.Clear()
            txtarray.Clear()
        Else
            MsgBox("No se puede modificar si no rellean los campos")
        End If
    End Sub

    Private Sub grillaVehiculo_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grillaVehiculo.CellContentClick
        If txtModeloV.Text = Nothing Then

            txtModeloV.Text = grillaVehiculo.SelectedCells.Item(0).Value
            txtarray.Text = grillaVehiculo.SelectedCells.Item(0).Value
        Else
            txtarray.Clear()
            txtModeloV.Clear()
        End If

    End Sub

    Private Sub txtModeloV_TextChanged(sender As Object, e As EventArgs) Handles txtModeloV.TextChanged

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim conexion As SqlConnection
        Dim comando As New SqlCommand

        conexion = New SqlConnection("Data Source =168.197.51.109; Initial Catalog = LUBRICENTRO; user id = LUBRICENTRO; password = LUBRICENTRO123")


        conexion.Open()
        comando.Connection = conexion
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = ("botoneliminarVehiculo")

        With comando.Parameters
            .AddWithValue("@modelo", txtModeloV.Text)
        End With

        comando.ExecuteScalar()
        cargargrillaVehiculo()
        conexion.Close()
        txtModeloV.Clear()
        txtarray.Clear()

    End Sub


    Sub buscarVehiculo()
        Dim shape As New DataTable
        Dim data As New SqlDataAdapter
        Dim sss As String = "Data Source =168.197.51.109; Initial Catalog = LUBRICENTRO; user id = LUBRICENTRO; password = LUBRICENTRO123"

        data = New SqlDataAdapter("buscarVehiculo", sss)
        shape = New DataTable
        data.SelectCommand.CommandType = CommandType.StoredProcedure
        data.SelectCommand.CommandText = ("buscarVehiculo")
        data.SelectCommand.Parameters.Add("@modelo", SqlDbType.VarChar).Value = barra.Text
        data.Fill(shape)
        grillaVehiculo.DataSource = shape


    End Sub
    Private Sub barra_TextChanged(sender As Object, e As EventArgs) Handles barra.TextChanged
        buscarVehiculo()
    End Sub
End Class