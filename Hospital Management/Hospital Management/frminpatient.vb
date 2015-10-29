Public Class frminpatient

    Private Sub frminpatient_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Return
        opendb()
        cmbInpatientId.Visible = False
        lblbednum.Visible = False
        cmbbedno.Visible = False
        txtdocname.Enabled = False
        Label15.Visible = False
        txtadv.Visible = False
        loadPid()
        If outpatid <> "" Then
            loadPid()
            'Loading OutPatient Details
            sql = "select * from tbl_outpatien where OutPatientid='" & outpatid & "'"
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
                cmbdept.Text = rs(11).Value
                txtphone.Text = rs(9).Value
                txtadd.Text = rs(10).Value

                outpatid = ""
            End If
        End If
        sql = "select * from tbl_dept"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        cmbdept.Items.Clear()
        Do While rs.EOF = False
            cmbdept.Items.Add(rs(1).Value)
            rs.MoveNext()
        Loop
    End Sub
    Public y = Today.Year

    Sub loadPid()
        Dim id
        sql = "select MAX(cast(SUBSTRING(InpatId,5,len(InpatId))+1 as int ))from tbl_Inpatients"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        If IsDBNull(rs(0).Value) = True Then
            Txtinpatid.Text = y & "1001"
        Else
            If rs.EOF = False Then
                id = rs(0).Value
                id = y & id
                Txtinpatid.Text = id
            End If
        End If
    End Sub

    Sub inpatid()
        sql = "select * from tbl_Inpatients"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        Do While Not rs.EOF
            cmbInpatientId.Items.Add(rs(0).Value)
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
    Sub clear()
        txtadd.Text = ""
        txtdesies.Text = ""
        txtdocname.Text = ""
        txtname.Text = ""
        txtphone.Text = ""
        cmbbedno.Text = ""
        cmbbloodgroup.Text = ""
        cmbDoctid.Text = ""
        cmbgender.Text = ""
        cmbroomno.Text = ""
        cmbroomtype.Text = ""
        cmbdept.Text = ""

    End Sub

    Private Sub cmbroomtype_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbroomtype.SelectedIndexChanged
        
        If cmbroomtype.Text = "General Ward" Then
            cmbroomno.Text = ""
            cmbbedno.Text = ""
            lblbednum.Visible = True
            cmbbedno.Visible = True
            sql = "select distinct(Roomno) from tbl_assignbednum where Roomtype='General Ward' and status='vacant'"
            If rs.State = 1 Then rs.Close()
            rs.Open(sql, conn)
            cmbroomno.Items.Clear()
            Do While Not rs.EOF
                cmbroomno.Items.Add(rs(0).Value)
                rs.MoveNext()
            Loop
        ElseIf cmbroomtype.Text = "Semi" Then
            cmbroomno.Text = ""
            lblbednum.Visible = False
            cmbbedno.Visible = False
            sql = "select * from tbl_roomtype where Roomtype='Semi' and status='vacant'"
            If rs.State = 1 Then rs.Close()
            rs.Open(sql, conn)
            cmbroomno.Items.Clear()
            Do While Not rs.EOF
                cmbroomno.Items.Add(rs(1).Value)
                rs.MoveNext()
            Loop
        ElseIf cmbroomtype.Text = "Special ward" Then
            cmbroomno.Text = ""
            lblbednum.Visible = False
            cmbbedno.Visible = False
            sql = "select * from tbl_roomtype where Roomtype='Special ward' and status='vacant'"
            If rs.State = 1 Then rs.Close()
            rs.Open(sql, conn)
            cmbroomno.Items.Clear()
            Do While Not rs.EOF
                cmbroomno.Items.Add(rs(1).Value)
                rs.MoveNext()
            Loop
        ElseIf cmbroomtype.Text = "ICU" Then
            cmbroomno.Text = ""
            lblbednum.Visible = False
            cmbbedno.Visible = False
            sql = "select * from tbl_roomtype where Roomtype='ICU' and status='vacant'"
            If rs.State = 1 Then rs.Close()
            rs.Open(sql, conn)
            cmbroomno.Items.Clear()
            Do While Not rs.EOF
                cmbroomno.Items.Add(rs(1).Value)
                rs.MoveNext()
            Loop
        ElseIf cmbroomtype.Text = "Operation Theatre" Then
            cmbroomno.Text = ""
            lblbednum.Visible = False
            cmbbedno.Visible = False
            sql = "select * from tbl_roomtype where Roomtype='Operation Theatre' and status='vacant'"
            If rs.State = 1 Then rs.Close()
            rs.Open(sql, conn)
            cmbroomno.Items.Clear()
            Do While Not rs.EOF
                cmbroomno.Items.Add(rs(1).Value)
                rs.MoveNext()
            Loop
        End If

    End Sub

    Private Sub ADD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ADD.Click
        If Txtinpatid.Text = "" Or cmbroomtype.Text = "" Or cmbroomno.Text = "" Or txtname.Text = "" Or cmbgender.Text = "" Or txtadd.Text = "" Or txtphone.Text = "" Or cmbbloodgroup.Text = "" Or txtdesies.Text = "" Or cmbDoctid.Text = "" Or txtdocname.Text = "" Or cmbdept.Text = "" Then
            MsgBox("enter all fields")
        ElseIf txtphone.TextLength <> 10 Then
            MsgBox("mobile number should be of 10 digits")
        ElseIf txtphone.Text = "0000000000" Then
            MsgBox("enter the valid phone number")
        ElseIf cmbroomtype.Text = "General Ward" And cmbbedno.Text = "" Then
            MsgBox("enter bednumber")
        Else

            If cmbroomtype.Text = "General Ward" Then
                sql = "update tbl_assignbednum set status='occupied' where bedno='" & cmbbedno.Text & "'"
                conn.Execute(sql)
                sql = "insert into tbl_inpatients(InpatId,Name,DOB,gender,address,phone,bloodgroup,disease,doctorId,DOJ,docname,status,dept,advpay)"
                sql = sql & "values('" & Txtinpatid.Text & "','" & txtname.Text & "',convert(date,'" & DateTimePicker1.Value & "',103),'" & cmbgender.Text & "','" & txtadd.Text & "','" & txtphone.Text & "','" & cmbbloodgroup.Text & "','" & txtdesies.Text & "','" & cmbDoctid.Text & "',convert(date,'" & DateTimePicker2.Value & "',103),'" & txtdocname.Text & "','Admit','" & cmbdept.Text & "','0')"
                conn.Execute(sql)
                sql = "insert into tbl_roomallotment(PId,roomtype,roomnum,bedno,joindate,shiftdate,status)"
                sql = sql & "values('" & Txtinpatid.Text & "','" & cmbroomtype.Text & "','" & cmbroomno.Text & "','" & cmbbedno.Text & "',convert(date,'" & Today.Date & "',103),convert(date,'" & Today.Date & "',103),'Admit')"
                conn.Execute(sql)
                MsgBox("Patient details added successfully")
                loadPid()
                clear()
            Else
                sql = "update tbl_roomtype set status='occupied' where roomno='" & cmbroomno.Text & "'"
                conn.Execute(sql)
                sql = "insert into tbl_inpatients(InpatId,Name,DOB,gender,address,phone,bloodgroup,disease,doctorId,DOJ,docname,status,dept)"
                sql = sql & "values('" & Txtinpatid.Text & "','" & txtname.Text & "',convert(date,'" & DateTimePicker1.Value & "',103),'" & cmbgender.Text & "','" & txtadd.Text & "','" & txtphone.Text & "','" & cmbbloodgroup.Text & "','" & txtdesies.Text & "','" & cmbDoctid.Text & "',convert(date,'" & DateTimePicker2.Value & "',103),'" & txtdocname.Text & "','Admit','" & cmbdept.Text & "')"
                conn.Execute(sql)
                sql = "insert into tbl_roomallotment(PId,roomtype,roomnum,bedno,joindate,shiftdate,status)"
                sql = sql & "values('" & Txtinpatid.Text & "','" & cmbroomtype.Text & "','" & cmbroomno.Text & "','" & cmbbedno.Text & "',convert(date,'" & Today.Date & "',103),convert(date,'" & Today.Date & "',103),'Admit')"
                conn.Execute(sql)

                MsgBox("Patient details added successfully")
                loadPid()
                clear()

            End If
        End If
    End Sub

    Private Sub cmbDoctid_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbDoctid.SelectedIndexChanged
        sql = "select * from tbl_doctor where doctorid='" & cmbDoctid.Text & "'"
        If rss.State = 1 Then rss.Close()
        rss.Open(sql, conn)
        If rss.EOF = False Then
            txtdocname.Text = rss(1).Value

        End If
    End Sub
    Private Sub cmbroomno_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbroomno.SelectedIndexChanged
        sql = "select * from tbl_assignbednum where Roomno='" & cmbroomno.Text & "' and status='vacant'"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        cmbbedno.Items.Clear()
        Do While Not rs.EOF
            cmbbedno.Items.Add(rs(2).Value)
            rs.MoveNext()
        Loop
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        clear()
    End Sub
    Private Sub cmbInpatientId_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbInpatientId.SelectedIndexChanged
        sql = "select * from tbl_Inpatients where InpatId='" & cmbInpatientId.Text & "'"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        If rs.EOF = False Then
            Label15.Visible = True
            txtadv.Visible = True
            txtname.Text = rs(1).Value
            DateTimePicker1.Value = rs(2).Value
            cmbgender.Text = rs(3).Value
            DateTimePicker2.Value = rs(9).Value
            cmbbloodgroup.Text = rs(6).Value
            txtdesies.Text = rs(7).Value
            cmbDoctid.Text = rs(8).Value
            txtdocname.Text = rs(10).Value
            txtphone.Text = rs(5).Value
            txtadd.Text = rs(4).Value
            cmbdept.Text = rs(12).Value
        End If
    End Sub

    Private Sub btnupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdate.Click
        If Txtinpatid.Text = "" Or txtname.Text = "" Or cmbgender.Text = "" Or txtadd.Text = "" Or txtphone.Text = "" Or cmbbloodgroup.Text = "" Or txtdesies.Text = "" Or cmbDoctid.Text = "" Or txtdocname.Text = "" Or cmbdept.Text = "" Then
            MsgBox("enter all fields")
        ElseIf cmbroomtype.Text = "General Ward" And cmbbedno.Text = "" Then
            MsgBox("enter bednumber")
        Else
            sql = "update tbl_Inpatients set name='" & txtname.Text & "',DOB=convert(date,'" & DateTimePicker1.Value & "',103),gender='" & cmbgender.Text & "',address='" & txtadd.Text & "',phone='" & txtphone.Text & "',bloodgroup='" & cmbbloodgroup.Text & "',disease='" & txtdesies.Text & "',doctorId='" & cmbDoctid.Text & "',DOJ=convert(date,'" & DateTimePicker2.Value & "',103),docname='" & txtdocname.Text & "',dept='" & cmbdept.Text & "',advpay='" & txtadv.Text & "' where InpatId='" & cmbInpatientId.Text & "' "
            conn.Execute(sql)
            MsgBox("Updated successfully")
            clear()
            cmbInpatientId.Text = ""

        End If

    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        sql = "delete from tbl_Inpatients where InpatId='" & cmbInpatientId.Text & "'"
        conn.Execute(sql)
        MsgBox("Deleted successfully")

        clear()
        cmbInpatientId.Text = ""
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Close()
        frmmaster.Show()
    End Sub
    Private Sub cmbdept_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbdept.SelectedIndexChanged
        loaddocid()
    End Sub

    
    Private Sub txtname_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtname.KeyDown
        CheckAlpha(e)
    End Sub

    Private Sub txtphone_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtphone.KeyDown
        CheckNum(e)
    End Sub

    Private Sub txtphone_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtphone.TextChanged

    End Sub

    Private Sub txtadd_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtadd.KeyDown
        CheckAlpha(e)
    End Sub

    Private Sub txtdesies_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtdesies.KeyDown
        CheckAlpha(e)
    End Sub
End Class