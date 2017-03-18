Public Class DepoDuzenle
    Dim db As New StokEntities()
    Private Sub btnKaydet_Click(sender As Object, e As EventArgs) Handles btnKaydet.Click
        If txtDepoKod.Text = "" Or txtDepoAd.Text = "" Then
            MsgBox("Depo Kodu ve Depo Adı boş olamaz", MsgBoxStyle.Exclamation, "Uyarı")
            Return
        End If
        Dim id As Integer = Convert.ToInt32(lblid.Text)
        Dim depoGuncelle = db.Depo.Where(Function(d) d.Depo_ID = id).First()
        If ckbAktif.Checked = True Then
            depoGuncelle.Durum = True
        Else
            depoGuncelle.Durum = False
        End If
        depoGuncelle.Depo_Kodu = Convert.ToInt32(txtDepoKod.Text)
        depoGuncelle.Depo_Adi = txtDepoAd.Text
        depoGuncelle.Depo_Adres = txtDepoAdres.Text
        depoGuncelle.ilce_ID = cmbIlce.SelectedValue
        depoGuncelle.il_ID = cmbIl.SelectedValue
        depoGuncelle.Depo_Yetkili = txtAdSoyad.Text
        depoGuncelle.Depo_Tel = txtTel.Text
        depoGuncelle.Depo_Fax = txtFax.Text
        depoGuncelle.Depo_Mail = txtMail.Text
        db.SaveChanges()
        MsgBox("Depo Güncellendi", MsgBoxStyle.Information, "Bilgi")
        temizle()
        Me.Close()
        Depolar.dgDepoListe.DataSource = db.Depo.ToList()
        Depolar.dgDepoListe.Columns("Depo_ID").Visible = False
        Depolar.dgDepoListe.Columns("Depo_Kodu").HeaderText = "Depo Kodu"
        Depolar.dgDepoListe.Columns("Depo_Adi").HeaderText = "Depo Adı"
        Depolar.dgDepoListe.Columns("Depo_Adres").Visible = False
        Depolar.dgDepoListe.Columns("ilce").Visible = False
        Depolar.dgDepoListe.Columns("ilce_ID").Visible = False
        Depolar.dgDepoListe.Columns("il").Visible = False
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

    Private Sub btnIptal_Click(sender As Object, e As EventArgs) Handles btnIptal.Click
        Me.Close()
    End Sub
End Class