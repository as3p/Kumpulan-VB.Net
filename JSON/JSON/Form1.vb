Imports System.Text
Imports System.Net
Imports System.IO
Imports Newtonsoft.Json

Public Class Form1
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim jsontext As String = "{""name"":""mahendra"",""language"":""vb.net"",""settings"":{""framework"":""3.5""}}"
        RichTextBox1.Text = jsontext
        'Memakai Imports Newtonsoft.Json
        'RichTextBox1.Text = JsonConvert.SerializeObject(jsontext)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim readingJson = Newtonsoft.Json.Linq.JObject.Parse(RichTextBox1.Text)
        TextBox1.Text = readingJson.Item("settings")("framework").ToString
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim readingJson = Newtonsoft.Json.Linq.JObject.Parse(RichTextBox1.Text)
        TextBox2.Text = readingJson("language").ToString
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        'Address of URL
        Dim URL As String = "http://ip-api.com/json/27.123.3.38"
        ' Get HTML data
        Dim client As WebClient = New WebClient()
        Dim data As Stream = client.OpenRead(URL)
        Dim reader As StreamReader = New StreamReader(data)
        Dim str As String = ""
        str = reader.ReadLine()
        RichTextBox2.Text = str
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim readingJson = Newtonsoft.Json.Linq.JObject.Parse(RichTextBox2.Text)
        TextBox3.Text = readingJson("query").ToString
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        'Address of URL
        Dim api_key As String = "293dc4ce4df06b15d37a7f0c1d13f716"
        Dim queri As String = "venom"
        Dim URL As String = "https://api.themoviedb.org/3/search/movie?api_key=" & api_key & "&language=en-US&query=" & queri
        ' Get HTML data
        Dim client As WebClient = New WebClient()
        Dim data As Stream = client.OpenRead(URL)
        Dim reader As StreamReader = New StreamReader(data)
        Dim str As String = ""
        str = reader.ReadLine
        RichTextBox3.Text = str
    End Sub
End Class
