<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class stats3
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(stats3))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Guna2CustomGradientPanel1 = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Viewtime_user = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Guna2CustomGradientPanel2 = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.mean_movie = New System.Windows.Forms.Label()
        Me.t_movies = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Avg_movieDur = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Guna2CustomGradientPanel7 = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.panel_score = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Recom_rates = New System.Windows.Forms.Label()
        Me.Times_Watched = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.M_Name = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.movie_pic = New System.Windows.Forms.PictureBox()
        Me.Selectmovie = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel2.SuspendLayout()
        Me.Guna2CustomGradientPanel1.SuspendLayout()
        CType(Me.Viewtime_user, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Guna2CustomGradientPanel2.SuspendLayout()
        Me.Guna2CustomGradientPanel7.SuspendLayout()
        Me.panel_score.SuspendLayout()
        CType(Me.movie_pic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1479, 84)
        Me.Panel1.TabIndex = 8
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Guna2CustomGradientPanel1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 636)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1479, 523)
        Me.Panel2.TabIndex = 9
        '
        'Guna2CustomGradientPanel1
        '
        Me.Guna2CustomGradientPanel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2CustomGradientPanel1.BorderRadius = 30
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.Label3)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.Viewtime_user)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.Label2)
        Me.Guna2CustomGradientPanel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Guna2CustomGradientPanel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.Guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.Guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.Guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.Guna2CustomGradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2CustomGradientPanel1.Name = "Guna2CustomGradientPanel1"
        Me.Guna2CustomGradientPanel1.ShadowDecoration.Parent = Me.Guna2CustomGradientPanel1
        Me.Guna2CustomGradientPanel1.Size = New System.Drawing.Size(1317, 523)
        Me.Guna2CustomGradientPanel1.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label3.Location = New System.Drawing.Point(115, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 25)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "In Minutes"
        '
        'Viewtime_user
        '
        Me.Viewtime_user.BackColor = System.Drawing.Color.Transparent
        Me.Viewtime_user.BorderlineColor = System.Drawing.SystemColors.ButtonShadow
        Me.Viewtime_user.BorderSkin.BorderColor = System.Drawing.Color.White
        ChartArea1.AxisX.InterlacedColor = System.Drawing.Color.White
        ChartArea1.AxisX.IsLabelAutoFit = False
        ChartArea1.AxisX.LabelStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White
        ChartArea1.AxisX.LineColor = System.Drawing.Color.White
        ChartArea1.AxisX.LineWidth = 2
        ChartArea1.AxisX.MajorGrid.Enabled = False
        ChartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.White
        ChartArea1.AxisX.MajorGrid.LineWidth = 0
        ChartArea1.AxisX.MajorTickMark.Enabled = False
        ChartArea1.AxisX.MajorTickMark.LineColor = System.Drawing.Color.White
        ChartArea1.AxisX.MinorGrid.LineColor = System.Drawing.Color.White
        ChartArea1.AxisX.MinorTickMark.LineColor = System.Drawing.Color.White
        ChartArea1.AxisX.TitleFont = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartArea1.AxisX.TitleForeColor = System.Drawing.Color.White
        ChartArea1.AxisX2.MajorGrid.Enabled = False
        ChartArea1.AxisX2.MajorGrid.LineColor = System.Drawing.Color.White
        ChartArea1.AxisX2.MajorGrid.LineWidth = 4
        ChartArea1.AxisX2.MinorGrid.LineColor = System.Drawing.Color.White
        ChartArea1.AxisX2.MinorTickMark.LineColor = System.Drawing.Color.White
        ChartArea1.AxisY.InterlacedColor = System.Drawing.Color.White
        ChartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        ChartArea1.AxisY.LineColor = System.Drawing.Color.White
        ChartArea1.AxisY.LineWidth = 2
        ChartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.White
        ChartArea1.AxisY.MajorGrid.LineWidth = 0
        ChartArea1.AxisY.MajorTickMark.Enabled = False
        ChartArea1.AxisY.TitleForeColor = System.Drawing.Color.White
        ChartArea1.AxisY2.MajorGrid.Enabled = False
        ChartArea1.AxisY2.MajorGrid.LineColor = System.Drawing.Color.White
        ChartArea1.AxisY2.MajorGrid.LineWidth = 10
        ChartArea1.AxisY2.MajorTickMark.LineColor = System.Drawing.Color.White
        ChartArea1.AxisY2.TitleFont = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartArea1.AxisY2.TitleForeColor = System.Drawing.Color.White
        ChartArea1.BackColor = System.Drawing.Color.Transparent
        ChartArea1.BackSecondaryColor = System.Drawing.Color.WhiteSmoke
        ChartArea1.BorderColor = System.Drawing.Color.White
        ChartArea1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDotDot
        ChartArea1.BorderWidth = 0
        ChartArea1.Name = "ChartArea1"
        ChartArea1.ShadowColor = System.Drawing.Color.White
        Me.Viewtime_user.ChartAreas.Add(ChartArea1)
        Me.Viewtime_user.Location = New System.Drawing.Point(30, 67)
        Me.Viewtime_user.Name = "Viewtime_user"
        Me.Viewtime_user.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area
        Series1.IsValueShownAsLabel = True
        Series1.LabelBackColor = System.Drawing.Color.Transparent
        Series1.LabelForeColor = System.Drawing.SystemColors.ActiveBorder
        Series1.Name = "ViewMovie"
        Series1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel
        Me.Viewtime_user.Series.Add(Series1)
        Me.Viewtime_user.Size = New System.Drawing.Size(1274, 334)
        Me.Viewtime_user.TabIndex = 4
        Me.Viewtime_user.Text = "Chart1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label2.Location = New System.Drawing.Point(95, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(143, 25)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Movie Duration"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Guna2CustomGradientPanel2)
        Me.Panel3.Controls.Add(Me.Panel5)
        Me.Panel3.Controls.Add(Me.Guna2CustomGradientPanel7)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 84)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1479, 552)
        Me.Panel3.TabIndex = 10
        '
        'Guna2CustomGradientPanel2
        '
        Me.Guna2CustomGradientPanel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2CustomGradientPanel2.BorderRadius = 20
        Me.Guna2CustomGradientPanel2.Controls.Add(Me.Label5)
        Me.Guna2CustomGradientPanel2.Controls.Add(Me.mean_movie)
        Me.Guna2CustomGradientPanel2.Controls.Add(Me.t_movies)
        Me.Guna2CustomGradientPanel2.Controls.Add(Me.Label8)
        Me.Guna2CustomGradientPanel2.Controls.Add(Me.Label9)
        Me.Guna2CustomGradientPanel2.Controls.Add(Me.Avg_movieDur)
        Me.Guna2CustomGradientPanel2.Controls.Add(Me.Label14)
        Me.Guna2CustomGradientPanel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Guna2CustomGradientPanel2.FillColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.Guna2CustomGradientPanel2.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.Guna2CustomGradientPanel2.FillColor3 = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.Guna2CustomGradientPanel2.FillColor4 = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.Guna2CustomGradientPanel2.Location = New System.Drawing.Point(887, 0)
        Me.Guna2CustomGradientPanel2.Name = "Guna2CustomGradientPanel2"
        Me.Guna2CustomGradientPanel2.ShadowDecoration.Parent = Me.Guna2CustomGradientPanel2
        Me.Guna2CustomGradientPanel2.Size = New System.Drawing.Size(427, 552)
        Me.Guna2CustomGradientPanel2.TabIndex = 74
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label5.Location = New System.Drawing.Point(34, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 32)
        Me.Label5.TabIndex = 74
        Me.Label5.Text = "Score"
        '
        'mean_movie
        '
        Me.mean_movie.AutoSize = True
        Me.mean_movie.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.mean_movie.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mean_movie.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.mean_movie.Location = New System.Drawing.Point(275, 224)
        Me.mean_movie.Name = "mean_movie"
        Me.mean_movie.Size = New System.Drawing.Size(23, 25)
        Me.mean_movie.TabIndex = 73
        Me.mean_movie.Text = "0"
        '
        't_movies
        '
        Me.t_movies.AutoSize = True
        Me.t_movies.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.t_movies.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.t_movies.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.t_movies.Location = New System.Drawing.Point(250, 139)
        Me.t_movies.Name = "t_movies"
        Me.t_movies.Size = New System.Drawing.Size(23, 25)
        Me.t_movies.TabIndex = 72
        Me.t_movies.Text = "0"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label8.Location = New System.Drawing.Point(22, 136)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(151, 29)
        Me.Label8.TabIndex = 65
        Me.Label8.Text = "Total Movies"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label9.Location = New System.Drawing.Point(22, 312)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(222, 25)
        Me.Label9.TabIndex = 67
        Me.Label9.Text = "Average Movie Duration"
        '
        'Avg_movieDur
        '
        Me.Avg_movieDur.AutoSize = True
        Me.Avg_movieDur.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.Avg_movieDur.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Avg_movieDur.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Avg_movieDur.Location = New System.Drawing.Point(275, 312)
        Me.Avg_movieDur.Name = "Avg_movieDur"
        Me.Avg_movieDur.Size = New System.Drawing.Size(23, 25)
        Me.Avg_movieDur.TabIndex = 71
        Me.Avg_movieDur.Text = "0"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label14.Location = New System.Drawing.Point(22, 224)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(137, 25)
        Me.Label14.TabIndex = 66
        Me.Label14.Text = "Average Rate:"
        '
        'Panel5
        '
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel5.Location = New System.Drawing.Point(848, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(39, 552)
        Me.Panel5.TabIndex = 75
        '
        'Guna2CustomGradientPanel7
        '
        Me.Guna2CustomGradientPanel7.BackColor = System.Drawing.Color.Transparent
        Me.Guna2CustomGradientPanel7.BorderRadius = 20
        Me.Guna2CustomGradientPanel7.Controls.Add(Me.panel_score)
        Me.Guna2CustomGradientPanel7.Controls.Add(Me.Label4)
        Me.Guna2CustomGradientPanel7.Controls.Add(Me.Label1)
        Me.Guna2CustomGradientPanel7.Controls.Add(Me.movie_pic)
        Me.Guna2CustomGradientPanel7.Controls.Add(Me.Selectmovie)
        Me.Guna2CustomGradientPanel7.Dock = System.Windows.Forms.DockStyle.Left
        Me.Guna2CustomGradientPanel7.FillColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.Guna2CustomGradientPanel7.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.Guna2CustomGradientPanel7.FillColor3 = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.Guna2CustomGradientPanel7.FillColor4 = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.Guna2CustomGradientPanel7.Location = New System.Drawing.Point(30, 0)
        Me.Guna2CustomGradientPanel7.Name = "Guna2CustomGradientPanel7"
        Me.Guna2CustomGradientPanel7.ShadowDecoration.Parent = Me.Guna2CustomGradientPanel7
        Me.Guna2CustomGradientPanel7.Size = New System.Drawing.Size(818, 552)
        Me.Guna2CustomGradientPanel7.TabIndex = 8
        '
        'panel_score
        '
        Me.panel_score.BackColor = System.Drawing.Color.Transparent
        Me.panel_score.BorderRadius = 20
        Me.panel_score.Controls.Add(Me.Label11)
        Me.panel_score.Controls.Add(Me.Label15)
        Me.panel_score.Controls.Add(Me.Recom_rates)
        Me.panel_score.Controls.Add(Me.Times_Watched)
        Me.panel_score.Controls.Add(Me.Label13)
        Me.panel_score.Controls.Add(Me.M_Name)
        Me.panel_score.FillColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.panel_score.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.panel_score.FillColor3 = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.panel_score.FillColor4 = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.panel_score.Location = New System.Drawing.Point(43, 176)
        Me.panel_score.Name = "panel_score"
        Me.panel_score.ShadowDecoration.Parent = Me.panel_score
        Me.panel_score.Size = New System.Drawing.Size(375, 336)
        Me.panel_score.TabIndex = 73
        Me.panel_score.Visible = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label11.Location = New System.Drawing.Point(22, 66)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(122, 25)
        Me.Label11.TabIndex = 65
        Me.Label11.Text = "Movie Name"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label15.Location = New System.Drawing.Point(18, 235)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(199, 25)
        Me.Label15.TabIndex = 67
        Me.Label15.Text = "Recommended Rates"
        '
        'Recom_rates
        '
        Me.Recom_rates.AutoSize = True
        Me.Recom_rates.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.Recom_rates.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Recom_rates.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Recom_rates.Location = New System.Drawing.Point(245, 235)
        Me.Recom_rates.Name = "Recom_rates"
        Me.Recom_rates.Size = New System.Drawing.Size(23, 25)
        Me.Recom_rates.TabIndex = 71
        Me.Recom_rates.Text = "0"
        '
        'Times_Watched
        '
        Me.Times_Watched.AutoSize = True
        Me.Times_Watched.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.Times_Watched.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Times_Watched.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Times_Watched.Location = New System.Drawing.Point(245, 135)
        Me.Times_Watched.Name = "Times_Watched"
        Me.Times_Watched.Size = New System.Drawing.Size(23, 25)
        Me.Times_Watched.TabIndex = 70
        Me.Times_Watched.Text = "0"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label13.Location = New System.Drawing.Point(18, 135)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(186, 50)
        Me.Label13.TabIndex = 66
        Me.Label13.Text = "Total User Watched" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "This Movie"
        '
        'M_Name
        '
        Me.M_Name.AutoSize = True
        Me.M_Name.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.M_Name.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.M_Name.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.M_Name.Location = New System.Drawing.Point(175, 66)
        Me.M_Name.Name = "M_Name"
        Me.M_Name.Size = New System.Drawing.Size(23, 25)
        Me.M_Name.TabIndex = 69
        Me.M_Name.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label4.Location = New System.Drawing.Point(65, 84)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(209, 25)
        Me.Label4.TabIndex = 64
        Me.Label4.Text = "Report On Each Movie"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label1.Location = New System.Drawing.Point(39, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 32)
        Me.Label1.TabIndex = 63
        Me.Label1.Text = "Score"
        '
        'movie_pic
        '
        Me.movie_pic.Image = CType(resources.GetObject("movie_pic.Image"), System.Drawing.Image)
        Me.movie_pic.Location = New System.Drawing.Point(460, 176)
        Me.movie_pic.Name = "movie_pic"
        Me.movie_pic.Size = New System.Drawing.Size(293, 336)
        Me.movie_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.movie_pic.TabIndex = 62
        Me.movie_pic.TabStop = False
        Me.movie_pic.Visible = False
        '
        'Selectmovie
        '
        Me.Selectmovie.Animated = True
        Me.Selectmovie.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Selectmovie.BorderColor = System.Drawing.Color.Transparent
        Me.Selectmovie.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.Selectmovie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Selectmovie.FillColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Selectmovie.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Selectmovie.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Selectmovie.FocusedState.Parent = Me.Selectmovie
        Me.Selectmovie.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Selectmovie.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Selectmovie.HoverState.Parent = Me.Selectmovie
        Me.Selectmovie.ItemHeight = 30
        Me.Selectmovie.ItemsAppearance.Parent = Me.Selectmovie
        Me.Selectmovie.Location = New System.Drawing.Point(43, 134)
        Me.Selectmovie.Name = "Selectmovie"
        Me.Selectmovie.ShadowDecoration.Parent = Me.Selectmovie
        Me.Selectmovie.Size = New System.Drawing.Size(294, 36)
        Me.Selectmovie.TabIndex = 61
        '
        'Panel4
        '
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(30, 552)
        Me.Panel4.TabIndex = 9
        '
        'stats3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1500, 1055)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "stats3"
        Me.Text = "stats3"
        Me.Panel2.ResumeLayout(False)
        Me.Guna2CustomGradientPanel1.ResumeLayout(False)
        Me.Guna2CustomGradientPanel1.PerformLayout()
        CType(Me.Viewtime_user, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Guna2CustomGradientPanel2.ResumeLayout(False)
        Me.Guna2CustomGradientPanel2.PerformLayout()
        Me.Guna2CustomGradientPanel7.ResumeLayout(False)
        Me.Guna2CustomGradientPanel7.PerformLayout()
        Me.panel_score.ResumeLayout(False)
        Me.panel_score.PerformLayout()
        CType(Me.movie_pic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Guna2CustomGradientPanel7 As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Guna2CustomGradientPanel1 As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents Viewtime_user As DataVisualization.Charting.Chart
    Friend WithEvents Selectmovie As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents movie_pic As PictureBox
    Friend WithEvents Recom_rates As Label
    Friend WithEvents Times_Watched As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents M_Name As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents panel_score As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents Guna2CustomGradientPanel2 As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents mean_movie As Label
    Friend WithEvents t_movies As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Avg_movieDur As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label5 As Label
End Class
