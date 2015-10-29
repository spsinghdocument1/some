Public Class frmmovepatients

    Private Sub frmmovepatients_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Return
        opendb()
        sql = "select * from tbl_outpatien"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        Do While Not rs.EOF
            cmbopid.Items.Add(rs(0).Value)
            rs.MoveNext()
        Loop
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        outpatid = cmbopid.Text
        frminpatient.Show()
    End Sub

  
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
        frmmaster.Show()

    End Sub

    Private Sub cmbopid_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbopid.KeyDown
        CheckAlpha(e)
        CheckNum(e)

    End Sub
End Class