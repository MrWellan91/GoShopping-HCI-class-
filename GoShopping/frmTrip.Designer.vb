<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTrip
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
        Me.dtTrip = New System.Windows.Forms.DateTimePicker()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.lblButton = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnPickList = New System.Windows.Forms.Button()
        Me.btnCreateList = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtTrip
        '
        Me.dtTrip.Location = New System.Drawing.Point(12, 29)
        Me.dtTrip.Name = "dtTrip"
        Me.dtTrip.Size = New System.Drawing.Size(326, 20)
        Me.dtTrip.TabIndex = 0
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(12, 74)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(237, 20)
        Me.txtSearch.TabIndex = 1
        Me.txtSearch.Text = "Walmart Supercenter, Florida"
        '
        'lblButton
        '
        Me.lblButton.Location = New System.Drawing.Point(256, 74)
        Me.lblButton.Name = "lblButton"
        Me.lblButton.Size = New System.Drawing.Size(75, 20)
        Me.lblButton.TabIndex = 2
        Me.lblButton.Text = "Search"
        Me.lblButton.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.GoShopping.My.Resources.Resources.walmart
        Me.PictureBox1.Location = New System.Drawing.Point(12, 120)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(327, 168)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'btnPickList
        '
        Me.btnPickList.Location = New System.Drawing.Point(12, 295)
        Me.btnPickList.Name = "btnPickList"
        Me.btnPickList.Size = New System.Drawing.Size(326, 81)
        Me.btnPickList.TabIndex = 4
        Me.btnPickList.Text = "Pick a list"
        Me.btnPickList.UseVisualStyleBackColor = True
        '
        'btnCreateList
        '
        Me.btnCreateList.Location = New System.Drawing.Point(13, 382)
        Me.btnCreateList.Name = "btnCreateList"
        Me.btnCreateList.Size = New System.Drawing.Size(326, 81)
        Me.btnCreateList.TabIndex = 5
        Me.btnCreateList.Text = "Create a new list"
        Me.btnCreateList.UseVisualStyleBackColor = True
        '
        'frmTrip
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(351, 512)
        Me.Controls.Add(Me.btnCreateList)
        Me.Controls.Add(Me.btnPickList)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblButton)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.dtTrip)
        Me.Name = "frmTrip"
        Me.Text = "Plan a TRIP"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dtTrip As DateTimePicker
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents lblButton As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnPickList As Button
    Friend WithEvents btnCreateList As Button
End Class
