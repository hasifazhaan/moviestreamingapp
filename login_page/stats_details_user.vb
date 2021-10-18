Imports System.Data.SqlClient
Public Class stats_details_user
    Dim con
    Dim year = 2020
    Private Sub Stats_user_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con = admin_page.con
        Me.user_count.Text = stats.user_count.Text
        ComboBox1.SelectedIndex = 0
        SelectMostUserLiveIn()
        GetTopActiveUser()
        GetAllActiveUser()
        Loadtimespend()
    End Sub
    Private Sub SelectMostUserLiveIn()
        Dim query = "Select  count(username) as Topt , country as Country  from valid_user group by country order by Count(username) DESC "
        Dim command As New SqlCommand With {
            .Connection = con,
            .CommandText = query
        }
        Dim dr As SqlDataReader
        dr = command.ExecuteReader
        If dr.Read Then
            topuser_country.Text = dr("Country")
        End If

        dr.Close()
    End Sub
    Private Sub GetTopActiveUser()
        Dim query = "select top 5 user_id ,Sum(watched_time) from history  group by user_id ORDER BY Sum(watched_time) DESC"
        Dim command As New SqlCommand With
            {
            .Connection = con,
            .CommandText = query
        }
        Dim dr As SqlDataReader
        dr = command.ExecuteReader
        Dim TopFiveusr() = {top1user, top2user, top3user, top4user, top5user}
        Dim i = 0
        While dr.Read
            TopFiveusr(i).Text += dr.GetValue(0)
            i += 1
            top_userchart.Series("top_usr").Points.AddXY(dr.GetValue(0), dr.GetValue(1))
        End While
        dr.Close()
    End Sub
    Private Sub GetAllActiveUser()
        Dim query = "Select count(Distinct user_id) from history "
        Dim command As New SqlCommand With {
            .Connection = con,
            .CommandText = query}
        Dim ans = command.ExecuteScalar
        All_ActiveUser.Text = ans
    End Sub

    Private Sub Loadtimespend()
        Dim query2 = "SELECT CAST(MONTH(watched) AS int), SUM(watched_time)FROM [history] where  CAST(YEAR(watched) AS int) = " + year + " GROUP BY CAST(MONTH(watched)AS int)"
        Dim cm As New SqlCommand With {
            .Connection = con,
            .CommandText = query2}
        Dim dr As SqlDataReader
        dr = cm.ExecuteReader
        Dim Month
        For Each series In Chart1.Series
            series.Points.Clear()
        Next


        Chart1.ChartAreas(0).AxisX.Interval = 1
        While dr.Read
            Select Case dr.GetValue(0)

                Case 1
                    Month = "Jan"
                Case 2
                    Month = "Feb"
                Case 3
                    Month = "Mar"
                Case = 4
                    Month = "Apr"
                Case = 5
                    Month = "May"
                Case = 6
                    Month = "Jun"
                Case = 7
                    Month = "Jul"
                Case = 8
                    Month = "Aug"
                Case = 9
                    Month = "Sep"
                Case = 10
                    Month = "Oct"
                Case = 11
                    Month = "Nov"
                Case = 12
                    Month = "Dec"
                Case Else
                    Month = "0"
            End Select
            Chart1.Series("ViewMovie").Points.AddXY(Month, dr.GetValue(1))
        End While
        dr.Close()
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub Guna2CustomGradientPanel6_Paint(sender As Object, e As PaintEventArgs) Handles Guna2CustomGradientPanel6.Paint

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        year = ComboBox1.SelectedItem.ToString
        Loadtimespend()
    End Sub
End Class