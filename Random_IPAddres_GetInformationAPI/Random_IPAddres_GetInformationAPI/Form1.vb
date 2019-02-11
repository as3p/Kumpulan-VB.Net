Imports System.Xml
Imports System.IO

Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
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


            Dim filename As String = "http://ip-api.com/xml/" + TextBox5.Text
            Dim XmlDocument As New XmlDocument
            XmlDocument.Load(filename)
            TextBox6.Text = XmlDocument.DocumentElement.SelectSingleNode("//country").InnerText
            TextBox7.Text = XmlDocument.DocumentElement.SelectSingleNode("//regionName").InnerText
            TextBox8.Text = XmlDocument.DocumentElement.SelectSingleNode("//city").InnerText
            TextBox9.Text = XmlDocument.DocumentElement.SelectSingleNode("//lat").InnerText
            TextBox10.Text = XmlDocument.DocumentElement.SelectSingleNode("//lon").InnerText
            TextBox11.Text = XmlDocument.DocumentElement.SelectSingleNode("//timezone").InnerText
            TextBox12.Text = XmlDocument.DocumentElement.SelectSingleNode("//isp").InnerText
            TextBox13.Text = XmlDocument.DocumentElement.SelectSingleNode("//as").InnerText
            TextBox14.Text = XmlDocument.DocumentElement.SelectSingleNode("//query/query").InnerText
        Catch ex As Exception
            TextBox6.Text = "Fail"
            TextBox7.Text = "Fail"
            TextBox8.Text = "Fail"
            TextBox9.Text = "Fail"
            TextBox10.Text = "Fail"
            TextBox11.Text = "Fail"
            TextBox12.Text = "Fail"
            TextBox13.Text = "Fail"
            TextBox14.Text = "Fail"
        End Try

    End Sub

End Class
