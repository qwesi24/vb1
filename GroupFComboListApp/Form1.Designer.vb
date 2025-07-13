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
        Dim EMPIDLabel As System.Windows.Forms.Label
        Dim EMPNAMELabel As System.Windows.Forms.Label
        Dim EMPPHONELabel As System.Windows.Forms.Label
        Dim EMPSALARYLabel As System.Windows.Forms.Label
        Dim EMPNOTELabel As System.Windows.Forms.Label
        Dim DeptNameLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboDepartment = New System.Windows.Forms.ComboBox()
        Me.DepartmentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupFdatabaseDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Group_F_databaseDataSet = New GroupFComboListApp.Group_F_databaseDataSet()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.EMPLOYEEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DepartmentTableAdapter = New GroupFComboListApp.Group_F_databaseDataSetTableAdapters.DepartmentTableAdapter()
        Me.EMPLOYEETableAdapter = New GroupFComboListApp.Group_F_databaseDataSetTableAdapters.EMPLOYEETableAdapter()
        Me.EMPLOYEEBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableAdapterManager = New GroupFComboListApp.Group_F_databaseDataSetTableAdapters.TableAdapterManager()
        Me.EMPIDTextBox = New System.Windows.Forms.TextBox()
        Me.EMPNAMETextBox = New System.Windows.Forms.TextBox()
        Me.EMPPHONETextBox = New System.Windows.Forms.TextBox()
        Me.EMPSALARYTextBox = New System.Windows.Forms.TextBox()
        Me.EMPNOTETextBox = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        EMPIDLabel = New System.Windows.Forms.Label()
        EMPNAMELabel = New System.Windows.Forms.Label()
        EMPPHONELabel = New System.Windows.Forms.Label()
        EMPSALARYLabel = New System.Windows.Forms.Label()
        EMPNOTELabel = New System.Windows.Forms.Label()
        DeptNameLabel = New System.Windows.Forms.Label()
        CType(Me.DepartmentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupFdatabaseDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Group_F_databaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EMPLOYEEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EMPLOYEEBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(129, 86)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Department"
        '
        'cboDepartment
        '
        Me.cboDepartment.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DepartmentBindingSource, "DeptName", True))
        Me.cboDepartment.DataSource = Me.DepartmentBindingSource
        Me.cboDepartment.DisplayMember = "DeptID"
        Me.cboDepartment.FormattingEnabled = True
        Me.cboDepartment.Location = New System.Drawing.Point(287, 83)
        Me.cboDepartment.Name = "cboDepartment"
        Me.cboDepartment.Size = New System.Drawing.Size(175, 24)
        Me.cboDepartment.TabIndex = 1
        Me.cboDepartment.ValueMember = "DeptName"
        '
        'DepartmentBindingSource
        '
        Me.DepartmentBindingSource.DataMember = "Department"
        Me.DepartmentBindingSource.DataSource = Me.GroupFdatabaseDataSetBindingSource
        '
        'GroupFdatabaseDataSetBindingSource
        '
        Me.GroupFdatabaseDataSetBindingSource.DataSource = Me.Group_F_databaseDataSet
        Me.GroupFdatabaseDataSetBindingSource.Position = 0
        '
        'Group_F_databaseDataSet
        '
        Me.Group_F_databaseDataSet.DataSetName = "Group_F_databaseDataSet"
        Me.Group_F_databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(287, 143)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(175, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Members of the Department "
        '
        'ListBox1
        '
        Me.ListBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.EMPLOYEEBindingSource, "EMPNAME", True))
        Me.ListBox1.DataSource = Me.EMPLOYEEBindingSource
        Me.ListBox1.DisplayMember = "DeptName"
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Location = New System.Drawing.Point(290, 199)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(172, 84)
        Me.ListBox1.TabIndex = 3
        Me.ListBox1.ValueMember = "EMPID"
        '
        'EMPLOYEEBindingSource
        '
        Me.EMPLOYEEBindingSource.DataMember = "EMPLOYEE"
        Me.EMPLOYEEBindingSource.DataSource = Me.GroupFdatabaseDataSetBindingSource
        '
        'DepartmentTableAdapter
        '
        Me.DepartmentTableAdapter.ClearBeforeFill = True
        '
        'EMPLOYEETableAdapter
        '
        Me.EMPLOYEETableAdapter.ClearBeforeFill = True
        '
        'EMPLOYEEBindingSource1
        '
        Me.EMPLOYEEBindingSource1.DataMember = "EMPLOYEE"
        Me.EMPLOYEEBindingSource1.DataSource = Me.Group_F_databaseDataSet
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.DepartmentTableAdapter = Me.DepartmentTableAdapter
        Me.TableAdapterManager.EMPLOYEETableAdapter = Me.EMPLOYEETableAdapter
        Me.TableAdapterManager.UpdateOrder = GroupFComboListApp.Group_F_databaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'EMPIDLabel
        '
        EMPIDLabel.AutoSize = True
        EMPIDLabel.Location = New System.Drawing.Point(564, 90)
        EMPIDLabel.Name = "EMPIDLabel"
        EMPIDLabel.Size = New System.Drawing.Size(52, 16)
        EMPIDLabel.TabIndex = 4
        EMPIDLabel.Text = "EMPID:"
        '
        'EMPIDTextBox
        '
        Me.EMPIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMPLOYEEBindingSource1, "EMPID", True))
        Me.EMPIDTextBox.Location = New System.Drawing.Point(662, 87)
        Me.EMPIDTextBox.Name = "EMPIDTextBox"
        Me.EMPIDTextBox.Size = New System.Drawing.Size(121, 22)
        Me.EMPIDTextBox.TabIndex = 5
        '
        'EMPNAMELabel
        '
        EMPNAMELabel.AutoSize = True
        EMPNAMELabel.Location = New System.Drawing.Point(564, 121)
        EMPNAMELabel.Name = "EMPNAMELabel"
        EMPNAMELabel.Size = New System.Drawing.Size(78, 16)
        EMPNAMELabel.TabIndex = 6
        EMPNAMELabel.Text = "EMPNAME:"
        '
        'EMPNAMETextBox
        '
        Me.EMPNAMETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMPLOYEEBindingSource1, "EMPNAME", True))
        Me.EMPNAMETextBox.Location = New System.Drawing.Point(662, 115)
        Me.EMPNAMETextBox.Name = "EMPNAMETextBox"
        Me.EMPNAMETextBox.Size = New System.Drawing.Size(121, 22)
        Me.EMPNAMETextBox.TabIndex = 7
        '
        'EMPPHONELabel
        '
        EMPPHONELabel.AutoSize = True
        EMPPHONELabel.Location = New System.Drawing.Point(564, 149)
        EMPPHONELabel.Name = "EMPPHONELabel"
        EMPPHONELabel.Size = New System.Drawing.Size(87, 16)
        EMPPHONELabel.TabIndex = 8
        EMPPHONELabel.Text = "EMPPHONE:"
        '
        'EMPPHONETextBox
        '
        Me.EMPPHONETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMPLOYEEBindingSource1, "EMPPHONE", True))
        Me.EMPPHONETextBox.Location = New System.Drawing.Point(662, 143)
        Me.EMPPHONETextBox.Name = "EMPPHONETextBox"
        Me.EMPPHONETextBox.Size = New System.Drawing.Size(121, 22)
        Me.EMPPHONETextBox.TabIndex = 9
        '
        'EMPSALARYLabel
        '
        EMPSALARYLabel.AutoSize = True
        EMPSALARYLabel.Location = New System.Drawing.Point(559, 177)
        EMPSALARYLabel.Name = "EMPSALARYLabel"
        EMPSALARYLabel.Size = New System.Drawing.Size(92, 16)
        EMPSALARYLabel.TabIndex = 10
        EMPSALARYLabel.Text = "EMPSALARY:"
        '
        'EMPSALARYTextBox
        '
        Me.EMPSALARYTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMPLOYEEBindingSource1, "EMPSALARY", True))
        Me.EMPSALARYTextBox.Location = New System.Drawing.Point(662, 171)
        Me.EMPSALARYTextBox.Name = "EMPSALARYTextBox"
        Me.EMPSALARYTextBox.Size = New System.Drawing.Size(121, 22)
        Me.EMPSALARYTextBox.TabIndex = 11
        '
        'EMPNOTELabel
        '
        EMPNOTELabel.AutoSize = True
        EMPNOTELabel.Location = New System.Drawing.Point(564, 205)
        EMPNOTELabel.Name = "EMPNOTELabel"
        EMPNOTELabel.Size = New System.Drawing.Size(77, 16)
        EMPNOTELabel.TabIndex = 12
        EMPNOTELabel.Text = "EMPNOTE:"
        '
        'EMPNOTETextBox
        '
        Me.EMPNOTETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMPLOYEEBindingSource1, "EMPNOTE", True))
        Me.EMPNOTETextBox.Location = New System.Drawing.Point(662, 199)
        Me.EMPNOTETextBox.Name = "EMPNOTETextBox"
        Me.EMPNOTETextBox.Size = New System.Drawing.Size(121, 22)
        Me.EMPNOTETextBox.TabIndex = 13
        '
        'DeptNameLabel
        '
        DeptNameLabel.AutoSize = True
        DeptNameLabel.Location = New System.Drawing.Point(564, 236)
        DeptNameLabel.Name = "DeptNameLabel"
        DeptNameLabel.Size = New System.Drawing.Size(79, 16)
        DeptNameLabel.TabIndex = 14
        DeptNameLabel.Text = "Dept Name:"
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.EMPLOYEEBindingSource, "DeptName", True))
        Me.ComboBox1.DataSource = Me.EMPLOYEEBindingSource1
        Me.ComboBox1.DisplayMember = "EMPID"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(662, 228)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 24)
        Me.ComboBox1.TabIndex = 15
        Me.ComboBox1.ValueMember = "DeptName"
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.BindingNavigator1.BindingSource = Me.EMPLOYEEBindingSource
        Me.BindingNavigator1.CountItem = Me.BindingNavigatorCountItem
        Me.BindingNavigator1.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.BindingNavigator1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem})
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator1.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BindingNavigator1.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BindingNavigator1.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BindingNavigator1.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem
        Me.BindingNavigator1.Size = New System.Drawing.Size(983, 27)
        Me.BindingNavigator1.TabIndex = 16
        Me.BindingNavigator1.Text = "BindingNavigator1"
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(45, 24)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
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
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 27)
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
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(983, 450)
        Me.Controls.Add(Me.BindingNavigator1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(EMPIDLabel)
        Me.Controls.Add(Me.EMPIDTextBox)
        Me.Controls.Add(EMPNAMELabel)
        Me.Controls.Add(Me.EMPNAMETextBox)
        Me.Controls.Add(EMPPHONELabel)
        Me.Controls.Add(Me.EMPPHONETextBox)
        Me.Controls.Add(EMPSALARYLabel)
        Me.Controls.Add(Me.EMPSALARYTextBox)
        Me.Controls.Add(EMPNOTELabel)
        Me.Controls.Add(Me.EMPNOTETextBox)
        Me.Controls.Add(DeptNameLabel)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cboDepartment)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Combo and ListBox"
        CType(Me.DepartmentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupFdatabaseDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Group_F_databaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EMPLOYEEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EMPLOYEEBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cboDepartment As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents GroupFdatabaseDataSetBindingSource As BindingSource
    Friend WithEvents Group_F_databaseDataSet As Group_F_databaseDataSet
    Friend WithEvents DepartmentBindingSource As BindingSource
    Friend WithEvents DepartmentTableAdapter As Group_F_databaseDataSetTableAdapters.DepartmentTableAdapter
    Friend WithEvents EMPLOYEEBindingSource As BindingSource
    Friend WithEvents EMPLOYEETableAdapter As Group_F_databaseDataSetTableAdapters.EMPLOYEETableAdapter
    Friend WithEvents EMPLOYEEBindingSource1 As BindingSource
    Friend WithEvents TableAdapterManager As Group_F_databaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents EMPIDTextBox As TextBox
    Friend WithEvents EMPNAMETextBox As TextBox
    Friend WithEvents EMPPHONETextBox As TextBox
    Friend WithEvents EMPSALARYTextBox As TextBox
    Friend WithEvents EMPNOTETextBox As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents BindingNavigator1 As BindingNavigator
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
End Class
