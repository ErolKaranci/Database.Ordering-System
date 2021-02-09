Public Class HouseholdSummary
    Private total As Integer
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Call Restart()
    End Sub

    Private Sub HouseholdSummary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatabasesFP1DataSet.Household' table. You can move, or remove it, as needed.
        Me.HouseholdTableAdapter.Fill(Me.DatabasesFP1DataSet.Household)

    End Sub
    Private Sub XABLE()
        Button1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
        Button4.Enabled = True
        Button5.Enabled = True
        Button6.Enabled = True
        Button7.Enabled = True
        Button8.Enabled = True

    End Sub
    Private Sub xDisABLE()
        Button1.Enabled = False
        Button2.Enabled = False
        Button3.Enabled = False
        Button4.Enabled = False
        Button5.Enabled = False
        Button6.Enabled = False
        Button7.Enabled = False
        Button8.Enabled = False
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Add
        If Button1.Text = "Add" Then
            Call xDisABLE()
            Button1.Enabled = True
            Button1.Text = "Save"
            HouseholdBindingSource.AddNew()

        Else
            HouseholdBindingSource.EndEdit()
            HouseholdTableAdapter.Update(DatabasesFP1DataSet.Household)
            Call XABLE()
            Button1.Text = "Add"
            total = total + 1
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        HouseholdBindingSource.RemoveCurrent()
        HouseholdTableAdapter.Update(DatabasesFP1DataSet)
        total = total - 1
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Button3.Text = "Modify" Then
            Call xDisABLE()
            Button3.Enabled = True
            Button3.Text = "Save"
            Validate()

        Else
            HouseholdBindingSource.EndEdit()
            HouseholdTableAdapter.Update(DatabasesFP1DataSet.Household)
            Call XABLE()
            Button3.Text = "Modify"
            total = total + 1

        End If
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        HouseholdBindingSource.MoveFirst()
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim RecNum As Long
        RecNum = HouseholdBindingSource.Position
        If RecNum = total - 1 Then
            Call Button4_Click(sender, e)
        Else
            HouseholdBindingSource.MoveNext()
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        HouseholdBindingSource.MovePrevious()
    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        HouseholdBindingSource.MoveLast()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim K, Target As Long
        Dim Userrep, Key As String
        Userrep = CStr(InputBox("Enter a client"))

        Target = -1
        HouseholdBindingSource.MoveFirst()
        For K = 0 To total - 1
            Key = DatabasesFP1DataSet.Military(K).Client
            If Userrep = Key Then
                Target = K
                Exit For
            End If
            HouseholdBindingSource.MoveNext()
        Next
    End Sub
End Class