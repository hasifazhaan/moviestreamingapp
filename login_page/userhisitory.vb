Public Class userhistory
    Public history As Panel
    Dim p As Panel
    Public Sub Userhisitory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '   history.AutoScroll = True
        '   history.Size = New Size(1452, 600)
        '  history.BackColor = Color.AntiqueWhite
        Dim sql_history = "SELECT * from allmovie where movie_id in(SELECT movie_id from history where history.user_id = '" + main_page.Userid + "'  ) "
        main_page.ReadFromDb(sql_history, Me.pic_his)

        Me.BringToFront()
        emptylab1.Visible = False
        emptylab2.Visible = False




    End Sub
    Public Sub CheckIfUserStore(ByRef root, ByRef l1, ByRef l2)
        For Each ctrl As Control In root.Controls
            If TypeOf ctrl Is PictureBox Then
                l1.Visible = False
                l2.Visible = False
                Exit Sub
            End If


        Next ctrl
        l1.Visible = True
        l2.Visible = True
    End Sub

    Private Sub emptylab2_Click(sender As Object, e As EventArgs) Handles emptylab2.Click

    End Sub
End Class