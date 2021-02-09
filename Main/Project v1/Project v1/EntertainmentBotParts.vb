Public Class EntertainmentBotParts
    Private ECost, Parts As Double
    Private I As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        FormEntertainment.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Schematics.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        CustomerSummary.Show()
    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click
        Me.Hide()
        Home_Page.Show()
    End Sub

    Private Sub Label15_Click(sender As Object, e As EventArgs) Handles Label15.Click
        Call Restart()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        'Calculates Total Cost

        Parts = CDbl(TextBox1.Text) + CDbl(TextBox2.Text) + CDbl(TextBox3.Text) + CDbl(TextBox4.Text) + CDbl(TextBox5.Text) + CDbl(TextBox6.Text) + CDbl(TextBox7.Text) + CDbl(TextBox8.Text) + CDbl(TextBox9.Text) + CDbl(TextBox10.Text) + CDbl(TextBox11.Text) + CDbl(TextBox12.Text)
        ECost = CInt(TextBox1.Text) * 10 + CInt(TextBox2.Text) * 0.5 + CInt(TextBox3.Text) * 2 + CInt(TextBox4.Text) * 0.25 + CInt(TextBox5.Text) * 0.33 + CInt(TextBox6.Text) * 0.5 + CInt(TextBox7.Text) * 1.5 + CInt(TextBox8.Text) * 1 + CInt(TextBox9.Text) * 0.05 + CInt(TextBox10.Text) * 0.08 + CInt(TextBox11.Text) * 0.1 + CInt(TextBox12.Text) * 5
        TextBox13.Text = Format(ECost, "$.00")
    End Sub



    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click


        If I = 0 Then
            ETCost = ECost
            EParts = Parts
            MsgBox("Order Input Recieved!")
            I = 1
        Else
            ETCost = ECost
            EParts = Parts
            MsgBox("Order Changed!")
        End If

        C1 = TextBox1.Text
        C2 = TextBox2.Text
        C3 = TextBox3.Text
        C4 = TextBox4.Text
        C5 = TextBox5.Text
        C6 = TextBox6.Text
        C7 = TextBox7.Text
        C88 = TextBox8.Text
        C9 = TextBox9.Text
        C10 = TextBox10.Text
        C11 = TextBox11.Text
        C12 = TextBox12.Text

    End Sub
End Class