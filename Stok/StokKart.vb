Imports System.Data.Entity.SqlServer
Imports System.Data.Linq.SqlClient
Imports System.Drawing.Imaging
Public Class StokKart
    Dim db As StokEntities = New StokEntities()
    Private Sub StokKart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listele()
    End Sub
    Private Sub btnEkle_Click(sender As Object, e As EventArgs) Handles btnEkle.Click
        StokKartEkle.ShowDialog()
    End Sub
    Private Sub listele()
        dgListe.DataSource = (From u In db.Urun
                              Select u.Urun_ID, u.Stok_Kodu, u.Stok_Adi, u.Stok_Barkod, u.Kategori_ID, u.Stok_Miktar, u.Birim_ID, Stok_Birim = u.Birim.Birim_Adi,
                                     u.Stok_TSeviye, u.Depo_ID, u.Stok_AFiyati, u.Stok_SFiyati, u.Stok_Kdv, u.Stok_KayitTarihi, u.Stok_Foto, u.Durum).ToList()
        dgDuzenle()
        renklendir()
    End Sub
    Private Sub cmbDurum_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDurum.SelectedIndexChanged
        If cmbDurum.SelectedItem = "Tümü" Then
            listele()
            renklendir()
        ElseIf cmbDurum.SelectedItem = "Aktif" Then
            dgListe.DataSource = (From u In db.Urun
                                  Where u.Durum = True
                                  Select u.Urun_ID, u.Stok_Kodu, u.Stok_Adi, u.Stok_Barkod, u.Kategori_ID, u.Stok_Miktar, u.Birim_ID, Stok_Birim = u.Birim.Birim_Adi,
                                     u.Stok_TSeviye, u.Depo_ID, u.Stok_AFiyati, u.Stok_SFiyati, u.Stok_Kdv, u.Stok_KayitTarihi, u.Stok_Foto, u.Durum).ToList()
            dgDuzenle()
            renklendir()
        ElseIf cmbDurum.SelectedItem = "Pasif" Then
            dgListe.DataSource = (From u In db.Urun
                                  Where u.Durum = False
                                  Select u.Urun_ID, u.Stok_Kodu, u.Stok_Adi, u.Stok_Barkod, u.Kategori_ID, u.Stok_Miktar, u.Birim_ID, Stok_Birim = u.Birim.Birim_Adi,
                                     u.Stok_TSeviye, u.Depo_ID, u.Stok_AFiyati, u.Stok_SFiyati, u.Stok_Kdv, u.Stok_KayitTarihi, u.Stok_Foto, u.Durum).ToList()
            dgDuzenle()
            renklendir()
        End If
    End Sub
    Private Sub txtAra_TextChanged(sender As Object, e As EventArgs) Handles txtAra.TextChanged
        Try
            Dim kod As Integer = Convert.ToInt32(txtAra.Text)
            dgListe.DataSource = (From u In db.Urun
                                  Where SqlFunctions.StringConvert(u.Stok_Kodu).Contains(kod.ToString())
                                  Select u.Urun_ID, u.Stok_Kodu, u.Stok_Adi, u.Stok_Barkod, u.Kategori_ID, u.Stok_Miktar, u.Birim_ID, Stok_Birim = u.Birim.Birim_Adi,
                                     u.Stok_TSeviye, u.Depo_ID, u.Stok_AFiyati, u.Stok_SFiyati, u.Stok_Kdv, u.Stok_KayitTarihi, u.Stok_Foto, u.Durum).ToList()
            dgDuzenle()
            renklendir()
        Catch
            listele()
        End Try
    End Sub
    Private Sub txtAra_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAra.KeyPress
        If Not (Char.IsNumber(e.KeyChar) = True) And e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True
        End If
    End Sub
    Private Sub StokKart_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose()
    End Sub
    Private Sub btnSec_Click(sender As Object, e As EventArgs) Handles btnSec.Click
        Dim uID As Integer = Convert.ToInt32(dgListe.CurrentRow.Cells("Urun_ID").Value)
        Dim urunSec = (From u In db.Urun
                       Where u.Urun_ID = uID
                       Select
                                 stokID = u.Urun_ID,
                                 stokKodu = u.Stok_Kodu,
                                 stokAdi = u.Stok_Adi,
                                 stokMiktar = u.Stok_Miktar,
                                 stokBirim_ID = u.Birim.Birim_ID,
                                 stokBirimAdi = u.Birim.Birim_Adi,
                                 stokBfiyat = u.Stok_SFiyati,
                                 stokTseviye = u.Stok_TSeviye).FirstOrDefault()
        If giris = True Then
            Me.Hide()
            StokGiris.Show()
            StokGiris.lblid.Text = urunSec.stokID
            StokGiris.txtStokKodu.Text = urunSec.stokKodu
            StokGiris.txtStokAdi.Text = urunSec.stokAdi
            StokGiris.txtBirim.Text = urunSec.stokBirimAdi
            StokGiris.txtBirimFiyat.Text = urunSec.stokBfiyat
            giris = False
        ElseIf girisDuzenle = True Then
            Me.Hide()
            StokGirisDuzenle.Show()
            StokGirisDuzenle.lblid.Text = urunSec.stokID
            StokGirisDuzenle.txtStokKodu.Text = urunSec.stokKodu
            StokGirisDuzenle.txtStokAdi.Text = urunSec.stokAdi
            StokGirisDuzenle.txtBirim.Text = urunSec.stokBirimAdi
            StokGirisDuzenle.txtBirimFiyat.Text = urunSec.stokBfiyat
            girisDuzenle = False
        ElseIf cikis = True Then
            Me.Hide()
            StokCikis.Show()
            StokCikis.lblid.Text = urunSec.stokID
            StokCikis.txtStokKodu.Text = urunSec.stokKodu
            StokCikis.txtStokAdi.Text = urunSec.stokAdi
            StokCikis.txtBirim.Text = urunSec.stokBirimAdi
            StokCikis.txtBirimFiyat.Text = urunSec.stokBfiyat
            cikis = False
        ElseIf cikisDuzenle = True Then
            Me.Hide()
            StokCikisDuzenle.Show()
            StokCikisDuzenle.lblid.Text = urunSec.stokID
            StokCikisDuzenle.txtStokKodu.Text = urunSec.stokKodu
            StokCikisDuzenle.txtStokAdi.Text = urunSec.stokAdi
            StokCikisDuzenle.txtBirim.Text = urunSec.stokBirimAdi
            StokCikisDuzenle.txtBirimFiyat.Text = urunSec.stokBfiyat
            cikisDuzenle = False
        ElseIf aktar = True Then
            Me.Hide()
            DepoAktarEkle.Show()
            DepoAktarEkle.lblid.Text = urunSec.stokID
            DepoAktarEkle.txtStokKodu.Text = urunSec.stokKodu
            DepoAktarEkle.txtStokAdi.Text = urunSec.stokAdi
            DepoAktarEkle.txtBirim.Text = urunSec.stokBirimAdi
            aktar = False
        ElseIf aktarDuzenle = True Then
            Me.Hide()
            DepoAktarDuzenle.Show()
            DepoAktarDuzenle.lblid.Text = urunSec.stokID
            DepoAktarDuzenle.txtStokKodu.Text = urunSec.stokKodu
            DepoAktarDuzenle.txtStokAdi.Text = urunSec.stokAdi
            DepoAktarDuzenle.txtBirim.Text = urunSec.stokBirimAdi
            aktarDuzenle = False
        End If
    End Sub
    Private Sub btnSil_Click(sender As Object, e As EventArgs) Handles btnSil.Click
        If lblId.Text = "" Then
            MsgBox("Silme işlemi yapabilmek için kayıt seçiniz", MsgBoxStyle.Exclamation, "Uyarı")
            Return
        End If
        If MsgBox("Ürünü Silmek İstiyor musunuz?", MsgBoxStyle.YesNo, "Uyarı") = MsgBoxResult.No Then
            Return
        End If
        Try
            If dgListe.Rows.Count > 0 Then
                Dim uID As Integer = Convert.ToInt32(dgListe.CurrentRow.Cells("Urun_ID").Value)
                Dim sil = db.Urun.Where(Function(u) u.Urun_ID = uID).FirstOrDefault()
                db.Urun.Remove(sil)
                db.SaveChanges()
            End If
        Catch
            MsgBox("Ürünle ilişkili Fiş Mevcut. Ürünü kaldırmak için önce stok hareketlerinizi düzenleyiniz.", MsgBoxStyle.Exclamation, "Uyarı")
        End Try
        listele()
    End Sub
    Private Sub btnYenile_Click(sender As Object, e As EventArgs) Handles btnYenile.Click
        listele()
    End Sub

    Private Sub dgListe_CellClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles dgListe.CellClick
        If gizleSec = True Then
            btnSec.Enabled = True
        Else
            btnSec.Enabled = False
        End If
        lblId.Text = dgListe.CurrentRow.Cells("Urun_ID").Value
    End Sub

    Private Sub btnDuzenle_Click(sender As Object, e As EventArgs) Handles btnDuzenle.Click
        If lblId.Text = "" Then
            MsgBox("Düzenleme işlemi yapabilmek için kayıt seçiniz", MsgBoxStyle.Exclamation, "Uyarı")
            Return
        End If
        StokKartDuzenle.Show()
        If dgListe.CurrentRow.Cells("Durum").Value = True Then
            StokKartDuzenle.ckbAktif.Checked = True
        Else
            StokKartDuzenle.ckbAktif.Checked = False
        End If
        StokKartDuzenle.lblUrunID.Text = dgListe.CurrentRow.Cells("Urun_ID").Value
        StokKartDuzenle.DateTimePicker1.Value = dgListe.CurrentRow.Cells("Stok_KayitTarihi").Value
        StokKartDuzenle.txtSk.Text = dgListe.CurrentRow.Cells("Stok_Kodu").Value
        StokKartDuzenle.txtBarkod.Text = dgListe.CurrentRow.Cells("Stok_Barkod").Value
        StokKartDuzenle.txtStokAdi.Text = dgListe.CurrentRow.Cells("Stok_Adi").Value
        StokKartDuzenle.cmbKategori.SelectedValue = dgListe.CurrentRow.Cells("Kategori_ID").Value
        StokKartDuzenle.nudMiktar.Value = dgListe.CurrentRow.Cells("Stok_Miktar").Value
        StokKartDuzenle.nudTSeviye.Value = dgListe.CurrentRow.Cells("Stok_TSeviye").Value
        StokKartDuzenle.cmbBirim.SelectedValue = dgListe.CurrentRow.Cells("Birim_ID").Value
        StokKartDuzenle.cmbDepo.SelectedValue = dgListe.CurrentRow.Cells("Depo_ID").Value
        StokKartDuzenle.txtAlisFiyati.Text = dgListe.CurrentRow.Cells("Stok_AFiyati").Value
        StokKartDuzenle.txtSatisFiyati.Text = dgListe.CurrentRow.Cells("Stok_SFiyati").Value
        StokKartDuzenle.txtKdv.Text = dgListe.CurrentRow.Cells("Stok_Kdv").Value
        StokKartDuzenle.PictureBox1.Image = Nothing

    End Sub
    Private Sub dgDuzenle()
        dgListe.Columns("Urun_ID").Visible = False
        dgListe.Columns("Stok_Kodu").HeaderText = "Stok Kodu"
        dgListe.Columns("Stok_Adi").HeaderText = "Stok Adı"
        dgListe.Columns("Stok_Barkod").Visible = False
        dgListe.Columns("Kategori_ID").Visible = False
        dgListe.Columns("Stok_Miktar").HeaderText = "Miktar"
        dgListe.Columns("Birim_ID").Visible = False
        dgListe.Columns("Stok_Birim").HeaderText = "Birim"
        dgListe.Columns("Stok_TSeviye").Visible = False
        dgListe.Columns("Depo_ID").Visible = False
        dgListe.Columns("Stok_AFiyati").HeaderText = "Alış Fiyatı"
        dgListe.Columns("Stok_SFiyati").HeaderText = "Satış Fiyatı"
        dgListe.Columns("Stok_Kdv").Visible = False
        dgListe.Columns("Stok_KayitTarihi").Visible = False
        dgListe.Columns("Stok_Foto").Visible = False
        dgListe.Columns("Durum").Visible = False
    End Sub
    Private Sub renklendir()
        For i = 0 To dgListe.Rows.Count - 1
            Application.DoEvents()
            Dim renk As DataGridViewCellStyle = New DataGridViewCellStyle()
            If dgListe.Rows(i).Cells("Stok_Miktar").Value > dgListe.Rows(i).Cells("Stok_TSeviye").Value Then
                renk.BackColor = Color.YellowGreen
                renk.ForeColor = Color.White
            ElseIf dgListe.Rows(i).Cells("Stok_Miktar").Value < dgListe.Rows(i).Cells("Stok_TSeviye").Value Then
                renk.BackColor = Color.Orange
                renk.ForeColor = Color.White
            ElseIf dgListe.Rows(i).Cells("Stok_Miktar").Value = 0 Then
                renk.BackColor = Color.DarkRed
                renk.ForeColor = Color.White
            End If
            dgListe.Rows(i).DefaultCellStyle = renk
        Next
    End Sub
End Class
