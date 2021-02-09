Module Module1
    Public EPics(), MPics(), HPics() As String
    Public a, b, c, EParts, NRobotA, NRobotB, MQuantity As Integer
    Public ETCost, MBuildTime, MTCost As Double

    Public MQ(), MT(), MC(), Mn As Double

    Public C1, C2, C3, C4, C5, C6, C7, C8, C88, C9, C10, C11, C12, MAQuantity As Integer

    Public Sub FormPictures()

        FileOpen(1, “MillitaryPics.txt”, OpenMode.Input)

        Do Until EOF(1)
            ReDim Preserve MPics(0 To a)
            Input(1, MPics(a))

            a = a + 1
        Loop
        FileClose(1)

        FileOpen(2, “HouseholdPics.txt”, OpenMode.Input)

        Do Until EOF(2)
            ReDim Preserve HPics(0 To b)
            Input(2, HPics(b))

            b = b + 1
        Loop
        FileClose(2)


        FileOpen(3, “EntertainmentPics.txt”, OpenMode.Input)

        Do Until EOF(3)
            ReDim Preserve EPics(0 To c)
            Input(3, EPics(c))

            c = c + 1
        Loop
        FileClose(3)

    End Sub

    Public Sub Restart()
        Application.Restart()
        FormLogin.Show()
    End Sub
End Module
