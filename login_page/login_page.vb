Imports System.Data.SqlClient
Public Class login_page
    Public con As New SqlConnection

    Public usr

    Private Sub login_page_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'connection string
        con.ConnectionString = "data source=(localdb)\mssqllocaldb;attachdbfilename=c:\users\haseef\source\repos\login_page\login_page\database1.mdf;integrated security=true"
        con.Open()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        validation()
    End Sub
    Private Sub validation()
        Dim cmd As New SqlCommand
        Dim sql As String
        Dim dr As SqlDataReader
        'sql command to validate if user is in database
        sql = "select * from valid_user where username  = '" + (TextBox1.Text) + "'  AND Passwd ='" + (TextBox2.Text) + "'"
        cmd.Connection = con
        cmd.CommandText = sql
        dr = cmd.ExecuteReader
        If dr.Read Then
            'checks if he is has admin privelage or not
            If dr("isadmin") = 1 Then
                admin_page.Show()
            Else
                main_page.user.Text = TextBox1.Text
                main_page.Show()
                main_page.Setuserdp()
                Me.Hide()
            End If
            Me.Hide()
            TextBox1.Text = "Username"
            TextBox2.Text = "Password"
            TextBox2.PasswordChar = ""
        Else
            invalidtext.Visible = True
            Panel1.BackColor = Color.Red
            Panel2.BackColor = Color.Red
        End If
        dr.Close()
    End Sub
    Private Sub Exit_button_Click(sender As Object, e As EventArgs) Handles Exit_button.Click
        Application.Exit()
    End Sub
    Private Sub Mini_button_Click(sender As Object, e As EventArgs) Handles Mini_button.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub Max_button_Click(sender As Object, e As EventArgs) Handles Max_button.Click
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        Else
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub

    'All Below is for ui design
    Private Sub Button1_MouseHover(sender As Object, e As EventArgs) Handles Button1.MouseEnter
        ChangecoloronHover(Button1, 3, Color.FromArgb(105, 102, 102))
    End Sub
    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave
        ChangecoloronHover(Button1, 0, Color.FromArgb(101, 101, 219))
    End Sub
    Private Sub TextBox2_Click(sender As Object, e As MouseEventArgs) Handles TextBox2.Click
        TextBox2.Text = ""
        TextBox2.PasswordChar = "*"
        Panel2.BackColor = Color.White
        invalidtext.Visible = False
    End Sub
    Private Sub TextBox1_Click(sender As Object, e As EventArgs) Handles TextBox1.Click
        TextBox1.Text = ""
        Panel1.BackColor = Color.White
        invalidtext.Visible = False
    End Sub
    Private Sub ChangecoloronHover(ByRef btn_name, ByVal border, ByVal color)
        btn_name.FlatAppearance.BorderSize = border
        btn_name.BackColor = color
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        register.Show()
        Me.Hide()
    End Sub
    Private Sub Button2_MouseLeave(sender As Object, e As EventArgs) Handles Button2.MouseLeave
        ChangecoloronHover(Button2, 3, Color.FromArgb(40, 40, 41))
    End Sub
    Private Sub Button2_MouseHover(sender As Object, e As EventArgs) Handles Button2.MouseEnter
        ChangecoloronHover(Button2, 0, Color.FromArgb(200, 200, 204))
    End Sub
    Private Sub PictureBox4_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox4.MouseEnter
        TextBox2.PasswordChar = ""
    End Sub
    Private Sub PictureBox4_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox4.MouseLeave
        TextBox2.PasswordChar = "*"
    End Sub
    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        TextBox2.PasswordChar = "*"
    End Sub
    Private Sub ShowOnHover(ByRef button, ByVal img)
        button.Image = Image.FromFile(img)
        'sets the image specified in the button
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

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click

    End Sub

    Private Sub forgotpwd_Click(sender As Object, e As EventArgs) Handles forgotpwd.Click
        forgotpwd_page.Show()
        Me.Hide()
    End Sub
End Class