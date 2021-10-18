Public Class discover
    Dim cl = 0
    Private Sub Button5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.Click
        If cl = 0 Then
            TextBox1.Text = ""
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim searchquery = "select * from allmovie where movie_name  LIKE '%" + TextBox1.Text + "%'"
        Me.PanelMovie.Controls.Clear()
        main_page.ReadFromDb(searchquery, Me.PanelMovie)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        fill("Action")
    End Sub
    Private Sub fill(ByVal gen)
        Dim searchquery = "select * from allmovie,genre where genre.genre_name = '" + gen + "' AND genre.movie_id = allmovie.movie_id"
        Me.PanelMovie.Controls.Clear()
        main_page.ReadFromDb(searchquery, Me.PanelMovie)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        fill("Comedy")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        fill("Romance")
    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click
        fill("Sci-fic")
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        fill("Thriller")
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        fill("Mystery")
    End Sub


End Class