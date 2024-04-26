Public Class MainWinForm

    Private Sub redBtn_Click(sender As Object, e As EventArgs) Handles redBtn.Click
        RichTextBox1.BackColor = Color.Red
    End Sub

    Private Sub blueBtn_Click(sender As Object, e As EventArgs) Handles blueBtn.Click
        RichTextBox1.BackColor = Color.Blue
    End Sub

    Private Sub greenBtn_Click(sender As Object, e As EventArgs) Handles greenBtn.Click
        RichTextBox1.BackColor = Color.Green
    End Sub

    Private Sub exitSubMenuItem_Click(sender As Object, e As EventArgs) Handles exitSubMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub aboutSubMenuItem_Click(sender As Object, e As EventArgs) Handles aboutSubMenuItem.Click
        Aboutme.ShowDialog()
    End Sub
End Class
