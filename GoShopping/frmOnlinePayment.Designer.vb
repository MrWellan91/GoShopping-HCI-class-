<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOnlinePayment
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblSelect = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.picBitcoin = New System.Windows.Forms.PictureBox()
        Me.picPaypal = New System.Windows.Forms.PictureBox()
        Me.picCreditCard = New System.Windows.Forms.PictureBox()
        Me.rbBitcoin = New System.Windows.Forms.RadioButton()
        Me.rbPaypal = New System.Windows.Forms.RadioButton()
        Me.rbCreditCard = New System.Windows.Forms.RadioButton()
        Me.pnlSelectedPayment = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.picBitcoin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPaypal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCreditCard, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblSelect
        '
        Me.lblSelect.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelect.Location = New System.Drawing.Point(3, 16)
        Me.lblSelect.Name = "lblSelect"
        Me.lblSelect.Size = New System.Drawing.Size(320, 29)
        Me.lblSelect.TabIndex = 0
        Me.lblSelect.Text = "Select your payment method: "
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.picBitcoin)
        Me.Panel1.Controls.Add(Me.picPaypal)
        Me.Panel1.Controls.Add(Me.picCreditCard)
        Me.Panel1.Controls.Add(Me.rbBitcoin)
        Me.Panel1.Controls.Add(Me.rbPaypal)
        Me.Panel1.Controls.Add(Me.rbCreditCard)
        Me.Panel1.Controls.Add(Me.lblSelect)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(326, 154)
        Me.Panel1.TabIndex = 1
        '
        'picBitcoin
        '
        Me.picBitcoin.Image = Global.GoShopping.My.Resources.Resources.bitcoin
        Me.picBitcoin.Location = New System.Drawing.Point(121, 109)
        Me.picBitcoin.Name = "picBitcoin"
        Me.picBitcoin.Size = New System.Drawing.Size(39, 23)
        Me.picBitcoin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picBitcoin.TabIndex = 6
        Me.picBitcoin.TabStop = False
        '
        'picPaypal
        '
        Me.picPaypal.Image = Global.GoShopping.My.Resources.Resources.paypal
        Me.picPaypal.Location = New System.Drawing.Point(121, 80)
        Me.picPaypal.Name = "picPaypal"
        Me.picPaypal.Size = New System.Drawing.Size(39, 23)
        Me.picPaypal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picPaypal.TabIndex = 5
        Me.picPaypal.TabStop = False
        '
        'picCreditCard
        '
        Me.picCreditCard.Image = Global.GoShopping.My.Resources.Resources.creditcard
        Me.picCreditCard.Location = New System.Drawing.Point(121, 48)
        Me.picCreditCard.Name = "picCreditCard"
        Me.picCreditCard.Size = New System.Drawing.Size(39, 23)
        Me.picCreditCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picCreditCard.TabIndex = 4
        Me.picCreditCard.TabStop = False
        '
        'rbBitcoin
        '
        Me.rbBitcoin.AutoSize = True
        Me.rbBitcoin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbBitcoin.Location = New System.Drawing.Point(7, 108)
        Me.rbBitcoin.Name = "rbBitcoin"
        Me.rbBitcoin.Size = New System.Drawing.Size(75, 24)
        Me.rbBitcoin.TabIndex = 3
        Me.rbBitcoin.TabStop = True
        Me.rbBitcoin.Text = "Bitcoin"
        Me.rbBitcoin.UseVisualStyleBackColor = True
        '
        'rbPaypal
        '
        Me.rbPaypal.AutoSize = True
        Me.rbPaypal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbPaypal.Location = New System.Drawing.Point(7, 78)
        Me.rbPaypal.Name = "rbPaypal"
        Me.rbPaypal.Size = New System.Drawing.Size(74, 24)
        Me.rbPaypal.TabIndex = 2
        Me.rbPaypal.TabStop = True
        Me.rbPaypal.Text = "Paypal"
        Me.rbPaypal.UseVisualStyleBackColor = True
        '
        'rbCreditCard
        '
        Me.rbCreditCard.AutoSize = True
        Me.rbCreditCard.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbCreditCard.Location = New System.Drawing.Point(7, 48)
        Me.rbCreditCard.Name = "rbCreditCard"
        Me.rbCreditCard.Size = New System.Drawing.Size(107, 24)
        Me.rbCreditCard.TabIndex = 1
        Me.rbCreditCard.TabStop = True
        Me.rbCreditCard.Text = "Credit Card"
        Me.rbCreditCard.UseVisualStyleBackColor = True
        '
        'pnlSelectedPayment
        '
        Me.pnlSelectedPayment.Location = New System.Drawing.Point(12, 173)
        Me.pnlSelectedPayment.Name = "pnlSelectedPayment"
        Me.pnlSelectedPayment.Size = New System.Drawing.Size(326, 237)
        Me.pnlSelectedPayment.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnConfirm)
        Me.Panel2.Controls.Add(Me.btnCancel)
        Me.Panel2.Location = New System.Drawing.Point(12, 416)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(326, 82)
        Me.Panel2.TabIndex = 6
        '
        'btnConfirm
        '
        Me.btnConfirm.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirm.Location = New System.Drawing.Point(181, 3)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(142, 76)
        Me.btnConfirm.TabIndex = 1
        Me.btnConfirm.Text = "Confirm"
        Me.btnConfirm.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(3, 3)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(142, 76)
        Me.btnCancel.TabIndex = 0
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'frmOnlinePayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(344, 512)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.pnlSelectedPayment)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmOnlinePayment"
        Me.Text = "frmOnlinePayment"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.picBitcoin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPaypal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCreditCard, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblSelect As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents rbBitcoin As RadioButton
    Friend WithEvents rbPaypal As RadioButton
    Friend WithEvents rbCreditCard As RadioButton
    Friend WithEvents picBitcoin As PictureBox
    Friend WithEvents picPaypal As PictureBox
    Friend WithEvents picCreditCard As PictureBox
    Friend WithEvents pnlSelectedPayment As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnConfirm As Button
End Class
