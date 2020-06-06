Namespace My
    <ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Never)>
    Partial Friend Class Dialogs
        Public Shared Function Question(text As String) As Boolean

            Return (MessageBox.Show(text, "Question",
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                                    MessageBoxDefaultButton.Button2) = MsgBoxResult.Yes)
        End Function
    End Class

    <HideModuleName()>
    Friend Module CustomDialogs
        Private ReadOnly Instance As New ThreadSafeObjectProvider(Of Dialogs)
        ReadOnly Property Dialogs() As Dialogs
            Get
                Return Instance.GetInstance()
            End Get
        End Property
    End Module
End Namespace
