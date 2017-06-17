Public Class frmMain
    Dim visibleLocation As New Point(12, 12)


    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        pnlLists.Location = visibleLocation
        pnlNoList.Location = visibleLocation

        AddHandler btnNewListe.Click, AddressOf frmMenu.lblNew_Click

        If frmMobile.lists.Count > 0 Then
            pnlLists.Enabled = True
            pnlLists.Visible = True
            lblNbLists.Text = "Hello, " + vbCrLf + "You have " + frmMobile.lists.Count.ToString() + " lists"
            loadLists()
        Else
            pnlNoList.Enabled = True
            pnlNoList.Visible = True
        End If

    End Sub

    Public Sub loadLists()
        twLists.Nodes.Clear()
        twLists.Nodes.Add("Lists")
        For Each list In frmMobile.lists
            Dim ndList = Liste.listeToTreenode(list)
            twLists.Nodes(0).Nodes.Add(ndList)
        Next
        twLists.Nodes(0).Expand()
    End Sub


    Private Sub twLists_BeforeSelect(ByVal sender As Object, ByVal e As TreeViewCancelEventArgs) Handles twLists.BeforeSelect
        If e.Node.Level > 1 Then
            e.Cancel = True
            Me.BeginInvoke(New Action(Of TreeNode)(AddressOf SelectNode), e.Node.Parent)
        ElseIf e.Node.Level < 1 Then
            e.Cancel = True
        End If
    End Sub

    Private Sub SelectNode(ByVal node As TreeNode)
        node.TreeView.SelectedNode = node
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Dim edit As String = Nothing
        Try
            edit = twLists.SelectedNode.Name
        Catch ex As Exception

        End Try
        If edit IsNot Nothing Then
            Dim list = frmMobile.getList(edit)
            Dim frmBrowse = New frmBrowse(list)
            frmMobile.changeContentForm(frmBrowse, frmBrowse.Text)
        End If

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim edit As String = Nothing
        Try
            edit = twLists.SelectedNode.Name
        Catch ex As Exception

        End Try
        If edit IsNot Nothing Then
            frmMobile.deleteListe(edit)
            twLists.SelectedNode.Remove()
            If frmMobile.lists.Count <= 0 Then
                pnlLists.Enabled = False
                pnlLists.Visible = False
                pnlNoList.Enabled = True
                pnlNoList.Visible = True
            End If
        End If
    End Sub

    Private Sub btnCheckout_Click(sender As Object, e As EventArgs) Handles btnCheckout.Click
        Dim edit As String = Nothing
        Try
            edit = twLists.SelectedNode.Name
        Catch ex As Exception

        End Try
        If edit IsNot Nothing Then
            Dim list = frmMobile.getList(edit)
            Dim frmRecap As New frmRecap(list)
            frmMobile.changeContentForm(frmRecap, frmRecap.Text)
        End If

    End Sub
End Class