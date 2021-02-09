Public Class Form_MillitaryRobot
    Private Material, Manufacturing, Coloring, Features As Integer
    Private Cost, TCost As Double
    Private T1, T2, T3, T4, Time, TTime As Double

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        FormMillitary.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        CustomerSummary.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox1.Text = 1
        RadioButton1.Checked = True
        RadioButton11.Checked = True
        RadioButton8.Checked = True
        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox3.Checked = False
        CheckBox4.Checked = False
        CheckBox5.Checked = False
        CheckBox6.Checked = False
        Call TextBoxInput()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'Adds contents to database used on Millitary Summary, Customer Summary, and Manager Summary

        MBuildTime = TTime + MBuildTime
        MTCost = MTCost + TCost
        MAQuantity = CInt(TextBox1.Text)
        MQuantity = CInt(TextBox1.Text) + MQuantity
        MsgBox("Order Recieved!")


        ReDim Preserve MQ(0 To Mn)
        ReDim Preserve MC(0 To Mn)
        ReDim Preserve MT(0 To Mn)
        MQ(Mn) = MAQuantity
        MC(Mn) = MTCost
        MT(Mn) = MBuildTime

        Mn = Mn + 1

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.Hide()
        Home_Page.Show()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Call Restart()
    End Sub

    Private Sub Form_MillitaryRobot_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RadioButton1.Checked = True
        RadioButton11.Checked = True
        RadioButton8.Checked = True
    End Sub

    Private Sub Group1(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged, RadioButton2.CheckedChanged, RadioButton3.CheckedChanged, RadioButton4.CheckedChanged
        Select Case True
            Case RadioButton1.Checked
                Material = 500
                T1 = 30 / 60
            Case RadioButton2.Checked
                Material = 700
                T1 = 35 / 60
            Case RadioButton3.Checked
                Material = 1000
                T1 = 40 / 60
            Case RadioButton4.Checked
                Material = 750
                T1 = 60 / 60
        End Select

        Call TextBoxInput()
    End Sub

    Private Sub Group2(sender As Object, e As EventArgs) Handles RadioButton9.CheckedChanged, RadioButton10.CheckedChanged, RadioButton11.CheckedChanged
        Select Case True
            Case RadioButton9.Checked
                Manufacturing = 800
                T2 = (T1 * 1)
            Case RadioButton10.Checked
                Manufacturing = 600
                T2 = (T1 * 0.5)
            Case RadioButton11.Checked
                Manufacturing = 500
                T2 = (T1 * 0.25)
        End Select
        Call TextBoxInput()
    End Sub

    Private Sub Group3(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged, RadioButton6.CheckedChanged, RadioButton7.CheckedChanged, RadioButton8.CheckedChanged, RadioButton13.CheckedChanged, RadioButton15.CheckedChanged, RadioButton16.CheckedChanged, RadioButton17.CheckedChanged
        Select Case True
            Case RadioButton5.Checked
                Coloring = 250
                T3 = 15 / 60
            Case RadioButton6.Checked
                Coloring = 250
                T3 = 15 / 60
            Case RadioButton7.Checked
                Coloring = 250
                T3 = 15 / 60
            Case RadioButton8.Checked
                Coloring = 250
                T3 = 15 / 60
            Case RadioButton13.Checked
                Coloring = 200
                T3 = 7.5 / 60
            Case RadioButton15.Checked
                Coloring = 300
                T3 = 20 / 60
            Case RadioButton16.Checked
                Coloring = 200
                T3 = 5 / 60
            Case RadioButton17.Checked
                Coloring = 200
                T3 = 7.5 / 60
        End Select
        Call TextBoxInput()
    End Sub

    Private Sub Group4(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged, CheckBox2.CheckedChanged, CheckBox3.CheckedChanged, CheckBox4.CheckedChanged, CheckBox5.CheckedChanged, CheckBox6.CheckedChanged
        Dim F1, F2, F3, F4, F5, F6 As Integer
        Dim TF1, TF2, TF3, TF4, TF5, TF6 As Double
        If CheckBox1.Checked = True Then
            F1 = 150
            TF1 = 5 / 60
        ElseIf CheckBox1.Checked = False Then
            F1 = 0
            TF1 = 0
        End If

        If CheckBox2.Checked = True Then
            F2 = 275
            TF2 = 1 / 3
        ElseIf CheckBox2.Checked = False Then
            F2 = 0
            TF2 = 0
        End If

        If CheckBox3.Checked = True Then
            F3 = 500
            TF3 = 1 / 6
        ElseIf CheckBox3.Checked = False Then
            F3 = 0
            TF3 = 0
        End If

        If CheckBox4.Checked = True Then
            F4 = 2000
            TF4 = 1 / 6
        ElseIf CheckBox4.Checked = False Then
            F4 = 0
            TF4 = 0
        End If

        If CheckBox5.Checked = True Then
            F5 = 75
            TF5 = 1 / 4
        ElseIf CheckBox5.Checked = False Then
            F5 = 0
            TF5 = 0
        End If

        If CheckBox6.Checked = True Then
            F6 = 40
            TF6 = 5 / 60
        ElseIf CheckBox6.Checked = False Then
            F6 = 0
            TF6 = 0
        End If

        Features = F1 + F2 + F3 + F4 + F5 + F6
        T4 = TF1 + TF2 + TF3 + TF4 + TF5 + TF6
        Call TextBoxInput()
    End Sub

    Private Sub TextBoxInput()
        Time = T1 + T2 + T3 + T4
        Time = Math.Round(Time, 2)
        Cost = Material + Manufacturing + Coloring + Features
        Cost = Math.Round(Cost, 2)
        TTime = (Time * CInt(TextBox1.Text)) / 8
        TTime = Math.Round(TTime, 2)
        TCost = Cost * CInt(TextBox1.Text)
        TCost = Math.Round(TCost, 2)
        TextBox2.Text = "$" & CStr(Cost)
        TextBox3.Text = "$" & CStr(TCost)
        TextBox4.Text = CStr(Time) & "hr"
        TextBox5.Text = CStr(TTime) & "d"
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text = "" Then
            TextBox1.Text = "1"
        End If

        Call TextBoxInput()
    End Sub
End Class