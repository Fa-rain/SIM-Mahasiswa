<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MataKuliahControl
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
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.txtKodeMK = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtNamaMK = New System.Windows.Forms.TextBox()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.cmbJurusan = New System.Windows.Forms.ComboBox()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.lblJurusan = New System.Windows.Forms.Label()
        Me.lblKodeMK = New System.Windows.Forms.Label()
        Me.lblNamaMK = New System.Windows.Forms.Label()
        Me.dgvMataKuliah = New System.Windows.Forms.DataGridView()
        Me.txtCari = New System.Windows.Forms.TextBox()
        Me.btnCari = New System.Windows.Forms.Button()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgvMataKuliah, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.Controls.Add(Me.txtKodeMK)
        Me.Panel4.Location = New System.Drawing.Point(0, 121)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(399, 21)
        Me.Panel4.TabIndex = 40
        '
        'txtKodeMK
        '
        Me.txtKodeMK.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtKodeMK.Location = New System.Drawing.Point(7, 2)
        Me.txtKodeMK.Name = "txtKodeMK"
        Me.txtKodeMK.Size = New System.Drawing.Size(377, 15)
        Me.txtKodeMK.TabIndex = 3
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.txtNamaMK)
        Me.Panel2.Location = New System.Drawing.Point(0, 63)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(399, 21)
        Me.Panel2.TabIndex = 38
        '
        'txtNamaMK
        '
        Me.txtNamaMK.BackColor = System.Drawing.Color.White
        Me.txtNamaMK.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNamaMK.Location = New System.Drawing.Point(7, 2)
        Me.txtNamaMK.Name = "txtNamaMK"
        Me.txtNamaMK.Size = New System.Drawing.Size(377, 15)
        Me.txtNamaMK.TabIndex = 3
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
        'cmbJurusan
        '
        Me.cmbJurusan.AllowDrop = True
        Me.cmbJurusan.BackColor = System.Drawing.Color.White
        Me.cmbJurusan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbJurusan.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbJurusan.FormattingEnabled = True
        Me.cmbJurusan.Location = New System.Drawing.Point(507, 63)
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
        'lblJurusan
        '
        Me.lblJurusan.AutoSize = True
        Me.lblJurusan.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJurusan.Location = New System.Drawing.Point(504, 47)
        Me.lblJurusan.Name = "lblJurusan"
        Me.lblJurusan.Size = New System.Drawing.Size(47, 13)
        Me.lblJurusan.TabIndex = 2
        Me.lblJurusan.Text = "Jurusan"
        '
        'lblKodeMK
        '
        Me.lblKodeMK.AutoSize = True
        Me.lblKodeMK.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKodeMK.Location = New System.Drawing.Point(4, 105)
        Me.lblKodeMK.Name = "lblKodeMK"
        Me.lblKodeMK.Size = New System.Drawing.Size(97, 13)
        Me.lblKodeMK.TabIndex = 2
        Me.lblKodeMK.Text = "Kode Mata Kuliah"
        '
        'lblNamaMK
        '
        Me.lblNamaMK.AutoSize = True
        Me.lblNamaMK.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNamaMK.Location = New System.Drawing.Point(4, 44)
        Me.lblNamaMK.Name = "lblNamaMK"
        Me.lblNamaMK.Size = New System.Drawing.Size(100, 13)
        Me.lblNamaMK.TabIndex = 2
        Me.lblNamaMK.Text = "Nama Mata Kuliah"
        '
        'dgvMataKuliah
        '
        Me.dgvMataKuliah.AllowUserToAddRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.dgvMataKuliah.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvMataKuliah.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvMataKuliah.BackgroundColor = System.Drawing.Color.White
        Me.dgvMataKuliah.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvMataKuliah.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvMataKuliah.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvMataKuliah.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvMataKuliah.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvMataKuliah.GridColor = System.Drawing.Color.LightGray
        Me.dgvMataKuliah.Location = New System.Drawing.Point(17, 314)
        Me.dgvMataKuliah.MultiSelect = False
        Me.dgvMataKuliah.Name = "dgvMataKuliah"
        Me.dgvMataKuliah.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvMataKuliah.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        Me.dgvMataKuliah.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvMataKuliah.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White
        Me.dgvMataKuliah.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvMataKuliah.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvMataKuliah.RowTemplate.Height = 25
        Me.dgvMataKuliah.Size = New System.Drawing.Size(747, 190)
        Me.dgvMataKuliah.TabIndex = 47
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
        Me.btnCari.Location = New System.Drawing.Point(348, 284)
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
        Me.Panel6.Location = New System.Drawing.Point(17, 285)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(325, 23)
        Me.Panel6.TabIndex = 49
        '
        'Panel1
        '
        Me.Panel1.AllowDrop = True
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.btnHapus)
        Me.Panel1.Controls.Add(Me.btnEdit)
        Me.Panel1.Controls.Add(Me.cmbJurusan)
        Me.Panel1.Controls.Add(Me.btnTambah)
        Me.Panel1.Controls.Add(Me.lblJurusan)
        Me.Panel1.Controls.Add(Me.lblKodeMK)
        Me.Panel1.Controls.Add(Me.lblNamaMK)
        Me.Panel1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.ForeColor = System.Drawing.Color.Black
        Me.Panel1.ImeMode = System.Windows.Forms.ImeMode.Hiragana
        Me.Panel1.Location = New System.Drawing.Point(17, 18)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(747, 256)
        Me.Panel1.TabIndex = 48
        '
        'MataKuliahControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.dgvMataKuliah)
        Me.Controls.Add(Me.btnCari)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "MataKuliahControl"
        Me.Size = New System.Drawing.Size(780, 550)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.dgvMataKuliah, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel4 As Panel
    Friend WithEvents txtKodeMK As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtNamaMK As TextBox
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents cmbJurusan As ComboBox
    Friend WithEvents btnTambah As Button
    Friend WithEvents lblJurusan As Label
    Friend WithEvents lblKodeMK As Label
    Friend WithEvents lblNamaMK As Label
    Friend WithEvents dgvMataKuliah As DataGridView
    Friend WithEvents txtCari As TextBox
    Friend WithEvents btnCari As Button
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel1 As Panel
End Class
