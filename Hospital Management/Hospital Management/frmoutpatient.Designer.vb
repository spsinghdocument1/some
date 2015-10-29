<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmoutpatient
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmoutpatient))
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtdocname = New System.Windows.Forms.TextBox
        Me.cmbbloodgroup = New System.Windows.Forms.ComboBox
        Me.cmbgender = New System.Windows.Forms.ComboBox
        Me.Button5 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.ADD = New System.Windows.Forms.Button
        Me.cmbDoctid = New System.Windows.Forms.ComboBox
        Me.txtadd = New System.Windows.Forms.TextBox
        Me.txtphone = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtdesies = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtname = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Txtoutpatid = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmboutpatientid = New System.Windows.Forms.ComboBox
        Me.btnupdate = New System.Windows.Forms.Button
        Me.btndelete = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label8 = New System.Windows.Forms.Label
        Me.cmbdept = New System.Windows.Forms.ComboBox
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(21, 306)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(98, 13)
        Me.Label13.TabIndex = 60
        Me.Label13.Text = "DOCTOR NAME"
        '
        'txtdocname
        '
        Me.txtdocname.Location = New System.Drawing.Point(217, 306)
        Me.txtdocname.Name = "txtdocname"
        Me.txtdocname.Size = New System.Drawing.Size(137, 20)
        Me.txtdocname.TabIndex = 59
        '
        'cmbbloodgroup
        '
        Me.cmbbloodgroup.FormattingEnabled = True
        Me.cmbbloodgroup.Items.AddRange(New Object() {"A +ve", "A -ve", "B +ve", "B -ve", "O +ve", "O -ve", "AB +ve", "AB -ve"})
        Me.cmbbloodgroup.Location = New System.Drawing.Point(220, 166)
        Me.cmbbloodgroup.Name = "cmbbloodgroup"
        Me.cmbbloodgroup.Size = New System.Drawing.Size(134, 21)
        Me.cmbbloodgroup.TabIndex = 58
        '
        'cmbgender
        '
        Me.cmbgender.FormattingEnabled = True
        Me.cmbgender.Items.AddRange(New Object() {"Male", "Female"})
        Me.cmbgender.Location = New System.Drawing.Point(220, 103)
        Me.cmbgender.Name = "cmbgender"
        Me.cmbgender.Size = New System.Drawing.Size(134, 21)
        Me.cmbgender.TabIndex = 57
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(381, 8)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(87, 33)
        Me.Button5.TabIndex = 56
        Me.Button5.Text = "EXIT"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(287, 8)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(87, 33)
        Me.Button2.TabIndex = 55
        Me.Button2.Text = "RESET"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ADD
        '
        Me.ADD.Location = New System.Drawing.Point(3, 8)
        Me.ADD.Name = "ADD"
        Me.ADD.Size = New System.Drawing.Size(87, 33)
        Me.ADD.TabIndex = 54
        Me.ADD.Text = "ADD"
        Me.ADD.UseVisualStyleBackColor = True
        '
        'cmbDoctid
        '
        Me.cmbDoctid.FormattingEnabled = True
        Me.cmbDoctid.Location = New System.Drawing.Point(217, 279)
        Me.cmbDoctid.Name = "cmbDoctid"
        Me.cmbDoctid.Size = New System.Drawing.Size(137, 21)
        Me.cmbDoctid.TabIndex = 53
        '
        'txtadd
        '
        Me.txtadd.Location = New System.Drawing.Point(217, 367)
        Me.txtadd.Multiline = True
        Me.txtadd.Name = "txtadd"
        Me.txtadd.Size = New System.Drawing.Size(137, 66)
        Me.txtadd.TabIndex = 52
        '
        'txtphone
        '
        Me.txtphone.Location = New System.Drawing.Point(217, 335)
        Me.txtphone.Name = "txtphone"
        Me.txtphone.Size = New System.Drawing.Size(137, 20)
        Me.txtphone.TabIndex = 51
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(21, 370)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(66, 13)
        Me.Label12.TabIndex = 50
        Me.Label12.Text = "ADDRESS"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(21, 338)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(50, 13)
        Me.Label11.TabIndex = 49
        Me.Label11.Text = "PHONE"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(21, 279)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(76, 13)
        Me.Label10.TabIndex = 48
        Me.Label10.Text = "DOCTOR ID"
        '
        'txtdesies
        '
        Me.txtdesies.Location = New System.Drawing.Point(220, 202)
        Me.txtdesies.Multiline = True
        Me.txtdesies.Name = "txtdesies"
        Me.txtdesies.Size = New System.Drawing.Size(134, 41)
        Me.txtdesies.TabIndex = 47
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(21, 174)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(97, 13)
        Me.Label7.TabIndex = 46
        Me.Label7.Text = "BLOOD GROUP"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(21, 205)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 13)
        Me.Label6.TabIndex = 45
        Me.Label6.Text = "DISEASE"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(220, 137)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(134, 20)
        Me.DateTimePicker2.TabIndex = 44
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(21, 143)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 13)
        Me.Label5.TabIndex = 43
        Me.Label5.Text = "DATE OF VISIT"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(21, 111)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 13)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = "GENDER"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(220, 71)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(134, 20)
        Me.DateTimePicker1.TabIndex = 41
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 13)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "DATE OF BIRTH"
        '
        'txtname
        '
        Me.txtname.Location = New System.Drawing.Point(220, 35)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(134, 20)
        Me.txtname.TabIndex = 39
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "NAME"
        '
        'Txtoutpatid
        '
        Me.Txtoutpatid.Enabled = False
        Me.Txtoutpatid.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtoutpatid.Location = New System.Drawing.Point(217, 15)
        Me.Txtoutpatid.Name = "Txtoutpatid"
        Me.Txtoutpatid.Size = New System.Drawing.Size(134, 20)
        Me.Txtoutpatid.TabIndex = 37
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 13)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "OUTPATIENT ID"
        '
        'cmboutpatientid
        '
        Me.cmboutpatientid.FormattingEnabled = True
        Me.cmboutpatientid.Location = New System.Drawing.Point(217, 12)
        Me.cmboutpatientid.Name = "cmboutpatientid"
        Me.cmboutpatientid.Size = New System.Drawing.Size(137, 21)
        Me.cmboutpatientid.TabIndex = 61
        '
        'btnupdate
        '
        Me.btnupdate.Location = New System.Drawing.Point(98, 8)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(87, 33)
        Me.btnupdate.TabIndex = 62
        Me.btnupdate.Text = "UPDATE"
        Me.btnupdate.UseVisualStyleBackColor = True
        '
        'btndelete
        '
        Me.btndelete.Location = New System.Drawing.Point(192, 8)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(87, 33)
        Me.btndelete.TabIndex = 63
        Me.btndelete.Text = "DELETE"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.cmbdept)
        Me.Panel1.Controls.Add(Me.txtdesies)
        Me.Panel1.Controls.Add(Me.Txtoutpatid)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.cmboutpatientid)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.txtname)
        Me.Panel1.Controls.Add(Me.txtdocname)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.cmbbloodgroup)
        Me.Panel1.Controls.Add(Me.DateTimePicker1)
        Me.Panel1.Controls.Add(Me.cmbgender)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.DateTimePicker2)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.cmbDoctid)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.txtadd)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.txtphone)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Location = New System.Drawing.Point(3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(392, 441)
        Me.Panel1.TabIndex = 64
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(21, 260)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(92, 13)
        Me.Label8.TabIndex = 68
        Me.Label8.Text = "DEPARTMENT"
        '
        'cmbdept
        '
        Me.cmbdept.FormattingEnabled = True
        Me.cmbdept.Location = New System.Drawing.Point(217, 252)
        Me.cmbdept.Name = "cmbdept"
        Me.cmbdept.Size = New System.Drawing.Size(137, 21)
        Me.cmbdept.TabIndex = 67
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.ADD)
        Me.Panel2.Controls.Add(Me.btnupdate)
        Me.Panel2.Controls.Add(Me.Button5)
        Me.Panel2.Controls.Add(Me.btndelete)
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Location = New System.Drawing.Point(161, 441)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(472, 49)
        Me.Panel2.TabIndex = 65
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(463, 126)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(265, 192)
        Me.PictureBox1.TabIndex = 66
        Me.PictureBox1.TabStop = False
        '
        'frmoutpatient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(829, 489)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmoutpatient"
        Me.Text = "outpatient"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtdocname As System.Windows.Forms.TextBox
    Friend WithEvents cmbbloodgroup As System.Windows.Forms.ComboBox
    Friend WithEvents cmbgender As System.Windows.Forms.ComboBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents ADD As System.Windows.Forms.Button
    Friend WithEvents cmbDoctid As System.Windows.Forms.ComboBox
    Friend WithEvents txtadd As System.Windows.Forms.TextBox
    Friend WithEvents txtphone As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtdesies As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtname As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Txtoutpatid As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmboutpatientid As System.Windows.Forms.ComboBox
    Friend WithEvents btnupdate As System.Windows.Forms.Button
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents cmbdept As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
End Class
