Public Class Perpus

    Public Shared dataPerpustakaan As DataPerpustkaan
    Public Shared selectedTableKoleksi
    Public Shared selectedTableKoleksiNama
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        dataPerpustakaan = New DataPerpustkaan()
        'UpdateDataTableArrayList()

        ReloadDataTableDataBase()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub TambahKoleksiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TambahKoleksiToolStripMenuItem.Click
        Dim pindah = New tambahKoleksi()
        pindah.Show()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim pindah = New tambahKoleksi()
        pindah.Show()
    End Sub

    Private Sub btnRmv_Click(sender As Object, e As EventArgs) Handles btnRmv.Click

        If ListBoxKoleksi.SelectedIndex >= 0 Then
            dataPerpustakaan.GSdelete = ListBoxKoleksi.SelectedItem()
            Dim pindah = New HapusKoleksi()
            pindah.Show()
        Else
            MessageBox.Show("Pilih data terlebih dahulu")
        End If
    End Sub

    Public Sub UpdateDataTableArrayList()
        DataGridKoleksi.Rows.Clear()
        For Each rowkoleksi In dataPerpustakaan.getkoleksiDataTable()
            Dim dataTable As String() = {
               rowkoleksi(1),
               rowkoleksi(2),
               rowkoleksi(3),
               rowkoleksi(4),
               rowkoleksi(5),
               rowkoleksi(6),
               rowkoleksi(7),
               rowkoleksi(8),
               rowkoleksi(9)}
            DataGridKoleksi.Rows.Add(dataTable)
        Next
    End Sub

    Private Sub Perpus_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        'UpdateDataTableArrayList()
        ReloadDataTableDataBase()
    End Sub

    Private Sub ReloadDataTableDataBase()
        DataGridKoleksi.DataSource = dataPerpustakaan.GetDataKoleksiDatabase()
    End Sub

    Private Sub DataGridKoleksi_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridKoleksi.CellContentClick
        Dim index As Integer = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridKoleksi.Rows(index)

        selectedTableKoleksi = selectedRow.Cells(0).Value
        selectedTableKoleksiNama = selectedRow.Cells(1).Value
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        Dim selectedKoleksi As List(Of String) = dataPerpustakaan.GetDataKoleksiIDDatabase(selectedTableKoleksi)

        dataPerpustakaan.GSfoto = selectedKoleksi(2)
        dataPerpustakaan.GSnamaKoleksi = selectedKoleksi(1)
        dataPerpustakaan.GSjenisKoleksi = selectedKoleksi(5)
        dataPerpustakaan.GSdeskripsi = selectedKoleksi(3)
        dataPerpustakaan.GSPenerbit = selectedKoleksi(4)
        dataPerpustakaan.GStahunterbit = selectedKoleksi(6)
        dataPerpustakaan.GSlokasiRak = selectedKoleksi(7)
        dataPerpustakaan.GStanggalMasuk = selectedKoleksi(8)
        dataPerpustakaan.GSstock = selectedKoleksi(9)
        dataPerpustakaan.GSbahasa = selectedKoleksi(10)
        Dim data_kategori As List(Of String) = dataPerpustakaan.ConvertStringToKoleksi(selectedKoleksi(11))

        For Each info_kategori In data_kategori
            dataPerpustakaan.GSkategori.Add(info_kategori)
        Next

        Dim FormUpdate = New UpdateKoleksi
        UpdateKoleksi.Show()

        Dim convertedKoleksi = Perpus.dataPerpustakaan.ConvertkoleksiToString(Perpus.dataPerpustakaan.GSkategori)

        Perpus.dataPerpustakaan.UpdateDataKoleksiByIDDatabase(selectedTableKoleksi,
                                                                Perpus.dataPerpustakaan.GSfoto,
                                                                Perpus.dataPerpustakaan.GSnamaKoleksi,
                                                                Perpus.dataPerpustakaan.GSjenisKoleksi,
                                                                Perpus.dataPerpustakaan.GSdeskripsi,
                                                                Perpus.dataPerpustakaan.GSPenerbit,
                                                                Perpus.dataPerpustakaan.GStahunterbit,
                                                                Perpus.dataPerpustakaan.GSlokasiRak,
                                                                Perpus.dataPerpustakaan.GStanggalMasuk,
                                                                Perpus.dataPerpustakaan.GSstock,
                                                                Perpus.dataPerpustakaan.GSbahasa,
                                                                convertedKoleksi)
        Dim infoTambah = New infoTambahKoleksi()
        infoTambah.Show()

        Me.Close()
    End Sub

    Private Sub BtnRemove_Click(sender As Object, e As EventArgs) Handles BtnRemove.Click
        Dim formHapus = New HapusKoleksi()
        formHapus.Show()
    End Sub

    Private Sub BtnSelect_Click(sender As Object, e As EventArgs) Handles BtnSelect.Click
        Dim selectedKoleksi As List(Of String) = dataPerpustakaan.GetDataKoleksiIDDatabase(selectedTableKoleksi)

        dataPerpustakaan.GSfoto = selectedKoleksi(2)
        dataPerpustakaan.GSnamaKoleksi = selectedKoleksi(1)
        dataPerpustakaan.GSjenisKoleksi = selectedKoleksi(5)
        dataPerpustakaan.GSdeskripsi = selectedKoleksi(3)
        dataPerpustakaan.GSPenerbit = selectedKoleksi(4)
        dataPerpustakaan.GStahunterbit = selectedKoleksi(6)
        dataPerpustakaan.GSlokasiRak = selectedKoleksi(7)
        dataPerpustakaan.GStanggalMasuk = selectedKoleksi(8)
        dataPerpustakaan.GSstock = selectedKoleksi(9)
        dataPerpustakaan.GSbahasa = selectedKoleksi(10)
        Dim data_kategori As List(Of String) = dataPerpustakaan.ConvertStringToKoleksi(selectedKoleksi(11))

        For Each info_kategori In data_kategori
            dataPerpustakaan.GSkategori.Add(info_kategori)
        Next

        Dim InfoTambah = New infoTambahKoleksi()
        InfoTambah.Show()

    End Sub
End Class
