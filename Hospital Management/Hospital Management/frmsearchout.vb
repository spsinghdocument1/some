Public Class frmsearchout
    Private Sub frmsearchout_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        opendb()
    End Sub

    Public searchvalue
    Sub searchInpatient()
        Dim EntText
        EntText = TextBox1.Text & "%"
        sql = "select * from tbl_outpatien where " & searchvalue & " like   '" & EntText & "'"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        DataGridView1.Rows.Clear()
        Dim i
        i = 0
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
        If DataGridView1.RowCount = 1 Then
            MsgBox("no such record")

        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "PatientId" Then
            searchvalue = "OutPatientid"
            DataGridView1.Rows.Clear()
            TextBox1.Text = ""
        ElseIf ComboBox1.Text = "PatientName" Then
            searchvalue = "Name"
            DataGridView1.Rows.Clear()
            TextBox1.Text = ""

        End If
    End Sub

    Private Sub btnsearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        searchInpatient()
        If TextBox1.Text = "" Then
            DataGridView1.Rows.Clear()

        End If
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Me.Close()
        frmmaster.Show()
    End Sub
End Class