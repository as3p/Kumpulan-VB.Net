Public Class Form1


    Sub random_ip()
        Dim ip1, ip2, ip3, ip4 As Integer
        Randomize()
        ip1 = Int(Rnd() * 254) + 1
        ip2 = Int(Rnd() * 254) + 1
        ip3 = Int(Rnd() * 254) + 1
        ip4 = Int(Rnd() * 254) + 1

        TextBox1.Text = ip1
        TextBox2.Text = ip2
        TextBox3.Text = ip3
        TextBox4.Text = ip4
        TextBox5.Text = ip1.ToString + "." + ip2.ToString + "." + ip3.ToString + "." + ip4.ToString
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        random_ip()
    End Sub
End Class
