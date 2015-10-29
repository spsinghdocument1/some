Public Class frmoutpatientbill




    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        sql = "insert into tbl_OPbill(billno,date,PId,Pname,fees,status)"
        sql = sql & "values('" & txtbillno.Text & "',convert(date,'" & DateTimePicker1.Value & "',103),'" & cmbopid.Text & "','" & txtpatname.Text & "','" & txtfees.Text & "','Paid')"
        conn.Execute(sql)
        MsgBox("record added")
        clear()
        loadbillno()
    End Sub
    Sub clear()

        DateTimePicker1.Value = Today.Date
        cmbopid.Text = ""
        txtpatname.Text = ""
        txtfees.Text = ""
    End Sub

    Private Sub frmoutpatientbill_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Return
        opendb()
        loadbillno()

        sql = "select * from tbl_outpatien"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        Do While Not rs.EOF
            cmbopid.Items.Add(rs(0).Value)
            rs.MoveNext()
        Loop
    End Sub
    
    Sub loadbillno()
        Dim i
        sql = "select max(billno) from tbl_OPbill"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        If IsDBNull(rs(0).Value) = True Then
            txtbillno.Text = 1
        Else
            i = rs(0).Value
            txtbillno.Text = i + 1

        End If
    End Sub

    Private Sub cmbopid_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbopid.SelectedIndexChanged
        sql = "SELECT tbl_treat.PId,tbl_outpatien.Name FROM tbl_treat INNER JOIN tbl_outpatien ON tbl_treat.PId =tbl_outpatien.OutPatientid where Outpatientid='" & cmbopid.Text & "'"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        If rs.EOF = False Then
            txtpatname.Text = rs(1).Value
        End If
        sql = "select * from tbl_treat where PId='" & cmbopid.Text & "' and date=convert(date,'" & Today.Date & "',103)"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        If rs.EOF = False Then
            txtdoccharge.Text = rs(4).Value
            txtmedcharge.Text = rs(5).Value
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        clear()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
        frmmaster.Show()
    End Sub
    Private Sub txtmedcharge_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtmedcharge.TextChanged
        txtfees.Text = Val(txtmedcharge.Text) + Val(txtdoccharge.Text)
    End Sub

    Private Sub txtdoccharge_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdoccharge.TextChanged
        txtfees.Text = Val(txtmedcharge.Text) + Val(txtdoccharge.Text)
    End Sub
End Class