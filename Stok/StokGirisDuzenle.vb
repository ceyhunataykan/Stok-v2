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

    Private Sub btnIptal_Click(sender As Object, e As EventArgs) Handles btnIptal.Click
        Me.Close()
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

    Dim stokAdi As String
    Dim stokKodu As String
    Dim stokMiktar As String
    Dim stokBirim As String
    Dim stokBFiyat As String
    Dim stokTutar As String
    Private Sub btnSil_Click(sender As Object, e As EventArgs) Handles btnSil.Click
        Dim fID As Integer = Convert.ToInt32(lblFisId.Text)
        Dim gfEkle = db.Fis.Where(Function(f) f.Fis_ID = fID).FirstOrDefault()
        If dgFisListe.Rows.Count > 0 Then
            Dim id As Integer = Convert.ToInt32(dgFisListe.CurrentRow.Cells(6).Value)
            Dim bul = db.Urun.Where(Function(u) u.Urun_ID = id).FirstOrDefault()
            Dim sm As Integer = bul.Stok_Miktar
            bul.Stok_Miktar = sm - Convert.ToInt32(dgFisListe.CurrentRow.Cells(2).Value)
            db.SaveChanges()
            For Each row As DataGridViewRow In dgFisListe.SelectedRows
                dgFisListe.Rows.Remove(row)
            Next
            For i = 0 To dgFisListe.Rows.Count - 1 Step 1
                If Not i = dgFisListe.Rows.Count - 1 Then
                    stokKodu += Convert.ToString(dgFisListe.Rows(i).Cells(0).Value & ";")
                    stokAdi += Convert.ToString(dgFisListe.Rows(i).Cells(1).Value & ";")
                    stokMiktar += Convert.ToString(dgFisListe.Rows(i).Cells(2).Value & ";")
                    stokBirim += Convert.ToString(dgFisListe.Rows(i).Cells(3).Value & ";")
                    stokBFiyat += Convert.ToString(dgFisListe.Rows(i).Cells(4).Value & ";")
                    stokTutar += Convert.ToString(dgFisListe.Rows(i).Cells(5).Value & ";")
                Else
                    stokKodu += Convert.ToString(dgFisListe.Rows(i).Cells(0).Value)
                    stokAdi += Convert.ToString(dgFisListe.Rows(i).Cells(1).Value)
                    stokMiktar += Convert.ToString(dgFisListe.Rows(i).Cells(2).Value)
                    stokBirim += Convert.ToString(dgFisListe.Rows(i).Cells(3).Value)
                    stokBFiyat += Convert.ToString(dgFisListe.Rows(i).Cells(4).Value)
                    stokTutar += Convert.ToString(dgFisListe.Rows(i).Cells(5).Value)
                End If
                Dim gID As Integer = Convert.ToInt32(dgFisListe.Rows(i).Cells(6).Value)
                Dim gBul = db.Urun.Where(Function(u) u.Urun_ID = gID).FirstOrDefault()
                Dim gSm As Integer = gBul.Stok_Miktar
                gBul.Stok_Miktar = gSm + Convert.ToInt32(dgFisListe.Rows(i).Cells(2).Value)
                db.SaveChanges()
            Next
        End If
        gfEkle.Fis_No = Convert.ToInt32(txtFisNo.Text)
        gfEkle.Fis_Türü = "Stok Giriş"
        gfEkle.Fis_Tarih = dtpFisTarihi.Value
        gfEkle.Depo_ID = cmbBolum.SelectedValue
        gfEkle.Bolum_ID = cmbBolum.SelectedValue
        gfEkle.Stok_Kodu = stokKodu
        gfEkle.Stok_Adi = stokAdi
        gfEkle.Stok_Miktar = stokMiktar
        gfEkle.Birim = stokBirim
        gfEkle.Birim_Fiyat = stokBFiyat
        gfEkle.Tutar = stokTutar
        gfEkle.Aciklama = txtAciklama.Text
        db.SaveChanges()
        MsgBox("Urun Başarıyla Silindi.", MsgBoxStyle.Information, "Bilgi")
    End Sub

    Private Sub btnKaydet_Click(sender As Object, e As EventArgs) Handles btnKaydet.Click
        Dim fID As Integer = Convert.ToInt32(lblFisId.Text)
        Dim gfEkle = db.Fis.Where(Function(f) f.Fis_ID = fID).FirstOrDefault()
        If dgFisListe.Rows.Count > 0 Then
            For i = 0 To dgFisListe.Rows.Count - 1 Step 1
                If Not i = dgFisListe.Rows.Count - 1 Then
                    stokKodu += Convert.ToString(dgFisListe.Rows(i).Cells(0).Value & ";")
                    stokAdi += Convert.ToString(dgFisListe.Rows(i).Cells(1).Value & ";")
                    stokMiktar += Convert.ToString(dgFisListe.Rows(i).Cells(2).Value & ";")
                    stokBirim += Convert.ToString(dgFisListe.Rows(i).Cells(3).Value & ";")
                    stokBFiyat += Convert.ToString(dgFisListe.Rows(i).Cells(4).Value & ";")
                    stokTutar += Convert.ToString(dgFisListe.Rows(i).Cells(5).Value & ";")
                Else
                    stokKodu += Convert.ToString(dgFisListe.Rows(i).Cells(0).Value)
                    stokAdi += Convert.ToString(dgFisListe.Rows(i).Cells(1).Value)
                    stokMiktar += Convert.ToString(dgFisListe.Rows(i).Cells(2).Value)
                    stokBirim += Convert.ToString(dgFisListe.Rows(i).Cells(3).Value)
                    stokBFiyat += Convert.ToString(dgFisListe.Rows(i).Cells(4).Value)
                    stokTutar += Convert.ToString(dgFisListe.Rows(i).Cells(5).Value)
                End If
                Dim gID As Integer = Convert.ToInt32(dgFisListe.Rows(i).Cells(6).Value)
                Dim gBul = db.Urun.Where(Function(u) u.Urun_ID = gID).FirstOrDefault()
                Dim gSm As Integer = gBul.Stok_Miktar
                gBul.Stok_Miktar = gSm + Convert.ToInt32(dgFisListe.Rows(i).Cells(2).Value)
                db.SaveChanges()
            Next
        End If
        gfEkle.Fis_No = Convert.ToInt32(txtFisNo.Text)
        gfEkle.Fis_Türü = "Stok Giriş"
        gfEkle.Fis_Tarih = dtpFisTarihi.Value
        gfEkle.Depo_ID = cmbBolum.SelectedValue
        gfEkle.Bolum_ID = cmbBolum.SelectedValue
        gfEkle.Stok_Kodu = stokKodu
        gfEkle.Stok_Adi = stokAdi
        gfEkle.Stok_Miktar = stokMiktar
        gfEkle.Birim = stokBirim
        gfEkle.Birim_Fiyat = stokBFiyat
        gfEkle.Tutar = stokTutar
        gfEkle.Aciklama = txtAciklama.Text
        db.SaveChanges()
        MsgBox("Fis Güncelleme Başarılı.", MsgBoxStyle.Information, "Bilgi")
        Me.Close()
    End Sub
End Class