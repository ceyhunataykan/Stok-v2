Imports System.Data.Entity.Core.Objects
Imports System.Data.Entity.SqlServer

Public Class DepoAktar
    Dim db As New StokEntities()
    Private Sub DepoAktar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbDoldur()
        listele()
    End Sub
    Private Sub cmbCDepo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCDepo.SelectedIndexChanged
        Dim id As Integer = Convert.ToInt32(cmbCDepo.SelectedValue)
        Dim liste = (From f In db.Aktarim_Fis
                     Where f.Cikis_Depo_ID = id
                     Select f.Aktarim_ID, f.Aktarim_No, f.Aktarim_Tarih, f.Aktarim_Türü, f.Cikis_Depo_ID, cikisDepo = f.Depo.Depo_Adi, f.Giris_Depo_ID, girisDepo = f.Depo1.Depo_Adi, f.Aktarim_Aciklama).ToList()
        dgFisListe.DataSource = liste
        dgDuzenle()
    End Sub

    Private Sub cmbGDepo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbGDepo.SelectedIndexChanged
        Dim id As Integer = Convert.ToInt32(cmbGDepo.SelectedValue)
        Dim liste = (From f In db.Aktarim_Fis
                     Where f.Giris_Depo_ID = id
                     Select f.Aktarim_ID, f.Aktarim_No, f.Aktarim_Tarih, f.Aktarim_Türü, f.Cikis_Depo_ID, cikisDepo = f.Depo.Depo_Adi, f.Giris_Depo_ID, girisDepo = f.Depo1.Depo_Adi, f.Aktarim_Aciklama).ToList()
        dgFisListe.DataSource = liste
        dgDuzenle()
    End Sub

    Private Sub txtAra_TextChanged(sender As Object, e As EventArgs) Handles txtAra.TextChanged
        Try
            Dim kod As Integer = Convert.ToInt32(txtAra.Text)
            Dim liste = (From f In db.Aktarim_Fis
                         Where SqlFunctions.StringConvert(f.Aktarim_No).Contains(kod.ToString())
                         Select f.Aktarim_ID, f.Aktarim_No, f.Aktarim_Tarih, f.Aktarim_Türü, f.Cikis_Depo_ID, cikisDepo = f.Depo.Depo_Adi, f.Giris_Depo_ID, girisDepo = f.Depo1.Depo_Adi, f.Aktarim_Aciklama).ToList()
            dgFisListe.DataSource = liste
            dgDuzenle()
        Catch ex As Exception
            listele()
        End Try
    End Sub

    Private Sub txtAra_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAra.KeyPress
        If Not (Char.IsNumber(e.KeyChar) = True) And e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True
        End If
    End Sub
    Private Sub dtpTarih_ValueChanged(sender As Object, e As EventArgs) Handles dtpTarih.ValueChanged
        Dim dt As DateTime = Convert.ToDateTime(dtpTarih.Value)
        Dim liste = (From f In db.Aktarim_Fis
                     Where EntityFunctions.TruncateTime(f.Aktarim_Tarih) = dt.Date
                     Select f.Aktarim_ID, f.Aktarim_No, f.Aktarim_Tarih, f.Aktarim_Türü, f.Cikis_Depo_ID, cikisDepo = f.Depo.Depo_Adi, f.Giris_Depo_ID, girisDepo = f.Depo1.Depo_Adi, f.Aktarim_Aciklama).ToList()
        dgFisListe.DataSource = liste
        dgDuzenle()
    End Sub

    Private Sub btnTum_Click(sender As Object, e As EventArgs) Handles btnTum.Click
        listele()
    End Sub

    Private Sub btnEkle_Click(sender As Object, e As EventArgs) Handles btnEkle.Click
        DepoAktarEkle.ShowDialog()
    End Sub

    Private Sub btnDuzenle_Click(sender As Object, e As EventArgs) Handles btnDuzenle.Click
        Dim id As Integer = Convert.ToInt32(dgFisListe.CurrentRow.Cells("Aktarim_ID").Value)
        Dim tarih As DateTime = Convert.ToDateTime(dgFisListe.CurrentRow.Cells("Aktarim_Tarih").Value)
        DepoAktarDuzenle.Show()
        DepoAktarDuzenle.lblFisId.Text = dgFisListe.CurrentRow.Cells("Aktarim_ID").Value
        DepoAktarDuzenle.dtpFisTarihi.Value = tarih.ToShortDateString
        DepoAktarDuzenle.txtFisNo.Text = dgFisListe.CurrentRow.Cells("Aktarim_No").Value
        DepoAktarDuzenle.cmbCDepo.SelectedValue = dgFisListe.CurrentRow.Cells("Cikis_Depo_ID").Value
        DepoAktarDuzenle.cmbGDepo.SelectedValue = dgFisListe.CurrentRow.Cells("Giris_Depo_ID").Value
        DepoAktarDuzenle.txtAciklama.Text = dgFisListe.CurrentRow.Cells("Aktarim_Aciklama").Value
        Dim fisDetay = (From f In db.Aktarim_Detay
                        Where f.Aktarim_Fis_ID = id
                        Select f.Detay_ID, f.Aktarim_Fis_ID, f.Urun_ID, stokKodu = f.Urun.Stok_Kodu, stokAdi = f.Urun.Stok_Adi, f.Miktar, f.Birim_ID, stokBirim = f.Birim.Birim_Adi).ToList()
        DepoAktarDuzenle.dgFisListe.DataSource = fisDetay
        DepoAktarDuzenle.dgFisListe.Columns("Detay_ID").Visible = False
        DepoAktarDuzenle.dgFisListe.Columns("Aktarim_Fis_ID").Visible = False
        DepoAktarDuzenle.dgFisListe.Columns("Urun_ID").Visible = False
        DepoAktarDuzenle.dgFisListe.Columns("stokKodu").HeaderText = "Stok Kodu"
        DepoAktarDuzenle.dgFisListe.Columns("stokAdi").HeaderText = "Stok Adı"
        DepoAktarDuzenle.dgFisListe.Columns("Miktar").HeaderText = "Miktar"
        DepoAktarDuzenle.dgFisListe.Columns("Birim_ID").Visible = False
        DepoAktarDuzenle.dgFisListe.Columns("stokBirim").HeaderText = "Birim"
    End Sub

    Private Sub btnSil_Click(sender As Object, e As EventArgs) Handles btnSil.Click
        If lblId.Text = "" Then
            MsgBox("Silme işlemi yapabilmek için kayıt seçiniz", MsgBoxStyle.Exclamation, "Uyarı")
            Return
        End If
        If MsgBox("Kaydı silmek istiyor musunuz?", MsgBoxStyle.YesNo, "Uyarı") = MsgBoxResult.No Then
            Return
        End If
        Dim id As Integer = Convert.ToInt32(dgFisListe.CurrentRow.Cells("Aktarim_ID").Value)
        Try
            If dgFisListe.Rows.Count > 0 Then
                db.Aktarim_Detay.RemoveRange(db.Aktarim_Detay.Where(Function(a) a.Aktarim_Fis_ID = id))
                db.SaveChanges()

                Dim fisSil = db.Aktarim_Fis.Where(Function(a) a.Aktarim_ID = id).First()
                db.Aktarim_Fis.Remove(fisSil)
                db.SaveChanges()
            End If
        Catch

        End Try
        listele()
    End Sub
    Private Sub listele()
        Dim liste = (From f In db.Aktarim_Fis Select f.Aktarim_ID, f.Aktarim_No, f.Aktarim_Tarih, f.Aktarim_Türü, f.Cikis_Depo_ID, cikisDepo = f.Depo.Depo_Adi, f.Giris_Depo_ID, girisDepo = f.Depo1.Depo_Adi, f.Aktarim_Aciklama).ToList()
        dgFisListe.DataSource = liste
        dgDuzenle()
    End Sub
    Private Sub dgDuzenle()
        dgFisListe.Columns("Aktarim_ID").Visible = False
        dgFisListe.Columns("Aktarim_No").HeaderText = "Fiş No"
        dgFisListe.Columns("Aktarim_Tarih").HeaderText = "Tarih"
        dgFisListe.Columns("Aktarim_Türü").HeaderText = "Fiş Türü"
        dgFisListe.Columns("Cikis_Depo_ID").Visible = False
        dgFisListe.Columns("cikisDepo").HeaderText = "Çıkış Depo"
        dgFisListe.Columns("Giris_Depo_ID").Visible = False
        dgFisListe.Columns("girisDepo").HeaderText = "Giriş Depo"
        dgFisListe.Columns("Aktarim_Aciklama").Visible = False
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

    Private Sub dgFisListe_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgFisListe.CellClick
        lblId.Text = dgFisListe.CurrentRow.Cells("Aktarim_ID").Value
    End Sub

    Private Sub DepoAktar_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose()
    End Sub
End Class