Public Class frmviewpatient


   
    Private Sub frmviewpatient_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        opendb()
        lodgrid()
    End Sub
    Sub lodgrid()
        Dim i = 0
        sql = " select * from tbl_outpatien"
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
            DataGridView1.Item(5, i).Value = rs(5).Value
            DataGridView1.Item(6, i).Value = rs(6).Value
            DataGridView1.Item(7, i).Value = rs(7).Value
            DataGridView1.Item(8, i).Value = rs(8).Value
            DataGridView1.Item(9, i).Value = rs(9).Value
            rs.MoveNext()
            i = i + 1
        Loop
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Me.Close()
        frmmaster.Show()
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub
End Class