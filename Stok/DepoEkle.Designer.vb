<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DepoEkle
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DepoEkle))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ckbAktif = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbIl = New System.Windows.Forms.ComboBox()
        Me.cmbIlce = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDepoAdres = New System.Windows.Forms.TextBox()
        Me.lblid = New System.Windows.Forms.Label()
        Me.txtDepoKod = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDepoAd = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtAdSoyad = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btnIptal = New DevExpress.XtraEditors.SimpleButton()
        Me.btnKaydet = New DevExpress.XtraEditors.SimpleButton()
        Me.txtTel = New System.Windows.Forms.MaskedTextBox()
        Me.txtFax = New System.Windows.Forms.MaskedTextBox()
        Me.txtMail = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DimGray
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 513)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(368, 28)
        Me.Panel1.TabIndex = 48
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DimGray
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(368, 28)
        Me.Panel2.TabIndex = 47
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Silver
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.ckbAktif)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cmbIl)
        Me.GroupBox1.Controls.Add(Me.cmbIlce)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtDepoAdres)
        Me.GroupBox1.Controls.Add(Me.lblid)
        Me.GroupBox1.Controls.Add(Me.txtDepoKod)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtDepoAd)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.DimGray
        Me.GroupBox1.Location = New System.Drawing.Point(12, 43)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(344, 266)
        Me.GroupBox1.TabIndex = 52
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Depo"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DimGray
        Me.Label6.Location = New System.Drawing.Point(54, 27)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 58
        Me.Label6.Text = "Aktif :"
        '
        'ckbAktif
        '
        Me.ckbAktif.AutoSize = True
        Me.ckbAktif.Location = New System.Drawing.Point(100, 27)
        Me.ckbAktif.Name = "ckbAktif"
        Me.ckbAktif.Size = New System.Drawing.Size(15, 14)
        Me.ckbAktif.TabIndex = 57
        Me.ckbAktif.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DimGray
        Me.Label5.Location = New System.Drawing.Point(73, 227)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(21, 13)
        Me.Label5.TabIndex = 56
        Me.Label5.Text = "İl :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DimGray
        Me.Label4.Location = New System.Drawing.Point(60, 200)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 13)
        Me.Label4.TabIndex = 55
        Me.Label4.Text = "İlçe :"
        '
        'cmbIl
        '
        Me.cmbIl.FormattingEnabled = True
        Me.cmbIl.Location = New System.Drawing.Point(100, 224)
        Me.cmbIl.Name = "cmbIl"
        Me.cmbIl.Size = New System.Drawing.Size(121, 21)
        Me.cmbIl.TabIndex = 54
        '
        'cmbIlce
        '
        Me.cmbIlce.FormattingEnabled = True
        Me.cmbIlce.Location = New System.Drawing.Point(100, 197)
        Me.cmbIlce.Name = "cmbIlce"
        Me.cmbIlce.Size = New System.Drawing.Size(121, 21)
        Me.cmbIlce.TabIndex = 53
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DimGray
        Me.Label3.Location = New System.Drawing.Point(48, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 52
        Me.Label3.Text = "Adres :"
        '
        'txtDepoAdres
        '
        Me.txtDepoAdres.Location = New System.Drawing.Point(100, 100)
        Me.txtDepoAdres.Multiline = True
        Me.txtDepoAdres.Name = "txtDepoAdres"
        Me.txtDepoAdres.Size = New System.Drawing.Size(217, 91)
        Me.txtDepoAdres.TabIndex = 51
        '
        'lblid
        '
        Me.lblid.AutoSize = True
        Me.lblid.Location = New System.Drawing.Point(128, 17)
        Me.lblid.Name = "lblid"
        Me.lblid.Size = New System.Drawing.Size(0, 13)
        Me.lblid.TabIndex = 50
        Me.lblid.Visible = False
        '
        'txtDepoKod
        '
        Me.txtDepoKod.Location = New System.Drawing.Point(100, 47)
        Me.txtDepoKod.Name = "txtDepoKod"
        Me.txtDepoKod.Size = New System.Drawing.Size(217, 21)
        Me.txtDepoKod.TabIndex = 46
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(31, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 49
        Me.Label2.Text = "Depo Adı :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(21, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "Depo Kodu :"
        '
        'txtDepoAd
        '
        Me.txtDepoAd.Location = New System.Drawing.Point(100, 73)
        Me.txtDepoAd.Name = "txtDepoAd"
        Me.txtDepoAd.Size = New System.Drawing.Size(217, 21)
        Me.txtDepoAd.TabIndex = 48
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Silver
        Me.GroupBox2.Controls.Add(Me.txtFax)
        Me.GroupBox2.Controls.Add(Me.txtTel)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.txtMail)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txtAdSoyad)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.DimGray
        Me.GroupBox2.Location = New System.Drawing.Point(11, 315)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(345, 149)
        Me.GroupBox2.TabIndex = 60
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Yetkili"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DimGray
        Me.Label8.Location = New System.Drawing.Point(38, 110)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 13)
        Me.Label8.TabIndex = 53
        Me.Label8.Text = "E-Posta :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DimGray
        Me.Label7.Location = New System.Drawing.Point(61, 83)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(33, 13)
        Me.Label7.TabIndex = 51
        Me.Label7.Text = "Fax :"
        '
        'txtAdSoyad
        '
        Me.txtAdSoyad.Location = New System.Drawing.Point(100, 27)
        Me.txtAdSoyad.Name = "txtAdSoyad"
        Me.txtAdSoyad.Size = New System.Drawing.Size(218, 21)
        Me.txtAdSoyad.TabIndex = 46
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.DimGray
        Me.Label12.Location = New System.Drawing.Point(39, 56)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(55, 13)
        Me.Label12.TabIndex = 49
        Me.Label12.Text = "Telefon :"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.DimGray
        Me.Label13.Location = New System.Drawing.Point(28, 30)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(66, 13)
        Me.Label13.TabIndex = 47
        Me.Label13.Text = "Ad Soyad :"
        '
        'btnIptal
        '
        Me.btnIptal.Appearance.ForeColor = System.Drawing.Color.Black
        Me.btnIptal.Appearance.Options.UseForeColor = True
        Me.btnIptal.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.btnIptal.Image = CType(resources.GetObject("btnIptal.Image"), System.Drawing.Image)
        Me.btnIptal.Location = New System.Drawing.Point(197, 474)
        Me.btnIptal.Name = "btnIptal"
        Me.btnIptal.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnIptal.Size = New System.Drawing.Size(85, 26)
        Me.btnIptal.TabIndex = 62
        Me.btnIptal.Text = "İptal"
        '
        'btnKaydet
        '
        Me.btnKaydet.Appearance.ForeColor = System.Drawing.Color.Black
        Me.btnKaydet.Appearance.Options.UseForeColor = True
        Me.btnKaydet.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.btnKaydet.Image = CType(resources.GetObject("btnKaydet.Image"), System.Drawing.Image)
        Me.btnKaydet.Location = New System.Drawing.Point(106, 474)
        Me.btnKaydet.Name = "btnKaydet"
        Me.btnKaydet.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnKaydet.Size = New System.Drawing.Size(85, 26)
        Me.btnKaydet.TabIndex = 61
        Me.btnKaydet.Text = "Kaydet"
        '
        'txtTel
        '
        Me.txtTel.Location = New System.Drawing.Point(101, 54)
        Me.txtTel.Mask = "(999) 000-0000"
        Me.txtTel.Name = "txtTel"
        Me.txtTel.Size = New System.Drawing.Size(138, 21)
        Me.txtTel.TabIndex = 54
        '
        'txtFax
        '
        Me.txtFax.Location = New System.Drawing.Point(101, 80)
        Me.txtFax.Mask = "(999) 000-0000"
        Me.txtFax.Name = "txtFax"
        Me.txtFax.Size = New System.Drawing.Size(138, 21)
        Me.txtFax.TabIndex = 55
        '
        'txtMail
        '
        Me.txtMail.Location = New System.Drawing.Point(100, 107)
        Me.txtMail.Name = "txtMail"
        Me.txtMail.Size = New System.Drawing.Size(218, 21)
        Me.txtMail.TabIndex = 52
        '
        'DepoEkle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(368, 541)
        Me.Controls.Add(Me.btnIptal)
        Me.Controls.Add(Me.btnKaydet)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "DepoEkle"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Depo Ekle"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents ckbAktif As CheckBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbIl As ComboBox
    Friend WithEvents cmbIlce As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtDepoAdres As TextBox
    Friend WithEvents lblid As Label
    Friend WithEvents txtDepoKod As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtDepoAd As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtAdSoyad As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents btnIptal As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnKaydet As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtFax As MaskedTextBox
    Friend WithEvents txtTel As MaskedTextBox
    Friend WithEvents txtMail As TextBox
End Class
