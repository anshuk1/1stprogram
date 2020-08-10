Public Class Form1
    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles PasswordField.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Dim a As Integer = 0
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Not UsernameField.text = "" Then
            a += 1
        End If
        If Not PasswordField.text = "" Then
            a += 1

        End If
        If a = 2 Then
            My.Settings.Username = UsernameField.text
            My.Settings.Password = PasswordField.text
            My.Settings.Save()
        End If
        MsgBox("register successful")
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub UsernameField_TextChanged(sender As Object, e As EventArgs) Handles UsernameField.TextChanged

    End Sub
End Class
