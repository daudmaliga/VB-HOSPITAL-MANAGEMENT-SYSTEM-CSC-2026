Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim loginForm As New LoginForm()
        loginForm.Show()
        Me.Hide()
    End Sub
End Class
