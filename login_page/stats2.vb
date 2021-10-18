Imports System.Data.SqlClient

Public Class stats2
    Dim con
    Private Sub stats2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con = admin_page.con
        Dim query = "SELECT genre_name,COUNT(genre_name) FROM genre WHERE movie_id IN (SELECT DISTINCT movie_id FROM history) GROUP BY genre_name"
        admin_page.Fill_Page(query, "Genre", TotalGen_Watched)
        Dim query2 = "SELECT genre_name,COUNT(genre_name) FROM genre WHERE movie_id IN (SELECT DISTINCT movie_id FROM favourite_movies) GROUP BY genre_name"
        admin_page.Fill_Page(query2, "Genre_Liked", GenreLiked_User)
        watched_mve.Text = Decimal.Round(stats.totalwatched_Movie / stats.Movie_count.Text * 100)
        watched_mve.Text += "%"
        Dim qu = "SELECT Top 4 genre.genre_name,count(Distinct history.user_id) FROM Genre INNER JOIN history ON genre.movie_id = history.movie_id group by genre.genre_name ORDER BY COUNT(history.user_id) DESC "
        Dim cm As New SqlCommand With {
            .Connection = con,
            .CommandText = qu}
        Dim dr As SqlDataReader
        dr = cm.ExecuteReader
        Dim TopFourGen() = {TopWatched_Genre, SecWatched_Gen, ThirdWatched_Gen, FourthWatched_Gen}
        Dim TopFourVal() = {user_count, usercnt_sec, usercnt_third, usrcnt_forth}
        Dim i = 0
        While dr.Read
            TopFourGen(i).Text = dr.GetValue(0)
            TopFourVal(i).Text = dr.GetValue(1)
            i += 1
        End While
        dr.Close()

    End Sub


    Private Sub GenreLiked_User_Click(sender As Object, e As EventArgs) Handles GenreLiked_User.Click

    End Sub
End Class