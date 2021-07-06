Imports System.Data
Imports System.Data.SqlClient
Public Class Kayit


    Dim tc, adsoyad, dyili, adres, tel, sql As String
    Dim baglanti As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\IIII Donem\Görsel Programlama II\randevu sistemi\randevusistemi\Database1.mdf;Integrated Security=True")
    Dim verioku As SqlDataReader

    'Temizle Button
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        temizle()
    End Sub

    'Kayıt Olma Button
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        tc = MaskedTextBox1.Text
        adsoyad = TextBox1.Text
        dyili = ComboBox1.Text
        tel = MaskedTextBox2.Text
        adres = RichTextBox1.Text

        sql = "select  tc from hastalar where tc = '" & tc & "' "
        Dim komut1 As New SqlCommand(sql, baglanti)
        baglanti.Open()
        verioku = komut1.ExecuteReader()
        If verioku.HasRows Then
            MsgBox("kisi kayıtlı", MsgBoxStyle.OkOnly, "Hata")
            baglanti.Close()
        Else
            baglanti.Close()
            sql = "insert into hastalar (tc,adsoyad,dyili,adres,tel) values ('" & tc & "','" & adsoyad & "','" & dyili & "','" & adres & "','" & tel & "')"
            Dim komut2 As New SqlCommand(sql, baglanti)
            baglanti.Open()
            komut2.ExecuteNonQuery()
            baglanti.Close()
            MsgBox("kişi kaydedildi", MsgBoxStyle.OkOnly, "Bildirim")


        End If

    End Sub

    Private Sub Kayit_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox1_MouseHover(sender As Object, e As EventArgs) Handles PictureBox1.MouseHover
        PictureBox1.BorderStyle = BorderStyle.FixedSingle
    End Sub

    Private Sub PictureBox1_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox1.MouseLeave
        PictureBox1.BorderStyle = BorderStyle.None
    End Sub

    Private Sub Panel1_MouseClick(sender As Object, e As MouseEventArgs) Handles Panel1.MouseClick
        Me.Hide()
        GirisEkrani.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Hide()
        GirisEkrani.Show()
    End Sub

    Private Sub temizle()
        TextBox1.Text = " "
        MaskedTextBox2.Clear()
        RichTextBox1.Clear()
        MaskedTextBox1.Clear()
        ComboBox1.Text = " "
    End Sub
    'Arama Buttom
    'Private Sub Button1_Click(sender As Object, e As EventArgs)
    '    tc = MaskedTextBox1.Text
    '    sql = "select  * from hastalar where tc = '" & tc & "' "
    '    Dim komut2 As New SqlCommand(sql, baglanti)

    '    baglanti.Open()
    '    verioku = komut2.ExecuteReader
    '    If verioku.HasRows Then
    '        Do While verioku.Read
    '            If verioku.HasRows Then
    '                TextBox1.Text = verioku("adsoyad")
    '                ComboBox1.Text = verioku("dyili")
    '                MaskedTextBox2.Text = verioku("tel")
    '                RichTextBox1.Text = verioku("adres")
    '            End If
    '        Loop
    '        baglanti.Close()
    '    Else
    '        baglanti.Close()
    '        MsgBox("Kayıt bulunmadı", MsgBoxStyle.Critical, "Uyarı")
    '        'temizle()
    '    End If
    '    baglanti.Close()






    'End Sub
End Class
