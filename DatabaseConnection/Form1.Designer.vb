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
        Me.btnOpenConnection = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnOpenConnection
        '
        Me.btnOpenConnection.Location = New System.Drawing.Point(302, 246)
        Me.btnOpenConnection.Name = "btnOpenConnection"
        Me.btnOpenConnection.Size = New System.Drawing.Size(152, 40)
        Me.btnOpenConnection.TabIndex = 0
        Me.btnOpenConnection.Text = "Open Connection"
        Me.btnOpenConnection.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnOpenConnection)
        Me.Name = "Form1"
        Me.Text = "Database Connection"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnOpenConnection As Button
End Class
