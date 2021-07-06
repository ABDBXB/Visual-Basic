Imports System.Data
Imports System.Data.SqlClient
Public Class Form1



    Dim tc, adsoyad, dyili, adres, tel, sql, doktorad, saat, tarih As String





    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        ComboBox3.Items.Clear()
        ComboBox3.Text = ""
        Dim komut As New SqlCommand("select doktorad  from doktor where poliklinik='" & ComboBox2.Text & "'", baglanti)
        baglanti.Open()
        verioku = komut.ExecuteReader
        Do While verioku.Read
            ComboBox3.Items.Add(verioku("doktorad"))
        Loop
        baglanti.Close()
    End Sub



    Dim baglanti As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\IIII Donem\Görsel Programlama II\randevu sistemi\randevusistemi\Database1.mdf;Integrated Security=True")
    Dim verioku As SqlDataReader

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database1DataSet1.doktor' table. You can move, or remove it, as needed.
        Me.DoktorTableAdapter1.Fill(Me.Database1DataSet1.doktor)
        'TODO: This line of code loads data into the 'Database1DataSet.doktor' table. You can move, or remove it, as needed.
        Me.DoktorTableAdapter.Fill(Me.Database1DataSet.doktor)


    End Sub



    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        doktorad = ComboBox3.Text
        saat = ComboBox4.Text
        tarih = DateTimePicker1.Value.ToString("dd/MM/yyyy")
        tc = MaskedTextBox1.Text
        adsoyad = TextBox1.Text
        sql = "insert into randevu (doktorad,saat,tarih,hasta_ad,hasta_tc) values ('" & doktorad & "','" & saat & "','" & tarih & "','" & adsoyad & "','" & tc & "')"

        Dim komut As New SqlCommand(sql, baglanti)
        baglanti.Open()
        komut.ExecuteNonQuery()
        baglanti.Close()
        MsgBox("randevunuz başarıyla alındı ", MsgBoxStyle.Information, "Bilgilendirme")
    End Sub



    Private Sub temizle()
        TextBox1.Text = " "
        MaskedTextBox2.Clear()
        RichTextBox1.Clear()
        MaskedTextBox1.Clear()
        ComboBox1.Text = " "
        ComboBox2.Text = " "
        ComboBox3.Text = " "
        ComboBox4.Text = " "
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        temizle()
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        tc = MaskedTextBox1.Text
        sql = "select  * from hastalar where tc = '" & tc & "' "
        Dim komut2 As New SqlCommand(sql, baglanti)

        baglanti.Open()
        verioku = komut2.ExecuteReader
        If verioku.HasRows Then
            Do While verioku.Read
                If verioku.HasRows Then
                    TextBox1.Text = verioku("adsoyad")
                    ComboBox1.Text = verioku("dyili")
                    MaskedTextBox2.Text = verioku("tel")
                    RichTextBox1.Text = verioku("adres")
                End If
            Loop
            baglanti.Close()
        Else
            baglanti.Close()
            MsgBox("Kayıt bulunmadı", MsgBoxStyle.Critical, "Uyarı")
            temizle()
        End If
        baglanti.Close()






    End Sub


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



End Class
