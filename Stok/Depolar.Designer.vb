<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Depolar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Depolar))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.dgDepoListe = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnSil = New DevExpress.XtraEditors.SimpleButton()
        Me.btnDuzenle = New DevExpress.XtraEditors.SimpleButton()
        Me.btnEkle = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblId = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtAra = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbDurum = New System.Windows.Forms.ComboBox()
        CType(Me.dgDepoListe, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DimGray
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 472)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(643, 28)
        Me.Panel1.TabIndex = 46
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DimGray
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(643, 28)
        Me.Panel2.TabIndex = 45
        '
        'dgDepoListe
        '
        Me.dgDepoListe.AllowUserToAddRows = False
        Me.dgDepoListe.AllowUserToDeleteRows = False
        Me.dgDepoListe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgDepoListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgDepoListe.Location = New System.Drawing.Point(17, 27)
        Me.dgDepoListe.MultiSelect = False
        Me.dgDepoListe.Name = "dgDepoListe"
        Me.dgDepoListe.ReadOnly = True
        Me.dgDepoListe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgDepoListe.Size = New System.Drawing.Size(587, 287)
        Me.dgDepoListe.TabIndex = 60
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Silver
        Me.GroupBox3.Controls.Add(Me.dgDepoListe)
        Me.GroupBox3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.DimGray
        Me.GroupBox3.Location = New System.Drawing.Point(12, 94)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(618, 335)
        Me.GroupBox3.TabIndex = 59
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Liste"
        '
        'btnSil
        '
        Me.btnSil.Appearance.ForeColor = System.Drawing.Color.Black
        Me.btnSil.Appearance.Options.UseForeColor = True
        Me.btnSil.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.btnSil.Image = CType(resources.GetObject("btnSil.Image"), System.Drawing.Image)
        Me.btnSil.Location = New System.Drawing.Point(545, 435)
        Me.btnSil.Name = "btnSil"
        Me.btnSil.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnSil.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[False]
        Me.btnSil.Size = New System.Drawing.Size(85, 26)
        Me.btnSil.TabIndex = 61
        Me.btnSil.Text = "Sil"
        '
        'btnDuzenle
        '
        Me.btnDuzenle.Appearance.ForeColor = System.Drawing.Color.Black
        Me.btnDuzenle.Appearance.Options.UseForeColor = True
        Me.btnDuzenle.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.btnDuzenle.Image = CType(resources.GetObject("btnDuzenle.Image"), System.Drawing.Image)
        Me.btnDuzenle.Location = New System.Drawing.Point(454, 435)
        Me.btnDuzenle.Name = "btnDuzenle"
        Me.btnDuzenle.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnDuzenle.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[False]
        Me.btnDuzenle.Size = New System.Drawing.Size(85, 26)
        Me.btnDuzenle.TabIndex = 60
        Me.btnDuzenle.Text = "Düzenle"
        '
        'btnEkle
        '
        Me.btnEkle.Appearance.ForeColor = System.Drawing.Color.Black
        Me.btnEkle.Appearance.Options.UseForeColor = True
        Me.btnEkle.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.btnEkle.Image = CType(resources.GetObject("btnEkle.Image"), System.Drawing.Image)
        Me.btnEkle.Location = New System.Drawing.Point(12, 435)
        Me.btnEkle.Name = "btnEkle"
        Me.btnEkle.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnEkle.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[False]
        Me.btnEkle.Size = New System.Drawing.Size(151, 26)
        Me.btnEkle.TabIndex = 62
        Me.btnEkle.Text = "Yeni Depo Ekle"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblId)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtAra)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cmbDurum)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.DimGray
        Me.GroupBox1.Location = New System.Drawing.Point(12, 34)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(618, 54)
        Me.GroupBox1.TabIndex = 63
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtre"
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.Location = New System.Drawing.Point(241, 21)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(0, 13)
        Me.lblId.TabIndex = 9
        Me.lblId.Visible = False
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
        'txtAra
        '
        Me.txtAra.Location = New System.Drawing.Point(428, 20)
        Me.txtAra.Name = "txtAra"
        Me.txtAra.Size = New System.Drawing.Size(176, 21)
        Me.txtAra.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(352, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Depo Kodu :"
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
        'Depolar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(643, 500)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnEkle)
        Me.Controls.Add(Me.btnSil)
        Me.Controls.Add(Me.btnDuzenle)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "Depolar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Depolar"
        CType(Me.dgDepoListe, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents dgDepoListe As DataGridView
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnSil As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnDuzenle As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnEkle As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtAra As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbDurum As ComboBox
    Friend WithEvents lblId As Label
End Class
