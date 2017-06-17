<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPaypal
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
        Me.pnlPaypal = New System.Windows.Forms.Panel()
        Me.btnConnectPaypal = New System.Windows.Forms.Button()
        Me.txtLogin = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblLogin = New System.Windows.Forms.Label()
        Me.lblCredentials = New System.Windows.Forms.Label()
        Me.lblPaypal = New System.Windows.Forms.Label()
        Me.pnlPaypal.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlPaypal
        '
        Me.pnlPaypal.Controls.Add(Me.btnConnectPaypal)
        Me.pnlPaypal.Controls.Add(Me.txtLogin)
        Me.pnlPaypal.Controls.Add(Me.txtPassword)
        Me.pnlPaypal.Controls.Add(Me.lblPassword)
        Me.pnlPaypal.Controls.Add(Me.lblLogin)
        Me.pnlPaypal.Controls.Add(Me.lblCredentials)
        Me.pnlPaypal.Controls.Add(Me.lblPaypal)
        Me.pnlPaypal.Location = New System.Drawing.Point(3, 1)
        Me.pnlPaypal.Name = "pnlPaypal"
        Me.pnlPaypal.Size = New System.Drawing.Size(326, 237)
        Me.pnlPaypal.TabIndex = 5
        '
        'btnConnectPaypal
        '
        Me.btnConnectPaypal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConnectPaypal.Location = New System.Drawing.Point(7, 171)
        Me.btnConnectPaypal.Name = "btnConnectPaypal"
        Me.btnConnectPaypal.Size = New System.Drawing.Size(316, 46)
        Me.btnConnectPaypal.TabIndex = 11
        Me.btnConnectPaypal.Text = "Connect to paypal"
        Me.btnConnectPaypal.UseVisualStyleBackColor = True
        '
        'txtLogin
        '
        Me.txtLogin.Location = New System.Drawing.Point(87, 92)
        Me.txtLogin.Name = "txtLogin"
        Me.txtLogin.Size = New System.Drawing.Size(203, 20)
        Me.txtLogin.TabIndex = 10
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(87, 129)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(203, 20)
        Me.txtPassword.TabIndex = 7
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.Location = New System.Drawing.Point(3, 129)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(78, 20)
        Me.lblPassword.TabIndex = 9
        Me.lblPassword.Text = "Password"
        '
        'lblLogin
        '
        Me.lblLogin.AutoSize = True
        Me.lblLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogin.Location = New System.Drawing.Point(3, 92)
        Me.lblLogin.Name = "lblLogin"
        Me.lblLogin.Size = New System.Drawing.Size(48, 20)
        Me.lblLogin.TabIndex = 8
        Me.lblLogin.Text = "Login"
        '
        'lblCredentials
        '
        Me.lblCredentials.AutoSize = True
        Me.lblCredentials.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCredentials.Location = New System.Drawing.Point(3, 48)
        Me.lblCredentials.Name = "lblCredentials"
        Me.lblCredentials.Size = New System.Drawing.Size(183, 20)
        Me.lblCredentials.TabIndex = 7
        Me.lblCredentials.Text = "Your Paypal credentials: "
        '
        'lblPaypal
        '
        Me.lblPaypal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPaypal.Location = New System.Drawing.Point(3, 14)
        Me.lblPaypal.Name = "lblPaypal"
        Me.lblPaypal.Size = New System.Drawing.Size(320, 24)
        Me.lblPaypal.TabIndex = 1
        Me.lblPaypal.Text = "Paypal payment"
        Me.lblPaypal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmPaypal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(330, 238)
        Me.Controls.Add(Me.pnlPaypal)
        Me.Name = "frmPaypal"
        Me.Text = "frmPaypal"
        Me.pnlPaypal.ResumeLayout(False)
        Me.pnlPaypal.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlPaypal As Panel
    Friend WithEvents btnConnectPaypal As Button
    Friend WithEvents txtLogin As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents lblPassword As Label
    Friend WithEvents lblLogin As Label
    Friend WithEvents lblCredentials As Label
    Friend WithEvents lblPaypal As Label
End Class
