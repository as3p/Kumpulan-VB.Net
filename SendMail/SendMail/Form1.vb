Imports System.Web
Imports System.IO
Imports System.Net.Mail

Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub OpenFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        'browse file
        Dim strm As System.IO.Stream
        strm = OpenFileDialog1.OpenFile()
        TextBox6.Text = OpenFileDialog1.FileName.ToString()
        If Not (strm Is Nothing) Then
            strm.Close()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        OpenFileDialog1.Title = "Please Select a File"
        OpenFileDialog1.FileName = " "
        OpenFileDialog1.InitialDirectory = "D:\"
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim mail As New MailMessage
        Dim smtpSrv As New SmtpClient

        Dim pengirim As String = TextBox1.Text
        Dim NamaPengirim As String = TextBox2.Text
        Dim password As String = TextBox3.Text
        Dim penerima As String = TextBox4.Text
        Dim Subjek As String = TextBox5.Text
        Dim Pesan As String = RichTextBox1.Text

        smtpSrv.Credentials = New Net.NetworkCredential(pengirim, password)
        smtpSrv.Port = 587
        smtpSrv.Host = "smtp.gmail.com"
        smtpSrv.EnableSsl = True
        mail.From = New MailAddress(pengirim, NamaPengirim)
        mail.To.Add(penerima)
        mail.Subject = Subjek

        'Logic jika RadioButton HTML di pilih 
        If RadioButton1.Checked Then
            mail.IsBodyHtml = True
        End If
        mail.Body = Pesan

        'Logic jika kirim tanpa lampiran
        If TextBox6.Text = "" Then
        Else
            'Logic jika kirim dengan lampiran
            Dim lampiran As New System.Net.Mail.Attachment(TextBox6.Text) 'untuk lampiran
            mail.Attachments.Add(lampiran) 'browse kirim lampiran
        End If

        smtpSrv.Send(mail)
    End Sub
End Class
