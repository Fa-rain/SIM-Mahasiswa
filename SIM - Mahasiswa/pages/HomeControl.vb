Imports MySql.Data.MySqlClient

Public Class HomeControl

    ' ---------------------------------------------------------------
    ' PROPERTY UNTUK MENYIMPAN USERNAME YANG AKAN DI-TAMPILKAN
    ' ---------------------------------------------------------------
    Public Property LoggedUsername As String = ""

    ' ---------------------------------------------------------------
    ' EVENT LOGOUT — USERCONTROL NGIRIM SINYAL KE FORM DASHBOARD
    ' ---------------------------------------------------------------
    Public Event LogoutRequested()


    ' ---------------------------------------------------------------
    ' METHOD UNTUK MENGAMBIL TOTAL ROW DARI SUATU TABEL
    ' ---------------------------------------------------------------
    Private Function GetCount(table As String) As Integer
        connection()

        Dim total As Integer = 0
        Dim query As String = $"SELECT COUNT(*) FROM {table}"

        Using cmd As New MySqlCommand(query, conn)
            total = Convert.ToInt32(cmd.ExecuteScalar())
        End Using

        Return total
    End Function


    ' ---------------------------------------------------------------
    ' AMBIL SEMUA STATISTIK DAN TEMPATKAN KE LABEL MASING-MASING
    ' ---------------------------------------------------------------
    Private Sub LoadStatistics()
        lblMahasiswa.Text = GetCount("mahasiswa").ToString()
        lblDosen.Text = GetCount("dosen").ToString()
        lblJurusan.Text = GetCount("jurusan").ToString()
        lblMataKuliah.Text = GetCount("mata_kuliah").ToString()
        lblRuangan.Text = GetCount("ruangan").ToString()
        lblStaff.Text = GetCount("staff").ToString()
    End Sub


    ' ---------------------------------------------------------------
    ' TOMBOL LOGOUT — TAPI DISINI CUMA NGIRIM EVENT
    ' ---------------------------------------------------------------



    ' ---------------------------------------------------------------
    ' KETIKA USERCONTROL DI-LOAD, TAMPILIN NAMA DAN STATISTIK
    ' ---------------------------------------------------------------
    Private Sub HomeControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' tampilkan sapaan
        lblWelcome.Text = "Selamat datang, " & LoggedUsername

        ' ambil statistik dari database
        LoadStatistics()

    End Sub

    Private Sub btnLogout_Click_1(sender As Object, e As EventArgs)
        RaiseEvent LogoutRequested()   ' -> kasih sinyal ke dashboard
    End Sub
End Class
