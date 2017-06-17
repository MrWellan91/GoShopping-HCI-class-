Public Class frmChooseAList
    Public list As New Liste
    Public Answer As Integer = 0 'If 1 answer is Ok, if 0 answer is cancer
    Public cmbSelect As String

    Private Sub frmChooseAList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each l In frmMobile.lists
            cmbLists.Items.Add(l.ListName)
        Next
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        Answer = 1
        list = frmMobile.lists.Find(Function(x) x.ListName = cmbLists.Text)
        Me.Visible = False
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Answer = 0
        Me.Visible = False
    End Sub
End Class