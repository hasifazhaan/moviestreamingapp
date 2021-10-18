Imports System.Data.SqlClient
Imports System.Globalization

Public Class register
    Dim con As New SqlConnection

    Dim confrugration_username = False
    Dim confrugration_phoneno = False
    Dim confrugration_password = False

    Private Sub register_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.ConnectionString = "data source=(localdb)\mssqllocaldb;attachdbfilename=c:\users\haseef\source\repos\login_page\login_page\database1.mdf;integrated security=true"
        con.Open()
        Country_list()

    End Sub
    Private Sub Country_list()
        For Each cl As CultureInfo In CultureInfo.GetCultures(CultureTypes.SpecificCultures)
            Dim reg As RegionInfo = New RegionInfo(cl.LCID)
            If (ComboBox1.Items.Contains(reg.EnglishName) = False) Then
                ComboBox1.Items.Add(reg.EnglishName)

            End If
            ComboBox1.Sorted = True
        Next
    End Sub
    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        login_page.Show()
        Hide()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim usrname = Me.username.Text
            Dim fulln = Me.f_name.Text
            Dim phoneno = Me.phno.Text
            Dim passwd = pass.Text
            Dim r_passwd = r_pass.Text
            Dim county = Me.ComboBox1.SelectedItem.ToString
            Dim mail = email.Text

            If confrugration_password And confrugration_username And confrugration_phoneno Then
                Insert_new_user(usrname, fulln, passwd, phoneno, county, mail)
                result.Text = "Registered Sucessfully"
            Else
                result.Text = "Invalid Input"
            End If
            result_panel.Visible = True
        Catch ex As Exception
            result.Text = "Somthing went wrong "
            Console.WriteLine(ex.ToString)
            result_panel.Visible = True
        End Try
        con.Close()
    End Sub
    Private Sub Excp_Sql(ByVal ex)
        MsgBox("error" + ex.ToString)
        If ex.Number = 2627 Then
            result.Text = "User Already Exist ," & vbCrLf & " please try with different" & vbCrLf & " User name"
            result_panel.Visible = True
        Else
            result.Text = "Somthing went wrong "
            Console.WriteLine(ex.ToString)
            result_panel.Visible = True
        End If
    End Sub
    Private Sub Insert_new_user(ByVal uname, ByVal fullname, ByVal passwd, ByVal phno, ByVal country, ByVal mail)
        Dim command As New SqlCommand
        Dim da As New SqlDataAdapter
        command.Connection = con
        command.CommandText = "INSERT INTO valid_user(username,fullname,passwd,phno,country,profile_pic,mail,isadmin) VALUES(@name,@fullname,@passwd,@phno,@country,@pp,@mail,@isadmin)"

        Dim param_name As New SqlParameter("@name", SqlDbType.VarChar, 50) With {
            .Value = uname
        }
        Dim param_full As New SqlParameter("@fullname", SqlDbType.VarChar, 50) With {
            .Value = fullname}

        Dim param_passwd As New SqlParameter("@passwd", SqlDbType.VarChar, 30) With {
            .Value = passwd
        }
        Dim param_phone As New SqlParameter("@phno", SqlDbType.VarChar, 50) With {
            .Value = phno
        }
        Dim param_country As New SqlParameter("@country", SqlDbType.VarChar, 10) With {
            .Value = country
        }
        Dim param_pp As New SqlParameter("@pp", SqlDbType.VarChar, 150) With {
            .Value = "C:\Users\HASEEF\source\repos\login_page\login_page\Resources\User-Account-PNG-Image(1)1.png"
        }
        Dim param_mail As New SqlParameter("@mail", SqlDbType.VarChar, 50) With {
            .Value = mail
        }
        Dim Isadmin As New SqlParameter("@isadmin", SqlDbType.Int, 5) With {
            .Value = 0
        }

        command.Parameters.Add(param_name)
        command.Parameters.Add(param_full)
        command.Parameters.Add(param_passwd)
        command.Parameters.Add(param_phone)
        command.Parameters.Add(param_country)
        command.Parameters.Add(param_pp)
        command.Parameters.Add(param_mail)
        command.Parameters.Add(Isadmin)
        da.InsertCommand = command

        Try
            da.InsertCommand.ExecuteNonQuery()
        Catch ex As SqlException
            Excp_Sql(ex)
        End Try


    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles username.TextChanged

        If username.Text.Contains(" ") Then
            MsgBox("please Use Underscore '_' not space")
            username.Text = username.Text.Substring(0, username.Text.Length - 1)
        End If
        If username.Text.Length > 2 Then
            check_aval.Visible = True
            'Checks If username is Avaiable in database or not
            Check_Avaliablity(username.Text)
        Else
            check_aval.Visible = False
        End If

    End Sub
    Private Sub Check_Avaliablity(ByVal name)
        Dim cmd As New SqlCommand
        Dim sql As String
        sql = "select count(username) from valid_user where username = '" + name + "'"
        cmd.Connection = con
        cmd.CommandText = sql
        Dim ans = cmd.ExecuteScalar()
        If ans >= 1 Then
            check_aval.Text = "Not Available"
            check_aval.ForeColor = Color.Tomato
            confrugration_username = False
        Else
            check_aval.Text = "Available"
            check_aval.ForeColor = Color.Lime
            confrugration_username = True
        End If

    End Sub

    Private Sub phno_TextChanged(sender As Object, e As EventArgs) Handles phno.TextChanged
        Check_phno.Visible = True
        If phno.Text.Length >= 10 And phno.Text.Length < 13 Then
            If IsNumeric(phno.Text) Then
                Check_phno.Text = "Ok"
                Check_phno.ForeColor = Color.Lime
                confrugration_phoneno = True
            Else
                Check_phno.Text = "Not Valid"
                Check_phno.ForeColor = Color.Tomato
                confrugration_phoneno = False
            End If
        Else
            Check_phno.Text = "Not Valid"
            Check_phno.ForeColor = Color.Tomato
            confrugration_phoneno = False
        End If

    End Sub
    Private Sub email_TextChanged(sender As Object, e As EventArgs) Handles email.TextChanged
        Email_Validation.Visible = True
        If email.Text.Contains("@") And email.Text.Contains(".com") Then
            Email_Validation.Text = "Ok"
            Email_Validation.ForeColor = Color.Lime
        Else
            Email_Validation.Text = "Email Not Valid"
            Email_Validation.ForeColor = Color.Tomato
        End If
    End Sub

    Private Sub r_pass_TextChanged(sender As Object, e As EventArgs) Handles r_pass.TextChanged
        If pass.Text = r_pass.Text Then
            confrugration_password = True
            mismatch.Visible = False
        Else
            mismatch.Visible = True
            confrugration_password = False
        End If
    End Sub
    Private Sub pass_TextChanged(sender As Object, e As EventArgs) Handles pass.TextChanged
        If pass.TextLength >= 6 And pass.TextLength <= 15 Then
            pass_validation.Visible = False
        Else
            pass_validation.Visible = True
        End If
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
        login_page.Show()
    End Sub
    'UI Design
    Private Sub TextBox1_Click(sender As Object, e As EventArgs) Handles username.Click
        Changepanelcolor(Panel1)
    End Sub
    Private Sub f_name_Click(sender As Object, e As EventArgs) Handles f_name.Click
        Changepanelcolor(Panel10)
    End Sub

    Private Sub TextBox2_Click(sender As Object, e As EventArgs) Handles phno.Click
        Changepanelcolor(Panel2)
    End Sub
    Private Sub TextBox3_Click(sender As Object, e As EventArgs) Handles pass.Click
        Changepanelcolor(Panel3)
    End Sub
    Private Sub TextBox4_Click(sender As Object, e As EventArgs) Handles r_pass.Click
        Changepanelcolor(Panel4)
    End Sub
    Private Sub TextBox5_Click(sender As Object, e As EventArgs) Handles email.Click
        Changepanelcolor(Panel5)
    End Sub
    Private Sub TextBox6_Click(sender As Object, e As EventArgs)
        Changepanelcolor(Panel6)
    End Sub
    Private Sub Changepanelcolor(ByRef pnl_name)
        MakeAllWhite()
        pnl_name.Backcolor = Color.FromKnownColor(KnownColor.MenuHighlight)
    End Sub
    Private Sub MakeAllWhite()
        Panel1.BackColor = Color.White
        Panel2.BackColor = Color.White
        Panel3.BackColor = Color.White
        Panel4.BackColor = Color.White
        Panel5.BackColor = Color.White
        Panel6.BackColor = Color.White
        Panel10.BackColor = Color.White

    End Sub
    Private Sub Button1_MouseHover(sender As Object, e As EventArgs) Handles Button1.MouseHover
        Button1.FlatAppearance.BorderSize = 3
        Button1.BackColor = Color.FromArgb(105, 102, 102)
    End Sub
    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave
        Button1.FlatAppearance.BorderSize = 0
        Button1.BackColor = Color.Silver
    End Sub
End Class