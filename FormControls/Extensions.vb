Imports System.Runtime.CompilerServices
Imports System.Windows.Forms

Public Module Extensions
    <Extension>
    Public Iterator Function Descendants(Of T As Class)(control As Control) As IEnumerable(Of T)
        For Each child As Control In control.Controls
            Dim thisControl As T = TryCast(child, T)
            If thisControl IsNot Nothing Then
                Yield CType(thisControl, T)
            End If

            If child.HasChildren Then
                For Each descendant As T In Descendants(Of T)(child)
                    Yield descendant
                Next descendant
            End If
        Next child
    End Function
    <Extension>
    Public Function TextBoxList(control As Control) As List(Of TextBox)
        Return control.Descendants(Of TextBox).ToList()
    End Function
    <Extension>
    Public Function ButtonList(control As Control) As List(Of Button)
        Return control.Descendants(Of Button).ToList()
    End Function
    <Extension>
    Public Function ToolStripButtonList(control As Control) As List(Of ToolStripButton)
        Return control.Descendants(Of ToolStripButton).ToList()
    End Function
End Module
