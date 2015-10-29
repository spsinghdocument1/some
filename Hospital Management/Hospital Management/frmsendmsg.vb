Public Class frmsendmsg

    Private Sub btnok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnok.Click
        If ComboBox1.Text = "Doctor" Then
            If ComboBox1.Text = "" Then
                MsgBox("Pls select the Receipient")
            ElseIf txtmsg.Text = "" Then
                MsgBox("Pls enter the text to send")

            ElseIf cmbdoctor.Text = "" Then
                MsgBox("Select the doctor")
            Else
                sql = "insert into tbl_msg(msg,status,msgby,tomsg)"
                sql = sql & "values('" & txtmsg.Text & "','unread','Admin','" & cmbdoctor.Text & "')"
                conn.Execute(sql)
            End If
        ElseIf ComboBox1.Text = "Receptionist" Then
            If ComboBox1.Text = "" Then
                MsgBox("Pls select the Receipient")
            ElseIf txtmsg.Text = "" Then
                MsgBox("Pls enter the text to send")
            Else
                sql = "insert into tbl_msg(msg,status,msgby,tomsg)"
                sql = sql & "values('" & txtmsg.Text & "','unread','" & userid & "','" & ComboBox1.Text & "')"
                conn.Execute(sql)
            End If
        ElseIf ComboBox1.Text = "Admin" Then
            If ComboBox1.Text = "" Then
                MsgBox("Pls select the Receipient")
            ElseIf txtmsg.Text = "" Then
                MsgBox("Pls enter the text to send")
            Else
                sql = "insert into tbl_msg(msg,status,msgby,tomsg)"
                sql = sql & "values('" & txtmsg.Text & "','unread','" & userid & "','" & ComboBox1.Text & "')"
                conn.Execute(sql)
            End If
            End If
        MsgBox("msg sent")
        clear()

    End Sub

    Private Sub frmsendmsg_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        opendb()
        cmbdoctor.Visible = False
        If usertype = "Admin" Then
            ComboBox1.Items.Clear()
            ComboBox1.Items.Add("Doctor")
            ComboBox1.Items.Add("Receptionist")
        ElseIf usertype = "Doctor" Then
            ComboBox1.Items.Clear()
            ComboBox1.Items.Add("Admin")
            ComboBox1.Items.Add("Receptionist")
            
        ElseIf usertype = "Receptionist" Then
            ComboBox1.Items.Clear()
            ComboBox1.Items.Add("Admin")
            ComboBox1.Items.Add("Doctor")

            
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "Doctor" Then
            cmbdoctor.Visible = True
            sql = "select * from tbl_doctor where status='registered'"
            If rs.State = 1 Then rs.Close()
            rs.Open(sql, conn)
            cmbdoctor.Items.Clear()
            Do While rs.EOF = False
                cmbdoctor.Items.Add(rs(0).Value)
                rs.MoveNext()
            Loop
        Else
            cmbdoctor.Visible = False
        End If
    End Sub
    Sub clear()
        cmbdoctor.Text = ""
        ComboBox1.Text = ""
        txtmsg.Text = ""

    End Sub
End Class