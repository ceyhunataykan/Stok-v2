Public Class StokGiris

    Dim db As StokEntities = New StokEntities()

    Private Sub btnIptal_Click(sender As Object, e As EventArgs) Handles btnIptal.Click
        Close()
    End Sub

    Private Sub btnStokKart_Click(sender As Object, e As EventArgs) Handles btnStokKart.Click
        StokKart.Show()
        gizleSec = True
        giris = True
    End Sub

    Private Sub btnKaydet_Click(sender As Object, e As EventArgs) Handles btnKaydet.Click
        Dim gfEkle As New Fis
        If dgFisListe.Rows.Count > 0 Then
            For i = 0 To dgFisListe.Rows.Count - 1 Step 1
                gfEkle.Fis_No = Convert.ToInt32(txtFisNo.Text)
                gfEkle.Fis_Türü = "Stok Giriş"
                gfEkle.Fis_Tarih = dtpFisTarihi.Value
                gfEkle.Stok_Kodu = Convert.ToInt32(dgFisListe.Rows(i).Cells(0).Value)
                gfEkle.Stok_Adi = dgFisListe.Rows(i).Cells(1).Value
                gfEkle.Stok_Miktar = Convert.ToInt32(dgFisListe.Rows(i).Cells(2).Value)
                gfEkle.Birim = dgFisListe.Rows(i).Cells(3).Value
                gfEkle.Birim_Fiyat = Convert.ToDecimal(dgFisListe.Rows(i).Cells(4).Value)
                gfEkle.Tutar = Convert.ToDecimal(dgFisListe.Rows(i).Cells(5).Value)
                db.Fis.Add(gfEkle)
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
    Private Sub StokGiris_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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