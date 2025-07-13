<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim PnameLabel As System.Windows.Forms.Label
        Dim PaddressLabel As System.Windows.Forms.Label
        Dim PtelLabel As System.Windows.Forms.Label
        Dim PageLabel As System.Windows.Forms.Label
        Dim PnoteLabel As System.Windows.Forms.Label
        Dim PcodeLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Another_database_2DataSet = New DataValidationApp.Another_database_2DataSet()
        Me.PeopleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PeopleTableAdapter = New DataValidationApp.Another_database_2DataSetTableAdapters.PeopleTableAdapter()
        Me.TableAdapterManager = New DataValidationApp.Another_database_2DataSetTableAdapters.TableAdapterManager()
        Me.PeopleBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.PeopleBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.PnameTextBox = New System.Windows.Forms.TextBox()
        Me.PaddressTextBox = New System.Windows.Forms.TextBox()
        Me.PtelTextBox = New System.Windows.Forms.TextBox()
        Me.PageTextBox = New System.Windows.Forms.TextBox()
        Me.PnoteTextBox = New System.Windows.Forms.TextBox()
        Me.PcodeTextBox = New System.Windows.Forms.TextBox()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        PnameLabel = New System.Windows.Forms.Label()
        PaddressLabel = New System.Windows.Forms.Label()
        PtelLabel = New System.Windows.Forms.Label()
        PageLabel = New System.Windows.Forms.Label()
        PnoteLabel = New System.Windows.Forms.Label()
        PcodeLabel = New System.Windows.Forms.Label()
        CType(Me.Another_database_2DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PeopleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PeopleBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PeopleBindingNavigator.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PnameLabel
        '
        PnameLabel.AutoSize = True
        PnameLabel.Location = New System.Drawing.Point(225, 127)
        PnameLabel.Name = "PnameLabel"
        PnameLabel.Size = New System.Drawing.Size(53, 16)
        PnameLabel.TabIndex = 1
        PnameLabel.Text = "Pname:"
        AddHandler PnameLabel.Click, AddressOf Me.PnameLabel_Click
        '
        'PaddressLabel
        '
        PaddressLabel.AutoSize = True
        PaddressLabel.Location = New System.Drawing.Point(225, 155)
        PaddressLabel.Name = "PaddressLabel"
        PaddressLabel.Size = New System.Drawing.Size(69, 16)
        PaddressLabel.TabIndex = 3
        PaddressLabel.Text = "Paddress:"
        AddHandler PaddressLabel.Click, AddressOf Me.PaddressLabel_Click
        '
        'PtelLabel
        '
        PtelLabel.AutoSize = True
        PtelLabel.Location = New System.Drawing.Point(225, 183)
        PtelLabel.Name = "PtelLabel"
        PtelLabel.Size = New System.Drawing.Size(33, 16)
        PtelLabel.TabIndex = 5
        PtelLabel.Text = "Ptel:"
        AddHandler PtelLabel.Click, AddressOf Me.PtelLabel_Click
        '
        'PageLabel
        '
        PageLabel.AutoSize = True
        PageLabel.Location = New System.Drawing.Point(225, 211)
        PageLabel.Name = "PageLabel"
        PageLabel.Size = New System.Drawing.Size(43, 16)
        PageLabel.TabIndex = 7
        PageLabel.Text = "Page:"
        AddHandler PageLabel.Click, AddressOf Me.PageLabel_Click
        '
        'PnoteLabel
        '
        PnoteLabel.AutoSize = True
        PnoteLabel.Location = New System.Drawing.Point(225, 239)
        PnoteLabel.Name = "PnoteLabel"
        PnoteLabel.Size = New System.Drawing.Size(45, 16)
        PnoteLabel.TabIndex = 9
        PnoteLabel.Text = "Pnote:"
        AddHandler PnoteLabel.Click, AddressOf Me.PnoteLabel_Click
        '
        'PcodeLabel
        '
        PcodeLabel.AutoSize = True
        PcodeLabel.Location = New System.Drawing.Point(225, 267)
        PcodeLabel.Name = "PcodeLabel"
        PcodeLabel.Size = New System.Drawing.Size(50, 16)
        PcodeLabel.TabIndex = 11
        PcodeLabel.Text = "Pcode:"
        AddHandler PcodeLabel.Click, AddressOf Me.PcodeLabel_Click
        '
        'Another_database_2DataSet
        '
        Me.Another_database_2DataSet.DataSetName = "Another_database_2DataSet"
        Me.Another_database_2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PeopleBindingSource
        '
        Me.PeopleBindingSource.DataMember = "People"
        Me.PeopleBindingSource.DataSource = Me.Another_database_2DataSet
        '
        'PeopleTableAdapter
        '
        Me.PeopleTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.PeopleTableAdapter = Me.PeopleTableAdapter
        Me.TableAdapterManager.UpdateOrder = DataValidationApp.Another_database_2DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PeopleBindingNavigator
        '
        Me.PeopleBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.PeopleBindingNavigator.BindingSource = Me.PeopleBindingSource
        Me.PeopleBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.PeopleBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.PeopleBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.PeopleBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.PeopleBindingNavigatorSaveItem})
        Me.PeopleBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.PeopleBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.PeopleBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.PeopleBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.PeopleBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.PeopleBindingNavigator.Name = "PeopleBindingNavigator"
        Me.PeopleBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.PeopleBindingNavigator.Size = New System.Drawing.Size(800, 27)
        Me.PeopleBindingNavigator.TabIndex = 0
        Me.PeopleBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(45, 24)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 27)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'PeopleBindingNavigatorSaveItem
        '
        Me.PeopleBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PeopleBindingNavigatorSaveItem.Image = CType(resources.GetObject("PeopleBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.PeopleBindingNavigatorSaveItem.Name = "PeopleBindingNavigatorSaveItem"
        Me.PeopleBindingNavigatorSaveItem.Size = New System.Drawing.Size(29, 24)
        Me.PeopleBindingNavigatorSaveItem.Text = "Save Data"
        '
        'PnameTextBox
        '
        Me.PnameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PeopleBindingSource, "Pname", True))
        Me.PnameTextBox.Location = New System.Drawing.Point(300, 124)
        Me.PnameTextBox.Name = "PnameTextBox"
        Me.PnameTextBox.Size = New System.Drawing.Size(204, 22)
        Me.PnameTextBox.TabIndex = 2
        '
        'PaddressTextBox
        '
        Me.PaddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PeopleBindingSource, "Paddress", True))
        Me.PaddressTextBox.Location = New System.Drawing.Point(300, 152)
        Me.PaddressTextBox.Name = "PaddressTextBox"
        Me.PaddressTextBox.Size = New System.Drawing.Size(204, 22)
        Me.PaddressTextBox.TabIndex = 4
        '
        'PtelTextBox
        '
        Me.PtelTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PeopleBindingSource, "Ptel", True))
        Me.PtelTextBox.Location = New System.Drawing.Point(300, 180)
        Me.PtelTextBox.Name = "PtelTextBox"
        Me.PtelTextBox.Size = New System.Drawing.Size(204, 22)
        Me.PtelTextBox.TabIndex = 6
        '
        'PageTextBox
        '
        Me.PageTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PeopleBindingSource, "Page", True))
        Me.PageTextBox.Location = New System.Drawing.Point(300, 208)
        Me.PageTextBox.Name = "PageTextBox"
        Me.PageTextBox.Size = New System.Drawing.Size(204, 22)
        Me.PageTextBox.TabIndex = 8
        '
        'PnoteTextBox
        '
        Me.PnoteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PeopleBindingSource, "Pnote", True))
        Me.PnoteTextBox.Location = New System.Drawing.Point(300, 236)
        Me.PnoteTextBox.Name = "PnoteTextBox"
        Me.PnoteTextBox.Size = New System.Drawing.Size(204, 22)
        Me.PnoteTextBox.TabIndex = 10
        '
        'PcodeTextBox
        '
        Me.PcodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PeopleBindingSource, "Pcode", True))
        Me.PcodeTextBox.Location = New System.Drawing.Point(300, 264)
        Me.PcodeTextBox.Name = "PcodeTextBox"
        Me.PcodeTextBox.Size = New System.Drawing.Size(204, 22)
        Me.PcodeTextBox.TabIndex = 12
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 456)
        Me.Controls.Add(PnameLabel)
        Me.Controls.Add(Me.PnameTextBox)
        Me.Controls.Add(PaddressLabel)
        Me.Controls.Add(Me.PaddressTextBox)
        Me.Controls.Add(PtelLabel)
        Me.Controls.Add(Me.PtelTextBox)
        Me.Controls.Add(PageLabel)
        Me.Controls.Add(Me.PageTextBox)
        Me.Controls.Add(PnoteLabel)
        Me.Controls.Add(Me.PnoteTextBox)
        Me.Controls.Add(PcodeLabel)
        Me.Controls.Add(Me.PcodeTextBox)
        Me.Controls.Add(Me.PeopleBindingNavigator)
        Me.Name = "Form1"
        Me.Text = "Data Validation"
        CType(Me.Another_database_2DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PeopleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PeopleBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PeopleBindingNavigator.ResumeLayout(False)
        Me.PeopleBindingNavigator.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Another_database_2DataSet As Another_database_2DataSet
    Friend WithEvents PeopleBindingSource As BindingSource
    Friend WithEvents PeopleTableAdapter As Another_database_2DataSetTableAdapters.PeopleTableAdapter
    Friend WithEvents TableAdapterManager As Another_database_2DataSetTableAdapters.TableAdapterManager
    Friend WithEvents PeopleBindingNavigator As BindingNavigator
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
    Friend WithEvents PeopleBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents PnameTextBox As TextBox
    Friend WithEvents PaddressTextBox As TextBox
    Friend WithEvents PtelTextBox As TextBox
    Friend WithEvents PageTextBox As TextBox
    Friend WithEvents PnoteTextBox As TextBox
    Friend WithEvents PcodeTextBox As TextBox
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
