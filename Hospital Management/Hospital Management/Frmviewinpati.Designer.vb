<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frmviewinpati
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column13 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.btnsave = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Column14 = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9, Me.Column12, Me.Column10, Me.Column11, Me.Column13, Me.Column14})
        Me.DataGridView1.Location = New System.Drawing.Point(49, 65)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(513, 162)
        Me.DataGridView1.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.HeaderText = "InPatientId"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Name"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "DOB"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Gender"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "Addres"
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.HeaderText = "phone"
        Me.Column6.Name = "Column6"
        '
        'Column7
        '
        Me.Column7.HeaderText = "Blood Group"
        Me.Column7.Name = "Column7"
        '
        'Column8
        '
        Me.Column8.HeaderText = "Disease"
        Me.Column8.Name = "Column8"
        '
        'Column9
        '
        Me.Column9.HeaderText = "Doctor Id"
        Me.Column9.Name = "Column9"
        '
        'Column12
        '
        Me.Column12.HeaderText = "DoJ"
        Me.Column12.Name = "Column12"
        '
        'Column10
        '
        Me.Column10.HeaderText = "Room type"
        Me.Column10.Name = "Column10"
        '
        'Column11
        '
        Me.Column11.HeaderText = "Room Number"
        Me.Column11.Name = "Column11"
        '
        'Column13
        '
        Me.Column13.HeaderText = "Bed number"
        Me.Column13.Name = "Column13"
        '
        'btnsave
        '
        Me.btnsave.Location = New System.Drawing.Point(251, 233)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(87, 36)
        Me.btnsave.TabIndex = 10
        Me.btnsave.Text = "EXIT"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(140, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(299, 42)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "INPATIENT DETAILS"
        '
        'Column14
        '
        Me.Column14.HeaderText = "Status"
        Me.Column14.Name = "Column14"
        '
        'Frmviewinpati
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(730, 279)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.DataGridView1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Frmviewinpati"
        Me.Text = "Frmviewinpati"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Column14 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
