Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FileOpen(1, "in1.txt", OpenMode.Input)
        FileOpen(2, "in2.txt", OpenMode.Input)
        FileOpen(3, "output.txt", OpenMode.Output)
        For i = 1 To 2
            Dim m0 As Integer = LineInput(i)
            For j = 1 To m0
                Dim a(m0)
                a(j) = LineInput(i)
                For k = 1 To Len(a(j))
                    If Mid(a(j), k, 1) = "}" Then
                        Dim m1 = Mid(a(j), 1, k - 1)
                        Dim m2 = Mid(a(j), k + 1)
                        Dim m3 = ""
                        Dim m4 = ""
                        Dim m5 = ""
                        Dim m6 = ""
                        Dim m7 = ""
                        Dim m8 = ""
                        For l = 1 To Len(m1)
                            If Mid(m1, l, 1) > "0" And Mid(m1, l, 1) < "9" Then
                                m3 &= Mid(m1, l, 1)
                            End If
                        Next
                        For l = 1 To Len(m2)
                            If Mid(m2, l, 1) > "0" And Mid(m2, l, 1) < "9" Then
                                m4 &= Mid(m2, l, 1)
                            End If
                        Next
                        Dim b(9), c(9), d(9)
                        For l = 1 To Len(m3)
                            b(Mid(m3, l, 1)) += 1
                        Next
                        For l = 1 To Len(m4)
                            c(Mid(m4, l, 1)) += 1
                        Next
                        '********************************
                        Dim aa = "" '1
                        For l = 0 To 9
                            If b(l) = "1" Then d(l) = "1"
                            If c(l) = "1" Then d(l) = "1"
                            If d(l) = "1" Then
                                aa &= l & ","
                            End If
                        Next
                        If aa = "" Then aa = "N,"
                        m5 = Mid(aa, 1, Len(aa) - 1)
                        If m5 <> "N" Then
                            m5 = "{" & m5 & "}"
                        End If
                        '********************************
                        Dim bb = "" '2
                        For l = 0 To 9
                            If b(l) = "1" And c(l) = "1" Then
                                bb &= l & ","
                            End If
                        Next
                        If bb = "" Then bb = "N,"
                        m6 = Mid(bb, 1, Len(bb) - 1)
                        If m6 <> "N" Then
                            m6 = "{" & m6 & "}"
                        End If
                        '********************************
                        Dim cc = "" '3
                        For l = 0 To 9
                            If b(l) = "1" And c(l) <> "1" Then
                                cc &= l & ","
                            End If
                        Next
                        If cc = "" Then cc = "N,"
                        m7 = Mid(cc, 1, Len(cc) - 1)
                        If m7 <> "N" Then
                            m7 = "{" & m7 & "}"
                        End If
                        '********************************
                        Dim dd = "" '4
                        ReDim d(9)
                        For l = 0 To 9
                            If b(l) = "1" Then d(l) = b(l)
                            If c(l) = "1" Then d(l) = c(l)
                            If b(l) = "1" And c(l) = "1" Then d(l) = ""
                            If d(l) = "1" Then
                                dd &= l & ","
                            End If
                        Next
                        If dd = "" Then dd = "N,"
                        m8 = Mid(dd, 1, Len(dd) - 1)
                        If m8 <> "N" Then
                            m8 = "{" & m8 & "}"
                        End If
                        '********************************
                        Dim 答案 = m5 & "," & m6 & "," & m7 & "," & m8
                        PrintLine(3, 答案)
                        Exit For
                    End If
                Next
            Next
            Print(3, vbNewLine)
        Next

        FileClose(1)
        FileClose(2)
        FileClose(3)

        Close()

    End Sub
End Class
