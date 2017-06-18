Public Class frmBrowse
    Dim defListe As Liste = frmMobile.defaultList
    Dim list As Liste

    Public Sub New(ByVal list As Liste)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.list = list
    End Sub

    Private Sub frmBrowse_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        twShop.Nodes.Add(Liste.listeToTreenode(defListe))
        twCart.Nodes.Add(Liste.listeToTreenode(list))

        twShop.ExpandAll()
        twCart.ExpandAll()
    End Sub

    Private Sub getParentNode(ByVal node As TreeNode, ByRef path As String)

        If node.Parent IsNot Nothing Then

            path = IO.Path.Combine(node.Name, path)    ' Parent\Child 

            If node.Parent.Level = 0 Then Exit Sub

            'Call again the method to check if can extract more info
            getParentNode(node.Parent, path)

        End If

    End Sub

    Private Sub twShop_NodeDoubleClick(sender As Object, e As TreeNodeMouseClickEventArgs) Handles twShop.NodeMouseDoubleClick
        Dim path As String = ""

        getParentNode(e.Node, path)

        Dim words = path.Split(New Char() {"\"c}).ToList()
        words.RemoveAt(words.Count() - 1)

        If e.Node.Name <> defListe.ListName Then
            Dim cate = defListe.getCategory(words.First)
            Dim cate2 = Category.getRecuCategory(words.Last, cate)
            Dim item = cate2.getItem(e.Node.Name)


            cate = list.getCategory(words.First)
            cate2 = Category.getRecuCategory(words.Last, cate)

            list.addItem(cate2, item)
            twCart.Nodes.Clear()
            twCart.Nodes.Add(Liste.listeToTreenode(list))
            twCart.ExpandAll()
        End If

    End Sub

    Private Sub twCart_NodeDoubleClick(sender As Object, e As TreeNodeMouseClickEventArgs) Handles twCart.NodeMouseDoubleClick
        Dim path As String = ""

        getParentNode(e.Node, path)

        Dim words = path.Split(New Char() {"\"c}).ToList()
        words.RemoveAt(words.Count() - 1)

        If e.Node.Name <> list.ListName And list.getCategory(e.Node.Name) Is Nothing Then
            Dim cate = defListe.getCategory(words.First)
            Dim getCate = Category.getRecuCategory(words.Last, cate)
            If getCate IsNot Nothing And getCate.CategoryName <> "Empty Category" Then
                Dim cate2 = Category.getRecuCategory(words.Last, cate)
                Dim item = cate2.getItem(e.Node.Name)

                cate = list.getCategory(words.First)
                cate2 = Category.getRecuCategory(words.Last, cate)

                cate2.removeItem(item)
                twCart.Nodes.Clear()
                twCart.Nodes.Add(Liste.listeToTreenode(list))
                twCart.ExpandAll()
            End If
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Dim msg = MessageBox.Show(Me, "Do you really want to cancel your list ?", "Cancelling ?", MessageBoxButtons.YesNo)
        If msg = DialogResult.Yes Then
            frmMobile.changeContentForm(frmMain)
            Dispose()
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        frmMobile.updateListes(list)
        Dim frmMain As New frmMain
        frmMobile.changeContentForm(frmMain)
    End Sub
End Class