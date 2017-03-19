Public Class CariHesapDuzenle
    Dim db As New StokEntities()

    Private Sub CariHesapDuzenle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim id As Integer = Convert.ToInt32(CariHesap.lblid.Text)
        Dim hesapDuzenle = db.Cari.Where(Function(c) c.Firma_ID = id).FirstOrDefault()
        If hesapDuzenle.Durum = True Then
            ckbAktif.Checked = True
        Else
            ckbAktif.Checked = False
        End If
        txtFirKod.Text = hesapDuzenle.Firma_Kodu
        txtFirAd.Text = hesapDuzenle.Firma_Adi
        txtFirAdres.Text = hesapDuzenle.Firma_Adres
        cmbIlce.SelectedValue = hesapDuzenle.ilce_ID
        cmbIl.SelectedValue = hesapDuzenle.il_ID
        txtVNo.Text = hesapDuzenle.Vergi_No
        txtVD.Text = hesapDuzenle.Vergi_Dairesi
        txtAdSoyad.Text = hesapDuzenle.Firma_Yetkili
        txtTel.Text = hesapDuzenle.Firma_Tel
        txtGsm.Text = hesapDuzenle.Firma_Cep
        txtFax.Text = hesapDuzenle.Firma_Fax
        txtMail.Text = hesapDuzenle.Firma_Mail
    End Sub

    Private Sub btnKaydet_Click(sender As Object, e As EventArgs) Handles btnKaydet.Click
        If txtFirKod.Text = "" Or txtFirAd.Text = "" Then
            MsgBox("Firma Kodu ve Firma Adı Boş Olamaz", MsgBoxStyle.Exclamation, "Uyarı")
            Return
        End If
        Dim id As Integer = Convert.ToInt32(lblid.Text)
        Dim hesapDuzenle = db.Cari.Where(Function(c) c.Firma_ID = id).FirstOrDefault()
        If ckbAktif.Checked = True Then
            hesapDuzenle.Durum = True
        Else
            hesapDuzenle.Durum = False
        End If
        hesapDuzenle.Firma_Kodu = txtFirKod.Text
        hesapDuzenle.Firma_Adi = txtFirAd.Text
        hesapDuzenle.Firma_Adres = txtFirAdres.Text
        hesapDuzenle.ilce_ID = cmbIlce.SelectedValue
        hesapDuzenle.il_ID = cmbIl.SelectedValue
        hesapDuzenle.Vergi_No = Convert.ToInt32(txtVNo.Text)
        hesapDuzenle.Vergi_Dairesi = txtVD.Text
        hesapDuzenle.Firma_Yetkili = txtAdSoyad.Text
        hesapDuzenle.Firma_Tel = txtTel.Text
        hesapDuzenle.Firma_Cep = txtGsm.Text
        hesapDuzenle.Firma_Fax = txtFax.Text
        hesapDuzenle.Firma_Mail = txtMail.Text
        db.SaveChanges()
        MsgBox("Firma Bilgileri Güncellendi", MsgBoxStyle.Information, "Bilgi")
        temizle()
        Me.Close()
        CariHesap.dgListe.DataSource = (From f In db.Cari_Detay Select f.Detay_ID, f.Firma_ID, firmaKodu = f.Cari.Firma_Kodu, firmaAdi = f.Cari.Firma_Adi, f.Bakiye).ToList()
        CariHesap.dgListe.Columns("Detay_ID").Visible = False
        CariHesap.dgListe.Columns("Firma_ID").Visible = False
        CariHesap.dgListe.Columns("firmaKodu").HeaderText = "Firma Kodu"
        CariHesap.dgListe.Columns("firmaAdi").HeaderText = "Firma Adı"
        CariHesap.dgListe.Columns("Bakiye").HeaderText = "Bakiye"
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