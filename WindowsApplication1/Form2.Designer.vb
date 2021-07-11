<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.lbOrder = New System.Windows.Forms.ListBox()
        Me.laName = New System.Windows.Forms.Label()
        Me.laChange = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.laAmRe = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.laTotal = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.laQuan = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.laMeal = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.laPrice = New System.Windows.Forms.Label()
        Me.buEXIT2 = New System.Windows.Forms.Button()
        Me.buBACK = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbOrder
        '
        Me.lbOrder.FormattingEnabled = True
        Me.lbOrder.Location = New System.Drawing.Point(64, 57)
        Me.lbOrder.Name = "lbOrder"
        Me.lbOrder.Size = New System.Drawing.Size(231, 147)
        Me.lbOrder.TabIndex = 2
        '
        'laName
        '
        Me.laName.AutoSize = True
        Me.laName.Location = New System.Drawing.Point(106, 9)
        Me.laName.Name = "laName"
        Me.laName.Size = New System.Drawing.Size(43, 13)
        Me.laName.TabIndex = 3
        Me.laName.Text = "laName"
        '
        'laChange
        '
        Me.laChange.AutoSize = True
        Me.laChange.Location = New System.Drawing.Point(123, 315)
        Me.laChange.Name = "laChange"
        Me.laChange.Size = New System.Drawing.Size(52, 13)
        Me.laChange.TabIndex = 4
        Me.laChange.Text = "laChange"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(61, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(61, 315)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Change:"
        '
        'laAmRe
        '
        Me.laAmRe.AutoSize = True
        Me.laAmRe.Location = New System.Drawing.Point(162, 290)
        Me.laAmRe.Name = "laAmRe"
        Me.laAmRe.Size = New System.Drawing.Size(44, 13)
        Me.laAmRe.TabIndex = 7
        Me.laAmRe.Text = "laAmRe"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(61, 290)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Amount Recieved:"
        '
        'laTotal
        '
        Me.laTotal.AutoSize = True
        Me.laTotal.Location = New System.Drawing.Point(117, 267)
        Me.laTotal.Name = "laTotal"
        Me.laTotal.Size = New System.Drawing.Size(39, 13)
        Me.laTotal.TabIndex = 9
        Me.laTotal.Text = "laTotal"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(61, 267)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Total:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(64, 243)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Quantity:"
        '
        'laQuan
        '
        Me.laQuan.AutoSize = True
        Me.laQuan.Location = New System.Drawing.Point(129, 243)
        Me.laQuan.Name = "laQuan"
        Me.laQuan.Size = New System.Drawing.Size(41, 13)
        Me.laQuan.TabIndex = 12
        Me.laQuan.Text = "laQuan"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(64, 38)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(33, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Meal:"
        '
        'laMeal
        '
        Me.laMeal.AutoSize = True
        Me.laMeal.Location = New System.Drawing.Point(109, 38)
        Me.laMeal.Name = "laMeal"
        Me.laMeal.Size = New System.Drawing.Size(38, 13)
        Me.laMeal.TabIndex = 14
        Me.laMeal.Text = "laMeal"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(64, 220)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(34, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Price:"
        '
        'laPrice
        '
        Me.laPrice.AutoSize = True
        Me.laPrice.Location = New System.Drawing.Point(107, 219)
        Me.laPrice.Name = "laPrice"
        Me.laPrice.Size = New System.Drawing.Size(39, 13)
        Me.laPrice.TabIndex = 16
        Me.laPrice.Text = "laPrice"
        '
        'buEXIT2
        '
        Me.buEXIT2.Location = New System.Drawing.Point(303, 333)
        Me.buEXIT2.Name = "buEXIT2"
        Me.buEXIT2.Size = New System.Drawing.Size(75, 23)
        Me.buEXIT2.TabIndex = 17
        Me.buEXIT2.Text = "E&XIT"
        Me.buEXIT2.UseVisualStyleBackColor = True
        '
        'buBACK
        '
        Me.buBACK.Location = New System.Drawing.Point(303, 304)
        Me.buBACK.Name = "buBACK"
        Me.buBACK.Size = New System.Drawing.Size(75, 23)
        Me.buBACK.TabIndex = 18
        Me.buBACK.Text = "&BACK"
        Me.buBACK.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(420, 368)
        Me.Controls.Add(Me.buBACK)
        Me.Controls.Add(Me.buEXIT2)
        Me.Controls.Add(Me.laPrice)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.laMeal)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.laQuan)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.laTotal)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.laAmRe)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.laChange)
        Me.Controls.Add(Me.laName)
        Me.Controls.Add(Me.lbOrder)
        Me.Name = "Form2"
        Me.Text = "Receipt"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbOrder As ListBox
    Friend WithEvents laName As Label
    Friend WithEvents laChange As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents laAmRe As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents laTotal As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents laQuan As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents laMeal As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents laPrice As Label
    Friend WithEvents buEXIT2 As Button
    Friend WithEvents buBACK As Button
End Class
