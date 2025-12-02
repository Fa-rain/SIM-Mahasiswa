Imports MySql.Data.MySqlClient

Public Class dashboard

    ' ----------------------------------------------------
    ' PROPERTY UNTUK MENYIMPAN USERNAME YANG LOGIN SAAT INI
    ' ----------------------------------------------------
    Public Property LoggedUsername As String

    ' -------------------------------------------
    ' PANEL UTAMA TEMPAT SEMUA MODULE DI TAMPILKAN
    ' -------------------------------------------
    Public ReadOnly Property MainPanel As Panel
        Get
            Return panelContent ' --> panelContent dari designer
        End Get
    End Property



    ' ====================================
    ' LOAD AWAL SAAT DASHBOARD DIJALANKAN
    ' ====================================
    Private Sub dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' ---------------------------------------------
        ' TAMBAHKAN SIDEBAR KE FORM DASHBOARD
        ' ---------------------------------------------
        Dim side As New sidebar()
        Me.Controls.Add(side)
        side.Dock = DockStyle.Left

        ' ---------------------------------------------
        ' MUNCULKAN HALAMAN HOME PERTAMA KALI
        ' ---------------------------------------------
        Dim home As New HomeControl()
        home.LoggedUsername = LoggedUsername

        ' --> pasang event logout dari home
        AddHandler home.LogoutRequested, AddressOf HandleLogout

        LoadPage(home)
    End Sub



    ' ==========================================================
    ' METHOD UMUM UNTUK MENAMPILKAN USERCONTROL KE DALAM MAINPANEL
    ' ==========================================================
    Public Sub LoadPage(page As UserControl)

        ' --> bersihkan panel utama
        MainPanel.Controls.Clear()

        ' ----------------------------------------------------
        ' kalau page = HomeControl, pasang handler logout lagi
        ' ----------------------------------------------------
        If TypeOf page Is HomeControl Then
            Dim home = DirectCast(page, HomeControl)
            AddHandler home.LogoutRequested, AddressOf HandleLogout
        End If

        ' --> tampilkan halaman baru
        page.Dock = DockStyle.Fill
        MainPanel.Controls.Add(page)

    End Sub



    ' ==============================================
    ' HANDLE LOGOUT: KEMBALI KE FORM LOGIN
    ' ==============================================
    Private Sub HandleLogout()

        ' --> buat ulang form login
        Dim loginForm As New Login()
        loginForm.Show()

        ' --> tutup dashboard
        Me.Close()

    End Sub

End Class
