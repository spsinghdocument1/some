<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmoutpatientbill
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmoutpatientbill))
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnsave = New System.Windows.Forms.Button
        Me.txtbillno = New System.Windows.Forms.TextBox
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.cmbopid = New System.Windows.Forms.ComboBox
        Me.txtpatname = New System.Windows.Forms.TextBox
        Me.txtfees = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtmedcharge = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtdoccharge = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Button3 = New System.Windows.Forms.Button
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(12, 276)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 19)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Total Bill"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 178)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 19)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Patient Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 137)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 19)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Patient Id"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 19)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Bill Date"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 19)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "BILL NO"
        '
        'btnsave
        '
        Me.btnsave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.Location = New System.Drawing.Point(14, 380)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(75, 28)
        Me.btnsave.TabIndex = 16
        Me.btnsave.Text = "SAVE"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'txtbillno
        '
        Me.txtbillno.Location = New System.Drawing.Point(95, 61)
        Me.txtbillno.Name = "txtbillno"
        Me.txtbillno.Size = New System.Drawing.Size(72, 20)
        Me.txtbillno.TabIndex = 17
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(147, 99)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(100, 20)
        Me.DateTimePicker1.TabIndex = 18
        '
        'cmbopid
        '
        Me.cmbopid.FormattingEnabled = True
        Me.cmbopid.Location = New System.Drawing.Point(147, 138)
        Me.cmbopid.Name = "cmbopid"
        Me.cmbopid.Size = New System.Drawing.Size(100, 21)
        Me.cmbopid.TabIndex = 19
        '
        'txtpatname
        '
        Me.txtpatname.Location = New System.Drawing.Point(147, 179)
        Me.txtpatname.Name = "txtpatname"
        Me.txtpatname.Size = New System.Drawing.Size(100, 20)
        Me.txtpatname.TabIndex = 20
        '
        'txtfees
        '
        Me.txtfees.Location = New System.Drawing.Point(143, 277)
        Me.txtfees.Name = "txtfees"
        Me.txtfees.Size = New System.Drawing.Size(100, 20)
        Me.txtfees.TabIndex = 21
        Me.txtfees.Text = "0"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(180, 404)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 28)
        Me.Button1.TabIndex = 22
        Me.Button1.Text = "EXIT"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(92, 404)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 28)
        Me.Button2.TabIndex = 23
        Me.Button2.Text = "CLEAR"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(263, 35)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(244, 306)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 24
        Me.PictureBox1.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Black
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(25, 1)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(471, 31)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Dr.T.M.A Pai Rotary Hospital Karkala"
        '
        'txtmedcharge
        '
        Me.txtmedcharge.Location = New System.Drawing.Point(147, 241)
        Me.txtmedcharge.Name = "txtmedcharge"
        Me.txtmedcharge.Size = New System.Drawing.Size(100, 20)
        Me.txtmedcharge.TabIndex = 31
        Me.txtmedcharge.Text = "0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 244)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(122, 13)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "MEDICINE CHARGE"
        '
        'txtdoccharge
        '
        Me.txtdoccharge.Location = New System.Drawing.Point(147, 205)
        Me.txtdoccharge.Name = "txtdoccharge"
        Me.txtdoccharge.Size = New System.Drawing.Size(100, 20)
        Me.txtdoccharge.TabIndex = 29
        Me.txtdoccharge.Text = "0"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(8, 213)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(114, 13)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "DOCTOR CHARGE"
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(263, 404)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 28)
        Me.Button3.TabIndex = 32
        Me.Button3.Text = "PRINT"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'frmoutpatientbill
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(594, 465)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.txtmedcharge)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtdoccharge)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtfees)
        Me.Controls.Add(Me.txtpatname)
        Me.Controls.Add(Me.cmbopid)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.txtbillno)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmoutpatientbill"
        Me.Text = "frmoutpatientbill"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents txtbillno As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbopid As System.Windows.Forms.ComboBox
    Friend WithEvents txtpatname As System.Windows.Forms.TextBox
    Friend WithEvents txtfees As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtmedcharge As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtdoccharge As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class
