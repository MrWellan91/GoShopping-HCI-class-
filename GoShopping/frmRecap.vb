Public Class frmRecap
    Dim list As Liste

    Public Sub New(ByVal list As Liste)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.list = list
        lblList.Text = lblList.Text + list.ListName
        twList.Nodes.Add(Liste.listeToTreenode(list))
        twList.ExpandAll()

        lblNb.Text = lblNb.Text + list.getNbItem().ToString()

    End Sub

    Private Sub btnCheckout_Click(sender As Object, e As EventArgs) Handles btnCheckout.Click
        Dim frmCheckChoice As New frmCheckoutChoice(list)
        frmMobile.changeContentForm(frmCheckChoice)
    End Sub
End Class