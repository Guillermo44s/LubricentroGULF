Public Class Form1
    Dim adm As String = "Moris"
    Dim contraseñaadm As String = "Sintetico"
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Limpiar()
        txt_usuario.Clear()
        txt_contraseña.Clear()
    End Sub
    Private Sub btn_aceptar_Click(sender As Object, e As EventArgs) Handles btn_aceptar.Click
        If txt_usuario.Text <> "" And txt_contraseña.Text <> "" Then
            If txt_usuario.Text = adm And txt_contraseña.Text = contraseñaadm Then
                Form2.Show()
                MsgBox("Bienvenido!" & "  " & txt_usuario.Text, vbInformation, "GULF")
                Limpiar()

            Else
                MsgBox("Usuario y/o Contraseña Incorrectos", vbInformation, "GULF")
            End If

        Else
            MsgBox("Complete los campos porfavor", vbInformation, "GULF")
        End If
    End Sub


End Class
