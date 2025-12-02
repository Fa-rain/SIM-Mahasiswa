<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HomeControl
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
        Dim btnLogout As System.Windows.Forms.Button
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HomeControl))
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblStaff = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblMahasiswa = New System.Windows.Forms.Label()
        Me.lblRuangan = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblDosen = New System.Windows.Forms.Label()
        Me.lblMataKuliah = New System.Windows.Forms.Label()
        Me.lblJurusan = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.panel = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        btnLogout = New System.Windows.Forms.Button()
        Me.panel.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnLogout
        '
        btnLogout.BackColor = System.Drawing.Color.White
        btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        btnLogout.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        btnLogout.ForeColor = System.Drawing.Color.SteelBlue
        btnLogout.Location = New System.Drawing.Point(686, 8)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New System.Drawing.Size(75, 31)
        btnLogout.TabIndex = 15
        btnLogout.Text = "Logout"
        btnLogout.UseVisualStyleBackColor = False
        AddHandler btnLogout.Click, AddressOf Me.btnLogout_Click_1
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label11.Location = New System.Drawing.Point(657, 100)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(46, 21)
        Me.Label11.TabIndex = 7
        Me.Label11.Text = "Staff"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label2.Location = New System.Drawing.Point(15, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 21)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Mahasiswa"
        '
        'lblStaff
        '
        Me.lblStaff.AutoSize = True
        Me.lblStaff.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStaff.ForeColor = System.Drawing.Color.CadetBlue
        Me.lblStaff.Location = New System.Drawing.Point(640, 34)
        Me.lblStaff.Name = "lblStaff"
        Me.lblStaff.Size = New System.Drawing.Size(73, 73)
        Me.lblStaff.TabIndex = 0
        Me.lblStaff.Text = "32"
        Me.lblStaff.UseCompatibleTextRendering = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label9.Location = New System.Drawing.Point(522, 100)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(78, 21)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Ruangan"
        '
        'lblMahasiswa
        '
        Me.lblMahasiswa.AutoSize = True
        Me.lblMahasiswa.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMahasiswa.ForeColor = System.Drawing.Color.CadetBlue
        Me.lblMahasiswa.Location = New System.Drawing.Point(25, 34)
        Me.lblMahasiswa.Name = "lblMahasiswa"
        Me.lblMahasiswa.Size = New System.Drawing.Size(73, 73)
        Me.lblMahasiswa.TabIndex = 0
        Me.lblMahasiswa.Text = "32"
        Me.lblMahasiswa.UseCompatibleTextRendering = True
        '
        'lblRuangan
        '
        Me.lblRuangan.AutoSize = True
        Me.lblRuangan.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRuangan.ForeColor = System.Drawing.Color.CadetBlue
        Me.lblRuangan.Location = New System.Drawing.Point(517, 34)
        Me.lblRuangan.Name = "lblRuangan"
        Me.lblRuangan.Size = New System.Drawing.Size(73, 73)
        Me.lblRuangan.TabIndex = 0
        Me.lblRuangan.Text = "32"
        Me.lblRuangan.UseCompatibleTextRendering = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label3.Location = New System.Drawing.Point(157, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 21)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Dosen"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label7.Location = New System.Drawing.Point(385, 101)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(93, 20)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Mata Kuliah"
        '
        'lblDosen
        '
        Me.lblDosen.AutoSize = True
        Me.lblDosen.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDosen.ForeColor = System.Drawing.Color.CadetBlue
        Me.lblDosen.Location = New System.Drawing.Point(148, 34)
        Me.lblDosen.Name = "lblDosen"
        Me.lblDosen.Size = New System.Drawing.Size(73, 73)
        Me.lblDosen.TabIndex = 0
        Me.lblDosen.Text = "32"
        Me.lblDosen.UseCompatibleTextRendering = True
        '
        'lblMataKuliah
        '
        Me.lblMataKuliah.AutoSize = True
        Me.lblMataKuliah.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMataKuliah.ForeColor = System.Drawing.Color.CadetBlue
        Me.lblMataKuliah.Location = New System.Drawing.Point(394, 34)
        Me.lblMataKuliah.Name = "lblMataKuliah"
        Me.lblMataKuliah.Size = New System.Drawing.Size(73, 73)
        Me.lblMataKuliah.TabIndex = 0
        Me.lblMataKuliah.Text = "32"
        Me.lblMataKuliah.UseCompatibleTextRendering = True
        '
        'lblJurusan
        '
        Me.lblJurusan.AutoSize = True
        Me.lblJurusan.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJurusan.ForeColor = System.Drawing.Color.CadetBlue
        Me.lblJurusan.Location = New System.Drawing.Point(271, 34)
        Me.lblJurusan.Name = "lblJurusan"
        Me.lblJurusan.Size = New System.Drawing.Size(73, 73)
        Me.lblJurusan.TabIndex = 0
        Me.lblJurusan.Text = "32"
        Me.lblJurusan.UseCompatibleTextRendering = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label5.Location = New System.Drawing.Point(275, 100)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 21)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Jurusan"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Black", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label1.Location = New System.Drawing.Point(25, 96)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(258, 40)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "SIM - Mahasiswa"
        '
        'Label4
        '
        Me.Label4.AllowDrop = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.CadetBlue
        Me.Label4.Location = New System.Drawing.Point(30, 155)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(493, 62)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = resources.GetString("Label4.Text")
        '
        'panel
        '
        Me.panel.BackColor = System.Drawing.Color.WhiteSmoke
        Me.panel.Controls.Add(Me.Panel2)
        Me.panel.Controls.Add(Me.Label6)
        Me.panel.Controls.Add(Me.Label1)
        Me.panel.Controls.Add(Me.Label4)
        Me.panel.Controls.Add(Me.Panel1)
        Me.panel.Location = New System.Drawing.Point(0, 0)
        Me.panel.Name = "panel"
        Me.panel.Size = New System.Drawing.Size(780, 550)
        Me.panel.TabIndex = 14
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(btnLogout)
        Me.Panel2.Controls.Add(Me.lblWelcome)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Location = New System.Drawing.Point(1, 1)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(779, 45)
        Me.Panel2.TabIndex = 16
        '
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.ForeColor = System.Drawing.Color.SteelBlue
        Me.lblWelcome.Location = New System.Drawing.Point(85, 12)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(138, 21)
        Me.lblWelcome.TabIndex = 0
        Me.lblWelcome.Text = "Selamat datang, "
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(32, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(35, 35)
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Black", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label6.Location = New System.Drawing.Point(26, 304)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(135, 40)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Statistik"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.lblStaff)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.lblMahasiswa)
        Me.Panel1.Controls.Add(Me.lblRuangan)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.lblDosen)
        Me.Panel1.Controls.Add(Me.lblMataKuliah)
        Me.Panel1.Controls.Add(Me.lblJurusan)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Location = New System.Drawing.Point(29, 347)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(733, 168)
        Me.Panel1.TabIndex = 1
        '
        'HomeControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.panel)
        Me.Name = "HomeControl"
        Me.Size = New System.Drawing.Size(780, 550)
        Me.panel.ResumeLayout(False)
        Me.panel.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label11 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblStaff As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lblMahasiswa As Label
    Friend WithEvents lblRuangan As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblDosen As Label
    Friend WithEvents lblMataKuliah As Label
    Friend WithEvents lblJurusan As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents panel As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblWelcome As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel2 As Panel
End Class
