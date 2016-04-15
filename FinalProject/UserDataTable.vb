Public Class UserDataTable
    Private Sub UserDataTable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'NotesDataSet.Table' table. You can move, or remove it, as needed.
        Me.TableTableAdapter.Fill(Me.NotesDataSet.Table)

    End Sub

    Private Sub dgvData_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvData.CellContentClick

    End Sub
End Class