Public Class frmCheckoutChoice
    Dim list As Liste

    Public Sub New(ByRef list As Liste)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.list = list
        lblList.Text = lblList.Text + list.ListName
        lblNbProducts.Text = lblNbProducts.Text + list.getNbItem().ToString()

        Dim subtotal As Double = list.totalSum()
        Dim taxeRate As Double = 0.195R
        Dim taxes = subtotal * taxeRate
        Dim total As Double = subtotal * (taxeRate + 1) ' or subtotal + taxes, as you want ;)

        lblSubtotal.Text = lblSubtotal.Text + subtotal.ToString() + " €"
        lblTaxes.Text = lblTaxes.Text + taxes.ToString() + " €"
        lblTotal.Text = lblTotal.Text + total.ToString() + " €"
    End Sub

    Private Sub btnPayment_Click(sender As Object, e As EventArgs) Handles btnPayment.Click
        Dim frmLocal As New frmLocalPayment
        frmMobile.changeContentForm(frmLocal)
    End Sub

    Private Sub btnOnlinePayment_Click(sender As Object, e As EventArgs) Handles btnOnlinePayment.Click
        Dim frmOnline As New frmOnlinePayment
        frmMobile.changeContentForm(frmOnline)
    End Sub
End Class