Module Module1
    <System.Runtime.CompilerServices.Extension()> _
    Public Function GetChildControlsRecursives(Of T As Control)(root As Control) As IEnumerable(Of T)
        If root Is Nothing Then
            Throw New ArgumentNullException("root")
        End If
        Dim controls As New List(Of T)
        Dim stack = New Stack(Of Control)()
        stack.Push(root)
        While stack.Count > 0
            Dim parent As Control = stack.Pop()
            For Each child As Control In parent.Controls
                If TypeOf child Is T Then
                    controls.Add(DirectCast(child, T))
                End If
                stack.Push(child)
            Next
        End While
        Return controls
    End Function
End Module
