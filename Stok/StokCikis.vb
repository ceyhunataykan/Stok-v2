Public Class StokCikis
    Dim db As New StokEntities

    Private Sub btnIptal_Click(sender As Object, e As EventArgs) Handles btnIptal.Click
        Close()
    End Sub

    Private Sub btnStokKart_Click(sender As Object, e As EventArgs) Handles btnStokKart.Click
        StokKart.Show()
        gizleSec = True
        cikis = True
    End Sub
    Private Sub btnKaydet_Click(sender As Object, e As EventArgs) Handles btnKaydet.Click
        Dim cfEkle As New Fis
        If dgFisListe.Rows.Count > 0 Then
            For i = 0 To dgFisListe.Rows.Count - 1 Step 1
                cfEkle.Fis_No = Convert.ToInt32(txtFisNo.Text)
                cfEkle.Fis_Türü = "Stok Çıkış"
                cfEkle.Fis_Tarih = dtpFisTarihi.Value
                cfEkle.Stok_Kodu = Convert.ToInt32(dgFisListe.Rows(i).Cells(0).Value)
                cfEkle.Stok_Adi = dgFisListe.Rows(i).Cells(1).Value
                cfEkle.Stok_Miktar = Convert.ToInt32(dgFisListe.Rows(i).Cells(2).Value)
                cfEkle.Birim = dgFisListe.Rows(i).Cells(3).Value
                cfEkle.Birim_Fiyat = Convert.ToDecimal(dgFisListe.Rows(i).Cells(4).Value)
                cfEkle.Tutar = Convert.ToDecimal(dgFisListe.Rows(i).Cells(5).Value)
                db.Fis.Add(cfEkle)
                db.SaveChanges()

                Me.Close()
            Next
        End If
    End Sub

    Private Sub btnListeEkle_Click(sender As Object, e As EventArgs) Handles btnListeEkle.Click
        dgFisListe.Rows.Add(txtStokKodu.Text, txtStokAdi.Text, nudMiktar.Value, txtBirim.Text, txtBirimFiyat.Text, txtTutar.Text)
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