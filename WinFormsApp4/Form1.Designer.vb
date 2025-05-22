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
        lblSalesApp = New Label()
        lblCurrentSales = New Label()
        Label2 = New Label()
        txtCurrentSales = New TextBox()
        lblProjSales = New Label()
        btnCal = New Button()
        btnExist = New Button()
        SuspendLayout()
        ' 
        ' lblSalesApp
        ' 
        lblSalesApp.AutoSize = True
        lblSalesApp.Font = New Font("Showcard Gothic", 24F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblSalesApp.Location = New Point(276, 34)
        lblSalesApp.Name = "lblSalesApp"
        lblSalesApp.Size = New Size(228, 50)
        lblSalesApp.TabIndex = 0
        lblSalesApp.Text = "Sales App"
        ' 
        ' lblCurrentSales
        ' 
        lblCurrentSales.AutoSize = True
        lblCurrentSales.Location = New Point(173, 112)
        lblCurrentSales.Name = "lblCurrentSales"
        lblCurrentSales.Size = New Size(92, 20)
        lblCurrentSales.TabIndex = 1
        lblCurrentSales.Text = "Current Sale:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(173, 158)
        Label2.Name = "Label2"
        Label2.Size = New Size(72, 20)
        Label2.TabIndex = 2
        Label2.Text = "GROWTH"
        ' 
        ' txtCurrentSales
        ' 
        txtCurrentSales.Location = New Point(285, 113)
        txtCurrentSales.Name = "txtCurrentSales"
        txtCurrentSales.Size = New Size(125, 27)
        txtCurrentSales.TabIndex = 3
        ' 
        ' lblProjSales
        ' 
        lblProjSales.AutoSize = True
        lblProjSales.BorderStyle = BorderStyle.FixedSingle
        lblProjSales.Location = New Point(190, 244)
        lblProjSales.Name = "lblProjSales"
        lblProjSales.Size = New Size(55, 22)
        lblProjSales.TabIndex = 4
        lblProjSales.Text = "Label1"
        ' 
        ' btnCal
        ' 
        btnCal.Location = New Point(228, 333)
        btnCal.Name = "btnCal"
        btnCal.Size = New Size(94, 29)
        btnCal.TabIndex = 5
        btnCal.Text = "Calculate"
        btnCal.UseVisualStyleBackColor = True
        ' 
        ' btnExist
        ' 
        btnExist.Location = New Point(437, 333)
        btnExist.Name = "btnExist"
        btnExist.Size = New Size(94, 29)
        btnExist.TabIndex = 6
        btnExist.Text = "Exist"
        btnExist.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnExist)
        Controls.Add(btnCal)
        Controls.Add(lblProjSales)
        Controls.Add(txtCurrentSales)
        Controls.Add(Label2)
        Controls.Add(lblCurrentSales)
        Controls.Add(lblSalesApp)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblSalesApp As Label
    Friend WithEvents lblCurrentSales As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCurrentSales As TextBox
    Friend WithEvents lblProjSales As Label
    Friend WithEvents btnCal As Button
    Friend WithEvents btnExist As Button

End Class
