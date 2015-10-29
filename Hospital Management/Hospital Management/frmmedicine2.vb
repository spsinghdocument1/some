Imports System.Data.SqlClient
Public Class frmmedicine2

    Private Sub btnprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprint.Click
        If con.State = ConnectionState.Open Then con.Close()
        con.Open()
        'Dim cmd As New SqlCommand("select * from tbl_setting", con)
        'Dim dr As SqlDataReader
        'dr = cmd.ExecuteReader
        'If dr.Read = True Then

        '    Server = dr.Item(0).ToString
        '    Database = dr.Item(1).ToString
        '    User = dr.Item(2).ToString
        '    Password = dr.Item(3).ToString
        'End If
        'con.Close()
        For j = 0 To DataGridView1.Rows.Count - 1
            Dim rpt As New medcnReport1
            'rpt.DataSourceConnections.Item(0).SetConnection(Server, Database, User, Password)
            'rpt.DataSourceConnections.Item(0).SetLogon(User, Password)


            rpt.SetParameterValue("Med", DataGridView1.Item(0, j).Value)
            rpt.SetParameterValue("qty", DataGridView1.Item(1, j).Value)
            Me.CrystalReportViewer1.ReportSource = rpt




            Me.CrystalReportViewer1.Refresh()
            'Dim int As New salesReport1
            'int.SetDataSource(ds)
            'Salesreprt.ReportSource = int
            ' int.Refresh()

            Me.Show()
        Next
    End Sub

    Private Sub frmmedicine2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        opendb()
    End Sub

    Dim i = 0
    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click

        DataGridView1.Rows.Add()
        DataGridView1.Item(0, i).Value = txtmed.Text
        DataGridView1.Item(1, i).Value = txtqty.Text
        i = i + 1
    End Sub
End Class