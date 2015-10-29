<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frminpatient
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frminpatient))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Txtinpatid = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtname = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtdesies = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtphone = New System.Windows.Forms.TextBox
        Me.txtadd = New System.Windows.Forms.TextBox
        Me.cmbDoctid = New System.Windows.Forms.ComboBox
        Me.cmbroomno = New System.Windows.Forms.ComboBox
        Me.cmbroomtype = New System.Windows.Forms.ComboBox
        Me.ADD = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        Me.lblbednum = New System.Windows.Forms.Label
        Me.cmbbedno = New System.Windows.Forms.ComboBox
        Me.cmbgender = New System.Windows.Forms.ComboBox
        Me.cmbbloodgroup = New System.Windows.Forms.ComboBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtdocname = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.cmbInpatientId = New System.Windows.Forms.ComboBox
        Me.btnupdate = New System.Windows.Forms.Button
        Me.btndelete = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label14 = New System.Windows.Forms.Label
        Me.cmbdept = New System.Windows.Forms.ComboBox
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label15 = New System.Windows.Forms.Label
        Me.txtadv = New System.Windows.Forms.TextBox
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(6, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "INPATIENT ID"
        '
        'Txtinpatid
        '
        Me.Txtinpatid.AllowDrop = True
        Me.Txtinpatid.Enabled = False
        Me.Txtinpatid.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtinpatid.Location = New System.Drawing.Point(167, 11)
        Me.Txtinpatid.Name = "Txtinpatid"
        Me.Txtinpatid.Size = New System.Drawing.Size(137, 20)
        Me.Txtinpatid.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(6, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "NAME"
        '
        'txtname
        '
        Me.txtname.Location = New System.Drawing.Point(169, 37)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(140, 20)
        Me.txtname.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(6, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "DATE OF BIRTH"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(169, 69)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(140, 20)
        Me.DateTimePicker1.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(6, 106)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "GENDER"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(6, 135)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "DATE OF ADMIT"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(169, 129)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(140, 20)
        Me.DateTimePicker2.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(6, 199)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "DISEASE"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(6, 165)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(97, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "BLOOD GROUP"
        '
        'txtdesies
        '
        Me.txtdesies.Location = New System.Drawing.Point(169, 190)
        Me.txtdesies.Multiline = True
        Me.txtdesies.Name = "txtdesies"
        Me.txtdesies.Size = New System.Drawing.Size(140, 45)
        Me.txtdesies.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(40, 88)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(101, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "ROOM NUMBER"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(40, 49)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 13)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "ROOM TYPE"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Location = New System.Drawing.Point(6, 272)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(76, 13)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "DOCTOR ID"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Location = New System.Drawing.Point(6, 333)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(50, 13)
        Me.Label11.TabIndex = 17
        Me.Label11.Text = "PHONE"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Location = New System.Drawing.Point(6, 362)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(66, 13)
        Me.Label12.TabIndex = 18
        Me.Label12.Text = "ADDRESS"
        '
        'txtphone
        '
        Me.txtphone.Location = New System.Drawing.Point(169, 326)
        Me.txtphone.MaxLength = 10
        Me.txtphone.Name = "txtphone"
        Me.txtphone.Size = New System.Drawing.Size(140, 20)
        Me.txtphone.TabIndex = 19
        '
        'txtadd
        '
        Me.txtadd.Location = New System.Drawing.Point(169, 359)
        Me.txtadd.Multiline = True
        Me.txtadd.Name = "txtadd"
        Me.txtadd.Size = New System.Drawing.Size(140, 66)
        Me.txtadd.TabIndex = 20
        '
        'cmbDoctid
        '
        Me.cmbDoctid.FormattingEnabled = True
        Me.cmbDoctid.Location = New System.Drawing.Point(169, 272)
        Me.cmbDoctid.Name = "cmbDoctid"
        Me.cmbDoctid.Size = New System.Drawing.Size(140, 21)
        Me.cmbDoctid.TabIndex = 21
        '
        'cmbroomno
        '
        Me.cmbroomno.FormattingEnabled = True
        Me.cmbroomno.Location = New System.Drawing.Point(175, 88)
        Me.cmbroomno.Name = "cmbroomno"
        Me.cmbroomno.Size = New System.Drawing.Size(116, 21)
        Me.cmbroomno.TabIndex = 22
        '
        'cmbroomtype
        '
        Me.cmbroomtype.FormattingEnabled = True
        Me.cmbroomtype.Items.AddRange(New Object() {"General Ward", "Semi", "Special ward", "ICU", "Operation Theatre"})
        Me.cmbroomtype.Location = New System.Drawing.Point(175, 46)
        Me.cmbroomtype.Name = "cmbroomtype"
        Me.cmbroomtype.Size = New System.Drawing.Size(116, 21)
        Me.cmbroomtype.TabIndex = 23
        '
        'ADD
        '
        Me.ADD.Location = New System.Drawing.Point(13, 8)
        Me.ADD.Name = "ADD"
        Me.ADD.Size = New System.Drawing.Size(87, 33)
        Me.ADD.TabIndex = 24
        Me.ADD.Text = "ADD"
        Me.ADD.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(106, 8)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(87, 33)
        Me.Button2.TabIndex = 25
        Me.Button2.Text = "RESET"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(385, 8)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(87, 33)
        Me.Button5.TabIndex = 28
        Me.Button5.Text = "EXIT"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'lblbednum
        '
        Me.lblbednum.AutoSize = True
        Me.lblbednum.Location = New System.Drawing.Point(40, 127)
        Me.lblbednum.Name = "lblbednum"
        Me.lblbednum.Size = New System.Drawing.Size(89, 13)
        Me.lblbednum.TabIndex = 29
        Me.lblbednum.Text = "BED NUMBER"
        '
        'cmbbedno
        '
        Me.cmbbedno.FormattingEnabled = True
        Me.cmbbedno.Location = New System.Drawing.Point(175, 124)
        Me.cmbbedno.Name = "cmbbedno"
        Me.cmbbedno.Size = New System.Drawing.Size(116, 21)
        Me.cmbbedno.TabIndex = 30
        '
        'cmbgender
        '
        Me.cmbgender.FormattingEnabled = True
        Me.cmbgender.Items.AddRange(New Object() {"Male", "Female"})
        Me.cmbgender.Location = New System.Drawing.Point(169, 98)
        Me.cmbgender.Name = "cmbgender"
        Me.cmbgender.Size = New System.Drawing.Size(140, 21)
        Me.cmbgender.TabIndex = 31
        '
        'cmbbloodgroup
        '
        Me.cmbbloodgroup.FormattingEnabled = True
        Me.cmbbloodgroup.Items.AddRange(New Object() {"A +ve", "A -ve", "B +ve", "B -ve", "O +ve", "O -ve", "AB +ve", "AB -ve"})
        Me.cmbbloodgroup.Location = New System.Drawing.Point(169, 162)
        Me.cmbbloodgroup.Name = "cmbbloodgroup"
        Me.cmbbloodgroup.Size = New System.Drawing.Size(140, 21)
        Me.cmbbloodgroup.TabIndex = 32
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.cmbroomno)
        Me.GroupBox1.Controls.Add(Me.cmbbedno)
        Me.GroupBox1.Controls.Add(Me.cmbroomtype)
        Me.GroupBox1.Controls.Add(Me.lblbednum)
        Me.GroupBox1.Location = New System.Drawing.Point(356, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(351, 179)
        Me.GroupBox1.TabIndex = 33
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ROOM DETAILS"
        '
        'txtdocname
        '
        Me.txtdocname.Location = New System.Drawing.Point(169, 299)
        Me.txtdocname.Name = "txtdocname"
        Me.txtdocname.Size = New System.Drawing.Size(140, 20)
        Me.txtdocname.TabIndex = 34
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Location = New System.Drawing.Point(6, 302)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(98, 13)
        Me.Label13.TabIndex = 35
        Me.Label13.Text = "DOCTOR NAME"
        '
        'cmbInpatientId
        '
        Me.cmbInpatientId.FormattingEnabled = True
        Me.cmbInpatientId.Location = New System.Drawing.Point(169, 3)
        Me.cmbInpatientId.Name = "cmbInpatientId"
        Me.cmbInpatientId.Size = New System.Drawing.Size(140, 21)
        Me.cmbInpatientId.TabIndex = 36
        '
        'btnupdate
        '
        Me.btnupdate.Location = New System.Drawing.Point(199, 8)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(87, 33)
        Me.btnupdate.TabIndex = 37
        Me.btnupdate.Text = "UPDATE"
        Me.btnupdate.UseVisualStyleBackColor = True
        '
        'btndelete
        '
        Me.btndelete.Location = New System.Drawing.Point(292, 8)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(87, 33)
        Me.btndelete.TabIndex = 38
        Me.btndelete.Text = "DELETE"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(356, 202)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(351, 235)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 39
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.cmbdept)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Txtinpatid)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.cmbInpatientId)
        Me.Panel1.Controls.Add(Me.txtname)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.DateTimePicker1)
        Me.Panel1.Controls.Add(Me.txtdocname)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.cmbbloodgroup)
        Me.Panel1.Controls.Add(Me.DateTimePicker2)
        Me.Panel1.Controls.Add(Me.cmbgender)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.txtdesies)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.cmbDoctid)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.txtadd)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.txtphone)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(328, 436)
        Me.Panel1.TabIndex = 40
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Location = New System.Drawing.Point(6, 245)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(92, 13)
        Me.Label14.TabIndex = 38
        Me.Label14.Tag = "TMENT"
        Me.Label14.Text = "DEPARTMENT"
        '
        'cmbdept
        '
        Me.cmbdept.FormattingEnabled = True
        Me.cmbdept.Location = New System.Drawing.Point(169, 245)
        Me.cmbdept.Name = "cmbdept"
        Me.cmbdept.Size = New System.Drawing.Size(140, 21)
        Me.cmbdept.TabIndex = 37
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.ADD)
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.Button5)
        Me.Panel2.Controls.Add(Me.btndelete)
        Me.Panel2.Controls.Add(Me.btnupdate)
        Me.Panel2.Location = New System.Drawing.Point(123, 454)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(492, 57)
        Me.Panel2.TabIndex = 37
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Location = New System.Drawing.Point(393, 246)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(109, 13)
        Me.Label15.TabIndex = 31
        Me.Label15.Text = "Advance Payment"
        '
        'txtadv
        '
        Me.txtadv.Location = New System.Drawing.Point(538, 243)
        Me.txtadv.Name = "txtadv"
        Me.txtadv.Size = New System.Drawing.Size(140, 20)
        Me.txtadv.TabIndex = 41
        '
        'frminpatient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(774, 503)
        Me.Controls.Add(Me.txtadv)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frminpatient"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Txtinpatid As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtname As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtdesies As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtphone As System.Windows.Forms.TextBox
    Friend WithEvents txtadd As System.Windows.Forms.TextBox
    Friend WithEvents cmbDoctid As System.Windows.Forms.ComboBox
    Friend WithEvents cmbroomno As System.Windows.Forms.ComboBox
    Friend WithEvents cmbroomtype As System.Windows.Forms.ComboBox
    Friend WithEvents ADD As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents lblbednum As System.Windows.Forms.Label
    Friend WithEvents cmbbedno As System.Windows.Forms.ComboBox
    Friend WithEvents cmbgender As System.Windows.Forms.ComboBox
    Friend WithEvents cmbbloodgroup As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtdocname As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cmbInpatientId As System.Windows.Forms.ComboBox
    Friend WithEvents btnupdate As System.Windows.Forms.Button
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents cmbdept As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtadv As System.Windows.Forms.TextBox
End Class
