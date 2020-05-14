Public Class Form1
    Dim a As New ArrayList
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FileOpen(1, "in1.txt", OpenMode.Input)
        FileOpen(2, "in2.txt", OpenMode.Input)
        FileOpen(3, "output.txt", OpenMode.Output)

        For i = 1 To 2
            Dim m0 As Integer = LineInput(i)
            For j = 1 To m0
                Dim b() As String = Split(LineInput(i), ",")
                a.Clear()
                a.Add("")
                Call calc(0, b(0), "")
                Print(3, Trim(ans(a(b(1)), a(b(2)))) & vbNewLine)
            Next
            Print(3, vbNewLine)
        Next

        FileClose(1)
        FileClose(2)
        FileClose(3)

        Close()
    End Sub
    Function calc(ByVal n As Integer, ByVal b As String, ByVal answer As String)

        If n = Len(b) Then
            a.Add(answer)
        Else
            For k = 1 To Len(b)
                If InStr(answer, Mid(b, k, 1)) = 0 Then Call calc(n + 1, b, answer & Mid(b, k, 1))
            Next
        End If

    End Function
    Function ans(ByVal c, ByVal d)

        If d = 0 Then
            Return c
        Else
            Return ans(d, c Mod d)
        End If

    End Function
End Class
