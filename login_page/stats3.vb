Imports System.Data.SqlClient

Public Class stats3
    Dim con
    Dim watched As New List(Of String)()


    Private Sub stats3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con = admin_page.con
        Dim query = "select movie_id ,movie_duration from allmovie"
        admin_page.Fill_Page(query, "ViewMovie", Viewtime_user)
        admin_page.AddmovieId(Selectmovie)
        Score()
    End Sub

    Private Sub Score()
        t_movies.Text = stats.Movie_count.Text
        mean_movie.Text = getscore("select avg(watched_time) from history group by user_id")
        Avg_movieDur.Text = getscore("select avg(movie_duration) from allmovie ")
    End Sub
    Private Function getscore(ByVal q)
        Dim comm As New SqlCommand With {
            .Connection = con,
            .CommandText = q}
        Dim ans = comm.ExecuteScalar()
        Return ans
    End Function

    Private Sub getMovieDetails()
        Dim movie_id = Selectmovie.SelectedItem.ToString
        Dim query As String = "select * from allmovie where movie_id = '" + movie_id + "'"
        Dim command As New SqlCommand With {
            .Connection = con,
            .CommandText = query
        }
        Dim dr As SqlDataReader
        dr = command.ExecuteReader()
        If dr.Read Then
            M_Name.Text = dr("movie_name")
            Dim movie_pic = dr("display_picture")
            Me.movie_pic.Image = Image.FromFile(movie_pic)
            dr.Close()
        End If
        Times_Watched.Text = getscore("select count(*) from history where movie_id = '" + movie_id + "'")
        Dim totawatched = getscore("select count(*) from history")
        Recom_rates.Text = (Math.Round(Times_Watched.Text / totawatched * 100, 4)).ToString + " %"
    End Sub

    Private Sub Selectmovie_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Selectmovie.SelectedIndexChanged
        movie_pic.Visible = True
        panel_score.Visible = True
        getMovieDetails()
    End Sub

    Private Sub panel_score_Paint(sender As Object, e As PaintEventArgs) Handles panel_score.Paint

    End Sub
End Class