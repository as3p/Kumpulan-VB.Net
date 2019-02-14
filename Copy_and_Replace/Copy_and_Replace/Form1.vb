Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim str As String = TextBox1.Text
        Dim replceStr As String = TextBox2.Text

        If RichTextBox1.Text.Contains(str) Then
            RichTextBox1.Text = RichTextBox1.Text.Replace(str, replceStr)
        Else
            MessageBox.Show("Maaf, string tidak di temukan")
        End If
    End Sub
End Class
