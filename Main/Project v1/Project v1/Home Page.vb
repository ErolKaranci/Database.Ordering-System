Public Class Home_Page
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Call Restart()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Hide()
        FormMillitary.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Hide()
        FormHousehold.Show()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.Hide()
        FormEntertainment.Show()
    End Sub

    Private Sub Home_Page_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class