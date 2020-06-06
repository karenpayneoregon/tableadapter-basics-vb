Public Class Form1
    Private Sub ContactsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ContactsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ContactsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.NorthWindContactsDataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'NorthWindContactsDataSet.Contacts' table. You can move, or remove it, as needed.
        Me.ContactsTableAdapter.Fill(Me.NorthWindContactsDataSet.Contacts)

    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Close()
    End Sub
End Class
