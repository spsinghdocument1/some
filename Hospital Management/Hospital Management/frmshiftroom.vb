Public Class frmshiftroom

    Private Sub frmshiftroom_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Return
        opendb()
        lblbednum.Visible = False
        txtbednum.Visible = False

        sql = "select * from tbl_inpatients where status='Admit'"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        cmbpatientid.Items.Clear()
        Do While rs.EOF = False
            cmbpatientid.Items.Add(rs(0).Value)
            rs.MoveNext()
        Loop
    End Sub

    Private Sub cmbpatientid_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbpatientid.KeyDown
        CheckAlpha(e)
        CheckNum(e)
    End Sub

    Private Sub cmbpatientid_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbpatientid.SelectedIndexChanged
        sql = "select * from tbl_roomallotment where PId='" & cmbpatientid.Text & "' and status='Admit'"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        If rs.EOF = False Then
            txtroomtype.Text = rs(1).Value
            txtroomnum.Text = rs(2).Value
            txtbednum.Text = rs(3).Value

        End If
    End Sub

    Private Sub txtroomtype_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtroomtype.TextChanged
        If txtroomtype.Text = "General Ward" Then
            lblbednum.Visible = True
            txtbednum.Visible = True
        Else
            lblbednum.Visible = False
            txtbednum.Visible = False
        End If
    End Sub

    Private Sub cmbroomtype_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbroomtype.KeyDown
        CheckAlpha(e)
        CheckNum(e)
    End Sub

    Private Sub cmbtoroomtype_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbroomtype.SelectedIndexChanged
        
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
            cmbbedno.Text = ""
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
            cmbbedno.Text = ""
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

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub cmbroomno_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbroomno.KeyDown
        CheckAlpha(e)
        CheckNum(e)
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

    Private Sub btnshift_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnshift.Click
        'Change the status of the assigned room

        If cmbroomtype.Text = "General Ward" Then
            'sql = "select datediff(day,joindate,shiftdate) from tbl_roomallotment where PId='" & cmbpatientid.Text & "' and status='Admit' and bedno='" & txtbednum.Text & "'"
            'If rs.State = 1 Then rs.Close()
            'rs.Open(sql, conn)
            'If rs.EOF = False Then
            '    numofdays = rs(0).Value
            'End If


            sql = "update tbl_assignbednum set status='vacant' where bedno='" & txtbednum.Text & "'"
            conn.Execute(sql)
            sql = "update tbl_assignbednum set status='occupied' where bedno='" & cmbbedno.Text & "'"
            conn.Execute(sql)
        Else
            



            sql = "update tbl_roomtype set status='vacant' where roomno='" & txtroomnum.Text & "'"
            conn.Execute(sql)
            sql = "update tbl_roomtype set status='occupied' where roomno='" & cmbroomno.Text & "'"
            conn.Execute(sql)
        End If
        'Update the shift date of roomallotment table
        sql = "update tbl_roomallotment set shiftdate=convert(date,'" & Today.Date & "',103),status='Shifted' where PId='" & cmbpatientid.Text & "' and status='Admit'"
        conn.Execute(sql)
        'Insert the value to roomallotment table
        sql = "insert into tbl_roomallotment(PId,roomtype,roomnum,bedno,joindate,shiftdate,status)"
        sql = sql & "values('" & cmbpatientid.Text & "','" & cmbroomtype.Text & "','" & cmbroomno.Text & "','" & cmbbedno.Text & "',convert(date,'" & Today.Date & "',103),convert(date,'" & Today.Date & "',103),'Admit')"
        conn.Execute(sql)
        MsgBox("Room shited")

    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Me.Close()
        frmmaster.Show()
    End Sub




    Private Sub cmbbedno_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbbedno.KeyDown
        CheckAlpha(e)
        CheckNum(e)
    End Sub
End Class