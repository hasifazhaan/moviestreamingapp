<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class admin_page
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(admin_page))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LogOut = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Del_Movie = New System.Windows.Forms.Button()
        Me.add_btn = New System.Windows.Forms.Button()
        Me.logo = New System.Windows.Forms.PictureBox()
        Me.Panel_add_movie = New System.Windows.Forms.Panel()
        Me.result_panel = New System.Windows.Forms.Panel()
        Me.result = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.mve_dur = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.m_id = New System.Windows.Forms.TextBox()
        Me.m_genre = New System.Windows.Forms.TextBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.m_cast = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.m_director = New System.Windows.Forms.TextBox()
        Me.display_dp_file = New System.Windows.Forms.TextBox()
        Me.display_vid_file = New System.Windows.Forms.TextBox()
        Me.SelectDp = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.released_year = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.add_todatabase_movie = New System.Windows.Forms.Button()
        Me.Panel_genre = New System.Windows.Forms.Panel()
        Me.Panel_star = New System.Windows.Forms.Panel()
        Me.selectMovieFile = New System.Windows.Forms.Button()
        Me.Panel_director = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.m_desc = New System.Windows.Forms.RichTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Rating_1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.m_name = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DeleteMovie_panel = New System.Windows.Forms.Panel()
        Me.Selectdeletemovie = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.res_invalid = New System.Windows.Forms.Panel()
        Me.hide_pnl = New System.Windows.Forms.Button()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Movie_detail_panel = New System.Windows.Forms.Panel()
        Me.movie_ratings_todelete = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.movie_year_todelete = New System.Windows.Forms.Label()
        Me.movie_gen_todelete = New System.Windows.Forms.Label()
        Me.movie_dir_todelete = New System.Windows.Forms.Label()
        Me.movie_name_todelete = New System.Windows.Forms.Label()
        Me.DeleteMovie = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.movie_pic_todelete = New System.Windows.Forms.PictureBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.SearchButton = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Minimise = New System.Windows.Forms.Button()
        Me.buttonExit = New System.Windows.Forms.Button()
        Me.OpenFileDialog2 = New System.Windows.Forms.OpenFileDialog()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Max_button = New System.Windows.Forms.PictureBox()
        Me.Mini_button = New System.Windows.Forms.PictureBox()
        Me.Exit_button = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_add_movie.SuspendLayout()
        Me.result_panel.SuspendLayout()
        Me.DeleteMovie_panel.SuspendLayout()
        Me.res_invalid.SuspendLayout()
        Me.Movie_detail_panel.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.movie_pic_todelete, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.Max_button, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Mini_button, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Exit_button, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.Panel1.Controls.Add(Me.LogOut)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Del_Movie)
        Me.Panel1.Controls.Add(Me.add_btn)
        Me.Panel1.Controls.Add(Me.logo)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(227, 1080)
        Me.Panel1.TabIndex = 0
        '
        'LogOut
        '
        Me.LogOut.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.LogOut.Dock = System.Windows.Forms.DockStyle.Top
        Me.LogOut.FlatAppearance.BorderSize = 0
        Me.LogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LogOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogOut.ForeColor = System.Drawing.SystemColors.Control
        Me.LogOut.Location = New System.Drawing.Point(0, 370)
        Me.LogOut.Name = "LogOut"
        Me.LogOut.Size = New System.Drawing.Size(227, 76)
        Me.LogOut.TabIndex = 23
        Me.LogOut.Text = "Log Out"
        Me.LogOut.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.Control
        Me.Button2.Location = New System.Drawing.Point(0, 294)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(227, 76)
        Me.Button2.TabIndex = 22
        Me.Button2.Text = "Analyse"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Del_Movie
        '
        Me.Del_Movie.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Del_Movie.Dock = System.Windows.Forms.DockStyle.Top
        Me.Del_Movie.FlatAppearance.BorderSize = 0
        Me.Del_Movie.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Del_Movie.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Del_Movie.ForeColor = System.Drawing.SystemColors.Control
        Me.Del_Movie.Location = New System.Drawing.Point(0, 218)
        Me.Del_Movie.Name = "Del_Movie"
        Me.Del_Movie.Size = New System.Drawing.Size(227, 76)
        Me.Del_Movie.TabIndex = 21
        Me.Del_Movie.Text = "Delete Movie"
        Me.Del_Movie.UseVisualStyleBackColor = False
        '
        'add_btn
        '
        Me.add_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.add_btn.Dock = System.Windows.Forms.DockStyle.Top
        Me.add_btn.FlatAppearance.BorderSize = 0
        Me.add_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.add_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.add_btn.ForeColor = System.Drawing.SystemColors.Control
        Me.add_btn.Location = New System.Drawing.Point(0, 142)
        Me.add_btn.Name = "add_btn"
        Me.add_btn.Size = New System.Drawing.Size(227, 76)
        Me.add_btn.TabIndex = 20
        Me.add_btn.Text = "Add Movie"
        Me.add_btn.UseVisualStyleBackColor = False
        '
        'logo
        '
        Me.logo.Dock = System.Windows.Forms.DockStyle.Top
        Me.logo.Image = CType(resources.GetObject("logo.Image"), System.Drawing.Image)
        Me.logo.Location = New System.Drawing.Point(0, 0)
        Me.logo.Name = "logo"
        Me.logo.Size = New System.Drawing.Size(227, 142)
        Me.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.logo.TabIndex = 2
        Me.logo.TabStop = False
        '
        'Panel_add_movie
        '
        Me.Panel_add_movie.AutoScroll = True
        Me.Panel_add_movie.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Panel_add_movie.Controls.Add(Me.result_panel)
        Me.Panel_add_movie.Controls.Add(Me.mve_dur)
        Me.Panel_add_movie.Controls.Add(Me.Label23)
        Me.Panel_add_movie.Controls.Add(Me.Label18)
        Me.Panel_add_movie.Controls.Add(Me.Button6)
        Me.Panel_add_movie.Controls.Add(Me.Label1)
        Me.Panel_add_movie.Controls.Add(Me.m_id)
        Me.Panel_add_movie.Controls.Add(Me.m_genre)
        Me.Panel_add_movie.Controls.Add(Me.Button5)
        Me.Panel_add_movie.Controls.Add(Me.m_cast)
        Me.Panel_add_movie.Controls.Add(Me.Button3)
        Me.Panel_add_movie.Controls.Add(Me.m_director)
        Me.Panel_add_movie.Controls.Add(Me.display_dp_file)
        Me.Panel_add_movie.Controls.Add(Me.display_vid_file)
        Me.Panel_add_movie.Controls.Add(Me.SelectDp)
        Me.Panel_add_movie.Controls.Add(Me.Label16)
        Me.Panel_add_movie.Controls.Add(Me.released_year)
        Me.Panel_add_movie.Controls.Add(Me.Label15)
        Me.Panel_add_movie.Controls.Add(Me.add_todatabase_movie)
        Me.Panel_add_movie.Controls.Add(Me.Panel_genre)
        Me.Panel_add_movie.Controls.Add(Me.Panel_star)
        Me.Panel_add_movie.Controls.Add(Me.selectMovieFile)
        Me.Panel_add_movie.Controls.Add(Me.Panel_director)
        Me.Panel_add_movie.Controls.Add(Me.Label8)
        Me.Panel_add_movie.Controls.Add(Me.m_desc)
        Me.Panel_add_movie.Controls.Add(Me.Label7)
        Me.Panel_add_movie.Controls.Add(Me.Label6)
        Me.Panel_add_movie.Controls.Add(Me.Label5)
        Me.Panel_add_movie.Controls.Add(Me.Label4)
        Me.Panel_add_movie.Controls.Add(Me.Rating_1)
        Me.Panel_add_movie.Controls.Add(Me.Label3)
        Me.Panel_add_movie.Controls.Add(Me.m_name)
        Me.Panel_add_movie.Controls.Add(Me.Label2)
        Me.Panel_add_movie.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel_add_movie.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Panel_add_movie.Location = New System.Drawing.Point(0, 0)
        Me.Panel_add_movie.Name = "Panel_add_movie"
        Me.Panel_add_movie.Size = New System.Drawing.Size(1311, 1039)
        Me.Panel_add_movie.TabIndex = 4
        Me.Panel_add_movie.Visible = False
        '
        'result_panel
        '
        Me.result_panel.AutoScroll = True
        Me.result_panel.Controls.Add(Me.result)
        Me.result_panel.Controls.Add(Me.Button4)
        Me.result_panel.Location = New System.Drawing.Point(521, 393)
        Me.result_panel.Name = "result_panel"
        Me.result_panel.Size = New System.Drawing.Size(329, 256)
        Me.result_panel.TabIndex = 44
        Me.result_panel.Visible = False
        '
        'result
        '
        Me.result.AutoSize = True
        Me.result.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.result.ForeColor = System.Drawing.SystemColors.Control
        Me.result.Location = New System.Drawing.Point(54, 69)
        Me.result.Name = "result"
        Me.result.Size = New System.Drawing.Size(233, 29)
        Me.result.TabIndex = 1
        Me.result.Text = "Inserted  Sucessfully"
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Button4.FlatAppearance.BorderSize = 2
        Me.Button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button4.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.Button4.Location = New System.Drawing.Point(126, 191)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 0
        Me.Button4.Text = "OK"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'mve_dur
        '
        Me.mve_dur.Location = New System.Drawing.Point(241, 317)
        Me.mve_dur.Name = "mve_dur"
        Me.mve_dur.Size = New System.Drawing.Size(205, 22)
        Me.mve_dur.TabIndex = 55
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(98, 279)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(209, 25)
        Me.Label23.TabIndex = 54
        Me.Label23.Text = "Movie Duration(in Min)"
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.Label18.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label18.Location = New System.Drawing.Point(0, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(1430, 35)
        Me.Label18.TabIndex = 53
        Me.Label18.Text = "Add Movies"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button6
        '
        Me.Button6.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.ForeColor = System.Drawing.Color.Lime
        Me.Button6.Location = New System.Drawing.Point(885, 318)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(27, 27)
        Me.Button6.TabIndex = 52
        Me.Button6.Text = "✔"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(99, 127)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Movie Id"
        '
        'm_id
        '
        Me.m_id.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.m_id.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.m_id.Location = New System.Drawing.Point(234, 129)
        Me.m_id.Name = "m_id"
        Me.m_id.ReadOnly = True
        Me.m_id.Size = New System.Drawing.Size(205, 15)
        Me.m_id.TabIndex = 1
        '
        'm_genre
        '
        Me.m_genre.Location = New System.Drawing.Point(707, 324)
        Me.m_genre.Name = "m_genre"
        Me.m_genre.Size = New System.Drawing.Size(160, 22)
        Me.m_genre.TabIndex = 51
        '
        'Button5
        '
        Me.Button5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.ForeColor = System.Drawing.Color.Lime
        Me.Button5.Location = New System.Drawing.Point(1208, 81)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(27, 27)
        Me.Button5.TabIndex = 50
        Me.Button5.Text = "✔"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'm_cast
        '
        Me.m_cast.Location = New System.Drawing.Point(1030, 82)
        Me.m_cast.Name = "m_cast"
        Me.m_cast.Size = New System.Drawing.Size(160, 22)
        Me.m_cast.TabIndex = 49
        '
        'Button3
        '
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.ForeColor = System.Drawing.Color.Lime
        Me.Button3.Location = New System.Drawing.Point(850, 79)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(27, 27)
        Me.Button3.TabIndex = 48
        Me.Button3.Text = "✔"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'm_director
        '
        Me.m_director.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.m_director.Location = New System.Drawing.Point(672, 80)
        Me.m_director.Name = "m_director"
        Me.m_director.Size = New System.Drawing.Size(160, 22)
        Me.m_director.TabIndex = 47
        '
        'display_dp_file
        '
        Me.display_dp_file.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.display_dp_file.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.display_dp_file.Cursor = System.Windows.Forms.Cursors.No
        Me.display_dp_file.Location = New System.Drawing.Point(114, 552)
        Me.display_dp_file.Name = "display_dp_file"
        Me.display_dp_file.ReadOnly = True
        Me.display_dp_file.Size = New System.Drawing.Size(369, 15)
        Me.display_dp_file.TabIndex = 46
        Me.display_dp_file.Visible = False
        '
        'display_vid_file
        '
        Me.display_vid_file.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.display_vid_file.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.display_vid_file.Cursor = System.Windows.Forms.Cursors.No
        Me.display_vid_file.Location = New System.Drawing.Point(114, 433)
        Me.display_vid_file.Name = "display_vid_file"
        Me.display_vid_file.ReadOnly = True
        Me.display_vid_file.Size = New System.Drawing.Size(363, 15)
        Me.display_vid_file.TabIndex = 45
        Me.display_vid_file.Visible = False
        '
        'SelectDp
        '
        Me.SelectDp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SelectDp.Location = New System.Drawing.Point(326, 474)
        Me.SelectDp.Name = "SelectDp"
        Me.SelectDp.Size = New System.Drawing.Size(151, 56)
        Me.SelectDp.TabIndex = 27
        Me.SelectDp.Text = "Select"
        Me.SelectDp.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(109, 474)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(196, 25)
        Me.Label16.TabIndex = 26
        Me.Label16.Text = "Picture To Be Shown"
        '
        'released_year
        '
        Me.released_year.Location = New System.Drawing.Point(241, 242)
        Me.released_year.Name = "released_year"
        Me.released_year.Size = New System.Drawing.Size(205, 22)
        Me.released_year.TabIndex = 25
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(98, 238)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(140, 25)
        Me.Label15.TabIndex = 24
        Me.Label15.Text = "Released Year"
        '
        'add_todatabase_movie
        '
        Me.add_todatabase_movie.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.add_todatabase_movie.Location = New System.Drawing.Point(17, 908)
        Me.add_todatabase_movie.Name = "add_todatabase_movie"
        Me.add_todatabase_movie.Size = New System.Drawing.Size(1413, 56)
        Me.add_todatabase_movie.TabIndex = 22
        Me.add_todatabase_movie.Text = "Add "
        Me.add_todatabase_movie.UseVisualStyleBackColor = True
        '
        'Panel_genre
        '
        Me.Panel_genre.AutoScroll = True
        Me.Panel_genre.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Panel_genre.Location = New System.Drawing.Point(579, 380)
        Me.Panel_genre.Name = "Panel_genre"
        Me.Panel_genre.Size = New System.Drawing.Size(333, 105)
        Me.Panel_genre.TabIndex = 23
        '
        'Panel_star
        '
        Me.Panel_star.AutoScroll = True
        Me.Panel_star.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Panel_star.Location = New System.Drawing.Point(935, 128)
        Me.Panel_star.Name = "Panel_star"
        Me.Panel_star.Size = New System.Drawing.Size(300, 105)
        Me.Panel_star.TabIndex = 22
        '
        'selectMovieFile
        '
        Me.selectMovieFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.selectMovieFile.Location = New System.Drawing.Point(326, 355)
        Me.selectMovieFile.Name = "selectMovieFile"
        Me.selectMovieFile.Size = New System.Drawing.Size(151, 56)
        Me.selectMovieFile.TabIndex = 21
        Me.selectMovieFile.Text = "Upload File"
        Me.selectMovieFile.UseVisualStyleBackColor = True
        '
        'Panel_director
        '
        Me.Panel_director.AutoScroll = True
        Me.Panel_director.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Panel_director.Location = New System.Drawing.Point(583, 127)
        Me.Panel_director.Name = "Panel_director"
        Me.Panel_director.Size = New System.Drawing.Size(300, 105)
        Me.Panel_director.TabIndex = 19
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(100, 368)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(199, 25)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Select File To Upload"
        '
        'm_desc
        '
        Me.m_desc.Location = New System.Drawing.Point(104, 645)
        Me.m_desc.Name = "m_desc"
        Me.m_desc.Size = New System.Drawing.Size(1173, 241)
        Me.m_desc.TabIndex = 13
        Me.m_desc.Text = ""
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(99, 607)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(167, 25)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Movie Description"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(930, 79)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(94, 25)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Star Cast"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(578, 320)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 25)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Genre"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(574, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 25)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Director"
        '
        'Rating_1
        '
        Me.Rating_1.Location = New System.Drawing.Point(237, 189)
        Me.Rating_1.Name = "Rating_1"
        Me.Rating_1.Size = New System.Drawing.Size(205, 22)
        Me.Rating_1.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(100, 185)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 25)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Rating"
        '
        'm_name
        '
        Me.m_name.Location = New System.Drawing.Point(234, 75)
        Me.m_name.Name = "m_name"
        Me.m_name.Size = New System.Drawing.Size(205, 22)
        Me.m_name.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(99, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Movie Name"
        '
        'DeleteMovie_panel
        '
        Me.DeleteMovie_panel.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.DeleteMovie_panel.Controls.Add(Me.Selectdeletemovie)
        Me.DeleteMovie_panel.Controls.Add(Me.res_invalid)
        Me.DeleteMovie_panel.Controls.Add(Me.Movie_detail_panel)
        Me.DeleteMovie_panel.Controls.Add(Me.SearchButton)
        Me.DeleteMovie_panel.Controls.Add(Me.Label11)
        Me.DeleteMovie_panel.Controls.Add(Me.Label9)
        Me.DeleteMovie_panel.Dock = System.Windows.Forms.DockStyle.Left
        Me.DeleteMovie_panel.Location = New System.Drawing.Point(1311, 0)
        Me.DeleteMovie_panel.Name = "DeleteMovie_panel"
        Me.DeleteMovie_panel.Size = New System.Drawing.Size(1031, 1039)
        Me.DeleteMovie_panel.TabIndex = 54
        Me.DeleteMovie_panel.Visible = False
        '
        'Selectdeletemovie
        '
        Me.Selectdeletemovie.Animated = True
        Me.Selectdeletemovie.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Selectdeletemovie.BorderColor = System.Drawing.Color.Transparent
        Me.Selectdeletemovie.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.Selectdeletemovie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Selectdeletemovie.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.Selectdeletemovie.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Selectdeletemovie.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Selectdeletemovie.FocusedState.Parent = Me.Selectdeletemovie
        Me.Selectdeletemovie.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Selectdeletemovie.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Selectdeletemovie.HoverState.Parent = Me.Selectdeletemovie
        Me.Selectdeletemovie.ItemHeight = 30
        Me.Selectdeletemovie.ItemsAppearance.Parent = Me.Selectdeletemovie
        Me.Selectdeletemovie.Location = New System.Drawing.Point(223, 223)
        Me.Selectdeletemovie.Name = "Selectdeletemovie"
        Me.Selectdeletemovie.ShadowDecoration.Parent = Me.Selectdeletemovie
        Me.Selectdeletemovie.Size = New System.Drawing.Size(294, 36)
        Me.Selectdeletemovie.TabIndex = 60
        '
        'res_invalid
        '
        Me.res_invalid.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.res_invalid.Controls.Add(Me.hide_pnl)
        Me.res_invalid.Controls.Add(Me.RichTextBox1)
        Me.res_invalid.Controls.Add(Me.Label22)
        Me.res_invalid.Controls.Add(Me.Label20)
        Me.res_invalid.Location = New System.Drawing.Point(191, 317)
        Me.res_invalid.Name = "res_invalid"
        Me.res_invalid.Size = New System.Drawing.Size(739, 352)
        Me.res_invalid.TabIndex = 59
        Me.res_invalid.Visible = False
        '
        'hide_pnl
        '
        Me.hide_pnl.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.hide_pnl.FlatAppearance.BorderSize = 2
        Me.hide_pnl.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.hide_pnl.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.hide_pnl.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.hide_pnl.Location = New System.Drawing.Point(277, 263)
        Me.hide_pnl.Name = "hide_pnl"
        Me.hide_pnl.Size = New System.Drawing.Size(145, 50)
        Me.hide_pnl.TabIndex = 60
        Me.hide_pnl.Text = "OK"
        Me.hide_pnl.UseVisualStyleBackColor = False
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.RichTextBox1.Cursor = System.Windows.Forms.Cursors.Default
        Me.RichTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.ForeColor = System.Drawing.SystemColors.Window
        Me.RichTextBox1.Location = New System.Drawing.Point(59, 116)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(573, 117)
        Me.RichTextBox1.TabIndex = 59
        Me.RichTextBox1.Text = "Movie You Are Searching For Is Either Invalid Or Deleted" & Global.Microsoft.VisualBasic.ChrW(10) & "Please Try With Differen" &
    "t Id "
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(84, 157)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(0, 25)
        Me.Label22.TabIndex = 58
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(256, 68)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(146, 25)
        Me.Label20.TabIndex = 57
        Me.Label20.Text = "Invalid Movie id"
        '
        'Movie_detail_panel
        '
        Me.Movie_detail_panel.AutoScroll = True
        Me.Movie_detail_panel.AutoSize = True
        Me.Movie_detail_panel.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Movie_detail_panel.Controls.Add(Me.movie_ratings_todelete)
        Me.Movie_detail_panel.Controls.Add(Me.Label21)
        Me.Movie_detail_panel.Controls.Add(Me.movie_year_todelete)
        Me.Movie_detail_panel.Controls.Add(Me.movie_gen_todelete)
        Me.Movie_detail_panel.Controls.Add(Me.movie_dir_todelete)
        Me.Movie_detail_panel.Controls.Add(Me.movie_name_todelete)
        Me.Movie_detail_panel.Controls.Add(Me.DeleteMovie)
        Me.Movie_detail_panel.Controls.Add(Me.Panel5)
        Me.Movie_detail_panel.Controls.Add(Me.Label19)
        Me.Movie_detail_panel.Controls.Add(Me.Label14)
        Me.Movie_detail_panel.Controls.Add(Me.Label13)
        Me.Movie_detail_panel.Controls.Add(Me.Label12)
        Me.Movie_detail_panel.Controls.Add(Me.Label10)
        Me.Movie_detail_panel.Dock = System.Windows.Forms.DockStyle.Right
        Me.Movie_detail_panel.Location = New System.Drawing.Point(682, 35)
        Me.Movie_detail_panel.Name = "Movie_detail_panel"
        Me.Movie_detail_panel.Size = New System.Drawing.Size(349, 1004)
        Me.Movie_detail_panel.TabIndex = 58
        Me.Movie_detail_panel.Visible = False
        '
        'movie_ratings_todelete
        '
        Me.movie_ratings_todelete.AutoSize = True
        Me.movie_ratings_todelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.movie_ratings_todelete.Location = New System.Drawing.Point(224, 638)
        Me.movie_ratings_todelete.Name = "movie_ratings_todelete"
        Me.movie_ratings_todelete.Size = New System.Drawing.Size(77, 25)
        Me.movie_ratings_todelete.TabIndex = 67
        Me.movie_ratings_todelete.Text = "Ratings"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(69, 638)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(77, 25)
        Me.Label21.TabIndex = 66
        Me.Label21.Text = "Ratings"
        '
        'movie_year_todelete
        '
        Me.movie_year_todelete.AutoSize = True
        Me.movie_year_todelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.movie_year_todelete.Location = New System.Drawing.Point(224, 550)
        Me.movie_year_todelete.Name = "movie_year_todelete"
        Me.movie_year_todelete.Size = New System.Drawing.Size(77, 25)
        Me.movie_year_todelete.TabIndex = 65
        Me.movie_year_todelete.Text = "Cast(s)"
        '
        'movie_gen_todelete
        '
        Me.movie_gen_todelete.AutoSize = True
        Me.movie_gen_todelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.movie_gen_todelete.Location = New System.Drawing.Point(224, 460)
        Me.movie_gen_todelete.Name = "movie_gen_todelete"
        Me.movie_gen_todelete.Size = New System.Drawing.Size(90, 25)
        Me.movie_gen_todelete.TabIndex = 64
        Me.movie_gen_todelete.Text = "Genre(s)"
        '
        'movie_dir_todelete
        '
        Me.movie_dir_todelete.AutoSize = True
        Me.movie_dir_todelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.movie_dir_todelete.Location = New System.Drawing.Point(224, 379)
        Me.movie_dir_todelete.Name = "movie_dir_todelete"
        Me.movie_dir_todelete.Size = New System.Drawing.Size(103, 25)
        Me.movie_dir_todelete.TabIndex = 63
        Me.movie_dir_todelete.Text = "Director(s)"
        '
        'movie_name_todelete
        '
        Me.movie_name_todelete.AutoSize = True
        Me.movie_name_todelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.movie_name_todelete.Location = New System.Drawing.Point(224, 291)
        Me.movie_name_todelete.Name = "movie_name_todelete"
        Me.movie_name_todelete.Size = New System.Drawing.Size(122, 25)
        Me.movie_name_todelete.TabIndex = 62
        Me.movie_name_todelete.Text = "Movie Name"
        '
        'DeleteMovie
        '
        Me.DeleteMovie.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DeleteMovie.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DeleteMovie.Location = New System.Drawing.Point(0, 935)
        Me.DeleteMovie.Name = "DeleteMovie"
        Me.DeleteMovie.Size = New System.Drawing.Size(349, 69)
        Me.DeleteMovie.TabIndex = 61
        Me.DeleteMovie.Text = "Delete"
        Me.DeleteMovie.UseVisualStyleBackColor = True
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.movie_pic_todelete)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 47)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(349, 229)
        Me.Panel5.TabIndex = 60
        '
        'movie_pic_todelete
        '
        Me.movie_pic_todelete.Dock = System.Windows.Forms.DockStyle.Fill
        Me.movie_pic_todelete.Image = CType(resources.GetObject("movie_pic_todelete.Image"), System.Drawing.Image)
        Me.movie_pic_todelete.Location = New System.Drawing.Point(0, 0)
        Me.movie_pic_todelete.Name = "movie_pic_todelete"
        Me.movie_pic_todelete.Size = New System.Drawing.Size(349, 229)
        Me.movie_pic_todelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.movie_pic_todelete.TabIndex = 0
        Me.movie_pic_todelete.TabStop = False
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(69, 556)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(53, 25)
        Me.Label19.TabIndex = 59
        Me.Label19.Text = "Year"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(67, 468)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(90, 25)
        Me.Label14.TabIndex = 58
        Me.Label14.Text = "Genre(s)"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(69, 379)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(103, 25)
        Me.Label13.TabIndex = 57
        Me.Label13.Text = "Director(s)"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(67, 291)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(122, 25)
        Me.Label12.TabIndex = 56
        Me.Label12.Text = "Movie Name"
        '
        'Label10
        '
        Me.Label10.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label10.Location = New System.Drawing.Point(0, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(349, 47)
        Me.Label10.TabIndex = 55
        Me.Label10.Text = "Movie Details"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SearchButton
        '
        Me.SearchButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.SearchButton.FlatAppearance.BorderSize = 2
        Me.SearchButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.SearchButton.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.SearchButton.Location = New System.Drawing.Point(321, 279)
        Me.SearchButton.Name = "SearchButton"
        Me.SearchButton.Size = New System.Drawing.Size(145, 50)
        Me.SearchButton.TabIndex = 57
        Me.SearchButton.Text = "OK"
        Me.SearchButton.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(131, 234)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(86, 25)
        Me.Label11.TabIndex = 55
        Me.Label11.Text = "Movie Id"
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label9.Location = New System.Drawing.Point(0, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(1031, 35)
        Me.Label9.TabIndex = 54
        Me.Label9.Text = "Delete Movies"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Minimise
        '
        Me.Minimise.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.Minimise.AutoSize = True
        Me.Minimise.FlatAppearance.BorderSize = 0
        Me.Minimise.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Minimise.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Minimise.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Minimise.Location = New System.Drawing.Point(1590, 0)
        Me.Minimise.Name = "Minimise"
        Me.Minimise.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Minimise.Size = New System.Drawing.Size(48, 41)
        Me.Minimise.TabIndex = 26
        Me.Minimise.Text = "-"
        Me.Minimise.UseVisualStyleBackColor = True
        '
        'buttonExit
        '
        Me.buttonExit.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.buttonExit.AutoSize = True
        Me.buttonExit.FlatAppearance.BorderSize = 0
        Me.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.buttonExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonExit.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.buttonExit.Location = New System.Drawing.Point(1644, 0)
        Me.buttonExit.Name = "buttonExit"
        Me.buttonExit.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.buttonExit.Size = New System.Drawing.Size(57, 41)
        Me.buttonExit.TabIndex = 25
        Me.buttonExit.Text = "X"
        Me.buttonExit.UseVisualStyleBackColor = True
        '
        'OpenFileDialog2
        '
        Me.OpenFileDialog2.FileName = "OpenFileDialog1"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label17)
        Me.Panel2.Controls.Add(Me.Max_button)
        Me.Panel2.Controls.Add(Me.Mini_button)
        Me.Panel2.Controls.Add(Me.Exit_button)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(227, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1563, 41)
        Me.Panel2.TabIndex = 27
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label17.Location = New System.Drawing.Point(279, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(1132, 35)
        Me.Label17.TabIndex = 27
        Me.Label17.Text = "Admin Page"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Max_button
        '
        Me.Max_button.Dock = System.Windows.Forms.DockStyle.Left
        Me.Max_button.Image = Global.login_page.My.Resources.Resources.Green
        Me.Max_button.Location = New System.Drawing.Point(48, 0)
        Me.Max_button.Name = "Max_button"
        Me.Max_button.Size = New System.Drawing.Size(24, 41)
        Me.Max_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Max_button.TabIndex = 25
        Me.Max_button.TabStop = False
        '
        'Mini_button
        '
        Me.Mini_button.Dock = System.Windows.Forms.DockStyle.Left
        Me.Mini_button.Image = CType(resources.GetObject("Mini_button.Image"), System.Drawing.Image)
        Me.Mini_button.Location = New System.Drawing.Point(24, 0)
        Me.Mini_button.Name = "Mini_button"
        Me.Mini_button.Size = New System.Drawing.Size(24, 41)
        Me.Mini_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Mini_button.TabIndex = 24
        Me.Mini_button.TabStop = False
        '
        'Exit_button
        '
        Me.Exit_button.Dock = System.Windows.Forms.DockStyle.Left
        Me.Exit_button.Image = CType(resources.GetObject("Exit_button.Image"), System.Drawing.Image)
        Me.Exit_button.Location = New System.Drawing.Point(0, 0)
        Me.Exit_button.Name = "Exit_button"
        Me.Exit_button.Size = New System.Drawing.Size(24, 41)
        Me.Exit_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Exit_button.TabIndex = 23
        Me.Exit_button.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.DeleteMovie_panel)
        Me.Panel3.Controls.Add(Me.Panel_add_movie)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(227, 41)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1563, 1039)
        Me.Panel3.TabIndex = 54
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 30
        Me.Guna2Elipse1.TargetControl = Me
        '
        'admin_page
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1790, 1080)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.buttonExit)
        Me.Controls.Add(Me.Minimise)
        Me.Controls.Add(Me.Panel1)
        Me.ForeColor = System.Drawing.Color.Silver
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(1790, 1080)
        Me.Name = "admin_page"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "admin_page"
        Me.Panel1.ResumeLayout(False)
        CType(Me.logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_add_movie.ResumeLayout(False)
        Me.Panel_add_movie.PerformLayout()
        Me.result_panel.ResumeLayout(False)
        Me.result_panel.PerformLayout()
        Me.DeleteMovie_panel.ResumeLayout(False)
        Me.DeleteMovie_panel.PerformLayout()
        Me.res_invalid.ResumeLayout(False)
        Me.res_invalid.PerformLayout()
        Me.Movie_detail_panel.ResumeLayout(False)
        Me.Movie_detail_panel.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        CType(Me.movie_pic_todelete, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.Max_button, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Mini_button, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Exit_button, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel_add_movie As Panel
    Friend WithEvents m_id As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Rating_1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents m_name As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents m_desc As RichTextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Panel_director As Panel
    Friend WithEvents Minimise As Button
    Friend WithEvents buttonExit As Button
    Friend WithEvents logo As PictureBox
    Friend WithEvents add_btn As Button
    Friend WithEvents selectMovieFile As Button
    Friend WithEvents Panel_genre As Panel
    Friend WithEvents Panel_star As Panel
    Friend WithEvents add_todatabase_movie As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Del_Movie As Button
    Friend WithEvents released_year As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents SelectDp As Button
    Friend WithEvents Label16 As Label
    Friend WithEvents result_panel As Panel
    Friend WithEvents result As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents OpenFileDialog2 As OpenFileDialog
    Friend WithEvents display_dp_file As TextBox
    Friend WithEvents display_vid_file As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Max_button As PictureBox
    Friend WithEvents Mini_button As PictureBox
    Friend WithEvents Exit_button As PictureBox
    Friend WithEvents Button6 As Button
    Friend WithEvents m_genre As TextBox
    Friend WithEvents Button5 As Button
    Friend WithEvents m_cast As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents m_director As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents DeleteMovie_panel As Panel
    Friend WithEvents Movie_detail_panel As Panel
    Friend WithEvents movie_year_todelete As Label
    Friend WithEvents movie_gen_todelete As Label
    Friend WithEvents movie_dir_todelete As Label
    Friend WithEvents movie_name_todelete As Label
    Friend WithEvents DeleteMovie As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents movie_pic_todelete As PictureBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents SearchButton As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents movie_ratings_todelete As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents res_invalid As Panel
    Friend WithEvents hide_pnl As Button
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Label23 As Label
    Friend WithEvents mve_dur As TextBox
    Friend WithEvents LogOut As Button
    Friend WithEvents Selectdeletemovie As Guna.UI2.WinForms.Guna2ComboBox
End Class
