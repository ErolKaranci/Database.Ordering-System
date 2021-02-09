Public Class FormLogin
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Select Case True
            Case TextBox1.Text = "Customer" And TextBox2.Text = "Generic"
                TextBox1.Text = ""
                TextBox2.Text = ""
                Me.Hide()
                Home_Page.Show()
            Case TextBox1.Text = "Employee" And TextBox2.Text = "Household"
                TextBox1.Text = ""
                TextBox2.Text = ""
                Me.Hide()
                HouseholdSummary.Show()
            Case TextBox1.Text = "Employee" And TextBox2.Text = "Millitary"
                TextBox1.Text = ""
                TextBox2.Text = ""
                Me.Hide()
                MillitarySummary.Show()
            Case TextBox1.Text = "Employee" And TextBox2.Text = "Entertainment"
                TextBox1.Text = ""
                TextBox2.Text = ""
                Me.Hide()
                EntertainmentSummary.Show()
            Case TextBox1.Text = "Manager" And TextBox2.Text = "Showtime"
                TextBox1.Text = ""
                TextBox2.Text = ""
                Me.Hide()
                ManagerSummary.Show()
            Case TextBox1.Text = "" Or TextBox2.Text = ""
                MsgBox("Please fill in all information")
            Case Else
                MsgBox("Username or password is incorrect")
                TextBox2.Text = ""
        End Select
    End Sub

    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call FormPictures()
    End Sub
End Class
