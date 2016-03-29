Public Class frmStartUp
    Private Sub txtUserName_TextChanged(sender As Object, e As EventArgs) Handles txtUserName.TextChanged
        If IsNumeric(txtUserName.Text) Then
            btnStart.Enabled = False
        ElseIf txtUserName.Text.Length = 0
            btnStart.Enabled = False
        Else
            btnStart.Enabled = True
        End If
    End Sub
End Class
