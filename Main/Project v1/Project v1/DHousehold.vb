Public Class FormHousehold
    Private I As Integer
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Call Restart()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.Hide()
        Home_Page.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        HouseHoldRobotA.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        HouseHoldRobotB.Show()
    End Sub

    Private Sub FormHousehold_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        I = 0
        PictureBox2.Load(HPics(I))
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If I < 2 Then
            I = I + 1
            PictureBox2.Load(HPics(I))
        Else
            I = 0
            PictureBox2.Load(HPics((I)))
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If I > 0 Then
            I = I - 1
            PictureBox2.Load(HPics(I))
        Else
            I = 2
            PictureBox2.Load(HPics((I)))
        End If
    End Sub
End Class