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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BSHit = New System.Windows.Forms.BindingSource(Me.components)
        Me.Gctu300DataSet = New GCTUBasic.gctu300DataSet()
        Me.PurpeseBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PurpeseTableAdapter = New GCTUBasic.gctu300DataSetTableAdapters.PurpeseTableAdapter()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemPurchasedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BSHit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Gctu300DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PurpeseBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.ItemPurchasedDataGridViewTextBoxColumn, Me.PriceDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.PurpeseBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(62, 145)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(529, 197)
        Me.DataGridView1.TabIndex = 0
        '
        'BSHit
        '
        Me.BSHit.DataSource = Me.Gctu300DataSet
        Me.BSHit.Position = 0
        '
        'Gctu300DataSet
        '
        Me.Gctu300DataSet.DataSetName = "gctu300DataSet"
        Me.Gctu300DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PurpeseBindingSource
        '
        Me.PurpeseBindingSource.DataMember = "Purpese"
        Me.PurpeseBindingSource.DataSource = Me.BSHit
        '
        'PurpeseTableAdapter
        '
        Me.PurpeseTableAdapter.ClearBeforeFill = True
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.Width = 125
        '
        'ItemPurchasedDataGridViewTextBoxColumn
        '
        Me.ItemPurchasedDataGridViewTextBoxColumn.DataPropertyName = "Item_Purchased"
        Me.ItemPurchasedDataGridViewTextBoxColumn.HeaderText = "Item_Purchased"
        Me.ItemPurchasedDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ItemPurchasedDataGridViewTextBoxColumn.Name = "ItemPurchasedDataGridViewTextBoxColumn"
        Me.ItemPurchasedDataGridViewTextBoxColumn.Width = 125
        '
        'PriceDataGridViewTextBoxColumn
        '
        Me.PriceDataGridViewTextBoxColumn.DataPropertyName = "Price"
        Me.PriceDataGridViewTextBoxColumn.HeaderText = "Price"
        Me.PriceDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PriceDataGridViewTextBoxColumn.Name = "PriceDataGridViewTextBoxColumn"
        Me.PriceDataGridViewTextBoxColumn.Width = 125
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form1"
        Me.Text = "Database Connection"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BSHit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Gctu300DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PurpeseBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BSHit As BindingSource
    Friend WithEvents Gctu300DataSet As gctu300DataSet
    Friend WithEvents PurpeseBindingSource As BindingSource
    Friend WithEvents PurpeseTableAdapter As gctu300DataSetTableAdapters.PurpeseTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ItemPurchasedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
