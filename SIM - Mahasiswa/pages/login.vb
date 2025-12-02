Imports MySql.Data.MySqlClient

Public Class Login

    ' ================================
    ' LOGIN: PROSES AUTENTIKASI USER
    ' ================================
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        connection() ' --> panggil method connection dari koneksi.vb

        Try
            Dim query As String =
                "SELECT * FROM user WHERE username = @username AND password = @password" ' --> query cek username & password

            cmd = New MySqlCommand(query, conn) ' --> buat command SQL

            cmd.Parameters.AddWithValue("@username", txtUsername.Text) ' --> parameter username
            cmd.Parameters.AddWithValue("@password", txtPassword.Text) ' --> parameter password

            rd = cmd.ExecuteReader() ' --> eksekusi reader

            If rd.HasRows Then ' --> jika data ditemukan
                MsgBox("Login Berhasil!", MsgBoxStyle.Information, "Berhasil") ' --> notifikasi sukses

                Dim dash As New dashboard() ' --> buka dashboard
                dash.LoggedUsername = txtUsername.Text ' --> kirim username
                dash.Show() ' --> tampilkan dashboard
                Me.Hide() ' --> sembunyikan form login

            Else
                MsgBox("Login Gagal!", MsgBoxStyle.Information, "Gagal") ' --> notifikasi gagal
            End If

        Catch ex As Exception
            MsgBox("Error", MsgBoxStyle.Information, "Error") ' --> error jika query gagal

        End Try

    End Sub




    ' ================================
    ' LOAD: POSISIKAN PANEL LOGIN
    ' ================================
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CenterLoginPanel() ' --> posisikan panel ke tengah
    End Sub




    ' ================================
    ' POSISIKAN PANEL KE TENGAH FORM
    ' ================================
    Private Sub CenterLoginPanel()
        Panel1.Left = (Me.ClientSize.Width - Panel1.Width) \ 2 ' --> hitung posisi horizontal
        Panel1.Top = (Me.ClientSize.Height - Panel1.Height) \ 2 ' --> hitung posisi vertikal
    End Sub




    ' ================================
    ' RESIZE: TETAP TENGAH SAAT DIRESIZE
    ' ================================
    Private Sub Login_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        CenterLoginPanel() ' --> jaga panel tetap center
    End Sub


End Class
