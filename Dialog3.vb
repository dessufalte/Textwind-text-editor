Imports System.Windows.Forms
Public Class Dialog3
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Dim strange As String
        Dim TabText As RichTextBox
        On Error GoTo Errorr
        If ListBox1.SelectedIndex <> -1 Then
            strange = ListBox1.SelectedItem.ToString
            For Each indexing As TabPage In Form1.TabControl1.TabPages
                If strange = indexing.Text Then
                    For Each TabText In indexing.Controls
                        TabText.Paste()
                        Form1.TabControl1.SelectedTab = indexing
                    Next
                End If
            Next
            If Form1.UnusualClipboard = "" Then
                Exit Sub
                Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
                Me.Close()
            Else
                Clipboard.SetText(Form1.UnusualClipboard)
            End If
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Close()
        Else
            MsgBox("Select tab to join ", MsgBoxStyle.Information, "Join")
        End If
        Exit Sub
errorr: MsgBox("Can't join to text", MsgBoxStyle.Exclamation, "Join")
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        If Form1.UnusualClipboard = "" Then
            Exit Sub
            Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.Close()
        Else
            Clipboard.SetText(Form1.UnusualClipboard)    
        End If
    End Sub

    Private Sub Dialog3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListBox1.Items.Clear()
        With Form1
            For i = 0 To .TabControl1.TabPages.Count - 1
                ListBox1.Items.Add(.TabControl1.TabPages(i).Text)
            Next
        End With
        RichTextBox1.Text = Clipboard.GetText
    End Sub
End Class
