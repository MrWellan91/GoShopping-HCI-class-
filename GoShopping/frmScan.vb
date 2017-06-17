Public Class frmScan
    Dim list As Liste
    Dim defList As Liste = frmMobile.defaultList
    Dim item As New Item
    Dim cat As String
    Private Sub frmScan_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Public Sub New(ByRef list As Liste)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.list = list
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If txtSearch.Text.Count > 0 Then
            item = defList.getItemId(Integer.Parse(txtSearch.Text), cat)
            lblItemData.Text = item.ItemName
        End If

    End Sub

    Private Sub btnDetails_Click(sender As Object, e As EventArgs) Handles btnDetails.Click
        MessageBox.Show(Me, "Name: " + item.ItemName + vbCrLf + "ID: " + item.ItemId.ToString + vbCrLf + "Price: " + item.Price.ToString + " €", item.ItemName)
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If cat.Count > 0 Then
            Dim words = cat.Split(New Char() {"\"c})
            Dim c1 = list.getCategory(words.Last)
            Dim c2 = c1.getCategory(words.First)
            list.addItem(c2, item)
            MessageBox.Show(Me, item.ItemName + " added", "Item added")
            frmMobile.updateListes(list)
        End If

    End Sub
End Class