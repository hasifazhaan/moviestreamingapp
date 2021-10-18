Imports System.Data.SqlClient

Public Class admin_page
    Public con As New SqlConnection


    Dim dp, fileloc As String
    Dim directors As New List(Of String)()
    Dim genre As New List(Of String)()
    Dim stars As New List(Of String)()
    Dim val As String
    Private Sub Admin_page_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Connects To The DataBase
        con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HASEEF\source\repos\login_page\login_page\Database1.mdf;Integrated Security=True"
        con.Open()
    End Sub
    Private Sub ButtonExit_Click(sender As Object, e As EventArgs) Handles buttonExit.Click
        con.Close()
        Application.Exit()
    End Sub

    Private Sub Minimise_Click(sender As Object, e As EventArgs) Handles Minimise.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub SelectMovie_Click(sender As Object, e As EventArgs) Handles selectMovieFile.Click
        Dim filter = "All Media Files|*.mpg;*.mpeg;*.m3u;*.mp4;*.mov;*.3gp;*.midi;*.mkv;*.MPEG;*.MP4;*.3GP;*.MIDI;*.MKV"
        fileloc = SelectFile(filter, display_vid_file)
    End Sub
    Private Sub SelectDp_Click(sender As Object, e As EventArgs) Handles SelectDp.Click
        Dim filter = "All Media Files|*.bmp;*.png;*.jpg;*.gif;*.tif"
        dp = SelectFile(filter, display_dp_file)
    End Sub
    Private Function SelectFile(ByVal string_filter, ByRef textbox)

        OpenFileDialog1.Filter = string_filter
        OpenFileDialog1.FilterIndex = 1
        OpenFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Recent)
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            val = OpenFileDialog1.FileName
        End If
        textbox.Text = val
        textbox.Visible = True
        Return val
    End Function


    Private Sub InsertNewMovie(sender As Object, e As EventArgs) Handles add_todatabase_movie.Click
        Try
            Dim movie_id As String = m_id.Text
            Dim name As String = m_name.Text
            Dim rating As String = Rating_1.Text
            Dim rel As String = released_year.Text
            Dim desc As String = m_desc.Text
            Dim dur As String = mve_dur.Text
            Dim command As New SqlCommand
            Dim query As String = "insert into allmovie(movie_id,movie_name,rating,released,movie_description,display_picture,movie_file,movie_duration) values(@mid,@mname,@ratings,@released,@moviedesc,@dp,@mf,@mdur)"
            command.Connection = con
            command.CommandText = query
            Dim param_mid As New SqlParameter("@mid", SqlDbType.VarChar, 10)
            param_mid.Value = movie_id
            Dim param_name As New SqlParameter("@mname", SqlDbType.VarChar, 50)
            param_name.Value = name

            Dim param_ratings As New SqlParameter("@ratings", SqlDbType.Float)
            param_ratings.Value = rating

            Dim param_rel As New SqlParameter("@released", SqlDbType.Int, 4)
            param_rel.Value = rel
            Dim param_desc As New SqlParameter("@moviedesc", SqlDbType.VarChar, 1000)
            param_desc.Value = desc
            Dim param_dp As New SqlParameter("@dp", SqlDbType.VarChar, 150)
            param_dp.Value = dp
            Dim param_file As New SqlParameter("@mf", SqlDbType.VarChar, 150)
            param_file.Value = fileloc
            Dim param_duration As New SqlParameter("@mdur", SqlDbType.VarChar, 150)
            param_duration.Value = dur
            command.Parameters.Add(param_mid)
            command.Parameters.Add(param_name)
            command.Parameters.Add(param_ratings)
            command.Parameters.Add(param_rel)
            command.Parameters.Add(param_desc)
            command.Parameters.Add(param_dp)
            command.Parameters.Add(param_file)
            command.Parameters.Add(param_duration)
            Try
                Dim adapter As New SqlDataAdapter
                adapter.InsertCommand = command
                adapter.InsertCommand.ExecuteNonQuery()
                MoreDb(movie_id)
                result_panel.Visible = True
                result.Text = "Inserted Sucessfully"

            Catch ex As SqlException
                If ex.Number = 2627 Then
                    result.Text = "Movie Already Exist ," & vbCrLf & " please try with different" & vbCrLf & " Title"
                    result_panel.Visible = True
                Else
                    result.Text = "Somthing went wrong "
                    result_panel.Visible = True
                End If
            End Try

        Catch ex As Exception
            result.Text = "Somthing went wrong "
            result_panel.Visible = True
        End Try
    End Sub

    Private Sub MoreDb(ByVal m_id)
        Dim query1 = "insert into genre(movie_id,genre_name) values(@mid,@name)"
        Dim query2 = "insert into director(movie_id,director_name) values(@mid,@name)"
        Dim query3 = "insert into actor(movie_id,star_name) values(@mid,@name)"
        For Each value As String In genre
            InsertIntoDb(query1, m_id, value)
        Next
        For Each value As String In directors
            InsertIntoDb(query2, m_id, value)
        Next
        For Each value As String In stars
            InsertIntoDb(query3, m_id, value)
        Next
    End Sub
    Private Sub InsertIntoDb(ByVal query, ByVal movie_id, ByVal value)
        Dim command As New SqlCommand
        Dim da As New SqlDataAdapter
        command.Connection = con
        command.CommandText = query
        da.InsertCommand = command
        Dim param_mid As New SqlParameter("@mid", SqlDbType.VarChar, 10)
        param_mid.Value = movie_id
        Dim param_name As New SqlParameter("@name", SqlDbType.VarChar, 50)
        param_name.Value = value
        command.Parameters.Add(param_mid)
        command.Parameters.Add(param_name)
        da.InsertCommand = command
        da.InsertCommand.ExecuteNonQuery()
    End Sub
    Public Sub Showpanel(ByRef pnl)
        Hidepanel()
        pnl.visible = True
        pnl.dock = DockStyle.Fill

    End Sub
    Private Sub Hidepanel()
        Panel_add_movie.Visible = False
        Panel_director.Dock = DockStyle.None
        DeleteMovie_panel.Visible = False
        DeleteMovie_panel.Dock = DockStyle.None
        stats.Hide()
        stats2.Hide()
        stats3.Hide()
        stats_details_user.Hide()

    End Sub

    Private Sub add_btn_Click(sender As Object, e As EventArgs) Handles add_btn.Click
        Showpanel(Panel_add_movie)
    End Sub
    Private Sub ShowOnHover(ByRef button, ByVal img)
        button.Image = Image.FromFile(img)
    End Sub
    Private Sub Exit_button_MouseEnter(sender As Object, e As EventArgs) Handles Exit_button.MouseEnter
        Dim img = "C:\Users\HASEEF\source\repos\login_page\login_page\Resources\Exit.png"
        ShowOnHover(Exit_button, img)

    End Sub
    Private Sub Exit_button_MouseLeave(sender As Object, e As EventArgs) Handles Exit_button.MouseLeave
        Dim img = "C:\Users\HASEEF\source\repos\login_page\login_page\Resources\Red.png"
        ShowOnHover(Exit_button, img)
    End Sub
    Private Sub Mini_button_MouseEnter(sender As Object, e As EventArgs) Handles Mini_button.MouseEnter
        Dim img = "C:\Users\HASEEF\source\repos\login_page\login_page\Resources\Minimise.png"
        ShowOnHover(Mini_button, img)
    End Sub
    Private Sub Mini_button_MouseLeave(sender As Object, e As EventArgs) Handles Mini_button.MouseLeave
        Dim img = "C:\Users\HASEEF\source\repos\login_page\login_page\Resources\Yellow.png"
        ShowOnHover(Mini_button, img)
    End Sub
    Private Sub Max_button_MouseEnter(sender As Object, e As EventArgs) Handles Max_button.MouseEnter
        Dim img = "C:\Users\HASEEF\source\repos\login_page\login_page\Resources\Maximise.png"
        ShowOnHover(Max_button, img)
    End Sub
    Private Sub Max_button_MouseLeave(sender As Object, e As EventArgs) Handles Max_button.MouseLeave
        Dim img = "C:\Users\HASEEF\source\repos\login_page\login_page\Resources\Green.png"
        ShowOnHover(Max_button, img)
    End Sub

    Private Sub Exit_button_Click(sender As Object, e As EventArgs) Handles Exit_button.Click
        Application.Exit()
    End Sub
    Private Sub Mini_button_Click(sender As Object, e As EventArgs) Handles Mini_button.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub Max_button_Click(sender As Object, e As EventArgs) Handles Max_button.Click
        Me.MaximizedBounds = Screen.GetWorkingArea(Me)
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        Else
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub

    Dim x1 As Integer = 3
    Dim x2 As Integer = 3
    Dim x3 As Integer = 3
    Dim item As Integer = 0

    Private Sub CreateVisibleValues(ByRef box, ByRef array, ByRef parent_panel, ByVal x, ByVal name)
        Dim txtbx As New TextBox With {
            .Name = name + item.ToString,
            .Text = box.text,
            .Location = New Point(x, 4),
            .ReadOnly = True,
            .BorderStyle = BorderStyle.FixedSingle,
            .BackColor = Color.FromKnownColor(KnownColor.ScrollBar),
            .Font = New Font("Microsoft Sans Serif", 11, FontStyle.Regular)
        }
        array.add(txtbx.Text)
        parent_panel.Controls.Add(txtbx)
        box.Text = ""
        item += 1
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        CreateVisibleValues(m_genre, genre, Panel_genre, x1, "genre_")
        x1 += 120
    End Sub
    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        CreateVisibleValues(m_director, directors, Panel_director, x2, "dir_")
        x2 += 120
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        CreateVisibleValues(m_cast, stars, Panel_star, x3, "cast_")
        x3 += 120
    End Sub
    Private Sub RemoveControls(ByVal panel_name As Panel)
        panel_name.Controls.Clear()
    End Sub

    Private Sub ClearFromForm(sender As Object, e As EventArgs) Handles Button4.Click
        ClearTextBox(Me)
        m_desc.Text = ""
        RemoveControls(Panel_director)
        RemoveControls(Panel_genre)
        RemoveControls(Panel_star)
        x1 = 0
        x2 = 0
        x3 = 0
        result_panel.Visible = False
        directors.Clear()
        genre.Clear()
        stars.Clear()
    End Sub
    Public Sub ClearTextBox(ByVal root As Control)
        For Each ctrl As Control In root.Controls
            ClearTextBox(ctrl)
            If TypeOf ctrl Is TextBox Then
                CType(ctrl, TextBox).Text = String.Empty
            End If
        Next ctrl
    End Sub

    Private Sub ShowDelPanel(sender As Object, e As EventArgs) Handles Del_Movie.Click
        Showpanel(DeleteMovie_panel)
        AddmovieId(Me.Selectdeletemovie)
    End Sub
    Public Sub AddmovieId(ByRef ctrl)
        Dim query = "select movie_id as id from allmovie"
        Dim cmd As New SqlCommand With {
            .Connection = con,
            .CommandText = query}
        Dim dr As SqlDataReader
        dr = cmd.ExecuteReader
        While dr.Read
            ctrl.Items.Add(dr("id"))
        End While
        dr.Close()
    End Sub

    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click
        Dim query As String = "select * from allmovie where movie_id = '" + Selectdeletemovie.SelectedItem.ToString + "'"
        Dim sql_genre = "select genre_name from genre where movie_id = '" + Selectdeletemovie.SelectedItem.ToString + "'"
        Dim sql_director = "select director_name from director where movie_id = '" + Selectdeletemovie.SelectedItem.ToString + "'"
        Dim command As New SqlCommand With {
            .Connection = con,
            .CommandText = query
        }
        Dim dr As SqlDataReader
        dr = command.ExecuteReader()
        If dr.Read Then
            Movie_detail_panel.Visible = True
            Dim movie_pic = dr("display_picture")
            movie_name_todelete.Text = dr("movie_name")
            movie_ratings_todelete.Text = dr("rating")
            movie_year_todelete.Text = dr("released")
            movie_pic_todelete.Image = Image.FromFile(movie_pic)
            dr.Close()
            Search_otherDb(sql_director, movie_dir_todelete, "director_name")
            Search_otherDb(sql_genre, movie_gen_todelete, "genre_name")
        Else
            res_invalid.Visible = True
        End If
        dr.Close()

    End Sub
    Private Sub Search_otherDb(ByVal sql, ByRef control, ByVal col_name)
        Dim command As New SqlCommand
        Dim dr As SqlDataReader
        command.Connection = con
        command.CommandText = sql
        dr = command.ExecuteReader()
        If dr.Read Then
            control.text = dr(col_name)
        End If
        dr.Close()
    End Sub
    Dim success = 0
    Private Sub DeleteMovie_Click(sender As Object, e As EventArgs) Handles DeleteMovie.Click
        If MessageBox.Show("Do you really want to delete this record?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) =
             Windows.Forms.DialogResult.Yes Then
            DeleteMovieFromDb(CreateSqlString("allmovie", Selectdeletemovie.SelectedItem.ToString))
            DeleteMovieFromDb(CreateSqlString("director", Selectdeletemovie.SelectedItem.ToString))
            DeleteMovieFromDb(CreateSqlString("genre", Selectdeletemovie.SelectedItem.ToString))
            DeleteMovieFromDb(CreateSqlString("actor", Selectdeletemovie.SelectedItem.ToString))
            DeleteMovieFromDb(CreateSqlString("history", Selectdeletemovie.SelectedItem.ToString))
            DeleteMovieFromDb(CreateSqlString("favourite_movies", Selectdeletemovie.SelectedItem.ToString))
            If success > 0 Then
                MsgBox("Record Successfully Deleted")
            Else
                MsgBox("Record is not deleted")
            End If
            Movie_detail_panel.Visible = False
        End If
    End Sub

    Private Function CreateSqlString(ByVal table, ByVal movie_id)
        Dim query = "Delete From " + table + " Where movie_id = '" + movie_id + "'"
        Return query
    End Function
    Private Sub DeleteMovieFromDb(ByVal query)
        Dim cmd As New SqlCommand With {
            .Connection = con,
            .CommandText = query
        }
        Dim i As Integer = cmd.ExecuteNonQuery()
        If (i > 0) Then
            success += 1
        End If
    End Sub
    Private Sub hide_pnl_Click(sender As Object, e As EventArgs) Handles hide_pnl.Click
        res_invalid.Visible = False
        Movie_detail_panel.Visible = False
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        InsertInPanel(stats)
    End Sub
    Public Sub InsertInPanel(ByRef Pnl)
        Pnl.TopLevel = False
        Pnl.TopMost = True
        Showpanel(Pnl)
        Panel3.Controls.Add(Pnl)
    End Sub

    Private Sub LogOut_Click(sender As Object, e As EventArgs) Handles LogOut.Click
        login_page.Show()
        Me.Hide()
    End Sub


    Dim i = 1100
    Private Sub m_name_TextChanged(sender As Object, e As EventArgs) Handles m_name.TextChanged
        Dim id
        Dim tid
        If m_name.TextLength <= 4 Then
            id = m_name.Text
        Else
            id = m_name.Text.Substring(0, 4)
        End If
        tid = id
        Dim checkid = True
        id += i.ToString()
        While checkid
            Dim query = "select movie_id from allmovie where movie_id  ='" + id + "'"
            Dim command As New SqlCommand With {
            .Connection = con,
            .CommandText = query}
            Dim dr As SqlDataReader
            dr = command.ExecuteReader
            If dr.Read = False Then
                checkid = False
                m_id.Text = id
            Else
                i = i + 1
                id = tid + i.ToString
            End If
            dr.Close()

        End While
    End Sub


    Public Sub Fill_Page(ByVal query, ByVal Seriesname, ByRef Chartname)
        Dim cmd As New SqlCommand With {
           .Connection = con,
           .CommandText = query}
        Dim dr As SqlDataReader
        dr = cmd.ExecuteReader
        Chartname.ChartAreas(0).AxisX.Interval = 1
        While dr.Read
            Chartname.Series(Seriesname).Points.AddXY(dr.GetValue(0), dr.GetValue(1))
        End While

        dr.Close()
    End Sub
End Class