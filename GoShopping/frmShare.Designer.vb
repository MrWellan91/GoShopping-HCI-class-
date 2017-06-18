<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmShare
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
        Me.twLists = New System.Windows.Forms.TreeView()
        Me.btnShare = New System.Windows.Forms.Button()
        Me.pctFb = New System.Windows.Forms.PictureBox()
        Me.pctFile = New System.Windows.Forms.PictureBox()
        Me.pctTwitter = New System.Windows.Forms.PictureBox()
        Me.pctGoogleP = New System.Windows.Forms.PictureBox()
        Me.pctWhatsapp = New System.Windows.Forms.PictureBox()
        Me.pctBluetooth = New System.Windows.Forms.PictureBox()
        CType(Me.pctFb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctFile, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctTwitter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctGoogleP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctWhatsapp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctBluetooth, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'twLists
        '
        Me.twLists.Location = New System.Drawing.Point(12, 12)
        Me.twLists.Name = "twLists"
        Me.twLists.Size = New System.Drawing.Size(321, 260)
        Me.twLists.TabIndex = 3
        '
        'btnShare
        '
        Me.btnShare.Enabled = False
        Me.btnShare.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShare.Location = New System.Drawing.Point(13, 278)
        Me.btnShare.Name = "btnShare"
        Me.btnShare.Size = New System.Drawing.Size(321, 75)
        Me.btnShare.TabIndex = 4
        Me.btnShare.Text = "Share with another user"
        Me.btnShare.UseVisualStyleBackColor = True
        '
        'pctFb
        '
        Me.pctFb.Enabled = False
        Me.pctFb.Image = Global.GoShopping.My.Resources.Resources.fb
        Me.pctFb.Location = New System.Drawing.Point(45, 359)
        Me.pctFb.Name = "pctFb"
        Me.pctFb.Size = New System.Drawing.Size(65, 58)
        Me.pctFb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctFb.TabIndex = 5
        Me.pctFb.TabStop = False
        '
        'pctFile
        '
        Me.pctFile.Enabled = False
        Me.pctFile.Image = Global.GoShopping.My.Resources.Resources.file
        Me.pctFile.Location = New System.Drawing.Point(45, 423)
        Me.pctFile.Name = "pctFile"
        Me.pctFile.Size = New System.Drawing.Size(65, 58)
        Me.pctFile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctFile.TabIndex = 6
        Me.pctFile.TabStop = False
        '
        'pctTwitter
        '
        Me.pctTwitter.Enabled = False
        Me.pctTwitter.Image = Global.GoShopping.My.Resources.Resources.twitter
        Me.pctTwitter.Location = New System.Drawing.Point(141, 359)
        Me.pctTwitter.Name = "pctTwitter"
        Me.pctTwitter.Size = New System.Drawing.Size(65, 58)
        Me.pctTwitter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctTwitter.TabIndex = 7
        Me.pctTwitter.TabStop = False
        '
        'pctGoogleP
        '
        Me.pctGoogleP.Enabled = False
        Me.pctGoogleP.Image = Global.GoShopping.My.Resources.Resources.googlep
        Me.pctGoogleP.Location = New System.Drawing.Point(234, 359)
        Me.pctGoogleP.Name = "pctGoogleP"
        Me.pctGoogleP.Size = New System.Drawing.Size(65, 58)
        Me.pctGoogleP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctGoogleP.TabIndex = 8
        Me.pctGoogleP.TabStop = False
        '
        'pctWhatsapp
        '
        Me.pctWhatsapp.Enabled = False
        Me.pctWhatsapp.Image = Global.GoShopping.My.Resources.Resources.whatsapp
        Me.pctWhatsapp.Location = New System.Drawing.Point(141, 423)
        Me.pctWhatsapp.Name = "pctWhatsapp"
        Me.pctWhatsapp.Size = New System.Drawing.Size(65, 58)
        Me.pctWhatsapp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctWhatsapp.TabIndex = 9
        Me.pctWhatsapp.TabStop = False
        '
        'pctBluetooth
        '
        Me.pctBluetooth.Enabled = False
        Me.pctBluetooth.Image = Global.GoShopping.My.Resources.Resources.bt
        Me.pctBluetooth.Location = New System.Drawing.Point(234, 423)
        Me.pctBluetooth.Name = "pctBluetooth"
        Me.pctBluetooth.Size = New System.Drawing.Size(65, 58)
        Me.pctBluetooth.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctBluetooth.TabIndex = 10
        Me.pctBluetooth.TabStop = False
        '
        'frmShare
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(351, 512)
        Me.Controls.Add(Me.pctBluetooth)
        Me.Controls.Add(Me.pctWhatsapp)
        Me.Controls.Add(Me.pctGoogleP)
        Me.Controls.Add(Me.pctTwitter)
        Me.Controls.Add(Me.pctFile)
        Me.Controls.Add(Me.pctFb)
        Me.Controls.Add(Me.btnShare)
        Me.Controls.Add(Me.twLists)
        Me.Name = "frmShare"
        Me.Text = "Share your list"
        CType(Me.pctFb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctFile, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctTwitter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctGoogleP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctWhatsapp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctBluetooth, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents twLists As TreeView
    Friend WithEvents btnShare As Button
    Friend WithEvents pctFb As PictureBox
    Friend WithEvents pctFile As PictureBox
    Friend WithEvents pctTwitter As PictureBox
    Friend WithEvents pctGoogleP As PictureBox
    Friend WithEvents pctWhatsapp As PictureBox
    Friend WithEvents pctBluetooth As PictureBox
End Class
