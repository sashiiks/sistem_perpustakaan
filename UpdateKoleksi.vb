Public Class UpdateKoleksi
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        PictureBoxFoto.Load(Perpus.dataPerpustakaan.GSfoto)
        PictureBoxFoto.SizeMode = PictureBoxSizeMode.StretchImage
        DateTimePickerMasukKoleksiUpdate.Format = DateTimePickerMasukKoleksiUpdate.CustomFormat
        DateTimePickerMasukKoleksiUpdate.CustomFormat = "yyyy/MM/dd"
        TextBoxNamaKoleksiUpdate.Text = Perpus.dataPerpustakaan.GSnamaKoleksi
        ComboBoxJenisKoleksiUpdate.SelectedItem() = Perpus.dataPerpustakaan.GSjenisKoleksi
        RichTextBoxDeskripsiUpdate.Text = Perpus.dataPerpustakaan.GSdeskripsi
        TextBoxPenerbitUpdate.Text = Perpus.dataPerpustakaan.GSPenerbit
        TextBoxTahunPenerbitUpdate.Text = Perpus.dataPerpustakaan.GStahunterbit
        TextBoxLokasiRakUpdate.Text = Perpus.dataPerpustakaan.GSlokasiRak
        DateTimePickerMasukKoleksiUpdate.Value = Perpus.dataPerpustakaan.GStanggalMasuk
        TextBoxStockUpdate.Text = Perpus.dataPerpustakaan.GSstock

        If String.Compare(Perpus.dataPerpustakaan.GSbahasa, "indonesia") = 0 Then
            RadiobtnBhsIndo.Checked = True
        ElseIf String.Compare(Perpus.dataPerpustakaan.GSbahasa, "inggris") = 0 Then
            RadioBtnBhsInggris.Checked = True
        End If

        For Each kategoriItem In Perpus.dataPerpustakaan.GSkategori
            If String.Compare(kategoriItem, "sains") = 0 Then
                CheckBoxSains.Checked = True
            ElseIf String.Compare(kategoriItem, "sosial") = 0 Then
                CheckBoxSosial.Checked = True
            ElseIf String.Compare(kategoriItem, "teknologi") = 0 Then
                CheckBoxTeknologi.Checked = True
            ElseIf String.Compare(kategoriItem, "budaya") = 0 Then
                CheckBoxBudaya.Checked = True
            End If
        Next
    End Sub

    Private Sub BtnTambahGambar_Click(sender As Object, e As EventArgs) Handles BtnTambahGambar.Click
        OpenFileDialog1.Title = "Open Gambar Koleksi"
        OpenFileDialog1.Filter = "All Format|*.*|Image|*.bmp|Image JPG|*.jpg|Image JPEG|*.jpeg|Image PNG|*.png|Image GIF|*.gif"
        OpenFileDialog1.ShowDialog()

        Dim picKoleksiDir As String = OpenFileDialog1.FileName

        PictureBoxFoto.Load(picKoleksiDir)
        PictureBoxFoto.SizeMode = PictureBoxSizeMode.StretchImage
        Perpus.dataPerpustakaan.GSfoto = picKoleksiDir.ToString()
        Perpus.dataPerpustakaan.GSfoto = Perpus.dataPerpustakaan.GSfoto.Replace("\", "/")
    End Sub

    Private Sub btnTambahKoleksiUpdate_Click(sender As Object, e As EventArgs) Handles btnTambahKoleksiUpdate.Click
        Perpus.dataPerpustakaan.GSnamaKoleksi = TextBoxNamaKoleksiUpdate.Text.ToString()
        Perpus.dataPerpustakaan.GSjenisKoleksi = ComboBoxJenisKoleksiUpdate.SelectedItem().ToString()
        Perpus.dataPerpustakaan.GSdeskripsi = RichTextBoxDeskripsiUpdate.Text.ToString()
        Perpus.dataPerpustakaan.GSPenerbit = TextBoxPenerbitUpdate.Text.ToString()
        Perpus.dataPerpustakaan.GStahunterbit = Integer.Parse(TextBoxTahunPenerbitUpdate.Text)

        Perpus.dataPerpustakaan.GSlokasiRak = TextBoxLokasiRakUpdate.Text.ToString()
        Perpus.dataPerpustakaan.GStanggalMasuk = DateTimePickerMasukKoleksiUpdate.Value.ToString("yyyy/MM/dd")
        Perpus.dataPerpustakaan.GSstock = Integer.Parse(TextBoxStockUpdate.Text)

        If RadiobtnBhsIndo.Checked Then
            Perpus.dataPerpustakaan.GSbahasa = "Indonesia"
        ElseIf RadioBtnBhsInggris.Checked Then
            Perpus.dataPerpustakaan.GSbahasa = "Inggris"
        End If

        If CheckBoxSains.Checked Then
            Perpus.dataPerpustakaan.GSkategori.Add("Sains")
        ElseIf CheckBoxSosial.Checked Then
            Perpus.dataPerpustakaan.GSkategori.Add("Sosial")
        ElseIf CheckBoxTeknologi.Checked Then
            Perpus.dataPerpustakaan.GSkategori.Add("Teknologi")
        ElseIf CheckBoxBudaya.Checked Then
            Perpus.dataPerpustakaan.GSkategori.Add("Budaya")
        End If
    End Sub
End Class