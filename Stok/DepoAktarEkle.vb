Public Class DepoAktarEkle
    Dim db As New StokEntities()
    Private Sub DepoAktarEkle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbDoldur()
        dgFisListe.Columns(4).Visible = False
    End Sub
    Private Sub btnKaydet_Click(sender As Object, e As EventArgs) Handles btnKaydet.Click
        Dim aktarFisEkle As New Aktarim_Fis()
        aktarFisEkle.Aktarim_No = txtFisNo.Text
        aktarFisEkle.Aktarim_Tarih = dtpFisTarihi.Value
        aktarFisEkle.Aktarim_Türü = "Depolar Arası Aktarım"
        aktarFisEkle.Cikis_Depo_ID = cmbCDepo.SelectedValue
        aktarFisEkle.Giris_Depo_ID = cmbGDepo.SelectedValue
        aktarFisEkle.Aktarim_Aciklama = txtAciklama.Text
        db.Aktarim_Fis.Add(aktarFisEkle)
        db.SaveChanges()
        Dim aktarDetayEkle As New Aktarim_Detay()
        If dgFisListe.Rows.Count > 0 Then
            For i = 0 To dgFisListe.RowCount - 1
                aktarDetayEkle.Aktarim_Fis_ID = aktarFisEkle.Aktarim_ID
                aktarDetayEkle.Urun_ID = Convert.ToInt32(dgFisListe.Rows(i).Cells(4).Value)
                aktarDetayEkle.Miktar = Convert.ToInt32(dgFisListe.Rows(i).Cells(2).Value)
                db.Aktarim_Detay.Add(aktarDetayEkle)
                db.SaveChanges()
            Next
        End If
        MsgBox("Depo Aktarım Fişi Oluşturuldu.", MsgBoxStyle.Information, "Bilgi")
        Me.Close()
        Dim liste = (From f In db.Aktarim_Fis Select f.Aktarim_ID, f.Aktarim_No, f.Aktarim_Tarih, f.Aktarim_Türü, f.Cikis_Depo_ID, cikisDepo = f.Depo.Depo_Adi, f.Giris_Depo_ID, girisDepo = f.Depo1.Depo_Adi, f.Aktarim_Aciklama).ToList()
        DepoAktar.dgFisListe.DataSource = liste
        DepoAktar.dgFisListe.Columns("Aktarim_ID").Visible = False
        DepoAktar.dgFisListe.Columns("Aktarim_No").HeaderText = "Fiş No"
        DepoAktar.dgFisListe.Columns("Aktarim_Tarih").HeaderText = "Tarih"
        DepoAktar.dgFisListe.Columns("Aktarim_Türü").HeaderText = "Fiş Türü"
        DepoAktar.dgFisListe.Columns("Cikis_Depo_ID").Visible = False
        DepoAktar.dgFisListe.Columns("cikisDepo").HeaderText = "Çıkış Depo"
        DepoAktar.dgFisListe.Columns("Giris_Depo_ID").Visible = False
        DepoAktar.dgFisListe.Columns("girisDepo").HeaderText = "Giriş Depo"
        DepoAktar.dgFisListe.Columns("Aktarim_Aciklama").Visible = False
    End Sub
    Private Sub btnSil_Click(sender As Object, e As EventArgs) Handles btnSil.Click
        For Each row As DataGridViewRow In dgFisListe.SelectedRows
            dgFisListe.Rows.Remove(row)
        Next
    End Sub
    Private Sub btnIptal_Click(sender As Object, e As EventArgs) Handles btnIptal.Click
        Me.Close()
    End Sub
    Private Sub btnStokKart_Click(sender As Object, e As EventArgs) Handles btnStokKart.Click
        gizleSec = True
        aktar = True
        StokKart.Show()
    End Sub

    Private Sub btnListeEkle_Click(sender As Object, e As EventArgs) Handles btnListeEkle.Click
        dgFisListe.Rows.Add(txtStokKodu.Text, txtStokAdi.Text, nudMiktar.Value, txtBirim.Text, lblid.Text)
        temizle()
    End Sub
    Private Sub temizle()
        txtStokKodu.Text = ""
        txtStokAdi.Text = ""
        nudMiktar.Value = 0
        txtBirim.Text = ""
    End Sub
    Private Sub cmbDoldur()
        cmbCDepo.DisplayMember = "Depo_Adi"
        cmbCDepo.ValueMember = "Depo_ID"
        cmbCDepo.DataSource = db.Depo.ToList()
        cmbCDepo.SelectedIndex = -1
        cmbCDepo.SelectedText = "Seçiniz"

        cmbGDepo.DisplayMember = "Depo_Adi"
        cmbGDepo.ValueMember = "Depo_ID"
        cmbGDepo.DataSource = db.Depo.ToList()
        cmbGDepo.SelectedIndex = -1
        cmbGDepo.SelectedText = "Seçiniz"
    End Sub
End Class