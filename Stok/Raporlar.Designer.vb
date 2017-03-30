<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Raporlar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Raporlar))
        Me.btnDepo = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCari = New DevExpress.XtraEditors.SimpleButton()
        Me.btnStokKart = New DevExpress.XtraEditors.SimpleButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.SuspendLayout()
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
        Me.btnDepo.Location = New System.Drawing.Point(225, 163)
        Me.btnDepo.Name = "btnDepo"
        Me.btnDepo.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[False]
        Me.btnDepo.Size = New System.Drawing.Size(199, 95)
        Me.btnDepo.TabIndex = 55
        Me.btnDepo.Text = "Depo Hareketleri Ekstre"
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
        Me.btnCari.Location = New System.Drawing.Point(20, 163)
        Me.btnCari.Name = "btnCari"
        Me.btnCari.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[False]
        Me.btnCari.Size = New System.Drawing.Size(199, 95)
        Me.btnCari.TabIndex = 52
        Me.btnCari.Text = "Stok Hareketleri Ekstre"
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
        Me.btnStokKart.TabIndex = 51
        Me.btnStokKart.Text = "Azalan Stok Raporu"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DimGray
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 407)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(447, 28)
        Me.Panel1.TabIndex = 50
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DimGray
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(447, 28)
        Me.Panel2.TabIndex = 49
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.SimpleButton1.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.SimpleButton1.Appearance.Options.UseFont = True
        Me.SimpleButton1.Appearance.Options.UseForeColor = True
        Me.SimpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.SimpleButton1.Location = New System.Drawing.Point(20, 62)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[False]
        Me.SimpleButton1.Size = New System.Drawing.Size(199, 95)
        Me.SimpleButton1.TabIndex = 56
        Me.SimpleButton1.Text = "Stok Durum Raporu"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.SimpleButton2.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.SimpleButton2.Appearance.Options.UseFont = True
        Me.SimpleButton2.Appearance.Options.UseForeColor = True
        Me.SimpleButton2.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.SimpleButton2.Image = CType(resources.GetObject("SimpleButton2.Image"), System.Drawing.Image)
        Me.SimpleButton2.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.SimpleButton2.Location = New System.Drawing.Point(225, 264)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[False]
        Me.SimpleButton2.Size = New System.Drawing.Size(199, 95)
        Me.SimpleButton2.TabIndex = 58
        Me.SimpleButton2.Text = "Borç Alacak Durumu"
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.SimpleButton3.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.SimpleButton3.Appearance.Options.UseFont = True
        Me.SimpleButton3.Appearance.Options.UseForeColor = True
        Me.SimpleButton3.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.SimpleButton3.Image = CType(resources.GetObject("SimpleButton3.Image"), System.Drawing.Image)
        Me.SimpleButton3.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.SimpleButton3.Location = New System.Drawing.Point(20, 264)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[False]
        Me.SimpleButton3.Size = New System.Drawing.Size(199, 95)
        Me.SimpleButton3.TabIndex = 57
        Me.SimpleButton3.Text = "Maliyet Raporu"
        '
        'Raporlar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(447, 435)
        Me.Controls.Add(Me.SimpleButton2)
        Me.Controls.Add(Me.SimpleButton3)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.btnDepo)
        Me.Controls.Add(Me.btnCari)
        Me.Controls.Add(Me.btnStokKart)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Raporlar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Raporlar"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnDepo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCari As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnStokKart As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
End Class
