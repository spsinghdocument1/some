Public Class Frmnurse

    Dim year
    Dim dtpdate As Date
    Private Sub Frmnurse_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Return

        opendb()
        year = Now.Year - 23
        dtpdate = Now.Day & "/" & Now.Month & "/" & year
        DateTimePicker1.MaxDate = dtpdate
        sql = "select * from tbl_dept"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        Cmbdept.Items.Clear()
        Do While rs.EOF = False
            Cmbdept.Items.Add(rs(1).Value)
            rs.MoveNext()
        Loop
        loadid()
        loadnurse()
        DateTimePicker2.MinDate = Today.Date
        DateTimePicker2.MaxDate = Today.Date
        DateTimePicker3.Visible = False
        DateTimePicker3.Enabled = False
        btnupdate.Enabled = False
        btndelete.Enabled = False
    End Sub
    Sub clear()
        txtNurseid.Text = ""
        txtsalary.Text = ""
        TxtNursename.Text = ""
        Txtqualification.Text = ""
        Cmbdept.Text = ""
        'DateTimePicker1.Value = Today.Date
        DateTimePicker2.Value = Today.Date
        DateTimePicker3.Value = Today.Date
    End Sub
    Sub loadid()
        Dim id
        sql = "select MAX(cast(SUBSTRING(nurseid,2,len(nurseid))+1 as int ))from tbl_nurse "
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        If IsDBNull(rs(0).Value) = True Then
            txtNurseid.Text = "N101"
        Else
            If rs.EOF = False Then
                id = rs(0).Value
                id = "N" & id
                txtNurseid.Text = id
            End If
        End If
    End Sub
    Sub loadnurse()
        Dim i
        i = 0
        sql = "select * from tbl_nurse"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        DataGridView1.Rows.Clear()
        Do While rs.EOF = False
            DataGridView1.Rows.Add()
            DataGridView1.Item(0, i).Value = rs(0).Value
            DataGridView1.Item(1, i).Value = rs(1).Value
            DataGridView1.Item(2, i).Value = rs(2).Value
            DataGridView1.Item(3, i).Value = rs(3).Value
            DataGridView1.Item(5, i).Value = rs(5).Value
            DataGridView1.Item(4, i).Value = rs(4).Value
            DataGridView1.Item(6, i).Value = rs(6).Value
            rs.MoveNext()
            i = i + 1

        Loop
    End Sub

    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
        If Cmbdept.Text = "" Or TxtNursename.Text = "" Or Txtqualification.Text = "" Or txtsalary.Text = "" Then
            MsgBox("enter all the fields")
        ElseIf txtsalary.Text < 7000 Then
            MsgBox("salary shoud be atleast 7000")
        ElseIf txtsalary.Text > 15000 Then
            MsgBox("salary shoud be belove 15000")
        Else
            sql = "insert into tbl_nurse(nurseid,nursename,deptname,dob,doj,qualification,salary)"
            sql = sql & "values('" & txtNurseid.Text & "','" & TxtNursename.Text & "','" & Cmbdept.Text & "',convert(date,'" & DateTimePicker1.Value & "',103),convert(date,'" & DateTimePicker2.Value & "',103),'" & Txtqualification.Text & "','" & txtsalary.Text & "')"
            conn.Execute(sql)
            MsgBox("added successfully")
            clear()
            loadid()
            loadnurse()
        End If
    End Sub

    Private Sub btnreset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreset.Click
        clear()
        btnupdate.Enabled = False
        btndelete.Enabled = False
        btnadd.Enabled = True
        loadid()
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        btnupdate.Enabled = True
        btndelete.Enabled = True
        btnadd.Enabled = False

        Dim Location As System.Drawing.Point

        DateTimePicker3.Visible = True
        DateTimePicker2.Visible = False
        
        'DateTimePicker3.MaxDate = Today.Date
        DateTimePicker1.MaxDate = DataGridView1.CurrentRow.Cells(3).Value
        Cmbdept.Text = DataGridView1.CurrentRow.Cells(2).Value
        txtNurseid.Text = DataGridView1.CurrentRow.Cells(0).Value
        TxtNursename.Text = DataGridView1.CurrentRow.Cells(1).Value
        DateTimePicker1.Value = DataGridView1.CurrentRow.Cells(3).Value
        Txtqualification.Text = DataGridView1.CurrentRow.Cells(5).Value
        DateTimePicker3.Value = DataGridView1.CurrentRow.Cells(4).Value
        txtsalary.Text = DataGridView1.CurrentRow.Cells(6).Value
    End Sub

    Private Sub btnupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdate.Click
        If Cmbdept.Text = "" Or TxtNursename.Text = "" Or Txtqualification.Text = "" Or txtsalary.Text = "" Then
            MsgBox("some fields are empty")

        ElseIf txtsalary.Text < 7000 Then
            MsgBox("salary shoud be atleast 7000")
        ElseIf txtsalary.Text > 15000 Then
            MsgBox("salary shoud be belove 15000")
        Else
            sql = "update tbl_nurse set deptname='" & Cmbdept.Text & "',nursename='" & TxtNursename.Text & "',dob=convert(date,'" & DateTimePicker1.Value & "',103),doj=convert(date,'" & DateTimePicker2.Value & "',103),qualification='" & Txtqualification.Text & "',salary='" & txtsalary.Text & "' where nurseid='" & txtNurseid.Text & "'"
            conn.Execute(sql)
            MsgBox("updated successfully")
            clear()
            loadid()
            loadnurse()
            btnupdate.Enabled = False
            btndelete.Enabled = False
            btnadd.Enabled = True

        End If
    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        sql = "delete from tbl_nurse where nurseid='" & txtNurseid.Text & "'"
        conn.Execute(sql)
        MsgBox(" deleted successfully")
        clear()
        loadid()
        loadnurse()
        btnupdate.Enabled = False
        btndelete.Enabled = False
        btnadd.Enabled = True

    End Sub

    Private Sub btnadd_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnadd.MouseEnter
        btnadd.BackColor = Color.PaleGreen

    End Sub

    Private Sub btnadd_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnadd.MouseLeave
        btnadd.BackColor = Color.Transparent
    End Sub

    
    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Me.Close()
        frmmaster.Show()

    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click

    End Sub

    Private Sub DateTimePicker3_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker3.ValueChanged

    End Sub

    Private Sub TxtNursename_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtNursename.KeyDown
        CheckAlpha(e)
    End Sub

    Private Sub Txtqualification_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Txtqualification.KeyDown
        CheckAlpha(e)
    End Sub

    Private Sub txtsalary_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtsalary.KeyDown
        CheckNum(e)
    End Sub

    Private Sub Cmbdept_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Cmbdept.KeyDown
        CheckAlpha(e)
        CheckNum(e)
    End Sub
End Class