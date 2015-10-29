<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmmsg
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
        Me.txtmsg = New System.Windows.Forms.TextBox
        Me.btnok = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblid = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtmsg
        '
        Me.txtmsg.Location = New System.Drawing.Point(51, 52)
        Me.txtmsg.Multiline = True
        Me.txtmsg.Name = "txtmsg"
        Me.txtmsg.ReadOnly = True
        Me.txtmsg.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtmsg.Size = New System.Drawing.Size(321, 117)
        Me.txtmsg.TabIndex = 0
        '
        'btnok
        '
        Me.btnok.Location = New System.Drawing.Point(159, 175)
        Me.btnok.Name = "btnok"
        Me.btnok.Size = New System.Drawing.Size(75, 23)
        Me.btnok.TabIndex = 1
        Me.btnok.Text = "Ok"
        Me.btnok.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(57, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Message from "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(208, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(13, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "L"
        '
        'lblid
        '
        Me.lblid.AutoSize = True
        Me.lblid.Enabled = False
        Me.lblid.Location = New System.Drawing.Point(261, 23)
        Me.lblid.Name = "lblid"
        Me.lblid.Size = New System.Drawing.Size(39, 13)
        Me.lblid.TabIndex = 5
        Me.lblid.Text = "Label3"
        Me.lblid.Visible = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.lblid)
        Me.Panel1.Controls.Add(Me.txtmsg)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.btnok)
        Me.Panel1.Location = New System.Drawing.Point(72, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(444, 212)
        Me.Panel1.TabIndex = 6
        '
        'frmmsg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(633, 400)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmmsg"
        Me.Text = "frmmsg"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtmsg As System.Windows.Forms.TextBox
    Friend WithEvents btnok As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblid As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
