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
        txtGCTUfeescollectionapp = New Label()
        lblFirstName = New Label()
        lblIndexNumber = New Label()
        txtFirstName = New TextBox()
        txtIndexNumber = New TextBox()
        grpLevel = New GroupBox()
        chkPhd = New CheckBox()
        chkLevel4 = New CheckBox()
        chkMasters = New CheckBox()
        chkLevel3 = New CheckBox()
        chkLevel2 = New CheckBox()
        chkLevel1 = New CheckBox()
        grbProgramme = New GroupBox()
        rdbEngineering = New RadioButton()
        rbdWebDesginning = New RadioButton()
        rdbBscComputerScienece = New RadioButton()
        rdbBIT = New RadioButton()
        grpGender = New GroupBox()
        chkFemale = New CheckBox()
        chkMale = New CheckBox()
        btnGetFees = New Button()
        btnReset = New Button()
        btnExist = New Button()
        txtDisplay = New TextBox()
        grpLevel.SuspendLayout()
        grbProgramme.SuspendLayout()
        grpGender.SuspendLayout()
        SuspendLayout()
        ' 
        ' txtGCTUfeescollectionapp
        ' 
        txtGCTUfeescollectionapp.AutoSize = True
        txtGCTUfeescollectionapp.Font = New Font("Stencil", 28.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtGCTUfeescollectionapp.Location = New Point(96, 23)
        txtGCTUfeescollectionapp.Name = "txtGCTUfeescollectionapp"
        txtGCTUfeescollectionapp.Size = New Size(645, 56)
        txtGCTUfeescollectionapp.TabIndex = 0
        txtGCTUfeescollectionapp.Text = "GCTU FEES COLLECTION APP"
        ' 
        ' lblFirstName
        ' 
        lblFirstName.AutoSize = True
        lblFirstName.Location = New Point(171, 108)
        lblFirstName.Name = "lblFirstName"
        lblFirstName.Size = New Size(80, 20)
        lblFirstName.TabIndex = 1
        lblFirstName.Text = "First Name"
        ' 
        ' lblIndexNumber
        ' 
        lblIndexNumber.AutoSize = True
        lblIndexNumber.Location = New Point(171, 177)
        lblIndexNumber.Name = "lblIndexNumber"
        lblIndexNumber.Size = New Size(103, 20)
        lblIndexNumber.TabIndex = 2
        lblIndexNumber.Text = "Index Number"
        ' 
        ' txtFirstName
        ' 
        txtFirstName.Location = New Point(378, 113)
        txtFirstName.Name = "txtFirstName"
        txtFirstName.Size = New Size(171, 27)
        txtFirstName.TabIndex = 3
        ' 
        ' txtIndexNumber
        ' 
        txtIndexNumber.Location = New Point(378, 177)
        txtIndexNumber.Name = "txtIndexNumber"
        txtIndexNumber.Size = New Size(171, 27)
        txtIndexNumber.TabIndex = 4
        ' 
        ' grpLevel
        ' 
        grpLevel.Controls.Add(chkPhd)
        grpLevel.Controls.Add(chkLevel4)
        grpLevel.Controls.Add(chkMasters)
        grpLevel.Controls.Add(chkLevel3)
        grpLevel.Controls.Add(chkLevel2)
        grpLevel.Controls.Add(chkLevel1)
        grpLevel.Location = New Point(171, 271)
        grpLevel.Name = "grpLevel"
        grpLevel.Size = New Size(288, 237)
        grpLevel.TabIndex = 5
        grpLevel.TabStop = False
        grpLevel.Text = "Level of Study"
        ' 
        ' chkPhd
        ' 
        chkPhd.AutoSize = True
        chkPhd.Location = New Point(14, 188)
        chkPhd.Name = "chkPhd"
        chkPhd.Size = New Size(61, 24)
        chkPhd.TabIndex = 7
        chkPhd.Text = "PHD"
        chkPhd.UseVisualStyleBackColor = True
        ' 
        ' chkLevel4
        ' 
        chkLevel4.AutoSize = True
        chkLevel4.Location = New Point(14, 128)
        chkLevel4.Name = "chkLevel4"
        chkLevel4.Size = New Size(93, 24)
        chkLevel4.TabIndex = 3
        chkLevel4.Text = "Level 400"
        chkLevel4.UseVisualStyleBackColor = True
        ' 
        ' chkMasters
        ' 
        chkMasters.AutoSize = True
        chkMasters.Location = New Point(14, 158)
        chkMasters.Name = "chkMasters"
        chkMasters.Size = New Size(86, 24)
        chkMasters.TabIndex = 6
        chkMasters.Text = "Masters "
        chkMasters.UseVisualStyleBackColor = True
        ' 
        ' chkLevel3
        ' 
        chkLevel3.AutoSize = True
        chkLevel3.Location = New Point(14, 98)
        chkLevel3.Name = "chkLevel3"
        chkLevel3.Size = New Size(93, 24)
        chkLevel3.TabIndex = 2
        chkLevel3.Text = "Level 300"
        chkLevel3.UseVisualStyleBackColor = True
        ' 
        ' chkLevel2
        ' 
        chkLevel2.AutoSize = True
        chkLevel2.Location = New Point(14, 68)
        chkLevel2.Name = "chkLevel2"
        chkLevel2.Size = New Size(93, 24)
        chkLevel2.TabIndex = 1
        chkLevel2.Text = "Level 200"
        chkLevel2.UseVisualStyleBackColor = True
        ' 
        ' chkLevel1
        ' 
        chkLevel1.AutoSize = True
        chkLevel1.Location = New Point(14, 38)
        chkLevel1.Name = "chkLevel1"
        chkLevel1.Size = New Size(93, 24)
        chkLevel1.TabIndex = 0
        chkLevel1.Text = "Level 100"
        chkLevel1.UseVisualStyleBackColor = True
        ' 
        ' grbProgramme
        ' 
        grbProgramme.Controls.Add(rdbEngineering)
        grbProgramme.Controls.Add(rbdWebDesginning)
        grbProgramme.Controls.Add(rdbBscComputerScienece)
        grbProgramme.Controls.Add(rdbBIT)
        grbProgramme.Location = New Point(551, 271)
        grbProgramme.Name = "grbProgramme"
        grbProgramme.Size = New Size(250, 182)
        grbProgramme.TabIndex = 6
        grbProgramme.TabStop = False
        grbProgramme.Text = "Programme of Study"
        ' 
        ' rdbEngineering
        ' 
        rdbEngineering.AutoSize = True
        rdbEngineering.Location = New Point(20, 124)
        rdbEngineering.Name = "rdbEngineering"
        rdbEngineering.Size = New Size(138, 24)
        rdbEngineering.TabIndex = 7
        rdbEngineering.TabStop = True
        rdbEngineering.Text = "Bsc. Engineering"
        rdbEngineering.UseVisualStyleBackColor = True
        ' 
        ' rbdWebDesginning
        ' 
        rbdWebDesginning.AutoSize = True
        rbdWebDesginning.Location = New Point(20, 94)
        rbdWebDesginning.Name = "rbdWebDesginning"
        rbdWebDesginning.Size = New Size(131, 24)
        rbdWebDesginning.TabIndex = 2
        rbdWebDesginning.TabStop = True
        rbdWebDesginning.Text = "Web Designing"
        rbdWebDesginning.UseVisualStyleBackColor = True
        ' 
        ' rdbBscComputerScienece
        ' 
        rdbBscComputerScienece.AutoSize = True
        rdbBscComputerScienece.Location = New Point(20, 64)
        rdbBscComputerScienece.Name = "rdbBscComputerScienece"
        rdbBscComputerScienece.Size = New Size(179, 24)
        rdbBscComputerScienece.TabIndex = 1
        rdbBscComputerScienece.TabStop = True
        rdbBscComputerScienece.Text = "Bsc. Computer Science"
        rdbBscComputerScienece.UseVisualStyleBackColor = True
        ' 
        ' rdbBIT
        ' 
        rdbBIT.AutoSize = True
        rdbBIT.Location = New Point(20, 34)
        rdbBIT.Name = "rdbBIT"
        rdbBIT.Size = New Size(217, 24)
        rdbBIT.TabIndex = 0
        rdbBIT.TabStop = True
        rdbBIT.Text = "Bsc. Information Technology"
        rdbBIT.UseVisualStyleBackColor = True
        ' 
        ' grpGender
        ' 
        grpGender.Controls.Add(chkFemale)
        grpGender.Controls.Add(chkMale)
        grpGender.Location = New Point(905, 271)
        grpGender.Name = "grpGender"
        grpGender.Size = New Size(250, 125)
        grpGender.TabIndex = 7
        grpGender.TabStop = False
        grpGender.Text = "Gender"
        ' 
        ' chkFemale
        ' 
        chkFemale.AutoSize = True
        chkFemale.Location = New Point(24, 68)
        chkFemale.Name = "chkFemale"
        chkFemale.Size = New Size(79, 24)
        chkFemale.TabIndex = 1
        chkFemale.Text = "Female"
        chkFemale.UseVisualStyleBackColor = True
        ' 
        ' chkMale
        ' 
        chkMale.AutoSize = True
        chkMale.Location = New Point(24, 38)
        chkMale.Name = "chkMale"
        chkMale.Size = New Size(64, 24)
        chkMale.TabIndex = 0
        chkMale.Text = "Male"
        chkMale.UseVisualStyleBackColor = True
        ' 
        ' btnGetFees
        ' 
        btnGetFees.Location = New Point(354, 553)
        btnGetFees.Name = "btnGetFees"
        btnGetFees.Size = New Size(144, 29)
        btnGetFees.TabIndex = 8
        btnGetFees.Text = "Display Fees"
        btnGetFees.UseVisualStyleBackColor = True
        ' 
        ' btnReset
        ' 
        btnReset.Location = New Point(551, 553)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(94, 29)
        btnReset.TabIndex = 9
        btnReset.Text = "Resst"
        btnReset.UseVisualStyleBackColor = True
        ' 
        ' btnExist
        ' 
        btnExist.Location = New Point(684, 553)
        btnExist.Name = "btnExist"
        btnExist.Size = New Size(94, 29)
        btnExist.TabIndex = 10
        btnExist.Text = "Exist"
        btnExist.UseVisualStyleBackColor = True
        ' 
        ' txtDisplay
        ' 
        txtDisplay.Location = New Point(717, 108)
        txtDisplay.Multiline = True
        txtDisplay.Name = "txtDisplay"
        txtDisplay.ReadOnly = True
        txtDisplay.Size = New Size(276, 89)
        txtDisplay.TabIndex = 11
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1203, 607)
        Controls.Add(txtDisplay)
        Controls.Add(btnExist)
        Controls.Add(btnReset)
        Controls.Add(btnGetFees)
        Controls.Add(grpGender)
        Controls.Add(grbProgramme)
        Controls.Add(grpLevel)
        Controls.Add(txtIndexNumber)
        Controls.Add(txtFirstName)
        Controls.Add(lblIndexNumber)
        Controls.Add(lblFirstName)
        Controls.Add(txtGCTUfeescollectionapp)
        Name = "Form1"
        Text = "Form1"
        grpLevel.ResumeLayout(False)
        grpLevel.PerformLayout()
        grbProgramme.ResumeLayout(False)
        grbProgramme.PerformLayout()
        grpGender.ResumeLayout(False)
        grpGender.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtGCTUfeescollectionapp As Label
    Friend WithEvents lblFirstName As Label
    Friend WithEvents lblIndexNumber As Label
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents txtIndexNumber As TextBox
    Friend WithEvents grpLevel As GroupBox
    Friend WithEvents chkPhd As CheckBox
    Friend WithEvents chkLevel4 As CheckBox
    Friend WithEvents chkMasters As CheckBox
    Friend WithEvents chkLevel3 As CheckBox
    Friend WithEvents chkLevel2 As CheckBox
    Friend WithEvents chkLevel1 As CheckBox
    Friend WithEvents grbProgramme As GroupBox
    Friend WithEvents rdbEngineering As RadioButton
    Friend WithEvents rbdWebDesginning As RadioButton
    Friend WithEvents rdbBscComputerScienece As RadioButton
    Friend WithEvents rdbBIT As RadioButton
    Friend WithEvents grpGender As GroupBox
    Friend WithEvents chkFemale As CheckBox
    Friend WithEvents chkMale As CheckBox
    Friend WithEvents btnGetFees As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExist As Button
    Friend WithEvents txtDisplay As TextBox

End Class
