Imports System.Windows.Forms.VisualStyles.VisualStyleElement ' --> import visual style (opsional)
Imports MySql.Data.MySqlClient ' --> import library MySQL Connector/NET untuk operasi database

Public Class MataKuliahControl ' --> class user control untuk CRUD mata kuliah

    Private selectedId As Integer ' --> variabel penyimpan id mata kuliah yang sedang dipilih






    ' ====================================
    ' MENAMPILKAN DATA DALAM BENTUK TABEL 
    ' ====================================
    Private Sub tampilData() ' --> method untuk menampilkan data mata kuliah ke DataGridView

        connection() ' --> panggil fungsi koneksi database

        Try ' --> blok try untuk menangkap error

            Dim vData As New MySqlDataAdapter(
                "SELECT m.id_mata_kuliah, m.nama_mata_kuliah, j.nama_jurusan, m.kode_mata_kuliah 
                 FROM mata_kuliah m 
                 JOIN jurusan j ON m.id_jurusan = j.id_jurusan", conn) ' --> query join mk + jurusan

            Dim ds As New DataSet() ' --> buat DataSet kosong
            vData.Fill(ds, "mata_kuliah") ' --> isi dataset dengan hasil query
            dgvMataKuliah.DataSource = ds.Tables("mata_kuliah") ' --> tampilkan ke DataGridView

            dgvMataKuliah.Columns("id_mata_kuliah").Visible = False ' --> sembunyikan kolom id

        Catch ex As Exception
            MsgBox("Data Gagal Ditampilkan: " & ex.Message, MsgBoxStyle.Information) ' --> jika error tampilkan pesan
        End Try

    End Sub






    ' =============================
    ' MERESSET / MEMBERSIHKAN FORM
    ' =============================
    Private Sub clearForm() ' --> menghapus isi seluruh input form

        txtNamaMK.Clear() ' --> kosongkan textbox nama mata kuliah
        txtKodeMK.Clear() ' --> kosongkan textbox kode mk
        cmbJurusan.SelectedIndex = -1 ' --> reset combobox jurusan agar tidak terpilih apapun

    End Sub






    ' ===================================================
    ' UTILITY: MENDAPATKAN ID BERDASARKAN NAMA (COMBOBOX)
    ' ===================================================
    Private Function GetId(table As String, idColumn As String, namaColumn As String, namaValue As String) As Integer

        Dim result As Integer = 0 ' --> default 0 artinya tidak ditemukan

        Dim query = $"SELECT {idColumn} FROM {table} WHERE {namaColumn}=@name LIMIT 1" ' --> query parametris

        Using cmd As New MySqlCommand(query, conn) ' --> buat command
            cmd.Parameters.AddWithValue("@name", namaValue) ' --> isi parameter @name
            Dim rd = cmd.ExecuteReader() ' --> eksekusi reader

            If rd.Read() Then ' --> kalau ada baris
                result = Convert.ToInt32(rd(idColumn)) ' --> ambil nilai id
            End If

            rd.Close() ' --> tutup reader
        End Using

        Return result ' --> kembalikan id

    End Function






    ' ==================================
    ' CREATE: MENAMBAH DATA MATA KULIAH
    ' ==================================
    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click

        connection() ' --> aktifkan koneksi

        Dim id_jurusan = GetId("jurusan", "id_jurusan", "nama_jurusan", cmbJurusan.Text) ' --> ambil id jurusan dari combo

        Try ' --> blok try menangkap error

            Dim query As String =
                "INSERT INTO mata_kuliah 
                 (nama_mata_kuliah, id_jurusan, kode_mata_kuliah) 
                 VALUES 
                 (@nama_mata_kuliah, @id_jurusan, @kode_mata_kuliah)" ' --> query insert parametris

            Using cmd = New MySqlCommand(query, conn) ' --> buat command SQL
                cmd.Parameters.AddWithValue("@nama_mata_kuliah", txtNamaMK.Text) ' --> parameter nama mk
                cmd.Parameters.AddWithValue("@kode_mata_kuliah", txtKodeMK.Text) ' --> parameter kode mk
                cmd.Parameters.AddWithValue("@id_jurusan", id_jurusan) ' --> parameter id jurusan
                cmd.ExecuteNonQuery() ' --> eksekusi insert
            End Using

            MsgBox("Berhasil Ditambahkan!", MsgBoxStyle.Information, "Berhasil") ' --> notifikasi sukses
            tampilData() ' --> refresh datagrid
            clearForm() ' --> reset form

        Catch ex As Exception
            MsgBox("Gagal Ditambahkan: " & ex.Message, MsgBoxStyle.Information) ' --> pesan error
        End Try

    End Sub





    ' ====================================
    ' LOAD DATA SAAT CONTROL DIBUKA
    ' ====================================
    Private Sub dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        tampilData() ' --> tampilkan data mk ke tabel

        ' --> isi combobox jurusan (sementara manual, bisa pake loadCombo)
        cmbJurusan.Items.Add("Teknik Informatika")
        cmbJurusan.Items.Add("Sistem Informasi")
        cmbJurusan.Items.Add("Komputerisasi Akuntansi")

    End Sub







    ' ====================================
    ' UPDATE: MENGEDIT DATA MATA KULIAH  
    ' ====================================
    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click

        connection() ' --> buka koneksi

        Dim id_jurusan = GetId("jurusan", "id_jurusan", "nama_jurusan", cmbJurusan.Text) ' --> ambil id jurusan

        Try

            Dim query As String =
                "UPDATE mata_kuliah SET 
                    nama_mata_kuliah = @nama_mata_kuliah,
                    id_jurusan = @id_jurusan,
                    kode_mata_kuliah = @kode_mata_kuliah
                 WHERE 
                    id_mata_kuliah = @id_mata_kuliah" ' --> query update parametris

            Using cmd As New MySqlCommand(query, conn) ' --> buat command
                cmd.Parameters.AddWithValue("@nama_mata_kuliah", txtNamaMK.Text) ' --> isi nama mk
                cmd.Parameters.AddWithValue("@kode_mata_kuliah", txtKodeMK.Text) ' --> isi kode mk
                cmd.Parameters.AddWithValue("@id_jurusan", id_jurusan) ' --> isi id jurusan
                cmd.Parameters.AddWithValue("@id_mata_kuliah", selectedId) ' --> id mk yang diupdate
                cmd.ExecuteNonQuery() ' --> jalankan update
            End Using

            MsgBox("Data Berhasil Diperbaharui!", MsgBoxStyle.Information, "Berhasil") ' --> pesan sukses
            tampilData() ' --> refresh data
            clearForm() ' --> reset form

        Catch ex As Exception
            MsgBox("Data Gagal Diperbaharui: " & ex.Message, MsgBoxStyle.Critical) ' --> pesan error
        End Try

    End Sub






    ' ====================================
    ' DELETE: MENGHAPUS DATA MATA KULIAH  
    ' ====================================
    Private Sub btn_hapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click

        connection() ' --> aktifkan koneksi

        Try

            Dim query As String = "DELETE FROM mata_kuliah WHERE id_mata_kuliah = @id_mata_kuliah" ' --> query delete

            Using cmd As New MySqlCommand(query, conn) ' --> buat command
                cmd.Parameters.AddWithValue("@id_mata_kuliah", selectedId) ' --> id mk yang akan dihapus
                cmd.ExecuteNonQuery() ' --> jalankan delete
            End Using

            MsgBox("Data Berhasil Dihapus!", MsgBoxStyle.Information, "Berhasil") ' --> pesan sukses
            tampilData() ' --> refresh tabel
            clearForm() ' --> reset form

        Catch ex As Exception
            MsgBox("Gagal Menghapus: " & ex.Message, MsgBoxStyle.Critical) ' --> tampilkan error
        End Try

    End Sub







    ' ======================================================
    ' LOAD DATA KE FORM KETIKA ROW TABEL DI-CLICK
    ' ======================================================
    Private Sub dgvMataKuliah_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMataKuliah.CellClick

        If e.RowIndex >= 0 Then ' --> hanya eksekusi jika klik di baris data

            Dim row As DataGridViewRow = dgvMataKuliah.Rows(e.RowIndex) ' --> ambil baris yg diklik

            selectedId = Convert.ToInt32(row.Cells("id_mata_kuliah").Value) ' --> simpan id mk

            txtNamaMK.Text = row.Cells("nama_mata_kuliah").Value.ToString() ' --> isi nama mk
            txtKodeMK.Text = row.Cells("kode_mata_kuliah").Value.ToString() ' --> isi kode mk

            Dim jr As String = row.Cells("nama_jurusan").Value.ToString() ' --> ambil nama jurusan

            If cmbJurusan.Items.Contains(jr) Then ' --> kalau combobox berisi jurusan tsb
                cmbJurusan.SelectedItem = jr ' --> pilih jurusan
            Else
                cmbJurusan.SelectedIndex = -1 ' --> reset jika tidak ada
            End If

        End If

    End Sub




    ' ======================================================
    ' PENCARIAN: MENCARI MATA KULIAH BERDASARKAN KEYWORD
    ' ======================================================
    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click

        connection() ' --> koneksi aktif

        Try

            ' --> kalau kolom pencarian kosong, tampilkan semua data
            If txtCari.Text.Trim() = "" Then
                tampilData()
                Return
            End If

            Dim keyword As String = "%" & txtCari.Text & "%" ' --> wildcard pencarian

            Dim query As String =
                "SELECT m.id_mata_kuliah, m.nama_mata_kuliah, j.nama_jurusan, m.kode_mata_kuliah
                 FROM mata_kuliah m
                 JOIN jurusan j ON m.id_jurusan = j.id_jurusan
                 WHERE 
                    m.nama_mata_kuliah LIKE @keyword
                    OR j.nama_jurusan LIKE @keyword
                    OR m.kode_mata_kuliah LIKE @keyword" ' --> query search beberapa kolom

            Using cmd As New MySqlCommand(query, conn) ' --> buat command
                cmd.Parameters.AddWithValue("@keyword", keyword) ' --> parameter search

                Dim adapter As New MySqlDataAdapter(cmd) ' --> buat adapter
                Dim ds As New DataSet() ' --> dataset untuk menampung hasil query
                adapter.Fill(ds, "mata_kuliah") ' --> fill dataset

                dgvMataKuliah.DataSource = ds.Tables("mata_kuliah") ' --> tampilkan data
            End Using

        Catch ex As Exception
            MsgBox("Gagal mencari: " & ex.Message) ' --> pesan error
        End Try

    End Sub

End Class
