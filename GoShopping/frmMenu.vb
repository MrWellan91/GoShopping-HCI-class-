﻿Public Class frmMenu
    Dim frmChoose As frmChooseAList
    Dim scan As frmScan
    Dim list As Liste

    Public frmName As String = "Menu"

    Sub lblNew_Click(sender As Object, e As EventArgs) Handles lblNew.Click
        Dim response = InputBox("Name your list", "New List", "")
        If response = "" Then
        Else
            Dim newList = New frmNewList(response)
            frmMobile.changeContentForm(newList, newList.Text)
        End If
    End Sub

    Private Sub lblOpen_Click(sender As Object, e As EventArgs) Handles lblOpen.Click
        Dim openList = New frmOpen
        frmMobile.changeContentForm(openList, openList.Text)
    End Sub

    Private Sub lblScan_Click(sender As Object, e As EventArgs) Handles lblScan.Click
        If frmMobile.lists.Count > 0 Then
            Me.Visible = False
            frmChoose = New frmChooseAList
            frmChoose.Visible = True
            AddHandler frmChoose.btnOk.Click, AddressOf closedChoose

        Else
            Dim response = InputBox("Name your list", "New List", "")

            If response = "" Then
            Else
                Dim liste = New Liste(response)
                scan = New frmScan(liste)
                frmMobile.AddListe(liste)
                frmMobile.changeContentForm(scan, scan.Text)
            End If

        End If

    End Sub

    Private Sub closedChoose()
        If frmChoose.Answer = 1 Then
            list = frmChoose.list
            scan = New frmScan(list)
            frmMobile.changeContentForm(scan, scan.Text)
        End If
    End Sub

    Private Sub lblMain_Click(sender As Object, e As EventArgs) Handles lblMain.Click
        Dim frmMain = New frmMain
        frmMobile.changeContentForm(frmMain, frmMain.Text)
    End Sub
End Class