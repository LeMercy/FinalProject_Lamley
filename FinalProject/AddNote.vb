Public Class AddNote
    Public userTitle As String = txtTitle.Text
    Private Sub ToolStripTextBox1_Change(sender As Object, e As EventArgs) Handles txtTitle.TextChanged
        Me.Text = txtTitle.Text
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        MessageBox.Show("Are you sure you want to clear the text?", "Clear", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If MsgBoxResult.Yes Then
            txtText.Text = ""
            btnClear.Enabled = False
            Return
        ElseIf MsgBoxResult.No Then
            Return
        End If
    End Sub

    Private Sub txtText_TextChanged(sender As Object, e As EventArgs) Handles txtText.TextChanged
        If txtText.Text.Length > 0 Then
            btnClear.Enabled = True
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        MessageBox.Show("Would you like to save your current progress?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If MsgBoxResult.Yes Then
            SaveNote()
            txtText.Text = ""
            Me.Close()
        Else
            DeleteNote()
            txtText.Text = ""
            Me.Close()
        End If
    End Sub

    Public Function GetTitle()
        Return userTitle
    End Function

    Private Sub txtTitle_Change(sender As Object, e As EventArgs) Handles txtTitle.TextChanged
        userTitle = txtTitle.Text
    End Sub
End Class