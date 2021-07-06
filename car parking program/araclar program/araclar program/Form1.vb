Imports System.Data
Imports System.Data.SqlClient
Public Class Form1
    Dim baglanti As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\IIII Donem\Görsel Programlama II\araclar programi\araclar program\araclar program\Database1.mdf;Integrated Security=True")
    Dim verioku As SqlDataReader
    Dim sqlquary As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database1DataSet.tblMarka' table. You can move, or remove it, as needed.
        Me.TblMarkaTableAdapter.Fill(Me.Database1DataSet.tblMarka)
        ComboBox1.Text = "Seçiniz..."
        goster()



    End Sub
    Public Function checkcombobox(CB1 As String, CB2 As String) As Boolean
        If (baglanti.State = ConnectionState.Open) Then
            baglanti.Close()
        End If
        CB1 = ComboBox1.Text
        CB2 = ComboBox2.Text
        Dim sqlkomut As New SqlCommand("select tblModel.*,tblMarka.* from tblModel,tblMarka where tblModel.marka_no =tblMarka.Id and tblMarka.Marka_ad ='" & CB1 & "' and tblModel.Model_ad  ='" & CB2 & "'", baglanti)
        baglanti.Open()
        verioku = sqlkomut.ExecuteReader
        If verioku.HasRows Then
            baglanti.Close()
            Return True

        Else
            baglanti.Close()
            Return False
        End If


    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim plaka, marka, model, renk, sqlinsert As String
        plaka = TextBox1.Text
        marka = ComboBox1.Text
        model = ComboBox2.Text
        renk = ComboBox3.Text

        If plaka.Equals("") Or marka.Equals("") Or model.Equals("") Or renk.Equals("") Then
            MsgBox("alanlar boş geçirlemez")

        Else
            sqlquary = "select * from araclar where plaka='" & plaka & "' "

            Dim sqlkomut As New SqlCommand(sqlquary, baglanti)
            baglanti.Open()
            verioku = sqlkomut.ExecuteReader
            If verioku.HasRows Then
                MsgBox("Bu Arac Zaten Kayıtlı", MsgBoxStyle.Exclamation, "Uyarı")
                baglanti.Close()
            Else
                'Marka ve Model Kayıtlı 
                If checkcombobox(marka, model) = True Then
                    If (baglanti.State = ConnectionState.Open) Then
                        baglanti.Close()
                    End If
                    'MODEL ID'Sİ ALMA KOMUTU
                    Dim Model_id As New SqlCommand("select id from tblModel where Model_ad='" & ComboBox2.Text & "'", baglanti)
                    baglanti.Open()
                    verioku = Model_id.ExecuteReader
                    verioku.Read()
                    model = verioku("id")
                    baglanti.Close()
                    'INSERT KOMUTU
                    sqlinsert = "insert into araclar(plaka,model_no,renk) values ('" & plaka & "','" & model & "','" & renk & "')"
                    Dim komut As New SqlCommand(sqlinsert, baglanti)
                    baglanti.Open()
                    komut.ExecuteNonQuery()
                    baglanti.Close()
                    goster()
                    MsgBox("Araç Başarılı bir Şekilde Kaydedildi", MsgBoxStyle.Information, "Bilgilendirme")

                Else
                    MsgBox("Böyle bir Marka Yada Model Yok Lütfen Girniz.", MsgBoxStyle.Information, "Bilgilendirme")

                End If





            End If


        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        Dim sqlView As String
        sqlView = "select araclar.plaka,araclar.renk ,tblModel.Model_ad ,tblMarka.Marka_ad  from araclar ,tblModel ,tblMarka where araclar.model_no=tblModel.Id and tblModel.marka_no =tblMarka.Id and  plaka like '%" & TextBox2.Text & "%'"
        Dim komut As New SqlDataAdapter(sqlView, baglanti)
        baglanti.Open()
        Dim ds As New DataSet
        komut.Fill(ds)
        baglanti.Close()
        DataGridView1.DataSource = ds.Tables(0)

    End Sub

    Private Sub SilToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SilToolStripMenuItem.Click
        Dim plaka As String
        plaka = DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells("plaka").Value
        Dim komut As New SqlCommand("delete  from araclar where plaka='" & plaka & "'", baglanti)

        baglanti.Open()
        komut.ExecuteNonQuery()
        baglanti.Close()
        MsgBox("Araç Başarılı bir Şekilde Silindi", MsgBoxStyle.Information, "Bilgilendirme")
        goster()

    End Sub


    Public Sub goster()
        Dim sql As String
        sql = "select araclar.plaka,araclar.renk ,tblModel.Model_ad ,tblMarka.Marka_ad  from araclar ,tblModel ,tblMarka where araclar.model_no=tblModel.Id and tblModel.marka_no =tblMarka.Id "
        Dim komut As New SqlDataAdapter(sql, baglanti)
        Dim verikumesi As New DataSet
        baglanti.Open()
        komut.Fill(verikumesi)
        baglanti.Close()
        'DataGridView1.Rows.Clear()
        DataGridView1.DataSource = verikumesi.Tables(0)
        DataGridView1.Columns(0).HeaderText = "Plaka"
        DataGridView1.Columns(1).HeaderText = "Renk"
        DataGridView1.Columns(2).HeaderText = "Model ADI"
        DataGridView1.Columns(3).HeaderText = "Marka ADI"
    End Sub



    Private Sub DüzenleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DüzenleToolStripMenuItem.Click
        Dim plaka As String
        plaka = DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells("plaka").Value.ToString
        Dim sql As String
        sql = "select araclar.plaka,araclar.renk ,tblModel.Model_ad ,tblMarka.Marka_ad  from araclar ,tblModel ,tblMarka where araclar.model_no=tblModel.Id and tblModel.marka_no =tblMarka.Id and plaka='" & plaka & "' "

        Dim komut As New SqlDataAdapter(sql, baglanti)
        baglanti.Open()
        Dim verikumesi As New DataSet
        komut.Fill(verikumesi)
        baglanti.Close()
        TextBox1.Text = verikumesi.Tables(0).Rows(0)("plaka").ToString
        ComboBox1.Text = verikumesi.Tables(0).Rows(0)("Marka_ad").ToString()
        ComboBox2.Text = verikumesi.Tables(0).Rows(0)("Model_ad").ToString()
        ComboBox3.Text = verikumesi.Tables(0).Rows(0)("renk").ToString()



    End Sub

    'Güncelle Button
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim plaka, marka, model, renk, sqlupdate As String
        plaka = TextBox1.Text
        marka = ComboBox1.Text
        model = ComboBox2.Text
        renk = ComboBox3.Text
        If plaka.Equals("") Or marka.Equals("") Or model.Equals("") Or renk.Equals("") Then
            MsgBox("alanlar boş geçirlemez")

        Else
            If checkcombobox(marka, model) = True Then
                sqlquary = "select * from araclar where plaka='" & plaka & "'  "

                Dim sqlkomut As New SqlCommand(sqlquary, baglanti)
                baglanti.Open()
                verioku = sqlkomut.ExecuteReader
                If verioku.HasRows Then
                    If (baglanti.State = ConnectionState.Open) Then
                        baglanti.Close()
                    End If


                    'MODEL ID'Sİ ALMA KOMUTU
                    Dim Model_id As New SqlCommand("select id from tblModel where Model_ad='" & ComboBox2.Text & "'", baglanti)
                    baglanti.Open()
                    verioku = Model_id.ExecuteReader
                    verioku.Read()
                    model = verioku("id")
                    baglanti.Close()

                    plaka = TextBox1.Text
                    renk = ComboBox3.Text
                    sqlupdate = "update araclar set plaka='" & plaka & "', model_no='" & model & "', renk='" & renk & "' where plaka='" & plaka & "' "
                    Dim update As New SqlCommand(sqlupdate, baglanti)
                    baglanti.Open()
                    update.ExecuteNonQuery()
                    baglanti.Close()
                    goster()
                    MsgBox("Araç Başarılı bir Şekilde güncellendi", MsgBoxStyle.Information, "Bilgilendirme")

                Else
                    MsgBox("Böyle Bir Araç Bulunmadı Lütfen Kaydedin sonra tekrar deneyiniz", MsgBoxStyle.Exclamation, "Uyarı")
                    baglanti.Close()


                End If

            Else
                MsgBox("Böyle bir Marka Yada Model Yok Lütfen Girniz.", MsgBoxStyle.Information, "Bilgilendirme")

            End If




        End If
    End Sub

    Private Sub DataGridView1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles DataGridView1.MouseDoubleClick
        Dim plaka As String
        plaka = DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells("plaka").Value.ToString
        Dim sql As String
        sql = "select araclar.plaka,araclar.renk ,tblModel.Model_ad ,tblMarka.Marka_ad  from araclar ,tblModel ,tblMarka where araclar.model_no=tblModel.Id and tblModel.marka_no =tblMarka.Id and plaka='" & plaka & "' "

        Dim komut As New SqlDataAdapter(sql, baglanti)
        baglanti.Open()
        Dim verikumesi As New DataSet
        komut.Fill(verikumesi)
        baglanti.Close()
        TextBox1.Text = verikumesi.Tables(0).Rows(0)("plaka").ToString
        ComboBox1.Text = verikumesi.Tables(0).Rows(0)("Marka_ad").ToString()
        ComboBox2.Text = verikumesi.Tables(0).Rows(0)("Model_ad").ToString()
        ComboBox3.Text = verikumesi.Tables(0).Rows(0)("renk").ToString()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        ComboBox2.Items.Clear()
        ComboBox2.Text = ""
        Dim komut As New SqlCommand("select Model_ad  from tblModel where marka_no in (select id from tblMarka where marka_ad='" & ComboBox1.Text & "')", baglanti)
        baglanti.Open()
        verioku = komut.ExecuteReader
        Do While verioku.Read
            ComboBox2.Items.Add(verioku("Model_ad"))
        Loop
        If ComboBox2.Items.Count > 0 Then
            ComboBox2.Text = ComboBox2.Items(0).ToString
        End If
        baglanti.Close()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

        Dim marka_ad As String
        marka_ad = InputBox("Yeni Markanın Adı Giriniz Lütfen", "Yeni Marka Ekleme")
        If marka_ad.Equals("") Then
            MsgBox("Marka Boş Girilimemeli.", MsgBoxStyle.Critical, "Bilgilendirme")
        Else
            Dim sqlkomut As New SqlCommand("select Marka_ad from tblMarka where Marka_ad='" & marka_ad & "'", baglanti)
            baglanti.Open()
            verioku = sqlkomut.ExecuteReader
            If verioku.HasRows Then
                MsgBox("Bu Marka Zaten Eklendi.", MsgBoxStyle.Information, "Bilgilendirme")
                baglanti.Close()
            Else

                If (baglanti.State = ConnectionState.Open) Then
                    baglanti.Close()
                End If
                Dim insert As New SqlCommand("insert into tblMarka(Marka_ad) values ('" & marka_ad & "')", baglanti)
                baglanti.Open()
                insert.ExecuteNonQuery()
                baglanti.Close()

                Dim komut As New SqlDataAdapter("select Marka_ad from tblMarka", baglanti)
                Dim verikumesi As New DataSet
                baglanti.Open()
                komut.Fill(verikumesi)
                baglanti.Close()
                ComboBox1.DataSource = verikumesi.Tables(0)
                ComboBox1.Text = marka_ad

            End If




            'Me.Controls.Clear()
            'InitializeComponent()
            'Form1_Load(e, e)
            'Application.Restart()
            'Me.TblMarkaTableAdapter.Fill(Me.Database1DataSet.tblMarka)
            'Me.Refresh()



        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim Marka_id As Integer
        Dim Marka_idsql As New SqlCommand("select id from tblMarka where Marka_ad='" & ComboBox1.Text & "'", baglanti)
        baglanti.Open()
        verioku = Marka_idsql.ExecuteReader
        verioku.Read()
        If verioku.HasRows Then
            Marka_id = verioku("id")
        End If
        baglanti.Close()

        If Marka_id = 0 Then
            MsgBox("Lütfen Marka Seçin, Marka Yoksa ekleyin :)", MsgBoxStyle.Information, "Bilgilendirme")
        Else
            Dim Model_ad As String
            Model_ad = InputBox("Yeni Modelin Adı Giriniz Lütfen", "Yeni Model Ekleme")
            If Model_ad.Equals("") Then
                MsgBox("Marka Boş Girilimemeli.", MsgBoxStyle.Critical, "Bilgilendirme")
            Else

                Dim sqlkomut As New SqlCommand("select Model_ad from tblModel where Model_ad='" & Model_ad & "'", baglanti)
                baglanti.Open()
                verioku = sqlkomut.ExecuteReader
                If verioku.HasRows Then
                    MsgBox("Bu Marka Zaten Eklendi.", MsgBoxStyle.Information, "Bilgilendirme")
                    baglanti.Close()
                Else
                    If (baglanti.State = ConnectionState.Open) Then
                        baglanti.Close()
                    End If
                    Dim insert As New SqlCommand("insert into tblModel(Model_ad,marka_no) values ('" & Model_ad & "','" & Marka_id & "')", baglanti)
                    baglanti.Open()
                    insert.ExecuteNonQuery()
                    baglanti.Close()

                    ComboBox2.Items.Clear()
                    Dim komut As New SqlCommand("select Model_ad  from tblModel where marka_no in (select id from tblMarka where marka_ad='" & ComboBox1.Text & "')", baglanti)
                    baglanti.Open()
                    verioku = komut.ExecuteReader
                    Do While verioku.Read
                        ComboBox2.Items.Add(verioku("Model_ad"))
                    Loop
                    baglanti.Close()

                End If




            End If
        End If

    End Sub
End Class
