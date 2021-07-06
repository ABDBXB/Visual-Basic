Imports System.Data
Imports System.Data.SqlClient

Public Class Form1
    Dim baglanti As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\IIII Donem\Görsel Programlama II\kayit\kayit\kayit\Database1.mdf;Integrated Security=True")
    Dim verioku As SqlDataReader
    Dim cm As CurrencyManager

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'DateTimePicker1.Format = DateTimePickerFormat.Custom
        'DateTimePicker1.CustomFormat = "dd/MM/yyyy"
        goster()
        Currencyayarla()

        '==============
        'Data Tabel
        '==============
        'Dim Dataadapter As New SqlDataAdapter("select tc,adsoyad,d_yili from kayit ", baglanti)
        'baglanti.Open()
        'Dataadapter.Fill(dt)
        'baglanti.Close()

        'TextBox1.DataBindings.Add("Text", dt, "tc")
        'TextBox2.DataBindings.Add("Text", dt, "adsoyad")
        'DateTimePicker1.DataBindings.Add("Value", dt, "d_yili")

        'cm = Me.BindingContext(dt)
        'Label4.Text = "1" + "/" + cm.Count.ToString()
        '------------------------------------------------


    End Sub
    Public Sub Currencyayarla()


        'Application.Restart()
        Dim Dataadapter As New SqlDataAdapter("select tc,adsoyad,d_yili from kayit ", baglanti)
        baglanti.Open()
        Dim dt As New DataTable
        Dataadapter.Fill(dt)
        baglanti.Close()

        TextBox1.DataBindings.Clear()
        TextBox2.DataBindings.Clear()
        DateTimePicker1.DataBindings.Clear()

        TextBox1.DataBindings.Add("Text", dt, "tc")
        TextBox2.DataBindings.Add("Text", dt, "adsoyad")
        DateTimePicker1.DataBindings.Add("Value", dt, "d_yili")

        'cm.ResumeBinding()

        cm = Me.BindingContext(dt)
        Try

            cm.Refresh()
            'cm.Position = cm.Count

        Catch ex As Exception
        End Try

        Label4.Text = "1" + "/" + cm.Count.ToString()
        'Label4.Text = (cm.Count).ToString() + "/" + cm.Count.ToString()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim tc, adsoyad, d_yili As String
        tc = TextBox1.Text
        adsoyad = TextBox2.Text
        d_yili = DateTimePicker1.Value.ToString("MM/dd/yyyy")

        If tc.Equals("") Or adsoyad.Equals("") Then
            MsgBox("alanlar boş geçirlemez")

        Else
            Dim sqlquary As String = "select * from Kayit where tc='" & tc & "' "
        Dim sqlkomut As New SqlCommand(sqlquary, baglanti)
            baglanti.Open()
            verioku = sqlkomut.ExecuteReader
            If verioku.HasRows Then
                MsgBox("Zaten Kayıtlı", MsgBoxStyle.Exclamation, "Uyarı")
                baglanti.Close()
            Else
                baglanti.Close()
                'INSERT KOMUTU
                Dim sqlinsert As String = "insert into Kayit(tc,adsoyad,d_yili) values ('" & tc & "','" & adsoyad & "','" & d_yili & "')"
                Dim insertcommand As New SqlCommand(sqlinsert, baglanti)
                baglanti.Open()
                insertcommand.ExecuteNonQuery()
                baglanti.Close()
                Currencyayarla()
                goster()
                MsgBox("Kişi Başarılı bir Şekilde Kaydedildi", MsgBoxStyle.Information, "Bilgilendirme")
                Button5.Enabled = True
                Button6.Enabled = True
            End If
        End If







    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim tc, adsoyad, d_yili As String
        tc = TextBox1.Text
        adsoyad = TextBox2.Text
        If tc.Equals("") Or adsoyad.Equals("") Then
            MsgBox("alanlar boş geçirlemez")

        Else
            Dim sqlquary As String = "select * from Kayit where tc='" & tc & "' "
            Dim sqlkomut As New SqlCommand(sqlquary, baglanti)
                baglanti.Open()
                verioku = sqlkomut.ExecuteReader
            If verioku.HasRows Then
                If (baglanti.State = ConnectionState.Open) Then
                    baglanti.Close()
                End If
                tc = TextBox1.Text
                adsoyad = TextBox2.Text
                d_yili = DateTimePicker1.Value.ToString("MM/dd/yyyy")

                Dim sqlupdate As String = "update Kayit set  adsoyad='" & adsoyad & "', d_yili='" & d_yili & "' where tc='" & tc & "' "
                Dim update As New SqlCommand(sqlupdate, baglanti)
                baglanti.Open()
                update.ExecuteNonQuery()
                baglanti.Close()
                Currencyayarla()
                goster()
                MsgBox("Kişi Başarılı bir Şekilde güncellendi", MsgBoxStyle.Information, "Bilgilendirme")
                Button5.Enabled = True
                Button6.Enabled = True
            Else
                MsgBox("Böyle Bir Kişi Bulunmadı Lütfen Kaydedin sonra tekrar deneyiniz", MsgBoxStyle.Exclamation, "Uyarı")
                baglanti.Close()


            End If


        End If



    End Sub


    Private Sub SilToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SilToolStripMenuItem.Click
        Dim tc As String
        tc = DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells("tc").Value
        Dim komut As New SqlCommand("delete  from Kayit where tc='" & tc & "'", baglanti)
        baglanti.Open()
        komut.ExecuteNonQuery()
        baglanti.Close()
        MsgBox("Kişi Başarılı bir Şekilde Silindi", MsgBoxStyle.Information, "Bilgilendirme")
        Currencyayarla()
        goster()
        Button5.Enabled = True
        Button6.Enabled = True
    End Sub


    Public Sub goster()
        Dim sql As String
        sql = "select tc,adsoyad,d_yili from Kayit "
        Dim komut As New SqlDataAdapter(sql, baglanti)
        Dim verikumesi As New DataSet
        baglanti.Open()
        komut.Fill(verikumesi)
        baglanti.Close()
        DataGridView1.DataSource = verikumesi.Tables(0)
        DataGridView1.Columns(0).HeaderText = "T.C."
        DataGridView1.Columns(1).HeaderText = "AD Soyad"
        DataGridView1.Columns(2).HeaderText = "Doğum Yılı"



    End Sub




    ''ilk kayit
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        cm.Position = 0
        Label4.Text = (cm.Position + 1).ToString() + "/" + cm.Count.ToString()

    End Sub
    ''Son kayit
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        cm.Position = cm.Count - 1
        Label4.Text = (cm.Position + 1).ToString() + "/" + cm.Count.ToString()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        cm.Position -= 1
        Label4.Text = (cm.Position + 1).ToString() + "/" + cm.Count.ToString()
        If cm.Position = 0 Then
            Button5.Enabled = False
            'MsgBox("Şimdi İlk Kayıt'tasiniz. ", MsgBoxStyle.Information, "Bilgilendirme")
        Else
            Button5.Enabled = True
            Button6.Enabled = True
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        cm.Position += 1
        Label4.Text = (cm.Position + 1).ToString() + "/" + cm.Count.ToString()
        If cm.Position = cm.Count - 1 Then
            Button6.Enabled = False
            'MsgBox("Şimdi Son Kayıt'tasiniz. ", MsgBoxStyle.Information, "Bilgilendirme")
        Else
            Button6.Enabled = True
            Button5.Enabled = True

        End If
    End Sub
End Class
