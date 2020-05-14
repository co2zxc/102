Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FileOpen(1, "in1.txt", OpenMode.Input)
        FileOpen(2, "in2.txt", OpenMode.Input)
        FileOpen(3, "output.txt", OpenMode.Output)

        ' Dim s As String = My.Computer.FileSystem.ReadAllText("C:123.txt") 一次讀完

        ' My.Computer.FileSystem.WriteAllText("C:123.txt", s, True) 一次寫完,ture:可以重複寫進去而不遺失

        Dim text
        For i = 1 To 2
            Dim m0 As Integer = LineInput(i)
            Dim a(m0) As String
            For j = 1 To m0
                Input(i, a(j))
                Dim b(m0) As String
                For k = 1 To Len(a(j))
                    If Mid(a(j), k, 1) <= "9" And Mid(a(j), k, 1) >= "0" Then
                        b(j) &= Mid(a(j), k, 1)
                    End If
                Next
                Dim c(m0)
                For k = 0 To 9
                    For l = 1 To Len(b(j))
                        If Mid(b(j), l, 1) = k Then
                            c(j) &= k
                            Exit For
                        End If
                    Next
                Next
                If c(j) = "" Then c(j) = "N"
                text &= c(j) & vbNewLine
            Next
            text = text & vbNewLine
        Next

        PrintLine(3, text)
        FileClose(1)
        FileClose(2)
        FileClose(3)

        Close()
    End Sub
End Class
