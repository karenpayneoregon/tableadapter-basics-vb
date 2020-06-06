Imports System.ComponentModel
Imports TableAdapter.Classes

Public Class AddNewForm
    Public Property Contact() As Contact

    Private Sub AddNewForm_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        SetCueText(FirstNameTextBox, "first name required")
        SetCueText(LastNameTextBox, "last name required")

        '
        ' Bypass validation of TextBox controls
        '
        CancelButton.CausesValidation = False


    End Sub
    Private Sub FirstNameTextBox_Validating(sender As Object, e As ComponentModel.CancelEventArgs) _
        Handles FirstNameTextBox.Validating

        If String.IsNullOrWhiteSpace(FirstNameTextBox.Text) Then
            ErrorProvider1.SetError(FirstNameTextBox, "Required")
            e.Cancel = True
        End If
    End Sub

    Private Sub FirstNameTextBox_Validated(sender As Object, e As EventArgs) _
        Handles FirstNameTextBox.Validated

        ErrorProvider1.SetError(FirstNameTextBox, "")
    End Sub

    Private Sub LastNameTextBox_Validating(sender As Object, e As ComponentModel.CancelEventArgs) _
        Handles LastNameTextBox.Validating

        If String.IsNullOrWhiteSpace(LastNameTextBox.Text) Then
            ErrorProvider1.SetError(LastNameTextBox, "Required")
            e.Cancel = True
        End If

    End Sub

    Private Sub LastNameTextBox_Validated(sender As Object, e As EventArgs) _
        Handles LastNameTextBox.Validated

        ErrorProvider1.SetError(LastNameTextBox, "")

    End Sub

    Private Sub AddNewForm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Contact = New Contact() With {.FirstName = FirstNameTextBox.Text, .LastName = LastNameTextBox.Text}
    End Sub
End Class