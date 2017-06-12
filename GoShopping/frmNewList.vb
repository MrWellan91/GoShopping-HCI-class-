Public Class frmNewList

    Dim frmName As String


    Public Sub setName(ByVal name As String)
        frmMobile.setName(name)
        frmName = name
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        frmMobile.changeContentForm(New frmBrowse(), "Browse Products")
    End Sub
End Class