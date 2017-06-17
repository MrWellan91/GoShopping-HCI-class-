<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMobile
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.pnlTop = New System.Windows.Forms.Panel()
        Me.lblHambIcon = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.pnlContent = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.picReturn = New System.Windows.Forms.PictureBox()
        Me.picTasks = New System.Windows.Forms.PictureBox()
        Me.picHome = New System.Windows.Forms.PictureBox()
        Me.pnlTop.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.picReturn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picTasks, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picHome, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlTop
        '
        Me.pnlTop.BackColor = System.Drawing.SystemColors.Desktop
        Me.pnlTop.Controls.Add(Me.lblHambIcon)
        Me.pnlTop.Controls.Add(Me.lblTitle)
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.Location = New System.Drawing.Point(0, 0)
        Me.pnlTop.Margin = New System.Windows.Forms.Padding(0)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(344, 50)
        Me.pnlTop.TabIndex = 0
        '
        'lblHambIcon
        '
        Me.lblHambIcon.AutoSize = True
        Me.lblHambIcon.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHambIcon.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblHambIcon.Location = New System.Drawing.Point(12, 9)
        Me.lblHambIcon.Name = "lblHambIcon"
        Me.lblHambIcon.Size = New System.Drawing.Size(32, 34)
        Me.lblHambIcon.TabIndex = 1
        Me.lblHambIcon.Text = "≡"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblTitle.Location = New System.Drawing.Point(127, 16)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(110, 25)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "GoShopping"
        '
        'pnlContent
        '
        Me.pnlContent.Location = New System.Drawing.Point(0, 50)
        Me.pnlContent.Margin = New System.Windows.Forms.Padding(0)
        Me.pnlContent.Name = "pnlContent"
        Me.pnlContent.Size = New System.Drawing.Size(344, 498)
        Me.pnlContent.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Desktop
        Me.Panel1.Controls.Add(Me.picReturn)
        Me.Panel1.Controls.Add(Me.picTasks)
        Me.Panel1.Controls.Add(Me.picHome)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 552)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(344, 50)
        Me.Panel1.TabIndex = 3
        '
        'picReturn
        '
        Me.picReturn.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.picReturn.Image = Global.GoShopping.My.Resources.Resources.Ret
        Me.picReturn.Location = New System.Drawing.Point(45, 0)
        Me.picReturn.Name = "picReturn"
        Me.picReturn.Size = New System.Drawing.Size(49, 50)
        Me.picReturn.TabIndex = 2
        Me.picReturn.TabStop = False
        '
        'picTasks
        '
        Me.picTasks.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.picTasks.Image = Global.GoShopping.My.Resources.Resources.Tasks
        Me.picTasks.Location = New System.Drawing.Point(244, 0)
        Me.picTasks.Name = "picTasks"
        Me.picTasks.Size = New System.Drawing.Size(49, 50)
        Me.picTasks.TabIndex = 1
        Me.picTasks.TabStop = False
        '
        'picHome
        '
        Me.picHome.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.picHome.Image = Global.GoShopping.My.Resources.Resources.Home
        Me.picHome.Location = New System.Drawing.Point(153, 0)
        Me.picHome.Name = "picHome"
        Me.picHome.Size = New System.Drawing.Size(49, 50)
        Me.picHome.TabIndex = 0
        Me.picHome.TabStop = False
        '
        'frmMobile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(344, 602)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pnlContent)
        Me.Controls.Add(Me.pnlTop)
        Me.IsMdiContainer = True
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(360, 640)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(360, 640)
        Me.Name = "frmMobile"
        Me.Text = "GoShopping"
        Me.pnlTop.ResumeLayout(False)
        Me.pnlTop.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.picReturn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picTasks, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picHome, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlTop As Panel
    Friend WithEvents lblHambIcon As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents pnlContent As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents picHome As PictureBox
    Friend WithEvents picReturn As PictureBox
    Friend WithEvents picTasks As PictureBox
End Class
