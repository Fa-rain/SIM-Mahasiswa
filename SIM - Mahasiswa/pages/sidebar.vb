' ============================================
' SIDEBAR: NAVIGASI UTAMA KE SETIAP MODULE
' ============================================
Public Class sidebar

    ' =============================================================
    ' FUNGSI: MENDAPATKAN FORM dashboard SEBAGAI PARENT CONTAINER
    ' =============================================================
    Private Function GetDashboard() As dashboard
        Return TryCast(Me.FindForm(), dashboard) ' --> cari parent form bertipe dashboard
    End Function



    ' ==================================
    ' LINK: MAHASISWA
    ' ==================================
    Private Sub linkMahasiswa_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkMahasiswa.LinkClicked
        Dim parent = GetDashboard() ' --> ambil parent dashboard
        If parent Is Nothing Then Exit Sub ' --> validasi

        parent.LoadPage(New MahasiswaControl()) ' --> load page mahasiswa
    End Sub



    ' ==================================
    ' LINK: DOSEN
    ' ==================================
    Private Sub linkDosen_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkDosen.LinkClicked
        Dim parent = GetDashboard()
        If parent Is Nothing Then Exit Sub

        parent.LoadPage(New DosenControl()) ' --> load page dosen
    End Sub



    ' ==================================
    ' LINK: MATA KULIAH
    ' ==================================
    Private Sub linkMataKuliah_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkMataKuliah.LinkClicked
        Dim parent = GetDashboard()
        If parent Is Nothing Then Exit Sub

        parent.LoadPage(New MataKuliahControl()) ' --> load page mata kuliah
    End Sub



    ' ==================================
    ' LINK: RUANGAN
    ' ==================================
    Private Sub linkRuangan_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkRuangan.LinkClicked
        Dim parent = GetDashboard()
        If parent Is Nothing Then Exit Sub

        parent.LoadPage(New RuanganControl()) ' --> load page ruangan
    End Sub



    ' ==================================
    ' LINK: JADWAL
    ' ==================================
    Private Sub linkJadwal_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkJadwal.LinkClicked
        Dim parent = GetDashboard()
        If parent Is Nothing Then Exit Sub

        parent.LoadPage(New JadwalControl()) ' --> load page jadwal
    End Sub



    ' ==================================
    ' LINK: STAFF
    ' ==================================
    Private Sub linkStaff_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkStaff.LinkClicked
        Dim parent = GetDashboard()
        If parent Is Nothing Then Exit Sub

        parent.LoadPage(New StaffControl()) ' --> load page staff
    End Sub



    ' ==================================
    ' LINK: TUGAS
    ' ==================================
    Private Sub link_tugas_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles link_tugas.LinkClicked
        Dim parent = GetDashboard()
        If parent Is Nothing Then Exit Sub

        parent.LoadPage(New TugasControl(parent.MainPanel)) ' --> load page tugas (punya kebutuhan panel khusus)
    End Sub



    ' ==================================
    ' LINK: JURUSAN
    ' ==================================
    Private Sub linkJurusan_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkJurusan.LinkClicked
        Dim parent = GetDashboard()
        If parent Is Nothing Then Exit Sub

        parent.LoadPage(New JurusanControl()) ' --> load page jurusan
    End Sub



    ' ==================================
    ' LINK: NILAI
    ' ==================================
    Private Sub linkNilai_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkNilai.LinkClicked
        Dim parent = GetDashboard()
        If parent Is Nothing Then Exit Sub

        parent.LoadPage(New NilaiControl()) ' --> load page nilai
    End Sub



    ' ==================================
    ' LINK: DASHBOARD / HOME
    ' ==================================
    Private Sub link_dashboard_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles link_dashboard.LinkClicked
        Dim parent = GetDashboard()
        If parent Is Nothing Then Exit Sub

        Dim home As New HomeControl() ' --> buat halaman home baru
        home.LoggedUsername = parent.LoggedUsername ' --> kirim username yg login
        parent.LoadPage(home) ' --> tampilkan home
    End Sub

End Class
