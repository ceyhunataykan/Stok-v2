Public Class StokGiris
    Dim db As StokEntities = New StokEntities()
    Private Sub btnIptal_Click(sender As Object, e As EventArgs) Handles btnIptal.Click
        Close()
    End Sub
    Private Sub btnStokKart_Click(sender As Object, e As EventArgs) Handles btnStokKart.Click
        gizleSec = True
        giris = True
        StokKart.Show()
    End Sub
    Private Sub btnKaydet_Click(sender As Object, e As EventArgs) Handles btnKaydet.Click
        Dim gfEkle As New Fis
        gfEkle.Fis_Türü = "Stok Giriş"
        gfEkle.Fis_Tarih = dtpFisTarihi.Value
        gfEkle.Fis_No = Convert.ToInt32(txtFisNo.Text)
        gfEkle.Depo_ID = cmbDepo.SelectedValue
        gfEkle.Bolum_ID = cmbBolum.SelectedValue
        db.Fis.Add(gfEkle)
        db.SaveChanges()
        Dim fdEkle As New Fis_Detay
        If dgFisListe.Rows.Count > 0 Then
            For i = 0 To dgFisListe.RowCount - 1
                fdEkle.Fis_ID = gfEkle.Fis_ID
                fdEkle.Urun_ID = Convert.ToInt32(dgFisListe.Rows(i).Cells(6).Value)
                fdEkle.Miktar = Convert.ToInt32(dgFisListe.Rows(i).Cells(2).Value)
                fdEkle.Fiyat = Convert.ToDecimal(dgFisListe.Rows(i).Cells(4).Value)
                fdEkle.Tutar = fdEkle.Miktar * fdEkle.Fiyat
                db.Fis_Detay.Add(fdEkle)
                db.SaveChanges()
                Dim id As Integer = Convert.ToInt32(dgFisListe.Rows(i).Cells(6).Value)
                Dim bul = db.Urun.Where(Function(u) u.Urun_ID = id).FirstOrDefault()
                Dim sm As Integer = bul.Stok_Miktar
                bul.Stok_Miktar = sm + Convert.ToInt32(dgFisListe.Rows(i).Cells(2).Value)
                db.SaveChanges()
            Next
        End If
        MsgBox("Stok Giriş Fişi Oluşturuldu.", MsgBoxStyle.Information, "Bilgi")
        Me.Close()
        Dim fisListe = (From f In db.Fis
                        Select
                            fisID = f.Fis_ID,
                            fisNo = f.Fis_No,
                            fisTur = f.Fis_Türü,
                            fisTarih = f.Fis_Tarih,
                            fisDepo = f.Depo.Depo_Adi,
                            fisBolum = f.Bolum.Bolum_Adi).ToList()
        StokHareket.dgFisListe.DataSource = fisListe
        StokHareket.dgFisListe.Columns("fisID").Visible = False
        StokHareket.dgFisListe.Columns("fisNo").HeaderText = "Fiş No"
        StokHareket.dgFisListe.Columns("fisTur").HeaderText = "Fiş Türü"
        StokHareket.dgFisListe.Columns("fisTarih").HeaderText = "Tarih"
        StokHareket.dgFisListe.Columns("fisDepo").HeaderText = "Depo"
        StokHareket.dgFisListe.Columns("fisBolum").HeaderText = "Bölüm"
    End Sub

    Private Sub btnListeEkle_Click(sender As Object, e As EventArgs) Handles btnListeEkle.Click
        dgFisListe.Rows.Add(txtStokKodu.Text, txtStokAdi.Text, nudMiktar.Value, txtBirim.Text, txtBirimFiyat.Text, txtTutar.Text, lblid.Text)
        temizle()
        If dgFisListe.Rows.Count > 0 Then
            Dim miktar As Integer = 0
            Dim toplam As Decimal = 0
            For i = 0 To dgFisListe.Rows.Count - 1 Step 1
                miktar += Convert.ToInt32(dgFisListe.Rows(i).Cells(2).Value)
                toplam += Convert.ToDecimal(dgFisListe.Rows(i).Cells(5).Value)
            Next
            txtTopBirim.Text = miktar.ToString()
            txtTopTutar.Text = toplam.ToString()
        End If
    End Sub
    Private Sub temizle()
        txtStokKodu.Text = ""
        txtStokAdi.Text = ""
        nudMiktar.Value = 0
        txtBirim.Text = ""
        txtBirimFiyat.Text = ""
        txtTutar.Text = ""
    End Sub
    Private Sub StokGiris_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim depoListe As IList(Of Depo) = db.Depo.ToList()
        cmbDepo.DataSource = depoListe
        cmbDepo.DisplayMember = "Depo_Adi"
        cmbDepo.ValueMember = "Depo_ID"
        Dim bolumListe As IList(Of Bolum) = db.Bolum.ToList()
        cmbBolum.DataSource = bolumListe
        cmbBolum.DisplayMember = "Bolum_Adi"
        cmbBolum.ValueMember = "Bolum_ID"
        dgFisListe.Columns(6).Visible = False
    End Sub
    Private Sub nudMiktar_ValueChanged(sender As Object, e As EventArgs) Handles nudMiktar.ValueChanged
        txtTutar.Text = (Convert.ToDecimal(txtBirimFiyat.Text) * nudMiktar.Value).ToString()
    End Sub
    Private Sub btnSil_Click(sender As Object, e As EventArgs) Handles btnSil.Click
        For Each row As DataGridViewRow In dgFisListe.SelectedRows
            dgFisListe.Rows.Remove(row)
        Next
    End Sub
    Private Sub StokGiris_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        dgFisListe.Rows.Clear()
        Me.Dispose()
    End Sub
End Class