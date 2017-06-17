<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmOpen
    Inherits System.Windows.Forms.Form
    '
    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.gbList = New System.Windows.Forms.GroupBox()
        Me.twFiles = New System.Windows.Forms.TreeView()
        Me.lblView = New System.Windows.Forms.Label()
        Me.lblTap = New System.Windows.Forms.Label()
        Me.lblList = New System.Windows.Forms.Label()
        Me.btnOpen = New System.Windows.Forms.Button()
        Me.txtListName = New System.Windows.Forms.TextBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.pcList = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.msgFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.gbList.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbList
        '
        Me.gbList.Controls.Add(Me.twFiles)
        Me.gbList.Location = New System.Drawing.Point(13, 62)
        Me.gbList.Name = "gbList"
        Me.gbList.Size = New System.Drawing.Size(321, 200)
        Me.gbList.TabIndex = 0
        Me.gbList.TabStop = False
        Me.gbList.Text = "Your list"
        '
        'twFiles
        '
        Me.twFiles.Location = New System.Drawing.Point(7, 20)
        Me.twFiles.Name = "twFiles"
        Me.twFiles.Size = New System.Drawing.Size(308, 174)
        Me.twFiles.TabIndex = 0
        '
        'lblView
        '
        Me.lblView.AutoSize = True
        Me.lblView.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.lblView.Location = New System.Drawing.Point(20, 269)
        Me.lblView.Name = "lblView"
        Me.lblView.Size = New System.Drawing.Size(62, 24)
        Me.lblView.TabIndex = 1
        Me.lblView.Text = "View :"
        '
        'lblTap
        '
        Me.lblTap.AutoSize = True
        Me.lblTap.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.lblTap.Location = New System.Drawing.Point(20, 316)
        Me.lblTap.Name = "lblTap"
        Me.lblTap.Size = New System.Drawing.Size(171, 24)
        Me.lblTap.TabIndex = 2
        Me.lblTap.Text = "Tap open to open :"
        '
        'lblList
        '
        Me.lblList.AutoSize = True
        Me.lblList.Location = New System.Drawing.Point(197, 324)
        Me.lblList.Name = "lblList"
        Me.lblList.Size = New System.Drawing.Size(23, 13)
        Me.lblList.TabIndex = 3
        Me.lblList.Text = "List"
        '
        'btnOpen
        '
        Me.btnOpen.Location = New System.Drawing.Point(12, 343)
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Size = New System.Drawing.Size(322, 152)
        Me.btnOpen.TabIndex = 4
        Me.btnOpen.Text = "Open"
        Me.btnOpen.UseVisualStyleBackColor = True
        '
        'txtListName
        '
        Me.txtListName.Location = New System.Drawing.Point(67, 24)
        Me.txtListName.Name = "txtListName"
        Me.txtListName.Size = New System.Drawing.Size(267, 20)
        Me.txtListName.TabIndex = 5
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.GoShopping.My.Resources.Resources.imageFile
        Me.PictureBox3.Location = New System.Drawing.Point(126, 269)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox3.TabIndex = 8
        Me.PictureBox3.TabStop = False
        '
        'pcList
        '
        Me.pcList.Image = Global.GoShopping.My.Resources.Resources.list
        Me.pcList.Location = New System.Drawing.Point(88, 269)
        Me.pcList.Name = "pcList"
        Me.pcList.Size = New System.Drawing.Size(32, 32)
        Me.pcList.TabIndex = 7
        Me.pcList.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.GoShopping.My.Resources.Resources.search
        Me.PictureBox1.Location = New System.Drawing.Point(13, 8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 48)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'frmOpen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(340, 509)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.pcList)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtListName)
        Me.Controls.Add(Me.btnOpen)
        Me.Controls.Add(Me.lblList)
        Me.Controls.Add(Me.lblTap)
        Me.Controls.Add(Me.lblView)
        Me.Controls.Add(Me.gbList)
        Me.Name = "frmOpen"
        Me.Text = "Open a list"
        Me.gbList.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gbList As GroupBox
    Friend WithEvents twFiles As TreeView
    Friend WithEvents lblView As Label
    Friend WithEvents lblTap As Label
    Friend WithEvents lblList As Label
    Friend WithEvents btnOpen As Button
    Friend WithEvents txtListName As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents pcList As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents msgFileDialog As OpenFileDialog
End Class
