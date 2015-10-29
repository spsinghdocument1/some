Public Class frmdept

    

    Private Sub frmdept_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Return
        opendb()
        Panel1.Visible = False
        Panel2.Visible = False
        loaddept()
        loaddesig()

    End Sub
    Sub loaddept()
        Dim i = 0
        sql = " select * from tbl_dept"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        DataGridView1.Rows.Clear()
        Do While Not rs.EOF
            DataGridView1.Rows.Add()
            DataGridView1.Item(0, i).Value = rs(0).Value
            DataGridView1.Item(1, i).Value = rs(1).Value
            rs.MoveNext()
            i = i + 1
        Loop

    End Sub
    Sub loaddesig()
        Dim i = 0
        sql = " select * from tbl_design"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        DataGridView2.Rows.Clear()
        Do While Not rs.EOF
            DataGridView2.Rows.Add()
            DataGridView2.Item(0, i).Value = rs(0).Value
            DataGridView2.Item(1, i).Value = rs(1).Value
            rs.MoveNext()
            i = i + 1
        Loop
    End Sub
    Sub loaddeptid()
        Dim depid
        sql = " select max(deptid) from tbl_dept"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        If IsDBNull(rs(0).Value) = True Then
            depid = 1
            Txtdeptid.Text = depid
        Else
            depid = rs(0).Value
            Txtdeptid.Text = depid + 1
        End If
    End Sub
    Sub loaddesigID()
        Dim desid
        sql = " select max(id) from tbl_design"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        If IsDBNull(rs(0).Value) = True Then
            desid = 1
            txtdesid.Text = desid
        Else
            desid = rs(0).Value
            txtdesid.Text = desid + 1
        End If
    End Sub

    Private Sub Btnadd_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnadd.Click

        If Txtdeptname.Text = "" And Txtdeptid.Text = "" Then
            MsgBox("pls click on new button to add new dept")
        ElseIf Txtdeptname.Text = "" Then
            MsgBox("Pls enter the department name")
        Else
            sql = "select * from tbl_dept where deptname='" & Txtdeptname.Text & "'"
            If rs.State = 1 Then rs.Close()
            rs.Open(sql, conn)
            If rs.EOF = False Then
                MsgBox("department exist!!!!")
            Else
                sql = "insert into tbl_dept(deptid,deptname)"
                sql = sql & "values('" & Txtdeptid.Text & "','" & Txtdeptname.Text & "')"
                conn.Execute(sql)
                MsgBox("department added !!!")
                Txtdeptid.Text = ""
                Txtdeptname.Text = ""
                loaddept()
            End If
        End If
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Panel1.Visible = False
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Panel1.Visible = True
        Panel2.Visible = False

    End Sub

    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Panel1.Visible = False
        Panel2.Visible = True
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd1.Click
        If txtdesname.Text = "" And txtdesid.Text = "" Then
            MsgBox("pls click on new button to add new designation")
        ElseIf txtdesname.Text = "" Then
            MsgBox("Pls enter the Designation")
        Else
            sql = "select * from tbl_design where name='" & txtdesname.Text & "'"
            If rs.State = 1 Then rs.Close()
            rs.Open(sql, conn)
            If rs.EOF = False Then
                MsgBox("designation already exist!!!!")
            Else
                sql = "insert into tbl_design(id,name)"
                sql = sql & "values('" & txtdesid.Text & "','" & txtdesname.Text & "')"
                conn.Execute(sql)
                MsgBox("designation added !!!")
                txtdesid.Text = ""
                txtdesname.Text = ""
                loaddesig()
            End If
        End If
       
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Panel2.Visible = False
    End Sub

    

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Btnadd.Enabled = False
        btndelete.Enabled = True
        btnupdate.Enabled = True
        Txtdeptid.Text = DataGridView1.CurrentRow.Cells(0).Value
        Txtdeptname.Text = DataGridView1.CurrentRow.Cells(1).Value
    End Sub

    Private Sub DataGridView2_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.CellClick
        btnadd1.Enabled = False
        btndelete1.Enabled = True
        btnupdate1.Enabled = True
        txtdesid.Text = DataGridView2.CurrentRow.Cells(0).Value
        txtdesname.Text = DataGridView2.CurrentRow.Cells(1).Value
    End Sub

    Private Sub btnnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnew.Click
        Btnadd.Enabled = True
        btndelete.Enabled = False
        btnupdate.Enabled = False
        loaddeptid()
        Txtdeptname.Text = ""
    End Sub

    Private Sub btnupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdate.Click
        If Txtdeptname.Text = "" Then
            MsgBox("some field are empty")
        Else
            sql = "update tbl_dept set deptname='" & Txtdeptname.Text & "' where deptid='" & Txtdeptid.Text & "'"
            conn.Execute(sql)
            MsgBox("record updated successfully")

            Txtdeptid.Text = ""
            Txtdeptname.Text = ""
            Btnadd.Enabled = True
            btndelete.Enabled = False
            btnupdate.Enabled = False
            loaddept()
        End If
    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        sql = "select * from tbl_doctor where deptname='" & Txtdeptname.Text & "'"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        If rs.EOF = False Then
            MsgBox("You have assigned some doctor's in this department!! Pls update doctor record first")

        Else

            sql = "select * from tbl_nurse where deptname='" & Txtdeptname.Text & "'"
            If rs.State = 1 Then rs.Close()
            rs.Open(sql, conn)
            If rs.EOF = False Then
                MsgBox("You have assigned some nurse in this department!! Pls update nurse record first")
            Else
                sql = "delete from tbl_dept where deptid='" & Txtdeptid.Text & "'"
                conn.Execute(sql)
                MsgBox("department deleted successfully")
                Txtdeptid.Text = ""
                Txtdeptname.Text = ""
                Btnadd.Enabled = True
                btndelete.Enabled = False
                btnupdate.Enabled = False
                loaddept()
            End If
        End If
    End Sub

    Private Sub btnnew2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnew2.Click
        btnadd1.Enabled = True
        btndelete1.Enabled = False
        btnupdate1.Enabled = False
        loaddesigID()
        txtdesname.Text = ""
    End Sub


    Private Sub btnupdate1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdate1.Click
        If txtdesname.Text = "" Then
            MsgBox("some field are empty")
        Else
            sql = "update tbl_design set name='" & txtdesname.Text & "' where id='" & txtdesid.Text & "'"
            conn.Execute(sql)
            MsgBox("record updated successfully")
            txtdesid.Text = ""
            txtdesname.Text = ""
            Btnadd.Enabled = True
            btndelete.Enabled = False
            btnupdate.Enabled = False

            loaddesig()
        End If
    End Sub

    Private Sub btndelete1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete1.Click
        sql = "select * from tbl_emp where emp_desig='" & txtdesname.Text & "'"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        If rs.EOF = False Then
            MsgBox("You have assigned some employyee's in this designation!! Pls update employee record first")

        Else
            sql = "delete from tbl_design where id='" & txtdesid.Text & "'"
            conn.Execute(sql)
            MsgBox("designation deleted successfully")
            txtdesid.Text = ""
            txtdesname.Text = ""
            Btnadd.Enabled = True
            btndelete.Enabled = False
            btnupdate.Enabled = False
            loaddesig()

        End If
    End Sub

    Private Sub LinkLabel3_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        Me.Close()
        frmmaster.Show()

    End Sub

   
    Private Sub Txtdeptname_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Txtdeptname.KeyDown
        CheckAlpha(e)
    End Sub

    Private Sub txtdesname_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtdesname.KeyDown
        CheckAlpha(e)
    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Txtdeptid.Text = ""
        Txtdeptname.Text = ""
        loaddeptid()
        btnupdate.Enabled = False
        btndelete.Enabled = False
        Btnadd.Enabled = True
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        txtdesid.Text = ""
        txtdesname.Text = ""
        loaddesigID()
        btnupdate.Enabled = False
        btndelete.Enabled = False
        Btnadd.Enabled = True
    End Sub
End Class