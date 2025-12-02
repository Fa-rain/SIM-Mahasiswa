Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient  ' --> import library MySQL Connector/NET


Public Class RuanganControl  ' --> Class


    Private selectedId As Integer  ' --> variabel penyimpan id ruangan yang sedang dipilih




    ' ====================================
    ' MENAMPILKAN DATA DALAM BENTUK TABEL
    ' ====================================
    Private Sub tampilData()  ' --> method untuk mengisi dgvRuangan dari database
        connection()  ' --> panggil fungsi koneksi


        Try  ' --> mulai blok try untuk menangkap error
            Dim vData As New MySqlDataAdapter("SELECT * FROM ruangan", conn)  ' --> query select semua data ruangan dibungkus adapter


            Dim ds As New DataSet()  ' --> dataset untuk menampung hasil query
            vData.Fill(ds, "ruangan")  ' --> isi dataset dengan tabel "ruangan"
            dgvRuangan.DataSource = ds.Tables("ruangan")  ' --> tampilkan dataset ke datagrid
            dgvRuangan.Columns("id_ruangan").Visible = False  ' --> sembunyikan kolom id_ruangan


        Catch ex As Exception
            MsgBox("Data Gagal Ditampilkan" & ex.Message, MsgBoxStyle.Information)  ' --> pesan error jika gagal load
        End Try

    End Sub




    ' ======================================
    ' MENGHAPUS / MERESet FORM SETELAH CRUD
    ' ======================================
    Private Sub clearForm()  ' --> method untuk mereset input form

        txtNamaRuangan.Clear()  ' --> kosongkan textbox nama ruangan
        txtKodeRuangan.Clear()  ' --> kosongkan textbox kode ruangan
        numKapasitas.ResetText()  ' --> reset numeric kapasitas

    End Sub




    ' ===========================
    ' CREATE: MENAMBAH DATA BARU
    ' ===========================
    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        connection()  ' --> pastikan koneksi terbuka


        Try
            Dim query As String = "
                INSERT INTO ruangan
                (nama_ruangan, kode_ruangan, kapasitas)
                VALUES
                (@nama_ruangan, @kode_ruangan, @kapasitas)"  ' --> query insert data ruangan


            Using cmd = New MySqlCommand(query, conn)  ' --> buat command insert
                cmd.Parameters.AddWithValue("@nama_ruangan", txtNamaRuangan.Text)  ' --> isi parameter nama
                cmd.Parameters.AddWithValue("@kode_ruangan", txtKodeRuangan.Text)  ' --> isi parameter kode
                cmd.Parameters.AddWithValue("@kapasitas", numKapasitas.Text)  ' --> isi parameter kapasitas
                cmd.ExecuteNonQuery()  ' --> jalankan insert
            End Using

            MsgBox("Berhasil Ditambahkan!", MsgBoxStyle.Information, "Berhasil")  ' --> notifikasi sukses insert
            tampilData()  ' --> refresh tabel
            clearForm()  ' --> reset input

        Catch ex As Exception
            MsgBox("Gagal Ditambahkan" & ex.Message, MsgBoxStyle.Information, "Gagal")  ' --> notifikasi gagal insert
        End Try
    End Sub




    ' ============================
    ' LOAD: SAAT CONTROL DIBUKA
    ' ============================
    Private Sub dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        tampilData()  ' --> tampilkan data ruangan di datagrid saat control dibuka

    End Sub




    ' ================================
    ' UPDATE: MEMPERBARUI DATA RUANGAN
    ' ================================
    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        connection()  ' --> pastikan koneksi aktif


        Try
            Dim query As String = "
                UPDATE ruangan SET
                    nama_ruangan = @nama_ruangan,
                    kode_ruangan = @kode_ruangan,
                    kapasitas = @kapasitas
                WHERE
                    id_ruangan = @id_ruangan"  ' --> query update ruangan berdasarkan id


            Using cmd = New MySqlCommand(query, conn)  ' --> buat command update
                cmd.Parameters.AddWithValue("@nama_ruangan", txtNamaRuangan.Text)  ' --> parameter nama
                cmd.Parameters.AddWithValue("@kode_ruangan", txtKodeRuangan.Text)  ' --> parameter kode
                cmd.Parameters.AddWithValue("@kapasitas", numKapasitas.Text)  ' --> parameter kapasitas
                cmd.Parameters.AddWithValue("@id_ruangan", selectedId)  ' --> id ruangan yg sedang dipilih
                cmd.ExecuteNonQuery()  ' --> eksekusi update
            End Using

            MsgBox("Data Berhasil Diperbaharui!", MsgBoxStyle.Information, "Berhasil")  ' --> notifikasi sukses update
            tampilData()  ' --> refresh tabel
            clearForm()  ' --> reset input form

        Catch ex As Exception
            MsgBox("Data Gagal Diperbaharui!" & ex.Message, MsgBoxStyle.Critical)  ' --> notifikasi gagal update

        End Try
    End Sub




    ' ================================
    ' DELETE: MENGHAPUS DATA RUANGAN
    ' ================================
    Private Sub btn_hapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        connection()  ' --> pastikan koneksi aktif


        Try
            Dim query As String = "DELETE FROM ruangan WHERE id_ruangan = @id_ruangan"  ' --> query delete ruangan berdasarkan id

            Using cmd = New MySqlCommand(query, conn)  ' --> buat command delete
                cmd.Parameters.AddWithValue("@id_ruangan", selectedId)  ' --> parameter id yang akan dihapus
                cmd.ExecuteNonQuery()  ' --> eksekusi delete
            End Using

            MsgBox("Data Berhasil Dihapus!", MsgBoxStyle.Information, "Berhasil")  ' --> notifikasi sukses hapus
            tampilData()  ' --> refresh tabel
            clearForm()  ' --> reset input

        Catch ex As Exception
            MsgBox("Gagal Menghapus: " & ex.Message, MsgBoxStyle.Critical)  ' --> tampilkan pesan jika gagal hapus
        End Try
    End Sub




    ' ======================================================================
    ' MENAMPILKAN DATA KE FORM SAAT KLIK ROW DI DATAGRID
    ' ======================================================================
    Private Sub dgvRuangan_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRuangan.CellClick

        If e.RowIndex >= 0 Then  ' --> hanya proses jika klik pada baris valid
            Dim row As DataGridViewRow = dgvRuangan.Rows(e.RowIndex)  ' --> ambil baris yang diklik

            selectedId = row.Cells("id_ruangan").Value  ' --> simpan id ruangan


            txtNamaRuangan.Text = row.Cells("nama_ruangan").Value.ToString()  ' --> tampilkan nama ruangan ke textbox
            txtKodeRuangan.Text = row.Cells("kode_ruangan").Value.ToString()  ' --> tampilkan kode ruangan
            numKapasitas.Text = row.Cells("kapasitas").Value  ' --> tampilkan kapasitas ke numeric box

        End If
    End Sub




    ' ============================================================
    ' PENCARIAN: MENCARI DATA BERDASARKAN KEYWORD
    ' ============================================================
    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        connection()  ' --> pastikan koneksi aktif


        Try
            ' --> jika keyword kosong, tampilkan semua data
            If txtCari.Text.Trim() = "" Then
                tampilData()
                Return
            End If

            Dim keyword As String = "%" & txtCari.Text & "%"  ' --> bungkus keyword LIKE


            Dim query As String = "
                SELECT * FROM ruangan
                WHERE 
                    nama_ruangan LIKE @keyword
                    OR kode_ruangan LIKE @keyword
                    OR kapasitas LIKE @keyword"  ' --> query pencarian di 3 kolom


            Using cmd As New MySqlCommand(query, conn)  ' --> buat command
                cmd.Parameters.AddWithValue("@keyword", keyword)  ' --> parameter keyword

                Dim adapter As New MySqlDataAdapter(cmd)  ' --> adapter untuk load hasil
                Dim ds As New DataSet  ' --> dataset penampung
                adapter.Fill(ds, "ruangan")  ' --> isi dataset
                dgvRuangan.DataSource = ds.Tables("ruangan")  ' --> tampilkan hasil ke datagrid
            End Using

        Catch ex As Exception
            MsgBox("Gagal mencari: " & ex.Message)  ' --> pesan jika pencarian gagal
        End Try
    End Sub

End Class
