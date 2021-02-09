Public Class FormEntertainment
    Private I As Integer
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Call Restart()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.Hide()
        Home_Page.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        EntertainmentBotParts.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Schematics.Show()
    End Sub

    Private Sub FormEntertainment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        I = 0
        PictureBox2.Load(EPics(I))
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If I < 2 Then
            I = I + 1
            PictureBox2.Load(EPics(I))
        Else
            I = 0
            PictureBox2.Load(EPics(I))
        End If
    End Sub
End Class