Imports MySql.Data.MySqlClient
Imports module1
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class Form1
    Dim sqlQuery As String
    Dim da As mysqldataadapter
    Dim dt As DataTable

    Private Sub dataRecord_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataRecord.CellContentClick
        DbConnect()
    End Sub

    Private Sub btnload_Click(sender As Object, e As EventArgs) Handles btnload.Click

        Try
            conn.Open()
            sqlQuery = "Select * from employee"
            da = New MySqlDataAdapter(sqlQuery, conn)
            dt = New DataTable
            da.Fill(dt)
            dataRecord.DataSource = dt
            dataRecord.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnMode.Fill
            conn.Close()


        Catch ex As Exception

        End Try
        conn.Close()


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DbConnect()

    End Sub
    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        End

    End Sub

    Private Sub btnprint_Click(sender As Object, e As EventArgs) Handles btnprint.Click
        Form3.Show() 'Load form3
        Dim report As New ReportDocument
        'load cyrsttal report
        report.Load("C:\66\employee1111-master\UserList.rpt")
        Form3.CrystalReportViewer1.ReportSource = report
        Form3.CrystalReportViewer1.Refresh()


    End Sub
End Class


