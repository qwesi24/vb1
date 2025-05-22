Imports System.Windows.Forms.Design

Public Class Form1
    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        If TextBox1.Modified Then
            Dim a As MsgBoxResult
            a = MsgBox("Do you want save changes", MsgBoxStyle.YesNoCancel, "New Document")
            If a = MsgBoxResult.No Then
                TextBox1.Clear()
            ElseIf a = MsgBoxResult.Cancel Then
            ElseIf a = MsgBoxResult.Yes Then
                SaveFileDialog1.ShowDialog()
                My.Computer.FileSystem.WriteAllText(SaveFileDialog1.FileName, TextBox1.Text, False)
                TextBox1.Clear()
            End If
        Else
            TextBox1.Clear()
        End If

    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        If TextBox1.Modified Then


            Dim ask As MsgBoxResult
            ask = MsgBox("Do you want to save the file", MsgBoxStyle.YesNoCancel, "upen Document")
            If ask = MsgBoxResult.No Then
                OpenFileDialog1.ShowDialog()
                TextBox1.Text = My.Computer.FileSystem.ReadAllText(OpenFileDialog1.FileName)
            ElseIf ask = MsgBoxResult.Cancel Then
            ElseIf ask = MsgBoxResult.Yes Then
                My.Computer.FileSystem.WriteAllText(SaveFileDialog1.FileName, TextBox1.Text, False)
                TextBox1.Clear()




            End If

        Else
            OpenFileDialog1.ShowDialog()
            Try
                TextBox1.Text = My.Computer.FileSystem.ReadAllText(OpenFileDialog1.FileName)
            Catch ex As Exception

            End Try

        End If
    End Sub

    Private Sub ExistToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExistToolStripMenuItem.Click
        SaveFileDialog1.ShowDialog()
        If My.Computer.FileSystem.FileExists(SaveFileDialog1.FileName) Then
            Dim ask As MsgBoxResult
            ask = MsgBox("File already Exists, would you like to replace it?", MsgBoxStyle.YesNoCancel, "File Exists")
            If ask = MsgBoxResult.No Then
                SaveFileDialog1.ShowDialog()
            ElseIf ask = MsgBoxResult.Yes Then
                My.Computer.FileSystem.WriteAllText(SaveFileDialog1.FileName, TextBox1.Text, False)
            End If
        Else
            Try
                My.Computer.FileSystem.WriteAllText(SaveFileDialog1.FileName, TextBox1.Text, False)
            Catch ex As Exception

            End Try
        End If



    End Sub

    Private Sub ExistToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ExistToolStripMenuItem2.Click
        End
    End Sub

    Private Sub UndoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UndoToolStripMenuItem.Click
        If TextBox1.CanUndo Then
            TextBox1.Undo()
        Else
        End If
    End Sub

    Private Sub RedoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RedoToolStripMenuItem.Click

    End Sub

    Private Sub CutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CutToolStripMenuItem.Click
        My.Computer.Clipboard.Clear()
        If TextBox1.SelectionLength > 0 Then
            My.Computer.Clipboard.SetText(TextBox1.SelectedText)



        End If
        TextBox1.SelectedText = ""
    End Sub

    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click
        My.Computer.Clipboard.Clear()
        If TextBox1.SelectionLength > 0 Then
            My.Computer.Clipboard.SetText(TextBox1.SelectedText)
        End If
    End Sub

    Private Sub PasteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasteToolStripMenuItem.Click
        My.Computer.Clipboard.Clear()
        If TextBox1.SelectionLength > 0 Then
            My.Computer.Clipboard.SetText(TextBox1.SelectedText)
        End If
    End Sub

    Private Sub FindToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FindToolStripMenuItem.Click
        Dim a As String
        Dim b As String
        a = InputBox("Enter text to be found")
        b = InStr(TextBox1.Text, a)
        If b Then
            TextBox1.Focus()
            TextBox1.SelectionStart = b - 1
            TextBox1.SelectionLength = Len(a)
        Else
            MsgBox("Text not found.")
        End If
    End Sub

    Private Sub FontToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FontToolStripMenuItem.Click
        FontDialog1.ShowDialog()
        TextBox1.Font = FontDialog1.Font
    End Sub

    Private Sub FontColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FontColorToolStripMenuItem.Click
        ColorDialog1.ShowDialog()
        TextBox1.ForeColor = ColorDialog1.Color
    End Sub

    Private Sub BackgroundColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackgroundColorToolStripMenuItem.Click
        ColorDialog1.ShowDialog()
        TextBox1.BackColor = ColorDialog1.Color
    End Sub

    Private Sub HelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem.Click
        MsgBox("Visual basic code")

    End Sub
End Class
