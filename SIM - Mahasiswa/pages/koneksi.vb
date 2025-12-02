Imports MySql.Data.MySqlClient

Module Koneksi
    Public conn As MySqlConnection ' --> objek koneksi utama
    Public cmd As MySqlCommand     ' --> objek perintah SQL
    Public rd As MySqlDataReader   ' --> reader untuk baca hasil query
    Public da As MySqlDataAdapter  ' --> adapter buat fill dataset
    Public ds As DataSet           ' --> dataset penampung data

    ' ==================================
    ' KONEKSI: MEMBUKA KONEKSI DATABASE
    ' ==================================
    Sub connection()
        Try
            ' --> string koneksi (setting server, user, dan database)
            Dim str As String =
                "server = localhost;
                 user id = root;
                 password =;
                 database = db_sim_mahasiswa;"

            ' --> buat koneksi baru setiap dipanggil
            conn = New MySqlConnection(str)

            ' --> buka koneksi kalau masih closed
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message) ' --> tampilkan error jika gagal koneksi
        End Try
    End Sub
End Module
