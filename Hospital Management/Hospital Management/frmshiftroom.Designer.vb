<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmshiftroom
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
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.lblbednum = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmbroomno = New System.Windows.Forms.ComboBox
        Me.cmbbedno = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtbednum = New System.Windows.Forms.TextBox
        Me.txtroomnum = New System.Windows.Forms.TextBox
        Me.txtroomtype = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmbroomtype = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.cmbpatientid = New System.Windows.Forms.ComboBox
        Me.btnshift = New System.Windows.Forms.Button
        Me.btnsave = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(22, 68)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(101, 13)
        Me.Label8.TabIndex = 31
        Me.Label8.Text = "ROOM NUMBER"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(22, 34)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 13)
        Me.Label9.TabIndex = 32
        Me.Label9.Text = "ROOM TYPE"
        '
        'lblbednum
        '
        Me.lblbednum.AutoSize = True
        Me.lblbednum.Location = New System.Drawing.Point(22, 115)
        Me.lblbednum.Name = "lblbednum"
        Me.lblbednum.Size = New System.Drawing.Size(89, 13)
        Me.lblbednum.TabIndex = 35
        Me.lblbednum.Text = "BED NUMBER"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 13)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "ROOM NUMBER"
        '
        'cmbroomno
        '
        Me.cmbroomno.FormattingEnabled = True
        Me.cmbroomno.Location = New System.Drawing.Point(152, 65)
        Me.cmbroomno.Name = "cmbroomno"
        Me.cmbroomno.Size = New System.Drawing.Size(116, 21)
        Me.cmbroomno.TabIndex = 38
        '
        'cmbbedno
        '
        Me.cmbbedno.FormattingEnabled = True
        Me.cmbbedno.Location = New System.Drawing.Point(152, 105)
        Me.cmbbedno.Name = "cmbbedno"
        Me.cmbbedno.Size = New System.Drawing.Size(116, 21)
        Me.cmbbedno.TabIndex = 40
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 13)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "BED NUMBER"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.txtbednum)
        Me.GroupBox1.Controls.Add(Me.txtroomnum)
        Me.GroupBox1.Controls.Add(Me.txtroomtype)
        Me.GroupBox1.Controls.Add(Me.lblbednum)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Location = New System.Drawing.Point(45, 116)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(292, 170)
        Me.GroupBox1.TabIndex = 41
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "FROM ROOM"
        '
        'txtbednum
        '
        Me.txtbednum.Enabled = False
        Me.txtbednum.Location = New System.Drawing.Point(154, 107)
        Me.txtbednum.Name = "txtbednum"
        Me.txtbednum.Size = New System.Drawing.Size(116, 20)
        Me.txtbednum.TabIndex = 39
        '
        'txtroomnum
        '
        Me.txtroomnum.Enabled = False
        Me.txtroomnum.Location = New System.Drawing.Point(154, 68)
        Me.txtroomnum.Name = "txtroomnum"
        Me.txtroomnum.Size = New System.Drawing.Size(116, 20)
        Me.txtroomnum.TabIndex = 38
        '
        'txtroomtype
        '
        Me.txtroomtype.Enabled = False
        Me.txtroomtype.Location = New System.Drawing.Point(154, 27)
        Me.txtroomtype.Name = "txtroomtype"
        Me.txtroomtype.Size = New System.Drawing.Size(116, 20)
        Me.txtroomtype.TabIndex = 37
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.cmbroomtype)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.cmbroomno)
        Me.GroupBox2.Controls.Add(Me.cmbbedno)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(343, 116)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(286, 170)
        Me.GroupBox2.TabIndex = 42
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "TO ROOM"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 13)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "ROOM TYPE"
        '
        'cmbroomtype
        '
        Me.cmbroomtype.FormattingEnabled = True
        Me.cmbroomtype.Items.AddRange(New Object() {"General Ward", "Semi", "Special ward", "ICU", "Operation Theatre "})
        Me.cmbroomtype.Location = New System.Drawing.Point(152, 25)
        Me.cmbroomtype.Name = "cmbroomtype"
        Me.cmbroomtype.Size = New System.Drawing.Size(116, 21)
        Me.cmbroomtype.TabIndex = 42
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(196, 60)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(141, 13)
        Me.Label4.TabIndex = 43
        Me.Label4.Text = "SELECT INPATIENT ID"
        '
        'cmbpatientid
        '
        Me.cmbpatientid.FormattingEnabled = True
        Me.cmbpatientid.Location = New System.Drawing.Point(343, 57)
        Me.cmbpatientid.Name = "cmbpatientid"
        Me.cmbpatientid.Size = New System.Drawing.Size(140, 21)
        Me.cmbpatientid.TabIndex = 44
        '
        'btnshift
        '
        Me.btnshift.Location = New System.Drawing.Point(132, 301)
        Me.btnshift.Name = "btnshift"
        Me.btnshift.Size = New System.Drawing.Size(87, 32)
        Me.btnshift.TabIndex = 45
        Me.btnshift.Text = "SHIFT"
        Me.btnshift.UseVisualStyleBackColor = True
        '
        'btnsave
        '
        Me.btnsave.Location = New System.Drawing.Point(431, 301)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(87, 32)
        Me.btnsave.TabIndex = 46
        Me.btnsave.Text = "EXIT"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'frmshiftroom
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(641, 361)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.btnshift)
        Me.Controls.Add(Me.cmbpatientid)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmshiftroom"
        Me.Text = "frmshiftroom"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lblbednum As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbroomno As System.Windows.Forms.ComboBox
    Friend WithEvents cmbbedno As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbroomtype As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbpatientid As System.Windows.Forms.ComboBox
    Friend WithEvents txtbednum As System.Windows.Forms.TextBox
    Friend WithEvents txtroomnum As System.Windows.Forms.TextBox
    Friend WithEvents txtroomtype As System.Windows.Forms.TextBox
    Friend WithEvents btnshift As System.Windows.Forms.Button
    Friend WithEvents btnsave As System.Windows.Forms.Button
End Class
