Public Class frmNewList
    Dim list As Liste

    Public Sub New(ByVal name As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        list = New Liste(name)
        Me.Text = name
        frmMobile.AddListe(list)
        AddHandler btnScan.Click, AddressOf frmMenu.lblScan_Click
    End Sub

    Public Sub New(ByVal list As Liste)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.list = list
        Me.Text = list.ListName
        frmMobile.AddListe(list)
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click

        Dim frmBrowse = New frmBrowse(list)
        frmMobile.changeContentForm(frmBrowse)
        Dispose()
    End Sub
End Class