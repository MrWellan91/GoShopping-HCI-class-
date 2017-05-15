Public Class frmMobile
    Dim actualContentForm As Form
    Dim frmMenu As New frmMenu()

    Private Sub lblHambIcon_Click(sender As Object, e As EventArgs) Handles lblHambIcon.Click
        menu()
    End Sub

    ''' <summary>
    ''' Permet de changer le contenu du panel loader par le frm de votre choix
    ''' </summary>
    ''' <param name="frmC">frm que l'on veut Load</param>
    Public Sub changeContentForm(ByRef frmC As Form)
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

        actualContentForm = frmC
        actualContentForm.Visible = True
    End Sub

    Public Shadows Sub menu()
        frmMenu.Visible = Not frmMenu.Visible
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