﻿Public Class frmStartUp
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
        txtUserName.Text = ""
        Me.Visible = False
        Home.ShowDialog()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click
        txtUserName.Copy()
    End Sub

    Private Sub CutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CutToolStripMenuItem.Click
        txtUserName.Cut()
    End Sub

    Private Sub PasteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasteToolStripMenuItem.Click
        txtUserName.Paste()
    End Sub

End Class
