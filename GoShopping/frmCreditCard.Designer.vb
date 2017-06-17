<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCreditCard
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
        Me.pnlCreditCard = New System.Windows.Forms.Panel()
        Me.txtSecurity = New System.Windows.Forms.TextBox()
        Me.dtExpiration = New System.Windows.Forms.DateTimePicker()
        Me.txtCardNumber = New System.Windows.Forms.TextBox()
        Me.lblSecurityCode = New System.Windows.Forms.Label()
        Me.lblExpirationDate = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblCreditCard = New System.Windows.Forms.Label()
        Me.pnlCreditCard.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlCreditCard
        '
        Me.pnlCreditCard.Controls.Add(Me.txtSecurity)
        Me.pnlCreditCard.Controls.Add(Me.dtExpiration)
        Me.pnlCreditCard.Controls.Add(Me.txtCardNumber)
        Me.pnlCreditCard.Controls.Add(Me.lblSecurityCode)
        Me.pnlCreditCard.Controls.Add(Me.lblExpirationDate)
        Me.pnlCreditCard.Controls.Add(Me.Label1)
        Me.pnlCreditCard.Controls.Add(Me.lblCreditCard)
        Me.pnlCreditCard.Location = New System.Drawing.Point(0, 1)
        Me.pnlCreditCard.Name = "pnlCreditCard"
        Me.pnlCreditCard.Size = New System.Drawing.Size(326, 237)
        Me.pnlCreditCard.TabIndex = 4
        '
        'txtSecurity
        '
        Me.txtSecurity.Location = New System.Drawing.Point(131, 171)
        Me.txtSecurity.MaxLength = 3
        Me.txtSecurity.Name = "txtSecurity"
        Me.txtSecurity.Size = New System.Drawing.Size(31, 20)
        Me.txtSecurity.TabIndex = 6
        '
        'dtExpiration
        '
        Me.dtExpiration.CustomFormat = "MM / yy"
        Me.dtExpiration.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtExpiration.Location = New System.Drawing.Point(131, 118)
        Me.dtExpiration.Name = "dtExpiration"
        Me.dtExpiration.Size = New System.Drawing.Size(192, 20)
        Me.dtExpiration.TabIndex = 5
        '
        'txtCardNumber
        '
        Me.txtCardNumber.Location = New System.Drawing.Point(131, 67)
        Me.txtCardNumber.MaxLength = 16
        Me.txtCardNumber.Name = "txtCardNumber"
        Me.txtCardNumber.Size = New System.Drawing.Size(192, 20)
        Me.txtCardNumber.TabIndex = 4
        '
        'lblSecurityCode
        '
        Me.lblSecurityCode.AutoSize = True
        Me.lblSecurityCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSecurityCode.Location = New System.Drawing.Point(3, 169)
        Me.lblSecurityCode.Name = "lblSecurityCode"
        Me.lblSecurityCode.Size = New System.Drawing.Size(105, 20)
        Me.lblSecurityCode.TabIndex = 3
        Me.lblSecurityCode.Text = "Security code"
        '
        'lblExpirationDate
        '
        Me.lblExpirationDate.AutoSize = True
        Me.lblExpirationDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExpirationDate.Location = New System.Drawing.Point(3, 118)
        Me.lblExpirationDate.Name = "lblExpirationDate"
        Me.lblExpirationDate.Size = New System.Drawing.Size(118, 20)
        Me.lblExpirationDate.TabIndex = 2
        Me.lblExpirationDate.Text = "Expiration Date"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Card number"
        '
        'lblCreditCard
        '
        Me.lblCreditCard.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCreditCard.Location = New System.Drawing.Point(3, 15)
        Me.lblCreditCard.Name = "lblCreditCard"
        Me.lblCreditCard.Size = New System.Drawing.Size(320, 23)
        Me.lblCreditCard.TabIndex = 0
        Me.lblCreditCard.Text = "Credit Card payment"
        Me.lblCreditCard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmCreditCard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(330, 239)
        Me.Controls.Add(Me.pnlCreditCard)
        Me.Name = "frmCreditCard"
        Me.Text = "frmCreditCard"
        Me.pnlCreditCard.ResumeLayout(False)
        Me.pnlCreditCard.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlCreditCard As Panel
    Friend WithEvents txtSecurity As TextBox
    Friend WithEvents dtExpiration As DateTimePicker
    Friend WithEvents txtCardNumber As TextBox
    Friend WithEvents lblSecurityCode As Label
    Friend WithEvents lblExpirationDate As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblCreditCard As Label
End Class
