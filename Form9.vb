Public Class Form9

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Select Case ComboBox1.SelectedItem
            Case "New"
                RichTextBox1.Text = "In  tab Home,click new to Build new file text"
            Case "Open"
                RichTextBox1.Text = "In  tab Home,click Open to open file text"
            Case "Save as"
                RichTextBox1.Text = "In  tab Home,click Save/save as to Save new file text"
            Case "Save"
                RichTextBox1.Text = "In  tab Home,click Save/save to Save file text in this file"
            Case "Undo"
                RichTextBox1.Text = "In  tab Edit,click Undo as to undo text"
            Case "Undo"
                RichTextBox1.Text = "In  tab Edit,click Undo as to undo text"
            Case "Paste"
                RichTextBox1.Text = "In  tab Edit,click Paste as to Paste text on text"
            Case "Copy"
                RichTextBox1.Text = "In  tab Edit,click Copy as to Copy text on text"
            Case "Cut"
                RichTextBox1.Text = "In  tab Edit,click Cut as to Cut text on text"
            Case "  Clipboard options"
                RichTextBox1.Text = "In  tab Edit,click Clipboard options as to Setting clipboard"
            Case "  Clipboard options"
                RichTextBox1.Text = "In  tab Edit,click Clipboard options as to Setting clipboard"
            Case "Uppercase"
                RichTextBox1.Text = "In  tab Edit,click Uppercase as to convert text to Uppercase"
            Case "Lowercase"
                RichTextBox1.Text = "In  tab Edit,click Lowercase as to convert text to Lowercase"
            Case "Date and Time"
                RichTextBox1.Text = "In  tab Edit,click Date and Time as to insert date and time"
            Case "Command"
                RichTextBox1.Text = "for vr 2"
        End Select
    End Sub
End Class