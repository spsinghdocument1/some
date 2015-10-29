Public Class frmsearchdoctor

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If RadioButton1.Checked = False And RadioButton2.Checked = False Then
            MsgBox("select the radiobutton")
        End If
        If RadioButton1.Checked = True Then
            If ComboBox1.Text = "Id" Then
                searchvalue = "doctorid"
                TextBox1.Text = ""
                DataGridView1.Rows.Clear()
            ElseIf ComboBox1.Text = "Name" Then
                searchvalue = "doctorname"
                TextBox1.Text = ""
                DataGridView1.Rows.Clear()
                DataGridView2.Rows.Clear()
            End If
        ElseIf RadioButton2.Checked = True Then
            If ComboBox1.Text = "Id" Then
                searchvalue = "Nurseid"
                TextBox1.Text = ""
                DataGridView2.Rows.Clear()
            ElseIf ComboBox1.Text = "Name" Then
                searchvalue = "Nursename"
                TextBox1.Text = ""
                DataGridView2.Rows.Clear()
                DataGridView1.Rows.Clear()
            End If
        End If

    End Sub
    Public searchvalue

    Private Sub frmsearchdoctor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        opendb()
        DataGridView1.Visible = False
        DataGridView2.Visible = False
    End Sub
    Sub searchDoctor()
        Dim EntText
        EntText = TextBox1.Text & "%"
        sql = "select * from tbl_doctor where " & searchvalue & " like   '" & EntText & "'"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        DataGridView1.Rows.Clear()
        Dim i
        i = 0
        Do While Not rs.EOF
            DataGridView1.Rows.Add()
            DataGridView1.Item(0, i).Value = rs(2).Value
            DataGridView1.Item(1, i).Value = rs(0).Value
            DataGridView1.Item(2, i).Value = rs(1).Value
            DataGridView1.Item(3, i).Value = rs(3).Value
            DataGridView1.Item(4, i).Value = rs(5).Value
            DataGridView1.Item(5, i).Value = rs(4).Value
            DataGridView1.Item(6, i).Value = rs(7).Value

            rs.MoveNext()
            i = i + 1
        Loop
        If DataGridView1.RowCount = 1 Then
            MsgBox("no such record")
        End If
    End Sub
    Sub searchNurse()
        Dim EntText
        EntText = TextBox1.Text & "%"
        sql = "select * from tbl_nurse where " & searchvalue & " like '" & EntText & "'"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        DataGridView2.Rows.Clear()
        Dim i
        i = 0
        Do While Not rs.EOF
            DataGridView2.Rows.Add()
            DataGridView2.Item(0, i).Value = rs(0).Value
            DataGridView2.Item(1, i).Value = rs(1).Value
            DataGridView2.Item(2, i).Value = rs(2).Value
            DataGridView2.Item(3, i).Value = rs(3).Value
            DataGridView2.Item(4, i).Value = rs(5).Value
            DataGridView2.Item(5, i).Value = rs(4).Value
            DataGridView2.Item(6, i).Value = rs(6).Value
            rs.MoveNext()
            i = i + 1
        Loop
        If DataGridView2.RowCount = 1 Then
            MsgBox("no such record")
        End If
    End Sub
    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        If RadioButton1.Checked = True Then

            DataGridView1.Visible = True
            DataGridView2.Visible = False
            searchDoctor()
        Else
            DataGridView1.Visible = False
            DataGridView2.Visible = True
            searchNurse()
        End If
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Me.Close()
        frmmaster.Show()
    End Sub

    
End Class