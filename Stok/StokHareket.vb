Public Class StokHareket
    Dim db As StokEntities = New StokEntities()

    Private Sub btnEkle_Click(sender As Object, e As EventArgs) Handles btnEkle.Click
        StokGiris.ShowDialog()
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        StokCikis.ShowDialog()
    End Sub

    Private Sub StokHareket_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim depoListe As IList(Of Depo) = db.Depo.ToList()
        cmbDepo.DataSource = depoListe
        cmbDepo.DisplayMember = "Depo_Adi"
        cmbDepo.ValueMember = "Depo_ID"

        Dim bolumListe As IList(Of Bolum) = db.Bolum.ToList()
        cmbBolum.DataSource = bolumListe
        cmbBolum.DisplayMember = "Bolum_Adi"
        cmbBolum.ValueMember = "Bolum_ID"

        listele()
    End Sub

    Private Sub listele()
        Dim fisListe = (From f In db.Fis
                        Select
                            fisID = f.Fis_ID,
                            fisNo = f.Fis_No,
                            fisTur = f.Fis_Türü,
                            fisTarih = f.Fis_Tarih,
                            fisDepo = f.Depo.Depo_Adi,
                            fisBolum = f.Bolum.Bolum_Adi).ToList()
        dgFisListe.DataSource = fisListe
        dgFisListe.Columns("fisID").Visible = False
        dgFisListe.Columns("fisNo").HeaderText = "Fiş No"
        dgFisListe.Columns("fisTur").HeaderText = "Fiş Türü"
        dgFisListe.Columns("fisTarih").HeaderText = "Tarih"
        dgFisListe.Columns("fisDepo").HeaderText = "Depo"
        dgFisListe.Columns("fisBolum").HeaderText = "Bölüm"
    End Sub

    Private Sub btnDuzenle_Click(sender As Object, e As EventArgs) Handles btnDuzenle.Click
        Dim fID As Integer = Convert.ToInt32(dgFisListe.CurrentRow.Cells("fisID").Value)
        Dim fisSec = (From f In db.Fis
                      Where f.Fis_ID = fID
                      Select
                          fisID = f.Fis_ID,
                          fisNo = f.Fis_No,
                          fisTarih = f.Fis_Tarih,
                          fisDepo = f.Depo_ID,
                          fisBolum = f.Bolum_ID,
                          fisAciklama = f.Aciklama).FirstOrDefault()
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

        If dgFisListe.CurrentRow.Cells("fisTur").Value = "Stok Giriş" Then
            StokGirisDuzenle.Show()
            StokGirisDuzenle.dgFisListe.DataSource = fisDetay
            StokGirisDuzenle.dgFisListe.Columns("detayID").Visible = False
            StokGirisDuzenle.dgFisListe.Columns("urunID").Visible = False
            StokGirisDuzenle.dgFisListe.Columns("fisID").Visible = False
            StokGirisDuzenle.dgFisListe.Columns("stokKodu").HeaderText = "Stok Kodu"
            StokGirisDuzenle.dgFisListe.Columns("stokAdi").HeaderText = "Stok Adı"
            StokGirisDuzenle.dgFisListe.Columns("stokMiktar").HeaderText = "Miktar"
            StokGirisDuzenle.dgFisListe.Columns("stokFiyat").HeaderText = "Fiyat"
            StokGirisDuzenle.dgFisListe.Columns("stokTutar").HeaderText = "Tutar"

            StokGirisDuzenle.txtFisNo.Text = fisSec.fisNo
            StokGirisDuzenle.lblFisId.Text = fisSec.fisID
            StokGirisDuzenle.cmbDepo.SelectedValue = fisSec.fisDepo
            StokGirisDuzenle.cmbBolum.SelectedValue = fisSec.fisBolum

        ElseIf dgFisListe.CurrentRow.Cells("fisTur").Value = "Stok Çıkış" Then
            StokCikisDuzenle.Show()

            StokCikisDuzenle.dgFisListe.DataSource = fisDetay
            StokCikisDuzenle.dgFisListe.Columns("detayID").Visible = False
            StokCikisDuzenle.dgFisListe.Columns("urunID").Visible = False
            StokGirisDuzenle.dgFisListe.Columns("fisID").Visible = False
            StokCikisDuzenle.dgFisListe.Columns("stokKodu").HeaderText = "Stok Kodu"
            StokCikisDuzenle.dgFisListe.Columns("stokAdi").HeaderText = "Stok Adı"
            StokCikisDuzenle.dgFisListe.Columns("stokMiktar").HeaderText = "Miktar"
            StokCikisDuzenle.dgFisListe.Columns("stokFiyat").HeaderText = "Fiyat"
            StokCikisDuzenle.dgFisListe.Columns("stokTutar").HeaderText = "Tutar"

            StokCikisDuzenle.txtFisNo.Text = fisSec.fisNo
            StokCikisDuzenle.lblFisId.Text = fisSec.fisID
            StokCikisDuzenle.cmbDepo.SelectedValue = fisSec.fisDepo
            StokCikisDuzenle.cmbBolum.SelectedValue = fisSec.fisBolum
        End If
    End Sub

    Private Sub btnSil_Click(sender As Object, e As EventArgs) Handles btnSil.Click
        Try
            If dgFisListe.Rows.Count > 0 Then
                Dim fID As Integer = Convert.ToInt32(dgFisListe.CurrentRow.Cells("fisID").Value)
                db.Fis_Detay.RemoveRange(db.Fis_Detay.Where(Function(f) f.Fis_ID = fID))
                db.SaveChanges()

                Dim silFis = db.Fis.Where(Function(f) f.Fis_ID = fID).FirstOrDefault()
                db.Fis.Remove(silFis)
                db.SaveChanges()
            End If
        Catch

        End Try
        listele()
    End Sub
End Class