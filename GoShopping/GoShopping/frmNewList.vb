Public Class frmNewList

    Dim frmName As String


    Public Sub setName(ByVal name As String)
        frmMobile.setName(name)
        frmName = name
        lblListName.Text = name
    End Sub


End Class