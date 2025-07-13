Imports System.Data.OleDb
Imports System.Windows.Forms.PropertyGridInternal

Public Class Form1
    Private Sub btnOpenConnection_Click(sender As Object, e As EventArgs) Handles btnOpenConnection.Click
        ' Define Connection Object
        Dim Connection As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\User\Desktop\Assignment\Advance VB assignment\Test database.accdb")

        ' Open connection to the database
        Connection.Open()

        ' This is my query
        Dim command As New OleDb.OleDbCommand("SELECT * FROM [NNM]", Connection)

        Dim readers = command.ExecuteReader()

        Do While readers.Read
            MsgBox(readers.GetValue(0).ToString())
        Loop

        readers.Close()
        command.Dispose()

        ' Close connection
        Connection.Close()
    End Sub

End Class
