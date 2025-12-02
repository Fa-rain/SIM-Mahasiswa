Imports MySql.Data.MySqlClient

Public Class NilaiInputControl

    Private selectedMahasiswaId As Integer = -1 ' --> id mahasiswa yang dipilih (default -1 = belum ada)
    Private idTugas As Integer = -1 ' --> id tugas yang dikirim dari form sebelumnya
    Private mainPanel As Panel ' --> panel tujuan untuk meletakkan control ini


    ' ======================================
    ' CONSTRUCTOR UTAMA (terima panel + id)
    ' ======================================
    Public Sub New(targetPanel As Panel, tugasId As Integer, namaTugas As String)
        InitializeComponent() ' --> inisialisasi komponen form
        mainPanel = targetPanel ' --> simpan panel utama
        idTugas = tugasId ' --> simpan id tugas
        lblNamaTugas.Text = namaTugas ' --> tampilkan nama tugas di label
    End Sub






    ' =====================
    ' LOAD AWAL
    ' =====================
    Private Sub NilaiInputControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampilMahasiswa() ' --> panggil fungsi untuk menampilkan daftar mahasiswa
    End Sub






    ' =====================
    ' TAMPILKAN MAHASISWA
    ' =====================
    Private Sub tampilMahasiswa()
        Try
            connection() ' --> pastikan koneksi MySQL aktif

            Dim query As String =
                "SELECT id_mahasiswa, nim, nama_mahasiswa, email 
                 FROM mahasiswa 
                 ORDER BY nama_mahasiswa ASC" ' --> ambil data mahasiswa urut nama

            Dim cmd As New MySqlCommand(query, conn) ' --> buat command SELECT
            Dim adapter As New MySqlDataAdapter(cmd) ' --> adapter untuk mengisi tabel
            Dim dt As New DataTable ' --> tabel penampung data
            adapter.Fill(dt) ' --> isi tabel dari database

            dgvMahasiswa.DataSource = dt ' --> tampilkan data ke DataGridView

        Catch ex As Exception
            MsgBox("Gagal tampil mahasiswa: " & ex.Message) ' --> tampilkan error jika gagal load data
        End Try
    End Sub






    ' =====================
    ' PILIH MAHASISWA
    ' =====================
    Private Sub dgvMahasiswa_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMahasiswa.CellClick
        If e.RowIndex >= 0 Then ' --> pastikan klik bukan pada header
            selectedMahasiswaId = dgvMahasiswa.Rows(e.RowIndex).Cells("id_mahasiswa").Value ' --> ambil id mahasiswa
            txtMahasiswa.Text = dgvMahasiswa.Rows(e.RowIndex).Cells("nama_mahasiswa").Value ' --> tampilkan nama di textbox
        End If
    End Sub






    ' =====================
    ' SIMPAN NILAI
    ' =====================
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click

        If selectedMahasiswaId = -1 Then ' --> validasi: harus pilih mahasiswa
            MsgBox("Pilih mahasiswa dulu.")
            Return
        End If

        If idTugas <= 0 Then ' --> validasi: id tugas harus benar
            MsgBox("ID Tugas tidak valid.")
            Return
        End If

        Try
            connection() ' --> pastikan koneksi aktif

            Dim query As String =
                "INSERT INTO nilai (nilai, id_tugas, keterangan, id_mahasiswa)
                 VALUES (@nilai, @tugas, @ket, @mhs)" ' --> query insert nilai

            Dim cmd As New MySqlCommand(query, conn) ' --> buat command insert
            cmd.Parameters.AddWithValue("@nilai", numNilai.Value) ' --> nilai angka
            cmd.Parameters.AddWithValue("@tugas", idTugas) ' --> id tugas
            cmd.Parameters.AddWithValue("@ket", txtKeterangan.Text.Trim()) ' --> keterangan
            cmd.Parameters.AddWithValue("@mhs", selectedMahasiswaId) ' --> id mahasiswa yang dipilih

            cmd.ExecuteNonQuery() ' --> jalankan perintah insert

            MsgBox("Nilai berhasil disimpan.") ' --> info sukses

        Catch ex As Exception
            MsgBox("Gagal menyimpan data: " & ex.Message) ' --> info jika error
        End Try

    End Sub

End Class
