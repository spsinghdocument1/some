Public Class frmmsg

    Private Sub btnok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnok.Click
        If usertype = "Doctor" Then
            sql = "update tbl_msg set status='read' where id='" & lblid.Text & "'"
            conn.Execute(sql)
        ElseIf usertype = "Admin" Then
            sql = "update tbl_msg set status='read' where id='" & lblid.Text & "'"
            '  conn.Execute(sql)
        Else
            sql = "update tbl_msg set status='read' where id='" & lblid.Text & "'"
            '  conn.Execute(sql)
        End If
       
        frmmaster.SendMessageToolStripMenuItem.BackColor = Color.Transparent
        Me.Close()
       
    End Sub

    Private Sub frmmsg_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        opendb()
        If usertype = "Doctor" Then

            sql = "select * from tbl_msg where status='unread' and tomsg='" & userid & "'"
            If rs.State = 1 Then rs.Close()
            rs.Open(sql, conn)
            If rs.EOF = False Then
                Panel1.Visible = True
                lblid.Text = rs(0).Value
                Label2.Text = rs(3).Value
                Me.txtmsg.Text = rs(1).Value
            Else
                Panel1.Visible = False
                MsgBox("There is no msg")
                Me.Close()
            End If
        ElseIf usertype = "Admin" Then
            sql = "select * from tbl_msg where status='unread' and tomsg='Admin'"
            If rs.State = 1 Then rs.Close()
            rs.Open(sql, conn)
            If rs.EOF = False Then
                Panel1.Visible = True
                lblid.Text = rs(0).Value
                '   Label2.Text = rs(3).Value
                Me.txtmsg.Text = rs(1).Value
            Else
                Panel1.Visible = False
                MsgBox("There is no msg")
                Me.Close()
            End If
        ElseIf usertype = "Receptionist" Then
            sql = "select * from tbl_msg where status='unread' and tomsg='Receptionist'"
            If rs.State = 1 Then rs.Close()
            rs.Open(sql, conn)
            If rs.EOF = False Then
                Panel1.Visible = True
                lblid.Text = rs(0).Value
                Label2.Text = rs(3).Value
                Me.txtmsg.Text = rs(1).Value
            Else
                Panel1.Visible = False
                MsgBox("There is no msg")
                Me.Close()
            End If
            
        End If
        
    End Sub

End Class