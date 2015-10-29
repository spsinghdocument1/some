Public Class frmoperation

    Private Sub frmoperation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Return

        opendb()
        loaddocid()
        loadnurseid()
        sql = "select * from tbl_Inpatients where doctorId='" & userid & "'"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        Do While Not rs.EOF
            cmbpatid.Items.Add(rs(0).Value)
            rs.MoveNext()
        Loop
    End Sub
    Public docid, nurseid
    Public Sub save_docid()
        Dim items As New ArrayList
        Dim x As Integer
        items.AddRange(Me.ListBox1.Items)
        For x = 0 To items.Count - 1
            If x = 0 Then
                docid = items.Item(x).ToString
            Else
                docid = docid & "," & items.Item(x).ToString
            End If
        Next
    End Sub
    Public Sub save_Nurseid()
        Dim item As New ArrayList
        Dim y As Integer
        item.AddRange(Me.ListBox2.Items)
        For y = 0 To item.Count - 1
            If y = 0 Then
                nurseid = item.Item(y).ToString
            Else
                nurseid = nurseid & "," & item.Item(y).ToString
            End If
        Next
    End Sub
    Sub loaddocid()
        sql = "select * from tbl_doctor"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        cmbdoctor.Items.Clear()
        Do While rs.EOF = False
            cmbdoctor.Items.Add(rs(0).Value)
            rs.MoveNext()
        Loop
    End Sub
    Sub loadnurseid()
        sql = "select * from tbl_nurse"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        cmbnurse.Items.Clear()
        Do While rs.EOF = False
            cmbnurse.Items.Add(rs(0).Value)
            rs.MoveNext()
        Loop
    End Sub
    Dim i As Integer = 0
    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
        If ListBox1.Items.Count >= 1 Then
            For i = 0 To ListBox1.Items.Count - 1
                If ListBox1.Items(i) = cmbdoctor.Text Then
                    MsgBox("Doctor Id exist")
                    Exit Sub
                End If
            Next
            ListBox1.Items.Add(cmbdoctor.Text)
        Else
            ListBox1.Items.Add(cmbdoctor.Text)
        End If
    End Sub

    Private Sub btnremove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnremove.Click
        Try
            ListBox1.Items.Remove(ListBox1.SelectedItem.ToString)
        Catch ex As Exception
            MsgBox("select the record to remove")
        End Try

    End Sub

    Private Sub btnnurseadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnurseadd.Click
        If ListBox2.Items.Count >= 1 Then
            For i = 0 To ListBox2.Items.Count - 1
                If ListBox2.Items(i) = cmbnurse.Text Then
                    MsgBox("Nurse Id exist")
                    Exit Sub
                End If
            Next
            ListBox2.Items.Add(cmbnurse.Text)
        Else
            ListBox2.Items.Add(cmbnurse.Text)
        End If
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        save_docid()
        save_Nurseid()
        sql = "insert into tbl_operation(PId,Date,operationtype,Doctor,Nurse,Cost,Advpayment,addedby)"
        sql = sql & "values('" & cmbpatid.Text & "',convert(date,'" & DateTimePicker1.Value & "',103),'" & cmboptype.Text & "','" & docid & "','" & nurseid & "','" & txtcost.Text & "','0','" & userid & "')"
        conn.Execute(sql)
        MsgBox("added")
    End Sub

    Private Sub brnnurseremove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles brnnurseremove.Click
        Try
            ListBox2.Items.Remove(ListBox2.SelectedItem.ToString)
        Catch ex As Exception
            MsgBox("select the record to remove")
        End Try

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
        frmmaster.Show()

    End Sub

    Private Sub cmbdoctor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbdoctor.SelectedIndexChanged

    End Sub
End Class