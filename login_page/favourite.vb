Public Class favourite
    Public Sub favourite_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pic_fav.Controls.Clear()
        Dim sql_favourite = "SELECT * from allmovie where movie_id in(SELECT movie_id from favourite_movies where favourite_movies.user_id = '" + main_page.Userid + "'  ) "
        main_page.ReadFromDb(sql_favourite, Me.pic_fav)
    End Sub


End Class