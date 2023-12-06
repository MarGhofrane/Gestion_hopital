Public Class FormLogin


    Private Sub txt_Username_TextChanged(sender As Object, e As EventArgs) Handles txt_Username.TextChanged
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If PictureBox3.Left < Me.Width Then
            PictureBox3.Left = PictureBox3.Left + 10
        Else
            PictureBox3.Left = 0
        End If
    End Sub
    Private Sub init()
        txt_Username.Clear()
        txt_password.Clear()
    End Sub
    Private Sub btn_entrer_Click(sender As Object, e As EventArgs) Handles btn_entrer.Click
        btn_entrer.BackColor = Color.Aqua
        Timer1.Enabled = False
        Dim Username As String
        Dim Password As String
        Username = txt_Username.Text
        Password = txt_password.Text
        If (Username = "admin") And (Password = "1234") Then
            Me.Hide()
            Frm_Menu.Show()
        Else
            init()
        End If

    End Sub

    Private Sub Show_CheckedChanged(sender As Object, e As EventArgs) Handles Checkbox.CheckedChanged
        If Checkbox.Checked = True Then
            txt_password.UseSystemPasswordChar = False
        Else
            txt_password.UseSystemPasswordChar = True

        End If
    End Sub
End Class