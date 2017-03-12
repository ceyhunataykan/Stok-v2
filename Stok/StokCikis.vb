Public Class StokCikis
    Dim db As New StokEntities

    Private Sub btnIptal_Click(sender As Object, e As EventArgs) Handles btnIptal.Click
        Close()
    End Sub

    Private Sub btnStokKart_Click(sender As Object, e As EventArgs) Handles btnStokKart.Click
        gizleSec = True
        cikis = True
        StokKart.Show()
    End Sub

    Dim stokAdi As String
    Dim stokKodu As String
    Dim stokMiktar As String
    Dim stokBirim As String
    Dim stokBFiyat As String
    Dim stokTutar As String
    Dim stokUrunID As String
    Private Sub btnKaydet_Click(sender As Object, e As EventArgs) Handles btnKaydet.Click
        Dim cfEkle As New Fis
        If dgFisListe.Rows.Count > 0 Then
            For i = 0 To dgFisListe.Rows.Count - 1 Step 1
                If Not i = dgFisListe.Rows.Count - 1 Then
                    stokKodu += Convert.ToString(dgFisListe.Rows(i).Cells(0).Value & ";")
                    stokAdi += Convert.ToString(dgFisListe.Rows(i).Cells(1).Value & ";")
                    stokMiktar += Convert.ToString(dgFisListe.Rows(i).Cells(2).Value & ";")
                    stokBirim += Convert.ToString(dgFisListe.Rows(i).Cells(3).Value & ";")
                    stokBFiyat += Convert.ToString(dgFisListe.Rows(i).Cells(4).Value & ";")
                    stokTutar += Convert.ToString(dgFisListe.Rows(i).Cells(5).Value & ";")
                    stokUrunID += Convert.ToString(dgFisListe.Rows(i).Cells(6).Value & ";")
                Else
                    stokKodu += Convert.ToString(dgFisListe.Rows(i).Cells(0).Value)
                    stokAdi += Convert.ToString(dgFisListe.Rows(i).Cells(1).Value)
                    stokMiktar += Convert.ToString(dgFisListe.Rows(i).Cells(2).Value)
                    stokBirim += Convert.ToString(dgFisListe.Rows(i).Cells(3).Value)
                    stokBFiyat += Convert.ToString(dgFisListe.Rows(i).Cells(4).Value)
                    stokTutar += Convert.ToString(dgFisListe.Rows(i).Cells(5).Value)
                    stokUrunID += Convert.ToString(dgFisListe.Rows(i).Cells(6).Value)
                End If
                Dim id As Integer = Convert.ToInt32(dgFisListe.Rows(i).Cells(6).Value)
                Dim bul = db.Urun.Where(Function(u) u.Urun_ID = id).FirstOrDefault()
                Dim sm As Integer = bul.Stok_Miktar
                bul.Stok_Miktar = sm - Convert.ToInt32(dgFisListe.Rows(i).Cells(2).Value)
                db.SaveChanges()
            Next
        End If
        cfEkle.Fis_No = Convert.ToInt32(txtFisNo.Text)
        cfEkle.Fis_Türü = "Stok Çıkış"
        cfEkle.Fis_Tarih = dtpFisTarihi.Value
        cfEkle.Depo_ID = cmbDepo.SelectedValue
        cfEkle.Bolum_ID = cmbBolum.SelectedValue
        cfEkle.Stok_Urun_ID = stokUrunID
        cfEkle.Stok_Kodu = stokKodu
        cfEkle.Stok_Adi = stokAdi
        cfEkle.Stok_Miktar = stokMiktar
        cfEkle.Birim = stokBirim
        cfEkle.Birim_Fiyat = stokBFiyat
        cfEkle.Tutar = stokTutar
        cfEkle.Aciklama = txtAciklama.Text
        db.Fis.Add(cfEkle)
        db.SaveChanges()
        MsgBox("Stok Çıkış Fişi Oluşturuldu.", MsgBoxStyle.Information, "Bilgi")
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

    Private Sub StokCikis_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
End Class