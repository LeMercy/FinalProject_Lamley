Module NewNote
    Private NumberOfNotes As Integer = 0
    Private NewId As Integer = 1
    Public Sub AddNote()
        NumberOfNotes += 1

    End Sub

    Public Sub DeleteNote()
        'Tutorial 5-13
    End Sub

    Public Sub OpenNote()
        'Tutorial 5-12
    End Sub

    Public Sub SaveNote()

    End Sub

    Public Sub NoteCancelled()
        NumberOfNotes -= 1
    End Sub

    Public Function GetNumberofNotes()
        Return NumberOfNotes
    End Function

    Public Function CreateID()
        'Goes through database and checks to see if current ID is taken
        'If its taken then it'll add one to the ID and check again until it finds an Id that is not taken
        Return NewId
    End Function

End Module
