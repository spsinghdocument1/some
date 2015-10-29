<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmmaster
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmmaster))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.MasterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AddDoctorsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AddOtherWorkersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EquipmentDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RegisterUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AddNewRoomToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AddNewDepartmentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PatientToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.InPatientToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AddToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EditOrDeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.OutPatientToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AddToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.EditOrDeleteToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ViewToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ShiftRoomToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MovePatientToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DischargePatientToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.OutPatientBillToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TreatmentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PatientTreatmentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PrescriptionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.OperationAllotmentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PatientToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.InPatientToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.OutPatientToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.DoctorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NurseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SendMessageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SendMessgeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ViewToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem
        Me.ChangePasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MasterToolStripMenuItem, Me.PatientToolStripMenuItem, Me.TreatmentToolStripMenuItem, Me.SearchToolStripMenuItem, Me.SendMessageToolStripMenuItem, Me.ChangePasswordToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1042, 38)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MasterToolStripMenuItem
        '
        Me.MasterToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddDoctorsToolStripMenuItem, Me.AToolStripMenuItem, Me.AddOtherWorkersToolStripMenuItem, Me.EquipmentDetailsToolStripMenuItem, Me.RegisterUserToolStripMenuItem, Me.AddNewRoomToolStripMenuItem, Me.AddNewDepartmentToolStripMenuItem})
        Me.MasterToolStripMenuItem.Name = "MasterToolStripMenuItem"
        Me.MasterToolStripMenuItem.ShowShortcutKeys = False
        Me.MasterToolStripMenuItem.Size = New System.Drawing.Size(55, 34)
        Me.MasterToolStripMenuItem.Text = "Master"
        '
        'AddDoctorsToolStripMenuItem
        '
        Me.AddDoctorsToolStripMenuItem.Name = "AddDoctorsToolStripMenuItem"
        Me.AddDoctorsToolStripMenuItem.Size = New System.Drawing.Size(241, 22)
        Me.AddDoctorsToolStripMenuItem.Text = " Doctors Detail"
        '
        'AToolStripMenuItem
        '
        Me.AToolStripMenuItem.Name = "AToolStripMenuItem"
        Me.AToolStripMenuItem.Size = New System.Drawing.Size(241, 22)
        Me.AToolStripMenuItem.Text = "Nurse Detail"
        '
        'AddOtherWorkersToolStripMenuItem
        '
        Me.AddOtherWorkersToolStripMenuItem.Name = "AddOtherWorkersToolStripMenuItem"
        Me.AddOtherWorkersToolStripMenuItem.Size = New System.Drawing.Size(241, 22)
        Me.AddOtherWorkersToolStripMenuItem.Text = "Other Workers Detail"
        '
        'EquipmentDetailsToolStripMenuItem
        '
        Me.EquipmentDetailsToolStripMenuItem.Name = "EquipmentDetailsToolStripMenuItem"
        Me.EquipmentDetailsToolStripMenuItem.Size = New System.Drawing.Size(241, 22)
        Me.EquipmentDetailsToolStripMenuItem.Text = "Equipment details"
        '
        'RegisterUserToolStripMenuItem
        '
        Me.RegisterUserToolStripMenuItem.Name = "RegisterUserToolStripMenuItem"
        Me.RegisterUserToolStripMenuItem.Size = New System.Drawing.Size(241, 22)
        Me.RegisterUserToolStripMenuItem.Text = "Register User"
        '
        'AddNewRoomToolStripMenuItem
        '
        Me.AddNewRoomToolStripMenuItem.Name = "AddNewRoomToolStripMenuItem"
        Me.AddNewRoomToolStripMenuItem.Size = New System.Drawing.Size(241, 22)
        Me.AddNewRoomToolStripMenuItem.Text = "Add New Room"
        '
        'AddNewDepartmentToolStripMenuItem
        '
        Me.AddNewDepartmentToolStripMenuItem.Name = "AddNewDepartmentToolStripMenuItem"
        Me.AddNewDepartmentToolStripMenuItem.Size = New System.Drawing.Size(241, 22)
        Me.AddNewDepartmentToolStripMenuItem.Text = "Add department or Designation"
        '
        'PatientToolStripMenuItem
        '
        Me.PatientToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InPatientToolStripMenuItem, Me.OutPatientToolStripMenuItem, Me.ShiftRoomToolStripMenuItem, Me.MovePatientToolStripMenuItem, Me.DischargePatientToolStripMenuItem, Me.OutPatientBillToolStripMenuItem})
        Me.PatientToolStripMenuItem.Name = "PatientToolStripMenuItem"
        Me.PatientToolStripMenuItem.Size = New System.Drawing.Size(56, 34)
        Me.PatientToolStripMenuItem.Text = "Patient"
        '
        'InPatientToolStripMenuItem
        '
        Me.InPatientToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddToolStripMenuItem, Me.EditOrDeleteToolStripMenuItem, Me.ViewToolStripMenuItem})
        Me.InPatientToolStripMenuItem.Name = "InPatientToolStripMenuItem"
        Me.InPatientToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.InPatientToolStripMenuItem.Text = "InPatient"
        '
        'AddToolStripMenuItem
        '
        Me.AddToolStripMenuItem.Name = "AddToolStripMenuItem"
        Me.AddToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.AddToolStripMenuItem.Text = "Add"
        '
        'EditOrDeleteToolStripMenuItem
        '
        Me.EditOrDeleteToolStripMenuItem.Name = "EditOrDeleteToolStripMenuItem"
        Me.EditOrDeleteToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.EditOrDeleteToolStripMenuItem.Text = "Edit Or Delete"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.ViewToolStripMenuItem.Text = "View"
        '
        'OutPatientToolStripMenuItem
        '
        Me.OutPatientToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddToolStripMenuItem1, Me.EditOrDeleteToolStripMenuItem1, Me.ViewToolStripMenuItem1})
        Me.OutPatientToolStripMenuItem.Name = "OutPatientToolStripMenuItem"
        Me.OutPatientToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.OutPatientToolStripMenuItem.Text = "OutPatient"
        '
        'AddToolStripMenuItem1
        '
        Me.AddToolStripMenuItem1.Name = "AddToolStripMenuItem1"
        Me.AddToolStripMenuItem1.Size = New System.Drawing.Size(144, 22)
        Me.AddToolStripMenuItem1.Text = "Add"
        '
        'EditOrDeleteToolStripMenuItem1
        '
        Me.EditOrDeleteToolStripMenuItem1.Name = "EditOrDeleteToolStripMenuItem1"
        Me.EditOrDeleteToolStripMenuItem1.Size = New System.Drawing.Size(144, 22)
        Me.EditOrDeleteToolStripMenuItem1.Text = "Edit or Delete"
        '
        'ViewToolStripMenuItem1
        '
        Me.ViewToolStripMenuItem1.Name = "ViewToolStripMenuItem1"
        Me.ViewToolStripMenuItem1.Size = New System.Drawing.Size(144, 22)
        Me.ViewToolStripMenuItem1.Text = "View"
        '
        'ShiftRoomToolStripMenuItem
        '
        Me.ShiftRoomToolStripMenuItem.Name = "ShiftRoomToolStripMenuItem"
        Me.ShiftRoomToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.ShiftRoomToolStripMenuItem.Text = "Shift room"
        '
        'MovePatientToolStripMenuItem
        '
        Me.MovePatientToolStripMenuItem.Name = "MovePatientToolStripMenuItem"
        Me.MovePatientToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.MovePatientToolStripMenuItem.Text = "Move Patient"
        '
        'DischargePatientToolStripMenuItem
        '
        Me.DischargePatientToolStripMenuItem.Name = "DischargePatientToolStripMenuItem"
        Me.DischargePatientToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.DischargePatientToolStripMenuItem.Text = "Discharge Patient"
        '
        'OutPatientBillToolStripMenuItem
        '
        Me.OutPatientBillToolStripMenuItem.Name = "OutPatientBillToolStripMenuItem"
        Me.OutPatientBillToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.OutPatientBillToolStripMenuItem.Text = "OutPatient Bill"
        '
        'TreatmentToolStripMenuItem
        '
        Me.TreatmentToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PatientTreatmentToolStripMenuItem, Me.PrescriptionToolStripMenuItem, Me.OperationAllotmentToolStripMenuItem})
        Me.TreatmentToolStripMenuItem.Name = "TreatmentToolStripMenuItem"
        Me.TreatmentToolStripMenuItem.Size = New System.Drawing.Size(74, 34)
        Me.TreatmentToolStripMenuItem.Text = "Treatment"
        '
        'PatientTreatmentToolStripMenuItem
        '
        Me.PatientTreatmentToolStripMenuItem.Name = "PatientTreatmentToolStripMenuItem"
        Me.PatientTreatmentToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.PatientTreatmentToolStripMenuItem.Text = "Patient Treatment"
        '
        'PrescriptionToolStripMenuItem
        '
        Me.PrescriptionToolStripMenuItem.Name = "PrescriptionToolStripMenuItem"
        Me.PrescriptionToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.PrescriptionToolStripMenuItem.Text = "Prescription"
        '
        'OperationAllotmentToolStripMenuItem
        '
        Me.OperationAllotmentToolStripMenuItem.Name = "OperationAllotmentToolStripMenuItem"
        Me.OperationAllotmentToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.OperationAllotmentToolStripMenuItem.Text = "Operation Allotment"
        '
        'SearchToolStripMenuItem
        '
        Me.SearchToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PatientToolStripMenuItem1, Me.DoctorToolStripMenuItem, Me.NurseToolStripMenuItem})
        Me.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem"
        Me.SearchToolStripMenuItem.Size = New System.Drawing.Size(54, 34)
        Me.SearchToolStripMenuItem.Text = "Search"
        '
        'PatientToolStripMenuItem1
        '
        Me.PatientToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InPatientToolStripMenuItem1, Me.OutPatientToolStripMenuItem1})
        Me.PatientToolStripMenuItem1.Name = "PatientToolStripMenuItem1"
        Me.PatientToolStripMenuItem1.Size = New System.Drawing.Size(111, 22)
        Me.PatientToolStripMenuItem1.Text = "Patient"
        '
        'InPatientToolStripMenuItem1
        '
        Me.InPatientToolStripMenuItem1.Name = "InPatientToolStripMenuItem1"
        Me.InPatientToolStripMenuItem1.Size = New System.Drawing.Size(131, 22)
        Me.InPatientToolStripMenuItem1.Text = "InPatient"
        '
        'OutPatientToolStripMenuItem1
        '
        Me.OutPatientToolStripMenuItem1.Name = "OutPatientToolStripMenuItem1"
        Me.OutPatientToolStripMenuItem1.Size = New System.Drawing.Size(131, 22)
        Me.OutPatientToolStripMenuItem1.Text = "OutPatient"
        '
        'DoctorToolStripMenuItem
        '
        Me.DoctorToolStripMenuItem.Name = "DoctorToolStripMenuItem"
        Me.DoctorToolStripMenuItem.Size = New System.Drawing.Size(111, 22)
        Me.DoctorToolStripMenuItem.Text = "Doctor"
        '
        'NurseToolStripMenuItem
        '
        Me.NurseToolStripMenuItem.Name = "NurseToolStripMenuItem"
        Me.NurseToolStripMenuItem.Size = New System.Drawing.Size(111, 22)
        Me.NurseToolStripMenuItem.Text = "Nurse"
        '
        'SendMessageToolStripMenuItem
        '
        Me.SendMessageToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SendMessgeToolStripMenuItem, Me.ViewToolStripMenuItem2})
        Me.SendMessageToolStripMenuItem.Name = "SendMessageToolStripMenuItem"
        Me.SendMessageToolStripMenuItem.Size = New System.Drawing.Size(65, 34)
        Me.SendMessageToolStripMenuItem.Text = "Message"
        '
        'SendMessgeToolStripMenuItem
        '
        Me.SendMessgeToolStripMenuItem.Name = "SendMessgeToolStripMenuItem"
        Me.SendMessgeToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.SendMessgeToolStripMenuItem.Text = "Send messge"
        '
        'ViewToolStripMenuItem2
        '
        Me.ViewToolStripMenuItem2.Name = "ViewToolStripMenuItem2"
        Me.ViewToolStripMenuItem2.Size = New System.Drawing.Size(143, 22)
        Me.ViewToolStripMenuItem2.Text = "View"
        '
        'ChangePasswordToolStripMenuItem
        '
        Me.ChangePasswordToolStripMenuItem.Name = "ChangePasswordToolStripMenuItem"
        Me.ChangePasswordToolStripMenuItem.Size = New System.Drawing.Size(113, 34)
        Me.ChangePasswordToolStripMenuItem.Text = "Change Password"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(57, 34)
        Me.ExitToolStripMenuItem.Text = "Logout"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 200
        '
        'frmmaster
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1042, 559)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmmaster"
        Me.Text = "frmmaster"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MasterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddDoctorsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PatientToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TreatmentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SearchToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddOtherWorkersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EquipmentDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegisterUserToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddNewRoomToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PatientTreatmentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrescriptionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OperationAllotmentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InPatientToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditOrDeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OutPatientToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShiftRoomToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MovePatientToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditOrDeleteToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PatientToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InPatientToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OutPatientToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DoctorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NurseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DischargePatientToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OutPatientBillToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddNewDepartmentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SendMessageToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SendMessgeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChangePasswordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
