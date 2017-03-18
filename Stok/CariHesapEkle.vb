Public Class CariHesapEkle
    Dim db As New StokEntities()
    Private Sub btnKaydet_Click(sender As Object, e As EventArgs) Handles btnKaydet.Click
        Dim hesapEkle As New Cari()
        If ckbAktif.Checked = True Then
            hesapEkle.Durum = True
        Else
            hesapEkle.Durum = False
        End If
        hesapEkle.Firma_Kodu = txtFirKod.Text
        hesapEkle.Firma_Adi = txtFirAd.Text
        hesapEkle.Firma_Adres = txtFirAdres.Text
        hesapEkle.ilce_ID = cmbIlce.SelectedValue
        hesapEkle.il_ID = cmbIl.SelectedValue
        hesapEkle.Vergi_No = txtVNo.Text
        hesapEkle.Vergi_Dairesi = txtVD.Text
        hesapEkle.Firma_Yetkili = txtAdSoyad.Text
        hesapEkle.Firma_Tel = txtTel.Text
        hesapEkle.Firma_Cep = txtGsm.Text
        hesapEkle.Firma_Fax = txtFax.Text
        hesapEkle.Firma_Mail = txtMail.Text
        db.Cari.Add(hesapEkle)
        db.SaveChanges()

        Dim detay As New Cari_Detay()
        detay.Firma_ID = hesapEkle.Firma_ID
        detay.Borc = 0
        detay.Alacak = 0
        detay.Bakiye = 0
        db.Cari_Detay.Add(detay)
        db.SaveChanges()
        temizle()
        MsgBox("Kayıt Başarılı", MsgBoxStyle.Information, "Bilgi")
        Me.Close()
    End Sub

    Private Sub btnIptal_Click(sender As Object, e As EventArgs) Handles btnIptal.Click
        Me.Close()
    End Sub
    Private Sub temizle()
        txtAdSoyad.Text = ""
        txtFax.Text = ""
        txtFirAd.Text = ""
        txtFirAdres.Text = ""
        txtFirKod.Text = ""
        txtGsm.Text = ""
        txtMail.Text = ""
        txtTel.Text = ""
        txtVD.Text = ""
        txtVNo.Text = ""
        cmbIl.SelectedValue = -1
        cmbIlce.SelectedValue = -1
        ckbAktif.Checked = False
        txtFirKod.Focus()
    End Sub
End Class