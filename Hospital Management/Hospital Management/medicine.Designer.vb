<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class medicine
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtmedid = New System.Windows.Forms.TextBox
        Me.txtmed = New System.Windows.Forms.TextBox
        Me.txtqty = New System.Windows.Forms.TextBox
        Me.txtcost = New System.Windows.Forms.TextBox
        Me.btnadd = New System.Windows.Forms.Button
        Me.btnexit = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "MEDICINE ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "MEDICINE"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 157)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "QUANTITY"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(26, 203)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "COST"
        '
        'txtmedid
        '
        Me.txtmedid.Location = New System.Drawing.Point(232, 41)
        Me.txtmedid.Name = "txtmedid"
        Me.txtmedid.Size = New System.Drawing.Size(100, 20)
        Me.txtmedid.TabIndex = 4
        '
        'txtmed
        '
        Me.txtmed.Location = New System.Drawing.Point(232, 91)
        Me.txtmed.Name = "txtmed"
        Me.txtmed.Size = New System.Drawing.Size(100, 20)
        Me.txtmed.TabIndex = 5
        '
        'txtqty
        '
        Me.txtqty.Location = New System.Drawing.Point(232, 157)
        Me.txtqty.Name = "txtqty"
        Me.txtqty.Size = New System.Drawing.Size(100, 20)
        Me.txtqty.TabIndex = 6
        '
        'txtcost
        '
        Me.txtcost.Location = New System.Drawing.Point(232, 213)
        Me.txtcost.Name = "txtcost"
        Me.txtcost.Size = New System.Drawing.Size(100, 20)
        Me.txtcost.TabIndex = 7
        '
        'btnadd
        '
        Me.btnadd.Location = New System.Drawing.Point(85, 239)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(75, 23)
        Me.btnadd.TabIndex = 8
        Me.btnadd.Text = "ADD"
        Me.btnadd.UseVisualStyleBackColor = True
        '
        'btnexit
        '
        Me.btnexit.Location = New System.Drawing.Point(185, 239)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(75, 23)
        Me.btnexit.TabIndex = 9
        Me.btnexit.Text = "EXIT"
        Me.btnexit.UseVisualStyleBackColor = True
        '
        'medicine
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(467, 355)
        Me.Controls.Add(Me.btnexit)
        Me.Controls.Add(Me.btnadd)
        Me.Controls.Add(Me.txtcost)
        Me.Controls.Add(Me.txtqty)
        Me.Controls.Add(Me.txtmed)
        Me.Controls.Add(Me.txtmedid)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "medicine"
        Me.Text = "medicine"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtmedid As System.Windows.Forms.TextBox
    Friend WithEvents txtmed As System.Windows.Forms.TextBox
    Friend WithEvents txtqty As System.Windows.Forms.TextBox
    Friend WithEvents txtcost As System.Windows.Forms.TextBox
    Friend WithEvents btnadd As System.Windows.Forms.Button
    Friend WithEvents btnexit As System.Windows.Forms.Button
End Class
