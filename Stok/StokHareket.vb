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
                            fisBolum = f.Bolum.Bolum_Adi,
                            fisUrun = f.Stok_Adi).ToList()
        dgFisListe.DataSource = fisListe
        dgFisListe.Columns("fisID").Visible = False
        dgFisListe.Columns("fisNo").HeaderText = "Fiş No"
        dgFisListe.Columns("fisTur").HeaderText = "Fiş Türü"
        dgFisListe.Columns("fisTarih").HeaderText = "Tarih"
        dgFisListe.Columns("fisDepo").HeaderText = "Depo"
        dgFisListe.Columns("fisBolum").HeaderText = "Bölüm"
        dgFisListe.Columns("fisUrun").HeaderText = "Ürünler"
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
                          fisStokUrunID = f.Stok_Urun_ID,
                          fisStokKodu = f.Stok_Kodu,
                          fisStokAdi = f.Stok_Adi,
                          fisStokMiktar = f.Stok_Miktar,
                          fisBirim = f.Birim,
                          fisBFiyat = f.Birim_Fiyat,
                          fisTutar = f.Tutar,
                          fisAciklama = f.Aciklama).FirstOrDefault()
        StokGirisDuzenle.Show()
        Dim say() = Split(fisSec.fisStokKodu, ";")
        For i = 0 To say.Count - 1 Step 1
            Dim sk() = Split(fisSec.fisStokKodu, ";")
            Dim sa() = Split(fisSec.fisStokAdi, ";")
            Dim sm() = Split(fisSec.fisStokMiktar, ";")
            Dim b() = Split(fisSec.fisBirim, ";")
            Dim bf() = Split(fisSec.fisBFiyat, ";")
            Dim t() = Split(fisSec.fisTutar, ";")
            Dim id() = Split(fisSec.fisStokUrunID, ";")
            StokGirisDuzenle.dgFisListe.Rows.Add(sk(i), sa(i), sm(i), b(i), bf(i), t(i), id(i))
        Next
        StokGirisDuzenle.txtFisNo.Text = fisSec.fisNo
        StokGirisDuzenle.lblFisId.Text = fisSec.fisID
        StokGirisDuzenle.cmbDepo.SelectedValue = fisSec.fisDepo
        StokGirisDuzenle.cmbBolum.SelectedValue = fisSec.fisBolum

    End Sub
End Class