<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNewList
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
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.lblOr = New System.Windows.Forms.Label()
        Me.btnScan = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblInfo
        '
        Me.lblInfo.Location = New System.Drawing.Point(110, 161)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(139, 48)
        Me.lblInfo.TabIndex = 0
        Me.lblInfo.Text = "This list is empty. Start adding products by clicking one of the buttons below"
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(113, 212)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(136, 23)
        Me.btnBrowse.TabIndex = 1
        Me.btnBrowse.Text = "Browse products"
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'lblOr
        '
        Me.lblOr.AutoSize = True
        Me.lblOr.Location = New System.Drawing.Point(169, 238)
        Me.lblOr.Name = "lblOr"
        Me.lblOr.Size = New System.Drawing.Size(18, 13)
        Me.lblOr.TabIndex = 2
        Me.lblOr.Text = "Or"
        '
        'btnScan
        '
        Me.btnScan.Location = New System.Drawing.Point(113, 254)
        Me.btnScan.Name = "btnScan"
        Me.btnScan.Size = New System.Drawing.Size(136, 23)
        Me.btnScan.TabIndex = 3
        Me.btnScan.Text = "Scan products"
        Me.btnScan.UseVisualStyleBackColor = True
        '
        'frmNewList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(372, 512)
        Me.Controls.Add(Me.btnScan)
        Me.Controls.Add(Me.lblOr)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.lblInfo)
        Me.Name = "frmNewList"
        Me.Text = "frmNewList"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblInfo As Label
    Friend WithEvents btnBrowse As Button
    Friend WithEvents lblOr As Label
    Friend WithEvents btnScan As Button
End Class
