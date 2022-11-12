Imports System.IO
Public Class Form1
    Dim flagstep As Boolean
    Private namestring As String = String.Empty
    Private lastfocusedtext As TextBox
    Dim NewText1 As New TextBox
    Dim NewText2 As New TextBox
    Dim NewText3 As New TextBox
    Dim NewText4 As New TextBox
    Dim NewText5 As New TextBox
    Dim NewText6 As New TextBox
    Dim NewText7 As New TextBox
    Dim NewText8 As New TextBox
    Dim NewText9 As New TextBox
    Dim NewText10 As New TextBox
    Dim tabpagetext1 As New TabPage
    Dim tabpagetext2 As New TabPage
    Dim tabpagetext3 As New TabPage
    Dim tabpagetext4 As New TabPage
    Dim tabpagetext5 As New TabPage
    Dim tabpagetext6 As New TabPage
    Dim tabpagetext7 As New TabPage
    Dim tabpagetext8 As New TabPage
    Dim tabpagetext9 As New TabPage
    Dim tabpagetext10 As New TabPage
    Dim nlist As New ListBox
    Dim lenlist As New ListBox
    Sub flagel()

    End Sub
    Sub delete()
        'clear document
        Me.ActiveControl.Text = ""
        'clear name document
        namestring = String.Empty
        flagstep = False
    End Sub
    Sub open()
        Dim enterfile As StreamReader
        Contents2.Text = Me.ActiveControl.Text

        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            namestring = OpenFileDialog1.FileName
            Try

                    enterfile = File.OpenText(namestring)
                Me.ActiveControl.Text = enterfile.ReadToEnd
                    flagstep = False
            Catch ex As Exception
                MessageBox.Show("Error to enter file!")
            End Try
        End If
    End Sub
    Sub save()
        Dim fileexist As StreamWriter
        Try
            If Me.ActiveControl.Text = Nothing Then
                MsgBox("Please click text or Text is clear", MsgBoxStyle.Exclamation, "Active Control is Nothing")
            Else
                fileexist = File.CreateText(namestring)
                fileexist.Write(Me.ActiveControl.Text)
                fileexist.Close()
                flagstep = False
            End If
        Catch ex As Exception
            MsgBox("Error to create text!")
        End Try
    End Sub
    Private Sub ToolStripButton20_Click(sender As Object, e As EventArgs) Handles ToolStripButton20.Click
        Form2.ShowDialog()
    End Sub
    Private Sub ToolStripButton6_Click(sender As Object, e As EventArgs) Handles ToolStripButton6.Click
            Application.Exit()
    End Sub

    Private Sub ToolStripButton24_Click(sender As Object, e As EventArgs) Handles ToolStripButton24.Click
        Form9.ShowDialog()
    End Sub
    Private Sub ToolStripSplitButton2_Click(sender As Object, e As EventArgs) Handles ToolStripSplitButton2.Click
        Form7.ShowDialog()
    End Sub
    Private Sub ToolStripButton13_Click(sender As Object, e As EventArgs) Handles ToolStripButton13.Click
        Form5.ShowDialog()
    End Sub
    Private Sub ToolStripButton14_Click(sender As Object, e As EventArgs) Handles ToolStripButton14.Click
        Form8.ShowDialog()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        flagstep = True
        ToolStripStatusLabel1.Text = "Character: " & TextBox1.TextLength.ToString
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        If flagstep = True Then
            If MessageBox.Show("Document is changes. You sure?", "Warning", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                delete()
            Else
            End If
        End If
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        If namestring = String.Empty Then
            If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                namestring = SaveFileDialog1.FileName
                save()
            End If
        Else
            save()
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveAsToolStripMenuItem.Click
        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            namestring = SaveFileDialog1.FileName
            save()
        End If
    End Sub

    Private Sub Form1_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Contents.Paste()
        If Contents.Text = "" Then ToolStripButton11.Enabled = False Else 
        ToolStripButton11.Enabled = True
    End Sub
    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If flagstep = True Then
            If MessageBox.Show("Document is changes. You sure?", "Warning", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                e.Cancel = False
            Else
                e.Cancel = True
            End If
        End If
    End Sub

    
    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
            If Me.ActiveControl.Text = Nothing Then
            MsgBox("Please click text or Text is clear", MsgBoxStyle.Exclamation, "Active Control is Nothing")
        Else

            e.Graphics.DrawString(Me.ActiveControl.Text, New Font("MS Sans Serif", 12, FontStyle.Regular), Brushes.Black, 10, 10)
        End If
    End Sub

    Private Sub PrintToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintToolStripMenuItem.Click
        PrintDocument1.Print()
    End Sub

    Private Sub PrintSetupToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintSetupToolStripMenuItem.Click
        PrintDialog1.ShowDialog()
    End Sub

    Private Sub ShowPreviewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowPreviewToolStripMenuItem.Click
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub PageLayoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PageLayoutToolStripMenuItem.Click
        PageSetupDialog1.ShowDialog()
    End Sub

    Private Sub ToolStripButton3_ButtonClick(sender As Object, e As EventArgs) Handles ToolStripButton3.ButtonClick
        If namestring = String.Empty Then
            If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                namestring = SaveFileDialog1.FileName
                save()
            End If
        Else
            save()
        End If
    End Sub

    Private Sub ToolStripButton4_ButtonClick(sender As Object, e As EventArgs) Handles ToolStripButton4.ButtonClick
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub ToolStripButton5_ButtonClick(sender As Object, e As EventArgs) Handles ToolStripButton5.ButtonClick
        PrintDocument1.Print()
    End Sub

    Private Sub ToolStripButton7_Click(sender As Object, e As EventArgs) Handles ToolStripButton7.Click

    End Sub

  

    Private Sub ToolStripButton9_Click(sender As Object, e As EventArgs) Handles ToolStripButton9.Click
        TextBox1.Cut()
    End Sub

    Private Sub ToolStripButton10_Click(sender As Object, e As EventArgs) Handles ToolStripButton10.Click
        If Contents.Text = "" Then
        Else
            ToolStripButton11.Enabled = True
        End If


    End Sub

    Private Sub ToolStripButton11_Click(sender As Object, e As EventArgs) Handles ToolStripButton11.Click

    End Sub

    Private Sub ToolStripButton12_Click(sender As Object, e As EventArgs) Handles ToolStripButton12.Click
        If Me.ActiveControl.Text = "" Then
            MsgBox("Please click text or Text is clear", MsgBoxStyle.Exclamation, "Active Control is Nothing")
        Else
            Me.ActiveControl.Text = ""
        End If
    End Sub

    Private Sub ToolStripButton15_Click(sender As Object, e As EventArgs) Handles ToolStripButton15.Click
        TextBox1.SelectAll()
    End Sub

    Private Sub ToolStripButton16_Click(sender As Object, e As EventArgs) Handles ToolStripButton16.Click
        TextBox1.Enabled = False

    End Sub

    Private Sub ToolStripButton17_Click(sender As Object, e As EventArgs) Handles ToolStripButton17.Click
        TextBox1.Enabled = True
    End Sub

    Private Sub WordWrapToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WordWrapToolStripMenuItem.Click
       
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        If flagstep = True Then
            If MessageBox.Show("Document is changes. You sure?", "Warning", MessageBoxButtons.YesNo) Then
                delete()
                open()
            End If
        Else
            delete()
            open()
        End If
    End Sub

    Private Sub ToolStripButton21_Click(sender As Object, e As EventArgs) Handles ToolStripButton21.Click
        StrConv(TextBox1.SelectedText, VbStrConv.Uppercase)
    End Sub

    Private Sub ToolStripButton22_Click(sender As Object, e As EventArgs) Handles ToolStripButton22.Click
        StrConv(TextBox1.SelectedText, VbStrConv.Lowercase)
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ToolStripSplitButton3_ButtonClick(sender As Object, e As EventArgs)

    End Sub

    Private Sub StatusBarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StatusBarToolStripMenuItem.Click
        If StatusBarToolStripMenuItem.Checked = False Then
            StatusBarToolStripMenuItem.Checked = True
            StatusStrip1.Visible = True
        Else
            StatusStrip1.Visible = False
            StatusBarToolStripMenuItem.Checked = False
        End If
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Enabled = True
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Timer1.Enabled = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Timer1.Enabled = False
        Button1.Visible = False
        Button2.Visible = False
        Button3.Visible = False
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        TextBox1.Paste()
    End Sub

    Private Sub InsertToolStripMenuItem_Click(sender As Object, e As EventArgs)
        TextBox1.SelectedText = Now
    End Sub

    Private Sub ToolStripButton8_Click(sender As Object, e As EventArgs) Handles ToolStripButton8.Click
        TextBox1.SelectedText = Now
    End Sub

    Private Sub AutoPasteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AutoPasteToolStripMenuItem.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Contents.Paste()
        If Contents.Text = "" Then ToolStripButton11.Enabled = False Else 
        ToolStripButton11.Enabled = True
    
    End Sub

    Private Sub ToolStripButton11_ButtonClick(sender As Object, e As EventArgs) Handles ToolStripButton11.ButtonClick
        On Error GoTo errorhandler
        Contents.Paste()
        Me.ActiveControl.Text = Me.ActiveControl.Text + Contents.Text
        Exit Sub
errorhandler: MsgBox("Click Text")
    End Sub

    Private Sub PasteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasteToolStripMenuItem.Click
        TextBox1.Paste()
    End Sub

    Private Sub ToolStripButton18_ButtonClick(sender As Object, e As EventArgs) Handles ToolStripButton18.ButtonClick
        addtab()
    End Sub
    Sub addtab()
        Dim countertab As Integer
        countertab = TabControl1.TabPages.Count
        If countertab = 1 Then
            tabpagetext1.Text = "Text 2"
            NewText1.Parent = tabpagetext1
            NewText1.BorderStyle = BorderStyle.None
            NewText1.Multiline = True
            NewText1.ScrollBars = ScrollBars.Both
            NewText1.Location = New Point(10, 10)
            NewText1.Dock = DockStyle.Fill
            TabControl1.TabPages.Add(tabpagetext1)
        End If
    End Sub

    Private Sub ToolStripStatusLabel1_Click(sender As Object, e As EventArgs) Handles ToolStripStatusLabel1.Click

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Dim amounte As Integer
        amounte = Len(Me.ActiveControl.Text)
        ToolStripStatusLabel1.Text = "Character: " + amounte.ToString
    End Sub

    Private Sub PrintPreviewDialog1_Load(sender As Object, e As EventArgs) Handles PrintPreviewDialog1.Load

    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Dim contentfill As String
        If Me.ActiveControl.Text = "" Then
            Exit Sub
        Else
            If Not nlist.Items.Contains(Contents3.Text) Then
                If Contents3.Text = "" Then
                    Exit Sub         
                Else
                    If Len(Contents3.Text) >= 25 Then
                        contentfill = "..." & Strings.Right(Contents3.Text, 26)
                        lenlist.Items.Add(contentfill)
                        nlist.Items.Add(Contents3.Text)
                        If nlist.Items.Count = 9 Then
                            nlist.Items.RemoveAt(0)
                        ElseIf lenlist.Items.Count = 9 Then
                            lenlist.Items.RemoveAt(0)
                        End If
                        ToolStripButton7.DropDownItems.Clear()
                        For i = 0 To lenlist.Items.Count - 1
                            ToolStripButton7.DropDownItems.Add(lenlist.Items(i).ToString)
                        Next
                    Else
                        lenlist.Items.Add(Contents3.Text)
                        nlist.Items.Add(Contents3.Text)
                        If nlist.Items.Count = 9 Then
                            nlist.Items.RemoveAt(0)
                        ElseIf lenlist.Items.Count = 9 Then
                            lenlist.Items.RemoveAt(0)
                        End If
                        ToolStripButton7.DropDownItems.Clear()
                        For i = 0 To lenlist.Items.Count - 1
                            ToolStripButton7.DropDownItems.Add(lenlist.Items(i).ToString)
                        Next
                    End If
                    
                End If
            Else
                Exit Sub
            End If
        End If
        For k = 0 To nlist.Items.Count
            ListBox1.Items.Add(nlist.Items(k))
        Next

    End Sub

    Private Sub ToolStripButton7_ButtonClick(sender As Object, e As EventArgs) Handles ToolStripButton7.ButtonClick
        Dim lasted As String
        Dim intlast As Integer
        intlast = nlist.Items.Count - 1
        lasted = nlist.Items(intlast).ToString
        Me.ActiveControl.Text = Me.ActiveControl.Text + lasted.ToString
    End Sub

    Private Sub ToolStripButton7_DropDownItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ToolStripButton7.DropDownItemClicked
        Dim intdex As Integer
        Dim listnw As New ListBox
        Dim strend As String
        listnw.Items.Clear()
        For i = 1 To lenlist.Items.Count - 1
            listnw.Items.Add(lenlist.Items(1))
        Next
        For j = 0 To ToolStripButton7.DropDownItems.Count
            For Each strlst As String In ToolStripButton7.DropDownItems(j).Text
                For i = 0 To lenlist.Items.Count - 1
                    If strlst = listnw.Items(i).ToString Then
                        intdex = i
                        strend = nlist.Items(i).ToString()
                        Me.ActiveControl.Text = Me.ActiveControl.Text & strend
                    End If
                Next
            Next
        Next
    End Sub
    Sub rowitem()
        Dim nitem As String

        Dim vlist As New ListBox
        vlist.Items.Clear()
        For i = 1 To ToolStripButton7.DropDownItems.Count - 1
            vlist.Items.Add(ToolStripButton7.DropDownItems(i).Text)
        Next
        For Each dinas As String In vlist.Items
                Me.ActiveControl.Text = nitem
        Next
    End Sub
    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        If Me.ActiveControl.Text = "" Then
            Exit Sub
        Else
            Contents3.Text = Me.ActiveControl.Text
        End If
    End Sub

    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick
        ToolStripStatusLabel2.Text = "Tabs: " + TabControl1.TabPages.Count.ToString
    End Sub
End Class
