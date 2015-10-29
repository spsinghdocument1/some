<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmtreatment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmtreatment))
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmbpatid = New System.Windows.Forms.ComboBox
        Me.txttreatment = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtdoccharge = New System.Windows.Forms.TextBox
        Me.txtmedcharge = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.btnadd = New System.Windows.Forms.Button
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.btnsave = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtavqty = New System.Windows.Forms.TextBox
        Me.DataGridViewmedicine = New System.Windows.Forms.DataGridView
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.btnmedadd = New System.Windows.Forms.Button
        Me.txtqty = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.cmbmedicine = New System.Windows.Forms.ComboBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridViewmedicine, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(402, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "SELECT PATIENT ID"
        '
        'cmbpatid
        '
        Me.cmbpatid.FormattingEnabled = True
        Me.cmbpatid.Location = New System.Drawing.Point(548, 17)
        Me.cmbpatid.Name = "cmbpatid"
        Me.cmbpatid.Size = New System.Drawing.Size(140, 21)
        Me.cmbpatid.TabIndex = 1
        '
        'txttreatment
        '
        Me.txttreatment.Location = New System.Drawing.Point(124, 6)
        Me.txttreatment.Multiline = True
        Me.txttreatment.Name = "txttreatment"
        Me.txttreatment.Size = New System.Drawing.Size(140, 73)
        Me.txttreatment.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "TREATMENT"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(52, 269)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "DATE"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(202, 263)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(140, 20)
        Me.DateTimePicker1.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(52, 206)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(114, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "DOCTOR CHARGE"
        '
        'txtdoccharge
        '
        Me.txtdoccharge.Location = New System.Drawing.Point(202, 199)
        Me.txtdoccharge.Name = "txtdoccharge"
        Me.txtdoccharge.Size = New System.Drawing.Size(140, 20)
        Me.txtdoccharge.TabIndex = 14
        '
        'txtmedcharge
        '
        Me.txtmedcharge.Location = New System.Drawing.Point(202, 230)
        Me.txtmedcharge.Name = "txtmedcharge"
        Me.txtmedcharge.Size = New System.Drawing.Size(140, 20)
        Me.txtmedcharge.TabIndex = 16
        Me.txtmedcharge.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(52, 237)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(122, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "MEDICINE CHARGE"
        '
        'btnadd
        '
        Me.btnadd.Location = New System.Drawing.Point(124, 418)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(87, 31)
        Me.btnadd.TabIndex = 17
        Me.btnadd.Text = "ADD"
        Me.btnadd.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.DataGridView1.Location = New System.Drawing.Point(26, 289)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(545, 125)
        Me.DataGridView1.TabIndex = 18
        '
        'Column1
        '
        Me.Column1.HeaderText = "Patient Id"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Treatment"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Doctor Charge"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Medicine Charge"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "Date"
        Me.Column5.Name = "Column5"
        '
        'btnsave
        '
        Me.btnsave.Location = New System.Drawing.Point(389, 421)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(87, 31)
        Me.btnsave.TabIndex = 21
        Me.btnsave.Text = "EXIT"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.txtavqty)
        Me.Panel1.Controls.Add(Me.txttreatment)
        Me.Panel1.Controls.Add(Me.DataGridViewmedicine)
        Me.Panel1.Controls.Add(Me.btnmedadd)
        Me.Panel1.Controls.Add(Me.btnsave)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.btnadd)
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Controls.Add(Me.txtqty)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.txtmedcharge)
        Me.Panel1.Controls.Add(Me.DateTimePicker1)
        Me.Panel1.Controls.Add(Me.cmbmedicine)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txtdoccharge)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(42, 55)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(759, 469)
        Me.Panel1.TabIndex = 22
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(321, 73)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(107, 13)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "enter the quantity"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(321, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(97, 13)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "Select medicine"
        '
        'txtavqty
        '
        Me.txtavqty.Location = New System.Drawing.Point(500, 40)
        Me.txtavqty.Name = "txtavqty"
        Me.txtavqty.Size = New System.Drawing.Size(100, 20)
        Me.txtavqty.TabIndex = 26
        Me.txtavqty.Text = "0"
        '
        'DataGridViewmedicine
        '
        Me.DataGridViewmedicine.AllowUserToAddRows = False
        Me.DataGridViewmedicine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewmedicine.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column6, Me.Column7, Me.Column8, Me.Column9})
        Me.DataGridViewmedicine.Location = New System.Drawing.Point(10, 96)
        Me.DataGridViewmedicine.Name = "DataGridViewmedicine"
        Me.DataGridViewmedicine.Size = New System.Drawing.Size(441, 97)
        Me.DataGridViewmedicine.TabIndex = 18
        '
        'Column6
        '
        Me.Column6.HeaderText = "Meicine"
        Me.Column6.Name = "Column6"
        '
        'Column7
        '
        Me.Column7.HeaderText = "Qty"
        Me.Column7.Name = "Column7"
        '
        'Column8
        '
        Me.Column8.HeaderText = "Unit Price"
        Me.Column8.Name = "Column8"
        '
        'Column9
        '
        Me.Column9.HeaderText = "Total Price"
        Me.Column9.Name = "Column9"
        '
        'btnmedadd
        '
        Me.btnmedadd.Location = New System.Drawing.Point(517, 113)
        Me.btnmedadd.Name = "btnmedadd"
        Me.btnmedadd.Size = New System.Drawing.Size(128, 30)
        Me.btnmedadd.TabIndex = 24
        Me.btnmedadd.Text = "add medicine"
        Me.btnmedadd.UseVisualStyleBackColor = True
        '
        'txtqty
        '
        Me.txtqty.Location = New System.Drawing.Point(517, 70)
        Me.txtqty.Name = "txtqty"
        Me.txtqty.Size = New System.Drawing.Size(100, 20)
        Me.txtqty.TabIndex = 23
        Me.txtqty.Text = "0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(321, 47)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 13)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Available qty"
        '
        'cmbmedicine
        '
        Me.cmbmedicine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbmedicine.FormattingEnabled = True
        Me.cmbmedicine.Location = New System.Drawing.Point(555, 6)
        Me.cmbmedicine.Name = "cmbmedicine"
        Me.cmbmedicine.Size = New System.Drawing.Size(121, 21)
        Me.cmbmedicine.TabIndex = 17
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(65, 20)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(171, 13)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "SELECT TYPE OF PATIENT "
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"InPatient", "OutPatient"})
        Me.ComboBox1.Location = New System.Drawing.Point(242, 17)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(140, 21)
        Me.ComboBox1.TabIndex = 24
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(807, 202)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(155, 219)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'frmtreatment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1011, 551)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbpatid)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmtreatment"
        Me.Text = "E:\new\Hospital Management\Hospital Management\frmtreatment.vb"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridViewmedicine, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbpatid As System.Windows.Forms.ComboBox
    Friend WithEvents txttreatment As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtdoccharge As System.Windows.Forms.TextBox
    Friend WithEvents txtmedcharge As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnadd As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents cmbmedicine As System.Windows.Forms.ComboBox
    Friend WithEvents DataGridViewmedicine As System.Windows.Forms.DataGridView
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtqty As System.Windows.Forms.TextBox
    Friend WithEvents btnmedadd As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtavqty As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
End Class
