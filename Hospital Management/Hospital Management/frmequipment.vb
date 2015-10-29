Public Class frmequipment

    Private Sub frmequipment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Return
        opendb()
        btnupdate.Enabled = False
        btndelete.Enabled = False
        loadeqid()
        loadgrid()
        DateTimePicker1.MinDate = Today.Date
        DateTimePicker1.MaxDate = Today.Date
    End Sub
    Sub loadeqid()

        Dim i
        sql = "select max(eqId) from tbl_equip"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        If IsDBNull(rs(0).Value) = True Then
            txteqid.Text = 1
        Else
            i = rs(0).Value
            txteqid.Text = i + 1

        End If
    End Sub

    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
        If txteqname.Text = "" Or txtdes.Text = "" Or txtqty.Text = "" Then
            MsgBox("enter all the fields")
        ElseIf txtqty.Text <= 0 Then
            MsgBox("enter proper quantity ")
        Else
            sql = "insert into tbl_equip(eqId,eqname,description,quantity,date)"
            sql = sql & "values('" & txteqid.Text & "','" & txteqname.Text & "','" & txtdes.Text & "','" & txtqty.Text & "',convert(date,'" & DateTimePicker1.Value & "',103))"
            conn.Execute(sql)
            MsgBox("Equipment added!!!")
            loadgrid()
            clear()
            loadeqid()
        End If
    End Sub
    Sub clear()
        txtdes.Text = ""
        txteqid.Text = ""
        txteqname.Text = ""
        txtqty.Text = ""

    End Sub
    Sub loadgrid()
        Dim i = 0
        sql = " select * from tbl_equip"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        DataGridView1.Rows.Clear()
        Do While Not rs.EOF
            DataGridView1.Rows.Add()
            DataGridView1.Item(0, i).Value = rs(0).Value
            DataGridView1.Item(1, i).Value = rs(1).Value
            DataGridView1.Item(2, i).Value = rs(2).Value
            DataGridView1.Item(3, i).Value = rs(3).Value
            DataGridView1.Item(4, i).Value = rs(4).Value
            rs.MoveNext()
            i = i + 1
        Loop

    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        btnadd.Enabled = False
        btnupdate.Enabled = True
        btndelete.Enabled = True
        DateTimePicker1.Enabled = False
        txteqid.Text = DataGridView1.CurrentRow.Cells(0).Value
        txteqname.Text = DataGridView1.CurrentRow.Cells(1).Value
        txtdes.Text = DataGridView1.CurrentRow.Cells(2).Value
        txtqty.Text = DataGridView1.CurrentRow.Cells(3).Value
        DateTimePicker1.Value = DataGridView1.CurrentRow.Cells(4).Value
    End Sub

    Private Sub btnupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdate.Click
        If txteqname.Text = "" Or txtdes.Text = "" Or txtqty.Text = "" Then
            MsgBox("enter all the fields")
        ElseIf txtqty.Text <= 0 Then
            MsgBox("enter proper quantity ")
        Else
            sql = "update tbl_equip set eqname='" & txteqname.Text & "',description='" & txtdes.Text & "',quantity='" & txtqty.Text & "',date=convert(date,'" & DateTimePicker1.Value & "',103) where eqId='" & txteqid.Text & "'"
            conn.Execute(sql)
            MsgBox("record updated successfully")
            btnadd.Enabled = True
            btnupdate.Enabled = False
            btndelete.Enabled = False
            clear()
            loadgrid()
            loadeqid()
        End If
    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        sql = "delete from tbl_equip where eqid='" & txteqid.Text & "'"
        conn.Execute(sql)
        MsgBox("record deleted successfully")
        clear()
        loadgrid()
        loadeqid()

        btnadd.Enabled = True
        btnupdate.Enabled = False
        btndelete.Enabled = False
    End Sub

    Private Sub btnreset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreset.Click
        clear()
        loadeqid()
        btnadd.Enabled = True
        btnupdate.Enabled = False
        btndelete.Enabled = False
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Me.Close()
        frmmaster.Show()

    End Sub

    Private Sub txtdes_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtdes.KeyDown
        CheckAlpha(e)
    End Sub

    Private Sub txteqname_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txteqname.KeyDown
        CheckAlpha(e)
    End Sub

    Private Sub txtqty_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtqty.KeyDown
        CheckNum(e)
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class