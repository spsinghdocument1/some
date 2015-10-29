Imports System.Data.SqlClient

Module Module1
    Public conn As New ADODB.Connection
    Public rs As New ADODB.Recordset
    Public rss As New ADODB.Recordset
    Public sql As String
    Public userid As String
    Public outpatid As String
    Public usertype As String
    Public Server, Database, User, Password

    Public con As New SqlConnection("Data Source=ADMINMAYANK;Initial Catalog=softin;User ID=sa;Password=1234")
    Public Function opendb()

        If conn.State = 1 Then conn.Close()
        conn.Open("Provider=SQLOLEDB.1;Persist Security Info=False;User ID=sa;password=1234;Initial Catalog=softin;Data Source=ADMINMAYANK")  '  conn.Open("Provider=SQLOLEDB.1;Persist Security Info=False;User ID=sa;password=q1w2e3r4/;Initial Catalog=Hospital;Data Source=NAAZNEEN-PC")
        Return 0
    End Function
    Public Function CheckNum(ByVal e As KeyEventArgs)
        If (e.KeyCode < 48 Or e.KeyCode > 57) And e.KeyCode <> 8 And (e.KeyCode < 96 Or e.KeyCode > 105) Then


            e.SuppressKeyPress = True
        End If
        Return 0

    End Function
    Function CheckAlpha(ByVal e As KeyEventArgs)
        If e.KeyCode > 48 And e.KeyCode < 57 Then
            e.SuppressKeyPress = True
        End If
        Return 0
    End Function
End Module
