Imports TableAdapter.Classes

Public Class EditForm
    ''' <summary>
    ''' Represents the current contact which is used
    ''' instead of a ContactRow as it's a light weight container
    ''' than ContactRow.
    ''' </summary>
    ''' <returns></returns>
    Public Property Contact() As Contact
    ''' <summary>
    ''' Set properties for form level property Contact
    ''' </summary>
    ''' <param name="contact"></param>
    Public Sub New(contact As Contact)
        InitializeComponent()

        Me.Contact = New Contact() With {
            .FirstName = contact.FirstName,
            .LastName = contact.LastName}

    End Sub
    ''' <summary>
    ''' No data binding, simply assign values to the
    ''' Text properties of the TextBox controls
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub EditForm_Shown(sender As Object, e As EventArgs) _
        Handles Me.Shown

        FirstNameTextBox.Text = Contact.FirstName
        LastNameTextBox.Text = Contact.LastName

        Text = $"Editing: {Contact.FirstName} {Contact.LastName}"

        SetCueText(FirstNameTextBox, "first name required")
        SetCueText(LastNameTextBox, "last name required")

    End Sub

    Private Sub SaveChangesButton_Click(sender As Object, e As EventArgs) _
        Handles SaveChangesButton.Click

        If String.IsNullOrWhiteSpace(FirstNameTextBox.Text) OrElse
           String.IsNullOrWhiteSpace(LastNameTextBox.Text) Then

            MessageBox.Show("Requires first and last name")

        Else

            Contact.FirstName = FirstNameTextBox.Text
            Contact.LastName = LastNameTextBox.Text

            DialogResult = DialogResult.OK
        End If
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
End Class