<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmdept
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
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Button2 = New System.Windows.Forms.Button
        Me.btnnew = New System.Windows.Forms.Button
        Me.Btnadd = New System.Windows.Forms.Button
        Me.btndelete = New System.Windows.Forms.Button
        Me.btnupdate = New System.Windows.Forms.Button
        Me.btncancel = New System.Windows.Forms.Button
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Txtdeptname = New System.Windows.Forms.TextBox
        Me.Txtdeptid = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.La = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Button3 = New System.Windows.Forms.Button
        Me.btnnew2 = New System.Windows.Forms.Button
        Me.btndelete1 = New System.Windows.Forms.Button
        Me.btnadd1 = New System.Windows.Forms.Button
        Me.btnupdate1 = New System.Windows.Forms.Button
        Me.DataGridView2 = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.txtdesname = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.txtdesid = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel
        Me.LinkLabel3 = New System.Windows.Forms.LinkLabel
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.btncancel)
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Controls.Add(Me.Txtdeptname)
        Me.Panel1.Controls.Add(Me.Txtdeptid)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.La)
        Me.Panel1.Location = New System.Drawing.Point(1, 59)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(477, 356)
        Me.Panel1.TabIndex = 6
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Button2)
        Me.Panel4.Controls.Add(Me.btnnew)
        Me.Panel4.Controls.Add(Me.Btnadd)
        Me.Panel4.Controls.Add(Me.btndelete)
        Me.Panel4.Controls.Add(Me.btnupdate)
        Me.Panel4.Location = New System.Drawing.Point(3, 292)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(472, 63)
        Me.Panel4.TabIndex = 16
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(369, 11)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 33)
        Me.Button2.TabIndex = 17
        Me.Button2.Text = "RESET"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnnew
        '
        Me.btnnew.Location = New System.Drawing.Point(3, 13)
        Me.btnnew.Name = "btnnew"
        Me.btnnew.Size = New System.Drawing.Size(87, 31)
        Me.btnnew.TabIndex = 15
        Me.btnnew.Text = "NEW"
        Me.btnnew.UseVisualStyleBackColor = True
        '
        'Btnadd
        '
        Me.Btnadd.Location = New System.Drawing.Point(94, 12)
        Me.Btnadd.Name = "Btnadd"
        Me.Btnadd.Size = New System.Drawing.Size(87, 33)
        Me.Btnadd.TabIndex = 10
        Me.Btnadd.Text = "ADD"
        Me.Btnadd.UseVisualStyleBackColor = True
        '
        'btndelete
        '
        Me.btndelete.Location = New System.Drawing.Point(283, 12)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(87, 33)
        Me.btndelete.TabIndex = 13
        Me.btndelete.Text = "DELETE"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'btnupdate
        '
        Me.btnupdate.Location = New System.Drawing.Point(189, 11)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(87, 33)
        Me.btnupdate.TabIndex = 12
        Me.btnupdate.Text = "UPDATE"
        Me.btnupdate.UseVisualStyleBackColor = True
        '
        'btncancel
        '
        Me.btncancel.Location = New System.Drawing.Point(372, 253)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(100, 33)
        Me.btncancel.TabIndex = 11
        Me.btncancel.Text = "EXIT"
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2})
        Me.DataGridView1.Location = New System.Drawing.Point(77, 136)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(244, 150)
        Me.DataGridView1.TabIndex = 14
        '
        'Column1
        '
        Me.Column1.HeaderText = "Department Id"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Department Name"
        Me.Column2.Name = "Column2"
        '
        'Txtdeptname
        '
        Me.Txtdeptname.Location = New System.Drawing.Point(257, 79)
        Me.Txtdeptname.Name = "Txtdeptname"
        Me.Txtdeptname.Size = New System.Drawing.Size(116, 20)
        Me.Txtdeptname.TabIndex = 9
        '
        'Txtdeptid
        '
        Me.Txtdeptid.Enabled = False
        Me.Txtdeptid.Location = New System.Drawing.Point(257, 30)
        Me.Txtdeptid.Name = "Txtdeptid"
        Me.Txtdeptid.Size = New System.Drawing.Size(116, 20)
        Me.Txtdeptid.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(74, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(131, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "DEPARTMENT NAME"
        '
        'La
        '
        Me.La.AutoSize = True
        Me.La.Location = New System.Drawing.Point(74, 34)
        Me.La.Name = "La"
        Me.La.Size = New System.Drawing.Size(109, 13)
        Me.La.TabIndex = 6
        Me.La.Text = "DEPARTMENT ID"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.DataGridView2)
        Me.Panel2.Controls.Add(Me.txtdesname)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.txtdesid)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Location = New System.Drawing.Point(511, 59)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(486, 356)
        Me.Panel2.TabIndex = 7
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.Controls.Add(Me.Button3)
        Me.Panel3.Controls.Add(Me.btnnew2)
        Me.Panel3.Controls.Add(Me.btndelete1)
        Me.Panel3.Controls.Add(Me.btnadd1)
        Me.Panel3.Controls.Add(Me.btnupdate1)
        Me.Panel3.Location = New System.Drawing.Point(3, 292)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(486, 63)
        Me.Panel3.TabIndex = 11
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(381, 19)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(96, 33)
        Me.Button3.TabIndex = 16
        Me.Button3.Text = "RESET"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'btnnew2
        '
        Me.btnnew2.Location = New System.Drawing.Point(6, 21)
        Me.btnnew2.Name = "btnnew2"
        Me.btnnew2.Size = New System.Drawing.Size(87, 31)
        Me.btnnew2.TabIndex = 18
        Me.btnnew2.Text = "NEW"
        Me.btnnew2.UseVisualStyleBackColor = True
        '
        'btndelete1
        '
        Me.btndelete1.Location = New System.Drawing.Point(287, 19)
        Me.btndelete1.Name = "btndelete1"
        Me.btndelete1.Size = New System.Drawing.Size(87, 33)
        Me.btndelete1.TabIndex = 17
        Me.btndelete1.Text = "DELETE"
        Me.btndelete1.UseVisualStyleBackColor = True
        '
        'btnadd1
        '
        Me.btnadd1.Location = New System.Drawing.Point(99, 19)
        Me.btnadd1.Name = "btnadd1"
        Me.btnadd1.Size = New System.Drawing.Size(87, 33)
        Me.btnadd1.TabIndex = 10
        Me.btnadd1.Text = "ADD"
        Me.btnadd1.UseVisualStyleBackColor = True
        '
        'btnupdate1
        '
        Me.btnupdate1.Location = New System.Drawing.Point(192, 19)
        Me.btnupdate1.Name = "btnupdate1"
        Me.btnupdate1.Size = New System.Drawing.Size(87, 33)
        Me.btnupdate1.TabIndex = 16
        Me.btnupdate1.Text = "UPDATE"
        Me.btnupdate1.UseVisualStyleBackColor = True
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.DataGridView2.Location = New System.Drawing.Point(113, 136)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(245, 150)
        Me.DataGridView2.TabIndex = 15
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Designation Id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Designation Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'txtdesname
        '
        Me.txtdesname.Location = New System.Drawing.Point(290, 86)
        Me.txtdesname.Name = "txtdesname"
        Me.txtdesname.Size = New System.Drawing.Size(116, 20)
        Me.txtdesname.TabIndex = 9
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(384, 253)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(96, 33)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "EXIT"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtdesid
        '
        Me.txtdesid.Location = New System.Drawing.Point(290, 27)
        Me.txtdesid.Name = "txtdesid"
        Me.txtdesid.Size = New System.Drawing.Size(116, 20)
        Me.txtdesid.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(110, 93)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "DESIGNATION "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(110, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "DESIGNATION ID"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoEllipsis = True
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.LinkColor = System.Drawing.Color.Black
        Me.LinkLabel1.Location = New System.Drawing.Point(12, 9)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(168, 25)
        Me.LinkLabel1.TabIndex = 8
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Add Department"
        Me.LinkLabel1.VisitedLinkColor = System.Drawing.Color.Fuchsia
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel2.LinkColor = System.Drawing.Color.Black
        Me.LinkLabel2.Location = New System.Drawing.Point(189, 9)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(171, 25)
        Me.LinkLabel2.TabIndex = 9
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Add Designation"
        '
        'LinkLabel3
        '
        Me.LinkLabel3.AutoSize = True
        Me.LinkLabel3.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel3.LinkColor = System.Drawing.Color.Black
        Me.LinkLabel3.Location = New System.Drawing.Point(383, 9)
        Me.LinkLabel3.Name = "LinkLabel3"
        Me.LinkLabel3.Size = New System.Drawing.Size(48, 25)
        Me.LinkLabel3.TabIndex = 10
        Me.LinkLabel3.TabStop = True
        Me.LinkLabel3.Text = "Exit"
        '
        'frmdept
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1030, 441)
        Me.Controls.Add(Me.LinkLabel3)
        Me.Controls.Add(Me.LinkLabel2)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmdept"
        Me.Text = "frmdept"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btncancel As System.Windows.Forms.Button
    Friend WithEvents Btnadd As System.Windows.Forms.Button
    Friend WithEvents Txtdeptname As System.Windows.Forms.TextBox
    Friend WithEvents Txtdeptid As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents La As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnadd1 As System.Windows.Forms.Button
    Friend WithEvents txtdesname As System.Windows.Forms.TextBox
    Friend WithEvents txtdesid As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel2 As System.Windows.Forms.LinkLabel
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents btnupdate As System.Windows.Forms.Button
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btndelete1 As System.Windows.Forms.Button
    Friend WithEvents btnupdate1 As System.Windows.Forms.Button
    Friend WithEvents btnnew As System.Windows.Forms.Button
    Friend WithEvents btnnew2 As System.Windows.Forms.Button
    Friend WithEvents LinkLabel3 As System.Windows.Forms.LinkLabel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class
