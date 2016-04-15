Module CustomView
    Public Sub ViewAll()

    End Sub

    Public Sub Sortby()

    End Sub

    Public Sub ChangeView()
        If Home.radFour.Checked Then
            'All buttons
            Home.btnS10N1.Visible = False
            Home.btnS10N2.Visible = False
            Home.btnS10N3.Visible = False
            Home.btnS10N4.Visible = False
            Home.btnS10N5.Visible = False
            Home.btnS10N6.Visible = False
            Home.btnS10N7.Visible = False
            Home.btnS10N8.Visible = False
            Home.btnS10N9.Visible = False
            Home.btnS10N10.Visible = False

            Home.btnS8A1.Visible = False
            Home.btnS8A2.Visible = False
            Home.btnS8A3.Visible = False
            Home.btnS8A4.Visible = False
            Home.btnS8A5.Visible = False
            Home.btnS8A6.Visible = False
            Home.btnS8A7.Visible = False
            Home.btnS8A8.Visible = False

            Home.btnS4N1.Visible = True
            Home.btnS4N2.Visible = True
            Home.btnS4N3.Visible = True
            Home.btnS4N4.Visible = True

        ElseIf Home.radEight.Checked Then
            'All buttons
            Home.btnS10N1.Visible = False
            Home.btnS10N2.Visible = False
            Home.btnS10N3.Visible = False
            Home.btnS10N4.Visible = False
            Home.btnS10N5.Visible = False
            Home.btnS10N6.Visible = False
            Home.btnS10N7.Visible = False
            Home.btnS10N8.Visible = False
            Home.btnS10N9.Visible = False
            Home.btnS10N10.Visible = False

            Home.btnS8A1.Visible = True
            Home.btnS8A2.Visible = True
            Home.btnS8A3.Visible = True
            Home.btnS8A4.Visible = True
            Home.btnS8A5.Visible = True
            Home.btnS8A6.Visible = True
            Home.btnS8A7.Visible = True
            Home.btnS8A8.Visible = True

            Home.btnS4N1.Visible = False
            Home.btnS4N2.Visible = False
            Home.btnS4N3.Visible = False
            Home.btnS4N4.Visible = False

        ElseIf Home.radTen.Checked Then
            'All buttons
            Home.btnS10N1.Visible = True
            Home.btnS10N2.Visible = True
            Home.btnS10N3.Visible = True
            Home.btnS10N4.Visible = True
            Home.btnS10N5.Visible = True
            Home.btnS10N6.Visible = True
            Home.btnS10N7.Visible = True
            Home.btnS10N8.Visible = True
            Home.btnS10N9.Visible = True
            Home.btnS10N10.Visible = True

            Home.btnS8A1.Visible = False
            Home.btnS8A2.Visible = False
            Home.btnS8A3.Visible = False
            Home.btnS8A4.Visible = False
            Home.btnS8A5.Visible = False
            Home.btnS8A6.Visible = False
            Home.btnS8A7.Visible = False
            Home.btnS8A8.Visible = False

            Home.btnS4N1.Visible = False
            Home.btnS4N3.Visible = False
            Home.btnS4N4.Visible = False
        End If
    End Sub

    Public Sub CheckNumberofNotes()
        If GetNumberofNotes() > 3 Then
            Home.radFour.Enabled = True
        ElseIf GetNumberofNotes() > 7 Then
            Home.radEight.Enabled = True
        ElseIf GetNumberofNotes() > 9 Then
            Home.radTen.Enabled = True

        End If
    End Sub
End Module
