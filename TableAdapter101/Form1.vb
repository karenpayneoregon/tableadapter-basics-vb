Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Text
Imports FormControls
Imports TableAdapter.Classes
Imports TableAdapter.LanguageExtensions
Imports TableAdapter.My
Imports NWZ = TableAdapter.NorthWindAzureForInsertsDataSet

Public Class Form1
    ''' <summary>
    ''' In addition to standard save code guard against unforeseen errors
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ContactsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) _
        Handles ContactsBindingNavigatorSaveItem.Click

        Validate()
        ContactsBindingSource.EndEdit()

        Try
            TableAdapterManager.UpdateAll(Me.NorthWindAzureForInsertsDataSet)
        Catch ex As Exception
            '
            ' This will not happen in this code sample but in a relation
            ' database without cascading deletes and a record is used by
            ' related records an excepton would be thrown.
            '
            If ex.Message.Contains("FK_Customers_Contacts") Then
                MessageBox.Show("One or more customers are dependent on this contact, can not remove")
            Else
                '
                ' Unknown exception(s)
                '
                MessageBox.Show(ex.Message)
            End If

        End Try

    End Sub
    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        Task.Run(
            Sub()
                Try
                    '
                    ' Attempt to load data
                    '
                    ContactsTableAdapter.Fill(NorthWindAzureForInsertsDataSet.Contacts)

                    For Each column In ContactsDataGridView.Columns.Cast(Of DataGridViewColumn)
                        column.HeaderText = column.HeaderText.SplitCamelCase()
                        Invoke(New Action(Sub() column.HeaderText = column.HeaderText.SplitCamelCase()))
                    Next

                    Invoke(New Action(Sub() ContactsBindingSource.DataSource = NorthWindAzureForInsertsDataSet.Contacts))
                    Invoke(New Action(Sub() ButtonList().ForEach(Sub(button) button.Enabled = True)))
                    Invoke(New Action(
                        Sub()
                            For Each tsb As ToolStripButton In ContactsBindingNavigator.Items.OfType(Of ToolStripButton)
                                If Not tsb.Enabled Then
                                    tsb.Enabled = True
                                End If
                            Next

                        End Sub))

                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                    Exit Sub
                End Try
            End Sub)


        If Environment.UserName = "PayneK" Then
            ContactIdDataGridViewTextBoxColumn.Visible = True
        End If


    End Sub
    '
    ' Split column headers
    ' Show id column if the developer is running the app,
    ' most likely in the IDE.
    '
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ButtonList().ForEach(Sub(button) button.Enabled = False)

        For Each tsb As ToolStripButton In ContactsBindingNavigator.Items.OfType(Of ToolStripButton)
            If tsb.Enabled Then
                tsb.Enabled = False
            End If
        Next


    End Sub
    Private Sub ContactsDataGridView_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) _
        Handles ContactsDataGridView.CellEndEdit

        'CType(ContactsBindingSource.Current, DataRowView).Row.AcceptChanges()

    End Sub
    ''' <summary>
    ''' Edit current contact from button at bottom of form
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub EditCurrentButton_Click(sender As Object, e As EventArgs) _
        Handles EditCurrentButton.Click

        EditCurrentContact()

    End Sub
    ''' <summary>
    ''' Edit current contact from edit button in the
    ''' BindingNavigator
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub EditToolStripButton_Click(sender As Object, e As EventArgs) _
        Handles EditToolStripButton.Click

        EditCurrentContact()

    End Sub
    ''' <summary>
    ''' Show a modal form and provide editing of current contact.
    ''' The form has validation on each TextBox
    ''' </summary>
    Private Sub EditCurrentContact()

        If ContactsBindingSource.Current Is Nothing Then
            Exit Sub
        End If

        Dim editForm As New EditForm(Me.ContactRow)

        Try
            If editForm.ShowDialog() = DialogResult.OK Then
                Contact().FirstName = editForm.Contact.FirstName
                Contact().LastName = editForm.Contact.LastName
                'CType(ContactsBindingSource.Current, DataRowView).Row.AcceptChanges()
            End If
        Finally
            editForm.Dispose()
        End Try

    End Sub
    ''' <summary>
    ''' using a child form add a new contact where the form
    ''' has validation
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub AddNewRecordButton_Click(sender As Object, e As EventArgs) Handles AddNewRecordButton.Click

        Dim addRecordForm As New AddNewForm

        If addRecordForm.ShowDialog() = DialogResult.OK Then

            Dim newContact = addRecordForm.Contact
            Dim contactRow = Me.NorthWindAzureForInsertsDataSet.Contacts.NewContactsRow()

            contactRow.FirstName = newContact.FirstName
            contactRow.LastName = newContact.LastName

            Me.NorthWindAzureForInsertsDataSet.Contacts.Rows.Add(contactRow)

        End If

    End Sub
    ''' <summary>
    ''' Here we are looking to see if first or last name
    ''' are empty, if so reject and restore to prior value
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ContactsBindingSource_ListChanged(sender As Object, e As ListChangedEventArgs) Handles ContactsBindingSource.ListChanged

        '
        ' Interested in changes
        '
        If e.ListChangedType = ListChangedType.ItemChanged AndAlso e.PropertyDescriptor IsNot Nothing Then
            '
            ' Can't access deleted rows, exit now
            '
            If e.ListChangedType = e.ListChangedType.ItemDeleted Then
                Exit Sub
            End If

            Dim currentContact = Contact()

            If IsDBNull(currentContact(e.PropertyDescriptor.Name)) Then
                currentContact.RejectChanges()
                MessageBox.Show($"We don't like empty values for {e.PropertyDescriptor.Name.SplitCamelCase()}")
            End If

        End If
    End Sub
    ''' <summary>
    ''' Override delete operation by removing the delete item value
    ''' from the BindingNavigator
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BindingNavigatorDeleteItem_Click(sender As Object, e As EventArgs) _
        Handles BindingNavigatorDeleteItem.Click

        Dim row = CType(ContactsBindingSource.Current, DataRowView).Row

        If ContactsBindingSource.Current Is Nothing Then
            Exit Sub
        End If

        If Dialogs.Question($"Remove {row.Field(Of String)("FirstName")} {row.Field(Of String)("LastName")}") Then
            If ContactsTableAdapter.Delete(row.Field(Of Integer)("ContactId")) = 1 Then
                ContactsBindingSource.RemoveCurrent()
                row.AcceptChanges()
            Else
                MessageBox.Show("Failed to remove contact")
            End If

        End If
    End Sub
    Private Sub ContactsDataGridView_UserDeletingRow(sender As Object, e As DataGridViewRowCancelEventArgs) _
        Handles ContactsDataGridView.UserDeletingRow

        If ContactsBindingSource.Current Is Nothing Then
            Exit Sub
        End If

        If Dialogs.Question($"Remove '{ContactFullName}'") Then
            Dim row = CType(ContactsBindingSource.Current, DataRowView).Row
            If ContactsTableAdapter.Delete(Row.Field(Of Integer)("ContactId")) = 1 Then
                ContactsBindingSource.RemoveCurrent()
                Row.AcceptChanges()
            Else
                MessageBox.Show("Failed to remove contact")
            End If

        End If

        e.Cancel = True

    End Sub
    ''' <summary>
    ''' Shortcut to keep code clean
    ''' </summary>
    ''' <returns></returns>
    Private Function Contact() As NWZ.ContactsRow
        Return NorthWindAzureForInsertsDataSet.Contacts(ContactsDataGridView.CurrentRow.Index)
    End Function
    Private Function ContactRow() As Contact
        Dim row = CType(ContactsBindingSource.Current, DataRowView).Row

        Return New Contact With {
            .ContactId = row.Field(Of Integer)("ContactId"),
            .FirstName = row.Field(Of String)("FirstName"),
            .LastName = row.Field(Of String)("LastName")}

    End Function
    Private ReadOnly Property ContactFullName() As String
        Get
            Return $"{Contact.FirstName} {Contact.LastName}"
        End Get
    End Property
    ''' <summary>
    ''' Count each type of change and present to user
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ChangesToolButton_Click(sender As Object, e As EventArgs) Handles ChangesToolButton.Click
        Dim sb As New StringBuilder

        Dim contactTable = NorthWindAzureForInsertsDataSet.Tables("Contacts")

        Dim added = contactTable.GetChanges(DataRowState.Added)

        If added Is Nothing Then
            sb.AppendLine("Additions: 0")
        Else
            sb.AppendLine($"Additions: {added.Rows.Count}")
        End If

        Dim modified = contactTable.GetChanges(DataRowState.Modified)
        If modified Is Nothing Then
            sb.AppendLine("Modified: 0")
        Else
            sb.AppendLine($"Modified: {modified.Rows.Count}")
        End If

        Dim removed = contactTable.GetChanges(DataRowState.Deleted)

        If removed Is Nothing Then
            sb.AppendLine("Deleted: 0")
        Else
            sb.AppendLine($"Deleted: {removed.Rows.Count}")
            For index = 0 To removed.Rows.Count - 1
                If removed.Rows(index).RowState = DataRowState.Deleted Then
                    Console.WriteLine(Convert.ToInt32(removed.Rows(index)("ContactId", DataRowVersion.Original)))
                End If
            Next index
        End If

        MessageBox.Show(sb.ToString())

    End Sub
    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Close()
    End Sub


End Class
