<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmroom
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmroom))
        Me.label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtroomno = New System.Windows.Forms.TextBox
        Me.Cmbroom = New System.Windows.Forms.ComboBox
        Me.txtcost = New System.Windows.Forms.TextBox
        Me.btnadd = New System.Windows.Forms.Button
        Me.txtbedno = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label5 = New System.Windows.Forms.Label
        Me.cmbednnum = New System.Windows.Forms.ComboBox
        Me.btnadd1 = New System.Windows.Forms.Button
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridView2 = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.btndelete = New System.Windows.Forms.Button
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.btnsave = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(15, 34)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(80, 13)
        Me.label1.TabIndex = 0
        Me.label1.Text = "ROOM TYPE"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ROOM NUMBER"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "COST"
        '
        'txtroomno
        '
        Me.txtroomno.Enabled = False
        Me.txtroomno.Location = New System.Drawing.Point(174, 80)
        Me.txtroomno.Name = "txtroomno"
        Me.txtroomno.Size = New System.Drawing.Size(140, 20)
        Me.txtroomno.TabIndex = 4
        '
        'Cmbroom
        '
        Me.Cmbroom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmbroom.FormattingEnabled = True
        Me.Cmbroom.Items.AddRange(New Object() {"General Ward", "Semi ", "Special ward", "ICU", "Operation Theatre"})
        Me.Cmbroom.Location = New System.Drawing.Point(174, 34)
        Me.Cmbroom.Name = "Cmbroom"
        Me.Cmbroom.Size = New System.Drawing.Size(140, 21)
        Me.Cmbroom.TabIndex = 5
        '
        'txtcost
        '
        Me.txtcost.Location = New System.Drawing.Point(174, 120)
        Me.txtcost.Name = "txtcost"
        Me.txtcost.Size = New System.Drawing.Size(140, 20)
        Me.txtcost.TabIndex = 6
        '
        'btnadd
        '
        Me.btnadd.Location = New System.Drawing.Point(64, 158)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(87, 32)
        Me.btnadd.TabIndex = 7
        Me.btnadd.Text = "ADD"
        Me.btnadd.UseVisualStyleBackColor = True
        '
        'txtbedno
        '
        Me.txtbedno.Enabled = False
        Me.txtbedno.Location = New System.Drawing.Point(208, 6)
        Me.txtbedno.Name = "txtbedno"
        Me.txtbedno.Size = New System.Drawing.Size(88, 20)
        Me.txtbedno.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 11)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "BED NUMBER"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txtbedno)
        Me.Panel1.Location = New System.Drawing.Point(14, 67)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(299, 44)
        Me.Panel1.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(11, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(215, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "SELECT GENERAL WARD NUMBER"
        '
        'cmbednnum
        '
        Me.cmbednnum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbednnum.FormattingEnabled = True
        Me.cmbednnum.Location = New System.Drawing.Point(225, 29)
        Me.cmbednnum.Name = "cmbednnum"
        Me.cmbednnum.Size = New System.Drawing.Size(88, 21)
        Me.cmbednnum.TabIndex = 12
        '
        'btnadd1
        '
        Me.btnadd1.Location = New System.Drawing.Point(126, 137)
        Me.btnadd1.Name = "btnadd1"
        Me.btnadd1.Size = New System.Drawing.Size(87, 36)
        Me.btnadd1.TabIndex = 13
        Me.btnadd1.Text = "ADD"
        Me.btnadd1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        Me.DataGridView1.Location = New System.Drawing.Point(46, 247)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(345, 110)
        Me.DataGridView1.TabIndex = 14
        '
        'Column1
        '
        Me.Column1.HeaderText = "RoomType"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Roomnumber"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Cost"
        Me.Column3.Name = "Column3"
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.DataGridView2.Location = New System.Drawing.Point(515, 247)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(243, 110)
        Me.DataGridView2.TabIndex = 15
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "General ward number"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Bednumber"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.btndelete)
        Me.Panel2.Controls.Add(Me.label1)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Cmbroom)
        Me.Panel2.Controls.Add(Me.txtroomno)
        Me.Panel2.Controls.Add(Me.txtcost)
        Me.Panel2.Controls.Add(Me.btnadd)
        Me.Panel2.Location = New System.Drawing.Point(28, 37)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(400, 193)
        Me.Panel2.TabIndex = 16
        '
        'btndelete
        '
        Me.btndelete.Location = New System.Drawing.Point(174, 157)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(87, 33)
        Me.btndelete.TabIndex = 14
        Me.btndelete.Text = "DELETE"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.Panel1)
        Me.Panel3.Controls.Add(Me.cmbednnum)
        Me.Panel3.Controls.Add(Me.btnadd1)
        Me.Panel3.Location = New System.Drawing.Point(472, 37)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(320, 191)
        Me.Panel3.TabIndex = 17
        '
        'btnsave
        '
        Me.btnsave.Location = New System.Drawing.Point(412, 323)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(87, 34)
        Me.btnsave.TabIndex = 18
        Me.btnsave.Text = "EXIT"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(799, 37)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(274, 320)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'frmroom
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1085, 370)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmroom"
        Me.Text = "frmroom"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtroomno As System.Windows.Forms.TextBox
    Friend WithEvents Cmbroom As System.Windows.Forms.ComboBox
    Friend WithEvents txtcost As System.Windows.Forms.TextBox
    Friend WithEvents btnadd As System.Windows.Forms.Button
    Friend WithEvents txtbedno As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbednnum As System.Windows.Forms.ComboBox
    Friend WithEvents btnadd1 As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btndelete As System.Windows.Forms.Button
End Class
