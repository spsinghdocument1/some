Public Class frmoutpatient

    Private Sub frmoutpatient_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Return
        opendb()
        loadOPid()
        clear()
        outpatid()
        sql = "select * from tbl_dept"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        cmbdept.Items.Clear()
        Do While rs.EOF = False
            cmbdept.Items.Add(rs(1).Value)
            rs.MoveNext()
        Loop
    End Sub
    Sub loaddocid()
        sql = "select * from tbl_doctor where status='Registered' and deptname='" & cmbdept.Text & "'"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        cmbDoctid.Items.Clear()
        Do While rs.EOF = False
            cmbDoctid.Items.Add(rs(0).Value)
            rs.MoveNext()
        Loop
    End Sub
    Sub loadOPid()
        Dim id
        sql = "select MAX(cast(SUBSTRING(OutPatientid,3,len(OutPatientid))+1 as int ))from tbl_outpatien "
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        If IsDBNull(rs(0).Value) = True Then
            Txtoutpatid.Text = "OP101"
        Else
            If rs.EOF = False Then
                id = rs(0).Value
                id = "OP" & id
                Txtoutpatid.Text = id
            End If
        End If
    End Sub
    'Load OutPatientId to combobox to edit or delete
    Sub outpatid()
        sql = "select * from tbl_outpatien"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        cmboutpatientid.Items.Clear()
        Do While Not rs.EOF
            cmboutpatientid.Items.Add(rs(0).Value)
            rs.MoveNext()
        Loop
    End Sub
    Private Sub ADD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ADD.Click
        If Txtoutpatid.Text = "" Or txtname.Text = "" Or cmbgender.Text = "" Or txtadd.Text = "" Or txtphone.Text = "" Or cmbbloodgroup.Text = "" Or txtdesies.Text = "" Or cmbDoctid.Text = "" Or txtdocname.Text = "" Or cmbdept.Text = "" Then
            MsgBox("enter all fields")
        Else
            sql = "insert into tbl_outpatien(Outpatientid,Name,dateOfBirth,Gender,date,BloodGroup,Diseas,Doctorid,Doctorname,Phone,Address,dept)"
            sql = sql & "values('" & Txtoutpatid.Text & "','" & txtname.Text & "',convert(date,'" & DateTimePicker1.Value & "',103),'" & cmbgender.Text & "',convert(date,'" & DateTimePicker2.Value & "',103),'" & cmbbloodgroup.Text & "','" & txtdesies.Text & "','" & cmbDoctid.Text & "','" & txtdocname.Text & "','" & txtphone.Text & "','" & txtadd.Text & "','" & cmbdept.Text & "')"
            conn.Execute(sql)
            MsgBox("Record added")
            clear()
            loadOPid()
        End If
    End Sub

    Private Sub cmbDoctid_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbDoctid.KeyDown
        CheckAlpha(e)
        CheckNum(e)
    End Sub

    Private Sub cmbDoctid_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbDoctid.SelectedIndexChanged
        sql = "select * from tbl_doctor where doctorid='" & cmbDoctid.Text & "'"
        If rss.State = 1 Then rss.Close()
        rss.Open(sql, conn)
        If rss.EOF = False Then
            txtdocname.Text = rss(1).Value

        End If
    End Sub

    Private Sub cmboutpatientid_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmboutpatientid.KeyDown
        CheckAlpha(e)
        CheckNum(e)
    End Sub

    Private Sub cmboutpatientid_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmboutpatientid.SelectedIndexChanged
        sql = "select * from tbl_outpatien where Outpatientid='" & cmboutpatientid.Text & "'"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        If rs.EOF = False Then
            txtname.Text = rs(1).Value
            DateTimePicker1.Value = rs(2).Value
            cmbgender.Text = rs(3).Value
            DateTimePicker2.Value = rs(4).Value
            cmbbloodgroup.Text = rs(5).Value
            txtdesies.Text = rs(6).Value
            cmbDoctid.Text = rs(7).Value
            txtdocname.Text = rs(8).Value
            txtphone.Text = rs(9).Value
            txtadd.Text = rs(10).Value
            cmbdept.Text = rs(11).Value
        End If
    End Sub

   

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        sql = "delete from tbl_outpatien Where OutPatientid='" & cmboutpatientid.Text & "' "
        conn.Execute(sql)
        MsgBox("Deleted successfully")
        clear()
        cmboutpatientid.Text = ""
    End Sub

    Private Sub btnupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdate.Click
        If Txtoutpatid.Text = "" Or txtname.Text = "" Or cmbgender.Text = "" Or txtadd.Text = "" Or txtphone.Text = "" Or cmbbloodgroup.Text = "" Or txtdesies.Text = "" Or cmbDoctid.Text = "" Or txtdocname.Text = "" Or cmbdept.Text = "" Then
            MsgBox("enter all fields")
        Else
            sql = "update tbl_outpatien set name='" & txtname.Text & "',DateOfBirth=convert(date,'" & DateTimePicker1.Value & "',103),Gender='" & cmbgender.Text & "',Address='" & txtadd.Text & "',Phone='" & txtphone.Text & "',BloodGroup='" & cmbbloodgroup.Text & "',Diseas='" & txtdesies.Text & "',Doctorid='" & cmbDoctid.Text & "',date=convert(date,'" & DateTimePicker2.Value & "',103),Doctorname='" & txtdocname.Text & "' where OutPatientid='" & cmboutpatientid.Text & "' "
            conn.Execute(sql)
            MsgBox("Updated successfully")
            cmboutpatientid.Text = ""
            clear()
        End If
    End Sub
    Sub clear()
        txtname.Text = ""
        cmbbloodgroup.Text = ""
        txtdesies.Text = ""
        cmbDoctid.Text = ""
        txtdocname.Text = ""
        txtphone.Text = ""
        txtadd.Text = ""
        cmbgender.Text = ""
        cmbdept.Text = ""
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Close()
        frmmaster.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        clear()
    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click

    End Sub

    Private Sub cmbdept_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbdept.KeyDown
        CheckAlpha(e)
        CheckNum(e)
    End Sub

    Private Sub cmbdept_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbdept.SelectedIndexChanged
        loaddocid()
    End Sub

    Private Sub txtadd_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtadd.KeyDown
        CheckAlpha(e)
    End Sub

    Private Sub txtdesies_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtdesies.KeyDown
        CheckAlpha(e)

    End Sub

    Private Sub txtname_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtname.KeyDown
        CheckAlpha(e)
    End Sub

    Private Sub txtphone_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtphone.KeyDown
        CheckNum(e)
    End Sub

    Private Sub cmbgender_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbgender.KeyDown
        CheckAlpha(e)
        CheckNum(e)
    End Sub

    Private Sub cmbbloodgroup_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbbloodgroup.KeyDown
        CheckAlpha(e)
        CheckNum(e)
    End Sub
End Class