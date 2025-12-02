<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class JadwalControl
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
        Me.cmbRuangan = New System.Windows.Forms.ComboBox()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.cmbDosen = New System.Windows.Forms.ComboBox()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.lblDosen = New System.Windows.Forms.Label()
        Me.lblMataKuliah = New System.Windows.Forms.Label()
        Me.lblRuangan = New System.Windows.Forms.Label()
        Me.lblJamSelesai = New System.Windows.Forms.Label()
        Me.lblJamMulai = New System.Windows.Forms.Label()
        Me.lblHari = New System.Windows.Forms.Label()
        Me.dgvJadwal = New System.Windows.Forms.DataGridView()
        Me.txtCari = New System.Windows.Forms.TextBox()
        Me.btnCari = New System.Windows.Forms.Button()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cmbMataKuliah = New System.Windows.Forms.ComboBox()
        Me.dtpJamSelesai = New System.Windows.Forms.DateTimePicker()
        Me.dtpJamMulai = New System.Windows.Forms.DateTimePicker()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtHari = New System.Windows.Forms.TextBox()
        Me.dtpTanggal = New System.Windows.Forms.DateTimePicker()
        Me.lblTanggal = New System.Windows.Forms.Label()
        CType(Me.dgvJadwal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmbRuangan
        '
        Me.cmbRuangan.AllowDrop = True
        Me.cmbRuangan.BackColor = System.Drawing.Color.White
        Me.cmbRuangan.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbRuangan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbRuangan.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbRuangan.FormattingEnabled = True
        Me.cmbRuangan.IntegralHeight = False
        Me.cmbRuangan.Items.AddRange(New Object() {"Laki-laki", "Perempuan"})
        Me.cmbRuangan.Location = New System.Drawing.Point(507, 62)
        Me.cmbRuangan.Name = "cmbRuangan"
        Me.cmbRuangan.Size = New System.Drawing.Size(237, 23)
        Me.cmbRuangan.TabIndex = 3
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
        'cmbDosen
        '
        Me.cmbDosen.AllowDrop = True
        Me.cmbDosen.BackColor = System.Drawing.Color.White
        Me.cmbDosen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbDosen.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDosen.FormattingEnabled = True
        Me.cmbDosen.Location = New System.Drawing.Point(507, 162)
        Me.cmbDosen.Name = "cmbDosen"
        Me.cmbDosen.Size = New System.Drawing.Size(237, 21)
        Me.cmbDosen.TabIndex = 3
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
        'lblDosen
        '
        Me.lblDosen.AutoSize = True
        Me.lblDosen.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDosen.Location = New System.Drawing.Point(504, 146)
        Me.lblDosen.Name = "lblDosen"
        Me.lblDosen.Size = New System.Drawing.Size(40, 13)
        Me.lblDosen.TabIndex = 2
        Me.lblDosen.Text = "Dosen" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblMataKuliah
        '
        Me.lblMataKuliah.AutoSize = True
        Me.lblMataKuliah.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMataKuliah.Location = New System.Drawing.Point(504, 95)
        Me.lblMataKuliah.Name = "lblMataKuliah"
        Me.lblMataKuliah.Size = New System.Drawing.Size(68, 13)
        Me.lblMataKuliah.TabIndex = 2
        Me.lblMataKuliah.Text = "Mata Kuliah"
        '
        'lblRuangan
        '
        Me.lblRuangan.AutoSize = True
        Me.lblRuangan.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRuangan.Location = New System.Drawing.Point(504, 46)
        Me.lblRuangan.Name = "lblRuangan"
        Me.lblRuangan.Size = New System.Drawing.Size(54, 13)
        Me.lblRuangan.TabIndex = 2
        Me.lblRuangan.Text = "Ruangan"
        '
        'lblJamSelesai
        '
        Me.lblJamSelesai.AutoSize = True
        Me.lblJamSelesai.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJamSelesai.Location = New System.Drawing.Point(3, 198)
        Me.lblJamSelesai.Name = "lblJamSelesai"
        Me.lblJamSelesai.Size = New System.Drawing.Size(64, 13)
        Me.lblJamSelesai.TabIndex = 2
        Me.lblJamSelesai.Text = "Jam Selesai"
        '
        'lblJamMulai
        '
        Me.lblJamMulai.AutoSize = True
        Me.lblJamMulai.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJamMulai.Location = New System.Drawing.Point(3, 144)
        Me.lblJamMulai.Name = "lblJamMulai"
        Me.lblJamMulai.Size = New System.Drawing.Size(58, 13)
        Me.lblJamMulai.TabIndex = 2
        Me.lblJamMulai.Text = "Jam Mulai"
        '
        'lblHari
        '
        Me.lblHari.AutoSize = True
        Me.lblHari.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHari.Location = New System.Drawing.Point(3, 44)
        Me.lblHari.Name = "lblHari"
        Me.lblHari.Size = New System.Drawing.Size(28, 13)
        Me.lblHari.TabIndex = 2
        Me.lblHari.Text = "Hari"
        '
        'dgvJadwal
        '
        Me.dgvJadwal.AllowUserToAddRows = False
        Me.dgvJadwal.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.dgvJadwal.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvJadwal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvJadwal.BackgroundColor = System.Drawing.Color.White
        Me.dgvJadwal.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvJadwal.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvJadwal.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvJadwal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvJadwal.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvJadwal.GridColor = System.Drawing.Color.LightGray
        Me.dgvJadwal.Location = New System.Drawing.Point(17, 312)
        Me.dgvJadwal.MultiSelect = False
        Me.dgvJadwal.Name = "dgvJadwal"
        Me.dgvJadwal.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvJadwal.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        Me.dgvJadwal.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvJadwal.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White
        Me.dgvJadwal.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvJadwal.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvJadwal.RowTemplate.Height = 25
        Me.dgvJadwal.Size = New System.Drawing.Size(747, 222)
        Me.dgvJadwal.TabIndex = 47
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
        'btnCari
        '
        Me.btnCari.BackColor = System.Drawing.Color.SteelBlue
        Me.btnCari.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCari.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCari.ForeColor = System.Drawing.Color.White
        Me.btnCari.Location = New System.Drawing.Point(260, 282)
        Me.btnCari.Name = "btnCari"
        Me.btnCari.Size = New System.Drawing.Size(68, 24)
        Me.btnCari.TabIndex = 50
        Me.btnCari.Text = "Cari"
        Me.btnCari.UseVisualStyleBackColor = False
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.White
        Me.Panel6.Controls.Add(Me.txtCari)
        Me.Panel6.Location = New System.Drawing.Point(17, 283)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(237, 23)
        Me.Panel6.TabIndex = 49
        '
        'Panel1
        '
        Me.Panel1.AllowDrop = True
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.Controls.Add(Me.cmbMataKuliah)
        Me.Panel1.Controls.Add(Me.dtpJamSelesai)
        Me.Panel1.Controls.Add(Me.dtpJamMulai)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.dtpTanggal)
        Me.Panel1.Controls.Add(Me.lblTanggal)
        Me.Panel1.Controls.Add(Me.cmbRuangan)
        Me.Panel1.Controls.Add(Me.btnHapus)
        Me.Panel1.Controls.Add(Me.btnEdit)
        Me.Panel1.Controls.Add(Me.cmbDosen)
        Me.Panel1.Controls.Add(Me.btnTambah)
        Me.Panel1.Controls.Add(Me.lblDosen)
        Me.Panel1.Controls.Add(Me.lblMataKuliah)
        Me.Panel1.Controls.Add(Me.lblRuangan)
        Me.Panel1.Controls.Add(Me.lblJamSelesai)
        Me.Panel1.Controls.Add(Me.lblJamMulai)
        Me.Panel1.Controls.Add(Me.lblHari)
        Me.Panel1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.ForeColor = System.Drawing.Color.Black
        Me.Panel1.ImeMode = System.Windows.Forms.ImeMode.Hiragana
        Me.Panel1.Location = New System.Drawing.Point(17, 18)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(747, 255)
        Me.Panel1.TabIndex = 48
        '
        'cmbMataKuliah
        '
        Me.cmbMataKuliah.AllowDrop = True
        Me.cmbMataKuliah.BackColor = System.Drawing.Color.White
        Me.cmbMataKuliah.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbMataKuliah.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbMataKuliah.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMataKuliah.FormattingEnabled = True
        Me.cmbMataKuliah.IntegralHeight = False
        Me.cmbMataKuliah.Items.AddRange(New Object() {"Laki-laki", "Perempuan"})
        Me.cmbMataKuliah.Location = New System.Drawing.Point(507, 111)
        Me.cmbMataKuliah.Name = "cmbMataKuliah"
        Me.cmbMataKuliah.Size = New System.Drawing.Size(237, 23)
        Me.cmbMataKuliah.TabIndex = 47
        '
        'dtpJamSelesai
        '
        Me.dtpJamSelesai.CalendarForeColor = System.Drawing.Color.Black
        Me.dtpJamSelesai.CalendarMonthBackground = System.Drawing.Color.White
        Me.dtpJamSelesai.CustomFormat = "HH:mm:ss"
        Me.dtpJamSelesai.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpJamSelesai.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpJamSelesai.Location = New System.Drawing.Point(0, 218)
        Me.dtpJamSelesai.Name = "dtpJamSelesai"
        Me.dtpJamSelesai.Size = New System.Drawing.Size(237, 22)
        Me.dtpJamSelesai.TabIndex = 46
        '
        'dtpJamMulai
        '
        Me.dtpJamMulai.CalendarForeColor = System.Drawing.Color.Black
        Me.dtpJamMulai.CalendarMonthBackground = System.Drawing.Color.White
        Me.dtpJamMulai.CustomFormat = "HH:mm:ss"
        Me.dtpJamMulai.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpJamMulai.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpJamMulai.Location = New System.Drawing.Point(0, 162)
        Me.dtpJamMulai.Name = "dtpJamMulai"
        Me.dtpJamMulai.Size = New System.Drawing.Size(237, 22)
        Me.dtpJamMulai.TabIndex = 45
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.txtHari)
        Me.Panel2.Location = New System.Drawing.Point(0, 64)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(237, 21)
        Me.Panel2.TabIndex = 41
        '
        'txtHari
        '
        Me.txtHari.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtHari.Location = New System.Drawing.Point(7, 2)
        Me.txtHari.Name = "txtHari"
        Me.txtHari.Size = New System.Drawing.Size(220, 15)
        Me.txtHari.TabIndex = 3
        '
        'dtpTanggal
        '
        Me.dtpTanggal.CalendarForeColor = System.Drawing.Color.Black
        Me.dtpTanggal.CalendarMonthBackground = System.Drawing.Color.White
        Me.dtpTanggal.CustomFormat = ""
        Me.dtpTanggal.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpTanggal.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTanggal.Location = New System.Drawing.Point(0, 111)
        Me.dtpTanggal.Name = "dtpTanggal"
        Me.dtpTanggal.Size = New System.Drawing.Size(237, 22)
        Me.dtpTanggal.TabIndex = 44
        '
        'lblTanggal
        '
        Me.lblTanggal.AutoSize = True
        Me.lblTanggal.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTanggal.Location = New System.Drawing.Point(3, 95)
        Me.lblTanggal.Name = "lblTanggal"
        Me.lblTanggal.Size = New System.Drawing.Size(47, 13)
        Me.lblTanggal.TabIndex = 43
        Me.lblTanggal.Text = "Tanggal"
        '
        'JadwalControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.dgvJadwal)
        Me.Controls.Add(Me.btnCari)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "JadwalControl"
        Me.Size = New System.Drawing.Size(780, 550)
        CType(Me.dgvJadwal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cmbRuangan As ComboBox
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents cmbDosen As ComboBox
    Friend WithEvents btnTambah As Button
    Friend WithEvents lblDosen As Label
    Friend WithEvents lblMataKuliah As Label
    Friend WithEvents lblRuangan As Label
    Friend WithEvents lblJamSelesai As Label
    Friend WithEvents lblJamMulai As Label
    Friend WithEvents lblHari As Label
    Friend WithEvents dgvJadwal As DataGridView
    Friend WithEvents txtCari As TextBox
    Friend WithEvents btnCari As Button
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents dtpTanggal As DateTimePicker
    Friend WithEvents lblTanggal As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtHari As TextBox
    Friend WithEvents dtpJamSelesai As DateTimePicker
    Friend WithEvents dtpJamMulai As DateTimePicker
    Friend WithEvents cmbMataKuliah As ComboBox
End Class
