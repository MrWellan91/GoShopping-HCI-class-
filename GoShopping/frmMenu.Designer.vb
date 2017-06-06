<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenu
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
        Me.pnlMenu = New System.Windows.Forms.Panel()
        Me.lblOpen = New System.Windows.Forms.Label()
        Me.lblNew = New System.Windows.Forms.Label()
        Me.lblShare = New System.Windows.Forms.Label()
        Me.lblScan = New System.Windows.Forms.Label()
        Me.lblPlanATrip = New System.Windows.Forms.Label()
        Me.pnlMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlMenu
        '
        Me.pnlMenu.BackColor = System.Drawing.SystemColors.Desktop
        Me.pnlMenu.Controls.Add(Me.lblOpen)
        Me.pnlMenu.Controls.Add(Me.lblNew)
        Me.pnlMenu.Controls.Add(Me.lblShare)
        Me.pnlMenu.Controls.Add(Me.lblPlanATrip)
        Me.pnlMenu.Controls.Add(Me.lblScan)
        Me.pnlMenu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMenu.Location = New System.Drawing.Point(0, 0)
        Me.pnlMenu.Name = "pnlMenu"
        Me.pnlMenu.Size = New System.Drawing.Size(328, 551)
        Me.pnlMenu.TabIndex = 0
        '
        'lblOpen
        '
        Me.lblOpen.AutoSize = True
        Me.lblOpen.BackColor = System.Drawing.SystemColors.Desktop
        Me.lblOpen.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOpen.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblOpen.Location = New System.Drawing.Point(230, 449)
        Me.lblOpen.Name = "lblOpen"
        Me.lblOpen.Size = New System.Drawing.Size(86, 33)
        Me.lblOpen.TabIndex = 5
        Me.lblOpen.Text = "Open"
        '
        'lblNew
        '
        Me.lblNew.AutoSize = True
        Me.lblNew.BackColor = System.Drawing.SystemColors.Desktop
        Me.lblNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNew.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblNew.Location = New System.Drawing.Point(128, 449)
        Me.lblNew.Name = "lblNew"
        Me.lblNew.Size = New System.Drawing.Size(73, 33)
        Me.lblNew.TabIndex = 4
        Me.lblNew.Text = "New"
        '
        'lblShare
        '
        Me.lblShare.AutoSize = True
        Me.lblShare.BackColor = System.Drawing.SystemColors.Desktop
        Me.lblShare.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShare.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblShare.Location = New System.Drawing.Point(12, 449)
        Me.lblShare.Name = "lblShare"
        Me.lblShare.Size = New System.Drawing.Size(92, 33)
        Me.lblShare.TabIndex = 3
        Me.lblShare.Text = "Share"
        '
        'lblScan
        '
        Me.lblScan.AutoSize = True
        Me.lblScan.BackColor = System.Drawing.SystemColors.Desktop
        Me.lblScan.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScan.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblScan.Location = New System.Drawing.Point(85, 169)
        Me.lblScan.Name = "lblScan"
        Me.lblScan.Size = New System.Drawing.Size(156, 33)
        Me.lblScan.TabIndex = 0
        Me.lblScan.Text = "SCANNER"
        '
        'lblPlanATrip
        '
        Me.lblPlanATrip.AutoSize = True
        Me.lblPlanATrip.BackColor = System.Drawing.SystemColors.Desktop
        Me.lblPlanATrip.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlanATrip.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblPlanATrip.Location = New System.Drawing.Point(85, 266)
        Me.lblPlanATrip.Name = "lblPlanATrip"
        Me.lblPlanATrip.Size = New System.Drawing.Size(146, 33)
        Me.lblPlanATrip.TabIndex = 1
        Me.lblPlanATrip.Text = "Plan a trip"
        '
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(328, 551)
        Me.Controls.Add(Me.pnlMenu)
        Me.Name = "frmMenu"
        Me.Text = "MenuForm"
        Me.pnlMenu.ResumeLayout(False)
        Me.pnlMenu.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlMenu As Panel
    Friend WithEvents lblOpen As Label
    Friend WithEvents lblNew As Label
    Friend WithEvents lblShare As Label
    Friend WithEvents lblPlanATrip As Label
    Friend WithEvents lblScan As Label
End Class
