Imports System.ComponentModel

Public Class Form1
    Private Sub PeopleBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles PeopleBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PeopleBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Another_database_2DataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Another_database_2DataSet.People' table. You can move, or remove it, as needed.
        Me.PeopleTableAdapter.Fill(Me.Another_database_2DataSet.People)

    End Sub

    Private Sub PnameLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PtelLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PaddressLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PaddressTextBox_TextChanged(sender As Object, e As EventArgs) Handles PaddressTextBox.TextChanged

    End Sub

    Private Sub PnameTextBox_TextChanged(sender As Object, e As EventArgs) Handles PnameTextBox.TextChanged

    End Sub

    Private Sub PtelTextBox_TextChanged(sender As Object, e As EventArgs) Handles PtelTextBox.TextChanged

    End Sub

    Private Sub PageLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PageTextBox_TextChanged(sender As Object, e As EventArgs) Handles PageTextBox.TextChanged

    End Sub

    Private Sub PnoteLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PnoteTextBox_TextChanged(sender As Object, e As EventArgs) Handles PnoteTextBox.TextChanged

    End Sub

    Private Sub PcodeLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PcodeTextBox_TextChanged(sender As Object, e As EventArgs) Handles PcodeTextBox.TextChanged

    End Sub

    Private Sub PnameTextBox_Validating(sender As Object, e As CancelEventArgs) Handles PnameTextBox.Validating
        'check that the name is not null and aslo greater tahn 10
        If PnameTextBox.Text = "" Then
            e.Cancel = True
            ErrorProvider1.SetError(PnameTextBox, "not null value allowed")
        End If
        If PnameTextBox.Text.Length < 10 Then
            e.Cancel = True
            ErrorProvider1.SetError(PnameTextBox, "character must be more than 10")
        End If
    End Sub

    Private Sub PaddressTextBox_Validating(sender As Object, e As CancelEventArgs) Handles PaddressTextBox.Validating
        'address should not be null
        If PaddressTextBox.Text = "" Then
            e.Cancel = True
            ErrorProvider1.SetError(PaddressTextBox, "Please enter your address")
        End If
    End Sub

    Private Sub PageTextBox_Validating(sender As Object, e As CancelEventArgs) Handles PageTextBox.Validating
        Try
            Dim I As Integer
            I = Integer.Parse(PageTextBox.Text)
            If I <= 0 Then
                Err.Raise(1)
            End If
        Catch ex As Exception
            e.Cancel = True
            ErrorProvider1.SetError(PageTextBox, "Psotive number expected")
        End Try
    End Sub

    Private Sub PcodeTextBox_Validating(sender As Object, e As CancelEventArgs) Handles PcodeTextBox.Validating
        If PcodeTextBox.Text.Length <= 5 Then
            ErrorProvider1.SetError(PcodeTextBox, "Please enter number greater tahn 5")
        End If
    End Sub

    Private Sub PnoteTextBox_Validating(sender As Object, e As CancelEventArgs) Handles PnoteTextBox.Validating
        'address should not be null
        If PaddressTextBox.Text = "" Then
            e.Cancel = True
            ErrorProvider1.SetError(PaddressTextBox, "Please enter your address")
        End If
    End Sub

    Private Sub PtelTextBox_Validating(sender As Object, e As CancelEventArgs) Handles PtelTextBox.Validating
        'address should not be null
        If PtelTextBox.Text = "" Then
            e.Cancel = True
            ErrorProvider1.SetError(PaddressTextBox, "Please enter your address")
        End If
    End Sub
End Class
