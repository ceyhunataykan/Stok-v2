﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Faturalar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Faturalar))
        Me.lblId = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtFaturaAra = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dgListe = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtFirmaAra = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpTarih = New System.Windows.Forms.DateTimePicker()
        Me.cmbDepo = New System.Windows.Forms.ComboBox()
        Me.btnDetay = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSil = New DevExpress.XtraEditors.SimpleButton()
        Me.btnDuzenle = New DevExpress.XtraEditors.SimpleButton()
        Me.btnEkle = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.dgListe, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.Location = New System.Drawing.Point(367, 426)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(0, 13)
        Me.lblId.TabIndex = 41
        Me.lblId.Visible = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DimGray
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(808, 28)
        Me.Panel2.TabIndex = 39
        '
        'txtFaturaAra
        '
        Me.txtFaturaAra.Location = New System.Drawing.Point(224, 25)
        Me.txtFaturaAra.Name = "txtFaturaAra"
        Me.txtFaturaAra.Size = New System.Drawing.Size(119, 21)
        Me.txtFaturaAra.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(151, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Fatura No :"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DimGray
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 460)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(808, 28)
        Me.Panel1.TabIndex = 38
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
        Me.dgListe.Size = New System.Drawing.Size(757, 255)
        Me.dgListe.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgListe)
        Me.GroupBox2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.DimGray
        Me.GroupBox2.Location = New System.Drawing.Point(14, 119)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(782, 290)
        Me.GroupBox2.TabIndex = 37
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Faturalar"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtFirmaAra)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtFaturaAra)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.dtpTarih)
        Me.GroupBox1.Controls.Add(Me.cmbDepo)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.DimGray
        Me.GroupBox1.Location = New System.Drawing.Point(12, 39)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(783, 68)
        Me.GroupBox1.TabIndex = 36
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtre"
        '
        'txtFirmaAra
        '
        Me.txtFirmaAra.Location = New System.Drawing.Point(400, 25)
        Me.txtFirmaAra.Name = "txtFirmaAra"
        Me.txtFirmaAra.Size = New System.Drawing.Size(154, 21)
        Me.txtFirmaAra.TabIndex = 23
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DimGray
        Me.Label3.Location = New System.Drawing.Point(349, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Firma :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(10, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Depo :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DimGray
        Me.Label4.Location = New System.Drawing.Point(560, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Tarih :"
        '
        'dtpTarih
        '
        Me.dtpTarih.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpTarih.Location = New System.Drawing.Point(608, 25)
        Me.dtpTarih.Name = "dtpTarih"
        Me.dtpTarih.Size = New System.Drawing.Size(163, 21)
        Me.dtpTarih.TabIndex = 21
        '
        'cmbDepo
        '
        Me.cmbDepo.FormattingEnabled = True
        Me.cmbDepo.Location = New System.Drawing.Point(58, 25)
        Me.cmbDepo.Name = "cmbDepo"
        Me.cmbDepo.Size = New System.Drawing.Size(87, 21)
        Me.cmbDepo.TabIndex = 16
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
        Me.btnDetay.TabIndex = 40
        Me.btnDetay.Text = "Detay"
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
        Me.btnSil.TabIndex = 34
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
        Me.btnDuzenle.TabIndex = 33
        Me.btnDuzenle.Text = "Düzenle"
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
        Me.btnEkle.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[False]
        Me.btnEkle.Size = New System.Drawing.Size(125, 26)
        Me.btnEkle.TabIndex = 32
        Me.btnEkle.Text = "Yeni Satış Faturası"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Appearance.ForeColor = System.Drawing.Color.Black
        Me.SimpleButton1.Appearance.Options.UseForeColor = True
        Me.SimpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(145, 420)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.SimpleButton1.Size = New System.Drawing.Size(125, 26)
        Me.SimpleButton1.TabIndex = 35
        Me.SimpleButton1.Text = "Yeni Alış Faturası"
        '
        'Faturalar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(808, 488)
        Me.Controls.Add(Me.lblId)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnDetay)
        Me.Controls.Add(Me.btnSil)
        Me.Controls.Add(Me.btnDuzenle)
        Me.Controls.Add(Me.btnEkle)
        Me.Controls.Add(Me.SimpleButton1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Faturalar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Faturalar"
        CType(Me.dgListe, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblId As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtFaturaAra As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents dgListe As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents dtpTarih As DateTimePicker
    Friend WithEvents cmbDepo As ComboBox
    Friend WithEvents btnDetay As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSil As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnDuzenle As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnEkle As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtFirmaAra As TextBox
    Friend WithEvents Label3 As Label
End Class
