<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmogin))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Txtusername = New System.Windows.Forms.TextBox()
        Me.Cmbusertype = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Txtpassword = New System.Windows.Forms.TextBox()
        Me.btnok = New System.Windows.Forms.Button()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(31, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(223, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "SELECT USER TYPE"
        '
        'Txtusername
        '
        Me.Txtusername.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtusername.Location = New System.Drawing.Point(252, 74)
        Me.Txtusername.Name = "Txtusername"
        Me.Txtusername.Size = New System.Drawing.Size(180, 30)
        Me.Txtusername.TabIndex = 4
        '
        'Cmbusertype
        '
        Me.Cmbusertype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmbusertype.DropDownWidth = 180
        Me.Cmbusertype.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmbusertype.FormattingEnabled = True
        Me.Cmbusertype.ItemHeight = 25
        Me.Cmbusertype.Items.AddRange(New Object() {"Admin", "Doctor", "Receptionist"})
        Me.Cmbusertype.Location = New System.Drawing.Point(252, 19)
        Me.Cmbusertype.Name = "Cmbusertype"
        Me.Cmbusertype.Size = New System.Drawing.Size(180, 33)
        Me.Cmbusertype.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(31, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(138, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "USER NAME"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(31, 135)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(138, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "PASSWORD"
        '
        'Txtpassword
        '
        Me.Txtpassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtpassword.Location = New System.Drawing.Point(252, 132)
        Me.Txtpassword.Name = "Txtpassword"
        Me.Txtpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Txtpassword.Size = New System.Drawing.Size(180, 30)
        Me.Txtpassword.TabIndex = 5
        Me.Txtpassword.UseSystemPasswordChar = True
        '
        'btnok
        '
        Me.btnok.BackColor = System.Drawing.Color.White
        Me.btnok.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnok.Location = New System.Drawing.Point(122, 178)
        Me.btnok.Name = "btnok"
        Me.btnok.Size = New System.Drawing.Size(81, 32)
        Me.btnok.TabIndex = 6
        Me.btnok.Text = "LOGIN"
        Me.btnok.UseVisualStyleBackColor = False
        '
        'btncancel
        '
        Me.btncancel.BackColor = System.Drawing.Color.White
        Me.btncancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancel.Location = New System.Drawing.Point(209, 178)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(79, 32)
        Me.btncancel.TabIndex = 7
        Me.btncancel.Text = "CANCEL"
        Me.btncancel.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Silver
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Cmbusertype)
        Me.Panel1.Controls.Add(Me.btncancel)
        Me.Panel1.Controls.Add(Me.Txtusername)
        Me.Panel1.Controls.Add(Me.btnok)
        Me.Panel1.Controls.Add(Me.Txtpassword)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(145, 215)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(448, 235)
        Me.Panel1.TabIndex = 8
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(294, 178)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(79, 32)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "EXIT"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Location = New System.Drawing.Point(25, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(674, 135)
        Me.Panel2.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Palatino Linotype", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(266, 67)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(176, 44)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Karkala"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(20, 17)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(49, 50)
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Palatino Linotype", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(95, 17)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(564, 50)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Dr.T.M.A.Pai Rotary Hospital"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Palatino Linotype", 20.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(297, 155)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(115, 44)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "LOGIN"
        '
        'frmogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(729, 483)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.Name = "frmogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Txtusername As System.Windows.Forms.TextBox
    Friend WithEvents Cmbusertype As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Txtpassword As System.Windows.Forms.TextBox
    Friend WithEvents btnok As System.Windows.Forms.Button
    Friend WithEvents btncancel As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label

End Class
