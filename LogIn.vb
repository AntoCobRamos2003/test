Public Class LogIn
    Public strUsername As String
    Private Sub btnLogIn_Click(sender As Object, e As EventArgs) Handles btnLogIn.Click
        If String.IsNullOrEmpty(txtUsername.Text.Trim) Then
            ErrorProvider1.SetError(txtUsername, "Username is required")
        Else
            ErrorProvider1.SetError(txtUsername, String.Empty)
        End If

        If String.IsNullOrEmpty(txtPassword.Text.Trim) Then
            ErrorProvider2.SetError(txtPassword, "Password is required")
        Else
            ErrorProvider2.SetError(txtPassword, String.Empty)
        End If
        If txtUsername.Text <> "" And txtPassword.Text <> "" Then
            strUsername = txtUsername.Text
            Me.Hide()
            main.Show()
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Application.Exit()
    End Sub

End Class