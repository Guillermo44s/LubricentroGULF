Imports System.Data.SqlClient
Imports System.Configuration
Public Class patente
    Sub cargargrillaPatente()
        Dim conexion As SqlConnection
        Dim comando As New SqlCommand

        conexion = New SqlConnection("Data Source =168.197.51.109; Initial Catalog = LUBRICENTRO; user id = LUBRICENTRO; password = LUBRICENTRO123")

        conexion.Open()
        comando.Connection = conexion
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = ("cargargrillaPatente")

        Dim datadapter As New SqlDataAdapter(comando)
        Dim oDs As New DataSet
        datadapter.Fill(oDs)


        If oDs.Tables(0).Rows.Count > 0 Then
            grillaPatente.AutoGenerateColumns = True
            grillaPatente.DataSource = oDs.Tables(0)
            grillaPatente.Refresh()
        End If

        oDs = Nothing
        conexion.Close()
    End Sub

    Private Sub patente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargargrillaPatente()
    End Sub

    Private Sub btncargar_Click(sender As Object, e As EventArgs) Handles btncargar.Click
        If txtPatente.Text = Nothing Then
            MsgBox("Por favor rellene los campos para poder agregar la patente", vbInformation)
        Else
            Try
                Dim conexion As SqlConnection
                Dim comando As New SqlCommand

                conexion = New SqlConnection("Data Source =168.197.51.109; Initial Catalog = LUBRICENTRO; user id = LUBRICENTRO; password = LUBRICENTRO123")


                conexion.Open()
                comando.Connection = conexion
                comando.CommandType = CommandType.StoredProcedure
                comando.CommandText = ("botoncargarPatente")

                With comando.Parameters
                    .AddWithValue("@patente", txtPatente.Text)
                End With
                comando.ExecuteScalar()
                cargargrillaPatente()
                conexion.Close()
                txtPatente.Clear()
                txtarray.Clear()
            Catch ex As Exception
                MsgBox("No se pueden agregar patentes que ya existen", ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnmodificar_Click(sender As Object, e As EventArgs) Handles btnmodificar.Click
        If txtPatente.Text = Nothing Then
            MsgBox("Por favor rellene los campos para poder modificar", vbInformation)
        Else
            Try
                Dim conexion As SqlConnection
                Dim comando As New SqlCommand

                conexion = New SqlConnection("Data Source =168.197.51.109; Initial Catalog = LUBRICENTRO; user id = LUBRICENTRO; password = LUBRICENTRO123")


                conexion.Open()
                comando.Connection = conexion
                comando.CommandType = CommandType.StoredProcedure
                comando.CommandText = ("botonmodificarPatente")

                With comando.Parameters
                    .AddWithValue("@patente", txtPatente.Text)
                    .AddWithValue("@array", txtarray.Text)
                End With

                comando.ExecuteScalar()
                cargargrillaPatente()
                conexion.Close()
                txtPatente.Clear()
                txtarray.Clear()
            Catch ex As Exception
                MsgBox("El nombre de la patente ya existe", ex.Message)
            End Try
        End If
    End Sub

    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        Dim conexion As SqlConnection
        Dim comando As New SqlCommand

        conexion = New SqlConnection("Data Source =168.197.51.109; Initial Catalog = LUBRICENTRO; user id = LUBRICENTRO; password = LUBRICENTRO123")


        conexion.Open()
        comando.Connection = conexion
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = ("botoneliminarPatente")

        With comando.Parameters
            .AddWithValue("@array", txtarray.Text)
        End With

        comando.ExecuteScalar()
        cargargrillaPatente()
        conexion.Close()
        txtPatente.Clear()
        txtarray.Clear()
    End Sub

    Private Sub grillaPatente_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grillaPatente.CellContentClick
        If txtPatente.Text = Nothing Then

            txtPatente.Text = grillaPatente.SelectedCells.Item(0).Value
            txtarray.Text = grillaPatente.SelectedCells.Item(0).Value
        Else
            txtarray.Clear()
            txtPatente.Clear()
        End If
    End Sub
    Sub buscarPatente()
        Dim shape As New DataTable
        Dim data As New SqlDataAdapter
        Dim sss As String = "Data Source =168.197.51.109; Initial Catalog = LUBRICENTRO; user id = LUBRICENTRO; password = LUBRICENTRO123"

        data = New SqlDataAdapter("buscarPatente", sss)
        shape = New DataTable
        data.SelectCommand.CommandType = CommandType.StoredProcedure
        data.SelectCommand.CommandText = ("buscarPatente")
        data.SelectCommand.Parameters.Add("@patente", SqlDbType.VarChar).Value = barra.Text
        data.Fill(shape)
        grillaPatente.DataSource = shape


    End Sub
    Private Sub barra_TextChanged(sender As Object, e As EventArgs) Handles barra.TextChanged
        buscarPatente()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click

    End Sub
End Class