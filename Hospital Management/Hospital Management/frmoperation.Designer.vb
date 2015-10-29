<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmoperation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmoperation))
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.ListBox1 = New System.Windows.Forms.ListBox
        Me.btnadd = New System.Windows.Forms.Button
        Me.cmbdoctor = New System.Windows.Forms.ComboBox
        Me.btnremove = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmbnurse = New System.Windows.Forms.ComboBox
        Me.brnnurseremove = New System.Windows.Forms.Button
        Me.btnnurseadd = New System.Windows.Forms.Button
        Me.ListBox2 = New System.Windows.Forms.ListBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtcost = New System.Windows.Forms.TextBox
        Me.btnsave = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.cmbpatid = New System.Windows.Forms.ComboBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmboptype = New System.Windows.Forms.ComboBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(539, 222)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 13)
        Me.Label4.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 27)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(127, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "SELECT DOCTOR ID"
        '
        'ListBox1
        '
        Me.ListBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(137, 52)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(122, 69)
        Me.ListBox1.TabIndex = 9
        '
        'btnadd
        '
        Me.btnadd.Location = New System.Drawing.Point(12, 56)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(82, 25)
        Me.btnadd.TabIndex = 10
        Me.btnadd.Text = "ADD"
        Me.btnadd.UseVisualStyleBackColor = True
        '
        'cmbdoctor
        '
        Me.cmbdoctor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbdoctor.FormattingEnabled = True
        Me.cmbdoctor.Location = New System.Drawing.Point(137, 19)
        Me.cmbdoctor.Name = "cmbdoctor"
        Me.cmbdoctor.Size = New System.Drawing.Size(122, 21)
        Me.cmbdoctor.TabIndex = 11
        '
        'btnremove
        '
        Me.btnremove.Location = New System.Drawing.Point(12, 96)
        Me.btnremove.Name = "btnremove"
        Me.btnremove.Size = New System.Drawing.Size(82, 25)
        Me.btnremove.TabIndex = 12
        Me.btnremove.Text = "REMOVE"
        Me.btnremove.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "SELECT NURSE ID"
        '
        'cmbnurse
        '
        Me.cmbnurse.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbnurse.FormattingEnabled = True
        Me.cmbnurse.Location = New System.Drawing.Point(137, 19)
        Me.cmbnurse.Name = "cmbnurse"
        Me.cmbnurse.Size = New System.Drawing.Size(122, 21)
        Me.cmbnurse.TabIndex = 14
        '
        'brnnurseremove
        '
        Me.brnnurseremove.Location = New System.Drawing.Point(15, 96)
        Me.brnnurseremove.Name = "brnnurseremove"
        Me.brnnurseremove.Size = New System.Drawing.Size(82, 25)
        Me.brnnurseremove.TabIndex = 17
        Me.brnnurseremove.Text = "REMOVE"
        Me.brnnurseremove.UseVisualStyleBackColor = True
        '
        'btnnurseadd
        '
        Me.btnnurseadd.Location = New System.Drawing.Point(15, 52)
        Me.btnnurseadd.Name = "btnnurseadd"
        Me.btnnurseadd.Size = New System.Drawing.Size(82, 25)
        Me.btnnurseadd.TabIndex = 16
        Me.btnnurseadd.Text = "ADD"
        Me.btnnurseadd.UseVisualStyleBackColor = True
        '
        'ListBox2
        '
        Me.ListBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(137, 52)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(122, 69)
        Me.ListBox2.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(14, 397)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(116, 13)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "OPERATION COST"
        '
        'txtcost
        '
        Me.txtcost.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcost.Location = New System.Drawing.Point(149, 397)
        Me.txtcost.Name = "txtcost"
        Me.txtcost.Size = New System.Drawing.Size(122, 20)
        Me.txtcost.TabIndex = 20
        '
        'btnsave
        '
        Me.btnsave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.Location = New System.Drawing.Point(27, 443)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(82, 36)
        Me.btnsave.TabIndex = 22
        Me.btnsave.Text = "SAVE"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(14, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 13)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "OPERATION DATE"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(149, 39)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(122, 20)
        Me.DateTimePicker1.TabIndex = 25
        '
        'cmbpatid
        '
        Me.cmbpatid.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbpatid.FormattingEnabled = True
        Me.cmbpatid.Location = New System.Drawing.Point(149, 6)
        Me.cmbpatid.Name = "cmbpatid"
        Me.cmbpatid.Size = New System.Drawing.Size(122, 21)
        Me.cmbpatid.TabIndex = 24
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(12, 9)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(128, 13)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "SELECT PATIENT ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(135, 13)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "TYPE OF OPERATION"
        '
        'cmboptype
        '
        Me.cmboptype.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmboptype.FormattingEnabled = True
        Me.cmboptype.Items.AddRange(New Object() {"xyz", "abc"})
        Me.cmboptype.Location = New System.Drawing.Point(149, 74)
        Me.cmboptype.Name = "cmboptype"
        Me.cmboptype.Size = New System.Drawing.Size(122, 21)
        Me.cmboptype.TabIndex = 28
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.cmbdoctor)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.ListBox1)
        Me.GroupBox1.Controls.Add(Me.btnadd)
        Me.GroupBox1.Controls.Add(Me.btnremove)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 108)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(259, 127)
        Me.GroupBox1.TabIndex = 29
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DOCTOR DETAILS"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.btnnurseadd)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.cmbnurse)
        Me.GroupBox2.Controls.Add(Me.ListBox2)
        Me.GroupBox2.Controls.Add(Me.brnnurseremove)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 241)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(259, 132)
        Me.GroupBox2.TabIndex = 30
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "NURSE DETAILS"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(165, 443)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(85, 36)
        Me.Button1.TabIndex = 31
        Me.Button1.Text = "EXIT"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(286, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(465, 490)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 32
        Me.PictureBox1.TabStop = False
        '
        'frmoperation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(756, 508)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmboptype)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.cmbpatid)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.txtcost)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmoperation"
        Me.Text = "frmoperation"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents btnadd As System.Windows.Forms.Button
    Friend WithEvents cmbdoctor As System.Windows.Forms.ComboBox
    Friend WithEvents btnremove As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbnurse As System.Windows.Forms.ComboBox
    Friend WithEvents brnnurseremove As System.Windows.Forms.Button
    Friend WithEvents btnnurseadd As System.Windows.Forms.Button
    Friend WithEvents ListBox2 As System.Windows.Forms.ListBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtcost As System.Windows.Forms.TextBox
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbpatid As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmboptype As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
