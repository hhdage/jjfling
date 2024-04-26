Public Class Aboutme
    Private Sub authorValueLabel_Click(sender As Object, e As EventArgs) Handles authorValueLabel.Click

    End Sub

    Private Sub Aboutme_DoubleClick(sender As Object, e As EventArgs) Handles MyBase.DoubleClick
        BackColor = Color.Red

    End Sub

    Private Sub Aboutme_MouseEnter(sender As Object, e As EventArgs) Handles MyBase.MouseEnter
        BackColor = Color.Blue

    End Sub

    Private Sub Aboutme_MouseLeave(sender As Object, e As EventArgs) Handles MyBase.MouseLeave
        BackColor = Color.Green

    End Sub
End Class