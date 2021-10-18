Imports System.Data.SqlClient
Imports System.Net.Mail
Imports System.Net.Mime

Public Class forgotpwd_page
    Dim con = login_page.con
    Dim mail_id
    Dim passwd
    Private Sub Exit_button_Click(sender As Object, e As EventArgs) Handles Exit_button.Click
        Me.Close()
        login_page.Show()
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

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim cmd As New SqlCommand
        Dim sql As String
        Dim dr As SqlDataReader
        'sql command to validate if user is in database
        sql = "select * from valid_user where username  = '" + (TextBox1.Text) + "'"
        cmd.Connection = con
        cmd.CommandText = sql
        dr = cmd.ExecuteReader
        res_pnl.Visible = True
        If dr.Read Then
            SendEmail(dr)

        Else
            res.Text = "Failure.
You Dont Have Account. Please Try With Valid Username"

        End If
        dr.Close()
    End Sub

    Private Sub okbtn_Click(sender As Object, e As EventArgs) Handles okbtn.Click
        res_pnl.Visible = False
        login_page.Show()
        Me.Hide()

    End Sub
    Private Sub SendEmail(ByVal details)
        Try
            getuersDetails(details)
            Dim Smtp_Server As New SmtpClient
            Dim e_mail As New MailMessage()
            Smtp_Server.UseDefaultCredentials = False
            Smtp_Server.Credentials = New Net.NetworkCredential("binger.movieapp@gmail.com", "1234@qwerty")
            Smtp_Server.Port = 587
            Smtp_Server.EnableSsl = True
            Smtp_Server.Host = "smtp.gmail.com"

            e_mail = New MailMessage()
            e_mail.From = New MailAddress("binger.movieapp@gmail.com")
            e_mail.To.Add(mail_id)
            e_mail.Subject = "Forgot Password"
            e_mail.IsBodyHtml = False

            Dim emailBody = "Hey " + TextBox1.Text + ", We Heard You Forgot Your Password , Don't Worry We Have It Kept It Safe . Below You Can Find Your Password." + vbCrLf + vbCrLf + vbCrLf +
                "Your Password is :" + passwd
            e_mail.Body = emailBody
            Smtp_Server.Send(e_mail)
            res.Text = "Sucess.
Your Password Is Send To Your Email Id"
        Catch error_in As ArgumentException
            res.Text = "You Have Not Provided Your Email id " + vbCrLf + "Please Contact Administrator" + vbCrLf + vbCrLf + vbCrLf + "Administrator Email: binger.movieapp@gmail.com"
        Catch ex As Exception
            res.Text = "Failure.
Internal Problem Occured"
        End Try

    End Sub

    Private Sub getuersDetails(ByVal details)
        mail_id = details("mail")
        passwd = details("passwd")
    End Sub
End Class