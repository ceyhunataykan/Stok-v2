Public Class StokGirisDuzenle
    Dim db As StokEntities = New StokEntities()
    Private Sub StokGirisDuzenle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim depoListe As IList(Of Depo) = db.Depo.ToList()
        cmbDepo.DataSource = depoListe
        cmbDepo.DisplayMember = "Depo_Adi"
        cmbDepo.ValueMember = "Depo_ID"
        Dim bolumListe As IList(Of Bolum) = db.Bolum.ToList()
        cmbBolum.DataSource = bolumListe
        cmbBolum.DisplayMember = "Bolum_Adi"
        cmbBolum.ValueMember = "Bolum_ID"
        hesapla()
    End Sub
    Private Sub btnListeEkle_Click(sender As Object, e As EventArgs) Handles btnListeEkle.Click
        Dim fID As Integer = Convert.ToInt32(lblFisId.Text)
        Dim fdEkle As New Fis_Detay
        fdEkle.Fis_ID = fID
        fdEkle.Urun_ID = Convert.ToInt32(lblid.Text)
        fdEkle.Miktar = Convert.ToInt32(nudMiktar.Value)
        fdEkle.Fiyat = Convert.ToDecimal(txtBirimFiyat.Text)
        fdEkle.Tutar = fdEkle.Miktar * fdEkle.Fiyat
        db.Fis_Detay.Add(fdEkle)
        db.SaveChanges()

        Dim id As Integer = Convert.ToInt32(lblid.Text)
        Dim bul = db.Urun.Where(Function(u) u.Urun_ID = id).FirstOrDefault()
        Dim sm As Integer = bul.Stok_Miktar
        bul.Stok_Miktar = sm + Convert.ToInt32(nudMiktar.Value)
        db.SaveChanges()

        MsgBox("Ürün Listeye Eklendi. Stok Bilgileri Güncellendi.", MsgBoxStyle.Information, "Bilgi")

        temizle()
        listeGetir()

    End Sub
    Private Sub btnSil_Click(sender As Object, e As EventArgs) Handles btnSil.Click
        'Listeden ürün çıkarır. Ürün bilgilerini günceller.
        Dim id As Integer = Convert.ToInt32(dgFisListe.CurrentRow.Cells("urunID").Value)
        Dim bul = db.Urun.Where(Function(u) u.Urun_ID = id).FirstOrDefault()
        Dim sm As Integer = bul.Stok_Miktar
        bul.Stok_Miktar = sm - Convert.ToInt32(dgFisListe.CurrentRow.Cells("stokMiktar").Value)
        db.SaveChanges()

        'Fiş üzerinden ürün kaldırır.
        Dim fID As Integer = Convert.ToInt32(dgFisListe.CurrentRow.Cells("detayID").Value)
        Dim dBul = db.Fis_Detay.Where(Function(f) f.Detay_ID = fID).FirstOrDefault()
        db.Fis_Detay.Remove(dBul)
        db.SaveChanges()
        MsgBox("Ürün Listeden Çıkarıldı. Stok Bilgileri Güncellendi.", MsgBoxStyle.Information, "Bilgi")
        listeGetir()
        hesapla()
    End Sub
    Private Sub btnStokKart_Click(sender As Object, e As EventArgs) Handles btnStokKart.Click
        gizleSec = True
        girisDuzenle = True
        StokKart.Show()
    End Sub
    Private Sub nudMiktar_ValueChanged(sender As Object, e As EventArgs) Handles nudMiktar.ValueChanged
        txtTutar.Text = (Convert.ToDecimal(txtBirimFiyat.Text) * nudMiktar.Value).ToString()
    End Sub
    Private Sub btnIptal_Click(sender As Object, e As EventArgs) Handles btnIptal.Click
        Me.Close()
    End Sub
    Private Sub listeGetir()
        Dim fID As Integer = Convert.ToInt32(lblFisId.Text)
        Dim fisDetay = (From f In db.Fis_Detay
                        Where f.Fis_ID = fID
                        Select
                            detayID = f.Detay_ID,
                            fisID = f.Fis_ID,
                            urunID = f.Urun.Urun_ID,
                            stokKodu = f.Urun.Stok_Kodu,
                            stokAdi = f.Urun.Stok_Adi,
                            stokMiktar = f.Miktar,
                            stokFiyat = f.Fiyat,
                            stokTutar = f.Tutar).ToList()

        dgFisListe.DataSource = fisDetay
        dgFisListe.Columns("detayID").Visible = False
        dgFisListe.Columns("urunID").Visible = False
        dgFisListe.Columns("stokKodu").HeaderText = "Stok Kodu"
        dgFisListe.Columns("stokAdi").HeaderText = "Stok Adı"
        dgFisListe.Columns("stokMiktar").HeaderText = "Miktar"
        dgFisListe.Columns("stokFiyat").HeaderText = "Fiyat"
        dgFisListe.Columns("stokTutar").HeaderText = "Tutar"
    End Sub
    Private Sub temizle()
        txtStokKodu.Text = ""
        txtStokAdi.Text = ""
        nudMiktar.Value = 0
        txtBirim.Text = ""
        txtBirimFiyat.Text = ""
        txtTutar.Text = ""
    End Sub
    Public Sub hesapla()
        'Dim fID As Integer = Convert.ToInt32(lblFisId.Text)
        'Dim toplamMiktar = db.Fis_Detay.Where(Function(m) m.Fis_ID = fID).Sum(Function(m) m.Miktar)
        'Dim toplamTutar = db.Fis_Detay.Where(Function(t) t.Fis_ID = fID).Sum(Function(t) t.Tutar)
        'txtTopBirim.Text = toplamMiktar.ToString()
        'txtTopTutar.Text = toplamTutar.ToString()
    End Sub
End Class