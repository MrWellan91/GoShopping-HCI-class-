Public Class frmShareFriends
    Private Sub txtSearch_Click(sender As Object, e As EventArgs) Handles txtSearch.Click
        txtSearch.Text = ""
    End Sub

    Private Sub btnShare_Click(sender As Object, e As EventArgs) Handles btnShare.Click
        Dim msg = MessageBox.Show(Me, "Your list has been sent to your friend !" + vbCrLf + "(Not really, it's not implemented yet)", "Shared !")
        If msg Then
            Dispose()
        End If
    End Sub
End Class