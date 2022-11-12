Public Class Form5

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
     
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form8.ShowDialog()
        Form8.TextBox1.Text = Me.TextBox1.Text
        Me.Hide()
        Form8.TextBox1.Text = Me.TextBox1.Text
    End Sub

End Class