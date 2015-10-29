Public Class frmogin

    Private Sub btnok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnok.Click
        If Cmbusertype.Text = "Admin" Then
            sql = "select * from tbl_login where logintype='" & Cmbusertype.Text & "' and  loginname='" & Txtusername.Text & "' and loginpass='" & Txtpassword.Text & "'"
            If rs.State = 1 Then rs.Close()
            rs.Open(sql, conn)
            If rs.EOF = False Then
                usertype = Cmbusertype.Text
                userid = Txtusername.Text
                Cmbusertype.Text = ""
                Txtpassword.Text = ""
                Txtusername.Text = ""

                Me.Hide()
                frmmaster.Show()
            Else
                MsgBox("login failed")
                Cmbusertype.Text = ""
                Txtpassword.Text = ""
                Txtusername.Text = ""

            End If
        Else
            sql = "select * from tbl_register where usertype='" & Cmbusertype.Text & "' and  username='" & Txtusername.Text & "' and password='" & Txtpassword.Text & "'"
            If rs.State = 1 Then rs.Close()
            rs.Open(sql, conn)
            If rs.EOF = False Then
                'frmmsg.Show()
                'frmmsg.Hide()
                usertype = Cmbusertype.Text
                userid = rs(1).Value
                Cmbusertype.Text = ""
                Txtpassword.Text = ""
                Txtusername.Text = ""
                Me.Hide()
                frmmaster.Show()
            Else
                MsgBox("login failed")
                Cmbusertype.Text = ""
                Txtpassword.Text = ""
                Txtusername.Text = ""

            End If
        End If

    End Sub

    Private Sub frmogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        opendb()
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Cmbusertype.Text = ""
        Txtpassword.Text = ""
        Txtusername.Text = ""
    End Sub

    
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        End
    End Sub

    Private Sub Cmbusertype_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Cmbusertype.KeyDown
        CheckAlpha(e)
        CheckNum(e)

    End Sub

   
End Class
