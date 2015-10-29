<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmdischarge
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmdischarge))
        Me.cmbpatid = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtroomcharge = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtdocCharge = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtoperationcharge = New System.Windows.Forms.TextBox
        Me.txtmedcharge = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txttoalopcharge = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtadvpay = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txttotalcharge = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.txtdiscount = New System.Windows.Forms.TextBox
        Me.txtfinalamount = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        Me.btnsave = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtpname = New System.Windows.Forms.TextBox
        Me.txtbillno = New System.Windows.Forms.TextBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbpatid
        '
        Me.cmbpatid.FormattingEnabled = True
        Me.cmbpatid.Location = New System.Drawing.Point(299, 14)
        Me.cmbpatid.Name = "cmbpatid"
        Me.cmbpatid.Size = New System.Drawing.Size(140, 21)
        Me.cmbpatid.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(29, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(254, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "SELECT THE PATIENT ID TO DISCHARGE"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(30, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "ROOM CHARGE"
        '
        'txtroomcharge
        '
        Me.txtroomcharge.Enabled = False
        Me.txtroomcharge.Location = New System.Drawing.Point(300, 78)
        Me.txtroomcharge.Name = "txtroomcharge"
        Me.txtroomcharge.Size = New System.Drawing.Size(140, 20)
        Me.txtroomcharge.TabIndex = 3
        Me.txtroomcharge.Text = "0"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(109, 33)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(174, 20)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "CONFIRM DISCHARGE"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column8, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7})
        Me.DataGridView1.Location = New System.Drawing.Point(14, 400)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(565, 83)
        Me.DataGridView1.TabIndex = 5
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column1.HeaderText = "PId"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 51
        '
        'Column8
        '
        Me.Column8.HeaderText = "Roomtype"
        Me.Column8.Name = "Column8"
        Me.Column8.Width = 50
        '
        'Column2
        '
        Me.Column2.HeaderText = "RoomNo"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 50
        '
        'Column3
        '
        Me.Column3.HeaderText = "BedNo"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 50
        '
        'Column4
        '
        Me.Column4.HeaderText = "Join date"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "Shift date"
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.HeaderText = "num of days"
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 50
        '
        'Column7
        '
        Me.Column7.HeaderText = "Roomcharge"
        Me.Column7.Name = "Column7"
        Me.Column7.Width = 70
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(30, 109)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "DOCTOR CHARGE"
        '
        'txtdocCharge
        '
        Me.txtdocCharge.Enabled = False
        Me.txtdocCharge.Location = New System.Drawing.Point(300, 106)
        Me.txtdocCharge.Name = "txtdocCharge"
        Me.txtdocCharge.Size = New System.Drawing.Size(140, 20)
        Me.txtdocCharge.TabIndex = 9
        Me.txtdocCharge.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(27, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(126, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "OPRATION CHARGE"
        '
        'txtoperationcharge
        '
        Me.txtoperationcharge.Enabled = False
        Me.txtoperationcharge.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtoperationcharge.Location = New System.Drawing.Point(297, 19)
        Me.txtoperationcharge.Name = "txtoperationcharge"
        Me.txtoperationcharge.Size = New System.Drawing.Size(140, 20)
        Me.txtoperationcharge.TabIndex = 11
        Me.txtoperationcharge.Text = "0"
        '
        'txtmedcharge
        '
        Me.txtmedcharge.Enabled = False
        Me.txtmedcharge.Location = New System.Drawing.Point(300, 134)
        Me.txtmedcharge.Name = "txtmedcharge"
        Me.txtmedcharge.Size = New System.Drawing.Size(140, 20)
        Me.txtmedcharge.TabIndex = 12
        Me.txtmedcharge.Text = "0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(30, 137)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(122, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "MEDICINE CHARGE"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txttoalopcharge)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtadvpay)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtoperationcharge)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(3, 163)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(437, 102)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "OPERATION DETAILS"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(27, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "BALANCE"
        '
        'txttoalopcharge
        '
        Me.txttoalopcharge.Enabled = False
        Me.txttoalopcharge.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttoalopcharge.Location = New System.Drawing.Point(297, 73)
        Me.txttoalopcharge.Name = "txttoalopcharge"
        Me.txttoalopcharge.Size = New System.Drawing.Size(140, 20)
        Me.txttoalopcharge.TabIndex = 18
        Me.txttoalopcharge.Text = "0"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(-3, 85)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(0, 13)
        Me.Label8.TabIndex = 17
        '
        'txtadvpay
        '
        Me.txtadvpay.Enabled = False
        Me.txtadvpay.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtadvpay.Location = New System.Drawing.Point(297, 41)
        Me.txtadvpay.Name = "txtadvpay"
        Me.txtadvpay.Size = New System.Drawing.Size(140, 20)
        Me.txtadvpay.TabIndex = 16
        Me.txtadvpay.Text = "0"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(27, 48)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(128, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "ADVANCE PAYMENT"
        '
        'txttotalcharge
        '
        Me.txttotalcharge.Enabled = False
        Me.txttotalcharge.Location = New System.Drawing.Point(299, 271)
        Me.txttotalcharge.Name = "txttotalcharge"
        Me.txttotalcharge.Size = New System.Drawing.Size(140, 20)
        Me.txttotalcharge.TabIndex = 15
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(29, 278)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(77, 13)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "TOTAL BILL"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(29, 306)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(94, 13)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "HEALTH CARD"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.BackColor = System.Drawing.Color.Transparent
        Me.RadioButton1.Location = New System.Drawing.Point(299, 302)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(49, 17)
        Me.RadioButton1.TabIndex = 18
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "YES"
        Me.RadioButton1.UseVisualStyleBackColor = False
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.BackColor = System.Drawing.Color.Transparent
        Me.RadioButton2.Location = New System.Drawing.Point(374, 302)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(43, 17)
        Me.RadioButton2.TabIndex = 19
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "NO"
        Me.RadioButton2.UseVisualStyleBackColor = False
        '
        'txtdiscount
        '
        Me.txtdiscount.Location = New System.Drawing.Point(299, 329)
        Me.txtdiscount.Name = "txtdiscount"
        Me.txtdiscount.Size = New System.Drawing.Size(140, 20)
        Me.txtdiscount.TabIndex = 20
        Me.txtdiscount.Text = "0"
        '
        'txtfinalamount
        '
        Me.txtfinalamount.Enabled = False
        Me.txtfinalamount.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfinalamount.Location = New System.Drawing.Point(299, 359)
        Me.txtfinalamount.Name = "txtfinalamount"
        Me.txtfinalamount.Size = New System.Drawing.Size(140, 20)
        Me.txtfinalamount.TabIndex = 53
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(29, 332)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(147, 13)
        Me.Label11.TabIndex = 54
        Me.Label11.Text = "ENTER DISCOUNT IN %"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(29, 362)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(151, 13)
        Me.Label12.TabIndex = 55
        Me.Label12.Text = "TOTAL BILL TO BE PAID"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(431, 489)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(183, 33)
        Me.Button2.TabIndex = 56
        Me.Button2.Text = "EXIT"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnsave
        '
        Me.btnsave.Location = New System.Drawing.Point(234, 489)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(177, 33)
        Me.btnsave.TabIndex = 57
        Me.btnsave.Text = "CLEAR"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.txtpname)
        Me.Panel1.Controls.Add(Me.txtbillno)
        Me.Panel1.Controls.Add(Me.txttotalcharge)
        Me.Panel1.Controls.Add(Me.cmbpatid)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.txtroomcharge)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txtfinalamount)
        Me.Panel1.Controls.Add(Me.txtdocCharge)
        Me.Panel1.Controls.Add(Me.txtdiscount)
        Me.Panel1.Controls.Add(Me.txtmedcharge)
        Me.Panel1.Controls.Add(Me.RadioButton2)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.RadioButton1)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(450, 382)
        Me.Panel1.TabIndex = 59
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(106, 55)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(51, 13)
        Me.Label13.TabIndex = 58
        Me.Label13.Text = "BILLNO"
        '
        'txtpname
        '
        Me.txtpname.Location = New System.Drawing.Point(159, 102)
        Me.txtpname.Name = "txtpname"
        Me.txtpname.Size = New System.Drawing.Size(100, 20)
        Me.txtpname.TabIndex = 57
        '
        'txtbillno
        '
        Me.txtbillno.Enabled = False
        Me.txtbillno.Location = New System.Drawing.Point(222, 52)
        Me.txtbillno.Name = "txtbillno"
        Me.txtbillno.Size = New System.Drawing.Size(100, 20)
        Me.txtbillno.TabIndex = 56
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(469, 29)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(423, 346)
        Me.PictureBox1.TabIndex = 58
        Me.PictureBox1.TabStop = False
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(45, 489)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(177, 33)
        Me.Button3.TabIndex = 60
        Me.Button3.Text = "SAVE"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(650, 400)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(177, 33)
        Me.Button4.TabIndex = 61
        Me.Button4.Text = "PRINT"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'frmdischarge
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(904, 525)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmdischarge"
        Me.Text = "frmdischarge"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmbpatid As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtroomcharge As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtdocCharge As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtoperationcharge As System.Windows.Forms.TextBox
    Friend WithEvents txtmedcharge As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtadvpay As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txttoalopcharge As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txttotalcharge As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents txtdiscount As System.Windows.Forms.TextBox
    Friend WithEvents txtfinalamount As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents txtbillno As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtpname As System.Windows.Forms.TextBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
End Class
