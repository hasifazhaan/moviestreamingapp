Imports System.Data.SqlClient
Public Class main_page
    Dim con As New SqlConnection
    Dim count As Integer = 0
    Dim file As String
    Dim director As String
    Dim stars As String
    Dim genre As String
    Public Userid As String
    Dim watched_movies As New List(Of String)()
    Dim clickedMovie As String

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

    Private Sub Main_page_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Userid = user.Text
        con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HASEEF\source\repos\login_page\login_page\Database1.mdf;Integrated Security=True"
        con.Open()
        Fillhomescreen()
        add_btn_Click(sender, e)

    End Sub
    Private Sub Fillhomescreen()

        Dim sql_history = "SELECT * from allmovie where movie_id in(SELECT movie_id from history where history.user_id = '" + Userid + "'  ) "
        Dim sql_actionmovies = "select * from allmovie,genre where genre.genre_name = 'Action' AND genre.movie_id = allmovie.movie_id"
        Dim sql_madeforyou = "select * from allmovie where rating >= '7.5' order by rating DESC"
        Dim sql_scific = "select * from allmovie,genre where genre.genre_name = 'Sci-fic' AND genre.movie_id = allmovie.movie_id"
        Dim sql_Romance = "select * from allmovie,genre where genre.genre_name = 'Romance' AND genre.movie_id = allmovie.movie_id"
        ReadFromDb(sql_history, pic_history)
        ReadFromDb(sql_actionmovies, Action_pnl)
        ReadFromDb(sql_madeforyou, made_for_you_panel)
        ReadFromDb(sql_scific, Scific_panel)
        ReadFromDb(sql_Romance, Romance_panel)
    End Sub
    Private Sub ShowPanel(ByRef pnl)
        HideAllPanel()
        pnl.visible = True
    End Sub
    Private Sub HideAllPanel()
        collection_panel.Visible = False
        Movie_info_pnl.Hide()
        trending.Hide()
        userhistory.Hide()
        favourite.Hide()
        discover.Hide()
        user_setting.Hide()
    End Sub

    Public Sub ReadFromDb(ByVal sql, ByRef pnl)
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader

        cmd.Connection = con
        cmd.CommandText = sql
        dr = cmd.ExecuteReader()
        Dim x As Integer = 5
        Dim y As Integer = 3
        Dim elem = 0
        While dr.Read
            elem += 1
            Dim pic As New PictureBox
            pic.Size = New Point(150, 210)
            pic.Name = "pic_box-" & (count + 1)
            pic.Location = New Point(x, y)
            pic.SizeMode = PictureBoxSizeMode.Zoom
            Dim movie_id = dr("movie_id")
            Dim movie_pic = dr("display_picture")
            Dim movie_name = dr("movie_name")
            Dim movie_rating = dr("rating")
            Dim movie_released = dr("released")
            Dim movie_desc = dr("movie_description")
            Dim movie_file = dr("movie_file")
            pic.Image = Image.FromFile(movie_pic)
            AddHandler pic.Click, AddressOf Me.ShowDetails
            Dim val() As String = {movie_pic, movie_name, movie_released, movie_rating, movie_desc, movie_file, movie_id}
            pic.Tag = val

            pnl.Controls.Add(pic)
            x += 195
            count += 1
            If elem = 5 Then
                x = 5
                y = 250
            End If
        End While

        dr.Close()
    End Sub
    Public Sub GetOtherDetails(ByVal movie_id)
        clickedMovie = movie_id
        Dim sql_genre = "select genre_name from genre where movie_id = '" + movie_id + "'"
        Dim sql_director = "select director_name from director where movie_id = '" + movie_id + "'"
        Dim sql_actor = "select star_name from actor where movie_id = '" + movie_id + "'"
        genre = ""
        director = ""
        stars = ""
        Storeinvar(sql_genre, "genre_name", genre)
        Storeinvar(sql_director, "director_name", director)
        Storeinvar(sql_actor, "star_name", stars)


    End Sub
    Public Sub Storeinvar(ByVal sql, ByVal col_name, ByRef values)
        Dim command As New SqlCommand
        Dim dr As SqlDataReader
        command.Connection = con
        command.CommandText = sql
        dr = command.ExecuteReader()
        While dr.Read
            If values = String.Empty Then
                values = dr(col_name)
            Else
                values += " , " + dr(col_name)
            End If
        End While
        dr.Close()
    End Sub
    Public Sub ShowDetails(sender As Object, e As EventArgs)
        Dim picbox As PictureBox = CType(sender, PictureBox)
        Dim item() As String = picbox.Tag
        Show_box(item)
    End Sub
    Public Sub Show_box(ByRef details)

        picture.Image = Image.FromFile(details(0))
        mve_name.Text = details(1)
        rel_yr.Text = details(2)
        rat.Text = details(3)
        mve_details.Text = details(4)
        file = details(5)
        GetOtherDetails(details(6))
        mve_genre.Text = genre
        mve_directors.Text = director
        mve_stars.Text = stars
        Movie_info_pnl.Show()
        CheckCollection()

    End Sub
    Public Sub play_mve_Click(sender As Object, e As EventArgs) Handles play_mve.Click

        move_player.Show()
        Dim st = file
        move_player.pa.playlist.add("file:///" & st)
        Dim query = "insert into history(user_id,movie_id) values(@uid,@mid)"
        Savetohistory(query)
        updateTimeAndDate()
        pic_history.Controls.Clear()
        Dim sql_history = "SELECT * from allmovie where movie_id in(SELECT movie_id from history where history.user_id = '" + Userid + "'  ) "
        ReadFromDb(sql_history, pic_history)
        Me.WindowState = FormWindowState.Minimized

    End Sub
    Private Sub updateTimeAndDate()
        Dim dt As Date = Date.Today.ToString("dd'/'MM'/'yyyy")
        dt = Format(dt, "MM/dd/yyyy")


        Dim dr As SqlDataReader
        Dim getTimes = "Select watched_time from history where user_id  = '" + Userid + "' and movie_id = '" + clickedMovie + "'"
        Dim times = 1
        Dim cmd As New SqlCommand With {
            .Connection = con,
            .CommandText = getTimes
        }

        dr = cmd.ExecuteReader()
        If dr.Read() Then
            Dim Value = IsDBNull(dr("watched_time"))
            If Value Then
                times = 1
            Else
                times = Int(times + dr("watched_time"))
            End If



        End If

        dr.Close()


        Dim update = "Update history set watched_time =" & times & " ,watched  = '" & dt & "' where user_id  = '" + Userid + "' and movie_id = '" + clickedMovie + "'"
        Dim comm As New SqlCommand With {
            .Connection = con,
            .CommandText = update
        }
        comm.ExecuteNonQuery()
    End Sub
    Private Sub Savetohistory(ByVal query)
        Dim command As New SqlCommand
        Dim da As New SqlDataAdapter
        command.Connection = con
        command.CommandText = query
        da.InsertCommand = command
        Dim param_mid As New SqlParameter("@uid", SqlDbType.VarChar, 10)
        param_mid.Value = Userid
        Dim param_name As New SqlParameter("@mid", SqlDbType.VarChar, 50)
        param_name.Value = clickedMovie

        command.Parameters.Add(param_mid)
        command.Parameters.Add(param_name)
        da.InsertCommand = command
        Try
            da.InsertCommand.ExecuteNonQuery()
        Catch ex As Exception
            Dim q = "update history set watched_time = watched_time + 1 where user_id = '" + Userid + "' and movie_id = '" + clickedMovie + "'"
            command.CommandText = q
            command.ExecuteNonQuery()
        End Try

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles info_btn.Click
        If Movie_info_pnl.Dock = DockStyle.Right Then
            Movie_info_pnl.Dock = DockStyle.Fill
            Home.Hide()
            info_btn.Text = "Show Less"
            more_movie_info_pnl.Visible = True
        Else
            Movie_info_pnl.Dock = DockStyle.Right
            Home.Show()
            info_btn.Text = "Show More"
            more_movie_info_pnl.Visible = False

        End If

    End Sub
    Private Sub CheckCollection()
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader

        cmd.Connection = con
        cmd.CommandText = "select * from favourite_movies where  user_id = '" + Userid + "'  AND movie_id ='" + clickedMovie + "'"
        dr = cmd.ExecuteReader()
        If dr.Read Then
            PictureBox3.Image = Image.FromFile("C:\Users\HASEEF\source\repos\login_page\login_page\Resources\icons8-checked-48.png")
            PictureBox3.Tag = 1
        Else
            PictureBox3.Image = Image.FromFile("C:\Users\HASEEF\source\repos\login_page\login_page\Resources\icons8-plus-48.png")
            PictureBox3.Tag = 0
        End If

        dr.Close()
    End Sub

    Private Sub close_pnl_Click_1(sender As Object, e As EventArgs) Handles close_pnl.Click
        Movie_info_pnl.Visible = False
        Home.Show()
        CheckCollection()
    End Sub
    Private Sub Add(ByRef pnl, ByRef Addhere)

        pnl.TopLevel = False
        pnl.TopMost = True
        pnl.FormBorderStyle = FormBorderStyle.None
        pnl.Dock = DockStyle.Fill
        Addhere.Controls.Add(pnl)
        Addhere.AutoScroll = True
        pnl.BringToFront()
        pnl.Show()
    End Sub

    Private Sub add_btn_Click(sender As Object, e As EventArgs) Handles Home_btn.Click
        ShowPanel(collection_panel)
        ClickedButton(Home_btn)
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles trending_btn.Click
        HideAllPanel()
        Add(trending, Home)
        ClickedButton(trending_btn)

    End Sub
    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles History_btn.Click
        collection_panel.Controls.Remove(history)
        HideAllPanel()
        userhistory.Userhisitory_Load(sender, e)
        Add(userhistory, Home)
        userhistory.CheckIfUserStore(userhistory.pic_his, userhistory.emptylab1, userhistory.emptylab2)
        ClickedButton(History_btn)
    End Sub
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        If PictureBox3.Tag = 0 Then
            Timer1.Start()
            PictureBox3.Image = Image.FromFile("C:\Users\HASEEF\source\repos\login_page\login_page\Resources\icons8-plus.gif")
            Dim query = "insert into favourite_movies(user_id,movie_id) values(@uid,@mid)"
            Savetohistory(query)
            PictureBox3.Tag = 1
        Else
            MsgBox("Already Bookmarked")
        End If
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        PictureBox3.Image = Image.FromFile("C:\Users\HASEEF\source\repos\login_page\login_page\Resources\icons8-checked-48.png")
        Timer1.Stop()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Collection_btn.Click
        HideAllPanel()
        favourite.favourite_Load(sender, e)
        Add(favourite, Home)
        ' userhistory.CheckIfUserStore(favourite.pic_fav)
        ClickedButton(Collection_btn)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Discover_btn.Click
        HideAllPanel()
        Add(discover, Home)
        ClickedButton(Discover_btn)
    End Sub

    Private Sub Button1_Click_3(sender As Object, e As EventArgs) Handles More_btn.Click
        If Panel_morefunction.Visible = False Then
            Panel_morefunction.Visible = True
        Else
            Panel_morefunction.Visible = False
        End If
        ClickedButton(More_btn)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        HideAllPanel()
        Add(user_setting, Home)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Hide()
        login_page.Show()
        login_page.WindowState = FormWindowState.Normal
    End Sub
    Public Function Select_user()
        Dim q = "select * from valid_user where username = '" + Me.Userid + "'"
        Dim com As New SqlCommand With {
            .Connection = con,
            .CommandText = q}
        Dim dr = com.ExecuteReader

        Return dr
    End Function
    Public Sub Setuserdp()
        Userid = user.Text
        Dim dr = Select_user()
        While dr.read
            PictureBox2.Image = Image.FromFile(dr("profile_pic"))
        End While
        dr.close()
    End Sub

    'UI Design
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
    Private Sub ClickedButton(ByRef btn)
        StandardBtn()
        btn.backcolor = Color.FromArgb(11, 20, 150)
    End Sub
    Private Sub StandardBtn()
        Home_btn.BackColor = Color.FromArgb(11, 17, 37)
        trending_btn.BackColor = Color.FromArgb(11, 17, 37)
        Discover_btn.BackColor = Color.FromArgb(11, 17, 37)
        Collection_btn.BackColor = Color.FromArgb(11, 17, 37)
        History_btn.BackColor = Color.FromArgb(11, 17, 37)
        More_btn.BackColor = Color.FromArgb(11, 17, 37)

    End Sub

End Class