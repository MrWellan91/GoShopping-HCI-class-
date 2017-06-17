<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.btnNewListe = New System.Windows.Forms.Button()
        Me.pnlNoList = New System.Windows.Forms.Panel()
        Me.pnlLists = New System.Windows.Forms.Panel()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnCheckout = New System.Windows.Forms.Button()
        Me.twLists = New System.Windows.Forms.TreeView()
        Me.lblNbLists = New System.Windows.Forms.Label()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.pnlNoList.SuspendLayout()
        Me.pnlLists.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblMessage
        '
        Me.lblMessage.AutoSize = True
        Me.lblMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblMessage.Location = New System.Drawing.Point(22, 174)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(288, 40)
        Me.lblMessage.TabIndex = 0
        Me.lblMessage.Text = "Hello" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "It seems you have no shopping lists yet."
        Me.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnNewListe
        '
        Me.btnNewListe.Location = New System.Drawing.Point(119, 217)
        Me.btnNewListe.Name = "btnNewListe"
        Me.btnNewListe.Size = New System.Drawing.Size(99, 23)
        Me.btnNewListe.TabIndex = 1
        Me.btnNewListe.Text = "Create a new list"
        Me.btnNewListe.UseVisualStyleBackColor = True
        '
        'pnlNoList
        '
        Me.pnlNoList.Controls.Add(Me.lblMessage)
        Me.pnlNoList.Controls.Add(Me.btnNewListe)
        Me.pnlNoList.Enabled = False
        Me.pnlNoList.Location = New System.Drawing.Point(405, 8)
        Me.pnlNoList.Name = "pnlNoList"
        Me.pnlNoList.Size = New System.Drawing.Size(327, 488)
        Me.pnlNoList.TabIndex = 2
        Me.pnlNoList.Visible = False
        '
        'pnlLists
        '
        Me.pnlLists.Controls.Add(Me.btnDelete)
        Me.pnlLists.Controls.Add(Me.btnCheckout)
        Me.pnlLists.Controls.Add(Me.twLists)
        Me.pnlLists.Controls.Add(Me.lblNbLists)
        Me.pnlLists.Controls.Add(Me.btnEdit)
        Me.pnlLists.Enabled = False
        Me.pnlLists.Location = New System.Drawing.Point(12, 12)
        Me.pnlLists.Name = "pnlLists"
        Me.pnlLists.Size = New System.Drawing.Size(327, 488)
        Me.pnlLists.TabIndex = 3
        Me.pnlLists.Visible = False
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(0, 454)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(321, 30)
        Me.btnDelete.TabIndex = 4
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnCheckout
        '
        Me.btnCheckout.Location = New System.Drawing.Point(3, 418)
        Me.btnCheckout.Name = "btnCheckout"
        Me.btnCheckout.Size = New System.Drawing.Size(321, 30)
        Me.btnCheckout.TabIndex = 3
        Me.btnCheckout.Text = "Checkout"
        Me.btnCheckout.UseVisualStyleBackColor = True
        '
        'twLists
        '
        Me.twLists.Location = New System.Drawing.Point(3, 86)
        Me.twLists.Name = "twLists"
        Me.twLists.Size = New System.Drawing.Size(321, 290)
        Me.twLists.TabIndex = 2
        '
        'lblNbLists
        '
        Me.lblNbLists.AutoSize = True
        Me.lblNbLists.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblNbLists.Location = New System.Drawing.Point(102, 20)
        Me.lblNbLists.Name = "lblNbLists"
        Me.lblNbLists.Size = New System.Drawing.Size(139, 40)
        Me.lblNbLists.TabIndex = 0
        Me.lblNbLists.Text = "Hello," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "You have {nb} lists"
        Me.lblNbLists.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(3, 382)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(321, 30)
        Me.btnEdit.TabIndex = 1
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(351, 512)
        Me.Controls.Add(Me.pnlLists)
        Me.Controls.Add(Me.pnlNoList)
        Me.Name = "frmMain"
        Me.Text = "GoShopping"
        Me.pnlNoList.ResumeLayout(False)
        Me.pnlNoList.PerformLayout()
        Me.pnlLists.ResumeLayout(False)
        Me.pnlLists.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblMessage As Label
    Friend WithEvents btnNewListe As Button
    Friend WithEvents pnlNoList As Panel
    Friend WithEvents pnlLists As Panel
    Friend WithEvents lblNbLists As Label
    Friend WithEvents btnEdit As Button
    Friend WithEvents twLists As TreeView
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnCheckout As Button
End Class
