Public Class frmMobile

    Dim actualContentForm As Form
    Dim frmName = "GoShopping"
    Dim frmMenu As New frmMenu()
    Dim actualName = "GoShopping"
    Public Shared lists As New List(Of Liste)
    Public Shared defaultList = Liste.jsonToListe(My.Resources.marketList)

    Private Sub lblHambIcon_Click(sender As Object, e As EventArgs) Handles lblHambIcon.Click
        menu()

    End Sub

    ''' <summary>
    ''' Permet de changer le contenu du panel loader par le frm de votre choix
    ''' </summary>
    ''' <param name="frmC">frm que l'on veut Load</param>
    Public Sub changeContentForm(ByVal frmC As Form)
        frmC.TopLevel = False
        frmC.FormBorderStyle = FormBorderStyle.None
        frmC.MdiParent = Me
        frmC.WindowState = FormWindowState.Normal
        frmC.Size = New Size(pnlContent.Size)

        If Not pnlContent.Controls.Contains(frmC) And actualContentForm IsNot frmC Then
            pnlContent.Controls.Add(frmC)
        End If

        If actualContentForm IsNot Nothing Then
            actualContentForm.Visible = False
        End If
        actualName = frmC.Text
        setName(frmC.Text)
        actualContentForm = frmC
        actualContentForm.Visible = True
        frmMenu.Visible = False
    End Sub

    Public Shadows Sub menu()
        If frmMenu.Visible Then
            frmMenu.Visible = False
            setName(actualName)
        Else
            frmMenu.Visible = True
            setName("Menu")
        End If
    End Sub

    Public Sub setName(ByVal name As String)
        lblTitle.Text = name
    End Sub

    Private Sub frmMobile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmMenu.TopLevel = False
        frmMenu.FormBorderStyle = FormBorderStyle.None
        frmMenu.MdiParent = Me
        frmMenu.WindowState = FormWindowState.Normal
        frmMenu.Size = New Size(pnlContent.Size)
        pnlContent.Controls.Add(frmMenu)
        frmMenu.Visible = False
        changeContentForm(New frmMain)

    End Sub

    Public Shared Sub AddListe(ByVal liste As Liste)
        Dim found = lists.Find(Function(x) x.ListName = liste.ListName)
        If found Is Nothing Then
            lists.Add(liste)
        End If
    End Sub

    Public Shared Sub updateListes(ByVal liste As Liste)
        Dim found = lists.FindIndex(Function(x) x.ListName = liste.ListName)
        If lists(found) IsNot Nothing Then
            lists(found) = liste
        End If
    End Sub

    Public Shared Function getList(ByVal name As String) As Liste
        Dim found = lists.FindIndex(Function(x) x.ListName = name)
        If lists(found) IsNot Nothing Then
            Return lists(found)
        End If
        Return Nothing
    End Function

    Public Shared Sub deleteListe(ByVal listName As String)
        Dim found = lists.FindIndex(Function(x) x.ListName = listName)
        If lists(found) IsNot Nothing Then
            lists.RemoveAt(found)
        End If
    End Sub
End Class