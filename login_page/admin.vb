Imports System.Data.SqlClient

Public Class admin
    Dim con As SqlConnection
    Dim directors As New List(Of String)()
    Dim genre As New List(Of String)()
    Dim stars As New List(Of String)()
    Dim movie_id As String
    Dim movie_name As String
    Private Sub add_movie_Click(sender As Object, e As EventArgs) Handles add_movie.Click
        Panel_add_movie.Visible = True
    End Sub

    Private Sub add_btn_Click(sender As Object, e As EventArgs)

    End Sub
    Dim x As Integer = 0
    Dim y As Integer = 0
    Dim z As Integer = 0
    Private Sub add_btn_Click_1(sender As Object, e As EventArgs) Handles add_btn.Click
        Panel_add.Visible = True
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles addtodir.Click
        Dim name As String = dir.Text
        Createtb(directors, name, Panel_dir, x)
        x += 120
    End Sub

    Private Sub addtogen_Click(sender As Object, e As EventArgs) Handles addtogen.Click
        Dim name As String = gen.Text
        Createtb(genre, name, Panel_gen, y)
        y += 120
    End Sub

    Private Sub Createtb(ByRef array, ByVal name, ByRef parent_panel, ByVal x)
        Dim tb As New TextBox
        tb.Text = name
        tb.Location = New Point(0 + x, 20)
        tb.ReadOnly = True
        parent_panel.Controls.Add(tb)
        array.Add(tb.Text)
    End Sub

    Private Sub addtostar_Click(sender As Object, e As EventArgs) Handles addtostar.Click
        Dim name As String = star.Text
        Createtb(stars, name, Panel_star, z)
        z += 120
    End Sub

    Private Sub add_todatabase_movie_Click(sender As Object, e As EventArgs) Handles add_todatabase_movie.Click
        con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HASEEF\source\repos\login_page\login_page\Database1.mdf;Integrated Security=True"
        con.Open()
        movie_id = m_id.Text
        movie_name = m_name.Text
        Dim rating As String = Rating_1.Text
        Dim details As String = RichTextBox1.Text

    End Sub
    Private Sub Addtodb(ByVal query, id, name)
        Dim cmd As New SqlCommand
        cmd.Connection = con
        cmd.CommandText = query
        Dim param_id As New SqlParameter("@id", SqlDbType.VarChar, 20)
        param_id.Value = id
        Dim param_name As New SqlParameter("@name", SqlDbType.VarChar, 50)
        param_name.Value = name
        cmd.Parameters.Add(param_id)
        cmd.Parameters.Add(param_name)
        Dim da As New SqlDataAdapter
        da.InsertCommand = cmd
        da.InsertCommand.ExecuteNonQuery()
        MsgBox("Inserted succesfully")

    End Sub
End Class