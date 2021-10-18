Public Class trending
    Private Sub trending_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sql_trending = "SELECT * from allmovie where released  >= '2020'"
        main_page.ReadFromDb(sql_trending, Me.pic_trend)

    End Sub

    Private Sub history_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub pic_trend_Paint(sender As Object, e As PaintEventArgs) Handles pic_trend.Paint
    End Sub

    Private Sub pic_trend_MouseEnter(sender As Object, e As EventArgs) Handles pic_trend.MouseEnter
        pic_trend.AutoScroll = True
    End Sub

    Private Sub pic_trend_MouseLeave(sender As Object, e As EventArgs) Handles pic_trend.MouseLeave
        pic_trend.AutoScroll = False
    End Sub
End Class