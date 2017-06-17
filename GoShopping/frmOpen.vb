Imports System.IO

Public Class frmOpen
    Dim openedList As Liste

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Private Sub twFiles_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles twFiles.AfterSelect
        'Oui
    End Sub

    Private Sub frmOpen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        openFile()
    End Sub

    Private Sub btnOpen_Click(sender As Object, e As EventArgs) Handles btnOpen.Click
        Dim frmBrowse As New frmBrowse(openedList)
        If openedList IsNot Nothing Then
            frmMobile.AddListe(openedList)
            frmMobile.changeContentForm(frmBrowse, frmBrowse.Text)
            Dispose()
        Else
            Dim msg = MessageBox.Show(Me, "No list has been loaded." + vbCrLf + "Do you want to create a new one ?", "No list", MessageBoxButtons.YesNo)
            If msg = DialogResult.Yes Then
                frmMenu.lblNew_Click(sender, e)
            End If
            Dispose()
        End If
    End Sub

    Public Sub openFile()
        Dim stream As Stream = Nothing
        msgFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
        msgFileDialog.Filter = "JSon list (*.json)|*.json|TextList (*.txt)|*.txt"
        msgFileDialog.FilterIndex = 1
        msgFileDialog.RestoreDirectory = True
        If msgFileDialog.ShowDialog() = DialogResult.OK Then
            Try
                stream = msgFileDialog.OpenFile()
                Dim reader As New StreamReader(stream)
                openedList = Liste.jsonToListe(reader.ReadToEnd())
                Dim nodeListe = Liste.listeToTreenode(openedList)
                nodeListe.ExpandAll()
                twFiles.Nodes.Add(nodeListe)
                txtListName.Text = openedList.ListName
                lblList.Text = openedList.ListName
            Catch ex As Exception
                MessageBox.Show("Cannot read file from disk. Original error: " & ex.Message)
            Finally
                If stream IsNot Nothing Then
                    stream.Close()
                End If
            End Try
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        openFile()
    End Sub
End Class