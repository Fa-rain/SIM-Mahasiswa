Imports MySql.Data.MySqlClient

Public Class NilaiControl

    Private selectedId As Integer  ' --> menyimpan id_nilai yang dipilih



    ' ================================
    '  MENAMPILKAN DATA NILAI
    ' ================================
    Private Sub tampilData()
        connection() ' --> pastikan koneksi aktif

        Try
            Dim query As String =
                "SELECT 
                    n.id_nilai,
                    t.nama_tugas,
                    m.nama_mahasiswa,
                    n.nilai,
                    n.keterangan
                FROM nilai n
                JOIN tugas t ON n.id_tugas = t.id_tugas
                JOIN mahasiswa m ON n.id_mahasiswa = m.id_mahasiswa" ' --> query join tabel nilai, tugas, mahasiswa

            Dim da As New MySqlDataAdapter(query, conn) ' --> adapter untuk ambil data
            Dim ds As New DataSet()
            da.Fill(ds, "nilai") ' --> isi dataset dengan hasil query

            dgvNilai.DataSource = ds.Tables("nilai") ' --> tampilkan data di tabel
            dgvNilai.Columns("id_nilai").Visible = False ' --> sembunyikan kolom id

        Catch ex As Exception
            MsgBox("Data gagal ditampilkan: " & ex.Message) ' --> pesan error
        End Try
    End Sub






    ' ================================
    '  CLEAR FORM
    ' ================================
    Private Sub clearForm()
        txtNamaTugas.Clear() ' --> reset nama tugas
        txtNamaMahasiswa.Clear() ' --> reset nama mahasiswa
        txtKeterangan.Clear() ' --> reset keterangan
        selectedId = -1 ' --> tidak ada data yang dipilih
    End Sub






    ' ================================
    '  LOAD CONTROL
    ' ================================
    Private Sub NilaiControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampilData() ' --> load tabel saat pertama dibuka
    End Sub






    ' ================================
    '  CLICK ROW (AMBIL DATA)
    ' ================================
    Private Sub dgvNilai_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvNilai.CellClick
        If e.RowIndex >= 0 Then ' --> pastikan kliknya pada baris valid
            Dim row As DataGridViewRow = dgvNilai.Rows(e.RowIndex)

            selectedId = row.Cells("id_nilai").Value ' --> simpan id_nilai yang dipilih

            txtNamaTugas.Text = row.Cells("nama_tugas").Value.ToString() ' --> tampilkan nama tugas
            numNilai.Value = Convert.ToInt32(row.Cells("nilai").Value) ' --> tampilkan nilai
            txtNamaMahasiswa.Text = row.Cells("nama_mahasiswa").Value.ToString() ' --> tampilkan mahasiswa
            txtKeterangan.Text = row.Cells("keterangan").Value.ToString() ' --> tampilkan keterangan
        End If
    End Sub






    ' ================================
    '  CARI DATA NILAI
    ' ================================
    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        connection() ' --> pastikan koneksi aktif

        If txtCari.Text.Trim() = "" Then ' --> jika kotak kosong, tampilkan semua data
            tampilData()
            Return
        End If

        Try
            Dim keyword As String = "%" & txtCari.Text & "%" ' --> keyword pencarian

            Dim query As String =
                "SELECT 
                    n.id_nilai,
                    t.nama_tugas,
                    m.nama_mahasiswa,
                    n.nilai,
                    n.keterangan
                 FROM nilai n
                 JOIN tugas t ON n.id_tugas = t.id_tugas
                 JOIN mahasiswa m ON n.id_mahasiswa = m.id_mahasiswa
                 WHERE 
                    t.nama_tugas LIKE @key
                    OR m.nama_mahasiswa LIKE @key
                    OR n.keterangan LIKE @key" ' --> query pencarian

            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@key", keyword) ' --> isi parameter pencarian

            Dim da As New MySqlDataAdapter(cmd)
            Dim ds As New DataSet
            da.Fill(ds, "nilai")

            dgvNilai.DataSource = ds.Tables("nilai") ' --> tampilkan hasil

        Catch ex As Exception
            MsgBox("Gagal mencari: " & ex.Message) ' --> error
        End Try
    End Sub






    ' ================================
    '  EDIT DATA NILAI
    ' ================================
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If selectedId = -1 Then ' --> cek jika belum memilih baris
            MsgBox("Pilih data dulu.")
            Return
        End If

        connection() ' --> pastikan koneksi aktif

        Try
            Dim query As String =
                "UPDATE nilai SET
                    nilai = @nilai,
                    keterangan = @ket
                 WHERE 
                    id_nilai = @id" ' --> query update berdasarkan id_nilai

            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@nilai", numNilai.Value) ' --> parameter nilai
                cmd.Parameters.AddWithValue("@ket", txtKeterangan.Text) ' --> parameter keterangan
                cmd.Parameters.AddWithValue("@id", selectedId) ' --> id yang akan diupdate
                cmd.ExecuteNonQuery() ' --> jalankan update
            End Using

            MsgBox("Data berhasil diperbarui!") ' --> sukses
            tampilData() ' --> refresh tabel
            clearForm() ' --> reset form

        Catch ex As Exception
            MsgBox("Gagal update: " & ex.Message) ' --> gagal
        End Try
    End Sub






    ' ================================
    '  HAPUS DATA NILAI
    ' ================================
    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If selectedId = -1 Then ' --> cek apakah sudah memilih baris
            MsgBox("Pilih data dulu.")
            Return
        End If

        connection() ' --> pastikan koneksi aktif

        Try
            Dim query As String = "DELETE FROM nilai WHERE id_nilai = @id" ' --> query delete

            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@id", selectedId) ' --> id nilai yang akan dihapus
                cmd.ExecuteNonQuery() ' --> jalankan delete
            End Using

            MsgBox("Data berhasil dihapus!") ' --> sukses
            tampilData() ' --> refresh tabel
            clearForm() ' --> reset form

        Catch ex As Exception
            MsgBox("Gagal hapus: " & ex.Message) ' --> error
        End Try
    End Sub






    ' ================================
    '  TOMBOL TAMBAH (INFO)
    ' ================================
    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        MsgBox("Untuk menambah nilai, silakan buka halaman Tugas lalu klik tombol 'Input Nilai'.",
           MsgBoxStyle.Information,
           "Informasi") ' --> hanya menampilkan info
    End Sub

End Class
