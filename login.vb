Public Class login
    Public Shared users As Users
    Public Shared perpustakaan As Perpus

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        users = New Users()
        perpustakaan = New Perpus()
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        Dim plainUsername As String = TextBoxUsername.Text
        Dim plainPassword As String = TextBoxPass.Text

        Dim data_user As List(Of String) = users.CheckAuthDatabase(plainUsername, plainPassword)
        ' Dim AuthStatus As Boolean = users.CheckAuth(plainUsername, plainPassword)

        If data_user.Count > 0 Then
            users.GSusername = data_user(1)
            Perpus.Show()
            Me.Hide()
        Else
            MessageBox.Show("salah password")
        End If
        'If AuthStatus Then
        'Perpus.Show()
        'End If

        'Try
        'If AuthStatus = False Then
        'Throw New System.Exception()
        'End If
        'Catch ex As Exception
        'MessageBox.Show("username atau password salah")
        'End Try
    End Sub

    Private Sub BtnRegister_Click(sender As Object, e As EventArgs) Handles BtnRegister.Click
        register.Show()
    End Sub
End Class