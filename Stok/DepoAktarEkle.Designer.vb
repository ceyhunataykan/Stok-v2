<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DepoAktarEkle
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DepoAktarEkle))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpFisTarihi = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtFisNo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbCDepo = New System.Windows.Forms.ComboBox()
        Me.cmbGDepo = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblid = New System.Windows.Forms.Label()
        Me.txtBirim = New System.Windows.Forms.TextBox()
        Me.nudMiktar = New System.Windows.Forms.NumericUpDown()
        Me.btnListeEkle = New DevExpress.XtraEditors.SimpleButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtStokKodu = New System.Windows.Forms.TextBox()
        Me.btnStokKart = New DevExpress.XtraEditors.SimpleButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtStokAdi = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btnSil = New DevExpress.XtraEditors.SimpleButton()
        Me.dgFisListe = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtAciklama = New System.Windows.Forms.TextBox()
        Me.btnIptal = New DevExpress.XtraEditors.SimpleButton()
        Me.btnKaydet = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.nudMiktar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.dgFisListe, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DimGray
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 586)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(581, 28)
        Me.Panel1.TabIndex = 62
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DimGray
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(581, 28)
        Me.Panel2.TabIndex = 61
        '
        'GroupBox1
        '
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
        Me.GroupBox1.Size = New System.Drawing.Size(556, 84)
        Me.GroupBox1.TabIndex = 63
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Fiş Bilgileri"
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
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblid)
        Me.GroupBox2.Controls.Add(Me.txtBirim)
        Me.GroupBox2.Controls.Add(Me.nudMiktar)
        Me.GroupBox2.Controls.Add(Me.btnListeEkle)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txtStokKodu)
        Me.GroupBox2.Controls.Add(Me.btnStokKart)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtStokAdi)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.DimGray
        Me.GroupBox2.Location = New System.Drawing.Point(13, 131)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(556, 122)
        Me.GroupBox2.TabIndex = 64
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Ürün Bilgileri"
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
        'btnListeEkle
        '
        Me.btnListeEkle.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.btnListeEkle.Image = CType(resources.GetObject("btnListeEkle.Image"), System.Drawing.Image)
        Me.btnListeEkle.Location = New System.Drawing.Point(431, 85)
        Me.btnListeEkle.Name = "btnListeEkle"
        Me.btnListeEkle.Size = New System.Drawing.Size(102, 23)
        Me.btnListeEkle.TabIndex = 23
        Me.btnListeEkle.Text = "Listeye Ekle"
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
        'txtStokKodu
        '
        Me.txtStokKodu.Enabled = False
        Me.txtStokKodu.Location = New System.Drawing.Point(87, 23)
        Me.txtStokKodu.Name = "txtStokKodu"
        Me.txtStokKodu.Size = New System.Drawing.Size(151, 21)
        Me.txtStokKodu.TabIndex = 9
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
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btnSil)
        Me.GroupBox4.Controls.Add(Me.dgFisListe)
        Me.GroupBox4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.DimGray
        Me.GroupBox4.Location = New System.Drawing.Point(13, 259)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(556, 172)
        Me.GroupBox4.TabIndex = 65
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
        Me.dgFisListe.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.id})
        Me.dgFisListe.Location = New System.Drawing.Point(14, 20)
        Me.dgFisListe.Name = "dgFisListe"
        Me.dgFisListe.ReadOnly = True
        Me.dgFisListe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgFisListe.Size = New System.Drawing.Size(528, 107)
        Me.dgFisListe.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.HeaderText = "Stok Kodu"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Stok Adı"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Miktar"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "Birim"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'id
        '
        Me.id.HeaderText = "id"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtAciklama)
        Me.GroupBox3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.DimGray
        Me.GroupBox3.Location = New System.Drawing.Point(13, 437)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(556, 92)
        Me.GroupBox3.TabIndex = 66
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Açıklama"
        '
        'txtAciklama
        '
        Me.txtAciklama.Location = New System.Drawing.Point(14, 29)
        Me.txtAciklama.Multiline = True
        Me.txtAciklama.Name = "txtAciklama"
        Me.txtAciklama.Size = New System.Drawing.Size(528, 45)
        Me.txtAciklama.TabIndex = 0
        '
        'btnIptal
        '
        Me.btnIptal.Appearance.ForeColor = System.Drawing.Color.Black
        Me.btnIptal.Appearance.Options.UseForeColor = True
        Me.btnIptal.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.btnIptal.Image = CType(resources.GetObject("btnIptal.Image"), System.Drawing.Image)
        Me.btnIptal.Location = New System.Drawing.Point(302, 543)
        Me.btnIptal.Name = "btnIptal"
        Me.btnIptal.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnIptal.Size = New System.Drawing.Size(85, 26)
        Me.btnIptal.TabIndex = 60
        Me.btnIptal.Text = "İptal"
        '
        'btnKaydet
        '
        Me.btnKaydet.Appearance.ForeColor = System.Drawing.Color.Black
        Me.btnKaydet.Appearance.Options.UseForeColor = True
        Me.btnKaydet.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.btnKaydet.Image = CType(resources.GetObject("btnKaydet.Image"), System.Drawing.Image)
        Me.btnKaydet.Location = New System.Drawing.Point(211, 543)
        Me.btnKaydet.Name = "btnKaydet"
        Me.btnKaydet.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnKaydet.Size = New System.Drawing.Size(85, 26)
        Me.btnKaydet.TabIndex = 59
        Me.btnKaydet.Text = "Kaydet"
        '
        'DepoAktarEkle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(581, 614)
        Me.Controls.Add(Me.btnIptal)
        Me.Controls.Add(Me.btnKaydet)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "DepoAktarEkle"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Depo Aktarım Fişi Ekle"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.nudMiktar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.dgFisListe, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dtpFisTarihi As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents txtFisNo As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbCDepo As ComboBox
    Friend WithEvents cmbGDepo As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblid As Label
    Friend WithEvents txtBirim As TextBox
    Friend WithEvents nudMiktar As NumericUpDown
    Friend WithEvents btnListeEkle As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label5 As Label
    Friend WithEvents txtStokKodu As TextBox
    Friend WithEvents btnStokKart As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label6 As Label
    Friend WithEvents txtStokAdi As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents btnSil As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents dgFisListe As DataGridView
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtAciklama As TextBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents btnIptal As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnKaydet As DevExpress.XtraEditors.SimpleButton
End Class
