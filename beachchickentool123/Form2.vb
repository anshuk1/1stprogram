Public Class Form2
    Dim a As Integer = 0

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If UsernameTextField.Text = My.Settings.Username Then
            a += 1
        End If
        If PasswordTextField.Text = My.Settings.Password Then
            a += 1

        End If
        If a = 2 Then
            MsgBox("login successful", MsgBoxStyle.Information)
        Else
            MsgBox("please check your credintials again", MsgBoxStyle.Exclamation)

        End If
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Form1.Show()
        Me.Hide()
    End Sub
End Class