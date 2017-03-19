<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CariHesap
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CariHesap))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgListe = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.txtAra = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbDurum = New System.Windows.Forms.ComboBox()
        Me.btnDetay = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSil = New DevExpress.XtraEditors.SimpleButton()
        Me.btnDuzenle = New DevExpress.XtraEditors.SimpleButton()
        Me.btnEkle = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSec = New DevExpress.XtraEditors.SimpleButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblid = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgListe, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgListe)
        Me.GroupBox2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.DimGray
        Me.GroupBox2.Location = New System.Drawing.Point(16, 108)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(680, 290)
        Me.GroupBox2.TabIndex = 26
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Firmalar"
        '
        'dgListe
        '
        Me.dgListe.AllowUserToAddRows = False
        Me.dgListe.AllowUserToDeleteRows = False
        Me.dgListe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgListe.BackgroundColor = System.Drawing.Color.DarkGray
        Me.dgListe.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgListe.GridColor = System.Drawing.Color.LightGray
        Me.dgListe.Location = New System.Drawing.Point(12, 20)
        Me.dgListe.MultiSelect = False
        Me.dgListe.Name = "dgListe"
        Me.dgListe.ReadOnly = True
        Me.dgListe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgListe.Size = New System.Drawing.Size(654, 255)
        Me.dgListe.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Controls.Add(Me.txtAra)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cmbDurum)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.DimGray
        Me.GroupBox1.Location = New System.Drawing.Point(15, 34)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(680, 68)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtre"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(562, 29)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(104, 17)
        Me.CheckBox1.TabIndex = 18
        Me.CheckBox1.Text = "Borçlu Olanlar"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'txtAra
        '
        Me.txtAra.Location = New System.Drawing.Point(328, 26)
        Me.txtAra.Name = "txtAra"
        Me.txtAra.Size = New System.Drawing.Size(197, 21)
        Me.txtAra.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(256, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Firma Adı :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(10, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Durum :"
        '
        'cmbDurum
        '
        Me.cmbDurum.FormattingEnabled = True
        Me.cmbDurum.Items.AddRange(New Object() {"Tümü", "Aktif Hesaplar", "Pasif Hesaplar"})
        Me.cmbDurum.Location = New System.Drawing.Point(67, 26)
        Me.cmbDurum.Name = "cmbDurum"
        Me.cmbDurum.Size = New System.Drawing.Size(155, 21)
        Me.cmbDurum.TabIndex = 16
        '
        'btnDetay
        '
        Me.btnDetay.Appearance.ForeColor = System.Drawing.Color.Black
        Me.btnDetay.Appearance.Options.UseForeColor = True
        Me.btnDetay.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.btnDetay.Image = CType(resources.GetObject("btnDetay.Image"), System.Drawing.Image)
        Me.btnDetay.Location = New System.Drawing.Point(409, 404)
        Me.btnDetay.Name = "btnDetay"
        Me.btnDetay.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnDetay.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[False]
        Me.btnDetay.Size = New System.Drawing.Size(102, 26)
        Me.btnDetay.TabIndex = 34
        Me.btnDetay.Text = "Hesap Özeti"
        '
        'btnSil
        '
        Me.btnSil.Appearance.ForeColor = System.Drawing.Color.Black
        Me.btnSil.Appearance.Options.UseForeColor = True
        Me.btnSil.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.btnSil.Image = CType(resources.GetObject("btnSil.Image"), System.Drawing.Image)
        Me.btnSil.Location = New System.Drawing.Point(608, 404)
        Me.btnSil.Name = "btnSil"
        Me.btnSil.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnSil.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[False]
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
        Me.btnDuzenle.Location = New System.Drawing.Point(517, 404)
        Me.btnDuzenle.Name = "btnDuzenle"
        Me.btnDuzenle.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnDuzenle.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[False]
        Me.btnDuzenle.Size = New System.Drawing.Size(85, 26)
        Me.btnDuzenle.TabIndex = 32
        Me.btnDuzenle.Text = "Düzenle"
        '
        'btnEkle
        '
        Me.btnEkle.Appearance.ForeColor = System.Drawing.Color.Black
        Me.btnEkle.Appearance.Options.UseForeColor = True
        Me.btnEkle.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.btnEkle.Image = CType(resources.GetObject("btnEkle.Image"), System.Drawing.Image)
        Me.btnEkle.Location = New System.Drawing.Point(86, 404)
        Me.btnEkle.Name = "btnEkle"
        Me.btnEkle.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnEkle.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[False]
        Me.btnEkle.Size = New System.Drawing.Size(92, 26)
        Me.btnEkle.TabIndex = 31
        Me.btnEkle.Text = "Yeni Firma"
        '
        'btnSec
        '
        Me.btnSec.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.btnSec.Enabled = False
        Me.btnSec.Image = CType(resources.GetObject("btnSec.Image"), System.Drawing.Image)
        Me.btnSec.Location = New System.Drawing.Point(14, 404)
        Me.btnSec.Name = "btnSec"
        Me.btnSec.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnSec.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[False]
        Me.btnSec.Size = New System.Drawing.Size(66, 26)
        Me.btnSec.TabIndex = 30
        Me.btnSec.Text = "Seç"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DimGray
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 446)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(708, 28)
        Me.Panel1.TabIndex = 36
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DimGray
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(708, 28)
        Me.Panel2.TabIndex = 35
        '
        'lblid
        '
        Me.lblid.AutoSize = True
        Me.lblid.Location = New System.Drawing.Point(271, 410)
        Me.lblid.Name = "lblid"
        Me.lblid.Size = New System.Drawing.Size(0, 13)
        Me.lblid.TabIndex = 37
        Me.lblid.Visible = False
        '
        'CariHesap
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(708, 474)
        Me.Controls.Add(Me.lblid)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.btnDetay)
        Me.Controls.Add(Me.btnSil)
        Me.Controls.Add(Me.btnDuzenle)
        Me.Controls.Add(Me.btnEkle)
        Me.Controls.Add(Me.btnSec)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "CariHesap"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cari Hesaplar"
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgListe, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dgListe As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtAra As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbDurum As ComboBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents btnDetay As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSil As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnDuzenle As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnEkle As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSec As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblid As Label
End Class
