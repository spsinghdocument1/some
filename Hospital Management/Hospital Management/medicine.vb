Public Class medicine

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexit.Click

    End Sub

    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
        sql = "select * from tbl_med where med='" & txtmed.Text & "'"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        If rs.EOF = False Then
            If MsgBox("Entered Medicine exist in the database,Do you want to update the qty and cost?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                sql = "update tbl_med set qty=qty+'" & txtqty.Text & "',cost='" & txtcost.Text & "' where med='" & txtmed.Text & "'"
                conn.Execute(sql)
                MsgBox("Updated")
                txtcost.Text = ""
                txtmed.Text = ""
                txtqty.Text = ""
            Else
                Exit Sub
            End If
        Else
            If txtmedid.Text = "" Or txtmed.Text = "" Or txtqty.Text = "" Or txtcost.Text = "" Then
                MsgBox("enter all fields")
            Else
                sql = "insert into tbl_med(med,qty,cost)"
                sql = sql & "values('" & txtmed.Text & "','" & txtqty.Text & "','" & txtcost.Text & "')"
                conn.Execute(sql)
                MsgBox("added")
            End If
        End If
    End Sub

    Private Sub medicine_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        opendb()
        Dim depid
        sql = " select max(medid) from tbl_med"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        If IsDBNull(rs(0).Value) = True Then
            depid = 1
            txtmedid.Text = depid
        Else
            depid = rs(0).Value
            txtmedid.Text = depid + 1
        End If
    End Sub
End Class