Imports System.Data.SqlClient

Public Class stats

    Dim con
    Public totalwatched_Movie
    Private Sub stats_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con = admin_page.con
        FillHomeStats()
    End Sub
    Private Sub FillHomeStats()
        Dim Query = "select count(username) from valid_user"
        user_count.Text = CountTotalInDb(Query)
        Dim Query2 = "select count(movie_id) from allmovie"
        Movie_count.Text = CountTotalInDb(Query2)
        GetMovieDetails()
        GetGenreWatched()
        totalwatched_Movie = CountTotalInDb("select  count(distinct movie_id) from history")

    End Sub
    Public Function CountTotalInDb(ByVal query)
        Dim cmd As New SqlCommand With {
            .Connection = con,
            .CommandText = query
        }
        Dim ans = cmd.ExecuteScalar()
        Return ans

    End Function
    Private Sub GetMovieDetails()
        Dim query = "select top 5 count(movie_id),movie_id  from history  group by movie_id ORDER BY COUNT(movie_id) DESC "
        Dim cmd As New SqlCommand With {
            .Connection = con,
            .CommandText = query
        }
        Dim dr As SqlDataReader
        dr = cmd.ExecuteReader
        Dim a = 0
        While dr.Read
            If a = 0 Then
                TopMovie.Text = dr.GetString(1)

                a = 1
            End If
            Chart1.Series("Movies").Points.AddXY(dr.GetString(1), dr.GetInt32(0))
        End While
        dr.Close()
        GetMovie_Pic(TopMovie.Text)
    End Sub
    Private Sub GetMovie_Pic(ByVal movie_id)
        Dim cmd As New SqlCommand With {
            .Connection = con,
            .CommandText = "select display_picture,movie_name from allmovie where movie_id = '" + movie_id + "'"}
        Dim dr2 As SqlDataReader
        dr2 = cmd.ExecuteReader
        If dr2.Read Then
            Dim img = dr2.GetValue(0)
            Top_MoviePic.Image = Image.FromFile(img)
            TopMovie.Text = dr2.GetValue(1)
        End If
        dr2.Close()
    End Sub
    Private Sub GetGenreWatched()
        Dim query = "Select genre_name,count(genre_name) from genre group by genre_name"
        admin_page.Fill_Page(query, "Genre", TotalMovie_Gen)
    End Sub
    Private Sub Guna2CircleButton2_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton2.Click
        admin_page.InsertInPanel(stats2)
    End Sub

    Private Sub Guna2CircleButton3_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton3.Click
        admin_page.InsertInPanel(stats3)
    End Sub

    Private Sub Chart1_Click(sender As Object, e As EventArgs) Handles Chart1.Click

    End Sub

    Private Sub Guna2CircleButton1_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton1.Click
        admin_page.InsertInPanel(stats_details_user)
    End Sub
End Class