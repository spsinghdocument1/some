Public Class frmdoctor
    Dim year
    Dim dtpdate As Date
    Private Sub frmdoctor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Return

        opendb()
        year = Now.Year - 23
        dtpdate = Now.Day & "/" & Now.Month & "/" & year
        DateTimePicker1.MaxDate = dtpdate
        sql = "select * from tbl_dept"
        If rs.State = 1 Then rs.Close()
        '    rs.Open(sql, conn)
        Cmbdept.Items.Clear()
        Do While rs.EOF = False
            Cmbdept.Items.Add(rs(1).Value)
            rs.MoveNext()
        Loop
        loadid()
        loadgrid()
        btnupdate.Enabled = False
        btndelete.Enabled = False
        DateTimePicker2.MinDate = Today.Date
        DateTimePicker2.MaxDate = Today.Date
        DateTimePicker3.Visible = False
        DateTimePicker3.Enabled = False

    End Sub
    Sub clear()
        Cmbdept.Text = ""
        txtdoctorid.Text = ""
        Txtdoctorname.Text = ""
        Txtqualification.Text = ""
        txtsalary.Text = ""
    End Sub
    Sub loadid()
        Dim id
        sql = "select MAX(cast(SUBSTRING(doctorid,2,len(doctorid))+1 as int ))from tbl_doctor "
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        If IsDBNull(rs(0).Value) = True Then
            txtdoctorid.Text = "D101"
        Else
            If rs.EOF = False Then
                id = rs(0).Value
                id = "D" & id
                txtdoctorid.Text = id
            End If
        End If
    End Sub
    Sub loadgrid()
        Dim i = 0
        sql = " select * from tbl_doctor"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        DataGridView1.Rows.Clear()
        Do While Not rs.EOF
            DataGridView1.Rows.Add()
            DataGridView1.Item(0, i).Value = rs(2).Value
            DataGridView1.Item(1, i).Value = rs(0).Value
            DataGridView1.Item(2, i).Value = rs(1).Value
            DataGridView1.Item(3, i).Value = rs(3).Value
            DataGridView1.Item(4, i).Value = rs(5).Value
            DataGridView1.Item(5, i).Value = rs(4).Value
            DataGridView1.Item(6, i).Value = rs(7).Value
            rs.MoveNext()
            i = i + 1
        Loop

    End Sub

    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
        If Cmbdept.Text = "" Or Txtdoctorname.Text = "" Or Txtqualification.Text = "" Or txtsalary.Text = "" Then
            MsgBox("enter all the fields")
        Else

            sql = "insert into tbl_doctor (doctorid,doctorname,deptname,dob,doj,qualification,status,salary) "
            sql = sql & "values('" & txtdoctorid.Text & "','" & Txtdoctorname.Text & "','" & Cmbdept.Text & "',convert(date,'" & DateTimePicker1.Value & "',103),convert(date,'" & DateTimePicker2.Value & "',103),'" & Txtqualification.Text & "','unregistered','" & txtsalary.Text & "')"
            conn.Execute(sql)
            MsgBox("added successfully")
            clear()
            loadid()
            loadgrid()

        End If
    End Sub

    Private Sub btnreset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreset.Click
        clear()
        loadid()
        btnupdate.Enabled = False
        btndelete.Enabled = False
        btnadd.Enabled = True
    End Sub

    
    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        btnadd.Enabled = False
        btnupdate.Enabled = True
        btndelete.Enabled = True
        DateTimePicker1.MaxDate = DataGridView1.CurrentRow.Cells(3).Value
        DateTimePicker2.Visible = False
        DateTimePicker3.Visible = True
        DateTimePicker3.MaxDate = Today.Date
        Cmbdept.Text = DataGridView1.CurrentRow.Cells(0).Value
        txtdoctorid.Text = DataGridView1.CurrentRow.Cells(1).Value
        Txtdoctorname.Text = DataGridView1.CurrentRow.Cells(2).Value
        DateTimePicker1.Value = DataGridView1.CurrentRow.Cells(3).Value
        Txtqualification.Text = DataGridView1.CurrentRow.Cells(4).Value
        DateTimePicker3.Value = DataGridView1.CurrentRow.Cells(5).Value
        txtsalary.Text = DataGridView1.CurrentRow.Cells(6).Value
    End Sub

    Private Sub btnupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdate.Click
        If Cmbdept.Text = "" Or Txtdoctorname.Text = "" Or Txtqualification.Text = "" Or txtsalary.Text = "" Then
            MsgBox("some fields are empty")
        Else
            sql = "update tbl_doctor set deptname='" & Cmbdept.Text & "',doctorname='" & Txtdoctorname.Text & "',dob=convert(date,'" & DateTimePicker1.Value & "',103),qualification='" & Txtqualification.Text & "',doj=convert(date,'" & DateTimePicker3.Value & "',103),salary='" & txtsalary.Text & "' where doctorid='" & txtdoctorid.Text & "'"
            conn.Execute(sql)
            MsgBox(" updated successfully")
            sql = "update tbl_register set username='" & Txtdoctorname.Text & "'where userid='" & txtdoctorid.Text & "'"
            conn.Execute(sql)
            clear()
            loadgrid()
            loadid()
            btnadd.Enabled = True
            btnupdate.Enabled = False
            btndelete.Enabled = False
        End If
    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        sql = "delete from tbl_doctor where doctorid='" & txtdoctorid.Text & "'"
        conn.Execute(sql)
        MsgBox(" deleted successfully")

        sql = "delete from tbl_register where userid='" & txtdoctorid.Text & "'"
        conn.Execute(sql)
        clear()
        loadgrid()
        loadid()
        btnadd.Enabled = True
        btnupdate.Enabled = False
        btndelete.Enabled = False

    End Sub

    Private Sub Cmbdept_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Cmbdept_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Cmbdept.KeyDown
        CheckAlpha(e)
        CheckNum(e)
    End Sub

    Private Sub Cmbdept_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmbdept.SelectedIndexChanged

    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Me.Close()
        frmmaster.Show()
    End Sub

    Private Sub txtsalary_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtsalary.KeyDown
        CheckNum(e)
    End Sub

    Private Sub Txtdoctorname_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Txtdoctorname.KeyDown
        CheckAlpha(e)
    End Sub

    Private Sub Txtqualification_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Txtqualification.KeyDown
        CheckAlpha(e)
    End Sub


    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "MD" Then
            txtsalary.Text = 50000
        ElseIf ComboBox1.Text = "ABC" Then
            txtsalary.Text = 25000
        ElseIf ComboBox1.Text = "XYZ" Then
            txtsalary.Text = 30000
        End If
    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub
End Class