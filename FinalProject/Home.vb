Public Class Home

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
        frmStartUp.ShowDialog()
    End Sub

    Private Sub Home_Load(sender As Object, e As EventArgs) Handles Me.Load
        CheckNumberofNotes()
    End Sub

    Private Sub radTen_CheckedChanged(sender As Object, e As EventArgs) Handles radTen.CheckedChanged
        CustomView.ChangeView()
    End Sub

    Private Sub radEight_CheckedChanged(sender As Object, e As EventArgs) Handles radEight.CheckedChanged
        CustomView.ChangeView()
    End Sub

    Private Sub radFour_CheckedChanged(sender As Object, e As EventArgs) Handles radFour.CheckedChanged
        CustomView.ChangeView()
    End Sub

    Private Sub Add()
        'Checks to see which buttons have been modified and will find an unmodified button on the page to fill
        'Will make next page if all buttons are taken
        If radFour.Checked Then
            If Not btnS4N1.BackColor = Color.White Then
                btnS4N1.BackColor = Color.White
                btnS4N1.Text = AddNote.GetTitle
                Return
            ElseIf Not btnS4N2.BackColor = Color.White Then
                btnS4N2.BackColor = Color.White
                btnS4N2.Text = AddNote.GetTitle
                Return
            ElseIf Not btnS4N3.BackColor = Color.White Then
                btnS4N3.BackColor = Color.White
                btnS4N3.Text = AddNote.GetTitle
                Return
            ElseIf Not btnS4N4.BackColor = Color.White Then
                btnS4N4.BackColor = Color.White
                btnS4N4.Text = AddNote.GetTitle
                Return
            Else
                'Adds another page
            End If
        ElseIf radEight.Checked Then
            If Not btnS8A1.BackColor = Color.White Then
                btnS8A1.BackColor = Color.White
                btnS8A1.Text = AddNote.GetTitle
                Return
            ElseIf Not btnS8A2.BackColor = Color.White Then
                btnS8A2.BackColor = Color.White
                btnS8A2.Text = AddNote.GetTitle
                Return
            ElseIf Not btnS8A3.BackColor = Color.White Then
                btnS8A3.BackColor = Color.White
                btnS8A3.Text = AddNote.GetTitle
                Return
            ElseIf Not btnS8A4.BackColor = Color.White Then
                btnS8A4.BackColor = Color.White
                btnS8A4.Text = AddNote.GetTitle
                Return
            ElseIf Not btnS8A5.BackColor = Color.White Then
                btnS8A5.BackColor = Color.White
                btnS8A5.Text = AddNote.GetTitle
                Return
            ElseIf Not btnS8A6.BackColor = Color.White Then
                btnS8A6.BackColor = Color.White
                btnS8A6.Text = AddNote.GetTitle
                Return
            ElseIf Not btnS8A7.BackColor = Color.White Then
                btnS8A7.BackColor = Color.White
                btnS8A7.Text = AddNote.GetTitle
                Return
            ElseIf Not btnS8A8.BackColor = Color.White Then
                btnS8A8.BackColor = Color.White
                btnS8A8.Text = AddNote.GetTitle
                Return
            Else
                'adds another page
            End If
        End If


    End Sub


    'Use size 190, 275 for Sort by 4
    'Use size 125, 159 for Sort by 8 & 10
End Class