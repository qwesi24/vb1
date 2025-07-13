Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Group_F_databaseDataSet.EMPLOYEE' table. You can move, or remove it, as needed.
        Me.EMPLOYEETableAdapter.Fill(Me.Group_F_databaseDataSet.EMPLOYEE)
        'TODO: This line of code loads data into the 'Group_F_databaseDataSet.Department' table. You can move, or remove it, as needed.
        Me.DepartmentTableAdapter.Fill(Me.Group_F_databaseDataSet.Department)

    End Sub
End Class
