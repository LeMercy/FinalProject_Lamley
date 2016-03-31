Public Class frmStartUp
    Private userName As String
    Private Sub txtUserName_TextChanged(sender As Object, e As EventArgs) Handles txtUserName.TextChanged
        If IsNumeric(txtUserName.Text) Then
            btnStart.Enabled = False
        ElseIf txtUserName.Text.Length = 0
            btnStart.Enabled = False
        Else
            btnStart.Enabled = True
        End If
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        userName = txtUserName.Text
        Me.Visible = False
        Home.ShowDialog()
    End Sub

End Class
