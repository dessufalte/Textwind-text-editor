Module Module2
    Public previosctrl As Control
    Public Sub doset(ByVal parentctr As Control)
        Dim ctr As Control
        For Each ctr In parentctr.Controls
            AddHandler ctr.Leave, AddressOf meLeave
            doset(ctr)
        Next
    End Sub
    Public Sub meLeave(ByVal sender As Object, ByVal e As System.EventArgs)
        previosctrl = DirectCast(sender, Control)
    End Sub
End Module
