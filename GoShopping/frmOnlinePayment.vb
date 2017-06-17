Public Class frmOnlinePayment
    Dim frmBitcoin As frmBitcoin
    Dim frmPaypal As frmPaypal
    Dim frmCreditCard As frmCreditCard

    Private Sub rbCreditCard_CheckedChanged(sender As Object, e As EventArgs) Handles rbCreditCard.CheckedChanged
        If rbCreditCard.Checked Then
            frmCreditCard = New frmCreditCard()
            setPanel(frmCreditCard)
        End If
    End Sub

    Private Sub rbPaypal_CheckedChanged(sender As Object, e As EventArgs) Handles rbPaypal.CheckedChanged
        If rbPaypal.Checked Then
            frmPaypal = New frmPaypal()
            setPanel(frmPaypal)
        End If
    End Sub

    Private Sub rbBitcoin_CheckedChanged(sender As Object, e As EventArgs) Handles rbBitcoin.CheckedChanged
        If rbBitcoin.Checked Then
            frmBitcoin = New frmBitcoin()
            setPanel(frmBitcoin)
        End If
    End Sub

    Private Sub setPanel(ByVal frm As Form)
        pnlSelectedPayment.Controls.Clear()
        pnlSelectedPayment.Controls.Add(frm.Controls(0))
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        MessageBox.Show("Don't worry, payment not implemented !")
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Dim frmMain As New frmMain
        frmMobile.changeContentForm(frmMain, frmMain.Text)
    End Sub
End Class