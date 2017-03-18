Public Class DepoAktarDuzenle
    Dim db As New StokEntities()
    Private Sub DepoAktarDuzenle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbDoldur()
    End Sub
    Private Sub cmbDoldur()
        cmbCDepo.DisplayMember = "Depo_Adi"
        cmbCDepo.ValueMember = "Depo_ID"
        cmbCDepo.DataSource = db.Depo.ToList()

        cmbGDepo.DisplayMember = "Depo_Adi"
        cmbGDepo.ValueMember = "Depo_ID"
        cmbGDepo.DataSource = db.Depo.ToList()

    End Sub

    Private Sub btnFisDuzenle_Click(sender As Object, e As EventArgs) Handles btnFisDuzenle.Click
        Dim id As Integer = Convert.ToInt32(lblFisId.Text)
        Dim fisDuz = db.Aktarim_Fis.Where(Function(f) f.Aktarim_ID = id).FirstOrDefault()
        fisDuz.Aktarim_No = Convert.ToInt32(txtFisNo.Text)
        fisDuz.Aktarim_Tarih = dtpFisTarihi.Value
        fisDuz.Cikis_Depo_ID = cmbCDepo.SelectedValue
        fisDuz.Giris_Depo_ID = cmbGDepo.SelectedValue
        fisDuz.Aktarim_Aciklama = txtAciklama.Text
        db.SaveChanges()
        MsgBox("Fiş Bilgileri Güncellendi.", MsgBoxStyle.Information, "Bilgi")
    End Sub
    Private Sub btnStokKart_Click(sender As Object, e As EventArgs) Handles btnStokKart.Click
        gizleSec = True
        aktarDuzenle = True
        StokKart.Show()
    End Sub
    Private Sub btnListeEkle_Click(sender As Object, e As EventArgs) Handles btnListeEkle.Click
        Dim id As Integer = Convert.ToInt32(lblFisId.Text)
        Dim aktarDetayEkle As New Aktarim_Detay()
        aktarDetayEkle.Aktarim_Fis_ID = id
        aktarDetayEkle.Urun_ID = Convert.ToInt32(lblid.Text)
        aktarDetayEkle.Miktar = Convert.ToInt32(nudMiktar.Value)
        db.Aktarim_Detay.Add(aktarDetayEkle)
        db.SaveChanges()
        MsgBox("Ürün Listeye Eklendi.", MsgBoxStyle.Information, "Bilgi")
        temizle()
        detayListele()
    End Sub

    Private Sub btnSil_Click(sender As Object, e As EventArgs) Handles btnSil.Click
        If MsgBox("Ürün Listeden Kaldırılıyor... Onaylıyor musunuz?", MsgBoxStyle.YesNo, "Uyarı") = MsgBoxResult.No Then
            Return
        End If
        Dim id As Integer = Convert.ToInt32(dgFisListe.CurrentRow.Cells("Detay_ID").Value)
        Dim aktarDetaySil = db.Aktarim_Detay.Where(Function(f) f.Detay_ID = id).FirstOrDefault()
        db.Aktarim_Detay.Remove(aktarDetaySil)
        db.SaveChanges()
        MsgBox("Ürün Listeden Çıkarıldı.", MsgBoxStyle.Information, "Bilgi")
        detayListele()
    End Sub

    Private Sub detayListele()
        Dim id As Integer = Convert.ToInt32(lblFisId.Text)
        Dim fisDetay = (From f In db.Aktarim_Detay
                        Where f.Aktarim_Fis_ID = id
                        Select f.Detay_ID, f.Aktarim_Fis_ID, f.Urun_ID, stokKodu = f.Urun.Stok_Kodu, stokAdi = f.Urun.Stok_Adi, f.Miktar, f.Birim_ID, stokBirim = f.Birim.Birim_Adi).ToList()
        dgFisListe.DataSource = fisDetay
        dgFisListe.Columns("Detay_ID").Visible = False
        dgFisListe.Columns("Aktarim_Fis_ID").Visible = False
        dgFisListe.Columns("Urun_ID").Visible = False
        dgFisListe.Columns("stokKodu").HeaderText = "Stok Kodu"
        dgFisListe.Columns("stokAdi").HeaderText = "Stok Adı"
        dgFisListe.Columns("Miktar").HeaderText = "Miktar"
        dgFisListe.Columns("Birim_ID").Visible = False
        dgFisListe.Columns("stokBirim").HeaderText = "Birim"
    End Sub
    Private Sub temizle()
        txtStokKodu.Text = ""
        txtStokAdi.Text = ""
        nudMiktar.Value = 0
        txtBirim.Text = ""
    End Sub
    Private Sub btnIptal_Click(sender As Object, e As EventArgs) Handles btnIptal.Click
        Me.Close()
    End Sub
End Class