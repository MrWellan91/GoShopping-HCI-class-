<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCheckoutChoice
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
        Me.pnlInfo = New System.Windows.Forms.Panel()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblTaxes = New System.Windows.Forms.Label()
        Me.lblSubtotal = New System.Windows.Forms.Label()
        Me.lblNbProducts = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnOnlinePayment = New System.Windows.Forms.Button()
        Me.btnPayment = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlInfo.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblList
        '
        Me.lblList.AutoSize = True
        Me.lblList.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblList.Location = New System.Drawing.Point(3, 15)
        Me.lblList.Name = "lblList"
        Me.lblList.Size = New System.Drawing.Size(78, 24)
        Me.lblList.TabIndex = 0
        Me.lblList.Text = "LISTE: "
        '
        'pnlInfo
        '
        Me.pnlInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlInfo.Controls.Add(Me.lblTotal)
        Me.pnlInfo.Controls.Add(Me.lblTaxes)
        Me.pnlInfo.Controls.Add(Me.lblSubtotal)
        Me.pnlInfo.Controls.Add(Me.lblNbProducts)
        Me.pnlInfo.Controls.Add(Me.lblList)
        Me.pnlInfo.Location = New System.Drawing.Point(12, 12)
        Me.pnlInfo.Name = "pnlInfo"
        Me.pnlInfo.Size = New System.Drawing.Size(327, 314)
        Me.pnlInfo.TabIndex = 1
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(73, 273)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(87, 29)
        Me.lblTotal.TabIndex = 4
        Me.lblTotal.Text = "Total: "
        '
        'lblTaxes
        '
        Me.lblTaxes.AutoSize = True
        Me.lblTaxes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTaxes.Location = New System.Drawing.Point(4, 132)
        Me.lblTaxes.Name = "lblTaxes"
        Me.lblTaxes.Size = New System.Drawing.Size(118, 20)
        Me.lblTaxes.TabIndex = 3
        Me.lblTaxes.Text = "Taxes (19.5%): "
        '
        'lblSubtotal
        '
        Me.lblSubtotal.AutoSize = True
        Me.lblSubtotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubtotal.Location = New System.Drawing.Point(3, 98)
        Me.lblSubtotal.Name = "lblSubtotal"
        Me.lblSubtotal.Size = New System.Drawing.Size(77, 20)
        Me.lblSubtotal.TabIndex = 2
        Me.lblSubtotal.Text = "Subtotal: "
        '
        'lblNbProducts
        '
        Me.lblNbProducts.AutoSize = True
        Me.lblNbProducts.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNbProducts.Location = New System.Drawing.Point(3, 62)
        Me.lblNbProducts.Name = "lblNbProducts"
        Me.lblNbProducts.Size = New System.Drawing.Size(157, 20)
        Me.lblNbProducts.TabIndex = 1
        Me.lblNbProducts.Text = "Number of products: "
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnOnlinePayment)
        Me.Panel1.Controls.Add(Me.btnPayment)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(12, 333)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(327, 146)
        Me.Panel1.TabIndex = 2
        '
        'btnOnlinePayment
        '
        Me.btnOnlinePayment.Location = New System.Drawing.Point(3, 91)
        Me.btnOnlinePayment.Name = "btnOnlinePayment"
        Me.btnOnlinePayment.Size = New System.Drawing.Size(321, 23)
        Me.btnOnlinePayment.TabIndex = 8
        Me.btnOnlinePayment.Text = "Pay Online"
        Me.btnOnlinePayment.UseVisualStyleBackColor = True
        '
        'btnPayment
        '
        Me.btnPayment.Location = New System.Drawing.Point(3, 38)
        Me.btnPayment.Name = "btnPayment"
        Me.btnPayment.Size = New System.Drawing.Size(321, 23)
        Me.btnPayment.TabIndex = 7
        Me.btnPayment.Text = "Pay at checkout office"
        Me.btnPayment.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(75, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(130, 24)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "I'm at home: "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(75, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(198, 24)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "I'm in a supermarket"
        '
        'frmCheckoutChoice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(351, 512)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pnlInfo)
        Me.Name = "frmCheckoutChoice"
        Me.Text = "Checkout"
        Me.pnlInfo.ResumeLayout(False)
        Me.pnlInfo.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblList As Label
    Friend WithEvents pnlInfo As Panel
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblTaxes As Label
    Friend WithEvents lblSubtotal As Label
    Friend WithEvents lblNbProducts As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnOnlinePayment As Button
    Friend WithEvents btnPayment As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
