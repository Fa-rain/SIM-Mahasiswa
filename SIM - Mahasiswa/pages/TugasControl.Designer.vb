<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TugasControl
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
        Me.cmbMataKuliah = New System.Windows.Forms.ComboBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtKeterangan = New System.Windows.Forms.TextBox()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtNamaTugas = New System.Windows.Forms.TextBox()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.dtpTenggat = New System.Windows.Forms.DateTimePicker()
        Me.lblTenggat = New System.Windows.Forms.Label()
        Me.lblMataKuliah = New System.Windows.Forms.Label()
        Me.lblKeterangan = New System.Windows.Forms.Label()
        Me.lblNamaTugas = New System.Windows.Forms.Label()
        Me.dgvTugas = New System.Windows.Forms.DataGridView()
        Me.txtCari = New System.Windows.Forms.TextBox()
        Me.btnCari = New System.Windows.Forms.Button()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnInputNilai = New System.Windows.Forms.Button()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgvTugas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
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
        Me.cmbMataKuliah.Location = New System.Drawing.Point(507, 62)
        Me.cmbMataKuliah.Name = "cmbMataKuliah"
        Me.cmbMataKuliah.Size = New System.Drawing.Size(237, 23)
        Me.cmbMataKuliah.TabIndex = 3
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.txtKeterangan)
        Me.Panel3.Controls.Add(Me.txtNama)
        Me.Panel3.Location = New System.Drawing.Point(12, 109)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(387, 131)
        Me.Panel3.TabIndex = 39
        '
        'txtKeterangan
        '
        Me.txtKeterangan.BackColor = System.Drawing.Color.White
        Me.txtKeterangan.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtKeterangan.Location = New System.Drawing.Point(7, 2)
        Me.txtKeterangan.Multiline = True
        Me.txtKeterangan.Name = "txtKeterangan"
        Me.txtKeterangan.Size = New System.Drawing.Size(377, 126)
        Me.txtKeterangan.TabIndex = 3
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
        Me.Panel2.Controls.Add(Me.txtNamaTugas)
        Me.Panel2.Location = New System.Drawing.Point(12, 63)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(387, 21)
        Me.Panel2.TabIndex = 38
        '
        'txtNamaTugas
        '
        Me.txtNamaTugas.BackColor = System.Drawing.Color.White
        Me.txtNamaTugas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNamaTugas.Location = New System.Drawing.Point(7, 2)
        Me.txtNamaTugas.Name = "txtNamaTugas"
        Me.txtNamaTugas.Size = New System.Drawing.Size(377, 15)
        Me.txtNamaTugas.TabIndex = 3
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
        'dtpTenggat
        '
        Me.dtpTenggat.CalendarForeColor = System.Drawing.Color.Black
        Me.dtpTenggat.CalendarMonthBackground = System.Drawing.Color.White
        Me.dtpTenggat.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpTenggat.Location = New System.Drawing.Point(507, 111)
        Me.dtpTenggat.Name = "dtpTenggat"
        Me.dtpTenggat.Size = New System.Drawing.Size(237, 22)
        Me.dtpTenggat.TabIndex = 3
        '
        'lblTenggat
        '
        Me.lblTenggat.AutoSize = True
        Me.lblTenggat.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTenggat.Location = New System.Drawing.Point(504, 95)
        Me.lblTenggat.Name = "lblTenggat"
        Me.lblTenggat.Size = New System.Drawing.Size(48, 13)
        Me.lblTenggat.TabIndex = 2
        Me.lblTenggat.Text = "Tenggat"
        '
        'lblMataKuliah
        '
        Me.lblMataKuliah.AutoSize = True
        Me.lblMataKuliah.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMataKuliah.Location = New System.Drawing.Point(504, 46)
        Me.lblMataKuliah.Name = "lblMataKuliah"
        Me.lblMataKuliah.Size = New System.Drawing.Size(68, 13)
        Me.lblMataKuliah.TabIndex = 2
        Me.lblMataKuliah.Text = "Mata Kuliah"
        '
        'lblKeterangan
        '
        Me.lblKeterangan.AutoSize = True
        Me.lblKeterangan.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKeterangan.Location = New System.Drawing.Point(9, 93)
        Me.lblKeterangan.Name = "lblKeterangan"
        Me.lblKeterangan.Size = New System.Drawing.Size(66, 13)
        Me.lblKeterangan.TabIndex = 2
        Me.lblKeterangan.Text = "Keterangan"
        '
        'lblNamaTugas
        '
        Me.lblNamaTugas.AutoSize = True
        Me.lblNamaTugas.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNamaTugas.Location = New System.Drawing.Point(9, 44)
        Me.lblNamaTugas.Name = "lblNamaTugas"
        Me.lblNamaTugas.Size = New System.Drawing.Size(69, 13)
        Me.lblNamaTugas.TabIndex = 2
        Me.lblNamaTugas.Text = "Nama Tugas"
        '
        'dgvTugas
        '
        Me.dgvTugas.AllowUserToAddRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.dgvTugas.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvTugas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvTugas.BackgroundColor = System.Drawing.Color.White
        Me.dgvTugas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvTugas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvTugas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvTugas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvTugas.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvTugas.GridColor = System.Drawing.Color.LightGray
        Me.dgvTugas.Location = New System.Drawing.Point(17, 343)
        Me.dgvTugas.MultiSelect = False
        Me.dgvTugas.Name = "dgvTugas"
        Me.dgvTugas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvTugas.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        Me.dgvTugas.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvTugas.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White
        Me.dgvTugas.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvTugas.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvTugas.RowTemplate.Height = 25
        Me.dgvTugas.Size = New System.Drawing.Size(747, 190)
        Me.dgvTugas.TabIndex = 47
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
        Me.btnCari.Location = New System.Drawing.Point(232, 313)
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
        Me.Panel6.Location = New System.Drawing.Point(17, 314)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(200, 23)
        Me.Panel6.TabIndex = 49
        '
        'Panel1
        '
        Me.Panel1.AllowDrop = True
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.Controls.Add(Me.cmbMataKuliah)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.btnHapus)
        Me.Panel1.Controls.Add(Me.btnEdit)
        Me.Panel1.Controls.Add(Me.btnTambah)
        Me.Panel1.Controls.Add(Me.dtpTenggat)
        Me.Panel1.Controls.Add(Me.lblTenggat)
        Me.Panel1.Controls.Add(Me.lblMataKuliah)
        Me.Panel1.Controls.Add(Me.lblKeterangan)
        Me.Panel1.Controls.Add(Me.lblNamaTugas)
        Me.Panel1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.ForeColor = System.Drawing.Color.Black
        Me.Panel1.ImeMode = System.Windows.Forms.ImeMode.Hiragana
        Me.Panel1.Location = New System.Drawing.Point(17, 18)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(747, 277)
        Me.Panel1.TabIndex = 48
        '
        'btnInputNilai
        '
        Me.btnInputNilai.BackColor = System.Drawing.Color.ForestGreen
        Me.btnInputNilai.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInputNilai.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInputNilai.ForeColor = System.Drawing.Color.White
        Me.btnInputNilai.Location = New System.Drawing.Point(676, 314)
        Me.btnInputNilai.Name = "btnInputNilai"
        Me.btnInputNilai.Size = New System.Drawing.Size(85, 24)
        Me.btnInputNilai.TabIndex = 40
        Me.btnInputNilai.Text = "Input Nilai"
        Me.btnInputNilai.UseVisualStyleBackColor = False
        '
        'TugasControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btnInputNilai)
        Me.Controls.Add(Me.dgvTugas)
        Me.Controls.Add(Me.btnCari)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "TugasControl"
        Me.Size = New System.Drawing.Size(780, 550)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.dgvTugas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cmbMataKuliah As ComboBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txtKeterangan As TextBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtNamaTugas As TextBox
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnTambah As Button
    Friend WithEvents dtpTenggat As DateTimePicker
    Friend WithEvents lblTenggat As Label
    Friend WithEvents lblMataKuliah As Label
    Friend WithEvents lblKeterangan As Label
    Friend WithEvents lblNamaTugas As Label
    Friend WithEvents dgvTugas As DataGridView
    Friend WithEvents txtCari As TextBox
    Friend WithEvents btnCari As Button
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnInputNilai As Button
End Class
