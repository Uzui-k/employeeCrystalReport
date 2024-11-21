Imports MySql.Data.MySqlClient


Module Module1
    Public conn As New MySqlConnection

    Public Sub DbConnect()

        Dim dbname As String = "it2a"
        Dim username As String = "root"
        Dim password As String = "password" 'mysql server pwd
        Dim server As String = "127.0.0.1" 'pc ipadd'

        'check if connection is open
        If Not conn Is Nothing Then
            conn.Close()
            'establish new connection
            conn.ConnectionString = "server=" & server & ";user id =" & username & ";password =" & password & ";database=" & dbname & ""
            Try
                conn.Open() 'open connection
                MsgBox("connected")

            Catch ex As Exception
                MsgBox(ex.Message)


            End Try

        End If
    End Sub
End Module
