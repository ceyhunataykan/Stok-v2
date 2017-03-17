<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StokKartDuzenle
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StokKartDuzenle))
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btnAc = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.nudTSeviye = New System.Windows.Forms.NumericUpDown()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.nudMiktar = New System.Windows.Forms.NumericUpDown()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblUrunID = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSk = New System.Windows.Forms.TextBox()
        Me.txtStokAdi = New System.Windows.Forms.TextBox()
        Me.cmbKategori = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtBarkod = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cmbBirim = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cmbDepo = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtAlisFiyati = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtSatisFiyati = New System.Windows.Forms.TextBox()
        Me.txtKdv = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ckbAktif = New System.Windows.Forms.CheckBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnIptal = New DevExpress.XtraEditors.SimpleButton()
        Me.btnKaydet = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudTSeviye, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudMiktar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'btnAc
        '
        Me.btnAc.Appearance.ForeColor = System.Drawing.Color.Black
        Me.btnAc.Appearance.Options.UseForeColor = True
        Me.btnAc.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.btnAc.Image = CType(resources.GetObject("btnAc.Image"), System.Drawing.Image)
        Me.btnAc.Location = New System.Drawing.Point(15, 257)
        Me.btnAc.Name = "btnAc"
        Me.btnAc.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnAc.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[False]
        Me.btnAc.Size = New System.Drawing.Size(50, 26)
        Me.btnAc.TabIndex = 47
        Me.btnAc.Text = "Aç"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnAc)
        Me.GroupBox2.Controls.Add(Me.SimpleButton1)
        Me.GroupBox2.Controls.Add(Me.PictureBox1)
        Me.GroupBox2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.DimGray
        Me.GroupBox2.Location = New System.Drawing.Point(514, 44)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(343, 308)
        Me.GroupBox2.TabIndex = 51
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Ürün Resmi"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Appearance.ForeColor = System.Drawing.Color.Black
        Me.SimpleButton1.Appearance.Options.UseForeColor = True
        Me.SimpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(277, 257)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.SimpleButton1.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[False]
        Me.SimpleButton1.Size = New System.Drawing.Size(50, 26)
        Me.SimpleButton1.TabIndex = 46
        Me.SimpleButton1.Text = "Sil"
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(15, 24)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(312, 218)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 44
        Me.PictureBox1.TabStop = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.DimGray
        Me.Label16.Location = New System.Drawing.Point(55, 59)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(42, 13)
        Me.Label16.TabIndex = 43
        Me.Label16.Text = "Tarih :"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(103, 53)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(141, 21)
        Me.DateTimePicker1.TabIndex = 42
        '
        'nudTSeviye
        '
        Me.nudTSeviye.Location = New System.Drawing.Point(103, 242)
        Me.nudTSeviye.Name = "nudTSeviye"
        Me.nudTSeviye.Size = New System.Drawing.Size(88, 21)
        Me.nudTSeviye.TabIndex = 41
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.DimGray
        Me.Label15.Location = New System.Drawing.Point(46, 190)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(50, 13)
        Me.Label15.TabIndex = 40
        Me.Label15.Text = "Miktar :"
        '
        'nudMiktar
        '
        Me.nudMiktar.Location = New System.Drawing.Point(102, 188)
        Me.nudMiktar.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.nudMiktar.Name = "nudMiktar"
        Me.nudMiktar.Size = New System.Drawing.Size(88, 21)
        Me.nudMiktar.TabIndex = 39
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblUrunID)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.nudTSeviye)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.nudMiktar)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtSk)
        Me.GroupBox1.Controls.Add(Me.txtStokAdi)
        Me.GroupBox1.Controls.Add(Me.cmbKategori)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.txtBarkod)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.cmbBirim)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.cmbDepo)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtAlisFiyati)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtSatisFiyati)
        Me.GroupBox1.Controls.Add(Me.txtKdv)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.ckbAktif)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.DimGray
        Me.GroupBox1.Location = New System.Drawing.Point(12, 37)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(485, 315)
        Me.GroupBox1.TabIndex = 50
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ürün Bilgileri"
        '
        'lblUrunID
        '
        Me.lblUrunID.AutoSize = True
        Me.lblUrunID.Location = New System.Drawing.Point(429, 17)
        Me.lblUrunID.Name = "lblUrunID"
        Me.lblUrunID.Size = New System.Drawing.Size(50, 13)
        Me.lblUrunID.TabIndex = 44
        Me.lblUrunID.Text = "Urun ID"
        Me.lblUrunID.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(26, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Stok Kodu :"
        '
        'txtSk
        '
        Me.txtSk.Location = New System.Drawing.Point(102, 80)
        Me.txtSk.Name = "txtSk"
        Me.txtSk.Size = New System.Drawing.Size(142, 21)
        Me.txtSk.TabIndex = 7
        '
        'txtStokAdi
        '
        Me.txtStokAdi.Location = New System.Drawing.Point(102, 134)
        Me.txtStokAdi.Name = "txtStokAdi"
        Me.txtStokAdi.Size = New System.Drawing.Size(142, 21)
        Me.txtStokAdi.TabIndex = 9
        '
        'cmbKategori
        '
        Me.cmbKategori.FormattingEnabled = True
        Me.cmbKategori.Location = New System.Drawing.Point(102, 161)
        Me.cmbKategori.Name = "cmbKategori"
        Me.cmbKategori.Size = New System.Drawing.Size(121, 21)
        Me.cmbKategori.TabIndex = 38
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(36, 137)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Stok Adı :"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.DimGray
        Me.Label14.Location = New System.Drawing.Point(35, 164)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(61, 13)
        Me.Label14.TabIndex = 37
        Me.Label14.Text = "Kategori :"
        '
        'txtBarkod
        '
        Me.txtBarkod.Location = New System.Drawing.Point(102, 107)
        Me.txtBarkod.Name = "txtBarkod"
        Me.txtBarkod.Size = New System.Drawing.Size(142, 21)
        Me.txtBarkod.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DimGray
        Me.Label3.Location = New System.Drawing.Point(43, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Barkod :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DimGray
        Me.Label4.Location = New System.Drawing.Point(24, 218)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Ölçü Birimi :"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.DimGray
        Me.Label13.Location = New System.Drawing.Point(441, 273)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(20, 13)
        Me.Label13.TabIndex = 33
        Me.Label13.Text = "TL"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DimGray
        Me.Label5.Location = New System.Drawing.Point(294, 217)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Depo :"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.DimGray
        Me.Label12.Location = New System.Drawing.Point(197, 272)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(20, 13)
        Me.Label12.TabIndex = 32
        Me.Label12.Text = "TL"
        '
        'cmbBirim
        '
        Me.cmbBirim.FormattingEnabled = True
        Me.cmbBirim.Location = New System.Drawing.Point(102, 215)
        Me.cmbBirim.Name = "cmbBirim"
        Me.cmbBirim.Size = New System.Drawing.Size(121, 21)
        Me.cmbBirim.TabIndex = 17
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.DimGray
        Me.Label11.Location = New System.Drawing.Point(393, 246)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(20, 13)
        Me.Label11.TabIndex = 31
        Me.Label11.Text = "%"
        '
        'cmbDepo
        '
        Me.cmbDepo.FormattingEnabled = True
        Me.cmbDepo.Location = New System.Drawing.Point(342, 215)
        Me.cmbDepo.Name = "cmbDepo"
        Me.cmbDepo.Size = New System.Drawing.Size(121, 21)
        Me.cmbDepo.TabIndex = 18
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.DimGray
        Me.Label10.Location = New System.Drawing.Point(57, 32)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(40, 13)
        Me.Label10.TabIndex = 30
        Me.Label10.Text = "Aktif :"
        '
        'txtAlisFiyati
        '
        Me.txtAlisFiyati.Location = New System.Drawing.Point(102, 269)
        Me.txtAlisFiyati.Name = "txtAlisFiyati"
        Me.txtAlisFiyati.Size = New System.Drawing.Size(89, 21)
        Me.txtAlisFiyati.TabIndex = 19
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DimGray
        Me.Label6.Location = New System.Drawing.Point(29, 272)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 13)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Alış Fiyatı :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DimGray
        Me.Label8.Location = New System.Drawing.Point(302, 246)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(34, 13)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "Kdv :"
        '
        'txtSatisFiyati
        '
        Me.txtSatisFiyati.Location = New System.Drawing.Point(342, 270)
        Me.txtSatisFiyati.Name = "txtSatisFiyati"
        Me.txtSatisFiyati.Size = New System.Drawing.Size(93, 21)
        Me.txtSatisFiyati.TabIndex = 21
        '
        'txtKdv
        '
        Me.txtKdv.Location = New System.Drawing.Point(342, 243)
        Me.txtKdv.Name = "txtKdv"
        Me.txtKdv.Size = New System.Drawing.Size(45, 21)
        Me.txtKdv.TabIndex = 26
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DimGray
        Me.Label7.Location = New System.Drawing.Point(261, 273)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 13)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Satış Fiyatı :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.DimGray
        Me.Label9.Location = New System.Drawing.Point(11, 244)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(85, 13)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "Takip Seviye :"
        '
        'ckbAktif
        '
        Me.ckbAktif.AutoSize = True
        Me.ckbAktif.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.ckbAktif.ForeColor = System.Drawing.Color.LightGray
        Me.ckbAktif.Location = New System.Drawing.Point(103, 32)
        Me.ckbAktif.Name = "ckbAktif"
        Me.ckbAktif.Size = New System.Drawing.Size(15, 14)
        Me.ckbAktif.TabIndex = 23
        Me.ckbAktif.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DimGray
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 415)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(869, 28)
        Me.Panel1.TabIndex = 49
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DimGray
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(869, 28)
        Me.Panel2.TabIndex = 48
        '
        'btnIptal
        '
        Me.btnIptal.Appearance.ForeColor = System.Drawing.Color.Black
        Me.btnIptal.Appearance.Options.UseForeColor = True
        Me.btnIptal.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.btnIptal.Image = CType(resources.GetObject("btnIptal.Image"), System.Drawing.Image)
        Me.btnIptal.Location = New System.Drawing.Point(444, 371)
        Me.btnIptal.Name = "btnIptal"
        Me.btnIptal.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnIptal.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[False]
        Me.btnIptal.Size = New System.Drawing.Size(85, 26)
        Me.btnIptal.TabIndex = 47
        Me.btnIptal.Text = "İptal"
        '
        'btnKaydet
        '
        Me.btnKaydet.Appearance.ForeColor = System.Drawing.Color.Black
        Me.btnKaydet.Appearance.Options.UseForeColor = True
        Me.btnKaydet.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.btnKaydet.Image = CType(resources.GetObject("btnKaydet.Image"), System.Drawing.Image)
        Me.btnKaydet.Location = New System.Drawing.Point(353, 371)
        Me.btnKaydet.Name = "btnKaydet"
        Me.btnKaydet.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnKaydet.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[False]
        Me.btnKaydet.Size = New System.Drawing.Size(85, 26)
        Me.btnKaydet.TabIndex = 46
        Me.btnKaydet.Text = "Güncelle"
        '
        'StokKartDuzenle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(869, 443)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.btnIptal)
        Me.Controls.Add(Me.btnKaydet)
        Me.Name = "StokKartDuzenle"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stok Kart Düzenle"
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudTSeviye, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudMiktar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents btnAc As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label16 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents nudTSeviye As NumericUpDown
    Friend WithEvents Label15 As Label
    Friend WithEvents nudMiktar As NumericUpDown
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtSk As TextBox
    Friend WithEvents txtStokAdi As TextBox
    Friend WithEvents cmbKategori As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents txtBarkod As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents cmbBirim As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents cmbDepo As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtAlisFiyati As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtSatisFiyati As TextBox
    Friend WithEvents txtKdv As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents ckbAktif As CheckBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnIptal As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnKaydet As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblUrunID As Label
End Class
