<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class admin
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
        Me.buttonExit = New System.Windows.Forms.Button()
        Me.Minimise = New System.Windows.Forms.Button()
        Me.Panel_add_movie = New System.Windows.Forms.Panel()
        Me.add_todatabase_movie = New System.Windows.Forms.Button()
        Me.Panel_star = New System.Windows.Forms.Panel()
        Me.Panel_gen = New System.Windows.Forms.Panel()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Panel_add_star = New System.Windows.Forms.Panel()
        Me.panel_add_director = New System.Windows.Forms.Panel()
        Me.add_to_database_dir = New System.Windows.Forms.Button()
        Me.dir_name = New System.Windows.Forms.TextBox()
        Me.dir_id = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.add_to_database_star = New System.Windows.Forms.Button()
        Me.star_name = New System.Windows.Forms.TextBox()
        Me.star_id = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel_dir = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Rating_1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.m_name = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.m_id = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.update_btn = New System.Windows.Forms.Button()
        Me.delete_btn = New System.Windows.Forms.Button()
        Me.add_btn = New System.Windows.Forms.Button()
        Me.logo = New System.Windows.Forms.PictureBox()
        Me.Panel_update = New System.Windows.Forms.Panel()
        Me.Panel_del = New System.Windows.Forms.Panel()
        Me.Panel_add = New System.Windows.Forms.Panel()
        Me.add_movie = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.dir = New System.Windows.Forms.TextBox()
        Me.gen = New System.Windows.Forms.TextBox()
        Me.star = New System.Windows.Forms.TextBox()
        Me.addtodir = New System.Windows.Forms.Button()
        Me.addtogen = New System.Windows.Forms.Button()
        Me.addtostar = New System.Windows.Forms.Button()
        Me.Panel_add_movie.SuspendLayout()
        Me.Panel_add_star.SuspendLayout()
        Me.panel_add_director.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_update.SuspendLayout()
        Me.Panel_del.SuspendLayout()
        Me.Panel_add.SuspendLayout()
        Me.SuspendLayout()
        '
        'buttonExit
        '
        Me.buttonExit.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.buttonExit.AutoSize = True
        Me.buttonExit.FlatAppearance.BorderSize = 0
        Me.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.buttonExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonExit.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.buttonExit.Location = New System.Drawing.Point(1483, 7)
        Me.buttonExit.Name = "buttonExit"
        Me.buttonExit.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.buttonExit.Size = New System.Drawing.Size(46, 41)
        Me.buttonExit.TabIndex = 27
        Me.buttonExit.Text = "X"
        Me.buttonExit.UseVisualStyleBackColor = True
        '
        'Minimise
        '
        Me.Minimise.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.Minimise.AutoSize = True
        Me.Minimise.FlatAppearance.BorderSize = 0
        Me.Minimise.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Minimise.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Minimise.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Minimise.Location = New System.Drawing.Point(1441, 6)
        Me.Minimise.Name = "Minimise"
        Me.Minimise.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Minimise.Size = New System.Drawing.Size(37, 41)
        Me.Minimise.TabIndex = 28
        Me.Minimise.Text = "-"
        Me.Minimise.UseVisualStyleBackColor = True
        '
        'Panel_add_movie
        '
        Me.Panel_add_movie.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Panel_add_movie.Controls.Add(Me.addtostar)
        Me.Panel_add_movie.Controls.Add(Me.addtogen)
        Me.Panel_add_movie.Controls.Add(Me.addtodir)
        Me.Panel_add_movie.Controls.Add(Me.star)
        Me.Panel_add_movie.Controls.Add(Me.gen)
        Me.Panel_add_movie.Controls.Add(Me.dir)
        Me.Panel_add_movie.Controls.Add(Me.add_todatabase_movie)
        Me.Panel_add_movie.Controls.Add(Me.Panel_star)
        Me.Panel_add_movie.Controls.Add(Me.Panel_gen)
        Me.Panel_add_movie.Controls.Add(Me.Button6)
        Me.Panel_add_movie.Controls.Add(Me.Panel_add_star)
        Me.Panel_add_movie.Controls.Add(Me.Panel_dir)
        Me.Panel_add_movie.Controls.Add(Me.Label8)
        Me.Panel_add_movie.Controls.Add(Me.RichTextBox1)
        Me.Panel_add_movie.Controls.Add(Me.Label7)
        Me.Panel_add_movie.Controls.Add(Me.Label6)
        Me.Panel_add_movie.Controls.Add(Me.Label5)
        Me.Panel_add_movie.Controls.Add(Me.Label4)
        Me.Panel_add_movie.Controls.Add(Me.Rating_1)
        Me.Panel_add_movie.Controls.Add(Me.Label3)
        Me.Panel_add_movie.Controls.Add(Me.m_name)
        Me.Panel_add_movie.Controls.Add(Me.Label2)
        Me.Panel_add_movie.Controls.Add(Me.m_id)
        Me.Panel_add_movie.Controls.Add(Me.Label1)
        Me.Panel_add_movie.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Panel_add_movie.Location = New System.Drawing.Point(240, 59)
        Me.Panel_add_movie.Name = "Panel_add_movie"
        Me.Panel_add_movie.Size = New System.Drawing.Size(1290, 1000)
        Me.Panel_add_movie.TabIndex = 29
        Me.Panel_add_movie.Visible = False
        '
        'add_todatabase_movie
        '
        Me.add_todatabase_movie.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.add_todatabase_movie.Location = New System.Drawing.Point(79, 879)
        Me.add_todatabase_movie.Name = "add_todatabase_movie"
        Me.add_todatabase_movie.Size = New System.Drawing.Size(1049, 56)
        Me.add_todatabase_movie.TabIndex = 22
        Me.add_todatabase_movie.Text = "Add "
        Me.add_todatabase_movie.UseVisualStyleBackColor = True
        '
        'Panel_star
        '
        Me.Panel_star.AutoScroll = True
        Me.Panel_star.Location = New System.Drawing.Point(729, 153)
        Me.Panel_star.Name = "Panel_star"
        Me.Panel_star.Size = New System.Drawing.Size(339, 103)
        Me.Panel_star.TabIndex = 23
        '
        'Panel_gen
        '
        Me.Panel_gen.AutoScroll = True
        Me.Panel_gen.Location = New System.Drawing.Point(738, 393)
        Me.Panel_gen.Name = "Panel_gen"
        Me.Panel_gen.Size = New System.Drawing.Size(319, 105)
        Me.Panel_gen.TabIndex = 22
        '
        'Button6
        '
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Location = New System.Drawing.Point(965, 553)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(151, 56)
        Me.Button6.TabIndex = 21
        Me.Button6.Text = "Upload File"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Panel_add_star
        '
        Me.Panel_add_star.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Panel_add_star.Controls.Add(Me.panel_add_director)
        Me.Panel_add_star.Controls.Add(Me.add_to_database_star)
        Me.Panel_add_star.Controls.Add(Me.star_name)
        Me.Panel_add_star.Controls.Add(Me.star_id)
        Me.Panel_add_star.Controls.Add(Me.Label11)
        Me.Panel_add_star.Controls.Add(Me.Label10)
        Me.Panel_add_star.Controls.Add(Me.Label9)
        Me.Panel_add_star.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Panel_add_star.Location = New System.Drawing.Point(1117, 214)
        Me.Panel_add_star.Name = "Panel_add_star"
        Me.Panel_add_star.Size = New System.Drawing.Size(177, 140)
        Me.Panel_add_star.TabIndex = 20
        Me.Panel_add_star.Visible = False
        '
        'panel_add_director
        '
        Me.panel_add_director.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.panel_add_director.Controls.Add(Me.add_to_database_dir)
        Me.panel_add_director.Controls.Add(Me.dir_name)
        Me.panel_add_director.Controls.Add(Me.dir_id)
        Me.panel_add_director.Controls.Add(Me.Label12)
        Me.panel_add_director.Controls.Add(Me.Label13)
        Me.panel_add_director.Controls.Add(Me.Label14)
        Me.panel_add_director.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.panel_add_director.Location = New System.Drawing.Point(425, 84)
        Me.panel_add_director.Name = "panel_add_director"
        Me.panel_add_director.Size = New System.Drawing.Size(1297, 794)
        Me.panel_add_director.TabIndex = 21
        Me.panel_add_director.Visible = False
        '
        'add_to_database_dir
        '
        Me.add_to_database_dir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.add_to_database_dir.Location = New System.Drawing.Point(373, 405)
        Me.add_to_database_dir.Name = "add_to_database_dir"
        Me.add_to_database_dir.Size = New System.Drawing.Size(151, 56)
        Me.add_to_database_dir.TabIndex = 5
        Me.add_to_database_dir.Text = "Add"
        Me.add_to_database_dir.UseVisualStyleBackColor = True
        '
        'dir_name
        '
        Me.dir_name.Location = New System.Drawing.Point(311, 329)
        Me.dir_name.Name = "dir_name"
        Me.dir_name.Size = New System.Drawing.Size(213, 22)
        Me.dir_name.TabIndex = 4
        '
        'dir_id
        '
        Me.dir_id.Location = New System.Drawing.Point(311, 255)
        Me.dir_id.Name = "dir_id"
        Me.dir_id.Size = New System.Drawing.Size(213, 22)
        Me.dir_id.TabIndex = 3
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(93, 334)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(136, 25)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "Director Name"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(93, 263)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(100, 25)
        Me.Label13.TabIndex = 1
        Me.Label13.Text = "Director Id"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(200, 32)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(120, 25)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "Add Director"
        '
        'add_to_database_star
        '
        Me.add_to_database_star.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.add_to_database_star.Location = New System.Drawing.Point(373, 405)
        Me.add_to_database_star.Name = "add_to_database_star"
        Me.add_to_database_star.Size = New System.Drawing.Size(151, 56)
        Me.add_to_database_star.TabIndex = 5
        Me.add_to_database_star.Text = "Add"
        Me.add_to_database_star.UseVisualStyleBackColor = True
        '
        'star_name
        '
        Me.star_name.Location = New System.Drawing.Point(311, 329)
        Me.star_name.Name = "star_name"
        Me.star_name.Size = New System.Drawing.Size(213, 22)
        Me.star_name.TabIndex = 4
        '
        'star_id
        '
        Me.star_id.Location = New System.Drawing.Point(311, 255)
        Me.star_id.Name = "star_id"
        Me.star_id.Size = New System.Drawing.Size(213, 22)
        Me.star_id.TabIndex = 3
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(93, 334)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(110, 25)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Cast Name"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(93, 263)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(74, 25)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Cast Id"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(200, 32)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(94, 25)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Add Cast"
        '
        'Panel_dir
        '
        Me.Panel_dir.AutoScroll = True
        Me.Panel_dir.Location = New System.Drawing.Point(64, 261)
        Me.Panel_dir.Name = "Panel_dir"
        Me.Panel_dir.Size = New System.Drawing.Size(298, 83)
        Me.Panel_dir.TabIndex = 19
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(742, 584)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(199, 25)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Select File To Upload"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(86, 627)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(1042, 241)
        Me.RichTextBox1.TabIndex = 13
        Me.RichTextBox1.Text = ""
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(99, 584)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(167, 25)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Movie Description"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(733, 344)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(94, 25)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Star Cast"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(733, 89)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 25)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Genre"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(59, 202)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 25)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Director"
        '
        'Rating_1
        '
        Me.Rating_1.Location = New System.Drawing.Point(179, 390)
        Me.Rating_1.Name = "Rating_1"
        Me.Rating_1.Size = New System.Drawing.Size(205, 22)
        Me.Rating_1.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(71, 381)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 25)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Rating"
        '
        'm_name
        '
        Me.m_name.Location = New System.Drawing.Point(214, 154)
        Me.m_name.Name = "m_name"
        Me.m_name.Size = New System.Drawing.Size(205, 22)
        Me.m_name.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(58, 150)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Movie Name"
        '
        'm_id
        '
        Me.m_id.Location = New System.Drawing.Point(214, 88)
        Me.m_id.Name = "m_id"
        Me.m_id.Size = New System.Drawing.Size(205, 22)
        Me.m_id.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(58, 84)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Movie Id"
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.Panel1.Controls.Add(Me.Panel_update)
        Me.Panel1.Controls.Add(Me.update_btn)
        Me.Panel1.Controls.Add(Me.Panel_del)
        Me.Panel1.Controls.Add(Me.delete_btn)
        Me.Panel1.Controls.Add(Me.Panel_add)
        Me.Panel1.Controls.Add(Me.add_btn)
        Me.Panel1.Controls.Add(Me.logo)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(227, 1035)
        Me.Panel1.TabIndex = 30
        '
        'update_btn
        '
        Me.update_btn.Dock = System.Windows.Forms.DockStyle.Top
        Me.update_btn.FlatAppearance.BorderSize = 0
        Me.update_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.update_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.update_btn.ForeColor = System.Drawing.SystemColors.Control
        Me.update_btn.Location = New System.Drawing.Point(0, 414)
        Me.update_btn.Name = "update_btn"
        Me.update_btn.Size = New System.Drawing.Size(227, 76)
        Me.update_btn.TabIndex = 24
        Me.update_btn.Text = "Update"
        Me.update_btn.UseVisualStyleBackColor = True
        '
        'delete_btn
        '
        Me.delete_btn.Dock = System.Windows.Forms.DockStyle.Top
        Me.delete_btn.FlatAppearance.BorderSize = 0
        Me.delete_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.delete_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.delete_btn.ForeColor = System.Drawing.SystemColors.Control
        Me.delete_btn.Location = New System.Drawing.Point(0, 264)
        Me.delete_btn.Name = "delete_btn"
        Me.delete_btn.Size = New System.Drawing.Size(227, 76)
        Me.delete_btn.TabIndex = 22
        Me.delete_btn.Text = "Delete"
        Me.delete_btn.UseVisualStyleBackColor = True
        '
        'add_btn
        '
        Me.add_btn.Dock = System.Windows.Forms.DockStyle.Top
        Me.add_btn.FlatAppearance.BorderSize = 0
        Me.add_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.add_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.add_btn.ForeColor = System.Drawing.SystemColors.Control
        Me.add_btn.Location = New System.Drawing.Point(0, 127)
        Me.add_btn.Name = "add_btn"
        Me.add_btn.Size = New System.Drawing.Size(227, 76)
        Me.add_btn.TabIndex = 20
        Me.add_btn.Text = "Add"
        Me.add_btn.UseVisualStyleBackColor = True
        '
        'logo
        '

        'Panel_update
        '
        Me.Panel_update.Controls.Add(Me.Button2)
        Me.Panel_update.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_update.Location = New System.Drawing.Point(0, 490)
        Me.Panel_update.Name = "Panel_update"
        Me.Panel_update.Size = New System.Drawing.Size(227, 67)
        Me.Panel_update.TabIndex = 25
        Me.Panel_update.Visible = False
        '
        'Panel_del
        '
        Me.Panel_del.Controls.Add(Me.Button1)
        Me.Panel_del.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_del.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel_del.Location = New System.Drawing.Point(0, 340)
        Me.Panel_del.Name = "Panel_del"
        Me.Panel_del.Size = New System.Drawing.Size(227, 74)
        Me.Panel_del.TabIndex = 23
        Me.Panel_del.Visible = False
        '
        'Panel_add
        '
        Me.Panel_add.Controls.Add(Me.add_movie)
        Me.Panel_add.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_add.Location = New System.Drawing.Point(0, 203)
        Me.Panel_add.Name = "Panel_add"
        Me.Panel_add.Size = New System.Drawing.Size(227, 61)
        Me.Panel_add.TabIndex = 21
        Me.Panel_add.Visible = False
        '
        'add_movie
        '
        Me.add_movie.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.add_movie.Dock = System.Windows.Forms.DockStyle.Top
        Me.add_movie.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.add_movie.FlatAppearance.BorderSize = 0
        Me.add_movie.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.add_movie.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.add_movie.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.add_movie.ForeColor = System.Drawing.SystemColors.Control
        Me.add_movie.Location = New System.Drawing.Point(0, 0)
        Me.add_movie.Name = "add_movie"
        Me.add_movie.Size = New System.Drawing.Size(227, 61)
        Me.add_movie.TabIndex = 3
        Me.add_movie.Text = "Movie"
        Me.add_movie.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.SystemColors.Control
        Me.Button1.Location = New System.Drawing.Point(0, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(227, 73)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Movie"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.SystemColors.Control
        Me.Button2.Location = New System.Drawing.Point(0, 0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(227, 61)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Movie"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'dir
        '
        Me.dir.Location = New System.Drawing.Point(214, 202)
        Me.dir.Name = "dir"
        Me.dir.Size = New System.Drawing.Size(205, 22)
        Me.dir.TabIndex = 24
        '
        'gen
        '
        Me.gen.Location = New System.Drawing.Point(814, 93)
        Me.gen.Name = "gen"
        Me.gen.Size = New System.Drawing.Size(205, 22)
        Me.gen.TabIndex = 25
        '
        'star
        '
        Me.star.Location = New System.Drawing.Point(833, 347)
        Me.star.Name = "star"
        Me.star.Size = New System.Drawing.Size(205, 22)
        Me.star.TabIndex = 26
        '
        'addtodir
        '
        Me.addtodir.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.addtodir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.addtodir.ForeColor = System.Drawing.Color.Green
        Me.addtodir.Location = New System.Drawing.Point(425, 202)
        Me.addtodir.Name = "addtodir"
        Me.addtodir.Size = New System.Drawing.Size(44, 25)
        Me.addtodir.TabIndex = 27
        Me.addtodir.Text = "✔"
        Me.addtodir.UseVisualStyleBackColor = True
        '
        'addtogen
        '
        Me.addtogen.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.addtogen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.addtogen.ForeColor = System.Drawing.Color.Green
        Me.addtogen.Location = New System.Drawing.Point(1025, 92)
        Me.addtogen.Name = "addtogen"
        Me.addtogen.Size = New System.Drawing.Size(44, 25)
        Me.addtogen.TabIndex = 28
        Me.addtogen.Text = "✔"
        Me.addtogen.UseVisualStyleBackColor = True
        '
        'addtostar
        '
        Me.addtostar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.addtostar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.addtostar.ForeColor = System.Drawing.Color.Green
        Me.addtostar.Location = New System.Drawing.Point(1044, 346)
        Me.addtostar.Name = "addtostar"
        Me.addtostar.Size = New System.Drawing.Size(44, 25)
        Me.addtostar.TabIndex = 29
        Me.addtostar.Text = "✔"
        Me.addtostar.UseVisualStyleBackColor = True
        '
        'admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1532, 1035)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel_add_movie)
        Me.Controls.Add(Me.buttonExit)
        Me.Controls.Add(Me.Minimise)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "admin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "admin"
        Me.Panel_add_movie.ResumeLayout(False)
        Me.Panel_add_movie.PerformLayout()
        Me.Panel_add_star.ResumeLayout(False)
        Me.Panel_add_star.PerformLayout()
        Me.panel_add_director.ResumeLayout(False)
        Me.panel_add_director.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_update.ResumeLayout(False)
        Me.Panel_del.ResumeLayout(False)
        Me.Panel_add.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents buttonExit As Button
    Friend WithEvents Minimise As Button
    Friend WithEvents add_todatabase_movie As Button
    Friend WithEvents Panel_star As Panel
    Friend WithEvents Panel_gen As Panel
    Friend WithEvents Button6 As Button
    Friend WithEvents Panel_add_star As Panel
    Friend WithEvents panel_add_director As Panel
    Friend WithEvents add_to_database_dir As Button
    Friend WithEvents dir_name As TextBox
    Friend WithEvents dir_id As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents add_to_database_star As Button
    Friend WithEvents star_name As TextBox
    Friend WithEvents star_id As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel_dir As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Rating_1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents m_name As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents m_id As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents update_btn As Button
    Friend WithEvents delete_btn As Button
    Friend WithEvents add_btn As Button
    Friend WithEvents logo As PictureBox
    Friend WithEvents star As TextBox
    Friend WithEvents gen As TextBox
    Friend WithEvents dir As TextBox
    Friend WithEvents Panel_update As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel_del As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel_add As Panel
    Friend WithEvents add_movie As Button
    Private WithEvents Panel_add_movie As Panel
    Friend WithEvents addtostar As Button
    Friend WithEvents addtogen As Button
    Friend WithEvents addtodir As Button
End Class
