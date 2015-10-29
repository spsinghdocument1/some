<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmequipment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmequipment))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txteqid = New System.Windows.Forms.TextBox
        Me.txteqname = New System.Windows.Forms.TextBox
        Me.txtdes = New System.Windows.Forms.TextBox
        Me.txtqty = New System.Windows.Forms.TextBox
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.btnadd = New System.Windows.Forms.Button
        Me.btnupdate = New System.Windows.Forms.Button
        Me.btndelete = New System.Windows.Forms.Button
        Me.btncancel = New System.Windows.Forms.Button
        Me.btnreset = New System.Windows.Forms.Button
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "EQUIPMENT ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "EQUIPMENT"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "DESCRIPTION"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 165)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "QUANTITY"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 205)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "DATE OF STORE"
        '
        'txteqid
        '
        Me.txteqid.Enabled = False
        Me.txteqid.Location = New System.Drawing.Point(153, 12)
        Me.txteqid.Name = "txteqid"
        Me.txteqid.Size = New System.Drawing.Size(116, 20)
        Me.txteqid.TabIndex = 5
        '
        'txteqname
        '
        Me.txteqname.Location = New System.Drawing.Point(153, 51)
        Me.txteqname.Name = "txteqname"
        Me.txteqname.Size = New System.Drawing.Size(116, 20)
        Me.txteqname.TabIndex = 6
        '
        'txtdes
        '
        Me.txtdes.Location = New System.Drawing.Point(153, 86)
        Me.txtdes.Multiline = True
        Me.txtdes.Name = "txtdes"
        Me.txtdes.Size = New System.Drawing.Size(116, 53)
        Me.txtdes.TabIndex = 7
        '
        'txtqty
        '
        Me.txtqty.Location = New System.Drawing.Point(153, 162)
        Me.txtqty.Name = "txtqty"
        Me.txtqty.Size = New System.Drawing.Size(116, 20)
        Me.txtqty.TabIndex = 8
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(153, 198)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(116, 20)
        Me.DateTimePicker1.TabIndex = 9
        '
        'btnadd
        '
        Me.btnadd.Location = New System.Drawing.Point(3, 13)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(87, 35)
        Me.btnadd.TabIndex = 10
        Me.btnadd.Text = "ADD"
        Me.btnadd.UseVisualStyleBackColor = True
        '
        'btnupdate
        '
        Me.btnupdate.Location = New System.Drawing.Point(216, 13)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(87, 35)
        Me.btnupdate.TabIndex = 11
        Me.btnupdate.Text = "UPDATE"
        Me.btnupdate.UseVisualStyleBackColor = True
        '
        'btndelete
        '
        Me.btndelete.Location = New System.Drawing.Point(322, 13)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(87, 35)
        Me.btndelete.TabIndex = 12
        Me.btndelete.Text = "DELETE"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'btncancel
        '
        Me.btncancel.Location = New System.Drawing.Point(428, 13)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(87, 35)
        Me.btncancel.TabIndex = 13
        Me.btncancel.Text = "EXIT"
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'btnreset
        '
        Me.btnreset.Location = New System.Drawing.Point(111, 13)
        Me.btnreset.Name = "btnreset"
        Me.btnreset.Size = New System.Drawing.Size(87, 35)
        Me.btnreset.TabIndex = 14
        Me.btnreset.Text = "RESET"
        Me.btnreset.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.DataGridView1.Location = New System.Drawing.Point(14, 263)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(544, 108)
        Me.DataGridView1.TabIndex = 15
        '
        'Column1
        '
        Me.Column1.HeaderText = "Equipment Id"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Equipment Name"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Description"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Quantity"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "Dateof Store"
        Me.Column5.Name = "Column5"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txteqid)
        Me.Panel1.Controls.Add(Me.txteqname)
        Me.Panel1.Controls.Add(Me.DateTimePicker1)
        Me.Panel1.Controls.Add(Me.txtdes)
        Me.Panel1.Controls.Add(Me.txtqty)
        Me.Panel1.Location = New System.Drawing.Point(14, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(285, 227)
        Me.Panel1.TabIndex = 16
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.btnadd)
        Me.Panel2.Controls.Add(Me.btnreset)
        Me.Panel2.Controls.Add(Me.btnupdate)
        Me.Panel2.Controls.Add(Me.btncancel)
        Me.Panel2.Controls.Add(Me.btndelete)
        Me.Panel2.Location = New System.Drawing.Point(33, 385)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(516, 59)
        Me.Panel2.TabIndex = 17
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(305, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(253, 227)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'frmequipment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(563, 456)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmequipment"
        Me.Text = "frmequipment"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txteqid As System.Windows.Forms.TextBox
    Friend WithEvents txteqname As System.Windows.Forms.TextBox
    Friend WithEvents txtdes As System.Windows.Forms.TextBox
    Friend WithEvents txtqty As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnadd As System.Windows.Forms.Button
    Friend WithEvents btnupdate As System.Windows.Forms.Button
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents btncancel As System.Windows.Forms.Button
    Friend WithEvents btnreset As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
