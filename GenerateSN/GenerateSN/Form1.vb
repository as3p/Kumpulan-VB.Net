Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        '====== awal set bulan ======
        Dim bulan As String = ""
        If Format(Now, "MM") = "01" Then
            bulan = "01"
        ElseIf Format(Now, "MM") = "02" Then
            bulan = "02"
        ElseIf Format(Now, "MM") = "03" Then
            bulan = "03"
        ElseIf Format(Now, "MM") = "04" Then
            bulan = "04"
        ElseIf Format(Now, "MM") = "05" Then
            bulan = "05"
        ElseIf Format(Now, "MM") = "06" Then
            bulan = "06"
        ElseIf Format(Now, "MM") = "07" Then
            bulan = "07"
        ElseIf Format(Now, "MM") = "08" Then
            bulan = "08"
        ElseIf Format(Now, "MM") = "09" Then
            bulan = "09"
        ElseIf Format(Now, "MM") = "10" Then
            bulan = "A"
        ElseIf Format(Now, "MM") = "11" Then
            bulan = "B"
        ElseIf Format(Now, "MM") = "12" Then
            bulan = "C"
        End If
        '====== akhir set bulan ======

        '====== awal set tahun ======
        Dim tahun As String = ""
        If Format(Now, "yyyy") = "2018" Then
            tahun = "18"
        ElseIf Format(Now, "yyyy") = "2019" Then
            tahun = "BB"
        ElseIf Format(Now, "yyyy") = "2020" Then
            tahun = "CC"
        ElseIf Format(Now, "yyyy") = "2021" Then
            tahun = "DD"
        ElseIf Format(Now, "yyyy") = "2022" Then
            tahun = "EE"
        End If
        '====== akhir set tahun ======

        '====== awal set model ======
        Dim model As String = ""
        If Label8.Text = "Model 1" Then
            model = "M1"
        ElseIf Label8.Text = "Model 2" Then
            model = "M2"
        ElseIf Label8.Text = "Model 3" Then
            model = "M3"
        ElseIf Label8.Text = "Model 4" Then
            model = "M4"
        ElseIf Label8.Text = "Model 5" Then
            model = "M5"
        End If
        '====== akhir set tahun ======

        '====== set nomor ======
        Dim i As Integer
        Dim j As Integer
        ListBox1.Items.Clear()
        i = 1
        j = i + 1
        Dim k As String = ""

        'Looping serial number
        For j = TextBox1.Text To TextBox2.Text
            If j <= 9 Then
                k = "AS" & tahun & bulan & "00000" & j & model
            ElseIf j <= 99 Then
                k = "AS" & tahun & bulan & "0000" & j & model
            ElseIf j <= 999 Then
                k = "AS" & tahun & bulan & "000" & j & model
            ElseIf j <= 9999 Then
                k = "AS" & tahun & bulan & "00" & j & model
            ElseIf j <= 99999 Then
                k = "AS" & tahun & bulan & "0" & j & model
            ElseIf j > 999999 Then
                MsgBox("Batas Nomor Generate Sampai 999999")
                'stop looping
                Exit Sub
            Else
                k = "AS" & tahun & bulan & j & model
            End If
            ListBox1.Items.Add(k.ToString)
        Next (j)
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label5.Text = Format(Now, "MMMM")
        Label6.Text = Format(Now, "yyyy")
        Label7.Text = "Model 1"
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        'maskimal jumlah yang di input
        TextBox1.MaxLength = 6
        'hanya angka yang boleh di input
        If Strings.InStr("0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = Chr(0)
        End If
    End Sub

    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        'maskimal jumlah yang di input
        TextBox2.MaxLength = 6
        'hanya angka yang boleh di input
        If Strings.InStr("0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = Chr(0)
        End If
    End Sub

  
End Class
