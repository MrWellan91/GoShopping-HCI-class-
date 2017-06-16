Public Class frmBrowse
    Private Sub frmBrowse_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        twShop.Nodes.Add(Liste.listeToTreenode(Liste.jsonToListe(My.Resources.marketList)))
    End Sub
End Class