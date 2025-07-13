Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Gctu300DataSet.Purpese' table. You can move, or remove it, as needed.
        Me.PurpeseTableAdapter.Fill(Me.Gctu300DataSet.Purpese)

    End Sub
End Class
