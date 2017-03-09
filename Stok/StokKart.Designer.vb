<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StokKart
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StokKart))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnSec = New DevExpress.XtraEditors.SimpleButton()
        Me.btnEkle = New DevExpress.XtraEditors.SimpleButton()
        Me.btnDuzenle = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSil = New DevExpress.XtraEditors.SimpleButton()
        Me.txtAra = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbDurum = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgListe = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnDetay = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgListe, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSec
        '
        Me.btnSec.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.btnSec.Enabled = False
        Me.btnSec.Image = CType(resources.GetObject("btnSec.Image"), System.Drawing.Image)
        Me.btnSec.Location = New System.Drawing.Point(12, 457)
        Me.btnSec.Name = "btnSec"
        Me.btnSec.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnSec.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[False]
        Me.btnSec.Size = New System.Drawing.Size(66, 26)
        Me.btnSec.TabIndex = 1
        Me.btnSec.Text = "Seç"
        '
        'btnEkle
        '
        Me.btnEkle.Appearance.ForeColor = System.Drawing.Color.Black
        Me.btnEkle.Appearance.Options.UseForeColor = True
        Me.btnEkle.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.btnEkle.Image = CType(resources.GetObject("btnEkle.Image"), System.Drawing.Image)
        Me.btnEkle.Location = New System.Drawing.Point(84, 457)
        Me.btnEkle.Name = "btnEkle"
        Me.btnEkle.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnEkle.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[False]
        Me.btnEkle.Size = New System.Drawing.Size(151, 26)
        Me.btnEkle.TabIndex = 2
        Me.btnEkle.Text = "Yeni Stok Ekle"
        '
        'btnDuzenle
        '
        Me.btnDuzenle.Appearance.ForeColor = System.Drawing.Color.Black
        Me.btnDuzenle.Appearance.Options.UseForeColor = True
        Me.btnDuzenle.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.btnDuzenle.Image = CType(resources.GetObject("btnDuzenle.Image"), System.Drawing.Image)
        Me.btnDuzenle.Location = New System.Drawing.Point(515, 457)
        Me.btnDuzenle.Name = "btnDuzenle"
        Me.btnDuzenle.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnDuzenle.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[False]
        Me.btnDuzenle.Size = New System.Drawing.Size(85, 26)
        Me.btnDuzenle.TabIndex = 3
        Me.btnDuzenle.Text = "Düzenle"
        '
        'btnSil
        '
        Me.btnSil.Appearance.ForeColor = System.Drawing.Color.Black
        Me.btnSil.Appearance.Options.UseForeColor = True
        Me.btnSil.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.btnSil.Image = CType(resources.GetObject("btnSil.Image"), System.Drawing.Image)
        Me.btnSil.Location = New System.Drawing.Point(606, 457)
        Me.btnSil.Name = "btnSil"
        Me.btnSil.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnSil.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[False]
        Me.btnSil.Size = New System.Drawing.Size(85, 26)
        Me.btnSil.TabIndex = 4
        Me.btnSil.Text = "Sil"
        '
        'txtAra
        '
        Me.txtAra.Location = New System.Drawing.Point(490, 20)
        Me.txtAra.Name = "txtAra"
        Me.txtAra.Size = New System.Drawing.Size(176, 21)
        Me.txtAra.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(414, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Stok Kodu :"
        '
        'cmbDurum
        '
        Me.cmbDurum.FormattingEnabled = True
        Me.cmbDurum.Items.AddRange(New Object() {"Tümü", "Aktif", "Pasif"})
        Me.cmbDurum.Location = New System.Drawing.Point(69, 19)
        Me.cmbDurum.Name = "cmbDurum"
        Me.cmbDurum.Size = New System.Drawing.Size(87, 21)
        Me.cmbDurum.TabIndex = 7
        Me.cmbDurum.Text = "Seçiniz"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(11, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Durum :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtAra)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cmbDurum)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.DimGray
        Me.GroupBox1.Location = New System.Drawing.Point(12, 38)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(679, 54)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtre"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgListe)
        Me.GroupBox2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.DimGray
        Me.GroupBox2.Location = New System.Drawing.Point(12, 111)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(679, 333)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Stok Kartları"
        '
        'dgListe
        '
        Me.dgListe.AllowUserToAddRows = False
        Me.dgListe.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gray
        Me.dgListe.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgListe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgListe.BackgroundColor = System.Drawing.Color.DarkGray
        Me.dgListe.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgListe.GridColor = System.Drawing.Color.LightGray
        Me.dgListe.Location = New System.Drawing.Point(14, 20)
        Me.dgListe.Name = "dgListe"
        Me.dgListe.ReadOnly = True
        Me.dgListe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgListe.Size = New System.Drawing.Size(652, 298)
        Me.dgListe.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DimGray
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(703, 28)
        Me.Panel2.TabIndex = 27
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DimGray
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 499)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(703, 28)
        Me.Panel1.TabIndex = 28
        '
        'btnDetay
        '
        Me.btnDetay.Appearance.ForeColor = System.Drawing.Color.Black
        Me.btnDetay.Appearance.Options.UseForeColor = True
        Me.btnDetay.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.btnDetay.Image = CType(resources.GetObject("btnDetay.Image"), System.Drawing.Image)
        Me.btnDetay.Location = New System.Drawing.Point(424, 457)
        Me.btnDetay.Name = "btnDetay"
        Me.btnDetay.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnDetay.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[False]
        Me.btnDetay.Size = New System.Drawing.Size(85, 26)
        Me.btnDetay.TabIndex = 29
        Me.btnDetay.Text = "Detay"
        '
        'StokKart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(703, 527)
        Me.Controls.Add(Me.btnDetay)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnSil)
        Me.Controls.Add(Me.btnDuzenle)
        Me.Controls.Add(Me.btnEkle)
        Me.Controls.Add(Me.btnSec)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "StokKart"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stok Kart İşlemleri"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgListe, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnSec As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnEkle As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnDuzenle As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSil As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtAra As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbDurum As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnDetay As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents dgListe As DataGridView
End Class
