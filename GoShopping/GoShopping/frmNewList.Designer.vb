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
        Me.lblListName = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblListName
        '
        Me.lblListName.AutoSize = True
        Me.lblListName.Location = New System.Drawing.Point(109, 51)
        Me.lblListName.Name = "lblListName"
        Me.lblListName.Size = New System.Drawing.Size(48, 13)
        Me.lblListName.TabIndex = 0
        Me.lblListName.Text = "New List"
        '
        'frmNewList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(312, 512)
        Me.Controls.Add(Me.lblListName)
        Me.Name = "frmNewList"
        Me.Text = "frmNewList"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblListName As Label
End Class
