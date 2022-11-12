Public Class Form2
    


    Private Sub Form1_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Dim Application_Path As String = Application.ExecutablePath()
        Clipboard.Clear()
        Timer1.Start()
        RichTextBox2.Text = Clipboard.GetText
    End Sub

   

    Private Sub TextBox1_TextChanged(sender As Object, e As System.EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text = "" Then
            Exit Sub
        End If
        ListBox1.Items.Add(My.Computer.Clipboard.GetText)

    End Sub


   

    
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        On Error GoTo sds
        RichTextBox2.Copy()
        Form1.Show()
        Me.Hide()
        Form1.Button1.Visible = True
        Form1.Button2.Visible = True
        Form1.Button3.Visible = True
        Form1.Timer1.Interval = TextBox4.Text
        Exit Sub
sds:    MsgBox("Error to auto paste")
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Clipboard.Clear()
        TextBox1.Text = ""
        Timer1.Start()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click

        If (ListBox1.SelectedItem <> "") Then
            TextBox2.Text = ListBox1.SelectedItem
            ListBox1.Items.Remove(ListBox1.SelectedItem)
            Clipboard.SetText(TextBox2.Text)
        Else
            MessageBox.Show("You must select an item")
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        ListBox1.Items.Clear()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Using SW As New IO.StreamWriter(Application.StartupPath & "\" & "ListBox1.txt", True)
            For Each itm As String In Me.ListBox1.Items
                SW.WriteLine(itm)
            Next
        End Using
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Clipboard.ContainsText Then
            Label1.Visible = False
            Label2.Visible = True
            TextBox1.Text = My.Computer.Clipboard.GetText

        Else
            Label1.Visible = True
            Label2.Visible = False
        End If
    End Sub

    Private Sub listActiveObject_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listActiveObject.SelectedIndexChanged

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click

    End Sub
End Class