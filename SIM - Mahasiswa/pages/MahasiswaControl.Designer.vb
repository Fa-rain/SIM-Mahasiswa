<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MahasiswaControl
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnCari = New System.Windows.Forms.Button()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.txtCari = New System.Windows.Forms.TextBox()
        Me.cmbKelamin = New System.Windows.Forms.ComboBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtNim = New System.Windows.Forms.TextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.txtAlamat = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtNamaMahasiswa = New System.Windows.Forms.TextBox()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.dgvMahasiswa = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.cmbJurusan = New System.Windows.Forms.ComboBox()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.dtpTanggalLahir = New System.Windows.Forms.DateTimePicker()
        Me.lblJurusan = New System.Windows.Forms.Label()
        Me.lblTanggalLahir = New System.Windows.Forms.Label()
        Me.lblKelamin = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblAlamat = New System.Windows.Forms.Label()
        Me.lblNama = New System.Windows.Forms.Label()
        Me.lblNim = New System.Windows.Forms.Label()
        Me.Panel6.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgvMahasiswa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCari
        '
        Me.btnCari.BackColor = System.Drawing.Color.SteelBlue
        Me.btnCari.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCari.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCari.ForeColor = System.Drawing.Color.White
        Me.btnCari.Location = New System.Drawing.Point(334, 281)
        Me.btnCari.Name = "btnCari"
        Me.btnCari.Size = New System.Drawing.Size(68, 24)
        Me.btnCari.TabIndex = 46
        Me.btnCari.Text = "Cari"
        Me.btnCari.UseVisualStyleBackColor = False
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.White
        Me.Panel6.Controls.Add(Me.txtCari)
        Me.Panel6.Location = New System.Drawing.Point(15, 282)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(313, 23)
        Me.Panel6.TabIndex = 45
        '
        'txtCari
        '
        Me.txtCari.BackColor = System.Drawing.Color.White
        Me.txtCari.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCari.Location = New System.Drawing.Point(7, 6)
        Me.txtCari.Name = "txtCari"
        Me.txtCari.Size = New System.Drawing.Size(190, 13)
        Me.txtCari.TabIndex = 24
        '
        'cmbKelamin
        '
        Me.cmbKelamin.AllowDrop = True
        Me.cmbKelamin.BackColor = System.Drawing.Color.White
        Me.cmbKelamin.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbKelamin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbKelamin.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbKelamin.FormattingEnabled = True
        Me.cmbKelamin.IntegralHeight = False
        Me.cmbKelamin.Items.AddRange(New Object() {"laki-laki", "perempuan"})
        Me.cmbKelamin.Location = New System.Drawing.Point(507, 62)
        Me.cmbKelamin.Name = "cmbKelamin"
        Me.cmbKelamin.Size = New System.Drawing.Size(237, 23)
        Me.cmbKelamin.TabIndex = 3
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.White
        Me.Panel5.Controls.Add(Me.TextBox1)
        Me.Panel5.Controls.Add(Me.txtEmail)
        Me.Panel5.Location = New System.Drawing.Point(1, 214)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(387, 21)
        Me.Panel5.TabIndex = 41
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Location = New System.Drawing.Point(7, -18)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(377, 15)
        Me.TextBox1.TabIndex = 25
        '
        'txtEmail
        '
        Me.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEmail.Location = New System.Drawing.Point(7, 2)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(377, 15)
        Me.txtEmail.TabIndex = 3
        '
        'txtNim
        '
        Me.txtNim.BackColor = System.Drawing.Color.White
        Me.txtNim.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNim.Location = New System.Drawing.Point(7, 2)
        Me.txtNim.Name = "txtNim"
        Me.txtNim.Size = New System.Drawing.Size(377, 15)
        Me.txtNim.TabIndex = 3
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.Controls.Add(Me.txtAlamat)
        Me.Panel4.Location = New System.Drawing.Point(1, 160)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(387, 21)
        Me.Panel4.TabIndex = 40
        '
        'txtAlamat
        '
        Me.txtAlamat.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAlamat.Location = New System.Drawing.Point(7, 2)
        Me.txtAlamat.Name = "txtAlamat"
        Me.txtAlamat.Size = New System.Drawing.Size(377, 15)
        Me.txtAlamat.TabIndex = 3
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.txtNamaMahasiswa)
        Me.Panel3.Controls.Add(Me.txtNama)
        Me.Panel3.Location = New System.Drawing.Point(1, 109)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(387, 21)
        Me.Panel3.TabIndex = 39
        '
        'txtNamaMahasiswa
        '
        Me.txtNamaMahasiswa.BackColor = System.Drawing.Color.White
        Me.txtNamaMahasiswa.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNamaMahasiswa.Location = New System.Drawing.Point(7, 2)
        Me.txtNamaMahasiswa.Name = "txtNamaMahasiswa"
        Me.txtNamaMahasiswa.Size = New System.Drawing.Size(377, 15)
        Me.txtNamaMahasiswa.TabIndex = 3
        '
        'txtNama
        '
        Me.txtNama.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNama.Location = New System.Drawing.Point(7, -18)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(377, 15)
        Me.txtNama.TabIndex = 24
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.txtNim)
        Me.Panel2.Location = New System.Drawing.Point(1, 63)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(387, 21)
        Me.Panel2.TabIndex = 38
        '
        'btnHapus
        '
        Me.btnHapus.BackColor = System.Drawing.Color.Red
        Me.btnHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHapus.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHapus.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnHapus.Location = New System.Drawing.Point(676, 216)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(68, 24)
        Me.btnHapus.TabIndex = 3
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = False
        '
        'dgvMahasiswa
        '
        Me.dgvMahasiswa.AllowUserToAddRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.dgvMahasiswa.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvMahasiswa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvMahasiswa.BackgroundColor = System.Drawing.Color.White
        Me.dgvMahasiswa.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvMahasiswa.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvMahasiswa.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvMahasiswa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvMahasiswa.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvMahasiswa.GridColor = System.Drawing.Color.LightGray
        Me.dgvMahasiswa.Location = New System.Drawing.Point(15, 311)
        Me.dgvMahasiswa.MultiSelect = False
        Me.dgvMahasiswa.Name = "dgvMahasiswa"
        Me.dgvMahasiswa.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvMahasiswa.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        Me.dgvMahasiswa.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvMahasiswa.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White
        Me.dgvMahasiswa.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvMahasiswa.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvMahasiswa.RowTemplate.Height = 25
        Me.dgvMahasiswa.Size = New System.Drawing.Size(747, 223)
        Me.dgvMahasiswa.TabIndex = 43
        '
        'Panel1
        '
        Me.Panel1.AllowDrop = True
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.Controls.Add(Me.cmbKelamin)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.btnHapus)
        Me.Panel1.Controls.Add(Me.btnEdit)
        Me.Panel1.Controls.Add(Me.cmbJurusan)
        Me.Panel1.Controls.Add(Me.btnTambah)
        Me.Panel1.Controls.Add(Me.dtpTanggalLahir)
        Me.Panel1.Controls.Add(Me.lblJurusan)
        Me.Panel1.Controls.Add(Me.lblTanggalLahir)
        Me.Panel1.Controls.Add(Me.lblKelamin)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.lblAlamat)
        Me.Panel1.Controls.Add(Me.lblNama)
        Me.Panel1.Controls.Add(Me.lblNim)
        Me.Panel1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.ForeColor = System.Drawing.Color.Black
        Me.Panel1.ImeMode = System.Windows.Forms.ImeMode.Hiragana
        Me.Panel1.Location = New System.Drawing.Point(14, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(747, 258)
        Me.Panel1.TabIndex = 44
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.SteelBlue
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.ForeColor = System.Drawing.Color.White
        Me.btnEdit.Location = New System.Drawing.Point(593, 216)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(68, 24)
        Me.btnEdit.TabIndex = 3
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'cmbJurusan
        '
        Me.cmbJurusan.AllowDrop = True
        Me.cmbJurusan.BackColor = System.Drawing.Color.White
        Me.cmbJurusan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbJurusan.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbJurusan.FormattingEnabled = True
        Me.cmbJurusan.Location = New System.Drawing.Point(507, 162)
        Me.cmbJurusan.Name = "cmbJurusan"
        Me.cmbJurusan.Size = New System.Drawing.Size(237, 21)
        Me.cmbJurusan.TabIndex = 3
        '
        'btnTambah
        '
        Me.btnTambah.BackColor = System.Drawing.Color.ForestGreen
        Me.btnTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTambah.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTambah.ForeColor = System.Drawing.Color.White
        Me.btnTambah.Location = New System.Drawing.Point(507, 216)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(68, 24)
        Me.btnTambah.TabIndex = 3
        Me.btnTambah.Text = "Tambah"
        Me.btnTambah.UseVisualStyleBackColor = False
        '
        'dtpTanggalLahir
        '
        Me.dtpTanggalLahir.CalendarForeColor = System.Drawing.Color.Black
        Me.dtpTanggalLahir.CalendarMonthBackground = System.Drawing.Color.White
        Me.dtpTanggalLahir.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpTanggalLahir.Location = New System.Drawing.Point(507, 111)
        Me.dtpTanggalLahir.Name = "dtpTanggalLahir"
        Me.dtpTanggalLahir.Size = New System.Drawing.Size(237, 22)
        Me.dtpTanggalLahir.TabIndex = 3
        '
        'lblJurusan
        '
        Me.lblJurusan.AutoSize = True
        Me.lblJurusan.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJurusan.Location = New System.Drawing.Point(504, 146)
        Me.lblJurusan.Name = "lblJurusan"
        Me.lblJurusan.Size = New System.Drawing.Size(47, 13)
        Me.lblJurusan.TabIndex = 2
        Me.lblJurusan.Text = "Jurusan"
        '
        'lblTanggalLahir
        '
        Me.lblTanggalLahir.AutoSize = True
        Me.lblTanggalLahir.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTanggalLahir.Location = New System.Drawing.Point(504, 95)
        Me.lblTanggalLahir.Name = "lblTanggalLahir"
        Me.lblTanggalLahir.Size = New System.Drawing.Size(75, 13)
        Me.lblTanggalLahir.TabIndex = 2
        Me.lblTanggalLahir.Text = "Tanggal Lahir"
        '
        'lblKelamin
        '
        Me.lblKelamin.AutoSize = True
        Me.lblKelamin.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKelamin.Location = New System.Drawing.Point(504, 46)
        Me.lblKelamin.Name = "lblKelamin"
        Me.lblKelamin.Size = New System.Drawing.Size(75, 13)
        Me.lblKelamin.TabIndex = 2
        Me.lblKelamin.Text = "Jenis Kelamin"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(4, 198)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Email"
        '
        'lblAlamat
        '
        Me.lblAlamat.AutoSize = True
        Me.lblAlamat.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAlamat.Location = New System.Drawing.Point(4, 144)
        Me.lblAlamat.Name = "lblAlamat"
        Me.lblAlamat.Size = New System.Drawing.Size(42, 13)
        Me.lblAlamat.TabIndex = 2
        Me.lblAlamat.Text = "Alamat"
        '
        'lblNama
        '
        Me.lblNama.AutoSize = True
        Me.lblNama.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNama.Location = New System.Drawing.Point(4, 93)
        Me.lblNama.Name = "lblNama"
        Me.lblNama.Size = New System.Drawing.Size(36, 13)
        Me.lblNama.TabIndex = 2
        Me.lblNama.Text = "Nama"
        '
        'lblNim
        '
        Me.lblNim.AutoSize = True
        Me.lblNim.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNim.Location = New System.Drawing.Point(4, 44)
        Me.lblNim.Name = "lblNim"
        Me.lblNim.Size = New System.Drawing.Size(28, 13)
        Me.lblNim.TabIndex = 2
        Me.lblNim.Text = "NIM"
        '
        'MahasiswaControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btnCari)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.dgvMahasiswa)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "MahasiswaControl"
        Me.Size = New System.Drawing.Size(780, 550)
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.dgvMahasiswa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnCari As Button
    Friend WithEvents Panel6 As Panel
    Friend WithEvents txtCari As TextBox
    Friend WithEvents cmbKelamin As ComboBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtNim As TextBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txtNamaMahasiswa As TextBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnHapus As Button
    Friend WithEvents dgvMahasiswa As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnEdit As Button
    Friend WithEvents cmbJurusan As ComboBox
    Friend WithEvents btnTambah As Button
    Friend WithEvents dtpTanggalLahir As DateTimePicker
    Friend WithEvents lblJurusan As Label
    Friend WithEvents lblTanggalLahir As Label
    Friend WithEvents lblKelamin As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblAlamat As Label
    Friend WithEvents lblNama As Label
    Friend WithEvents lblNim As Label
End Class
