Imports System.Net
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient ' --> import mysql client

Public Class JurusanControl



    Private selectedId As Integer  '--> menyimpan id jurusan yang dipilih








    ' ===================================
    ' MENAMPILKAN DATA DALAM BENTUK TABEL
    ' ===================================
    Private Sub tampilData()

        connection()  '--> buka koneksi

        Try '--> mulai operasi database
            Dim vData As New MySqlDataAdapter("SELECT * FROM jurusan", conn)  '--> adapter untuk ambil semua data jurusan

            Dim ds As New DataSet()  '--> dataset penampung data
            vData.Fill(ds, "jurusan")  '--> isi dataset
            dgvJurusan.DataSource = ds.Tables("jurusan")  '--> tampilkan isi dataset di dgv
            dgvJurusan.Columns("id_jurusan").Visible = False  '--> sembunyikan kolom id
        Catch ex As Exception  '--> jika error
            MsgBox("Data Gagal Ditampilkan" & ex.Message, MsgBoxStyle.Information)  '--> tampilkan pesan error
        End Try  '--> akhir try/catch

    End Sub







    ' =====================================
    ' MENGHAPUS / MERESET FORM
    ' =====================================
    Private Sub clearForm()
        txtNamaJurusan.Clear()  '--> kosongkan input nama jurusan
        txtDeskripsi.Clear()  '--> kosongkan input deskripsi
    End Sub






    ' ===================================
    ' MENAMBAH DATA JURUSAN
    ' ===================================
    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click

        connection()  '--> buka koneksi

        Try  '--> mulai proses insert
            Dim query As String = "INSERT INTO jurusan
                                    (
                                    nama_jurusan,
                                    deskripsi
                                    ) VALUES
                                    (
                                    @nama_jurusan,
                                    @deskripsi
                                    )"  '--> query insert data

            Using cmd = New MySqlCommand(query, conn)  '--> buat command
                cmd.Parameters.AddWithValue("@nama_jurusan", txtNamaJurusan.Text)  '--> isi parameter nama
                cmd.Parameters.AddWithValue("@deskripsi", txtDeskripsi.Text) '--> isi parameter deskripsi
                cmd.ExecuteNonQuery()  '--> eksekusi query
            End Using  '--> tutup command

            MsgBox("Berhasil Ditambahkan!", MsgBoxStyle.Information, "Berhasil")  '--> pesan sukses
            tampilData()  '--> refresh tabel
            clearForm()  '--> bersihkan form

        Catch ex As Exception  '--> jika gagal
            MsgBox("Gagal Ditambahkan" & ex.Message, MsgBoxStyle.Information, "Gagal")  '--> tampilkan error
        End Try  '--> akhir try/catch

    End Sub






    ' ===================================
    ' LOAD AWAL KETIKA DIBUKA
    ' ===================================
    Private Sub dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        tampilData()  '--> tampilkan data pertama kali

    End Sub







    ' ===================================
    ' MENGEDIT DATA JURUSAN
    ' ===================================
    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click

        connection()  '--> buka koneksi

        Try  '--> mulai proses update
            Dim query As String = "UPDATE jurusan SET
                                   nama_jurusan = @nama_jurusan,
                                   deskripsi = @deskripsi
                                   WHERE
                                   id_jurusan = @id_jurusan"  '--> query update

            Using cmd = New MySqlCommand(query, conn)  '--> buat command
                cmd.Parameters.AddWithValue("@nama_jurusan", txtNamaJurusan.Text)  '--> isi parameter nama
                cmd.Parameters.AddWithValue("@deskripsi", txtDeskripsi.Text)  '--> isi parameter deskripsi
                cmd.Parameters.AddWithValue("@id_jurusan", selectedId)  '--> isi id jurusan yang dipilih
                cmd.ExecuteNonQuery()  '--> jalankan update
            End Using  '--> tutup command

            MsgBox("Data Berhasil Diperbaharui!", MsgBoxStyle.Information, "Berhasil")  '--> pesan sukses
            tampilData()  '--> refresh tabel
            clearForm()  '--> kosongkan form

        Catch ex As Exception  '--> jika gagal
            MsgBox("Data Gagal Diperbaharui!" & ex.Message, MsgBoxStyle.Critical) '--> tampilkan error
        End Try

    End Sub







    ' =================================
    ' MENGHAPUS DATA JURUSAN
    ' =================================
    Private Sub btn_hapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click  '--> event tombol hapus
        connection()  '--> buka koneksi

        Try  '--> mulai proses delete
            Dim query As String = "DELETE FROM jurusan WHERE id_jurusan = @id_jurusan"  '--> query delete
            Using cmd As New MySqlCommand(query, conn)  '--> buat command
                cmd.Parameters.AddWithValue("@id_jurusan", selectedId)  '--> set parameter id
                cmd.ExecuteNonQuery()  '--> eksekusi delete
            End Using  '--> tutup command

            MsgBox("Data Berhasil Dihapus!", MsgBoxStyle.Information, "Berhasil")  '--> pesan sukses
            tampilData()  '--> refresh tabel
            clearForm()  '--> bersihkan form

        Catch ex As Exception  '--> jika gagal
            ' sengaja dikosongkan seperti kode asli
        End Try  '--> akhir try/catch
    End Sub







    ' ======================================================================
    ' MENANGANI KLIK PADA BARIS DATA GRID (mengisi form dengan row terpilih)
    ' ======================================================================
    Private Sub dgvJurusan_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvJurusan.CellClick
        If e.RowIndex >= 0 Then  '--> pastikan klik baris valid
            Dim row As DataGridViewRow = dgvJurusan.Rows(e.RowIndex)  '--> ambil baris

            selectedId = row.Cells("id_jurusan").Value  '--> simpan id ke variabel

            txtNamaJurusan.Text = row.Cells("nama_jurusan").Value.ToString()  '--> tampilkan nama jurusan
            txtDeskripsi.Text = row.Cells("deskripsi").Value.ToString() ' --> tampilkan deskripsi

        End If  '--> akhir pengecekan rowIndex
    End Sub







    ' ======================
    ' SEARCH DATA BY KEYWORD
    ' ======================
    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click

        connection()  '--> buka koneksi

        Try  '--> mulai proses pencarian
            If txtCari.Text.Trim() = "" Then  '--> jika kota cari kosong
                tampilData()  '--> tampilkan semua data
                Return  '--> hentikan proses
            End If  '--> akhir pengecekan kosong

            Dim keyword As String = "%" & txtCari.Text & "%"  '--> format LIKE

            Dim query As String = "SELECT id_jurusan, nama_jurusan, deskripsi
                                   FROM jurusan j
                                   WHERE 
                                   nama_jurusan LIKE @keyword
                                   OR deskripsi LIKE @keyword"  '--> query pencarian

            Using cmd As New MySqlCommand(query, conn)  '--> buat command
                cmd.Parameters.AddWithValue("@keyword", keyword)  '--> set keyword

                Dim adapter As New MySqlDataAdapter(cmd)  '--> adapter
                Dim ds As New DataSet  '--> dataset
                adapter.Fill(ds, "jurusan")  '--> isi dataset
                dgvJurusan.DataSource = ds.Tables("jurusan")  '--> tampilkan hasil
            End Using ' --> tutup command

        Catch ex As Exception  '--> jika gagal
            MsgBox("Gagal mencari: " & ex.Message)  '--> tampilkan error
        End Try  '--> akhir try/catch
    End Sub  '--> akhir btnCari

End Class
