<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DepoAktarDuzenle
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DepoAktarDuzenle))
        Me.lblid = New System.Windows.Forms.Label()
        Me.txtBirim = New System.Windows.Forms.TextBox()
        Me.nudMiktar = New System.Windows.Forms.NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btnSil = New DevExpress.XtraEditors.SimpleButton()
        Me.dgFisListe = New System.Windows.Forms.DataGridView()
        Me.txtAciklama = New System.Windows.Forms.TextBox()
        Me.btnIptal = New DevExpress.XtraEditors.SimpleButton()
        Me.txtStokKodu = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnFisDuzenle = New DevExpress.XtraEditors.SimpleButton()
        Me.lblFisId = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpFisTarihi = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtFisNo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbCDepo = New System.Windows.Forms.ComboBox()
        Me.cmbGDepo = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnListeEkle = New DevExpress.XtraEditors.SimpleButton()
        Me.btnStokKart = New DevExpress.XtraEditors.SimpleButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtStokAdi = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.nudMiktar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.dgFisListe, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblid
        '
        Me.lblid.AutoSize = True
        Me.lblid.Location = New System.Drawing.Point(282, 26)
        Me.lblid.Name = "lblid"
        Me.lblid.Size = New System.Drawing.Size(50, 13)
        Me.lblid.TabIndex = 43
        Me.lblid.Text = "Ürün ID"
        Me.lblid.Visible = False
        '
        'txtBirim
        '
        Me.txtBirim.Enabled = False
        Me.txtBirim.Location = New System.Drawing.Point(412, 49)
        Me.txtBirim.Name = "txtBirim"
        Me.txtBirim.Size = New System.Drawing.Size(121, 21)
        Me.txtBirim.TabIndex = 42
        '
        'nudMiktar
        '
        Me.nudMiktar.Location = New System.Drawing.Point(412, 22)
        Me.nudMiktar.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.nudMiktar.Name = "nudMiktar"
        Me.nudMiktar.Size = New System.Drawing.Size(121, 21)
        Me.nudMiktar.TabIndex = 41
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DimGray
        Me.Label5.Location = New System.Drawing.Point(11, 26)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Stok Kodu :"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btnSil)
        Me.GroupBox4.Controls.Add(Me.dgFisListe)
        Me.GroupBox4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.DimGray
        Me.GroupBox4.Location = New System.Drawing.Point(12, 330)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(556, 172)
        Me.GroupBox4.TabIndex = 73
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Fiş Liste"
        '
        'btnSil
        '
        Me.btnSil.Appearance.ForeColor = System.Drawing.Color.Black
        Me.btnSil.Appearance.Options.UseForeColor = True
        Me.btnSil.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.btnSil.Image = CType(resources.GetObject("btnSil.Image"), System.Drawing.Image)
        Me.btnSil.Location = New System.Drawing.Point(457, 133)
        Me.btnSil.Name = "btnSil"
        Me.btnSil.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnSil.Size = New System.Drawing.Size(85, 26)
        Me.btnSil.TabIndex = 15
        Me.btnSil.Text = "Sil"
        '
        'dgFisListe
        '
        Me.dgFisListe.AllowUserToAddRows = False
        Me.dgFisListe.AllowUserToDeleteRows = False
        Me.dgFisListe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgFisListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgFisListe.Location = New System.Drawing.Point(14, 20)
        Me.dgFisListe.Name = "dgFisListe"
        Me.dgFisListe.ReadOnly = True
        Me.dgFisListe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgFisListe.Size = New System.Drawing.Size(528, 107)
        Me.dgFisListe.TabIndex = 0
        '
        'txtAciklama
        '
        Me.txtAciklama.Location = New System.Drawing.Point(87, 76)
        Me.txtAciklama.Multiline = True
        Me.txtAciklama.Name = "txtAciklama"
        Me.txtAciklama.Size = New System.Drawing.Size(193, 66)
        Me.txtAciklama.TabIndex = 0
        '
        'btnIptal
        '
        Me.btnIptal.Appearance.ForeColor = System.Drawing.Color.Black
        Me.btnIptal.Appearance.Options.UseForeColor = True
        Me.btnIptal.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.btnIptal.Image = CType(resources.GetObject("btnIptal.Image"), System.Drawing.Image)
        Me.btnIptal.Location = New System.Drawing.Point(250, 517)
        Me.btnIptal.Name = "btnIptal"
        Me.btnIptal.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnIptal.Size = New System.Drawing.Size(85, 26)
        Me.btnIptal.TabIndex = 68
        Me.btnIptal.Text = "İptal"
        '
        'txtStokKodu
        '
        Me.txtStokKodu.Enabled = False
        Me.txtStokKodu.Location = New System.Drawing.Point(87, 23)
        Me.txtStokKodu.Name = "txtStokKodu"
        Me.txtStokKodu.Size = New System.Drawing.Size(151, 21)
        Me.txtStokKodu.TabIndex = 9
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnFisDuzenle)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.txtAciklama)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.dtpFisTarihi)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtFisNo)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cmbCDepo)
        Me.GroupBox1.Controls.Add(Me.cmbGDepo)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.DimGray
        Me.GroupBox1.Location = New System.Drawing.Point(12, 41)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(556, 160)
        Me.GroupBox1.TabIndex = 71
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Fiş Bilgileri"
        '
        'btnFisDuzenle
        '
        Me.btnFisDuzenle.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.btnFisDuzenle.Image = CType(resources.GetObject("btnFisDuzenle.Image"), System.Drawing.Image)
        Me.btnFisDuzenle.Location = New System.Drawing.Point(448, 119)
        Me.btnFisDuzenle.Name = "btnFisDuzenle"
        Me.btnFisDuzenle.Size = New System.Drawing.Size(102, 23)
        Me.btnFisDuzenle.TabIndex = 48
        Me.btnFisDuzenle.Text = "Fiş Düzenle"
        '
        'lblFisId
        '
        Me.lblFisId.AutoSize = True
        Me.lblFisId.Location = New System.Drawing.Point(267, 31)
        Me.lblFisId.Name = "lblFisId"
        Me.lblFisId.Size = New System.Drawing.Size(31, 13)
        Me.lblFisId.TabIndex = 47
        Me.lblFisId.Text = "fis ID"
        Me.lblFisId.Visible = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.DimGray
        Me.Label15.Location = New System.Drawing.Point(16, 79)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(65, 13)
        Me.Label15.TabIndex = 46
        Me.Label15.Text = "Açıklama :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(18, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Fiş Tarihi :"
        '
        'dtpFisTarihi
        '
        Me.dtpFisTarihi.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFisTarihi.Location = New System.Drawing.Point(87, 22)
        Me.dtpFisTarihi.Name = "dtpFisTarihi"
        Me.dtpFisTarihi.Size = New System.Drawing.Size(151, 21)
        Me.dtpFisTarihi.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(36, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Fiş No :"
        '
        'txtFisNo
        '
        Me.txtFisNo.Location = New System.Drawing.Point(87, 49)
        Me.txtFisNo.Name = "txtFisNo"
        Me.txtFisNo.Size = New System.Drawing.Size(151, 21)
        Me.txtFisNo.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DimGray
        Me.Label3.Location = New System.Drawing.Point(323, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Çıkış Deposu :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DimGray
        Me.Label4.Location = New System.Drawing.Point(323, 52)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Giriş Deposu :"
        '
        'cmbCDepo
        '
        Me.cmbCDepo.FormattingEnabled = True
        Me.cmbCDepo.Location = New System.Drawing.Point(413, 22)
        Me.cmbCDepo.Name = "cmbCDepo"
        Me.cmbCDepo.Size = New System.Drawing.Size(121, 21)
        Me.cmbCDepo.TabIndex = 6
        '
        'cmbGDepo
        '
        Me.cmbGDepo.FormattingEnabled = True
        Me.cmbGDepo.Location = New System.Drawing.Point(413, 49)
        Me.cmbGDepo.Name = "cmbGDepo"
        Me.cmbGDepo.Size = New System.Drawing.Size(121, 21)
        Me.cmbGDepo.TabIndex = 7
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DimGray
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 555)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(581, 28)
        Me.Panel1.TabIndex = 70
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DimGray
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(581, 28)
        Me.Panel2.TabIndex = 69
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnListeEkle)
        Me.GroupBox2.Controls.Add(Me.lblid)
        Me.GroupBox2.Controls.Add(Me.txtBirim)
        Me.GroupBox2.Controls.Add(Me.nudMiktar)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txtStokKodu)
        Me.GroupBox2.Controls.Add(Me.btnStokKart)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtStokAdi)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.DimGray
        Me.GroupBox2.Location = New System.Drawing.Point(12, 207)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(556, 117)
        Me.GroupBox2.TabIndex = 72
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Ürün Bilgileri"
        '
        'btnListeEkle
        '
        Me.btnListeEkle.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.btnListeEkle.Image = CType(resources.GetObject("btnListeEkle.Image"), System.Drawing.Image)
        Me.btnListeEkle.Location = New System.Drawing.Point(405, 87)
        Me.btnListeEkle.Name = "btnListeEkle"
        Me.btnListeEkle.Size = New System.Drawing.Size(145, 23)
        Me.btnListeEkle.TabIndex = 44
        Me.btnListeEkle.Text = "Fiş'e Yeni Ürün Ekle"
        '
        'btnStokKart
        '
        Me.btnStokKart.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.btnStokKart.Appearance.Options.UseBackColor = True
        Me.btnStokKart.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.btnStokKart.Image = CType(resources.GetObject("btnStokKart.Image"), System.Drawing.Image)
        Me.btnStokKart.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnStokKart.Location = New System.Drawing.Point(244, 21)
        Me.btnStokKart.Name = "btnStokKart"
        Me.btnStokKart.Size = New System.Drawing.Size(32, 23)
        Me.btnStokKart.TabIndex = 10
        Me.btnStokKart.Text = "Seç"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DimGray
        Me.Label6.Location = New System.Drawing.Point(21, 52)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Stok Adı :"
        '
        'txtStokAdi
        '
        Me.txtStokAdi.Enabled = False
        Me.txtStokAdi.Location = New System.Drawing.Point(87, 49)
        Me.txtStokAdi.Name = "txtStokAdi"
        Me.txtStokAdi.Size = New System.Drawing.Size(151, 21)
        Me.txtStokAdi.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DimGray
        Me.Label7.Location = New System.Drawing.Point(356, 26)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Miktar :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DimGray
        Me.Label8.Location = New System.Drawing.Point(364, 52)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Birim :"
        '
        'DepoAktarDuzenle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(581, 583)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.lblFisId)
        Me.Controls.Add(Me.btnIptal)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "DepoAktarDuzenle"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Depo Aktarım Fişi Düzenle"
        CType(Me.nudMiktar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.dgFisListe, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblid As Label
    Friend WithEvents txtBirim As TextBox
    Friend WithEvents nudMiktar As NumericUpDown
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents btnSil As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents dgFisListe As DataGridView
    Friend WithEvents txtAciklama As TextBox
    Friend WithEvents btnIptal As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtStokKodu As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dtpFisTarihi As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents txtFisNo As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbCDepo As ComboBox
    Friend WithEvents cmbGDepo As ComboBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnStokKart As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label6 As Label
    Friend WithEvents txtStokAdi As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents lblFisId As Label
    Friend WithEvents btnFisDuzenle As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnListeEkle As DevExpress.XtraEditors.SimpleButton
End Class
