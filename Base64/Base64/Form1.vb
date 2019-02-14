Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim byt As Byte() = System.Text.Encoding.UTF8.GetBytes(TextBox1.Text)
        TextBox2.Text = Convert.ToBase64String(byt)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim b As Byte() = Convert.FromBase64String(TextBox3.Text)
        TextBox4.Text = System.Text.Encoding.UTF8.GetString(b)
    End Sub
End Class
