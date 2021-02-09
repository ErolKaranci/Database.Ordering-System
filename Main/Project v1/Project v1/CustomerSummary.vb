Public Class CustomerSummary
    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        Call Restart()
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        Me.Close()
        Home_Page.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Checkout.Show()
    End Sub

    Private Sub CustomerSummary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cost As Double
        Dim T1 As Integer

        TextBox1.Text = NRobotA
        TextBox2.Text = NRobotB

        TextBox6.Text = TextBox3.Text + TextBox4.Text + TextBox5.Text
        TextBox1.Text = NRobotA
        TextBox2.Text = NRobotB
        cost = (NRobotA * 150) + (NRobotB * 400)
        TextBox3.Text = CStr(cost)

        TextBox4.Text = MTCost
        ListBox1.Items.Add("Order" & vbTab & "Quantity" & vbTab & "Time (d)" & vbTab & "Cost")

        If Mn <> 0 Then
            Do Until T1 = Mn
                ListBox1.Items.Add(T1 + 1 & vbTab & MQ(T1) & vbTab & MT(T1) & vbTab & MC(T1) & vbNewLine)

                T1 = T1 + 1
            Loop
        End If

        TextBox5.Text = ETCost
        ListBox2.Items.Add("Item" & vbTab & vbTab & "Count")
        ListBox2.Items.Add("Controller" & vbTab & vbTab & C1)
        ListBox2.Items.Add("Shaft" & vbTab & vbTab & C2)
        ListBox2.Items.Add("Wheels" & vbTab & vbTab & C3)
        ListBox2.Items.Add("12 Tooth Gear" & vbTab & C4)
        ListBox2.Items.Add("36 Tooth Gear" & vbTab & C5)
        ListBox2.Items.Add("76 Tooth Gear" & vbTab & C6)
        ListBox2.Items.Add("4in Wheel" & vbTab & C7)
        ListBox2.Items.Add("C Chanel" & vbTab & vbTab & C88)
        ListBox2.Items.Add("Pop Rivet" & vbTab & C9)
        ListBox2.Items.Add("Keps Nuts" & vbTab & C10)
        ListBox2.Items.Add("Screw" & vbTab & vbTab & C11)
        ListBox2.Items.Add("Motor" & vbTab & vbTab & C12)
    End Sub


End Class