Public Class frmemployee
    Dim Receptionist As String
    Dim year
    Dim dtpdate As Date
    Private Sub frmemployee_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Return
        opendb()
        year = Now.Year - 18
        dtpdate = Now.Day & "/" & Now.Month & "/" & year
        DateTimePicker1.MaxDate = dtpdate
        loademp()
        DateTimePicker3.Visible = False
        DateTimePicker2.MinDate = Today.Date
        DateTimePicker2.MaxDate = Today.Date
        sql = "select * from tbl_design"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        cmbdesig.Items.Clear()
        Do While rs.EOF = False
            cmbdesig.Items.Add(rs(1).Value)
            rs.MoveNext()
        Loop
        btnupdate.Enabled = False
        btndelete.Enabled = False
        DateTimePicker2.MinDate = Today.Date
        DateTimePicker2.MaxDate = Today.Date
        DateTimePicker3.Visible = False
        DateTimePicker3.Enabled = False
    End Sub
    Sub loademp()
        Dim i = 0
        sql = " select * from tbl_emp"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        DataGridView1.Rows.Clear()
        Do While Not rs.EOF
            DataGridView1.Rows.Add()
            DataGridView1.Item(0, i).Value = rs(0).Value
            DataGridView1.Item(1, i).Value = rs(1).Value
            DataGridView1.Item(2, i).Value = rs(2).Value
            DataGridView1.Item(3, i).Value = rs(6).Value
            DataGridView1.Item(4, i).Value = rs(3).Value
            DataGridView1.Item(5, i).Value = rs(4).Value
            DataGridView1.Item(6, i).Value = rs(5).Value
            rs.MoveNext()
            i = i + 1
        Loop

    End Sub
    Sub clear()
        cmbdesig.Text = ""
        Txtempid.Text = ""
        Txtempname.Text = ""
        txtqualification.Text = ""
        txtsalary.Text = ""

    End Sub
    Private Sub Btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnadd.Click
        If cmbdesig.Text = "" Or Txtempname.Text = "" Or txtqualification.Text = "" Or txtsalary.Text = "" Then
            MsgBox("enter all the fields")
        ElseIf txtsalary.Text < 5000 Then
            MsgBox("salary shoud be atleast 5000")
        ElseIf txtsalary.Text > 15000 Then
            MsgBox("salary shoud be belove 15000")
        Else
            sql = " insert into tbl_emp (emp_id,emp_name,emp_desig,dob,doj,qulification,salary,status)"
            sql = sql & " values('" & Txtempid.Text & "' ,'" & Txtempname.Text & "','" & cmbdesig.Text & "',convert(date,'" & DateTimePicker1.Value & "',103),convert(date,'" & DateTimePicker2.Value & "',103),'" & txtqualification.Text & "','" & txtsalary.Text & "','unregistered')"
            conn.Execute(sql)
            MsgBox("employee added")
            clear()
            loademp()
        End If
    End Sub

    Private Sub btnreset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreset.Click
        clear()
        loademp()
        btnupdate.Enabled = False
        btndelete.Enabled = False
        Btnadd.Enabled = True

    End Sub

    Private Sub cmbdesig_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbdesig.KeyDown
        CheckAlpha(e)
        CheckNum(e)
    End Sub

    Private Sub cmbdesig_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbdesig.SelectedIndexChanged
        Dim strData, var As String

        strData = cmbdesig.Text
        ''Display the first three characters
        var = (strData.Substring(0, 3))
        'Txtempid.Text = var
        Dim id
        sql = "select MAX(cast(SUBSTRING(emp_id,4,len(emp_id))+1 as int ))from tbl_emp where emp_id like '" & var & "%'"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        If IsDBNull(rs(0).Value) = True Then
            Txtempid.Text = var & 101
        Else
            If rs.EOF = False Then
                id = rs(0).Value
                id = var & id
                Txtempid.Text = id
            End If
        End If
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Me.Close()
        frmmaster.Show()

    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Btnadd.Enabled = False
        btnupdate.Enabled = True
        btndelete.Enabled = True
        DateTimePicker2.Visible = False
        DateTimePicker3.Visible = True
        DateTimePicker3.MaxDate = Today.Date
        DateTimePicker1.MaxDate = DataGridView1.CurrentRow.Cells(4).Value
        cmbdesig.Text = DataGridView1.CurrentRow.Cells(2).Value
        Txtempid.Text = DataGridView1.CurrentRow.Cells(0).Value
        Txtempname.Text = DataGridView1.CurrentRow.Cells(1).Value

        txtsalary.Text = DataGridView1.CurrentRow.Cells(3).Value
        DateTimePicker1.Value = DataGridView1.CurrentRow.Cells(4).Value
        DateTimePicker3.Value = DataGridView1.CurrentRow.Cells(5).Value
        txtqualification.Text = DataGridView1.CurrentRow.Cells(6).Value
    End Sub

    Private Sub btnupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdate.Click
        If cmbdesig.Text = "" Or Txtempname.Text = "" Or txtqualification.Text = "" Or txtsalary.Text = "" Then
            MsgBox("some fields are empty")
        ElseIf txtsalary.Text < 5000 Then
            MsgBox("salary shoud be atleast 5000")
        ElseIf txtsalary.Text > 15000 Then
            MsgBox("salary shoud be belove 15000")
        Else
            sql = "update tbl_emp set emp_name='" & Txtempname.Text & "',emp_desig='" & cmbdesig.Text & "',dob=convert(date,'" & DateTimePicker1.Value & "',103),doj=convert(date,'" & DateTimePicker3.Value & "',103),qulification='" & txtqualification.Text & "',salary='" & txtsalary.Text & "' where emp_id='" & Txtempid.Text & "'"
            conn.Execute(sql)
            sql = "update tbl_register set username='" & Txtempname.Text & "' where userid='" & Txtempid.Text & "' and usertype='" & cmbdesig.Text & "'"
            conn.Execute(sql)
            MsgBox(" updated successfully")
            Btnadd.Enabled = True
            btnupdate.Enabled = False
            btndelete.Enabled = False
            DateTimePicker3.Visible = False
            DateTimePicker2.Visible = True
            clear()
            loademp()
            cmbdesig.Text = ""
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Txtempname_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Txtempname.KeyDown
        CheckAlpha(e)

    End Sub

    Private Sub txtsalary_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtsalary.KeyDown
        CheckNum(e)
    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        sql = "delete from tbl_emp where emp_id='" & Txtempid.Text & "'"
        conn.Execute(sql)
        sql = "delete from tbl_register where userid='" & Txtempid.Text & "' and usertype='" & cmbdesig.Text & "'"
        conn.Execute(sql)
        MsgBox("Deleted SuccessFully")
        clear()
        loademp()
        Btnadd.Enabled = True
        btnupdate.Enabled = False
        btndelete.Enabled = False
    End Sub

    Private Sub txtqualification_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtqualification.KeyDown
        CheckAlpha(e)
    End Sub
End Class