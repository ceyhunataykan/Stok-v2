<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Bolumler
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Bolumler))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.dgBolListe = New System.Windows.Forms.DataGridView()
        Me.txtBolAd = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblid = New System.Windows.Forms.Label()
        Me.btnKapat = New DevExpress.XtraEditors.SimpleButton()
        Me.btnTemizle = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnSil = New DevExpress.XtraEditors.SimpleButton()
        Me.btnDuzenle = New DevExpress.XtraEditors.SimpleButton()
        Me.btnEkle = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.dgBolListe, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DimGray
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 438)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(454, 28)
        Me.Panel1.TabIndex = 66
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DimGray
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(454, 28)
        Me.Panel2.TabIndex = 65
        '
        'dgBolListe
        '
        Me.dgBolListe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgBolListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgBolListe.Location = New System.Drawing.Point(19, 20)
        Me.dgBolListe.MultiSelect = False
        Me.dgBolListe.Name = "dgBolListe"
        Me.dgBolListe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgBolListe.Size = New System.Drawing.Size(395, 192)
        Me.dgBolListe.TabIndex = 45
        '
        'txtBolAd
        '
        Me.txtBolAd.Location = New System.Drawing.Point(102, 46)
        Me.txtBolAd.Name = "txtBolAd"
        Me.txtBolAd.Size = New System.Drawing.Size(171, 21)
        Me.txtBolAd.TabIndex = 46
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(27, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "Bölüm Adı :"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Silver
        Me.GroupBox1.Controls.Add(Me.lblid)
        Me.GroupBox1.Controls.Add(Me.txtBolAd)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.DimGray
        Me.GroupBox1.Location = New System.Drawing.Point(12, 43)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(310, 110)
        Me.GroupBox1.TabIndex = 67
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Bolum"
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
        'btnKapat
        '
        Me.btnKapat.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnKapat.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.btnKapat.Appearance.Options.UseFont = True
        Me.btnKapat.Appearance.Options.UseForeColor = True
        Me.btnKapat.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnKapat.Location = New System.Drawing.Point(184, 407)
        Me.btnKapat.Name = "btnKapat"
        Me.btnKapat.Size = New System.Drawing.Size(101, 23)
        Me.btnKapat.TabIndex = 73
        Me.btnKapat.Text = "Kapat"
        '
        'btnTemizle
        '
        Me.btnTemizle.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnTemizle.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.btnTemizle.Appearance.Options.UseFont = True
        Me.btnTemizle.Appearance.Options.UseForeColor = True
        Me.btnTemizle.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnTemizle.Image = CType(resources.GetObject("btnTemizle.Image"), System.Drawing.Image)
        Me.btnTemizle.Location = New System.Drawing.Point(339, 127)
        Me.btnTemizle.Name = "btnTemizle"
        Me.btnTemizle.Size = New System.Drawing.Size(101, 23)
        Me.btnTemizle.TabIndex = 72
        Me.btnTemizle.Text = "Temizle"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Silver
        Me.GroupBox2.Controls.Add(Me.dgBolListe)
        Me.GroupBox2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.DimGray
        Me.GroupBox2.Location = New System.Drawing.Point(12, 165)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(429, 231)
        Me.GroupBox2.TabIndex = 68
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Liste"
        '
        'btnSil
        '
        Me.btnSil.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnSil.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.btnSil.Appearance.Options.UseFont = True
        Me.btnSil.Appearance.Options.UseForeColor = True
        Me.btnSil.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnSil.Image = CType(resources.GetObject("btnSil.Image"), System.Drawing.Image)
        Me.btnSil.Location = New System.Drawing.Point(339, 101)
        Me.btnSil.Name = "btnSil"
        Me.btnSil.Size = New System.Drawing.Size(101, 23)
        Me.btnSil.TabIndex = 71
        Me.btnSil.Text = "Sil"
        '
        'btnDuzenle
        '
        Me.btnDuzenle.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnDuzenle.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.btnDuzenle.Appearance.Options.UseFont = True
        Me.btnDuzenle.Appearance.Options.UseForeColor = True
        Me.btnDuzenle.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnDuzenle.Image = CType(resources.GetObject("btnDuzenle.Image"), System.Drawing.Image)
        Me.btnDuzenle.Location = New System.Drawing.Point(339, 75)
        Me.btnDuzenle.Name = "btnDuzenle"
        Me.btnDuzenle.Size = New System.Drawing.Size(101, 23)
        Me.btnDuzenle.TabIndex = 70
        Me.btnDuzenle.Text = "Düzenle"
        '
        'btnEkle
        '
        Me.btnEkle.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnEkle.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.btnEkle.Appearance.Options.UseFont = True
        Me.btnEkle.Appearance.Options.UseForeColor = True
        Me.btnEkle.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnEkle.Image = CType(resources.GetObject("btnEkle.Image"), System.Drawing.Image)
        Me.btnEkle.Location = New System.Drawing.Point(340, 49)
        Me.btnEkle.Name = "btnEkle"
        Me.btnEkle.Size = New System.Drawing.Size(101, 23)
        Me.btnEkle.TabIndex = 69
        Me.btnEkle.Text = "Ekle"
        '
        'Bolumler
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(454, 466)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnKapat)
        Me.Controls.Add(Me.btnTemizle)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnSil)
        Me.Controls.Add(Me.btnDuzenle)
        Me.Controls.Add(Me.btnEkle)
        Me.Name = "Bolumler"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bolumler"
        CType(Me.dgBolListe, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents dgBolListe As DataGridView
    Friend WithEvents txtBolAd As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblid As Label
    Friend WithEvents btnKapat As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnTemizle As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnSil As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnDuzenle As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnEkle As DevExpress.XtraEditors.SimpleButton
End Class
