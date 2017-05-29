Public Class frmMobile

    Dim actualContentForm As Form
    Dim frmName = "GoShopping"
    Dim frmMenu As New frmMenu()
    Dim actualName = "GoShopping"

    Private Sub lblHambIcon_Click(sender As Object, e As EventArgs) Handles lblHambIcon.Click
        menu()

    End Sub

    ''' <summary>
    ''' Permet de changer le contenu du panel loader par le frm de votre choix
    ''' </summary>
    ''' <param name="frmC">frm que l'on veut Load</param>
    Public Sub changeContentForm(ByVal frmC As Form, name As String)
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
        actualName = name
        setName(name)
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
    End Sub
End Class