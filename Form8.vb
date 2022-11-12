Public Class Form8
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        On Error GoTo sds
        If InStr(Form1.listActiveObject.Items(0).ToString, "richs") Then
            Form1.activeObject.Text = Replace(Form1.activeObject.Text, TextBox1.Text, TextBox2.Text)
        ElseIf Form1.listActiveObject.Items.Count = 0 Then
            Exit Sub
        Else
            Form1.activeText.Text = Replace(Form1.activeText.Text, TextBox1.Text, TextBox2.Text)
        End If
        Exit Sub
sds:
        MsgBox("Error to find", MsgBoxStyle.Exclamation, "Replace")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        On Error GoTo sds
        If InStr(Form1.listActiveObject.Items(0).ToString, "richs") Then
            Form1.activeObject.SelectedText = Replace(Form1.activeObject.SelectedText, TextBox1.Text, TextBox2.Text)
        ElseIf Form1.listActiveObject.Items.Count = 0 Then
            Exit Sub
        Else
            Form1.activeText.SelectedText = Replace(Form1.activeText.SelectedText, TextBox1.Text, TextBox2.Text)
        End If
        Exit Sub
sds:
        MsgBox("Error to find", MsgBoxStyle.Exclamation, "Replace")
    End Sub
End Class