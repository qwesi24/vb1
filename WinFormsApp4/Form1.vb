Public Class Form1
    Private Sub btnExist_Click(sender As Object, e As EventArgs) Handles btnExist.Click
        End
    End Sub

    Private Sub btnCal_Click(sender As Object, e As EventArgs) Handles btnCal.Click
        ' Declare constant growth rate
        Const dblGROWTH_RATE As Double = 0.03

        ' Declare variables
        Dim dblSales As Double
        Dim dblIncrease As Double
        Dim intYears As Integer

        ' Convert text box value to a number and store in dblSales
        dblSales = CDbl(txtCurrentSales.Text)

        ' Repeat while sales are less than $150,000
        Do While dblSales < 150000
            ' Calculate the increase in sales
            dblIncrease = dblSales * dblGROWTH_RATE

            ' Add the increase to the sales
            dblSales += dblIncrease

            ' Increment the year counter
            intYears += 1
        Loop

        ' Display the years and projected sales in the label
        lblProjSales.Text = "Years: " & intYears & " Projected Sales: " & dblSales.ToString("C")

    End Sub
End Class
