Imports MySql.Data.MySqlClient

Public Class JadwalControl

    Private selectedId As Integer ' --> menampung id_jadwal yang dipilih dari tabel



    ' ================================
    ' TAMPILKAN DATA KE DALAM TABEL
    ' ================================
    Private Sub tampilData()
        connection() ' --> pastikan koneksi aktif

        Try
            Dim query As String =
                "SELECT 
                    id_jadwal,
                    hari,
                    tanggal,
                    jam_mulai,
                    jam_selesai,
                    nama_ruangan,
                    nama_mata_kuliah,
                    nama_dosen
                FROM jadwal j
                LEFT JOIN ruangan r ON j.id_ruangan = r.id_ruangan
                LEFT JOIN mata_kuliah m ON j.id_mata_kuliah = m.id_mata_kuliah
                LEFT JOIN dosen d ON j.id_dosen = d.id_dosen"

            Dim da As New MySqlDataAdapter(query, conn)
            Dim ds As New DataSet
            da.Fill(ds, "jadwal")

            dgvJadwal.DataSource = ds.Tables("jadwal") ' --> set data ke grid
            dgvJadwal.Columns("id_jadwal").Visible = False ' --> id disembunyikan

        Catch ex As Exception
            MsgBox("Gagal menampilkan data: " & ex.Message)
        End Try
    End Sub



    ' ================================
    ' RESET FORM SETELAH CRUD
    ' ================================
    Private Sub clearForm()
        txtHari.Clear() ' --> kosongkan input hari
        dtpTanggal.Value = Date.Now ' --> reset tanggal
        dtpJamMulai.Value = Date.Now ' --> reset jam mulai
        dtpJamSelesai.Value = Date.Now ' --> reset jam selesai

        cmbRuangan.SelectedIndex = -1 ' --> hapus pilihan ruangan
        cmbMataKuliah.SelectedIndex = -1 ' --> hapus pilihan mk
        cmbDosen.SelectedIndex = -1 ' --> hapus pilihan dosen
    End Sub



    ' ================================
    ' LOAD COMBOBOX DARI DATABASE
    ' ================================
    Private Sub loadCombo()
        connection() ' --> pastikan koneksi aktif

        Try
            ' --> COMBOBOX RUANGAN
            cmbRuangan.Items.Clear()
            Using cmd As New MySqlCommand("SELECT nama_ruangan FROM ruangan", conn)
                Using rd = cmd.ExecuteReader()
                    While rd.Read()
                        cmbRuangan.Items.Add(rd("nama_ruangan").ToString()) ' --> isi item
                    End While
                End Using
            End Using

            ' --> COMBOBOX MATA KULIAH
            cmbMataKuliah.Items.Clear()
            Using cmd As New MySqlCommand("SELECT nama_mata_kuliah FROM mata_kuliah", conn)
                Using rd = cmd.ExecuteReader()
                    While rd.Read()
                        cmbMataKuliah.Items.Add(rd("nama_mata_kuliah").ToString())
                    End While
                End Using
            End Using

            ' --> COMBOBOX DOSEN
            cmbDosen.Items.Clear()
            Using cmd As New MySqlCommand("SELECT nama_dosen FROM dosen", conn)
                Using rd = cmd.ExecuteReader()
                    While rd.Read()
                        cmbDosen.Items.Add(rd("nama_dosen").ToString())
                    End While
                End Using
            End Using

        Catch ex As Exception
            MsgBox("Gagal load combobox: " & ex.Message)
        End Try

    End Sub




    ' ================================
    ' LOAD AWAL FORM
    ' ================================
    Private Sub JadwalControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampilData() ' --> tampilkan data jadwal
        loadCombo()  ' --> load isi combobox

        txtHari.Text = "" ' --> pastikan input hari kosong
    End Sub




    ' ================================
    ' TAMBAH DATA JADWAL
    ' ================================
    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        connection() ' --> pastikan koneksi aktif

        Try
            ' --> ambil id dari combobox
            Dim id_ruangan = GetId("ruangan", "id_ruangan", "nama_ruangan", cmbRuangan.Text)
            Dim id_mk = GetId("mata_kuliah", "id_mata_kuliah", "nama_mata_kuliah", cmbMataKuliah.Text)
            Dim id_dosen = GetId("dosen", "id_dosen", "nama_dosen", cmbDosen.Text)

            Dim query As String =
                "INSERT INTO jadwal (hari, tanggal, jam_mulai, jam_selesai, id_ruangan, id_mata_kuliah, id_dosen)
                 VALUES (@hari, @tanggal, @jam_mulai, @jam_selesai, @id_ruangan, @id_mata_kuliah, @id_dosen)"

            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@hari", txtHari.Text) ' --> hari
                cmd.Parameters.AddWithValue("@tanggal", dtpTanggal.Value.ToString("yyyy-MM-dd")) ' --> tanggal
                cmd.Parameters.Add("@jam_mulai", MySqlDbType.Time).Value = dtpJamMulai.Value.TimeOfDay ' --> jam mulai
                cmd.Parameters.Add("@jam_selesai", MySqlDbType.Time).Value = dtpJamSelesai.Value.TimeOfDay ' --> jam selesai
                cmd.Parameters.AddWithValue("@id_ruangan", id_ruangan) ' --> id ruangan
                cmd.Parameters.AddWithValue("@id_mata_kuliah", id_mk) ' --> id mk
                cmd.Parameters.AddWithValue("@id_dosen", id_dosen) ' --> id dosen
                cmd.ExecuteNonQuery() ' --> eksekusi insert
            End Using

            MsgBox("Berhasil menambah jadwal!") ' --> notifikasi sukses
            tampilData() ' --> refresh tabel
            clearForm() ' --> reset form

        Catch ex As Exception
            MsgBox("Gagal menambah jadwal: " & ex.Message)
        End Try

    End Sub




    ' ================================
    ' UPDATE DATA JADWAL
    ' ================================
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        connection() ' --> pastikan koneksi aktif

        Try
            Dim id_ruangan = GetId("ruangan", "id_ruangan", "nama_ruangan", cmbRuangan.Text)
            Dim id_mk = GetId("mata_kuliah", "id_mata_kuliah", "nama_mata_kuliah", cmbMataKuliah.Text)
            Dim id_dosen = GetId("dosen", "id_dosen", "nama_dosen", cmbDosen.Text)

            Dim query As String =
                "UPDATE jadwal SET
                 hari=@hari, tanggal=@tanggal, jam_mulai=@jam_mulai, jam_selesai=@jam_selesai,
                 id_ruangan=@id_ruangan, id_mata_kuliah=@id_mata_kuliah, id_dosen=@id_dosen
                 WHERE id_jadwal=@id_jadwal"

            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@hari", txtHari.Text) ' --> hari baru
                cmd.Parameters.AddWithValue("@tanggal", dtpTanggal.Value.ToString("yyyy-MM-dd")) ' --> tanggal baru
                cmd.Parameters.Add("@jam_mulai", MySqlDbType.Time).Value = dtpJamMulai.Value.TimeOfDay ' --> jam mulai
                cmd.Parameters.Add("@jam_selesai", MySqlDbType.Time).Value = dtpJamSelesai.Value.TimeOfDay ' --> jam selesai
                cmd.Parameters.AddWithValue("@id_ruangan", id_ruangan) ' --> id ruangan
                cmd.Parameters.AddWithValue("@id_mata_kuliah", id_mk) ' --> id mk
                cmd.Parameters.AddWithValue("@id_dosen", id_dosen) ' --> id dosen
                cmd.Parameters.AddWithValue("@id_jadwal", selectedId) ' --> id jadwal yang mau diupdate
                cmd.ExecuteNonQuery() ' --> eksekusi update
            End Using

            MsgBox("Berhasil mengupdate jadwal!") ' --> sukses
            tampilData()
            clearForm()

        Catch ex As Exception
            MsgBox("Gagal update: " & ex.Message)
        End Try

    End Sub




    ' ================================
    ' HAPUS DATA JADWAL
    ' ================================
    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        connection() ' --> pastikan koneksi aktif

        Try
            Dim query = "DELETE FROM jadwal WHERE id_jadwal=@id"

            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@id", selectedId) ' --> id jadwal yg dihapus
                cmd.ExecuteNonQuery() ' --> eksekusi delete
            End Using

            MsgBox("Berhasil menghapus jadwal!") ' --> sukses
            tampilData()
            clearForm()

        Catch ex As Exception
            MsgBox("Gagal hapus: " & ex.Message)
        End Try
    End Sub




    ' ================================
    ' AMBIL ID BERDASARKAN NAMA COMBOBOX
    ' ================================
    Private Function GetId(table As String, idColumn As String, nameColumn As String, nameValue As String) As Integer
        Dim result As Integer = 0 ' --> default 0 jika tidak ditemukan

        Dim query = $"SELECT {idColumn} FROM {table} WHERE {nameColumn}=@name LIMIT 1"

        Using cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@name", nameValue) ' --> nama yang dipilih
            Dim rd = cmd.ExecuteReader()
            If rd.Read() Then
                result = rd(idColumn) ' --> ambil ID
            End If
            rd.Close()
        End Using

        Return result
    End Function




    ' ================================
    ' KETIKA ROW TABEL DIKLIK
    ' ================================
    Private Sub dgvJadwal_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvJadwal.CellClick
        If e.RowIndex < 0 Then Exit Sub ' --> kalau klik header, abaikan

        Dim row = dgvJadwal.Rows(e.RowIndex)
        selectedId = row.Cells("id_jadwal").Value ' --> simpan id jadwal terpilih

        txtHari.Text = row.Cells("hari").Value.ToString() ' --> isi input hari

        ' --> parsing jam mulai & selesai
        Dim ts_mulai As TimeSpan = TimeSpan.Parse(row.Cells("jam_mulai").Value.ToString())
        Dim ts_selesai As TimeSpan = TimeSpan.Parse(row.Cells("jam_selesai").Value.ToString())

        dtpTanggal.Value = Convert.ToDateTime(row.Cells("tanggal").Value) ' --> set tanggal
        dtpJamMulai.Value = DateTime.Today.Add(ts_mulai) ' --> set jam mulai
        dtpJamSelesai.Value = DateTime.Today.Add(ts_selesai) ' --> set jam selesai

        cmbRuangan.SelectedItem = row.Cells("nama_ruangan").Value.ToString() ' --> set ruangan
        cmbMataKuliah.SelectedItem = row.Cells("nama_mata_kuliah").Value.ToString() ' --> set mk
        cmbDosen.SelectedItem = row.Cells("nama_dosen").Value.ToString() ' --> set dosen
    End Sub




    ' ================================
    ' SEARCH DATA
    ' ================================
    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        connection()

        If txtCari.Text.Trim() = "" Then
            tampilData() ' --> kalau kosong, tampilkan semua
            Return
        End If

        Try
            Dim keyword = "%" & txtCari.Text & "%" ' --> wildcard pencarian

            Dim query As String =
                "SELECT j.id_jadwal, j.hari, j.tanggal, j.jam_mulai, j.jam_selesai,
                        r.nama_ruangan, m.nama_mata_kuliah, d.nama_dosen
                 FROM jadwal j
                 LEFT JOIN ruangan r ON j.id_ruangan = r.id_ruangan
                 LEFT JOIN mata_kuliah m ON j.id_mata_kuliah = m.id_mata_kuliah
                 LEFT JOIN dosen d ON j.id_dosen = d.id_dosen
                 WHERE 
                 j.hari LIKE @keyword OR
                 j.tanggal LIKE @keyword OR
                 r.nama_ruangan LIKE @keyword OR
                 m.nama_mata_kuliah LIKE @keyword OR
                 d.nama_dosen LIKE @keyword"

            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@keyword", keyword) ' --> kata kunci pencarian

                Dim da As New MySqlDataAdapter(cmd)
                Dim ds As New DataSet
                da.Fill(ds, "jadwal")
                dgvJadwal.DataSource = ds.Tables("jadwal") ' --> update tabel
            End Using

        Catch ex As Exception
            MsgBox("Gagal mencari: " & ex.Message)
        End Try
    End Sub

End Class
