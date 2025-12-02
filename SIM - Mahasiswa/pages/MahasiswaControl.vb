Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient ' --> import library MySQL Connector/NET

Public Class MahasiswaControl ' --> Class




    Private selectedId As Integer = 0 ' --> variabel penyimpan id mahasiswa yang sedang dipilih 






    ' ====================================
    ' MENAMPILKAN DATA DALAM BENTUK TABEL
    ' ====================================
    Private Sub tampilData() ' --> method untuk mengisi dgvMahasiswa dari database
        connection()  ' --> panggil fungsi koneksi


        Try ' --> mulai blok try untuk menangkap exception
            Dim vData As New MySqlDataAdapter(
                "SELECT m.id_mahasiswa, m.nim, m.nama_mahasiswa, m.alamat, m.email, m.jenis_kelamin, m.tgl_lahir, j.nama_jurusan " &
                "FROM mahasiswa m JOIN jurusan j ON m.id_jurusan = j.id_jurusan", conn)  ' --> query join mahasiswa + jurusan, lalu bungkus di DataAdapter


            Dim ds As New DataSet() ' --> buat DataSet kosong untuk menampung hasil query
            vData.Fill(ds, "mahasiswa") ' --> isi DataSet dengan hasil query, tabel diberi nama "mahasiswa"
            dgvMahasiswa.DataSource = ds.Tables("mahasiswa") ' --> set DataSource DataGridView ke tabel "mahasiswa" di DataSet
            dgvMahasiswa.Columns("id_mahasiswa").Visible = False ' --> sembunyikan kolom id_mahasiswa di tampilan (tetap ada di data)


        Catch ex As Exception
            MsgBox("Data Gagal Ditampilkan: " & ex.Message, MsgBoxStyle.Information) ' --> tampilkan pesan kalau gagal
        End Try ' --> akhir blok try/catch
    End Sub




    ' ======================================
    ' MENGHAPUS / MERESET FORM SETELAH CRUD
    ' ======================================
    Private Sub clearForm() ' --> method untuk mereset semua input form ke kondisi awal

        txtNim.Clear() ' --> kosongkan textbox NIM
        txtNamaMahasiswa.Clear() ' --> kosongkan textbox nama
        txtAlamat.Clear() ' --> kosongkan textbox alamat
        txtEmail.Clear() ' --> kosongkan textbox email
        dtpTanggalLahir.Value = Date.Now() ' --> set DateTimePicker ke tanggal sekarang
        cmbKelamin.SelectedIndex = -1 ' --> reset combobox jenis kelamin (tidak ada pilihan terpilih)
        cmbJurusan.SelectedIndex = -1 ' --> reset combobox jurusan (tidak ada pilihan terpilih)
        selectedId = 0  ' --> reset selectedId supaya tidak tersisa nilai lama

    End Sub






    ' =============================
    ' LOAD DATA KE COMBOBOX JURUSAN
    ' =============================
    Private Sub loadCombo() ' --> method untuk mengisi cmbJurusan dari tabel jurusan

        Try ' --> mulai try

            cmbJurusan.Items.Clear() ' --> kosongkan item yg ada di combo dulu agar tidak duplikat


            Using cmd As New MySqlCommand("SELECT id_jurusan, nama_jurusan FROM jurusan", conn)  ' --> buat command select jurusan
                Using rd = cmd.ExecuteReader() ' --> eksekusi reader untuk mengambil data baris per baris
                    While rd.Read() ' --> loop selama masih ada baris hasil query
                        cmbJurusan.Items.Add(rd("nama_jurusan").ToString())  ' --> tambahkan nama_jurusan ke combo sebagai string
                    End While ' --> akhir loop
                End Using ' --> tutup reader
            End Using ' --> tutup command


        Catch ex As Exception
            MsgBox("Data comboBox gagal ditampilkan: " & ex.Message, MsgBoxStyle.Information)  ' --> tampilkan error bila gagal
        End Try ' --> akhir try/catch

    End Sub




    ' ===================================================
    ' UTILITY: MENDAPATKAN ID DARI NAMA (umum untuk combo)
    ' ===================================================
    Private Function GetId(table As String, idColumn As String, namaColumn As String, namaValue As String) As Integer

        Dim result As Integer = 0 ' --> inisialisasi hasil default 0 (0 artinya tidak ketemu)


        Dim query = $"SELECT {idColumn} FROM {table} WHERE {namaColumn}=@name LIMIT 1" ' --> query parametris untuk menghindari SQL injection


        Using cmd As New MySqlCommand(query, conn) ' --> buat command
            cmd.Parameters.AddWithValue("@name", namaValue) ' --> set parameter @name dengan namaValue
            Dim rd = cmd.ExecuteReader() ' --> eksekusi reader
            If rd.Read() Then ' --> jika ada baris
                result = Convert.ToInt32(rd(idColumn)) ' --> ambil kolom id dan konversi ke Integer
            End If

            rd.Close() ' --> tutup reader
        End Using ' --> dispose command
        Return result ' --> kembalikan hasil

    End Function





    ' ===============================
    ' CREATE: MENAMBAH DATA MAHASISWA
    ' ===============================
    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click

        connection() ' --> pastikan koneksi aktif sebelum operasi DB


        Dim id_jurusan = GetId("jurusan", "id_jurusan", "nama_jurusan", cmbJurusan.Text) ' --> ambil id_jurusan dari combo berdasarkan teks yang dipilih

        Try
            Dim query As String = "
                INSERT INTO mahasiswa
                (nim, nama_mahasiswa, alamat, email, jenis_kelamin, tgl_lahir, id_jurusan)
                VALUES
                (@nim, @nama_mahasiswa, @alamat, @email, @jenis_kelamin, @tgl_lahir, @id_jurusan)"  ' --> query insert dengan parameter

            Using cmd = New MySqlCommand(query, conn) ' --> buat MySqlCommand
                cmd.Parameters.AddWithValue("@nim", txtNim.Text)  ' --> isi parameter @nim dengan isi textbox NIM
                cmd.Parameters.AddWithValue("@nama_mahasiswa", txtNamaMahasiswa.Text) ' --> isi nama
                cmd.Parameters.AddWithValue("@alamat", txtAlamat.Text) ' --> isi alamat
                cmd.Parameters.AddWithValue("@email", txtEmail.Text) ' --> isi email

                cmd.Parameters.AddWithValue("@jenis_kelamin", cmbKelamin.Text)

                cmd.Parameters.AddWithValue("@tgl_lahir", dtpTanggalLahir.Value.ToString("yyyy-MM-dd")) ' --> format tanggal ke yyyy-MM-dd
                cmd.Parameters.AddWithValue("@id_jurusan", id_jurusan) ' --> id jurusan dari fungsi GetId

                cmd.ExecuteNonQuery() ' --> eksekusi perintah insert
            End Using

            MsgBox("Berhasil Ditambahkan!", MsgBoxStyle.Information, "Berhasil") ' --> pesan sukses
            tampilData() ' --> refresh tabel setelah insert
            clearForm()  ' --> bersihkan form

        Catch ex As Exception
            MsgBox("Gagal Ditambahkan: " & ex.Message, MsgBoxStyle.Information) ' --> pesan error kalau gagal
        End Try

    End Sub






    ' ========================
    ' LOAD SAAT CONTROL DIBUKA
    ' ========================
    Private Sub dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        tampilData() ' --> isi tabel saat control dimuat
        loadCombo()  ' --> isi combo jurusan saat control dimuat

        ' --> atur default selected index jika item ada (menghindari error)
        If cmbJurusan.Items.Count > 0 Then cmbJurusan.SelectedIndex = 0
        If cmbKelamin.Items.Count > 0 Then cmbKelamin.SelectedIndex = 0

    End Sub






    ' ==================================
    ' UPDATE: MEMPERBARUI DATA MAHASISWA
    ' ==================================
    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        connection() ' --> pastikan koneksi aktif

        ' --> ambil id_jurusan dari combo (username/jurusan harus berupa teks nama jurusan)
        Dim id_jurusan = GetId("jurusan", "id_jurusan", "nama_jurusan", cmbJurusan.Text)

        Try
            Dim query As String = "
                UPDATE mahasiswa SET
                    nim = @nim,
                    nama_mahasiswa = @nama_mahasiswa,
                    alamat = @alamat,
                    email = @email,
                    jenis_kelamin = @jenis_kelamin,
                    tgl_lahir = @tgl_lahir,
                    id_jurusan = @id_jurusan
                WHERE
                    id_mahasiswa = @id_mahasiswa" ' --> query update dengan where id_mahasiswa

            Using cmd As New MySqlCommand(query, conn) ' --> buat command update
                cmd.Parameters.AddWithValue("@nim", txtNim.Text) ' --> parameter nim
                cmd.Parameters.AddWithValue("@nama_mahasiswa", txtNamaMahasiswa.Text) ' --> parameter nama
                cmd.Parameters.AddWithValue("@alamat", txtAlamat.Text) ' --> parameter alamat
                cmd.Parameters.AddWithValue("@email", txtEmail.Text) ' --> parameter email
                cmd.Parameters.AddWithValue("@jenis_kelamin", cmbKelamin.Text) ' --> parameter jenis kelamin (pakai Text)
                cmd.Parameters.AddWithValue("@tgl_lahir", dtpTanggalLahir.Value.ToString("yyyy-MM-dd")) ' --> parameter tanggal lahir
                cmd.Parameters.AddWithValue("@id_jurusan", id_jurusan) ' --> parameter id jurusan
                cmd.Parameters.AddWithValue("@id_mahasiswa", selectedId) ' --> parameter id mahasiswa yang akan diupdate

                cmd.ExecuteNonQuery() ' --> jalankan update
            End Using

            MsgBox("Data Berhasil Diperbaharui!", MsgBoxStyle.Information, "Berhasil") ' --> notifikasi sukses
            tampilData() ' --> refresh tabel
            clearForm()  ' --> reset form

        Catch ex As Exception
            MsgBox("Data Gagal Diperbaharui: " & ex.Message, MsgBoxStyle.Critical) ' --> notifikasi jika gagal
        End Try

    End Sub





    ' ================================
    ' DELETE: MENGHAPUS DATA MAHASISWA
    ' ================================
    Private Sub btn_hapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        connection() ' --> pastikan koneksi aktif

        Try
            Dim query As String = "DELETE FROM mahasiswa WHERE id_mahasiswa = @id_mahasiswa" ' --> query delete berdasarkan id

            Using cmd As New MySqlCommand(query, conn) ' --> buat command delete
                cmd.Parameters.AddWithValue("@id_mahasiswa", selectedId) ' --> isi parameter id yang akan dihapus
                cmd.ExecuteNonQuery() ' --> eksekusi delete
            End Using

            MsgBox("Data Berhasil Dihapus!", MsgBoxStyle.Information, "Berhasil") ' --> info sukses
            tampilData() ' --> refresh tabel
            clearForm() ' --> reset form

        Catch ex As Exception
            MsgBox("Gagal Menghapus: " & ex.Message, MsgBoxStyle.Critical) ' --> tampilkan pesan error bila ada
        End Try

    End Sub






    ' ======================================================================
    ' MENANGANI KLIK PADA BARIS DATA GRID (mengisi form dengan row terpilih)
    ' ======================================================================
    Private Sub dgvMahasiswa_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMahasiswa.CellClick

        If e.RowIndex >= 0 Then ' --> hanya proses jika klik pada baris (bukan header atau area kosong)
            Dim row As DataGridViewRow = dgvMahasiswa.Rows(e.RowIndex) ' --> ambil baris yang diklik

            selectedId = Convert.ToInt32(row.Cells("id_mahasiswa").Value) ' --> simpan id mahasiswa yang dipilih

            txtNim.Text = row.Cells("nim").Value.ToString()  ' --> isi textbox NIM dari cell
            txtNamaMahasiswa.Text = row.Cells("nama_mahasiswa").Value.ToString() ' --> isi nama
            txtAlamat.Text = row.Cells("alamat").Value.ToString() ' --> isi alamat
            txtEmail.Text = row.Cells("email").Value.ToString()   ' --> isi email

            Dim jk As String = row.Cells("jenis_kelamin").Value.ToString() ' --> ambil nilai jenis kelamin dari row
            If cmbKelamin.Items.Contains(jk) Then ' --> jika combo sudah memiliki item sama
                cmbKelamin.SelectedItem = jk ' --> set combobox ke item tersebut
            Else
                cmbKelamin.SelectedIndex = -1 ' --> kalau tidak ditemukan, reset combobox
            End If

            ' --> konversi nilai string/timestamp menjadi Date untuk DateTimePicker
            dtpTanggalLahir.Value = Convert.ToDateTime(row.Cells("tgl_lahir").Value)

            Dim jr As String = row.Cells("nama_jurusan").Value.ToString() ' --> ambil nama jurusan dari row
            If cmbJurusan.Items.Contains(jr) Then ' --> jika combo jurusan berisi nama itu
                cmbJurusan.SelectedItem = jr ' --> set combobox jurusan ke nama tersebut
            Else
                cmbJurusan.SelectedIndex = -1 ' --> jika tidak ada, reset combobox
            End If
        End If

    End Sub






    ' ============================================================
    ' PENCARIAN: MENCARI DATA BERDASARKAN KEYWORD
    ' ============================================================
    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click

        connection() ' --> pastikan koneksi aktif

        Try
            ' --> jika tidak ada keyword, tampilkan semua data
            If txtCari.Text.Trim() = "" Then
                tampilData()
                Return
            End If

            Dim keyword As String = "%" & txtCari.Text & "%" ' --> bungkus keyword dengan wildcard untuk LIKE

            Dim query As String = "
                SELECT 
                    m.id_mahasiswa, m.nim, m.nama_mahasiswa, m.alamat, m.email, 
                    m.jenis_kelamin, m.tgl_lahir, j.nama_jurusan
                FROM mahasiswa m
                JOIN jurusan j ON m.id_jurusan = j.id_jurusan
                WHERE 
                    m.nim LIKE @keyword
                    OR m.nama_mahasiswa LIKE @keyword
                    OR m.alamat LIKE @keyword
                    OR m.email LIKE @keyword
                    OR m.jenis_kelamin LIKE @keyword
                    OR m.tgl_lahir LIKE @keyword
                    OR j.nama_jurusan LIKE @keyword" ' --> query pencarian di beberapa kolom

            Using cmd As New MySqlCommand(query, conn)  ' --> buat command
                cmd.Parameters.AddWithValue("@keyword", keyword) ' --> isi parameter @keyword
                Dim adapter As New MySqlDataAdapter(cmd) ' --> adapter untuk mengeksekusi command dan mengisi DataSet
                Dim ds As New DataSet() ' --> DataSet penampung hasil
                adapter.Fill(ds, "mahasiswa") ' --> isi dataset
                dgvMahasiswa.DataSource = ds.Tables("mahasiswa") ' --> tampilkan hasil di DataGridView
            End Using
        Catch ex As Exception
            MsgBox("Gagal mencari: " & ex.Message, MsgBoxStyle.Critical) ' --> tampilkan error bila pencarian gagal
        End Try

    End Sub

End Class
