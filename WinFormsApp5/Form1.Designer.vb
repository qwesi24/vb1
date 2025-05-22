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
        MenuStrip1 = New MenuStrip()
        FileToolStripMenuItem = New ToolStripMenuItem()
        NewToolStripMenuItem = New ToolStripMenuItem()
        OpenToolStripMenuItem = New ToolStripMenuItem()
        ExistToolStripMenuItem = New ToolStripMenuItem()
        ExistToolStripMenuItem2 = New ToolStripMenuItem()
        ExistToolStripMenuItem1 = New ToolStripMenuItem()
        UndoToolStripMenuItem = New ToolStripMenuItem()
        RedoToolStripMenuItem = New ToolStripMenuItem()
        CutToolStripMenuItem = New ToolStripMenuItem()
        CopyToolStripMenuItem = New ToolStripMenuItem()
        PasteToolStripMenuItem = New ToolStripMenuItem()
        FindToolStripMenuItem = New ToolStripMenuItem()
        FormateToolStripMenuItem = New ToolStripMenuItem()
        FontToolStripMenuItem = New ToolStripMenuItem()
        FontColorToolStripMenuItem = New ToolStripMenuItem()
        BackgroundColorToolStripMenuItem = New ToolStripMenuItem()
        HelpToolStripMenuItem = New ToolStripMenuItem()
        TextBox1 = New TextBox()
        SaveFileDialog1 = New SaveFileDialog()
        OpenFileDialog1 = New OpenFileDialog()
        FontDialog1 = New FontDialog()
        ColorDialog1 = New ColorDialog()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {FileToolStripMenuItem, ExistToolStripMenuItem1, FormateToolStripMenuItem, HelpToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 28)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' FileToolStripMenuItem
        ' 
        FileToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {NewToolStripMenuItem, OpenToolStripMenuItem, ExistToolStripMenuItem, ExistToolStripMenuItem2})
        FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        FileToolStripMenuItem.Size = New Size(46, 24)
        FileToolStripMenuItem.Text = "File"
        ' 
        ' NewToolStripMenuItem
        ' 
        NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        NewToolStripMenuItem.Size = New Size(128, 26)
        NewToolStripMenuItem.Text = "New"
        ' 
        ' OpenToolStripMenuItem
        ' 
        OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        OpenToolStripMenuItem.Size = New Size(128, 26)
        OpenToolStripMenuItem.Text = "Open"
        ' 
        ' ExistToolStripMenuItem
        ' 
        ExistToolStripMenuItem.Name = "ExistToolStripMenuItem"
        ExistToolStripMenuItem.Size = New Size(128, 26)
        ExistToolStripMenuItem.Text = "Save"
        ' 
        ' ExistToolStripMenuItem2
        ' 
        ExistToolStripMenuItem2.Name = "ExistToolStripMenuItem2"
        ExistToolStripMenuItem2.Size = New Size(128, 26)
        ExistToolStripMenuItem2.Text = "Exist"
        ' 
        ' ExistToolStripMenuItem1
        ' 
        ExistToolStripMenuItem1.DropDownItems.AddRange(New ToolStripItem() {UndoToolStripMenuItem, RedoToolStripMenuItem, CutToolStripMenuItem, CopyToolStripMenuItem, PasteToolStripMenuItem, FindToolStripMenuItem})
        ExistToolStripMenuItem1.Name = "ExistToolStripMenuItem1"
        ExistToolStripMenuItem1.Size = New Size(53, 24)
        ExistToolStripMenuItem1.Text = "Exist"
        ' 
        ' UndoToolStripMenuItem
        ' 
        UndoToolStripMenuItem.Name = "UndoToolStripMenuItem"
        UndoToolStripMenuItem.Size = New Size(128, 26)
        UndoToolStripMenuItem.Text = "Undo"
        ' 
        ' RedoToolStripMenuItem
        ' 
        RedoToolStripMenuItem.Name = "RedoToolStripMenuItem"
        RedoToolStripMenuItem.Size = New Size(128, 26)
        RedoToolStripMenuItem.Text = "Redo"
        ' 
        ' CutToolStripMenuItem
        ' 
        CutToolStripMenuItem.Name = "CutToolStripMenuItem"
        CutToolStripMenuItem.Size = New Size(128, 26)
        CutToolStripMenuItem.Text = "Cut"
        ' 
        ' CopyToolStripMenuItem
        ' 
        CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        CopyToolStripMenuItem.Size = New Size(128, 26)
        CopyToolStripMenuItem.Text = "Copy"
        ' 
        ' PasteToolStripMenuItem
        ' 
        PasteToolStripMenuItem.Name = "PasteToolStripMenuItem"
        PasteToolStripMenuItem.Size = New Size(128, 26)
        PasteToolStripMenuItem.Text = "Paste"
        ' 
        ' FindToolStripMenuItem
        ' 
        FindToolStripMenuItem.Name = "FindToolStripMenuItem"
        FindToolStripMenuItem.Size = New Size(128, 26)
        FindToolStripMenuItem.Text = "Find"
        ' 
        ' FormateToolStripMenuItem
        ' 
        FormateToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {FontToolStripMenuItem, FontColorToolStripMenuItem, BackgroundColorToolStripMenuItem})
        FormateToolStripMenuItem.Name = "FormateToolStripMenuItem"
        FormateToolStripMenuItem.Size = New Size(78, 24)
        FormateToolStripMenuItem.Text = "Formate"
        ' 
        ' FontToolStripMenuItem
        ' 
        FontToolStripMenuItem.Name = "FontToolStripMenuItem"
        FontToolStripMenuItem.Size = New Size(211, 26)
        FontToolStripMenuItem.Text = "Font"
        ' 
        ' FontColorToolStripMenuItem
        ' 
        FontColorToolStripMenuItem.Name = "FontColorToolStripMenuItem"
        FontColorToolStripMenuItem.Size = New Size(211, 26)
        FontColorToolStripMenuItem.Text = "Font Color"
        ' 
        ' BackgroundColorToolStripMenuItem
        ' 
        BackgroundColorToolStripMenuItem.Name = "BackgroundColorToolStripMenuItem"
        BackgroundColorToolStripMenuItem.Size = New Size(211, 26)
        BackgroundColorToolStripMenuItem.Text = "Background Color"
        ' 
        ' HelpToolStripMenuItem
        ' 
        HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        HelpToolStripMenuItem.Size = New Size(55, 24)
        HelpToolStripMenuItem.Text = "Help"
        ' 
        ' TextBox1
        ' 
        TextBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        TextBox1.Location = New Point(14, 31)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(800, 425)
        TextBox1.TabIndex = 1
        ' 
        ' SaveFileDialog1
        ' 
        SaveFileDialog1.CheckPathExists = False
        SaveFileDialog1.CheckWriteAccess = False
        SaveFileDialog1.DefaultExt = "txt"
        SaveFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*"
        SaveFileDialog1.OverwritePrompt = False
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.CheckPathExists = False
        OpenFileDialog1.DefaultExt = "txt"
        OpenFileDialog1.FileName = "OpenFileDialog1"
        OpenFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(TextBox1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        Text = "Form1"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExistToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExistToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents UndoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RedoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PasteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FindToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FormateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FontToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FontColorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BackgroundColorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents ExistToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents FontDialog1 As FontDialog
    Friend WithEvents ColorDialog1 As ColorDialog

End Class
