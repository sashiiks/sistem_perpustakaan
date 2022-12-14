Imports System.IO

Public Class tambahKoleksi

    Private Sub BtnTambahGambar_Click(sender As Object, e As EventArgs) Handles BtnTambahGambar.Click
        OpenFileDialog1.Title = "Open Foto"
        OpenFileDialog1.Filter = "Image|*.bmp|Image JPG|*.jpg|Image JPEG|*.jpeg|Image PNG|*.png|Image GIF|*.gif|All Format|*.*"
        OpenFileDialog1.ShowDialog()

        'Perpus.dataPerpustakaan.GSfoto = OpenFileDialog1.FileName
        Dim pic As String = OpenFileDialog1.FileName
        PictureBoxFoto.Load(pic)
        PictureBoxFoto.SizeMode = PictureBoxSizeMode.StretchImage
        Perpus.dataPerpustakaan.GSfoto = OpenFileDialog1.ToString()
        Perpus.dataPerpustakaan.GSfoto = Perpus.dataPerpustakaan.GSfoto.Replace("\", "/")
    End Sub

    Dim bahasa
    Dim kategori_list As New List(Of String)

    Private Sub RadiobtnBhsIndo_CheckedChanged(sender As Object, e As EventArgs) Handles RadiobtnBhsIndo.CheckedChanged
        bahasa = "Bahasa Indonesia"
    End Sub

    Private Sub RadioBtnBhsInggris_CheckedChanged(sender As Object, e As EventArgs) Handles RadioBtnBhsInggris.CheckedChanged
        bahasa = "Bahasa Inggris"
    End Sub

    Private Sub btnTambahKoleksi_Click(sender As Object, e As EventArgs) Handles btnTambahKoleksi.Click
        'MessageBox.Show()

        MessageBox.Show(OpenFileDialog1.FileName)

        Perpus.dataPerpustakaan.GSnamaKoleksi = TextBoxNamaKoleksi.Text
        Perpus.dataPerpustakaan.GSjenisKoleksi = ComboBoxJenisKoleksi.SelectedItem()
        Perpus.dataPerpustakaan.GSdeskripsi = RichTextBoxDeskripsi.Text
        Perpus.dataPerpustakaan.GSPenerbit = TextBoxPenerbit.Text
        Perpus.dataPerpustakaan.GStahunterbit = TextBoxTahunPenerbit.Text
        Perpus.dataPerpustakaan.GSlokasiRak = TextBoxLokasiRak.Text
        Perpus.dataPerpustakaan.GStanggalMasuk = DateTimePickerMasukKoleksi.Value.ToShortDateString
        Perpus.dataPerpustakaan.GSstock = TextBoxStock.Text
        Perpus.dataPerpustakaan.GSbahasa = bahasa
        Perpus.dataPerpustakaan.GSkategori = kategori_list


        If CheckBoxSains.Checked() Then
            kategori_list.Add("Sains")
        End If
        If CheckBoxBudaya.Checked() Then
            kategori_list.Add("Budaya")
        End If
        If CheckBoxSosial.Checked() Then
            kategori_list.Add("Sosial")
        End If
        If CheckBoxTeknologi.Checked() Then
            kategori_list.Add("Teknologi")
        End If


        'Dim move = New infoTambahKoleksi
        'move.Show()

        Perpus.ListBoxKoleksi.Items.Add(Perpus.dataPerpustakaan.GSnamaKoleksi)
        Dim convertedKoleksi = Perpus.dataPerpustakaan.ConvertkoleksiToString(Perpus.dataPerpustakaan.GSkategori)
        Perpus.dataPerpustakaan.AddDataKoleksiDatabase(Perpus.dataPerpustakaan.GSfoto,
                                               Perpus.dataPerpustakaan.GSnamaKoleksi,
                                               Perpus.dataPerpustakaan.GSjenisKoleksi,
                                               Perpus.dataPerpustakaan.GSPenerbit,
                                               Perpus.dataPerpustakaan.GSdeskripsi,
                                               Perpus.dataPerpustakaan.GStahunterbit,
                                               Perpus.dataPerpustakaan.GSlokasiRak,
                                               Perpus.dataPerpustakaan.GStanggalMasuk,
                                               Perpus.dataPerpustakaan.GSstock,
                                               Perpus.dataPerpustakaan.GSbahasa,
                                               convertedKoleksi
                                               )

        Me.Close()

    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        DateTimePickerMasukKoleksi.Format = DateTimePickerFormat.Custom
        DateTimePickerMasukKoleksi.CustomFormat = "yyyy/MM/dd"
    End Sub

End Class