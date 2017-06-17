<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBitcoin
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
        Me.pnlBitcoin = New System.Windows.Forms.Panel()
        Me.lblValidationCode = New System.Windows.Forms.Label()
        Me.txtValidation = New System.Windows.Forms.TextBox()
        Me.txtWallet = New System.Windows.Forms.TextBox()
        Me.lblBitcoinAddress = New System.Windows.Forms.Label()
        Me.lblBitcoin = New System.Windows.Forms.Label()
        Me.pnlBitcoin.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlBitcoin
        '
        Me.pnlBitcoin.Controls.Add(Me.lblValidationCode)
        Me.pnlBitcoin.Controls.Add(Me.txtValidation)
        Me.pnlBitcoin.Controls.Add(Me.txtWallet)
        Me.pnlBitcoin.Controls.Add(Me.lblBitcoinAddress)
        Me.pnlBitcoin.Controls.Add(Me.lblBitcoin)
        Me.pnlBitcoin.Location = New System.Drawing.Point(0, 0)
        Me.pnlBitcoin.Name = "pnlBitcoin"
        Me.pnlBitcoin.Size = New System.Drawing.Size(326, 237)
        Me.pnlBitcoin.TabIndex = 6
        '
        'lblValidationCode
        '
        Me.lblValidationCode.AutoSize = True
        Me.lblValidationCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValidationCode.Location = New System.Drawing.Point(107, 123)
        Me.lblValidationCode.Name = "lblValidationCode"
        Me.lblValidationCode.Size = New System.Drawing.Size(121, 20)
        Me.lblValidationCode.TabIndex = 9
        Me.lblValidationCode.Text = "Validation Code"
        '
        'txtValidation
        '
        Me.txtValidation.Location = New System.Drawing.Point(3, 163)
        Me.txtValidation.Name = "txtValidation"
        Me.txtValidation.Size = New System.Drawing.Size(315, 20)
        Me.txtValidation.TabIndex = 8
        '
        'txtWallet
        '
        Me.txtWallet.Location = New System.Drawing.Point(7, 90)
        Me.txtWallet.Name = "txtWallet"
        Me.txtWallet.ReadOnly = True
        Me.txtWallet.Size = New System.Drawing.Size(316, 20)
        Me.txtWallet.TabIndex = 7
        Me.txtWallet.Text = "1BvBMSEYstWetqTFn5Au4m4GFg7xJaNVN2"
        Me.txtWallet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblBitcoinAddress
        '
        Me.lblBitcoinAddress.AutoSize = True
        Me.lblBitcoinAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBitcoinAddress.Location = New System.Drawing.Point(107, 56)
        Me.lblBitcoinAddress.Name = "lblBitcoinAddress"
        Me.lblBitcoinAddress.Size = New System.Drawing.Size(105, 20)
        Me.lblBitcoinAddress.TabIndex = 7
        Me.lblBitcoinAddress.Text = "Bitcoin Wallet"
        '
        'lblBitcoin
        '
        Me.lblBitcoin.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBitcoin.Location = New System.Drawing.Point(3, 17)
        Me.lblBitcoin.Name = "lblBitcoin"
        Me.lblBitcoin.Size = New System.Drawing.Size(320, 24)
        Me.lblBitcoin.TabIndex = 2
        Me.lblBitcoin.Text = "Bitcoin payment"
        Me.lblBitcoin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmBitcoin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(327, 239)
        Me.Controls.Add(Me.pnlBitcoin)
        Me.Name = "frmBitcoin"
        Me.Text = "frmBitcoin"
        Me.pnlBitcoin.ResumeLayout(False)
        Me.pnlBitcoin.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlBitcoin As Panel
    Friend WithEvents lblValidationCode As Label
    Friend WithEvents txtValidation As TextBox
    Friend WithEvents txtWallet As TextBox
    Friend WithEvents lblBitcoinAddress As Label
    Friend WithEvents lblBitcoin As Label
End Class
