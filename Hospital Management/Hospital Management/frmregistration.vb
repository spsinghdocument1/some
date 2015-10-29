Public Class frmregistration

    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
        If cmbid.Text = "" Then
            MsgBox("select userid first")
        ElseIf cmbuser.Text = "" Then
            MsgBox("select user first")
        Else

            If cmbuser.Text = "Doctor" Then
                sql = "update tbl_doctor set status='registered' where doctorid='" & cmbid.Text & "'"
                conn.Execute(sql)
                sql = "insert into tbl_register(usertype,userid,username,password)"
                sql = sql & "values('" & cmbuser.Text & "','" & cmbid.Text & "','" & txtuname.Text & "','" & txtpass.Text & "')"
                conn.Execute(sql)
                MsgBox("registered")
                cmbid.Text = ""
                cmbuser.Text = ""
                txtuname.Text = ""
                txtpass.Text = ""
                regdoctor()
            ElseIf cmbuser.Text = "Receptionist" Then

                sql = "update tbl_emp set status='registered' where emp_id='" & cmbid.Text & "'"
                conn.Execute(sql)
                sql = "insert into tbl_register(usertype,userid,username,password)"
                sql = sql & "values('" & cmbuser.Text & "','" & cmbid.Text & "','" & txtuname.Text & "','" & txtpass.Text & "')"
                conn.Execute(sql)
                MsgBox("registered")
                cmbid.Text = ""
                cmbuser.Text = ""
                txtuname.Text = ""
                txtpass.Text = ""
                regreceptionist()
            End If

            loadgrid()

        End If
    End Sub
    Sub regdoctor()
        sql = "select * from tbl_doctor where status='unregistered'"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        cmbid.Items.Clear()
        Do While rs.EOF = False
            cmbid.Items.Add(rs(0).Value)
            rs.MoveNext()
        Loop
    End Sub
    Sub regreceptionist()
        sql = "select * from tbl_emp where emp_desig='Receptionist' and status='unregistered'"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        cmbid.Items.Clear()
        Do While rs.EOF = False
            cmbid.Items.Add(rs(0).Value)
            rs.MoveNext()
        Loop
    End Sub

    Private Sub frmregistration_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Return
        opendb()
        loadgrid()
    End Sub
    Sub loadgrid()
        Dim i = 0
        sql = " select * from tbl_register"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        DataGridView1.Rows.Clear()
        Do While Not rs.EOF
            DataGridView1.Rows.Add()
            DataGridView1.Item(0, i).Value = rs(0).Value
            DataGridView1.Item(1, i).Value = rs(1).Value
            DataGridView1.Item(2, i).Value = rs(2).Value
            DataGridView1.Item(3, i).Value = rs(3).Value
           
            rs.MoveNext()
            i = i + 1
        Loop

    End Sub

    Private Sub cmbuser_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbuser.KeyDown
        CheckAlpha(e)
        CheckNum(e)
    End Sub
    Private Sub cmbuser_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbuser.SelectedIndexChanged
        
        If cmbuser.Text = "Doctor" Then
            regdoctor()

        ElseIf cmbuser.Text = "Receptionist" Then
            regreceptionist()
        End If
    End Sub

    Private Sub cmbid_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbid.KeyDown
        CheckAlpha(e)
        CheckNum(e)
    End Sub

    Private Sub cmbid_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbid.SelectedIndexChanged
        Dim pass
        Dim randomclass As New Random
        Dim randomnumber As Integer
        If cmbuser.Text = "Doctor" Then
            sql = "select * from tbl_doctor where doctorid='" & cmbid.Text & "'"
            If rs.State = 1 Then rs.Close()
            rs.Open(sql, conn)
            If rs.EOF = False Then
                pass = rs(1).Value
                txtuname.Text = pass
                randomnumber = randomclass.Next(2012)
                txtpass.Text = pass & randomnumber
            End If

        ElseIf cmbuser.Text = "Receptionist" Then
            sql = "select * from tbl_emp where emp_id='" & cmbid.Text & "'"
            If rs.State = 1 Then rs.Close()
            rs.Open(sql, conn)
            If rs.EOF = False Then
                pass = rs(1).Value
                txtuname.Text = pass
                randomnumber = randomclass.Next(2012)
                txtpass.Text = pass & randomnumber
            End If
        End If
        sql = "select * from tbl_emp where emp_id='" & cmbid.Text & "'"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        If rs.EOF = False Then
            pass = rs(1).Value
            txtuname.Text = pass
            randomnumber = randomclass.Next(2012)
            txtpass.Text = pass & randomnumber
        End If
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Me.Close()
        frmmaster.Show()
    End Sub

    Private Sub txtuname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtuname.TextChanged

    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class