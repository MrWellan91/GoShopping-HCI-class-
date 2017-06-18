<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmShareFriends
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
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.VScrollBar1 = New System.Windows.Forms.VScrollBar()
        Me.btnShare = New System.Windows.Forms.Button()
        Me.CheckedListBox1 = New System.Windows.Forms.CheckedListBox()
        Me.SuspendLayout()
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(12, 13)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(208, 20)
        Me.txtSearch.TabIndex = 0
        Me.txtSearch.Text = "Search by username"
        '
        'VScrollBar1
        '
        Me.VScrollBar1.Location = New System.Drawing.Point(205, 39)
        Me.VScrollBar1.Name = "VScrollBar1"
        Me.VScrollBar1.Size = New System.Drawing.Size(15, 109)
        Me.VScrollBar1.TabIndex = 0
        '
        'btnShare
        '
        Me.btnShare.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShare.Location = New System.Drawing.Point(12, 154)
        Me.btnShare.Name = "btnShare"
        Me.btnShare.Size = New System.Drawing.Size(208, 38)
        Me.btnShare.TabIndex = 2
        Me.btnShare.Text = "Share selected list"
        Me.btnShare.UseVisualStyleBackColor = True
        '
        'CheckedListBox1
        '
        Me.CheckedListBox1.FormattingEnabled = True
        Me.CheckedListBox1.Items.AddRange(New Object() {"MehdiDu13", "ThibautGod", "GuillaumeMaster"})
        Me.CheckedListBox1.Location = New System.Drawing.Point(12, 39)
        Me.CheckedListBox1.Name = "CheckedListBox1"
        Me.CheckedListBox1.Size = New System.Drawing.Size(208, 109)
        Me.CheckedListBox1.TabIndex = 1
        '
        'frmShareFriends
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(232, 204)
        Me.Controls.Add(Me.VScrollBar1)
        Me.Controls.Add(Me.CheckedListBox1)
        Me.Controls.Add(Me.btnShare)
        Me.Controls.Add(Me.txtSearch)
        Me.Name = "frmShareFriends"
        Me.Text = "frmShareFriends"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtSearch As TextBox
    Friend WithEvents VScrollBar1 As VScrollBar
    Friend WithEvents btnShare As Button
    Friend WithEvents CheckedListBox1 As CheckedListBox
End Class
