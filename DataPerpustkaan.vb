﻿Imports System.Text
Imports MySql.Data.MySqlClient
Imports Mysqlx.XDevAPI.Common

Public Class DataPerpustkaan
    Private namakoleksi As String
    Private jeniskoleksi As String
    Private deskripsi As String
    Private penerbit As String
    Private tahunterbit As String
    Private lokasirak As String
    Private tanggalmasuk As String
    Private stock As String
    Private bahasa As String
    Private foto As String
    Private kategori As New List(Of String)
    Private deleteItem
    Private koleksiDataTable As New ArrayList()

    Public Property GSfoto() As String
        Get
            Return foto
        End Get
        Set(ByVal value As String)
            foto = value
        End Set
    End Property

    Public Property GSnamaKoleksi() As String
        Get
            Return namakoleksi
        End Get
        Set(value As String)
            namakoleksi = value
        End Set
    End Property

    Public Property GSjenisKoleksi() As String
        Get
            Return jeniskoleksi
        End Get
        Set(value As String)
            jeniskoleksi = value
        End Set
    End Property

    Public Property GSdeskripsi() As String
        Get
            Return deskripsi
        End Get
        Set(value As String)
            deskripsi = value
        End Set
    End Property

    Public Property GSPenerbit() As String
        Get
            Return penerbit
        End Get
        Set(value As String)
            penerbit = value
        End Set
    End Property

    Public Property GStahunterbit() As String
        Get
            Return tahunterbit
        End Get
        Set(value As String)
            tahunterbit = value
        End Set
    End Property

    Public Property GSlokasiRak() As String
        Get
            Return lokasirak
        End Get
        Set(value As String)
            lokasirak = value
        End Set
    End Property

    Public Property GStanggalMasuk() As String
        Get
            Return tanggalmasuk
        End Get
        Set(value As String)
            tanggalmasuk = value
        End Set
    End Property

    Public Property GSstock() As String
        Get
            Return stock
        End Get
        Set(value As String)
            stock = value
        End Set
    End Property

    Public Property GSbahasa() As String
        Get
            Return bahasa
        End Get
        Set(value As String)
            bahasa = value
        End Set
    End Property

    Public Property GSkategori() As List(Of String)
        Get
            Return kategori
        End Get
        Set(value As List(Of String))
            kategori = value
        End Set
    End Property

    Public Property GSdelete() As String
        Get
            Return deleteItem
        End Get
        Set(value As String)
            deleteItem = value
        End Set
    End Property


    Public Sub addkoleksiData(dir_gambar As String,
                                        nama_koleksi As String,
                                        jenis_koleksi As String,
                                        penerbit_koleksi As String,
                                        deskripsi_koleksi As String,
                                        tahun_terbit As String,
                                        lokasi_rak As String,
                                        tanggal_masuk As String,
                                        stock_koleksi As String,
                                        bahasa_koleksi As String,
                                        kategori_koleksi As String)
        koleksiDataTable.Add({dir_gambar,
                             nama_koleksi,
                             penerbit_koleksi,
                             deskripsi_koleksi,
                             tahun_terbit,
                             lokasi_rak,
                             tanggal_masuk,
                             stock_koleksi,
                             bahasa_koleksi,
                             kategori_koleksi})
    End Sub

    Public Sub RemoveKoleksiDataTable(index As Integer)
        koleksiDataTable.Remove(index)
    End Sub

    Public ReadOnly Property getkoleksiDataTable() As ArrayList
        Get
            Return koleksiDataTable
        End Get
    End Property

    Public Function ConvertkoleksiToString(vals As List(Of String))
        Dim builder As StringBuilder = New StringBuilder()
        For Each Val As String In vals
            builder.Append(Val).Append("|")
        Next

        'convert to string . 
        Dim res = builder.ToString()
        Return res
    End Function

    Public Function ConvertStringToKoleksi(value As String)
        Dim arr() As String = value.Split("|")

        'convert to list.
        Dim vals As List(Of String) = arr.ToList()
        Return vals
    End Function

    'database global variable
    Public Shared dbConn As New MySqlConnection
    Public Shared sqlCommand As New MySqlCommand
    Public Shared sqlread As MySqlDataReader

    Private sqlQuery As String
    Private server As String = "localhost"
    Private username As String = "root"
    Private password As String = ""
    Private database As String = "perpustakaan"

    Public Function GetDataKoleksiDatabase() As DataTable
        Dim result As New DataTable

        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
            + "password=" + password + ";" + "database =" + database
        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT id_koleksi AS 'ID', 
                                  nama_koleksi AS 'Nama Koleksi',
                                  jenis_koleksi AS 'Jenis Koleksi',
                                  penerbit AS 'Penerbit', 
                                  tahun_terbit AS 'Tahun Terbit',
                                  tanggal_masuk_koleksi AS 'Tanggal Masuk',
                                  lokasi AS 'Lokasi Rak',
                                  stock AS 'Stock',
                                  bahasa AS 'Bahasa'
                                  From koleksi"

        sqlread = sqlCommand.ExecuteReader

        result.Load(sqlread)
        sqlread.Close()
        dbConn.Close()
        Return result
    End Function

    Public Function AddDataKoleksiDatabase(dir_gambar As String,
                                        nama_koleksi As String,
                                        jenis_koleksi As String,
                                        penerbit_koleksi As String,
                                        deskripsi_koleksi As String,
                                        tahun_terbit As String,
                                        lokasi_rak As String,
                                        tanggal_masuk As Date,
                                        stock_koleksi As String,
                                        bahasa_koleksi As String,
                                        kategori_koleksi As String)

        Try

            MessageBox.Show("test")
            dbConn.ConnectionString = "server = " + server + ";" + "user id=" + username + ";" _
                + "password=" + password + ";" + "database =" + database

            dbConn.Open()

            sqlCommand.Connection = dbConn
            sqlQuery = "INSERT INTO koleksi(
                            nama_koleksi, 
                            dir_gambar,
                            deskripsi, 
                            penerbit, 
                            jenis_koleksi,
                            tahun_terbit, 
                            lokasi, 
                            tanggal_masuk_koleksi,
                            stock, 
                            bahasa, 
                            kategori
                        ) VALUE('" _
                & nama_koleksi & "','" _
                & dir_gambar & "', '" _
                & deskripsi_koleksi & "', '" _
                & penerbit_koleksi & "', '" _
                & jenis_koleksi & "', '" _
                & tahun_terbit & "', '" _
                & lokasi_rak & "', ' " _
                & tanggal_masuk.ToString("yyyy/MM/dd") & "', '" _
                & stock_koleksi & "', '" _
                & bahasa_koleksi & "', '" _
                & kategori_koleksi & "')"


            MessageBox.Show(sqlQuery)
            Debug.Print(sqlQuery)

            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlread = sqlCommand.ExecuteReader


            sqlread.Close()
            dbConn.Close()
        Catch ex As Exception
            Return ex.Message
        Finally
            dbConn.Dispose()
        End Try
    End Function

    Public Function GetDataKoleksiIDDatabase(ID As Integer) As List(Of String)
        Dim result As New List(Of String)

        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
         + "password=" + password + ";" + "database =" + database
        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT id_koleksi,
                                    nama_koleksi,
                                    dir_gambar,
                                    deskripsi,
                                    penerbit,
                                    jenis_koleksi,
                                    tahun_terbit,
                                    lokasi,
                                    tanggal_masuk,
                                    stock,
                                    bahasa,
                                    kategori
                                    FROM koleksi
                                    WHERE id_koleksi= '" & ID & "'"

        sqlread = sqlCommand.ExecuteReader

        While sqlread.Read
            result.Add(sqlread.GetString(0).ToString())
            result.Add(sqlread.GetString(1).ToString())
            result.Add(sqlread.GetString(2).ToString())
            result.Add(sqlread.GetString(3).ToString())
            result.Add(sqlread.GetString(4).ToString())
            result.Add(sqlread.GetString(5).ToString())
            result.Add(sqlread.GetString(6).ToString())
            result.Add(sqlread.GetString(7).ToString())
            result.Add(sqlread.GetString(8).ToString())
            result.Add(sqlread.GetString(9).ToString())
            result.Add(sqlread.GetString(10).ToString())
            result.Add(sqlread.GetString(11).ToString())
        End While

        sqlread.Close()
        dbConn.Close()
        Return result
    End Function

    Public Function UpdateDataKoleksiByIDDatabase(ID As Integer,
                                        dir_gambar As String,
                                        nama_koleksi As String,
                                        jenis_koleksi As String,
                                        penerbit_koleksi As String,
                                        deskripsi_koleksi As String,
                                        tahun_terbit As String,
                                        lokasi_rak As String,
                                        tanggal_masuk As String,
                                        stock_koleksi As String,
                                        bahasa_koleksi As String,
                                        kategori_koleksi As String)

        tahun_terbit = tahun_terbit.ToString()
        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
         + "password=" + password + ";" + "database =" + database

        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "UPDATE koleksi SET " &
            "nama_koleksi=' " & nama_koleksi & "', " &
            "deksripsi=' " & deskripsi_koleksi & "', " &
            "penerbit=' " & penerbit_koleksi & "', " &
            "jenis_koleksi=' " & jenis_koleksi & "', " &
            "tahun_terbit=' " & tahun_terbit & "', " &
            "lokasi=' " & lokasi_rak & "', " &
            "tanggal_masuk_koleksi=' " & tanggal_masuk & "', " &
            "stock=' " & stock_koleksi & "', " &
            "bahasa=' " & bahasa_koleksi & "', " &
            "kategori=' " & kategori_koleksi & "', " &
            "WHERE id_koleksi=' " & ID & "'"

            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlread = sqlCommand.ExecuteReader
            dbConn.Close()

            sqlread.Close()
            dbConn.Close()
        Catch ex As Exception
            Return ex.Message
        Finally
            dbConn.Dispose()
        End Try
    End Function

    Public Function DeleteDataKoleksiByIDDatabase(ID As Integer)

        dbConn.ConnectionString = "server -" + server + ";" + "user id-" + username + ";" _
            + "password-" + password + ";" + "database -" + database

        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "DELETE FROM koleksi " &
                    "WHERE id_koleksi-'" & ID & "'"


            Debug.WriteLine(sqlQuery)

            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlread = sqlCommand.ExecuteReader
            dbConn.Close()

            'perpustakaan.sqlDt.Load(sqlRead)
            sqlread.Close()
            dbConn.Close()
        Catch ex As Exception
            Return ex.Message
        Finally
            dbConn.Dispose()
        End Try
    End Function
End Class

