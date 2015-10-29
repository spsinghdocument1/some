Public Class frmmaster

    Private Sub AddDoctorsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddDoctorsToolStripMenuItem.Click
        frmdoctor.Show()
    End Sub

    

    Private Sub AToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AToolStripMenuItem.Click
        Frmnurse.Show()
    End Sub

    Private Sub AddOtherWorkersToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddOtherWorkersToolStripMenuItem.Click
        frmemployee.Show()
    End Sub

    Private Sub RegisterUserToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegisterUserToolStripMenuItem.Click
        frmregistration.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
        frmogin.Show()

    End Sub

    Private Sub frmmaster_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        opendb()
        'ListBox1.Visible = False
    End Sub

    
    Private Sub PatientTreatmentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PatientTreatmentToolStripMenuItem.Click
        frmtreatment.Show()
    End Sub

    Private Sub PrescriptionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrescriptionToolStripMenuItem.Click
        frmprescription.Show()
    End Sub

    Private Sub OperationAllotmentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OperationAllotmentToolStripMenuItem.Click
        frmoperation.Show()
    End Sub

   
    Private Sub EditOrDeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditOrDeleteToolStripMenuItem.Click
        frminpatient.Show()
        frminpatient.Txtinpatid.Visible = False
        frminpatient.cmbInpatientId.Visible = True
        frminpatient.GroupBox1.Visible = False
        frminpatient.ADD.Visible = False
        Return
        frminpatient.inpatid()
    End Sub

    Private Sub AddToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddToolStripMenuItem.Click
        frminpatient.Show()
        frminpatient.btndelete.Visible = False
        frminpatient.btnupdate.Visible = False
    End Sub

    Private Sub ViewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewToolStripMenuItem.Click
        Frmviewinpati.Show()
    End Sub

    Private Sub ShiftRoomToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShiftRoomToolStripMenuItem.Click
        frmshiftroom.Show()
    End Sub

    Private Sub MovePatientToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MovePatientToolStripMenuItem.Click
        frmmovepatients.Show()
    End Sub

    Private Sub AddToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddToolStripMenuItem1.Click
        frmoutpatient.Show()
        frmoutpatient.cmboutpatientid.Visible = False
        frmoutpatient.btndelete.Visible = False
        frmoutpatient.btnupdate.Visible = False
    End Sub

    Private Sub EditOrDeleteToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditOrDeleteToolStripMenuItem1.Click
        frmoutpatient.Show()
        frmoutpatient.Txtoutpatid.Visible = False
        frmoutpatient.cmboutpatientid.Visible = True
        frmoutpatient.ADD.Visible = False
        Return
        frmoutpatient.outpatid()
    End Sub

    Private Sub EquipmentDetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EquipmentDetailsToolStripMenuItem.Click
        frmequipment.Show()
    End Sub

    Private Sub AddNewRoomToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddNewRoomToolStripMenuItem.Click
        frmroom.Show()
    End Sub

    Private Sub DischargePatientToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DischargePatientToolStripMenuItem.Click
        frmdischarge.Show()
    End Sub

    Private Sub OutPatientBillToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OutPatientBillToolStripMenuItem.Click
        frmoutpatientbill.Show()
    End Sub

    Private Sub AddNewDepartmentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddNewDepartmentToolStripMenuItem.Click
        frmdept.Show()
    End Sub

    

    Private Sub InPatientToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InPatientToolStripMenuItem1.Click
        frmsearchinpatient.Show()
    End Sub

    Private Sub OutPatientToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OutPatientToolStripMenuItem1.Click
        frmsearchout.Show()
    End Sub

    Private Sub DoctorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DoctorToolStripMenuItem.Click
        frmsearchdoctor.Show()
    End Sub

    Private Sub NurseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NurseToolStripMenuItem.Click
        frmsearchdoctor.Show()

    End Sub

    Private Sub ViewToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmviewpatient.Show()
    End Sub

    Private Sub ViewToolStripMenuItem1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewToolStripMenuItem1.Click
        frmviewout.Show()
    End Sub

    Private Sub SendMessgeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SendMessgeToolStripMenuItem.Click
        frmsendmsg.Show()

    End Sub

    Private Sub ViewToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewToolStripMenuItem2.Click
        frmmsg.Show()
    End Sub
    Private Sub ChangePasswordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangePasswordToolStripMenuItem.Click
        frmchange.Show()
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If usertype = "Admin" Then
            sql = "select * from tbl_msg where status='unread' and tomsg='Admin'"
            If rs.State = 1 Then rs.Close()
            rs.Open(sql, conn)
            If rs.EOF = False Then
                SendMessageToolStripMenuItem.BackColor = Color.Red
            Else
                SendMessageToolStripMenuItem.BackColor = Color.Transparent
            End If

        ElseIf usertype = "Doctor" Then
            MasterToolStripMenuItem.Visible = False
            PatientToolStripMenuItem.Visible = False
            sql = "select * from tbl_msg where status='unread' and tomsg='" & userid & "'"
            If rs.State = 1 Then rs.Close()
            rs.Open(sql, conn)
            If rs.EOF = False Then
                '    sql = "select count(msg) from tbl_msg where status='unread' and tomsg='" & userid & "'"
                '    If rs.State = 1 Then rs.Close()
                '    rs.Open(sql, conn)
                '    ListBox1.Items.Clear()
                '    If rs.EOF = False Then
                '        ListBox1.Visible = True
                '        ListBox1.Items.Add(rs(0).Value & "unread msg")
                '    Else
                '        ListBox1.Visible = False
                '   End If
                SendMessageToolStripMenuItem.BackColor = Color.Red
               
            Else
                SendMessageToolStripMenuItem.BackColor = Color.Transparent
            End If
        ElseIf usertype = "Receptionist" Then
            MasterToolStripMenuItem.Visible = False
            TreatmentToolStripMenuItem.Visible = False
            sql = "select * from tbl_msg where status='unread' and tomsg='Receptionist'"
            If rs.State = 1 Then rs.Close()
            rs.Open(sql, conn)
            If rs.EOF = False Then
                SendMessageToolStripMenuItem.BackColor = Color.Red
            Else
                SendMessageToolStripMenuItem.BackColor = Color.Transparent
            End If
        End If
    End Sub
    
End Class