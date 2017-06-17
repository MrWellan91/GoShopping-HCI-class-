<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmScan
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
        Me.btnDetails = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.lblPurpose = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.lblItem = New System.Windows.Forms.Label()
        Me.lblItemData = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.GoShopping.My.Resources.Resources.NotImplemented
        Me.PictureBox1.Location = New System.Drawing.Point(75, 85)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(192, 272)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'btnDetails
        '
        Me.btnDetails.Location = New System.Drawing.Point(12, 424)
        Me.btnDetails.Name = "btnDetails"
        Me.btnDetails.Size = New System.Drawing.Size(151, 55)
        Me.btnDetails.TabIndex = 1
        Me.btnDetails.Text = "Details"
        Me.btnDetails.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(187, 424)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(152, 55)
        Me.btnAdd.TabIndex = 2
        Me.btnAdd.Text = "Add To List"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(12, 398)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(100, 20)
        Me.txtSearch.TabIndex = 3
        '
        'lblPurpose
        '
        Me.lblPurpose.AutoSize = True
        Me.lblPurpose.Location = New System.Drawing.Point(9, 382)
        Me.lblPurpose.Name = "lblPurpose"
        Me.lblPurpose.Size = New System.Drawing.Size(182, 13)
        Me.lblPurpose.TabIndex = 4
        Me.lblPurpose.Text = "For a purpose of test just enter an ID:"
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(118, 398)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 20)
        Me.btnSearch.TabIndex = 5
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'lblItem
        '
        Me.lblItem.AutoSize = True
        Me.lblItem.Location = New System.Drawing.Point(263, 382)
        Me.lblItem.Name = "lblItem"
        Me.lblItem.Size = New System.Drawing.Size(30, 13)
        Me.lblItem.TabIndex = 6
        Me.lblItem.Text = "Item:"
        '
        'lblItemData
        '
        Me.lblItemData.AutoSize = True
        Me.lblItemData.Location = New System.Drawing.Point(249, 405)
        Me.lblItemData.Name = "lblItemData"
        Me.lblItemData.Size = New System.Drawing.Size(0, 13)
        Me.lblItemData.TabIndex = 7
        '
        'frmScan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(351, 512)
        Me.Controls.Add(Me.lblItemData)
        Me.Controls.Add(Me.lblItem)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.lblPurpose)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnDetails)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmScan"
        Me.Text = "Scanner"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnDetails As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents lblPurpose As Label
    Friend WithEvents btnSearch As Button
    Friend WithEvents lblItem As Label
    Friend WithEvents lblItemData As Label
End Class
