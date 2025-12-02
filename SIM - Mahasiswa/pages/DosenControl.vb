Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient

Public Class DosenControl

    Private selectedId As Integer = 0  ' --> variabel penyimpan id dosen yang sedang dipilih





    ' ====================================
    ' MENAMPILKAN DATA DALAM BENTUK TABEL
    ' ====================================
    Private Sub tampilData()

        connection()  ' --> pastikan koneksi database aktif

        Try
            Dim vData As New MySqlDataAdapter(
                "SELECT id_dosen, nid, nama_dosen, alamat, email, jenis_kelamin, tgl_lahir, j.nama_jurusan
                 FROM dosen d JOIN jurusan j ON d.id_jurusan = j.id_jurusan", conn)  ' --> query join dosen + jurusan

            Dim ds As New DataSet()  ' --> DataSet untuk menampung hasil query
            vData.Fill(ds, "dosen")  ' --> isi DataSet, tabel dinamakan "dosen"
            dgvDosen.DataSource = ds.Tables("dosen")  ' --> set DataSource DataGridView ke tabel "dosen"
            dgvDosen.Columns("id_dosen").Visible = False  ' --> sembunyikan kolom id_dosen di tampilan

        Catch ex As Exception
            MsgBox("Data Gagal Ditampilkan: " & ex.Message, MsgBoxStyle.Information)  ' --> tampilkan pesan jika gagal
        End Try

    End Sub






    ' ======================================
    ' MENGOSONGKAN FORM (RESET SETELAH CRUD)
    ' ======================================
    Private Sub clearForm()

        txtNim.Clear()  ' --> kosongkan textbox NID
        txtNamaDosen.Clear()  ' --> kosongkan textbox nama dosen
        txtAlamat.Clear()  ' --> kosongkan textbox alamat
        txtEmail.Clear()  ' --> kosongkan textbox email
        dtpTanggalLahir.Value = Date.Now()  ' --> set DateTimePicker ke tanggal sekarang
        cmbKelamin.SelectedIndex = -1  ' --> reset combobox jenis kelamin
        cmbJurusan.SelectedIndex = -1  ' --> reset combobox jurusan
        selectedId = 0  ' --> reset selectedId supaya tidak tersisa nilai lama

    End Sub






    ' =============================
    ' LOAD DATA KE COMBOBOX JURUSAN
    ' =============================
    Private Sub loadCombo()

        Try
            cmbJurusan.Items.Clear()  ' --> kosongkan item agar tidak duplikat

            Using cmd As New MySqlCommand("SELECT id_jurusan, nama_jurusan FROM jurusan", conn)  ' --> buat command select jurusan
                Using rd = cmd.ExecuteReader()  ' --> eksekusi reader
                    While rd.Read()  ' --> loop untuk setiap baris hasil query
                        cmbJurusan.Items.Add(rd("nama_jurusan").ToString())  ' --> tambahkan nama_jurusan ke combo
                    End While
                End Using
            End Using

        Catch ex As Exception
            MsgBox("Data comboBox gagal ditampilkan: " & ex.Message, MsgBoxStyle.Information)  ' --> tampilkan pesan error
        End Try

    End Sub







    ' ===================================================
    ' UTILITY: MENDAPATKAN ID DARI NAMA (umum untuk combo)
    ' ===================================================
    Private Function GetId(table As String, idColumn As String, namaColumn As String, namaValue As String) As Integer

        Dim result As Integer = 0  ' --> inisialisasi hasil default 0 (tidak ketemu)

        Dim query = $"SELECT {idColumn} FROM {table} WHERE {namaColumn}=@name LIMIT 1"  ' --> query parameter untuk keamanan

        Using cmd As New MySqlCommand(query, conn)  ' --> buat command
            cmd.Parameters.AddWithValue("@name", namaValue)  ' --> set parameter @name dengan nilai
            Dim rd = cmd.ExecuteReader()  ' --> eksekusi reader
            If rd.Read() Then  ' --> jika ada hasil
                result = Convert.ToInt32(rd(idColumn))  ' --> ambil kolom id dan konversi ke Integer
            End If
            rd.Close()  ' --> tutup reader
        End Using
        Return result  ' --> kembalikan hasil

    End Function

    ' =====================================
    ' CREATE: MENAMBAH DATA DOSEN
    ' =====================================
    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click

        connection()  ' --> pastikan koneksi aktif

        Dim id_jurusan = GetId("jurusan", "id_jurusan", "nama_jurusan", cmbJurusan.Text)  ' --> ambil id_jurusan dari combobox

        Try
            Dim query As String = "
                INSERT INTO dosen
                (nid, nama_dosen, alamat, email, jenis_kelamin, tgl_lahir, id_jurusan)
                VALUES
                (@nid, @nama_dosen, @alamat, @email, @jenis_kelamin, @tgl_lahir, @id_jurusan)"  ' --> query INSERT dengan parameter

            Using cmd As New MySqlCommand(query, conn)  ' --> buat MySqlCommand
                cmd.Parameters.AddWithValue("@nid", txtNim.Text)  ' --> isi parameter @nid
                cmd.Parameters.AddWithValue("@nama_dosen", txtNamaDosen.Text)  ' --> isi nama dosen
                cmd.Parameters.AddWithValue("@alamat", txtAlamat.Text)  ' --> isi alamat
                cmd.Parameters.AddWithValue("@email", txtEmail.Text)  ' --> isi email
                cmd.Parameters.AddWithValue("@jenis_kelamin", cmbKelamin.Text)  ' --> isi jenis kelamin
                cmd.Parameters.AddWithValue("@tgl_lahir", dtpTanggalLahir.Value.ToString("yyyy-MM-dd"))  ' --> isi tanggal lahir
                cmd.Parameters.AddWithValue("@id_jurusan", id_jurusan)  ' --> isi id_jurusan

                cmd.ExecuteNonQuery()  ' --> eksekusi perintah insert
            End Using

            MsgBox("Berhasil Ditambahkan!", MsgBoxStyle.Information, "Berhasil")  ' --> pesan sukses
            tampilData()  ' --> refresh tabel
            clearForm()  ' --> bersihkan form

        Catch ex As Exception
            MsgBox("Gagal Ditambahkan: " & ex.Message, MsgBoxStyle.Information)  ' --> pesan error kalau gagal
        End Try

    End Sub






    ' =====================================
    ' LOAD SAAT CONTROL DIBUKA
    ' =====================================
    Private Sub DosenControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        tampilData()  ' --> isi tabel saat control dimuat
        loadCombo()  ' --> isi combo jurusan saat control dimuat

        ' --> atur default selected index jika item ada
        If cmbJurusan.Items.Count > 0 Then cmbJurusan.SelectedIndex = 0
        If cmbKelamin.Items.Count > 0 Then cmbKelamin.SelectedIndex = 0

    End Sub

    ' ==================================
    ' UPDATE: MEMPERBARUI DATA DOSEN
    ' ==================================
    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click

        connection()  ' --> pastikan koneksi aktif

        Dim id_jurusan = GetId("jurusan", "id_jurusan", "nama_jurusan", cmbJurusan.Text)  ' --> ambil id_jurusan dari combobox

        Try
            Dim query As String = "
                UPDATE dosen SET
                    nid = @nid,
                    nama_dosen = @nama_dosen,
                    alamat = @alamat,
                    email = @email,
                    jenis_kelamin = @jenis_kelamin,
                    tgl_lahir = @tgl_lahir,
                    id_jurusan = @id_jurusan
                WHERE
                    id_dosen = @id_dosen"  ' --> query update dengan kondisi

            Using cmd As New MySqlCommand(query, conn)  ' --> buat command update
                cmd.Parameters.AddWithValue("@nid", txtNim.Text)  ' --> isi NID
                cmd.Parameters.AddWithValue("@nama_dosen", txtNamaDosen.Text)  ' --> isi nama dosen
                cmd.Parameters.AddWithValue("@alamat", txtAlamat.Text)  ' --> isi alamat
                cmd.Parameters.AddWithValue("@email", txtEmail.Text)  ' --> isi email
                cmd.Parameters.AddWithValue("@jenis_kelamin", cmbKelamin.Text)  ' --> isi jenis kelamin
                cmd.Parameters.AddWithValue("@tgl_lahir", dtpTanggalLahir.Value.ToString("yyyy-MM-dd"))  ' --> isi tanggal lahir
                cmd.Parameters.AddWithValue("@id_jurusan", id_jurusan)  ' --> isi id jurusan
                cmd.Parameters.AddWithValue("@id_dosen", selectedId)  ' --> isi id dosen yang akan diupdate

                cmd.ExecuteNonQuery()  ' --> eksekusi update
            End Using

            MsgBox("Data Berhasil Diperbaharui!", MsgBoxStyle.Information, "Berhasil")  ' --> notifikasi sukses
            tampilData()  ' --> refresh tabel
            clearForm()  ' --> reset form

        Catch ex As Exception
            MsgBox("Data Gagal Diperbaharui: " & ex.Message, MsgBoxStyle.Critical)  ' --> notifikasi jika gagal
        End Try

    End Sub






    ' ================================
    ' DELETE: MENGHAPUS DATA DOSEN
    ' ================================
    Private Sub btn_hapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click

        connection()  ' --> pastikan koneksi aktif

        Try
            Dim query As String = "DELETE FROM dosen WHERE id_dosen = @id_dosen"  ' --> query delete berdasarkan id

            Using cmd As New MySqlCommand(query, conn)  ' --> buat command delete
                cmd.Parameters.AddWithValue("@id_dosen", selectedId)  ' --> isi id yang akan dihapus
                cmd.ExecuteNonQuery()  ' --> eksekusi delete
            End Using

            MsgBox("Data Berhasil Dihapus!", MsgBoxStyle.Information, "Berhasil")  ' --> notifikasi sukses
            tampilData()  ' --> refresh tabel
            clearForm()  ' --> reset form

        Catch ex As Exception
            MsgBox("Gagal Menghapus: " & ex.Message, MsgBoxStyle.Critical)  ' --> pesan error bila gagal
        End Try

    End Sub






    ' ======================================================================
    ' MENANGANI KLIK PADA BARIS DATA GRID (mengisi form dengan row terpilih)
    ' ======================================================================
    Private Sub dgvDosen_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDosen.CellClick

        If e.RowIndex >= 0 Then  ' --> hanya proses jika klik pada baris data
            Dim row As DataGridViewRow = dgvDosen.Rows(e.RowIndex)  ' --> baris yang diklik

            selectedId = Convert.ToInt32(row.Cells("id_dosen").Value)  ' --> simpan id dosen yang dipilih

            txtNim.Text = row.Cells("nid").Value.ToString()  ' --> isi textbox NID dari cell
            txtNamaDosen.Text = row.Cells("nama_dosen").Value.ToString()  ' --> isi nama dosen
            txtAlamat.Text = row.Cells("alamat").Value.ToString()  ' --> isi alamat
            txtEmail.Text = row.Cells("email").Value.ToString()  ' --> isi email

            Dim jk As String = row.Cells("jenis_kelamin").Value.ToString()  ' --> ambil jenis kelamin
            If cmbKelamin.Items.Contains(jk) Then
                cmbKelamin.SelectedItem = jk  ' --> set combobox jenis kelamin
            Else
                cmbKelamin.SelectedIndex = -1  ' --> reset jika tidak ada
            End If

            dtpTanggalLahir.Value = Convert.ToDateTime(row.Cells("tgl_lahir").Value)  ' --> set tanggal lahir

            Dim jr As String = row.Cells("nama_jurusan").Value.ToString()  ' --> ambil nama jurusan
            If cmbJurusan.Items.Contains(jr) Then
                cmbJurusan.SelectedItem = jr  ' --> set combobox jurusan
            Else
                cmbJurusan.SelectedIndex = -1  ' --> reset jika tidak ada
            End If

        End If

    End Sub






    ' ============================================================
    ' PENCARIAN: MENCARI DATA BERDASARKAN KEYWORD
    ' ============================================================
    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click

        connection()  ' --> pastikan koneksi aktif

        Try
            ' --> jika tidak ada keyword, tampilkan semua data
            If txtCari.Text.Trim() = "" Then
                tampilData()
                Return
            End If

            Dim keyword As String = "%" & txtCari.Text & "%"  ' --> bungkus keyword dengan wildcard

            Dim query As String = "
                SELECT id_dosen, nid, nama_dosen, alamat, email, jenis_kelamin, tgl_lahir, j.nama_jurusan
                FROM dosen d
                JOIN jurusan j ON d.id_jurusan = j.id_jurusan
                WHERE 
                    d.nid LIKE @keyword
                    OR d.nama_dosen LIKE @keyword
                    OR d.alamat LIKE @keyword
                    OR d.email LIKE @keyword
                    OR d.jenis_kelamin LIKE @keyword
                    OR d.tgl_lahir LIKE @keyword
                    OR j.nama_jurusan LIKE @keyword"  ' --> query pencarian di beberapa kolom

            Using cmd As New MySqlCommand(query, conn)  ' --> buat command
                cmd.Parameters.AddWithValue("@keyword", keyword)  ' --> isi parameter @keyword
                Dim adapter As New MySqlDataAdapter(cmd)  ' --> adapter untuk eksekusi query
                Dim ds As New DataSet()  ' --> DataSet penampung hasil
                adapter.Fill(ds, "dosen")  ' --> isi dataset
                dgvDosen.DataSource = ds.Tables("dosen")  ' --> tampilkan hasil
            End Using

        Catch ex As Exception
            MsgBox("Gagal mencari: " & ex.Message, MsgBoxStyle.Critical)  ' --> pesan error bila gagal
        End Try

    End Sub

End Class
