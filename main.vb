Public Class main
    Private Sub main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUser.Text = LogIn.strUsername
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        LogIn.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub
End Class