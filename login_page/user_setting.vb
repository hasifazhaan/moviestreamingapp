Imports System.Data.SqlClient

Public Class user_setting
    Dim con As New SqlConnection
    Dim pass_auth = False
    Private pass


    Private Sub LoadPage(sender As Object, e As EventArgs) Handles MyBase.Load
        con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HASEEF\source\repos\login_page\login_page\Database1.mdf;Integrated Security=True"
        con.Open()
        Res_panel.BringToFront()

        GetUserDetail()
    End Sub

    Private Sub ChangeDp_Click(sender As Object, e As EventArgs) Handles ChangeDp.Click
        Dim changeimage = " "
        OpenFileDialog1.Filter = "All Media Files|*.bmp;*.png;*.jpg;*.gif;*.tif"
        OpenFileDialog1.FilterIndex = 1
        OpenFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Recent)
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            changeimage = OpenFileDialog1.FileName
        Else
            Exit Sub
        End If

        Dim query = "update valid_user set profile_pic = '" + changeimage + "' where username = '" + main_page.Userid + "'"
        Dim cm As New SqlCommand With {
            .Connection = con,
            .CommandText = query}
        If cm.ExecuteNonQuery() Then
            Res_panel.Visible = True
            Resultlab.Text = "You Have Changed Sucessfully"

        End If

        GetUserDetail()
        main_page.Setuserdp()
    End Sub


    Public Sub GetUserDetail()
        Dim dr = main_page.Select_user()
        While dr.Read
            full_name.Text = dr("fullname")
            usr_name.Text = dr("username")
            usr_email.Text = dr("mail")
            usr_country.Text = dr("country")
            pass = dr("passwd")
            usr_phno.Text = dr("phno")
            profile_picture.Image = Image.FromFile(dr("profile_pic"))
        End While
        dr.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ShowSpecificPanel(Newpass_panel)
    End Sub
    Private Sub ValidateUpdate(ByRef value, ByVal updatehere)
        Dim query = "update valid_user set " + updatehere + " = '" + value.Text + "' where username = '" + main_page.Userid + "'"
        If UpdateUserDetail(query) Then
            Res_panel.Visible = True
            Res_panel.BringToFront()
            Resultlab.Text = "You Have Changed Sucessfully"
            value.Text = ""
            HideAllPanels()
            GetUserDetail()
        Else
            Res_panel.Visible = True
            Resultlab.Text = "Somthing Went Wrong ." + vbCrLf + " Please Try Again!"
            value.Text = ""
        End If
    End Sub
    Private Sub ChangePassword_Click(sender As Object, e As EventArgs) Handles ChangePassword.Click
        Authenticate_pass()
        If pass_auth Then
            If newp.Text = r_newp.Text Then
                ValidateUpdate(newp, "passwd")
                GetUserDetail()
            Else
                Res_panel.Visible = True
                Resultlab.Text = "Password Mis Match "

            End If
        Else
            Res_panel.Visible = True
            Resultlab.Text = "Old Password Do Not " + vbCrLf + "Match With Our Database "

        End If


    End Sub
    Private Function UpdateUserDetail(ByVal query)
        Dim cm As New SqlCommand With {
            .Connection = con,
            .CommandText = query}
        Dim res = cm.ExecuteNonQuery()
        Return res
    End Function

    Private Sub Authenticate_pass()
        If pass = old.Text Then
            pass_auth = True
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Res_panel.Visible = False
    End Sub

    Private Sub ShowEmail_panel_Click(sender As Object, e As EventArgs) Handles ShowEmail_panel.Click
        ShowSpecificPanel(newEmail_panel)
    End Sub
    Private Sub ShowSpecificPanel(ByRef panel)
        If panel.visible = False Then
            HideAllPanels()
            panel.visible = True
        Else
            panel.visible = False
        End If
    End Sub
    Private Sub HideAllPanels()
        newEmail_panel.Visible = False
        Newcount_panel.Visible = False
        Newpass_panel.Visible = False
        NewPhno_panel.Visible = False

    End Sub

    Private Sub ShowPh_panel_Click(sender As Object, e As EventArgs) Handles ShowPh_panel.Click
        ShowSpecificPanel(NewPhno_panel)
    End Sub

    Private Sub ShowCount_panel_Click(sender As Object, e As EventArgs) Handles ShowCount_panel.Click
        ShowSpecificPanel(Newcount_panel)
    End Sub

    Private Sub ChangeEmail_Click(sender As Object, e As EventArgs) Handles ChangeEmail.Click
        ValidateUpdate(New_Email, "mail")
    End Sub

    Private Sub ChangePhoneno_Click(sender As Object, e As EventArgs) Handles ChangePhoneno.Click
        ValidateUpdate(New_phone, "phno")

    End Sub

    Private Sub ChangeCountry_Click(sender As Object, e As EventArgs) Handles ChangeCountry.Click
        ValidateUpdate(New_Country, "Country")
    End Sub

End Class