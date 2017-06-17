Public Class frmTrip
    Dim frmChoose As New frmChooseAList
    Dim list As Liste

    Private Sub btnPickList_Click(sender As Object, e As EventArgs) Handles btnPickList.Click
        If frmMobile.lists.Count > 0 Then
            frmChoose.Visible = True
            AddHandler frmChoose.btnOk.Click, AddressOf closedChoose
        Else
            MessageBox.Show(Me, "You got no lists stored in the application", "No lists")
        End If
    End Sub

    Private Sub closedChoose()
        If frmChoose.Answer = 1 Then
            list = frmChoose.list
            list.Trip = New Trip(dtTrip.Value, txtSearch.Text)
            frmMobile.updateListes(list)
            Dim home = New frmMain()
            MessageBox.Show(Me, "Trip planned !", "Trip planned")
            frmMobile.changeContentForm(home)
        End If
    End Sub

    Private Sub btnCreateList_Click(sender As Object, e As EventArgs) Handles btnCreateList.Click
        Dim response = InputBox("Name your list", "New List", "")
        If response = "" Then
        Else
            list = New Liste(response, New Trip(dtTrip.Value, txtSearch.Text))
            Dim frmNewList As New frmNewList(list)
            frmMobile.changeContentForm(frmNewList)
        End If
    End Sub

    Private Sub lblButton_Click(sender As Object, e As EventArgs) Handles lblButton.Click
        MessageBox.Show(Me, "Not implemented", "Not implemented")
    End Sub
End Class