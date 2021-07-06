Imports System.Data
Imports System.Data.SqlClient
Public Class AnaEkran
    Dim alinmissaatlist As New ArrayList
    Dim doktor_id As String




    Dim baglanti As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\IIII Donem\Görsel Programlama II\randevu sistemi\randevusistemi\Database1.mdf;Integrated Security=True")
    Dim verioku As SqlDataReader
    Private Sub AnaEkran_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database1DataSet3.poliklinik' table. You can move, or remove it, as needed.
        Me.PoliklinikTableAdapter.Fill(Me.Database1DataSet3.poliklinik)
        'TODO: This line of code loads data into the 'Database1DataSet2.doktor' table. You can move, or remove it, as needed.
        Me.DoktorTableAdapter1.Fill(Me.Database1DataSet2.doktor)





    End Sub

    ''Poliklinik Combobox
    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        ComboBox3.Items.Clear()
        ComboBox3.Text = ""
        Dim komut As New SqlCommand("select doktorad  from doktor where poliklinik in (select id from poliklinik where poliklinik_ad='" & ComboBox2.Text & "')", baglanti)
        baglanti.Open()
        verioku = komut.ExecuteReader
        Do While verioku.Read
            ComboBox3.Items.Add(verioku("doktorad"))
        Loop

        baglanti.Close()

    End Sub

    ''Doktor Combobox
    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        saatgoster()
        Dim komut As New SqlCommand("select id from doktor where doktorad='" & ComboBox3.Text & "'", baglanti)
        baglanti.Open()
        verioku = komut.ExecuteReader
        verioku.Read()
        doktor_id = verioku("id")

        baglanti.Close()

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        saatgoster()

    End Sub


    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click

        If (baglanti.State = ConnectionState.Closed) Then
            baglanti.Open()

        End If

        If ComboBox2.Text = "" Or ComboBox3.Text = "" Or Label2.Text = "00:00" Then
            MsgBox("lütfen bilgilerinizi kontroll ediniz", MsgBoxStyle.Information, "Bilgilendirme")
            baglanti.Close()
        Else
            Dim Sql As String
            Dim tc As String = GirisEkrani.TextBox1.Text

            Dim randevuKontroll As New SqlCommand("select id  from randevu where hasta_tc ='" & tc & "' and doktor_id='" & doktor_id & "' and tarih ='" & DateTimePicker1.Value.ToString("dd/MM/yyyy") & "' and saat = '" & Label2.Text & "' ", baglanti)
            verioku = randevuKontroll.ExecuteReader
            If verioku.HasRows Then
                MsgBox("bu randevu alımıştır ", MsgBoxStyle.Information, "Bilgilendirme")
                baglanti.Close()

            Else
                verioku.Close()
                Sql = "insert into randevu (hasta_tc,doktor_id,tarih,saat) values ('" & tc & "','" & doktor_id & "','" & DateTimePicker1.Value.ToString("dd/MM/yyyy") & "','" & Label2.Text & "')"
                Dim komut As New SqlCommand(Sql, baglanti)
                komut.ExecuteNonQuery()
                baglanti.Close()
                saatgoster()
                MsgBox("randevunuz başarıyla alındı ", MsgBoxStyle.Information, "Bilgilendirme")
            End If
        End If



    End Sub






    Public Sub alinmissaat()
        If (baglanti.State = ConnectionState.Closed) Then
            baglanti.Open()
        End If
        Dim sql, tarih As String
        tarih = DateTimePicker1.Value.ToString("dd/MM/yyyy")
        sql = "select saat from randevu where doktor_id = (select id from doktor where doktorad = '" & ComboBox3.Text & "') and tarih = '" & tarih & "' "
        Dim komut As New SqlCommand(sql, baglanti)
        verioku = komut.ExecuteReader()
        alinmissaatlist.Clear()
        While verioku.Read()
            alinmissaatlist.Add(verioku("saat"))

        End While
        baglanti.Close()


    End Sub





    Public Sub saatgoster()
        styleyap()
        alinmissaatlist.Clear()
        alinmissaat()
        For i = 0 To alinmissaatlist.Count - 1

            ''09:00
            If (alinmissaatlist.Item(i).ToString() = button900.Text) Then

                button900.BackColor = Color.DimGray
                button900.Enabled = False

            ElseIf (alinmissaatlist.Item(i).ToString() = button910.Text) Then

                button910.BackColor = Color.DimGray
                button910.Enabled = False

            ElseIf (alinmissaatlist.Item(i).ToString() = button920.Text) Then

                button920.BackColor = Color.DimGray
                button920.Enabled = False

            ElseIf (alinmissaatlist.Item(i).ToString() = button930.Text) Then

                button930.BackColor = Color.DimGray
                button930.Enabled = False

            ElseIf (alinmissaatlist.Item(i).ToString() = button940.Text) Then

                button940.BackColor = Color.DimGray
                button940.Enabled = False

            ElseIf (alinmissaatlist.Item(i).ToString() = button950.Text) Then

                button950.BackColor = Color.DimGray
                button950.Enabled = False

                ''10:00

            ElseIf (alinmissaatlist.Item(i).ToString() = button1000.Text) Then
                button1000.BackColor = Color.DimGray
                button1000.Enabled = False

            ElseIf (alinmissaatlist.Item(i).ToString() = button1010.Text) Then
                button1010.BackColor = Color.DimGray
                button1010.Enabled = False

            ElseIf (alinmissaatlist.Item(i).ToString() = button1020.Text) Then
                button1020.BackColor = Color.DimGray
                button1020.Enabled = False

            ElseIf (alinmissaatlist.Item(i).ToString() = button1030.Text) Then
                button1030.BackColor = Color.DimGray
                button1030.Enabled = False

            ElseIf (alinmissaatlist.Item(i).ToString() = button1040.Text) Then

                button1040.BackColor = Color.DimGray
                button1040.Enabled = False

            ElseIf (alinmissaatlist.Item(i).ToString() = button1050.Text) Then

                button1050.BackColor = Color.DimGray
                button1050.Enabled = False

                ''11:00

            ElseIf (alinmissaatlist.Item(i).ToString() = button1100.Text) Then

                button1100.BackColor = Color.DimGray
                button1100.Enabled = False

            ElseIf (alinmissaatlist.Item(i).ToString() = button1110.Text) Then

                button1110.BackColor = Color.DimGray
                button1110.Enabled = False

            ElseIf (alinmissaatlist.Item(i).ToString() = button1120.Text) Then

                button1120.BackColor = Color.DimGray
                button1120.Enabled = False

            ElseIf (alinmissaatlist.Item(i).ToString() = button1130.Text) Then

                button1130.BackColor = Color.DimGray
                button1130.Enabled = False

            ElseIf (alinmissaatlist.Item(i).ToString() = button1140.Text) Then

                button1140.BackColor = Color.DimGray
                button1140.Enabled = False

            ElseIf (alinmissaatlist.Item(i).ToString() = button1150.Text) Then

                button1150.BackColor = Color.DimGray
                button1150.Enabled = False

                ''13:00
            ElseIf (alinmissaatlist.Item(i).ToString() = button1300.Text) Then

                button1300.BackColor = Color.DimGray
                button1300.Enabled = False

            ElseIf (alinmissaatlist.Item(i).ToString() = button1310.Text) Then

                button1310.BackColor = Color.DimGray
                button1310.Enabled = False

            ElseIf (alinmissaatlist.Item(i).ToString() = button1320.Text) Then

                button1320.BackColor = Color.DimGray
                button1320.Enabled = False

            ElseIf (alinmissaatlist.Item(i).ToString() = button1330.Text) Then

                button1330.BackColor = Color.DimGray
                button1330.Enabled = False

            ElseIf (alinmissaatlist.Item(i).ToString() = button1340.Text) Then

                button1340.BackColor = Color.DimGray
                button1340.Enabled = False

            ElseIf (alinmissaatlist.Item(i).ToString() = button1350.Text) Then

                button1350.BackColor = Color.DimGray
                button1350.Enabled = False

                ''14:00
            ElseIf (alinmissaatlist.Item(i).ToString() = button1400.Text) Then

                button1400.BackColor = Color.DimGray
                button1400.Enabled = False

            ElseIf (alinmissaatlist.Item(i).ToString() = button1410.Text) Then

                button1410.BackColor = Color.DimGray
                button1410.Enabled = False

            ElseIf (alinmissaatlist.Item(i).ToString() = button1420.Text) Then

                button1420.BackColor = Color.DimGray
                button1420.Enabled = False

            ElseIf (alinmissaatlist.Item(i).ToString() = button1430.Text) Then

                button1430.BackColor = Color.DimGray
                button1430.Enabled = False

            ElseIf (alinmissaatlist.Item(i).ToString() = button1440.Text) Then

                button1440.BackColor = Color.DimGray
                button1440.Enabled = False

            ElseIf (alinmissaatlist.Item(i).ToString() = button1450.Text) Then

                button1450.BackColor = Color.DimGray
                button1450.Enabled = False

                ''15:00
            ElseIf (alinmissaatlist.Item(i).ToString() = button1500.Text) Then

                button1500.BackColor = Color.DimGray
                button1500.Enabled = False

            ElseIf (alinmissaatlist.Item(i).ToString() = button1510.Text) Then

                button1510.BackColor = Color.DimGray
                button1510.Enabled = False

            ElseIf (alinmissaatlist.Item(i).ToString() = button1520.Text) Then

                button1520.BackColor = Color.DimGray
                button1520.Enabled = False

            ElseIf (alinmissaatlist.Item(i).ToString() = button1530.Text) Then

                button1530.BackColor = Color.DimGray
                button1530.Enabled = False

            ElseIf (alinmissaatlist.Item(i).ToString() = button1540.Text) Then

                button1540.BackColor = Color.DimGray
                button1540.Enabled = False

            ElseIf (alinmissaatlist.Item(i).ToString() = button1550.Text) Then

                button1550.BackColor = Color.DimGray
                button1550.Enabled = False





            End If


        Next






    End Sub

    Public Sub styleyap()
        button900.Enabled = True
        button910.Enabled = True
        button920.Enabled = True
        button930.Enabled = True
        button940.Enabled = True
        button950.Enabled = True

        button1000.Enabled = True
        button1010.Enabled = True
        button1020.Enabled = True
        button1030.Enabled = True
        button1040.Enabled = True
        button1050.Enabled = True

        button1100.Enabled = True
        button1110.Enabled = True
        button1120.Enabled = True
        button1130.Enabled = True
        button1140.Enabled = True
        button1150.Enabled = True

        button1300.Enabled = True
        button1310.Enabled = True
        button1320.Enabled = True
        button1330.Enabled = True
        button1340.Enabled = True
        button1350.Enabled = True

        button1400.Enabled = True
        button1410.Enabled = True
        button1420.Enabled = True
        button1430.Enabled = True
        button1440.Enabled = True
        button1450.Enabled = True

        button1500.Enabled = True
        button1510.Enabled = True
        button1520.Enabled = True
        button1530.Enabled = True
        button1540.Enabled = True
        button1550.Enabled = True


        button900.BackColor = Color.LimeGreen
        button910.BackColor = Color.LimeGreen
        button920.BackColor = Color.LimeGreen
        button930.BackColor = Color.LimeGreen
        button940.BackColor = Color.LimeGreen
        button950.BackColor = Color.LimeGreen

        button1000.BackColor = Color.LimeGreen
        button1010.BackColor = Color.LimeGreen
        button1020.BackColor = Color.LimeGreen
        button1030.BackColor = Color.LimeGreen
        button1040.BackColor = Color.LimeGreen
        button1050.BackColor = Color.LimeGreen

        button1100.BackColor = Color.LimeGreen
        button1110.BackColor = Color.LimeGreen
        button1120.BackColor = Color.LimeGreen
        button1130.BackColor = Color.LimeGreen
        button1140.BackColor = Color.LimeGreen
        button1150.BackColor = Color.LimeGreen


        button1300.BackColor = Color.LimeGreen
        button1310.BackColor = Color.LimeGreen
        button1320.BackColor = Color.LimeGreen
        button1330.BackColor = Color.LimeGreen
        button1340.BackColor = Color.LimeGreen
        button1350.BackColor = Color.LimeGreen

        button1400.BackColor = Color.LimeGreen
        button1410.BackColor = Color.LimeGreen
        button1420.BackColor = Color.LimeGreen
        button1430.BackColor = Color.LimeGreen
        button1440.BackColor = Color.LimeGreen
        button1450.BackColor = Color.LimeGreen

        button1500.BackColor = Color.LimeGreen
        button1510.BackColor = Color.LimeGreen
        button1520.BackColor = Color.LimeGreen
        button1530.BackColor = Color.LimeGreen
        button1540.BackColor = Color.LimeGreen
        button1550.BackColor = Color.LimeGreen

    End Sub




    ''09:00 button's
    Private Sub button900_Click(sender As Object, e As EventArgs) Handles button900.Click
        Label2.Text = button900.Text
    End Sub

    Private Sub button910_Click(sender As Object, e As EventArgs) Handles button910.Click
        Label2.Text = button910.Text
    End Sub

    Private Sub button920_Click(sender As Object, e As EventArgs) Handles button920.Click
        Label2.Text = button920.Text
    End Sub

    Private Sub button930_Click(sender As Object, e As EventArgs) Handles button930.Click
        Label2.Text = button930.Text
    End Sub
    Private Sub button940_Click(sender As Object, e As EventArgs) Handles button940.Click
        Label2.Text = button940.Text
    End Sub
    Private Sub button950_Click(sender As Object, e As EventArgs) Handles button950.Click
        Label2.Text = button950.Text
    End Sub

    ''10:00
    Private Sub button1000_Click(sender As Object, e As EventArgs) Handles button1000.Click
        Label2.Text = button1000.Text
    End Sub

    Private Sub button1010_Click(sender As Object, e As EventArgs) Handles button1010.Click
        Label2.Text = button1010.Text
    End Sub

    Private Sub button1020_Click(sender As Object, e As EventArgs) Handles button1020.Click
        Label2.Text = button1020.Text
    End Sub

    Private Sub button1030_Click(sender As Object, e As EventArgs) Handles button1030.Click
        Label2.Text = button1030.Text
    End Sub
    Private Sub button1040_Click(sender As Object, e As EventArgs) Handles button1040.Click
        Label2.Text = button1040.Text
    End Sub
    Private Sub button1050_Click(sender As Object, e As EventArgs) Handles button1050.Click
        Label2.Text = button1050.Text
    End Sub

    ''11:00
    Private Sub button1100_Click(sender As Object, e As EventArgs) Handles button1100.Click
        Label2.Text = button1100.Text
    End Sub

    Private Sub button1110_Click(sender As Object, e As EventArgs) Handles button1110.Click
        Label2.Text = button1110.Text
    End Sub

    Private Sub button1120_Click(sender As Object, e As EventArgs) Handles button1120.Click
        Label2.Text = button1120.Text
    End Sub

    Private Sub button1130_Click(sender As Object, e As EventArgs) Handles button1130.Click
        Label2.Text = button1130.Text
    End Sub
    Private Sub button1140_Click(sender As Object, e As EventArgs) Handles button1140.Click
        Label2.Text = button1140.Text
    End Sub
    Private Sub button1150_Click(sender As Object, e As EventArgs) Handles button1150.Click
        Label2.Text = button1150.Text
    End Sub

    ''13:00
    Private Sub button1300_Click(sender As Object, e As EventArgs) Handles button1300.Click
        Label2.Text = button1300.Text
    End Sub

    Private Sub button1310_Click(sender As Object, e As EventArgs) Handles button1310.Click
        Label2.Text = button1310.Text
    End Sub

    Private Sub button1320_Click(sender As Object, e As EventArgs) Handles button1320.Click
        Label2.Text = button1320.Text
    End Sub

    Private Sub button1330_Click(sender As Object, e As EventArgs) Handles button1330.Click
        Label2.Text = button1330.Text
    End Sub
    Private Sub button1340_Click(sender As Object, e As EventArgs) Handles button1340.Click
        Label2.Text = button1340.Text
    End Sub
    Private Sub button1350_Click(sender As Object, e As EventArgs) Handles button1350.Click
        Label2.Text = button1350.Text
    End Sub

    ''14:00
    Private Sub button1400_Click(sender As Object, e As EventArgs) Handles button1400.Click
        Label2.Text = button1400.Text
    End Sub

    Private Sub button1410_Click(sender As Object, e As EventArgs) Handles button1410.Click
        Label2.Text = button1410.Text
    End Sub

    Private Sub button1420_Click(sender As Object, e As EventArgs) Handles button1420.Click
        Label2.Text = button1420.Text
    End Sub

    Private Sub button1430_Click(sender As Object, e As EventArgs) Handles button1430.Click
        Label2.Text = button1430.Text
    End Sub
    Private Sub button1440_Click(sender As Object, e As EventArgs) Handles button1440.Click
        Label2.Text = button1440.Text
    End Sub
    Private Sub button1450_Click(sender As Object, e As EventArgs) Handles button1450.Click
        Label2.Text = button1450.Text
    End Sub

    ''15:00
    Private Sub button1500_Click(sender As Object, e As EventArgs) Handles button1500.Click
        Label2.Text = button1500.Text
    End Sub

    Private Sub button1510_Click(sender As Object, e As EventArgs) Handles button1510.Click
        Label2.Text = button1510.Text
    End Sub

    Private Sub button1520_Click(sender As Object, e As EventArgs) Handles button1520.Click
        Label2.Text = button1520.Text
    End Sub

    Private Sub button1530_Click(sender As Object, e As EventArgs) Handles button1530.Click
        Label2.Text = button1530.Text
    End Sub
    Private Sub button1540_Click(sender As Object, e As EventArgs) Handles button1540.Click
        Label2.Text = button1540.Text
    End Sub
    Private Sub button1550_Click(sender As Object, e As EventArgs) Handles button1550.Click
        Label2.Text = button1550.Text
    End Sub


End Class