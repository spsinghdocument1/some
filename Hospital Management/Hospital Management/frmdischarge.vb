Imports System.Data
Imports System.Data.SqlClient
Public Class frmdischarge
    Dim bilno
    Private Sub frmdischarge_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Return

        opendb()
        Label11.Visible = False
        txtdiscount.Visible = False
        sql = "select * from tbl_roomallotment where status='Admit'"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        cmbpatid.Items.Clear()
        Do While rs.EOF = False
            cmbpatid.Items.Add(rs(0).Value)
            rs.MoveNext()

        Loop
    End Sub
    Sub loadbillno()
        Dim i
        sql = "select max(biilno) from tbl_IPbill"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        If IsDBNull(rs(0).Value) = True Then
            txtbillno.Text = 1
        Else
            i = rs(0).Value
            txtbillno.Text = i + 1

        End If
    End Sub
    Dim numofdays As Integer
    Dim cost As Double
    Dim roomtype, roomno, bedno As String
    Sub displayroomcharge()
        'Displaying num of days
        Dim i = 0
        sql = "select datediff(day,joindate,shiftdate),PId,roomtype,roomnum,bedno,joindate,shiftdate from tbl_roomallotment where PId='" & cmbpatid.Text & "'"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        DataGridView1.Rows.Clear()
        Do While Not rs.EOF
            numofdays = rs(0).Value
            DataGridView1.Rows.Add()
            DataGridView1.Item(0, i).Value = rs(1).Value
            DataGridView1.Item(1, i).Value = rs(2).Value
            DataGridView1.Item(2, i).Value = rs(3).Value
            DataGridView1.Item(3, i).Value = rs(4).Value
            DataGridView1.Item(4, i).Value = rs(5).Value
            DataGridView1.Item(5, i).Value = rs(6).Value
            DataGridView1.Item(6, i).Value = rs(0).Value
            'displaying roomcharge
            sql = "select * from tbl_roomtype where Roomtype='" & roomtype & "' and Roomno='" & roomno & "'"
            If rss.State = 1 Then rss.Close()
            rss.Open(sql, conn)
            If rss.EOF = False Then
                cost = rss(2).Value
            End If
            If DataGridView1.Item(6, i).Value = 0 Then
                DataGridView1.Item(7, i).Value = cost
            Else
                DataGridView1.Item(7, i).Value = cost * DataGridView1.Item(6, i).Value
            End If

            txtroomcharge.Text = Val(txtroomcharge.Text) + DataGridView1.Item(7, i).Value
            rs.MoveNext()
            i = i + 1
        Loop
    End Sub
    Sub loaddoccharge()
        sql = "select * from tbl_treat where PId='" & cmbpatid.Text & "'"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        If rs.EOF = False Then
            txtdocCharge.Text = rs(4).Value
            txtmedcharge.Text = rs(5).Value
        End If
    End Sub
    Sub loadoperationcharge()
        sql = "select * from tbl_operation where PId='" & cmbpatid.Text & "'"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        If rs.EOF = False Then
            txtoperationcharge.Text = rs(6).Value
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        loadbillno()
        'Get the roomtype
        sql = "select * from tbl_roomallotment where PId='" & cmbpatid.Text & "' and status='Admit'"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        If rs.EOF = False Then
            roomtype = rs(1).Value
            roomno = rs(2).Value
            bedno = rs(3).Value
        End If

        'Update status as discharge
        'sql = "update tbl_roomallotment set shiftdate=convert(date,'" & Today.Date & "',103),status='Discharge' where PId='" & cmbpatid.Text & "' and status='Admit'"
        'conn.Execute(sql)
        'sql = "update tbl_Inpatients set status='Discharge' where InpatId='" & cmbpatid.Text & "'"
        'conn.Execute(sql)
        ''Updating room as vacant
        'If roomtype = "General Ward" Then
        '    sql = "update tbl_assignbednum set status='vacant' where bedno='" & bedno & "'"
        '    conn.Execute(sql)
        'Else
        '    sql = "update tbl_roomtype set status='vacant' where roomno='" & roomno & "'"
        '    conn.Execute(sql)
        'End If

        displayroomcharge()
        loaddoccharge()
        loadoperationcharge()
        sql = "select * from tbl_Inpatients where InpatId='" & cmbpatid.Text & "'"
        If rss.State = 1 Then rss.Close()
        rss.Open(sql, conn)
        If rss.EOF = False Then
            txtadvpay.Text = rss(13).Value
        End If
        txttotalcharge.Text = Val(txtroomcharge.Text) + Val(txtdocCharge.Text) + Val(txtmedcharge.Text) + Val(txttoalopcharge.Text)

        sql = "select * from tbl_roomallotment where status='Admit'"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        cmbpatid.Items.Clear()
        Do While rs.EOF = False
            cmbpatid.Items.Add(rs(0).Value)
            rs.MoveNext()

        Loop
    End Sub

    Private Sub txtadvpay_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtadvpay.TextChanged
        txttoalopcharge.Text = Val(txtoperationcharge.Text) - Val(txtadvpay.Text)

    End Sub
    Sub discountcalc()
        Dim amount As Double
        Dim disc As Double
        amount = Val(txttotalcharge.Text) * Val(txtdiscount.Text) / 100
        disc = Val(txttotalcharge.Text) - amount
        txtfinalamount.Text = disc
    End Sub

    Private Sub txtdiscount_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtdiscount.KeyDown
        CheckNum(e)
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdiscount.TextChanged
        discountcalc()
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            Label11.Visible = True
            txtdiscount.Visible = True
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            txtfinalamount.Text = Val(txttotalcharge.Text)
            Label11.Visible = False
            txtdiscount.Text = 0
            txtdiscount.Visible = False
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
        frmmaster.Show()

    End Sub
    Sub clear()
        cmbpatid.Text = ""
        txtdiscount.Text = ""
        txtdocCharge.Text = 0
        txtfinalamount.Text = ""
        txtmedcharge.Text = 0
        txtoperationcharge.Text = 0
        txtroomcharge.Text = 0
        txttoalopcharge.Text = 0
        txtadvpay.Text = 0
        txttotalcharge.Text = ""

    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        clear()
        sql = "select * from tbl_roomallotment where status='Admit'"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        cmbpatid.Items.Clear()
        Do While rs.EOF = False
            cmbpatid.Items.Add(rs(0).Value)
            rs.MoveNext()
        Loop
    End Sub
    Private Sub cmbpatid_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbpatid.KeyDown
        CheckAlpha(e)
        CheckNum(e)
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If cmbpatid.Text = "" Then
            MsgBox("Pls select the patient Id")
        ElseIf RadioButton1.Checked = False And RadioButton2.Checked = False Then
            MsgBox("select healthcard")
        Else
            bilno = txtbillno.Text
            sql = "insert into tbl_IPbill(biilno,pid,Name,doccharge,medcharge,optcharge,adv,bal,amount,discount,total,date)"
            sql = sql & "values('" & txtbillno.Text & "','" & cmbpatid.Text & "','" & txtpname.Text & "','" & txtdocCharge.Text & "','" & txtmedcharge.Text & "','" & txtoperationcharge.Text & "','" & txtadvpay.Text & "','" & txttoalopcharge.Text & "','" & txttotalcharge.Text & "','" & txtdiscount.Text & "','" & txtfinalamount.Text & "',convert(date,'" & Today.Date & "',103))"
            conn.Execute(sql)
            MsgBox("Bill saved")
        End If

    End Sub

    Private Sub cmbpatid_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbpatid.SelectedIndexChanged
        sql = "select * from tbl_Inpatients where Inpatid='" & cmbpatid.Text & "'"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        If rs.EOF = False Then
            txtpname.Text = rs(1).Value
        End If

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If con.State = ConnectionState.Open Then con.Close()
        con.Open()
        Dim cmd As New SqlCommand("select * from tbl_setting", con)
        Dim dr As SqlDataReader
        dr = cmd.ExecuteReader
        If dr.Read = True Then

            Server = dr.Item(0).ToString
            Database = dr.Item(1).ToString
            User = dr.Item(2).ToString
            Password = dr.Item(3).ToString
        End If
        con.Close()

        con.Open()
        Dim da As New SqlDataAdapter("select * from tbl_IPbill where Biilno=" & bilno & "", con)
        Dim ds As New DataSet
        da.Fill(ds)
        Dim rpt As New CrystalReport1
        rpt.DataSourceConnections.Item(0).SetConnection(Server, Database, User, Password)
        rpt.DataSourceConnections.Item(0).SetLogon(User, Password)
        rpt.SetParameterValue("bilno", bilno)
        frmprintbill.CrystalReportViewer1.ReportSource = rpt
        frmprintbill.CrystalReportViewer1.Refresh()
        'Dim int As New salesReport1
        'int.SetDataSource(ds)
        'Salesreprt.ReportSource = int
        ' int.Refresh()

        frmprintbill.Show()
    End Sub
End Class