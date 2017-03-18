<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dashboard))
        Me.btnStokHareket = New DevExpress.XtraEditors.SimpleButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.btnStokKart = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton4 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton5 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton6 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton7 = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnStokHareket
        '
        Me.btnStokHareket.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnStokHareket.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.btnStokHareket.Appearance.Options.UseFont = True
        Me.btnStokHareket.Appearance.Options.UseForeColor = True
        Me.btnStokHareket.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnStokHareket.Image = CType(resources.GetObject("btnStokHareket.Image"), System.Drawing.Image)
        Me.btnStokHareket.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.btnStokHareket.Location = New System.Drawing.Point(227, 107)
        Me.btnStokHareket.Name = "btnStokHareket"
        Me.btnStokHareket.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[False]
        Me.btnStokHareket.Size = New System.Drawing.Size(199, 95)
        Me.btnStokHareket.TabIndex = 1
        Me.btnStokHareket.Text = "Stok Hareketleri"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.DimGray
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(156, 62)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DimGray
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 449)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(653, 61)
        Me.Panel1.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LightGray
        Me.Label1.Location = New System.Drawing.Point(242, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(173, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Stok Takip | Ceyhun Ataykan"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DimGray
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(653, 87)
        Me.Panel2.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.LightGray
        Me.Label4.Location = New System.Drawing.Point(542, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 13)
        Me.Label4.TabIndex = 4
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
        Me.SimpleButton1.Location = New System.Drawing.Point(432, 107)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[False]
        Me.SimpleButton1.Size = New System.Drawing.Size(199, 95)
        Me.SimpleButton1.TabIndex = 2
        Me.SimpleButton1.Text = "Aktarım İşlemleri"
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
        Me.btnStokKart.Location = New System.Drawing.Point(22, 107)
        Me.btnStokKart.Name = "btnStokKart"
        Me.btnStokKart.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[False]
        Me.btnStokKart.Size = New System.Drawing.Size(199, 95)
        Me.btnStokKart.TabIndex = 0
        Me.btnStokKart.Text = "Stok Kart"
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
        Me.SimpleButton2.Location = New System.Drawing.Point(432, 208)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[False]
        Me.SimpleButton2.Size = New System.Drawing.Size(199, 95)
        Me.SimpleButton2.TabIndex = 5
        Me.SimpleButton2.Text = "Tanımlar"
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
        Me.SimpleButton3.Location = New System.Drawing.Point(227, 208)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[False]
        Me.SimpleButton3.Size = New System.Drawing.Size(199, 95)
        Me.SimpleButton3.TabIndex = 4
        Me.SimpleButton3.Text = "Kasa İşlemleri"
        '
        'SimpleButton4
        '
        Me.SimpleButton4.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.SimpleButton4.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.SimpleButton4.Appearance.Options.UseFont = True
        Me.SimpleButton4.Appearance.Options.UseForeColor = True
        Me.SimpleButton4.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.SimpleButton4.Image = CType(resources.GetObject("SimpleButton4.Image"), System.Drawing.Image)
        Me.SimpleButton4.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.SimpleButton4.Location = New System.Drawing.Point(22, 208)
        Me.SimpleButton4.Name = "SimpleButton4"
        Me.SimpleButton4.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[False]
        Me.SimpleButton4.Size = New System.Drawing.Size(199, 95)
        Me.SimpleButton4.TabIndex = 3
        Me.SimpleButton4.Text = "Faturalar"
        '
        'SimpleButton5
        '
        Me.SimpleButton5.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.SimpleButton5.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.SimpleButton5.Appearance.Options.UseFont = True
        Me.SimpleButton5.Appearance.Options.UseForeColor = True
        Me.SimpleButton5.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.SimpleButton5.Image = CType(resources.GetObject("SimpleButton5.Image"), System.Drawing.Image)
        Me.SimpleButton5.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.SimpleButton5.Location = New System.Drawing.Point(432, 309)
        Me.SimpleButton5.Name = "SimpleButton5"
        Me.SimpleButton5.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[False]
        Me.SimpleButton5.Size = New System.Drawing.Size(199, 95)
        Me.SimpleButton5.TabIndex = 8
        Me.SimpleButton5.Text = "Ayarlar"
        '
        'SimpleButton6
        '
        Me.SimpleButton6.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.SimpleButton6.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.SimpleButton6.Appearance.Options.UseFont = True
        Me.SimpleButton6.Appearance.Options.UseForeColor = True
        Me.SimpleButton6.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.SimpleButton6.Image = CType(resources.GetObject("SimpleButton6.Image"), System.Drawing.Image)
        Me.SimpleButton6.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.SimpleButton6.Location = New System.Drawing.Point(227, 309)
        Me.SimpleButton6.Name = "SimpleButton6"
        Me.SimpleButton6.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[False]
        Me.SimpleButton6.Size = New System.Drawing.Size(199, 95)
        Me.SimpleButton6.TabIndex = 7
        Me.SimpleButton6.Text = "Yedekle"
        '
        'SimpleButton7
        '
        Me.SimpleButton7.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.SimpleButton7.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.SimpleButton7.Appearance.Options.UseFont = True
        Me.SimpleButton7.Appearance.Options.UseForeColor = True
        Me.SimpleButton7.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.SimpleButton7.Image = CType(resources.GetObject("SimpleButton7.Image"), System.Drawing.Image)
        Me.SimpleButton7.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.SimpleButton7.Location = New System.Drawing.Point(22, 309)
        Me.SimpleButton7.Name = "SimpleButton7"
        Me.SimpleButton7.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[False]
        Me.SimpleButton7.Size = New System.Drawing.Size(199, 95)
        Me.SimpleButton7.TabIndex = 6
        Me.SimpleButton7.Text = "Raporlar"
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(653, 510)
        Me.Controls.Add(Me.SimpleButton5)
        Me.Controls.Add(Me.SimpleButton6)
        Me.Controls.Add(Me.SimpleButton7)
        Me.Controls.Add(Me.SimpleButton2)
        Me.Controls.Add(Me.SimpleButton3)
        Me.Controls.Add(Me.SimpleButton4)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnStokHareket)
        Me.Controls.Add(Me.btnStokKart)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Dashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dashboard"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnStokHareket As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnStokKart As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton4 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton5 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton6 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton7 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
End Class
