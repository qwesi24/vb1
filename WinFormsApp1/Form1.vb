Public Class Form1
    Private Sub btnExist_Click(sender As Object, e As EventArgs) Handles btnExist.Click
        End
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtDisplay.Clear()
        txtFirstName.Clear()
        txtIndexNumber.Clear()
        rdbBscComputerScienece.Checked = False
        rdbBIT.Checked = False
        rbdWebDesginning.Checked = False
        rdbEngineering.Checked = False
        chkFemale.Checked = False
        chkMale.Checked = False
        chkLevel4.Checked = False
        chkLevel2.Checked = False
        chkLevel3.Checked = False
        chkLevel4.Checked = False
        chkMasters.Checked = False
        chkPhd.Checked = False
    End Sub

    Private Sub btnGetFees_Click(sender As Object, e As EventArgs) Handles btnGetFees.Click
        'declare variables'
        Dim name, indexnumber
        name = txtFirstName.Text.Trim.ToUpper
        indexnumber = txtIndexNumber.Text



        Dim fees As Integer
        Dim level As String = String.Empty

        ' Set fees based on level
        If chkLevel1.Checked Then
            level = "Level100"
            fees = 1000
        ElseIf chkLevel2.Checked Then
            level = "Level200"
            fees = 1200
        ElseIf chkLevel3.Checked Then
            level = "Level300"
            fees = 1500
        ElseIf chkLevel4.Checked Then
            level = "Level400"
            fees = 1800
        Else
            fees = 0 ' Default case if no level is selected
        End If


        ' Determine gender
        Dim sex As String = If(chkMale.Checked, "Male", If(chkFemale.Checked, "Female", String.Empty))

        ' Adjust fees based on gender
        If sex = "Female" Then
            fees -= 200 ' Discount for girls
        End If

        ' Display the fees
        txtDisplay.Text = "your school fees is: " & fees.ToString()
    End Sub
End Class
