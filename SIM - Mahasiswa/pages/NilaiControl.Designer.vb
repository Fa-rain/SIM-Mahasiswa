<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NilaiControl
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.numNilai = New System.Windows.Forms.NumericUpDown()
        Me.lblNilai = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.txtNamaMahasiswa = New System.Windows.Forms.TextBox()
        Me.lblMahasiswa = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtKeterangan = New System.Windows.Forms.TextBox()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtNamaTugas = New System.Windows.Forms.TextBox()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.lblKeterangan = New System.Windows.Forms.Label()
        Me.lblNamaTugas = New System.Windows.Forms.Label()
        Me.txtCari = New System.Windows.Forms.TextBox()
        Me.dgvNilai = New System.Windows.Forms.DataGridView()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        CType(Me.numNilai, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgvNilai, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCari
        '
        Me.btnCari.BackColor = System.Drawing.Color.SteelBlue
        Me.btnCari.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCari.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCari.ForeColor = System.Drawing.Color.White
        Me.btnCari.Location = New System.Drawing.Point(232, 279)
        Me.btnCari.Name = "btnCari"
        Me.btnCari.Size = New System.Drawing.Size(68, 24)
        Me.btnCari.TabIndex = 54
        Me.btnCari.Text = "Cari"
        Me.btnCari.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.AllowDrop = True
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.Controls.Add(Me.numNilai)
        Me.Panel1.Controls.Add(Me.lblNilai)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.lblMahasiswa)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.btnHapus)
        Me.Panel1.Controls.Add(Me.btnEdit)
        Me.Panel1.Controls.Add(Me.btnTambah)
        Me.Panel1.Controls.Add(Me.lblKeterangan)
        Me.Panel1.Controls.Add(Me.lblNamaTugas)
        Me.Panel1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.ForeColor = System.Drawing.Color.Black
        Me.Panel1.ImeMode = System.Windows.Forms.ImeMode.Hiragana
        Me.Panel1.Location = New System.Drawing.Point(17, 18)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(747, 251)
        Me.Panel1.TabIndex = 52
        '
        'numNilai
        '
        Me.numNilai.Location = New System.Drawing.Point(0, 172)
        Me.numNilai.Name = "numNilai"
        Me.numNilai.Size = New System.Drawing.Size(132, 22)
        Me.numNilai.TabIndex = 43
        '
        'lblNilai
        '
        Me.lblNilai.AutoSize = True
        Me.lblNilai.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNilai.Location = New System.Drawing.Point(4, 154)
        Me.lblNilai.Name = "lblNilai"
        Me.lblNilai.Size = New System.Drawing.Size(30, 13)
        Me.lblNilai.TabIndex = 42
        Me.lblNilai.Text = "Nilai"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.Controls.Add(Me.txtNamaMahasiswa)
        Me.Panel4.Location = New System.Drawing.Point(0, 112)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(399, 21)
        Me.Panel4.TabIndex = 41
        '
        'txtNamaMahasiswa
        '
        Me.txtNamaMahasiswa.BackColor = System.Drawing.Color.White
        Me.txtNamaMahasiswa.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNamaMahasiswa.Location = New System.Drawing.Point(7, 2)
        Me.txtNamaMahasiswa.Name = "txtNamaMahasiswa"
        Me.txtNamaMahasiswa.ReadOnly = True
        Me.txtNamaMahasiswa.Size = New System.Drawing.Size(377, 15)
        Me.txtNamaMahasiswa.TabIndex = 3
        '
        'lblMahasiswa
        '
        Me.lblMahasiswa.AutoSize = True
        Me.lblMahasiswa.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMahasiswa.Location = New System.Drawing.Point(4, 93)
        Me.lblMahasiswa.Name = "lblMahasiswa"
        Me.lblMahasiswa.Size = New System.Drawing.Size(96, 13)
        Me.lblMahasiswa.TabIndex = 40
        Me.lblMahasiswa.Text = "Nama Mahasiswa"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.txtKeterangan)
        Me.Panel3.Controls.Add(Me.txtNama)
        Me.Panel3.Location = New System.Drawing.Point(507, 63)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(237, 131)
        Me.Panel3.TabIndex = 39
        '
        'txtKeterangan
        '
        Me.txtKeterangan.BackColor = System.Drawing.Color.White
        Me.txtKeterangan.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtKeterangan.Location = New System.Drawing.Point(7, 2)
        Me.txtKeterangan.Multiline = True
        Me.txtKeterangan.Name = "txtKeterangan"
        Me.txtKeterangan.Size = New System.Drawing.Size(227, 126)
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
        Me.Panel2.Location = New System.Drawing.Point(0, 63)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(399, 21)
        Me.Panel2.TabIndex = 38
        '
        'txtNamaTugas
        '
        Me.txtNamaTugas.BackColor = System.Drawing.Color.White
        Me.txtNamaTugas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNamaTugas.Location = New System.Drawing.Point(7, 2)
        Me.txtNamaTugas.Name = "txtNamaTugas"
        Me.txtNamaTugas.ReadOnly = True
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
        'lblKeterangan
        '
        Me.lblKeterangan.AutoSize = True
        Me.lblKeterangan.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKeterangan.Location = New System.Drawing.Point(504, 47)
        Me.lblKeterangan.Name = "lblKeterangan"
        Me.lblKeterangan.Size = New System.Drawing.Size(66, 13)
        Me.lblKeterangan.TabIndex = 2
        Me.lblKeterangan.Text = "Keterangan"
        '
        'lblNamaTugas
        '
        Me.lblNamaTugas.AutoSize = True
        Me.lblNamaTugas.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNamaTugas.Location = New System.Drawing.Point(4, 44)
        Me.lblNamaTugas.Name = "lblNamaTugas"
        Me.lblNamaTugas.Size = New System.Drawing.Size(69, 13)
        Me.lblNamaTugas.TabIndex = 2
        Me.lblNamaTugas.Text = "Nama Tugas"
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
        'dgvNilai
        '
        Me.dgvNilai.AllowUserToAddRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.dgvNilai.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvNilai.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvNilai.BackgroundColor = System.Drawing.Color.White
        Me.dgvNilai.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvNilai.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvNilai.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvNilai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvNilai.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvNilai.GridColor = System.Drawing.Color.LightGray
        Me.dgvNilai.Location = New System.Drawing.Point(17, 309)
        Me.dgvNilai.MultiSelect = False
        Me.dgvNilai.Name = "dgvNilai"
        Me.dgvNilai.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvNilai.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        Me.dgvNilai.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvNilai.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White
        Me.dgvNilai.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvNilai.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvNilai.RowTemplate.Height = 25
        Me.dgvNilai.Size = New System.Drawing.Size(747, 224)
        Me.dgvNilai.TabIndex = 51
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.White
        Me.Panel6.Controls.Add(Me.txtCari)
        Me.Panel6.Location = New System.Drawing.Point(17, 280)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(200, 23)
        Me.Panel6.TabIndex = 53
        '
        'NilaiControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btnCari)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dgvNilai)
        Me.Controls.Add(Me.Panel6)
        Me.Name = "NilaiControl"
        Me.Size = New System.Drawing.Size(780, 550)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.numNilai, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.dgvNilai, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnCari As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txtKeterangan As TextBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtNamaTugas As TextBox
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnTambah As Button
    Friend WithEvents lblKeterangan As Label
    Friend WithEvents lblNamaTugas As Label
    Friend WithEvents txtCari As TextBox
    Friend WithEvents dgvNilai As DataGridView
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents txtNamaMahasiswa As TextBox
    Friend WithEvents lblMahasiswa As Label
    Friend WithEvents numNilai As NumericUpDown
    Friend WithEvents lblNilai As Label
End Class
