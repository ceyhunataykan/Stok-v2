<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tanimlar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Tanimlar))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnBolum = New DevExpress.XtraEditors.SimpleButton()
        Me.btnDepo = New DevExpress.XtraEditors.SimpleButton()
        Me.btnKategori = New DevExpress.XtraEditors.SimpleButton()
        Me.btnBirim = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCari = New DevExpress.XtraEditors.SimpleButton()
        Me.btnStokKart = New DevExpress.XtraEditors.SimpleButton()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DimGray
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 407)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(447, 28)
        Me.Panel1.TabIndex = 42
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DimGray
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(447, 28)
        Me.Panel2.TabIndex = 41
        '
        'btnBolum
        '
        Me.btnBolum.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnBolum.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.btnBolum.Appearance.Options.UseFont = True
        Me.btnBolum.Appearance.Options.UseForeColor = True
        Me.btnBolum.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnBolum.Image = CType(resources.GetObject("btnBolum.Image"), System.Drawing.Image)
        Me.btnBolum.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.btnBolum.Location = New System.Drawing.Point(225, 163)
        Me.btnBolum.Name = "btnBolum"
        Me.btnBolum.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[False]
        Me.btnBolum.Size = New System.Drawing.Size(199, 95)
        Me.btnBolum.TabIndex = 48
        Me.btnBolum.Text = "Bölümler"
        '
        'btnDepo
        '
        Me.btnDepo.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnDepo.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.btnDepo.Appearance.Options.UseFont = True
        Me.btnDepo.Appearance.Options.UseForeColor = True
        Me.btnDepo.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnDepo.Image = CType(resources.GetObject("btnDepo.Image"), System.Drawing.Image)
        Me.btnDepo.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.btnDepo.Location = New System.Drawing.Point(20, 163)
        Me.btnDepo.Name = "btnDepo"
        Me.btnDepo.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[False]
        Me.btnDepo.Size = New System.Drawing.Size(199, 95)
        Me.btnDepo.TabIndex = 47
        Me.btnDepo.Text = "Depolar"
        '
        'btnKategori
        '
        Me.btnKategori.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnKategori.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.btnKategori.Appearance.Options.UseFont = True
        Me.btnKategori.Appearance.Options.UseForeColor = True
        Me.btnKategori.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnKategori.Image = CType(resources.GetObject("btnKategori.Image"), System.Drawing.Image)
        Me.btnKategori.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.btnKategori.Location = New System.Drawing.Point(20, 264)
        Me.btnKategori.Name = "btnKategori"
        Me.btnKategori.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[False]
        Me.btnKategori.Size = New System.Drawing.Size(199, 95)
        Me.btnKategori.TabIndex = 46
        Me.btnKategori.Text = "Kategoriler"
        '
        'btnBirim
        '
        Me.btnBirim.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnBirim.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.btnBirim.Appearance.Options.UseFont = True
        Me.btnBirim.Appearance.Options.UseForeColor = True
        Me.btnBirim.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnBirim.Image = CType(resources.GetObject("btnBirim.Image"), System.Drawing.Image)
        Me.btnBirim.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.btnBirim.Location = New System.Drawing.Point(225, 264)
        Me.btnBirim.Name = "btnBirim"
        Me.btnBirim.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[False]
        Me.btnBirim.Size = New System.Drawing.Size(199, 95)
        Me.btnBirim.TabIndex = 45
        Me.btnBirim.Text = "Birimler"
        '
        'btnCari
        '
        Me.btnCari.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnCari.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.btnCari.Appearance.Options.UseFont = True
        Me.btnCari.Appearance.Options.UseForeColor = True
        Me.btnCari.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnCari.Image = CType(resources.GetObject("btnCari.Image"), System.Drawing.Image)
        Me.btnCari.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.btnCari.Location = New System.Drawing.Point(20, 62)
        Me.btnCari.Name = "btnCari"
        Me.btnCari.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[False]
        Me.btnCari.Size = New System.Drawing.Size(199, 95)
        Me.btnCari.TabIndex = 44
        Me.btnCari.Text = "Cari Hesaplar"
        '
        'btnStokKart
        '
        Me.btnStokKart.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnStokKart.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.btnStokKart.Appearance.Options.UseFont = True
        Me.btnStokKart.Appearance.Options.UseForeColor = True
        Me.btnStokKart.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnStokKart.Image = CType(resources.GetObject("btnStokKart.Image"), System.Drawing.Image)
        Me.btnStokKart.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.btnStokKart.Location = New System.Drawing.Point(225, 62)
        Me.btnStokKart.Name = "btnStokKart"
        Me.btnStokKart.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[False]
        Me.btnStokKart.Size = New System.Drawing.Size(199, 95)
        Me.btnStokKart.TabIndex = 43
        Me.btnStokKart.Text = "Stok Kart"
        '
        'Tanimlar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(447, 435)
        Me.Controls.Add(Me.btnBolum)
        Me.Controls.Add(Me.btnDepo)
        Me.Controls.Add(Me.btnKategori)
        Me.Controls.Add(Me.btnBirim)
        Me.Controls.Add(Me.btnCari)
        Me.Controls.Add(Me.btnStokKart)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Tanimlar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tanımlar"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnBolum As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnDepo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnKategori As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnBirim As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCari As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnStokKart As DevExpress.XtraEditors.SimpleButton
End Class
