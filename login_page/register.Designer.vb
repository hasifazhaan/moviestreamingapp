<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class register
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(register))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Phone = New System.Windows.Forms.Label()
        Me.label = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lab = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.username = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.phno = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.pass = New System.Windows.Forms.TextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.r_pass = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.mismatch = New System.Windows.Forms.Label()
        Me.result_panel = New System.Windows.Forms.Panel()
        Me.result = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.email = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.pass_validation = New System.Windows.Forms.Label()
        Me.Email_Validation = New System.Windows.Forms.Label()
        Me.ComboBox1 = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Check_phno = New System.Windows.Forms.Label()
        Me.check_aval = New System.Windows.Forms.Label()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.f_name = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.result_panel.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel7.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(223, 117)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(154, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Registration"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(19, 187)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 42)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "* Username:"
        '
        'Phone
        '
        Me.Phone.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Phone.ForeColor = System.Drawing.SystemColors.Control
        Me.Phone.Location = New System.Drawing.Point(15, 296)
        Me.Phone.Name = "Phone"
        Me.Phone.Size = New System.Drawing.Size(113, 32)
        Me.Phone.TabIndex = 1
        Me.Phone.Text = "* Phone no:"
        '
        'label
        '
        Me.label.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label.ForeColor = System.Drawing.SystemColors.Control
        Me.label.Location = New System.Drawing.Point(10, 353)
        Me.label.Name = "label"
        Me.label.Size = New System.Drawing.Size(114, 32)
        Me.label.TabIndex = 2
        Me.label.Text = "* Password:"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Silver
        Me.Button1.CausesValidation = False
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Button1.Location = New System.Drawing.Point(39, 579)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(381, 43)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Register"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'lab
        '
        Me.lab.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lab.ForeColor = System.Drawing.SystemColors.Control
        Me.lab.Location = New System.Drawing.Point(14, 403)
        Me.lab.Name = "lab"
        Me.lab.Size = New System.Drawing.Size(117, 72)
        Me.lab.TabIndex = 22
        Me.lab.Text = "* Re-type Password:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.Location = New System.Drawing.Point(137, 212)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(283, 1)
        Me.Panel1.TabIndex = 32
        '
        'username
        '
        Me.username.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.username.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.username.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.username.ForeColor = System.Drawing.SystemColors.Control
        Me.username.Location = New System.Drawing.Point(151, 187)
        Me.username.Name = "username"
        Me.username.Size = New System.Drawing.Size(276, 21)
        Me.username.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.Panel2.Location = New System.Drawing.Point(141, 321)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(283, 1)
        Me.Panel2.TabIndex = 34
        '
        'phno
        '
        Me.phno.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.phno.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.phno.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.phno.ForeColor = System.Drawing.SystemColors.Control
        Me.phno.Location = New System.Drawing.Point(152, 295)
        Me.phno.Name = "phno"
        Me.phno.Size = New System.Drawing.Size(279, 21)
        Me.phno.TabIndex = 2
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.Control
        Me.Panel3.Location = New System.Drawing.Point(141, 378)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(303, 1)
        Me.Panel3.TabIndex = 36
        '
        'pass
        '
        Me.pass.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.pass.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.pass.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pass.ForeColor = System.Drawing.SystemColors.Control
        Me.pass.Location = New System.Drawing.Point(138, 351)
        Me.pass.Name = "pass"
        Me.pass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.pass.Size = New System.Drawing.Size(277, 21)
        Me.pass.TabIndex = 3
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.Control
        Me.Panel4.Location = New System.Drawing.Point(130, 458)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(283, 1)
        Me.Panel4.TabIndex = 38
        '
        'r_pass
        '
        Me.r_pass.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.r_pass.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.r_pass.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.r_pass.ForeColor = System.Drawing.SystemColors.Control
        Me.r_pass.Location = New System.Drawing.Point(137, 431)
        Me.r_pass.Name = "r_pass"
        Me.r_pass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.r_pass.Size = New System.Drawing.Size(278, 21)
        Me.r_pass.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label6.Location = New System.Drawing.Point(12, 10)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(258, 32)
        Me.Label6.TabIndex = 40
        Me.Label6.Text = "Already have an account ?"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.Button2.CausesValidation = False
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight
        Me.Button2.FlatAppearance.BorderSize = 2
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Button2.Location = New System.Drawing.Point(3, 45)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(361, 43)
        Me.Button2.TabIndex = 41
        Me.Button2.Text = "Login"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'mismatch
        '
        Me.mismatch.AutoSize = True
        Me.mismatch.ForeColor = System.Drawing.Color.Tomato
        Me.mismatch.Location = New System.Drawing.Point(428, 403)
        Me.mismatch.Name = "mismatch"
        Me.mismatch.Size = New System.Drawing.Size(137, 17)
        Me.mismatch.TabIndex = 42
        Me.mismatch.Text = "Password Mis-Match"
        Me.mismatch.Visible = False
        '
        'result_panel
        '
        Me.result_panel.AutoScroll = True
        Me.result_panel.Controls.Add(Me.result)
        Me.result_panel.Controls.Add(Me.Button3)
        Me.result_panel.Location = New System.Drawing.Point(434, 351)
        Me.result_panel.Name = "result_panel"
        Me.result_panel.Size = New System.Drawing.Size(331, 256)
        Me.result_panel.TabIndex = 43
        Me.result_panel.Visible = False
        '
        'result
        '
        Me.result.AutoSize = True
        Me.result.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.result.ForeColor = System.Drawing.SystemColors.Control
        Me.result.Location = New System.Drawing.Point(38, 65)
        Me.result.Name = "result"
        Me.result.Size = New System.Drawing.Size(259, 29)
        Me.result.TabIndex = 1
        Me.result.Text = "Registered Sucessfully"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Button3.FlatAppearance.BorderSize = 2
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.Button3.Location = New System.Drawing.Point(126, 191)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 8
        Me.Button3.Text = "OK"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(612, 114)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 39
        Me.PictureBox1.TabStop = False
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.SystemColors.Control
        Me.Panel5.Location = New System.Drawing.Point(127, 555)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(286, 1)
        Me.Panel5.TabIndex = 46
        '
        'email
        '
        Me.email.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.email.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.email.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.email.ForeColor = System.Drawing.SystemColors.Control
        Me.email.Location = New System.Drawing.Point(130, 527)
        Me.email.Name = "email"
        Me.email.Size = New System.Drawing.Size(286, 21)
        Me.email.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.Control
        Me.Label7.Location = New System.Drawing.Point(17, 528)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(86, 32)
        Me.Label7.TabIndex = 44
        Me.Label7.Text = "*Email:"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.SystemColors.Control
        Me.Panel6.Location = New System.Drawing.Point(129, 514)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(300, 1)
        Me.Panel6.TabIndex = 49
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.Control
        Me.Label8.Location = New System.Drawing.Point(15, 481)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(84, 32)
        Me.Label8.TabIndex = 47
        Me.Label8.Text = "*Country:"
        '
        'Panel7
        '
        Me.Panel7.AutoScroll = True
        Me.Panel7.AutoScrollMargin = New System.Drawing.Size(20, 100)
        Me.Panel7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel7.Controls.Add(Me.pass_validation)
        Me.Panel7.Controls.Add(Me.Email_Validation)
        Me.Panel7.Controls.Add(Me.ComboBox1)
        Me.Panel7.Controls.Add(Me.Check_phno)
        Me.Panel7.Controls.Add(Me.check_aval)
        Me.Panel7.Controls.Add(Me.Panel10)
        Me.Panel7.Controls.Add(Me.f_name)
        Me.Panel7.Controls.Add(Me.Label9)
        Me.Panel7.Controls.Add(Me.Panel5)
        Me.Panel7.Controls.Add(Me.Label7)
        Me.Panel7.Controls.Add(Me.email)
        Me.Panel7.Controls.Add(Me.Panel8)
        Me.Panel7.Controls.Add(Me.mismatch)
        Me.Panel7.Controls.Add(Me.Phone)
        Me.Panel7.Controls.Add(Me.Panel6)
        Me.Panel7.Controls.Add(Me.Panel4)
        Me.Panel7.Controls.Add(Me.r_pass)
        Me.Panel7.Controls.Add(Me.Panel3)
        Me.Panel7.Controls.Add(Me.Button1)
        Me.Panel7.Controls.Add(Me.pass)
        Me.Panel7.Controls.Add(Me.Label8)
        Me.Panel7.Controls.Add(Me.Panel2)
        Me.Panel7.Controls.Add(Me.phno)
        Me.Panel7.Controls.Add(Me.Panel1)
        Me.Panel7.Controls.Add(Me.username)
        Me.Panel7.Controls.Add(Me.Label2)
        Me.Panel7.Controls.Add(Me.lab)
        Me.Panel7.Controls.Add(Me.label)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel7.Location = New System.Drawing.Point(662, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(612, 741)
        Me.Panel7.TabIndex = 100
        '
        'pass_validation
        '
        Me.pass_validation.AutoSize = True
        Me.pass_validation.ForeColor = System.Drawing.Color.LightCoral
        Me.pass_validation.Location = New System.Drawing.Point(437, 334)
        Me.pass_validation.Name = "pass_validation"
        Me.pass_validation.Size = New System.Drawing.Size(150, 34)
        Me.pass_validation.TabIndex = 59
        Me.pass_validation.Text = "Password Must Range" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " From 6-15 Characters"
        Me.pass_validation.Visible = False
        '
        'Email_Validation
        '
        Me.Email_Validation.AutoSize = True
        Me.Email_Validation.ForeColor = System.Drawing.Color.Tomato
        Me.Email_Validation.Location = New System.Drawing.Point(437, 531)
        Me.Email_Validation.Name = "Email_Validation"
        Me.Email_Validation.Size = New System.Drawing.Size(103, 17)
        Me.Email_Validation.TabIndex = 58
        Me.Email_Validation.Text = "Email Not Valid"
        Me.Email_Validation.Visible = False
        '
        'ComboBox1
        '
        Me.ComboBox1.Animated = True
        Me.ComboBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.ComboBox1.BorderColor = System.Drawing.Color.Transparent
        Me.ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.ComboBox1.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ComboBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ComboBox1.FocusedState.Parent = Me.ComboBox1
        Me.ComboBox1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.ComboBox1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.ComboBox1.HoverState.Parent = Me.ComboBox1
        Me.ComboBox1.ItemHeight = 30
        Me.ComboBox1.ItemsAppearance.Parent = Me.ComboBox1
        Me.ComboBox1.Location = New System.Drawing.Point(129, 476)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.ShadowDecoration.Parent = Me.ComboBox1
        Me.ComboBox1.Size = New System.Drawing.Size(294, 36)
        Me.ComboBox1.TabIndex = 57
        '
        'Check_phno
        '
        Me.Check_phno.AutoSize = True
        Me.Check_phno.ForeColor = System.Drawing.Color.Tomato
        Me.Check_phno.Location = New System.Drawing.Point(437, 300)
        Me.Check_phno.Name = "Check_phno"
        Me.Check_phno.Size = New System.Drawing.Size(65, 17)
        Me.Check_phno.TabIndex = 56
        Me.Check_phno.Text = "Not Valid"
        Me.Check_phno.Visible = False
        '
        'check_aval
        '
        Me.check_aval.AutoSize = True
        Me.check_aval.ForeColor = System.Drawing.Color.Lime
        Me.check_aval.Location = New System.Drawing.Point(433, 177)
        Me.check_aval.Name = "check_aval"
        Me.check_aval.Size = New System.Drawing.Size(65, 17)
        Me.check_aval.TabIndex = 55
        Me.check_aval.Text = "Available"
        Me.check_aval.Visible = False
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.SystemColors.Control
        Me.Panel10.Location = New System.Drawing.Point(135, 265)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(283, 1)
        Me.Panel10.TabIndex = 54
        '
        'f_name
        '
        Me.f_name.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.f_name.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.f_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.f_name.ForeColor = System.Drawing.SystemColors.Control
        Me.f_name.Location = New System.Drawing.Point(149, 240)
        Me.f_name.Name = "f_name"
        Me.f_name.Size = New System.Drawing.Size(276, 21)
        Me.f_name.TabIndex = 53
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.Control
        Me.Label9.Location = New System.Drawing.Point(17, 240)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(126, 42)
        Me.Label9.TabIndex = 52
        Me.Label9.Text = "* Full Name:"
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.PictureBox1)
        Me.Panel8.Controls.Add(Me.Label1)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel8.Location = New System.Drawing.Point(0, 0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(612, 154)
        Me.Panel8.TabIndex = 50
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.Transparent
        Me.Panel9.Controls.Add(Me.Label6)
        Me.Panel9.Controls.Add(Me.Button2)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel9.Location = New System.Drawing.Point(0, 641)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(662, 100)
        Me.Panel9.TabIndex = 101
        '
        'register
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1274, 741)
        Me.Controls.Add(Me.result_panel)
        Me.Controls.Add(Me.Panel9)
        Me.Controls.Add(Me.Panel7)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "register"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form3"
        Me.result_panel.ResumeLayout(False)
        Me.result_panel.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.Panel9.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Phone As Label
    Friend WithEvents label As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents lab As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents username As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents phno As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents pass As TextBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents r_pass As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents mismatch As Label
    Friend WithEvents result_panel As Panel
    Friend WithEvents result As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents email As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Panel10 As Panel
    Friend WithEvents f_name As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Check_phno As Label
    Friend WithEvents check_aval As Label
    Friend WithEvents ComboBox1 As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Email_Validation As Label
    Friend WithEvents pass_validation As Label
End Class
