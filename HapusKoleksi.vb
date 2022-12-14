Public Class HapusKoleksi
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        LabelHapusKoleksi.Text = Perpus.dataPerpustakaan.GSdelete


        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        'Perpus.ListBoxKoleksi.Items.RemoveAt(Perpus.ListBoxKoleksi.SelectedIndex)
        Perpus.dataPerpustakaan.DeleteDataKoleksiByIDDatabase(Perpus.selectedTableKoleksi)
        'MessageBox.Show("Data berhasil dihapus")
        Me.Close()
    End Sub
End Class