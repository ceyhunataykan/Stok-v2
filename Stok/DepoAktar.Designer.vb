<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DepoAktar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DepoAktar))
        Me.btnDetay = New DevExpress.XtraEditors.SimpleButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtAra = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgFisListe = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnTum = New DevExpress.XtraEditors.SimpleButton()
        Me.cmbGDepo = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpTarih = New System.Windows.Forms.DateTimePicker()
        Me.cmbCDepo = New System.Windows.Forms.ComboBox()
        Me.btnEkle = New DevExpress.XtraEditors.SimpleButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnSil = New DevExpress.XtraEditors.SimpleButton()
        Me.btnDuzenle = New DevExpress.XtraEditors.SimpleButton()
        Me.lblId = New System.Windows.Forms.Label()
        CType(Me.dgFisListe, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnDetay
        '
        Me.btnDetay.Appearance.ForeColor = System.Drawing.Color.Black
        Me.btnDetay.Appearance.Options.UseForeColor = True
        Me.btnDetay.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.btnDetay.Image = CType(resources.GetObject("btnDetay.Image"), System.Drawing.Image)
        Me.btnDetay.Location = New System.Drawing.Point(529, 420)
        Me.btnDetay.Name = "btnDetay"
        Me.btnDetay.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnDetay.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[False]
        Me.btnDetay.Size = New System.Drawing.Size(85, 26)
        Me.btnDetay.TabIndex = 39
        Me.btnDetay.Text = "Detay"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DimGray
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 460)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(808, 28)
        Me.Panel1.TabIndex = 37
        '
        'txtAra
        '
        Me.txtAra.Location = New System.Drawing.Point(369, 26)
        Me.txtAra.Name = "txtAra"
        Me.txtAra.Size = New System.Drawing.Size(119, 21)
        Me.txtAra.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(319, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Fiş No :"
        '
        'dgFisListe
        '
        Me.dgFisListe.AllowUserToAddRows = False
        Me.dgFisListe.AllowUserToDeleteRows = False
        Me.dgFisListe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgFisListe.BackgroundColor = System.Drawing.Color.DarkGray
        Me.dgFisListe.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgFisListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgFisListe.GridColor = System.Drawing.Color.LightGray
        Me.dgFisListe.Location = New System.Drawing.Point(12, 20)
        Me.dgFisListe.MultiSelect = False
        Me.dgFisListe.Name = "dgFisListe"
        Me.dgFisListe.ReadOnly = True
        Me.dgFisListe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgFisListe.Size = New System.Drawing.Size(757, 255)
        Me.dgFisListe.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgFisListe)
        Me.GroupBox2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.DimGray
        Me.GroupBox2.Location = New System.Drawing.Point(14, 119)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(782, 290)
        Me.GroupBox2.TabIndex = 36
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Aktarım Fişleri"
        '
        'btnTum
        '
        Me.btnTum.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.btnTum.Image = CType(resources.GetObject("btnTum.Image"), System.Drawing.Image)
        Me.btnTum.Location = New System.Drawing.Point(668, 26)
        Me.btnTum.Name = "btnTum"
        Me.btnTum.Size = New System.Drawing.Size(106, 23)
        Me.btnTum.TabIndex = 22
        Me.btnTum.Text = "Tümünü Listele"
        '
        'cmbGDepo
        '
        Me.cmbGDepo.FormattingEnabled = True
        Me.cmbGDepo.Location = New System.Drawing.Point(226, 26)
        Me.cmbGDepo.Name = "cmbGDepo"
        Me.cmbGDepo.Size = New System.Drawing.Size(87, 21)
        Me.cmbGDepo.TabIndex = 18
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DimGray
        Me.Label3.Location = New System.Drawing.Point(164, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "G. Depo :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnTum)
        Me.GroupBox1.Controls.Add(Me.txtAra)
        Me.GroupBox1.Controls.Add(Me.cmbGDepo)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.dtpTarih)
        Me.GroupBox1.Controls.Add(Me.cmbCDepo)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.DimGray
        Me.GroupBox1.Location = New System.Drawing.Point(12, 39)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(783, 68)
        Me.GroupBox1.TabIndex = 35
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(10, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Ç. Depo :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DimGray
        Me.Label4.Location = New System.Drawing.Point(494, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Tarih :"
        '
        'dtpTarih
        '
        Me.dtpTarih.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpTarih.Location = New System.Drawing.Point(542, 27)
        Me.dtpTarih.Name = "dtpTarih"
        Me.dtpTarih.Size = New System.Drawing.Size(110, 21)
        Me.dtpTarih.TabIndex = 21
        '
        'cmbCDepo
        '
        Me.cmbCDepo.FormattingEnabled = True
        Me.cmbCDepo.Location = New System.Drawing.Point(71, 26)
        Me.cmbCDepo.Name = "cmbCDepo"
        Me.cmbCDepo.Size = New System.Drawing.Size(87, 21)
        Me.cmbCDepo.TabIndex = 16
        '
        'btnEkle
        '
        Me.btnEkle.Appearance.ForeColor = System.Drawing.Color.Black
        Me.btnEkle.Appearance.Options.UseForeColor = True
        Me.btnEkle.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.btnEkle.Image = CType(resources.GetObject("btnEkle.Image"), System.Drawing.Image)
        Me.btnEkle.Location = New System.Drawing.Point(14, 420)
        Me.btnEkle.Name = "btnEkle"
        Me.btnEkle.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnEkle.Size = New System.Drawing.Size(125, 26)
        Me.btnEkle.TabIndex = 34
        Me.btnEkle.Text = "Yeni Aktarım Fişi"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DimGray
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(808, 28)
        Me.Panel2.TabIndex = 38
        '
        'btnSil
        '
        Me.btnSil.Appearance.ForeColor = System.Drawing.Color.Black
        Me.btnSil.Appearance.Options.UseForeColor = True
        Me.btnSil.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.btnSil.Image = CType(resources.GetObject("btnSil.Image"), System.Drawing.Image)
        Me.btnSil.Location = New System.Drawing.Point(711, 420)
        Me.btnSil.Name = "btnSil"
        Me.btnSil.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnSil.Size = New System.Drawing.Size(85, 26)
        Me.btnSil.TabIndex = 33
        Me.btnSil.Text = "Sil"
        '
        'btnDuzenle
        '
        Me.btnDuzenle.Appearance.ForeColor = System.Drawing.Color.Black
        Me.btnDuzenle.Appearance.Options.UseForeColor = True
        Me.btnDuzenle.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.btnDuzenle.Image = CType(resources.GetObject("btnDuzenle.Image"), System.Drawing.Image)
        Me.btnDuzenle.Location = New System.Drawing.Point(620, 420)
        Me.btnDuzenle.Name = "btnDuzenle"
        Me.btnDuzenle.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnDuzenle.Size = New System.Drawing.Size(85, 26)
        Me.btnDuzenle.TabIndex = 32
        Me.btnDuzenle.Text = "Düzenle"
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.Location = New System.Drawing.Point(288, 426)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(0, 13)
        Me.lblId.TabIndex = 40
        Me.lblId.Visible = False
        '
        'DepoAktar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(808, 488)
        Me.Controls.Add(Me.lblId)
        Me.Controls.Add(Me.btnDetay)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnEkle)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.btnSil)
        Me.Controls.Add(Me.btnDuzenle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "DepoAktar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Depolar Arası Aktarım İşlemleri"
        CType(Me.dgFisListe, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnDetay As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtAra As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dgFisListe As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnTum As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmbGDepo As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents dtpTarih As DateTimePicker
    Friend WithEvents cmbCDepo As ComboBox
    Friend WithEvents btnEkle As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnSil As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnDuzenle As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblId As Label
End Class
