Public Class frmMobile
    Dim actualContentForm As Form
    Dim frmMenu As New frmMenu()

    Private Sub lblHambIcon_Click(sender As Object, e As EventArgs) Handles lblHambIcon.Click
        If Not frmMenu.Visible Then
            changeContentForm(frmMenu)
        Else
            'A remplacer avec le frm du Main Menu
            frmMenu.Visible = False
        End If
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
        pnlContent.Controls.Add(frmC)
        If actualContentForm IsNot Nothing Then
            actualContentForm.Visible = False
        End If
        actualContentForm = frmC
        actualContentForm.Visible = True
    End Sub
End Class