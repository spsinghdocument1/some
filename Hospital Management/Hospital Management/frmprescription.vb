Public Class frmprescription

    Private Sub frmprescription_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        opendb()
        
        loaddosage()
        loaddays()
    End Sub
    Sub loaddosage()
        cmbdosage.Items.Add("1-1-1")

        cmbdosage.Items.Add("1-0-1")
        cmbdosage.Items.Add("1-0-0")
        cmbdosage.Items.Add("0-0-1")
        cmbdosage.Items.Add("0-1-0")

    End Sub
    Sub loaddays()
        Dim i As Integer
        For i = 1 To 15
            cmbdays.Items.Add(i)
        Next i
    End Sub
    Dim i = 0

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
        DataGridView1.Rows.Add()
        DataGridView1.Item(0, i).Value = txtmedicine.Text
        DataGridView1.Item(1, i).Value = cmbdays.Text
        DataGridView1.Item(2, i).Value = cmbdosage.Text
        DataGridView1.Item(3, i).Value = DateTimePicker1.Value
        i = i + 1
        medclear()
    End Sub
    Sub medclear()
        txtmedicine.Text = ""
        cmbdays.Text = ""
        cmbdosage.Text = ""
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Dim j = 0
        i = DataGridView1.RowCount
        Do While j < i
            sql = "insert into tbl_prescription(docId,PId,Medicine,days,dosage,date)"
            sql = sql & "values('" & userid & "','" & cmbpatid.Text & "','" & DataGridView1.Item(0, j).Value & "','" & DataGridView1.Item(1, j).Value & "','" & DataGridView1.Item(2, j).Value & "',convert(date,'" & DateTimePicker1.Value & "',103))"
            conn.Execute(sql)
            j = j + 1
        Loop
        MsgBox("saved")
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        txtmedicine.Text = DataGridView1.CurrentRow.Cells(0).Value
        cmbdays.Text = DataGridView1.CurrentRow.Cells(1).Value
        cmbdosage.Text = DataGridView1.CurrentRow.Cells(2).Value
    End Sub

    Private Sub cmbpatid_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbpatid.SelectedIndexChanged
        Dim i = 0
        sql = "select * from tbl_prescription where PId='" & cmbpatid.Text & "'"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        DataGridView1.Rows.Clear()
        Do While Not rs.EOF
            DataGridView1.Rows.Add()
            DataGridView1.Item(0, i).Value = rs(3).Value
            DataGridView1.Item(1, i).Value = rs(4).Value
            DataGridView1.Item(2, i).Value = rs(5).Value
            DataGridView1.Item(3, i).Value = rs(6).Value
            rs.MoveNext()
            i = i + 1
        Loop
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        DataGridView1.Rows.Clear()

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
        frmmaster.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        medclear()
        cmbpatid.Text = ""
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "Inpatient" Then
            sql = "select * from tbl_Inpatients where doctorId='" & userid & "'"
            If rs.State = 1 Then rs.Close()
            rs.Open(sql, conn)
            Do While Not rs.EOF
                cmbpatid.Items.Add(rs(0).Value)
                rs.MoveNext()
            Loop
        Else
            sql = "select * from tbl_Outpatien where doctorId='" & userid & "'"
            If rs.State = 1 Then rs.Close()
            rs.Open(sql, conn)
            Do While Not rs.EOF
                cmbpatid.Items.Add(rs(0).Value)
                rs.MoveNext()
            Loop
        End If
    End Sub
End Class