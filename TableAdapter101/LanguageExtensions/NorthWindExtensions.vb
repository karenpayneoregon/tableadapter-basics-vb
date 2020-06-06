Imports System.Runtime.CompilerServices
Imports TableAdapter.NorthWindAzureForInsertsDataSet
Namespace LanguageExtensions
    Public Module NorthWindExtensions
        <Extension>
        Public Function CurrentContact(dataset As NorthWindAzureForInsertsDataSet, position As Integer) As ContactsRow
            Return dataset.Contacts(position)
        End Function
    End Module
End Namespace