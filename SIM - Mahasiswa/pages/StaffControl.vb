Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient  ' --> import library MySQL


Public Class StaffControl  ' --> class utama untuk CRUD Staff


    Private selectedId As Integer  ' --> menyimpan id_staff yang dipilih






    ' ====================================
    ' MENAMPILKAN DATA DALAM BENTUK TABEL
    ' ====================================
    Private Sub tampilData()  ' --> method untuk load data staff
        connection()  ' --> buka koneksi


        Try
            Dim vData As New MySqlDataAdapter("SELECT * FROM staff", conn)  ' --> adapter mengambil semua data staff


            Dim ds As New DataSet()  ' --> dataset penampung
            vData.Fill(ds, "staff")  ' --> isi dataset dengan tabel staff
            dgvStaff.DataSource = ds.Tables("staff")  ' --> tampilkan ke datagrid
            dgvStaff.Columns("id_staff").Visible = False  ' --> kolom id disembunyikan

        Catch ex As Exception
            MsgBox("Data Gagal Ditampilkan" & ex.Message, MsgBoxStyle.Information)  ' --> pesan jika gagal load
        End Try

    End Sub






    ' ======================================
    ' MEMBERSIHKAN INPUT SETELAH CRUD
    ' ======================================
    Private Sub clearForm()  ' --> reset textbox dan combobox

        txtNamaStaff.Clear()  ' --> kosongkan nama staff
        cmbBagian.SelectedIndex = -1  ' --> reset combobox bagian

    End Sub






    ' ===========================
    ' CREATE: MENAMBAH DATA BARU
    ' ===========================
    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        connection()  ' --> pastikan koneksi aktif


        Try
            Dim query As String = "
                INSERT INTO staff
                (
                    nama_staff,
                    bagian
                ) VALUES
                (
                    @nama_staff,
                    @bagian
                )"  ' --> query insert data staff


            Using cmd = New MySqlCommand(query, conn)  ' --> buat command insert
                cmd.Parameters.AddWithValue("@nama_staff", txtNamaStaff.Text)  ' --> isi parameter nama
                cmd.Parameters.AddWithValue("@bagian", cmbBagian.SelectedItem.ToString())  ' --> isi parameter bagian
                cmd.ExecuteNonQuery()  ' --> jalankan query
            End Using

            MsgBox("Berhasil Ditambahkan!", MsgBoxStyle.Information, "Berhasil")  ' --> notif sukses
            tampilData()  ' --> refresh tabel
            clearForm()  ' --> reset form

        Catch ex As Exception
            MsgBox("Gagal Ditambahkan" & ex.Message, MsgBoxStyle.Information, "Gagal")  ' --> notif gagal
        End Try
    End Sub





    ' ============================
    ' LOAD: SAAT CONTROL DIBUKA
    ' ============================
    Private Sub dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        tampilData()  ' --> tampilkan data staff

        cmbBagian.SelectedIndex = -1  ' --> reset pilihan combobox
        cmbBagian.Items.Add("Kebersihan")  ' --> daftar bagian staff
        cmbBagian.Items.Add("IT")
        cmbBagian.Items.Add("Dapur")
        cmbBagian.Items.Add("Keamanan")

    End Sub





    ' ================================
    ' UPDATE: MEMPERBARUI DATA STAFF
    ' ================================
    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        connection()  ' --> pastikan koneksi aktif


        Try
            Dim query As String = "
                UPDATE staff SET
                    nama_staff = @nama_staff,
                    bagian = @bagian
                WHERE
                    id_staff = @id_staff"  ' --> query update berdasarkan id


            Using cmd = New MySqlCommand(query, conn)  ' --> buat command
                cmd.Parameters.AddWithValue("@nama_staff", txtNamaStaff.Text)  ' --> parameter nama
                cmd.Parameters.AddWithValue("@bagian", cmbBagian.SelectedItem.ToString())  ' --> parameter bagian
                cmd.Parameters.AddWithValue("@id_staff", selectedId)  ' --> id yang dipilih
                cmd.ExecuteNonQuery()  ' --> jalankan update
            End Using

            MsgBox("Data Berhasil Diperbaharui!", MsgBoxStyle.Information, "Berhasil")  ' --> notif sukses
            tampilData()  ' --> refresh tabel
            clearForm()  ' --> reset form

        Catch ex As Exception
            MsgBox("Data Gagal Diperbaharui!" & ex.Message, MsgBoxStyle.Critical)  ' --> notif gagal
        End Try
    End Sub





    ' ================================
    ' DELETE: MENGHAPUS DATA STAFF
    ' ================================
    Private Sub btn_hapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        connection()  ' --> buka koneksi


        Try
            Dim query As String = "DELETE FROM staff WHERE id_staff = @id_staff"  ' --> query delete berdasarkan id


            Using cmd = New MySqlCommand(query, conn)  ' --> buat command delete
                cmd.Parameters.AddWithValue("@id_staff", selectedId)  ' --> id staff yg dipilih
                cmd.ExecuteNonQuery()  ' --> eksekusi delete
            End Using

            MsgBox("Data Berhasil Dihapus!", MsgBoxStyle.Information, "Berhasil")  ' --> notif sukses
            tampilData()  ' --> refresh tabel
            clearForm()  ' --> reset input

        Catch ex As Exception
            MsgBox("Gagal Menghapus: " & ex.Message, MsgBoxStyle.Critical)  ' --> notif gagal
        End Try

    End Sub






    ' ======================================================================
    ' MENGISI FORM SAAT KLIK DATA DI DATAGRID
    ' ======================================================================
    Private Sub dgvStaff_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvStaff.CellClick

        If e.RowIndex >= 0 Then  ' --> pastikan klik pada baris valid
            Dim row As DataGridViewRow = dgvStaff.Rows(e.RowIndex)  ' --> ambil baris yg diklik

            selectedId = row.Cells("id_staff").Value  ' --> simpan id

            txtNamaStaff.Text = row.Cells("nama_staff").Value.ToString()  ' --> isi textbox nama


            Dim b As String = row.Cells("bagian").Value.ToString()  ' --> ambil bagian staff
            If cmbBagian.Items.Contains(b) Then  ' --> cek apakah value tersedia di combobox
                cmbBagian.SelectedItem = b
            Else
                cmbBagian.SelectedIndex = -1
            End If

        End If
    End Sub






    ' ============================================================
    ' PENCARIAN DATA BERDASARKAN KEYWORD
    ' ============================================================
    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        connection()  ' --> buka koneksi


        Try
            ' --> jika kotak pencarian kosong, tampilkan semua data
            If txtCari.Text.Trim() = "" Then
                tampilData()
                Return
            End If

            Dim keyword As String = "%" & txtCari.Text & "%"  ' --> bungkus keyword untuk LIKE


            Dim query As String = "
                SELECT * FROM staff
                WHERE 
                    nama_staff LIKE @keyword
                    OR bagian LIKE @keyword"  ' --> query pencarian 2 kolom


            Using cmd As New MySqlCommand(query, conn)  ' --> buat command
                cmd.Parameters.AddWithValue("@keyword", keyword)  ' --> set parameter

                Dim adapter As New MySqlDataAdapter(cmd)  ' --> adapter hasil query
                Dim ds As New DataSet  ' --> dataset
                adapter.Fill(ds, "staff")  ' --> load dataset
                dgvStaff.DataSource = ds.Tables("staff")  ' --> tampilkan hasil
            End Using

        Catch ex As Exception
            MsgBox("Gagal mencari: " & ex.Message)  ' --> notif gagal
        End Try

    End Sub

End Class
