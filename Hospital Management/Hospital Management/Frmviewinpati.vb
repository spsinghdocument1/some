Public Class Frmviewinpati
    

    Private Sub Frmviewinpati_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Return
        opendb()
        loadInPatient()

    End Sub
    Sub loadInPatient()
        Return
        Dim i = 0
        sql = " select * from tbl_inpatients"
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

            sql = "select * from tbl_roomallotment where PId='" & DataGridView1.Item(0, i).Value & "' and status='Admit'"
            If rss.State = 1 Then rss.Close()
            rss.Open(sql, conn)
            If rss.EOF = False Then
                DataGridView1.Item(10, i).Value = rss(1).Value
                DataGridView1.Item(11, i).Value = rss(2).Value
                DataGridView1.Item(12, i).Value = rss(3).Value


            End If
            DataGridView1.Item(13, i).Value = rs(11).Value

            rs.MoveNext()
            i = i + 1
        Loop

    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Me.Close()
        frmmaster.Show()

    End Sub
End Class