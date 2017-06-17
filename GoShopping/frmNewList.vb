Public Class frmNewList
    Dim list As Liste

    Public Sub New(ByVal name As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        list = New Liste(name)
        Me.Text = name
        frmMobile.AddListe(list)
    End Sub


    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click

        Dim frmBrowse = New frmBrowse(list)
        frmMobile.changeContentForm(frmBrowse, frmBrowse.Text)
        Dispose()
    End Sub

    Private Sub btnScan_Click(sender As Object, e As EventArgs) Handles btnScan.Click
        frmMobile.AddListe(list)
        Dim frmScan = New frmScan(list)
        frmMobile.changeContentForm(frmScan, frmScan.Text)
        Dispose()
    End Sub
End Class