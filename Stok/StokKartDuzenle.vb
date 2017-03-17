Imports System.Drawing.Imaging

Public Class StokKartDuzenle
    Dim db As StokEntities = New StokEntities()
    Private Sub StokKartDuzenle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbDoldur()
    End Sub
    Public Sub cmbDoldur()
        Dim ktgListe As IList(Of Kategori) = db.Kategori.ToList()
        cmbKategori.DataSource = ktgListe
        cmbKategori.DisplayMember = "Kategori_Adi"
        cmbKategori.ValueMember = "Kategori_ID"
        cmbKategori.SelectedIndex = -1
        cmbKategori.SelectedText = "Seçiniz"

        Dim brmListe As IList(Of Birim) = db.Birim.ToList()
        cmbBirim.DataSource = brmListe
        cmbBirim.DisplayMember = "Birim_Adi"
        cmbBirim.ValueMember = "Birim_ID"
        cmbBirim.SelectedIndex = -1
        cmbBirim.SelectedText = "Seçiniz"

        Dim depoListe As IList(Of Depo) = db.Depo.ToList()
        cmbDepo.DataSource = depoListe
        cmbDepo.DisplayMember = "Depo_Adi"
        cmbDepo.ValueMember = "Depo_ID"
        cmbDepo.SelectedIndex = -1
        cmbDepo.SelectedText = "Seçiniz"
    End Sub

    Private Sub btnIptal_Click(sender As Object, e As EventArgs) Handles btnIptal.Click
        Me.Close()
    End Sub

    Private Sub btnKaydet_Click(sender As Object, e As EventArgs) Handles btnKaydet.Click
        If txtStokAdi.Text = "" Or txtSk.Text = "" Then
            MsgBox("Stok Kodu ve Stok Adı boş olamaz", MsgBoxStyle.Exclamation, "Uyarı")
            Return
        End If
        Dim rasgele As New Random()
        Dim sayi As Integer = rasgele.Next(1, 100000)
        Dim yol As String = Application.StartupPath & "\UrunResim\" & "res-" & sayi & ".jpeg"
        If Not PictureBox1.Image Is Nothing Then
            PictureBox1.Image.Save(yol, ImageFormat.Jpeg)
        End If
        Dim x As Integer = Convert.ToInt32(lblUrunID.Text)
        Dim urunEkle As Urun = (From u In db.Urun Where u.Urun_ID = x).First()
        If ckbAktif.Checked = True Then
            urunEkle.Durum = True
        Else
            urunEkle.Durum = False
        End If
        urunEkle.Stok_KayitTarihi = DateTimePicker1.Value
        urunEkle.Stok_Kodu = Convert.ToInt32(txtSk.Text)
        urunEkle.Stok_Adi = txtStokAdi.Text.Trim()
        urunEkle.Stok_Barkod = Convert.ToInt32(txtBarkod.Text)
        urunEkle.Kategori_ID = cmbKategori.SelectedValue
        urunEkle.Depo_ID = cmbDepo.SelectedValue
        urunEkle.Stok_Miktar = nudMiktar.Value
        urunEkle.Birim_ID = cmbBirim.SelectedValue
        urunEkle.Stok_TSeviye = nudTSeviye.Value
        urunEkle.Stok_AFiyati = Convert.ToDecimal(txtAlisFiyati.Text.Trim())
        urunEkle.Stok_SFiyati = Convert.ToDecimal(_txtSatisFiyati.Text.Trim())
        urunEkle.Stok_Kdv = Convert.ToInt32(txtKdv.Text)
        urunEkle.Stok_Foto = yol

        db.SaveChanges()
        MsgBox("Ürün Bilgileri Güncellendi.", MsgBoxStyle.Information, "Bilgi")
        Me.Close()
        StokKart.btnYenile.PerformClick()
    End Sub
    Dim resim As String
    Private Sub btnAc_Click(sender As Object, e As EventArgs) Handles btnAc.Click
        OpenFileDialog1.Filter = "Resim Dosyası|*.jpg"
        OpenFileDialog1.FileName = ""
        If OpenFileDialog1.ShowDialog() = DialogResult.Cancel Then
            Return
        End If
        resim = OpenFileDialog1.FileName
        PictureBox1.Image = Image.FromFile(resim)
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        PictureBox1.Image = Nothing
    End Sub
    Private Sub temizle()
        txtSk.Text = ""
        txtStokAdi.Text = ""
        txtBarkod.Text = ""
        txtAlisFiyati.Text = ""
        txtSatisFiyati.Text = ""
        txtKdv.Text = ""
        nudMiktar.Value = 0
        nudTSeviye.Value = 0
        PictureBox1.Image = Nothing
        ckbAktif.Checked = False
        cmbDoldur()
    End Sub

    Private Sub StokKartDuzenle_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
    End Sub
End Class