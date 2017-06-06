Public Class frmMenu

    Public frmName As String = "Menu"

    Sub lblNew_Click(sender As Object, e As EventArgs) Handles lblNew.Click
        Dim response = InputBox("Name your list", "New List", "")
        If response = "" Then
        Else
            Dim newList = New frmNewList
            newList.setName(response)
            frmMobile.changeContentForm(newList, response)
        End If
    End Sub

    Private Sub lblOpen_Click(sender As Object, e As EventArgs) Handles lblOpen.Click
        Dim openList = New frmOpen
        frmMobile.changeContentForm(openList, "Open a List")
    End Sub
End Class