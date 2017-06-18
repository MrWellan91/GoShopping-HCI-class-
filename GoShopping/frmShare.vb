Imports System.IO

Public Class frmShare
    Dim list As Liste
    Dim genState As Boolean = False
    Public Sub loadLists()
        twLists.Nodes.Clear()
        twLists.Nodes.Add("Lists")
        For Each list In frmMobile.lists
            Dim ndList = Liste.listeToTreenode(list)
            twLists.Nodes(0).Nodes.Add(ndList)
        Next
        twLists.Nodes(0).Expand()
    End Sub

    Private Sub frmShare_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadLists()
        AddHandler pctBluetooth.Click, AddressOf pctBox_Click
        AddHandler pctFb.Click, AddressOf pctBox_Click
        AddHandler pctTwitter.Click, AddressOf pctBox_Click
        AddHandler pctGoogleP.Click, AddressOf pctBox_Click
        AddHandler pctWhatsapp.Click, AddressOf pctBox_Click

    End Sub

    Private Sub twLists_BeforeSelect(ByVal sender As Object, ByVal e As TreeViewCancelEventArgs) Handles twLists.BeforeSelect
        If e.Node.Level > 1 Then
            e.Cancel = True
            Me.BeginInvoke(New Action(Of TreeNode)(AddressOf SelectNode), e.Node.Parent)
        ElseIf e.Node.Level < 1 Then
            e.Cancel = True
        Else
            If Not genState Then
                genState = True
                changeControlsState(genState)
            End If
        End If
    End Sub

    Private Sub SelectNode(ByVal node As TreeNode)
        node.TreeView.SelectedNode = node
        If Not genState Then
            genState = True
            changeControlsState(genState)
        End If
    End Sub

    Public Sub changeControlsState(ByVal state As Boolean)

        btnShare.Enabled = state
        pctFb.Enabled = state
        pctTwitter.Enabled = state
        pctGoogleP.Enabled = state
        pctFile.Enabled = state
        pctWhatsapp.Enabled = state
        pctBluetooth.Enabled = state
    End Sub

    Private Sub pctFile_Click(sender As Object, e As EventArgs) Handles pctFile.Click
        list = frmMobile.getList(twLists.SelectedNode.Name)
        Dim l = list.listeToJson()
        Dim saveFileDialog As New SaveFileDialog()
        saveFileDialog.Filter = "JSonlist|*.json|TextList|*.txt"
        saveFileDialog.Title = "Save your list"
        saveFileDialog.ShowDialog()

        If saveFileDialog.FileName <> "" Then
            Dim objWriter As New StreamWriter(saveFileDialog.FileName)
            objWriter.WriteLine(l)
            objWriter.Close()

        End If
    End Sub

    Private Sub pctBox_Click(sender As Object, e As EventArgs)
        MessageBox.Show(Me, "Not implemented yet", "Not Implemented")
    End Sub

    Private Sub btnShare_Click(sender As Object, e As EventArgs) Handles btnShare.Click
        Dim frmShareFriend = New frmShareFriends
        frmShareFriend.Show()
    End Sub
End Class