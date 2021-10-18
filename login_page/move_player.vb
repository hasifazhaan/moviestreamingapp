Public Class move_player
    Private Sub move_player_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna2Button1.Location = New Point((pa.Width - Guna2Button1.Width) \ 2, (pa.Height - Guna2Button1.Height) \ 2)
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        pa.playlist.next()
        Guna2Button1.Visible = False
    End Sub

    Private Sub move_player_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        main_page.Show()
    End Sub

    Private Sub pa_Enter(sender As Object, e As EventArgs) Handles pa.Enter

    End Sub

    Private Sub Guna2CircleButton1_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton1.Click
        main_page.WindowState = FormWindowState.Normal
        Me.Close()
    End Sub
End Class

