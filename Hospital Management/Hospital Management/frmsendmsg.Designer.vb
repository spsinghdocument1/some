<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmsendmsg
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
        Me.btnok = New System.Windows.Forms.Button
        Me.txtmsg = New System.Windows.Forms.TextBox
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmbdoctor = New System.Windows.Forms.ComboBox
        Me.SuspendLayout()
        '
        'btnok
        '
        Me.btnok.Location = New System.Drawing.Point(152, 260)
        Me.btnok.Name = "btnok"
        Me.btnok.Size = New System.Drawing.Size(75, 23)
        Me.btnok.TabIndex = 3
        Me.btnok.Text = "Send"
        Me.btnok.UseVisualStyleBackColor = True
        '
        'txtmsg
        '
        Me.txtmsg.Location = New System.Drawing.Point(57, 120)
        Me.txtmsg.Multiline = True
        Me.txtmsg.Name = "txtmsg"
        Me.txtmsg.Size = New System.Drawing.Size(321, 117)
        Me.txtmsg.TabIndex = 2
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(191, 29)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(60, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "To Msg"
        '
        'cmbdoctor
        '
        Me.cmbdoctor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbdoctor.FormattingEnabled = True
        Me.cmbdoctor.Location = New System.Drawing.Point(191, 71)
        Me.cmbdoctor.Name = "cmbdoctor"
        Me.cmbdoctor.Size = New System.Drawing.Size(121, 21)
        Me.cmbdoctor.TabIndex = 6
        '
        'frmsendmsg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(390, 295)
        Me.Controls.Add(Me.cmbdoctor)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.btnok)
        Me.Controls.Add(Me.txtmsg)
        Me.Name = "frmsendmsg"
        Me.Text = "frmsendmsg"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnok As System.Windows.Forms.Button
    Friend WithEvents txtmsg As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbdoctor As System.Windows.Forms.ComboBox
End Class
