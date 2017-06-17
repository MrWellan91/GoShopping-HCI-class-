<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRecap
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
        Me.lblList = New System.Windows.Forms.Label()
        Me.twList = New System.Windows.Forms.TreeView()
        Me.btnCheckout = New System.Windows.Forms.Button()
        Me.lblNb = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblList
        '
        Me.lblList.AutoSize = True
        Me.lblList.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblList.Location = New System.Drawing.Point(12, 9)
        Me.lblList.Name = "lblList"
        Me.lblList.Size = New System.Drawing.Size(47, 23)
        Me.lblList.TabIndex = 0
        Me.lblList.Text = "List: "
        '
        'twList
        '
        Me.twList.Location = New System.Drawing.Point(16, 91)
        Me.twList.Name = "twList"
        Me.twList.Size = New System.Drawing.Size(323, 306)
        Me.twList.TabIndex = 1
        '
        'btnCheckout
        '
        Me.btnCheckout.Location = New System.Drawing.Point(16, 403)
        Me.btnCheckout.Name = "btnCheckout"
        Me.btnCheckout.Size = New System.Drawing.Size(323, 59)
        Me.btnCheckout.TabIndex = 2
        Me.btnCheckout.Text = "Proceed to checkout"
        Me.btnCheckout.UseVisualStyleBackColor = True
        '
        'lblNb
        '
        Me.lblNb.AutoSize = True
        Me.lblNb.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNb.Location = New System.Drawing.Point(12, 47)
        Me.lblNb.Name = "lblNb"
        Me.lblNb.Size = New System.Drawing.Size(85, 23)
        Me.lblNb.TabIndex = 3
        Me.lblNb.Text = "Nb items: "
        '
        'frmRecap
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(351, 512)
        Me.Controls.Add(Me.lblNb)
        Me.Controls.Add(Me.btnCheckout)
        Me.Controls.Add(Me.twList)
        Me.Controls.Add(Me.lblList)
        Me.Name = "frmRecap"
        Me.Text = "Recap"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblList As Label
    Friend WithEvents twList As TreeView
    Friend WithEvents btnCheckout As Button
    Friend WithEvents lblNb As Label
End Class
