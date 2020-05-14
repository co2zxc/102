Public Class Form2

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim a(4) As String
        FileOpen(1, "in2.txt", OpenMode.Input)
        For i = 1 To 4
            Input(1, a(i))
        Next
        FileClose(1)

        Dim b(3), c(3)
        For i = 2 To 4
            b(i - 1) = Len(a(i))
            For j = 1 To b(i - 1)
                If Mid(a(i), j, 1) >= "0" And Mid(a(i), j, 1) <= "9" Then
                    c(i - 1) &= Mid(a(i), j, 1)
                End If
            Next
        Next

        Dim d(3, 25)
        For i = 1 To 3
            For j = 1 To Len(c(i))
                d(i, j) = Mid(c(i), j, 1)
            Next
        Next

        For i = 1 To 3
            For j = 1 To Len(c(i)) - 1
                For k = 1 To Len(c(i)) - 1
                    If d(i, k) > d(i, k + 1) Then
                        d(i, 0) = d(i, k) : d(i, k) = d(i, k + 1) : d(i, k + 1) = d(i, 0)
                    End If
                Next
            Next
        Next

        Dim a1(3)
        For i = 1 To 3
            For j = 1 To 25
                a1(i) &= d(i, j)
            Next
        Next

        Dim m(3) As String
        For i = 1 To 3
            For j = 0 To 9
                For k = 1 To Len(a1(i))
                    If Mid(a1(i), k, 1) = j Then
                        m(i) &= j
                        Exit For
                    End If
                Next
            Next
        Next

        For i = 1 To 3
            If m(i) = "" Then
                m(i) = "N"
            End If
        Next

        FileOpen(1, "商科子題二in2", OpenMode.Output)
        For i = 1 To 3
            PrintLine(1, m(i))
        Next
        FileClose(1)

        Me.Close()

    End Sub
End Class