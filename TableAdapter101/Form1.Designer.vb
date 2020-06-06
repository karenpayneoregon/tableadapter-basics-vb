<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ContactsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.ContactsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NorthWindAzureForInsertsDataSet = New TableAdapter.NorthWindAzureForInsertsDataSet()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.ContactsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ChangesToolButton = New System.Windows.Forms.ToolStripButton()
        Me.EditToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ContactsDataGridView = New System.Windows.Forms.DataGridView()
        Me.ContactIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.AddNewRecordButton = New System.Windows.Forms.Button()
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.EditCurrentButton = New System.Windows.Forms.Button()
        Me.ContactsTableAdapter = New TableAdapter.NorthWindAzureForInsertsDataSetTableAdapters.ContactsTableAdapter()
        Me.TableAdapterManager = New TableAdapter.NorthWindAzureForInsertsDataSetTableAdapters.TableAdapterManager()
        CType(Me.ContactsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContactsBindingNavigator.SuspendLayout()
        CType(Me.ContactsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NorthWindAzureForInsertsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ContactsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ContactsBindingNavigator
        '
        Me.ContactsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ContactsBindingNavigator.BindingSource = Me.ContactsBindingSource
        Me.ContactsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ContactsBindingNavigator.DeleteItem = Nothing
        Me.ContactsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.EditToolStripButton, Me.ChangesToolButton, Me.BindingNavigatorDeleteItem, Me.ContactsBindingNavigatorSaveItem})
        Me.ContactsBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ContactsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ContactsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ContactsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ContactsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ContactsBindingNavigator.Name = "ContactsBindingNavigator"
        Me.ContactsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ContactsBindingNavigator.Size = New System.Drawing.Size(392, 25)
        Me.ContactsBindingNavigator.TabIndex = 0
        Me.ContactsBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new contact"
        '
        'ContactsBindingSource
        '
        Me.ContactsBindingSource.DataMember = "Contacts"
        Me.ContactsBindingSource.DataSource = Me.NorthWindAzureForInsertsDataSet
        '
        'NorthWindAzureForInsertsDataSet
        '
        Me.NorthWindAzureForInsertsDataSet.DataSetName = "NorthWindAzureForInsertsDataSet"
        Me.NorthWindAzureForInsertsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete current contact"
        '
        'ContactsBindingNavigatorSaveItem
        '
        Me.ContactsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ContactsBindingNavigatorSaveItem.Image = CType(resources.GetObject("ContactsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ContactsBindingNavigatorSaveItem.Name = "ContactsBindingNavigatorSaveItem"
        Me.ContactsBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.ContactsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ChangesToolButton
        '
        Me.ChangesToolButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ChangesToolButton.Image = CType(resources.GetObject("ChangesToolButton.Image"), System.Drawing.Image)
        Me.ChangesToolButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ChangesToolButton.Name = "ChangesToolButton"
        Me.ChangesToolButton.Size = New System.Drawing.Size(23, 22)
        Me.ChangesToolButton.Text = "Changes"
        '
        'EditToolStripButton
        '
        Me.EditToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.EditToolStripButton.Image = Global.TableAdapter.My.Resources.Resources.Edit_16x
        Me.EditToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.EditToolStripButton.Name = "EditToolStripButton"
        Me.EditToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.EditToolStripButton.Text = "Edit current contact"
        '
        'ContactsDataGridView
        '
        Me.ContactsDataGridView.AutoGenerateColumns = False
        Me.ContactsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ContactsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ContactIdDataGridViewTextBoxColumn, Me.FirstNameDataGridViewTextBoxColumn, Me.LastNameDataGridViewTextBoxColumn})
        Me.ContactsDataGridView.DataSource = Me.ContactsBindingSource
        Me.ContactsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ContactsDataGridView.Location = New System.Drawing.Point(0, 25)
        Me.ContactsDataGridView.Name = "ContactsDataGridView"
        Me.ContactsDataGridView.Size = New System.Drawing.Size(392, 231)
        Me.ContactsDataGridView.TabIndex = 1
        '
        'ContactIdDataGridViewTextBoxColumn
        '
        Me.ContactIdDataGridViewTextBoxColumn.DataPropertyName = "ContactId"
        Me.ContactIdDataGridViewTextBoxColumn.HeaderText = "ContactId"
        Me.ContactIdDataGridViewTextBoxColumn.Name = "ContactIdDataGridViewTextBoxColumn"
        Me.ContactIdDataGridViewTextBoxColumn.ReadOnly = True
        Me.ContactIdDataGridViewTextBoxColumn.Visible = False
        '
        'FirstNameDataGridViewTextBoxColumn
        '
        Me.FirstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName"
        Me.FirstNameDataGridViewTextBoxColumn.HeaderText = "FirstName"
        Me.FirstNameDataGridViewTextBoxColumn.Name = "FirstNameDataGridViewTextBoxColumn"
        '
        'LastNameDataGridViewTextBoxColumn
        '
        Me.LastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName"
        Me.LastNameDataGridViewTextBoxColumn.HeaderText = "LastName"
        Me.LastNameDataGridViewTextBoxColumn.Name = "LastNameDataGridViewTextBoxColumn"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.AddNewRecordButton)
        Me.Panel1.Controls.Add(Me.CloseButton)
        Me.Panel1.Controls.Add(Me.EditCurrentButton)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 256)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(392, 49)
        Me.Panel1.TabIndex = 3
        '
        'AddNewRecordButton
        '
        Me.AddNewRecordButton.Image = Global.TableAdapter.My.Resources.Resources.AddNewRecord
        Me.AddNewRecordButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AddNewRecordButton.Location = New System.Drawing.Point(112, 14)
        Me.AddNewRecordButton.Name = "AddNewRecordButton"
        Me.AddNewRecordButton.Size = New System.Drawing.Size(94, 23)
        Me.AddNewRecordButton.TabIndex = 4
        Me.AddNewRecordButton.Text = "New"
        Me.AddNewRecordButton.UseVisualStyleBackColor = True
        '
        'CloseButton
        '
        Me.CloseButton.Image = Global.TableAdapter.My.Resources.Resources.Exit_16x1
        Me.CloseButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CloseButton.Location = New System.Drawing.Point(305, 14)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(75, 23)
        Me.CloseButton.TabIndex = 3
        Me.CloseButton.Text = "Exit"
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'EditCurrentButton
        '
        Me.EditCurrentButton.Image = Global.TableAdapter.My.Resources.Resources.Edit_16x
        Me.EditCurrentButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.EditCurrentButton.Location = New System.Drawing.Point(12, 14)
        Me.EditCurrentButton.Name = "EditCurrentButton"
        Me.EditCurrentButton.Size = New System.Drawing.Size(94, 23)
        Me.EditCurrentButton.TabIndex = 2
        Me.EditCurrentButton.Text = "Edit"
        Me.EditCurrentButton.UseVisualStyleBackColor = True
        '
        'ContactsTableAdapter
        '
        Me.ContactsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ContactsTableAdapter = Me.ContactsTableAdapter
        Me.TableAdapterManager.UpdateOrder = TableAdapter.NorthWindAzureForInsertsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(392, 305)
        Me.Controls.Add(Me.ContactsDataGridView)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ContactsBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TableAdapter basics"
        CType(Me.ContactsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContactsBindingNavigator.ResumeLayout(False)
        Me.ContactsBindingNavigator.PerformLayout()
        CType(Me.ContactsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NorthWindAzureForInsertsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ContactsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NorthWindAzureForInsertsDataSet As NorthWindAzureForInsertsDataSet
    Friend WithEvents ContactsBindingSource As BindingSource
    Friend WithEvents ContactsTableAdapter As NorthWindAzureForInsertsDataSetTableAdapters.ContactsTableAdapter
    Friend WithEvents TableAdapterManager As NorthWindAzureForInsertsDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ContactsBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents ContactsBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents ContactsDataGridView As DataGridView
    Friend WithEvents EditCurrentButton As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ChangesToolButton As ToolStripButton
    Friend WithEvents ContactIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FirstNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LastNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EditToolStripButton As ToolStripButton
    Friend WithEvents CloseButton As Button
    Friend WithEvents AddNewRecordButton As Button
End Class
