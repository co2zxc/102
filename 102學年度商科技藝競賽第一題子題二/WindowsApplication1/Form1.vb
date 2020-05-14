Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FileOpen(1, "in1.txt", OpenMode.Input)
        FileOpen(2, "in2.txt", OpenMode.Input)
        FileOpen(3, "output.txt", OpenMode.Output)

        For i = 1 To 2
            Dim m0 As Integer = LineInput(i)
            For j = 1 To m0
                Dim m1 As Integer = LineInput(i)
                Dim no(39) As Integer
                For k = 1 To m1
                    Dim a() = Split(LineInput(i), ",")
                    For l = 1 To UBound(a) 'a陣列的最後一筆
                        no(Val(a(l - 1))) += 1
                    Next
                Next
                Dim m2 = no(1)
                For k = 1 To 39
                    If no(k) > m2 Then m2 = no(k)
                Next
                Dim m3 As String = ""
                For k = 1 To 39
                    If no(k) = m2 Then
                        If k < 10 Then
                            m3 &= "0" & k & ","
                        Else
                            m3 &= k & ","
                        End If
                    End If
                Next
                m3 = Mid(m3, 1, Len(m3) - 1)
                PrintLine(3, m3)
                If j <> m0 Then Dim 空格 = LineInput(i)
            Next
            PrintLine(3, "") 'Print(3,vbnewline)
        Next

        Close()

    End Sub
End Class
