<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmchange
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
        Me.txtoldpas = New System.Windows.Forms.TextBox
        Me.txtnewpas = New System.Windows.Forms.TextBox
        Me.txtconfirm = New System.Windows.Forms.TextBox
        Me.btnok = New System.Windows.Forms.Button
        Me.btncancel = New System.Windows.Forms.Button
        Me.btnexit = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label4 = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(153, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ENTER OLD PASSWORD"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(157, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ENTER NEW PASSWORD"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(171, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "CONFIRM NEW PASSWORD"
        '
        'txtoldpas
        '
        Me.txtoldpas.Location = New System.Drawing.Point(233, 14)
        Me.txtoldpas.Name = "txtoldpas"
        Me.txtoldpas.Size = New System.Drawing.Size(116, 20)
        Me.txtoldpas.TabIndex = 3
        Me.txtoldpas.UseSystemPasswordChar = True
        '
        'txtnewpas
        '
        Me.txtnewpas.Location = New System.Drawing.Point(233, 59)
        Me.txtnewpas.Name = "txtnewpas"
        Me.txtnewpas.Size = New System.Drawing.Size(116, 20)
        Me.txtnewpas.TabIndex = 4
        Me.txtnewpas.UseSystemPasswordChar = True
        '
        'txtconfirm
        '
        Me.txtconfirm.Location = New System.Drawing.Point(233, 106)
        Me.txtconfirm.Name = "txtconfirm"
        Me.txtconfirm.Size = New System.Drawing.Size(116, 20)
        Me.txtconfirm.TabIndex = 5
        Me.txtconfirm.UseSystemPasswordChar = True
        '
        'btnok
        '
        Me.btnok.BackColor = System.Drawing.SystemColors.Menu
        Me.btnok.Location = New System.Drawing.Point(3, 10)
        Me.btnok.Name = "btnok"
        Me.btnok.Size = New System.Drawing.Size(87, 30)
        Me.btnok.TabIndex = 6
        Me.btnok.Text = "OK"
        Me.btnok.UseVisualStyleBackColor = False
        '
        'btncancel
        '
        Me.btncancel.BackColor = System.Drawing.SystemColors.Menu
        Me.btncancel.Location = New System.Drawing.Point(98, 10)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(87, 30)
        Me.btncancel.TabIndex = 7
        Me.btncancel.Text = "CLEAR"
        Me.btncancel.UseVisualStyleBackColor = False
        '
        'btnexit
        '
        Me.btnexit.BackColor = System.Drawing.SystemColors.Menu
        Me.btnexit.Location = New System.Drawing.Point(192, 10)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(87, 30)
        Me.btnexit.TabIndex = 8
        Me.btnexit.Text = "EXIT"
        Me.btnexit.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtoldpas)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtconfirm)
        Me.Panel1.Controls.Add(Me.txtnewpas)
        Me.Panel1.Location = New System.Drawing.Point(14, 55)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(366, 149)
        Me.Panel1.TabIndex = 9
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnexit)
        Me.Panel2.Controls.Add(Me.btnok)
        Me.Panel2.Controls.Add(Me.btncancel)
        Me.Panel2.Location = New System.Drawing.Point(52, 210)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(283, 47)
        Me.Panel2.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                        Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(86, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(235, 25)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "CHANGE PASSWORD"
        '
        'frmchange
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Menu
        Me.ClientSize = New System.Drawing.Size(390, 262)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmchange"
        Me.Text = "HMS-Change Password"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtoldpas As System.Windows.Forms.TextBox
    Friend WithEvents txtnewpas As System.Windows.Forms.TextBox
    Friend WithEvents txtconfirm As System.Windows.Forms.TextBox
    Friend WithEvents btnok As System.Windows.Forms.Button
    Friend WithEvents btncancel As System.Windows.Forms.Button
    Friend WithEvents btnexit As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
