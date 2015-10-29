Public Class frmtreatment

    Private Sub frmtreatment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Return
        opendb()
        Panel1.Visible = False

        loadmedicine()
    End Sub
    Sub loadmedicine()
        sql = "select * from tbl_med"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        Do While Not rs.EOF
            cmbmedicine.Items.Add(rs(1).Value)
            rs.MoveNext()
        Loop
    End Sub

    Sub loadtreatment()
        Dim i = 0
        sql = " select * from tbl_treat where PId='" & cmbpatid.Text & "'"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        DataGridView1.Rows.Clear()
        Do While Not rs.EOF
            DataGridView1.Rows.Add()
            DataGridView1.Item(0, i).Value = rs(1).Value
            DataGridView1.Item(1, i).Value = rs(3).Value
            DataGridView1.Item(2, i).Value = rs(4).Value
            DataGridView1.Item(3, i).Value = rs(5).Value
            DataGridView1.Item(4, i).Value = rs(6).Value
            rs.MoveNext()
            i = i + 1
        Loop

    End Sub

    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
        sql = "insert into tbl_treat(docId,PId,Treatment,DocCharge,MedicineCharge,date)"
        sql = sql & "values('" & userid & "','" & cmbpatid.Text & "','" & txttreatment.Text & "','" & txtdoccharge.Text & "','" & txtmedcharge.Text & "',convert(date,'" & DateTimePicker1.Value & "',103))"
        conn.Execute(sql)

        For i = 0 To DataGridViewmedicine.Rows.Count - 1

            'update medicine qty
            sql = "update tbl_med set qty=qty-'" & DataGridViewmedicine.Item(1, i).Value & "' where med='" & DataGridViewmedicine.Item(0, i).Value & "'"
            conn.Execute(sql)

        Next
        MsgBox("added")
        loadtreatment()
    End Sub

    Private Sub cmbpatid_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbpatid.SelectedIndexChanged
        If cmbpatid.Text <> "" Then
            Panel1.Visible = True
        End If
        loadtreatment()
    End Sub

    Private Sub txtdoccharge_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtdoccharge.KeyDown
        CheckNum(e)
    End Sub

    Private Sub txtmedcharge_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtmedcharge.KeyDown
        CheckNum(e)
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Me.Close()
        frmmaster.Show()
    End Sub

    Private Sub cmbmedicine_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbmedicine.SelectedIndexChanged
        sql = "select * from tbl_med where med='" & cmbmedicine.Text & "'"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)

        If rs.EOF = False Then

            txtavqty.Text = rs(2).Value

        End If
        


    End Sub
    Dim i = 0
    Private Sub btnmedadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmedadd.Click
        If Val(txtqty.Text) > Val(txtavqty.Text) Then
            MsgBox("available qty is less")
        Else
            For i = 0 To DataGridViewmedicine.Rows.Count - 1
                If cmbmedicine.Text = DataGridViewmedicine.Item(0, i).Value Then
                    MsgBox("medicine exist in gridview")
                    Exit Sub

                End If
            Next
            DataGridViewmedicine.Rows.Add()
            DataGridViewmedicine.Item(0, i).Value = cmbmedicine.Text
            DataGridViewmedicine.Item(1, i).Value = txtqty.Text
            sql = "select * from tbl_med where med='" & DataGridViewmedicine.Item(0, i).Value & "'"
            If rss.State = 1 Then rss.Close()
            rss.Open(sql, conn)
            If rss.EOF = False Then
                DataGridViewmedicine.Item(2, i).Value = rss(3).Value
            End If
           
            DataGridViewmedicine.Item(3, i).Value = DataGridViewmedicine.Item(1, i).Value * DataGridViewmedicine.Item(2, i).Value
            txtmedcharge.Text = txtmedcharge.Text + DataGridViewmedicine.Item(3, i).Value
            i = i + 1

            cmbmedicine.Text = ""
            txtqty.Text = ""
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "InPatient" Then
            sql = "select * from tbl_Inpatients where doctorId='" & userid & "' and status='admit'"
            If rs.State = 1 Then rs.Close()
            rs.Open(sql, conn)
            cmbpatid.Items.Clear()
            Do While Not rs.EOF
                cmbpatid.Items.Add(rs(0).Value)
                rs.MoveNext()
            Loop
        ElseIf ComboBox1.Text = "OutPatient" Then
            sql = "select * from tbl_outpatien where doctorId='" & userid & "'"
            If rs.State = 1 Then rs.Close()
            rs.Open(sql, conn)
            cmbpatid.Items.Clear()
            Do While Not rs.EOF
                cmbpatid.Items.Add(rs(0).Value)
                rs.MoveNext()
            Loop
        End If
    End Sub
End Class