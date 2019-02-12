Public Class Form1
    Public Declare Function GetAsyncKeyState Lib "user32" (ByVal vKey As Int32) As Int16
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim hotkey1 As Boolean
        hotkey1 = GetAsyncKeyState(Keys.A)
        If hotkey1 = True Then
            RichTextBox1.SelectedText = "a"
        End If
        Dim hotkey2 As Boolean
        hotkey2 = GetAsyncKeyState(Keys.B)
        If hotkey2 = True Then
            RichTextBox1.SelectedText = "b"
        End If

        Dim hotkey3 As Boolean
        hotkey3 = GetAsyncKeyState(Keys.C)
        If hotkey3 = True Then
            RichTextBox1.SelectedText = "c"
        End If

        Dim hotkey4 As Boolean
        hotkey4 = GetAsyncKeyState(Keys.D)
        If hotkey4 = True Then
            RichTextBox1.SelectedText = "d"
        End If

        Dim hotkey5 As Boolean
        hotkey5 = GetAsyncKeyState(Keys.E)
        If hotkey5 = True Then
            RichTextBox1.SelectedText = "e"
        End If

        Dim hotkey6 As Boolean
        hotkey6 = GetAsyncKeyState(Keys.F)
        If hotkey6 = True Then
            RichTextBox1.SelectedText = "f"
        End If

        Dim hotkey7 As Boolean
        hotkey7 = GetAsyncKeyState(Keys.G)
        If hotkey7 = True Then
            RichTextBox1.SelectedText = "g"
        End If

        Dim hotkey8 As Boolean
        hotkey8 = GetAsyncKeyState(Keys.H)
        If hotkey8 = True Then
            RichTextBox1.SelectedText = "h"
        End If

        Dim hotkey9 As Boolean
        hotkey9 = GetAsyncKeyState(Keys.I)
        If hotkey9 = True Then
            RichTextBox1.SelectedText = "i"
        End If

        Dim hotkey10 As Boolean
        hotkey10 = GetAsyncKeyState(Keys.J)
        If hotkey10 = True Then
            RichTextBox1.SelectedText = "j"
        End If

        Dim hotkey11 As Boolean
        hotkey11 = GetAsyncKeyState(Keys.K)
        If hotkey11 = True Then
            RichTextBox1.SelectedText = "k"
        End If

        Dim hotkey12 As Boolean
        hotkey12 = GetAsyncKeyState(Keys.L)
        If hotkey12 = True Then
            RichTextBox1.SelectedText = "l"
        End If

        Dim hotkey13 As Boolean
        hotkey13 = GetAsyncKeyState(Keys.M)
        If hotkey13 = True Then
            RichTextBox1.SelectedText = "m"
        End If

        Dim hotkey14 As Boolean
        hotkey14 = GetAsyncKeyState(Keys.N)
        If hotkey14 = True Then
            RichTextBox1.SelectedText = "n"
        End If

        Dim hotkey15 As Boolean
        hotkey15 = GetAsyncKeyState(Keys.O)
        If hotkey15 = True Then
            RichTextBox1.SelectedText = "o"
        End If

        Dim hotkey16 As Boolean
        hotkey16 = GetAsyncKeyState(Keys.P)
        If hotkey16 = True Then
            RichTextBox1.SelectedText = "p"
        End If

        Dim hotkey17 As Boolean
        hotkey17 = GetAsyncKeyState(Keys.Q)
        If hotkey17 = True Then
            RichTextBox1.SelectedText = "q"
        End If

        Dim hotkey18 As Boolean
        hotkey18 = GetAsyncKeyState(Keys.R)
        If hotkey18 = True Then
            RichTextBox1.SelectedText = "r"
        End If

        Dim hotkey19 As Boolean
        hotkey19 = GetAsyncKeyState(Keys.S)
        If hotkey19 = True Then
            RichTextBox1.SelectedText = "s"
        End If

        Dim hotkey20 As Boolean
        hotkey20 = GetAsyncKeyState(Keys.T)
        If hotkey20 = True Then
            RichTextBox1.SelectedText = "t"
        End If

        Dim hotkey21 As Boolean
        hotkey21 = GetAsyncKeyState(Keys.U)
        If hotkey21 = True Then
            RichTextBox1.SelectedText = "u"
        End If

        Dim hotkey22 As Boolean
        hotkey22 = GetAsyncKeyState(Keys.V)
        If hotkey22 = True Then
            RichTextBox1.SelectedText = "v"
        End If

        Dim hotkey23 As Boolean
        hotkey23 = GetAsyncKeyState(Keys.W)
        If hotkey23 = True Then
            RichTextBox1.SelectedText = "w"
        End If

        Dim hotkey24 As Boolean
        hotkey24 = GetAsyncKeyState(Keys.X)
        If hotkey24 = True Then
            RichTextBox1.SelectedText = "x"
        End If

        Dim hotkey25 As Boolean
        hotkey25 = GetAsyncKeyState(Keys.Y)
        If hotkey25 = True Then
            RichTextBox1.SelectedText = "y"
        End If

        Dim z As Boolean
        z = GetAsyncKeyState(Keys.Z)
        If z = True Then
            RichTextBox1.SelectedText = "z"
        End If

        Dim hotkey26 As Boolean
        hotkey26 = GetAsyncKeyState(Keys.Space)
        If hotkey26 = True Then
            RichTextBox1.SelectedText = " "
        End If

        Dim hotkey27 As Boolean
        hotkey27 = GetAsyncKeyState(Keys.Enter)
        If hotkey27 = True Then
            RichTextBox1.SelectedText = vbNewLine
        End If

        Dim hotkey29 As Boolean
        hotkey29 = GetAsyncKeyState(Keys.NumLock)
        If hotkey29 = True Then
            RichTextBox1.SelectedText = "(NumLock)"
        End If

        Dim hotkey30 As Boolean
        hotkey30 = GetAsyncKeyState(Keys.NumPad0)
        If hotkey30 = True Then
            RichTextBox1.SelectedText = "0"
        End If
        Dim hotkey31 As Boolean
        hotkey31 = GetAsyncKeyState(Keys.NumPad1)
        If hotkey31 = True Then
            RichTextBox1.SelectedText = "1"
        End If
        Dim hotkey32 As Boolean
        hotkey32 = GetAsyncKeyState(Keys.NumPad2)
        If hotkey32 = True Then
            RichTextBox1.SelectedText = "2"
        End If
        Dim hotkey33 As Boolean
        hotkey33 = GetAsyncKeyState(Keys.NumPad3)
        If hotkey33 = True Then
            RichTextBox1.SelectedText = "3"
        End If
        Dim hotkey34 As Boolean
        hotkey34 = GetAsyncKeyState(Keys.NumPad4)
        If hotkey34 = True Then
            RichTextBox1.SelectedText = "4"
        End If
        Dim hotkey35 As Boolean
        hotkey35 = GetAsyncKeyState(Keys.NumPad5)
        If hotkey35 = True Then
            RichTextBox1.SelectedText = "5"
        End If
        Dim hotkey36 As Boolean
        hotkey36 = GetAsyncKeyState(Keys.NumPad6)
        If hotkey36 = True Then
            RichTextBox1.SelectedText = "6"
        End If
        Dim hotkey37 As Boolean
        hotkey37 = GetAsyncKeyState(Keys.NumPad7)
        If hotkey37 = True Then
            RichTextBox1.SelectedText = "7"
        End If
        Dim hotkey38 As Boolean
        hotkey38 = GetAsyncKeyState(Keys.NumPad8)
        If hotkey38 = True Then
            RichTextBox1.SelectedText = "8"
        End If
        Dim hotkey39 As Boolean
        hotkey39 = GetAsyncKeyState(Keys.NumPad9)
        If hotkey39 = True Then
            RichTextBox1.SelectedText = "9"
        End If

        Dim hotkey40 As Boolean
        hotkey40 = GetAsyncKeyState(Keys.Tab)
        If hotkey40 = True Then
            RichTextBox1.SelectedText = " Tab "
        End If

        Dim hotkey41 As Boolean
        hotkey41 = GetAsyncKeyState(Keys.Delete)
        If hotkey41 = True Then
            RichTextBox1.SelectedText = " Hapus "
        End If

        Dim hotkey42 As Boolean
        hotkey42 = GetAsyncKeyState(Keys.CapsLock)
        If hotkey42 = True Then
            RichTextBox1.SelectedText = " Hurup Besar "
        End If

        Dim hotkey43 As Boolean
        hotkey43 = GetAsyncKeyState(Keys.ShiftKey)
        If hotkey43 = True Then
            RichTextBox1.SelectedText = " ShiftKey "
        End If

        Dim hotkey44 As Boolean
        hotkey44 = GetAsyncKeyState(Keys.Shift)
        If hotkey44 = True Then
            RichTextBox1.SelectedText = " Shift "
        End If

        Dim hotkey45 As Boolean
        hotkey45 = GetAsyncKeyState(Keys.ControlKey)
        If hotkey45 = True Then
            RichTextBox1.SelectedText = " ControlKey "
        End If
    End Sub

End Class
