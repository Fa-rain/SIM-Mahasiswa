Imports MySql.Data.MySqlClient  ' --> library mysql


Public Class TugasControl  ' --> class untuk CRUD tugas


    Private selectedId As Integer  ' --> menyimpan id_tugas yang dipilih

    ' --> untuk fitur Input Nilai (butuh panel dari dashboard)
    Private mainPanel As Panel


    Public Sub New(targetPanel As Panel)  ' --> constructor menerima panel utama
        InitializeComponent()
        mainPanel = targetPanel
    End Sub





    ' =====================================
    ' TAMPILKAN DATA TUGAS
    ' =====================================
    Private Sub tampilData()
        connection()  ' --> buka koneksi


        Try
            Dim vData As New MySqlDataAdapter("
                SELECT 
                    id_tugas,
                    nama_tugas,
                    keterangan,
                    nama_mata_kuliah,
                    dibuat,
                    tenggat
                FROM tugas t
                LEFT JOIN mata_kuliah mk 
                    ON t.id_mata_kuliah = mk.id_mata_kuliah
            ", conn)  ' --> ambil data gabungan tugas + mk


            Dim ds As New DataSet()
            vData.Fill(ds, "tugas")  ' --> isi dataset
            dgvTugas.DataSource = ds.Tables("tugas")  ' --> tampilkan
            dgvTugas.Columns("id_tugas").Visible = False  ' --> sembunyikan id


        Catch ex As Exception
            MsgBox("Data gagal ditampilkan: " & ex.Message)
        End Try

    End Sub





    ' =====================================
    ' RESET FORM INPUT
    ' =====================================
    Private Sub clearForm()
        txtNamaTugas.Clear()  ' --> reset nama tugas
        txtKeterangan.Clear()  ' --> reset keterangan
        cmbMataKuliah.SelectedIndex = -1  ' --> reset combobox mk
        dtpTenggat.Value = Date.Now()  ' --> reset tanggal
    End Sub





    ' =====================================
    ' LOAD PERTAMA KALI
    ' =====================================
    Private Sub TugasControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampilData()  ' --> tampilkan data awal
        loadMataKuliah()  ' --> load combobox mk
    End Sub





    ' =====================================
    ' LOAD MATA KULIAH KE COMBOBOX
    ' =====================================
    Private Sub loadMataKuliah()
        connection()  ' --> buka koneksi


        Try
            Dim cmd As New MySqlCommand("
                SELECT id_mata_kuliah, nama_mata_kuliah 
                FROM mata_kuliah
            ", conn)  ' --> query untuk combobox


            Dim rd As MySqlDataReader = cmd.ExecuteReader()

            cmbMataKuliah.Items.Clear()  ' --> kosongkan combobox


            While rd.Read()
                cmbMataKuliah.Items.Add(New With {
                    .Text = rd("nama_mata_kuliah"),
                    .Value = rd("id_mata_kuliah")
                })  ' --> masukkan item objek (Text + Value)
            End While

            rd.Close()

        Catch ex As Exception
            MsgBox("Gagal memuat mata kuliah: " & ex.Message)
        End Try


        cmbMataKuliah.DisplayMember = "Text"
        cmbMataKuliah.ValueMember = "Value"
    End Sub





    ' =====================================
    ' TAMBAHKAN DATA BARU
    ' =====================================
    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        connection()


        Try
            If cmbMataKuliah.SelectedIndex = -1 Then
                MsgBox("Pilih mata kuliah terlebih dahulu!")
                Return
            End If


            Dim idMK As Integer = cmbMataKuliah.SelectedItem.Value  ' --> ambil id mk dari combobox


            Dim query As String = "
                INSERT INTO tugas 
                    (nama_tugas, keterangan, id_mata_kuliah, tenggat)
                VALUES 
                    (@nama_tugas, @keterangan, @id_mata_kuliah, @tenggat)
            "  ' --> query insert


            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@nama_tugas", txtNamaTugas.Text)
                cmd.Parameters.AddWithValue("@keterangan", txtKeterangan.Text)
                cmd.Parameters.AddWithValue("@id_mata_kuliah", idMK)
                cmd.Parameters.AddWithValue("@tenggat", dtpTenggat.Value.ToString("yyyy-MM-dd HH:mm:ss"))
                cmd.ExecuteNonQuery()
            End Using


            MsgBox("Tugas berhasil ditambahkan!")
            tampilData()
            clearForm()

        Catch ex As Exception
            MsgBox("Gagal menambah: " & ex.Message)
        End Try

    End Sub





    ' =====================================
    ' EDIT DATA TUGAS
    ' =====================================
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        connection()


        Try
            Dim idMK As Integer = cmbMataKuliah.SelectedItem.Value  ' --> ambil id mk yg dipilih


            Dim query As String = "
                UPDATE tugas SET
                    nama_tugas = @nama_tugas,
                    keterangan = @keterangan,
                    id_mata_kuliah = @id_mata_kuliah,
                    tenggat = @tenggat
                WHERE id_tugas = @id_tugas
            "  ' --> query update


            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@nama_tugas", txtNamaTugas.Text)
                cmd.Parameters.AddWithValue("@keterangan", txtKeterangan.Text)
                cmd.Parameters.AddWithValue("@id_mata_kuliah", idMK)
                cmd.Parameters.AddWithValue("@tenggat", dtpTenggat.Value.ToString("yyyy-MM-dd HH:mm:ss"))
                cmd.Parameters.AddWithValue("@id_tugas", selectedId)
                cmd.ExecuteNonQuery()
            End Using


            MsgBox("Tugas berhasil diperbarui!")
            tampilData()
            clearForm()

        Catch ex As Exception
            MsgBox("Gagal memperbarui: " & ex.Message)
        End Try

    End Sub





    ' =====================================
    ' HAPUS TUGAS
    ' =====================================
    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        connection()


        Try
            Dim query As String = "
                DELETE FROM tugas 
                WHERE id_tugas = @id_tugas
            "  ' --> query delete


            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@id_tugas", selectedId)
                cmd.ExecuteNonQuery()
            End Using


            MsgBox("Tugas berhasil dihapus!")
            tampilData()
            clearForm()

        Catch ex As Exception
            MsgBox("Gagal menghapus: " & ex.Message)
        End Try

    End Sub





    ' =====================================
    ' KETIKA KLIK DATA DI DATAGRID
    ' =====================================
    Private Sub dgvTugas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTugas.CellClick

        If e.RowIndex >= 0 Then
            Dim row = dgvTugas.Rows(e.RowIndex)  ' --> ambil baris yg diklik


            selectedId = row.Cells("id_tugas").Value  ' --> simpan id
            txtNamaTugas.Text = row.Cells("nama_tugas").Value.ToString()  ' --> isi nama
            txtKeterangan.Text = row.Cells("keterangan").Value.ToString()  ' --> isi keterangan


            Dim mk As String = row.Cells("nama_mata_kuliah").Value.ToString()  ' --> nama mk


            For Each item In cmbMataKuliah.Items  ' --> cocokkan combobox
                If item.Text = mk Then
                    cmbMataKuliah.SelectedItem = item
                    Exit For
                End If
            Next


            dtpTenggat.Value = Convert.ToDateTime(row.Cells("tenggat").Value)  ' --> isi tenggat

        End If

    End Sub





    ' =====================================
    ' SEARCH DATA
    ' =====================================
    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        connection()


        Try
            If txtCari.Text.Trim() = "" Then
                tampilData()
                Return
            End If


            Dim keyword As String = "%" & txtCari.Text & "%"  ' --> pattern LIKE


            Dim query As String = "
                SELECT 
                    id_tugas,
                    nama_tugas,
                    keterangan,
                    nama_mata_kuliah,
                    dibuat,
                    tenggat
                FROM tugas t
                LEFT JOIN mata_kuliah mk 
                    ON t.id_mata_kuliah = mk.id_mata_kuliah
                WHERE 
                    t.nama_tugas LIKE @key
                    OR t.keterangan LIKE @key
                    OR mk.nama_mata_kuliah LIKE @key
            "  ' --> query search 3 kolom


            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@key", keyword)

                Dim adapter As New MySqlDataAdapter(cmd)
                Dim ds As New DataSet
                adapter.Fill(ds, "tugas")
                dgvTugas.DataSource = ds.Tables("tugas")  ' --> tampilkan hasil
            End Using


        Catch ex As Exception
            MsgBox("Gagal mencari: " & ex.Message)
        End Try

    End Sub





    ' =====================================
    ' TOMBOL INPUT NILAI
    ' =====================================
    Private Sub btnInputNilai_Click(sender As Object, e As EventArgs) Handles btnInputNilai.Click

        If selectedId = 0 Then
            MsgBox("Pilih tugas dulu!")
            Return
        End If

        If mainPanel Is Nothing Then
            MsgBox("mainPanel belum dikirim ke TugasControl.")
            Return
        End If


        Dim nilaiInput As New NilaiInputControl(mainPanel, selectedId, txtNamaTugas.Text)  ' --> buka halaman input nilai


        mainPanel.Controls.Clear()  ' --> bersihkan panel
        mainPanel.Controls.Add(nilaiInput)  ' --> load control nilai
        nilaiInput.Dock = DockStyle.Fill  ' --> full layar

    End Sub

End Class
