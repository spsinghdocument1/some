Public Class frmchange
    Sub clear()
        txtconfirm.Text = ""
        txtnewpas.Text = ""
        txtoldpas.Text = ""
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        txtconfirm.Text = ""
        txtnewpas.Text = ""
        txtoldpas.Text = ""
    End Sub

    Private Sub btnexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexit.Click
        Me.Close()
        frmmaster.Show()
    End Sub

    Private Sub frmchange_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        opendb()
    End Sub

    Private Sub btnok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnok.Click
        If txtoldpas.Text = "" Then
            MsgBox(" Enter old Password")
        ElseIf txtnewpas.Text = "" Then
            MsgBox(" Enter new Password")
        ElseIf txtconfirm.Text = "" Then
            MsgBox(" First confirm new Password")
        Else

            If usertype = "Admin" Then
                sql = "select * from tbl_login where log_username='" & userid & "' and log_pass='" & txtoldpas.Text & "'"
                If rs.State = 1 Then rs.Close()
                rs.Open(sql, conn)
                If rs.EOF = False Then
                    If txtnewpas.Text <> txtconfirm.Text Then
                        MsgBox("Password doesn't match")
                        clear()
                    Else
                        sql = "update tbl_login set log_pass='" & txtnewpas.Text & "' where log_username='" & userid & "'"
                        conn.Execute(sql)
                        MsgBox("password changed")
                        clear()
                    End If
                Else
                    MsgBox("Invalid password")
                    clear()
                End If
            Else
                sql = "select * from tbl_register where userid='" & userid & "' and password='" & txtoldpas.Text & "'"
                If rs.State = 1 Then rs.Close()
                rs.Open(sql, conn)
                If rs.EOF = False Then
                    If txtnewpas.Text <> txtconfirm.Text Then
                        MsgBox("Password doesn't match")
                        clear()
                    Else
                        sql = "update tbl_register set password='" & txtnewpas.Text & "' where userid='" & userid & "'"
                        conn.Execute(sql)
                        MsgBox("password changed")
                        clear()
                    End If
                Else
                    MsgBox("Invalid password")
                    clear()
                End If
            End If
        End If
    End Sub
End Class