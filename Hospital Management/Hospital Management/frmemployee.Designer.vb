<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmemployee
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
        Me.Txtempid = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Txtempname = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.Label5 = New System.Windows.Forms.Label
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtqualification = New System.Windows.Forms.TextBox
        Me.Btnadd = New System.Windows.Forms.Button
        Me.btnreset = New System.Windows.Forms.Button
        Me.btncancel = New System.Windows.Forms.Button
        Me.cmbdesig = New System.Windows.Forms.ComboBox
        Me.txtsalary = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.btnupdate = New System.Windows.Forms.Button
        Me.btndelete = New System.Windows.Forms.Button
        Me.DateTimePicker3 = New System.Windows.Forms.DateTimePicker
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "EMPLOYEE ID"
        '
        'Txtempid
        '
        Me.Txtempid.Enabled = False
        Me.Txtempid.Location = New System.Drawing.Point(180, 52)
        Me.Txtempid.Name = "Txtempid"
        Me.Txtempid.Size = New System.Drawing.Size(140, 20)
        Me.Txtempid.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(35, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "EMPLOYEE NAME"
        '
        'Txtempname
        '
        Me.Txtempname.Location = New System.Drawing.Point(180, 84)
        Me.Txtempname.Name = "Txtempname"
        Me.Txtempname.Size = New System.Drawing.Size(140, 20)
        Me.Txtempname.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(35, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "DESIGNATION"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(35, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "DATE OF BIRTH"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(180, 114)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(140, 20)
        Me.DateTimePicker1.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(35, 152)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "DATE OF JOIN"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(180, 147)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(140, 20)
        Me.DateTimePicker2.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(35, 210)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(101, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "QUALIFICATION"
        '
        'txtqualification
        '
        Me.txtqualification.Location = New System.Drawing.Point(180, 207)
        Me.txtqualification.Name = "txtqualification"
        Me.txtqualification.Size = New System.Drawing.Size(140, 20)
        Me.txtqualification.TabIndex = 11
        '
        'Btnadd
        '
        Me.Btnadd.Location = New System.Drawing.Point(3, 20)
        Me.Btnadd.Name = "Btnadd"
        Me.Btnadd.Size = New System.Drawing.Size(87, 28)
        Me.Btnadd.TabIndex = 12
        Me.Btnadd.Text = "ADD"
        Me.Btnadd.UseVisualStyleBackColor = True
        '
        'btnreset
        '
        Me.btnreset.Location = New System.Drawing.Point(138, 20)
        Me.btnreset.Name = "btnreset"
        Me.btnreset.Size = New System.Drawing.Size(87, 28)
        Me.btnreset.TabIndex = 13
        Me.btnreset.Text = "RESET"
        Me.btnreset.UseVisualStyleBackColor = True
        '
        'btncancel
        '
        Me.btncancel.Location = New System.Drawing.Point(544, 20)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(87, 28)
        Me.btncancel.TabIndex = 14
        Me.btncancel.Text = "EXIT"
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'cmbdesig
        '
        Me.cmbdesig.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbdesig.FormattingEnabled = True
        Me.cmbdesig.Location = New System.Drawing.Point(180, 23)
        Me.cmbdesig.Name = "cmbdesig"
        Me.cmbdesig.Size = New System.Drawing.Size(140, 21)
        Me.cmbdesig.TabIndex = 15
        '
        'txtsalary
        '
        Me.txtsalary.Location = New System.Drawing.Point(180, 177)
        Me.txtsalary.Name = "txtsalary"
        Me.txtsalary.Size = New System.Drawing.Size(140, 20)
        Me.txtsalary.TabIndex = 16
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(35, 180)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 13)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "SALARY"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column2, Me.Column3, Me.Column1, Me.Column4, Me.Column5, Me.Column6, Me.Column7})
        Me.DataGridView1.Location = New System.Drawing.Point(14, 280)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(635, 150)
        Me.DataGridView1.TabIndex = 18
        '
        'Column2
        '
        Me.Column2.HeaderText = "Emp ID"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Emp Name"
        Me.Column3.Name = "Column3"
        '
        'Column1
        '
        Me.Column1.HeaderText = "Designation"
        Me.Column1.Name = "Column1"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Salary"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "DOB"
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.HeaderText = "DOJ"
        Me.Column6.Name = "Column6"
        '
        'Column7
        '
        Me.Column7.HeaderText = "Qualification"
        Me.Column7.Name = "Column7"
        '
        'btnupdate
        '
        Me.btnupdate.Location = New System.Drawing.Point(272, 20)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(87, 28)
        Me.btnupdate.TabIndex = 19
        Me.btnupdate.Text = "UPDATE"
        Me.btnupdate.UseVisualStyleBackColor = True
        '
        'btndelete
        '
        Me.btndelete.Location = New System.Drawing.Point(411, 20)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(87, 28)
        Me.btndelete.TabIndex = 20
        Me.btndelete.Text = "DELETE"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'DateTimePicker3
        '
        Me.DateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker3.Location = New System.Drawing.Point(180, 147)
        Me.DateTimePicker3.Name = "DateTimePicker3"
        Me.DateTimePicker3.Size = New System.Drawing.Size(140, 20)
        Me.DateTimePicker3.TabIndex = 21
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.DateTimePicker3)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Txtempid)
        Me.Panel1.Controls.Add(Me.Txtempname)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txtsalary)
        Me.Panel1.Controls.Add(Me.DateTimePicker1)
        Me.Panel1.Controls.Add(Me.cmbdesig)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.DateTimePicker2)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.txtqualification)
        Me.Panel1.Location = New System.Drawing.Point(14, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(374, 251)
        Me.Panel1.TabIndex = 22
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.btnupdate)
        Me.Panel2.Controls.Add(Me.Btnadd)
        Me.Panel2.Controls.Add(Me.btndelete)
        Me.Panel2.Controls.Add(Me.btnreset)
        Me.Panel2.Controls.Add(Me.btncancel)
        Me.Panel2.Location = New System.Drawing.Point(14, 436)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(635, 51)
        Me.Panel2.TabIndex = 23
        '
        'frmemployee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(657, 486)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmemployee"
        Me.RightToLeftLayout = True
        Me.Text = "frmemployee"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Txtempid As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Txtempname As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtqualification As System.Windows.Forms.TextBox
    Friend WithEvents Btnadd As System.Windows.Forms.Button
    Friend WithEvents btnreset As System.Windows.Forms.Button
    Friend WithEvents btncancel As System.Windows.Forms.Button
    Friend WithEvents cmbdesig As System.Windows.Forms.ComboBox
    Friend WithEvents txtsalary As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnupdate As System.Windows.Forms.Button
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents DateTimePicker3 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
End Class
