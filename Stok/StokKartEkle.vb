Imports System.Drawing.Imaging
Imports System.Runtime.Remoting.Channels
Imports Microsoft.SqlServer

Public Class StokKartEkle
    Dim db As StokEntities = New StokEntities()
    Private Sub btnIptal_Click(sender As Object, e As EventArgs) Handles btnIptal.Click
        Close()
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

    Private Sub btnKaydet_Click(sender As Object, e As EventArgs) Handles btnKaydet.Click
        Dim rasgele As New Random()
        Dim sayi As Integer = rasgele.Next(1, 100000)
        Dim yol As String = Application.StartupPath & "\UrunResim\" & "res-" & sayi & ".jpeg"
        PictureBox1.Image.Save(yol, ImageFormat.Jpeg)

        Dim urunEkle As Urun = New Urun()

        If ckbAktif.Checked = True Then
            urunEkle.Durum = True
        Else
            urunEkle.Durum = False
        End If
        urunEkle.Stok_KayitTarihi = DateTimePicker1.Value
        urunEkle.Stok_Kodu = Convert.ToInt32(txtStokKodu.Text.Trim())
        urunEkle.Stok_Adi = txtStokAdi.Text.Trim()
        urunEkle.Stok_Barkod = Convert.ToInt32(txtBarkod.Text.Trim())
        urunEkle.Kategori_ID = Convert.ToInt32(cmbKategori.SelectedValue)
        urunEkle.Depo_ID = Convert.ToInt32(cmbDepo.SelectedValue)
        urunEkle.Stok_Miktar = Convert.ToInt32(nudMiktar.Value)
        urunEkle.Birim_ID = Convert.ToInt32(cmbBirim.SelectedValue)
        urunEkle.Stok_TSeviye = Convert.ToInt32(nudTSeviye.Value)
        urunEkle.Stok_AFiyati = Convert.ToDecimal(txtAlisFiyati.Text.Trim())
        urunEkle.Stok_SFiyati = Convert.ToDecimal(_txtSatisFiyati.Text.Trim())
        urunEkle.Stok_Kdv = Convert.ToInt32(txtKdv.Text.Trim())
        urunEkle.Stok_Foto = yol

        db.Urun.Add(urunEkle)
        db.SaveChanges()
        temizle()
        Me.Close()
        StokKart.btnYenile.PerformClick()
    End Sub

    Private Sub StokKartEkle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ktgListe As IList(Of Kategori) = db.Kategori.ToList()
        cmbKategori.DataSource = ktgListe
        cmbKategori.DisplayMember = "Kategori_Adi"
        cmbKategori.ValueMember = "Kategori_ID"

        Dim brmListe As IList(Of Birim) = db.Birim.ToList()
        cmbBirim.DataSource = brmListe
        cmbBirim.DisplayMember = "Birim_Adi"
        cmbBirim.ValueMember = "Birim_ID"

        Dim depoListe As IList(Of Depo) = db.Depo.ToList()
        cmbDepo.DataSource = depoListe
        cmbDepo.DisplayMember = "Depo_Adi"
        cmbDepo.ValueMember = "Depo_ID"
    End Sub

    Private Sub temizle()
        txtStokKodu.Text = String.Empty
        txtStokAdi.Text = String.Empty
        txtBarkod.Text = String.Empty
        txtAlisFiyati.Text = String.Empty
        txtSatisFiyati.Text = String.Empty
        txtKdv.Text = String.Empty
        nudMiktar.Value = 0
        nudTSeviye.Value = 0
        PictureBox1.Image = Nothing
        ckbAktif.Checked = False
    End Sub
End Class