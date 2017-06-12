<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBrowse
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.twShop = New System.Windows.Forms.TreeView()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.pcList = New System.Windows.Forms.PictureBox()
        Me.lblView = New System.Windows.Forms.Label()
        Me.grpShop = New System.Windows.Forms.GroupBox()
        Me.grpCart = New System.Windows.Forms.GroupBox()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpShop.SuspendLayout()
        Me.grpCart.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.GoShopping.My.Resources.Resources.search
        Me.PictureBox1.Location = New System.Drawing.Point(7, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 48)
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(61, 25)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(267, 20)
        Me.TextBox1.TabIndex = 11
        '
        'twShop
        '
        Me.twShop.Location = New System.Drawing.Point(7, 20)
        Me.twShop.Name = "twShop"
        Me.twShop.Size = New System.Drawing.Size(308, 174)
        Me.twShop.TabIndex = 0
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.GoShopping.My.Resources.Resources.imageFile
        Me.PictureBox3.Location = New System.Drawing.Point(120, 270)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox3.TabIndex = 14
        Me.PictureBox3.TabStop = False
        '
        'pcList
        '
        Me.pcList.Image = Global.GoShopping.My.Resources.Resources.list
        Me.pcList.Location = New System.Drawing.Point(82, 270)
        Me.pcList.Name = "pcList"
        Me.pcList.Size = New System.Drawing.Size(32, 32)
        Me.pcList.TabIndex = 13
        Me.pcList.TabStop = False
        '
        'lblView
        '
        Me.lblView.AutoSize = True
        Me.lblView.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.lblView.Location = New System.Drawing.Point(14, 270)
        Me.lblView.Name = "lblView"
        Me.lblView.Size = New System.Drawing.Size(62, 24)
        Me.lblView.TabIndex = 10
        Me.lblView.Text = "View :"
        '
        'grpShop
        '
        Me.grpShop.Controls.Add(Me.twShop)
        Me.grpShop.Location = New System.Drawing.Point(7, 63)
        Me.grpShop.Name = "grpShop"
        Me.grpShop.Size = New System.Drawing.Size(321, 200)
        Me.grpShop.TabIndex = 9
        Me.grpShop.TabStop = False
        Me.grpShop.Text = "Online shop"
        '
        'grpCart
        '
        Me.grpCart.Controls.Add(Me.TreeView1)
        Me.grpCart.Location = New System.Drawing.Point(7, 308)
        Me.grpCart.Name = "grpCart"
        Me.grpCart.Size = New System.Drawing.Size(321, 158)
        Me.grpCart.TabIndex = 10
        Me.grpCart.TabStop = False
        Me.grpCart.Text = "Your cart"
        '
        'TreeView1
        '
        Me.TreeView1.Location = New System.Drawing.Point(7, 20)
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.Size = New System.Drawing.Size(308, 132)
        Me.TreeView1.TabIndex = 0
        '
        'frmBrowse
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(340, 509)
        Me.Controls.Add(Me.grpCart)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.pcList)
        Me.Controls.Add(Me.lblView)
        Me.Controls.Add(Me.grpShop)
        Me.Name = "frmBrowse"
        Me.Text = "frmBrowse"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpShop.ResumeLayout(False)
        Me.grpCart.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents twShop As TreeView
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents pcList As PictureBox
    Friend WithEvents lblView As Label
    Friend WithEvents grpShop As GroupBox
    Friend WithEvents grpCart As GroupBox
    Friend WithEvents TreeView1 As TreeView
End Class
