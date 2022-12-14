<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateKoleksi
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.CheckBoxTeknologi = New System.Windows.Forms.CheckBox()
        Me.PictureBoxFoto = New System.Windows.Forms.PictureBox()
        Me.BtnTambahGambar = New System.Windows.Forms.Button()
        Me.btnTambahKoleksiUpdate = New System.Windows.Forms.Button()
        Me.GroupBoxKategoriUpdate = New System.Windows.Forms.GroupBox()
        Me.CheckBoxBudaya = New System.Windows.Forms.CheckBox()
        Me.CheckBoxSosial = New System.Windows.Forms.CheckBox()
        Me.CheckBoxSains = New System.Windows.Forms.CheckBox()
        Me.GroupBoxBahasaUpdate = New System.Windows.Forms.GroupBox()
        Me.RadioBtnBhsInggris = New System.Windows.Forms.RadioButton()
        Me.RadiobtnBhsIndo = New System.Windows.Forms.RadioButton()
        Me.TextBoxStockUpdate = New System.Windows.Forms.TextBox()
        Me.LblKategori = New System.Windows.Forms.Label()
        Me.LblBahasa = New System.Windows.Forms.Label()
        Me.LblStock = New System.Windows.Forms.Label()
        Me.DateTimePickerMasukKoleksiUpdate = New System.Windows.Forms.DateTimePicker()
        Me.TextBoxLokasiRakUpdate = New System.Windows.Forms.TextBox()
        Me.LblTanggal = New System.Windows.Forms.Label()
        Me.TextBoxTahunPenerbitUpdate = New System.Windows.Forms.TextBox()
        Me.LblTahunTerbit = New System.Windows.Forms.Label()
        Me.LBlLokasiRak = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.TextBoxPenerbitUpdate = New System.Windows.Forms.TextBox()
        Me.LblPenerbit = New System.Windows.Forms.Label()
        Me.LblDeskripsi = New System.Windows.Forms.Label()
        Me.LblJenisKoleksi = New System.Windows.Forms.Label()
        Me.LblNamaKoleksi = New System.Windows.Forms.Label()
        Me.RichTextBoxDeskripsiUpdate = New System.Windows.Forms.RichTextBox()
        Me.ComboBoxJenisKoleksiUpdate = New System.Windows.Forms.ComboBox()
        Me.TextBoxNamaKoleksiUpdate = New System.Windows.Forms.TextBox()
        CType(Me.PictureBoxFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxKategoriUpdate.SuspendLayout()
        Me.GroupBoxBahasaUpdate.SuspendLayout()
        Me.SuspendLayout()
        '
        'CheckBoxTeknologi
        '
        Me.CheckBoxTeknologi.AutoSize = True
        Me.CheckBoxTeknologi.Location = New System.Drawing.Point(90, 22)
        Me.CheckBoxTeknologi.Name = "CheckBoxTeknologi"
        Me.CheckBoxTeknologi.Size = New System.Drawing.Size(73, 17)
        Me.CheckBoxTeknologi.TabIndex = 20
        Me.CheckBoxTeknologi.Text = "Teknologi"
        Me.CheckBoxTeknologi.UseVisualStyleBackColor = True
        '
        'PictureBoxFoto
        '
        Me.PictureBoxFoto.Location = New System.Drawing.Point(27, 52)
        Me.PictureBoxFoto.Name = "PictureBoxFoto"
        Me.PictureBoxFoto.Size = New System.Drawing.Size(117, 131)
        Me.PictureBoxFoto.TabIndex = 51
        Me.PictureBoxFoto.TabStop = False
        '
        'BtnTambahGambar
        '
        Me.BtnTambahGambar.Location = New System.Drawing.Point(27, 204)
        Me.BtnTambahGambar.Name = "BtnTambahGambar"
        Me.BtnTambahGambar.Size = New System.Drawing.Size(117, 23)
        Me.BtnTambahGambar.TabIndex = 50
        Me.BtnTambahGambar.Text = "Tambah Gambar"
        Me.BtnTambahGambar.UseVisualStyleBackColor = True
        '
        'btnTambahKoleksiUpdate
        '
        Me.btnTambahKoleksiUpdate.Location = New System.Drawing.Point(196, 575)
        Me.btnTambahKoleksiUpdate.Name = "btnTambahKoleksiUpdate"
        Me.btnTambahKoleksiUpdate.Size = New System.Drawing.Size(117, 23)
        Me.btnTambahKoleksiUpdate.TabIndex = 49
        Me.btnTambahKoleksiUpdate.Text = "Tambah Koleksi"
        Me.btnTambahKoleksiUpdate.UseVisualStyleBackColor = True
        '
        'GroupBoxKategoriUpdate
        '
        Me.GroupBoxKategoriUpdate.Controls.Add(Me.CheckBoxBudaya)
        Me.GroupBoxKategoriUpdate.Controls.Add(Me.CheckBoxTeknologi)
        Me.GroupBoxKategoriUpdate.Controls.Add(Me.CheckBoxSosial)
        Me.GroupBoxKategoriUpdate.Controls.Add(Me.CheckBoxSains)
        Me.GroupBoxKategoriUpdate.Location = New System.Drawing.Point(319, 479)
        Me.GroupBoxKategoriUpdate.Name = "GroupBoxKategoriUpdate"
        Me.GroupBoxKategoriUpdate.Size = New System.Drawing.Size(186, 69)
        Me.GroupBoxKategoriUpdate.TabIndex = 48
        Me.GroupBoxKategoriUpdate.TabStop = False
        Me.GroupBoxKategoriUpdate.Text = "Kategori"
        '
        'CheckBoxBudaya
        '
        Me.CheckBoxBudaya.AutoSize = True
        Me.CheckBoxBudaya.Location = New System.Drawing.Point(90, 39)
        Me.CheckBoxBudaya.Name = "CheckBoxBudaya"
        Me.CheckBoxBudaya.Size = New System.Drawing.Size(62, 17)
        Me.CheckBoxBudaya.TabIndex = 21
        Me.CheckBoxBudaya.Text = "Budaya"
        Me.CheckBoxBudaya.UseVisualStyleBackColor = True
        '
        'CheckBoxSosial
        '
        Me.CheckBoxSosial.AutoSize = True
        Me.CheckBoxSosial.Location = New System.Drawing.Point(3, 42)
        Me.CheckBoxSosial.Name = "CheckBoxSosial"
        Me.CheckBoxSosial.Size = New System.Drawing.Size(54, 17)
        Me.CheckBoxSosial.TabIndex = 23
        Me.CheckBoxSosial.Text = "Sosial"
        Me.CheckBoxSosial.UseVisualStyleBackColor = True
        '
        'CheckBoxSains
        '
        Me.CheckBoxSains.AutoSize = True
        Me.CheckBoxSains.Location = New System.Drawing.Point(3, 22)
        Me.CheckBoxSains.Name = "CheckBoxSains"
        Me.CheckBoxSains.Size = New System.Drawing.Size(52, 17)
        Me.CheckBoxSains.TabIndex = 22
        Me.CheckBoxSains.Text = "Sains"
        Me.CheckBoxSains.UseVisualStyleBackColor = True
        '
        'GroupBoxBahasaUpdate
        '
        Me.GroupBoxBahasaUpdate.Controls.Add(Me.RadioBtnBhsInggris)
        Me.GroupBoxBahasaUpdate.Controls.Add(Me.RadiobtnBhsIndo)
        Me.GroupBoxBahasaUpdate.Location = New System.Drawing.Point(319, 401)
        Me.GroupBoxBahasaUpdate.Name = "GroupBoxBahasaUpdate"
        Me.GroupBoxBahasaUpdate.Size = New System.Drawing.Size(128, 72)
        Me.GroupBoxBahasaUpdate.TabIndex = 47
        Me.GroupBoxBahasaUpdate.TabStop = False
        Me.GroupBoxBahasaUpdate.Text = "Bahasa"
        '
        'RadioBtnBhsInggris
        '
        Me.RadioBtnBhsInggris.AutoSize = True
        Me.RadioBtnBhsInggris.Location = New System.Drawing.Point(18, 42)
        Me.RadioBtnBhsInggris.Name = "RadioBtnBhsInggris"
        Me.RadioBtnBhsInggris.Size = New System.Drawing.Size(95, 17)
        Me.RadioBtnBhsInggris.TabIndex = 19
        Me.RadioBtnBhsInggris.TabStop = True
        Me.RadioBtnBhsInggris.Text = "Bahasa Inggris"
        Me.RadioBtnBhsInggris.UseVisualStyleBackColor = True
        '
        'RadiobtnBhsIndo
        '
        Me.RadiobtnBhsIndo.AutoSize = True
        Me.RadiobtnBhsIndo.Location = New System.Drawing.Point(18, 19)
        Me.RadiobtnBhsIndo.Name = "RadiobtnBhsIndo"
        Me.RadiobtnBhsIndo.Size = New System.Drawing.Size(110, 17)
        Me.RadiobtnBhsIndo.TabIndex = 18
        Me.RadiobtnBhsIndo.TabStop = True
        Me.RadiobtnBhsIndo.Text = "Bahasa Indonesia"
        Me.RadiobtnBhsIndo.UseVisualStyleBackColor = True
        '
        'TextBoxStockUpdate
        '
        Me.TextBoxStockUpdate.Location = New System.Drawing.Point(319, 370)
        Me.TextBoxStockUpdate.Name = "TextBoxStockUpdate"
        Me.TextBoxStockUpdate.Size = New System.Drawing.Size(186, 20)
        Me.TextBoxStockUpdate.TabIndex = 46
        '
        'LblKategori
        '
        Me.LblKategori.AutoSize = True
        Me.LblKategori.Location = New System.Drawing.Point(177, 487)
        Me.LblKategori.Name = "LblKategori"
        Me.LblKategori.Size = New System.Drawing.Size(46, 13)
        Me.LblKategori.TabIndex = 45
        Me.LblKategori.Text = "Kategori"
        '
        'LblBahasa
        '
        Me.LblBahasa.AutoSize = True
        Me.LblBahasa.Location = New System.Drawing.Point(177, 401)
        Me.LblBahasa.Name = "LblBahasa"
        Me.LblBahasa.Size = New System.Drawing.Size(43, 13)
        Me.LblBahasa.TabIndex = 44
        Me.LblBahasa.Text = "Bahasa"
        '
        'LblStock
        '
        Me.LblStock.AutoSize = True
        Me.LblStock.Location = New System.Drawing.Point(177, 373)
        Me.LblStock.Name = "LblStock"
        Me.LblStock.Size = New System.Drawing.Size(35, 13)
        Me.LblStock.TabIndex = 43
        Me.LblStock.Text = "Stock"
        '
        'DateTimePickerMasukKoleksiUpdate
        '
        Me.DateTimePickerMasukKoleksiUpdate.Location = New System.Drawing.Point(319, 336)
        Me.DateTimePickerMasukKoleksiUpdate.Name = "DateTimePickerMasukKoleksiUpdate"
        Me.DateTimePickerMasukKoleksiUpdate.Size = New System.Drawing.Size(186, 20)
        Me.DateTimePickerMasukKoleksiUpdate.TabIndex = 42
        '
        'TextBoxLokasiRakUpdate
        '
        Me.TextBoxLokasiRakUpdate.Location = New System.Drawing.Point(319, 304)
        Me.TextBoxLokasiRakUpdate.Name = "TextBoxLokasiRakUpdate"
        Me.TextBoxLokasiRakUpdate.Size = New System.Drawing.Size(186, 20)
        Me.TextBoxLokasiRakUpdate.TabIndex = 41
        '
        'LblTanggal
        '
        Me.LblTanggal.AutoSize = True
        Me.LblTanggal.Location = New System.Drawing.Point(177, 336)
        Me.LblTanggal.Name = "LblTanggal"
        Me.LblTanggal.Size = New System.Drawing.Size(118, 13)
        Me.LblTanggal.TabIndex = 40
        Me.LblTanggal.Text = "Tanggal Masuk Koleksi"
        '
        'TextBoxTahunPenerbitUpdate
        '
        Me.TextBoxTahunPenerbitUpdate.Location = New System.Drawing.Point(319, 265)
        Me.TextBoxTahunPenerbitUpdate.Name = "TextBoxTahunPenerbitUpdate"
        Me.TextBoxTahunPenerbitUpdate.Size = New System.Drawing.Size(186, 20)
        Me.TextBoxTahunPenerbitUpdate.TabIndex = 38
        '
        'LblTahunTerbit
        '
        Me.LblTahunTerbit.AutoSize = True
        Me.LblTahunTerbit.Location = New System.Drawing.Point(177, 272)
        Me.LblTahunTerbit.Name = "LblTahunTerbit"
        Me.LblTahunTerbit.Size = New System.Drawing.Size(68, 13)
        Me.LblTahunTerbit.TabIndex = 37
        Me.LblTahunTerbit.Text = "Tahun Terbit"
        '
        'LBlLokasiRak
        '
        Me.LBlLokasiRak.AutoSize = True
        Me.LBlLokasiRak.Location = New System.Drawing.Point(177, 307)
        Me.LBlLokasiRak.Name = "LBlLokasiRak"
        Me.LBlLokasiRak.Size = New System.Drawing.Size(61, 13)
        Me.LBlLokasiRak.TabIndex = 39
        Me.LBlLokasiRak.Text = "Lokasi Rak"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'TextBoxPenerbitUpdate
        '
        Me.TextBoxPenerbitUpdate.Location = New System.Drawing.Point(319, 232)
        Me.TextBoxPenerbitUpdate.Name = "TextBoxPenerbitUpdate"
        Me.TextBoxPenerbitUpdate.Size = New System.Drawing.Size(186, 20)
        Me.TextBoxPenerbitUpdate.TabIndex = 36
        '
        'LblPenerbit
        '
        Me.LblPenerbit.AutoSize = True
        Me.LblPenerbit.Location = New System.Drawing.Point(177, 235)
        Me.LblPenerbit.Name = "LblPenerbit"
        Me.LblPenerbit.Size = New System.Drawing.Size(46, 13)
        Me.LblPenerbit.TabIndex = 35
        Me.LblPenerbit.Text = "Penerbit"
        '
        'LblDeskripsi
        '
        Me.LblDeskripsi.AutoSize = True
        Me.LblDeskripsi.Location = New System.Drawing.Point(177, 102)
        Me.LblDeskripsi.Name = "LblDeskripsi"
        Me.LblDeskripsi.Size = New System.Drawing.Size(50, 13)
        Me.LblDeskripsi.TabIndex = 34
        Me.LblDeskripsi.Text = "Deskripsi"
        '
        'LblJenisKoleksi
        '
        Me.LblJenisKoleksi.AutoSize = True
        Me.LblJenisKoleksi.Location = New System.Drawing.Point(177, 70)
        Me.LblJenisKoleksi.Name = "LblJenisKoleksi"
        Me.LblJenisKoleksi.Size = New System.Drawing.Size(68, 13)
        Me.LblJenisKoleksi.TabIndex = 33
        Me.LblJenisKoleksi.Text = "Jenis Koleksi"
        '
        'LblNamaKoleksi
        '
        Me.LblNamaKoleksi.AutoSize = True
        Me.LblNamaKoleksi.Location = New System.Drawing.Point(177, 34)
        Me.LblNamaKoleksi.Name = "LblNamaKoleksi"
        Me.LblNamaKoleksi.Size = New System.Drawing.Size(72, 13)
        Me.LblNamaKoleksi.TabIndex = 32
        Me.LblNamaKoleksi.Text = "Nama Koleksi"
        '
        'RichTextBoxDeskripsiUpdate
        '
        Me.RichTextBoxDeskripsiUpdate.Location = New System.Drawing.Point(319, 102)
        Me.RichTextBoxDeskripsiUpdate.Name = "RichTextBoxDeskripsiUpdate"
        Me.RichTextBoxDeskripsiUpdate.Size = New System.Drawing.Size(186, 113)
        Me.RichTextBoxDeskripsiUpdate.TabIndex = 31
        Me.RichTextBoxDeskripsiUpdate.Text = ""
        '
        'ComboBoxJenisKoleksiUpdate
        '
        Me.ComboBoxJenisKoleksiUpdate.FormattingEnabled = True
        Me.ComboBoxJenisKoleksiUpdate.Items.AddRange(New Object() {"Buku", "Ensiklopedia", "Koran", "Majalah", "Publikasi ", "Penelitian"})
        Me.ComboBoxJenisKoleksiUpdate.Location = New System.Drawing.Point(319, 67)
        Me.ComboBoxJenisKoleksiUpdate.Name = "ComboBoxJenisKoleksiUpdate"
        Me.ComboBoxJenisKoleksiUpdate.Size = New System.Drawing.Size(186, 21)
        Me.ComboBoxJenisKoleksiUpdate.TabIndex = 30
        '
        'TextBoxNamaKoleksiUpdate
        '
        Me.TextBoxNamaKoleksiUpdate.Location = New System.Drawing.Point(319, 31)
        Me.TextBoxNamaKoleksiUpdate.Name = "TextBoxNamaKoleksiUpdate"
        Me.TextBoxNamaKoleksiUpdate.Size = New System.Drawing.Size(186, 20)
        Me.TextBoxNamaKoleksiUpdate.TabIndex = 29
        '
        'UpdateKoleksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(932, 726)
        Me.Controls.Add(Me.PictureBoxFoto)
        Me.Controls.Add(Me.BtnTambahGambar)
        Me.Controls.Add(Me.btnTambahKoleksiUpdate)
        Me.Controls.Add(Me.GroupBoxKategoriUpdate)
        Me.Controls.Add(Me.GroupBoxBahasaUpdate)
        Me.Controls.Add(Me.TextBoxStockUpdate)
        Me.Controls.Add(Me.LblKategori)
        Me.Controls.Add(Me.LblBahasa)
        Me.Controls.Add(Me.LblStock)
        Me.Controls.Add(Me.DateTimePickerMasukKoleksiUpdate)
        Me.Controls.Add(Me.TextBoxLokasiRakUpdate)
        Me.Controls.Add(Me.LblTanggal)
        Me.Controls.Add(Me.TextBoxTahunPenerbitUpdate)
        Me.Controls.Add(Me.LblTahunTerbit)
        Me.Controls.Add(Me.LBlLokasiRak)
        Me.Controls.Add(Me.TextBoxPenerbitUpdate)
        Me.Controls.Add(Me.LblPenerbit)
        Me.Controls.Add(Me.LblDeskripsi)
        Me.Controls.Add(Me.LblJenisKoleksi)
        Me.Controls.Add(Me.LblNamaKoleksi)
        Me.Controls.Add(Me.RichTextBoxDeskripsiUpdate)
        Me.Controls.Add(Me.ComboBoxJenisKoleksiUpdate)
        Me.Controls.Add(Me.TextBoxNamaKoleksiUpdate)
        Me.Name = "UpdateKoleksi"
        Me.Text = "UpdateKoleksi"
        CType(Me.PictureBoxFoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxKategoriUpdate.ResumeLayout(False)
        Me.GroupBoxKategoriUpdate.PerformLayout()
        Me.GroupBoxBahasaUpdate.ResumeLayout(False)
        Me.GroupBoxBahasaUpdate.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CheckBoxTeknologi As CheckBox
    Friend WithEvents PictureBoxFoto As PictureBox
    Friend WithEvents BtnTambahGambar As Button
    Friend WithEvents btnTambahKoleksiUpdate As Button
    Friend WithEvents GroupBoxKategoriUpdate As GroupBox
    Friend WithEvents CheckBoxBudaya As CheckBox
    Friend WithEvents CheckBoxSosial As CheckBox
    Friend WithEvents CheckBoxSains As CheckBox
    Friend WithEvents GroupBoxBahasaUpdate As GroupBox
    Friend WithEvents RadioBtnBhsInggris As RadioButton
    Friend WithEvents RadiobtnBhsIndo As RadioButton
    Friend WithEvents TextBoxStockUpdate As TextBox
    Friend WithEvents LblKategori As Label
    Friend WithEvents LblBahasa As Label
    Friend WithEvents LblStock As Label
    Friend WithEvents DateTimePickerMasukKoleksiUpdate As DateTimePicker
    Friend WithEvents TextBoxLokasiRakUpdate As TextBox
    Friend WithEvents LblTanggal As Label
    Friend WithEvents TextBoxTahunPenerbitUpdate As TextBox
    Friend WithEvents LblTahunTerbit As Label
    Friend WithEvents LBlLokasiRak As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents TextBoxPenerbitUpdate As TextBox
    Friend WithEvents LblPenerbit As Label
    Friend WithEvents LblDeskripsi As Label
    Friend WithEvents LblJenisKoleksi As Label
    Friend WithEvents LblNamaKoleksi As Label
    Friend WithEvents RichTextBoxDeskripsiUpdate As RichTextBox
    Friend WithEvents ComboBoxJenisKoleksiUpdate As ComboBox
    Friend WithEvents TextBoxNamaKoleksiUpdate As TextBox
End Class
