Public Class Checkout
    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        Call Restart()
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        Me.Hide()
        Home_Page.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Then
            MsgBox("Please Fill In All Data")
        ElseIf TextBox3.Text = TextBox4.Text Then
            MsgBox("Purchase Successful!")
            End
        Else
                MsgBox("Credit Card Number's Do Not Match!")
                TextBox4.Text = ""

        End If

    End Sub


End Class