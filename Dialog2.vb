Imports System.Windows.Forms
Public Class Dialog2
    Dim indexTab As Integer
    Dim leList As New ListBox
    Dim veList As New ListBox
    Dim boolList As Integer
    Sub optionrow()
        For i = 0 To Form1.TabControl1.TabPages.Count - 1
            Form1.TabControl1.TabPages(i).Text = ListBox1.Items(i).ToString
        Next
    End Sub
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        For i = 0 To Form1.TabControl1.TabPages.Count - 1
            Form1.TabControl1.TabPages(i).Text = leList.Items(i)
        Next
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub Dialog2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cancel_Button.Enabled = True
        leList.Items.Clear()
        ListBox1.Items.Clear()
        For i = 0 To Form1.TabControl1.TabPages.Count - 1
            leList.Items.Add(Form1.TabControl1.TabPages(i).Text)
            ListBox1.Items.Add(Form1.TabControl1.TabPages(i).Text)
        Next
    End Sub
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        On Error GoTo errorHandler
        indexTab = ListBox1.SelectedIndex
        Label4.Text = indexTab
        TextBox1.Text = ListBox1.SelectedItem.ToString
        namee.Text = Form1.TabControl1.TabPages(indexTab).Name.ToString
        modee.Text = Form1.TabControl1.TabPages(indexTab).ImeMode.ToString
        stylee.Text = Form1.TabControl1.TabPages(indexTab).BackColor.ToArgb.ToString
        Exit Sub
errorHandler: MsgBox("Bug again")
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If ListBox1.SelectedItem = Nothing Then
            MsgBox("Select Tab", MsgBoxStyle.Information, "Tab Option")
        Else
            Form1.TabControl1.TabPages(indexTab).Text = TextBox1.Text
            ListBox1.Items.Clear()
            For i = 0 To Form1.TabControl1.TabPages.Count - 1
                ListBox1.Items.Add(Form1.TabControl1.TabPages(i).Text)
            Next
        End If
    End Sub '
    Sub refreshd()
        ListBox1.Items.Clear()
        For i = 0 To Form1.TabControl1.TabPages.Count - 1
            ListBox1.Items.Add(Form1.TabControl1.TabPages(i).Text)
        Next
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ListBox1.SelectedItem = Nothing Then
            Exit Sub
        Else
            If MsgBox("Delete this tab? ", MsgBoxStyle.YesNo, "Option Tab") = MsgBoxResult.Yes Then
                Form1.TabControl1.TabPages.RemoveAt(indexTab)
                refreshd()
                Cancel_Button.Enabled = False
            Else
                Exit Sub
            End If
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            GroupBox2.Visible = True
        Else
            GroupBox2.Visible = False
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub
End Class
