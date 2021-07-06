Imports System.Data
Imports System.Data.SqlClient
Public Class GirisEkrani
    Dim baglanti As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\IIII Donem\Görsel Programlama II\randevu sistemi\randevusistemi\Database1.mdf;Integrated Security=True")
    Dim verioku As SqlDataReader

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        Kayit.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim tc, sql As String
        tc = TextBox1.Text


        sql = "select  tc from hastalar where tc = '" & tc & "' "
        Dim komut1 As New SqlCommand(sql, baglanti)
        baglanti.Open()
        verioku = komut1.ExecuteReader()
        If verioku.HasRows And TextBox1.Text <> "" Then
            baglanti.Close()

            Me.Hide()
            AnaEkran.Show()
        Else
            baglanti.Close()
            MsgBox("Kayıt bulunamadı Lütfen Kayıt olun Sonra tekrar deneyiniz !!", MsgBoxStyle.Information, "Bildirim")


        End If
    End Sub

    Private Sub GirisEkrani_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class