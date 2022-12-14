Public Class register
    Private Sub Btnregis_Click(sender As Object, e As EventArgs) Handles Btnregis.Click
        'Dim username As String = TextBoxUsername.Text
        'Dim password As String = TextBoxPass.Text
        'login.users.add_user(username, password)

        'MessageBox.Show("akun di tambahkan")
        'login.Show()

        If TextBoxUsername.Text.Length > 0 And TextBoxPass.Text.Length > 0 Then
            login.users.AddUsersDatabase(TextBoxUsername.Text, TextBoxPass.Text)
        Else
            MessageBox.Show("lengkapi Data")
        End If
    End Sub
End Class