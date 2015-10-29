Public Class frmroom

    

    Private Sub frmroom_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Return
        opendb()

        loadcombogeneralward()
        loadgrid1()
        loadgrid2()
    End Sub

    Sub loadroomno()
        'Dim num As String
        'sql = " select max(roomno) from tbl_roomtype where Roomtype <>'General Ward'"
        'If rs.State = 1 Then rs.Close()
        'rs.Open(sql, conn)
        'If IsDBNull(rs(0).Value) = True Then
        '    num = 1
        '    txtroomno.Text = num
        'Else
        '    num = rs(0).Value
        '    txtroomno.Text = num + 1
        'End If
        Dim data1, var1 As String
        data1 = "num"
        var1 = (data1.Substring(0, 3))
        Dim icuid
        sql = "select MAX(cast(SUBSTRING(Roomno,4,len(Roomno))+1 as int ))from tbl_roomtype where Roomno like '" & var1 & "%'"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        If IsDBNull(rs(0).Value) = True Then
            txtroomno.Text = var1 & 1
        Else
            If rs.EOF = False Then
                icuid = rs(0).Value
                icuid = var1 & icuid
                txtroomno.Text = icuid
            End If
        End If
    End Sub
    Sub loadcombogeneralward()
        sql = "select * from tbl_roomtype where Roomtype='General Ward'"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        cmbednnum.Items.Clear()
        Do While rs.EOF = False
            cmbednnum.Items.Add(rs(1).Value)
            rs.MoveNext()

        Loop
    End Sub
    Sub loadgrid1()
        Dim i = 0
        sql = " select * from tbl_roomtype"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        DataGridView1.Rows.Clear()
        Do While Not rs.EOF
            DataGridView1.Rows.Add()
            DataGridView1.Item(0, i).Value = rs(0).Value
            DataGridView1.Item(1, i).Value = rs(1).Value
            DataGridView1.Item(2, i).Value = rs(2).Value
            rs.MoveNext()
            i = i + 1
        Loop

    End Sub
    Sub loadgrid2()
        Dim i = 0
        sql = " select * from tbl_assignbednum"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        DataGridView2.Rows.Clear()
        Do While Not rs.EOF
            DataGridView2.Rows.Add()
            DataGridView2.Item(0, i).Value = rs(1).Value
            DataGridView2.Item(1, i).Value = rs(2).Value

            rs.MoveNext()
            i = i + 1
        Loop

    End Sub

    Private Sub Cmbroom_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmbroom.SelectedIndexChanged
        If Cmbroom.Text = "General Ward" Then
            Dim strData, var As String
            strData = "Ward"
            var = (strData.Substring(0, 4))
            Dim id
            sql = "select MAX(cast(SUBSTRING(Roomno,5,len(Roomno))+1 as int ))from tbl_roomtype where Roomno like '" & var & "%'"
            If rs.State = 1 Then rs.Close()
            rs.Open(sql, conn)
            If IsDBNull(rs(0).Value) = True Then
                txtroomno.Text = var & 101
            Else
                If rs.EOF = False Then
                    id = rs(0).Value
                    id = var & id
                    txtroomno.Text = id
                End If
            End If
        ElseIf Cmbroom.Text = "ICU" Then
            Dim data1, var1 As String
            data1 = "ICU"
            var1 = (data1.Substring(0, 3))
            Dim icuid
            sql = "select MAX(cast(SUBSTRING(Roomno,4,len(Roomno))+1 as int ))from tbl_roomtype where Roomno like '" & var1 & "%'"
            If rs.State = 1 Then rs.Close()
            rs.Open(sql, conn)
            If IsDBNull(rs(0).Value) = True Then
                txtroomno.Text = var1 & 1
            Else
                If rs.EOF = False Then
                    icuid = rs(0).Value
                    icuid = var1 & icuid
                    txtroomno.Text = icuid
                End If
            End If
        ElseIf Cmbroom.Text = "Operation Theatre" Then
            Dim data2, var2 As String
            data2 = "OPT"
            var2 = (data2.Substring(0, 3))
            Dim icuid
            sql = "select MAX(cast(SUBSTRING(Roomno,4,len(Roomno))+1 as int ))from tbl_roomtype where Roomno like '" & var2 & "%'"
            If rs.State = 1 Then rs.Close()
            rs.Open(sql, conn)
            If IsDBNull(rs(0).Value) = True Then
                txtroomno.Text = var2 & 1
            Else
                If rs.EOF = False Then
                    icuid = rs(0).Value
                    icuid = var2 & icuid
                    txtroomno.Text = icuid
                End If
            End If
        Else
            Cmbroom.Text = ""
            loadroomno()
            End If
    End Sub

    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
        sql = "insert into tbl_roomtype(Roomtype,Roomno,cost,status)"
        sql = sql & "values('" & Cmbroom.Text & "','" & txtroomno.Text & "','" & txtcost.Text & "','vacant')"
        conn.Execute(sql)
        MsgBox("Room Added !!!")
        loadcombogeneralward()
        loadgrid1()
        clearroom()
    End Sub

    Private Sub btnadd1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd1.Click
        sql = "insert into tbl_assignbednum(Roomtype,Roomno,bedno,status)"
        sql = sql & "values('General Ward','" & cmbednnum.Text & "','" & txtbedno.Text & "','vacant')"
        conn.Execute(sql)
        MsgBox(" bedadded")
        loadgrid2()
        clearward()
    End Sub

    Private Sub cmbednnum_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbednnum.SelectedIndexChanged
        
        Dim strData, var As String
        strData = cmbednnum.Text
        ''Display the first three characters
        var = (strData.Substring(0, 7))
        'Txtempid.Text = var
        Dim id
        sql = "select MAX(cast(SUBSTRING(bedno,9,len(bedno))+1 as int ))from tbl_assignbednum where bedno like '" & var & "%'"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        If IsDBNull(rs(0).Value) = True Then
            txtbedno.Text = var & "-" & 1
        Else
            If rs.EOF = False Then
                id = rs(0).Value
                id = var & "-" & id
                txtbedno.Text = id
            End If
        End If
    End Sub
    Sub clearroom()
        Cmbroom.Text = ""
        txtroomno.Text = ""
        txtcost.Text = ""
    End Sub
    Sub clearward()
        cmbednnum.Text = ""
        txtbedno.Text = ""
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Me.Close()
        frmmaster.Show()

    End Sub

    Private Sub txtcost_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtcost.KeyDown
        CheckNum(e)
    End Sub

   
    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        If Cmbroom.Text = "General Ward" Then
            sql = "select * from tbl_assignbednum where Roomno='" & txtroomno.Text & "' and status='occupied'"
            If rs.State = 1 Then rs.Close()
            rs.Open(sql, conn)
            If rs.EOF = False Then
                MsgBox("Patient is admitted in this roomnum,pls shift the patient first")
            Else
                sql = "delete from tbl_assignbednum where Roomno='" & txtroomno.Text & "'"
                conn.Execute(sql)
                MsgBox("department deleted successfully")
            End If
        Else
            sql = "select * from tbl_roomtype where Roomno='" & txtroomno.Text & "' and status='occupied'"
            If rs.State = 1 Then rs.Close()
            rs.Open(sql, conn)
            If rs.EOF = False Then
                MsgBox("Patient is admitted in this roomnum,pls shift the patient first")
            Else

                sql = "delete from tbl_roomtype where Roomno='" & txtroomno.Text & "'"
                conn.Execute(sql)
                MsgBox("department deleted successfully")
            End If
        End If
       
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Cmbroom.Text = DataGridView1.CurrentRow.Cells(0).Value
        txtroomno.Text = DataGridView1.CurrentRow.Cells(1).Value
        txtcost.Text = DataGridView1.CurrentRow.Cells(2).Value
    End Sub
End Class