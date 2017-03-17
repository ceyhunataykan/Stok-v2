Public Class DepoEkle
    Dim db As New StokEntities()
    Private Sub btnKaydet_Click(sender As Object, e As EventArgs) Handles btnKaydet.Click
        Dim depoEkle As New Depo()
        If ckbAktif.Checked = True Then
            depoEkle.Durum = True
        Else
            depoEkle.Durum = False
        End If
        depoEkle.Depo_Kodu = Convert.ToInt32(txtDepoKod.Text)
        depoEkle.Depo_Adi = txtDepoAd.Text
        depoEkle.Depo_Adres = txtDepoAdres.Text
        depoEkle.ilce_ID = cmbIlce.SelectedValue
        depoEkle.il_ID = cmbIl.SelectedValue
        depoEkle.Depo_Yetkili = txtAdSoyad.Text
        depoEkle.Depo_Tel = txtTel.Text
        depoEkle.Depo_Fax = txtFax.Text
        depoEkle.Depo_Mail = txtMail.Text
        db.Depo.Add(depoEkle)
        db.SaveChanges()
        MsgBox("Yeni Depo Eklendi", MsgBoxStyle.Information, "Bilgi")
        temizle()
        Me.Close()
        Depolar.dgDepoListe.DataSource = db.Depo.ToList()
        Depolar.dgDepoListe.Columns("Depo_ID").Visible = False
        Depolar.dgDepoListe.Columns("Depo_Kodu").HeaderText = "Depo Kodu"
        Depolar.dgDepoListe.Columns("Depo_Adi").HeaderText = "Depo Adı"
        Depolar.dgDepoListe.Columns("Depo_Adres").Visible = False
        Depolar.dgDepoListe.Columns("ilce_ID").Visible = False
        Depolar.dgDepoListe.Columns("il_ID").Visible = False
        Depolar.dgDepoListe.Columns("Depo_Yetkili").HeaderText = "Yetkili"
        Depolar.dgDepoListe.Columns("Depo_Tel").HeaderText = "Telefon"
        Depolar.dgDepoListe.Columns("Depo_Fax").Visible = False
        Depolar.dgDepoListe.Columns("Depo_Mail").Visible = False
        Depolar.dgDepoListe.Columns("Durum").Visible = False
        Depolar.dgDepoListe.Columns("Fis").Visible = False
        Depolar.dgDepoListe.Columns("Urun").Visible = False
    End Sub
    Private Sub temizle()
        ckbAktif.Checked = False
        txtDepoKod.Text = ""
        txtDepoAd.Text = ""
        txtDepoAdres.Text = ""
        cmbIlce.SelectedValue = -1
        cmbIl.SelectedValue = -1
        txtAdSoyad.Text = ""
        txtTel.Text = ""
        txtFax.Text = ""
        txtMail.Text = ""
    End Sub
End Class